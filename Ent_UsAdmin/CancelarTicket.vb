Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class CancelarTicket
    Public Autorizado As Boolean
    Dim cnsEmpresaMysql As String
    Public idTicket As String
    Public idNotificacion As String
    Dim localRemoto As String
    Dim ipLocalTicket As String
    Dim nombreRemoto As String
    Dim ipRemotoTicket As String
    Dim bdTicket As String
    Dim estadoNotificacion As String
    Dim tipoDoc As String
    Dim nCargando As Cargando
    Dim conectado As Boolean
    Private Sub CancelarTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtComentario.BackColor = Me.BackColor
        nCargando = New Cargando
        nCargando.Show()
        nCargando.MonoFlat_Label1.Text = "Consultando"
        nCargando.TopMost = True
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim conexionLogin As MySqlConnection
        conexionLogin = New MySqlConnection()
        conexionLogin.ConnectionString = "server=www.prestamosconfia.com;user id=ajas;pwd=123456;port=3306;database=USRS"
        conexionLogin.Open()

        Dim comandoComentarioMysql As MySqlCommand
        Dim consultaComentarioMysql As String
        Dim readerComentarioMysql As MySqlDataReader
        consultaComentarioMysql = "select Comentario,Empresa from Notificaciones where id = '" & idNotificacion & "'"
        comandoComentarioMysql = New MySqlCommand
        comandoComentarioMysql.Connection = conexionLogin
        comandoComentarioMysql.CommandText = consultaComentarioMysql
        readerComentarioMysql = comandoComentarioMysql.ExecuteReader
        If readerComentarioMysql.HasRows Then
            While readerComentarioMysql.Read
                txtComentario.Text = readerComentarioMysql("comentario")
                nombreRemoto = readerComentarioMysql("Empresa")
            End While
        End If
        readerComentarioMysql.Close()

        Dim comandoEmpresaMysql As MySqlCommand
        Dim consultaEmpresaMysql As String
        Dim readerEmpresaMysql As MySqlDataReader
        consultaEmpresaMysql = "select IP,BD,IPREMOTA from Empresas where Nombre = '" & nombreRemoto & "'"
        comandoEmpresaMysql = New MySqlCommand
        comandoEmpresaMysql.Connection = conexionLogin
        comandoEmpresaMysql.CommandText = consultaEmpresaMysql
        readerEmpresaMysql = comandoEmpresaMysql.ExecuteReader
        If readerEmpresaMysql.HasRows Then
            While readerEmpresaMysql.Read
                ipLocalTicket = readerEmpresaMysql("IP")
                bdTicket = readerEmpresaMysql("BD")
                ipRemotoTicket = readerEmpresaMysql("IPREMOTA")

            End While
        End If

        readerEmpresaMysql.Close()




        conexionLogin.Close()

        If ProbarConexionEmpresa(ipLocalTicket, bdTicket) Then
            conectado = True
            cnsEmpresaMysql = iniciarconexionRMysql(ipLocalTicket, bdTicket)
        Else
            conectado = ProbarConexionEmpresa(ipRemotoTicket, bdTicket)
            If conectado = True Then
                cnsEmpresaMysql = iniciarconexionRMysql(ipRemotoTicket, bdTicket)
            Else

            End If

        End If


        If conectado Then
        Else

        End If

        Dim conex As SqlConnection
        conex = New SqlConnection(cnsEmpresaMysql)
        conex.Open()

        Dim comandoTicket As SqlCommand
        Dim consultaTicket As String
        Dim readerTicket As SqlDataReader
        consultaTicket = "select *,case tick.nombredoc when 'Pago' then(select nombre from Credito where id = tick.idCredito)
when 'Apertura' then
(select nombre from Credito where id = tick.idCredito)
when 'Extra' then
tick.Concepto
when 'Convenio' then
(select credito.nombre from Credito inner join ConveniosSac on Credito.id = ConveniosSac.idCredito where ConveniosSac.id = tick.idCredito)
when 'Legal' then
(select nombre from Legales where id = tick.idCredito)
when 'Refrendo' then
(select nombre from Empeños where id = Tick.idCredito)
when 'Comisión por avalúo' then
(select nombre from Empeños where id = Tick.idCredito)
when 'Desempeño' then
(select nombre from Empeños where id = Tick.idCredito)
when 'Cancelación de Convenio' then 
(select nombre from Credito where id = tick.idCredito)
when 'Reestructura' then
(select Credito.Nombre from Credito inner join ReestructurasSac on Credito.id = ReestructurasSac.idCredito where ReestructurasSac.id = tick.idCredito)

 end as NombreCliente from 
