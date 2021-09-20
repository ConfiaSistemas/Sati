Imports System.ComponentModel
Imports System.Data.OleDb

Public Class AgregarEmpresa

    Dim idEmpresaSeleccionada As String
    Public bdEmpresaSeleccionada As String
    Public ipEmpresaSeleccionada As String
    Public nombreEmpresaSeleccionada As String
    Dim ncargando As Cargando
    Dim heightFlow As Integer
    Dim grande As Boolean




    Private Sub ModificarEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlowUsuarios.Height = 0

        ncargando = New Cargando
        ncargando.MonoFlat_Label1.Text = "Cargando Información"
        ncargando.Show()
        BackgroundInformacionEmpresa.RunWorkerAsync()


    End Sub

    Private Sub BackgroundActualizar_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundActualizar.DoWork
        iniciarconexion()
        Dim idEmpresaGenerado As Integer
        Dim comandoActualizar As OleDbCommand
        Dim consultaActualizar As String
        consultaActualizar = "insert into empresas values('" & txtNombre.Text & "','" & txtRazonSocial.Text & "','" & txtRFC.Text & "','" & txtCalle.Text & "','" & txtNoExterior.Text & "','" & txtColonia.Text & "','" & txtCiudad.Text & "','" & txtEstado.Text & "','" & txtCP.Text & "','" & txtTelefono.Text & "',
                               '" & txtIP.Text & "','" & txtBD.Text & "','" & txtPrefijo.Text & "','" & txtCorreo.Text & "','" & txtPassword.Text & "') select SCOPE_IDENTITY()"
        comandoActualizar = New OleDbCommand
        comandoActualizar.Connection = conexion
        comandoActualizar.CommandText = consultaActualizar
        idEmpresaGenerado = comandoActualizar.ExecuteScalar


        Dim nCargar As Integer = 0
        For Each ctrlc As Control In FlowUsuarios.Controls
            If TypeOf (ctrlc) Is CheckBox Then
                Dim checkE As CheckBox = ctrlc
                If checkE.CheckState = CheckState.Checked Then
                    nCargar += 1

                End If
            End If
        Next

        If nCargar > 0 Then
            For Each ctrlc As Control In FlowUsuarios.Controls
                If TypeOf (ctrlc) Is CheckBox Then
                    Dim checkE As CheckBox = ctrlc
                    If checkE.CheckState = CheckState.Checked Then
                        Dim comandoEmpresasPermitidas As OleDbCommand
                        Dim consultaEmpresasPermitidas As String
                        consultaEmpresasPermitidas = "insert into empresaspermitidas values('" & idEmpresaGenerado & "','" & checkE.Name & "')"
                        comandoEmpresasPermitidas = New OleDbCommand
                        comandoEmpresasPermitidas.Connection = conexion
                        comandoEmpresasPermitidas.CommandText = consultaEmpresasPermitidas
                        comandoEmpresasPermitidas.ExecuteNonQuery()


                    End If
                End If
            Next
        End If
    End Sub

    Private Sub BackgroundActualizar_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundActualizar.RunWorkerCompleted
        Empresas.Actualizado = True


        ncargando.Close()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        ncargando = New Cargando
        ncargando.MonoFlat_Label1.Text = "Agregando Empresa"
        ncargando.Show()
        BackgroundActualizar.RunWorkerAsync()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub ModificarEmpresa_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Invoke(Sub()
                      Empresas.CargarEmpresas()
                  End Sub)

    End Sub

    Private Sub BackgroundInformacionEmpresa_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundInformacionEmpresa.DoWork
        iniciarconexion()
        Dim comandoUsuarios As OleDbCommand
        Dim consultaUsuarios As String
        Dim readerUsuarios As OleDbDataReader

        consultaUsuarios = "select idusr,nm,nm_complete from usr"
        comandoUsuarios = New OleDbCommand
        comandoUsuarios.Connection = conexion
        comandoUsuarios.CommandText = consultaUsuarios
        readerUsuarios = comandoUsuarios.ExecuteReader
        If readerUsuarios.HasRows Then
            While readerUsuarios.Read
                Dim CheckUsuarios As New CheckBox

                CheckUsuarios.Visible = True
                '  checkEmpresa.Location = New Point(botonempresa.Width - checkEmpresa.Width, botonempresa.Height - checkEmpresa.Height)
                CheckUsuarios.BringToFront()
                '  checkEmpresa.Parent = botonempresa
                CheckUsuarios.ForeColor = Color.White
                CheckUsuarios.Name = readerUsuarios("idusr")
                CheckUsuarios.Tag = readerUsuarios("nm")
                CheckUsuarios.Text = readerUsuarios("nm_complete")
                CheckUsuarios.AutoSize = True
                Me.Invoke(Sub()
                              FlowUsuarios.Controls.Add(CheckUsuarios)
                          End Sub)

            End While
        End If
    End Sub

    Private Sub TimerGrande_Tick(sender As Object, e As EventArgs) Handles TimerGrande.Tick
        If heightFlow <= 272 Then
            FlowUsuarios.Height = heightFlow
            heightFlow += 10
        Else
            TimerGrande.Stop()
            TimerGrande.Enabled = False

        End If
    End Sub

    Private Sub TimerChico_Tick(sender As Object, e As EventArgs) Handles TimerChico.Tick
        If heightFlow >= 0 Then
            FlowUsuarios.Height = heightFlow
            heightFlow -= 10
        Else
            TimerChico.Stop()
            TimerChico.Enabled = False

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If grande = False Then
            grande = True
            TimerGrande.Enabled = True
            TimerGrande.Interval = 10
            TimerGrande.Start()

        Else
            grande = False
            TimerChico.Enabled = True
            TimerChico.Interval = 10
            TimerChico.Start()

        End If
    End Sub

    Private Sub BackgroundInformacionEmpresa_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundInformacionEmpresa.RunWorkerCompleted
        ncargando.Close()
    End Sub
End Class