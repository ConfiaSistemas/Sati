Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class impuestos
    Dim strimpuestos As String
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Agregar_Impuestos.Show()

    End Sub




    Public Sub cargarimpuestos()
        dtimpuestos.Rows.Clear()
        Try

            iniciarconexionempresa()

            strimpuestos = "select * from
(select id,concat(nombre, ' ',apellidopaterno,' ',apellidomaterno) as nombre from clientes)cli where cli.nombre like '%" & txtnombre.Text & "%' order by cli.nombre asc "

            Dim ejec = New SqlCommand(strimpuestos)
            ejec.Connection = conexionempresa
            Dim id, nombre, valor, factor, tipo As String

            Dim myreaderimpuestos As SqlDataReader = ejec.ExecuteReader()
            While myreaderimpuestos.Read
                id = myreaderimpuestos("id")
                nombre = myreaderimpuestos("nombre")

                dtimpuestos.Rows.Add(id, nombre)
            End While
            myreaderimpuestos.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub impuestos_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargarimpuestos()
        txtnombre.Select()

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        cargarimpuestos()
    End Sub

    Private Sub VerInformaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerInformaciónToolStripMenuItem.Click
        InformacionCliente.idCLiente = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value

        InformacionCliente.Show()
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub dtimpuestos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtimpuestos.CellContentClick

    End Sub

    Private Sub dtimpuestos_SelectionChanged(sender As Object, e As EventArgs) Handles dtimpuestos.SelectionChanged
        If dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(1).Value <> "" Then
            dtimpuestos.ContextMenuStrip = ContextMenuStrip1

        End If
    End Sub

    Private Sub MonoFlat_Label1_Click(sender As Object, e As EventArgs) Handles MonoFlat_Label1.Click

    End Sub

    Private Sub txtnombre_OnValueChanged(sender As Object, e As EventArgs) Handles txtnombre.OnValueChanged

    End Sub

    Private Sub txtnombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            cargarimpuestos()
        End If
    End Sub

    Private Sub ImprimirTarjetaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirTarjetaToolStripMenuItem.Click
        ImprimirTarjeta.idCredito = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value

        ImprimirTarjeta.Show()
    End Sub
End Class