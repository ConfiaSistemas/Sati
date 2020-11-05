Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class GestionesLegal
    Public idLegal As Integer
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub BackgroundGestiones_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundGestiones.DoWork
        iniciarconexionempresa()

        Dim comandoGestiones As SqlCommand
        Dim consultaGestiones As String
        Dim readerGestiones As SqlDataReader
        consultaGestiones = "select Fecha,Concepto,NombreUsuario from GestionesLegales where idCredito = " & idLegal
        comandoGestiones = New SqlCommand
        comandoGestiones.Connection = conexionempresa
        comandoGestiones.CommandText = consultaGestiones
        readerGestiones = comandoGestiones.ExecuteReader
        If readerGestiones.HasRows Then
            While readerGestiones.Read
                dtimpuestos.Rows.Add(Format(readerGestiones("Fecha"), "yyyy-MM-dd"), readerGestiones("Concepto"), readerGestiones("NombreUsuario"))
            End While
        End If
    End Sub

    Private Sub Retiros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGestiones()
    End Sub

    Private Sub BackgroundGestiones_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundGestiones.RunWorkerCompleted
        dtimpuestos.ScrollBars = ScrollBars.Both
        Cargando.Close()
    End Sub

    Public Sub CargarGestiones()
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando Información"
        Cargando.TopMost = True
        dtimpuestos.Rows.Clear()
        dtimpuestos.ScrollBars = ScrollBars.None

        BackgroundGestiones.RunWorkerAsync()
    End Sub
End Class