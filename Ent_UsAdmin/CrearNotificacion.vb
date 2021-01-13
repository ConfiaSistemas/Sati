Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class CrearNotificacion
    Dim Creada As Boolean
    Dim ncargando As Cargando
    Private Sub btnSesiones_Click(sender As Object, e As EventArgs) Handles btnSesiones.Click
        BuscarSesion.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ncargando = New Cargando
        ncargando.Show()
        ncargando.MonoFlat_Label1.Text = "Creando Notificación"
        ncargando.TopMost = True
        Button1.Enabled = False
        BackgroundNotificacion.RunWorkerAsync()

    End Sub

    Private Sub BackgroundNotificacion_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundNotificacion.DoWork
        Try
            Dim conexionLogin As MySqlConnection
            conexionLogin = New MySqlConnection()
            conexionLogin.ConnectionString = "server=www.prestamosconfia.com;user id=ajas;pwd=123456;port=3306;database=USRS"
            conexionLogin.Open()
            Dim comandoLogin As MySqlCommand
            Dim consultaLogin As String
            consultaLogin = "insert into Notificaciones values(null,'" & ComboTipo.Text & "',0,'" & nmusr & "','" & txtUsuario.Text & "','','" & txtMensaje.Text & "','',0,'" & txtIdSesion.Text & "','" & Date.Now.ToString("yyyy-MM-dd") & "','" & Date.Now.ToString("HH:mm:ss") & "','0','','','','',''); "
            comandoLogin = New MySqlCommand
            comandoLogin.Connection = conexionLogin
            comandoLogin.CommandText = consultaLogin
            comandoLogin.ExecuteNonQuery()
            conexionLogin.Close()
            Creada = True
        Catch ex As MySqlException
            Creada = False
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BackgroundNotificacion_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundNotificacion.RunWorkerCompleted
        If Creada Then
            MessageBox.Show("Notificación creada con éxito")
        Else
            MessageBox.Show("Ha ocurrido un error, inténtelo de nuevo")
        End If
        Button1.Enabled = True
        ncargando.Close()
    End Sub
End Class