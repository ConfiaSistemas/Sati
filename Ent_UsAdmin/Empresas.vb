Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Net.NetworkInformation
Imports System.Threading.Tasks
Imports MySql.Data.MySqlClient

Public Class Empresas
    Dim conectado As Boolean
    Public Actualizado As Boolean
    Dim heightAgregarEmpresa As Integer = 0

    Dim Dabajo As Boolean = False
    Private Sub MonoFlat_ThemeContainer1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Empresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Height = 0

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
                    sql = "select rs,ip,bd,nombre,id from empresas where id in (select idempresa from empresaspermitidas where idusuario = '" & idusr & "')"
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
                        Dim checkEmpresa As New CheckBox
                        checkEmpresa.Text = "holaaaaa"
                        checkEmpresa.Visible = False
                        '  checkEmpresa.Location = New Point(botonempresa.Width - checkEmpresa.Width, botonempresa.Height - checkEmpresa.Height)
                        checkEmpresa.BringToFront()
                        '  checkEmpresa.Parent = botonempresa
                        checkEmpresa.ForeColor = Color.White
                        checkEmpresa.Name = milector("nombre")
                        checkEmpresa.Tag = milector("id")
                        checkEmpresa.Size = New Size(20, 20)
                        Me.Invoke(Sub()
                                      FlowLayoutPanel1.Controls.Add(checkEmpresa)
                                  End Sub)


                    End While
                    milector.Close()
                    Dim adapterEmpresas As OleDbDataAdapter
                    adapterEmpresas = New OleDbDataAdapter(sql, conexion)
                    dataEmpresas = New DataTable
                    adapterEmpresas.Fill(dataEmpresas)


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
            ModificarEmpresa.nombreEmpresaSeleccionada = sender.text
            ModificarEmpresa.ipEmpresaSeleccionada = sender.tag
            ModificarEmpresa.bdEmpresaSeleccionada = sender.name
            ModificarEmpresa.Show()


        Else
            If usuarioActivo Then
                Try
                    '  Dim iniFile As New IniFile()
                    'iniFile.Load("C:\Modulo\SetConfig.ini")
                    ' Dim section As IniSection = iniFile.Sections.Add("Sucursal")
                    ' section.Keys.Add("BdSucursal", sender.name)

                    bdconsultas = sender.name
                    ' Save and encrypt the file.
                    ' iniFile.Save("C:\Modulo\SetConfig.ini")
                    ipconsultas = sender.tag

                    ' iniFile.Sections.Clear()
                    '  MessageBox.Show("Listo")
                    'iniciarconexionempresa()
                    Cargando.Show()
                    Cargando.MonoFlat_Label1.Text = "Intentando Conexión"
                    FlowLayoutPanel1.Enabled = False
                    Await Task.Factory.StartNew(Sub()


                                                    If IntentaConexion() = True Then

                                                        Dim comando As OleDb.OleDbCommand
                                                        Dim consulta As String
                                                        Dim reader As OleDb.OleDbDataReader
                                                        comando = New OleDb.OleDbCommand
                                                        consulta = "select id,rs,RFC,Calle,Nex,Col,Ciudad,Estado,CP,nombre,telefono,prefijo,correo,passwordcorreo FROM empresas where BD = '" & bdconsultas & "' and ip = '" & ipconsultas & "'"
                                                        comando.Connection = conexion
                                                        comando.CommandText = consulta
                                                        reader = comando.ExecuteReader
                                                        While reader.Read
                                                            NombreEmpresa = reader("rs")
                                                            RFCEmpresa = reader("RFC")
                                                            CalleEmpresa = reader("Calle")
                                                            NumeroEmpresa = reader("Nex")
                                                            ColEmpresa = reader("Col")
                                                            CiudadEmpresa = reader("Ciudad")
                                                            EstadoEmpresa = reader("Estado")
                                                            CPEmpresa = reader("CP")
                                                            nombreAmostrar = reader("Nombre")
                                                            idEmpresa = reader("id")
                                                            telEmpresa = reader("Telefono")
                                                            prefijoEmpresa = reader("prefijo")
                                                            correoEmpresa = reader("correo")
                                                            passwordCorreoEmpresa = reader("passwordcorreo")
                                                        End While

                                                        Dim consultaCorreos As String
                                                        consultaCorreos = "select * from correosempresas where idempresa = (select id from empresas where BD = '" & bdconsultas & "' and ip = '" & ipconsultas & "')"
                                                        adapterCorreos = New OleDbDataAdapter(consultaCorreos, conexion)
                                                        dataCorreos = New DataTable
                                                        adapterCorreos.Fill(dataCorreos)


                                                        iniciarconexionempresa()

                                                        Dim comandoEmpleado As SqlCommand
                                                        Dim consultaEmpleado As String
                                                        consultaEmpleado = "IF EXISTS((select * from empleadosAsignados where usr = '" & nmusr & "'))
BEGIN
select idempleado from empleadosAsignados where usr = '" & nmusr & "' end
else
begin
select '0'
end"
                                                        comandoEmpleado = New SqlCommand
                                                        comandoEmpleado.Connection = conexionempresa
                                                        comandoEmpleado.CommandText = consultaEmpleado
                                                        EmpleadoAsignado = comandoEmpleado.ExecuteScalar
                                                        Docs()
                                                        Colonias()
                                                        conectado = True
                                                        Try
                                                            Dim ip As System.Net.IPHostEntry
                                                            ip = System.Net.Dns.GetHostEntry(My.Computer.Name)
                                                            ' MessageBox.Show(ip.AddressList(4).ToString)
                                                            ' MessageBox.Show(My.Computer.Name.ToString)
                                                            Dim conexionLogin As MySqlConnection
                                                            conexionLogin = New MySqlConnection()
                                                            conexionLogin.ConnectionString = "server=www.prestamosconfia.com;user id=SATISesiones;password=123456;persistsecurityinfo=True;port=3306;database=USRS"
                                                            conexionLogin.Open()
                                                            Dim comandoEmpresaLogin As MySqlCommand
                                                            Dim consultaEmpresaLogin As String
                                                            consultaEmpresaLogin = "update Sesiones set Empresa = '" & nombreAmostrar & "',ip='" & ip.AddressList(4).ToString & "',Equipo='" & My.Computer.Name.ToString & "' where id = '" & idSesion & "'"
                                                            comandoEmpresaLogin = New MySqlCommand
                                                            comandoEmpresaLogin.Connection = conexionLogin
                                                            comandoEmpresaLogin.CommandText = consultaEmpresaLogin
                                                            comandoEmpresaLogin.ExecuteNonQuery()
                                                            conexionLogin.Close()

                                                        Catch ex As Exception
                                                            ' IO.File.AppendAllText("C:\ConfiaAdmin\SATI\Log.txt", String.Format("{0}{1}", Environment.NewLine, ex.ToString()))
                                                        End Try

                                                        Me.Invoke(Sub()
                                                                      frm_adm.BackgroundNotificaciones.RunWorkerAsync()

                                                                  End Sub)


                                                    Else
                                                        MessageBox.Show("Pruebe de nuevo o verifique su configuración")
                                                        FlowLayoutPanel1.Enabled = True
                                                        conectado = False
                                                        Cargando.Close()
                                                    End If

                                                End Sub)


                    If conectado Then


                        Cargando.Close()
                        frm_adm.Show()
                        Me.Close()
                    Else
                        Cargando.Close()
                    End If

                    ' Me.Close()


                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try
            Else
                MessageBox.Show("El usuario no está activo, no puedes acceder")
            End If

        End If


    End Sub

    Private Function IntentaConexion() As Boolean

        Try
            Dim IntentoConexion As OleDbConnection
            Dim cnConexion As String
            cnConexion = "Provider=sqloledb;" &
                        "Data Source=  " & ipconsultas & "\confia;" &
                         "Initial Catalog=" & bdconsultas & ";" &
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
    Public Sub CargarEmpresas()
        Dim num_controles As Integer = FlowLayoutPanel1.Controls.Count - 1
        For n As Integer = num_controles To 0 Step -1
            Dim ctrl As Control = FlowLayoutPanel1.Controls(n)
            FlowLayoutPanel1.Controls.Remove(ctrl)
            ctrl.Dispose()
        Next
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
                    sql = "select rs,ip,bd,nombre,id from empresas where id in (select idempresa from empresaspermitidas where idusuario = '" & idusr & "')"
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
                        Dim checkEmpresa As New CheckBox

                        checkEmpresa.Visible = False
                        '  checkEmpresa.Location = New Point(botonempresa.Width - checkEmpresa.Width, botonempresa.Height - checkEmpresa.Height)
                        checkEmpresa.BringToFront()
                        '  checkEmpresa.Parent = botonempresa
                        checkEmpresa.ForeColor = Color.White
                        checkEmpresa.Name = milector("nombre")
                        checkEmpresa.Tag = milector("id")
                        checkEmpresa.Size = New Size(20, 20)
                        Me.Invoke(Sub()
                                      FlowLayoutPanel1.Controls.Add(checkEmpresa)
                                  End Sub)

                    End While



                    milector.Close()
                    Dim adapterEmpresas As OleDbDataAdapter
                    adapterEmpresas = New OleDbDataAdapter(sql, conexion)
                    dataEmpresas = New DataTable
                    adapterEmpresas.Fill(dataEmpresas)

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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If heightAgregarEmpresa <= 30 Then
            Panel2.Height = heightAgregarEmpresa
            heightAgregarEmpresa += 5
        Else
            Timer1.Stop()
            Timer1.Enabled = False

        End If
    End Sub

    Private Async Sub Empresas_KeyDownAsync(sender As Object, e As KeyEventArgs) Handles Me.KeyDown


        If e.KeyCode = Keys.A Then
            Timer1.Enabled = True
            Timer1.Interval = 1
            Timer1.Start()
        End If
        If e.KeyCode = Keys.D Then
            Dabajo = True
            Dim ctrl As Control
            For Each ctrl In FlowLayoutPanel1.Controls
                If TypeOf (ctrl) Is CheckBox Then
                    Dim checkEmpresa As CheckBox = ctrl
                    checkEmpresa.Visible = True

                End If


            Next

        End If
        If e.KeyCode = Keys.Delete Then
            Dim nDelete As Integer = 0
            If Dabajo Then
                For Each ctrlc As Control In FlowLayoutPanel1.Controls
                    If TypeOf (ctrlc) Is CheckBox Then
                        Dim checkE As CheckBox = ctrlc
                        If checkE.CheckState = CheckState.Checked Then
                            nDelete += 1

                        End If
                    End If
                Next
                If nDelete > 0 Then
                    If MessageBox.Show("¿Está seguro que desea eliminar la(s) empresa(s) seleccionada(s)?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Await Task.Factory.StartNew(Sub()
                                                        Me.Invoke(Sub()
                                                                      Cargando.Show()
                                                                      Cargando.MonoFlat_Label1.Text = "Eliminando Empresas"
                                                                      Cargando.TopMost = True
                                                                  End Sub)
                                                        iniciarconexion()
                                                        For Each ctrlc As Control In FlowLayoutPanel1.Controls
                                                            If TypeOf (ctrlc) Is CheckBox Then
                                                                Dim checkE As CheckBox = ctrlc
                                                                If checkE.CheckState = CheckState.Checked Then
                                                                    Dim EliminarEmpresaPermitida As OleDbCommand
                                                                    Dim consultaEliminarEmpresaPermitida As String
                                                                    consultaEliminarEmpresaPermitida = "Delete from empresaspermitidas where idempresa = '" & checkE.Tag & "'"
                                                                    EliminarEmpresaPermitida = New OleDbCommand
                                                                    EliminarEmpresaPermitida.Connection = conexion
                                                                    EliminarEmpresaPermitida.CommandText = consultaEliminarEmpresaPermitida
                                                                    EliminarEmpresaPermitida.ExecuteNonQuery()

                                                                    Dim comandoEliminarEmpresa As OleDbCommand
                                                                    Dim consultaEliminarEmpresa As String
                                                                    consultaEliminarEmpresa = "Delete from empresas where id = '" & checkE.Tag & "'"
                                                                    comandoEliminarEmpresa = New OleDbCommand
                                                                    comandoEliminarEmpresa.Connection = conexion
                                                                    comandoEliminarEmpresa.CommandText = consultaEliminarEmpresa
                                                                    comandoEliminarEmpresa.ExecuteNonQuery()

                                                                End If

                                                            End If
                                                        Next
                                                        Cargando.Close()
                                                        Me.Invoke(Sub()
                                                                      CargarEmpresas()

                                                                  End Sub)
                                                    End Sub)
                    Else
                        Dim ctrl As Control
                        For Each ctrl In FlowLayoutPanel1.Controls
                            If TypeOf (ctrl) Is CheckBox Then
                                Dim checkEmpresa As CheckBox = ctrl
                                checkEmpresa.Visible = False

                            End If


                        Next
                    End If
                End If

            End If

        End If

    End Sub

    Private Sub Empresas_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.A Then
            Timer1.Stop()
            Timer1.Enabled = False
            Timer2.Enabled = True
            Timer2.Interval = 1
            Timer2.Start()
        End If
        If e.KeyCode = Keys.D Then
            Dabajo = False
            Dim ctrl As Control
            For Each ctrl In FlowLayoutPanel1.Controls
                If TypeOf (ctrl) Is CheckBox Then
                    Dim checkEmpresa As CheckBox = ctrl
                    checkEmpresa.Visible = False

                End If


            Next
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If heightAgregarEmpresa >= 0 Then
            Panel2.Height = heightAgregarEmpresa
            heightAgregarEmpresa -= 5
        Else
            Timer2.Stop()
            Timer2.Enabled = False

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AgregarEmpresa.Show()

        Timer1.Stop()
        Timer1.Enabled = False
        Timer2.Enabled = True
        Timer2.Interval = 1
        Timer2.Start()
    End Sub
End Class