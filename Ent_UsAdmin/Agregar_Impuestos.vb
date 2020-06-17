Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Agregar_Impuestos
    Dim actualizar As Boolean
    Public autorizado As Boolean
    Private Sub Agregar_Impuestos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If actualizar = True Then
            Me.Invoke(Sub()
                          impuestos.cargarimpuestos()
                      End Sub)


        End If
    End Sub

    Private Sub Agregar_Impuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Autorizacion.tipoAutorizacion = "SatiModClientesAgregar"
        Autorizacion.ShowDialog()
        If autorizado Then
            Dim sql As String
            Dim tiempo As String = TimeOfDay.ToString("HH:mm:ss")
            Dim respuesta As String
            sql = "If not exists(select * from Clientes where Nombre = '" & txtnombre.Text & "' and ApellidoPaterno = '" & txtApellidoP.Text & "' and ApellidoMaterno = '" & txtApellidoM.Text & "')
begin
insert into Clientes(Nombre,ApellidoPaterno,ApellidoMaterno,FechaNacimiento,fechaAlta,horaAlta,Telefono,Celular) values('" & txtnombre.Text & "', '" & txtApellidoP.Text & "', '" & txtApellidoM.Text & "', '" & Format(DateNacimiento.Value, "yyyy-MM-dd") & "','" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & txtTelefono.Text & "','" & txtCelular.Text & "') SELECT SCOPE_IDENTITY()
end
else
SELECT 'existe'"
            Dim comandoagregar As SqlCommand
            If txtnombre.Text = "" Then
                MessageBox.Show("No puede dejar el campo nombre en blanco")
            ElseIf txtApellidoP.Text = "" Or txtApellidoM.Text = "" Then
                MessageBox.Show("Por lo menos debe tener un apellido")
            Else
                Try
                    iniciarconexionempresa()
                    comandoagregar = New SqlCommand
                    comandoagregar.Connection = conexionempresa
                    comandoagregar.CommandText = sql
                    respuesta = comandoagregar.ExecuteScalar
                    If respuesta = "existe" Then
                        Dim result As DialogResult = MessageBox.Show("Ya existe un cliente con ese nombre, ¿Desea agregarlo de todos modos?",
                                                                  "Cliente existente",
                                                                  MessageBoxButtons.YesNo)

                        If (result = DialogResult.Yes) Then
                            Dim comandoAgregarAunAsi As SqlCommand
                            Dim consultaAgregarAunAsi As String
                            consultaAgregarAunAsi = "insert into Clientes(Nombre,ApellidoPaterno,ApellidoMaterno,FechaNacimiento,fechaAlta,horaAlta,Telefono,Celular) values('" & txtnombre.Text & "', '" & txtApellidoP.Text & "', '" & txtApellidoM.Text & "', '" & Format(DateNacimiento.Value, "yyyy-MM-dd") & "','" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & txtTelefono.Text & "','" & txtCelular.Text & "')"
                            comandoAgregarAunAsi = New SqlCommand
                            comandoAgregarAunAsi.Connection = conexionempresa
                            comandoAgregarAunAsi.CommandText = consultaAgregarAunAsi
                            comandoAgregarAunAsi.ExecuteNonQuery()
                        Else
                            MessageBox.Show("No fue agregado el cliente")
                        End If
                    Else
                        actualizar = True
                        MessageBox.Show("Listo")
                        txtnombre.Text = ""
                        txtApellidoP.Text = ""
                        txtApellidoM.Text = ""
                        txtCelular.Text = ""
                        txtTelefono.Text = ""
                    End If

                Catch ex As Exception
                    actualizar = False
                    MessageBox.Show(ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("No fue autorizado")
        End If



    End Sub
End Class