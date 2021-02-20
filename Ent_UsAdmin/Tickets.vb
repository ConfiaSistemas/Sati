Imports System.ComponentModel
Imports System.Data.SqlClient
'Imports ConfiaAdmin.CustomControl

Public Class Tickets
    Dim dataCajas As DataTable
    Dim adapterCajas As SqlDataAdapter
    Public autorizado As Boolean

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        dtdatos.Rows.Clear()

        iniciarconexionempresa()
        Dim comando As SqlCommand

        Dim reader As SqlDataReader
        Dim consulta As String
        Dim fechainserciondesde As String
        fechainserciondesde = dateDesde.Value.ToShortDateString

        Dim fechasqldesde As Date
        fechasqldesde = fechainserciondesde
        fechainserciondesde = Format(fechasqldesde, "yyyy-MM-dd")


        Dim fechainsercionhasta As String
        fechainsercionhasta = dateHasta.Value.ToShortDateString

        Dim fechasqlhasta As Date
        fechasqlhasta = fechainsercionhasta
        fechainsercionhasta = Format(fechasqlhasta, "yyyy-MM-dd")

        Dim cajaConsultar As String

        'consulta = "select Ticket.id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id where Ticket.fecha >= convert(date,'" & fechainserciondesde & "',102) and Ticket.fecha <= convert(date,'" & fechainsercionhasta & "',102)  order by Ticket.fecha,Ticket.hora asc "

        cajaConsultar = CheckedCajas.Text
        consulta = "select Ticket.id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja,ticket.estado from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id where Ticket.fecha >= convert(date,'" & fechainserciondesde & "',102) and Ticket.fecha <= convert(date,'" & fechainsercionhasta & "',102) and ticket.caja in (" & cajaConsultar & ")  order by Ticket.fecha,Ticket.hora asc "

        'End Select


        comando = New SqlCommand
        comando.Connection = conexionempresa
        comando.CommandTimeout = 120
        comando.CommandText = consulta
        reader = comando.ExecuteReader
        Dim recibido As Double = 0
        Dim totalPago As Double = 0
        While reader.Read
            Dim nombrecredito As String

            Select Case reader("tipo")
                Case "Convenio", "Transferencia Convenio", "Depósito Convenio"
                    Dim comandonombre As SqlCommand
                    comandonombre = New SqlCommand

                    Dim consultaNombre As String
                    consultaNombre = "select credito.nombre from conveniossac inner join credito on credito.id = conveniossac.idcredito where conveniossac.id = '" & reader("idcredito") & "'"
                    comandonombre.Connection = conexionempresa
                    comandonombre.CommandText = consultaNombre
                    nombrecredito = comandonombre.ExecuteScalar
                Case "Legal", "Depósito Legal"
                    Dim comandonombre As SqlCommand
                    comandonombre = New SqlCommand

                    Dim consultaNombre As String
                    consultaNombre = "select nombre from legales  where id = '" & reader("idcredito") & "'"
                    comandonombre.Connection = conexionempresa
                    comandonombre.CommandText = consultaNombre
                    nombrecredito = comandonombre.ExecuteScalar
                Case "Refrendo", "Comisión por avalúo", "Desempeño"
                    Dim comandonombre As SqlCommand
                    comandonombre = New SqlCommand

                    Dim consultaNombre As String
                    consultaNombre = "select nombre from empeños  where id = '" & reader("idcredito") & "'"
                    comandonombre.Connection = conexionempresa
                    comandonombre.CommandText = consultaNombre
                    nombrecredito = comandonombre.ExecuteScalar
                Case "Reestructura", "Transferencia Reestructura", "Depósito Reestructura"
                    Dim comandonombre As SqlCommand
                    comandonombre = New SqlCommand

                    Dim consultaNombre As String
                    consultaNombre = "select credito.nombre from reestructurassac inner join credito on credito.id = reestructurassac.idcredito where reestructurassac.id = '" & reader("idcredito") & "'"
                    comandonombre.Connection = conexionempresa
                    comandonombre.CommandText = consultaNombre
                    nombrecredito = comandonombre.ExecuteScalar
                Case "Liquidación Convenio 90%"
                    Dim comandonombre As SqlCommand
                    comandonombre = New SqlCommand

                    Dim consultaNombre As String
                    consultaNombre = "select credito.nombre from conveniossac inner join credito on credito.id = conveniossac.idcredito where conveniossac.id = '" & reader("idcredito") & "'"
                    comandonombre.Connection = conexionempresa
                    comandonombre.CommandText = consultaNombre
                    nombrecredito = comandonombre.ExecuteScalar
                Case Else
                    Dim comandonombre As SqlCommand
                    comandonombre = New SqlCommand

                    Dim consultaNombre As String
                    consultaNombre = "select nombre from credito  where id = '" & reader("idcredito") & "'"
                    comandonombre.Connection = conexionempresa
                    comandonombre.CommandText = consultaNombre
                    nombrecredito = comandonombre.ExecuteScalar
            End Select

            recibido = reader("recibido")
            totalPago = reader("total")
            If recibido > totalPago Then
                Select Case reader("tipo")
                    Case "Convenio"
                        dtdatos.Rows.Add(reader("id"), reader("idcredito"), nombrecredito, FormatCurrency(reader("Total")), Format(reader("Fecha"), "yyyy-MM-dd"), reader("hora"), reader("tipo"), reader("Caja"), reader("Estado"))
                    Case "Legal"

                        dtdatos.Rows.Add(reader("id"), reader("idcredito"), nombrecredito, FormatCurrency(reader("Total")), Format(reader("Fecha"), "yyyy-MM-dd"), reader("hora"), reader("tipo"), reader("Caja"), reader("Estado"))
                    Case "Extra"
                        dtdatos.Rows.Add(reader("id"), reader("idcredito"), reader("concepto"), FormatCurrency(reader("Total")), Format(reader("Fecha"), "yyyy-MM-dd"), reader("hora"), reader("tipo"), reader("Caja"), reader("Estado"))
                    Case Else
                        dtdatos.Rows.Add(reader("id"), reader("idcredito"), nombrecredito, FormatCurrency(reader("Total")), Format(reader("Fecha"), "yyyy-MM-dd"), reader("hora"), reader("tipo"), reader("Caja"), reader("Estado"))
                End Select



            Else
                Select Case reader("tipo")

                    Case "Convenio"
                        dtdatos.Rows.Add(reader("id"), reader("idcredito"), nombrecredito, FormatCurrency(reader("recibido")), Format(reader("Fecha"), "yyyy-MM-dd"), reader("hora"), reader("tipo"), reader("Caja"), reader("Estado"))
                    Case "Legal"

                        dtdatos.Rows.Add(reader("id"), reader("idcredito"), nombrecredito, FormatCurrency(reader("recibido")), Format(reader("Fecha"), "yyyy-MM-dd"), reader("hora"), reader("tipo"), reader("Caja"), reader("Estado"))
                    Case "Extra"
                        dtdatos.Rows.Add(reader("id"), reader("idcredito"), reader("concepto"), FormatCurrency(reader("recibido")), Format(reader("Fecha"), "yyyy-MM-dd"), reader("hora"), reader("tipo"), reader("Caja"), reader("Estado"))
                    Case Else
                        dtdatos.Rows.Add(reader("id"), reader("idcredito"), nombrecredito, FormatCurrency(reader("recibido")), Format(reader("Fecha"), "yyyy-MM-dd"), reader("hora"), reader("tipo"), reader("Caja"), reader("Estado"))
                End Select


            End If



        End While

        Dim total As Double
        total = 0
        Dim afecta As Boolean
        For Each row As DataGridViewRow In dtdatos.Rows
            afecta = AfectaCaja(row.Cells(6).Value)
            If afecta And row.Cells(8).Value <> "C" Then
                total = total + row.Cells(3).Value
            Else

            End If


        Next
        lbltotal.Text = FormatCurrency(total)
    End Sub

    Private Sub MonoFlat_HeaderLabel3_Click(sender As Object, e As EventArgs) Handles lbltotal.Click

    End Sub

    Private Sub BackgroundCajas_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundCajas.DoWork
        iniciarconexionempresa()
        Dim consultaCajas As String
        consultaCajas = "Select Nocaja from cajasSucursal"
        adapterCajas = New SqlDataAdapter(consultaCajas, conexionempresa)
        dataCajas = New DataTable
        adapterCajas.Fill(dataCajas)

    End Sub

    Private Sub BackgroundCajas_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundCajas.RunWorkerCompleted
        ComboFiltro.Items.Clear()
        ComboFiltro.Items.Add("Todas")
        For Each row As DataRow In dataCajas.Rows
            ComboFiltro.Items.Add(row("Nocaja").ToString)
            CheckedCajas.Items.Add(row("Nocaja").ToString)
            'PopupComboBox1.Items.Add(row("Nocaja").ToString)
        Next
        ComboFiltro.SelectedIndex = 0
        For i As Integer = 0 To CheckedCajas.Items.Count - 1
            CheckedCajas.CheckBoxItems.Item(i).CheckState = CheckState.Checked

        Next
        Cargando.Close()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        dtdatos.Rows.Clear()
        dtdatos.ScrollBars = ScrollBars.None
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Consultando"
        Cargando.TopMost = True
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        dtdatos.ScrollBars = ScrollBars.Both
        Cargando.Close()

        Cargando.TopMost = False
    End Sub

    Private Sub Tickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtdatos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dateDesde.Value = Now
        dateHasta.Value = Now
        CheckForIllegalCrossThreadCalls = False
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Consultando cajas"
        Cargando.TopMost = True
        BackgroundCajas.RunWorkerAsync()

    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs)
        TicketsPfecha.Show()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Exportando a Excel"
        Cargando.TopMost = True
        BackgroundExcel.RunWorkerAsync()
    End Sub

    Private Sub BackgroundExcel_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundExcel.DoWork
        nuevolibro()
        GridAExcel(dtdatos)
    End Sub

    Private Sub BackgroundExcel_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundExcel.RunWorkerCompleted
        Cargando.Close()
        cerrarlibro()

    End Sub

    Private Sub dateDesde_onValueChanged(sender As Object, e As EventArgs) Handles dateDesde.onValueChanged

    End Sub

    Private Sub CancelarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelarToolStripMenuItem.Click
        For Each row As DataRow In dataPermisos.Rows
            If row("SacCancelarTicket") Then
                Autorizacion.tipoAutorizacion = "SacCancelarTicket"
                Autorizacion.ShowDialog()
                If autorizado Then
                    Cargando.Show()
                    Cargando.MonoFlat_Label1.Text = "Cancelando Ticket"
                    BackgroundCancelar.RunWorkerAsync()
                Else
                    MessageBox.Show("No fue autorizado")
                End If
                Exit For
            Else
                If MessageBox.Show("¿No cuenta con los permisos, desea notificar a un usuario?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    CrearNotificacionCancelarTicket.idTicket = dtdatos.Rows(dtdatos.CurrentRow.Index).Cells(0).Value
                    CrearNotificacionCancelarTicket.Show()

                End If
            End If
        Next




    End Sub

    Private Sub BackgroundCancelar_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundCancelar.DoWork

        If dtdatos.Rows(dtdatos.CurrentRow.Index).Cells(6).Value = "Refrendo" Then
            Dim comandoFechaUpagoTicket As SqlCommand
            Dim fechaUpagoTicket As Date
            Dim consultaUfechaTicket As String
            consultaUfechaTicket = "select fecha from ticket where id = '" & dtdatos.Rows(dtdatos.CurrentRow.Index).Cells(0).Value & "'"
            comandoFechaUpagoTicket = New SqlCommand
            comandoFechaUpagoTicket.CommandText = consultaUfechaTicket
            comandoFechaUpagoTicket.Connection = conexionempresa
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
            comandoFechaPosterior.Connection = conexionempresa
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
                comandoFechaUpago.Connection = conexionempresa
                comandoFechaUpago.CommandText = consultaFechaUpago
                fechaUpago = comandoFechaUpago.ExecuteScalar

                Dim comandoConsultaTicketDetalle As SqlCommand
                Dim consultaTicketDetalle As String
                Dim readerTicketDetalle As SqlDataReader
                consultaTicketDetalle = "CancelarTicket"
                comandoConsultaTicketDetalle = New SqlCommand
                comandoConsultaTicketDetalle.Connection = conexionempresa
                comandoConsultaTicketDetalle.CommandText = consultaTicketDetalle
                comandoConsultaTicketDetalle.CommandType = CommandType.StoredProcedure
                comandoConsultaTicketDetalle.Parameters.AddWithValue("idTicket", dtdatos.Rows(dtdatos.CurrentRow.Index).Cells(0).Value)
                comandoConsultaTicketDetalle.Parameters.AddWithValue("Tipo", dtdatos.Rows(dtdatos.CurrentRow.Index).Cells(6).Value)
                comandoConsultaTicketDetalle.Parameters.AddWithValue("FechaUPago", fechaUpago.Date.ToString("yyyy-MM-dd"))
                comandoConsultaTicketDetalle.ExecuteNonQuery()
            Else
                MessageBox.Show("No se puede cancelar éste ticket, existen tickets activos con fechas posteriores")
            End If



        ElseIf dtdatos.Rows(dtdatos.CurrentRow.Index).Cells(6).Value = "Desempeño" Then
            Dim comandoFechaUpagoTicket As SqlCommand
            Dim fechaUpagoTicket As Date
            Dim consultaUfechaTicket As String
            consultaUfechaTicket = "select fecha from ticket where id = '" & dtdatos.Rows(dtdatos.CurrentRow.Index).Cells(0).Value & "'"
            comandoFechaUpagoTicket = New SqlCommand
            comandoFechaUpagoTicket.CommandText = consultaUfechaTicket
            comandoFechaUpagoTicket.Connection = conexionempresa
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
            comandoFechaUpago.Connection = conexionempresa
            comandoFechaUpago.CommandText = consultaFechaUpago
            fechaUpago = comandoFechaUpago.ExecuteScalar

            Dim comandoConsultaTicketDetalle As SqlCommand
            Dim consultaTicketDetalle As String
            Dim readerTicketDetalle As SqlDataReader
            consultaTicketDetalle = "CancelarTicket"
            comandoConsultaTicketDetalle = New SqlCommand
            comandoConsultaTicketDetalle.Connection = conexionempresa
            comandoConsultaTicketDetalle.CommandText = consultaTicketDetalle
            comandoConsultaTicketDetalle.CommandType = CommandType.StoredProcedure
            comandoConsultaTicketDetalle.Parameters.AddWithValue("idTicket", dtdatos.Rows(dtdatos.CurrentRow.Index).Cells(0).Value)
            comandoConsultaTicketDetalle.Parameters.AddWithValue("Tipo", dtdatos.Rows(dtdatos.CurrentRow.Index).Cells(6).Value)
            comandoConsultaTicketDetalle.Parameters.AddWithValue("FechaUPago", fechaUpago.Date.ToString("yyyy-MM-dd"))
            comandoConsultaTicketDetalle.ExecuteNonQuery()


        ElseIf dtdatos.Rows(dtdatos.CurrentRow.Index).Cells(6).Value = "Comisión por avalúo" Then
            Dim comandoFechaUpagoTicket As SqlCommand
            Dim fechaUpagoTicket As Date
            Dim consultaUfechaTicket As String
            consultaUfechaTicket = "select fecha from ticket where id = '" & dtdatos.Rows(dtdatos.CurrentRow.Index).Cells(0).Value & "'"
            comandoFechaUpagoTicket = New SqlCommand
            comandoFechaUpagoTicket.CommandText = consultaUfechaTicket
            comandoFechaUpagoTicket.Connection = conexionempresa
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
            comandoFechaPosterior.Connection = conexionempresa
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
                comandoFechaUpago.Connection = conexionempresa
                comandoFechaUpago.CommandText = consultaFechaUpago
                fechaUpago = comandoFechaUpago.ExecuteScalar

                Dim comandoConsultaTicketDetalle As SqlCommand
                Dim consultaTicketDetalle As String
                Dim readerTicketDetalle As SqlDataReader
                consultaTicketDetalle = "CancelarTicket"
                comandoConsultaTicketDetalle = New SqlCommand
                comandoConsultaTicketDetalle.Connection = conexionempresa
                comandoConsultaTicketDetalle.CommandText = consultaTicketDetalle
                comandoConsultaTicketDetalle.CommandType = CommandType.StoredProcedure
                comandoConsultaTicketDetalle.Parameters.AddWithValue("idTicket", dtdatos.Rows(dtdatos.CurrentRow.Index).Cells(0).Value)
                comandoConsultaTicketDetalle.Parameters.AddWithValue("Tipo", dtdatos.Rows(dtdatos.CurrentRow.Index).Cells(6).Value)
                comandoConsultaTicketDetalle.Parameters.AddWithValue("FechaUPago", fechaUpago.Date.ToString("yyyy-MM-dd"))
                comandoConsultaTicketDetalle.ExecuteNonQuery()
            Else
                MessageBox.Show("No se puede cancelar éste ticket, existen tickets activos con fechas posteriores")
            End If
        ElseIf dtdatos.Rows(dtdatos.CurrentRow.Index).Cells(6).Value = "Promesa de pago" Then
            Dim comandoFechaUpagoTicket As SqlCommand
            Dim fechaUpagoTicket As Date
            Dim consultaUfechaTicket As String
            consultaUfechaTicket = "select fecha from ticket where id = '" & dtdatos.Rows(dtdatos.CurrentRow.Index).Cells(0).Value & "'"
            comandoFechaUpagoTicket = New SqlCommand
            comandoFechaUpagoTicket.CommandText = consultaUfechaTicket
            comandoFechaUpagoTicket.Connection = conexionempresa
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
            comandoFechaPosterior.Connection = conexionempresa
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
                comandoFechaUpago.Connection = conexionempresa
                comandoFechaUpago.CommandText = consultaFechaUpago
                fechaUpago = comandoFechaUpago.ExecuteScalar

                Dim comandoConsultaTicketDetalle As SqlCommand
                Dim consultaTicketDetalle As String
                Dim readerTicketDetalle As SqlDataReader
                consultaTicketDetalle = "CancelarTicket"
                comandoConsultaTicketDetalle = New SqlCommand
                comandoConsultaTicketDetalle.Connection = conexionempresa
                comandoConsultaTicketDetalle.CommandText = consultaTicketDetalle
                comandoConsultaTicketDetalle.CommandType = CommandType.StoredProcedure
                comandoConsultaTicketDetalle.Parameters.AddWithValue("idTicket", dtdatos.Rows(dtdatos.CurrentRow.Index).Cells(0).Value)
                comandoConsultaTicketDetalle.Parameters.AddWithValue("Tipo", dtdatos.Rows(dtdatos.CurrentRow.Index).Cells(6).Value)
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
            comandoConsultaTicketDetalle.Connection = conexionempresa
            comandoConsultaTicketDetalle.CommandText = consultaTicketDetalle
            comandoConsultaTicketDetalle.CommandType = CommandType.StoredProcedure
            comandoConsultaTicketDetalle.Parameters.AddWithValue("idTicket", dtdatos.Rows(dtdatos.CurrentRow.Index).Cells(0).Value)
            comandoConsultaTicketDetalle.Parameters.AddWithValue("Tipo", dtdatos.Rows(dtdatos.CurrentRow.Index).Cells(6).Value)
            comandoConsultaTicketDetalle.Parameters.AddWithValue("FechaUPago", "")
            comandoConsultaTicketDetalle.ExecuteNonQuery()

        End If



    End Sub

    Private Sub dtdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtdatos.CellContentClick

    End Sub

    Private Sub dtdatos_SelectionChanged(sender As Object, e As EventArgs) Handles dtdatos.SelectionChanged
        If dtdatos.Rows(dtdatos.CurrentRow.Index).Cells(8).Value = "A" Then
            dtdatos.ContextMenuStrip = ContextMenuCancelar
        Else
            dtdatos.ContextMenuStrip = Nothing

        End If
    End Sub

    Private Sub BackgroundCancelar_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundCancelar.RunWorkerCompleted
        Cargando.MonoFlat_Label1.Text = "Consultando"
        BackgroundWorker1.RunWorkerAsync()

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Reportes.Panel1.Visible = False
        Reportes.RadPanorama1.Visible = True
    End Sub
End Class