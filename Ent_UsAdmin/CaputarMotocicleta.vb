Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO

Public Class CaputarMotocicleta
    Public idCredito As String
    Dim dataDocumentos As DataTable
    Dim adapterDocumentos As SqlDataAdapter
    Dim nCargando As Cargando

    Private Sub CaputarMotocicleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nCargando = New Cargando
        nCargando.Show()
        nCargando.MonoFlat_Label1.Text = "Cargando Datos"


        BackgroundMotocicleta.RunWorkerAsync()

    End Sub

    Private Sub BackgroundMotocicleta_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundMotocicleta.DoWork
        iniciarconexionempresa()

        Dim comandoMotocicleta As SqlCommand
        Dim consultaMotocicleta As String
        Dim readerMotocicleta As SqlDataReader

        consultaMotocicleta = "select * from motocicletas where idcredito='" & idCredito & "'"
        comandoMotocicleta = New SqlCommand
        comandoMotocicleta.Connection = conexionempresa
        comandoMotocicleta.CommandText = consultaMotocicleta

        readerMotocicleta = comandoMotocicleta.ExecuteReader
        If readerMotocicleta.HasRows Then
            While readerMotocicleta.Read
                txtMarca.Text = readerMotocicleta("Marca")
                txtModelo.Text = readerMotocicleta("Modelo")
                txtCilindraje.Text = readerMotocicleta("Cilindraje")
                txtColor.Text = readerMotocicleta("Color")
                txtAño.Text = readerMotocicleta("Año")
                txtSerie.Text = readerMotocicleta("Serie")
                txtNCI.Text = readerMotocicleta("NCI")
                txtNoMotor.Text = readerMotocicleta("NoMotor")
                txtNoPedimento.Text = readerMotocicleta("NoPedimento")
                txtNoFactura.Text = readerMotocicleta("NoFactura")
                txtValor.Text = readerMotocicleta("Valor")



            End While
        End If


    End Sub

    Private Sub BackgroundDocumentosMotocicleta_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundDocumentosMotocicleta.DoWork
        iniciarconexionempresa()
        Dim consultaDocumentos As String
        consultaDocumentos = "Select DocumentosCredito.Tipo,TiposdeDocumentosSolicitud.Nombre,DocumentosCredito.Imagen from documentosCredito inner join TiposdeDocumentosSolicitud on DocumentosCredito.Tipo = TiposdeDocumentosSolicitud.id where idCredito = '" & idCredito & "' and (DocumentosCredito.tipo = (select id from TiposdeDocumentosSolicitud where nombre='Motocicleta') or DocumentosCredito.tipo = (select id from TiposdeDocumentosSolicitud where nombre='Factura Motocicleta'))"
        adapterDocumentos = New SqlDataAdapter(consultaDocumentos, conexionempresa)
        dataDocumentos = New DataTable
        adapterDocumentos.Fill(dataDocumentos)
    End Sub

    Private Sub BackgroundDocumentosMotocicleta_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundDocumentosMotocicleta.RunWorkerCompleted
        dtdatosDocumentos.DataSource = dataDocumentos
        nCargando.Close()

    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        AgregarDocumentoMotocicleta.Show()

    End Sub

    Private Sub BackgroundMotocicleta_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundMotocicleta.RunWorkerCompleted
        nCargando.MonoFlat_Label1.Text = "Cargando Documentos"
        BackgroundDocumentosMotocicleta.RunWorkerAsync()

    End Sub

    Private Sub BackgroundDocumentos_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundDocumentos.DoWork
        iniciarconexionempresa()

        For Each row As DataGridViewRow In dtdatosDocumentosNuevos.Rows
            Dim comandoDocumento As SqlCommand
            Dim consultaDocumento As String
            Dim imagen As Bitmap = TryCast(row.Cells(2).Value, Bitmap)
            Dim NuevaImagen As Bitmap = ImagenComprimida(imagen)

            consultaDocumento = "insert into DocumentosCredito values('" & idCredito & "','" & row.Cells(0).Value & "',@Documento)"
            Dim imgDocumento As New SqlParameter("@Documento", SqlDbType.Image)
            Dim msImgDocumento As New MemoryStream
            NuevaImagen.Save(msImgDocumento, ImageFormat.Jpeg)
            imgDocumento.Value = msImgDocumento.GetBuffer
            comandoDocumento = New SqlCommand
            comandoDocumento.Connection = conexionempresa
            comandoDocumento.CommandText = consultaDocumento
            comandoDocumento.Parameters.Add(imgDocumento)
            comandoDocumento.ExecuteNonQuery()

        Next

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

    Private Sub BackgroundActualizarDatos_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundActualizarDatos.DoWork
        iniciarconexionempresa()
        Dim comandoActualizar As SqlCommand
        Dim consultaActualizar As String
        consultaActualizar = "UPDATE [dbo].[Motocicletas]
   SET [Marca] = '" & txtMarca.Text & "'
      ,[Modelo] = '" & txtModelo.Text & "'
      ,[Cilindraje] = '" & txtCilindraje.Text & "'
      ,[Color] = '" & txtColor.Text & "'
      ,[Año] = '" & txtAño.Text & "'
      ,[Serie] = '" & txtSerie.Text & "'
      ,[NCI] = '" & txtNCI.Text & "'
      ,[NoMotor] = '" & txtNoMotor.Text & "'
      ,[NoPedimento] = '" & txtNoPedimento.Text & "'
      ,[NoFactura] = '" & txtNoFactura.Text & "'
      ,[Valor] = '" & txtValor.Text & "'
     
 WHERE idcredito='" & idCredito & "'"

        comandoActualizar = New SqlCommand
        comandoActualizar.Connection = conexionempresa
        comandoActualizar.CommandText = consultaActualizar
        comandoActualizar.ExecuteNonQuery()

    End Sub

    Private Sub btn_Procesar_Click(sender As Object, e As EventArgs) Handles btn_Procesar.Click
        nCargando = New Cargando
        nCargando.Show()

        nCargando.MonoFlat_Label1.Text = "Actualizando Información"
        BackgroundActualizarDatos.RunWorkerAsync()

    End Sub

    Private Sub BackgroundActualizarDatos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundActualizarDatos.RunWorkerCompleted
        nCargando.MonoFlat_Label1.Text = "Insertando Documentos"
        BackgroundDocumentos.RunWorkerAsync()

    End Sub

    Private Sub BackgroundDocumentos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundDocumentos.RunWorkerCompleted
        nCargando.MonoFlat_Label1.Text = "Cargando Documentos"
        dtdatosDocumentosNuevos.Rows.Clear()

        BackgroundDocumentosMotocicleta.RunWorkerAsync()
        EntregarDocumentacion.MotoActualizada = True


    End Sub



    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub
End Class