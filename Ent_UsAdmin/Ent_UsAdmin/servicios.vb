Public Class servicios

    Public bloquearlabel As Boolean = False
    Public bloquearlabelagregar As Boolean = False
    Public agregarservicioabierto As Boolean = False
    Public yiniciallabel As Integer = 34
    Public yfinallabel As Integer = 30





    Private Sub MonoFlat_Label1_MouseClick(sender As Object, e As MouseEventArgs) Handles MonoFlat_Label1.MouseClick


    End Sub

    Private Sub MonoFlat_Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles MonoFlat_Label1.MouseDown
        MonoFlat_Label1.BorderStyle = BorderStyle.Fixed3D
        MonoFlat_Label1.ForeColor = Color.Coral
        bloquearlabelagregar = True
        agregarservicioabierto = True
        agregarservicio.Show()
    End Sub

    Private Sub MonoFlat_Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles MonoFlat_Label1.MouseUp
        'MonoFlat_Label1.ForeColor = Color.FromArgb(64, 64, 64)
        'MonoFlat_Label1.BorderStyle = BorderStyle.None
        'agregarservicio.Show()
    End Sub

    

    Private Sub MonoFlat_Label1_MouseHover(sender As Object, e As EventArgs) Handles MonoFlat_Label1.MouseHover
        ' MonoFlat_Label1.ForeColor = Color.FromArgb(204, 0, 0)
        If bloquearlabelagregar = False Then
            MonoFlat_Label1.Location = New Point(MonoFlat_Label1.Location.X, yfinallabel)
            bloquearlabelagregar = True
        End If


        'MonoFlat_Label1.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub MonoFlat_Label1_MouseLeave(sender As Object, e As EventArgs) Handles MonoFlat_Label1.MouseLeave
        If agregarservicioabierto = False Then
            If bloquearlabelagregar = True Then
                MonoFlat_Label1.ForeColor = Color.FromArgb(64, 64, 64)
                MonoFlat_Label1.BorderStyle = BorderStyle.None
                MonoFlat_Label1.Location = New Point(MonoFlat_Label1.Location.X, yiniciallabel)
                bloquearlabelagregar = False
            End If
        End If


    End Sub

   

    Private Sub lblmodificar_MouseDown(sender As Object, e As MouseEventArgs) Handles lblmodificar.MouseDown
        lblmodificar.BorderStyle = BorderStyle.Fixed3D
        lblmodificar.ForeColor = Color.Coral

    End Sub

    Private Sub lblmodificar_MouseHover(sender As Object, e As EventArgs) Handles lblmodificar.MouseHover
        If bloquearlabel = False Then
            lblmodificar.Location = New Point(lblmodificar.Location.X, lblmodificar.Location.Y - 4)
            bloquearlabel = True
        End If

    End Sub

    Private Sub lblmodificar_MouseLeave(sender As Object, e As EventArgs) Handles lblmodificar.MouseLeave
        If bloquearlabel = True Then
            lblmodificar.ForeColor = Color.FromArgb(64, 64, 64)
            lblmodificar.BorderStyle = BorderStyle.None
            lblmodificar.Location = New Point(lblmodificar.Location.X, lblmodificar.Location.Y + 4)
            bloquearlabel = False
        End If
    End Sub

    Private Sub lblmodificar_MouseUp(sender As Object, e As MouseEventArgs) Handles lblmodificar.MouseUp
        lblmodificar.ForeColor = Color.FromArgb(64, 64, 64)
        lblmodificar.BorderStyle = BorderStyle.None
    End Sub

    Private Sub lbleliminar_Click(sender As Object, e As EventArgs) Handles lbleliminar.Click

    End Sub

    Private Sub lbleliminar_MouseDown(sender As Object, e As MouseEventArgs) Handles lbleliminar.MouseDown
        lbleliminar.BorderStyle = BorderStyle.Fixed3D
        lbleliminar.ForeColor = Color.Coral
    End Sub

    Private Sub lbleliminar_MouseHover(sender As Object, e As EventArgs) Handles lbleliminar.MouseHover
        If bloquearlabel = False Then
            lbleliminar.Location = New Point(lbleliminar.Location.X, lbleliminar.Location.Y - 4)
            bloquearlabel = True
        End If
    End Sub

    Private Sub lbleliminar_MouseLeave(sender As Object, e As EventArgs) Handles lbleliminar.MouseLeave
        If bloquearlabel = True Then
            lbleliminar.ForeColor = Color.FromArgb(64, 64, 64)
            lbleliminar.BorderStyle = BorderStyle.None
            lbleliminar.Location = New Point(lbleliminar.Location.X, lbleliminar.Location.Y + 4)
            bloquearlabel = False
        End If
    End Sub

    Private Sub lbleliminar_MouseUp(sender As Object, e As MouseEventArgs) Handles lbleliminar.MouseUp
        lbleliminar.ForeColor = Color.FromArgb(64, 64, 64)
        lbleliminar.BorderStyle = BorderStyle.None
    End Sub

    Private Sub MonoFlat_Label1_Click(sender As Object, e As EventArgs) Handles MonoFlat_Label1.Click
       
       

    End Sub


End Class