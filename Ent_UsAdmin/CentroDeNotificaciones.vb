Imports ConfiaAdmin.MonoFlat

Public Class CentroDeNotificaciones
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub CentroDeNotificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoubleBuffered = True

        For Each n As Notificaciones In frm_adm.array
            Dim botonNotificacion As New Panel
            botonNotificacion.BackColor = Color.FromArgb(48, 55, 76)
            '   botonNotificacion.Iconimage = My.Resources.notificacion
            botonNotificacion.Size = New Size(792, 146)
            botonNotificacion.Text = ""
            botonNotificacion.Cursor = Cursors.Hand
            botonNotificacion.Name = n.id
            botonNotificacion.Tag = n.Valor

            AddHandler botonNotificacion.MouseEnter, AddressOf Panel_MouseHover
            AddHandler botonNotificacion.MouseLeave, AddressOf Panel_MouseLeave
            AddHandler botonNotificacion.Click, AddressOf Panel_Click

            FlowLayoutPanel1.PerformLayout()
            Me.Invoke(Sub()
                          FlowLayoutPanel1.Controls.Add(botonNotificacion)
                      End Sub)



            Dim lblFecha As New MonoFlat_HeaderLabel

            lblFecha.Location = New Point(158, 14)
            lblFecha.Text = n.Fecha

            lblFecha.AutoSize = True

            lblFecha.BringToFront()
            ' lblFecha.BackColor = Color.White
            lblFecha.ForeColor = Color.FromArgb(255, 255, 255)
            Me.Invoke(Sub()
                          botonNotificacion.Controls.Add(lblFecha)
                      End Sub)


            Dim lblHora As New MonoFlat_HeaderLabel

            lblHora.Location = New Point(413, 14)
            lblHora.Text = n.Hora

            lblHora.AutoSize = True
            lblHora.BringToFront()
            ' lblFecha.BackColor = Color.White
            lblHora.ForeColor = Color.FromArgb(255, 255, 255)
            Me.Invoke(Sub()
                          botonNotificacion.Controls.Add(lblHora)
                      End Sub)




            Dim lblLabelTipo As MonoFlat_HeaderLabel
            lblLabelTipo = New MonoFlat_HeaderLabel

            lblLabelTipo.Parent = botonNotificacion
            lblLabelTipo.Location = New Point(158, 72)
            lblLabelTipo.Text = "Tipo:"
            lblLabelTipo.AutoSize = True

            lblLabelTipo.BringToFront()
            ' lblFecha.BackColor = Color.White
            lblLabelTipo.ForeColor = Color.FromArgb(255, 255, 255)

            botonNotificacion.Controls.Add(lblLabelTipo)





            Dim lblTipo As New MonoFlat_HeaderLabel

            lblTipo.Location = New Point(218, 72)
            lblTipo.Text = n.Tipo
            lblTipo.AutoSize = True
            lblTipo.Name = "Tipo"
            lblTipo.BringToFront()
            ' lblFecha.BackColor = Color.White
            lblTipo.ForeColor = Color.FromArgb(255, 255, 255)
            Me.Invoke(Sub()
                          botonNotificacion.Controls.Add(lblTipo)
                      End Sub)




            Dim lblLabelUsuario As New MonoFlat_HeaderLabel

            lblLabelUsuario.Location = New Point(413, 72)
            lblLabelUsuario.Text = "Usuario:"
            lblLabelUsuario.AutoSize = True

            lblLabelUsuario.BringToFront()
            ' lblFecha.BackColor = Color.White
            lblLabelUsuario.ForeColor = Color.FromArgb(255, 255, 255)
            Me.Invoke(Sub()
                          botonNotificacion.Controls.Add(lblLabelUsuario)
                      End Sub)




            Dim lblUsuario As New MonoFlat_HeaderLabel

            lblUsuario.Location = New Point(497, 72)
            lblUsuario.Text = n.Usuario
            lblUsuario.AutoSize = True

            lblUsuario.BringToFront()
            ' lblFecha.BackColor = Color.White
            lblUsuario.ForeColor = Color.FromArgb(255, 255, 255)
            Me.Invoke(Sub()
                          botonNotificacion.Controls.Add(lblUsuario)
                      End Sub)


        Next
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel_MouseHover(sender As Object, e As EventArgs)
        sender.backcolor = Color.FromArgb(91, 103, 138)
    End Sub
    Private Sub Panel_MouseLeave(sender As Object, e As EventArgs)
        sender.backcolor = Color.FromArgb(48, 55, 76)
    End Sub

    Private Sub Panel_Click(sender As Object, e As EventArgs)
        sender.backcolor = Color.FromArgb(123, 127, 139)
        For Each ctrl As Control In sender.controls
            If TypeOf ctrl Is MonoFlat_HeaderLabel Then
                Dim lblTipo As MonoFlat_HeaderLabel = ctrl
                If lblTipo.Name = "Tipo" Then

                    If lblTipo.Text = "CancelarTicket" Then

                        CancelarTicket.idNotificacion = sender.name
                        CancelarTicket.idTicket = sender.tag
                        CancelarTicket.Show()
                        Exit For
                    End If
                End If
            End If

        Next


    End Sub

End Class