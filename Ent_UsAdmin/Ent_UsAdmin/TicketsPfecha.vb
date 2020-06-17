Imports System.Data.SqlClient

Imports WinControls.ListView
Imports System.Xml.Serialization
Imports System.ComponentModel

Public Class TicketsPfecha
    Dim dataCajas As DataTable
    Dim adapterCajas As SqlDataAdapter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        iniciarconexionempresa()
        TreeListView1.Nodes.Clear()
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
        Dim comandoTicket As SqlCommand
        Dim consulta As String
        Dim readerTicket As SqlDataReader
        consulta = "select IdRecibo,Recibido,(case when tipo = 'Legal' then Concepto
							   when tipo = 'Extra' then Concepto
							   when tipo = 'Convenio' then
							   (select creditosext.nombre from Convenios inner join CreditosExt on Convenios.id_credito = CreditosExt.id_credito where Convenios.id = pagos.id_Credito)
							   else ISNULL((select nombre from CreditosExt where id_credito = pagos.id_Credito),0) 		end) as nombre,id_Credito,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja from
(select Recibos.IdRecibo,Recibos.Recibido,Recibos.Id_Credito,Recibos.Fecha,recibos.hora,Recibos.PagoNormal,Recibos.Intereses,recibos.total,tipodoc.Nombre as tipo,recibos.concepto,recibos.caja from recibos  inner join TipoDoc on recibos.tipodoc = TipoDoc.id  where recibos.fecha >= convert(date,'2020-02-12',102) and recibos.fecha <= convert(date,'2020-02-12',102)  )pagos"
        comandoTicket = New SqlCommand
        comandoTicket.Connection = conexionempresa
        comandoTicket.CommandText = consulta
        readerTicket = comandoTicket.ExecuteReader
        If readerTicket.HasRows Then
            While readerTicket.Read
                Dim liItem As New TreeListNode(readerTicket("idrecibo"))
                With liItem.SubItems
                    .Add(readerTicket("id_credito"))
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
                consultaDetalle = "select concat(abonosext.concepto,' de ','Pago ', PagosExt.NPago) as pago,pagonormal,intereses,abonosext.monto from AbonosExt inner join PagosExt on AbonosExt.idpago = PagosExt.idpago where  idrecibo = '" & readerTicket("idrecibo") & "'"
                COMANDOdetalle = New SqlCommand
                COMANDOdetalle.Connection = conexionempresa
                COMANDOdetalle.CommandText = consultaDetalle
                readerDetalle = COMANDOdetalle.ExecuteReader
                If readerDetalle.HasRows Then
                    While readerDetalle.Read
                        Me._addSubItems(liItem.Nodes.Add(readerDetalle("pago")), readerDetalle("pagonormal"), readerDetalle("intereses"), readerDetalle("monto"))
                    End While
                End If
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

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        iniciarconexionempresa()
        TreeListView1.Nodes.Clear()
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
        Dim comandoTicket As SqlCommand
        Dim consulta As String
        Dim readerTicket As SqlDataReader
        Dim cajaConsultar As String
        Select Case ComboFiltro.Text
            Case "Todas"
                consulta = "select id,Recibido,(case when tipo = 'Legal' then Concepto
							   when tipo = 'Extra' then Concepto
							  
							   else ISNULL((select nombre from Credito where id = pagos.idCredito),0) 		end) as nombre,idCredito,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja from
(select Ticket.Id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.PagoNormal,Ticket.Intereses,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id  where Ticket.fecha >= convert(date,'" & fechainserciondesde & "',102) and Ticket.fecha <= convert(date,'" & fechainsercionhasta & "',102)  )pagos order by Fecha,Hora asc"
            Case Else
                cajaConsultar = ComboFiltro.Text
                consulta = "select id,Recibido,(case when tipo = 'Legal' then Concepto
							   when tipo = 'Extra' then Concepto
							  
							   else ISNULL((select nombre from Credito where id = pagos.idCredito),0) 		end) as nombre,idCredito,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja from
(select Ticket.Id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.PagoNormal,Ticket.Intereses,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id  where Ticket.fecha >= convert(date,'" & fechainserciondesde & "',102) and Ticket.fecha <= convert(date,'" & fechainsercionhasta & "',102) and ticket.caja = '" & cajaConsultar & "'  )pagos order by Fecha,Hora asc"
        End Select

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
                TreeListView1.Nodes.Add(liItem)
            End While
        End If
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
        Next
        ComboFiltro.SelectedIndex = 0
        Cargando.Close()
    End Sub

    Private Sub TicketsPfecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dateDesde.Value = Now
        dateHasta.Value = Now
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando Información"
        Cargando.TopMost = True
        BackgroundCajas.RunWorkerAsync()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click

        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        For Each nodee As TreeListNode In TreeListView1.Nodes
            MessageBox.Show(nodee.SubItems(4).Text)
        Next
    End Sub
End Class