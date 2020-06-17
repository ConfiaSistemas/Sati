Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class AgregarGestionCredito

    Public idCredito As String

    Private Sub AgregarGestionLegal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BackgroundGestion_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundGestion.DoWork
        iniciarconexionempresa()
        Dim comandoGestion As SqlCommand
        Dim consultaGestion As String
        Dim tiempo As String = TimeOfDay.ToString("HH:mm:ss")
        consultaGestion = "insert into GestionesCredito values('" & Now.ToString("yyyy-MM-dd") & "','" & idCredito & "','" & txtConcepto.Text & "')"
        comandoGestion = New SqlCommand
        comandoGestion.Connection = conexionempresa
        comandoGestion.CommandText = consultaGestion
        comandoGestion.ExecuteNonQuery()

    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Ejecutando"
        BackgroundGestion.RunWorkerAsync()

    End Sub

    Private Sub BackgroundGestion_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundGestion.RunWorkerCompleted
        Me.Invoke(Sub()
                      InformacionSolicitud.BackgroundClientes.RunWorkerAsync()

                  End Sub)
        Cargando.Close()
        Me.Close()

    End Sub
End Class