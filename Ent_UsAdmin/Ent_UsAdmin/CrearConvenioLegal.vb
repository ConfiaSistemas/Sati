Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class CrearConvenioLegal
    Dim Modalidad As String
    Public idCreditoLegal As String
    Public ParteCredito As Double
    Public ParteMoratorios As Double
    Public DeudaAP As Double
    Public DeudaTotal As Double
    Public incluyePorcentaje As Boolean
    Private Sub ZeroitMetroSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles ZeroitMetroSwitch1.CheckedChanged
        If ZeroitMetroSwitch1.Checked Then
            lblTipoPagos.Text = "Pago"
            txtPago.Enabled = True
            txtCantPagos.Enabled = False
        Else
            lblTipoPagos.Text = "Cantidad de Pagos"
            txtPago.Enabled = False
            txtCantPagos.Enabled = True
        End If
    End Sub

    Private Sub SwitchModalidad_CheckedChanged(sender As Object, e As EventArgs) Handles SwitchModalidad.CheckedChanged
        If SwitchModalidad.Checked Then
            lblModalidad.Text = "Semanal"
            Modalidad = "S"
        Else
            lblModalidad.Text = "Quincenal"
            Modalidad = "Q"
        End If
    End Sub

    Private Sub BackgroundDatos_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundDatos.DoWork
        iniciarconexionempresa()
        Dim comandoCreditoLegal As SqlCommand
        Dim consultaCreditoLegal As String
        Dim readerCreditoLegal As SqlDataReader
        consultaCreditoLegal = "select nombre,credito,Moratorios,deudaAP,TotalDeuda,incluyeporcentaje from legales where id = '" & idCreditoLegal & "'"
        comandoCreditoLegal = New SqlCommand
        comandoCreditoLegal.Connection = conexionempresa
        comandoCreditoLegal.CommandText = consultaCreditoLegal
        readerCreditoLegal = comandoCreditoLegal.ExecuteReader
        If readerCreditoLegal.HasRows Then
            While readerCreditoLegal.Read
                ParteCredito = readerCreditoLegal("credito")
                ParteMoratorios = readerCreditoLegal("Moratorios")
                DeudaAP = readerCreditoLegal("deudaAP")
                DeudaTotal = readerCreditoLegal("TotalDeuda")
                lblnombre.Text = readerCreditoLegal("Nombre")
                incluyePorcentaje = readerCreditoLegal("incluyeporcentaje")
            End While
        End If
        CheckPorcentaje.Checked = incluyePorcentaje

        lblParteCredito.Text = FormatCurrency(ParteCredito)
        lblParteMoratorios.Text = FormatCurrency(ParteMoratorios)
        lblSubtotal.Text = FormatCurrency(DeudaAP)
        lblTotal.Text = FormatCurrency(DeudaTotal)

    End Sub

    Private Sub BackgroundDatos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundDatos.RunWorkerCompleted
        Cargando.Close()

    End Sub

    Private Sub CrearConvenioLegal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando Datos"
        Cargando.TopMost = True
        BackgroundDatos.RunWorkerAsync()

    End Sub

    Private Sub txtPago_OnValueChanged(sender As Object, e As EventArgs) Handles txtPago.OnValueChanged

    End Sub

    Private Sub txtPago_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPago.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCantPagos.Text = CInt(Math.Ceiling((DeudaTotal) / Val(txtPago.Text)))
        End If
    End Sub

    Private Sub txtCantPagos_OnValueChanged(sender As Object, e As EventArgs) Handles txtCantPagos.OnValueChanged

    End Sub

    Private Sub txtCantPagos_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCantPagos.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPago.Text = CInt(Math.Ceiling(Val(DeudaTotal) / Val(txtCantPagos.Text)))
        End If
    End Sub

    Private Sub MonoFlat_LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles MonoFlat_LinkLabel1.LinkClicked
        Dim deuda As Double
        deuda = DeudaTotal
        Dim canPagos As Integer
        canPagos = Val(txtCantPagos.Text)
        Dim numero As Integer = 0
        If (DeudaTotal Mod canPagos) = 0 Then
            MessageBox.Show(canPagos & " pagos de " & txtPago.Text)
        Else
            For i As Integer = 1 To canPagos - 1
                deuda = deuda - Val(txtPago.Text)
                numero += 1

            Next
            MessageBox.Show(numero & " pagos de " & txtPago.Text & " y 1 pago de " & deuda)
        End If
    End Sub

    Private Sub btnGenerarCalendario_Click(sender As Object, e As EventArgs) Handles btnGenerarCalendario.Click
        If incluyePorcentaje Then
            CalendarioConvenioLegal.Moratorios = ParteMoratorios
            CalendarioConvenioLegal.Capital = ParteCredito
        Else
            CalendarioConvenioLegal.Moratorios = ParteMoratorios * 1.3
            CalendarioConvenioLegal.Capital = ParteCredito * 1.3
        End If

        ' CalendarioConvenioLegal.personalizado = personalizado
        CalendarioConvenioLegal.idCredito = idCreditoLegal
        CalendarioConvenioLegal.deuda = DeudaTotal
        CalendarioConvenioLegal.cantPagos = txtCantPagos.Text
        CalendarioConvenioLegal.MontoPago = txtPago.Text
        CalendarioConvenioLegal.PrimerPago = Convert.ToDateTime(datePrimerPago.Value.ToShortDateString)
        CalendarioConvenioLegal.Modalidad = Modalidad
        CalendarioConvenioLegal.deudaTotal = DeudaTotal
        'CalendarioConvenioLegal.gestor = gestor
        CalendarioConvenioLegal.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub


End Class