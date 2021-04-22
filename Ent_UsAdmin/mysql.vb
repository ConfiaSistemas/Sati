Imports MySql.Data.MySqlClient
Public Class mysql
    Private Declare Function Beep Lib "kernel32" (
               ByVal soundFrequency As Int32,
               ByVal soundDuration As Int32) As Int32
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Beep(txtfbeep1.Text, txtDbeep1.Text)
        Beep(txtfbeep2.Text, txtDbeep2.Text)
        Beep(txtfbeep3.Text, txtDbeep3.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Creamos un nuevo objeto MailMessage donde especificamos el "From" y el "To"
        Dim correo As New System.Net.Mail.MailMessage("sistemas@prestamosconfia.com", "jjah.jairo@gmail.com")
        correo.Subject = "Probando el asunto"
        correo.Body = "Estamos realizando una prueba"
        Dim cliente As New System.Net.Mail.SmtpClient()
        'Creamos el objeto que va a "preparar" la autentificación
        Dim autentificacion As New System.Net.NetworkCredential("sistemas@prestamosconfia.com", "Si5t3Ma$CFIA")
        Dim smtp As New System.Net.Mail.SmtpClient
        'Incluimos esta información a la hora de logarnos en el servidor
        smtp.Host = "p3plcpnl0962.prod.phx3.secureserver.net"
        smtp.UseDefaultCredentials = False
        smtp.Credentials = autentificacion
        smtp.Port = 587
        smtp.Send(correo)
    End Sub
End Class