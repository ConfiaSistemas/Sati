Imports System.ComponentModel
Imports System.Data.SqlClient
'Imports ConfiaAdmin.CustomControl

Public Class TicketsSinRecibir
    Dim dataCajas As DataTable
    Dim adapterCajas As SqlDataAdapter
    Public autorizado As Boolean

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        dtdatos.Rows.Clear()
        Try
            iniciarconexionempresa()
            Dim comando As SqlCommand

            Dim reader As SqlDataReader
            Dim consulta As String


            Dim cajaConsultar As String

            'consulta = "select Ticket.id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id where Ticket.fecha >= convert(date,'" & fechainserciondesde & "',102) and Ticket.fecha <= convert(date,'" & fechainsercionhasta & "',102)  order by Ticket.fecha,Ticket.hora asc "

            cajaConsultar = CheckedCajas.Text
            consulta = "select Ticket.id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja,ticket.estado from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id where ticket.caja in (" & cajaConsultar & ") and ticket.id not in (select idticket from DetalleCierreCajaGestores) order by Ticket.fecha,Ticket.hora asc "

            'End Select


            comando = New SqlCommand
            comando.Connection = conexionempresa
            ' comando.CommandTimeout = 120
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
                    Case "Legal", "Depósito Legal", "Promesa de pago legal", "Promesa Aplicada Legal", "Cancelación de Promesa Legal"
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

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

    Private Sub dateDesde_onValueChanged(sender As Object, e As EventArgs)

    End Sub





    Private Sub dtdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtdatos.CellContentClick

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