Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO

Public Class IngresarDepositoLegal
    Public MontoDeposito As Double
    Public idCredito As Integer
    Dim dataUsuarios As DataTable
    Dim adapterUsuarios As SqlDataAdapter

    Dim nCargando As Cargando
    Private Sub IngresarDepositoLegal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nCargando = New Cargando
        nCargando.Show()
        nCargando.MonoFlat_Label1.Text = "Consultando Usuarios"
        BackgroundUsuarios.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        iniciarconexionempresa()

        Dim comandoInsertaDeposito As SqlCommand
        Dim consultaInsertaDeposito As String
        Dim idDepositoLegal As String
        consultaInsertaDeposito = "insert into depositoslegal values('" & idCredito & "','" & txtMonto.Text & "','" & dateFechaDeposito.Value.ToString("yyyy-MM-dd") & "',@imagen,'" & txtComentario.Text & "','" & Date.Now.ToString("yyyy-MM-dd") & "','" & nmusr & "','','','','E') select SCOPE_IDENTITY()"
        Dim imagen As Bitmap = TryCast(BunifuImageButton1.Image, Bitmap)
        Dim NuevaImagen As Bitmap = ImagenComprimida(imagen)
        Dim imgDocumento As New SqlParameter("@imagen", SqlDbType.Image)
        Dim msImgDocumento As New MemoryStream
        NuevaImagen.Save(msImgDocumento, ImageFormat.Jpeg)
        imgDocumento.Value = msImgDocumento.GetBuffer
        comandoInsertaDeposito = New SqlCommand
        comandoInsertaDeposito.Connection = conexionempresa
        comandoInsertaDeposito.CommandText = consultaInsertaDeposito
        comandoInsertaDeposito.Parameters.Add(imgDocumento)
        idDepositoLegal = comandoInsertaDeposito.ExecuteScalar


        Dim comandoNotificacion As SqlCommand
        Dim consultaNotificación As String
        consultaNotificación = "INSERT INTO OPENQUERY (MYSQ, 'SELECT * FROM USRS.Notificaciones')
VALUES (null,'DepositoLegal',1,'" & nmusr & "','" & ComboUsuarios.selectedValue & "','" & idDepositoLegal & "','','" & txtComentario.Text & "',0,'0',GETDATE(),CONVERT(varchar(8),GETDATE(),108),'0','','','" & nombreAmostrar & "','','');"
        comandoNotificacion = New SqlCommand
        comandoNotificacion.Connection = conexionempresa
        comandoNotificacion.CommandText = consultaNotificación
        comandoNotificacion.ExecuteNonQuery()

    End Sub
    Private Function ImagenComprimida(bmp As Bitmap) As Bitmap
        Try

            Dim Width As Integer = bmp.Width
            Dim Height As Integer = bmp.Height
            'next we declare the maximum size of the resized image. 
            'In this case, all resized images need to be constrained to a 173x173 square.
            Dim Heightmax As Integer = 1572
            Dim Widthmax As Integer = 1826
            'declare the minimum value af the resizing factor before proceeding. 
            'All images with a lower factor than this will actually be resized
            Dim Factorlimit As Decimal = 1
            'determine if it is a portrait or landscape image
            Dim Relative As Decimal = Height / Width
            Dim Factor As Decimal
            'if the image is a portrait image, calculate the resizing factor based on its height. 
            'else the image is a landscape image, 
            'and we calculate the resizing factor based on its width.
            If Relative > 1 Then
                If Height < (Heightmax + 1) Then
                    Factor = 1
                Else
                    Factor = Heightmax / Height
                End If
                '
            Else
                If Width < (Widthmax + 1) Then
                    Factor = 1
                Else
                    Factor = Widthmax / Width
                End If
            End If
            If Factor < Factorlimit Then
                'draw a new image with the dimensions that result from the resizing
                Dim bmpnew As New Bitmap(bmp.Width * Factor, bmp.Height * Factor,
                    Imaging.PixelFormat.Format24bppRgb)
                Dim g As Graphics = Graphics.FromImage(bmpnew)
                g.InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
                'and paste the resized image into it
                g.DrawImage(bmp, 0, 0, bmpnew.Width, bmpnew.Height)
                Return bmpnew
            Else
                Return bmp
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Private Sub BackgroundUsuarios_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundUsuarios.DoWork
        iniciarconexionempresa()
        Dim consultaUsuarios As String
        consultaUsuarios = "SELECT * FROM OPENQUERY (MYSQ, 'select Usr.nm,Usr.nm_complete from Usr inner join grp on Usr.grp = grp.id inner join PermisosGrupo on grp.id = PermisosGrupo.idGrupo where PermisosGrupo.SatiModCreditosDescuentoPromesa = 1');  "
        adapterUsuarios = New SqlDataAdapter(consultaUsuarios, conexionempresa)
        dataUsuarios = New DataTable
        adapterUsuarios.Fill(dataUsuarios)
    End Sub

    Private Sub BackgroundUsuarios_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundUsuarios.RunWorkerCompleted
        ComboUsuarios.Clear()
        For Each row As DataRow In dataUsuarios.Rows
            ComboUsuarios.AddItem(row("nm").ToString)
        Next
        ComboUsuarios.selectedIndex = 0
        nCargando.Close()
    End Sub

    Private Sub ComboUsuarios_onItemSelected(sender As Object, e As EventArgs) Handles ComboUsuarios.onItemSelected
        For Each row As DataRow In dataUsuarios.Rows
            If row("nm").ToString = ComboUsuarios.selectedValue Then
                lblNombreUsuario.Text = row("nm_complete").ToString
                Exit For
            End If
        Next
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        nCargando = New Cargando
        nCargando.Show()
        nCargando.MonoFlat_Label1.Text = "Insertando Depósito"
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        nCargando.Close()
        Me.Close()

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Dim openFileDialog1 As New OpenFileDialog()
        Dim nombre As String
        openFileDialog1.Filter = "Imágenes (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg;*.jpeg;*.png"
        openFileDialog1.FilterIndex = 1

        openFileDialog1.ShowDialog()
        If openFileDialog1.FileName <> "" Then
            nombre = openFileDialog1.FileName
            BunifuImageButton1.Image = System.Drawing.Image.FromFile(nombre)


        Else
            MessageBox.Show("No se seleccionó ningún archivo")

        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub
End Class