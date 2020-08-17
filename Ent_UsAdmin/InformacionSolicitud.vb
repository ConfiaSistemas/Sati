Imports System.ComponentModel
Imports System.Data.SqlClient
Imports WinControls.ListView

Public Class InformacionSolicitud
    Public idCredito As Integer
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
        Panel2.Size = New Size(51, 85)
        Panel2.Location = New Drawing.Point(Me.Width - Panel2.Width, TabControl1.Location.Y - Panel2.Height)
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando Información"
        Cargando.TopMost = True
        BackgroundClientes.RunWorkerAsync()

    End Sub

    Private Sub BackgroundClientes_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundClientes.DoWork
        iniciarconexionempresa()
        Dim consultaCredito As String
        Dim comandoCredito As SqlCommand
        Dim readerCredito As SqlDataReader

        consultaCredito = "select format(FechaEntrega,'dd-MM-yy') as FechaEntrega,credito.Nombre,Monto,Credito.Pagare,TiposDeCredito.Nombre as tipo,credito.estado from Credito inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id where credito.id = '" & idCredito & "'"
        comandoCredito = New SqlCommand
        comandoCredito.Connection = conexionempresa
        comandoCredito.CommandText = consultaCredito
        readerCredito = comandoCredito.ExecuteReader
        While readerCredito.Read
            lblnombre.Text = readerCredito("Nombre")
            If IsDBNull(readerCredito("FechaEntrega")) Then
                lblfecha.Text = ""
            Else
                lblfecha.Text = readerCredito("FechaEntrega")
            End If
            ' lblfecha.Text = readerCredito("FechaEntrega")
            lblmonto.Text = FormatCurrency(readerCredito("Monto"))
            lblmontopagare.Text = FormatCurrency(readerCredito("Pagare"))
            lbltipo.Text = readerCredito("tipo")
            estado = readerCredito("estado")
        End While

        readerCredito.Close()
        Dim consultaClientes As String
        consultaClientes = "select Clientes.id,Clientes.Nombre,Clientes.Apellidopaterno,Clientes.ApellidoMaterno from Credito inner join Solicitud on Credito.IdSolicitud =  Solicitud.id inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud inner join Clientes on DatosSolicitud.IdCliente = Clientes.id where Credito.id = '" & idCredito & "'"
        adapterClientes = New SqlDataAdapter(consultaClientes, conexionempresa)
        dataClientes = New DataTable
        adapterClientes.Fill(dataClientes)

    End Sub

    Private Sub BackgroundClientes_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundClientes.RunWorkerCompleted
        Me.Text = "Información de Crédito " & lblnombre.Text
        dtClientes.DataSource = dataClientes
        BackgroundSolicitud.RunWorkerAsync()
        dtSolicitud.Rows.Clear()
        dtSolicitud.ScrollBars = ScrollBars.None
    End Sub

    Private Sub BackgroundSolicitud_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundSolicitud.DoWork

        Try
            Dim strimpuestos As String
            iniciarconexionempresa()

            strimpuestos = "select Solicitud.id,format(Solicitud.Fecha,'dd-MM-yy') as Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo from Credito inner join Solicitud on Credito.IdSolicitud = Solicitud.id where Credito.id = '" & idCredito & "'"




            Dim ejec = New SqlCommand(strimpuestos)
            ejec.Connection = conexionempresa
            Dim id, nombre, valor, factor, tipo As String

            Dim myreaderimpuestos As SqlDataReader = ejec.ExecuteReader()
            While myreaderimpuestos.Read
                id = myreaderimpuestos("id")


                dtSolicitud.Rows.Add(id, myreaderimpuestos("fecha"), FormatCurrency(myreaderimpuestos("Monto"), 2), FormatCurrency(myreaderimpuestos("MontoAutorizado"), 2), myreaderimpuestos("tipo"))
            End While
            myreaderimpuestos.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundSolicitud_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundSolicitud.RunWorkerCompleted
        dtSolicitud.ScrollBars = ScrollBars.Both
        BackgroundCalendario.RunWorkerAsync()

    End Sub

    Private Sub BackgroundCalendario_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundCalendario.DoWork
        Dim consultaCalendario As String
        consultaCalendario = "select format(CalendarioNormal.FechaPago,'dd-MM-yy') as FechaPago,CalendarioNormal.Npago,CalendarioNormal.Monto from Credito inner join CalendarioNormal on Credito.id = CalendarioNormal.id_credito where Credito.id = '" & idCredito & "'"
        adapterCalendario = New SqlDataAdapter(consultaCalendario, conexionempresa)
        dataCalendario = New DataTable
        adapterCalendario.Fill(dataCalendario)
    End Sub

    Private Sub BackgroundCalendario_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundCalendario.RunWorkerCompleted
        dtCalendarios.DataSource = dataCalendario
        BackgroundDocumentos.RunWorkerAsync()

    End Sub

    Private Sub BackgroundDocumentos_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundDocumentos.DoWork
        Dim consultaDocumentos As String
        consultaDocumentos = "select TiposdeDocumentosSolicitud.Nombre,DocumentosCredito.imagen from Credito inner join DocumentosCredito on Credito.id = DocumentosCredito.IdCredito inner join TiposdeDocumentosSolicitud on DocumentosCredito.Tipo = TiposdeDocumentosSolicitud.id where Credito.id = '" & idCredito & "'"
        adapterDocumentos = New SqlDataAdapter(consultaDocumentos, conexionempresa)
        dataDocumentos = New DataTable
        adapterDocumentos.Fill(dataDocumentos)
    End Sub

    Private Sub BackgroundDocumentos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundDocumentos.RunWorkerCompleted
        dtdatosDocumentos.DataSource = dataDocumentos
        BackgroundPagos.RunWorkerAsync()

        'Cargando.Close()
    End Sub

    Private Sub dtSolicitud_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtSolicitud.CellContentClick

    End Sub

    Private Sub dtSolicitud_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtSolicitud.CellContentDoubleClick
        DatosConsultaSolicitud.idSolicitud = dtSolicitud.Rows(dtSolicitud.CurrentRow.Index).Cells(0).Value
        '  DatosConsultaSolicitud.TipoSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(5).Value
        DatosConsultaSolicitud.Show()
    End Sub



    Private Sub dtdatosDocumentos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtdatosDocumentos.CellContentDoubleClick
        VistaDocumento.PictureBox1.Image = dtdatosDocumentos.Rows(dtdatosDocumentos.CurrentRow.Index).Cells(1).FormattedValue
        VistaDocumento.ShowDialog()
    End Sub

    Private Sub BackgroundPagos_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundPagos.DoWork
        iniciarconexionempresa()
        TreeListView1.Nodes.Clear()



        Dim comandoTicket As SqlCommand
        Dim consulta As String
        Dim readerTicket As SqlDataReader



        'consulta = "select id,Recibido,(case when tipo = 'Legal' then Concepto
        ' when tipo = 'Extra' then Concepto

        ' Else ISNULL((Select nombre from Credito where id = pagos.idCredito),0) 		End) As nombre,idCredito,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja from
        '(select Ticket.Id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.PagoNormal,Ticket.Intereses,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id  where  ticket.idcredito = '" & idCredito & "'  )pagos order by Fecha,Hora asc"

        consulta = "if  exists(select * from reestructurassac where idCredito = '" & idCredito & "')
