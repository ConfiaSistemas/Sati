Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class CreditosEnMora
    Dim exApp As New Microsoft.Office.Interop.Excel.Application
    Dim dataGestores As DataSet
    Dim dataPromotores As DataSet
    Dim adapterGestores As SqlDataAdapter
    Dim widthEmpresa = 0, heightEmpresa = 0
    Dim adapterPromotores As SqlDataAdapter
    Dim dataConsulta As DataTable
    Dim adapterConsulta As SqlDataAdapter
    Public arrayEmpresas As ArrayList = New ArrayList
    Dim chicoGrande As Boolean = False

    Private Sub Desembolsos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckForIllegalCrossThreadCalls = False
        FlowEmpresas.Size = New Size(0, 0)
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
                lblFiltro.Visible = False

                '  txtnombre.Enabled = False
                ComboElección.Items.Clear()
                ComboElección.Enabled = False
            Case "Promotor"
                lblFiltro.Visible = True
                ' txtnombre.Enabled = True
                ComboElección.Enabled = True
                ComboElección.Items.Clear()

                ComboElección.Items.Add("Todos")
                For Each row As DataRow In dataPromotores.Tables(0).Rows

                    ComboElección.Items.Add(row("nombre"))
                Next
                ComboElección.SelectedIndex = 0
            Case "Gestor"
                lblFiltro.Visible = True
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
        BackgroundEmpresas.RunWorkerAsync()

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
                    consulta = "select creditos_en_mora.* from
(select carteraVencida.id, carteravencida.nombre as Nombre,format(pagare,'C','es-mx') as Pagaré,format(PagoSemanal,'C','es-mx') as 'Pago Semanal',format(AbonadoSinMultas,'C','es-mx') as 'Abonado sin multas',format(Multas,'C','es-mx') as Multas,format(AbonadoMultas,'C','es-mx') as 'Multas abonadas',format(multasPendientes,'C','es-mx') as 'Multas pendientes',format(VencidoNormal,'C','es-mx') as 'Vencido normal',format(TotalPendiente,'C','es-mx') as 'Total Pendiente',Pagos_atrasados as 'Pagos atrasados',FechaDeAtraso as 'Fecha del último abono',
case when FechaDeAtraso = 'Nunca' then
	(case when carteraVencida.Estado = 'C' then
	datediff(day,(select top 1 fechapago from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where Abonado < (monto+interes) and ConveniosSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	when carteraVencida.Estado = 'R' then
	datediff(day,(select top 1 fechapago from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where Abonado < (monto+interes) and ReestructurasSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	else 
	datediff(day,(select top 1 fechapago from CalendarioNormal where Abonado < (monto+interes) and id_credito = carteraVencida.id order by FechaPago asc),GETDATE())
	end)
else (case when carteraVencida.Estado = 'C' then
	datediff(day,(select top 1 fechapago from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where Abonado < (monto+interes) and ConveniosSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	when carteraVencida.Estado = 'R' then
	datediff(day,(select top 1 fechapago from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where Abonado < (monto+interes) and ReestructurasSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	else 
	datediff(day,(select top 1 fechapago from CalendarioNormal where Abonado < (monto+interes) and id_credito = carteraVencida.id order by FechaPago asc),GETDATE())
	end)
end as Diasdeatraso,
format(((pagare - AbonadoSinMultas) + multasPendientes),'C','es-mx') as 'Liquida con',DatosSolicitud.Telefono,DatosSolicitud.Celular,(DatosSolicitud.Calle + ', ' + DatosSolicitud.Noext + ', ' + DatosSolicitud.Colonia ) as Domicilio,Promotor,Gestor,carteravencida.Estado from 
(select nombre,id,pagare,PagoSemanal,AbonadoSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,
 case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.Estado = 'R' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Promotor,Estado,Pagos_atrasados,IdSolicitud,FechaDeAtraso from
(select Cartera.nombre,Cartera.id,
case when Cartera.Estado = 'C' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where Abonado <> 0 and Abonado >= interes and conveniossac.idcredito = Cartera.id group by idcredito),0)
when Cartera.Estado = 'R' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where Abonado <> 0 and Abonado >= interes and ReestructurasSac.idcredito = Cartera.id group by idcredito),0)
else
isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id group by id_credito),0) end as AbonadoSinMultas,
case when Cartera.Estado = 'C' then
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idconvenio = ConveniosSac.id where CalendarioConveniosSac.estado = 'V' and Abonado <= CalendarioConveniosSac.Interes and ConveniosSac.idCredito =cartera.id group by CalendarioConveniosSac.idConvenio),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioConveniosSac.Interes) ))) )) as AbonadoInteres from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where CalendarioConveniosSac.estado = 'V' and Abonado >=CalendarioConveniosSac.Interes and ConveniosSac.idCredito =cartera.id group by CalendarioConveniosSac.idConvenio),0)),0)
--isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioConveniossac.estado = 'V' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0) 
when Cartera.Estado = 'R' then
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idconvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado <= CalendarioReestructurasSac.Interes and ReestructurasSac.idCredito =cartera.id group by CalendarioReestructurasSac.idConvenio),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioReestructurasSac.Interes) ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado >=CalendarioReestructurasSac.Interes and ReestructurasSac.idCredito =cartera.id group by CalendarioReestructurasSac.idConvenio),0)),0)
else
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)),0)end as AbonadoMultasV,
case when Cartera.Estado = 'C' then
isnull((select SUM(Abonado - CalendarioConveniossac.monto) as AbonadoMultas from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where  CalendarioConveniossac.estado = 'L' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(Abonado - CalendarioReestructurasSac.monto) as AbonadoMultas from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where  CalendarioReestructurasSac.estado = 'L' and ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L' and CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as AbonadoMultasL,
case when Cartera.Estado = 'C' THEN 
isnull((select SUM(CalendarioConveniossac.interes) as Multas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where  Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.interes) as Multas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where  ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(CalendarioNormal.interes) as Multas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as Multas,
case when cartera.Estado = 'C' THEN 
(select SUM(calendarioconveniossac.monto) from CalendarioConveniossac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(CalendarioReestructurasSac.monto) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where ReestructurasSac.idcredito = Cartera.id)
else
(select Pagare from credito where id = Cartera.id) end as pagare,
case when Cartera.Estado = 'C' then
(select COUNT(pendiente) AS Pagos_atrasados from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado = 'V' and Conveniossac.idcredito = cartera.id)
when Cartera.Estado = 'R' then
(select COUNT(pendiente) AS Pagos_atrasados from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = cartera.id)
 else
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
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.pendiente) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
isnull(convert(varchar,(select top 1 CalendarioConveniosSac.Fecha from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniosSac.Fecha>'1900-01-01' and ConveniosSac.idCredito = Cartera.id order by CalendarioConveniosSac.Fecha desc),23),'Nunca')
when Cartera.Estado = 'R' then
isnull(convert(varchar,(select top 1 CalendarioReestructurasSac.Fecha from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Fecha>'1900-01-01' and ReestructurasSac.idCredito = Cartera.id order by CalendarioReestructurasSac.Fecha desc),23),'Nunca')
else
isnull(convert(varchar,(select top 1 FechaUltimoPago from CalendarioNormal where FechaUltimoPago>'1900-01-01' and CalendarioNormal.id_credito = Cartera.id order by FechaUltimoPago desc),23),'Nunca')
end as FechaDeAtraso,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado ='V' and Conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(interes) as MultasVencidas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado ='V' and ReestructurasSac.idcredito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado,Cartera.IdSolicitud,isnull((select id from promesadepago where idcredito = Cartera.id and estado = 'A' and tipocredito = cartera.estado),0) as prompago from
(select Credito.nombre,Credito.id,Credito.IdGestor,Credito.IdPromotor,Credito.Estado,Credito.IdSolicitud from CREDITO inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito  where CalendarioNormal.Estado = 'V'  and Credito.Estado <> 'L' and Credito.Estado <> 'T' and Credito.Nombre like '%" & txtnombre.Text & "%' group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado,Credito.monto,Credito.Interes,Credito.IdSolicitud) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal where prompago = 0) carteraVencida inner join Solicitud on carteraVencida.IdSolicitud = Solicitud.id inner join DatosSolicitud on solicitud.id = DatosSolicitud.IdSolicitud where VencidoNormal <> 0)creditos_en_mora order by creditos_en_mora.nombre asc"

                Else

                    consulta = "select creditos_en_mora.* from
