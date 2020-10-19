Imports System.Data.SqlClient

Public Class AgregarTipoCredito
    Dim insertar As Boolean
    Public autorizado As Boolean
    Dim plazo As Integer
    Private Sub btn_Procesar_Click(sender As Object, e As EventArgs) Handles btn_Procesar.Click
        Autorizacion.tipoAutorizacion = "SatiModTiposCreditosAgregar"
        Autorizacion.ShowDialog()
        If autorizado Then
            Try

                iniciarconexionempresa()
                Dim comando As SqlCommand
                If ComboPlazo.Text = "Otro" Then
                    plazo = txtOtroPlazo.Text
                Else
                    plazo = ComboPlazo.Text
                End If

                Dim consulta As String
                consulta = "Insert into TiposDecredito values('" & txtNombre.Text & "','" & ComboModalidad.Text & "','" & ComboTipo.Text & "','" & plazo & "','" & txtInteres.Text & "')"
                comando = New SqlCommand
                comando.Connection = conexionempresa
                comando.CommandText = consulta
                comando.ExecuteNonQuery()
                insertar = True
                MessageBox.Show("Listo")
                txtNombre.Text = ""
            Catch ex As Exception
                insertar = False
                MessageBox.Show("Ha ocurrido un error " & ex.Message)
            End Try
        Else
            MessageBox.Show("No fue autorizado")
        End If

    End Sub

    Private Sub AgregarTipoCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboModalidad.Items.Add("S")
        ComboModalidad.Items.Add("Q")
        ComboModalidad.SelectedIndex = 0

        ComboTipo.Items.Add("I")
        ComboTipo.Items.Add("G")
        ComboTipo.Items.Add("L")
        ComboTipo.SelectedIndex = 0


    End Sub

    Private Sub ComboModalidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboModalidad.SelectedIndexChanged
        If ComboTipo.Text = "L" Then
            ComboPlazo.Items.Clear()
            ComboPlazo.Items.Add("0")
            ComboPlazo.SelectedIndex = 0
        Else
            Select Case ComboModalidad.Text
                Case "S"
                    ComboPlazo.Items.Clear()
                    ComboPlazo.Items.Add("16")
                    ComboPlazo.Items.Add("18")
                    ComboPlazo.Items.Add("22")
                    ComboPlazo.Items.Add("Otro")
                    ComboPlazo.SelectedIndex = 0
                Case "Q"
                    ComboPlazo.Items.Clear()
                    ComboPlazo.Items.Add("8")
                    ComboPlazo.Items.Add("11")
                    ComboPlazo.Items.Add("Otro")

                    ComboPlazo.SelectedIndex = 0
            End Select
        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub ComboPlazo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboPlazo.SelectedIndexChanged
        If ComboPlazo.Text = "Otro" Then
            lblOtroPlazo.Visible = True
            txtOtroPlazo.Visible = True
        Else
            lblOtroPlazo.Visible = False
            txtOtroPlazo.Visible = False
        End If
    End Sub
End Class