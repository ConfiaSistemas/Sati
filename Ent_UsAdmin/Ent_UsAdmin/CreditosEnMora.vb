Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class CreditosEnMora

    Dim dataGestores As DataSet
    Dim dataPromotores As DataSet
    Dim adapterGestores As SqlDataAdapter

    Dim adapterPromotores As SqlDataAdapter
    Dim dataConsulta As DataTable
    Dim adapterConsulta As SqlDataAdapter
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
                    consulta = "select carteravencida.nombre,carteraVencida.id,format(pagare,'C','es-mx') as Pagaré,format(PagoSemanal,'C','es-mx') as PagoSemanal,format(AbonadoSinMultas,'C','es-mx') as AbonadoSinMultas,format(Multas,'C','es-mx') as Multas,format(AbonadoMultas,'C','es-mx') as AbonadoMultas,format(multasPendientes,'C','es-mx') as MultasPendientes,format(VencidoNormal,'C','es-mx') as VencidoNormal,format(TotalPendiente,'C','es-mx') as TotalPendiente,semanasAtraso,format(((pagare - AbonadoSinMultas) + multasPendientes),'C','es-mx') as LiquidaCon,DatosSolicitud.Telefono,DatosSolicitud.Celular,(DatosSolicitud.Calle + ' ' + DatosSolicitud.Noext + ' ' + DatosSolicitud.Colonia ) as Domicilio,Gestor,carteravencida.Estado from 
