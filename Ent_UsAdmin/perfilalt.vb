Public Class perfilalt

    
    Private Sub BunifuThinButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton21.Click
        editarperfil.Show()
        frm_adm.abierto = False
        frm_adm.Timer2.Stop()

        Me.Close()

    End Sub

    Private Sub perfilalt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If imgstrusr = "" Then
            PictureBox2.Image = ConfiaAdmin.My.Resources.Resources.usuarionegro
        Else
            PictureBox2.Image = bitmapimgusr
        End If
        If nm_completeusr <> "" Then
            lblnm_complete.Text = nm_completeusr
        End If

        If addrusr <> "" Then
            lbldireccion.Text = addrusr
        End If

        If tlfusr <> "" Then
            lbltlf.Text = tlfusr
        End If

        If grpusr <> "" Then
            lblgrp.Text = grpusr
        End If

        If nmusr <> "" Then
            lblnm.Text = nmusr
        End If

        If idSesion <> "" Then
            lblSesion.Text = idSesion
        End If

    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        frm_adm.cerrarSesion = True
        frm_adm.Close()
    End Sub
End Class