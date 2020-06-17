Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Text

Public Class Editar_Usuario
    Dim actualizar As Boolean = False

    Public nombre, usuario, contraseña, idusuario, pass, passdecrypt As String
    Public grupo As String
    Public activo As Boolean
    Public fecha_alta As Date
    Dim cantidadgrupos As Integer
    Dim nombregrupo(1000) As String
    Dim codigogrupo(1000) As String
    Dim idgrupo(1000) As String
    Dim mostrarcontraseña As Boolean = False
    Public autorizado As Boolean

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub






    Private Sub Editar_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerformato.Enabled = True
        cargargrupos()
        cargarusuario()

    End Sub

    Public Sub cargargrupos()
        Try
            Dim strgrupos As String
            strgrupos = "select id,nm,cdg from grp"
            Dim ejec = New OleDbCommand(strgrupos)
            ejec.Connection = conexionempresaR
            Dim labelgrupo As Label

            Dim numero As Integer = 0

            Dim myreadergrupos As OleDbDataReader = ejec.ExecuteReader()
            While myreadergrupos.Read
                labelgrupo = New Label

                idgrupo(numero) = myreadergrupos("id")
                codigogrupo(numero) = myreadergrupos("cdg")

                nombregrupo(numero) = myreadergrupos("nm")
                labelgrupo.Name = idgrupo(numero)
                labelgrupo.AutoSize = True
                labelgrupo.Text = idgrupo(numero) & "-" & codigogrupo(numero) & "-" & nombregrupo(numero)
                labelgrupo.ForeColor = Color.White
                AddHandler labelgrupo.Click, AddressOf clickevent
                FlowLayoutPanel1.Controls.Add(labelgrupo)
                numero += 1
                cantidadgrupos = numero
            End While
            myreadergrupos.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FlowLayoutPanel1.Location = New Point(lblgrupo.Location.X, lblgrupo.Location.Y - lblgrupo.Height - FlowLayoutPanel1.Height)
        If FlowLayoutPanel1.Visible = False Then
            FlowLayoutPanel1.Visible = True
            FlowLayoutPanel1.BringToFront()
        Else
            FlowLayoutPanel1.Visible = False
        End If


    End Sub

    Public Sub cargarusuario()
        Try
            Dim strusuario As String
            strusuario = "select nm,nm_complete,pass,grp,fecha_alta,activo from usr where idusr= '" & idusuario & "'"
            Dim ejec = New OleDbCommand(strusuario)
            ejec.Connection = conexionempresaR
            Dim myreaderusuario As OleDbDataReader = ejec.ExecuteReader()
            While myreaderusuario.Read
                usuario = myreaderusuario("nm")
                nombre = myreaderusuario("nm_complete")
                pass = myreaderusuario("pass")
                grupo = myreaderusuario("grp")
                If Not IsDBNull(myreaderusuario("fecha_alta")) Then
                    fecha_alta = myreaderusuario("fecha_alta")

                End If
                If Not IsDBNull(myreaderusuario("activo")) Then
                    activo = myreaderusuario("activo")
                End If


            End While

            Dim byteconverter As New UnicodeEncoding()
            Dim CadByte As Byte() = System.Convert.FromBase64String(pass)

            Dim DecryptedMessage As Encryption.RSAResult = Encryption.RSA.Decrypt(CadByte, "<RSAKeyValue><Modulus>1D3WnN4qZq3DGHf7i3WjEixX0Nzka28RIR9lOrT7Eg2QmJTACm/E6388wMdGgH3yTwKPp/T5zm61yvZn44oHMka8EKlACGKkADsxN/ci0RLKJ0ZGYDVPtB+KSzI+GbmX2eO00R+FlYvXTpMzGXy3e4QpeCJbIbrDGFpt3rmXy28=</Modulus><Exponent>AQAB</Exponent><P>98YU9Nkhu3qQ4Y168ZbMX+kCFUEPK9mRDEc2yZiyfABU9UlrKU4Ja1qy47WJrQNSALA9nnARZgbiY/3JkslISQ==</P><Q>20nBaoUN5QK9cuH6yX0QqAzhhB88rsI/HFzb8xrbEkceNfsTbYOVt+7biqzQQAvsyEILU+0l529eSe6S52yl9w==</Q><DP>wk3CLWkBfQZXC6ppmX9KcoRFr+k/PoH1r41BN8LZZUjVVy3mLZQW6utLkirQ9q695fBPwincWwhXDVb+dnAGkQ==</DP><DQ>Ks/0hhJiCxME37gE2W+kX9rb8IqUs13TKntqqcTVfnUKDent+hSVl2p3zFQ++DIb0WEriwAixVN16iM85RfOMw==</DQ><InverseQ>coc9FIy42//YO02qCCKfORevLIU8GIeTSYFqD9kMwhHSy1a6QMDpKaYWrYvv8FcMHglqWzdTqbSgBSrsfcnibw==</InverseQ><D>JvPie4/awFWLxOXgaMwCTceNpmukEIOl5SpZ7dhhbALJUveZ91BkF8SWZdss+VAkNJQHwY+YeWagPsvSbVRb1WylY11D8gBQEb6EOR3EsM17/5+v6nRrJ5+cySfpcahRbUjUdJFaVhMCUQ1wsnevLNY/Xo20UF4XCE5Exp7TW0E=</D></RSAKeyValue>")
            passdecrypt = DecryptedMessage.AsString
            txtusuario.Text = usuario
            txtnombre.Text = nombre

            txtcontra.Text = passdecrypt
            txtcontra.isPassword = True
            txtgrupo.Text = grupo
            If fecha_alta = Convert.ToDateTime("01/01/1900 12:00:00 AM") Then
                dateusr.Value = Today
            Else
                dateusr.Value = fecha_alta
            End If
            If activo = False Then
                Switchactivo.Value = False
            Else
                Switchactivo.Value = True

            End If

            iniciarconexionempresa()

            Dim comandoEmpleado As SqlCommand
            Dim consultaEmpleado As String
            Dim readerEmpleado As SqlDataReader
            consultaEmpleado = "select idempleado from empleadosAsignados where usr = '" & usuario & "'"
            comandoEmpleado = New SqlCommand
            comandoEmpleado.Connection = conexionempresa
            comandoEmpleado.CommandText = consultaEmpleado
            readerEmpleado = comandoEmpleado.ExecuteReader
            If readerEmpleado.HasRows Then
                While readerEmpleado.Read
                    txtempleado.Text = readerEmpleado("idempleado")

                End While
                ConsultarEmpleado()

            Else
                txtempleado.Text = "0"
                ConsultarEmpleado()

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub timerformato_Tick(sender As Object, e As EventArgs) Handles timerformato.Tick
        timerformato.Interval = 1
        If mostrarcontraseña = False Then
            txtcontra.isPassword = True
        Else
            txtcontra.isPassword = False
        End If


    End Sub

    Private Sub txtempleado_OnValueChanged(sender As Object, e As EventArgs) Handles txtempleado.OnValueChanged

    End Sub

    Private Sub txtgrupo_TextChanged(sender As Object, e As EventArgs) Handles txtgrupo.TextChanged
        For numero As Integer = 0 To cantidadgrupos
            If txtgrupo.Text = idgrupo(numero) Then
                lblcdggrp.Text = codigogrupo(numero)
                lblnmgrp.Text = nombregrupo(numero)
                Exit For
            Else
                lblcdggrp.Text = "No existe"
                lblnmgrp.Text = "No existe"

            End If
        Next
    End Sub
    Public Sub clickevent(ByVal sender As Object, ByVal e As EventArgs)

        ' Dim label = DirectCast(sender, Label)

        txtgrupo.Text = sender.name
        FlowLayoutPanel1.Visible = False





    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        If mostrarcontraseña = False Then
            Label5.BorderStyle = BorderStyle.Fixed3D
            Label5.BackColor = Color.FromArgb(223, 223, 223)
            mostrarcontraseña = True
        Else
            Label5.BorderStyle = BorderStyle.None
            Label5.BackColor = Color.DimGray
            mostrarcontraseña = False
        End If
    End Sub


    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Autorizacion.tipoAutorizacion = "SatiModUsuariosModificar"
        Autorizacion.ShowDialog()
        If autorizado Then
            Try
                Dim EncryptedMessage As Encryption.RSAResult = Encryption.RSA.Encrypt(txtcontra.Text, "<RSAKeyValue><Modulus>1D3WnN4qZq3DGHf7i3WjEixX0Nzka28RIR9lOrT7Eg2QmJTACm/E6388wMdGgH3yTwKPp/T5zm61yvZn44oHMka8EKlACGKkADsxN/ci0RLKJ0ZGYDVPtB+KSzI+GbmX2eO00R+FlYvXTpMzGXy3e4QpeCJbIbrDGFpt3rmXy28=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>")
                Dim contraseña As String
                Dim activosql As Integer
                contraseña = EncryptedMessage.AsBase64String
                Dim sql As String
                If Switchactivo.Value = False Then
                    activosql = 0
                Else
                    activosql = 1
                End If
                sql = "update usr set nm = '" & txtusuario.Text & "',nm_complete='" & txtnombre.Text & "',pass='" & contraseña & "',grp='" & txtgrupo.Text & "',fecha_alta='" & dateusr.Value & "',activo='" & activosql & "' where idusr = '" & idusuario & "'"
                Dim comandoagregar As OleDbCommand

                iniciarconexionR()
                comandoagregar = New OleDbCommand
                comandoagregar.Connection = conexionempresaR
                comandoagregar.CommandText = sql
                comandoagregar.ExecuteNonQuery()

                iniciarconexionempresa()
                Dim comandoEliminarEmpleado As SqlCommand
                Dim consultaEliminarEmpleado As String
                consultaEliminarEmpleado = "Delete from empleadosAsignados where usr = '" & usuario & "'"
                comandoEliminarEmpleado = New SqlCommand
                comandoEliminarEmpleado.Connection = conexionempresa
                comandoEliminarEmpleado.CommandText = consultaEliminarEmpleado
                comandoEliminarEmpleado.ExecuteNonQuery()

                If txtempleado.Text <> "0" Then
                    Dim comandoAempleado As SqlCommand
                    Dim consultaAempleado As String
                    consultaAempleado = "IF NOT EXISTS((select * from empleadosAsignados where usr = '" & txtusuario.Text & "' and idempleado = '" & txtempleado.Text & "'))
