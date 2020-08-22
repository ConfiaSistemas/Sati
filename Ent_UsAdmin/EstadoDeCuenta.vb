Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word
Imports Xceed.Words.NET

Public Class EstadoDeCuenta
    Dim dataComportamiento As Data.DataTable

    Dim adapterComportamiento As SqlDataAdapter
    Public idCredito As Integer
    Dim ncargando As Cargando
    Dim pagoMinimo, montoCredito, MontoPagado, SaldoVencido, SaldoInicial, SaldoFinal, Pagare As Double
    Dim FechaLimite, FechaCorte As Date
    Dim ExisteSaldoInicial, ExisteSaldoFinal, EncontroRegistros As Boolean

    Private Sub BackgroundGeneral_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundGeneral.DoWork
        Dim comandoInformacion As SqlCommand
        Dim consultaInformacion As String
        Dim readerInformacion As SqlDataReader
        consultaInformacion = "select nombre,id,pagare,AbonadoSinMultas,(pagare-AbonadoSinMultas) as valorCarteraSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,((Multas-(AbonadoMultasL+AbonadoMultasV))+(pagare-AbonadoSinMultas)) as ValorCarteraConMultas, case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Promotor,Estado,FechaLimite from
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
case when not exists (select id from conveniossac where idCredito=Cartera.id) then (isnull((select top 1 FechaPago from CalendarioNormal where id_credito=cartera.id and estado='P' order by FechaPago asc),getdate()))
else isnull((select top 1 FechaPago from CalendarioConveniosSac where idConvenio=(select id from conveniossac where idcredito=cartera.id) and estado='P' order by FechaPago asc),getdate()) end as FechaLimite,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado ='V' and Conveniossac.idcredito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado from
(select credito.nombre,Credito.id,Credito.idgestor,Credito.IdPromotor,credito.Estado from Credito inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito where Credito.id = '" & idCredito & "' group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal order by nombre asc"


        comandoInformacion = New SqlCommand
        comandoInformacion.Connection = conexionempresa
        comandoInformacion.CommandText = consultaInformacion
        readerInformacion = comandoInformacion.ExecuteReader
        If readerInformacion.HasRows Then
            While readerInformacion.Read
                SaldoFinal = readerInformacion("TotalPendiente")
                SaldoInicial = readerInformacion("TotalPendiente")

                FechaLimite = readerInformacion("FechaLimite")
                pagoMinimo = readerInformacion("TotalPendiente")
                MontoPagado = readerInformacion("AbonadoSinMultas")
                SaldoVencido = readerInformacion("VencidoNormal")
                Pagare = readerInformacion("pagare")
                nombreCredito = readerInformacion("nombre")
                FechaCorte = readerInformacion("fechalimite")
                ExisteSaldoInicial = True

                ExisteSaldoFinal = True
            End While


        End If


        Dim consultaComportamiento As String
        consultaComportamiento = "if  exists(select * from ConveniosSac where idCredito = " & idCredito & " and estado = 'A')
begin
declare @SQL varchar(max),@numero int,@TipoPago varchar(50),
@idPago int,
@Npago int,
@Monto money,
@Interes money,
@Abonado money,
@Pendiente money,
@FechaPago date,
@FechaUltimoPago date
set @SQL = 'select * from ('
declare Comportamiento cursor  LOCAL STATIC READ_ONLY FORWARD_ONLY for
select  ROW_NUMBER() OVER(ORDER BY fechapago ASC) AS Numero,EstadoDeCuenta.* from
(select 'Normal' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,FechaUltimoPago from CalendarioNormal where id_credito = " & idCredito & " and Estado = 'L'
union
select 'Creación de convenio' as TipoDePago,'','',DeudaCredito,Moratorios,'',TotalDeuda,Fecha,'' from ConveniosSac where idCredito = " & idCredito & "
union
select 'Convenio' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,Fecha from CalendarioConveniosSac where idConvenio = (select id from ConveniosSac where idCredito = " & idCredito & " and calendarioconveniossac.abonado <> 0 ) ) EstadoDeCuenta  order by FechaPago asc
open Comportamiento
fetch next from Comportamiento into @numero,@TipoPago ,
@idPago ,
@Npago,
@Monto ,
@Interes ,
@Abonado ,
@Pendiente ,
@FechaPago ,
@FechaUltimoPago 
while(@@fetch_status=0)
begin
if @TipoPago = 'Normal'
begin
set @SQL = concat(@SQL , 'select   ' ,char(39), @TipoPago ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago, ',char(39), @Npago ,char(39),' as Npago, ',char(39), @Monto ,char(39),' as Monto, ',char(39), @Interes ,char(39),' as Interes, ',char(39), @Abonado ,char(39),' as Abonado, ',char(39), @Pendiente ,char(39),' as Pendiente, ',char(39), @FechaPago ,char(39),' as FechaPago, ',char(39), @FechaUltimoPago ,char(39),' as FechaUltimoPago, ',char(39),char(39),' as Hora', ' Union ')
	if exists(select * from TicketDetalle inner join TipoDoc on TicketDetalle.TipoDoc = TipoDoc.id where idpago = @idPago and TipoDoc.Nombre = 'Pago' )
	begin
		set @SQL = concat(@SQL , ' select ' ,char(39), 'Ticket' ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago,', char(39),char(39),',ticketdetalle.pagonormal,ticketdetalle.intereses,', char(39),char(39),',',char(39),char(39),',','ticketdetalle.fecha,',char(39),char(39),',hora from ticketdetalle inner join tipodoc on ticketdetalle.tipodoc = tipodoc.id inner join ticket on ticketdetalle.idticket = ticket.id where idpago = ',@idPago,' and tipodoc.nombre = ',char(39),'Pago',char(39),' Union ')

	end
end
if @TipoPago = 'Creación de Convenio'
begin
set @SQL = concat(@SQL , 'select   ' ,char(39), @TipoPago ,char(39), ' as TipoDePago,',char(39), '' ,char(39),' as Idpago, ',char(39), '' ,char(39),' as Npago, ',char(39), @Monto ,char(39),' as Monto, ',char(39), @Interes ,char(39),' as Interes, ',char(39), '' ,char(39),' as Abonado, ',char(39), '' ,char(39),' as Pendiente, ',char(39), @FechaPago ,char(39),' as FechaPago, ',char(39), '' ,char(39),' as FechaUltimopago, ',char(39),char(39),' as Hora', ' Union ')

end
if @TipoPago = 'Convenio'
begin
set @SQL = concat(@SQL , 'select  ' ,char(39), @TipoPago ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago, ',char(39), @Npago ,char(39),' as Npago, ',char(39), @Monto ,char(39),' as Monto, ',char(39), @Interes ,char(39),' as Interes, ',char(39), @Abonado ,char(39),' as Abonado, ',char(39), @Pendiente ,char(39),' as Pendiente, ',char(39), @FechaPago ,char(39),' as FechaPago, ',char(39), @FechaUltimoPago ,char(39),' as FechaUltimopago, ',char(39),char(39),' as Hora', ' Union ')
	if exists(select * from TicketDetalle inner join TipoDoc on TicketDetalle.TipoDoc = TipoDoc.id where idpago = @idPago and TipoDoc.Nombre = 'Convenio' )
	begin
		set @SQL = concat(@SQL , ' select   ' ,char(39), 'TicketC' ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago,', char(39),char(39),',ticketdetalle.pagonormal,ticketdetalle.intereses,', char(39),char(39),',',char(39),char(39),',','ticketdetalle.fecha,',char(39),char(39),',hora from ticketdetalle inner join tipodoc on ticketdetalle.tipodoc = tipodoc.id inner join ticket on ticketdetalle.idticket = ticket.id where idpago = ',@idPago,' and tipodoc.nombre = ',char(39),'Convenio',char(39),' Union ')

	end

end


fetch next from Comportamiento into @numero,@TipoPago ,
@idPago ,
@Npago,
@Monto ,
@Interes ,
@Abonado ,
@Pendiente ,
@FechaPago ,
@FechaUltimoPago 
end
end


else if exists(select * from ticket where idcredito = " & idCredito & " and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio'))
begin

set @SQL = 'select * from ('
declare Comportamiento cursor  LOCAL STATIC READ_ONLY FORWARD_ONLY for
select  ROW_NUMBER() OVER(ORDER BY fechapago ASC) AS Numero,EstadoDeCuenta.* from
(select 'Normal' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,FechaUltimoPago from CalendarioNormal where id_credito = " & idCredito & " and Estado = 'L' and fechaultimopago <= (select fecha from conveniossac where idcredito = " & idCredito & ")
union
select 'Creación de convenio' as TipoDePago,'','',DeudaCredito,Moratorios,'',TotalDeuda,Fecha,'' from ConveniosSac where idCredito = " & idCredito & "
union
select 'Convenio' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,Fecha from CalendarioConveniosSac where idConvenio = (select id from ConveniosSac where idCredito = " & idCredito & ") and abonado <> 0 and fecha <= (select fecha from ticket where idcredito = " & idCredito & " and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio'))
union
select 'Cancelación de convenio' as TipoDePago,'','',PagoNormal,Intereses,'',Total,Fecha,'' from Ticket where idcredito = " & idCredito & " and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio')
union
	
select 'Normal' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,FechaUltimoPago from CalendarioNormal where id_credito = " & idCredito & " and 1= case when exists(select id from ReestructurasSac where idCredito = " & idCredito & ")  and idpago in (select idPago from CalendarioNormal where id_credito = " & idCredito & " and (fechaultimopago >= (select fecha from ticket where idcredito = " & idCredito & " and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio')))) then 1 
when not exists(select id from ReestructurasSac where idCredito = " & idCredito & ") and idpago in (select idPago from CalendarioNormal where id_credito = " & idCredito & " and (fechaultimopago >= (select fecha from ticket where idcredito = " & idCredito & " and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio'))) )  then 1
 end


union

select 'Creación de reestructura' as TipoDePago,'','',DeudaCredito,Moratorios,'',TotalDeuda,Fecha,'' from reestructurassac where idCredito = " & idCredito & "
union
select 'Reestructura' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,Fecha from calendarioreestructurassac where idConvenio = (select id from reestructurassac where idCredito = " & idCredito & ") and abonado <> 0 )estadodecuenta  order by  (case  when idPago in (select idPago from CalendarioNormal where id_credito = " & idCredito & " and Estado = 'L' and fechaultimopago <= (select fecha from conveniossac where idcredito = " & idCredito & ")) then 1   when TipoDePago = 'Creación de convenio' then 2 when TipoDePago = 'Convenio' then 3 when TipoDePago = 'Cancelación de convenio' then 4 when idpago in (select idPago from CalendarioNormal where id_credito = " & idCredito & " and (fechaultimopago >= (select fecha from ticket where idcredito = " & idCredito & " and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio')) or FechaUltimoPago = '1900-01-01')) then 5 when TipoDePago = 'Creación de reestructura' then 6 when TipoDePago = 'Reestructura' then 7  end )asc
open Comportamiento
fetch next from Comportamiento into @numero,@TipoPago ,
@idPago ,
@Npago,
@Monto ,
@Interes ,
@Abonado ,
@Pendiente ,
@FechaPago ,
@FechaUltimoPago 
while(@@fetch_status=0)
begin
if @TipoPago = 'Normal'
begin
set @SQL = concat(@SQL , 'select   ' ,char(39), @TipoPago ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago, ',char(39), @Npago ,char(39),' as Npago, ',char(39), @Monto ,char(39),' as Monto, ',char(39), @Interes ,char(39),' as Interes, ',char(39), @Abonado ,char(39),' as Abonado, ',char(39), @Pendiente ,char(39),' as Pendiente, ',char(39), @FechaPago ,char(39),' as FechaPago, ',char(39), @FechaUltimoPago ,char(39),' as FechaUltimoPago, ',char(39),char(39),' as Hora', ' Union ')
	if exists(select * from TicketDetalle inner join TipoDoc on TicketDetalle.TipoDoc = TipoDoc.id where idpago = @idPago and TipoDoc.Nombre = 'Pago' )
	begin
		set @SQL = concat(@SQL , ' select ' ,char(39), 'Ticket' ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago,', char(39),char(39),',ticketdetalle.pagonormal,ticketdetalle.intereses,', char(39),char(39),',',char(39),char(39),',','ticketdetalle.fecha,',char(39),char(39),',hora from ticketdetalle inner join tipodoc on ticketdetalle.tipodoc = tipodoc.id inner join ticket on ticketdetalle.idticket = ticket.id where idpago = ',@idPago,' and tipodoc.nombre = ',char(39),'Pago',char(39),' Union ')
			if exists(select * from TicketDetalle inner join TipoDoc on TicketDetalle.TipoDoc = TipoDoc.id where idpago = @idPago and TipoDoc.Nombre = 'Cancelación de Convenio')
			begin
			set @SQL = concat(@SQL , ' select ' ,char(39), 'Pago por cancelación de convenio' ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago,', char(39),char(39),',ticketdetalle.pagonormal,ticketdetalle.intereses,', char(39),char(39),',',char(39),char(39),',','ticketdetalle.fecha,',char(39),char(39),',hora from ticketdetalle inner join tipodoc on ticketdetalle.tipodoc = tipodoc.id inner join ticket on ticketdetalle.idticket = ticket.id where idpago = ',@idPago,' and tipodoc.nombre = ',char(39),'Cancelación de Convenio',char(39),' Union ')

			end
	end
	else if exists(select * from TicketDetalle inner join TipoDoc on TicketDetalle.TipoDoc = TipoDoc.id where idpago = @idPago and TipoDoc.Nombre = 'Cancelación de Convenio')
	begin
		set @SQL = concat(@SQL , ' select ' ,char(39), 'Pago por cancelación de convenio' ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago,', char(39),char(39),',ticketdetalle.pagonormal,ticketdetalle.intereses,', char(39),char(39),',',char(39),char(39),',','ticketdetalle.fecha,',char(39),char(39),',hora from ticketdetalle inner join tipodoc on ticketdetalle.tipodoc = tipodoc.id inner join ticket on ticketdetalle.idticket = ticket.id where idpago = ',@idPago,' and tipodoc.nombre = ',char(39),'Cancelación de Convenio',char(39),' Union ')

	end
end
if @TipoPago = 'Creación de Convenio'
begin
set @SQL = concat(@SQL , 'select   ' ,char(39), @TipoPago ,char(39), ' as TipoDePago,',char(39), '' ,char(39),' as Idpago, ',char(39), '' ,char(39),' as Npago, ',char(39), @Monto ,char(39),' as Monto, ',char(39), @Interes ,char(39),' as Interes, ',char(39), '' ,char(39),' as Abonado, ',char(39), '' ,char(39),' as Pendiente, ',char(39), @FechaPago ,char(39),' as FechaPago, ',char(39), '' ,char(39),' as FechaUltimopago, ',char(39),char(39),' as Hora', ' Union ')

end
if @TipoPago = 'Convenio'
begin
set @SQL = concat(@SQL , 'select  ' ,char(39), @TipoPago ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago, ',char(39), @Npago ,char(39),' as Npago, ',char(39), @Monto ,char(39),' as Monto, ',char(39), @Interes ,char(39),' as Interes, ',char(39), @Abonado ,char(39),' as Abonado, ',char(39), @Pendiente ,char(39),' as Pendiente, ',char(39), @FechaPago ,char(39),' as FechaPago, ',char(39), @FechaUltimoPago ,char(39),' as FechaUltimopago, ',char(39),char(39),' as Hora', ' Union ')
	if exists(select * from TicketDetalle inner join TipoDoc on TicketDetalle.TipoDoc = TipoDoc.id where idpago = @idPago and TipoDoc.Nombre = 'Convenio' )
	begin
		set @SQL = concat(@SQL , ' select   ' ,char(39), 'TicketC' ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago,', char(39),char(39),',ticketdetalle.pagonormal,ticketdetalle.intereses,', char(39),char(39),',',char(39),char(39),',','ticketdetalle.fecha,',char(39),char(39),',hora from ticketdetalle inner join tipodoc on ticketdetalle.tipodoc = tipodoc.id inner join ticket on ticketdetalle.idticket = ticket.id where idpago = ',@idPago,' and tipodoc.nombre = ',char(39),'Convenio',char(39),' Union ')

	end

end


if @TipoPago = 'Cancelación de convenio'
begin
set @SQL = concat(@SQL , 'select   ' ,char(39), @TipoPago ,char(39), ' as TipoDePago,',char(39), '' ,char(39),' as Idpago, ',char(39), '' ,char(39),' as Npago, ',char(39), @Monto ,char(39),' as Monto, ',char(39), @Interes ,char(39),' as Interes, ',char(39), '' ,char(39),' as Abonado, ',char(39), '' ,char(39),' as Pendiente, ',char(39), @FechaPago ,char(39),' as FechaPago, ',char(39), '' ,char(39),' as FechaUltimopago, ',char(39),char(39),' as Hora', ' Union ')

end

if @TipoPago = 'Creación de reestructura'
begin
set @SQL = concat(@SQL , 'select   ' ,char(39), @TipoPago ,char(39), ' as TipoDePago,',char(39), '' ,char(39),' as Idpago, ',char(39), '' ,char(39),' as Npago, ',char(39), @Monto ,char(39),' as Monto, ',char(39), @Interes ,char(39),' as Interes, ',char(39), '' ,char(39),' as Abonado, ',char(39), '' ,char(39),' as Pendiente, ',char(39), @FechaPago ,char(39),' as FechaPago, ',char(39), '' ,char(39),' as FechaUltimopago, ',char(39),char(39),' as Hora', ' Union ')

end


if @TipoPago = 'Reestructura'
begin
set @SQL = concat(@SQL , 'select  ' ,char(39), @TipoPago ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago, ',char(39), @Npago ,char(39),' as Npago, ',char(39), @Monto ,char(39),' as Monto, ',char(39), @Interes ,char(39),' as Interes, ',char(39), @Abonado ,char(39),' as Abonado, ',char(39), @Pendiente ,char(39),' as Pendiente, ',char(39), @FechaPago ,char(39),' as FechaPago, ',char(39), @FechaUltimoPago ,char(39),' as FechaUltimopago, ',char(39),char(39),' as Hora', ' Union ')
	if exists(select * from TicketDetalle inner join TipoDoc on TicketDetalle.TipoDoc = TipoDoc.id where idpago = @idPago and TipoDoc.Nombre = 'Reestructura' )
	begin
		set @SQL = concat(@SQL , ' select   ' ,char(39), 'TicketR' ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago,', char(39),char(39),',ticketdetalle.pagonormal,ticketdetalle.intereses,', char(39),char(39),',',char(39),char(39),',','ticketdetalle.fecha,',char(39),char(39),',hora from ticketdetalle inner join tipodoc on ticketdetalle.tipodoc = tipodoc.id inner join ticket on ticketdetalle.idticket = ticket.id where idpago = ',@idPago,' and tipodoc.nombre = ',char(39),'Reestructura',char(39),' Union ')

	end

end



fetch next from Comportamiento into @numero,@TipoPago ,
@idPago ,
@Npago,
@Monto ,
@Interes ,
@Abonado ,
@Pendiente ,
@FechaPago ,
@FechaUltimoPago 
end
end




else if not exists(select * from ConveniosSac where idCredito = " & idCredito & ")
begin

set @SQL = 'select * from ('
declare Comportamiento cursor  LOCAL STATIC READ_ONLY FORWARD_ONLY for
select  ROW_NUMBER() OVER(ORDER BY fechapago ASC) AS Numero,EstadoDeCuenta.* from
(select 'Normal' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,FechaUltimoPago from CalendarioNormal where id_credito = " & idCredito & " and Estado = 'L' 
union
select 'Creación de convenio' as TipoDePago,'','',DeudaCredito,Moratorios,'',TotalDeuda,Fecha,'' from ConveniosSac where idCredito = " & idCredito & "
union
select 'Convenio' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,Fecha from CalendarioConveniosSac where idConvenio = (select id from ConveniosSac where idCredito = " & idCredito & " and CalendarioConveniosSac.Estado = 'L') ) EstadoDeCuenta  order by FechaPago asc
open Comportamiento
fetch next from Comportamiento into @numero,@TipoPago ,
@idPago ,
@Npago,
@Monto ,
@Interes ,
@Abonado ,
@Pendiente ,
@FechaPago ,
@FechaUltimoPago 
while(@@fetch_status=0)
begin
if @TipoPago = 'Normal'
begin
set @SQL = concat(@SQL , 'select   ' ,char(39), @TipoPago ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago, ',char(39), @Npago ,char(39),' as Npago, ',char(39), @Monto ,char(39),' as Monto, ',char(39), @Interes ,char(39),' as Interes, ',char(39), @Abonado ,char(39),' as Abonado, ',char(39), @Pendiente ,char(39),' as Pendiente, ',char(39), @FechaPago ,char(39),' as FechaPago, ',char(39), @FechaUltimoPago ,char(39),' as FechaUltimopago, ',char(39),char(39),' as Hora', ' Union ')
	if exists(select * from TicketDetalle inner join TipoDoc on TicketDetalle.TipoDoc = TipoDoc.id where idpago = @idPago and TipoDoc.Nombre = 'Pago' )
	begin
		set @SQL = concat(@SQL , ' select ' ,char(39), 'Ticket' ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago,', char(39),char(39),',ticketdetalle.pagonormal,ticketdetalle.intereses,', char(39),char(39),',',char(39),char(39),',','ticketdetalle.fecha,',char(39),char(39),',hora from ticketdetalle inner join tipodoc on ticketdetalle.tipodoc = tipodoc.id inner join ticket on ticketdetalle.idticket = ticket.id where idpago = ',@idPago,' and tipodoc.nombre = ',char(39),'Pago',char(39),' Union ')

	end
end
fetch next from Comportamiento into @numero,@TipoPago ,
@idPago ,
@Npago,
@Monto ,
@Interes ,
@Abonado ,
@Pendiente ,
@FechaPago ,
@FechaUltimoPago 
end
end
close Comportamiento
deallocate comportamiento
if @sql <> ''
begin
Set @SQL = Left(@SQL , Len(@SQL) - 5)
end
else
begin
set @SQL = CONCAT(@sql,'select  ',char(39), '' ,char(39),' as TipoDePago,',char(39), '' ,char(39),' as idPago,',char(39), '' ,char(39),' as Npago,',char(39), '' ,char(39),' as Monto,',char(39), '' ,char(39),' as Interes,',char(39), '' ,char(39),' as Abonado,',char(39), '' ,char(39),' as Pendiente,',char(39), '' ,char(39),' as FechaPago,',char(39), '' ,char(39),' as FechaUltimoPago,',char(39), '' ,char(39),' as Hora  ')
end



--set @SQL = CONCAT(@SQL,') estadocuenta group by idpago,npago,monto,interes,abonado,pendiente,fechapago,fechaultimopago,hora,tipodepago order by  (case tipodepago when ',char(39), 'Creación de reestructura' ,char(39),'  then idpago when  ',char(39), 'Convenio' ,char(39),' then idpago when ',char(39), 'TicketC' ,char(39),' then idpago when ',char(39), 'Creación de Convenio' ,char(39),'  then idpago   end ) asc, idpago,fechapago,hora asc')
set @SQL = CONCAT(@SQL,') estadocuenta group by idpago,npago,monto,interes,abonado,pendiente,fechapago,fechaultimopago,hora,tipodepago order by  (case  when idPago in (select idPago from CalendarioNormal where id_credito = " & idCredito & " and Estado =',char(39),'L',char(39),' and fechaultimopago <= (select fecha from conveniossac where idcredito = " & idCredito & ")) then 1   when TipoDePago = ',char(39), 'Creación de Convenio' ,char(39),' then 2 when TipoDePago = ',char(39), 'Convenio' ,char(39),' or TipoDePago = ',char(39), 'TicketC' ,char(39),' then 3 when TipoDePago = ',char(39), 'Cancelación de convenio' ,char(39),' then 4 when idpago in (select idPago from CalendarioNormal where id_credito = " & idCredito & " and (fechaultimopago >= (select fecha from ticket where idcredito = " & idCredito & " and tipodoc = (select id from tipodoc where nombre = ',char(39), 'Cancelación de convenio' ,char(39),')) or FechaUltimoPago = ',char(39), '1900-01-01' ,char(39),')) then 5 when TipoDePago = ',char(39), 'Creación de reestructura' ,char(39),' then 6 when TipoDePago = ',char(39), 'Reestructura' ,char(39),' or TipoDePago = ',char(39), 'TicketR' ,char(39),' then 7  end ) asc, idpago,fechapago,hora asc')
--set @SQL = CONCAT(@SQL,') estadocuenta  ')

print @sql
if @SQL <> ') estadocuenta group by idpago,tipodepago order by (case tipodepago wh) fechapago,hora desc'
begin
Execute (@SQL)
end
"
        adapterComportamiento = New SqlDataAdapter(consultaComportamiento, conexionempresa)
        dataComportamiento = New Data.DataTable
        adapterComportamiento.Fill(dataComportamiento)




        dataTableToWord(dataComportamiento)



    End Sub

    Dim nombreCredito As String

    Private Sub EstadoDeCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dateDesde.Value = Now
        dateHasta.Value = Now

        ncargando = New Cargando
        ncargando.Show()
        ncargando.MonoFlat_Label1.Text = "Cargando Información"
        BackgroundInformacion.RunWorkerAsync()

    End Sub

    Private Sub BackgroundInformacion_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundInformacion.DoWork
        iniciarconexionempresa()


    End Sub

    Private Sub BackgroundInformacion_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundInformacion.RunWorkerCompleted
        ncargando.Close()

    End Sub


    Private Sub dataTableToWord(ByVal dt As System.Data.DataTable)
        Dim Word As Application
        Dim Doc As Word.Document
        Dim Table As Word.Table
        Dim Rng As Range
        Dim Prf1 As Word.Paragraph
        Dim Prf2 As Word.Paragraph
        Dim Prf3 As Word.Paragraph

        Word = CreateObject("Word.Application")

        FileCopy("C:\ConfiaAdmin\SATI\Estado de cuenta.docx", "C:\ConfiaAdmin\SATI\TEMPDOCS\TempEstadodeCuenta.docx")
        Doc = Word.Documents.Open("C:\ConfiaAdmin\SATI\TEMPDOCS\TempEstadodeCuenta.docx")
        Dim NCol As Integer = dt.Columns.Count
        Dim NRow As Integer = dt.Rows.Count
        'alternativo

        Table = Doc.Tables.Add(Doc.Bookmarks.Item("\endofdoc").Range, dt.Rows.Count + 1, dt.Columns.Count)

        'Agregando Los Campos De La Grilla
        For i As Integer = 1 To NCol
            If dt.Columns(i - 1).ColumnName.ToString = "TipoDePago" Then
                Table.Cell(1, i).Range.Text = "Tipo de pago"

            ElseIf dt.Columns(i - 1).ColumnName.ToString = "Idpago" Then
                Table.Cell(1, i).Range.Text = "id Pago"





            ElseIf dt.Columns(i - 1).ColumnName.ToString = "Npago" Then
                Table.Cell(1, i).Range.Text = "No. de pago"





            ElseIf dt.Columns(i - 1).ColumnName.ToString = "Interes" Then
                Table.Cell(1, i).Range.Text = "Interés"


            ElseIf dt.Columns(i - 1).ColumnName.ToString = "FechaPago" Then
                Table.Cell(1, i).Range.Text = "Fecha de pago"

            ElseIf dt.Columns(i - 1).ColumnName.ToString = "FechaUltimoPago" Then
                Table.Cell(1, i).Range.Text = "Fecha de último pago"
            Else
                Table.Cell(1, i).Range.Text = dt.Columns(i - 1).ColumnName.ToString
            End If


        Next
        'Agregando Los Registros A La Tabla
        For Fila As Integer = 0 To NRow - 1
            For Col As Integer = 0 To NCol - 1
                If dt.Rows(NRow - 1)(Col).ToString IsNot DBNull.Value Then
                    Table.Cell(Fila + 2, Col + 1).Range.Text = dt.Rows(Fila)(Col).ToString
                End If
            Next
            'Incremento

        Next
        'Negrita y Kursiva Para Los Nombres De Los Campos
        Table.Rows.Item(1).Range.Font.Bold = True
        Table.Rows.Item(1).Range.Font.Italic = False
        Table.Rows.Item(1).Alignment = WdRowAlignment.wdAlignRowCenter

        For i As Integer = 1 To Table.Rows.Count
            Table.Rows.Item(i).Range.Font.Size = 6
        Next

        Table.AutoFitBehavior(WdAutoFitBehavior.wdAutoFitWindow)

        'Boder De La Tabla
        Table.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle
        Table.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle
        Table.Borders.InsideLineWidth = WdLineWidth.wdLineWidth050pt
        Table.Borders.InsideColor = WdColor.wdColorBlack
        Rng = Doc.Bookmarks.Item("\endofdoc").Range
        Rng.InsertParagraphAfter()

        Doc.Save()
        Doc.Close()
        ' Word = Nothing
        Word.Application.Quit()


    End Sub

    Private Sub BackgroundEstadodeCuenta_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundEstadodeCuenta.DoWork
        Dim comandoInformacion As SqlCommand
        Dim consultaInformacion As String
        Dim readerInformacion As SqlDataReader
        consultaInformacion = "select cred.*,ISNULL((select convert(varchar,ValorCarteraCmultas) from ValorCarteraXcreditoSati where fecha='" & dateDesde.Value.ToString("yyyy-MM-dd") & "' and idCredito=cred.id),'No existe')as SaldoInicial,
ISNULL((select Convert(varchar,ValorCarteraCmultas) from ValorCarteraXcreditoSati where fecha='" & dateHasta.Value.ToString("yyyy-MM-dd") & "' and idCredito=cred.id),'No existe')as SaldoFinal,
case when not exists (select id from conveniossac where idCredito=cred.id) then (isnull((select top 1 FechaPago from CalendarioNormal where id_credito=cred.id and estado='P' order by FechaPago asc),getdate()))
else isnull((select top 1 FechaPago from CalendarioConveniosSac where idConvenio=(select id from conveniossac where idcredito=cred.id) and estado='P' order by FechaPago asc),getdate()) end as FechaLimite,
case when not exists (select id from conveniossac where idCredito=cred.id) then (isnull((select top 1 FechaPago from CalendarioNormal where id_credito=cred.id and estado='P' order by FechaPago asc),getdate()))
else isnull((select top 1 FechaPago from CalendarioConveniosSac where idConvenio=(select id from conveniossac where idcredito=cred.id) and estado='P' order by FechaPago asc),getdate()) end as FechaCorte,
isnull((select TotalPendiente from ValorCarteraXcreditoSati where fecha='" & dateHasta.Value.ToString("yyyy-MM-dd") & "' and idCredito=cred.id ),0)as PagoMinimo,
isnull((select AbonadoSMultas from ValorCarteraXcreditoSati where fecha='" & dateHasta.Value.ToString("yyyy-MM-dd") & "' and idcredito=cred.id),0)as Pagado,
isnull((select vencidoNormal from ValorCarteraXcreditoSati where fecha='" & dateHasta.Value.ToString("yyyy-MM-dd") & "' and idcredito=cred.id),0)as Vencido from
(select id, nombre, pagare from credito where id='" & idCredito & "')cred"


        comandoInformacion = New SqlCommand
        comandoInformacion.Connection = conexionempresa
        comandoInformacion.CommandText = consultaInformacion
        readerInformacion = comandoInformacion.ExecuteReader
        If readerInformacion.HasRows Then
            While readerInformacion.Read
                If readerInformacion("SaldoInicial") = "No existe" Then
                    ExisteSaldoInicial = False

                ElseIf readerInformacion("SaldoFinal") = "No existe" Then
                    ExisteSaldoInicial = True
                    ExisteSaldoFinal = False
                Else
                    SaldoFinal = readerInformacion("SaldoFinal")
                    SaldoInicial = readerInformacion("SaldoInicial")

                    FechaLimite = readerInformacion("FechaLimite")
                    pagoMinimo = readerInformacion("PagoMinimo")
                    MontoPagado = readerInformacion("Pagado")
                    SaldoVencido = readerInformacion("Vencido")
                    Pagare = readerInformacion("pagare")
                    nombreCredito = readerInformacion("nombre")
                    FechaCorte = readerInformacion("fechacorte")
                    ExisteSaldoInicial = True

                    ExisteSaldoFinal = True
                End If




            End While
        Else
            ExisteSaldoInicial = False
            ExisteSaldoFinal = False

        End If



        If ExisteSaldoInicial = False Then
            EncontroRegistros = False
            Dim consultaSugiereFechaInicial As String
            Dim comandoSugiereFechaInicial As SqlCommand
            Dim readerSugiereFechaInicial As SqlDataReader
            consultaSugiereFechaInicial = "if exists (select top 1 fecha from ValorCarteraXcreditoSati where idCredito = '" & idCredito & "' and fecha <='" & dateDesde.Value.ToString("yyyy-MM-dd") & "' order by fecha desc)
                                           begin
                                           select top 1 fecha from ValorCarteraXcreditoSati where idCredito = '" & idCredito & "'  and fecha <='" & dateDesde.Value.ToString("yyyy-MM-dd") & "' order by fecha desc
                                           end
                                           else if exists(select top 1 fecha from ValorCarteraXcreditoSati where idCredito = '" & idCredito & "' and fecha >='" & dateDesde.Value.ToString("yyyy-MM-dd") & "' order by fecha asc)
                                           begin
                                           select top 1 fecha from ValorCarteraXcreditoSati where idCredito = '" & idCredito & "'  and fecha >='" & dateDesde.Value.ToString("yyyy-MM-dd") & "' order by fecha asc
                                           end
                                           else
                                           begin
                                           select 'Sin Registros' as fecha
                                           end"
            comandoSugiereFechaInicial = New SqlCommand
            comandoSugiereFechaInicial.Connection = conexionempresa
            comandoSugiereFechaInicial.CommandText = consultaSugiereFechaInicial
            readerSugiereFechaInicial = comandoSugiereFechaInicial.ExecuteReader
            If readerSugiereFechaInicial.HasRows Then
                While readerSugiereFechaInicial.Read
                    If readerSugiereFechaInicial("fecha").ToString <> "Sin Registros" Then
                        MessageBox.Show("La fecha inicial seleccionada no tiene ningún registro, te sugiero seleccionar la fecha " & readerSugiereFechaInicial("fecha"))
                    Else
                        MessageBox.Show(readerSugiereFechaInicial("fecha"))
                    End If
                End While
            End If

        ElseIf ExisteSaldoFinal = False Then
            EncontroRegistros = False
            Dim consultaSugiereFechaFinal As String
            Dim comandoSugiereFechaFinal As SqlCommand
            Dim readerSugiereFechaFinal As SqlDataReader
            consultaSugiereFechaFinal = "if exists (select top 1 fecha from ValorCarteraXcreditoSati where idCredito = '" & idCredito & "'  and fecha <='" & dateHasta.Value.ToString("yyyy-MM-dd") & "' order by fecha desc)
                                           begin
                                           select top 1 fecha from ValorCarteraXcreditoSati where idCredito = '" & idCredito & "' and fecha <='" & dateHasta.Value.ToString("yyyy-MM-dd") & "' order by fecha desc
                                           end
                                           else if exists(select top 1 fecha from ValorCarteraXcreditoSati where idCredito = '" & idCredito & "'  and fecha >='" & dateHasta.Value.ToString("yyyy-MM-dd") & "' order by fecha asc)
                                           begin
                                           select top 1 fecha from ValorCarteraXcreditoSati where idCredito = '" & idCredito & "' and fecha >='" & dateHasta.Value.ToString("yyyy-MM-dd") & "' order by fecha asc
                                           end
                                           else
                                           begin
                                           select 'Sin Registros' as fecha
                                           end"
            comandoSugiereFechaFinal = New SqlCommand
            comandoSugiereFechaFinal.Connection = conexionempresa
            comandoSugiereFechaFinal.CommandText = consultaSugiereFechaFinal
            readerSugiereFechaFinal = comandoSugiereFechaFinal.ExecuteReader
            If readerSugiereFechaFinal.HasRows Then
                While readerSugiereFechaFinal.Read
                    If readerSugiereFechaFinal("fecha").ToString <> "Sin Registros" Then
                        MessageBox.Show("La fecha final seleccionada no tiene ningún registro, te sugiero seleccionar la fecha " & readerSugiereFechaFinal("fecha"))
                    Else
                        MessageBox.Show(readerSugiereFechaFinal("fecha"))
                    End If
                End While
            End If

        Else
            Dim consultaComportamiento As String
            consultaComportamiento = "if  exists(select * from ConveniosSac where idCredito = " & idCredito & " and estado = 'A')
begin
declare @SQL varchar(max),@numero int,@TipoPago varchar(50),
@idPago int,
@Npago int,
@Monto money,
@Interes money,
@Abonado money,
@Pendiente money,
@FechaPago date,
@FechaUltimoPago date
set @SQL = 'select * from ('
declare Comportamiento cursor  LOCAL STATIC READ_ONLY FORWARD_ONLY for
select  ROW_NUMBER() OVER(ORDER BY fechapago ASC) AS Numero,EstadoDeCuenta.* from
(select 'Normal' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,convert(varchar,FechaUltimoPago,102) as FechaUltimoPago from CalendarioNormal where id_credito = " & idCredito & " and Estado = 'L'
union
select 'Creación de convenio' as TipoDePago,'','',DeudaCredito,Moratorios,'',TotalDeuda,'',Fecha from ConveniosSac where idCredito = " & idCredito & "
union
select 'Convenio' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,Fecha from CalendarioConveniosSac where idConvenio = (select id from ConveniosSac where idCredito = " & idCredito & " and CalendarioConveniosSac.Estado = 'L' ) ) EstadoDeCuenta  where 
(case TipoDePago when 'Normal' then FechaUltimoPago 
when 'Creación de convenio' then FechaPago 
when 'Convenio' then FechaUltimoPago 
when 'TicketC' then FechaPago 
when 'Cancelación de convenio' then FechaPago
when 'Pago por cancelación de convenio' then FechaPago
when 'Creación de reestructura' then FechaPago 
when 'Reestructura' then FechaUltimoPago 
when 'TicketR' then FechaPago end) between '" & dateDesde.Value.ToString("yyyy-MM-dd") & "' and '" & dateHasta.Value.ToString("yyyy-MM-dd") & "' order by FechaPago asc
open Comportamiento
fetch next from Comportamiento into @numero,@TipoPago ,
@idPago ,
@Npago,
@Monto ,
@Interes ,
@Abonado ,
@Pendiente ,
@FechaPago ,
@FechaUltimoPago 
while(@@fetch_status=0)
begin
if @TipoPago = 'Normal'
begin
set @SQL = concat(@SQL , 'select   ' ,char(39), @TipoPago ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago, ',char(39), @Npago ,char(39),' as Npago, ',char(39), @Monto ,char(39),' as Monto, ',char(39), @Interes ,char(39),' as Interes, ',char(39), @Abonado ,char(39),' as Abonado, ',char(39), @Pendiente ,char(39),' as Pendiente, convert(varchar,',char(39), @FechaPago ,char(39),',105) as FechaPago, ',char(39), @FechaUltimoPago ,char(39),' as FechaUltimoPago, ',char(39),char(39),' as Hora', ' Union ')
	if exists(select * from TicketDetalle inner join TipoDoc on TicketDetalle.TipoDoc = TipoDoc.id where idpago = @idPago and TipoDoc.Nombre = 'Pago' )
	begin
		set @SQL = concat(@SQL , ' select ' ,char(39), 'Ticket' ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago,', char(39),char(39),',ticketdetalle.pagonormal,ticketdetalle.intereses,', char(39),char(39),',',char(39),char(39),',',char(39),char(39),',ticketdetalle.fecha,hora from ticketdetalle inner join tipodoc on ticketdetalle.tipodoc = tipodoc.id inner join ticket on ticketdetalle.idticket = ticket.id where idpago = ',@idPago,' and tipodoc.nombre = ',char(39),'Pago',char(39),' Union ')

	end
end
if @TipoPago = 'Creación de Convenio'
begin
set @SQL = concat(@SQL , 'select   ' ,char(39), @TipoPago ,char(39), ' as TipoDePago,',char(39), '' ,char(39),' as Idpago, ',char(39), '' ,char(39),' as Npago, ',char(39), @Monto ,char(39),' as Monto, ',char(39), @Interes ,char(39),' as Interes, ',char(39), '' ,char(39),' as Abonado, ',char(39), '' ,char(39),' as Pendiente, convert(varchar,',char(39), @FechaPago ,char(39),',105) as FechaPago, ',char(39), '' ,char(39),' as FechaUltimopago, ',char(39),char(39),' as Hora', ' Union ')

end
if @TipoPago = 'Convenio'
begin
set @SQL = concat(@SQL , 'select  ' ,char(39), @TipoPago ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago, ',char(39), @Npago ,char(39),' as Npago, ',char(39), @Monto ,char(39),' as Monto, ',char(39), @Interes ,char(39),' as Interes, ',char(39), @Abonado ,char(39),' as Abonado, ',char(39), @Pendiente ,char(39),' as Pendiente, convert(varchar,',char(39), @FechaPago ,char(39),',105) as FechaPago, ',char(39), @FechaUltimoPago ,char(39),' as FechaUltimopago, ',char(39),char(39),' as Hora', ' Union ')
	if exists(select * from TicketDetalle inner join TipoDoc on TicketDetalle.TipoDoc = TipoDoc.id where idpago = @idPago and TipoDoc.Nombre = 'Convenio' )
	begin
		set @SQL = concat(@SQL , ' select   ' ,char(39), 'TicketC' ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago,', char(39),char(39),',ticketdetalle.pagonormal,ticketdetalle.intereses,', char(39),char(39),',',char(39),char(39),',','convert(varchar,ticketdetalle.fecha,23),',char(39),char(39),',hora from ticketdetalle inner join tipodoc on ticketdetalle.tipodoc = tipodoc.id inner join ticket on ticketdetalle.idticket = ticket.id where idpago = ',@idPago,' and tipodoc.nombre = ',char(39),'Convenio',char(39),' Union ')

	end

end


fetch next from Comportamiento into @numero,@TipoPago ,
@idPago ,
@Npago,
@Monto ,
@Interes ,
@Abonado ,
@Pendiente ,
@FechaPago ,
@FechaUltimoPago 
end
end


else if exists(select * from ticket where idcredito = " & idCredito & " and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio'))
begin

set @SQL = 'select * from ('
declare Comportamiento cursor  LOCAL STATIC READ_ONLY FORWARD_ONLY for
select  ROW_NUMBER() OVER(ORDER BY fechapago ASC) AS Numero,EstadoDeCuenta.* from
(select 'Normal' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,FechaUltimoPago from CalendarioNormal where id_credito = " & idCredito & " and Estado = 'L' and fechaultimopago <= (select fecha from conveniossac where idcredito = " & idCredito & ")
union
select 'Creación de convenio' as TipoDePago,'','',DeudaCredito,Moratorios,'',TotalDeuda,Fecha,'' from ConveniosSac where idCredito = " & idCredito & "
union
select 'Convenio' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,Fecha from CalendarioConveniosSac where idConvenio = (select id from ConveniosSac where idCredito = " & idCredito & ") and abonado <> 0 and fecha <= (select fecha from ticket where idcredito = " & idCredito & " and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio'))
union
select 'Cancelación de convenio' as TipoDePago,'','',PagoNormal,Intereses,'',Total,Fecha,'' from Ticket where idcredito = " & idCredito & " and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio')
union
	
select 'Normal' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,FechaUltimoPago from CalendarioNormal where id_credito = " & idCredito & " and 1= case when exists(select id from ReestructurasSac where idCredito = " & idCredito & ")  and idpago in (select idPago from CalendarioNormal where id_credito = " & idCredito & " and (fechaultimopago >= (select fecha from ticket where idcredito = " & idCredito & " and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio')))) then 1 
when not exists(select id from ReestructurasSac where idCredito = " & idCredito & ") and idpago in (select idPago from CalendarioNormal where id_credito = " & idCredito & " and (fechaultimopago >= (select fecha from ticket where idcredito = " & idCredito & " and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio'))) )  then 1
 end


union

select 'Creación de reestructura' as TipoDePago,'','',DeudaCredito,Moratorios,'',TotalDeuda,Fecha,'' from reestructurassac where idCredito = " & idCredito & "
union
select 'Reestructura' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,Fecha from calendarioreestructurassac where idConvenio = (select id from reestructurassac where idCredito = " & idCredito & ") and abonado <> 0 )estadodecuenta where 
(case TipoDePago when 'Normal' then FechaUltimoPago 
when 'Creación de convenio' then FechaPago 
when 'Convenio' then FechaUltimoPago 
when 'TicketC' then FechaPago 
when 'Cancelación de convenio' then FechaPago
when 'Pago por cancelación de convenio' then FechaPago
when 'Creación de reestructura' then FechaPago 
when 'Reestructura' then FechaUltimoPago 
when 'TicketR' then FechaPago end) between '2020-01-10' and '" & dateHasta.Value.ToString("yyyy-MM-dd") & "' 
order by  (case  when idPago in (select idPago from CalendarioNormal where id_credito = " & idCredito & " and Estado = 'L' and fechaultimopago <= (select fecha from conveniossac where idcredito = " & idCredito & ")) then 1   when TipoDePago = 'Creación de convenio' then 2 when TipoDePago = 'Convenio' then 3 when TipoDePago = 'Cancelación de convenio' then 4 when idpago in (select idPago from CalendarioNormal where id_credito = " & idCredito & " and (fechaultimopago >= (select fecha from ticket where idcredito = " & idCredito & " and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio')) or FechaUltimoPago = '1900-01-01')) then 5 when TipoDePago = 'Creación de reestructura' then 6 when TipoDePago = 'Reestructura' then 7  end )asc
open Comportamiento
fetch next from Comportamiento into @numero,@TipoPago ,
@idPago ,
@Npago,
@Monto ,
@Interes ,
@Abonado ,
@Pendiente ,
@FechaPago ,
@FechaUltimoPago 
while(@@fetch_status=0)
begin
if @TipoPago = 'Normal'
begin
set @SQL = concat(@SQL , 'select   ' ,char(39), @TipoPago ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago, ',char(39), @Npago ,char(39),' as Npago, ',char(39), @Monto ,char(39),' as Monto, ',char(39), @Interes ,char(39),' as Interes, ',char(39), @Abonado ,char(39),' as Abonado, ',char(39), @Pendiente ,char(39),' as Pendiente, ',char(39), @FechaPago ,char(39),' as FechaPago, ',char(39), @FechaUltimoPago ,char(39),' as FechaUltimoPago, ',char(39),char(39),' as Hora', ' Union ')
	if exists(select * from TicketDetalle inner join TipoDoc on TicketDetalle.TipoDoc = TipoDoc.id where idpago = @idPago and TipoDoc.Nombre = 'Pago' )
	begin
		set @SQL = concat(@SQL , ' select ' ,char(39), 'Ticket' ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago,', char(39),char(39),',ticketdetalle.pagonormal,ticketdetalle.intereses,', char(39),char(39),',',char(39),char(39),',','ticketdetalle.fecha,',char(39),char(39),',hora from ticketdetalle inner join tipodoc on ticketdetalle.tipodoc = tipodoc.id inner join ticket on ticketdetalle.idticket = ticket.id where idpago = ',@idPago,' and tipodoc.nombre = ',char(39),'Pago',char(39),' Union ')
			if exists(select * from TicketDetalle inner join TipoDoc on TicketDetalle.TipoDoc = TipoDoc.id where idpago = @idPago and TipoDoc.Nombre = 'Cancelación de Convenio')
			begin
			set @SQL = concat(@SQL , ' select ' ,char(39), 'Pago por cancelación de convenio' ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago,', char(39),char(39),',ticketdetalle.pagonormal,ticketdetalle.intereses,', char(39),char(39),',',char(39),char(39),',','ticketdetalle.fecha,',char(39),char(39),',hora from ticketdetalle inner join tipodoc on ticketdetalle.tipodoc = tipodoc.id inner join ticket on ticketdetalle.idticket = ticket.id where idpago = ',@idPago,' and tipodoc.nombre = ',char(39),'Cancelación de Convenio',char(39),' Union ')

			end
	end
	else if exists(select * from TicketDetalle inner join TipoDoc on TicketDetalle.TipoDoc = TipoDoc.id where idpago = @idPago and TipoDoc.Nombre = 'Cancelación de Convenio')
	begin
		set @SQL = concat(@SQL , ' select ' ,char(39), 'Pago por cancelación de convenio' ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago,', char(39),char(39),',ticketdetalle.pagonormal,ticketdetalle.intereses,', char(39),char(39),',',char(39),char(39),',','ticketdetalle.fecha,',char(39),char(39),',hora from ticketdetalle inner join tipodoc on ticketdetalle.tipodoc = tipodoc.id inner join ticket on ticketdetalle.idticket = ticket.id where idpago = ',@idPago,' and tipodoc.nombre = ',char(39),'Cancelación de Convenio',char(39),' Union ')

	end
end
if @TipoPago = 'Creación de Convenio'
begin
set @SQL = concat(@SQL , 'select   ' ,char(39), @TipoPago ,char(39), ' as TipoDePago,',char(39), '' ,char(39),' as Idpago, ',char(39), '' ,char(39),' as Npago, ',char(39), @Monto ,char(39),' as Monto, ',char(39), @Interes ,char(39),' as Interes, ',char(39), '' ,char(39),' as Abonado, ',char(39), '' ,char(39),' as Pendiente, ',char(39), @FechaPago ,char(39),' as FechaPago, ',char(39), '' ,char(39),' as FechaUltimopago, ',char(39),char(39),' as Hora', ' Union ')

end
if @TipoPago = 'Convenio'
begin
set @SQL = concat(@SQL , 'select  ' ,char(39), @TipoPago ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago, ',char(39), @Npago ,char(39),' as Npago, ',char(39), @Monto ,char(39),' as Monto, ',char(39), @Interes ,char(39),' as Interes, ',char(39), @Abonado ,char(39),' as Abonado, ',char(39), @Pendiente ,char(39),' as Pendiente, ',char(39), @FechaPago ,char(39),' as FechaPago, ',char(39), @FechaUltimoPago ,char(39),' as FechaUltimopago, ',char(39),char(39),' as Hora', ' Union ')
	if exists(select * from TicketDetalle inner join TipoDoc on TicketDetalle.TipoDoc = TipoDoc.id where idpago = @idPago and TipoDoc.Nombre = 'Convenio' )
	begin
		set @SQL = concat(@SQL , ' select   ' ,char(39), 'TicketC' ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago,', char(39),char(39),',ticketdetalle.pagonormal,ticketdetalle.intereses,', char(39),char(39),',',char(39),char(39),',','ticketdetalle.fecha,',char(39),char(39),',hora from ticketdetalle inner join tipodoc on ticketdetalle.tipodoc = tipodoc.id inner join ticket on ticketdetalle.idticket = ticket.id where idpago = ',@idPago,' and tipodoc.nombre = ',char(39),'Convenio',char(39),' Union ')

	end

end


if @TipoPago = 'Cancelación de convenio'
begin
set @SQL = concat(@SQL , 'select   ' ,char(39), @TipoPago ,char(39), ' as TipoDePago,',char(39), '' ,char(39),' as Idpago, ',char(39), '' ,char(39),' as Npago, ',char(39), @Monto ,char(39),' as Monto, ',char(39), @Interes ,char(39),' as Interes, ',char(39), '' ,char(39),' as Abonado, ',char(39), '' ,char(39),' as Pendiente, ',char(39), @FechaPago ,char(39),' as FechaPago, ',char(39), '' ,char(39),' as FechaUltimopago, ',char(39),char(39),' as Hora', ' Union ')

end

if @TipoPago = 'Creación de reestructura'
begin
set @SQL = concat(@SQL , 'select   ' ,char(39), @TipoPago ,char(39), ' as TipoDePago,',char(39), '' ,char(39),' as Idpago, ',char(39), '' ,char(39),' as Npago, ',char(39), @Monto ,char(39),' as Monto, ',char(39), @Interes ,char(39),' as Interes, ',char(39), '' ,char(39),' as Abonado, ',char(39), '' ,char(39),' as Pendiente, ',char(39), @FechaPago ,char(39),' as FechaPago, ',char(39), '' ,char(39),' as FechaUltimopago, ',char(39),char(39),' as Hora', ' Union ')

end


if @TipoPago = 'Reestructura'
begin
set @SQL = concat(@SQL , 'select  ' ,char(39), @TipoPago ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago, ',char(39), @Npago ,char(39),' as Npago, ',char(39), @Monto ,char(39),' as Monto, ',char(39), @Interes ,char(39),' as Interes, ',char(39), @Abonado ,char(39),' as Abonado, ',char(39), @Pendiente ,char(39),' as Pendiente, ',char(39), @FechaPago ,char(39),' as FechaPago, ',char(39), @FechaUltimoPago ,char(39),' as FechaUltimopago, ',char(39),char(39),' as Hora', ' Union ')
	if exists(select * from TicketDetalle inner join TipoDoc on TicketDetalle.TipoDoc = TipoDoc.id where idpago = @idPago and TipoDoc.Nombre = 'Reestructura' )
	begin
		set @SQL = concat(@SQL , ' select   ' ,char(39), 'TicketR' ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago,', char(39),char(39),',ticketdetalle.pagonormal,ticketdetalle.intereses,', char(39),char(39),',',char(39),char(39),',','ticketdetalle.fecha,',char(39),char(39),',hora from ticketdetalle inner join tipodoc on ticketdetalle.tipodoc = tipodoc.id inner join ticket on ticketdetalle.idticket = ticket.id where idpago = ',@idPago,' and tipodoc.nombre = ',char(39),'Reestructura',char(39),' Union ')

	end

end



fetch next from Comportamiento into @numero,@TipoPago ,
@idPago ,
@Npago,
@Monto ,
@Interes ,
@Abonado ,
@Pendiente ,
@FechaPago ,
@FechaUltimoPago 
end
end




else if not exists(select * from ConveniosSac where idCredito = " & idCredito & ")
begin

set @SQL = 'select * from ('
declare Comportamiento cursor  LOCAL STATIC READ_ONLY FORWARD_ONLY for
select  ROW_NUMBER() OVER(ORDER BY fechapago ASC) AS Numero,EstadoDeCuenta.* from
(select 'Normal' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,FechaUltimoPago from CalendarioNormal where id_credito = " & idCredito & " and Estado = 'L' 
union
select 'Creación de convenio' as TipoDePago,'','',DeudaCredito,Moratorios,'',TotalDeuda,Fecha,'' from ConveniosSac where idCredito = " & idCredito & "
union
select 'Convenio' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,Fecha from CalendarioConveniosSac where idConvenio = (select id from ConveniosSac where idCredito = " & idCredito & " and CalendarioConveniosSac.Estado = 'L') ) EstadoDeCuenta  where 
(case TipoDePago when 'Normal' then FechaUltimoPago 
when 'Creación de convenio' then FechaPago 
when 'Convenio' then FechaUltimoPago 
when 'TicketC' then FechaPago 
when 'Cancelación de convenio' then FechaPago
when 'Pago por cancelación de convenio' then FechaPago
when 'Creación de reestructura' then FechaPago 
when 'Reestructura' then FechaUltimoPago 
when 'TicketR' then FechaPago end) between '2020-01-10' and '2020-08-19'  order by FechaPago asc
open Comportamiento
fetch next from Comportamiento into @numero,@TipoPago ,
@idPago ,
@Npago,
@Monto ,
@Interes ,
@Abonado ,
@Pendiente ,
@FechaPago ,
@FechaUltimoPago 
while(@@fetch_status=0)
begin
if @TipoPago = 'Normal'
begin
set @SQL = concat(@SQL , 'select   ' ,char(39), @TipoPago ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago, ',char(39), @Npago ,char(39),' as Npago, ',char(39), @Monto ,char(39),' as Monto, ',char(39), @Interes ,char(39),' as Interes, ',char(39), @Abonado ,char(39),' as Abonado, ',char(39), @Pendiente ,char(39),' as Pendiente, ',char(39), @FechaPago ,char(39),' as FechaPago, ',char(39), @FechaUltimoPago ,char(39),' as FechaUltimopago, ',char(39),char(39),' as Hora', ' Union ')
	if exists(select * from TicketDetalle inner join TipoDoc on TicketDetalle.TipoDoc = TipoDoc.id where idpago = @idPago and TipoDoc.Nombre = 'Pago' )
	begin
		set @SQL = concat(@SQL , ' select ' ,char(39), 'Ticket' ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago,', char(39),char(39),',ticketdetalle.pagonormal,ticketdetalle.intereses,', char(39),char(39),',',char(39),char(39),',','ticketdetalle.fecha,',char(39),char(39),',hora from ticketdetalle inner join tipodoc on ticketdetalle.tipodoc = tipodoc.id inner join ticket on ticketdetalle.idticket = ticket.id where idpago = ',@idPago,' and tipodoc.nombre = ',char(39),'Pago',char(39),' Union ')

	end
end
fetch next from Comportamiento into @numero,@TipoPago ,
@idPago ,
@Npago,
@Monto ,
@Interes ,
@Abonado ,
@Pendiente ,
@FechaPago ,
@FechaUltimoPago 
end
end
close Comportamiento
deallocate comportamiento
if @sql <> ''
begin
Set @SQL = Left(@SQL , Len(@SQL) - 5)
end
else
begin
set @SQL = CONCAT(@sql,'select  ',char(39), '' ,char(39),' as TipoDePago,',char(39), '' ,char(39),' as idPago,',char(39), '' ,char(39),' as Npago,',char(39), '' ,char(39),' as Monto,',char(39), '' ,char(39),' as Interes,',char(39), '' ,char(39),' as Abonado,',char(39), '' ,char(39),' as Pendiente,',char(39), '' ,char(39),' as FechaPago,',char(39), '' ,char(39),' as FechaUltimoPago,',char(39), '' ,char(39),' as Hora  ')
end



--set @SQL = CONCAT(@SQL,') estadocuenta group by idpago,npago,monto,interes,abonado,pendiente,fechapago,fechaultimopago,hora,tipodepago order by  (case tipodepago when ',char(39), 'Creación de reestructura' ,char(39),'  then idpago when  ',char(39), 'Convenio' ,char(39),' then idpago when ',char(39), 'TicketC' ,char(39),' then idpago when ',char(39), 'Creación de Convenio' ,char(39),'  then idpago   end ) asc, idpago,fechapago,hora asc')
set @SQL = CONCAT(@SQL,') estadocuenta group by idpago,npago,monto,interes,abonado,pendiente,fechapago,fechaultimopago,hora,tipodepago order by  (case  when idPago in (select idPago from CalendarioNormal where id_credito = " & idCredito & " and Estado =',char(39),'L',char(39),' and fechaultimopago <= (select fecha from conveniossac where idcredito = " & idCredito & ")) then 1   when TipoDePago = ',char(39), 'Creación de Convenio' ,char(39),' then 2 when TipoDePago = ',char(39), 'Convenio' ,char(39),' or TipoDePago = ',char(39), 'TicketC' ,char(39),' then 3 when TipoDePago = ',char(39), 'Cancelación de convenio' ,char(39),' then 4 when idpago in (select idPago from CalendarioNormal where id_credito = " & idCredito & " and (fechaultimopago >= (select fecha from ticket where idcredito = " & idCredito & " and tipodoc = (select id from tipodoc where nombre = ',char(39), 'Cancelación de convenio' ,char(39),')) or FechaUltimoPago = ',char(39), '1900-01-01' ,char(39),')) then 5 when TipoDePago = ',char(39), 'Creación de reestructura' ,char(39),' then 6 when TipoDePago = ',char(39), 'Reestructura' ,char(39),' or TipoDePago = ',char(39), 'TicketR' ,char(39),' then 7  end ) asc, idpago,fechapago,hora asc')
--set @SQL = CONCAT(@SQL,') estadocuenta  ')

print @sql
if @SQL <> ') estadocuenta group by idpago,tipodepago order by (case tipodepago wh) fechapago,hora desc'
begin
--Execute (@SQL)
select @sql
end
"
            adapterComportamiento = New SqlDataAdapter(consultaComportamiento, conexionempresa)
            dataComportamiento = New Data.DataTable
            adapterComportamiento.Fill(dataComportamiento)
            MessageBox.Show(dateDesde.Value.ToString("yyyy-MM-dd"))

            EncontroRegistros = True

            dataTableToWord(dataComportamiento)

        End If


    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        ncargando = New Cargando
        ncargando.Show()
        ncargando.MonoFlat_Label1.Text = "Generando Estado de Cuenta"
        If CheckGeneral.Checked Then
            BackgroundGeneral.RunWorkerAsync()
        Else
            BackgroundEstadodeCuenta.RunWorkerAsync()
        End If


    End Sub

    Private Sub BackgroundEstadodeCuenta_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundEstadodeCuenta.RunWorkerCompleted
        If EncontroRegistros Then
            Dim documento As DocX = DocX.Load("C:\ConfiaAdmin\SATI\TEMPDOCS\TempEstadodeCuenta.docx")
            documento.ReplaceText("%IDCREDITO%", idCredito)
            documento.ReplaceText("%SALDOINICIALCORTE%", FormatCurrency(SaldoInicial, 2))
            documento.ReplaceText("%SALDOFINALCORTE%", FormatCurrency(SaldoFinal, 2))
            documento.ReplaceText("%PAGOMINIMO%", FormatCurrency(pagoMinimo, 2))
            documento.ReplaceText("%PAGADO%", FormatCurrency(MontoPagado, 2))
            documento.ReplaceText("%FECHAIMPRESION%", Now.Date.ToString("yyyy-MM-dd"))
            documento.ReplaceText("%VENCIDO%", FormatCurrency(pagoMinimo, 2))
            documento.ReplaceText("%FECHALIMITE%", FechaLimite)
            If FechaCorte = Now Then
                documento.ReplaceText("%FECHACORTE%", FechaCorte)
            Else
                documento.ReplaceText("%FECHACORTE%", FechaCorte.AddDays(-1))
            End If
            documento.ReplaceText("%NOMBRECLIENTE%", nombreCredito)
            documento.ReplaceText("%MONTOCREDITO%", FormatCurrency(Pagare, 2))
            documento.ReplaceText("%PERIODO%", "del " & GeneraDateString(dateDesde.Value.Day, dateDesde.Value.Month, dateDesde.Value.Year) & " al " & GeneraDateString(dateHasta.Value.Day, dateHasta.Value.Month, dateHasta.Value.Year))
            documento.ReplaceText("%DIASPERIODO%", DateDiff(DateInterval.Day, dateDesde.Value, dateHasta.Value))
            Dim para As String
            para = "Nota: *Cuando la fecha de pago corresponda a un día inhábil, el pago podrá efectuarse sin cargo adicional alguno el día hábil siguiente.

*Para solicitudes, aclaraciones o reclamaciones favor de comunicarse a la siguiente dirección, dentro de 90 días naturales Contados a partir de la fecha de la operación de que se trate.
Contacto: Omar Enrique Paniahua Ambriz 
Número telefónico de la oficina 01 (452) 52 4 43 91
correo: opaniahua@prestamosconfia.com

Procuraduría Federal del Consumidor
www.gob.mx/profeco; teléfono 01 800 468 87 22)
"
            documento.InsertParagraph(para).Bold.FontSize(9).Alignment = Alignment.center
            documento.Save()
            documento.Dispose()
            Dim spDoc As New Spire.Doc.Document
            spDoc.LoadFromFile("C:\ConfiaAdmin\SATI\TEMPDOCS\TempEstadodeCuenta.docx")
            Dim dialog As New PrintPreviewDialog

            ' dialog.AllowCurrentPage = True
            ' dialog.AllowSomePages = True
            ' dialog.UseEXDialog = True


            Try
                '  spDoc.PrintDialog = dialog.
                spDoc.PrintDocument.PrinterSettings.PrinterName = ImpresoraPredeterminada

                dialog.Document = spDoc.PrintDocument
                dialog.ShowDialog()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            ncargando.Close()
            ncargando.Close()
        Else
            MessageBox.Show("No se encontraron registros con esas fechas, marca la opción Estado de cuenta general")
            ncargando.Close()
        End If

    End Sub

    Private Function GeneraDateString(ByVal dia As Integer, ByVal mes As Integer, ByVal año As Integer) As String
        Dim dateString As String
        Dim diaString, mesString, añoString As String
        Select Case dia
            Case 1
                diaString = "Lunes"
            Case 2
                diaString = "Martes"
            Case 3
                diaString = "Miércoles"
            Case 4
                diaString = "Jueves"
            Case 5
                diaString = "Viernes"
            Case 6
                diaString = "Sábado"
            Case 7
                diaString = "Domingo"

        End Select

        Select Case mes
            Case 1
                mesString = "Enero"
            Case 2
                mesString = "Febrero"
            Case 3
                mesString = "Marzo"
            Case 4
                mesString = "Abril"
            Case 5
                mesString = "Mayo"
            Case 6
                mesString = "Junio"
            Case 7
                mesString = "Julio"
            Case 8
                mesString = "Agosto"
            Case 9
                mesString = "Septiembre"
            Case 10
                mesString = "Octubre"
            Case 11
                mesString = "Noviembre"
            Case 12
                mesString = "Diciembre"

        End Select

        dateString = dia & " de " & mesString & " del " & año
        Return dateString

    End Function

    Private Sub BackgroundGeneral_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundGeneral.RunWorkerCompleted
        Dim documento As DocX = DocX.Load("C:\ConfiaAdmin\SATI\TEMPDOCS\TempEstadodeCuenta.docx")
        documento.ReplaceText("%IDCREDITO%", idCredito)
        documento.ReplaceText("%SALDOINICIALCORTE%", FormatCurrency(SaldoInicial, 2))
        documento.ReplaceText("%SALDOFINALCORTE%", FormatCurrency(SaldoFinal, 2))
        documento.ReplaceText("%PAGOMINIMO%", FormatCurrency(pagoMinimo, 2))
        documento.ReplaceText("%PAGADO%", FormatCurrency(MontoPagado, 2))
        documento.ReplaceText("%FECHAIMPRESION%", Now.Date.ToString("yyyy-MM-dd"))
        documento.ReplaceText("%VENCIDO%", FormatCurrency(pagoMinimo, 2))
        documento.ReplaceText("%FECHALIMITE%", FechaLimite)
        If FechaCorte = Now Then
            documento.ReplaceText("%FECHACORTE%", FechaCorte)
        Else
            documento.ReplaceText("%FECHACORTE%", FechaCorte.AddDays(-1))
        End If

        documento.ReplaceText("%NOMBRECLIENTE%", nombreCredito)
        documento.ReplaceText("%MONTOCREDITO%", FormatCurrency(Pagare, 2))
        documento.ReplaceText("%PERIODO%", "del " & GeneraDateString(Now.Date.Day, Now.Date.Month, Now.Date.Year) & " al " & GeneraDateString(Now.Date.Day, Now.Date.Month, Now.Date.Year))
        documento.ReplaceText("%DIASPERIODO%", DateDiff(DateInterval.Day, dateDesde.Value, dateHasta.Value))
        Dim para As String
        para = "Nota: *Cuando la fecha de pago corresponda a un día inhábil, el pago podrá efectuarse sin cargo adicional alguno el día hábil siguiente.

*Para solicitudes, aclaraciones o reclamaciones favor de comunicarse a la siguiente dirección, dentro de 90 días naturales Contados a partir de la fecha de la operación de que se trate.
Contacto: Omar Enrique Paniahua Ambriz 
Número telefónico de la oficina 01 (452) 52 4 43 91
correo: opaniahua@prestamosconfia.com

Procuraduría Federal del Consumidor
www.gob.mx/profeco; teléfono 01 800 468 87 22)
"
        documento.InsertParagraph(para).Bold.FontSize(9).Alignment = Alignment.center
        documento.Save()
        documento.Dispose()

        Dim spDoc As New Spire.Doc.Document
        spDoc.LoadFromFile("C:\ConfiaAdmin\SATI\TEMPDOCS\TempEstadodeCuenta.docx")
        Dim dialog As New PrintPreviewDialog

        ' dialog.AllowCurrentPage = True
        ' dialog.AllowSomePages = True
        ' dialog.UseEXDialog = True


        Try
            '  spDoc.PrintDialog = dialog.
            spDoc.PrintDocument.PrinterSettings.PrinterName = ImpresoraPredeterminada

            dialog.Document = spDoc.PrintDocument
            dialog.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ncargando.Close()
    End Sub
End Class