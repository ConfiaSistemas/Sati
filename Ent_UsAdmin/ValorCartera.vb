Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class ValorCartera

    Dim dataGestores As DataSet
    Dim dataPromotores As DataSet
    Dim adapterGestores As SqlDataAdapter

    Dim adapterPromotores As SqlDataAdapter
    Dim dataConsulta As DataTable
    Dim adapterConsulta As SqlDataAdapter
    Dim totalSmultas, totalCmultas, totalNormal, totalVCmultas As Double
    Dim porcentajeSmultas As Double
    Dim porcentajeCmultas As Double
    Private Sub Desembolsos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        ComboFiltro.SelectedIndex = 0
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
                    consulta = "select nombre,id,pagare,AbonadoSinMultas,(pagare-AbonadoSinMultas) as valorCarteraSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,((Multas-(AbonadoMultasL+AbonadoMultasV))+(pagare-AbonadoSinMultas)) as ValorCarteraConMultas, case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Estado from
(select Cartera.nombre,Cartera.id,
case when Cartera.Estado = 'C' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where Abonado <> 0 and Abonado >= interes and convenios.id_credito = Cartera.id group by id_credito),0)
else
isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id group by id_credito),0) end as AbonadoSinMultas,
case when Cartera.Estado = 'C' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConvenios inner join Convenios on Convenios.id = CalendarioConvenios.Id_Convenio where abonado <> 0 and abonado <= interes and CalendarioConvenios.estado = 'V' and Convenios.id_credito = Cartera.id group by Convenios.id_credito),0) 
else
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)),0)end as AbonadoMultasV,
case when Cartera.Estado = 'C' then
isnull((select SUM(Abonado - CalendarioConvenios.monto) as AbonadoMultas from CalendarioConvenios inner join Convenios on Convenios.id = CalendarioConvenios.Id_Convenio where  CalendarioConvenios.estado = 'L' and Convenios.id_credito = Cartera.id group by Convenios.id_credito),0)
else
isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L' and CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as AbonadoMultasL,
case when Cartera.Estado = 'C' THEN 
isnull((select SUM(CalendarioConvenios.interes) as Multas from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where  Convenios.id_credito = Cartera.id group by Convenios.id_credito),0)
else
isnull((select SUM(CalendarioNormal.interes) as Multas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as Multas,
case when cartera.Estado = 'C' THEN 
(select SUM(calendarioconvenios.monto) from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where convenios.id_credito = Cartera.id)
else
(select Pagare from credito where id = Cartera.id) end as pagare,
case when Cartera.Estado = 'C' then
isnull((select SUM(calendarioconvenios.pendiente) from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where calendarioconvenios.Estado = 'V' and convenios.id_credito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where CalendarioConvenios.Estado ='V' and Convenios.id_credito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,cartera.Estado from
(select credito.nombre,Credito.id,Credito.idgestor,credito.Estado from Credito inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito where Credito.Estado <> 'L' group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id ) CarteraTotal order by nombre asc"

                Else

                    consulta = "select nombre,id,pagare,AbonadoSinMultas,(pagare-AbonadoSinMultas) as valorCarteraSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,((Multas-(AbonadoMultasL+AbonadoMultasV))+(pagare-AbonadoSinMultas)) as ValorCarteraConMultas, case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Estado from
(select Cartera.nombre,Cartera.id,
case when Cartera.Estado = 'C' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where Abonado <> 0 and Abonado >= interes and convenios.id_credito = Cartera.id group by id_credito),0)
else
isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id group by id_credito),0) end as AbonadoSinMultas,
case when Cartera.Estado = 'C' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConvenios inner join Convenios on Convenios.id = CalendarioConvenios.Id_Convenio where abonado <> 0 and abonado <= interes and CalendarioConvenios.estado = 'V' and Convenios.id_credito = Cartera.id group by Convenios.id_credito),0) 
else
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)),0)end as AbonadoMultasV,
case when Cartera.Estado = 'C' then
isnull((select SUM(Abonado - CalendarioConvenios.monto) as AbonadoMultas from CalendarioConvenios inner join Convenios on Convenios.id = CalendarioConvenios.Id_Convenio where  CalendarioConvenios.estado = 'L' and Convenios.id_credito = Cartera.id group by Convenios.id_credito),0)
else
isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L' and CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as AbonadoMultasL,
case when Cartera.Estado = 'C' THEN 
isnull((select SUM(CalendarioConvenios.interes) as Multas from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where  Convenios.id_credito = Cartera.id group by Convenios.id_credito),0)
else
isnull((select SUM(CalendarioNormal.interes) as Multas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as Multas,
case when cartera.Estado = 'C' THEN 
(select SUM(calendarioconvenios.monto) from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where convenios.id_credito = Cartera.id)
else
(select Pagare from credito where id = Cartera.id) end as pagare,
case when Cartera.Estado = 'C' then
isnull((select SUM(calendarioconvenios.pendiente) from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where calendarioconvenios.Estado = 'V' and convenios.id_credito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where CalendarioConvenios.Estado ='V' and Convenios.id_credito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,cartera.Estado from
(select credito.nombre,Credito.id,Credito.idgestor,credito.Estado from Credito inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito where Credito.Estado <> 'L' and credito.idgestor = '" & idEmpleado & "' group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id  ) CarteraTotal order by nombre asc"
                End If
            Case "Promotor"
                If ComboElección.Text = "Todos" Then
                    consulta = "select nombre,id,pagare,AbonadoSinMultas,(pagare-AbonadoSinMultas) as valorCarteraSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,((Multas-(AbonadoMultasL+AbonadoMultasV))+(pagare-AbonadoSinMultas)) as ValorCarteraConMultas, case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Promotor,Estado from
(select Cartera.nombre,Cartera.id,
case when Cartera.Estado = 'C' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where Abonado <> 0 and Abonado >= interes and convenios.id_credito = Cartera.id group by id_credito),0)
else
isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id group by id_credito),0) end as AbonadoSinMultas,
case when Cartera.Estado = 'C' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConvenios inner join Convenios on Convenios.id = CalendarioConvenios.Id_Convenio where abonado <> 0 and abonado <= interes and CalendarioConvenios.estado = 'V' and Convenios.id_credito = Cartera.id group by Convenios.id_credito),0) 
else
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)),0)end as AbonadoMultasV,
case when Cartera.Estado = 'C' then
isnull((select SUM(Abonado - CalendarioConvenios.monto) as AbonadoMultas from CalendarioConvenios inner join Convenios on Convenios.id = CalendarioConvenios.Id_Convenio where  CalendarioConvenios.estado = 'L' and Convenios.id_credito = Cartera.id group by Convenios.id_credito),0)
else
isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L' and CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as AbonadoMultasL,
case when Cartera.Estado = 'C' THEN 
isnull((select SUM(CalendarioConvenios.interes) as Multas from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where  Convenios.id_credito = Cartera.id group by Convenios.id_credito),0)
else
isnull((select SUM(CalendarioNormal.interes) as Multas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as Multas,
case when cartera.Estado = 'C' THEN 
(select SUM(calendarioconvenios.monto) from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where convenios.id_credito = Cartera.id)
else
(select Pagare from credito where id = Cartera.id) end as pagare,
case when Cartera.Estado = 'C' then
isnull((select SUM(calendarioconvenios.pendiente) from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where calendarioconvenios.Estado = 'V' and convenios.id_credito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where CalendarioConvenios.Estado ='V' and Convenios.id_credito = Cartera.id)
else '0' end as MultasVencidas
,Promotores.Nombre as Promotor,cartera.Estado from
(select credito.nombre,Credito.id,Credito.IdPromotor,credito.Estado from Credito inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito where Credito.Estado <> 'L' group by Credito.id,Credito.nombre,Credito.IdPromotor,Credito.estado) Cartera inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal order by nombre asc"
                Else
                    consulta = "select nombre,id,pagare,AbonadoSinMultas,(pagare-AbonadoSinMultas) as valorCarteraSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,((Multas-(AbonadoMultasL+AbonadoMultasV))+(pagare-AbonadoSinMultas)) as ValorCarteraConMultas, case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Promotor,Estado from
(select Cartera.nombre,Cartera.id,
case when Cartera.Estado = 'C' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where Abonado <> 0 and Abonado >= interes and convenios.id_credito = Cartera.id group by id_credito),0)
else
isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id group by id_credito),0) end as AbonadoSinMultas,
case when Cartera.Estado = 'C' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConvenios inner join Convenios on Convenios.id = CalendarioConvenios.Id_Convenio where abonado <> 0 and abonado <= interes and CalendarioConvenios.estado = 'V' and Convenios.id_credito = Cartera.id group by Convenios.id_credito),0) 
else
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)),0)end as AbonadoMultasV,
case when Cartera.Estado = 'C' then
isnull((select SUM(Abonado - CalendarioConvenios.monto) as AbonadoMultas from CalendarioConvenios inner join Convenios on Convenios.id = CalendarioConvenios.Id_Convenio where  CalendarioConvenios.estado = 'L' and Convenios.id_credito = Cartera.id group by Convenios.id_credito),0)
else
isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L' and CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as AbonadoMultasL,
case when Cartera.Estado = 'C' THEN 
isnull((select SUM(CalendarioConvenios.interes) as Multas from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where  Convenios.id_credito = Cartera.id group by Convenios.id_credito),0)
else
isnull((select SUM(CalendarioNormal.interes) as Multas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as Multas,
case when cartera.Estado = 'C' THEN 
(select SUM(calendarioconvenios.monto) from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where convenios.id_credito = Cartera.id)
else
(select Pagare from credito where id = Cartera.id) end as pagare,
case when Cartera.Estado = 'C' then
isnull((select SUM(calendarioconvenios.pendiente) from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where calendarioconvenios.Estado = 'V' and convenios.id_credito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where CalendarioConvenios.Estado ='V' and Convenios.id_credito = Cartera.id)
else '0' end as MultasVencidas
,Promotores.Nombre as Promotor,cartera.Estado from
(select credito.nombre,Credito.id,Credito.IdPromotor,credito.Estado from Credito inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito where Credito.Estado <> 'L' and credito.idpromotor = '" & idEmpleado & "' group by Credito.id,Credito.nombre,Credito.IdPromotor,Credito.estado) Cartera inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal order by nombre asc"
                End If
            Case "Todos"
                consulta = "select nombre,id,pagare,AbonadoSinMultas,(pagare-AbonadoSinMultas) as valorCarteraSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,((Multas-(AbonadoMultasL+AbonadoMultasV))+(pagare-AbonadoSinMultas)) as ValorCarteraConMultas, case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Promotor,Estado from
(select Cartera.nombre,Cartera.id,
case when Cartera.Estado = 'C' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where Abonado <> 0 and Abonado >= interes and conveniossac.idcredito = Cartera.id group by idcredito),0)
else
isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id group by id_credito),0) end as AbonadoSinMultas,
case when Cartera.Estado = 'C' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConveniossac inner join Conveniossac on ConveniosSac.id = CalendarioConveniossac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioConveniossac.estado = 'V' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0) 
else
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)),0)end as AbonadoMultasV,
case when Cartera.Estado = 'C' then
isnull((select SUM(Abonado - CalendarioConveniossac.monto) as AbonadoMultas from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where  CalendarioConveniossac.estado = 'L' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
else
isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L' and CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as AbonadoMultasL,
case when Cartera.Estado = 'C' THEN 
isnull((select SUM(CalendarioConveniossac.interes) as Multas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where  Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
else
isnull((select SUM(CalendarioNormal.interes) as Multas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as Multas,
case when cartera.Estado = 'C' THEN 
(select SUM(calendarioconveniossac.monto) from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where conveniossac.idcredito = Cartera.id)
else
(select Pagare from credito where id = Cartera.id) end as pagare,
case when Cartera.Estado = 'C' then
isnull((select SUM(calendarioconveniossac.pendiente) from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where calendarioconveniossac.Estado = 'V' and conveniossac.idcredito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado ='V' and Conveniossac.idcredito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado from
(select credito.nombre,Credito.id,Credito.idgestor,Credito.IdPromotor,credito.Estado from Credito inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito where Credito.Estado <> 'L' and credito.estado <> 'T' group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal order by nombre asc"
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
        Dim num_controles As Integer = FlowLayoutPanel1.Controls.Count - 1
        For n As Integer = num_controles To 0 Step -1
            Dim ctrl As Control = FlowLayoutPanel1.Controls(n)
            FlowLayoutPanel1.Controls.Remove(ctrl)
            ctrl.Dispose()
        Next

        totalSmultas = 0
        totalCmultas = 0
        totalNormal = 0
        totalVCmultas = 0
        porcentajeCmultas = 0
        porcentajeSmultas = 0
        Dim TotalCantCreditos As Double = 0
        Dim totalCreditosSanos As Double = 0
        Dim totalCreditosMorosos As Double = 0

        For Each row As DataGridViewRow In dtimpuestos.Rows
            totalSmultas = totalSmultas + row.Cells("ValorCarteraSinMultas").Value
            totalCmultas = totalCmultas + row.Cells("ValorCarteraConMultas").Value
            totalNormal = totalNormal + row.Cells("VencidoNormal").Value
            totalVCmultas = totalVCmultas + row.Cells("TotalPendiente").Value
            If Val(row.Cells("valorCarteraSinMultas").Value) <> 0 Then
                TotalCantCreditos += 1
                If Val(row.Cells("VencidoNormal").Value) > 0 Then
                    totalCreditosMorosos += 1
                Else
                    totalCreditosSanos += 1
                End If
            End If

        Next

        porcentajeSmultas = ((totalNormal * 100) / totalSmultas) / 100
        porcentajeCmultas = ((totalVCmultas * 100) / totalCmultas) / 100

        'lbltotal.Text = FormatCurrency(totalSmultas, 2)
        'lblTotalCmultas.Text = FormatCurrency(totalCmultas, 2)
        'lblTotalNormal.Text = FormatCurrency(totalNormal, 2)
        'lblTotalMultas.Text = FormatCurrency(totalVCmultas, 2)
        'lblporcentajeSmultas.Text = FormatPercent(porcentajeSmultas, 2)
        'lblporcentajeCmultas.Text = FormatPercent(porcentajeCmultas, 2)

        Dim botonValCarteraSmultas As New Bunifu.Framework.UI.BunifuTileButton

        ' botonempresa.Normalcolor = Color.FromArgb(48, 55, 76)
        'botonempresa.Iconimage = My.Resources.lconfia
        botonValCarteraSmultas.Size = New Size(117, 61)
        botonValCarteraSmultas.BackColor = Color.FromArgb(0, 64, 64)
        botonValCarteraSmultas.LabelText = FormatCurrency(totalSmultas, 2)



        FlowLayoutPanel1.Controls.Add(botonValCarteraSmultas)

        Dim botonValCarteraCmultas As New Bunifu.Framework.UI.BunifuTileButton

        ' botonempresa.Normalcolor = Color.FromArgb(48, 55, 76)
        'botonempresa.Iconimage = My.Resources.lconfia
        botonValCarteraCmultas.BackColor = Color.FromArgb(0, 64, 64)
        botonValCarteraCmultas.Size = New Size(117, 61)

        botonValCarteraCmultas.LabelText = FormatCurrency(totalCmultas, 2)



        FlowLayoutPanel1.Controls.Add(botonValCarteraCmultas)



        Dim botonVencidoNormal As New Bunifu.Framework.UI.BunifuTileButton

        ' botonempresa.Normalcolor = Color.FromArgb(48, 55, 76)
        'botonempresa.Iconimage = My.Resources.lconfia
        botonVencidoNormal.BackColor = Color.FromArgb(0, 64, 64)
        botonVencidoNormal.Size = New Size(117, 61)

        botonVencidoNormal.LabelText = FormatCurrency(totalNormal, 2)



        FlowLayoutPanel1.Controls.Add(botonVencidoNormal)



        Dim botonVencidoCmultas As New Bunifu.Framework.UI.BunifuTileButton

        ' botonempresa.Normalcolor = Color.FromArgb(48, 55, 76)
        'botonempresa.Iconimage = My.Resources.lconfia
        botonVencidoCmultas.Size = New Size(117, 61)
        botonVencidoCmultas.BackColor = Color.FromArgb(0, 64, 64)
        botonVencidoCmultas.LabelText = FormatCurrency(totalVCmultas, 2)



        FlowLayoutPanel1.Controls.Add(botonVencidoCmultas)


        Dim botonPorcentajeSmultas As New Bunifu.Framework.UI.BunifuTileButton

        ' botonempresa.Normalcolor = Color.FromArgb(48, 55, 76)
        'botonempresa.Iconimage = My.Resources.lconfia
        botonPorcentajeSmultas.Size = New Size(117, 61)
        botonPorcentajeSmultas.BackColor = Color.FromArgb(0, 64, 64)
        botonPorcentajeSmultas.LabelText = FormatPercent(porcentajeSmultas, 2)



        FlowLayoutPanel1.Controls.Add(botonPorcentajeSmultas)


        Dim botonPorcentajeCmultas As New Bunifu.Framework.UI.BunifuTileButton

        ' botonempresa.Normalcolor = Color.FromArgb(48, 55, 76)
        'botonempresa.Iconimage = My.Resources.lconfia
        botonPorcentajeCmultas.Size = New Size(117, 61)
        botonPorcentajeCmultas.BackColor = Color.FromArgb(0, 64, 64)
        botonPorcentajeCmultas.LabelText = FormatPercent(porcentajeCmultas, 2)



        FlowLayoutPanel1.Controls.Add(botonPorcentajeCmultas)



        Me.Chart2.Series(0).Points.Clear()
        Me.Chart2.Series(0).Points.AddXY("Créditos Morosos (" & totalCreditosMorosos & ")", totalCreditosMorosos)
        Me.Chart2.Series(0).Points.AddXY("Créditos Sanos (" & totalCreditosSanos & ")", totalCreditosSanos)


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

    Private Sub CreditosEnMora_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        BunifuThinButton22.Location = New Point(ComboElección.Location.X + ComboElección.Width + 20, ComboElección.Location.Y)
        Chart2.Location = New Point(Me.Width - Chart2.Width - 20, BunifuThinButton22.Location.Y)
    End Sub
End Class