BEGIN
insert into empleadosAsignados values('" & txtusuario.Text & "','" & txtempleado.Text & "') end"
                    comandoAempleado = New SqlCommand
                    comandoAempleado.Connection = conexionempresa
                    comandoAempleado.CommandText = consultaAempleado
                    comandoAempleado.ExecuteNonQuery()
                Else

                End If

                actualizar = True
                MessageBox.Show("Listo")
            Catch ex As Exception
                actualizar = False
                MessageBox.Show(ex.Message)
            End Try

        Else
            MessageBox.Show("No fue autorizado")
        End If


    End Sub

    Public Sub ConsultarEmpleado()
        If txtempleado.Text <> "0" Then
            iniciarconexionempresa()
            Dim comandoEmpleado As SqlCommand
            Dim consultaEmpleado As String
            consultaEmpleado = "Select nombre from empleados where id = '" & txtempleado.Text & "'"
            comandoEmpleado = New SqlCommand
            comandoEmpleado.Connection = conexionempresa
            comandoEmpleado.CommandText = consultaEmpleado
            lblempleado.Text = comandoEmpleado.ExecuteScalar

        Else
            lblempleado.Text = "Ninguno"
        End If

    End Sub

    Private Sub txtempleado_KeyDown(sender As Object, e As KeyEventArgs) Handles txtempleado.KeyDown
        If e.KeyCode = Keys.Enter Then
            ConsultarEmpleado()

        End If

        If e.KeyCode = Keys.F2 Then
            BuscarEmpleadoUsuarioActualizar.Show()
        End If
    End Sub
End Class