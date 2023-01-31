using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Xceed.Words.NET;

namespace ConfiaAdmin
{

    public partial class EstadoDeCuenta
    {
        private System.Data.DataTable dataComportamiento;

        private SqlDataAdapter adapterComportamiento;
        public int idCredito;
        private Cargando ncargando;
        private double pagoMinimo, montoCredito, MontoPagado, SaldoVencido, SaldoInicial, SaldoFinal, Pagare;
        private DateTime FechaLimite, FechaCorte;
        private bool ExisteSaldoInicial, ExisteSaldoFinal, EncontroRegistros;

        public EstadoDeCuenta()
        {
            InitializeComponent();
        }

        private void BackgroundGeneral_DoWork(object sender, DoWorkEventArgs e)
        {
            SqlCommand comandoInformacion;
            string consultaInformacion;
            SqlDataReader readerInformacion;
            consultaInformacion = @"select nombre,id,pagare,AbonadoSinMultas,(pagare-AbonadoSinMultas) as valorCarteraSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,((Multas-(AbonadoMultasL+AbonadoMultasV))+(pagare-AbonadoSinMultas)) as ValorCarteraConMultas, case when carteratotal.Estado = 'C' then
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
(select credito.nombre,Credito.id,Credito.idgestor,Credito.IdPromotor,credito.Estado from Credito inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito where Credito.id = '" + idCredito + @"' group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal order by nombre asc";


            comandoInformacion = new SqlCommand();
            comandoInformacion.Connection = Module1.conexionempresa;
            comandoInformacion.CommandText = consultaInformacion;
            readerInformacion = comandoInformacion.ExecuteReader();
            if (readerInformacion.HasRows)
            {
                while (readerInformacion.Read())
                {
                    SaldoFinal = Conversions.ToDouble(readerInformacion["TotalPendiente"]);
                    SaldoInicial = Conversions.ToDouble(readerInformacion["TotalPendiente"]);

                    FechaLimite = Conversions.ToDate(readerInformacion["FechaLimite"]);
                    pagoMinimo = Conversions.ToDouble(readerInformacion["TotalPendiente"]);
                    MontoPagado = Conversions.ToDouble(readerInformacion["AbonadoSinMultas"]);
                    SaldoVencido = Conversions.ToDouble(readerInformacion["VencidoNormal"]);
                    Pagare = Conversions.ToDouble(readerInformacion["pagare"]);
                    nombreCredito = Conversions.ToString(readerInformacion["nombre"]);
                    FechaCorte = Conversions.ToDate(readerInformacion["fechalimite"]);
                    ExisteSaldoInicial = true;

                    ExisteSaldoFinal = true;
                }


            }


            string consultaComportamiento;
            consultaComportamiento = "if  exists(select * from ConveniosSac where idCredito = " + idCredito + @" and estado = 'A')
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
(select 'Normal' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,FechaUltimoPago from CalendarioNormal where id_credito = " + idCredito + @" and Estado = 'L'
union
select 'Creación de convenio' as TipoDePago,'','',DeudaCredito,Moratorios,'',TotalDeuda,Fecha,'' from ConveniosSac where idCredito = " + idCredito + @"
union
select 'Convenio' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,Fecha from CalendarioConveniosSac where idConvenio = (select id from ConveniosSac where idCredito = " + idCredito + @" and calendarioconveniossac.abonado <> 0 ) ) EstadoDeCuenta  order by FechaPago asc
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
	if exists(select * from TicketDetalle inner join TipoDoc on TicketDetalle.TipoDoc = TipoDoc.id where idpago = @idPago and TipoDoc.Nombre = 'Pago' and ticketdetalle.estado = 'A' )
	begin
		set @SQL = concat(@SQL , ' select ' ,char(39), 'Ticket' ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago,', char(39),char(39),',ticketdetalle.pagonormal,ticketdetalle.intereses,', char(39),char(39),',',char(39),char(39),',','ticketdetalle.fecha,',char(39),char(39),',hora from ticketdetalle inner join tipodoc on ticketdetalle.tipodoc = tipodoc.id inner join ticket on ticketdetalle.idticket = ticket.id where idpago = ',@idPago,' and tipodoc.nombre = ',char(39),'Pago',char(39),' and ticketdetalle.estado = ',char(39),'A',char(39),' Union ')

	end
end
if @TipoPago = 'Creación de Convenio'
begin
set @SQL = concat(@SQL , 'select   ' ,char(39), @TipoPago ,char(39), ' as TipoDePago,',char(39), '' ,char(39),' as Idpago, ',char(39), '' ,char(39),' as Npago, ',char(39), @Monto ,char(39),' as Monto, ',char(39), @Interes ,char(39),' as Interes, ',char(39), '' ,char(39),' as Abonado, ',char(39), '' ,char(39),' as Pendiente, ',char(39), @FechaPago ,char(39),' as FechaPago, ',char(39), '' ,char(39),' as FechaUltimopago, ',char(39),char(39),' as Hora', ' Union ')

end
if @TipoPago = 'Convenio'
begin
set @SQL = concat(@SQL , 'select  ' ,char(39), @TipoPago ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago, ',char(39), @Npago ,char(39),' as Npago, ',char(39), @Monto ,char(39),' as Monto, ',char(39), @Interes ,char(39),' as Interes, ',char(39), @Abonado ,char(39),' as Abonado, ',char(39), @Pendiente ,char(39),' as Pendiente, ',char(39), @FechaPago ,char(39),' as FechaPago, ',char(39), @FechaUltimoPago ,char(39),' as FechaUltimopago, ',char(39),char(39),' as Hora', ' Union ')
	if exists(select * from TicketDetalle inner join TipoDoc on TicketDetalle.TipoDoc = TipoDoc.id where idpago = @idPago and TipoDoc.Nombre = 'Convenio' and ticketdetalle.estado = 'A' )
	begin
		set @SQL = concat(@SQL , ' select   ' ,char(39), 'TicketC' ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago,', char(39),char(39),',ticketdetalle.pagonormal,ticketdetalle.intereses,', char(39),char(39),',',char(39),char(39),',','ticketdetalle.fecha,',char(39),char(39),',hora from ticketdetalle inner join tipodoc on ticketdetalle.tipodoc = tipodoc.id inner join ticket on ticketdetalle.idticket = ticket.id where idpago = ',@idPago,' and tipodoc.nombre = ',char(39),'Convenio',char(39),' and ticketdetalle.estado = ',char(39),'A',char(39),' Union ')

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


else if exists(select * from ticket where idcredito = " + idCredito + @" and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio') and estado = 'A')
begin

set @SQL = 'select * from ('
declare Comportamiento cursor  LOCAL STATIC READ_ONLY FORWARD_ONLY for
select  ROW_NUMBER() OVER(ORDER BY fechapago ASC) AS Numero,EstadoDeCuenta.* from
(select 'Normal' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,FechaUltimoPago from CalendarioNormal where id_credito = " + idCredito + " and Estado = 'L' and fechaultimopago <= (select fecha from conveniossac where idcredito = " + idCredito + @")
union
select 'Creación de convenio' as TipoDePago,'','',DeudaCredito,Moratorios,'',TotalDeuda,Fecha,'' from ConveniosSac where idCredito = " + idCredito + @"
union
select 'Convenio' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,Fecha from CalendarioConveniosSac where idConvenio = (select id from ConveniosSac where idCredito = " + idCredito + ") and abonado <> 0 and fecha <= (select fecha from ticket where idcredito = " + idCredito + @" and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio') and estado = 'A')
union
select 'Cancelación de convenio' as TipoDePago,'','',PagoNormal,Intereses,'',Total,Fecha,'' from Ticket where idcredito = " + idCredito + @" and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio') and estado = 'A'
union
	
select 'Normal' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,FechaUltimoPago from CalendarioNormal where id_credito = " + idCredito + " and 1= case when exists(select id from ReestructurasSac where idCredito = " + idCredito + ")  and idpago in (select idPago from CalendarioNormal where id_credito = " + idCredito + " and (fechaultimopago >= (select fecha from ticket where idcredito = " + idCredito + @" and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio') and estado = 'A'))) then 1 
when not exists(select id from ReestructurasSac where idCredito = " + idCredito + ") and idpago in (select idPago from CalendarioNormal where id_credito = " + idCredito + " and (fechaultimopago >= (select fecha from ticket where idcredito = " + idCredito + @" and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio') and estado = 'A')) )  then 1
 end


union

select 'Creación de reestructura' as TipoDePago,'','',DeudaCredito,Moratorios,'',TotalDeuda,Fecha,'' from reestructurassac where idCredito = " + idCredito + @"
union
select 'Reestructura' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,Fecha from calendarioreestructurassac where idConvenio = (select id from reestructurassac where idCredito = " + idCredito + ") and abonado <> 0 )estadodecuenta  order by  (case  when idPago in (select idPago from CalendarioNormal where id_credito = " + idCredito + " and Estado = 'L' and fechaultimopago <= (select fecha from conveniossac where idcredito = " + idCredito + ")) then 1   when TipoDePago = 'Creación de convenio' then 2 when TipoDePago = 'Convenio' then 3 when TipoDePago = 'Cancelación de convenio' then 4 when idpago in (select idPago from CalendarioNormal where id_credito = " + idCredito + " and (fechaultimopago >= (select fecha from ticket where idcredito = " + idCredito + @" and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio') and estado = 'A') or FechaUltimoPago = '1900-01-01')) then 5 when TipoDePago = 'Creación de reestructura' then 6 when TipoDePago = 'Reestructura' then 7  end )asc
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
	if exists(select * from TicketDetalle inner join TipoDoc on TicketDetalle.TipoDoc = TipoDoc.id where idpago = @idPago and TipoDoc.Nombre = 'Pago' and estado = 'A' )
	begin
		set @SQL = concat(@SQL , ' select ' ,char(39), 'Ticket' ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago,', char(39),char(39),',ticketdetalle.pagonormal,ticketdetalle.intereses,', char(39),char(39),',',char(39),char(39),',','ticketdetalle.fecha,',char(39),char(39),',hora from ticketdetalle inner join tipodoc on ticketdetalle.tipodoc = tipodoc.id inner join ticket on ticketdetalle.idticket = ticket.id where idpago = ',@idPago,' and tipodoc.nombre = ',char(39),'Pago',char(39),' and ticketdetalle.estado = ',char(39),'A',char(39), ' Union ')
			if exists(select * from TicketDetalle inner join TipoDoc on TicketDetalle.TipoDoc = TipoDoc.id where idpago = @idPago and TipoDoc.Nombre = 'Cancelación de Convenio' and estado = 'A')
			begin
			set @SQL = concat(@SQL , ' select ' ,char(39), 'Pago por cancelación de convenio' ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago,', char(39),char(39),',ticketdetalle.pagonormal,ticketdetalle.intereses,', char(39),char(39),',',char(39),char(39),',','ticketdetalle.fecha,',char(39),char(39),',hora from ticketdetalle inner join tipodoc on ticketdetalle.tipodoc = tipodoc.id inner join ticket on ticketdetalle.idticket = ticket.id where idpago = ',@idPago,' and tipodoc.nombre = ',char(39),'Cancelación de Convenio',char(39),' and ticket.estado = ',char(39),'A',char(39),' Union ')

			end
	end
	else if exists(select * from TicketDetalle inner join TipoDoc on TicketDetalle.TipoDoc = TipoDoc.id where idpago = @idPago and TipoDoc.Nombre = 'Cancelación de Convenio' and estado = 'A')
	begin
		set @SQL = concat(@SQL , ' select ' ,char(39), 'Pago por cancelación de convenio' ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago,', char(39),char(39),',ticketdetalle.pagonormal,ticketdetalle.intereses,', char(39),char(39),',',char(39),char(39),',','ticketdetalle.fecha,',char(39),char(39),',hora from ticketdetalle inner join tipodoc on ticketdetalle.tipodoc = tipodoc.id inner join ticket on ticketdetalle.idticket = ticket.id where idpago = ',@idPago,' and tipodoc.nombre = ',char(39),'Cancelación de Convenio',char(39),' and ticket.estado = ',char(39),'A',char(39),' Union ')

	end
end
if @TipoPago = 'Creación de Convenio'
begin
set @SQL = concat(@SQL , 'select   ' ,char(39), @TipoPago ,char(39), ' as TipoDePago,',char(39), '' ,char(39),' as Idpago, ',char(39), '' ,char(39),' as Npago, ',char(39), @Monto ,char(39),' as Monto, ',char(39), @Interes ,char(39),' as Interes, ',char(39), '' ,char(39),' as Abonado, ',char(39), '' ,char(39),' as Pendiente, ',char(39), @FechaPago ,char(39),' as FechaPago, ',char(39), '' ,char(39),' as FechaUltimopago, ',char(39),char(39),' as Hora', ' Union ')

end
if @TipoPago = 'Convenio'
begin
set @SQL = concat(@SQL , 'select  ' ,char(39), @TipoPago ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago, ',char(39), @Npago ,char(39),' as Npago, ',char(39), @Monto ,char(39),' as Monto, ',char(39), @Interes ,char(39),' as Interes, ',char(39), @Abonado ,char(39),' as Abonado, ',char(39), @Pendiente ,char(39),' as Pendiente, ',char(39), @FechaPago ,char(39),' as FechaPago, ',char(39), @FechaUltimoPago ,char(39),' as FechaUltimopago, ',char(39),char(39),' as Hora', ' Union ')
	if exists(select * from TicketDetalle inner join TipoDoc on TicketDetalle.TipoDoc = TipoDoc.id where idpago = @idPago and TipoDoc.Nombre = 'Convenio' and ticketdetalle.estado = 'A' )
	begin
		set @SQL = concat(@SQL , ' select   ' ,char(39), 'TicketC' ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago,', char(39),char(39),',ticketdetalle.pagonormal,ticketdetalle.intereses,', char(39),char(39),',',char(39),char(39),',','ticketdetalle.fecha,',char(39),char(39),',hora from ticketdetalle inner join tipodoc on ticketdetalle.tipodoc = tipodoc.id inner join ticket on ticketdetalle.idticket = ticket.id where idpago = ',@idPago,' and tipodoc.nombre = ',char(39),'Convenio',char(39),' and ticketdetalle.estado = ',char(39),'A',char(39), ' Union ')

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
	if exists(select * from TicketDetalle inner join TipoDoc on TicketDetalle.TipoDoc = TipoDoc.id where idpago = @idPago and TipoDoc.Nombre = 'Reestructura' and ticketdetalle.estado = 'A' )
	begin
		set @SQL = concat(@SQL , ' select   ' ,char(39), 'TicketR' ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago,', char(39),char(39),',ticketdetalle.pagonormal,ticketdetalle.intereses,', char(39),char(39),',',char(39),char(39),',','ticketdetalle.fecha,',char(39),char(39),',hora from ticketdetalle inner join tipodoc on ticketdetalle.tipodoc = tipodoc.id inner join ticket on ticketdetalle.idticket = ticket.id where idpago = ',@idPago,' and tipodoc.nombre = ',char(39),'Reestructura',char(39),' and ticketdetalle.estado = ',char(39),'A',char(39),' Union ')

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




else if not exists(select * from ConveniosSac where idCredito = " + idCredito + @")
begin

set @SQL = 'select * from ('
declare Comportamiento cursor  LOCAL STATIC READ_ONLY FORWARD_ONLY for
select  ROW_NUMBER() OVER(ORDER BY fechapago ASC) AS Numero,EstadoDeCuenta.* from
(select 'Normal' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,FechaUltimoPago from CalendarioNormal where id_credito = " + idCredito + @" and Estado = 'L' 
union
select 'Creación de convenio' as TipoDePago,'','',DeudaCredito,Moratorios,'',TotalDeuda,Fecha,'' from ConveniosSac where idCredito = " + idCredito + @"
union
select 'Convenio' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,Fecha from CalendarioConveniosSac where idConvenio = (select id from ConveniosSac where idCredito = " + idCredito + @" and CalendarioConveniosSac.Estado = 'L') ) EstadoDeCuenta  order by FechaPago asc
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
	if exists(select * from TicketDetalle inner join TipoDoc on TicketDetalle.TipoDoc = TipoDoc.id where idpago = @idPago and TipoDoc.Nombre = 'Pago' and ticketdetalle.estado = 'A' )
	begin
		set @SQL = concat(@SQL , ' select ' ,char(39), 'Ticket' ,char(39), ' as TipoDePago,',char(39), @idPago ,char(39),' as Idpago,', char(39),char(39),',ticketdetalle.pagonormal,ticketdetalle.intereses,', char(39),char(39),',',char(39),char(39),',','ticketdetalle.fecha,',char(39),char(39),',hora from ticketdetalle inner join tipodoc on ticketdetalle.tipodoc = tipodoc.id inner join ticket on ticketdetalle.idticket = ticket.id where idpago = ',@idPago,' and tipodoc.nombre = ',char(39),'Pago',char(39),' and ticketdetalle.estado = ',char(39),'A',char(39),' Union ')

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
set @SQL = CONCAT(@SQL,') estadocuenta group by idpago,npago,monto,interes,abonado,pendiente,fechapago,fechaultimopago,hora,tipodepago order by  (case  when idPago in (select idPago from CalendarioNormal where id_credito = " + idCredito + " and Estado =',char(39),'L',char(39),' and fechaultimopago <= (select fecha from conveniossac where idcredito = " + idCredito + ")) then 1   when TipoDePago = ',char(39), 'Creación de Convenio' ,char(39),' then 2 when TipoDePago = ',char(39), 'Convenio' ,char(39),' or TipoDePago = ',char(39), 'TicketC' ,char(39),' then 3 when TipoDePago = ',char(39), 'Cancelación de convenio' ,char(39),' then 4 when idpago in (select idPago from CalendarioNormal where id_credito = " + idCredito + " and (fechaultimopago >= (select fecha from ticket where idcredito = " + idCredito + @" and tipodoc = (select id from tipodoc where nombre = ',char(39), 'Cancelación de convenio' ,char(39),') and estado = ',char(39),'A',char(39),') or FechaUltimoPago = ',char(39), '1900-01-01' ,char(39),')) then 5 when TipoDePago = ',char(39), 'Creación de reestructura' ,char(39),' then 6 when TipoDePago = ',char(39), 'Reestructura' ,char(39),' or TipoDePago = ',char(39), 'TicketR' ,char(39),' then 7  end ) asc, idpago,fechapago,hora asc')
--set @SQL = CONCAT(@SQL,') estadocuenta  ')

print @sql
if @SQL <> ') estadocuenta group by idpago,tipodepago order by (case tipodepago wh) fechapago,hora desc'
begin
Execute (@SQL)
end
";
            adapterComportamiento = new SqlDataAdapter(consultaComportamiento, Module1.conexionempresa);
            dataComportamiento = new System.Data.DataTable();
            adapterComportamiento.Fill(dataComportamiento);




            dataTableToWord(dataComportamiento);



        }

        private string nombreCredito;

        private void EstadoDeCuenta_Load(object sender, EventArgs e)
        {
            dateDesde.Value = DateTime.Now;
            dateHasta.Value = DateTime.Now;

            ncargando = new Cargando();
            ncargando.Show();
            ncargando.MonoFlat_Label1.Text = "Cargando Información";
            BackgroundInformacion.RunWorkerAsync();

        }

        private void BackgroundInformacion_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();


        }

        private void BackgroundInformacion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ncargando.Close();

        }


        private void dataTableToWord(System.Data.DataTable dt)
        {
            Microsoft.Office.Interop.Word.Application Word;
            Document Doc;
            Microsoft.Office.Interop.Word.Table Table;
            Range Rng;
            Microsoft.Office.Interop.Word.Paragraph Prf1;
            Microsoft.Office.Interop.Word.Paragraph Prf2;
            Microsoft.Office.Interop.Word.Paragraph Prf3;

            Word = (Microsoft.Office.Interop.Word.Application)Interaction.CreateObject("Word.Application");

            FileSystem.FileCopy(@"C:\ConfiaAdmin\SATI\Estado de cuenta.docx", @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempEstadodeCuenta.docx");
            object argFileName = @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempEstadodeCuenta.docx";
            Doc = Word.Documents.Open(ref argFileName);
            int NCol = dt.Columns.Count;
            int NRow = dt.Rows.Count;
            // alternativo

            object argIndex = @"\endofdoc";
            Table = Doc.Tables.Add(Doc.Bookmarks[ref argIndex].Range, dt.Rows.Count + 1, dt.Columns.Count);

            // Agregando Los Campos De La Grilla
            for (int i = 1, loopTo = NCol; i <= loopTo; i++)
            {
                if (dt.Columns[i - 1].ColumnName.ToString() == "TipoDePago")
                {
                    Table.Cell(1, i).Range.Text = "Tipo de pago";
                }

                else if (dt.Columns[i - 1].ColumnName.ToString() == "Idpago")
                {
                    Table.Cell(1, i).Range.Text = "id Pago";
                }





                else if (dt.Columns[i - 1].ColumnName.ToString() == "Npago")
                {
                    Table.Cell(1, i).Range.Text = "No. de pago";
                }





                else if (dt.Columns[i - 1].ColumnName.ToString() == "Interes")
                {
                    Table.Cell(1, i).Range.Text = "Interés";
                }


                else if (dt.Columns[i - 1].ColumnName.ToString() == "FechaPago")
                {
                    Table.Cell(1, i).Range.Text = "Fecha de pago";
                }

                else if (dt.Columns[i - 1].ColumnName.ToString() == "FechaUltimoPago")
                {
                    Table.Cell(1, i).Range.Text = "Fecha de último pago";
                }
                else
                {
                    Table.Cell(1, i).Range.Text = dt.Columns[i - 1].ColumnName.ToString();
                }


            }
            // Agregando Los Registros A La Tabla
            for (int Fila = 0, loopTo1 = NRow - 1; Fila <= loopTo1; Fila++)
            {
                for (int Col = 0, loopTo2 = NCol - 1; Col <= loopTo2; Col++)
                {
                    if (!ReferenceEquals(dt.Rows[NRow - 1][Col].ToString(), DBNull.Value))
                    {
                        Table.Cell(Fila + 2, Col + 1).Range.Text = dt.Rows[Fila][Col].ToString();
                    }
                }
                // Incremento

            }
            // Negrita y Kursiva Para Los Nombres De Los Campos
            Table.Rows[1].Range.Font.Bold = Conversions.ToInteger(true);
            Table.Rows[1].Range.Font.Italic = Conversions.ToInteger(false);
            Table.Rows[1].Alignment = WdRowAlignment.wdAlignRowCenter;

            for (int i = 1, loopTo3 = Table.Rows.Count; i <= loopTo3; i++)
                Table.Rows[i].Range.Font.Size = 6f;

            Table.AutoFitBehavior(WdAutoFitBehavior.wdAutoFitWindow);

            // Boder De La Tabla
            Table.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
            Table.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
            Table.Borders.InsideLineWidth = WdLineWidth.wdLineWidth050pt;
            Table.Borders.InsideColor = WdColor.wdColorBlack;
            object argIndex1 = @"\endofdoc";
            Rng = Doc.Bookmarks[ref argIndex1].Range;
            Rng.InsertParagraphAfter();

            Doc.Save();
            Doc.Close();
            // Word = Nothing
            Word.Application.Quit();


        }

        private void BackgroundEstadodeCuenta_DoWork(object sender, DoWorkEventArgs e)
        {
            SqlCommand comandoInformacion;
            string consultaInformacion;
            SqlDataReader readerInformacion;
            consultaInformacion = "select cred.*,ISNULL((select convert(varchar,ValorCarteraCmultas) from ValorCarteraXcreditoSati where fecha='" + dateDesde.Value.ToString("yyyy-MM-dd") + @"' and idCredito=cred.id),'No existe')as SaldoInicial,
ISNULL((select Convert(varchar,ValorCarteraCmultas) from ValorCarteraXcreditoSati where fecha='" + dateHasta.Value.ToString("yyyy-MM-dd") + @"' and idCredito=cred.id),'No existe')as SaldoFinal,
case when not exists (select id from conveniossac where idCredito=cred.id) then (isnull((select top 1 FechaPago from CalendarioNormal where id_credito=cred.id and estado='P' order by FechaPago asc),getdate()))
else isnull((select top 1 FechaPago from CalendarioConveniosSac where idConvenio=(select id from conveniossac where idcredito=cred.id) and estado='P' order by FechaPago asc),getdate()) end as FechaLimite,
case when not exists (select id from conveniossac where idCredito=cred.id) then (isnull((select top 1 FechaPago from CalendarioNormal where id_credito=cred.id and estado='P' order by FechaPago asc),getdate()))
else isnull((select top 1 FechaPago from CalendarioConveniosSac where idConvenio=(select id from conveniossac where idcredito=cred.id) and estado='P' order by FechaPago asc),getdate()) end as FechaCorte,
isnull((select TotalPendiente from ValorCarteraXcreditoSati where fecha='" + dateHasta.Value.ToString("yyyy-MM-dd") + @"' and idCredito=cred.id ),0)as PagoMinimo,
isnull((select AbonadoSMultas from ValorCarteraXcreditoSati where fecha='" + dateHasta.Value.ToString("yyyy-MM-dd") + @"' and idcredito=cred.id),0)as Pagado,
isnull((select vencidoNormal from ValorCarteraXcreditoSati where fecha='" + dateHasta.Value.ToString("yyyy-MM-dd") + @"' and idcredito=cred.id),0)as Vencido from
(select id, nombre, pagare from credito where id='" + idCredito + "')cred";


            comandoInformacion = new SqlCommand();
            comandoInformacion.Connection = Module1.conexionempresa;
            comandoInformacion.CommandText = consultaInformacion;
            readerInformacion = comandoInformacion.ExecuteReader();
            if (readerInformacion.HasRows)
            {
                while (readerInformacion.Read())
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(readerInformacion["SaldoInicial"], "No existe", false)))
                    {
                        ExisteSaldoInicial = false;
                    }

                    else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(readerInformacion["SaldoFinal"], "No existe", false)))
                    {
                        ExisteSaldoInicial = true;
                        ExisteSaldoFinal = false;
                    }
                    else
                    {
                        SaldoFinal = Conversions.ToDouble(readerInformacion["SaldoFinal"]);
                        SaldoInicial = Conversions.ToDouble(readerInformacion["SaldoInicial"]);

                        FechaLimite = Conversions.ToDate(readerInformacion["FechaLimite"]);
                        pagoMinimo = Conversions.ToDouble(readerInformacion["PagoMinimo"]);
                        MontoPagado = Conversions.ToDouble(readerInformacion["Pagado"]);
                        SaldoVencido = Conversions.ToDouble(readerInformacion["Vencido"]);
                        Pagare = Conversions.ToDouble(readerInformacion["pagare"]);
                        nombreCredito = Conversions.ToString(readerInformacion["nombre"]);
                        FechaCorte = Conversions.ToDate(readerInformacion["fechacorte"]);
                        ExisteSaldoInicial = true;

                        ExisteSaldoFinal = true;
                    }




                }
            }
            else
            {
                ExisteSaldoInicial = false;
                ExisteSaldoFinal = false;

            }



            if (ExisteSaldoInicial == false)
            {
                EncontroRegistros = false;
                string consultaSugiereFechaInicial;
                SqlCommand comandoSugiereFechaInicial;
                SqlDataReader readerSugiereFechaInicial;
                consultaSugiereFechaInicial = "if exists (select top 1 fecha from ValorCarteraXcreditoSati where idCredito = '" + idCredito + "' and fecha <='" + dateDesde.Value.ToString("yyyy-MM-dd") + @"' order by fecha desc)
                                           begin
                                           select top 1 fecha from ValorCarteraXcreditoSati where idCredito = '" + idCredito + "'  and fecha <='" + dateDesde.Value.ToString("yyyy-MM-dd") + @"' order by fecha desc
                                           end
                                           else if exists(select top 1 fecha from ValorCarteraXcreditoSati where idCredito = '" + idCredito + "' and fecha >='" + dateDesde.Value.ToString("yyyy-MM-dd") + @"' order by fecha asc)
                                           begin
                                           select top 1 fecha from ValorCarteraXcreditoSati where idCredito = '" + idCredito + "'  and fecha >='" + dateDesde.Value.ToString("yyyy-MM-dd") + @"' order by fecha asc
                                           end
                                           else
                                           begin
                                           select 'Sin Registros' as fecha
                                           end";
                comandoSugiereFechaInicial = new SqlCommand();
                comandoSugiereFechaInicial.Connection = Module1.conexionempresa;
                comandoSugiereFechaInicial.CommandText = consultaSugiereFechaInicial;
                readerSugiereFechaInicial = comandoSugiereFechaInicial.ExecuteReader();
                if (readerSugiereFechaInicial.HasRows)
                {
                    while (readerSugiereFechaInicial.Read())
                    {
                        if (readerSugiereFechaInicial["fecha"].ToString() != "Sin Registros")
                        {
                            MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("La fecha inicial seleccionada no tiene ningún registro, te sugiero seleccionar la fecha ", readerSugiereFechaInicial["fecha"])));
                        }
                        else
                        {
                            MessageBox.Show(Conversions.ToString(readerSugiereFechaInicial["fecha"]));
                        }
                    }
                }
            }

            else if (ExisteSaldoFinal == false)
            {
                EncontroRegistros = false;
                string consultaSugiereFechaFinal;
                SqlCommand comandoSugiereFechaFinal;
                SqlDataReader readerSugiereFechaFinal;
                consultaSugiereFechaFinal = "if exists (select top 1 fecha from ValorCarteraXcreditoSati where idCredito = '" + idCredito + "'  and fecha <='" + dateHasta.Value.ToString("yyyy-MM-dd") + @"' order by fecha desc)
                                           begin
                                           select top 1 fecha from ValorCarteraXcreditoSati where idCredito = '" + idCredito + "' and fecha <='" + dateHasta.Value.ToString("yyyy-MM-dd") + @"' order by fecha desc
                                           end
                                           else if exists(select top 1 fecha from ValorCarteraXcreditoSati where idCredito = '" + idCredito + "'  and fecha >='" + dateHasta.Value.ToString("yyyy-MM-dd") + @"' order by fecha asc)
                                           begin
                                           select top 1 fecha from ValorCarteraXcreditoSati where idCredito = '" + idCredito + "' and fecha >='" + dateHasta.Value.ToString("yyyy-MM-dd") + @"' order by fecha asc
                                           end
                                           else
                                           begin
                                           select 'Sin Registros' as fecha
                                           end";
                comandoSugiereFechaFinal = new SqlCommand();
                comandoSugiereFechaFinal.Connection = Module1.conexionempresa;
                comandoSugiereFechaFinal.CommandText = consultaSugiereFechaFinal;
                readerSugiereFechaFinal = comandoSugiereFechaFinal.ExecuteReader();
                if (readerSugiereFechaFinal.HasRows)
                {
                    while (readerSugiereFechaFinal.Read())
                    {
                        if (readerSugiereFechaFinal["fecha"].ToString() != "Sin Registros")
                        {
                            MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("La fecha final seleccionada no tiene ningún registro, te sugiero seleccionar la fecha ", readerSugiereFechaFinal["fecha"])));
                        }
                        else
                        {
                            MessageBox.Show(Conversions.ToString(readerSugiereFechaFinal["fecha"]));
                        }
                    }
                }
            }

            else
            {
                string consultaComportamiento;
                consultaComportamiento = "if  exists(select * from ConveniosSac where idCredito = " + idCredito + @" and estado = 'A')
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
(select 'Normal' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,convert(varchar,FechaUltimoPago,102) as FechaUltimoPago from CalendarioNormal where id_credito = " + idCredito + @" and Estado = 'L'
union
select 'Creación de convenio' as TipoDePago,'','',DeudaCredito,Moratorios,'',TotalDeuda,'',Fecha from ConveniosSac where idCredito = " + idCredito + @"
union
select 'Convenio' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,Fecha from CalendarioConveniosSac where idConvenio = (select id from ConveniosSac where idCredito = " + idCredito + @" and CalendarioConveniosSac.Estado = 'L' ) ) EstadoDeCuenta  where 
(case TipoDePago when 'Normal' then FechaUltimoPago 
when 'Creación de convenio' then FechaPago 
when 'Convenio' then FechaUltimoPago 
when 'TicketC' then FechaPago 
when 'Cancelación de convenio' then FechaPago
when 'Pago por cancelación de convenio' then FechaPago
when 'Creación de reestructura' then FechaPago 
when 'Reestructura' then FechaUltimoPago 
when 'TicketR' then FechaPago end) between '" + dateDesde.Value.ToString("yyyy-MM-dd") + "' and '" + dateHasta.Value.ToString("yyyy-MM-dd") + @"' order by FechaPago asc
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


else if exists(select * from ticket where idcredito = " + idCredito + @" and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio'))
begin

set @SQL = 'select * from ('
declare Comportamiento cursor  LOCAL STATIC READ_ONLY FORWARD_ONLY for
select  ROW_NUMBER() OVER(ORDER BY fechapago ASC) AS Numero,EstadoDeCuenta.* from
(select 'Normal' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,FechaUltimoPago from CalendarioNormal where id_credito = " + idCredito + " and Estado = 'L' and fechaultimopago <= (select fecha from conveniossac where idcredito = " + idCredito + @")
union
select 'Creación de convenio' as TipoDePago,'','',DeudaCredito,Moratorios,'',TotalDeuda,Fecha,'' from ConveniosSac where idCredito = " + idCredito + @"
union
select 'Convenio' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,Fecha from CalendarioConveniosSac where idConvenio = (select id from ConveniosSac where idCredito = " + idCredito + ") and abonado <> 0 and fecha <= (select fecha from ticket where idcredito = " + idCredito + @" and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio'))
union
select 'Cancelación de convenio' as TipoDePago,'','',PagoNormal,Intereses,'',Total,Fecha,'' from Ticket where idcredito = " + idCredito + @" and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio')
union
	
select 'Normal' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,FechaUltimoPago from CalendarioNormal where id_credito = " + idCredito + " and 1= case when exists(select id from ReestructurasSac where idCredito = " + idCredito + ")  and idpago in (select idPago from CalendarioNormal where id_credito = " + idCredito + " and (fechaultimopago >= (select fecha from ticket where idcredito = " + idCredito + @" and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio')))) then 1 
when not exists(select id from ReestructurasSac where idCredito = " + idCredito + ") and idpago in (select idPago from CalendarioNormal where id_credito = " + idCredito + " and (fechaultimopago >= (select fecha from ticket where idcredito = " + idCredito + @" and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio'))) )  then 1
 end


union

select 'Creación de reestructura' as TipoDePago,'','',DeudaCredito,Moratorios,'',TotalDeuda,Fecha,'' from reestructurassac where idCredito = " + idCredito + @"
union
select 'Reestructura' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,Fecha from calendarioreestructurassac where idConvenio = (select id from reestructurassac where idCredito = " + idCredito + @") and abonado <> 0 )estadodecuenta where 
(case TipoDePago when 'Normal' then FechaUltimoPago 
when 'Creación de convenio' then FechaPago 
when 'Convenio' then FechaUltimoPago 
when 'TicketC' then FechaPago 
when 'Cancelación de convenio' then FechaPago
when 'Pago por cancelación de convenio' then FechaPago
when 'Creación de reestructura' then FechaPago 
when 'Reestructura' then FechaUltimoPago 
when 'TicketR' then FechaPago end) between '2020-01-10' and '" + dateHasta.Value.ToString("yyyy-MM-dd") + @"' 
order by  (case  when idPago in (select idPago from CalendarioNormal where id_credito = " + idCredito + " and Estado = 'L' and fechaultimopago <= (select fecha from conveniossac where idcredito = " + idCredito + ")) then 1   when TipoDePago = 'Creación de convenio' then 2 when TipoDePago = 'Convenio' then 3 when TipoDePago = 'Cancelación de convenio' then 4 when idpago in (select idPago from CalendarioNormal where id_credito = " + idCredito + " and (fechaultimopago >= (select fecha from ticket where idcredito = " + idCredito + @" and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio')) or FechaUltimoPago = '1900-01-01')) then 5 when TipoDePago = 'Creación de reestructura' then 6 when TipoDePago = 'Reestructura' then 7  end )asc
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




else if not exists(select * from ConveniosSac where idCredito = " + idCredito + @")
begin

set @SQL = 'select * from ('
declare Comportamiento cursor  LOCAL STATIC READ_ONLY FORWARD_ONLY for
select  ROW_NUMBER() OVER(ORDER BY fechapago ASC) AS Numero,EstadoDeCuenta.* from
(select 'Normal' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,FechaUltimoPago from CalendarioNormal where id_credito = " + idCredito + @" and Estado = 'L' 
union
select 'Creación de convenio' as TipoDePago,'','',DeudaCredito,Moratorios,'',TotalDeuda,Fecha,'' from ConveniosSac where idCredito = " + idCredito + @"
union
select 'Convenio' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,Fecha from CalendarioConveniosSac where idConvenio = (select id from ConveniosSac where idCredito = " + idCredito + @" and CalendarioConveniosSac.Estado = 'L') ) EstadoDeCuenta  where 
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
set @SQL = CONCAT(@SQL,') estadocuenta group by idpago,npago,monto,interes,abonado,pendiente,fechapago,fechaultimopago,hora,tipodepago order by  (case  when idPago in (select idPago from CalendarioNormal where id_credito = " + idCredito + " and Estado =',char(39),'L',char(39),' and fechaultimopago <= (select fecha from conveniossac where idcredito = " + idCredito + ")) then 1   when TipoDePago = ',char(39), 'Creación de Convenio' ,char(39),' then 2 when TipoDePago = ',char(39), 'Convenio' ,char(39),' or TipoDePago = ',char(39), 'TicketC' ,char(39),' then 3 when TipoDePago = ',char(39), 'Cancelación de convenio' ,char(39),' then 4 when idpago in (select idPago from CalendarioNormal where id_credito = " + idCredito + " and (fechaultimopago >= (select fecha from ticket where idcredito = " + idCredito + @" and tipodoc = (select id from tipodoc where nombre = ',char(39), 'Cancelación de convenio' ,char(39),')) or FechaUltimoPago = ',char(39), '1900-01-01' ,char(39),')) then 5 when TipoDePago = ',char(39), 'Creación de reestructura' ,char(39),' then 6 when TipoDePago = ',char(39), 'Reestructura' ,char(39),' or TipoDePago = ',char(39), 'TicketR' ,char(39),' then 7  end ) asc, idpago,fechapago,hora asc')
--set @SQL = CONCAT(@SQL,') estadocuenta  ')

print @sql
if @SQL <> ') estadocuenta group by idpago,tipodepago order by (case tipodepago wh) fechapago,hora desc'
begin
--Execute (@SQL)
select @sql
end
";
                adapterComportamiento = new SqlDataAdapter(consultaComportamiento, Module1.conexionempresa);
                dataComportamiento = new System.Data.DataTable();
                adapterComportamiento.Fill(dataComportamiento);
                MessageBox.Show(dateDesde.Value.ToString("yyyy-MM-dd"));

                EncontroRegistros = true;

                dataTableToWord(dataComportamiento);

            }


        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            ncargando = new Cargando();
            ncargando.Show();
            ncargando.MonoFlat_Label1.Text = "Generando Estado de Cuenta";
            if (CheckGeneral.Checked)
            {
                BackgroundGeneral.RunWorkerAsync();
            }
            else
            {
                BackgroundEstadodeCuenta.RunWorkerAsync();
            }


        }

        private void BackgroundEstadodeCuenta_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (EncontroRegistros)
            {
                var documento = DocX.Load(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempEstadodeCuenta.docx");
                documento.ReplaceText("%IDCREDITO%", idCredito.ToString());
                documento.ReplaceText("%SALDOINICIALCORTE%", Strings.FormatCurrency(SaldoInicial, 2));
                documento.ReplaceText("%SALDOFINALCORTE%", Strings.FormatCurrency(SaldoFinal, 2));
                documento.ReplaceText("%PAGOMINIMO%", Strings.FormatCurrency(pagoMinimo, 2));
                documento.ReplaceText("%PAGADO%", Strings.FormatCurrency(MontoPagado, 2));
                documento.ReplaceText("%FECHAIMPRESION%", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                documento.ReplaceText("%VENCIDO%", Strings.FormatCurrency(pagoMinimo, 2));
                documento.ReplaceText("%FECHALIMITE%", Conversions.ToString(FechaLimite));
                if (FechaCorte == DateTime.Now)
                {
                    documento.ReplaceText("%FECHACORTE%", Conversions.ToString(FechaCorte));
                }
                else
                {
                    documento.ReplaceText("%FECHACORTE%", Conversions.ToString(FechaCorte.AddDays(-1)));
                }
                documento.ReplaceText("%NOMBRECLIENTE%", nombreCredito);
                documento.ReplaceText("%MONTOCREDITO%", Strings.FormatCurrency(Pagare, 2));
                documento.ReplaceText("%PERIODO%", "del " + GeneraDateString(dateDesde.Value.Day, dateDesde.Value.Month, dateDesde.Value.Year) + " al " + GeneraDateString(dateHasta.Value.Day, dateHasta.Value.Month, dateHasta.Value.Year));
                documento.ReplaceText("%DIASPERIODO%", DateAndTime.DateDiff(DateInterval.Day, dateDesde.Value, dateHasta.Value).ToString());
                string para;
                para = @"Nota: *Cuando la fecha de pago corresponda a un día inhábil, el pago podrá efectuarse sin cargo adicional alguno el día hábil siguiente.

*Para solicitudes, aclaraciones o reclamaciones favor de comunicarse a la siguiente dirección, dentro de 90 días naturales Contados a partir de la fecha de la operación de que se trate.
Contacto: Omar Enrique Paniahua Ambriz 
Número telefónico de la oficina 01 (452) 52 4 43 91
correo: opaniahua@prestamosconfia.com

Procuraduría Federal del Consumidor
www.gob.mx/profeco; teléfono 01 800 468 87 22)
";
                documento.InsertParagraph(para).Bold().FontSize(9d).Alignment = Alignment.center;
                documento.Save();
                documento.Dispose();
                var spDoc = new Spire.Doc.Document();
                spDoc.LoadFromFile(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempEstadodeCuenta.docx");
                var dialog = new PrintPreviewDialog();

                // dialog.AllowCurrentPage = True
                // dialog.AllowSomePages = True
                // dialog.UseEXDialog = True


                try
                {
                    // spDoc.PrintDialog = dialog.
                    spDoc.PrintDocument.PrinterSettings.PrinterName = Module1.ImpresoraPredeterminada;

                    dialog.Document = spDoc.PrintDocument;
                    dialog.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ncargando.Close();
                ncargando.Close();
            }
            else
            {
                MessageBox.Show("No se encontraron registros con esas fechas, marca la opción Estado de cuenta general");
                ncargando.Close();
            }

        }

        private string GeneraDateString(int dia, int mes, int año)
        {
            string dateString;
            string diaString, mesString ="", añoString;
            switch (dia)
            {
                case 1:
                    {
                        diaString = "Lunes";
                        break;
                    }
                case 2:
                    {
                        diaString = "Martes";
                        break;
                    }
                case 3:
                    {
                        diaString = "Miércoles";
                        break;
                    }
                case 4:
                    {
                        diaString = "Jueves";
                        break;
                    }
                case 5:
                    {
                        diaString = "Viernes";
                        break;
                    }
                case 6:
                    {
                        diaString = "Sábado";
                        break;
                    }
                case 7:
                    {
                        diaString = "Domingo";
                        break;
                    }

            }

            switch (mes)
            {
                case 1:
                    {
                        mesString = "Enero";
                        break;
                    }
                case 2:
                    {
                        mesString = "Febrero";
                        break;
                    }
                case 3:
                    {
                        mesString = "Marzo";
                        break;
                    }
                case 4:
                    {
                        mesString = "Abril";
                        break;
                    }
                case 5:
                    {
                        mesString = "Mayo";
                        break;
                    }
                case 6:
                    {
                        mesString = "Junio";
                        break;
                    }
                case 7:
                    {
                        mesString = "Julio";
                        break;
                    }
                case 8:
                    {
                        mesString = "Agosto";
                        break;
                    }
                case 9:
                    {
                        mesString = "Septiembre";
                        break;
                    }
                case 10:
                    {
                        mesString = "Octubre";
                        break;
                    }
                case 11:
                    {
                        mesString = "Noviembre";
                        break;
                    }
                case 12:
                    {
                        mesString = "Diciembre";
                        break;
                    }

            }

            dateString = dia + " de " + mesString + " del " + año;
            return dateString;

        }

        private void BackgroundGeneral_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var documento = DocX.Load(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempEstadodeCuenta.docx");
            documento.ReplaceText("%IDCREDITO%", idCredito.ToString());
            documento.ReplaceText("%SALDOINICIALCORTE%", Strings.FormatCurrency(SaldoInicial, 2));
            documento.ReplaceText("%SALDOFINALCORTE%", Strings.FormatCurrency(SaldoFinal, 2));
            documento.ReplaceText("%PAGOMINIMO%", Strings.FormatCurrency(pagoMinimo, 2));
            documento.ReplaceText("%PAGADO%", Strings.FormatCurrency(MontoPagado, 2));
            documento.ReplaceText("%FECHAIMPRESION%", DateTime.Now.Date.ToString("yyyy-MM-dd"));
            documento.ReplaceText("%VENCIDO%", Strings.FormatCurrency(pagoMinimo, 2));
            documento.ReplaceText("%FECHALIMITE%", Conversions.ToString(FechaLimite));
            if (FechaCorte == DateTime.Now)
            {
                documento.ReplaceText("%FECHACORTE%", Conversions.ToString(FechaCorte));
            }
            else
            {
                documento.ReplaceText("%FECHACORTE%", Conversions.ToString(FechaCorte.AddDays(-1)));
            }

            documento.ReplaceText("%NOMBRECLIENTE%", nombreCredito);
            documento.ReplaceText("%MONTOCREDITO%", Strings.FormatCurrency(Pagare, 2));
            documento.ReplaceText("%PERIODO%", "del " + GeneraDateString(DateTime.Now.Date.Day, DateTime.Now.Date.Month, DateTime.Now.Date.Year) + " al " + GeneraDateString(DateTime.Now.Date.Day, DateTime.Now.Date.Month, DateTime.Now.Date.Year));
            documento.ReplaceText("%DIASPERIODO%", DateAndTime.DateDiff(DateInterval.Day, dateDesde.Value, dateHasta.Value).ToString());
            string para;
            para = @"Nota: *Cuando la fecha de pago corresponda a un día inhábil, el pago podrá efectuarse sin cargo adicional alguno el día hábil siguiente.

*Para solicitudes, aclaraciones o reclamaciones favor de comunicarse a la siguiente dirección, dentro de 90 días naturales Contados a partir de la fecha de la operación de que se trate.
Contacto: Omar Enrique Paniahua Ambriz 
Número telefónico de la oficina 01 (452) 52 4 43 91
correo: opaniahua@prestamosconfia.com

Procuraduría Federal del Consumidor
www.gob.mx/profeco; teléfono 01 800 468 87 22)
";
            documento.InsertParagraph(para).Bold().FontSize(9d).Alignment = Alignment.center;
            documento.Save();
            documento.Dispose();

            var spDoc = new Spire.Doc.Document();
            spDoc.LoadFromFile(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempEstadodeCuenta.docx");
            var dialog = new PrintPreviewDialog();

            // dialog.AllowCurrentPage = True
            // dialog.AllowSomePages = True
            // dialog.UseEXDialog = True


            try
            {
                // spDoc.PrintDialog = dialog.
                spDoc.PrintDocument.PrinterSettings.PrinterName = Module1.ImpresoraPredeterminada;

                dialog.Document = spDoc.PrintDocument;
                dialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ncargando.Close();
        }
    }
}