Imports System.ComponentModel
Imports System.Data.OleDb

Public Class ModificarEmpresa
    Dim idEmpresaSeleccionada As String
    Public bdEmpresaSeleccionada As String
    Public ipEmpresaSeleccionada As String
    Public nombreEmpresaSeleccionada As String
    Dim ncargando As Cargando


    Private Sub BackgroundInformacionEmpresa_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundInformacionEmpresa.DoWork
        iniciarconexion()
        Dim comandoInformacion As OleDbCommand
        Dim consultaInformacion As String
        Dim readerInformacion As OleDbDataReader
        consultaInformacion = "select * from empresas where nombre = '" & nombreEmpresaSeleccionada & "' and ip = '" & ipEmpresaSeleccionada & "' and bd = '" & bdEmpresaSeleccionada & "'"
        comandoInformacion = New OleDbCommand
        comandoInformacion.Connection = conexion
        comandoInformacion.CommandText = consultaInformacion
        readerInformacion = comandoInformacion.ExecuteReader
        If readerInformacion.HasRows Then
            While readerInformacion.Read
                txtNombre.Text = readerInformacion("Nombre")
                txtRazonSocial.Text = readerInformacion("RS")
                txtRFC.Text = readerInformacion("RFC")
                txtCalle.Text = readerInformacion("Calle")
                txtNoExterior.Text = readerInformacion("Nex")
                txtCP.Text = readerInformacion("CP")
                txtColonia.Text = readerInformacion("COl")
                txtCiudad.Text = readerInformacion("ciudad")
                txtEstado.Text = readerInformacion("Estado")
                txtTelefono.Text = readerInformacion("Telefono")
                txtIP.Text = readerInformacion("IP")
                txtBD.Text = readerInformacion("BD")
                txtPrefijo.Text = readerInformacion("Prefijo")
                txtCorreo.Text = readerInformacion("Correo")
                txtPassword.Text = readerInformacion("passwordCorreo")
                idEmpresaSeleccionada = readerInformacion("id")
            End While
        End If
    End Sub

    Private Sub BackgroundInformacionEmpresa_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundInformacionEmpresa.RunWorkerCompleted
        ncargando.close

    End Sub

    Private Sub ModificarEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ncargando = New Cargando
        ncargando.MonoFlat_Label1.Text = "Cargando Información"
        ncargando.Show()
        BackgroundInformacionEmpresa.RunWorkerAsync()

    End Sub

    Private Sub BackgroundActualizar_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundActualizar.DoWork
        iniciarconexion()
        Dim comandoActualizar As OleDbCommand
        Dim consultaActualizar As String
        consultaActualizar = "update empresas set Nombre = '" & txtNombre.Text & "',RS = '" & txtRazonSocial.Text & "',RFC = '" & txtRFC.Text & "',Calle = '" & txtCalle.Text & "',nex = '" & txtNoExterior.Text & "',col = '" & txtColonia.Text & "',ciudad = '" & txtCiudad.Text & "',estado = '" & txtEstado.Text & "',cp = '" & txtCP.Text & "',telefono = '" & txtTelefono.Text & "',
                               IP = '" & txtIP.Text & "',BD='" & txtBD.Text & "',prefijo = '" & txtPrefijo.Text & "',correo = '" & txtCorreo.Text & "',passwordCorreo = '" & txtPassword.Text & "' where id = '" & idEmpresaSeleccionada & "'"
        comandoActualizar = New OleDbCommand
        comandoActualizar.Connection = conexion
        comandoActualizar.CommandText = consultaActualizar
        comandoActualizar.ExecuteNonQuery()

    End Sub

    Private Sub BackgroundActualizar_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundActualizar.RunWorkerCompleted
        Empresas.Actualizado = True


        ncargando.Close()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        ncargando = New Cargando
        ncargando.MonoFlat_Label1.Text = "Actualizando Información"
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
End Class