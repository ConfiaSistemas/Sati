using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using Microsoft.VisualBasic;

namespace ConfiaAdmin
{

    public partial class MoraPorNiveles
    {


        private DataSet dataGestores;
        private DataSet dataPromotores;
        private SqlDataAdapter adapterGestores;

        private SqlDataAdapter adapterPromotores;
        private DataTable dataConsulta;
        private SqlDataAdapter adapterConsulta;

        public MoraPorNiveles()
        {
            InitializeComponent();
        }
        private void Desembolsos_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            ComboFiltro.SelectedIndex = 0;
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Información";
            My.MyProject.Forms.Cargando.TopMost = true;
            BackgroundGestores.RunWorkerAsync();

        }

        private void BackgroundGestores_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consulta;
            consulta = "Select id,nombre from empleados where tipo = 'G'";
            adapterGestores = new SqlDataAdapter(consulta, Module1.conexionempresa);
            dataGestores = new DataSet();
            adapterGestores.Fill(dataGestores);
        }

        private void BackgroundGestores_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BackgroundPromotores.RunWorkerAsync();

        }

        private void BackgroundPromotores_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consulta;
            consulta = "Select id,nombre from empleados where tipo = 'P'";
            adapterPromotores = new SqlDataAdapter(consulta, Module1.conexionempresa);
            dataPromotores = new DataSet();
            adapterPromotores.Fill(dataPromotores);
        }

        private void ComboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboFiltro.Text ?? "")
            {
                case "Todos":
                    {
                        // txtnombre.Enabled = False
                        ComboElección.Items.Clear();
                        ComboElección.Enabled = false;
                        break;
                    }
                case "Promotor":
                    {
                        // txtnombre.Enabled = True
                        ComboElección.Enabled = true;
                        ComboElección.Items.Clear();

                        ComboElección.Items.Add("Todos");
                        foreach (DataRow row in dataPromotores.Tables[0].Rows)

                            ComboElección.Items.Add(row["nombre"]);
                        ComboElección.SelectedIndex = 0;
                        break;
                    }
                case "Gestor":
                    {
                        // txtnombre.Enabled = True
                        ComboElección.Enabled = true;
                        ComboElección.Items.Clear();

                        ComboElección.Items.Add("Todos");
                        ComboElección.Items.Add("Nivel 1");
                        ComboElección.Items.Add("Nivel 2");
                        ComboElección.Items.Add("Nivel 3");
                        ComboElección.Items.Add("Nivel 4");
                        ComboElección.Items.Add("Legal");
                        ComboElección.Items.Add("Goteo");

                        ComboElección.SelectedIndex = 0;
                        break;
                    }
            }
        }

        private void BackgroundPromotores_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();
        }

        private int ConsultarId(string nombre)
        {
            int idEmpleado=0;
            switch (ComboFiltro.Text ?? "")
            {
                case "Gestor":
                    {
                        foreach (DataRow row in dataGestores.Tables[0].Rows)
                        {
                            if ((row["nombre"].ToString() ?? "") == (ComboElección.Text ?? ""))
                            {
                                idEmpleado = (int)Math.Round(Conversion.Val(row["id"].ToString()));
                                break;
                            }
                        }

                        break;
                    }
                case "Promotor":
                    {
                        foreach (DataRow row in dataPromotores.Tables[0].Rows)
                        {
                            if ((row["nombre"].ToString() ?? "") == (ComboElección.Text ?? ""))
                            {
                                idEmpleado = (int)Math.Round(Conversion.Val(row["id"].ToString()));
                                break;
                            }
                        }

                        break;
                    }


            }
            return idEmpleado;
        }

        private void BackgroundConsulta_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consulta ="";

            int idEmpleado;
            idEmpleado = ConsultarId(ComboElección.Text);
            switch (ComboFiltro.Text ?? "")
            {
                case "Gestor":
                    {
                        if (ComboElección.Text == "Todos")
                        {
                            consulta = @"select creditos_en_mora.*,isnull((select nivel from morahistorica where fecha = DATEADD(DAY, 1, EOMONTH(GETDATE(), -1)) and idCredito = creditos_en_mora.id ),'Goteo') as Nivel
from
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
format(((pagare - AbonadoSinMultas) + multasPendientes),'C','es-mx') as 'Liquida con',DatosSolicitud.Telefono,DatosSolicitud.Celular,(DatosSolicitud.Calle + ', ' + DatosSolicitud.Noext + ', ' + DatosSolicitud.Colonia ) as Domicilio,Promotor,carteravencida.Estado from 
(select nombre,id,pagare,PagoSemanal,AbonadoSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,
 case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.estado = 'R' then
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
(select top 1 (monto + Multas) as pagoNormal from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where Conveniossac.idcredito = Cartera.id and CalendarioConveniossac.Estado = 'V' )
when Cartera.Estado = 'R' then
(select top 1 (monto + Multas) as pagoNormal from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where ReestructurasSac.idcredito = Cartera.id and CalendarioReestructurasSac.Estado = 'V' )

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
(select SUM(interes) as MultasVencidas from CalendarioReestructurassac inner join ReestructurasSac on CalendarioReestructurassac.IdConvenio = ReestructurasSac.id where CalendarioReestructurassac.Estado ='V' and ReestructurasSac.idcredito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado,Cartera.IdSolicitud from
(select Credito.nombre,Credito.id,Credito.IdGestor,Credito.IdPromotor,Credito.Estado,Credito.IdSolicitud from CREDITO inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito  where CalendarioNormal.Estado = 'V' and Credito.Estado <> 'L' group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado,Credito.monto,Credito.Interes,Credito.IdSolicitud) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal) carteraVencida inner join Solicitud on carteraVencida.IdSolicitud = Solicitud.id inner join DatosSolicitud on solicitud.id = DatosSolicitud.IdSolicitud where VencidoNormal <> 0)creditos_en_mora order by creditos_en_mora.nombre asc
";
                        }

                        else
                        {

                            consulta = @"select * from (select creditos_en_mora.*,isnull((select nivel from morahistorica where fecha = DATEADD(DAY, 1, EOMONTH(GETDATE(), -1)) and idCredito = creditos_en_mora.id ),'Goteo') as Nivel
from
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
format(((pagare - AbonadoSinMultas) + multasPendientes),'C','es-mx') as 'Liquida con',DatosSolicitud.Telefono,DatosSolicitud.Celular,(DatosSolicitud.Calle + ', ' + DatosSolicitud.Noext + ', ' + DatosSolicitud.Colonia ) as Domicilio,Promotor,carteravencida.Estado from 
(select nombre,id,pagare,PagoSemanal,AbonadoSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,
 case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.estado = 'R' then
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
(select top 1 (monto + Multas) as pagoNormal from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where Conveniossac.idcredito = Cartera.id and CalendarioConveniossac.Estado = 'V' )
when Cartera.Estado = 'R' then
(select top 1 (monto + Multas) as pagoNormal from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where ReestructurasSac.idcredito = Cartera.id and CalendarioReestructurasSac.Estado = 'V' )

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
(select SUM(interes) as MultasVencidas from CalendarioReestructurassac inner join ReestructurasSac on CalendarioReestructurassac.IdConvenio = ReestructurasSac.id where CalendarioReestructurassac.Estado ='V' and ReestructurasSac.idcredito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado,Cartera.IdSolicitud from
(select Credito.nombre,Credito.id,Credito.IdGestor,Credito.IdPromotor,Credito.Estado,Credito.IdSolicitud from CREDITO inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito  where CalendarioNormal.Estado = 'V' and Credito.Estado <> 'L' group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado,Credito.monto,Credito.Interes,Credito.IdSolicitud) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal) carteraVencida inner join Solicitud on carteraVencida.IdSolicitud = Solicitud.id inner join DatosSolicitud on solicitud.id = DatosSolicitud.IdSolicitud where VencidoNormal <> 0)creditos_en_mora)MoraNiveles where nivel = '" + ComboElección.Text + "' order by nombre asc";
                        }

                        break;
                    }
                case "Promotor":
                    {
                        if (ComboElección.Text == "Todos")
                        {
                            consulta = @"select creditos_en_mora.*,isnull((select nivel from morahistorica where fecha = DATEADD(DAY, 1, EOMONTH(GETDATE(), -1)) and idCredito = creditos_en_mora.id ),'Goteo') as Nivel
from
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
format(((pagare - AbonadoSinMultas) + multasPendientes),'C','es-mx') as 'Liquida con',DatosSolicitud.Telefono,DatosSolicitud.Celular,(DatosSolicitud.Calle + ', ' + DatosSolicitud.Noext + ', ' + DatosSolicitud.Colonia ) as Domicilio,Promotor,carteravencida.Estado from 
(select nombre,id,pagare,PagoSemanal,AbonadoSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,
 case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.estado = 'R' then
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
(select top 1 (monto + Multas) as pagoNormal from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where Conveniossac.idcredito = Cartera.id and CalendarioConveniossac.Estado = 'V' )
when Cartera.Estado = 'R' then
(select top 1 (monto + Multas) as pagoNormal from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where ReestructurasSac.idcredito = Cartera.id and CalendarioReestructurasSac.Estado = 'V' )

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
(select SUM(interes) as MultasVencidas from CalendarioReestructurassac inner join ReestructurasSac on CalendarioReestructurassac.IdConvenio = ReestructurasSac.id where CalendarioReestructurassac.Estado ='V' and ReestructurasSac.idcredito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado,Cartera.IdSolicitud from
(select Credito.nombre,Credito.id,Credito.IdGestor,Credito.IdPromotor,Credito.Estado,Credito.IdSolicitud from CREDITO inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito  where CalendarioNormal.Estado = 'V' and Credito.Estado <> 'L' group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado,Credito.monto,Credito.Interes,Credito.IdSolicitud) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal) carteraVencida inner join Solicitud on carteraVencida.IdSolicitud = Solicitud.id inner join DatosSolicitud on solicitud.id = DatosSolicitud.IdSolicitud where VencidoNormal <> 0)creditos_en_mora order by creditos_en_mora.nombre asc";
                        }
                        else
                        {
                            consulta = @"select creditos_en_mora.*,isnull((select nivel from morahistorica where fecha = DATEADD(DAY, 1, EOMONTH(GETDATE(), -1)) and idCredito = creditos_en_mora.id ),'Goteo') as Nivel
from
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
format(((pagare - AbonadoSinMultas) + multasPendientes),'C','es-mx') as 'Liquida con',DatosSolicitud.Telefono,DatosSolicitud.Celular,(DatosSolicitud.Calle + ', ' + DatosSolicitud.Noext + ', ' + DatosSolicitud.Colonia ) as Domicilio,Promotor,carteravencida.Estado from 
(select nombre,id,pagare,PagoSemanal,AbonadoSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,
 case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.estado = 'R' then
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
(select top 1 (monto + Multas) as pagoNormal from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where Conveniossac.idcredito = Cartera.id and CalendarioConveniossac.Estado = 'V' )
when Cartera.Estado = 'R' then
(select top 1 (monto + Multas) as pagoNormal from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where ReestructurasSac.idcredito = Cartera.id and CalendarioReestructurasSac.Estado = 'V' )

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
(select SUM(interes) as MultasVencidas from CalendarioReestructurassac inner join ReestructurasSac on CalendarioReestructurassac.IdConvenio = ReestructurasSac.id where CalendarioReestructurassac.Estado ='V' and ReestructurasSac.idcredito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado,Cartera.IdSolicitud from
(select Credito.nombre,Credito.id,Credito.IdGestor,Credito.IdPromotor,Credito.Estado,Credito.IdSolicitud from CREDITO inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito  where CalendarioNormal.Estado = 'V' and Credito.Estado <> 'L' and credito.idpromotor = '" + idEmpleado + @"' group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado,Credito.monto,Credito.Interes,Credito.IdSolicitud) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal) carteraVencida inner join Solicitud on carteraVencida.IdSolicitud = Solicitud.id inner join DatosSolicitud on solicitud.id = DatosSolicitud.IdSolicitud where VencidoNormal <> 0)creditos_en_mora order by creditos_en_mora.nombre asc";
                        }

                        break;
                    }
                case "Todos":
                    {
                        consulta = @"select creditos_en_mora.*,isnull((select nivel from morahistorica where fecha = DATEADD(DAY, 1, EOMONTH(GETDATE(), -1)) and idCredito = creditos_en_mora.id ),'Goteo') as Nivel
from
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
format(((pagare - AbonadoSinMultas) + multasPendientes),'C','es-mx') as 'Liquida con',DatosSolicitud.Telefono,DatosSolicitud.Celular,(DatosSolicitud.Calle + ', ' + DatosSolicitud.Noext + ', ' + DatosSolicitud.Colonia ) as Domicilio,Promotor,carteravencida.Estado from 
(select nombre,id,pagare,PagoSemanal,AbonadoSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,
 case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.estado = 'R' then
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
(select top 1 (monto + Multas) as pagoNormal from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where Conveniossac.idcredito = Cartera.id and CalendarioConveniossac.Estado = 'V' )
when Cartera.Estado = 'R' then
(select top 1 (monto + Multas) as pagoNormal from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where ReestructurasSac.idcredito = Cartera.id and CalendarioReestructurasSac.Estado = 'V' )

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
(select SUM(interes) as MultasVencidas from CalendarioReestructurassac inner join ReestructurasSac on CalendarioReestructurassac.IdConvenio = ReestructurasSac.id where CalendarioReestructurassac.Estado ='V' and ReestructurasSac.idcredito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado,Cartera.IdSolicitud from
(select Credito.nombre,Credito.id,Credito.IdGestor,Credito.IdPromotor,Credito.Estado,Credito.IdSolicitud from CREDITO inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito  where CalendarioNormal.Estado = 'V' and Credito.Estado <> 'L' group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado,Credito.monto,Credito.Interes,Credito.IdSolicitud) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal) carteraVencida inner join Solicitud on carteraVencida.IdSolicitud = Solicitud.id inner join DatosSolicitud on solicitud.id = DatosSolicitud.IdSolicitud where VencidoNormal <> 0)creditos_en_mora order by creditos_en_mora.nombre asc
";
                        break;
                    }
            }


            adapterConsulta = new SqlDataAdapter(consulta, Module1.conexionempresa);
            dataConsulta = new DataTable();
            adapterConsulta.Fill(dataConsulta);
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            BunifuThinButton22.Enabled = false;
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Consultando";
            My.MyProject.Forms.Cargando.TopMost = true;
            BackgroundConsulta.RunWorkerAsync();
        }

        private void BackgroundConsulta_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtimpuestos.DataSource = dataConsulta;
            My.MyProject.Forms.Cargando.Close();
            BunifuThinButton22.Enabled = true;
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Exportando a Excel";
            My.MyProject.Forms.Cargando.TopMost = true;
            BackgroundExcel.RunWorkerAsync();
        }

        private void BackgroundExcel_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.nuevolibro();
            Module1.GridAExcel(dtimpuestos);
        }

        private void BackgroundExcel_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();
            Module1.cerrarlibro();

        }

        private void CreditosEnMora_Resize(object sender, EventArgs e)
        {
            BunifuThinButton22.Location = new Point(ComboElección.Location.X + ComboElección.Width + 20, ComboElección.Location.Y);
        }
    }
}