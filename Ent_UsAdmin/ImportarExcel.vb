Public Class ImportarExcel
    Private Sub ImportarExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Combocodigo.Items.Add("A")
        Combocodigo.Items.Add("B")
        Combocodigo.Items.Add("C")
        Combocodigo.Items.Add("D")
        Combocodigo.Items.Add("E")
        Combocodigo.Items.Add("F")
        Combocodigo.Items.Add("G")
        Combocodigo.Items.Add("H")
        Combocodigo.Items.Add("I")
        Combocodigo.Items.Add("J")
        Combocodigo.Items.Add("K")
        Combocodigo.Items.Add("L")
        Combocodigo.Items.Add("M")
        Combocodigo.Items.Add("N")
        Combocodigo.Items.Add("O")
        Combocodigo.Items.Add("P")
        Combocodigo.Items.Add("Q")
        Combocodigo.Items.Add("R")
        Combocodigo.Items.Add("S")
        Combocodigo.Items.Add("T")
        Combocodigo.Items.Add("U")
        Combocodigo.Items.Add("V")
        Combocodigo.Items.Add("W")
        Combocodigo.Items.Add("X")
        Combocodigo.Items.Add("Y")
        Combocodigo.Items.Add("Z")
        Combocodigo.SelectedIndex = 0
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Migrar.fila = txtfila.Text
        Migrar.columna = Combocodigo.Text
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub
End Class