begin
select id,Recibido,(case when tipo = 'Legal' then Concepto
							   when tipo = 'Extra' then Concepto
							  
							   else ISNULL((select nombre from Credito where id = pagos.idCredito),0) 		end) as nombre,idCredito,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja from
(select Ticket.Id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.PagoNormal,Ticket.Intereses,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id  where  ticket.idcredito = '" & idCredito & "' and (tipodoc = (select id from tipodoc where nombre = 'Pago') or  tipodoc = (select id from tipodoc where nombre = 'Liquidación Insoluto') or tipodoc = (select id from tipodoc where nombre = 'Liquidación Renovación') or tipodoc = (select id from tipodoc where nombre = 'Liquidación Normal') or  tipodoc = (select id from tipodoc where nombre = 'Renovación Insoluto')) )pagos 
union
select id,Recibido,(case when tipo = 'Legal' then Concepto
							   when tipo = 'Extra' then Concepto
							  
							   else ISNULL((select nombre from Credito inner join ConveniosSac on Credito.id = ConveniosSac.idCredito where ConveniosSac.id = pagos.idCredito),0) 		end) as nombre,idCredito,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja from
(select Ticket.Id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.PagoNormal,Ticket.Intereses,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id  where  ticket.idcredito = (select id from ConveniosSac where idCredito ='" & idCredito & "') and TipoDoc = (select id from tipodoc where nombre = 'Convenio') )pagos
union
select id,Recibido,(case when tipo = 'Legal' then Concepto
							   when tipo = 'Extra' then Concepto
							  
							   else ISNULL((select nombre from Credito inner join ConveniosSac on Credito.id = ConveniosSac.idCredito where ConveniosSac.id = pagos.idCredito),0) 		end) as nombre,idCredito,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja from