(select carteraVencida.id, carteravencida.nombre as Nombre,format(pagare,'C','es-mx') as Pagaré,format(PagoSemanal,'C','es-mx') as 'Pago Semanal',format(AbonadoSinMultas,'C','es-mx') as 'Abonado sin multas',format(Multas,'C','es-mx') as Multas,format(AbonadoMultas,'C','es-mx') as 'Multas abonadas',format(multasPendientes,'C','es-mx') as 'Multas pendientes',format(VencidoNormal,'C','es-mx') as 'Vencido normal',format(TotalPendiente,'C','es-mx') as 'Total Pendiente',Pagos_atrasados as 'Pagos atrasados',FechaDeAtraso as 'Fecha del último abono',
case when FechaDeAtraso = 'Nunca' then
	(case when carteraVencida.Estado = 'C' then
	datediff(day,(select top 1 fechapago from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where Abonado < (monto+interes) and ConveniosSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	when carteraVencida.Estado = 'R' then
	datediff(day,(select top 1 fechapago from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where Abonado < (monto+interes) and ReestructurasSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	else 
	datediff(day,(select top 1 fechapago from CalendarioNormal where Abonado < (monto+interes) and id_credito = carteraVencida.id order by FechaPago asc),GETDATE())
	end)
else (case when carteraVencida.Estado = 'C' then
	datediff(day,(select top 1 fechapago from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where Abonado < (monto+interes) and ConveniosSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	when carteraVencida.Estado = 'R' then
	datediff(day,(select top 1 fechapago from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where Abonado < (monto+interes) and ReestructurasSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	else 
	datediff(day,(select top 1 fechapago from CalendarioNormal where Abonado < (monto+interes) and id_credito = carteraVencida.id order by FechaPago asc),GETDATE())
	end)
end as Diasdeatraso,
format(((pagare - AbonadoSinMultas) + multasPendientes),'C','es-mx') as 'Liquida con',DatosSolicitud.Telefono,DatosSolicitud.Celular,(DatosSolicitud.Calle + ', ' + DatosSolicitud.Noext + ', ' + DatosSolicitud.Colonia ) as Domicilio,Promotor,Gestor,carteravencida.Estado from 
(select nombre,id,pagare,PagoSemanal,AbonadoSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,
 case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.Estado = 'R' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Promotor,Estado,Pagos_atrasados,IdSolicitud,FechaDeAtraso from
(select Cartera.nombre,Cartera.id,
case when Cartera.Estado = 'C' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where Abonado <> 0 and Abonado >= interes and conveniossac.idcredito = Cartera.id group by idcredito),0)
when Cartera.Estado = 'R' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where Abonado <> 0 and Abonado >= interes and ReestructurasSac.idcredito = Cartera.id group by idcredito),0)
else
isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id group by id_credito),0) end as AbonadoSinMultas,
case when Cartera.Estado = 'C' then
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idconvenio = ConveniosSac.id where CalendarioConveniosSac.estado = 'V' and Abonado <= CalendarioConveniosSac.Interes and ConveniosSac.idCredito =cartera.id group by CalendarioConveniosSac.idConvenio),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioConveniosSac.Interes) ))) )) as AbonadoInteres from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where CalendarioConveniosSac.estado = 'V' and Abonado >=CalendarioConveniosSac.Interes and ConveniosSac.idCredito =cartera.id group by CalendarioConveniosSac.idConvenio),0)),0)
--isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioConveniossac.estado = 'V' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0) 
when Cartera.Estado = 'R' then
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idconvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado <= CalendarioReestructurasSac.Interes and ReestructurasSac.idCredito =cartera.id group by CalendarioReestructurasSac.idConvenio),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioReestructurasSac.Interes) ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado >=CalendarioReestructurasSac.Interes and ReestructurasSac.idCredito =cartera.id group by CalendarioReestructurasSac.idConvenio),0)),0)
else
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)),0)end as AbonadoMultasV,
case when Cartera.Estado = 'C' then
isnull((select SUM(Abonado - CalendarioConveniossac.monto) as AbonadoMultas from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where  CalendarioConveniossac.estado = 'L' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(Abonado - CalendarioReestructurasSac.monto) as AbonadoMultas from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where  CalendarioReestructurasSac.estado = 'L' and ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L' and CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as AbonadoMultasL,
case when Cartera.Estado = 'C' THEN 
isnull((select SUM(CalendarioConveniossac.interes) as Multas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where  Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.interes) as Multas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where  ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(CalendarioNormal.interes) as Multas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as Multas,
case when cartera.Estado = 'C' THEN 
(select SUM(calendarioconveniossac.monto) from CalendarioConveniossac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(CalendarioReestructurasSac.monto) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where ReestructurasSac.idcredito = Cartera.id)
else
(select Pagare from credito where id = Cartera.id) end as pagare,
case when Cartera.Estado = 'C' then
(select COUNT(pendiente) AS Pagos_atrasados from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado = 'V' and Conveniossac.idcredito = cartera.id)
when Cartera.Estado = 'R' then
(select COUNT(pendiente) AS Pagos_atrasados from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = cartera.id)
 else
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
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.pendiente) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
isnull(convert(varchar,(select top 1 CalendarioConveniosSac.Fecha from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniosSac.Fecha>'1900-01-01' and ConveniosSac.idCredito = Cartera.id order by CalendarioConveniosSac.Fecha desc),23),'Nunca')
when Cartera.Estado = 'R' then
isnull(convert(varchar,(select top 1 CalendarioReestructurasSac.Fecha from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Fecha>'1900-01-01' and ReestructurasSac.idCredito = Cartera.id order by CalendarioReestructurasSac.Fecha desc),23),'Nunca')
else
isnull(convert(varchar,(select top 1 FechaUltimoPago from CalendarioNormal where FechaUltimoPago>'1900-01-01' and CalendarioNormal.id_credito = Cartera.id order by FechaUltimoPago desc),23),'Nunca')
end as FechaDeAtraso,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado ='V' and Conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(interes) as MultasVencidas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado ='V' and ReestructurasSac.idcredito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado,Cartera.IdSolicitud,isnull((select id from promesadepago where idcredito = Cartera.id and estado = 'A' and tipocredito = cartera.estado),0) as prompago from
(select Credito.nombre,Credito.id,Credito.IdGestor,Credito.IdPromotor,Credito.Estado,Credito.IdSolicitud from CREDITO inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito  where CalendarioNormal.Estado = 'V'  and Credito.Estado <> 'L' and Credito.Estado <> 'T' and idgestor = '" & idEmpleado & "' and Credito.Nombre like '%" & txtnombre.Text & "%' group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado,Credito.monto,Credito.Interes,Credito.IdSolicitud) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal where prompago = 0) carteraVencida inner join Solicitud on carteraVencida.IdSolicitud = Solicitud.id inner join DatosSolicitud on solicitud.id = DatosSolicitud.IdSolicitud where VencidoNormal <> 0)creditos_en_mora order by creditos_en_mora.nombre asc"
                End If
            Case "Promotor"
                If ComboElección.Text = "Todos" Then
                    consulta = "select creditos_en_mora.* from
(select carteraVencida.id, carteravencida.nombre as Nombre,format(pagare,'C','es-mx') as Pagaré,format(PagoSemanal,'C','es-mx') as 'Pago Semanal',format(AbonadoSinMultas,'C','es-mx') as 'Abonado sin multas',format(Multas,'C','es-mx') as Multas,format(AbonadoMultas,'C','es-mx') as 'Multas abonadas',format(multasPendientes,'C','es-mx') as 'Multas pendientes',format(VencidoNormal,'C','es-mx') as 'Vencido normal',format(TotalPendiente,'C','es-mx') as 'Total Pendiente',Pagos_atrasados as 'Pagos atrasados',FechaDeAtraso as 'Fecha del último abono',
case when FechaDeAtraso = 'Nunca' then
	(case when carteraVencida.Estado = 'C' then
	datediff(day,(select top 1 fechapago from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where Abonado < (monto+interes) and ConveniosSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	when carteraVencida.Estado = 'R' then
	datediff(day,(select top 1 fechapago from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where Abonado < (monto+interes) and ReestructurasSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	else 
	datediff(day,(select top 1 fechapago from CalendarioNormal where Abonado < (monto+interes) and id_credito = carteraVencida.id order by FechaPago asc),GETDATE())
	end)
else (case when carteraVencida.Estado = 'C' then
	datediff(day,(select top 1 fechapago from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where Abonado < (monto+interes) and ConveniosSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	when carteraVencida.Estado = 'R' then
	datediff(day,(select top 1 fechapago from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where Abonado < (monto+interes) and ReestructurasSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	else 
	datediff(day,(select top 1 fechapago from CalendarioNormal where Abonado < (monto+interes) and id_credito = carteraVencida.id order by FechaPago asc),GETDATE())
	end)
end as Diasdeatraso,
format(((pagare - AbonadoSinMultas) + multasPendientes),'C','es-mx') as 'Liquida con',DatosSolicitud.Telefono,DatosSolicitud.Celular,(DatosSolicitud.Calle + ', ' + DatosSolicitud.Noext + ', ' + DatosSolicitud.Colonia ) as Domicilio,Promotor,Gestor,carteravencida.Estado from 
(select nombre,id,pagare,PagoSemanal,AbonadoSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,
 case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.Estado = 'R' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Promotor,Estado,Pagos_atrasados,IdSolicitud,FechaDeAtraso from
(select Cartera.nombre,Cartera.id,
case when Cartera.Estado = 'C' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where Abonado <> 0 and Abonado >= interes and conveniossac.idcredito = Cartera.id group by idcredito),0)
when Cartera.Estado = 'R' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where Abonado <> 0 and Abonado >= interes and ReestructurasSac.idcredito = Cartera.id group by idcredito),0)
else
isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id group by id_credito),0) end as AbonadoSinMultas,
case when Cartera.Estado = 'C' then
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idconvenio = ConveniosSac.id where CalendarioConveniosSac.estado = 'V' and Abonado <= CalendarioConveniosSac.Interes and ConveniosSac.idCredito =cartera.id group by CalendarioConveniosSac.idConvenio),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioConveniosSac.Interes) ))) )) as AbonadoInteres from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where CalendarioConveniosSac.estado = 'V' and Abonado >=CalendarioConveniosSac.Interes and ConveniosSac.idCredito =cartera.id group by CalendarioConveniosSac.idConvenio),0)),0)
--isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioConveniossac.estado = 'V' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0) 
when Cartera.Estado = 'R' then
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idconvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado <= CalendarioReestructurasSac.Interes and ReestructurasSac.idCredito =cartera.id group by CalendarioReestructurasSac.idConvenio),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioReestructurasSac.Interes) ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado >=CalendarioReestructurasSac.Interes and ReestructurasSac.idCredito =cartera.id group by CalendarioReestructurasSac.idConvenio),0)),0)
else
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)),0)end as AbonadoMultasV,
case when Cartera.Estado = 'C' then
isnull((select SUM(Abonado - CalendarioConveniossac.monto) as AbonadoMultas from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where  CalendarioConveniossac.estado = 'L' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(Abonado - CalendarioReestructurasSac.monto) as AbonadoMultas from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where  CalendarioReestructurasSac.estado = 'L' and ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L' and CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as AbonadoMultasL,
case when Cartera.Estado = 'C' THEN 
isnull((select SUM(CalendarioConveniossac.interes) as Multas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where  Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.interes) as Multas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where  ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(CalendarioNormal.interes) as Multas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as Multas,
case when cartera.Estado = 'C' THEN 
(select SUM(calendarioconveniossac.monto) from CalendarioConveniossac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(CalendarioReestructurasSac.monto) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where ReestructurasSac.idcredito = Cartera.id)
else
(select Pagare from credito where id = Cartera.id) end as pagare,
case when Cartera.Estado = 'C' then
(select COUNT(pendiente) AS Pagos_atrasados from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado = 'V' and Conveniossac.idcredito = cartera.id)
when Cartera.Estado = 'R' then
(select COUNT(pendiente) AS Pagos_atrasados from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = cartera.id)
 else
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
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.pendiente) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
isnull(convert(varchar,(select top 1 CalendarioConveniosSac.Fecha from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniosSac.Fecha>'1900-01-01' and ConveniosSac.idCredito = Cartera.id order by CalendarioConveniosSac.Fecha desc),23),'Nunca')
when Cartera.Estado = 'R' then
isnull(convert(varchar,(select top 1 CalendarioReestructurasSac.Fecha from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Fecha>'1900-01-01' and ReestructurasSac.idCredito = Cartera.id order by CalendarioReestructurasSac.Fecha desc),23),'Nunca')
else
isnull(convert(varchar,(select top 1 FechaUltimoPago from CalendarioNormal where FechaUltimoPago>'1900-01-01' and CalendarioNormal.id_credito = Cartera.id order by FechaUltimoPago desc),23),'Nunca')
end as FechaDeAtraso,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado ='V' and Conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(interes) as MultasVencidas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado ='V' and ReestructurasSac.idcredito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado,Cartera.IdSolicitud,isnull((select id from promesadepago where idcredito = Cartera.id and estado = 'A' and tipocredito = cartera.estado),0) as prompago from
(select Credito.nombre,Credito.id,Credito.IdGestor,Credito.IdPromotor,Credito.Estado,Credito.IdSolicitud from CREDITO inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito  where CalendarioNormal.Estado = 'V'  and Credito.Estado <> 'L' and Credito.Estado <> 'T' and Credito.Nombre like '%" & txtnombre.Text & "%' group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado,Credito.monto,Credito.Interes,Credito.IdSolicitud) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal where prompago = 0) carteraVencida inner join Solicitud on carteraVencida.IdSolicitud = Solicitud.id inner join DatosSolicitud on solicitud.id = DatosSolicitud.IdSolicitud where VencidoNormal <> 0)creditos_en_mora order by creditos_en_mora.nombre asc"
                Else
                    consulta = "select creditos_en_mora.* from
