Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class AgregarCaja
    Dim conerror As Boolean
    Public autorizado As Boolean
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Try
            iniciarconexionempresa()
            Dim comandoInsertaCaja As SqlCommand
            Dim consultaInsertaCaja As String
            consultaInsertaCaja = "insert into CajasSucursal values('" & txtNocaja.Text & "','" & txtFondo.Text & "','" & txtlimite.Text & "')"
            comandoInsertaCaja = New SqlCommand
            comandoInsertaCaja.Connection = conexionempresa
            comandoInsertaCaja.CommandText = consultaInsertaCaja
            comandoInsertaCaja.ExecuteNonQuery()
            conerror = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conerror = True
        End Try


    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Cargando.Close()
        If conerror Then
        Else
            txtFondo.Text = ""
            txtNocaja.Text = ""
            txtNocaja.Select()
        End If
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Autorizacion.tipoAutorizacion = "SatiModCajasAgregar"
        Autorizacion.ShowDialog()
        If autorizado Then
            Cargando.Show()
            Cargando.MonoFlat_Label1.Text = "Insertando Caja"
            BackgroundWorker1.RunWorkerAsync()
        Else
            MessageBox.Show("No fue autorizado")
        End If

    End Sub

    Private Sub AgregarCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False

    End Sub

    Private Sub AgregarCaja_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Invoke(Sub()
                      Cajas.cargarCajas()
                  End Sub)
    End Sub
End Class