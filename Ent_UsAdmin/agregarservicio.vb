Public Class agregarservicio

   






    Private Sub agregarservicio_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        inv.catservicios.MonoFlat_Label1.ForeColor = Color.FromArgb(64, 64, 64)
        inv.catservicios.MonoFlat_Label1.BorderStyle = BorderStyle.None
        inv.catservicios.MonoFlat_Label1.Location = New Point(inv.catservicios.MonoFlat_Label1.Location.X, inv.catservicios.yiniciallabel)
        inv.catservicios.bloquearlabelagregar = False
        inv.catservicios.agregarservicioabierto = False
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub


   
    

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub agregarservicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class