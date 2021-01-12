Imports System.ComponentModel
Imports System.Data.SqlClient

Imports MySql.Data.MySqlClient
Public Class SesionesActivas

    Dim dataConsulta As DataTable
    Dim adapterConsulta As MySqlDataAdapter
    Dim consulta As String
    Dim consultar As Boolean
    Dim Cerrar As Boolean
    Dim ncargando As Cargando
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Dim conexionSesiones As MySqlConnection
            conexionSesiones = New MySqlConnection()
            conexionSesiones.ConnectionString = "server=www.prestamosconfia.com;user id=ajas;pwd=123456;port=3306;database=USRS;Convert Zero Datetime=True"
            conexionSesiones.Open()
            adapterConsulta = New MySqlDataAdapter(consulta, conexionSesiones)
            dataConsulta = New DataTable
            adapterConsulta.Fill(dataConsulta)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BuscarClienteSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consulta = "select id,Usuario as Usuario,Empresa,Fecha,Hora,UltimoAcceso,Sistema  from Sesiones where Activo = 1"
        ncargando = New Cargando
        ncargando.Show()

        ncargando.MonoFlat_Label1.Text = "Consultando"
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        dtdatos.DataSource = dataConsulta
        consultar = False
        ncargando.Close()

    End Sub



    Private Sub txtnombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            If consultar Then
                MessageBox.Show("Consultando espere...")
            Else
                consulta = "select  id,Usuario as Usuario,Empresa,Fecha,Hora,UltimoAcceso,Sistema  from Sesiones where Activo = 1 and usuario like '%" & txtnombre.Text & "%'"
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



    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        ncargando = New Cargando
        ncargando.Show()
        ncargando.TopMost = True
        ncargando.MonoFlat_Label1.Text = "Cerrando la sesión del usuario"
        BackgroundCerrarSesion.RunWorkerAsync()

    End Sub

    Private Sub BackgroundCerrarSesion_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundCerrarSesion.DoWork
        Try
            Dim conexionSesiones As MySqlConnection
            conexionSesiones = New MySqlConnection()
            conexionSesiones.ConnectionString = "server=www.prestamosconfia.com;user id=ajas;pwd=123456;port=3306;database=USRS;Convert Zero Datetime=True"
            conexionSesiones.Open()

            Dim comandoCerrarSesion As MySqlCommand
            Dim consultaCerrarSesion As String
            consultaCerrarSesion = "update Sesiones set Activo = 0 where id = '" & dtdatos.Rows(dtdatos.CurrentRow.Index).Cells(0).Value & "'"
            comandoCerrarSesion = New MySqlCommand
            comandoCerrarSesion.CommandText = consultaCerrarSesion
            comandoCerrarSesion.Connection = conexionSesiones
            comandoCerrarSesion.ExecuteNonQuery()
            conexionSesiones.Close()
            Cerrar = True
        Catch ex As MySqlException
            Cerrar = False
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub BackgroundCerrarSesion_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundCerrarSesion.RunWorkerCompleted
        If Cerrar Then
            MessageBox.Show("Se cerró la sesión del usuario")
            ncargando.MonoFlat_Label1.Text = "Consultando"
            BackgroundWorker1.RunWorkerAsync()

        Else
            MessageBox.Show("Hubo un error")
            ncargando.Close()
            ncargando.Dispose()
        End If



    End Sub

    Private Sub dtdatos_SelectionChanged(sender As Object, e As EventArgs) Handles dtdatos.SelectionChanged
        If dtdatos.Rows(dtdatos.CurrentRow.Index).Cells(0).Value.ToString <> "" Then
            dtdatos.ContextMenuStrip = ContextCerrarSesion
        Else
            dtdatos.ContextMenuStrip = Nothing

        End If
    End Sub
End Class