(select carteraVencida.id, carteravencida.nombre as Nombre,format(pagare,'C','es-mx') as Pagaré,format(PagoSemanal,'C','es-mx') as 'Pago Semanal',format(AbonadoSinMultas,'C','es-mx') as 'Abonado sin multas',format(Multas,'C','es-mx') as Multas,format(AbonadoMultas,'C','es-mx') as 'Multas abonadas',format(multasPendientes,'C','es-mx') as 'Multas pendientes',format(VencidoNormal,'C','es-mx') as 'Vencido normal',format(TotalPendiente,'C','es-mx') as 'Total Pendiente',Pagos_atrasados as 'Pagos atrasados',FechaDeAtraso as 'Fecha del último abono',
case when FechaDeAtraso = 'Nunca' then
	(case when carteraVencida.Estado = 'C' then
	datediff(day,(select top 1 fechapago from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where Abonado < (monto+interes) and ConveniosSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	when carteraVencida.Estado = 'R' then
	datediff(day,(select top 1 fechapago from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where Abonado < (monto+interes) and ReestructurasSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	else 
	datediff(day,(select top 1 fechapago from CalendarioNormal where Abonado < (monto+interes) and id_credito = carteraVencida.id order by FechaPago asc),GETDATE())
	end)
else (case when carteraVencida.Estado = 'C' then
	datediff(day,(select top 1 fechapago from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where Abonado < (monto+interes) and ConveniosSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	when carteraVencida.Estado = 'R' then
	datediff(day,(select top 1 fechapago from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where Abonado < (monto+interes) and ReestructurasSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	else 
	datediff(day,(select top 1 fechapago from CalendarioNormal where Abonado < (monto+interes) and id_credito = carteraVencida.id order by FechaPago asc),GETDATE())
	end)
end as Diasdeatraso,
format(((pagare - AbonadoSinMultas) + multasPendientes),'C','es-mx') as 'Liquida con',DatosSolicitud.Telefono,DatosSolicitud.Celular,(DatosSolicitud.Calle + ', ' + DatosSolicitud.Noext + ', ' + DatosSolicitud.Colonia ) as Domicilio,Promotor,Gestor,carteravencida.Estado from 
(select nombre,id,pagare,PagoSemanal,AbonadoSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,
 case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.Estado = 'R' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Promotor,Estado,Pagos_atrasados,IdSolicitud,FechaDeAtraso from
(select Cartera.nombre,Cartera.id,
case when Cartera.Estado = 'C' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where Abonado <> 0 and Abonado >= interes and conveniossac.idcredito = Cartera.id group by idcredito),0)
when Cartera.Estado = 'R' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where Abonado <> 0 and Abonado >= interes and ReestructurasSac.idcredito = Cartera.id group by idcredito),0)
else
isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id group by id_credito),0) end as AbonadoSinMultas,
case when Cartera.Estado = 'C' then
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idconvenio = ConveniosSac.id where CalendarioConveniosSac.estado = 'V' and Abonado <= CalendarioConveniosSac.Interes and ConveniosSac.idCredito =cartera.id group by CalendarioConveniosSac.idConvenio),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioConveniosSac.Interes) ))) )) as AbonadoInteres from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where CalendarioConveniosSac.estado = 'V' and Abonado >=CalendarioConveniosSac.Interes and ConveniosSac.idCredito =cartera.id group by CalendarioConveniosSac.idConvenio),0)),0)
--isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioConveniossac.estado = 'V' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0) 
when Cartera.Estado = 'R' then
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idconvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado <= CalendarioReestructurasSac.Interes and ReestructurasSac.idCredito =cartera.id group by CalendarioReestructurasSac.idConvenio),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioReestructurasSac.Interes) ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado >=CalendarioReestructurasSac.Interes and ReestructurasSac.idCredito =cartera.id group by CalendarioReestructurasSac.idConvenio),0)),0)
else
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)),0)end as AbonadoMultasV,
case when Cartera.Estado = 'C' then
isnull((select SUM(Abonado - CalendarioConveniossac.monto) as AbonadoMultas from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where  CalendarioConveniossac.estado = 'L' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(Abonado - CalendarioReestructurasSac.monto) as AbonadoMultas from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where  CalendarioReestructurasSac.estado = 'L' and ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L' and CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as AbonadoMultasL,
case when Cartera.Estado = 'C' THEN 
isnull((select SUM(CalendarioConveniossac.interes) as Multas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where  Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.interes) as Multas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where  ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(CalendarioNormal.interes) as Multas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as Multas,
case when cartera.Estado = 'C' THEN 
(select SUM(calendarioconveniossac.monto) from CalendarioConveniossac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(CalendarioReestructurasSac.monto) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where ReestructurasSac.idcredito = Cartera.id)
else
(select Pagare from credito where id = Cartera.id) end as pagare,
case when Cartera.Estado = 'C' then
(select COUNT(pendiente) AS Pagos_atrasados from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado = 'V' and Conveniossac.idcredito = cartera.id)
when Cartera.Estado = 'R' then
(select COUNT(pendiente) AS Pagos_atrasados from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = cartera.id)
 else
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
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.pendiente) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
isnull(convert(varchar,(select top 1 CalendarioConveniosSac.Fecha from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniosSac.Fecha>'1900-01-01' and ConveniosSac.idCredito = Cartera.id order by CalendarioConveniosSac.Fecha desc),23),'Nunca')
when Cartera.Estado = 'R' then
isnull(convert(varchar,(select top 1 CalendarioReestructurasSac.Fecha from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Fecha>'1900-01-01' and ReestructurasSac.idCredito = Cartera.id order by CalendarioReestructurasSac.Fecha desc),23),'Nunca')
else
isnull(convert(varchar,(select top 1 FechaUltimoPago from CalendarioNormal where FechaUltimoPago>'1900-01-01' and CalendarioNormal.id_credito = Cartera.id order by FechaUltimoPago desc),23),'Nunca')
end as FechaDeAtraso,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado ='V' and Conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(interes) as MultasVencidas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado ='V' and ReestructurasSac.idcredito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado,Cartera.IdSolicitud,isnull((select id from promesadepago where idcredito = Cartera.id and estado = 'A' and tipocredito = cartera.estado),0) as prompago from
(select Credito.nombre,Credito.id,Credito.IdGestor,Credito.IdPromotor,Credito.Estado,Credito.IdSolicitud from CREDITO inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito  where CalendarioNormal.Estado = 'V'  and Credito.Estado <> 'L' and Credito.Estado <> 'T' and idpromotor = '" & idEmpleado & "' and Credito.Nombre like '%" & txtnombre.Text & "%' group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado,Credito.monto,Credito.Interes,Credito.IdSolicitud) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal where prompago = 0) carteraVencida inner join Solicitud on carteraVencida.IdSolicitud = Solicitud.id inner join DatosSolicitud on solicitud.id = DatosSolicitud.IdSolicitud where VencidoNormal <> 0)creditos_en_mora order by creditos_en_mora.nombre asc"
                End If
            Case "Todos"
                consulta = "select creditos_en_mora.* from
