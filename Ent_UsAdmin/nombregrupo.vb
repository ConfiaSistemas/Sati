Public Class nombregrupo

  
    Dim tiempo As Integer = 0
    Dim opacidad As Double = 1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = 100
        If tiempo < 10 Then
            Me.Size = New Size(Me.Width + tiempo, Me.Height + tiempo)
            opacidad = opacidad - 0.05
            Me.Opacity = opacidad
            tiempo += 1

        Else
            Timer1.Enabled = False
            Me.Close()

        End If
    End Sub

    Private Sub nombregrupo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(usuarios.Location.X + usuarios.Combogrupo.Location.X, usuarios.Location.Y + usuarios.Combogrupo.Location.Y + usuarios.Panel1.Height)
        Me.Size = New Size(Me.Width - 80, Me.Height - 80)
        Timer1.Enabled = True
        Me.TopMost = True
    End Sub

    Private Sub nombregrupo_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        MonoFlat_HeaderLabel1.Location = New Point((Me.Width / 2) - (MonoFlat_HeaderLabel1.Width / 2), (Me.Height / 2) - (MonoFlat_HeaderLabel1.Height / 2))
    End Sub
End Class