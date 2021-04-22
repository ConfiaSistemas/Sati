Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Desembolsos
    Dim dataGestores As DataSet
    Dim dataPromotores As DataSet
    Dim adapterGestores As SqlDataAdapter

    Dim adapterPromotores As SqlDataAdapter
    Dim dataConsulta As DataTable
    Dim adapterConsulta As SqlDataAdapter
    Private Sub Desembolsos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        ComboFiltro.SelectedIndex = 0
        dateDesde.Value = Now
        dateHasta.Value = Now
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando Información"
        Cargando.TopMost = True
        BackgroundGestores.RunWorkerAsync()

    End Sub

    Private Sub BackgroundGestores_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundGestores.DoWork
        iniciarconexionempresa()
        Dim consulta As String
        consulta = "Select id,nombre from empleados where tipo = 'G'"
        adapterGestores = New SqlDataAdapter(consulta, conexionempresa)
        dataGestores = New DataSet
        adapterGestores.Fill(dataGestores)
    End Sub

    Private Sub BackgroundGestores_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundGestores.RunWorkerCompleted
        BackgroundPromotores.RunWorkerAsync()

    End Sub

    Private Sub BackgroundPromotores_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundPromotores.DoWork
        iniciarconexionempresa()
        Dim consulta As String
        consulta = "Select id,nombre from empleados where tipo = 'P'"
        adapterPromotores = New SqlDataAdapter(consulta, conexionempresa)
        dataPromotores = New DataSet
        adapterPromotores.Fill(dataPromotores)
    End Sub

    Private Sub ComboFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboFiltro.SelectedIndexChanged
        Select Case ComboFiltro.Text
            Case "Todos"
                '  txtnombre.Enabled = False
                ComboElección.Items.Clear()
                ComboElección.Enabled = False
            Case "Promotor"
                ' txtnombre.Enabled = True
                ComboElección.Enabled = True
                ComboElección.Items.Clear()

                ComboElección.Items.Add("Todos")
                For Each row As DataRow In dataPromotores.Tables(0).Rows

                    ComboElección.Items.Add(row("nombre"))
                Next
                ComboElección.SelectedIndex = 0
            Case "Gestor"
                '  txtnombre.Enabled = True
                ComboElección.Enabled = True
                ComboElección.Items.Clear()

                ComboElección.Items.Add("Todos")
                For Each row As DataRow In dataGestores.Tables(0).Rows

                    ComboElección.Items.Add(row("nombre"))
                Next
                ComboElección.SelectedIndex = 0
        End Select
    End Sub

    Private Sub BackgroundPromotores_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundPromotores.RunWorkerCompleted
        Cargando.Close()
    End Sub

    Private Function ConsultarId(nombre As String) As Integer
        Dim idEmpleado As Integer
        Select Case ComboFiltro.Text
            Case "Gestor"
                For Each row As DataRow In dataGestores.Tables(0).Rows
                    If row("nombre").ToString = ComboElección.Text Then
                        idEmpleado = Val(row("id").ToString)
                        Exit For
                    End If
                Next
            Case "Promotor"
                For Each row As DataRow In dataPromotores.Tables(0).Rows
                    If row("nombre").ToString = ComboElección.Text Then
                        idEmpleado = Val(row("id").ToString)
                        Exit For
                    End If
                Next


        End Select
        Return idEmpleado
    End Function

    Private Sub BackgroundConsulta_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundConsulta.DoWork
        iniciarconexionempresa()
        Dim consulta As String

        Dim idEmpleado As Integer
        idEmpleado = ConsultarId(ComboElección.Text)
        Select Case ComboFiltro.Text
            Case "Gestor"
                If ComboElección.Text = "Todos" Then
                    '                    consulta = "select FechaEntrega,cred.id,cred.Nombre,format(cred.Monto,'C','es-mx') as Monto,format(cred.Pagare,'C','es-mx') as Pagaré,cred.Tipo,Gestores.Nombre as Gestor from
                    '(select FechaEntrega,Credito.id,credito.Nombre,Monto,Pagare,TiposDeCredito.Nombre as tipo,IdGestor from Credito inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id  where FechaEntrega is not null and (FechaEntrega >= '" & Format(dateDesde.Value, "yyyy-MM-dd") & "' and FechaEntrega <= '" & Format(dateHasta.Value, "yyyy-MM-dd") & "')) cred inner join
                    '(select * from Empleados where Tipo = 'G') Gestores on cred.IdGestor = Gestores.id
                    '"
                    consulta = "select FechaEntrega,id,Nombre,Monto,Pagaré,Tipo,Gestor,Promotor,case when CanCreditos > 1 then 'Renovación' else 'Nuevo' end as 'Nuevo o Renovación' from