(select carteraVencida.id, carteravencida.nombre as Nombre,format(pagare,'C','es-mx') as Pagaré,format(PagoSemanal,'C','es-mx') as 'Pago Semanal',format(AbonadoSinMultas,'C','es-mx') as 'Abonado sin multas',format(Multas,'C','es-mx') as Multas,format(AbonadoMultas,'C','es-mx') as 'Multas abonadas',format(multasPendientes,'C','es-mx') as 'Multas pendientes',format(VencidoNormal,'C','es-mx') as 'Vencido normal',format(TotalPendiente,'C','es-mx') as 'Total Pendiente',Pagos_atrasados as 'Pagos atrasados',FechaDeAtraso as 'Fecha del último abono',
case when FechaDeAtraso = 'Nunca' then
	(case when carteraVencida.Estado = 'C' then
	datediff(day,(select top 1 fechapago from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where Abonado < (monto+interes) and ConveniosSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	when carteraVencida.Estado = 'R' then
	datediff(day,(select top 1 fechapago from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where Abonado < (monto+interes) and ReestructurasSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	else 
	datediff(day,(select top 1 fechapago from CalendarioNormal where Abonado < (monto+interes) and id_credito = carteraVencida.id order by FechaPago asc),GETDATE())
	end)
else (case when carteraVencida.Estado = 'C' then
	datediff(day,(select top 1 fechapago from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where Abonado < (monto+interes) and ConveniosSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	when carteraVencida.Estado = 'R' then
	datediff(day,(select top 1 fechapago from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where Abonado < (monto+interes) and ReestructurasSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	else 
	datediff(day,(select top 1 fechapago from CalendarioNormal where Abonado < (monto+interes) and id_credito = carteraVencida.id order by FechaPago asc),GETDATE())
	end)
end as Diasdeatraso,
format(((pagare - AbonadoSinMultas) + multasPendientes),'C','es-mx') as 'Liquida con',DatosSolicitud.Telefono,DatosSolicitud.Celular,(DatosSolicitud.Calle + ', ' + DatosSolicitud.Noext + ', ' + DatosSolicitud.Colonia ) as Domicilio,Promotor,Gestor,carteravencida.Estado from 
(select nombre,id,pagare,PagoSemanal,AbonadoSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,
 case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.Estado = 'R' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Promotor,Estado,Pagos_atrasados,IdSolicitud,FechaDeAtraso from
(select Cartera.nombre,Cartera.id,
case when Cartera.Estado = 'C' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where Abonado <> 0 and Abonado >= interes and conveniossac.idcredito = Cartera.id group by idcredito),0)
when Cartera.Estado = 'R' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where Abonado <> 0 and Abonado >= interes and ReestructurasSac.idcredito = Cartera.id group by idcredito),0)
else
isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id group by id_credito),0) end as AbonadoSinMultas,
case when Cartera.Estado = 'C' then
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idconvenio = ConveniosSac.id where CalendarioConveniosSac.estado = 'V' and Abonado <= CalendarioConveniosSac.Interes and ConveniosSac.idCredito =cartera.id group by CalendarioConveniosSac.idConvenio),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioConveniosSac.Interes) ))) )) as AbonadoInteres from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where CalendarioConveniosSac.estado = 'V' and Abonado >=CalendarioConveniosSac.Interes and ConveniosSac.idCredito =cartera.id group by CalendarioConveniosSac.idConvenio),0)),0)
--isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioConveniossac.estado = 'V' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0) 
when Cartera.Estado = 'R' then
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idconvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado <= CalendarioReestructurasSac.Interes and ReestructurasSac.idCredito =cartera.id group by CalendarioReestructurasSac.idConvenio),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioReestructurasSac.Interes) ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado >=CalendarioReestructurasSac.Interes and ReestructurasSac.idCredito =cartera.id group by CalendarioReestructurasSac.idConvenio),0)),0)
else
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)),0)end as AbonadoMultasV,
case when Cartera.Estado = 'C' then
isnull((select SUM(Abonado - CalendarioConveniossac.monto) as AbonadoMultas from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where  CalendarioConveniossac.estado = 'L' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(Abonado - CalendarioReestructurasSac.monto) as AbonadoMultas from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where  CalendarioReestructurasSac.estado = 'L' and ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L' and CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as AbonadoMultasL,
case when Cartera.Estado = 'C' THEN 
isnull((select SUM(CalendarioConveniossac.interes) as Multas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where  Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.interes) as Multas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where  ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(CalendarioNormal.interes) as Multas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as Multas,
case when cartera.Estado = 'C' THEN 
(select SUM(calendarioconveniossac.monto) from CalendarioConveniossac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(CalendarioReestructurasSac.monto) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where ReestructurasSac.idcredito = Cartera.id)
else
(select Pagare from credito where id = Cartera.id) end as pagare,
case when Cartera.Estado = 'C' then
(select COUNT(pendiente) AS Pagos_atrasados from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado = 'V' and Conveniossac.idcredito = cartera.id)
when Cartera.Estado = 'R' then
(select COUNT(pendiente) AS Pagos_atrasados from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = cartera.id)
 else
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
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.pendiente) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
isnull(convert(varchar,(select top 1 CalendarioConveniosSac.Fecha from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniosSac.Fecha>'1900-01-01' and ConveniosSac.idCredito = Cartera.id order by CalendarioConveniosSac.Fecha desc),23),'Nunca')
when Cartera.Estado = 'R' then
isnull(convert(varchar,(select top 1 CalendarioReestructurasSac.Fecha from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Fecha>'1900-01-01' and ReestructurasSac.idCredito = Cartera.id order by CalendarioReestructurasSac.Fecha desc),23),'Nunca')
else
isnull(convert(varchar,(select top 1 FechaUltimoPago from CalendarioNormal where FechaUltimoPago>'1900-01-01' and CalendarioNormal.id_credito = Cartera.id order by FechaUltimoPago desc),23),'Nunca')
end as FechaDeAtraso,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado ='V' and Conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(interes) as MultasVencidas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado ='V' and ReestructurasSac.idcredito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado,Cartera.IdSolicitud,isnull((select id from promesadepago where idcredito = Cartera.id and estado = 'A' and tipocredito = cartera.estado),0) as prompago from
(select Credito.nombre,Credito.id,Credito.IdGestor,Credito.IdPromotor,Credito.Estado,Credito.IdSolicitud from CREDITO inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito  where CalendarioNormal.Estado = 'V'  and Credito.Estado <> 'L' and Credito.Estado <> 'T' and Credito.Nombre like '%" & txtnombre.Text & "%' group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado,Credito.monto,Credito.Interes,Credito.IdSolicitud) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal where prompago =0) carteraVencida inner join Solicitud on carteraVencida.IdSolicitud = Solicitud.id inner join DatosSolicitud on solicitud.id = DatosSolicitud.IdSolicitud where VencidoNormal <> 0)creditos_en_mora order by creditos_en_mora.nombre asc"
        End Select


        adapterConsulta = New SqlDataAdapter(consulta, conexionempresa)
        dataConsulta = New DataTable
        adapterConsulta.Fill(dataConsulta)
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        'BunifuThinButton22.Enabled = False
        'Cargando.Show()
        'Cargando.MonoFlat_Label1.Text = "Consultando"
        'Cargando.TopMost = True
        Panel2.Visible = True
        Panel2.BringToFront()
        ' TransparentPanel1.Location = dtimpuestos.Location
        TabControl1.Visible = False

        '  TransparentPanel1.Size = dtimpuestos.Size

        Panel2.Location = New Point((Me.Size.Width / 2) + (Panel2.Width / 2) - 200, (Me.Height / 2) + (Panel2.Height / 2) - 200)
        BackgroundConectarEmpresas.RunWorkerAsync()
    End Sub

    Private Sub BackgroundConsulta_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundConsulta.RunWorkerCompleted
        'dtimpuestos.DataSource = dataConsulta
        Cargando.Close()
        BunifuThinButton22.Enabled = True
        'txtnombre.Enabled = True
        'txtnombre.Select()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Exportando a Excel"
        Cargando.TopMost = True
        BackgroundExcel.RunWorkerAsync()
    End Sub

    Private Sub BackgroundExcel_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundExcel.DoWork
        nuevolibroMora()
        '   For Each tabP As TabPage In TabControl1.TabPages
        For Each ctrl As Control In TabControl1.Controls
            Dim ctrldentro As Control = ctrl
            For Each ctrldt As Control In ctrldentro.Controls
                If (TypeOf ctrldt Is Bunifu.Framework.UI.BunifuCustomDataGrid) Then

                    Dim dt As Bunifu.Framework.UI.BunifuCustomDataGrid = ctrldt
                    '   MessageBox.Show(dt.Name)
                    ' MessageBox.Show(dt.Rows.Count & " Filas antes")
                    GridAExcelMora(dt)


                End If
            Next

        Next
        'Next

    End Sub

    Private Sub BackgroundExcel_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundExcel.RunWorkerCompleted
        Cargando.Close()
        cerrarlibroMora()

    End Sub

    Private Sub CreditosEnMora_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        BunifuThinButton22.Location = New Point(ComboElección.Location.X + ComboElección.Width + 20, ComboElección.Location.Y)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Reportes.Panel1.Visible = False
        Reportes.RadPanorama1.Visible = True
    End Sub

    Private Sub txtnombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            'txtnombre.Enabled = False
            Cargando.Show()
            Cargando.MonoFlat_Label1.Text = "Consultando"
            Cargando.TopMost = True
            BackgroundConsulta.RunWorkerAsync()
        End If
    End Sub

    Private Sub dtimpuestos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        '  InformacionSolicitud.idCredito = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        'InformacionSolicitud.Show()
    End Sub

    Private Sub BackgroundEmpresas_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundEmpresas.DoWork
        iniciarconexion()

        Dim comandoEmpresasPermitidas As OleDbCommand

        Dim consultaEmpresasPermitidas As String
        Dim readerEmpresasPermitidas As OleDbDataReader
        consultaEmpresasPermitidas = "select id,nombre from empresas where id in (select idempresa from empresaspermitidas where idusuario = '" & idusr & "')"
        comandoEmpresasPermitidas = New OleDbCommand
        comandoEmpresasPermitidas.Connection = conexion
        comandoEmpresasPermitidas.CommandText = consultaEmpresasPermitidas
        readerEmpresasPermitidas = comandoEmpresasPermitidas.ExecuteReader
        If readerEmpresasPermitidas.HasRows Then

            While readerEmpresasPermitidas.Read
                Dim botonempresa As New Bunifu.Framework.UI.BunifuFlatButton

                botonempresa.Normalcolor = Color.FromArgb(48, 55, 76)
                botonempresa.Iconimage = Nothing

                botonempresa.Size = New Size(178, 48)
                botonempresa.Name = readerEmpresasPermitidas("id").ToString
                If readerEmpresasPermitidas("nombre") = nombreAmostrar Then
                    botonempresa.Text = readerEmpresasPermitidas("nombre").ToString & " (Activa)"
                    botonempresa.Normalcolor = Color.FromArgb(46, 139, 87)
                Else
                    botonempresa.Text = readerEmpresasPermitidas("nombre").ToString
                End If

                '  botonempresa.Tag = milector("ip")
                AddHandler botonempresa.Click, AddressOf clickevenntAsync
                'AddHandler botonempresa.MouseDown, AddressOf OnButtonMouseDown
                Me.Invoke(Sub()
                              FlowEmpresas.Controls.Add(botonempresa)
                          End Sub)

            End While

        End If
    End Sub

    Private Sub BackgroundEmpresas_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundEmpresas.RunWorkerCompleted
        Cargando.Close()

    End Sub
    Private Async Sub clickevenntAsync(ByVal sender As Object, ByVal e As System.EventArgs)

        If sender.NormalColor = Color.FromArgb(48, 55, 76) Then
            sender.NormalColor = Color.FromArgb(46, 139, 87)

        ElseIf sender.NormalColor = Color.FromArgb(46, 139, 87) Then
            sender.NormalColor = Color.FromArgb(48, 55, 76)
        ElseIf sender.NormalColor = Color.FromArgb(189, 2, 2) Then
            sender.NormalColor = Color.FromArgb(48, 55, 76)

        End If



    End Sub

    Private Sub BackgroundConectarEmpresas_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundConectarEmpresas.DoWork
        For i As Integer = 0 To TabControl1.TabCount - 1
            TabControl1.TabPages.RemoveAt(0)


        Next

        'For Each tabctrl As TabPage In TabControl1.TabPages
        '    Dim indexOfTab As Integer = TabControl1.TabPages.IndexOfKey(tabctrl.Name)
        '    MessageBox.Show(indexOfTab)
        'Next

        For Each ctrl As Control In FlowEmpresas.Controls
            If TypeOf (ctrl) Is Bunifu.Framework.UI.BunifuFlatButton Then
                Dim ctrlE As Bunifu.Framework.UI.BunifuFlatButton = ctrl
                Dim EmpresaActiva As Boolean
                If ctrlE.Text.Contains("Activa") Then
                    EmpresaActiva = True
                Else
                    EmpresaActiva = False
                End If

                If ctrlE.Normalcolor = Color.FromArgb(46, 139, 87) Then
                        For Each row As DataRow In dataEmpresas.Rows
                            If row("id").ToString = ctrlE.Name Then
                                '  MessageBox.Show(ctrlE.Name)

                                If ProbarConexionEmpresa(row("ip").ToString, row("bd").ToString) Then

                                    Dim empresaConect As New EmpresaConectada
                                    empresaConect.Conectada = True
                                    empresaConect.ConexionEmpresaConectada = CrearConexionEmpresa(row("ip").ToString, row("bd").ToString)
                                    arrayEmpresas.Add(empresaConect)
                                    Me.Invoke(Sub()
                                                  Dim tabPg As New TabPage
                                                  tabPg.Name = ctrlE.Text
                                                  tabPg.Text = ctrlE.Text
                                                  Dim dtConsultas As New Bunifu.Framework.UI.BunifuCustomDataGrid
                                                  dtConsultas.BackgroundColor = Color.Gainsboro
                                                  dtConsultas.Anchor = AnchorStyles.Bottom And AnchorStyles.Left And AnchorStyles.Right And AnchorStyles.Top
                                                  dtConsultas.Size = New Size(TabControl1.Width - 10, TabControl1.Height - 30)
                                                  dtConsultas.DataSource = CredMora(CrearConexionEmpresa(row("ip").ToString, row("bd").ToString), EmpresaActiva)
                                                  dtConsultas.AllowUserToAddRows = False
                                                  dtConsultas.AllowUserToDeleteRows = False
                                                  dtConsultas.HeaderBgColor = Color.DarkSlateGray
                                                  dtConsultas.ScrollBars = ScrollBars.Both
                                                  dtConsultas.HeaderForeColor = Color.FromArgb(223, 223, 223)
                                                  dtConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                                                  dtConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                                                  dtConsultas.Name = ctrlE.Text
                                                  tabPg.Controls.Add(dtConsultas)
                                                  dtConsultas.Location = New Point(0, 0)
                                                  Me.Invoke(Sub()
                                                                TabControl1.TabPages.Insert(TabControl1.TabPages.Count, tabPg)
                                                            End Sub)



                                              End Sub)


                                Else
                                    ctrlE.Normalcolor = Color.FromArgb(189, 2, 2)
                                End If
                                Exit For
                            End If
                        Next
                    End If
                End If

        Next

        For Each ctrl As TabPage In TabControl1.TabPages
            For Each ctrlDT As Control In ctrl.Controls
                If TypeOf (ctrlDT) Is Bunifu.Framework.UI.BunifuCustomDataGrid Then
                    Dim dt As Bunifu.Framework.UI.BunifuCustomDataGrid = ctrlDT
                    Me.Invoke(Sub()
                                  dt.Location = New Point(0, 0)

                              End Sub)

                End If
            Next
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Panel2.Visible = True
        'Panel2.BringToFront()
        ' TransparentPanel1.Location = dtimpuestos.Location
        'TabControl1.Visible = False

        '  TransparentPanel1.Size = dtimpuestos.Size

        'Panel2.Location = New Point((Me.Size.Width / 2) + (Panel2.Width / 2) - 200, (Me.Height / 2) + (Panel2.Height / 2) - 200)
        'BackgroundConectarEmpresas.RunWorkerAsync()

        If chicoGrande = False Then
            TimerGrande.Enabled = True
            TimerGrande.Interval = 1
            TimerGrande.Start()
        End If

        If chicoGrande Then
            TimerChico.Enabled = True
            TimerChico.Interval = 1
            TimerChico.Start()

        End If



    End Sub
    Private Function CredMora(conexiondt As OleDbConnection, EmpresaActiva As Boolean) As DataTable
        Dim adapterDT As OleDbDataAdapter
        Dim consulta As String
        Dim dataDT As DataTable
        Dim idEmpleado As Integer
        idEmpleado = ConsultarId(ComboElección.Text)
        If EmpresaActiva Then
            Select Case ComboFiltro.Text
                Case "Gestor"

                    If ComboElección.Text = "Todos" Then
                        consulta = "select creditos_en_mora.* from
