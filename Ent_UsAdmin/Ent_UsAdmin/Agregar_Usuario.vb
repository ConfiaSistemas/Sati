Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Text

Public Class Agregar_Usuario
    Dim actualizar As Boolean = False
    Public autorizado As Boolean
    Public nombre, usuario, contraseña, idusuario, pass, passdecrypt As String
    Public grupo As String
    Public activo As Boolean
    Public fecha_alta As Date
    Dim cantidadgrupos As Integer
    Dim nombregrupo(1000) As String
    Dim codigogrupo(1000) As String
    Dim idgrupo(1000) As String
    Dim mostrarcontraseña As Boolean = False


    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub






    Private Sub Editar_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerformato.Enabled = True
        cargargrupos()
        ConsultarEmpleado()

        dateusr.Value = Today

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


    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Autorizacion.tipoAutorizacion = "SatiModUsuariosAgregar"
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


                'sql = "update usr set nm = '" & txtusuario.Text & "',nm_complete='" & txtnombre.Text & "',pass='" & contraseña & "',grp='" & txtgrupo.Text & "',fecha_alta='" & dateusr.Value & "',activo='" & activosql & "' where idusr = '" & idusuario & "'"

                sql = "insert into usr(nm,pass,grp,nm_complete,addr,imgstr,tlf,fecha_alta,activo) values('" & txtusuario.Text & "','" & contraseña & "','" & txtgrupo.Text & "','" & txtnombre.Text & "','','','','" & dateusr.Value & "','" & activosql & "')"
                Dim comandoagregar As OleDbCommand

                iniciarconexionR()
                comandoagregar = New OleDbCommand
                comandoagregar.Connection = conexionempresaR
                comandoagregar.CommandText = sql
                comandoagregar.ExecuteNonQuery()

                If txtempleado.Text <> "0" Then
                    iniciarconexionempresa()
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
            BuscarEmpleadoUsuario.Show()
        End If
    End Sub
End Class