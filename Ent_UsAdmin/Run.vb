Public Class Run
    Private Sub txtcmd_OnValueChanged(sender As Object, e As EventArgs) Handles txtcmd.OnValueChanged

    End Sub

    Private Sub txtcmd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcmd.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtcmd.Text.Equals("Migrate", StringComparison.InvariantCultureIgnoreCase) Then
                Migrar.Show()
                Me.Close()

            End If
            If txtcmd.Text.Equals("PruebaDatosSolicitud", StringComparison.InvariantCultureIgnoreCase) Then
                DatosSolicitud.Show()
                Me.Close()

            End If
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub
End Class