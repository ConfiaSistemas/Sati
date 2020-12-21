Imports MySql.Data.MySqlClient
Public Class mysql
    Friend conexionsql As MySqlConnection
    Private Sub mysql_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conexionsql = New MySqlConnection()
            conexionsql.ConnectionString = "server=www.prestamosconfia.com;user id=" & UsuarioTxt.Text & ";pwd=" & PswdTxt.Text & ";port=3306;database=Versiones"
            conexionsql.Open()
            MessageBox.Show("Conectado al servidor")
            Dim mysqlcomando As MySqlCommand
            Dim consulta As String
            Dim readermysql As MySqlDataReader
            consulta = "select * from Versiones"
            mysqlcomando = New MySqlCommand
            mysqlcomando.Connection = conexionsql
            mysqlcomando.CommandText = consulta
            readermysql = mysqlcomando.ExecuteReader
            While readermysql.Read
                MessageBox.Show(readermysql("sistema"))
            End While

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class