(select carteraVencida.id,case when TiposDeCredito.Tipo = 'G' then concat(carteravencida.nombre,' (',Clientes.Nombre,' ' ,Clientes.ApellidoPaterno,' ',Clientes.ApellidoMaterno,')') else carteravencida.nombre end  as Nombre,format(pagare,'C','es-mx') as Pagaré,format(PagoSemanal,'C','es-mx') as 'Pago Semanal',format(AbonadoSinMultas,'C','es-mx') as 'Abonado sin multas',format(Multas,'C','es-mx') as Multas,format(AbonadoMultas,'C','es-mx') as 'Multas abonadas',format(multasPendientes,'C','es-mx') as 'Multas pendientes',format(VencidoNormal,'C','es-mx') as 'Vencido normal',format(TotalPendiente,'C','es-mx') as 'Total Pendiente',Pagos_atrasados as 'Pagos atrasados',FechaDeAtraso as 'Fecha del último abono',
case when FechaDeAtraso = 'Nunca' then
	(case when carteraVencida.Estado = 'C' then
	datediff(day,(select top 1 fechapago from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where Abonado < (monto+interes) and ConveniosSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	when carteraVencida.Estado = 'R' then
	datediff(day,(select top 1 fechapago from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where Abonado < (monto+interes) and ReestructurasSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	else 
	datediff(day,(select top 1 fechapago from CalendarioNormal where Abonado < (monto+interes) and id_credito = carteraVencida.id order by FechaPago asc),GETDATE())
	end)
else (case when carteraVencida.Estado = 'C' then
	datediff(day,(select top 1 fechapago from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where Abonado < (monto+interes) and ConveniosSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	when carteraVencida.Estado = 'R' then
	datediff(day,(select top 1 fechapago from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where Abonado < (monto+interes) and ReestructurasSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	else 
	datediff(day,(select top 1 fechapago from CalendarioNormal where Abonado < (monto+interes) and id_credito = carteraVencida.id order by FechaPago asc),GETDATE())
	end)
end as Diasdeatraso,
format(((pagare - AbonadoSinMultas) + multasPendientes),'C','es-mx') as 'Liquida con',DatosSolicitud.Telefono,DatosSolicitud.Celular,(DatosSolicitud.Calle + ', ' + DatosSolicitud.Noext + ', ' + DatosSolicitud.Colonia ) as Domicilio,Promotor,Gestor,DatosSolicitud.NombreR1 As 'Referencia 1',DatosSolicitud.TelefonoR1,DatosSolicitud.NombreR2 as 'Referencia 2',DatosSolicitud.TelefonoR2,carteravencida.Estado from 
(select nombre,id,pagare,PagoSemanal,AbonadoSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,
 case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.Estado = 'R' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Promotor,Estado,Pagos_atrasados,IdSolicitud,FechaDeAtraso from
(select Cartera.nombre,Cartera.id,
case when Cartera.Estado = 'C' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where Abonado <> 0 and Abonado >= interes and conveniossac.idcredito = Cartera.id group by idcredito),0)
when Cartera.Estado = 'R' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where Abonado <> 0 and Abonado >= interes and ReestructurasSac.idcredito = Cartera.id group by idcredito),0)
else
isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id group by id_credito),0) end as AbonadoSinMultas,
case when Cartera.Estado = 'C' then
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idconvenio = ConveniosSac.id where CalendarioConveniosSac.estado = 'V' and Abonado <= CalendarioConveniosSac.Interes and ConveniosSac.idCredito =cartera.id group by CalendarioConveniosSac.idConvenio),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioConveniosSac.Interes) ))) )) as AbonadoInteres from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where CalendarioConveniosSac.estado = 'V' and Abonado >=CalendarioConveniosSac.Interes and ConveniosSac.idCredito =cartera.id group by CalendarioConveniosSac.idConvenio),0)),0)
--isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioConveniossac.estado = 'V' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0) 
when Cartera.Estado = 'R' then
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idconvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado <= CalendarioReestructurasSac.Interes and ReestructurasSac.idCredito =cartera.id group by CalendarioReestructurasSac.idConvenio),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioReestructurasSac.Interes) ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado >=CalendarioReestructurasSac.Interes and ReestructurasSac.idCredito =cartera.id group by CalendarioReestructurasSac.idConvenio),0)),0)
else
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)),0)end as AbonadoMultasV,
case when Cartera.Estado = 'C' then
isnull((select SUM(Abonado - CalendarioConveniossac.monto) as AbonadoMultas from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where  CalendarioConveniossac.estado = 'L' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(Abonado - CalendarioReestructurasSac.monto) as AbonadoMultas from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where  CalendarioReestructurasSac.estado = 'L' and ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L' and CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as AbonadoMultasL,
case when Cartera.Estado = 'C' THEN 
isnull((select SUM(CalendarioConveniossac.interes) as Multas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where  Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.interes) as Multas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where  ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(CalendarioNormal.interes) as Multas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as Multas,
case when cartera.Estado = 'C' THEN 
(select SUM(calendarioconveniossac.monto) from CalendarioConveniossac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(CalendarioReestructurasSac.monto) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where ReestructurasSac.idcredito = Cartera.id)
else
(select Pagare from credito where id = Cartera.id) end as pagare,
case when Cartera.Estado = 'C' then
(select COUNT(pendiente) AS Pagos_atrasados from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado = 'V' and Conveniossac.idcredito = cartera.id)
when Cartera.Estado = 'R' then
(select COUNT(pendiente) AS Pagos_atrasados from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = cartera.id)
 else
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
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.pendiente) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
isnull(convert(varchar,(select top 1 CalendarioConveniosSac.Fecha from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniosSac.Fecha>'1900-01-01' and ConveniosSac.idCredito = Cartera.id order by CalendarioConveniosSac.Fecha desc),23),'Nunca')
when Cartera.Estado = 'R' then
isnull(convert(varchar,(select top 1 CalendarioReestructurasSac.Fecha from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Fecha>'1900-01-01' and ReestructurasSac.idCredito = Cartera.id order by CalendarioReestructurasSac.Fecha desc),23),'Nunca')
else
isnull(convert(varchar,(select top 1 FechaUltimoPago from CalendarioNormal where FechaUltimoPago>'1900-01-01' and CalendarioNormal.id_credito = Cartera.id order by FechaUltimoPago desc),23),'Nunca')
end as FechaDeAtraso,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado ='V' and Conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(interes) as MultasVencidas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado ='V' and ReestructurasSac.idcredito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado,Cartera.IdSolicitud,isnull((select id from promesadepago where idcredito = Cartera.id and estado = 'A' and tipocredito = cartera.estado),0) as prompago from
(select Credito.nombre,Credito.id,Credito.IdGestor,Credito.IdPromotor,Credito.Estado,Credito.IdSolicitud from CREDITO inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito  where CalendarioNormal.Estado = 'V'  and Credito.Estado <> 'L' and Credito.Estado <> 'T' and Credito.Nombre like '%" & txtnombre.Text & "%' group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado,Credito.monto,Credito.Interes,Credito.IdSolicitud) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal where prompago =0) carteraVencida inner join Solicitud on carteraVencida.IdSolicitud = Solicitud.id inner join DatosSolicitud on solicitud.id = DatosSolicitud.IdSolicitud inner join Clientes on DatosSolicitud.IdCliente = Clientes.id inner join TiposDeCredito on Solicitud.tipo = TiposDeCredito.id where VencidoNormal <> 0 and DatosSolicitud.Estado <> 'R')creditos_en_mora order by creditos_en_mora.nombre asc"

                    Else

                        consulta = "select creditos_en_mora.* from
(select carteraVencida.id,case when TiposDeCredito.Tipo = 'G' then concat(carteravencida.nombre,' (',Clientes.Nombre,' ' ,Clientes.ApellidoPaterno,' ',Clientes.ApellidoMaterno,')') else carteravencida.nombre end  as Nombre,format(pagare,'C','es-mx') as Pagaré,format(PagoSemanal,'C','es-mx') as 'Pago Semanal',format(AbonadoSinMultas,'C','es-mx') as 'Abonado sin multas',format(Multas,'C','es-mx') as Multas,format(AbonadoMultas,'C','es-mx') as 'Multas abonadas',format(multasPendientes,'C','es-mx') as 'Multas pendientes',format(VencidoNormal,'C','es-mx') as 'Vencido normal',format(TotalPendiente,'C','es-mx') as 'Total Pendiente',Pagos_atrasados as 'Pagos atrasados',FechaDeAtraso as 'Fecha del último abono',
case when FechaDeAtraso = 'Nunca' then
	(case when carteraVencida.Estado = 'C' then
	datediff(day,(select top 1 fechapago from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where Abonado < (monto+interes) and ConveniosSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	when carteraVencida.Estado = 'R' then
	datediff(day,(select top 1 fechapago from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where Abonado < (monto+interes) and ReestructurasSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	else 
	datediff(day,(select top 1 fechapago from CalendarioNormal where Abonado < (monto+interes) and id_credito = carteraVencida.id order by FechaPago asc),GETDATE())
	end)
else (case when carteraVencida.Estado = 'C' then
	datediff(day,(select top 1 fechapago from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where Abonado < (monto+interes) and ConveniosSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	when carteraVencida.Estado = 'R' then
	datediff(day,(select top 1 fechapago from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where Abonado < (monto+interes) and ReestructurasSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	else 
	datediff(day,(select top 1 fechapago from CalendarioNormal where Abonado < (monto+interes) and id_credito = carteraVencida.id order by FechaPago asc),GETDATE())
	end)
end as Diasdeatraso,
format(((pagare - AbonadoSinMultas) + multasPendientes),'C','es-mx') as 'Liquida con',DatosSolicitud.Telefono,DatosSolicitud.Celular,(DatosSolicitud.Calle + ', ' + DatosSolicitud.Noext + ', ' + DatosSolicitud.Colonia ) as Domicilio,Promotor,Gestor,DatosSolicitud.NombreR1 As 'Referencia 1',DatosSolicitud.TelefonoR1,DatosSolicitud.NombreR2 as 'Referencia 2',DatosSolicitud.TelefonoR2,carteravencida.Estado from 
(select nombre,id,pagare,PagoSemanal,AbonadoSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,
 case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.Estado = 'R' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Promotor,Estado,Pagos_atrasados,IdSolicitud,FechaDeAtraso from
(select Cartera.nombre,Cartera.id,
case when Cartera.Estado = 'C' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where Abonado <> 0 and Abonado >= interes and conveniossac.idcredito = Cartera.id group by idcredito),0)
when Cartera.Estado = 'R' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where Abonado <> 0 and Abonado >= interes and ReestructurasSac.idcredito = Cartera.id group by idcredito),0)
else
isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id group by id_credito),0) end as AbonadoSinMultas,
case when Cartera.Estado = 'C' then
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idconvenio = ConveniosSac.id where CalendarioConveniosSac.estado = 'V' and Abonado <= CalendarioConveniosSac.Interes and ConveniosSac.idCredito =cartera.id group by CalendarioConveniosSac.idConvenio),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioConveniosSac.Interes) ))) )) as AbonadoInteres from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where CalendarioConveniosSac.estado = 'V' and Abonado >=CalendarioConveniosSac.Interes and ConveniosSac.idCredito =cartera.id group by CalendarioConveniosSac.idConvenio),0)),0)
--isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioConveniossac.estado = 'V' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0) 
when Cartera.Estado = 'R' then
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idconvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado <= CalendarioReestructurasSac.Interes and ReestructurasSac.idCredito =cartera.id group by CalendarioReestructurasSac.idConvenio),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioReestructurasSac.Interes) ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado >=CalendarioReestructurasSac.Interes and ReestructurasSac.idCredito =cartera.id group by CalendarioReestructurasSac.idConvenio),0)),0)
else
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)),0)end as AbonadoMultasV,
case when Cartera.Estado = 'C' then
isnull((select SUM(Abonado - CalendarioConveniossac.monto) as AbonadoMultas from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where  CalendarioConveniossac.estado = 'L' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(Abonado - CalendarioReestructurasSac.monto) as AbonadoMultas from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where  CalendarioReestructurasSac.estado = 'L' and ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L' and CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as AbonadoMultasL,
case when Cartera.Estado = 'C' THEN 
isnull((select SUM(CalendarioConveniossac.interes) as Multas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where  Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.interes) as Multas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where  ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(CalendarioNormal.interes) as Multas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as Multas,
case when cartera.Estado = 'C' THEN 
(select SUM(calendarioconveniossac.monto) from CalendarioConveniossac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(CalendarioReestructurasSac.monto) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where ReestructurasSac.idcredito = Cartera.id)
else
(select Pagare from credito where id = Cartera.id) end as pagare,
case when Cartera.Estado = 'C' then
(select COUNT(pendiente) AS Pagos_atrasados from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado = 'V' and Conveniossac.idcredito = cartera.id)
when Cartera.Estado = 'R' then
(select COUNT(pendiente) AS Pagos_atrasados from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = cartera.id)
 else
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
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.pendiente) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
isnull(convert(varchar,(select top 1 CalendarioConveniosSac.Fecha from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniosSac.Fecha>'1900-01-01' and ConveniosSac.idCredito = Cartera.id order by CalendarioConveniosSac.Fecha desc),23),'Nunca')
when Cartera.Estado = 'R' then
isnull(convert(varchar,(select top 1 CalendarioReestructurasSac.Fecha from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Fecha>'1900-01-01' and ReestructurasSac.idCredito = Cartera.id order by CalendarioReestructurasSac.Fecha desc),23),'Nunca')
else
isnull(convert(varchar,(select top 1 FechaUltimoPago from CalendarioNormal where FechaUltimoPago>'1900-01-01' and CalendarioNormal.id_credito = Cartera.id order by FechaUltimoPago desc),23),'Nunca')
end as FechaDeAtraso,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado ='V' and Conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(interes) as MultasVencidas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado ='V' and ReestructurasSac.idcredito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado,Cartera.IdSolicitud,isnull((select id from promesadepago where idcredito = Cartera.id and estado = 'A' and tipocredito = cartera.estado),0) as prompago from
(select Credito.nombre,Credito.id,Credito.IdGestor,Credito.IdPromotor,Credito.Estado,Credito.IdSolicitud from CREDITO inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito  where CalendarioNormal.Estado = 'V'  and Credito.Estado <> 'L' and Credito.Estado <> 'T' and idgestor = '" & idEmpleado & "' and Credito.Nombre like '%" & txtnombre.Text & "%' group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado,Credito.monto,Credito.Interes,Credito.IdSolicitud) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal where prompago =0) carteraVencida inner join Solicitud on carteraVencida.IdSolicitud = Solicitud.id inner join DatosSolicitud on solicitud.id = DatosSolicitud.IdSolicitud inner join Clientes on DatosSolicitud.IdCliente = Clientes.id inner join TiposDeCredito on Solicitud.tipo = TiposDeCredito.id where VencidoNormal <> 0 and DatosSolicitud.Estado <> 'R')creditos_en_mora order by creditos_en_mora.nombre asc"
                    End If
                Case "Promotor"

                    If ComboElección.Text = "Todos" Then
                        consulta = "select creditos_en_mora.* from