(select FechaEntrega,cred.id,cred.Nombre,format(cred.Monto,'C','es-mx') as Monto,format(cred.Pagare,'C','es-mx') as Pagaré,cred.Tipo,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,isnull((select COUNT(id) from Credito where IdCliente = cred.IdCliente and cred.Estado <> 'E'),0) as CanCreditos from
(select FechaEntrega,Credito.id,credito.Nombre,Monto,Pagare,TiposDeCredito.Nombre as tipo,IdPromotor,IdGestor,IdCliente,Estado from Credito inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id  where FechaEntrega is not null and (FechaEntrega >= '" & Format(dateDesde.Value, "yyyy-MM-dd") & "' and FechaEntrega <= '" & Format(dateHasta.Value, "yyyy-MM-dd") & "')) cred inner join
(select * from Empleados where Tipo = 'G') Gestores on cred.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on cred.IdPromotor = Promotores.id) desembolsos"

                Else

                    '                    consulta = "select FechaEntrega,cred.id,cred.Nombre,format(cred.Monto,'C','es-mx') as Monto,format(cred.Pagare,'C','es-mx') as Pagaré,cred.Tipo,Gestores.Nombre as Gestor from
                    '(select FechaEntrega,Credito.id,credito.Nombre,Monto,Pagare,TiposDeCredito.Nombre as tipo,IdGestor from Credito inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id where credito.idgestor = '" & idEmpleado & "' and FechaEntrega is not null and (FechaEntrega >= '" & Format(dateDesde.Value, "yyyy-MM-dd") & "' and FechaEntrega <= '" & Format(dateHasta.Value, "yyyy-MM-dd") & "')) cred inner join
                    '(select * from Empleados where Tipo = 'G') Gestores on cred.IdGestor = Gestores.id
                    '  "
                    consulta = "select FechaEntrega,id,Nombre,Monto,Pagaré,Tipo,Gestor,Promotor,case when CanCreditos > 1 then 'Renovación' else 'Nuevo' end as 'Nuevo o Renovación' from