(select Ticket.Id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.PagoNormal,Ticket.Intereses,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id  where  ticket.idcredito = (select id from ConveniosSac where idCredito ='" & idCredito & "') and TipoDoc = (select id from tipodoc where nombre = 'Cancelación de Convenio') )pagos
order by Fecha,Hora asc
end
else if not exists(select * from ConveniosSac where idCredito = '" & idCredito & "')
begin
select id,Recibido,(case when tipo = 'Legal' then Concepto
							   when tipo = 'Extra' then Concepto
							  
							   else ISNULL((select nombre from Credito where id = pagos.idCredito),0) 		end) as nombre,idCredito,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja from
(select Ticket.Id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.PagoNormal,Ticket.Intereses,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id  where  ticket.idcredito = '" & idCredito & "'  and (tipodoc = (select id from tipodoc where nombre = 'Pago') or  tipodoc = (select id from tipodoc where nombre = 'Liquidación Insoluto') or tipodoc = (select id from tipodoc where nombre = 'Liquidación Renovación') or tipodoc = (select id from tipodoc where nombre = 'Liquidación Normal') or  tipodoc = (select id from tipodoc where nombre = 'Renovación Insoluto')))pagos order by Fecha,Hora asc
end
"

        comandoTicket = New SqlCommand
        comandoTicket.Connection = conexionempresa
        comandoTicket.CommandText = consulta
        readerTicket = comandoTicket.ExecuteReader
        If readerTicket.HasRows Then
            While readerTicket.Read
                Dim liItem As New TreeListNode(readerTicket("id"))
                With liItem.SubItems
                    .Add(readerTicket("idcredito"))
                    .Add(readerTicket("nombre"))
                    .Add(readerTicket("pagonormal"))
                    .Add(readerTicket("Intereses"))
                    .Add(readerTicket("total"))
                    .Add(readerTicket("Fecha"))
                    .Add(readerTicket("Hora").ToString)
                    .Add(readerTicket("Tipo"))
                    .Add(readerTicket("Caja"))
                End With

                Dim COMANDOdetalle As SqlCommand
                Dim consultaDetalle As String
                Dim readerDetalle As SqlDataReader
                Select Case readerTicket("Tipo")
                    Case "Pago"
                        consultaDetalle = "select concat(ticketdetalle.concepto,' de ','Pago ', calendarionormal.NPago) as pago,pagonormal,intereses,ticketdetalle.monto from ticketdetalle inner join calendarionormal on ticketdetalle.idpago = calendarionormal.idpago where  idTicket = '" & readerTicket("id") & "'"
                        COMANDOdetalle = New SqlCommand
                        COMANDOdetalle.Connection = conexionempresa
                        COMANDOdetalle.CommandText = consultaDetalle
                        readerDetalle = COMANDOdetalle.ExecuteReader
                        If readerDetalle.HasRows Then
                            While readerDetalle.Read
                                Me._addSubItems(liItem.Nodes.Add(readerDetalle("pago")), readerDetalle("pagonormal"), readerDetalle("intereses"), readerDetalle("monto"))
                            End While
                        End If
                       ' TreeListView1.Nodes.Add(liItem)
                    Case "Convenio"
                        consultaDetalle = "select concat(ticketdetalle.concepto,' de ','Pago ', calendarioconveniossac.NPago) as pago,pagonormal,intereses,ticketdetalle.monto from ticketdetalle inner join calendarioconveniossac on ticketdetalle.idpago = calendarioconveniossac.idpago where  idTicket = '" & readerTicket("id") & "'"
                        COMANDOdetalle = New SqlCommand
                        COMANDOdetalle.Connection = conexionempresa
                        COMANDOdetalle.CommandText = consultaDetalle
                        readerDetalle = COMANDOdetalle.ExecuteReader
                        If readerDetalle.HasRows Then
                            While readerDetalle.Read
                                Me._addSubItems(liItem.Nodes.Add(readerDetalle("pago")), readerDetalle("pagonormal"), readerDetalle("intereses"), readerDetalle("monto"))
                            End While
                        End If
                       ' TreeListView1.Nodes.Add(liItem)
                    Case "Apertura"
                        ' TreeListView1.Nodes.Add(liItem)
                    Case "Renovación Insoluto"
                        consultaDetalle = "select concat(ticketdetalle.concepto,' de ','Pago ', calendarionormal.NPago) as pago,pagonormal,intereses,ticketdetalle.monto from ticketdetalle inner join calendarionormal on ticketdetalle.idpago = calendarionormal.idpago where  idTicket = '" & readerTicket("id") & "'"
                        COMANDOdetalle = New SqlCommand
                        COMANDOdetalle.Connection = conexionempresa
                        COMANDOdetalle.CommandText = consultaDetalle
                        readerDetalle = COMANDOdetalle.ExecuteReader
                        If readerDetalle.HasRows Then
                            While readerDetalle.Read
                                Me._addSubItems(liItem.Nodes.Add(readerDetalle("pago")), readerDetalle("pagonormal"), readerDetalle("intereses"), readerDetalle("monto"))
                            End While
                        End If
                    Case "Liquidación Insoluto"
                        consultaDetalle = "select concat(ticketdetalle.concepto,' de ','Pago ', calendarionormal.NPago) as pago,pagonormal,intereses,ticketdetalle.monto from ticketdetalle inner join calendarionormal on ticketdetalle.idpago = calendarionormal.idpago where  idTicket = '" & readerTicket("id") & "'"
                        COMANDOdetalle = New SqlCommand
                        COMANDOdetalle.Connection = conexionempresa
                        COMANDOdetalle.CommandText = consultaDetalle
                        readerDetalle = COMANDOdetalle.ExecuteReader
                        If readerDetalle.HasRows Then
                            While readerDetalle.Read
                                Me._addSubItems(liItem.Nodes.Add(readerDetalle("pago")), readerDetalle("pagonormal"), readerDetalle("intereses"), readerDetalle("monto"))
                            End While
                        End If
                End Select
                TreeListView1.Nodes.Add(liItem)
                'consultaDetalle = "select concat(ticketdetalle.concepto,' de ','Pago ', calendarionormal.NPago) as pago,pagonormal,intereses,ticketdetalle.monto from ticketdetalle inner join calendarionormal on ticketdetalle.idpago = calendarionormal.idpago where  idTicket = '" & readerTicket("id") & "'"

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
        Cargando.MonoFlat_Label1.Text = "Consultando Gestiones"
        BackgroundGestiones.RunWorkerAsync()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        If bloqueado Then

        Else
            For i As Integer = 51 To 499 Step 10
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

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        AgregarGestionCredito.idCredito = idCredito
        AgregarGestionCredito.Show()
    End Sub

    Private Sub btnGenerarCalendario_Click(sender As Object, e As EventArgs) Handles btnGenerarCalendario.Click
        DocumentosCredito.idCredito = idCredito
        DocumentosCredito.Show()
    End Sub

    Private Sub BackgroundGestiones_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundGestiones.DoWork
        Dim consultaGestiones As String
        iniciarconexionempresa()
        consultaGestiones = "select id,Fecha,Concepto from gestionescredito where idcredito = '" & idCredito & "'"
        adapterGestiones = New SqlDataAdapter(consultaGestiones, conexionempresa)
        dataGestiones = New Data.DataTable
        adapterGestiones.Fill(dataGestiones)
    End Sub

    Private Sub BackgroundActualizaciones_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundActualizaciones.DoWork
        iniciarconexionempresa()
        Dim consultaActualizaciones As String
        consultaActualizaciones = "select Fecha,Hora,Campo,ValorAnterior,NuevoValor,Motivo from actualizacionescredito where idCredito = '" & idCredito & "'"
        adapterActualizaciones = New SqlDataAdapter(consultaActualizaciones, conexionempresa)
        dataActualizaciones = New Data.DataTable
        adapterActualizaciones.Fill(dataActualizaciones)
    End Sub

    Private Sub BackgroundGestiones_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundGestiones.RunWorkerCompleted
        dtGestiones.DataSource = dataGestiones
        Cargando.MonoFlat_Label1.Text = "Consultando Actualizaciones"
        BackgroundActualizaciones.RunWorkerAsync()

    End Sub

    Private Sub BackgroundActualizaciones_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundActualizaciones.RunWorkerCompleted
        dtActualizaciones.DataSource = dataActualizaciones
        If estado = "C" Then
            btn_convenio.Enabled = True
        ElseIf estado = "R" Then
            btn_convenio.Enabled = True
            btn_convenio.ButtonText = "Imprimir Reestructura"
        Else
            btn_convenio.Enabled = False
        End If
        Cargando.MonoFlat_Label1.Text = "Cargando Comportamiento"

        'Cargando.Close()
        BackgroundComportamiento.RunWorkerAsync()

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        ActInformacionCredito.idCredito = idCredito
        ActInformacionCredito.Show()
    End Sub

    Private Sub btn_convenio_Click(sender As Object, e As EventArgs) Handles btn_convenio.Click
        Select Case estado
            Case "C"
                ImprimirConvenio.idCredito = idCredito
                ImprimirConvenio.Show()
            Case "R"
                ImprimirReestructura.idCredito = idCredito
                ImprimirReestructura.Show()
        End Select
    End Sub

    Private Sub BackgroundComportamiento_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundComportamiento.DoWork
        iniciarconexionempresa()
        TreeListView2.Nodes.Clear()



        Dim comandoTicket As SqlCommand
        Dim consulta As String
        Dim readerTicket As SqlDataReader



        consulta = "
