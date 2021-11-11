Imports System.Data.SqlClient

Public Class CreditosEnLegal
    Dim strimpuestos As String
    Private Sub CreditosPorEntregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each row As DataRow In dataPermisos.Rows
            If row("SatiModLegalConvenio") Then
                EntregarToolStripMenuItem.Visible = True
                Exit For
            Else
                EntregarToolStripMenuItem.Visible = False
                Exit For
            End If


        Next

        For Each row As DataRow In dataPermisos.Rows
            If row("SatiModLegalVer") Then
                InformacionToolStripMenuItem.Visible = True
                ToolStripMenuItem2.Visible = True
                Exit For
            Else
                ToolStripMenuItem2.Visible = False
                InformacionToolStripMenuItem.Visible = False
                Exit For
            End If


        Next

        cargarSolicitudes()
        txtnombre.Select()
    End Sub
    Public Sub cargarSolicitudes()
        dtimpuestos.Rows.Clear()
        Try

            iniciarconexionempresa()

            strimpuestos = "select legales.Id,legales.Fecha,legales.Nombre,legales.TotalDeuda,TiposDeCredito.Nombre as Tipo,Empleados.Nombre as Gestor,legales.Estado from legales inner join TiposDeCredito on legales.tipo = TiposDeCredito.id inner join Empleados on legales.idGestorLegal = Empleados.id where legales.Nombre like '%" & txtnombre.Text & "%' order by legales.Nombre asc "

            Dim ejec = New SqlCommand(strimpuestos)
            ejec.Connection = conexionempresa
            Dim id, nombre As String

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
        If Now.Date <= "2021-11-16" Then
            DescuentoBuenFinToolStripMenuItem.Visible = True
        Else
            DescuentoBuenFinToolStripMenuItem.Visible = False

        End If

        If dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(6).Value = "A" Then
            dtimpuestos.ContextMenuStrip = ContextMenuEntregar
            CrearPromesaDePagoToolStripMenuItem.Visible = False
            EntregarToolStripMenuItem.Visible = True
        ElseIf dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(6).Value = "C" Then
            ' dtimpuestos.ContextMenuStrip = ContextMenuInformacion
            dtimpuestos.ContextMenuStrip = ContextMenuEntregar
            CrearPromesaDePagoToolStripMenuItem.Visible = True
            EntregarToolStripMenuItem.Visible = False
        ElseIf dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(6).Value = "T" Then
            dtimpuestos.ContextMenuStrip = ContextMenuEntregar
            CrearPromesaDePagoToolStripMenuItem.Visible = False

            EntregarToolStripMenuItem.Visible = False
        Else



            dtimpuestos.ContextMenuStrip = Nothing

        End If
    End Sub

    Private Sub EntregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntregarToolStripMenuItem.Click
        CrearConvenioLegal.idCreditoLegal = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        CrearConvenioLegal.Show()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)
        cargarSolicitudes()
    End Sub

    Private Sub InformacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformacionToolStripMenuItem.Click
        Dim frmLegal As New InformacionLegal
        frmLegal.idCredito = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        '  InformacionLegal.idCredito = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        '  DatosConsultaSolicitud.TipoSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(5).Value
        frmLegal.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim frmLegal As New InformacionLegal
        frmLegal.idCredito = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        'InformacionLegal.idCredito = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        '  DatosConsultaSolicitud.TipoSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(5).Value
        frmLegal.Show()
    End Sub

    Private Sub MonoFlat_HeaderLabel1_Click(sender As Object, e As EventArgs) Handles MonoFlat_HeaderLabel1.Click

    End Sub

    Private Sub txtnombre_OnValueChanged(sender As Object, e As EventArgs) Handles txtnombre.OnValueChanged

    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        cargarSolicitudes()
    End Sub

    Private Sub txtnombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            cargarSolicitudes()
        End If
    End Sub

    Private Sub CrearPromesaDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearPromesaDePagoToolStripMenuItem.Click
        PromPagoLegal.idCredito = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        PromPagoLegal.estadoCredito = "L"
        PromPagoLegal.Show()
    End Sub

    Private Sub DescuentoBuenFinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescuentoBuenFinToolStripMenuItem.Click
        PromPagoLegalBuenFin.idCredito = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        PromPagoLegalBuenFin.estadoCredito = "L"
        PromPagoLegalBuenFin.Show()
    End Sub
End Class