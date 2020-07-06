Imports System.Data.SqlClient

Public Class EmpeñosPorEntregar
    Private Sub CreditosPorEntregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarSolicitudes()
    End Sub
    Public Sub cargarSolicitudes()
        dtimpuestos.Rows.Clear()
        Try
            Dim strimpuestos As String
            iniciarconexionempresa()

            strimpuestos = "select id,format(Fecha,'yyyy-MM-dd')as Fecha,Nombre,MontoPrestado,MontoRefrendo,estado from Empeños where (Estado = 'E' or estado = 'P')"

            Dim ejec = New SqlCommand(strimpuestos)
            ejec.Connection = conexionempresa
            Dim id, nombre, valor, factor, tipo As String

            Dim myreaderimpuestos As SqlDataReader = ejec.ExecuteReader()
            While myreaderimpuestos.Read
                id = myreaderimpuestos("id")
                nombre = myreaderimpuestos("nombre")

                dtimpuestos.Rows.Add(id, myreaderimpuestos("fecha"), nombre, FormatCurrency(myreaderimpuestos("MontoPrestado"), 2), FormatCurrency(myreaderimpuestos("MontoRefrendo"), 2), myreaderimpuestos("Estado"), myreaderimpuestos("Estado"))
            End While
            myreaderimpuestos.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub dtimpuestos_SelectionChanged(sender As Object, e As EventArgs) Handles dtimpuestos.SelectionChanged
        'If dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(5).Value = "1" Then
        dtimpuestos.ContextMenuStrip = ContextMenuEntregar

        'Else

        '    dtimpuestos.ContextMenuStrip = Nothing

        'End If
    End Sub

    Private Sub EntregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntregarToolStripMenuItem.Click
        EntregarDocumentacionEmpeño.idEmpeñoAentregar = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        EntregarDocumentacionEmpeño.Show()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        cargarSolicitudes()
    End Sub

    Private Sub ContextMenuEntregar_Click(sender As Object, e As EventArgs) Handles ContextMenuEntregar.Click

    End Sub
End Class