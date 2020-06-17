Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class RetirosPorFecha

    Dim dataCajas As DataTable
    Dim adapterCajas As SqlDataAdapter
    Dim dataRetiros As DataTable
    Dim adapterRetiros As SqlDataAdapter


    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'dtdatos.Rows.Clear()

        iniciarconexionempresa()

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
        Select Case ComboFiltro.Text
            Case "Todas"
                consulta = "select * from retiros where (fecha >= '" & fechainserciondesde & "' and fecha <= '" & fechainsercionhasta & "') and usuariorecibe<> ''"
            Case Else
                cajaConsultar = ComboFiltro.Text
                consulta = "select * from retiros where (fecha >= '" & fechainserciondesde & "' and fecha <= '" & fechainsercionhasta & "') and usuariorecibe <> '' and caja = '" & cajaConsultar & "'"

        End Select


        adapterRetiros = New SqlDataAdapter(consulta, conexionempresa)
        dataRetiros = New DataTable
        adapterRetiros.Fill(dataRetiros)

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
        Next
        ComboFiltro.SelectedIndex = 0
        Cargando.Close()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        'dtdatos.Rows.Clear()
        dtdatos.ScrollBars = ScrollBars.None
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Consultando"
        Cargando.TopMost = True
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        dtdatos.ScrollBars = ScrollBars.Both
        dtdatos.DataSource = dataRetiros
        Dim total As Double
        total = 0
        For Each row As DataGridViewRow In dtdatos.Rows
            If Val(row.Cells(8).Value) = 0 Then
                total = total + row.Cells(1).Value
            Else
                total = total + row.Cells(8).Value
            End If

        Next
        lbltotal.Text = FormatCurrency(total, 2)
        Cargando.Close()

        Cargando.TopMost = False
    End Sub

    Private Sub Tickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dateDesde.Value = Now
        dateHasta.Value = Now
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Consultando cajas"
        Cargando.TopMost = True
        BackgroundCajas.RunWorkerAsync()

    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs)
        TicketsPfecha.Show()
    End Sub

    Private Sub dtdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtdatos.CellContentClick

    End Sub
End Class