(select nombre,id,pagare,PagoSemanal,AbonadoSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes, case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Estado,semanasAtraso,IdSolicitud from
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
(select COUNT(pendiente) AS semanasAtraso from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where CalendarioConvenios.Estado = 'V' and Convenios.id_credito = cartera.id) else
(select count(pendiente) as semanasAtraso from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id) end as semanasAtraso
,
case when Cartera.Estado = 'C' then
(select top 1 (monto + interes) as pagoNormal from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where Convenios.id_credito = Cartera.id and CalendarioConvenios.Estado = 'V' )
else
(select PagoIndividual  as PagoNormal From Credito where id = Cartera.id)
end as PagoSemanal
,
case when Cartera.Estado = 'C' then
isnull((select SUM(calendarioconvenios.pendiente) from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where calendarioconvenios.Estado = 'V' and convenios.id_credito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where CalendarioConvenios.Estado ='V' and Convenios.id_credito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,cartera.Estado,Cartera.IdSolicitud from
(select Credito.nombre,Credito.id,Credito.IdGestor,Credito.Estado,Credito.IdSolicitud from CREDITO inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito  where CalendarioNormal.Estado = 'V' and Credito.Estado <> 'L' group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado,Credito.monto,Credito.Interes,Credito.IdSolicitud) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id  ) CarteraTotal) carteraVencida inner join Solicitud on carteraVencida.IdSolicitud = Solicitud.id inner join DatosSolicitud on solicitud.id = DatosSolicitud.IdSolicitud where VencidoNormal <> 0 order by carteravencida.nombre asc
"

                Else

                    consulta = "select carteravencida.nombre,carteraVencida.id,format(pagare,'C','es-mx') as Pagaré,format(PagoSemanal,'C','es-mx') as PagoSemanal,format(AbonadoSinMultas,'C','es-mx') as AbonadoSinMultas,format(Multas,'C','es-mx') as Multas,format(AbonadoMultas,'C','es-mx') as AbonadoMultas,format(multasPendientes,'C','es-mx') as MultasPendientes,format(VencidoNormal,'C','es-mx') as VencidoNormal,format(TotalPendiente,'C','es-mx') as TotalPendiente,semanasAtraso,format(((pagare - AbonadoSinMultas) + multasPendientes),'C','es-mx') as LiquidaCon,DatosSolicitud.Telefono,DatosSolicitud.Celular,(DatosSolicitud.Calle + ' ' + DatosSolicitud.Noext + ' ' + DatosSolicitud.Colonia ) as Domicilio,Gestor,carteravencida.Estado from 
(select nombre,id,pagare,PagoSemanal,AbonadoSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes, case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Estado,semanasAtraso,IdSolicitud from
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
(select COUNT(pendiente) AS semanasAtraso from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where CalendarioConvenios.Estado = 'V' and Convenios.id_credito = cartera.id) else
(select count(pendiente) as semanasAtraso from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id) end as semanasAtraso
,
case when Cartera.Estado = 'C' then
(select top 1 (monto + interes) as pagoNormal from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where Convenios.id_credito = Cartera.id and CalendarioConvenios.Estado = 'V' )
else
(select PagoIndividual  as PagoNormal From Credito where id = Cartera.id)
end as PagoSemanal
,
case when Cartera.Estado = 'C' then
isnull((select SUM(calendarioconvenios.pendiente) from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where calendarioconvenios.Estado = 'V' and convenios.id_credito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where CalendarioConvenios.Estado ='V' and Convenios.id_credito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,cartera.Estado,Cartera.IdSolicitud from
(select Credito.nombre,Credito.id,Credito.IdGestor,Credito.Estado,Credito.IdSolicitud from CREDITO inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito  where CalendarioNormal.Estado = 'V' and Credito.Estado <> 'L' and credito.idgestor = '" & idEmpleado & "' group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.estado,Credito.monto,Credito.Interes,Credito.IdSolicitud) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id  ) CarteraTotal) carteraVencida inner join Solicitud on carteraVencida.IdSolicitud = Solicitud.id inner join DatosSolicitud on solicitud.id = DatosSolicitud.IdSolicitud where VencidoNormal <> 0 order by carteravencida.nombre asc"
                End If
            Case "Promotor"
                If ComboElección.Text = "Todos" Then
                    consulta = "select carteravencida.nombre,carteraVencida.id,format(pagare,'C','es-mx') as Pagaré,format(PagoSemanal,'C','es-mx') as PagoSemanal,format(AbonadoSinMultas,'C','es-mx') as AbonadoSinMultas,format(Multas,'C','es-mx') as Multas,format(AbonadoMultas,'C','es-mx') as AbonadoMultas,format(multasPendientes,'C','es-mx') as MultasPendientes,format(VencidoNormal,'C','es-mx') as VencidoNormal,format(TotalPendiente,'C','es-mx') as TotalPendiente,semanasAtraso,format(((pagare - AbonadoSinMultas) + multasPendientes),'C','es-mx') as LiquidaCon,DatosSolicitud.Telefono,DatosSolicitud.Celular,(DatosSolicitud.Calle + ' ' + DatosSolicitud.Noext + ' ' + DatosSolicitud.Colonia ) as Domicilio,Promotor,carteravencida.Estado from 
(select nombre,id,pagare,PagoSemanal,AbonadoSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes, case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Promotor,Estado,semanasAtraso,IdSolicitud from
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
(select COUNT(pendiente) AS semanasAtraso from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where CalendarioConvenios.Estado = 'V' and Convenios.id_credito = cartera.id) else
(select count(pendiente) as semanasAtraso from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id) end as semanasAtraso
,
case when Cartera.Estado = 'C' then
(select top 1 (monto + interes) as pagoNormal from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where Convenios.id_credito = Cartera.id and CalendarioConvenios.Estado = 'V' )
else
(select PagoIndividual  as PagoNormal From Credito where id = Cartera.id)
end as PagoSemanal
,
case when Cartera.Estado = 'C' then
isnull((select SUM(calendarioconvenios.pendiente) from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where calendarioconvenios.Estado = 'V' and convenios.id_credito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where CalendarioConvenios.Estado ='V' and Convenios.id_credito = Cartera.id)
else '0' end as MultasVencidas
,Promotores.Nombre as Promotor,cartera.Estado,Cartera.IdSolicitud from
(select Credito.nombre,Credito.id,Credito.IdPromotor,Credito.Estado,Credito.IdSolicitud from CREDITO inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito  where CalendarioNormal.Estado = 'V' and Credito.Estado <> 'L' group by Credito.id,Credito.nombre,Credito.IdPromotor,Credito.estado,Credito.monto,Credito.Interes,Credito.IdSolicitud) Cartera inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal) carteraVencida inner join Solicitud on carteraVencida.IdSolicitud = Solicitud.id inner join DatosSolicitud on solicitud.id = DatosSolicitud.IdSolicitud where VencidoNormal <> 0 order by carteravencida.nombre asc"
                Else
                    consulta = "select carteravencida.nombre,carteraVencida.id,format(pagare,'C','es-mx') as Pagaré,format(PagoSemanal,'C','es-mx') as PagoSemanal,format(AbonadoSinMultas,'C','es-mx') as AbonadoSinMultas,format(Multas,'C','es-mx') as Multas,format(AbonadoMultas,'C','es-mx') as AbonadoMultas,format(multasPendientes,'C','es-mx') as MultasPendientes,format(VencidoNormal,'C','es-mx') as VencidoNormal,format(TotalPendiente,'C','es-mx') as TotalPendiente,semanasAtraso,format(((pagare - AbonadoSinMultas) + multasPendientes),'C','es-mx') as LiquidaCon,DatosSolicitud.Telefono,DatosSolicitud.Celular,(DatosSolicitud.Calle + ' ' + DatosSolicitud.Noext + ' ' + DatosSolicitud.Colonia ) as Domicilio,Promotor,carteravencida.Estado from 
(select nombre,id,pagare,PagoSemanal,AbonadoSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes, case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Promotor,Estado,semanasAtraso,IdSolicitud from
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
(select COUNT(pendiente) AS semanasAtraso from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where CalendarioConvenios.Estado = 'V' and Convenios.id_credito = cartera.id) else
(select count(pendiente) as semanasAtraso from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id) end as semanasAtraso
,
case when Cartera.Estado = 'C' then
(select top 1 (monto + interes) as pagoNormal from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where Convenios.id_credito = Cartera.id and CalendarioConvenios.Estado = 'V' )
else
(select PagoIndividual  as PagoNormal From Credito where id = Cartera.id)
end as PagoSemanal
,
case when Cartera.Estado = 'C' then
isnull((select SUM(calendarioconvenios.pendiente) from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where calendarioconvenios.Estado = 'V' and convenios.id_credito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where CalendarioConvenios.Estado ='V' and Convenios.id_credito = Cartera.id)
else '0' end as MultasVencidas
,Promotores.Nombre as Promotor,cartera.Estado,Cartera.IdSolicitud from
(select Credito.nombre,Credito.id,Credito.IdPromotor,Credito.Estado,Credito.IdSolicitud from CREDITO inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito  where CalendarioNormal.Estado = 'V' and Credito.Estado <> 'L' and credito.idpromotor = '" & idEmpleado & "' group by Credito.id,Credito.nombre,Credito.IdPromotor,Credito.estado,Credito.monto,Credito.Interes,Credito.IdSolicitud) Cartera inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal) carteraVencida inner join Solicitud on carteraVencida.IdSolicitud = Solicitud.id inner join DatosSolicitud on solicitud.id = DatosSolicitud.IdSolicitud where VencidoNormal <> 0 order by carteravencida.nombre asc"
                End If
            Case "Todos"
                consulta = "select creditos_en_mora.*,
(case when (Diasdeatraso/7) < 1 then 'Goteo' when (Diasdeatraso /7) between 1 and 4 then 'Nivel 1' when (Diasdeatraso /7) between 5 and 8 then 'Nivel 2' when (Diasdeatraso /7) between 9 and 12 then 'Nivel 3' when (Diasdeatraso /7) between 13 and 16 then 'Nivel 4' else 'Legal'end)as Nivel
from
(select carteraVencida.id, carteravencida.nombre as Nombre,format(pagare,'C','es-mx') as Pagaré,format(PagoSemanal,'C','es-mx') as 'Pago Semanal',format(AbonadoSinMultas,'C','es-mx') as 'Abonado sin multas',format(Multas,'C','es-mx') as Multas,format(AbonadoMultas,'C','es-mx') as 'Multas abonadas',format(multasPendientes,'C','es-mx') as 'Multas pendientes',format(VencidoNormal,'C','es-mx') as 'Vencido normal',format(TotalPendiente,'C','es-mx') as 'Total Pendiente',Pagos_atrasados as 'Pagos atrasados',FechaDeAtraso as 'Fecha del último abono',
case when FechaDeAtraso = 'Nunca' then
	(case when carteraVencida.Estado = 'C' then
	datediff(day,(select top 1 fechapago from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where Abonado < (monto+interes) and ConveniosSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	else 
	datediff(day,(select top 1 fechapago from CalendarioNormal where Abonado < (monto+interes) and id_credito = carteraVencida.id order by FechaPago asc),GETDATE())
	end)
else (case when carteraVencida.Estado = 'C' then
	datediff(day,(select top 1 fechapago from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where Abonado < (monto+interes) and ConveniosSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	else 
	datediff(day,(select top 1 fechapago from CalendarioNormal where Abonado < (monto+interes) and id_credito = carteraVencida.id order by FechaPago asc),GETDATE())
	end)
end as Diasdeatraso
,format(((pagare - AbonadoSinMultas) + multasPendientes),'C','es-mx') as 'Liquida con',DatosSolicitud.Telefono,DatosSolicitud.Celular,(DatosSolicitud.Calle + ' ' + DatosSolicitud.Noext + ' ' + DatosSolicitud.Colonia ) as Domicilio,Promotor,carteravencida.Estado from 
(select nombre,id,pagare,PagoSemanal,AbonadoSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes, case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Promotor,Estado,Pagos_atrasados,IdSolicitud,FechaDeAtraso from
(select Cartera.nombre,Cartera.id,
case when Cartera.Estado = 'C' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where Abonado <> 0 and Abonado >= interes and conveniossac.idcredito = Cartera.id group by idcredito),0)
else
isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id group by id_credito),0) end as AbonadoSinMultas,
case when Cartera.Estado = 'C' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioConveniossac.estado = 'V' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0) 
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
(select SUM(calendarioconveniossac.monto) from CalendarioConveniossac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where conveniossac.idcredito = Cartera.id)
else
(select Pagare from credito where id = Cartera.id) end as pagare,
case when Cartera.Estado = 'C' then
(select COUNT(pendiente) AS Pagos_atrasados from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado = 'V' and Conveniossac.idcredito = cartera.id) else
(select count(pendiente) as Pagos_atrasados from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id) end as Pagos_atrasados
,
case when Cartera.Estado = 'C' then
(select top 1 (monto + interes) as pagoNormal from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where Conveniossac.idcredito = Cartera.id and CalendarioConveniossac.Estado = 'V' )
else
(select PagoIndividual  as PagoNormal From Credito where id = Cartera.id)
end as PagoSemanal
,
case when Cartera.Estado = 'C' then
isnull((select SUM(calendarioconveniossac.pendiente) from CalendarioConveniossac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where calendarioconveniossac.Estado = 'V' and conveniossac.idcredito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
isnull(convert(varchar,(select top 1 CalendarioConveniosSac.Fecha from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniosSac.Fecha>'1900-01-01' and ConveniosSac.idCredito = Cartera.id order by CalendarioConveniosSac.Fecha desc),23),'Nunca')
else
isnull(convert(varchar,(select top 1 FechaUltimoPago from CalendarioNormal where FechaUltimoPago>'1900-01-01' and CalendarioNormal.id_credito = Cartera.id order by FechaUltimoPago desc),23),'Nunca')
end as FechaDeAtraso,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado ='V' and Conveniossac.idcredito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado,Cartera.IdSolicitud from
(select Credito.nombre,Credito.id,Credito.IdGestor,Credito.IdPromotor,Credito.Estado,Credito.IdSolicitud from CREDITO inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito  where CalendarioNormal.Estado = 'V' and Credito.Estado <> 'L' group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado,Credito.monto,Credito.Interes,Credito.IdSolicitud) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal) carteraVencida inner join Solicitud on carteraVencida.IdSolicitud = Solicitud.id inner join DatosSolicitud on solicitud.id = DatosSolicitud.IdSolicitud where VencidoNormal <> 0)creditos_en_mora order by creditos_en_mora.nombre asc"
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
    End Sub
End Class