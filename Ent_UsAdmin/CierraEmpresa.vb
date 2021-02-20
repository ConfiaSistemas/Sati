Public Class CierraEmpresa
    Private Sub CierraEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.Sleep(1000) ' 1 segundo
        SeCierra()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_adm.cerrarEmpresa = True
        frm_adm.cerrarSesion = True
        frm_adm.Close()

    End Sub
    Private Sub SeCierra()
        frm_adm.cerrarEmpresa = True
        frm_adm.cerrarSesion = True
        frm_adm.Close()
    End Sub
End Class