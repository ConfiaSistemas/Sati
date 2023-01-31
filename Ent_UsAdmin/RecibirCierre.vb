Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class RecibirCierre

    Public autorizado As Boolean
    Public idRetiro As Integer
    Public Cantidad As Double
    Dim dataTickets As DataTable
    Dim adapterTickets As SqlDataAdapter
    Dim nCargando As Cargando
    Private Sub RecibirRetiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMonto.Text = FormatCurrency(Cantidad, 2)
        nCargando = New Cargando
        nCargando.MonoFlat_Label1.Text = "Cargando"
        nCargando.Show()
        BackgroundDetalleCierre.RunWorkerAsync()
    End Sub

    Private Sub MonoFlat_Button1_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button1.Click

        BackgroundWorker1.RunWorkerAsync()


    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        iniciarconexionempresa()
        Dim fechainsercionhasta As String
        Dim monto As Double
        Dim fechaRetiro As String
        Dim concepto As String
        monto = txtmonto.Text
        Dim tiempo As String = TimeOfDay.ToString("HH:mm:ss")
        fechainsercionhasta = Now.Date

        Dim fechasqlhasta As Date
        fechasqlhasta = fechainsercionhasta
        fechainsercionhasta = Format(fechasqlhasta, "yyyy-MM-dd")
        fechaRetiro = Format(fechasqlhasta, "dd/MM/yyyy")
        Dim comandoRecibirRetiro As SqlCommand
        Dim consultaRetiro As String
        consultaRetiro = "update cierrecajagestores set MontoRecibido = '" & txtmonto.Text & "',fechaRecibido = '" & fechainsercionhasta & "',usuariorecibe = '" & nmusr & "',horarecibido = '" & tiempo & "' where id = '" & idRetiro & "'"
        comandoRecibirRetiro = New SqlCommand
        comandoRecibirRetiro.Connection = conexionempresa
        comandoRecibirRetiro.CommandText = consultaRetiro
        comandoRecibirRetiro.ExecuteNonQuery()

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        Cargando.Close()
        Me.Invoke(Sub()
                      CierresSinRecibir.CargarRetiros()
                  End Sub)

        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub BackgroundDetalleCierre_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundDetalleCierre.DoWork
        Dim consultaDetalleCierre As String
        iniciarconexionempresa()
        consultaDetalleCierre = "select dc.id,dc.idTicket,dc.MontoTicket,Ticket.Fecha from detallecierrecajagestores dc inner join ticket on dc.idticket = ticket.id where dc.idcierre = '" & idRetiro & "'"
        adapterTickets = New SqlDataAdapter(consultaDetalleCierre, conexionempresa)
        dataTickets = New DataTable
        adapterTickets.Fill(dataTickets)

    End Sub

    Private Sub BackgroundDetalleCierre_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundDetalleCierre.RunWorkerCompleted
        dtimpuestos.DataSource = dataTickets
        nCargando.Close()
    End Sub
End Class