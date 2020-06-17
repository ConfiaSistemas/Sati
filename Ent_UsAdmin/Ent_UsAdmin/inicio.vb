Public Class inicio

    Private Sub inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If frm_adm.BunifuImageButton1.Width + frm_adm.panelusuarios.Width + frm_adm.Panelconfiguracion.Width + frm_adm.Panel3.Width + frm_adm.Panel4.Width + frm_adm.notificaciones.Width + frm_adm.imgperfil.Width + 30 > frm_adm.Panel1.Width Then




        ' Me.Panelsecundario.Visible = True




        ' Else



        ' Me.Panelsecundario.Visible = False





        'End If
        If frm_adm.mostrarpanelsecundario = False Then
            Panelsecundario.Visible = False
        Else
            Panelsecundario.Visible = True

        End If
        Me.Panelsecundario.Left = frm_adm.panelusuarios.Width + frm_adm.Panelconfiguracion.Width + frm_adm.BunifuImageButton1.Width - frm_adm.panelmenus.Width + 10
        Panelsecundario.Top = 0

    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        grupos.Show()

    End Sub
End Class