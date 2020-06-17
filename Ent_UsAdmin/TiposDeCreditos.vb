Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Threading.Tasks

Public Class TiposDeCreditos
    Dim idTipo As New List(Of Integer)
    Dim nombreTipo As New List(Of String)
    Private Async Sub TiposDeCreditos_LoadAsync(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Levantar_Solicitud.Location.X, Levantar_Solicitud.Location.Y + Levantar_Solicitud.txtTipo.Location.Y + Levantar_Solicitud.txtTipo.Height)
        CheckForIllegalCrossThreadCalls = False

        Await Task.Factory.StartNew(Sub()

                                        iniciarconexionempresa()
                                        Dim strgrupos As String
                                        strgrupos = "select id,nombre from TiposDeCredito"
                                        Dim ejec = New SqlCommand(strgrupos)
                                        ejec.Connection = conexionempresa
                                        Dim labelgrupo As Label

                                        Dim numero As Integer = 0

                                        Dim myreadergrupos As SqlDataReader = ejec.ExecuteReader()
                                        While myreadergrupos.Read
                                            labelgrupo = New Label

                                            idTipo.Add(myreadergrupos("id"))
                                            nombreTipo.Add(myreadergrupos("nombre"))

                                            Me.Invoke(Sub()
                                                          labelgrupo.Name = idTipo(numero)
                                                          labelgrupo.AutoSize = True
                                                          labelgrupo.Text = idTipo(numero) & "-" & nombreTipo(numero)
                                                          labelgrupo.ForeColor = Color.White
                                                          AddHandler labelgrupo.Click, AddressOf clickevent
                                                          FlowLayoutPanel1.Controls.Add(labelgrupo)
                                                      End Sub)

                                            numero += 1
                                            '  cantidadgrupos = numero
                                        End While
                                        myreadergrupos.Close()

                                    End Sub)
    End Sub

    Public Sub clickevent(ByVal sender As Object, ByVal e As EventArgs)

        ' Dim label = DirectCast(sender, Label)

        Levantar_Solicitud.txtTipo.Text = sender.name
        Levantar_Solicitud.ConsultarTipocredito()

        Me.Close()





    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
End Class