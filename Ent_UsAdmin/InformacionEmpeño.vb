Imports System.ComponentModel
Imports System.Data.SqlClient
Imports WinControls.ListView

Public Class InformacionEmpeño
    Public idEmpeño As Integer
    Dim dataArticulos As DataTable
    Dim adapterArticulos As SqlDataAdapter
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
        Panel2.Size = New Size(51, 85)
        Panel2.Location = New Drawing.Point(Me.Width - Panel2.Width, TabControl1.Location.Y - Panel2.Height)
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando Información..."
        Cargando.TopMost = True
        BackgroundArticulos.RunWorkerAsync()

    End Sub

    Private Sub BackgroundArticulos_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundArticulos.DoWork
        iniciarconexionempresa()
        Dim consultaEmpeño As String
        Dim comandoEmpeño As SqlCommand
        Dim readerEmpeño As SqlDataReader

        consultaEmpeño = "select format(FechaEntrega,'dd-MM-yy') as 'Fecha de Entrega',Empeños.Nombre,MontoPrestado as 'Monto Prestado',empeños.montoRefrendo as 'Monto Refrendo',TiposDeEmpeño.Nombre as Tipo,empeños.Estado from Empeños inner join SolicitudBoleta on SolicitudBoleta.id = Empeños.idSolicitudBoleta  inner join TiposDeEmpeño on SolicitudBoleta.idTipoEmpeño = TiposDeEmpeño.id where Empeños.id = '" & idEmpeño & "'"
        comandoEmpeño = New SqlCommand
        comandoEmpeño.Connection = conexionempresa
        comandoEmpeño.CommandText = consultaEmpeño
        readerEmpeño = comandoEmpeño.ExecuteReader
        While readerEmpeño.Read
            lblnombre.Text = readerEmpeño("Nombre")
            If IsDBNull(readerEmpeño("Fecha de Entrega")) Then
                lblfecha.Text = ""
            Else
                lblfecha.Text = readerEmpeño("Fecha de Entrega")
            End If
            lblmonto.Text = FormatCurrency(readerEmpeño("Monto Prestado"))
            lblmontorefrendo.Text = FormatCurrency(readerEmpeño("Monto Refrendo"))
            lbltipo.Text = readerEmpeño("Tipo")
            estado = readerEmpeño("Estado")
        End While
        readerEmpeño.Close()

        Dim consultaArticulos As String
        consultaArticulos = "select ArticulosEmpeños.id, Tipo, Descripcion, Marca, Modelo, NoSerie as 'No de Serie', format(ArticulosEmpeños.MontoValuado, 'C','es-mx') as 'Monto Valuado', format(ArticulosEmpeños.MontoPrestado, 'c', 'es-mx') as 'Monto Prestado', Imagen from Empeños inner join ArticulosEmpeños on ArticulosEmpeños.idSolicitud=Empeños.idSolicitudBoleta  where Empeños.id = '" & idEmpeño & "'"
        adapterArticulos = New SqlDataAdapter(consultaArticulos, conexionempresa)
        dataArticulos = New DataTable
        adapterArticulos.Fill(dataArticulos)

    End Sub

    Private Sub BackgroundArticulos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundArticulos.RunWorkerCompleted
        Me.Text = "Información de Empeño " & lblnombre.Text
        dtArticulos.DataSource = dataArticulos

        'Damos formato de imagen a la columna con la foto del artículo, y definimos el ancho y alto de esta.
        dtArticulos.Columns.Item(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dtArticulos.Columns.Item(8).Width = 200
        Dim imagecolumn As DataGridViewImageColumn
        imagecolumn = dtArticulos.Columns.Item(8)
        imagecolumn.ImageLayout = DataGridViewImageCellLayout.Zoom
        dtArticulos.Columns.Item(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dtArticulos.Columns.Item(2).Width = 300
        dtArticulos.Columns.Item(2).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dtArticulos.Columns.Item(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dtArticulos.Columns.Item(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        For Each row As DataGridViewRow In dtArticulos.Rows
            row.Height = 120
        Next

        BackgroundSolicitud.RunWorkerAsync()
        dtSolicitud.Rows.Clear()
        dtSolicitud.ScrollBars = ScrollBars.None
        Cargando.MonoFlat_Label1.Text = "Cargando Solicitud..."
    End Sub

    Private Sub BackgroundSolicitud_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundSolicitud.DoWork

        Try
            Dim strSolicitud As String
            iniciarconexionempresa()

            strSolicitud = "select SolicitudBoleta.id,format(SolicitudBoleta.Fecha,'dd-MM-yy') as Fecha,SolicitudBoleta.MontoValuado,SolicitudBoleta.MontoAutorizado, SolicitudBoleta.idTipoEmpeño as tipo from Empeños inner join SolicitudBoleta on Empeños.IdSolicitudBoleta = SolicitudBoleta.id where Empeños.id = '" & idEmpeño & "'"




            Dim ejec = New SqlCommand(strSolicitud)
            ejec.Connection = conexionempresa
            Dim id As String

            Dim myreaderSolicitud As SqlDataReader = ejec.ExecuteReader()
            While myreaderSolicitud.Read
                id = myreaderSolicitud("id")


                dtSolicitud.Rows.Add(id, myreaderSolicitud("fecha"), FormatCurrency(myreaderSolicitud("MontoValuado"), 2), FormatCurrency(myreaderSolicitud("MontoAutorizado"), 2), myreaderSolicitud("tipo"))
            End While
            myreaderSolicitud.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundSolicitud_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundSolicitud.RunWorkerCompleted
        dtSolicitud.ScrollBars = ScrollBars.Both
        Cargando.MonoFlat_Label1.Text = "Cargando Documentos..."
        BackgroundDocumentos.RunWorkerAsync()

    End Sub

    Private Sub BackgroundDocumentos_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundDocumentos.DoWork
        Dim consultaDocumentos As String
        consultaDocumentos = "select TiposdeDocumentosSolicitud.Nombre,DocumentosEmpeño.Imagen from Empeños inner join DocumentosEmpeño on Empeños.id = DocumentosEmpeño.idEmpeño inner join TiposdeDocumentosSolicitud on DocumentosEmpeño.Tipo = TiposdeDocumentosSolicitud.id where Empeños.id = '" & idEmpeño & "'"
        adapterDocumentos = New SqlDataAdapter(consultaDocumentos, conexionempresa)
        dataDocumentos = New DataTable
        adapterDocumentos.Fill(dataDocumentos)
    End Sub

    Private Sub BackgroundDocumentos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundDocumentos.RunWorkerCompleted
        dtdatosDocumentos.DataSource = dataDocumentos

        'Damos formato de imagen a la columna con la foto del artículo, y definimos el ancho y alto de esta.
        dtdatosDocumentos.Columns.Item(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dtdatosDocumentos.Columns.Item(1).Width = 250
        Dim imagecolumn As DataGridViewImageColumn
        imagecolumn = dtdatosDocumentos.Columns.Item(1)
        imagecolumn.ImageLayout = DataGridViewImageCellLayout.Zoom
        dtdatosDocumentos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None

        Cargando.MonoFlat_Label1.Text = "Cargando Pagos..."
        BackgroundPagos.RunWorkerAsync()
    End Sub

    Private Sub dtSolicitud_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtSolicitud.CellDoubleClick
        DatosSolicitudBoletaVerificar.idSolicitud = dtSolicitud.Rows(dtSolicitud.CurrentRow.Index).Cells(0).Value
        DatosSolicitudBoletaVerificar.verSolicitud = True
        DatosSolicitudBoletaVerificar.Show()
    End Sub



    Private Sub dtdatosDocumentos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtdatosDocumentos.CellDoubleClick
        Try
            VistaDocumento.PictureBox1.Image = dtdatosDocumentos.Rows(dtdatosDocumentos.CurrentRow.Index).Cells(1).FormattedValue
            VistaDocumento.ShowDialog()
        Catch a As Exception
            MessageBox.Show("No hay documentos para mostrar en este empeño.")
        End Try
    End Sub

    Private Sub BackgroundPagos_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundPagos.DoWork
        iniciarconexionempresa()
        TreeListView1.Nodes.Clear()

        Dim comandoTicket As SqlCommand
        Dim consulta As String
        Dim readerTicket As SqlDataReader

        consulta = $"select id,Recibido,(case when tipo = 'Refrendo' or tipo = 'Comisión por avalúo' or tipo = 'Desempeño' then
ISNULL((select nombre from Empeños where id = pagos.idEmpeño),0) 		end) as nombre,idEmpeño,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja from
(select Ticket.Id,Ticket.Recibido,Ticket.idCredito as idEmpeño,Ticket.Fecha,Ticket.hora,Ticket.PagoNormal,Ticket.Intereses,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id  where  ticket.idCredito = '{idEmpeño}'  and (tipodoc = (select id from tipodoc where nombre = 'Refrendo') or  tipodoc = (select id from tipodoc where nombre = 'Comisión por Avalúo') or  tipodoc = (select id from tipodoc where nombre = 'Desempeño')))pagos order by Fecha,Hora asc"

        comandoTicket = New SqlCommand
        comandoTicket.Connection = conexionempresa
        comandoTicket.CommandText = consulta
        readerTicket = comandoTicket.ExecuteReader
        If readerTicket.HasRows Then
            While readerTicket.Read
                Dim liItem As New TreeListNode(readerTicket("id"))
                With liItem.SubItems
                    .Add(readerTicket("idEmpeño"))
                    .Add(readerTicket("nombre"))
                    .Add(readerTicket("PagoNormal"))
                    .Add(readerTicket("Intereses"))
                    .Add(readerTicket("Total"))
                    .Add(readerTicket("Fecha"))
                    .Add(readerTicket("Hora").ToString)
                    .Add(readerTicket("Tipo"))
                    .Add(readerTicket("Caja"))
                End With


                TreeListView1.Nodes.Add(liItem)
            End While
        End If
    End Sub
    Private Sub _addSubItems(ByVal aObj As ContainerListViewObject, ByVal pagonormal As Double, ByVal intereses As Double, ByVal total As Double)
        With aObj.SubItems
            .Add("")
            .Add("")
            .Add(pagonormal)
            .Add(intereses)
            .Add(total)
        End With
    End Sub

    Private Sub BackgroundPagos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundPagos.RunWorkerCompleted
        Cargando.MonoFlat_Label1.Text = "Consultando Actualizaciones"
        BackgroundActualizaciones.RunWorkerAsync()
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        If bloqueado Then

        Else
            For i As Integer = 51 To 281 Step 10
                Panel2.Width = i
                Panel2.Location = New Drawing.Point(Me.Width - Panel2.Width, TabControl1.Location.Y - Panel2.Height)
            Next
            bloqueado = True
        End If
    End Sub

    Private Sub InformacionSolicitud_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        For i As Integer = Panel2.Width To 51 Step -10
            Panel2.Width = i
            Panel2.Location = New Drawing.Point(Me.Width - Panel2.Width, TabControl1.Location.Y - Panel2.Height)
        Next
        bloqueado = False
    End Sub

    Private Sub BackgroundActualizaciones_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundActualizaciones.DoWork
        iniciarconexionempresa()
        Dim consultaActualizaciones As String
        consultaActualizaciones = "select Fecha,Hora,Campo,ValorAnterior,NuevoValor,Motivo from ActualizacionesEmpeño where idEmpeño = '" & idEmpeño & "'"
        adapterActualizaciones = New SqlDataAdapter(consultaActualizaciones, conexionempresa)
        dataActualizaciones = New Data.DataTable
        adapterActualizaciones.Fill(dataActualizaciones)
    End Sub

    Private Sub BackgroundActualizaciones_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundActualizaciones.RunWorkerCompleted
        dtActualizaciones.DataSource = dataActualizaciones
        Cargando.Close()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        ActInformacionEmpeño.idEmpeño = idEmpeño
        ActInformacionEmpeño.Show()
    End Sub

    Private Sub btnAgregarDocumentos_Click(sender As Object, e As EventArgs) Handles btnAgregarDocumentos.Click
        DocumentosEmpeño.idEmpeño = idEmpeño
        DocumentosEmpeño.Show()
    End Sub

    Private Sub dtArticulos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtArticulos.CellDoubleClick
        Try
            VistaDocumento.PictureBox1.Image = dtArticulos.Rows(dtArticulos.CurrentRow.Index).Cells(8).FormattedValue
            VistaDocumento.ShowDialog()
        Catch a As Exception
            MessageBox.Show("No hay artículos para mostrar en este empeño.")
        End Try
    End Sub

    Private Sub dtArticulos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtArticulos.CellContentClick

    End Sub
End Class