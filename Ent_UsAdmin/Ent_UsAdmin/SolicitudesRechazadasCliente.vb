Imports System.Data.SqlClient

Public Class SolicitudesRechazadasCliente
    Public Idcliente As Integer
    Public tipoRechazo As String
    Private Sub SolicitudesRechazadasCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarSolicitudes()

    End Sub
    Public Sub cargarSolicitudes()
        dtimpuestos.Rows.Clear()
        Try
            Dim strimpuestos As String
            iniciarconexionempresa()
            Select Case tipoRechazo
                Case "R"
                    strimpuestos = "select Solicitud.id,solicitud.nombre,Fecha,solicitud.monto,Solicitud.Estado,solicitud.tipo from Solicitud inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud where DatosSolicitud.IdCliente = '" & Idcliente & "' and Solicitud.Estado = 'R' and Solicitud.Fecha >= DATEADD(MONTH,-4,GETDATE()) AND Solicitud.Fecha <= GETDATE()"

                Case "DSR"
                    strimpuestos = "select Solicitud.id,solicitud.nombre,Fecha,solicitud.monto,Solicitud.Estado,solicitud.tipo from Solicitud inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud where DatosSolicitud.IdCliente = '" & Idcliente & "' and DatosSolicitud.Estado = 'R' and Solicitud.Fecha >= DATEADD(MONTH,-4,GETDATE()) AND Solicitud.Fecha <= GETDATE()"
            End Select


            Dim ejec = New SqlCommand(strimpuestos)
            ejec.Connection = conexionempresa
            Dim id, nombre, valor, factor, tipo As String

            Dim myreaderimpuestos As SqlDataReader = ejec.ExecuteReader()
            While myreaderimpuestos.Read
                id = myreaderimpuestos("id")
                nombre = myreaderimpuestos("nombre")

                dtimpuestos.Rows.Add(id, nombre, myreaderimpuestos("fecha"), FormatCurrency(myreaderimpuestos("Monto"), 2), myreaderimpuestos("estado"), myreaderimpuestos("tipo"))
            End While
            myreaderimpuestos.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub dtimpuestos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtimpuestos.CellContentClick

    End Sub

    Private Sub dtimpuestos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtimpuestos.CellContentDoubleClick
        DatosConsultaSolicitud.idSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        '  DatosConsultaSolicitud.TipoSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(5).Value
        DatosConsultaSolicitud.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub
End Class