if  exists(select * from ConveniosSac where idCredito = '" & idCredito & "' and estado = 'A')
begin
select 'Normal' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,FechaUltimoPago from CalendarioNormal where id_credito = '" & idCredito & "' and Estado = 'L'
union
select 'Creación de convenio' as TipoDePago,'','',DeudaCredito,Moratorios,'',TotalDeuda,Fecha,'' from ConveniosSac where idCredito = '" & idCredito & "'
union
select 'Convenio' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,Fecha from CalendarioConveniosSac where idConvenio = (select id from ConveniosSac where idCredito ='" & idCredito & "')

order by FechaPago asc
end
else if exists(select * from ticket where idcredito = '" & idCredito & "' and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio'))
select * from
(select 'Normal' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,FechaUltimoPago from CalendarioNormal where id_credito = '" & idCredito & "' and Estado = 'L' and fechaultimopago <= (select fecha from conveniossac where idcredito = '" & idCredito & "')
union
select 'Creación de convenio' as TipoDePago,'','',DeudaCredito,Moratorios,'',TotalDeuda,Fecha,'' from ConveniosSac where idCredito = '" & idCredito & "'
union
select 'Convenio' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,Fecha from CalendarioConveniosSac where idConvenio = (select id from ConveniosSac where idCredito = '" & idCredito & "') and abonado <> 0 and fecha <= (select fecha from ticket where idcredito = '" & idCredito & "' and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio'))
union
select 'Cancelación de convenio' as TipoDePago,'','',PagoNormal,Intereses,'',Total,Fecha,'' from Ticket where idcredito = '" & idCredito & "' and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio')
union
	
select 'Normal' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,FechaUltimoPago from CalendarioNormal where id_credito = '" & idCredito & "' and 1= case when exists(select id from ReestructurasSac where idCredito = '" & idCredito & "')  and idpago in (select idPago from CalendarioNormal where id_credito = '" & idCredito & "' and (fechaultimopago >= (select fecha from ticket where idcredito = '" & idCredito & "' and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio')))) then 1 
when not exists(select id from ReestructurasSac where idCredito = '" & idCredito & "') and idpago in (select idPago from CalendarioNormal where id_credito = '" & idCredito & "' and (fechaultimopago >= (select fecha from ticket where idcredito = '" & idCredito & "' and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio'))) OR FechaUltimoPago = '1900-01-01')  then 1
 end


union

select 'Creación de reestructura' as TipoDePago,'','',DeudaCredito,Moratorios,'',TotalDeuda,Fecha,'' from reestructurassac where idCredito = '" & idCredito & "'
union
select 'Reestructura' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,Fecha from calendarioreestructurassac where idConvenio = (select id from reestructurassac where idCredito = '" & idCredito & "') 
) Comportamiento order by  (case  when idPago in (select idPago from CalendarioNormal where id_credito = '" & idCredito & "' and Estado = 'L' and fechaultimopago <= (select fecha from conveniossac where idcredito = '" & idCredito & "')) then 1   when TipoDePago = 'Creación de convenio' then 2 when TipoDePago = 'Convenio' then 3 when TipoDePago = 'Cancelación de convenio' then 4 when idpago in (select idPago from CalendarioNormal where id_credito = '" & idCredito & "' and (fechaultimopago >= (select fecha from ticket where idcredito = '" & idCredito & "' and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio')) or FechaUltimoPago = '1900-01-01')) then 5 when TipoDePago = 'Creación de reestructura' then 6 when TipoDePago = 'Reestructura' then 7  end )asc

else if not exists(select * from ConveniosSac where idCredito = '" & idCredito & "')
begin
select 'Normal' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,6FechaUltimoPago from CalendarioNormal where id_credito = '" & idCredito & "' 
end
"


        comandoTicket = New SqlCommand
        comandoTicket.Connection = conexionempresa
        comandoTicket.CommandText = consulta
        readerTicket = comandoTicket.ExecuteReader
        If readerTicket.HasRows Then
            While readerTicket.Read
                Dim liItem As New TreeListNode(readerTicket("TipoDePago"))
                With liItem.SubItems
                    .Add(readerTicket("idpago"))

                    .Add(readerTicket("Npago"))
                    .Add(readerTicket("Monto"))
                    .Add(readerTicket("Interes"))
                    .Add(readerTicket("Abonado"))
                    .Add(readerTicket("Pendiente"))
                    .Add(readerTicket("FechaPago"))

                    .Add(readerTicket("FechaUltimoPago"))

                End With
                Select Case readerTicket("TipoDePago")
                    Case "Normal"
                        Dim COMANDOdetalle As SqlCommand
                        Dim consultaDetalle As String
                        Dim readerDetalle As SqlDataReader
                        consultaDetalle = "select Ticket.id,TicketDetalle.Monto,TicketDetalle.PagoNormal,TicketDetalle.Intereses,Ticket.Fecha,Ticket.Hora from TicketDetalle inner join Ticket on TicketDetalle.idTicket =  Ticket.id and TicketDetalle.idPago = '" & readerTicket("idpago") & "' and ticket.tipodoc = 1 order by Ticket.Fecha,Ticket.Hora asc"
                        COMANDOdetalle = New SqlCommand
                        COMANDOdetalle.Connection = conexionempresa
                        COMANDOdetalle.CommandText = consultaDetalle
                        readerDetalle = COMANDOdetalle.ExecuteReader
                        If readerDetalle.HasRows Then
                            While readerDetalle.Read
                                ' Me._addSubItems(liItem.Nodes.Add(readerDetalle("pago")), readerDetalle("pagonormal"), readerDetalle("intereses"), readerDetalle("monto"))
                                Me._addSubItemsDetalle(liItem.Nodes.Add(""), readerDetalle("id"), "", readerDetalle("pagonormal"), readerDetalle("intereses"), "", "", readerDetalle("hora").ToString, "", readerDetalle("fecha"))
                            End While
                        End If
                    Case "Creación de convenio"
                        Dim COMANDOdetalle As SqlCommand
                        Dim consultaDetalle As String
                        Dim readerDetalle As SqlDataReader
                        consultaDetalle = "select idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,FechaUltimoPago from CalendarioNormal where id_credito = '" & idCredito & "' and (Estado = 'V' or Estado = 'P')"
                        COMANDOdetalle = New SqlCommand
                        COMANDOdetalle.Connection = conexionempresa
                        COMANDOdetalle.CommandText = consultaDetalle
                        readerDetalle = COMANDOdetalle.ExecuteReader
                        If readerDetalle.HasRows Then
                            While readerDetalle.Read
                                ' Me._addSubItems(liItem.Nodes.Add(readerDetalle("pago")), readerDetalle("pagonormal"), readerDetalle("intereses"), readerDetalle("monto"))
                                Me._addSubItemsDetalle(liItem.Nodes.Add(""), readerDetalle("idpago"), readerDetalle("Npago"), readerDetalle("monto"), readerDetalle("interes"), readerDetalle("Abonado"), readerDetalle("Pendiente"), "", readerDetalle("FechaPago"), "")
                            End While
                        End If
                    Case "Convenio"
                        Dim COMANDOdetalle As SqlCommand
                        Dim consultaDetalle As String
                        Dim readerDetalle As SqlDataReader
                        consultaDetalle = "select Ticket.id,TicketDetalle.Monto,TicketDetalle.PagoNormal,TicketDetalle.Intereses,Ticket.Fecha,Ticket.Hora from TicketDetalle inner join Ticket on TicketDetalle.idTicket =  Ticket.id and TicketDetalle.idPago = '" & readerTicket("idpago") & "' and ticket.tipodoc = (select id from tipodoc where nombre = 'Convenio') order by Ticket.Fecha,Ticket.Hora asc"
                        COMANDOdetalle = New SqlCommand
                        COMANDOdetalle.Connection = conexionempresa
                        COMANDOdetalle.CommandText = consultaDetalle
                        readerDetalle = COMANDOdetalle.ExecuteReader
                        If readerDetalle.HasRows Then
                            While readerDetalle.Read
                                ' Me._addSubItems(liItem.Nodes.Add(readerDetalle("pago")), readerDetalle("pagonormal"), readerDetalle("intereses"), readerDetalle("monto"))
                                Me._addSubItemsDetalle(liItem.Nodes.Add(""), readerDetalle("id"), "", readerDetalle("pagonormal"), readerDetalle("intereses"), "", "", readerDetalle("hora").ToString, "", readerDetalle("fecha"))
                            End While
                        End If
                End Select

                TreeListView2.Nodes.Add(liItem)
            End While
        End If
    End Sub

    Private Sub _addSubItemsDetalle(ByVal aObj As ContainerListViewObject, ByVal id As Integer, ByVal Npago As String, ByVal pagonormal As Double, ByVal intereses As Double, ByVal Abonado As String, ByVal Pendiente As String, ByVal hora As String, ByVal fechaPago As String, ByVal fecha As String)
        With aObj.SubItems
            .Add(id)
            .Add(Npago)
            .Add(pagonormal)
            .Add(intereses)
            .Add(Abonado)
            .Add(Pendiente)
            .Add(fechaPago)
            .Add(fecha)
            .Add(hora)
        End With
    End Sub

    Private Sub BackgroundComportamiento_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundComportamiento.RunWorkerCompleted
        Cargando.Close
    End Sub
End Class