Imports System.Data.SqlClient

Public Class EmpeñosActivos
    Dim strimpuestos As String
    Private Sub EmpeñosActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        cargarSolicitudes()
        txtnombre.Select()

    End Sub
    Public Sub cargarSolicitudes()
        dtDatos.Rows.Clear()
        Try

            iniciarconexionempresa()

            strimpuestos = "select id,format(Fecha,'yyyy-MM-dd')as Fecha,Nombre,MontoPrestado,MontoRefrendo, format(FechaPrimerPago,'yyyy-MM-dd')as FechaPrimerPago, Estado from Empeños where (estado = 'A' or estado = 'E') and nombre like '%" & txtnombre.Text & "%' order by nombre asc"

            Dim ejec = New SqlCommand(strimpuestos)
            ejec.Connection = conexionempresa
            Dim id, nombre As String

            Dim myreaderimpuestos As SqlDataReader = ejec.ExecuteReader()
            While myreaderimpuestos.Read
                id = myreaderimpuestos("id")
                nombre = myreaderimpuestos("nombre")

                dtDatos.Rows.Add(id, myreaderimpuestos("fecha"), nombre, FormatCurrency(myreaderimpuestos("MontoPrestado"), 2), FormatCurrency(myreaderimpuestos("MontoRefrendo"), 2), myreaderimpuestos("FechaPrimerPago"), myreaderimpuestos("Estado"))
            End While
            myreaderimpuestos.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub dtimpuestos_SelectionChanged(sender As Object, e As EventArgs) Handles dtDatos.SelectionChanged
        If dtDatos.Rows(dtDatos.CurrentRow.Index).Cells(6).Value = "A" Then

            dtDatos.ContextMenuStrip = ContextMenuEntregar
        Else

            dtDatos.ContextMenuStrip = Nothing

        End If
    End Sub

    Private Sub EntregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntregarToolStripMenuItem.Click
        EntregarDocumentacionEmpeño.idEmpeñoAentregar = dtDatos.Rows(dtDatos.CurrentRow.Index).Cells(0).Value
        EntregarDocumentacionEmpeño.Show()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        cargarSolicitudes()
    End Sub

    Private Sub InformacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformacionToolStripMenuItem.Click
        Dim frmInformacion As New InformacionEmpeño
        frmInformacion.idEmpeño = dtDatos.Rows(dtDatos.CurrentRow.Index).Cells(0).Value
        'InformacionSolicitud.idCredito = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        '  DatosConsultaSolicitud.TipoSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(5).Value
        frmInformacion.Show()
    End Sub

    Private Sub txtnombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            cargarSolicitudes()
        End If
    End Sub

End Class