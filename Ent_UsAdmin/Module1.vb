Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Imports System.ComponentModel


Module Module1
    Public strusuarios As String
    Public cn As String
    Public cnempresa As String
    Public cnEmpresasR As String
    Public ipser As String
    Public bdser As String
    Public ipconsultas As String
    Public bdconsultas As String
    Public nmusr As String
    Public grpusr As String
    Public nm_completeusr As String
    Public addrusr As String
    Public tlfusr As String
    Public imgstrusr As String
    Public bitmapBytes As Byte()
    Public idusr As String
    Public streamimgusr As System.IO.MemoryStream
    Public bitmapimgusr As Bitmap
    Public conexion As OleDbConnection
    Public conexionempresa As SqlConnection
    Public conexionempresaR As OleDbConnection
    Public m_PanStartPoint As New Point
    Public bloquear As Boolean = False
    Public NombreEmpresa As String
    Public RFCEmpresa As String
    Public CalleEmpresa As String
    Public NumeroEmpresa As String
    Public ColEmpresa As String
    Public CiudadEmpresa As String
    Public EstadoEmpresa As String
    Public CPEmpresa As String
    Public nombreAmostrar As String
    Public idEmpresa As String
    Public telEmpresa As String
    Public ImpresoraPredeterminada As String
    Public EmpleadoAsignado As Integer
    Public usuarioActivo As Boolean
    Public adapterPermisos As OleDb.OleDbDataAdapter
    Public dataPermisos As DataTable
    Public idGrp As Integer
    Public dataDocs As DataSet
    Public adapterDocs As SqlDataAdapter
    Public dataColonias As DataTable
    Public adapterColonias As SqlDataAdapter
    Public TipoEquipo As String

    Dim exApp As New Microsoft.Office.Interop.Excel.Application
    Public exLibro As Microsoft.Office.Interop.Excel.Workbook
    Private WithEvents TestWorker As System.ComponentModel.BackgroundWorker
    Private Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (
ByVal process As IntPtr,
ByVal minimumWorkingSetSize As Integer,
ByVal maximumWorkingSetSize As Integer) As Integer
    Private Declare Function CreateEllipticRgn Lib "gdi32" (ByVal X1 As Long, ByVal Y1 As Long, ByVal X2 As Long, ByVal Y2 As Long) As Long
    Private Declare Function SetWindowRgn Lib "user32" (ByVal hWnd As Long, ByVal hRgn As Long, ByVal bRedraw As Boolean) As Long
    Public Sub iniciarconexion()
        cn = "Provider=sqloledb;" &
                     "Data Source=  " & ipser & "\confia;" &
                     "Initial Catalog=" & bdser & ";" &
                     "User Id=sa;Password=BSi5t3Ma$CFAD;"
        conexion = New OleDbConnection(cn)
        conexion.Open()
    End Sub

    Public Sub iniciarconexionempresa()
        cnempresa = "Data Source=  " & ipconsultas & "\confia;" &
                     "Initial Catalog=" & bdconsultas & ";" &
                     "User Id=sa;Password=BSi5t3Ma$CFAD;MultipleActiveResultSets=true"
        conexionempresa = New SqlConnection(cnempresa)
        conexionempresa.Open()
    End Sub
    Public Sub iniciarconexionR()
        cnEmpresasR = "Provider=sqloledb;" &
                     "Data Source=  " & ipconsultas & "\confia;" &
                     "Initial Catalog=" & bdser & ";" &
                     "User Id=sa;Password=BSi5t3Ma$CFAD;"
        conexionempresaR = New OleDbConnection(cnEmpresasR)
        conexionempresaR.Open()
    End Sub

    Public Sub cargarperfil()
        Dim strconf As String = ("select x1.nm,x2.nm as grp,x1.nm_complete,x1.addr,x1.tlf,x1.imgstr,x1.activo,x1.grp as idgrp from usr x1 inner join grp x2 on x1.grp = x2.id where x1.idusr = '" & idusr & "'")
        Dim connexio = New OleDbConnection(cn)
        Dim ejec2 = New OleDbCommand(strconf)
        ejec2.Connection = connexio
        connexio.Open()
        Dim myreaderconf As OleDbDataReader = ejec2.ExecuteReader()
        While myreaderconf.Read()
            nmusr = Convert.ToString(myreaderconf("nm"))
            grpusr = Convert.ToString(myreaderconf("grp"))
            nm_completeusr = Convert.ToString(myreaderconf("nm_complete"))
            addrusr = Convert.ToString(myreaderconf("addr"))
            tlfusr = Convert.ToString(myreaderconf("tlf"))
            imgstrusr = Convert.ToString(myreaderconf("imgstr"))
            usuarioActivo = myreaderconf("activo")
            idGrp = myreaderconf("idgrp")
        End While
        If imgstrusr <> "" Then
            bitmapBytes = Convert.FromBase64String(imgstrusr)
            streamimgusr = New MemoryStream(bitmapBytes, 0, bitmapBytes.Length)
            streamimgusr.Write(bitmapBytes, 0, bitmapBytes.Length)
            bitmapimgusr = New Bitmap(streamimgusr)
        End If
        'connexio.Close()
        Dim consultaPermisos As String
        consultaPermisos = "Select * from permisosGrupo where idgrupo = '" & idGrp & "'"
        adapterPermisos = New OleDbDataAdapter(consultaPermisos, connexio)
        dataPermisos = New DataTable
        adapterPermisos.Fill(dataPermisos)

        connexio.Close()
    End Sub


    Public Sub cargarusuarios()
        Try
            Dim num_controles As Integer = usuarios.FlowLayoutPanel1.Controls.Count - 1

            For n As Integer = num_controles To 0 Step -1
                Dim ctrl As Control = usuarios.FlowLayoutPanel1.Controls(n)
                usuarios.FlowLayoutPanel1.Controls.Remove(ctrl)
                ctrl.Dispose()
            Next
            'strusuarios = "select idusr,nm_complete,imgstr from usr"
            Dim ejec2 = New OleDbCommand(strusuarios)
            ejec2.Connection = conexion
            Dim imgpanel As String
            Dim idusrpanel As String
            Dim nombrecompleto As String
            Dim bytespanel As Byte()
            Dim streamimgpanel As System.IO.MemoryStream
            Dim bitmapimgpanel As Bitmap
            Dim pictureboxpanel As Bunifu.Framework.UI.BunifuImageButton
            Dim labelnombre As Label

            Dim myreaderusuarios As OleDbDataReader = ejec2.ExecuteReader()
            While myreaderusuarios.Read
                imgpanel = Convert.ToString(myreaderusuarios("imgstr"))
                idusrpanel = Convert.ToString(myreaderusuarios("idusr"))
                nombrecompleto = Convert.ToString(myreaderusuarios("nm_complete"))

                If imgpanel <> "" Then
                    bytespanel = Convert.FromBase64String(imgpanel)
                    streamimgpanel = New MemoryStream(bytespanel, 0, bytespanel.Length)
                    streamimgpanel.Write(bytespanel, 0, bytespanel.Length)
                    bitmapimgpanel = New Bitmap(streamimgpanel)
                    pictureboxpanel = New Bunifu.Framework.UI.BunifuImageButton
                    pictureboxpanel.Image = bitmapimgpanel
                    pictureboxpanel.Size = New Size(100, 200)
                    pictureboxpanel.Name = idusrpanel
                    pictureboxpanel.BackColor = Color.FromArgb(223, 223, 223)
                    pictureboxpanel.SizeMode = PictureBoxSizeMode.StretchImage
                    AddHandler pictureboxpanel.MouseDown, AddressOf mousedownevent
                    AddHandler pictureboxpanel.MouseMove, AddressOf MouseMoveevent
                    AddHandler pictureboxpanel.MouseUp, AddressOf mouseupevent
                    AddHandler pictureboxpanel.Click, AddressOf clickevent
                    usuarios.FlowLayoutPanel1.PerformLayout()
                    usuarios.FlowLayoutPanel1.Controls.Add(pictureboxpanel)
                    labelnombre = New Label
                    labelnombre.Text = nombrecompleto
                    labelnombre.AutoSize = False
                    labelnombre.Size = New Size(100, 50)
                    labelnombre.BackColor = Color.FromArgb(18, 18, 18)
                    labelnombre.ForeColor = Color.FromArgb(223, 223, 223)
                    labelnombre.Location = New Point(0, pictureboxpanel.Height - labelnombre.Height)

                    pictureboxpanel.Controls.Add(labelnombre)
                Else
                    pictureboxpanel = New Bunifu.Framework.UI.BunifuImageButton
                    pictureboxpanel.Image = ConfiaAdmin.My.Resources.Resources.usuario
                    pictureboxpanel.Size = New Size(100, 200)
                    pictureboxpanel.Name = idusrpanel
                    pictureboxpanel.SizeMode = PictureBoxSizeMode.StretchImage
                    pictureboxpanel.BackColor = Color.FromArgb(223, 223, 223)
                    AddHandler pictureboxpanel.MouseDown, AddressOf mousedownevent
                    AddHandler pictureboxpanel.MouseMove, AddressOf MouseMoveevent
                    AddHandler pictureboxpanel.MouseUp, AddressOf mouseupevent
                    AddHandler pictureboxpanel.Click, AddressOf clickevent
                    usuarios.FlowLayoutPanel1.PerformLayout()
                    usuarios.FlowLayoutPanel1.Controls.Add(pictureboxpanel)
                    labelnombre = New Label
                    labelnombre.Text = nombrecompleto

                    labelnombre.AutoSize = False
                    labelnombre.Size = New Size(100, 50)
                    labelnombre.BackColor = Color.FromArgb(18, 18, 18)
                    labelnombre.ForeColor = Color.FromArgb(223, 223, 223)
                    labelnombre.Location = New Point(0, pictureboxpanel.Height - labelnombre.Height)
                    pictureboxpanel.Controls.Add(labelnombre)
                End If



            End While
            pictureboxpanel = New Bunifu.Framework.UI.BunifuImageButton
            pictureboxpanel.Image = My.Resources.usuario_agregar
            pictureboxpanel.Size = New Size(100, 200)
            pictureboxpanel.Name = "Agregar Usuario"
            pictureboxpanel.SizeMode = PictureBoxSizeMode.StretchImage
            pictureboxpanel.BackColor = Color.FromArgb(223, 223, 223)
            AddHandler pictureboxpanel.MouseDown, AddressOf mousedownevent
            AddHandler pictureboxpanel.MouseMove, AddressOf MouseMoveevent
            AddHandler pictureboxpanel.MouseUp, AddressOf mouseupevent
            AddHandler pictureboxpanel.Click, AddressOf clickevent
            usuarios.FlowLayoutPanel1.Controls.Add(pictureboxpanel)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub InitializeBackgroundWorker()
        TestWorker = New BackgroundWorker

        With TestWorker
            .WorkerReportsProgress = True
            .WorkerSupportsCancellation = True
        End With
    End Sub
    Public Sub RunWorkerAsync()
        TestWorker.RunWorkerAsync()
    End Sub
    Public Sub TestWorker_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles TestWorker.DoWork
        MessageBox.Show("haciendolo")
        cargarusuarios()
    End Sub

    Public Sub mousedownevent(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

        'Capture the initial point 
        m_PanStartPoint = New Point(e.X, e.Y)

    End Sub
    Public Sub mouseupevent(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

        'Capture the initial point 
        bloquear = False


    End Sub
    Public Sub MouseMoveevent(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

        'Verify Left Button is pressed while the mouse is moving
        If e.Button = Windows.Forms.MouseButtons.Left Then
            bloquear = True
            'Here we get the change in coordinates.
            Dim DeltaX As Integer = (m_PanStartPoint.X - e.X)
            Dim DeltaY As Integer = (m_PanStartPoint.Y - e.Y)

            'Then we set the new autoscroll position.
            'ALWAYS pass positive integers to the panels autoScrollPosition method
            usuarios.FlowLayoutPanel1.AutoScrollPosition = _
            New Drawing.Point((DeltaX - usuarios.FlowLayoutPanel1.AutoScrollPosition.X), _
                            (DeltaY - usuarios.FlowLayoutPanel1.AutoScrollPosition.Y))

        End If

    End Sub
    Public Sub clickevent(ByVal sender As Object, ByVal e As EventArgs)

        ' Dim label = DirectCast(sender, Label)
        If bloquear = False Then
            Editar_Usuario.idusuario = sender.name

            Editar_Usuario.Show()
        End If



    End Sub

    Private Sub TestWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles TestWorker.RunWorkerCompleted
        MessageBox.Show("listo")
    End Sub

    Public Sub FlushMemory()
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub Docs()
        Dim consultaDocs As String
        consultaDocs = "select * from tipodoc"
        adapterDocs = New SqlDataAdapter(consultaDocs, conexionempresa)
        dataDocs = New DataSet
        adapterDocs.Fill(dataDocs)
    End Sub

    Public Sub Colonias()
        Dim consultaColonias As String
        consultaColonias = "select * from colonias"
        adapterColonias = New SqlDataAdapter(consultaColonias, conexionempresa)
        dataColonias = New DataTable
        adapterColonias.Fill(dataColonias)
    End Sub

    Public Function AfectaCaja(nombredoc As String) As Boolean
        Dim afectacion As Boolean
        For Each row As DataRow In dataDocs.Tables(0).Rows
            If row("Nombre").ToString = nombredoc Then
                afectacion = Val(row("AfectaCaja").ToString)
                Exit For
            End If

        Next
        Return afectacion
    End Function

    Public Function ObtenerTipoDoc(nombredoc As String) As Integer
        Dim tipoDoc As Integer
        For Each row As DataRow In dataDocs.Tables(0).Rows
            If row("Nombre").ToString = nombredoc Then
                tipoDoc = Val(row("id").ToString)
                Exit For
            End If

        Next
        Return tipoDoc
    End Function

    Public Function GetNombreDoc(id As Integer) As String
        Dim nombreDoc As String
        For Each row As DataRow In dataDocs.Tables(0).Rows
            If row("id").ToString = id Then
                nombreDoc = row("Nombre").ToString
                Exit For
            End If

        Next
        Return nombreDoc
    End Function

    Public Sub nuevolibro()
        exLibro = exApp.Workbooks.Add
    End Sub


    Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean

        'Creamos las variables

        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try
            'Añadimos el Libro al programa, y la hoja al libro

            exHoja = exLibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount

            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).HeaderText.ToString
                'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value.ToString
                Next
            Next
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()
            'exHoja.Columns.Range("A:A").NumberFormat = "#0"

            'Aplicación visible

            exHoja = Nothing


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")

            Return False
        End Try

        Return True

    End Function


    Public Sub cerrarlibro()
        Try

            Dim guardar As SaveFileDialog
            guardar = New SaveFileDialog
            guardar.Filter = "Archivo de Excel|*.xlsx"
            If guardar.ShowDialog = DialogResult.OK _
            Then
                exApp.Application.Visible = True
                'exLibro.SaveAs(Environ("UserProfile") & "\desktop\" & nombre & ".xls")
                exLibro.SaveAs(guardar.FileName)
            End If

            ' exLibro.SaveAs(Environ("UserProfile") & "\desktop\NombreDeTuArchivo.xls")
            'exLibro = Nothing
            'exApp = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Module