(select carteraVencida.id,case when TiposDeCredito.Tipo = 'G' then concat(carteravencida.nombre,' (',Clientes.Nombre,' ' ,Clientes.ApellidoPaterno,' ',Clientes.ApellidoMaterno,')') else carteravencida.nombre end  as Nombre,format(pagare,'C','es-mx') as Pagaré,format(PagoSemanal,'C','es-mx') as 'Pago Semanal',format(AbonadoSinMultas,'C','es-mx') as 'Abonado sin multas',format(Multas,'C','es-mx') as Multas,format(AbonadoMultas,'C','es-mx') as 'Multas abonadas',format(multasPendientes,'C','es-mx') as 'Multas pendientes',format(VencidoNormal,'C','es-mx') as 'Vencido normal',format(TotalPendiente,'C','es-mx') as 'Total Pendiente',Pagos_atrasados as 'Pagos atrasados',FechaDeAtraso as 'Fecha del último abono',
case when FechaDeAtraso = 'Nunca' then
	(case when carteraVencida.Estado = 'C' then
	datediff(day,(select top 1 fechapago from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where Abonado < (monto+interes) and ConveniosSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	when carteraVencida.Estado = 'R' then
	datediff(day,(select top 1 fechapago from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where Abonado < (monto+interes) and ReestructurasSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	else 
	datediff(day,(select top 1 fechapago from CalendarioNormal where Abonado < (monto+interes) and id_credito = carteraVencida.id order by FechaPago asc),GETDATE())
	end)
else (case when carteraVencida.Estado = 'C' then
	datediff(day,(select top 1 fechapago from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where Abonado < (monto+interes) and ConveniosSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	when carteraVencida.Estado = 'R' then
	datediff(day,(select top 1 fechapago from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where Abonado < (monto+interes) and ReestructurasSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	else 
	datediff(day,(select top 1 fechapago from CalendarioNormal where Abonado < (monto+interes) and id_credito = carteraVencida.id order by FechaPago asc),GETDATE())
	end)
end as Diasdeatraso,
format(((pagare - AbonadoSinMultas) + multasPendientes),'C','es-mx') as 'Liquida con',DatosSolicitud.Telefono,DatosSolicitud.Celular,(DatosSolicitud.Calle + ', ' + DatosSolicitud.Noext + ', ' + DatosSolicitud.Colonia ) as Domicilio,Promotor,Gestor,DatosSolicitud.NombreR1 As 'Referencia 1',DatosSolicitud.TelefonoR1,DatosSolicitud.NombreR2 as 'Referencia 2',DatosSolicitud.TelefonoR2,carteravencida.Estado from 
(select nombre,id,pagare,PagoSemanal,AbonadoSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,
 case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.Estado = 'R' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Promotor,Estado,Pagos_atrasados,IdSolicitud,FechaDeAtraso from
(select Cartera.nombre,Cartera.id,
case when Cartera.Estado = 'C' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where Abonado <> 0 and Abonado >= interes and conveniossac.idcredito = Cartera.id group by idcredito),0)
when Cartera.Estado = 'R' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where Abonado <> 0 and Abonado >= interes and ReestructurasSac.idcredito = Cartera.id group by idcredito),0)
else
isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id group by id_credito),0) end as AbonadoSinMultas,
case when Cartera.Estado = 'C' then
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idconvenio = ConveniosSac.id where CalendarioConveniosSac.estado = 'V' and Abonado <= CalendarioConveniosSac.Interes and ConveniosSac.idCredito =cartera.id group by CalendarioConveniosSac.idConvenio),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioConveniosSac.Interes) ))) )) as AbonadoInteres from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where CalendarioConveniosSac.estado = 'V' and Abonado >=CalendarioConveniosSac.Interes and ConveniosSac.idCredito =cartera.id group by CalendarioConveniosSac.idConvenio),0)),0)
--isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioConveniossac.estado = 'V' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0) 
when Cartera.Estado = 'R' then
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idconvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado <= CalendarioReestructurasSac.Interes and ReestructurasSac.idCredito =cartera.id group by CalendarioReestructurasSac.idConvenio),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioReestructurasSac.Interes) ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado >=CalendarioReestructurasSac.Interes and ReestructurasSac.idCredito =cartera.id group by CalendarioReestructurasSac.idConvenio),0)),0)
else
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)),0)end as AbonadoMultasV,
case when Cartera.Estado = 'C' then
isnull((select SUM(Abonado - CalendarioConveniossac.monto) as AbonadoMultas from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where  CalendarioConveniossac.estado = 'L' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(Abonado - CalendarioReestructurasSac.monto) as AbonadoMultas from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where  CalendarioReestructurasSac.estado = 'L' and ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L' and CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as AbonadoMultasL,
case when Cartera.Estado = 'C' THEN 
isnull((select SUM(CalendarioConveniossac.interes) as Multas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where  Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.interes) as Multas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where  ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(CalendarioNormal.interes) as Multas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as Multas,
case when cartera.Estado = 'C' THEN 
(select SUM(calendarioconveniossac.monto) from CalendarioConveniossac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(CalendarioReestructurasSac.monto) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where ReestructurasSac.idcredito = Cartera.id)
else
(select Pagare from credito where id = Cartera.id) end as pagare,
case when Cartera.Estado = 'C' then
(select COUNT(pendiente) AS Pagos_atrasados from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado = 'V' and Conveniossac.idcredito = cartera.id)
when Cartera.Estado = 'R' then
(select COUNT(pendiente) AS Pagos_atrasados from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = cartera.id)
 else
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
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.pendiente) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
isnull(convert(varchar,(select top 1 CalendarioConveniosSac.Fecha from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniosSac.Fecha>'1900-01-01' and ConveniosSac.idCredito = Cartera.id order by CalendarioConveniosSac.Fecha desc),23),'Nunca')
when Cartera.Estado = 'R' then
isnull(convert(varchar,(select top 1 CalendarioReestructurasSac.Fecha from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Fecha>'1900-01-01' and ReestructurasSac.idCredito = Cartera.id order by CalendarioReestructurasSac.Fecha desc),23),'Nunca')
else
isnull(convert(varchar,(select top 1 FechaUltimoPago from CalendarioNormal where FechaUltimoPago>'1900-01-01' and CalendarioNormal.id_credito = Cartera.id order by FechaUltimoPago desc),23),'Nunca')
end as FechaDeAtraso,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado ='V' and Conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(interes) as MultasVencidas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado ='V' and ReestructurasSac.idcredito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado,Cartera.IdSolicitud,isnull((select id from promesadepago where idcredito = Cartera.id and estado = 'A' and tipocredito = cartera.estado),0) as prompago from
(select Credito.nombre,Credito.id,Credito.IdGestor,Credito.IdPromotor,Credito.Estado,Credito.IdSolicitud from CREDITO inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito  where CalendarioNormal.Estado = 'V'  and Credito.Estado <> 'L' and Credito.Estado <> 'T' and Credito.Nombre like '%" & txtnombre.Text & "%' group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado,Credito.monto,Credito.Interes,Credito.IdSolicitud) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal where prompago =0) carteraVencida inner join Solicitud on carteraVencida.IdSolicitud = Solicitud.id inner join DatosSolicitud on solicitud.id = DatosSolicitud.IdSolicitud inner join Clientes on DatosSolicitud.IdCliente = Clientes.id inner join TiposDeCredito on Solicitud.tipo = TiposDeCredito.id where VencidoNormal <> 0 and DatosSolicitud.Estado <> 'R')creditos_en_mora order by creditos_en_mora.nombre asc"
                    Else
                        consulta = "select creditos_en_mora.* from
