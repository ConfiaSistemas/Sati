Imports System.Data.SqlClient
Imports System.Threading.Tasks

Public Class Historia_de_Solicitud
    Public idSolicitud
    Public esEmpeño As Boolean

    Private Async Sub Historia_de_Solicitud_LoadAsync(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case esEmpeño
            Case False

                Await Task.Factory.StartNew(Sub()
                                                iniciarconexionempresa()
                                                Dim comando As SqlCommand
                                                Dim consulta As String
                                                Dim reader As SqlDataReader
                                                consulta = "select format(fecha,'dd/MM/yy') as fecha,hora,observaciones from cronogramaSolicitud where idSolicitud = '" & idSolicitud & "'"
                                                comando = New SqlCommand
                                                comando.Connection = conexionempresa
                                                comando.CommandText = consulta
                                                reader = comando.ExecuteReader
                                                Me.Invoke(Sub()
                                                              While reader.Read
                                                                  Dim botonempresa As New Bunifu.Framework.UI.BunifuFlatButton

                                                                  botonempresa.Normalcolor = Color.FromArgb(48, 55, 76)
                                                                  botonempresa.Iconimage = My.Resources.lconfia
                                                                  botonempresa.Size = New Size(530, 93)

                                                                  botonempresa.Text = "  " & reader("fecha").ToString & " " & "a las " & reader("hora").ToString & " - " & reader("observaciones")


                                                                  FlowLayoutPanel1.Controls.Add(botonempresa)
                                                              End While
                                                          End Sub)
                                            End Sub)
            Case True
                Await Task.Factory.StartNew(Sub()
                                                iniciarconexionempresa()
                                                Dim comando As SqlCommand
                                                Dim consulta As String
                                                Dim reader As SqlDataReader
                                                consulta = "select format(fecha,'dd/MM/yy') as fecha,hora,observaciones from cronogramaSolicitudEmpeño where idSolicitud = '" & idSolicitud & "'"
                                                comando = New SqlCommand
                                                comando.Connection = conexionempresa
                                                comando.CommandText = consulta
                                                reader = comando.ExecuteReader
                                                Me.Invoke(Sub()
                                                              While reader.Read
                                                                  Dim botonempresa As New Bunifu.Framework.UI.BunifuFlatButton

                                                                  botonempresa.Normalcolor = Color.FromArgb(48, 55, 76)
                                                                  botonempresa.Iconimage = My.Resources.lconfia
                                                                  botonempresa.Size = New Size(530, 93)

                                                                  botonempresa.Text = "  " & reader("fecha").ToString & " " & "a las " & reader("hora").ToString & " - " & reader("observaciones")


                                                                  FlowLayoutPanel1.Controls.Add(botonempresa)
                                                              End While
                                                          End Sub)
                                            End Sub)
        End Select
    End Sub
End Class