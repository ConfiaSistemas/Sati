Imports System.ComponentModel
Imports System.Data.SqlClient
Imports WinControls.ListView

Public Class InformacionCliente

    Public idCLiente As Integer

    Dim dataClientes As DataTable
    Dim adapterClientes As SqlDataAdapter
    Dim dataCalendario As DataTable
    Dim adapterCalendario As SqlDataAdapter
    Dim dataDocumentos As DataTable
    Dim adapterDocumentos As SqlDataAdapter
    Dim bloqueado As Boolean
    Dim dataGestiones As Data.DataTable
    Dim adapterGestiones As SqlDataAdapter
    Dim dataActualizaciones As Data.DataTable
    Dim adapterActualizaciones As SqlDataAdapter
    Dim estado As String
    Private Sub InformacionSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Panel2.Size = New Size(51, 85)
        'Panel2.Location = New Drawing.Point(Me.Width - Panel2.Width, TabControl1.Location.Y - Panel2.Height)
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando Información"
        Cargando.TopMost = True

        BackgroundDatos.RunWorkerAsync()
    End Sub



    Private Sub BackgroundSolicitud_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundSolicitud.DoWork

        Try
            Dim strimpuestos As String
            iniciarconexionempresa()

            strimpuestos = "select Solicitud.id,format(Solicitud.Fecha,'dd-MM-yy') as Fecha,Solicitud.Nombre,Solicitud.Monto,Solicitud.MontoAutorizado,TiposDeCredito.Nombre as Tipo from solicitud inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where DatosSolicitud.IdCliente ='" & idCLiente & "'"




            Dim ejec = New SqlCommand(strimpuestos)
            ejec.Connection = conexionempresa
            Dim id, nombre, valor, factor, tipo As String

            Dim myreaderimpuestos As SqlDataReader = ejec.ExecuteReader()
            While myreaderimpuestos.Read
                id = myreaderimpuestos("id")
                If IsDBNull(myreaderimpuestos("montoautorizado")) Then
                    valor = 0
                Else
                    valor = myreaderimpuestos("montoautorizado")
                End If


                dtSolicitud.Rows.Add(id, myreaderimpuestos("fecha"), myreaderimpuestos("nombre"), FormatCurrency(myreaderimpuestos("Monto"), 2), FormatCurrency(valor, 2), myreaderimpuestos("tipo"))
            End While
            myreaderimpuestos.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundSolicitud_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundSolicitud.RunWorkerCompleted
        dtSolicitud.ScrollBars = ScrollBars.Both
        ' BackgroundCalendario.RunWorkerAsync()
        Cargando.MonoFlat_Label1.Text = "Cargando Créditos"
        BackgroundCreditos.RunWorkerAsync()
    End Sub









    Private Sub dtSolicitud_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtSolicitud.CellContentDoubleClick
        DatosConsultaSolicitud.idSolicitud = dtSolicitud.Rows(dtSolicitud.CurrentRow.Index).Cells(0).Value
        '  DatosConsultaSolicitud.TipoSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(5).Value
        DatosConsultaSolicitud.Show()
    End Sub









    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub





    Private Sub btnGenerarCalendario_Click(sender As Object, e As EventArgs)
        DocumentosCredito.idCredito = 1
        DocumentosCredito.Show()
    End Sub


    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)
        ActInformacionCredito.idCredito = idCLiente
        ActInformacionCredito.Show()
    End Sub

    Private Sub BackgroundCreditos_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundCreditos.DoWork
        ' Try
        Dim strimpuestos As String
            iniciarconexionempresa()

            strimpuestos = "select Credito.id,format(Credito.FechaEntrega,'dd-MM-yy') as 'Fecha de Entrega',Credito.Nombre,Credito.Monto,TiposDeCredito.Nombre as Tipo, Credito.Estado  from Credito inner join Solicitud on Solicitud.id = Credito.IdSolicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id inner join DatosSolicitud on DatosSolicitud.IdSolicitud = Solicitud.id where DatosSolicitud.IdCliente ='" & idCLiente & "'"




            Dim ejec = New SqlCommand(strimpuestos)
            ejec.Connection = conexionempresa
            Dim id, nombre, valor, factor, tipo As String

            Dim myreaderimpuestos As SqlDataReader = ejec.ExecuteReader()
            While myreaderimpuestos.Read
                id = myreaderimpuestos("id")


                dtCredito.Rows.Add(id, myreaderimpuestos("Fecha de Entrega"), myreaderimpuestos("nombre"), FormatCurrency(myreaderimpuestos("Monto"), 2), myreaderimpuestos("tipo"), myreaderimpuestos("estado"))
            End While
            myreaderimpuestos.Close()
        ' Catch ex As Exception
        'MessageBox.Show(ex.Message)
        '  End Try
    End Sub

    Private Sub BackgroundDatos_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundDatos.DoWork

        ' consultadatos = "select CONCAT(Nombre,' ',ApellidoPaterno,' ',ApellidoMaterno) as nombre,FechaAlta,FechaNacimiento,Telefono,Celular	 from clientes where id = '" & idCLiente & "'"
        iniciarconexionempresa()
        Dim consultaCredito As String
        Dim comandoCredito As SqlCommand
        Dim readerCredito As SqlDataReader

        consultaCredito = "select CONCAT(Nombre,' ',ApellidoPaterno,' ',ApellidoMaterno) as nombre,FechaAlta,FechaNacimiento,Telefono,Celular	 from clientes where id = '" & idCLiente & "'"
        comandoCredito = New SqlCommand
        comandoCredito.Connection = conexionempresa
        comandoCredito.CommandText = consultaCredito
        readerCredito = comandoCredito.ExecuteReader
        While readerCredito.Read
            lblnombre.Text = readerCredito("Nombre")
            lblfecha.Text = readerCredito("fechaalta")
            lblfechanacimiento.Text = readerCredito("fechanacimiento")
            lbltelefono.Text = readerCredito("telefono")
            lblcelular.Text = readerCredito("celular")

        End While
    End Sub

    Private Sub BackgroundDatos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundDatos.RunWorkerCompleted
        Cargando.MonoFlat_Label1.Text = "Cargando Solicitudes"
        BackgroundSolicitud.RunWorkerAsync()

    End Sub

    Private Sub BackgroundCreditos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundCreditos.RunWorkerCompleted
        Cargando.Close()
    End Sub

    Private Sub dtCredito_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtCredito.CellContentClick

    End Sub

    Private Sub dtSolicitud_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtSolicitud.CellContentClick

    End Sub

    Private Sub dtCredito_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtCredito.CellContentDoubleClick
        InformacionSolicitud.idCredito = dtCredito.Rows(dtSolicitud.CurrentRow.Index).Cells(0).Value
        '  DatosConsultaSolicitud.TipoSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(5).Value
        InformacionSolicitud.Show()
    End Sub
End Class