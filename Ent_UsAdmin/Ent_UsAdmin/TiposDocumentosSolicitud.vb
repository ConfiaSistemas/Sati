Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class TiposDocumentosSolicitud
    Private Sub TiposDocumentosSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDocumentos()
    End Sub


    Public Sub cargarDocumentos()
        dtimpuestos.Rows.Clear()
        Try
            Dim strimpuestos As String
            iniciarconexionempresa()

            strimpuestos = "select * from TiposdeDocumentosSolicitud"

            Dim ejec = New SqlCommand(strimpuestos)
            ejec.Connection = conexionempresa
            Dim id, nombre, valor, factor, tipo As String

            Dim myreaderimpuestos As SqlDataReader = ejec.ExecuteReader()
            While myreaderimpuestos.Read
                id = myreaderimpuestos("id")
                nombre = myreaderimpuestos("nombre")

                dtimpuestos.Rows.Add(id, nombre, myreaderimpuestos("tipo"))
            End While
            myreaderimpuestos.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        cargarDocumentos()
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        AgregarTipoDocumentoSolicitud.Show()
    End Sub
End Class