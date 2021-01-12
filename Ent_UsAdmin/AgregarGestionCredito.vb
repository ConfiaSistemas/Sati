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
        If txtConcepto.Text.Length > 1000 Then
            MessageBox.Show("La gestión excede el límite de caracteres. Si es necesario, el texto restante se puede introducir en otra gestión.")
        Else
            Cargando.Show()
            Cargando.MonoFlat_Label1.Text = "Ejecutando"
            BackgroundGestion.RunWorkerAsync()
        End If

    End Sub

    Private Sub BackgroundGestion_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundGestion.RunWorkerCompleted
        Me.Invoke(Sub()
                      InformacionSolicitud.BackgroundClientes.RunWorkerAsync()

                  End Sub)
        Cargando.Close()
        Me.Close()

    End Sub

    Private Sub txtConcepto_TextChanged(sender As Object, e As EventArgs) Handles txtConcepto.TextChanged
        MonoFlat_HeaderLabel2.Text = 1000 - txtConcepto.TextLength
        If txtConcepto.TextLength > 1000 Then
            MonoFlat_HeaderLabel2.ForeColor = Color.Red
            MonoFlat_HeaderLabel3.ForeColor = Color.Red
            MonoFlat_HeaderLabel4.ForeColor = Color.Red
        Else
            MonoFlat_HeaderLabel2.ForeColor = Color.White
            MonoFlat_HeaderLabel3.ForeColor = Color.White
            MonoFlat_HeaderLabel4.ForeColor = Color.White
        End If
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub
End Class