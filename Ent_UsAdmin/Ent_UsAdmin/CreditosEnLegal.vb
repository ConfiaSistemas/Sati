Imports System.Data.SqlClient

Public Class CreditosEnLegal

    Private Sub CreditosPorEntregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarSolicitudes()
    End Sub
    Public Sub cargarSolicitudes()
        dtimpuestos.Rows.Clear()
        Try
            Dim strimpuestos As String
            iniciarconexionempresa()

            strimpuestos = "select legales.Id,legales.Fecha,legales.Nombre,legales.TotalDeuda,TiposDeCredito.Nombre as Tipo,Empleados.Nombre as Gestor,legales.Estado from legales inner join TiposDeCredito on legales.tipo = TiposDeCredito.id inner join Empleados on legales.idGestorLegal = Empleados.id "

            Dim ejec = New SqlCommand(strimpuestos)
            ejec.Connection = conexionempresa
            Dim id, nombre, valor, factor, tipo As String

            Dim myreaderimpuestos As SqlDataReader = ejec.ExecuteReader()
            While myreaderimpuestos.Read
                id = myreaderimpuestos("id")
                nombre = myreaderimpuestos("nombre")

                dtimpuestos.Rows.Add(id, myreaderimpuestos("fecha"), nombre, FormatCurrency(myreaderimpuestos("TotalDeuda"), 2), myreaderimpuestos("Tipo"), myreaderimpuestos("Gestor"), myreaderimpuestos("Estado"))
            End While
            myreaderimpuestos.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub dtimpuestos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtimpuestos.CellContentClick

    End Sub

    Private Sub dtimpuestos_SelectionChanged(sender As Object, e As EventArgs) Handles dtimpuestos.SelectionChanged
        If dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(6).Value = "A" Then
            dtimpuestos.ContextMenuStrip = ContextMenuEntregar

        ElseIf dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(6).Value = "C" Then
            dtimpuestos.ContextMenuStrip = ContextMenuInformacion
        Else


            dtimpuestos.ContextMenuStrip = Nothing

        End If
    End Sub

    Private Sub EntregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntregarToolStripMenuItem.Click
        CrearConvenioLegal.idCreditoLegal = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        CrearConvenioLegal.Show()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        cargarSolicitudes()
    End Sub

    Private Sub InformacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformacionToolStripMenuItem.Click
        InformacionLegal.idCredito = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        '  DatosConsultaSolicitud.TipoSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(5).Value
        InformacionLegal.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        InformacionLegal.idCredito = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        '  DatosConsultaSolicitud.TipoSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(5).Value
        InformacionLegal.Show()
    End Sub
End Class