(select carteraVencida.id,case when TiposDeCredito.Tipo = 'G' then concat(carteravencida.nombre,' (',Clientes.Nombre,' ' ,Clientes.ApellidoPaterno,' ',Clientes.ApellidoMaterno,')') else carteravencida.nombre end  as Nombre,format(pagare,'C','es-mx') as Pagaré,format(PagoSemanal,'C','es-mx') as 'Pago Semanal',format(AbonadoSinMultas,'C','es-mx') as 'Abonado sin multas',format(Multas,'C','es-mx') as Multas,format(AbonadoMultas,'C','es-mx') as 'Multas abonadas',format(multasPendientes,'C','es-mx') as 'Multas pendientes',format(VencidoNormal,'C','es-mx') as 'Vencido normal',format(TotalPendiente,'C','es-mx') as 'Total Pendiente',Pagos_atrasados as 'Pagos atrasados',FechaDeAtraso as 'Fecha del último abono',
case when FechaDeAtraso = 'Nunca' then
	(case when carteraVencida.Estado = 'C' then
	datediff(day,(select top 1 fechapago from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where Abonado < (monto+interes) and ConveniosSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	when carteraVencida.Estado = 'R' then
	datediff(day,(select top 1 fechapago from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where Abonado < (monto+interes) and ReestructurasSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	else 
	datediff(day,(select top 1 fechapago from CalendarioNormal where Abonado < (monto+interes) and id_credito = carteraVencida.id order by FechaPago asc),GETDATE())
	end)
else (case when carteraVencida.Estado = 'C' then
	datediff(day,(select top 1 fechapago from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where Abonado < (monto+interes) and ConveniosSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	when carteraVencida.Estado = 'R' then
	datediff(day,(select top 1 fechapago from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where Abonado < (monto+interes) and ReestructurasSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	else 
	datediff(day,(select top 1 fechapago from CalendarioNormal where Abonado < (monto+interes) and id_credito = carteraVencida.id order by FechaPago asc),GETDATE())
	end)
end as Diasdeatraso,
format(((pagare - AbonadoSinMultas) + multasPendientes),'C','es-mx') as 'Liquida con',DatosSolicitud.Telefono,DatosSolicitud.Celular,(DatosSolicitud.Calle + ', ' + DatosSolicitud.Noext + ', ' + DatosSolicitud.Colonia ) as Domicilio,Promotor,Gestor,DatosSolicitud.NombreR1 As 'Referencia 1',DatosSolicitud.TelefonoR1,DatosSolicitud.NombreR2 as 'Referencia 2',DatosSolicitud.TelefonoR2,carteravencida.Estado from 
(select nombre,id,pagare,PagoSemanal,AbonadoSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,
 case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.Estado = 'R' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Promotor,Estado,Pagos_atrasados,IdSolicitud,FechaDeAtraso from
(select Cartera.nombre,Cartera.id,
case when Cartera.Estado = 'C' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where Abonado <> 0 and Abonado >= interes and conveniossac.idcredito = Cartera.id group by idcredito),0)
when Cartera.Estado = 'R' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where Abonado <> 0 and Abonado >= interes and ReestructurasSac.idcredito = Cartera.id group by idcredito),0)
else
isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id group by id_credito),0) end as AbonadoSinMultas,
case when Cartera.Estado = 'C' then
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idconvenio = ConveniosSac.id where CalendarioConveniosSac.estado = 'V' and Abonado <= CalendarioConveniosSac.Interes and ConveniosSac.idCredito =cartera.id group by CalendarioConveniosSac.idConvenio),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioConveniosSac.Interes) ))) )) as AbonadoInteres from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where CalendarioConveniosSac.estado = 'V' and Abonado >=CalendarioConveniosSac.Interes and ConveniosSac.idCredito =cartera.id group by CalendarioConveniosSac.idConvenio),0)),0)
--isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioConveniossac.estado = 'V' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0) 
when Cartera.Estado = 'R' then
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idconvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado <= CalendarioReestructurasSac.Interes and ReestructurasSac.idCredito =cartera.id group by CalendarioReestructurasSac.idConvenio),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioReestructurasSac.Interes) ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado >=CalendarioReestructurasSac.Interes and ReestructurasSac.idCredito =cartera.id group by CalendarioReestructurasSac.idConvenio),0)),0)
else
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)),0)end as AbonadoMultasV,
case when Cartera.Estado = 'C' then
isnull((select SUM(Abonado - CalendarioConveniossac.monto) as AbonadoMultas from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where  CalendarioConveniossac.estado = 'L' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(Abonado - CalendarioReestructurasSac.monto) as AbonadoMultas from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where  CalendarioReestructurasSac.estado = 'L' and ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L' and CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as AbonadoMultasL,
case when Cartera.Estado = 'C' THEN 
isnull((select SUM(CalendarioConveniossac.interes) as Multas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where  Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.interes) as Multas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where  ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(CalendarioNormal.interes) as Multas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as Multas,
case when cartera.Estado = 'C' THEN 
(select SUM(calendarioconveniossac.monto) from CalendarioConveniossac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(CalendarioReestructurasSac.monto) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where ReestructurasSac.idcredito = Cartera.id)
else
(select Pagare from credito where id = Cartera.id) end as pagare,
case when Cartera.Estado = 'C' then
(select COUNT(pendiente) AS Pagos_atrasados from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado = 'V' and Conveniossac.idcredito = cartera.id)
when Cartera.Estado = 'R' then
(select COUNT(pendiente) AS Pagos_atrasados from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = cartera.id)
 else
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
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.pendiente) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
isnull(convert(varchar,(select top 1 CalendarioConveniosSac.Fecha from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniosSac.Fecha>'1900-01-01' and ConveniosSac.idCredito = Cartera.id order by CalendarioConveniosSac.Fecha desc),23),'Nunca')
when Cartera.Estado = 'R' then
isnull(convert(varchar,(select top 1 CalendarioReestructurasSac.Fecha from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Fecha>'1900-01-01' and ReestructurasSac.idCredito = Cartera.id order by CalendarioReestructurasSac.Fecha desc),23),'Nunca')
else
isnull(convert(varchar,(select top 1 FechaUltimoPago from CalendarioNormal where FechaUltimoPago>'1900-01-01' and CalendarioNormal.id_credito = Cartera.id order by FechaUltimoPago desc),23),'Nunca')
end as FechaDeAtraso,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado ='V' and Conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(interes) as MultasVencidas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado ='V' and ReestructurasSac.idcredito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado,Cartera.IdSolicitud,isnull((select id from promesadepago where idcredito = Cartera.id and estado = 'A' and tipocredito = cartera.estado),0) as prompago from
(select Credito.nombre,Credito.id,Credito.IdGestor,Credito.IdPromotor,Credito.Estado,Credito.IdSolicitud from CREDITO inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito  where CalendarioNormal.Estado = 'V'  and Credito.Estado <> 'L' and Credito.Estado <> 'T' and idpromotor = '" & idEmpleado & "' and Credito.Nombre like '%" & txtnombre.Text & "%' group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado,Credito.monto,Credito.Interes,Credito.IdSolicitud) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal where prompago =0) carteraVencida inner join Solicitud on carteraVencida.IdSolicitud = Solicitud.id inner join DatosSolicitud on solicitud.id = DatosSolicitud.IdSolicitud inner join Clientes on DatosSolicitud.IdCliente = Clientes.id inner join TiposDeCredito on Solicitud.tipo = TiposDeCredito.id where VencidoNormal <> 0 and DatosSolicitud.Estado <> 'R')creditos_en_mora order by creditos_en_mora.nombre asc"
                    End If
                Case "Todos"
                    consulta = "select creditos_en_mora.* from
(select carteraVencida.id,case when TiposDeCredito.Tipo = 'G' then concat(carteravencida.nombre,' (',Clientes.Nombre,' ' ,Clientes.ApellidoPaterno,' ',Clientes.ApellidoMaterno,')') else carteravencida.nombre end  as Nombre,format(pagare,'C','es-mx') as Pagaré,format(PagoSemanal,'C','es-mx') as 'Pago Semanal',format(AbonadoSinMultas,'C','es-mx') as 'Abonado sin multas',format(Multas,'C','es-mx') as Multas,format(AbonadoMultas,'C','es-mx') as 'Multas abonadas',format(multasPendientes,'C','es-mx') as 'Multas pendientes',format(VencidoNormal,'C','es-mx') as 'Vencido normal',format(TotalPendiente,'C','es-mx') as 'Total Pendiente',Pagos_atrasados as 'Pagos atrasados',FechaDeAtraso as 'Fecha del último abono',
case when FechaDeAtraso = 'Nunca' then
	(case when carteraVencida.Estado = 'C' then
	datediff(day,(select top 1 fechapago from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where Abonado < (monto+interes) and ConveniosSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	when carteraVencida.Estado = 'R' then
	datediff(day,(select top 1 fechapago from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where Abonado < (monto+interes) and ReestructurasSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	else 
	datediff(day,(select top 1 fechapago from CalendarioNormal where Abonado < (monto+interes) and id_credito = carteraVencida.id order by FechaPago asc),GETDATE())
	end)
else (case when carteraVencida.Estado = 'C' then
	datediff(day,(select top 1 fechapago from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where Abonado < (monto+interes) and ConveniosSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	when carteraVencida.Estado = 'R' then
	datediff(day,(select top 1 fechapago from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where Abonado < (monto+interes) and ReestructurasSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	else 
	datediff(day,(select top 1 fechapago from CalendarioNormal where Abonado < (monto+interes) and id_credito = carteraVencida.id order by FechaPago asc),GETDATE())
	end)
end as Diasdeatraso,
format(((pagare - AbonadoSinMultas) + multasPendientes),'C','es-mx') as 'Liquida con',DatosSolicitud.Telefono,DatosSolicitud.Celular,(DatosSolicitud.Calle + ', ' + DatosSolicitud.Noext + ', ' + DatosSolicitud.Colonia ) as Domicilio,Promotor,Gestor,DatosSolicitud.NombreR1 As 'Referencia 1',DatosSolicitud.TelefonoR1,DatosSolicitud.NombreR2 as 'Referencia 2',DatosSolicitud.TelefonoR2,carteravencida.Estado from 
(select nombre,id,pagare,PagoSemanal,AbonadoSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,
 case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.Estado = 'R' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Promotor,Estado,Pagos_atrasados,IdSolicitud,FechaDeAtraso from
(select Cartera.nombre,Cartera.id,
case when Cartera.Estado = 'C' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where Abonado <> 0 and Abonado >= interes and conveniossac.idcredito = Cartera.id group by idcredito),0)
when Cartera.Estado = 'R' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where Abonado <> 0 and Abonado >= interes and ReestructurasSac.idcredito = Cartera.id group by idcredito),0)
else
isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id group by id_credito),0) end as AbonadoSinMultas,
case when Cartera.Estado = 'C' then
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idconvenio = ConveniosSac.id where CalendarioConveniosSac.estado = 'V' and Abonado <= CalendarioConveniosSac.Interes and ConveniosSac.idCredito =cartera.id group by CalendarioConveniosSac.idConvenio),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioConveniosSac.Interes) ))) )) as AbonadoInteres from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where CalendarioConveniosSac.estado = 'V' and Abonado >=CalendarioConveniosSac.Interes and ConveniosSac.idCredito =cartera.id group by CalendarioConveniosSac.idConvenio),0)),0)
--isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioConveniossac.estado = 'V' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0) 
when Cartera.Estado = 'R' then
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idconvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado <= CalendarioReestructurasSac.Interes and ReestructurasSac.idCredito =cartera.id group by CalendarioReestructurasSac.idConvenio),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioReestructurasSac.Interes) ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado >=CalendarioReestructurasSac.Interes and ReestructurasSac.idCredito =cartera.id group by CalendarioReestructurasSac.idConvenio),0)),0)
else
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)),0)end as AbonadoMultasV,
case when Cartera.Estado = 'C' then
isnull((select SUM(Abonado - CalendarioConveniossac.monto) as AbonadoMultas from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where  CalendarioConveniossac.estado = 'L' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(Abonado - CalendarioReestructurasSac.monto) as AbonadoMultas from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where  CalendarioReestructurasSac.estado = 'L' and ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L' and CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as AbonadoMultasL,
case when Cartera.Estado = 'C' THEN 
isnull((select SUM(CalendarioConveniossac.interes) as Multas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where  Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.interes) as Multas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where  ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(CalendarioNormal.interes) as Multas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as Multas,
case when cartera.Estado = 'C' THEN 
(select SUM(calendarioconveniossac.monto) from CalendarioConveniossac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(CalendarioReestructurasSac.monto) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where ReestructurasSac.idcredito = Cartera.id)
else
(select Pagare from credito where id = Cartera.id) end as pagare,
case when Cartera.Estado = 'C' then
(select COUNT(pendiente) AS Pagos_atrasados from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado = 'V' and Conveniossac.idcredito = cartera.id)
when Cartera.Estado = 'R' then
(select COUNT(pendiente) AS Pagos_atrasados from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = cartera.id)
 else
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
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.pendiente) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
isnull(convert(varchar,(select top 1 CalendarioConveniosSac.Fecha from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniosSac.Fecha>'1900-01-01' and ConveniosSac.idCredito = Cartera.id order by CalendarioConveniosSac.Fecha desc),23),'Nunca')
when Cartera.Estado = 'R' then
isnull(convert(varchar,(select top 1 CalendarioReestructurasSac.Fecha from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Fecha>'1900-01-01' and ReestructurasSac.idCredito = Cartera.id order by CalendarioReestructurasSac.Fecha desc),23),'Nunca')
else
isnull(convert(varchar,(select top 1 FechaUltimoPago from CalendarioNormal where FechaUltimoPago>'1900-01-01' and CalendarioNormal.id_credito = Cartera.id order by FechaUltimoPago desc),23),'Nunca')
end as FechaDeAtraso,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado ='V' and Conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(interes) as MultasVencidas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado ='V' and ReestructurasSac.idcredito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado,Cartera.IdSolicitud,isnull((select id from promesadepago where idcredito = Cartera.id and estado = 'A' and tipocredito = cartera.estado),0) as prompago from
(select Credito.nombre,Credito.id,Credito.IdGestor,Credito.IdPromotor,Credito.Estado,Credito.IdSolicitud from CREDITO inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito  where CalendarioNormal.Estado = 'V'  and Credito.Estado <> 'L' and Credito.Estado <> 'T' and Credito.Nombre like '%" & txtnombre.Text & "%' group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado,Credito.monto,Credito.Interes,Credito.IdSolicitud) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal where prompago =0) carteraVencida inner join Solicitud on carteraVencida.IdSolicitud = Solicitud.id inner join DatosSolicitud on solicitud.id = DatosSolicitud.IdSolicitud inner join Clientes on DatosSolicitud.IdCliente = Clientes.id inner join TiposDeCredito on Solicitud.tipo = TiposDeCredito.id where VencidoNormal <> 0 and DatosSolicitud.Estado <> 'R')creditos_en_mora order by creditos_en_mora.nombre asc"
            End Select
        Else
            consulta = "select creditos_en_mora.* from
