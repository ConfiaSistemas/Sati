Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class CatTiposdeCredito
    Private Sub CatTiposdeCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTipos()
    End Sub
    Public Sub cargarTipos()
        dtimpuestos.Rows.Clear()
        Try
            Dim strimpuestos As String
            iniciarconexionempresa()

            strimpuestos = "select * from TiposDeCredito"

            Dim ejec = New SqlCommand(strimpuestos)
            ejec.Connection = conexionempresa
            Dim id, nombre, Modalidad, Tipo, Plazo As String

            Dim myreaderimpuestos As SqlDataReader = ejec.ExecuteReader()
            While myreaderimpuestos.Read
                id = myreaderimpuestos("id")
                nombre = myreaderimpuestos("nombre")
                Modalidad = myreaderimpuestos("Modalidad")
                Tipo = myreaderimpuestos("Tipo")
                Plazo = myreaderimpuestos("Plazo")
                dtimpuestos.Rows.Add(id, nombre, Modalidad, Tipo, Plazo)

            End While
            myreaderimpuestos.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        AgregarTipoCredito.Show()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        cargarTipos()
    End Sub

    Private Sub dtimpuestos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtimpuestos.CellContentClick

    End Sub

    Private Sub dtimpuestos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtimpuestos.CellContentDoubleClick
        DocumentosNecesarios.idTipo = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        DocumentosNecesarios.Show()

    End Sub
End Class