Imports System.Data.SqlClient

Public Class CreditosPorEntregar
    Private Sub CreditosPorEntregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarSolicitudes()
    End Sub
    Public Sub cargarSolicitudes()
        dtimpuestos.Rows.Clear()
        Try
            Dim strimpuestos As String
            iniciarconexionempresa()

            strimpuestos = "select * from
(select SinEntregar.*,case when sinentregar.ciudad <> '" & CiudadEmpresa & "' and Ciudad <> '' and Ciudad <> '0' and Ciudad <> '-' then 1 else  isnull((select count(id) from ticket where idCredito = SinEntregar.id and TipoDoc = '2' and estado = 'A'),0) END as Cobrado from
(select credito.id,credito.Fecha,credito.Nombre,credito.Monto,credito.Plazo,credito.fechaEntrega,credito.estado,ISNULL((select Ciudad from DatosSolicitud where DatosSolicitud.IdSolicitud = Credito.IdSolicitud and DatosSolicitud.IdCliente = Credito.IdCliente),0) as Ciudad from credito  where (credito.Estado = 'E' or credito.estado = 'P') ) SinEntregar) ComisionCobrada where Cobrado = 1 "

            Dim ejec = New SqlCommand(strimpuestos)
            ejec.Connection = conexionempresa
            Dim id, nombre, valor, factor, tipo As String

            Dim myreaderimpuestos As SqlDataReader = ejec.ExecuteReader()
            While myreaderimpuestos.Read
                id = myreaderimpuestos("id")
                nombre = myreaderimpuestos("nombre")

                dtimpuestos.Rows.Add(id, myreaderimpuestos("fecha"), nombre, FormatCurrency(myreaderimpuestos("Monto"), 2), myreaderimpuestos("Plazo"), myreaderimpuestos("Cobrado"), myreaderimpuestos("Estado"), myreaderimpuestos("ciudad"))
            End While
            myreaderimpuestos.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub dtimpuestos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtimpuestos.CellContentClick

    End Sub

    Private Sub dtimpuestos_SelectionChanged(sender As Object, e As EventArgs) Handles dtimpuestos.SelectionChanged
        If dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(5).Value = "1" Then
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
End Class