(select carteraVencida.id,case when TiposDeCredito.Tipo = 'G' then concat(carteravencida.nombre,' (',Clientes.Nombre,' ' ,Clientes.ApellidoPaterno,' ',Clientes.ApellidoMaterno,')') else carteravencida.nombre end  as Nombre,format(pagare,'C','es-mx') as Pagaré,format(PagoSemanal,'C','es-mx') as 'Pago Semanal',format(AbonadoSinMultas,'C','es-mx') as 'Abonado sin multas',format(Multas,'C','es-mx') as Multas,format(AbonadoMultas,'C','es-mx') as 'Multas abonadas',format(multasPendientes,'C','es-mx') as 'Multas pendientes',format(VencidoNormal,'C','es-mx') as 'Vencido normal',format(TotalPendiente,'C','es-mx') as 'Total Pendiente',Pagos_atrasados as 'Pagos atrasados',FechaDeAtraso as 'Fecha del último abono',
case when FechaDeAtraso = 'Nunca' then
	(case when carteraVencida.Estado = 'C' then
	datediff(day,(select top 1 fechapago from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where Abonado < (monto+interes) and ConveniosSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	when carteraVencida.Estado = 'R' then
	datediff(day,(select top 1 fechapago from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where Abonado < (monto+interes) and ReestructurasSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	else 
	datediff(day,(select top 1 fechapago from CalendarioNormal where Abonado < (monto+interes) and id_credito = carteraVencida.id order by FechaPago asc),GETDATE())
	end)
else (case when carteraVencida.Estado = 'C' then
	datediff(day,(select top 1 fechapago from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where Abonado < (monto+interes) and ConveniosSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	when carteraVencida.Estado = 'R' then
	datediff(day,(select top 1 fechapago from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where Abonado < (monto+interes) and ReestructurasSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	else 
	datediff(day,(select top 1 fechapago from CalendarioNormal where Abonado < (monto+interes) and id_credito = carteraVencida.id order by FechaPago asc),GETDATE())
	end)
end as Diasdeatraso,
format(((pagare - AbonadoSinMultas) + multasPendientes),'C','es-mx') as 'Liquida con',DatosSolicitud.Telefono,DatosSolicitud.Celular,(DatosSolicitud.Calle + ', ' + DatosSolicitud.Noext + ', ' + DatosSolicitud.Colonia ) as Domicilio,Promotor,Gestor,DatosSolicitud.NombreR1 As 'Referencia 1',DatosSolicitud.TelefonoR1,DatosSolicitud.NombreR2 as 'Referencia 2',DatosSolicitud.TelefonoR2,carteravencida.Estado from 
(select nombre,id,pagare,PagoSemanal,AbonadoSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,
 case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.Estado = 'R' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Promotor,Estado,Pagos_atrasados,IdSolicitud,FechaDeAtraso from
(select Cartera.nombre,Cartera.id,
case when Cartera.Estado = 'C' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where Abonado <> 0 and Abonado >= interes and conveniossac.idcredito = Cartera.id group by idcredito),0)
when Cartera.Estado = 'R' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where Abonado <> 0 and Abonado >= interes and ReestructurasSac.idcredito = Cartera.id group by idcredito),0)
else
isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id group by id_credito),0) end as AbonadoSinMultas,
case when Cartera.Estado = 'C' then
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idconvenio = ConveniosSac.id where CalendarioConveniosSac.estado = 'V' and Abonado <= CalendarioConveniosSac.Interes and ConveniosSac.idCredito =cartera.id group by CalendarioConveniosSac.idConvenio),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioConveniosSac.Interes) ))) )) as AbonadoInteres from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where CalendarioConveniosSac.estado = 'V' and Abonado >=CalendarioConveniosSac.Interes and ConveniosSac.idCredito =cartera.id group by CalendarioConveniosSac.idConvenio),0)),0)
--isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioConveniossac.estado = 'V' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0) 
when Cartera.Estado = 'R' then
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idconvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado <= CalendarioReestructurasSac.Interes and ReestructurasSac.idCredito =cartera.id group by CalendarioReestructurasSac.idConvenio),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioReestructurasSac.Interes) ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado >=CalendarioReestructurasSac.Interes and ReestructurasSac.idCredito =cartera.id group by CalendarioReestructurasSac.idConvenio),0)),0)
else
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)),0)end as AbonadoMultasV,
case when Cartera.Estado = 'C' then
isnull((select SUM(Abonado - CalendarioConveniossac.monto) as AbonadoMultas from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where  CalendarioConveniossac.estado = 'L' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(Abonado - CalendarioReestructurasSac.monto) as AbonadoMultas from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where  CalendarioReestructurasSac.estado = 'L' and ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L' and CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as AbonadoMultasL,
case when Cartera.Estado = 'C' THEN 
isnull((select SUM(CalendarioConveniossac.interes) as Multas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where  Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.interes) as Multas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where  ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(CalendarioNormal.interes) as Multas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as Multas,
case when cartera.Estado = 'C' THEN 
(select SUM(calendarioconveniossac.monto) from CalendarioConveniossac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(CalendarioReestructurasSac.monto) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where ReestructurasSac.idcredito = Cartera.id)
else
(select Pagare from credito where id = Cartera.id) end as pagare,
case when Cartera.Estado = 'C' then
(select COUNT(pendiente) AS Pagos_atrasados from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado = 'V' and Conveniossac.idcredito = cartera.id)
when Cartera.Estado = 'R' then
(select COUNT(pendiente) AS Pagos_atrasados from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = cartera.id)
 else
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
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.pendiente) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
isnull(convert(varchar,(select top 1 CalendarioConveniosSac.Fecha from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniosSac.Fecha>'1900-01-01' and ConveniosSac.idCredito = Cartera.id order by CalendarioConveniosSac.Fecha desc),23),'Nunca')
when Cartera.Estado = 'R' then
isnull(convert(varchar,(select top 1 CalendarioReestructurasSac.Fecha from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Fecha>'1900-01-01' and ReestructurasSac.idCredito = Cartera.id order by CalendarioReestructurasSac.Fecha desc),23),'Nunca')
else
isnull(convert(varchar,(select top 1 FechaUltimoPago from CalendarioNormal where FechaUltimoPago>'1900-01-01' and CalendarioNormal.id_credito = Cartera.id order by FechaUltimoPago desc),23),'Nunca')
end as FechaDeAtraso,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado ='V' and Conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(interes) as MultasVencidas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado ='V' and ReestructurasSac.idcredito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado,Cartera.IdSolicitud,isnull((select id from promesadepago where idcredito = Cartera.id and estado = 'A' and tipocredito = cartera.estado),0) as prompago from
(select Credito.nombre,Credito.id,Credito.IdGestor,Credito.IdPromotor,Credito.Estado,Credito.IdSolicitud from CREDITO inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito  where CalendarioNormal.Estado = 'V'  and Credito.Estado <> 'L' and Credito.Estado <> 'T' and Credito.Nombre like '%" & txtnombre.Text & "%' group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado,Credito.monto,Credito.Interes,Credito.IdSolicitud) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal where prompago =0) carteraVencida inner join Solicitud on carteraVencida.IdSolicitud = Solicitud.id inner join DatosSolicitud on solicitud.id = DatosSolicitud.IdSolicitud inner join Clientes on DatosSolicitud.IdCliente = Clientes.id inner join TiposDeCredito on Solicitud.tipo = TiposDeCredito.id where VencidoNormal <> 0 and DatosSolicitud.Estado <> 'R')creditos_en_mora order by creditos_en_mora.nombre asc"
        End If



        adapterDT = New OleDbDataAdapter(consulta, conexiondt)
        dataDT = New DataTable
        adapterDT.Fill(dataDT)
        Return dataDT

    End Function

    Private Sub BackgroundConectarEmpresas_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundConectarEmpresas.RunWorkerCompleted
        Panel2.Visible = False
        TabControl1.Visible = True
    End Sub
    Public Sub nuevolibroMora()
        exLibro = exApp.Workbooks.Add
    End Sub

    Function GridAExcelMora(ByVal ElGrid As DataGridView) As Boolean

        'Creamos las variables

        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try
            'Añadimos el Libro al programa, y la hoja al libro

            exHoja = exLibro.Worksheets.Add()
            exHoja.Name = ElGrid.Name

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount

            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.


            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).HeaderText.ToString
                'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value.ToString
                Next
            Next
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()
            'exHoja.Columns.Range("A:A").NumberFormat = "#0"

            'Aplicación visible

            exHoja = Nothing


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")

            Return False
        End Try

        Return True

    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerGrande.Tick
        If widthEmpresa <= 507 Then
            FlowEmpresas.Width = widthEmpresa
            widthEmpresa += 10
        Else
            If heightEmpresa <= 68 Then
                FlowEmpresas.Height = heightEmpresa
                heightEmpresa += 10
            Else
                TimerGrande.Stop()
                TimerGrande.Enabled = False
                chicoGrande = True
            End If

        End If
    End Sub

    Private Sub TimerChico_Tick(sender As Object, e As EventArgs) Handles TimerChico.Tick
        If widthEmpresa >= 0 Then
            FlowEmpresas.Width = widthEmpresa
            widthEmpresa -= 10
        Else
            If heightEmpresa >= 0 Then
                FlowEmpresas.Height = heightEmpresa
                heightEmpresa -= 10
            Else
                TimerChico.Stop()
                TimerChico.Enabled = False
                chicoGrande = False
            End If

        End If
    End Sub

    Public Sub cerrarlibroMora()
        Try

            Dim guardar As SaveFileDialog
            guardar = New SaveFileDialog
            guardar.Filter = "Archivo de Excel|*.xlsx"
            If guardar.ShowDialog = DialogResult.OK _
            Then
                exApp.Application.Visible = True
                'exLibro.SaveAs(Environ("UserProfile") & "\desktop\" & nombre & ".xls")
                exLibro.SaveAs(guardar.FileName)
            End If

            ' exLibro.SaveAs(Environ("UserProfile") & "\desktop\NombreDeTuArchivo.xls")
            'exLibro = Nothing
            'exApp = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class