(select FechaEntrega,cred.id,cred.Nombre,format(cred.Monto,'C','es-mx') as Monto,format(cred.Pagare,'C','es-mx') as Pagaré,cred.Tipo,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,isnull((select COUNT(id) from Credito where IdCliente = cred.IdCliente and cred.Estado <> 'E'),0) as CanCreditos from
(select FechaEntrega,Credito.id,credito.Nombre,Monto,Pagare,TiposDeCredito.Nombre as tipo,IdPromotor,IdGestor,IdCliente,Estado from Credito inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id  where credito.idgestor = '" & idEmpleado & "' and FechaEntrega is not null and (FechaEntrega >= '" & Format(dateDesde.Value, "yyyy-MM-dd") & "' and FechaEntrega <= '" & Format(dateHasta.Value, "yyyy-MM-dd") & "')) cred inner join
(select * from Empleados where Tipo = 'G') Gestores on cred.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on cred.IdPromotor = Promotores.id) desembolsos"
                End If
            Case "Promotor"
                If ComboElección.Text = "Todos" Then
                    '                    consulta = "select FechaEntrega,cred.id,cred.Nombre,format(cred.Monto,'C','es-mx') as Monto,format(cred.Pagare,'C','es-mx') as Pagaré,cred.Tipo,Promotores.Nombre as Promotor from
                    '(select FechaEntrega,Credito.id,credito.Nombre,Monto,Pagare,TiposDeCredito.Nombre as tipo,IdPromotor from Credito inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id where FechaEntrega is not null and (FechaEntrega >= '" & Format(dateDesde.Value, "yyyy-MM-dd") & "' and FechaEntrega <= '" & Format(dateHasta.Value, "yyyy-MM-dd") & "')) cred inner join
                    '(select * from Empleados where Tipo = 'P') Promotores on cred.IdPromotor = Promotores.id "
                    consulta = "select FechaEntrega,id,Nombre,Monto,Pagaré,Tipo,Gestor,Promotor,case when CanCreditos > 1 then 'Renovación' else 'Nuevo' end as 'Nuevo o Renovación' from
(select FechaEntrega,cred.id,cred.Nombre,format(cred.Monto,'C','es-mx') as Monto,format(cred.Pagare,'C','es-mx') as Pagaré,cred.Tipo,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,isnull((select COUNT(id) from Credito where IdCliente = cred.IdCliente and cred.Estado <> 'E'),0) as CanCreditos from
(select FechaEntrega,Credito.id,credito.Nombre,Monto,Pagare,TiposDeCredito.Nombre as tipo,IdPromotor,IdGestor,IdCliente,Estado from Credito inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id  where FechaEntrega is not null and (FechaEntrega >= '" & Format(dateDesde.Value, "yyyy-MM-dd") & "' and FechaEntrega <= '" & Format(dateHasta.Value, "yyyy-MM-dd") & "')) cred inner join
(select * from Empleados where Tipo = 'G') Gestores on cred.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on cred.IdPromotor = Promotores.id) desembolsos"
                Else
                    '                    consulta = "select FechaEntrega,cred.id,cred.Nombre,format(cred.Monto,'C','es-mx') as Monto,format(cred.Pagare,'C','es-mx') as Pagaré,cred.Tipo,Promotores.Nombre as Promotor from
                    '(select FechaEntrega,Credito.id,credito.Nombre,Monto,Pagare,TiposDeCredito.Nombre as tipo,IdPromotor from Credito inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id where credito.idpromotor = '" & idEmpleado & "' and FechaEntrega is not null and (FechaEntrega >= '" & Format(dateDesde.Value, "yyyy-MM-dd") & "' and FechaEntrega <= '" & Format(dateHasta.Value, "yyyy-MM-dd") & "')) cred inner join
                    '(select * from Empleados where Tipo = 'P') Promotores on cred.IdPromotor = Promotores.id "
                    consulta = "select FechaEntrega,id,Nombre,Monto,Pagaré,Tipo,Gestor,Promotor,case when CanCreditos > 1 then 'Renovación' else 'Nuevo' end as 'Nuevo o Renovación' from
