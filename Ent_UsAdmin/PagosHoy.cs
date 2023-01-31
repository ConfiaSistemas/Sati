using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace ConfiaAdmin
{

    public partial class PagosHoy
    {
        private SqlDataAdapter adapterPagos;
        private DataTable dataPagos;
        private Cargando ncargando;

        public PagosHoy()
        {
            InitializeComponent();
        }

        private void PagosHoy_Load(object sender, EventArgs e)
        {
            ComboFiltro.SelectedItem = 1;
            // ncargando = New Cargando
            // ncargando.Show()
            // ncargando.MonoFlat_Label1.Text = "Cargando Información"
            // BackgroundWorker1.RunWorkerAsync()

        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consultaPagos ="";
            switch (ComboFiltro.Text ?? "")
            {
                case "Programados para hoy":
                    {
                        consultaPagos = @"select calendarionormal.id_credito as 'id Crédito',case when TiposDeCredito.Tipo = 'I' then credito.nombre else CONCAT(Credito.Nombre,' (',Clientes.Nombre,' ',Clientes.ApellidoPaterno,' ',Clientes.ApellidoMaterno,')') end as Nombre,calendarionormal.monto as Monto,calendarionormal.interes as Interés,calendarionormal.abonado as Abonado,calendarionormal.pendiente As Pendiente,calendarionormal.Npago as 'No. de Pago',( case when calendarionormal.Abonado < (calendarionormal.Pendiente + calendarionormal.monto) and calendarionormal.abonado > 0 then 
'Abonado'
when Abonado = 0 then
'Sin pagar'
else
'Pagado'
END 
) AS Estado,DatosSolicitud.Telefono as 'Teléfono',DatosSolicitud.Celular,credito.estado as 'Estado crédito' 
 from calendarionormal inner join credito on calendarionormal.id_credito = credito.id inner join Solicitud on Credito.IdSolicitud = Solicitud.id inner join DatosSolicitud on DatosSolicitud.IdSolicitud = Solicitud.id inner join TiposDeCredito on Credito.Tipo=TiposDeCredito.id inner join Clientes on Clientes.id = DatosSolicitud.IdCliente where credito.estado = 'A' and calendarionormal.fechapago >= '" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "' and calendarionormal.fechapago <= '" + DateTime.Now.Date.ToString("yyyy-MM-dd") + @"' union select credito.id,case when TiposDeCredito.Tipo = 'I' then credito.nombre else CONCAT(Credito.Nombre,' (',Clientes.Nombre,' ',Clientes.ApellidoPaterno,' ',Clientes.ApellidoMaterno,')') end as Nombre,calendarioconveniossac.monto,calendarioconveniossac.interes,calendarioconveniossac.abonado,calendarioconveniossac.pendiente,calendarioconveniossac.Npago,( case when calendarioconveniossac.Abonado < (calendarioconveniossac.Pendiente + calendarioconveniossac.monto) and calendarioconveniossac.abonado > 0 then 
'Abonado'
when Abonado = 0 then
'Sin pagar'
else
'Pagado'
END 
) AS Estado,DatosSolicitud.Telefono as 'Teléfono',DatosSolicitud.Celular ,credito.estado as 'Estado Crédito' 
 from calendarioconveniossac inner join conveniossac on calendarioconveniossac.idconvenio = conveniossac.id inner join credito on conveniossac.idcredito = credito.id inner join Solicitud on Credito.IdSolicitud = Solicitud.id inner join DatosSolicitud on DatosSolicitud.IdSolicitud = Solicitud.id inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id inner join Clientes on DatosSolicitud.IdCliente = Clientes.id where credito.estado = 'C' and calendarioconveniossac.fechapago >= '" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "' and calendarioconveniossac.fechapago <= '" + DateTime.Now.Date.ToString("yyyy-MM-dd") + @"' union
 select credito.id,case when TiposDeCredito.Tipo = 'I' then credito.nombre else CONCAT(Credito.Nombre,' (',Clientes.Nombre,' ',Clientes.ApellidoPaterno,' ',Clientes.ApellidoMaterno,')') end as Nombre,CalendarioReestructurasSac.monto,CalendarioReestructurasSac.interes,CalendarioReestructurasSac.abonado,CalendarioReestructurasSac.pendiente,CalendarioReestructurasSac.Npago,( case when CalendarioReestructurasSac.Abonado < (CalendarioReestructurasSac.Pendiente + CalendarioReestructurasSac.monto) and CalendarioReestructurasSac.abonado > 0 then 
'Abonado'
when Abonado = 0 then
'Sin pagar'
else
'Pagado'
END 
) AS Estado,DatosSolicitud.Telefono as 'Teléfono',DatosSolicitud.Celular ,credito.estado as 'Estado Crédito' 
 from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idconvenio = ReestructurasSac.id inner join credito on ReestructurasSac.idcredito = credito.id inner join Solicitud on Credito.IdSolicitud = Solicitud.id inner join DatosSolicitud on DatosSolicitud.IdSolicitud = Solicitud.id inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id inner join Clientes on DatosSolicitud.IdCliente = Clientes.id where credito.estado = 'R' and CalendarioReestructurasSac.fechapago >= '" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "' and CalendarioReestructurasSac.fechapago <= '" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "'";
                        break;
                    }
                case "Créditos sin renovar":
                    {
                        consultaPagos = @"select creditosSRenovar.id,creditosSRenovar.Nombre,creditosSRenovar.ApellidoPaterno,creditosSRenovar.ApellidoMaterno,FechaAlta,HoraAlta,Telefono,Celular,idStr,PerteneceA,TerminoSiendo,FechaEntregaCredito,NombreCredito,FechaTermino,datediff(DAY,FechaTermino,GETDATE()) AS DiasSinRenovar from
(select *,isnull((select top 1 credito.id from credito inner join Solicitud on Credito.IdSolicitud=Solicitud.id inner join DatosSolicitud on DatosSolicitud.IdSolicitud = Solicitud.id where FechaEntrega > Concentrado.FechaEntregaCredito and DatosSolicitud.IdCliente = Concentrado.id order by FechaEntrega desc ),'') as CreditoPosterior,(case when TerminoSiendo = 'Convenio' then (select top 1 CalendarioConveniosSac.Fecha from CalendarioConveniosSac inner join ConveniosSac on ConveniosSac.id = CalendarioConveniosSac.idConvenio where ConveniosSac.idCredito = Concentrado.PerteneceA order by CalendarioConveniosSac.FechaPago desc )
when TerminoSiendo='Reestructura' then (select top 1 CalendarioReestructurasSac.Fecha from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where ReestructurasSac.idCredito= Concentrado.PerteneceA order by CalendarioReestructurasSac.FechaPago desc)
when TerminoSiendo = 'Incumplimiento' then (select top 1 FechaUltimoPago from CalendarioNormal where id_credito = Concentrado.PerteneceA order by FechaPago desc)
when TerminoSiendo = 'Normal' then (select top 1 FechaUltimoPago from CalendarioNormal where id_credito = Concentrado.PerteneceA order by FechaPago desc) end ) as FechaTermino from
(select *,(case when exists (select * from conveniossac where Estado= 'C' and idcredito = a.PerteneceA ) then case when exists (select * from ReestructurasSac where idCredito= a.PerteneceA and Estado= 'A') then 'Reestructura' else 'Incumplimiento' end else case when exists(select * from ConveniosSac where Estado = 'A' and idCredito= a.PerteneceA) then 'Convenio' else 'Normal' end end) as TerminoSiendo,
isnull((select fechaentrega from credito where id = a.PerteneceA),'') as FechaEntregaCredito,isnull((select nombre from Credito where id = a.PerteneceA ),'') NombreCredito from
(select *,isnull((select top 1 credito.id from Credito inner join Solicitud on Credito.IdSolicitud = Solicitud.id inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud where DatosSolicitud.IdCliente = cli.id and (Credito.Estado= 'T') order by Credito.FechaEntrega desc),0 ) as PerteneceA  from
(select * from Clientes) cli ) a where PerteneceA <>0) Concentrado) creditosSRenovar where CreditoPosterior = 0
";
                        break;
                    }
            }



            adapterPagos = new SqlDataAdapter(consultaPagos, Module1.conexionempresa);
            dataPagos = new DataTable();
            adapterPagos.Fill(dataPagos);
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtdatos.DataSource = dataPagos;
            ncargando.Close();

        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            ncargando = new Cargando();
            ncargando.Show();
            ncargando.MonoFlat_Label1.Text = "Cargando Información";
            BackgroundWorker1.RunWorkerAsync();
        }

        private void BackgroundExcel_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.nuevolibro();
            Module1.GridAExcel(dtdatos);
        }

        private void BackgroundExcel_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ncargando.Close();
            Module1.cerrarlibro();
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            ncargando = new Cargando();
            ncargando.Show();
            ncargando.MonoFlat_Label1.Text = "Exportando a Excel";
            BackgroundExcel.RunWorkerAsync();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Reportes.Panel1.Visible = false;
            My.MyProject.Forms.Reportes.RadPanorama1.Visible = true;
        }
    }
}