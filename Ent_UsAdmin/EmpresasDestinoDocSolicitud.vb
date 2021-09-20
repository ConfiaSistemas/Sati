Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Net.NetworkInformation
Imports System.Threading.Tasks
Imports MySql.Data.MySqlClient

Public Class EmpresasDestinoDocSolicitud


    Dim conectado As Boolean
    Dim ipPrueba As String
    Dim bdPrueba As String
    Private Sub MonoFlat_ThemeContainer1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Empresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim acceso As Boolean
            For Each row As DataRow In dataPermisos.Rows
                acceso = row("SatiAcceso")
            Next
            CheckForIllegalCrossThreadCalls = False
            If acceso Then
                Try
                    '
                    iniciarconexion()
                    Dim sql As String
                    Dim comando As OleDb.OleDbCommand
                    Dim milector As OleDb.OleDbDataReader

                    comando = New OleDb.OleDbCommand

                    comando.Connection = conexion
                    sql = "select rs,ip,bd,nombre from empresas"
                    comando.CommandText = sql
                    milector = comando.ExecuteReader
                    While milector.Read
                        Dim botonempresa As New Bunifu.Framework.UI.BunifuFlatButton

                        botonempresa.Normalcolor = Color.FromArgb(48, 55, 76)
                        botonempresa.Iconimage = My.Resources.empresa_azul
                        botonempresa.Size = New Size(390, 48)
                        botonempresa.Name = milector("bd")
                        botonempresa.Text = milector("nombre")
                        botonempresa.Tag = milector("ip")
                        AddHandler botonempresa.Click, AddressOf clickevenntAsync
                        FlowLayoutPanel1.Controls.Add(botonempresa)
                    End While
                    milector.Close()


                    'Timer1.Enabled = True
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                MessageBox.Show("El usuario no tiene acceso al sistema")
                Me.Close()
            End If
        Catch ex As Exception

        End Try



    End Sub
    Private Async Sub clickevenntAsync(ByVal sender As Object, ByVal e As System.EventArgs)
        If Control.ModifierKeys = Keys.Control Then

        End If
        If usuarioActivo Then
            Try
                '  Dim iniFile As New IniFile()
                'iniFile.Load("C:\Modulo\SetConfig.ini")
                ' Dim section As IniSection = iniFile.Sections.Add("Sucursal")
                ' section.Keys.Add("BdSucursal", sender.name)

                TraspasarDocumentosSolicitud.ipDestino = sender.tag
                ' Save and encrypt the file.
                ' iniFile.Save("C:\Modulo\SetConfig.ini")
                TraspasarDocumentosSolicitud.bdDestino = sender.name

                ipPrueba = sender.tag
                bdPrueba = sender.name
                ' iniFile.Sections.Clear()
                '  MessageBox.Show("Listo")
                'iniciarconexionempresa()
                Cargando.Show()
                Cargando.MonoFlat_Label1.Text = "Intentando Conexión"
                FlowLayoutPanel1.Enabled = False
                Await Task.Factory.StartNew(Sub()


                                                If IntentaConexion() = True Then

                                                    conectado = True



                                                Else
                                                    MessageBox.Show("Pruebe de nuevo o verifique su configuración")
                                                    FlowLayoutPanel1.Enabled = True
                                                    conectado = False
                                                    Cargando.Close()
                                                End If

                                            End Sub)


                If conectado Then


                    Cargando.Close()
                    TraspasarDocumentosSolicitud.lblDestino.Text = sender.text

                    Me.Close()
                Else
                    TraspasarDocumentosSolicitud.lblDestino.Text = "No se pudo conectar"
                    Cargando.Close()
                End If

                ' Me.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        Else
            MessageBox.Show("El usuario no está activo, no puedes acceder")
        End If

    End Sub

    Private Function IntentaConexion() As Boolean

        Try
            Dim IntentoConexion As OleDbConnection
            Dim cnConexion As String
            cnConexion = "Provider=sqloledb;" &
                        "Data Source=  " & ipPrueba & "\confia;" &
                         "Initial Catalog=" & bdPrueba & ";" &
                         "User Id=sa;Password=BSi5t3Ma$CFAD;"
            IntentoConexion = New OleDbConnection(cnConexion)
            IntentoConexion.Open()
            Return True
        Catch ex As System.Data.OleDb.OleDbException
            MessageBox.Show("No se puede conectar con el servidor")
            Return False
        End Try


    End Function

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Function getMacAddress()
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        Return nics(1).GetPhysicalAddress.ToString
    End Function
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub
End Class