Imports System.Data.SqlClient

Public Class passwordforgot
    Public UsuarioOlvidado As String
    Private Sub btn_Procesar_Click(sender As Object, e As EventArgs) Handles btn_Procesar.Click
        iniciarconexion()
        Dim comando As OleDb.OleDbCommand
        Dim consulta As String
        consulta = "insert into Notificaciones(Tipo,DirigidoA,idGrupoUsuario,EnviadaPor,Modulo,idNombreModulo) values('Password','Usuario','admin','" & UsuarioOlvidado & "','Login','" & UsuarioOlvidado & "')"
        comando = New OleDb.OleDbCommand
        comando.Connection = conexion
        comando.CommandText = consulta
        comando.ExecuteNonQuery()
        MessageBox.Show("Listo")
    End Sub
End Class