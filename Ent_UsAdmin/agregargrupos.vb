Imports System.Data.OleDb

Public Class agregargrupos
    Dim actualizar As Boolean = False
    Public autorizado As Boolean

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub



    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Autorizacion.tipoAutorizacion = "SatiModGruposAgregar"
        Autorizacion.ShowDialog()
        If autorizado Then
            Dim sql As String
            Dim idGrupoasignado As String
            sql = "insert into grp(cdg,nm) values('" & txtcodigo.Text & "','" & txtnombre.Text & "') SELECT SCOPE_IDENTITY()"
            Dim comandoagregar As OleDbCommand
            Try
                iniciarconexionR()
                comandoagregar = New OleDbCommand
                comandoagregar.Connection = conexionempresaR
                comandoagregar.CommandText = sql
                idGrupoasignado = comandoagregar.ExecuteScalar
                Dim comandoAgregarPermisos As OleDbCommand
                Dim consultaAgregarPermisos As String
                consultaAgregarPermisos = "insert into PermisosGrupo values('" & idGrupoasignado & "',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0)"
                comandoAgregarPermisos = New OleDbCommand
                comandoAgregarPermisos.Connection = conexionempresaR
                comandoAgregarPermisos.CommandText = consultaAgregarPermisos
                comandoAgregarPermisos.ExecuteNonQuery()

                actualizar = True
                MessageBox.Show("Listo")
                MessageBox.Show("El grupo creado por defecto no tiene ningún permiso asignado, puedes asignarselos en el apartado grupos")
            Catch ex As Exception
                actualizar = False
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("No fue autorizado")
        End If

    End Sub

    Private Sub agregargrupos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If actualizar = True Then
            Me.Invoke(Sub()
                          grupos.cargargrupos()
                      End Sub)


        End If
    End Sub

    Private Sub EvolveControlBox1_Click(sender As Object, e As EventArgs) Handles EvolveControlBox1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    

End Class