Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class CierresSinRecibir

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub BackgroundRetiros_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundRetiros.DoWork
        iniciarconexionempresa()

        Dim comandoRetiros As SqlCommand
        Dim consultaRetiros As String
        Dim readerRetiros As SqlDataReader
        consultaRetiros = "select id,Caja,UsuarioEntrega,Monto,Fecha,Hora from cierrecajagestores where usuariorecibe = ''"
        comandoRetiros = New SqlCommand
        comandoRetiros.Connection = conexionempresa
        comandoRetiros.CommandText = consultaRetiros
        readerRetiros = comandoRetiros.ExecuteReader
        If readerRetiros.HasRows Then
            While readerRetiros.Read
                dtimpuestos.Rows.Add(readerRetiros("id"), readerRetiros("Caja"), readerRetiros("UsuarioEntrega"), FormatCurrency(readerRetiros("Monto"), 2), Format(readerRetiros("Fecha"), "yyyy-MM-dd"), readerRetiros("hora"))
            End While
        End If
    End Sub

    Private Sub Retiros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarRetiros()
    End Sub

    Private Sub BackgroundRetiros_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundRetiros.RunWorkerCompleted
        dtimpuestos.ScrollBars = ScrollBars.Both
        Cargando.Close()
    End Sub

    Private Sub dtimpuestos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtimpuestos.CellContentClick

    End Sub

    Private Sub dtimpuestos_SelectionChanged(sender As Object, e As EventArgs) Handles dtimpuestos.SelectionChanged
        If dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(5).Value.ToString <> "" Then
            dtimpuestos.ContextMenuStrip = ContextMenuStrip1
        Else
            dtimpuestos.ContextMenuStrip = Nothing
        End If

    End Sub

    Private Sub RecibirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecibirToolStripMenuItem.Click
        RecibirCierre.idRetiro = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        RecibirCierre.Cantidad = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(3).Value
        RecibirCierre.Show()

    End Sub

    Public Sub CargarRetiros()
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando Información"
        Cargando.TopMost = True
        dtimpuestos.Rows.Clear()
        dtimpuestos.ScrollBars = ScrollBars.None

        BackgroundRetiros.RunWorkerAsync()
    End Sub
End Class