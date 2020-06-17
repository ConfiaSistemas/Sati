Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class AgregarTipoDocumentoSolicitud
    Dim insertar As Boolean
    Public autorizado As Boolean
    Private Sub btn_Procesar_Click(sender As Object, e As EventArgs) Handles btn_Procesar.Click
        Autorizacion.tipoAutorizacion = "SatiModTipoDocumentosAgregar"
        Autorizacion.ShowDialog()
        If autorizado Then
            Try
                iniciarconexionempresa()
                Dim comando As SqlCommand

                Dim consulta As String
                consulta = "Insert into TiposDeDocumentosSolicitud values('" & txtNombre.Text & "','" & ComboTipo.selectedValue & "')"
                comando = New SqlCommand
                comando.Connection = conexionempresa
                comando.CommandText = consulta
                comando.ExecuteNonQuery()
                insertar = True
                MessageBox.Show("Listo")
                txtNombre.Text = ""
            Catch ex As Exception
                insertar = False
                MessageBox.Show("Ha ocurrido un error " & ex.Message)
            End Try
        Else
            MessageBox.Show("No fue autorizado")
        End If


    End Sub

    Private Sub AgregarTipoDocumentoSolicitud_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If insertar Then
            TiposDocumentosSolicitud.cargarDocumentos()

        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseWheel(sender As Object, e As MouseEventArgs) Handles Panel1.MouseWheel
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub AgregarTipoDocumentoSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class