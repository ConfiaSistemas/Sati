Imports System.ComponentModel
Imports System.Data.SqlClient

Imports MySql.Data.MySqlClient
Public Class BuscarSesion

    Dim dataConsulta As DataTable
    Dim adapterConsulta As MySqlDataAdapter
    Dim consulta As String
    Dim consultar As Boolean
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim conexionSesiones As MySqlConnection
        conexionSesiones = New MySqlConnection()
        conexionSesiones.ConnectionString = "server=www.prestamosconfia.com;user id=ajas;pwd=123456;port=3306;database=USRS;Convert Zero Datetime=True"
        conexionSesiones.Open()
        adapterConsulta = New MySqlDataAdapter(consulta, conexionSesiones)
        dataConsulta = New DataTable
        adapterConsulta.Fill(dataConsulta)
    End Sub

    Private Sub BuscarClienteSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consulta = "select id,Usuario as Usuario,Empresa,UltimoAcceso,Sistema  from Sesiones where Activo = 1"
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Consultando"
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        dtdatos.DataSource = dataConsulta
        consultar = False
        Cargando.Close()
    End Sub



    Private Sub txtnombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            If consultar Then
                MessageBox.Show("Consultando espere...")
            Else
                consulta = "select id,Usuario as Usuario,Empresa,UltimoAcceso,Sistema  from Sesiones where Activo = 1 and usuario like '%" & txtnombre.Text & "%'"
                consultar = True
                Cargando.Show()
                Cargando.MonoFlat_Label1.Text = "Consultando"
                If BackgroundWorker1.IsBusy = True Then
                Else
                    BackgroundWorker1.RunWorkerAsync()
                End If

            End If

        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub txtnombre_OnValueChanged(sender As Object, e As EventArgs) Handles txtnombre.OnValueChanged

    End Sub

    Private Sub dtdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtdatos.CellContentClick

    End Sub

    Private Sub dtdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtdatos.CellDoubleClick
        CrearNotificacion.txtIdSesion.Text = dtdatos.CurrentRow.Cells(0).Value
        CrearNotificacion.txtUsuario.Text = dtdatos.CurrentRow.Cells(1).Value

        Me.Close()
    End Sub

    Private Sub dtdatos_KeyDown(sender As Object, e As KeyEventArgs) Handles dtdatos.KeyDown
        If e.KeyCode = Keys.Enter Then
            CrearNotificacion.txtIdSesion.Text = dtdatos.CurrentRow.Cells(0).Value
            CrearNotificacion.txtUsuario.Text = dtdatos.CurrentRow.Cells(1).Value

            Me.Close()
        End If
    End Sub
End Class