(select FechaEntrega,cred.id,cred.Nombre,format(cred.Monto,'C','es-mx') as Monto,format(cred.Pagare,'C','es-mx') as Pagaré,cred.Tipo,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,isnull((select COUNT(id) from Credito where IdCliente = cred.IdCliente and cred.Estado <> 'E'),0) as CanCreditos from
(select FechaEntrega,Credito.id,credito.Nombre,Monto,Pagare,TiposDeCredito.Nombre as tipo,IdPromotor,IdGestor,IdCliente,Estado from Credito inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id  where credito.idpromotor = '" & idEmpleado & "' and  FechaEntrega is not null and (FechaEntrega >= '" & Format(dateDesde.Value, "yyyy-MM-dd") & "' and FechaEntrega <= '" & Format(dateHasta.Value, "yyyy-MM-dd") & "')) cred inner join
(select * from Empleados where Tipo = 'G') Gestores on cred.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on cred.IdPromotor = Promotores.id) desembolsos"
                End If
            Case "Todos"
                '                consulta = "select FechaEntrega,cred.id,cred.Nombre,format(cred.Monto,'C','es-mx') as Monto,format(cred.Pagare,'C','es-mx') as Pagaré,cred.Tipo,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor from
                '(select FechaEntrega,Credito.id,credito.Nombre,Monto,Pagare,TiposDeCredito.Nombre as tipo,IdPromotor,IdGestor from Credito inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id  where FechaEntrega is not null and (FechaEntrega >= '" & Format(dateDesde.Value, "yyyy-MM-dd") & "' and FechaEntrega <= '" & Format(dateHasta.Value, "yyyy-MM-dd") & "')) cred inner join
                '(select * from Empleados where Tipo = 'G') Gestores on cred.IdGestor = Gestores.id inner join
                '(select * from Empleados where Tipo = 'P') Promotores on cred.IdPromotor = Promotores.id"
                consulta = "select FechaEntrega,id,Nombre,Monto,Pagaré,Tipo,Gestor,Promotor,case when CanCreditos > 1 then 'Renovación' else 'Nuevo' end as 'Nuevo o Renovación' from
(select FechaEntrega,cred.id,cred.Nombre,format(cred.Monto,'C','es-mx') as Monto,format(cred.Pagare,'C','es-mx') as Pagaré,cred.Tipo,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,isnull((select COUNT(id) from Credito where IdCliente = cred.IdCliente and cred.Estado <> 'E'),0) as CanCreditos from
(select FechaEntrega,Credito.id,credito.Nombre,Monto,Pagare,TiposDeCredito.Nombre as tipo,IdPromotor,IdGestor,IdCliente,Estado from Credito inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id  where FechaEntrega is not null and (FechaEntrega >= '" & Format(dateDesde.Value, "yyyy-MM-dd") & "' and FechaEntrega <= '" & Format(dateHasta.Value, "yyyy-MM-dd") & "')) cred inner join
(select * from Empleados where Tipo = 'G') Gestores on cred.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on cred.IdPromotor = Promotores.id) desembolsos"
        End Select


        adapterConsulta = New SqlDataAdapter(consulta, conexionempresa)
        dataConsulta = New DataTable
        adapterConsulta.Fill(dataConsulta)
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        BunifuThinButton22.Enabled = False
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Consultando"
        Cargando.TopMost = True
        BackgroundConsulta.RunWorkerAsync()
    End Sub

    Private Sub BackgroundConsulta_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundConsulta.RunWorkerCompleted
        dtimpuestos.DataSource = dataConsulta
        Dim totalEntregado As Double = 0
        Dim totalPagare As Double = 0

        For Each row As DataGridViewRow In dtimpuestos.Rows
            totalEntregado = totalEntregado + row.Cells(3).Value
            totalPagare = totalPagare + row.Cells(4).Value

        Next
        lblEntregado.Text = FormatCurrency(totalEntregado, 2)
        lblPagare.Text = FormatCurrency(totalPagare, 2)
        Cargando.Close()
        BunifuThinButton22.Enabled = True
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Exportando a Excel"
        Cargando.TopMost = True
        BackgroundExcel.RunWorkerAsync()
    End Sub

    Private Sub BackgroundExcel_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundExcel.DoWork
        nuevolibro()
        GridAExcel(dtimpuestos)
    End Sub

    Private Sub BackgroundExcel_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundExcel.RunWorkerCompleted
        Cargando.Close()
        cerrarlibro()

    End Sub

    Private Sub dtimpuestos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtimpuestos.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Reportes.Panel1.Visible = False
        Reportes.RadPanorama1.Visible = True
    End Sub
End Class