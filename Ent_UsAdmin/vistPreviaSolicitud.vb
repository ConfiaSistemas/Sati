Public Class vistPreviaSolicitud
    Public dataIntegrantes As DataTable
    Public nombre As String
    Public Monto As Double
    Public plazo As Integer
    Public tipo As String
    Public intere As Double
    Public promotor As String
    Public gestor As String
    Dim continuar As Boolean
    Private Sub vistPreviaSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        continuar = False
        lblNombre.Text = nombre
        lblMonto.Text = FormatCurrency(Monto, 2)
        lblPlazo.Text = plazo
        lblTipo.Text = tipo
        lblInteres.Text = FormatCurrency(intere, 2)
        lblPromotor.Text = promotor
        lblGestor.Text = gestor
        dtdatos.DataSource = dataIntegrantes

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_Resize(sender As Object, e As EventArgs) Handles Panel1.Resize

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub btnSi_Click(sender As Object, e As EventArgs) Handles btnSi.Click
        continuar = True
        Levantar_Solicitud.continuar = True
        Me.Close()

    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        continuar = False
        Levantar_Solicitud.continuar = False

        Me.Close()
    End Sub

    Private Sub vistPreviaSolicitud_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Levantar_Solicitud.continuar = continuar

    End Sub
End Class