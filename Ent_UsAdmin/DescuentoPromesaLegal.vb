Public Class DescuentoPromesaLegal

    Public Maximo As Double
    Public Total As Boolean

    Private Sub DescuentoPromesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMaximo.Text = FormatCurrency(Maximo, 2)

    End Sub

    Private Sub txtOtraCantidad_Click(sender As Object, e As EventArgs) Handles txtOtraCantidad.Click
        If txtcantidad.Text > Maximo Then
            MessageBox.Show("No puedes ingresar un descuento mayor al máximo establecido")
        Else
            Me.Close()

        End If
    End Sub

    Private Sub DescuentoPromesa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If txtcantidad.Text = "" Then


            PromPagoLegal.descuentoTotal = 0
        Else

            If txtcantidad.Text > Maximo Then

                PromPagoLegal.descuentoTotal = 0
            Else

                PromPagoLegal.descuentoTotal = txtcantidad.Text
            End If

        End If



    End Sub



    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub
End Class