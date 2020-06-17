Imports System.Data.SqlClient

Public Class Cajas
    Private Sub Cajas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCajas()
    End Sub

    Public Sub cargarCajas()
        dtimpuestos.Rows.Clear()
        Try
            Dim strimpuestos As String
            iniciarconexionempresa()

            strimpuestos = "select * from CajasSucursal"

            Dim ejec = New SqlCommand(strimpuestos)
            ejec.Connection = conexionempresa
            Dim id, numero, valor, factor, tipo As String

            Dim myreaderimpuestos As SqlDataReader = ejec.ExecuteReader()
            While myreaderimpuestos.Read
                id = myreaderimpuestos("id")
                numero = myreaderimpuestos("nocaja")

                dtimpuestos.Rows.Add(id, numero, FormatCurrency(myreaderimpuestos("Fondo"), 2), FormatCurrency(myreaderimpuestos("limite"), 2))
            End While
            myreaderimpuestos.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        AgregarCaja.Show()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        cargarCajas()
    End Sub
End Class