(select Ticket.*,TipoDoc.Nombre as nombredoc from ticket inner join TipoDoc on Ticket.TipoDoc = TipoDoc.id where ticket.id = '" & idTicket & "')tick"
        comandoTicket = New SqlCommand
        comandoTicket.Connection = conex
        comandoTicket.CommandText = consultaTicket
        readerTicket = comandoTicket.ExecuteReader
        While readerTicket.Read
            lblNombre.Text = readerTicket("NombreCliente")
            lblMonto.Text = FormatCurrency(readerTicket("Total"), 2)
            lblNoTicket.Text = idTicket

            tipoDoc = readerTicket("NombreDoc")
        End While
        readerTicket.Close()

        Dim comandoDetalle As SqlCommand
        Dim consultaDetalle As String
        Dim adapterDetalle As SqlDataAdapter
        Dim dataDetalle As DataTable

        Select Case tipoDoc
            Case "Pago"
                consultaDetalle = "select concat(ticketdetalle.concepto,' de ','Pago ', calendarionormal.NPago) as pago,pagonormal,intereses,ticketdetalle.monto from ticketdetalle inner join calendarionormal on ticketdetalle.idpago = calendarionormal.idpago where  idTicket = '" & idTicket & "'"

                adapterDetalle = New SqlDataAdapter(consultaDetalle, conex)
                dataDetalle = New DataTable
                adapterDetalle.Fill(dataDetalle)

                dtDetalle.DataSource = dataDetalle

            Case "Convenio"
                consultaDetalle = "select concat(ticketdetalle.concepto,' de ','Pago ', calendarioconveniossac.NPago) as pago,pagonormal,intereses,ticketdetalle.monto from ticketdetalle inner join calendarioconveniossac on ticketdetalle.idpago = calendarioconveniossac.idpago where  idTicket = '" & idTicket & "'"

                adapterDetalle = New SqlDataAdapter(consultaDetalle, conex)
                dataDetalle = New DataTable
                adapterDetalle.Fill(dataDetalle)

                dtDetalle.DataSource = dataDetalle

                       ' TreeListView1.Nodes.Add(liItem)
            Case "Apertura"

                adapterDetalle = New SqlDataAdapter(consultaDetalle, conex)
                dataDetalle = New DataTable
                adapterDetalle.Fill(dataDetalle)

                dtDetalle.DataSource = dataDetalle

                        ' TreeListView1.Nodes.Add(liItem)
            Case "Renovación Insoluto"
                consultaDetalle = "select concat(ticketdetalle.concepto,' de ','Pago ', calendarionormal.NPago) as pago,pagonormal,intereses,ticketdetalle.monto from ticketdetalle inner join calendarionormal on ticketdetalle.idpago = calendarionormal.idpago where  idTicket = '" & idTicket & "'"

                adapterDetalle = New SqlDataAdapter(consultaDetalle, conex)
                dataDetalle = New DataTable
                adapterDetalle.Fill(dataDetalle)

                dtDetalle.DataSource = dataDetalle

            Case "Liquidación Insoluto"
                consultaDetalle = "select concat(ticketdetalle.concepto,' de ','Pago ', calendarionormal.NPago) as pago,pagonormal,intereses,ticketdetalle.monto from ticketdetalle inner join calendarionormal on ticketdetalle.idpago = calendarionormal.idpago where  idTicket = '" & idTicket & "'"

                adapterDetalle = New SqlDataAdapter(consultaDetalle, conex)
                dataDetalle = New DataTable
                adapterDetalle.Fill(dataDetalle)

                dtDetalle.DataSource = dataDetalle

            Case "Cancelación de Convenio"
                consultaDetalle = "select concat(ticketdetalle.concepto,' de ','Pago ', calendarionormal.NPago) as pago,pagonormal,intereses,ticketdetalle.monto from ticketdetalle inner join calendarionormal on ticketdetalle.idpago = calendarionormal.idpago where  idTicket = '" & idTicket & "'"

                adapterDetalle = New SqlDataAdapter(consultaDetalle, conex)
                dataDetalle = New DataTable
                adapterDetalle.Fill(dataDetalle)

                dtDetalle.DataSource = dataDetalle

            Case "Reestructura"
                consultaDetalle = "select concat(ticketdetalle.concepto,' de ','Pago ', calendarioreestructurassac.NPago) as pago,pagonormal,intereses,ticketdetalle.monto from ticketdetalle inner join calendarioreestructurassac on ticketdetalle.idpago = calendarioreestructurassac.idpago where  idTicket = '" & idTicket & "'"

                adapterDetalle = New SqlDataAdapter(consultaDetalle, conex)
                dataDetalle = New DataTable
                adapterDetalle.Fill(dataDetalle)

                dtDetalle.DataSource = dataDetalle

            Case "Liquidación Promoción 90%"
                consultaDetalle = "select concat(ticketdetalle.concepto,' de ','Pago ', calendarionormal.NPago) as pago,pagonormal,intereses,ticketdetalle.monto from ticketdetalle inner join calendarionormal on ticketdetalle.idpago = calendarionormal.idpago where  idTicket = '" & idTicket & "'"

                adapterDetalle = New SqlDataAdapter(consultaDetalle, conex)
                dataDetalle = New DataTable
                adapterDetalle.Fill(dataDetalle)

                dtDetalle.DataSource = dataDetalle

            Case "Liquidación Convenio 90%"
                consultaDetalle = "select concat(ticketdetalle.concepto,' de ','Pago ', calendarioconveniossac.NPago) as pago,pagonormal,intereses,ticketdetalle.monto from ticketdetalle inner join calendarioconveniossac on ticketdetalle.idpago = calendarioconveniossac.idpago where  idTicket = '" & idTicket & "'"

                adapterDetalle = New SqlDataAdapter(consultaDetalle, conex)
                dataDetalle = New DataTable
                adapterDetalle.Fill(dataDetalle)

                dtDetalle.DataSource = dataDetalle

        End Select




    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        nCargando.Close()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        AutorizacionNotificacion.tipoAutorizacion = "SacCancelarTicket"
        AutorizacionNotificacion.ShowDialog()
        If Autorizado Then
            estadoNotificacion = "A"
            nCargando = New Cargando
            nCargando.Show()
            nCargando.MonoFlat_Label1.Text = "Actualizando notificación"
            BackgroundActNotificacion.RunWorkerAsync()
        Else
            MessageBox.Show("No fue autorizado")
        End If
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        AutorizacionNotificacion.tipoAutorizacion = "SacCancelarTicket"
        AutorizacionNotificacion.ShowDialog()
        If Autorizado Then
            estadoNotificacion = "R"
            nCargando = New Cargando
            nCargando.Show()
            nCargando.MonoFlat_Label1.Text = "Actualizando notificación"
            BackgroundActNotificacion.RunWorkerAsync()
        Else
            MessageBox.Show("No fue autorizado")
        End If
    End Sub

    Private Sub BackgroundActNotificacion_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundActNotificacion.DoWork
        Dim conexionLogin As MySqlConnection
        conexionLogin = New MySqlConnection()
        conexionLogin.ConnectionString = "server=www.prestamosconfia.com;user id=ajas;pwd=123456;port=3306;database=USRS"
        conexionLogin.Open()

        If ProbarConexionEmpresa(ipLocalTicket, bdTicket) Then
            conectado = True
            cnsEmpresaMysql = iniciarconexionRMysql(ipLocalTicket, bdTicket)
        Else
            conectado = ProbarConexionEmpresa(ipRemotoTicket, bdTicket)
            If conectado Then
                cnsEmpresaMysql = iniciarconexionRMysql(ipRemotoTicket, bdTicket)
            Else

            End If

        End If
        Dim conex As SqlConnection
        Try

            conex = New SqlConnection(cnsEmpresaMysql)
            conex.Open()
            conectado = True
        Catch ex As Exception
            conectado = False
        End Try



        If estadoNotificacion = "A" Then
            If conectado Then
                If tipoDoc = "Refrendo" Then
                    Dim comandoFechaUpagoTicket As SqlCommand
                    Dim fechaUpagoTicket As Date
                    Dim consultaUfechaTicket As String
                    consultaUfechaTicket = "select fecha from ticket where id = '" & idTicket & "'"
                    comandoFechaUpagoTicket = New SqlCommand
                    comandoFechaUpagoTicket.CommandText = consultaUfechaTicket
                    comandoFechaUpagoTicket.Connection = conex
                    fechaUpagoTicket = comandoFechaUpagoTicket.ExecuteScalar

                    Dim fechaPosterior As String
                    Dim comandoFechaPosterior As SqlCommand
                    Dim consultaFechaPosterior As String
                    consultaFechaPosterior = "if exists (select top 1 fecha from ticket where fecha > '" & fechaUpagoTicket.Date.ToString("yyyy-MM-dd") & "' and estado = 'A' and tipodoc = (select id from tipodoc where nombre = 'Refrendo') order by fecha desc)
                                           begin
                                           select 'Sí hay' as ss
                                           end
                                           else 
                                           begin
                                           select 'No hay' as ss
                                           end"

                    comandoFechaPosterior = New SqlCommand
                    comandoFechaPosterior.Connection = conex
                    comandoFechaPosterior.CommandText = consultaFechaPosterior
                    fechaPosterior = comandoFechaPosterior.ExecuteScalar

                    If fechaPosterior = "No hay" Then
                        Dim fechaUpago As Date
                        Dim comandoFechaUpago As SqlCommand
                        Dim consultaFechaUpago As String
                        consultaFechaUpago = "if exists (select top 1 fecha from ticket where fecha < '" & fechaUpagoTicket.Date.ToString("yyyy-MM-dd") & "' and estado = 'A' and tipodoc = (select id from tipodoc where nombre = 'Refrendo') order by fecha desc)
                                           begin
                                           select top 1 fecha from ticket where fecha < '" & fechaUpagoTicket.Date.ToString("yyyy-MM-dd") & "' and estado = 'A' and tipodoc = (select id from tipodoc where nombre = 'Refrendo') order by fecha desc
                                           end
                                           else 
                                           begin
                                           select '1900-01-01' as fecha
                                           end"
                        comandoFechaUpago = New SqlCommand
                        comandoFechaUpago.Connection = conex
                        comandoFechaUpago.CommandText = consultaFechaUpago
                        fechaUpago = comandoFechaUpago.ExecuteScalar

                        Dim comandoConsultaTicketDetalle As SqlCommand
                        Dim consultaTicketDetalle As String
                        Dim readerTicketDetalle As SqlDataReader
                        consultaTicketDetalle = "CancelarTicket"
                        comandoConsultaTicketDetalle = New SqlCommand
                        comandoConsultaTicketDetalle.Connection = conex
                        comandoConsultaTicketDetalle.CommandText = consultaTicketDetalle
                        comandoConsultaTicketDetalle.CommandType = CommandType.StoredProcedure
                        comandoConsultaTicketDetalle.Parameters.AddWithValue("idTicket", idTicket)
                        comandoConsultaTicketDetalle.Parameters.AddWithValue("Tipo", tipoDoc)
                        comandoConsultaTicketDetalle.Parameters.AddWithValue("FechaUPago", fechaUpago.Date.ToString("yyyy-MM-dd"))
                        comandoConsultaTicketDetalle.ExecuteNonQuery()
                    Else
                        MessageBox.Show("No se puede cancelar éste ticket, existen tickets activos con fechas posteriores")
                    End If



                ElseIf tipoDoc = "Desempeño" Then
                    Dim comandoFechaUpagoTicket As SqlCommand
                    Dim fechaUpagoTicket As Date
                    Dim consultaUfechaTicket As String
                    consultaUfechaTicket = "select fecha from ticket where id = '" & idTicket & "'"
                    comandoFechaUpagoTicket = New SqlCommand
                    comandoFechaUpagoTicket.CommandText = consultaUfechaTicket
                    comandoFechaUpagoTicket.Connection = conex
                    fechaUpagoTicket = comandoFechaUpagoTicket.ExecuteScalar




                    Dim fechaUpago As Date
                    Dim comandoFechaUpago As SqlCommand
                    Dim consultaFechaUpago As String
                    consultaFechaUpago = "if exists (select top 1 fecha from ticket where fecha < '" & fechaUpagoTicket.Date.ToString("yyyy-MM-dd") & "' and estado = 'A' and tipodoc = (select id from tipodoc where nombre = 'Refrendo') order by fecha desc)
                                           begin
                                           select top 1 fecha from ticket where fecha < '" & fechaUpagoTicket.Date.ToString("yyyy-MM-dd") & "' and estado = 'A' and tipodoc = (select id from tipodoc where nombre = 'Refrendo') order by fecha desc
                                           end
                                           else 
                                           begin
                                           select '1900-01-01' as fecha
                                           end"
                    comandoFechaUpago = New SqlCommand
                    comandoFechaUpago.Connection = conex
                    comandoFechaUpago.CommandText = consultaFechaUpago
                    fechaUpago = comandoFechaUpago.ExecuteScalar

                    Dim comandoConsultaTicketDetalle As SqlCommand
                    Dim consultaTicketDetalle As String
                    Dim readerTicketDetalle As SqlDataReader
                    consultaTicketDetalle = "CancelarTicket"
                    comandoConsultaTicketDetalle = New SqlCommand
                    comandoConsultaTicketDetalle.Connection = conex
                    comandoConsultaTicketDetalle.CommandText = consultaTicketDetalle
                    comandoConsultaTicketDetalle.CommandType = CommandType.StoredProcedure
                    comandoConsultaTicketDetalle.Parameters.AddWithValue("idTicket", idTicket)
                    comandoConsultaTicketDetalle.Parameters.AddWithValue("Tipo", tipoDoc)
                    comandoConsultaTicketDetalle.Parameters.AddWithValue("FechaUPago", fechaUpago.Date.ToString("yyyy-MM-dd"))
                    comandoConsultaTicketDetalle.ExecuteNonQuery()


                ElseIf tipoDoc = "Comisión por avalúo" Then
                    Dim comandoFechaUpagoTicket As SqlCommand
                    Dim fechaUpagoTicket As Date
                    Dim consultaUfechaTicket As String
                    consultaUfechaTicket = "select fecha from ticket where id = '" & idTicket & "'"
                    comandoFechaUpagoTicket = New SqlCommand
                    comandoFechaUpagoTicket.CommandText = consultaUfechaTicket
                    comandoFechaUpagoTicket.Connection = conex
                    fechaUpagoTicket = comandoFechaUpagoTicket.ExecuteScalar

                    Dim fechaPosterior As String
                    Dim comandoFechaPosterior As SqlCommand
                    Dim consultaFechaPosterior As String
                    consultaFechaPosterior = "if exists (select top 1 fecha from ticket where fecha >= '" & fechaUpagoTicket.Date.ToString("yyyy-MM-dd") & "' and estado = 'A' and tipodoc = (select id from tipodoc where nombre = 'Refrendo') order by fecha desc)
                                           begin
                                           select 'Sí hay' as ss
                                           end
                                           else 
                                           begin
                                           select 'No hay' as ss
                                           end"

                    comandoFechaPosterior = New SqlCommand
                    comandoFechaPosterior.Connection = conex
                    comandoFechaPosterior.CommandText = consultaFechaPosterior
                    fechaPosterior = comandoFechaPosterior.ExecuteScalar

                    If fechaPosterior = "No hay" Then
                        Dim fechaUpago As Date
                        Dim comandoFechaUpago As SqlCommand
                        Dim consultaFechaUpago As String
                        consultaFechaUpago = "if exists (select top 1 fecha from ticket where fecha < '" & fechaUpagoTicket.Date.ToString("yyyy-MM-dd") & "' and estado = 'A' and tipodoc = (select id from tipodoc where nombre = 'Refrendo') order by fecha desc)
                                           begin
                                           select top 1 fecha from ticket where fecha < '" & fechaUpagoTicket.Date.ToString("yyyy-MM-dd") & "' and estado = 'A' and tipodoc = (select id from tipodoc where nombre = 'Refrendo') order by fecha desc
                                           end
                                           else 
                                           begin
                                           select '1900-01-01' as fecha
                                           end"
                        comandoFechaUpago = New SqlCommand
                        comandoFechaUpago.Connection = conex
                        comandoFechaUpago.CommandText = consultaFechaUpago
                        fechaUpago = comandoFechaUpago.ExecuteScalar

                        Dim comandoConsultaTicketDetalle As SqlCommand
                        Dim consultaTicketDetalle As String
                        Dim readerTicketDetalle As SqlDataReader
                        consultaTicketDetalle = "CancelarTicket"
                        comandoConsultaTicketDetalle = New SqlCommand
                        comandoConsultaTicketDetalle.Connection = conex
                        comandoConsultaTicketDetalle.CommandText = consultaTicketDetalle
                        comandoConsultaTicketDetalle.CommandType = CommandType.StoredProcedure
                        comandoConsultaTicketDetalle.Parameters.AddWithValue("idTicket", idTicket)
                        comandoConsultaTicketDetalle.Parameters.AddWithValue("Tipo", tipoDoc)
                        comandoConsultaTicketDetalle.Parameters.AddWithValue("FechaUPago", fechaUpago.Date.ToString("yyyy-MM-dd"))
                        comandoConsultaTicketDetalle.ExecuteNonQuery()
                    Else
                        MessageBox.Show("No se puede cancelar éste ticket, existen tickets activos con fechas posteriores")
                    End If
                ElseIf tipoDoc = "Promesa de pago" Then
                    Dim comandoFechaUpagoTicket As SqlCommand
                    Dim fechaUpagoTicket As Date
                    Dim consultaUfechaTicket As String
                    consultaUfechaTicket = "select fecha from ticket where id = '" & idTicket & "'"
                    comandoFechaUpagoTicket = New SqlCommand
                    comandoFechaUpagoTicket.CommandText = consultaUfechaTicket
                    comandoFechaUpagoTicket.Connection = conex
                    fechaUpagoTicket = comandoFechaUpagoTicket.ExecuteScalar

                    Dim fechaPosterior As String
                    Dim comandoFechaPosterior As SqlCommand
                    Dim consultaFechaPosterior As String
                    consultaFechaPosterior = "if exists (select top 1 fecha from ticket where fecha > '" & fechaUpagoTicket.Date.ToString("yyyy-MM-dd") & "' and estado = 'A' and tipodoc = (select id from tipodoc where nombre = 'Promesa de pago') order by fecha desc)
                                           begin
                                           select 'Sí hay' as ss
                                           end
                                           else 
                                           begin
                                           select 'No hay' as ss
                                           end"

                    comandoFechaPosterior = New SqlCommand
                    comandoFechaPosterior.Connection = conex
                    comandoFechaPosterior.CommandText = consultaFechaPosterior
                    fechaPosterior = comandoFechaPosterior.ExecuteScalar
                    If fechaPosterior = "No hay" Then
                        Dim fechaUpago As Date
                        Dim comandoFechaUpago As SqlCommand
                        Dim consultaFechaUpago As String
                        consultaFechaUpago = "if exists (select top 1 fecha from ticket where fecha < '" & fechaUpagoTicket.Date.ToString("yyyy-MM-dd") & "' and estado = 'A' and tipodoc = (select id from tipodoc where nombre = 'Promesa de pago') order by fecha desc)
                                           begin
                                           select top 1 fecha from ticket where fecha < '" & fechaUpagoTicket.Date.ToString("yyyy-MM-dd") & "' and estado = 'A' and tipodoc = (select id from tipodoc where nombre = 'Promesa de pago') order by fecha desc
                                           end
                                           else 
                                           begin
                                           select '1900-01-01' as fecha
                                           end"
                        comandoFechaUpago = New SqlCommand
                        comandoFechaUpago.Connection = conex
                        comandoFechaUpago.CommandText = consultaFechaUpago
                        fechaUpago = comandoFechaUpago.ExecuteScalar

                        Dim comandoConsultaTicketDetalle As SqlCommand
                        Dim consultaTicketDetalle As String
                        Dim readerTicketDetalle As SqlDataReader
                        consultaTicketDetalle = "CancelarTicket"
                        comandoConsultaTicketDetalle = New SqlCommand
                        comandoConsultaTicketDetalle.Connection = conex
                        comandoConsultaTicketDetalle.CommandText = consultaTicketDetalle
                        comandoConsultaTicketDetalle.CommandType = CommandType.StoredProcedure
                        comandoConsultaTicketDetalle.Parameters.AddWithValue("idTicket", idTicket)
                        comandoConsultaTicketDetalle.Parameters.AddWithValue("Tipo", tipoDoc)
                        comandoConsultaTicketDetalle.Parameters.AddWithValue("FechaUPago", fechaUpago.Date.ToString("yyyy-MM-dd"))
                        comandoConsultaTicketDetalle.ExecuteNonQuery()
                    Else
                        MessageBox.Show("No se puede cancelar éste ticket, existen tickets activos con fechas posteriores")
                    End If

                Else



                    Dim comandoConsultaTicketDetalle As SqlCommand
                    Dim consultaTicketDetalle As String
                    Dim readerTicketDetalle As SqlDataReader
                    consultaTicketDetalle = "CancelarTicket"
                    comandoConsultaTicketDetalle = New SqlCommand
                    comandoConsultaTicketDetalle.Connection = conex
                    comandoConsultaTicketDetalle.CommandText = consultaTicketDetalle
                    comandoConsultaTicketDetalle.CommandType = CommandType.StoredProcedure
                    comandoConsultaTicketDetalle.Parameters.AddWithValue("idTicket", idTicket)
                    comandoConsultaTicketDetalle.Parameters.AddWithValue("Tipo", tipoDoc)
                    comandoConsultaTicketDetalle.Parameters.AddWithValue("FechaUPago", "")
                    comandoConsultaTicketDetalle.ExecuteNonQuery()

                End If
                Dim comandoComentarioMysql As MySqlCommand
                Dim consultaComentarioMysql As String
                Dim readerComentarioMysql As MySqlDataReader
                consultaComentarioMysql = "update Notificaciones set Aplicado=1, FechaAplicacion= '" & Date.Now.ToString("yyyy-MM-dd") & "',HoraAplicacion='" & Date.Now.ToString("HH:mm:ss") & "',ComentarioUsuarioDestino='" & txtAddComentario.Text & "',Estado = '" & estadoNotificacion & "' where id = '" & idNotificacion & "'"
                comandoComentarioMysql = New MySqlCommand
                comandoComentarioMysql.Connection = conexionLogin
                comandoComentarioMysql.CommandText = consultaComentarioMysql
                comandoComentarioMysql.ExecuteNonQuery()

            Else
                MessageBox.Show("Ha habido un error, inténtelo de nuevo")
            End If

        Else
            Dim comandoComentarioMysql As MySqlCommand
            Dim consultaComentarioMysql As String
            Dim readerComentarioMysql As MySqlDataReader
            consultaComentarioMysql = "update Notificaciones set Aplicado = 1, FechaAplicacion= '" & Date.Now.ToString("yyyy-MM-dd") & "',HoraAplicacion='" & Date.Now.ToString("HH:mm:ss") & "',ComentarioUsuarioDestino='" & txtAddComentario.Text & "',Estado = '" & estadoNotificacion & "' where id = '" & idNotificacion & "'"
            comandoComentarioMysql = New MySqlCommand
            comandoComentarioMysql.Connection = conexionLogin
            comandoComentarioMysql.CommandText = consultaComentarioMysql
            comandoComentarioMysql.ExecuteNonQuery()
        End If

    End Sub

    Private Sub BackgroundActNotificacion_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundActNotificacion.RunWorkerCompleted
        For i As Integer = CentroDeNotificaciones.FlowLayoutPanel1.Controls.Count - 1 To 0 Step -1
            If TypeOf CentroDeNotificaciones.FlowLayoutPanel1.Controls(i) Is Panel Then
                Dim ctr As Panel = CentroDeNotificaciones.FlowLayoutPanel1.Controls(i)
                If ctr.Name = idNotificacion Then
                    Me.Invoke(Sub()
                                  For a As Integer = frm_adm.array.Count - 1 To 0 Step -1
                                      If ctr.Name = frm_adm.array(a).id Then
                                          frm_adm.array.RemoveAt(a)
                                          frm_adm.CantNotificaciones -= 1
                                          frm_adm.notificaciones.Text = "Tienes " & frm_adm.array.Count & " notificaciones"
                                          frm_adm.notificaciones.Refresh()

                                          Exit For
                                      End If
                                  Next
                              End Sub)

                    CentroDeNotificaciones.FlowLayoutPanel1.Controls.RemoveAt(i)

                End If
            End If
        Next
        nCargando.Close()

    End Sub
End Class