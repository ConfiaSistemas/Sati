Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class BuscarClienteEmpeño
    Dim dataConsulta As DataTable
    Dim adapterConsulta As SqlDataAdapter
    Dim consulta As String
    Dim consultar As Boolean
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        iniciarconexionempresa()
        adapterConsulta = New SqlDataAdapter(consulta, conexionempresa)
        dataConsulta = New DataTable
        adapterConsulta.Fill(dataConsulta)
    End Sub

    Private Sub BuscarClienteSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consulta = "select id,(nombre+' '+apellidoPaterno+' '+apellidoMaterno) as nombre  from clientes order by nombre asc"
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
                consulta = "select id,(nombre+' '+apellidoPaterno+' '+apellidoMaterno) as nombre from clientes where nombre like '%" & txtnombre.Text & "%' or apellidoPaterno like '%" & txtnombre.Text & "%' or apellidoMaterno like '%" & txtnombre.Text & "%' order by nombre asc"
                consultar = True
                Cargando.Show()
                Cargando.MonoFlat_Label1.Text = "Consultando"
                BackgroundWorker1.RunWorkerAsync()
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
        Solicitud_Boleta.txtIdCliente.Text = dtdatos.CurrentRow.Cells(0).Value
        Solicitud_Boleta.ConsultarCliente()
        Me.Close()
    End Sub

    Private Sub dtdatos_KeyDown(sender As Object, e As KeyEventArgs) Handles dtdatos.KeyDown
        If e.KeyCode = Keys.Enter Then
            Solicitud_Boleta.txtIdCliente.Text = dtdatos.CurrentRow.Cells(0).Value
            Solicitud_Boleta.ConsultarCliente()
            Me.Close()
        End If
    End Sub
End Class