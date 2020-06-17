Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class AgregarGastosLegales
    Public idCredito As String

    Private Sub AgregarGastosLegales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BackgroundGastos_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundGastos.DoWork
        iniciarconexionempresa()
        Dim comandoGastos As SqlCommand
        Dim consultaGastos As String
        consultaGastos = "insert into GastosLegales values('" & Now.ToString("yyyy-MM-dd") & "','" & idCredito & "','" & txtMonto.Text & "','" & txtConcepto.Text & "','" & nmusr & "','" & nm_completeusr & "')"
        comandoGastos = New SqlCommand
        comandoGastos.Connection = conexionempresa
        comandoGastos.CommandText = consultaGastos
        comandoGastos.ExecuteNonQuery()

    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Insertando Gastos"
        Cargando.TopMost = True
        BackgroundGastos.RunWorkerAsync()
    End Sub

    Private Sub BackgroundGastos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundGastos.RunWorkerCompleted
        Me.Invoke(Sub()
                      InformacionLegal.BackgroundClientes.RunWorkerAsync()

                  End Sub)
        Cargando.Close()
        Me.Close()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub
End Class