Imports System.Data.SqlClient

Public Class CreditosActivos
    Dim strimpuestos As String
    Private Sub CreditosPorEntregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        cargarSolicitudes()
        txtnombre.Select()

    End Sub
    Public Sub cargarSolicitudes()
        dtimpuestos.Rows.Clear()
        Try

            iniciarconexionempresa()

            strimpuestos = "select id,Fecha,Nombre,Monto,Plazo,format(fechaEntrega,'dd/MM/yyyy') as FechaEntrega,estado from credito where (estado = 'A' or estado = 'C' or estado = 'I' or estado = 'R') and nombre like '%" & txtnombre.Text & "%' order by nombre asc"

            Dim ejec = New SqlCommand(strimpuestos)
            ejec.Connection = conexionempresa
            Dim id, nombre As String

            Dim myreaderimpuestos As SqlDataReader = ejec.ExecuteReader()
            While myreaderimpuestos.Read
                id = myreaderimpuestos("id")
                nombre = myreaderimpuestos("nombre")

                dtimpuestos.Rows.Add(id, myreaderimpuestos("fecha"), nombre, FormatCurrency(myreaderimpuestos("Monto"), 2), myreaderimpuestos("Plazo"), myreaderimpuestos("FechaEntrega"), myreaderimpuestos("Estado"))
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
            CrearReestructuraToolStripMenuItem.Visible = False
            CrearConvenioToolStripMenuItem.Visible = True
            dtimpuestos.ContextMenuStrip = ContextMenuEntregar

        ElseIf dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(6).Value = "C" Then
            CrearReestructuraToolStripMenuItem.Visible = False
            CrearConvenioToolStripMenuItem.Visible = False
            dtimpuestos.ContextMenuStrip = ContextMenuEntregar

        ElseIf dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(6).Value = "I" Then
            CrearReestructuraToolStripMenuItem.Visible = True
            CrearConvenioToolStripMenuItem.Visible = False
            dtimpuestos.ContextMenuStrip = ContextMenuEntregar
        ElseIf dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(6).Value = "R" Then
            CrearReestructuraToolStripMenuItem.Visible = False
            CrearConvenioToolStripMenuItem.Visible = False
            dtimpuestos.ContextMenuStrip = ContextMenuEntregar

        Else

            dtimpuestos.ContextMenuStrip = Nothing

        End If
    End Sub

    Private Sub EntregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntregarToolStripMenuItem.Click
        EntregarDocumentacion.idCreditoAentregar = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        EntregarDocumentacion.Show()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        cargarSolicitudes()
    End Sub

    Private Sub InformacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformacionToolStripMenuItem.Click
        Dim frmInformacion As New InformacionSolicitud
        frmInformacion.idCredito = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        'InformacionSolicitud.idCredito = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        '  DatosConsultaSolicitud.TipoSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(5).Value
        frmInformacion.Show()
    End Sub

    Private Sub CrearConvenioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearConvenioToolStripMenuItem.Click
        CrearConvenio.idCredito = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        CrearConvenio.Show()
    End Sub

    Private Sub txtnombre_OnValueChanged(sender As Object, e As EventArgs) Handles txtnombre.OnValueChanged

    End Sub

    Private Sub txtnombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            cargarSolicitudes()
        End If
    End Sub

    Private Sub MonoFlat_HeaderLabel1_Click(sender As Object, e As EventArgs) Handles MonoFlat_HeaderLabel1.Click

    End Sub

    Private Sub EstadoDeCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoDeCuentaToolStripMenuItem.Click
        EstadoDeCuenta.idCredito = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        EstadoDeCuenta.Show()
    End Sub

    Private Sub CrearReestructuraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearReestructuraToolStripMenuItem.Click
        CrearReestructura.idCredito = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        CrearReestructura.Show()
    End Sub

    Private Sub PromesaDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromesaDePagoToolStripMenuItem.Click
        PromesaPago.idCredito = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        PromesaPago.Show()

    End Sub
End Class