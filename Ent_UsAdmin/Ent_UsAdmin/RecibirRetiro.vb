Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class RecibirRetiro
    Public autorizado As Boolean
    Public idRetiro As Integer
    Public Cantidad As Double
    Private Sub RecibirRetiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMonto.Text = FormatCurrency(Cantidad, 2)
    End Sub

    Private Sub MonoFlat_Button1_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button1.Click
        AutorizacionRetiro.ShowDialog()
        If autorizado Then
            Cargando.Show()
            Cargando.MonoFlat_Label1.Text = "Recibiendo"
            Cargando.TopMost = True
            BackgroundWorker1.RunWorkerAsync()
        Else
            MessageBox.Show("No fue autorizado")
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        iniciarconexionempresa()
        Dim fechainsercionhasta As String
        Dim monto As Double
        Dim fechaRetiro As String
        Dim concepto As String
        monto = txtmonto.Text
        Dim tiempo As String = TimeOfDay.ToString("HH:mm:ss")
        fechainsercionhasta = Now.Date

        Dim fechasqlhasta As Date
        fechasqlhasta = fechainsercionhasta
        fechainsercionhasta = Format(fechasqlhasta, "yyyy-MM-dd")
        fechaRetiro = Format(fechasqlhasta, "dd/MM/yyyy")
        Dim comandoRecibirRetiro As SqlCommand
        Dim consultaRetiro As String
        consultaRetiro = "update Retiros set MontoRecibido = '" & txtmonto.Text & "',fechaRecibido = '" & fechainsercionhasta & "',usuariorecibe = '" & nmusr & "',horarecibido = '" & tiempo & "' where id = '" & idRetiro & "'"
        comandoRecibirRetiro = New SqlCommand
        comandoRecibirRetiro.Connection = conexionempresa
        comandoRecibirRetiro.CommandText = consultaRetiro
        comandoRecibirRetiro.ExecuteNonQuery()

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        Cargando.Close()
        Me.Invoke(Sub()
                      Retiros.CargarRetiros()
                  End Sub)

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