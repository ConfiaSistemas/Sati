using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using WinControls.ListView;
using Xceed.Words.NET;

namespace ConfiaAdmin
{

    public partial class InformacionSolicitud
    {
        public int idCredito;
        private DataTable dataClientes;
        private SqlDataAdapter adapterClientes;
        private DataTable dataCalendario;
        private SqlDataAdapter adapterCalendario;
        private DataTable dataDocumentos;
        private SqlDataAdapter adapterDocumentos;
        private bool bloqueado;
        private DataTable dataGestiones;
        private SqlDataAdapter adapterGestiones;
        private DataTable dataActualizaciones;
        private SqlDataAdapter adapterActualizaciones;
        private string estado;
        private SqlDataAdapter adapterPromesas;
        private DataTable dataPromesas;
        private bool moto = false;

        public InformacionSolicitud()
        {
            InitializeComponent();
        }
        private void InformacionSolicitud_Load(object sender, EventArgs e)
        {
            Panel2.Size = new Size(51, 85);
            Panel2.Location = new Point(Width - Panel2.Width, TabControl1.Location.Y - Panel2.Height);
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Información";
            My.MyProject.Forms.Cargando.TopMost = true;
            BackgroundClientes.RunWorkerAsync();

        }

        private void BackgroundClientes_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consultaCredito;
            SqlCommand comandoCredito;
            SqlDataReader readerCredito;

            consultaCredito = "select format(FechaEntrega,'dd-MM-yy') as FechaEntrega,credito.Nombre,Monto,Credito.Pagare,TiposDeCredito.Nombre as tipo,credito.estado,tiposdecredito.moto from Credito inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id where credito.id = '" + idCredito + "'";
            comandoCredito = new SqlCommand();
            comandoCredito.Connection = Module1.conexionempresa;
            comandoCredito.CommandText = consultaCredito;
            readerCredito = comandoCredito.ExecuteReader();
            while (readerCredito.Read())
            {
                lblnombre.Text = Conversions.ToString(readerCredito["Nombre"]);
                if (readerCredito["FechaEntrega"] is DBNull)
                {
                    lblfecha.Text = "";
                }
                else
                {
                    lblfecha.Text = Conversions.ToString(readerCredito["FechaEntrega"]);
                }
                // lblfecha.Text = readerCredito("FechaEntrega")
                lblmonto.Text = Strings.FormatCurrency(readerCredito["Monto"]);
                lblmontopagare.Text = Strings.FormatCurrency(readerCredito["Pagare"]);
                lbltipo.Text = Conversions.ToString(readerCredito["tipo"]);
                estado = Conversions.ToString(readerCredito["estado"]);
                moto = Conversions.ToBoolean(readerCredito["moto"]);
            }

            readerCredito.Close();
            string consultaClientes;
            consultaClientes = "select Clientes.id,Clientes.Nombre,Clientes.Apellidopaterno,Clientes.ApellidoMaterno from Credito inner join Solicitud on Credito.IdSolicitud =  Solicitud.id inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud inner join Clientes on DatosSolicitud.IdCliente = Clientes.id where Credito.id = '" + idCredito + "'";
            adapterClientes = new SqlDataAdapter(consultaClientes, Module1.conexionempresa);
            dataClientes = new DataTable();
            adapterClientes.Fill(dataClientes);

        }

        private void BackgroundClientes_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Text = "Información de Crédito " + lblnombre.Text;
            dtClientes.DataSource = dataClientes;
            BackgroundSolicitud.RunWorkerAsync();
            dtSolicitud.Rows.Clear();
            dtSolicitud.ScrollBars = ScrollBars.None;
        }

        private void BackgroundSolicitud_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {
                string strimpuestos;
                Module1.iniciarconexionempresa();

                strimpuestos = "select Solicitud.id,format(Solicitud.Fecha,'dd-MM-yy') as Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo from Credito inner join Solicitud on Credito.IdSolicitud = Solicitud.id where Credito.id = '" + idCredito + "'";




                var ejec = new SqlCommand(strimpuestos);
                ejec.Connection = Module1.conexionempresa;
                string id, nombre, valor, factor, tipo;

                var myreaderimpuestos = ejec.ExecuteReader();
                while (myreaderimpuestos.Read())
                {
                    id = Conversions.ToString(myreaderimpuestos["id"]);


                    dtSolicitud.Rows.Add(id, myreaderimpuestos["fecha"], Strings.FormatCurrency(myreaderimpuestos["Monto"], 2), Strings.FormatCurrency(myreaderimpuestos["MontoAutorizado"], 2), myreaderimpuestos["tipo"]);
                }
                myreaderimpuestos.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BackgroundSolicitud_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtSolicitud.ScrollBars = ScrollBars.Both;
            BackgroundCalendario.RunWorkerAsync();

        }

        private void BackgroundCalendario_DoWork(object sender, DoWorkEventArgs e)
        {
            string consultaCalendario;
            consultaCalendario = "select format(CalendarioNormal.FechaPago,'dd-MM-yy') as FechaPago,CalendarioNormal.Npago,CalendarioNormal.Monto from Credito inner join CalendarioNormal on Credito.id = CalendarioNormal.id_credito where Credito.id = '" + idCredito + "'";
            adapterCalendario = new SqlDataAdapter(consultaCalendario, Module1.conexionempresa);
            dataCalendario = new DataTable();
            adapterCalendario.Fill(dataCalendario);
        }

        private void BackgroundCalendario_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtCalendarios.DataSource = dataCalendario;
            BackgroundDocumentos.RunWorkerAsync();

        }

        private void BackgroundDocumentos_DoWork(object sender, DoWorkEventArgs e)
        {
            string consultaDocumentos;
            consultaDocumentos = "select TiposdeDocumentosSolicitud.Nombre,DocumentosCredito.imagen from Credito inner join DocumentosCredito on Credito.id = DocumentosCredito.IdCredito inner join TiposdeDocumentosSolicitud on DocumentosCredito.Tipo = TiposdeDocumentosSolicitud.id where Credito.id = '" + idCredito + "'";
            adapterDocumentos = new SqlDataAdapter(consultaDocumentos, Module1.conexionempresa);
            dataDocumentos = new DataTable();
            adapterDocumentos.Fill(dataDocumentos);
        }

        private void BackgroundDocumentos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtdatosDocumentos.DataSource = dataDocumentos;
            BackgroundPagos.RunWorkerAsync();

            // Cargando.Close()
        }

        private void dtSolicitud_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            My.MyProject.Forms.DatosConsultaSolicitud.idSolicitud = Conversions.ToInteger(dtSolicitud.Rows[dtSolicitud.CurrentRow.Index].Cells[0].Value);
            // DatosConsultaSolicitud.TipoSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(5).Value
            My.MyProject.Forms.DatosConsultaSolicitud.Show();
        }



        private void dtdatosDocumentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            My.MyProject.Forms.VistaDocumento.PictureBox1.Image = (System.Drawing.Image)dtdatosDocumentos.Rows[dtdatosDocumentos.CurrentRow.Index].Cells[1].FormattedValue;
            My.MyProject.Forms.VistaDocumento.ShowDialog();
        }

        private void BackgroundPagos_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            TreeListView1.Nodes.Clear();



            SqlCommand comandoTicket;
            string consulta;
            SqlDataReader readerTicket;



            // consulta = "select id,Recibido,(case when tipo = 'Legal' then Concepto
            // when tipo = 'Extra' then Concepto

            // Else ISNULL((Select nombre from Credito where id = pagos.idCredito),0) 		End) As nombre,idCredito,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja from
            // (select Ticket.Id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.PagoNormal,Ticket.Intereses,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id  where  ticket.idcredito = '" & idCredito & "'  )pagos order by Fecha,Hora asc"

            consulta = "if  exists(select * from ticket  where idCredito = '" + idCredito + @"' and TipoDoc = (select id from TipoDoc where nombre = 'Cancelación de convenio'))
begin
select id,Recibido,(case when tipo = 'Legal' then Concepto
							   when tipo = 'Extra' then Concepto
							  
							   else ISNULL((select nombre from Credito where id = pagos.idCredito),0) 		end) as nombre,idCredito,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja,estado from
(select Ticket.Id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.PagoNormal,Ticket.Intereses,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja,ticket.estado from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id  where  ticket.idcredito = '" + idCredito + @"' and (tipodoc = (select id from tipodoc where nombre = 'Apertura')) )pagos 
union

select id,Recibido,(case when tipo = 'Legal' then Concepto
							   when tipo = 'Extra' then Concepto
							  
							   else ISNULL((select nombre from Credito where id = pagos.idCredito),0) 		end) as nombre,idCredito,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja,estado from
(select Ticket.Id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.PagoNormal,Ticket.Intereses,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja,ticket.estado from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id  where  ticket.idcredito = '" + idCredito + @"' and (tipodoc = (select id from tipodoc where nombre = 'Pago') or tipodoc = (select id from tipodoc where nombre = 'Transferencia') or tipodoc = (select id from tipodoc where nombre = 'Depósito') or  tipodoc = (select id from tipodoc where nombre = 'Liquidación Insoluto') or tipodoc = (select id from tipodoc where nombre = 'Liquidación Renovación') or tipodoc = (select id from tipodoc where nombre = 'Liquidación Normal') or  tipodoc = (select id from tipodoc where nombre = 'Renovación Insoluto') or tipodoc =(select id from tipodoc where nombre = 'Liquidación Promoción 90%') ) )pagos 
union
select id,Recibido,(case when tipo = 'Legal' then Concepto
							   when tipo = 'Extra' then Concepto
							  
							   else ISNULL((select nombre from Credito inner join ConveniosSac on Credito.id = ConveniosSac.idCredito where ConveniosSac.id = pagos.idCredito),0) 		end) as nombre,idCredito,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja,estado from
(select Ticket.Id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.PagoNormal,Ticket.Intereses,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja,ticket.estado from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id  where  ticket.idcredito = (select id from ConveniosSac where idCredito ='" + idCredito + @"') and (TipoDoc = (select id from tipodoc where nombre = 'Convenio') or TipoDoc = (select id from tipodoc where nombre = 'Transferencia Convenio') or TipoDoc = (select id from tipodoc where nombre = 'Depósito Convenio')))pagos
union
select id,Recibido,(case when tipo = 'Legal' then Concepto
							   when tipo = 'Extra' then Concepto
							  
							   else ISNULL((select nombre from Credito where id = pagos.idCredito),0) 		end) as nombre,idCredito,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja,estado from
(select Ticket.Id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.PagoNormal,Ticket.Intereses,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja,ticket.estado from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id  where  ticket.idcredito = '" + idCredito + @"' and TipoDoc = (select id from tipodoc where nombre = 'Cancelación de convenio') )pagos
union
select id,Recibido,(case when tipo = 'Legal' then Concepto
							   when tipo = 'Extra' then Concepto
							  
							   else ISNULL((select nombre from Credito inner join ReestructurasSac on credito.id = ReestructurasSac.idCredito where ReestructurasSac.id = pagos.idCredito),0) 		end) as nombre,idCredito,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja,estado from
(select Ticket.Id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.PagoNormal,Ticket.Intereses,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja,ticket.estado from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id  where  ticket.idcredito = (select id from reestructurassac where idcredito = '" + idCredito + @"') and (TipoDoc = (select id from tipodoc where nombre = 'Reestructura') or TipoDoc = (select id from tipodoc where nombre = 'Transferencia Reestructura') or TipoDoc = (select id from tipodoc where nombre = 'Depósito Reestructura')) )pagos
union
select id,Recibido,(case when tipo = 'Legal' then Concepto
							   when tipo = 'Extra' then Concepto
							  
							   else ISNULL((select nombre from Credito where id = pagos.idCredito),0) 		end) as nombre,idCredito,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja,estado from
(select Ticket.Id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.PagoNormal,Ticket.Intereses,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja,ticket.estado from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id  where  ticket.idcredito = '" + idCredito + @"' and TipoDoc = (select id from tipodoc where nombre = 'Cancelación de Reestructura') )pagos
union
select id,Recibido,(case when tipo = 'Legal' then Concepto
							   when tipo = 'Extra' then Concepto
							  
							   else ISNULL((select nombre from Credito inner join ReestructurasSac on credito.id = ReestructurasSac.idCredito where ReestructurasSac.id = pagos.idCredito),0) 		end) as nombre,idCredito,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja,estado from
(select Ticket.Id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.PagoNormal,Ticket.Intereses,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja,ticket.estado from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id  where  ticket.idcredito = (select id from conveniosTerminalesSac where idcredito = '" + idCredito + @"') and (TipoDoc = (select id from tipodoc where nombre = 'Terminal') or TipoDoc = (select id from tipodoc where nombre = 'Transferencia Terminal') or TipoDoc = (select id from tipodoc where nombre = 'Depósito Terminal')) )pagos
union

select id,Recibido,(case when tipo = 'Legal' then Concepto
							   when tipo = 'Extra' then Concepto
							  
							   else ISNULL((select nombre from Credito where id = pagos.idCredito),0) 		end) as nombre,idCredito,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja,estado from
(select Ticket.Id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.PagoNormal,Ticket.Intereses,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja,ticket.estado from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id  where  ticket.idcredito = '" + idCredito + @"' and (tipodoc = (select id from tipodoc where nombre = 'Promesa de Pago') or  tipodoc = (select id from tipodoc where nombre = 'Cancelación de Promesa') or tipodoc = (select id from tipodoc where nombre = 'Cancelación de Promesa Convenio') or tipodoc = (select id from tipodoc where nombre = 'Cancelación de Promesa Reestructura') or  tipodoc = (select id from tipodoc where nombre = 'Promesa Aplicada Convenio') or tipodoc =(select id from tipodoc where nombre = 'Promesa Aplicada Reestructura') or tipodoc =(select id from tipodoc where nombre = 'Promesa Aplicada')) )pagos 
order by Fecha,Hora asc
end
else if  exists(select * from ConveniosSac where idCredito = '" + idCredito + @"' and Estado = 'A')
begin
select id,Recibido,(case when tipo = 'Legal' then Concepto
							   when tipo = 'Extra' then Concepto
							  
							   else ISNULL((select nombre from Credito where id = pagos.idCredito),0) 		end) as nombre,idCredito,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja,estado from
(select Ticket.Id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.PagoNormal,Ticket.Intereses,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja,ticket.estado from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id  where  ticket.idcredito = '" + idCredito + @"' and (tipodoc = (select id from tipodoc where nombre = 'Apertura')) )pagos 
union
select id,Recibido,(case when tipo = 'Legal' then Concepto
							   when tipo = 'Extra' then Concepto
							  
							   else ISNULL((select nombre from Credito where id = pagos.idCredito),0) 		end) as nombre,idCredito,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja,estado from
(select Ticket.Id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.PagoNormal,Ticket.Intereses,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja,ticket.estado from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id  where  ticket.idcredito = '" + idCredito + @"' and (tipodoc = (select id from tipodoc where nombre = 'Pago') or tipodoc = (select id from tipodoc where nombre = 'Transferencia') or tipodoc = (select id from tipodoc where nombre = 'Depósito') or  tipodoc = (select id from tipodoc where nombre = 'Liquidación Insoluto') or tipodoc = (select id from tipodoc where nombre = 'Liquidación Renovación') or tipodoc = (select id from tipodoc where nombre = 'Liquidación Normal') or  tipodoc = (select id from tipodoc where nombre = 'Renovación Insoluto')) )pagos 
union
select id,Recibido,(case when tipo = 'Legal' then Concepto
							   when tipo = 'Extra' then Concepto
							  
							   else ISNULL((select nombre from Credito inner join ConveniosSac on Credito.id = ConveniosSac.idCredito where ConveniosSac.id = pagos.idCredito),0) 		end) as nombre,idCredito,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja,estado from
(select Ticket.Id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.PagoNormal,Ticket.Intereses,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja,ticket.estado from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id  where  ticket.idcredito = (select id from ConveniosSac where idCredito ='" + idCredito + @"') and (TipoDoc = (select id from tipodoc where nombre = 'Convenio') or TipoDoc = (select id from tipodoc where nombre = 'Transferencia Convenio') or TipoDoc = (select id from tipodoc where nombre = 'Depósito Convenio') ))pagos
union
select id,Recibido,(case when tipo = 'Legal' then Concepto
							   when tipo = 'Extra' then Concepto
							  
							   else ISNULL((select nombre from Credito where id = pagos.idCredito),0) 		end) as nombre,idCredito,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja,estado from
(select Ticket.Id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.PagoNormal,Ticket.Intereses,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja,ticket.estado from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id  where  ticket.idcredito = '" + idCredito + @"' and (tipodoc = (select id from tipodoc where nombre = 'Promesa de Pago') or  tipodoc = (select id from tipodoc where nombre = 'Cancelación de Promesa') or tipodoc = (select id from tipodoc where nombre = 'Cancelación de Promesa Convenio') or  tipodoc = (select id from tipodoc where nombre = 'Cancelación de Reestructura') or tipodoc = (select id from tipodoc where nombre = 'Cancelación de Promesa Reestructura') or  tipodoc = (select id from tipodoc where nombre = 'Promesa Aplicada Convenio') or tipodoc =(select id from tipodoc where nombre = 'Promesa Aplicada Reestructura') or tipodoc =(select id from tipodoc where nombre = 'Promesa Aplicada')) )pagos 
end
else if not exists(select * from ConveniosSac where idCredito = '" + idCredito + @"')
begin
select id,Recibido,(case when tipo = 'Legal' then Concepto
							   when tipo = 'Extra' then Concepto
							  
							   else ISNULL((select nombre from Credito where id = pagos.idCredito),0) 		end) as nombre,idCredito,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja,estado from
(select Ticket.Id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.PagoNormal,Ticket.Intereses,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja,ticket.estado from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id  where  ticket.idcredito = '" + idCredito + @"' and (tipodoc = (select id from tipodoc where nombre = 'Apertura')) )pagos 
union
select id,Recibido,(case when tipo = 'Legal' then Concepto
							   when tipo = 'Extra' then Concepto
							  
							   else ISNULL((select nombre from Credito where id = pagos.idCredito),0) 		end) as nombre,idCredito,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja,estado from
(select Ticket.Id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.PagoNormal,Ticket.Intereses,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja,ticket.estado from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id  where  ticket.idcredito = '" + idCredito + @"'  and (tipodoc = (select id from tipodoc where nombre = 'Pago') or  tipodoc = (select id from tipodoc where nombre = 'Liquidación Insoluto') or tipodoc = (select id from tipodoc where nombre = 'Transferencia') or tipodoc = (select id from tipodoc where nombre = 'Depósito') or tipodoc = (select id from tipodoc where nombre = 'Liquidación Renovación') or tipodoc = (select id from tipodoc where nombre = 'Liquidación Normal') or  tipodoc = (select id from tipodoc where nombre = 'Renovación Insoluto') or tipodoc =(select id from tipodoc where nombre = 'Liquidación Promoción 90%')))pagos
union 
select id,Recibido,(case when tipo = 'Legal' then Concepto
							   when tipo = 'Extra' then Concepto
							  
							   else ISNULL((select nombre from Credito where id = pagos.idCredito),0) 		end) as nombre,idCredito,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja,estado from
(select Ticket.Id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.PagoNormal,Ticket.Intereses,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja,ticket.estado from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id  where  ticket.idcredito = '" + idCredito + @"' and (tipodoc = (select id from tipodoc where nombre = 'Promesa de Pago') or  tipodoc = (select id from tipodoc where nombre = 'Cancelación de Promesa') or tipodoc = (select id from tipodoc where nombre = 'Cancelación de Promesa Convenio') or tipodoc = (select id from tipodoc where nombre = 'Cancelación de Promesa Reestructura') or  tipodoc = (select id from tipodoc where nombre = 'Promesa Aplicada Convenio') or tipodoc =(select id from tipodoc where nombre = 'Promesa Aplicada Reestructura') or tipodoc =(select id from tipodoc where nombre = 'Promesa Aplicada')) )pagos 
order by Fecha,Hora asc
end
";

            comandoTicket = new SqlCommand();
            comandoTicket.Connection = Module1.conexionempresa;
            comandoTicket.CommandText = consulta;
            readerTicket = comandoTicket.ExecuteReader();
            if (readerTicket.HasRows)
            {
                while (readerTicket.Read())
                {
                    var liItem = new TreeListNode(Conversions.ToString(readerTicket["id"].ToString()));
                    {
                        var withBlock = liItem.SubItems;
                        withBlock.Add(readerTicket["idcredito"].ToString());
                        withBlock.Add(readerTicket["nombre"].ToString());
                        withBlock.Add(Strings.FormatCurrency(readerTicket["pagonormal"].ToString()));
                        withBlock.Add(Strings.FormatCurrency(readerTicket["Intereses"].ToString()));
                        withBlock.Add(Strings.FormatCurrency(readerTicket["total"].ToString()));
                        withBlock.Add(readerTicket["Fecha"].ToString());
                        withBlock.Add(readerTicket["Hora"].ToString());
                        withBlock.Add(readerTicket["Tipo"].ToString());
                        withBlock.Add(readerTicket["Caja"].ToString());
                        withBlock.Add(readerTicket["estado"].ToString());
                    }

                    SqlCommand COMANDOdetalle;
                    string consultaDetalle;
                    SqlDataReader readerDetalle;
                    switch (readerTicket["Tipo"])
                    {
                        case "Pago":
                        case "Transferencia":
                        case "Depósito":
                            {
                                consultaDetalle = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select concat(ticketdetalle.concepto,' de ','Pago ', calendarionormal.NPago) as pago,pagonormal,intereses,ticketdetalle.monto from ticketdetalle inner join calendarionormal on ticketdetalle.idpago = calendarionormal.idpago where  idTicket = '", readerTicket["id"]), "'"));
                                COMANDOdetalle = new SqlCommand();
                                COMANDOdetalle.Connection = Module1.conexionempresa;
                                COMANDOdetalle.CommandText = consultaDetalle;
                                readerDetalle = COMANDOdetalle.ExecuteReader();
                                if (readerDetalle.HasRows)
                                {
                                    while (readerDetalle.Read())
                                        _addSubItems((ContainerListViewObject)liItem.Nodes.Add(readerDetalle["pago"].ToString()), Conversions.ToDouble(readerDetalle["pagonormal"].ToString()), Conversions.ToDouble(readerDetalle["intereses"].ToString()), Conversions.ToDouble(readerDetalle["monto"].ToString()));
                                }

                                break;
                            }
                        // TreeListView1.Nodes.Add(liItem)
                        case "Convenio":
                        case "Transferencia Convenio":
                        case "Depósito Convenio":
                            {
                                consultaDetalle = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select concat(ticketdetalle.concepto,' de ','Pago ', calendarioconveniossac.NPago) as pago,pagonormal,intereses,ticketdetalle.monto from ticketdetalle inner join calendarioconveniossac on ticketdetalle.idpago = calendarioconveniossac.idpago where  idTicket = '", readerTicket["id"]), "'"));
                                COMANDOdetalle = new SqlCommand();
                                COMANDOdetalle.Connection = Module1.conexionempresa;
                                COMANDOdetalle.CommandText = consultaDetalle;
                                readerDetalle = COMANDOdetalle.ExecuteReader();
                                if (readerDetalle.HasRows)
                                {
                                    while (readerDetalle.Read())
                                        _addSubItems((ContainerListViewObject)liItem.Nodes.Add(readerDetalle["pago"].ToString()), Conversions.ToDouble(readerDetalle["pagonormal"].ToString()), Conversions.ToDouble(readerDetalle["intereses"].ToString()), Conversions.ToDouble(readerDetalle["monto"].ToString()));
                                }

                                break;
                            }
                        // TreeListView1.Nodes.Add(liItem)
                        case "Apertura":
                            {
                                break;
                            }
                        // TreeListView1.Nodes.Add(liItem)
                        case "Promesa de Pago":
                            {
                                break;
                            }
                        case "Cancelación de Promesa":
                        case "Promesa Aplicada":
                            {
                                consultaDetalle = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select concat(ticketdetalle.concepto,' de ','Pago ', calendarionormal.NPago) as pago,pagonormal,intereses,ticketdetalle.monto from ticketdetalle inner join calendarionormal on ticketdetalle.idpago = calendarionormal.idpago where  idTicket = '", readerTicket["id"]), "'"));
                                COMANDOdetalle = new SqlCommand();
                                COMANDOdetalle.Connection = Module1.conexionempresa;
                                COMANDOdetalle.CommandText = consultaDetalle;
                                readerDetalle = COMANDOdetalle.ExecuteReader();
                                if (readerDetalle.HasRows)
                                {
                                    while (readerDetalle.Read())
                                        _addSubItems((ContainerListViewObject)liItem.Nodes.Add(readerDetalle["pago"].ToString()), Conversions.ToDouble(readerDetalle["pagonormal"].ToString()), Conversions.ToDouble(readerDetalle["intereses"].ToString()), Conversions.ToDouble(readerDetalle["monto"].ToString()));
                                }

                                break;
                            }
                        case "Cancelación de Promesa Convenio":
                        case "Promesa Aplicada Convenio":
                            {
                                consultaDetalle = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select concat(ticketdetalle.concepto,' de ','Pago ', calendarioconveniossac.NPago) as pago,pagonormal,intereses,ticketdetalle.monto from ticketdetalle inner join calendarioconveniossac on ticketdetalle.idpago = calendarioconveniossac.idpago where  idTicket = '", readerTicket["id"]), "'"));
                                COMANDOdetalle = new SqlCommand();
                                COMANDOdetalle.Connection = Module1.conexionempresa;
                                COMANDOdetalle.CommandText = consultaDetalle;
                                readerDetalle = COMANDOdetalle.ExecuteReader();
                                if (readerDetalle.HasRows)
                                {
                                    while (readerDetalle.Read())
                                        _addSubItems((ContainerListViewObject)liItem.Nodes.Add(readerDetalle["pago"].ToString()), Conversions.ToDouble(readerDetalle["pagonormal"].ToString()), Conversions.ToDouble(readerDetalle["intereses"].ToString()), Conversions.ToDouble(readerDetalle["monto"].ToString()));
                                }

                                break;
                            }
                        case "Cancelación de Promesa Reestructura":
                        case "Promesa Aplicada Reestructura":
                            {
                                consultaDetalle = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select concat(ticketdetalle.concepto,' de ','Pago ', calendarioreestructurassac.NPago) as pago,pagonormal,intereses,ticketdetalle.monto from ticketdetalle inner join calendarioreestructurassac on ticketdetalle.idpago = calendarioreestructurassac.idpago where  idTicket = '", readerTicket["id"]), "'"));
                                COMANDOdetalle = new SqlCommand();
                                COMANDOdetalle.Connection = Module1.conexionempresa;
                                COMANDOdetalle.CommandText = consultaDetalle;
                                readerDetalle = COMANDOdetalle.ExecuteReader();
                                if (readerDetalle.HasRows)
                                {
                                    while (readerDetalle.Read())
                                        _addSubItems((ContainerListViewObject)liItem.Nodes.Add(readerDetalle["pago"].ToString()), Conversions.ToDouble(readerDetalle["pagonormal"].ToString()), Conversions.ToDouble(readerDetalle["intereses"].ToString()), Conversions.ToDouble(readerDetalle["monto"].ToString()));
                                }

                                break;
                            }
                        case "Renovación Insoluto":
                            {
                                consultaDetalle = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select concat(ticketdetalle.concepto,' de ','Pago ', calendarionormal.NPago) as pago,pagonormal,intereses,ticketdetalle.monto from ticketdetalle inner join calendarionormal on ticketdetalle.idpago = calendarionormal.idpago where  idTicket = '", readerTicket["id"]), "'"));
                                COMANDOdetalle = new SqlCommand();
                                COMANDOdetalle.Connection = Module1.conexionempresa;
                                COMANDOdetalle.CommandText = consultaDetalle;
                                readerDetalle = COMANDOdetalle.ExecuteReader();
                                if (readerDetalle.HasRows)
                                {
                                    while (readerDetalle.Read())
                                        _addSubItems((ContainerListViewObject)liItem.Nodes.Add(readerDetalle["pago"].ToString()), Conversions.ToDouble(readerDetalle["pagonormal"].ToString()), Conversions.ToDouble(readerDetalle["intereses"].ToString()), Conversions.ToDouble(readerDetalle["monto"].ToString()));
                                }

                                break;
                            }
                        case "Liquidación Insoluto":
                            {
                                consultaDetalle = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select concat(ticketdetalle.concepto,' de ','Pago ', calendarionormal.NPago) as pago,pagonormal,intereses,ticketdetalle.monto from ticketdetalle inner join calendarionormal on ticketdetalle.idpago = calendarionormal.idpago where  idTicket = '", readerTicket["id"]), "'"));
                                COMANDOdetalle = new SqlCommand();
                                COMANDOdetalle.Connection = Module1.conexionempresa;
                                COMANDOdetalle.CommandText = consultaDetalle;
                                readerDetalle = COMANDOdetalle.ExecuteReader();
                                if (readerDetalle.HasRows)
                                {
                                    while (readerDetalle.Read())
                                        _addSubItems((ContainerListViewObject)liItem.Nodes.Add(readerDetalle["pago"].ToString()), Conversions.ToDouble(readerDetalle["pagonormal"].ToString()), Conversions.ToDouble(readerDetalle["intereses"].ToString()), Conversions.ToDouble(readerDetalle["monto"].ToString()));
                                }

                                break;
                            }
                        case "Cancelación de Convenio":
                            {
                                consultaDetalle = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select concat(ticketdetalle.concepto,' de ','Pago ', calendarionormal.NPago) as pago,pagonormal,intereses,ticketdetalle.monto from ticketdetalle inner join calendarionormal on ticketdetalle.idpago = calendarionormal.idpago where  idTicket = '", readerTicket["id"]), "'"));
                                COMANDOdetalle = new SqlCommand();
                                COMANDOdetalle.Connection = Module1.conexionempresa;
                                COMANDOdetalle.CommandText = consultaDetalle;
                                readerDetalle = COMANDOdetalle.ExecuteReader();
                                if (readerDetalle.HasRows)
                                {
                                    while (readerDetalle.Read())
                                        _addSubItems((ContainerListViewObject)liItem.Nodes.Add(readerDetalle["pago"].ToString()), Conversions.ToDouble(readerDetalle["pagonormal"].ToString()), Conversions.ToDouble(readerDetalle["intereses"].ToString()), Conversions.ToDouble(readerDetalle["monto"].ToString()));
                                }

                                break;
                            }
                        case "Reestructura":
                        case "Transferencia Reestructura":
                        case "Depósito Reestructura":
                            {
                                consultaDetalle = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select concat(ticketdetalle.concepto,' de ','Pago ', calendarioreestructurassac.NPago) as pago,pagonormal,intereses,ticketdetalle.monto from ticketdetalle inner join calendarioreestructurassac on ticketdetalle.idpago = calendarioreestructurassac.idpago where  idTicket = '", readerTicket["id"]), "'"));
                                COMANDOdetalle = new SqlCommand();
                                COMANDOdetalle.Connection = Module1.conexionempresa;
                                COMANDOdetalle.CommandText = consultaDetalle;
                                readerDetalle = COMANDOdetalle.ExecuteReader();
                                if (readerDetalle.HasRows)
                                {
                                    while (readerDetalle.Read())
                                        _addSubItems((ContainerListViewObject)liItem.Nodes.Add(readerDetalle["pago"].ToString()), Conversions.ToDouble(readerDetalle["pagonormal"].ToString()), Conversions.ToDouble(readerDetalle["intereses"].ToString()), Conversions.ToDouble(readerDetalle["monto"].ToString()));
                                }

                                break;
                            }
                        case "Terminal":
                            {
                                consultaDetalle = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select concat(ticketdetalle.concepto,' de ','Pago ', calendarioConveniosTerminalesSac.NPago) as pago,pagonormal,intereses,ticketdetalle.monto from ticketdetalle inner join calendarioconveniosTerminalesSac on ticketdetalle.idpago = calendarioconveniosTerminalesSac.idpago where  idTicket = '", readerTicket["id"]), "'"));
                                COMANDOdetalle = new SqlCommand();
                                COMANDOdetalle.Connection = Module1.conexionempresa;
                                COMANDOdetalle.CommandText = consultaDetalle;
                                readerDetalle = COMANDOdetalle.ExecuteReader();
                                if (readerDetalle.HasRows)
                                {
                                    while (readerDetalle.Read())
                                        _addSubItems((ContainerListViewObject)liItem.Nodes.Add(readerDetalle["pago"].ToString()), Conversions.ToDouble(readerDetalle["pagonormal"].ToString()), Conversions.ToDouble(readerDetalle["intereses"].ToString()), Conversions.ToDouble(readerDetalle["monto"].ToString()));
                                }

                                break;
                            }
                        case "Liquidación Promoción 90%":
                            {
                                consultaDetalle = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select concat(ticketdetalle.concepto,' de ','Pago ', calendarionormal.NPago) as pago,pagonormal,intereses,ticketdetalle.monto from ticketdetalle inner join calendarionormal on ticketdetalle.idpago = calendarionormal.idpago where  idTicket = '", readerTicket["id"]), "'"));
                                COMANDOdetalle = new SqlCommand();
                                COMANDOdetalle.Connection = Module1.conexionempresa;
                                COMANDOdetalle.CommandText = consultaDetalle;
                                readerDetalle = COMANDOdetalle.ExecuteReader();
                                if (readerDetalle.HasRows)
                                {
                                    while (readerDetalle.Read())
                                        _addSubItems((ContainerListViewObject)liItem.Nodes.Add(readerDetalle["pago"].ToString()), Conversions.ToDouble(readerDetalle["pagonormal"].ToString()), Conversions.ToDouble(readerDetalle["intereses"].ToString()), Conversions.ToDouble(readerDetalle["monto"].ToString()));
                                }

                                break;
                            }
                        case "Liquidación Convenio 90%":
                            {
                                consultaDetalle = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select concat(ticketdetalle.concepto,' de ','Pago ', calendarioconveniossac.NPago) as pago,pagonormal,intereses,ticketdetalle.monto from ticketdetalle inner join calendarioconveniossac on ticketdetalle.idpago = calendarioconveniossac.idpago where  idTicket = '", readerTicket["id"]), "'"));
                                COMANDOdetalle = new SqlCommand();
                                COMANDOdetalle.Connection = Module1.conexionempresa;
                                COMANDOdetalle.CommandText = consultaDetalle;
                                readerDetalle = COMANDOdetalle.ExecuteReader();
                                if (readerDetalle.HasRows)
                                {
                                    while (readerDetalle.Read())
                                        _addSubItems((ContainerListViewObject)liItem.Nodes.Add(readerDetalle["pago"].ToString()), Conversions.ToDouble(readerDetalle["pagonormal"].ToString()), Conversions.ToDouble(readerDetalle["intereses"].ToString()), Conversions.ToDouble(readerDetalle["monto"].ToString()));
                                }

                                break;
                            }
                    }
                    TreeListView1.Nodes.Add(liItem);
                    // consultaDetalle = "select concat(ticketdetalle.concepto,' de ','Pago ', calendarionormal.NPago) as pago,pagonormal,intereses,ticketdetalle.monto from ticketdetalle inner join calendarionormal on ticketdetalle.idpago = calendarionormal.idpago where  idTicket = '" & readerTicket("id") & "'"

                }
            }
        }
        private void _addSubItems(ContainerListViewObject aObj, double pagonormal, double intereses, double total)
        {
            {
                var withBlock = aObj.SubItems;
                withBlock.Add("");
                withBlock.Add("");
                withBlock.Add(Strings.FormatCurrency(pagonormal));
                withBlock.Add(Strings.FormatCurrency(intereses));
                withBlock.Add(Strings.FormatCurrency(total));
            }
        }

        private void BackgroundPagos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Consultando Gestiones";
            BackgroundGestiones.RunWorkerAsync();

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Module_resize.MoveForm(this);
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_MouseHover(object sender, EventArgs e)
        {
            if (bloqueado)
            {
            }

            else
            {
                for (int i = 51; i <= 499; i += 10)
                {
                    Panel2.Width = i;
                    Panel2.Location = new Point(Width - Panel2.Width, TabControl1.Location.Y - Panel2.Height);
                }
                bloqueado = true;
            }
        }

        private void InformacionSolicitud_MouseHover(object sender, EventArgs e)
        {
            for (int i = Panel2.Width; i >= 51; i -= 10)
            {
                Panel2.Width = i;
                Panel2.Location = new Point(Width - Panel2.Width, TabControl1.Location.Y - Panel2.Height);
            }
            bloqueado = false;
        }

        private void BunifuThinButton23_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.AgregarGestionCredito.idCredito = idCredito.ToString();
            My.MyProject.Forms.AgregarGestionCredito.frmNombre = Text;
            My.MyProject.Forms.AgregarGestionCredito.Show();
        }

        private void btnGenerarCalendario_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.DocumentosCredito.frmNombre = Text;
            My.MyProject.Forms.DocumentosCredito.idCredito = idCredito.ToString();
            My.MyProject.Forms.DocumentosCredito.Show();
        }

        private void BackgroundGestiones_DoWork(object sender, DoWorkEventArgs e)
        {
            string consultaGestiones;
            Module1.iniciarconexionempresa();
            consultaGestiones = "select id,Fecha,Concepto from gestionescredito where idcredito = '" + idCredito + "'";
            adapterGestiones = new SqlDataAdapter(consultaGestiones, Module1.conexionempresa);
            dataGestiones = new DataTable();
            adapterGestiones.Fill(dataGestiones);
        }

        private void BackgroundActualizaciones_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consultaActualizaciones;
            consultaActualizaciones = "select Fecha,Hora,Campo,ValorAnterior,NuevoValor,Motivo from actualizacionescredito where idCredito = '" + idCredito + "'";
            adapterActualizaciones = new SqlDataAdapter(consultaActualizaciones, Module1.conexionempresa);
            dataActualizaciones = new DataTable();
            adapterActualizaciones.Fill(dataActualizaciones);
        }

        private void BackgroundGestiones_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtGestiones.DataSource = dataGestiones;
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Consultando Actualizaciones";
            BackgroundActualizaciones.RunWorkerAsync();

        }

        private void BackgroundActualizaciones_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtActualizaciones.DataSource = dataActualizaciones;
            if (estado == "C")
            {
                btn_convenio.Enabled = true;
            }
            else if (estado == "R")
            {
                btn_convenio.Enabled = true;
                btn_convenio.ButtonText = "Imprimir Reestructura";
            }
            else if (estado == "R")
            {
                btn_convenio.Enabled = true;
                btn_convenio.ButtonText = "Imprimir Terminal";
            }
            else
            {
                btn_convenio.Enabled = false;
            }
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Comportamiento";

            // Cargando.Close()
            BackgroundComportamiento.RunWorkerAsync();

        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.ActInformacionCredito.idCredito = idCredito.ToString();
            My.MyProject.Forms.ActInformacionCredito.Show();
        }

        private void btn_convenio_Click(object sender, EventArgs e)
        {
            switch (estado ?? "")
            {
                case "C":
                    {
                        My.MyProject.Forms.ImprimirConvenio.idCredito = idCredito.ToString();
                        My.MyProject.Forms.ImprimirConvenio.Show();
                        break;
                    }
                case "R":
                    {
                        My.MyProject.Forms.ImprimirReestructura.idCredito = idCredito.ToString();
                        My.MyProject.Forms.ImprimirReestructura.Show();
                        break;
                    }
                case "Z":
                    {
                        My.MyProject.Forms.ImprimirTerminal.idCredito = idCredito.ToString();
                        My.MyProject.Forms.ImprimirTerminal.Show();
                        break;
                    }
            }
        }

        private void BackgroundComportamiento_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            TreeListView2.Nodes.Clear();



            SqlCommand comandoTicket;
            string consulta;
            SqlDataReader readerTicket;



            consulta = @"
if  exists(select * from ConveniosSac where idCredito = '" + idCredito + @"' and estado = 'A')
begin
select * from 
(select 'Normal' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,FechaUltimoPago from CalendarioNormal where id_credito = '" + idCredito + @"' and Abonado<>0 and 1=(case when exists(select id from ticket where idCredito='" + idCredito + @"' and TipoDoc=(select id from TipoDoc where Nombre='Liquidación Insoluto')) and idPago not in(select idpago from TicketDetalle where idTicket=(select id from ticket where idCredito='" + idCredito + @"' and TipoDoc=(select id from TipoDoc where Nombre='Liquidación Insoluto'))) then 1 when not exists (select id from ticket where idCredito='" + idCredito + @"' and TipoDoc=(select id from TipoDoc where Nombre='Liquidación Insoluto')) then 1 end) 
union
select 'Creación de convenio' as TipoDePago,'','',DeudaCredito,Moratorios,'',TotalDeuda,Fecha,'' from ConveniosSac where idCredito = '" + idCredito + @"'
union
select 'Convenio' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,Fecha from CalendarioConveniosSac where idConvenio = (select id from ConveniosSac where idCredito ='" + idCredito + @"') and 1=(case when exists(select fecha from ticket where idCredito='" + idCredito + @"' and TipoDoc = (select id from TipoDoc where Nombre='Liquidación Insoluto')) and fecha <= (select fecha from ticket where idCredito='" + idCredito + @"' and TipoDoc = (select id from TipoDoc where Nombre='Liquidación Insoluto') and Abonado<>0) then 1 when not exists(select fecha from ticket where idCredito='" + idCredito + @"' and TipoDoc = (select id from TipoDoc where Nombre='Liquidación Insoluto'))  then 1 end )
union
select 'Liquidación Insoluto' as TipoDePago,'','',PagoNormal,Intereses,Total,'',Fecha,'' from Ticket where idCredito='" + idCredito + @"' and TipoDoc=(select id from TipoDoc where Nombre='Liquidación Insoluto')
)Comportamiento
order by (case  when idPago in (select idPago from CalendarioNormal where id_credito = '" + idCredito + @"' and Estado = 'L' and fechaultimopago <= (select fecha from conveniossac where idcredito = '" + idCredito + @"') ) then 1 when TipoDePago ='Creación de convenio' then 2  when 1= case when exists(select fecha from ticket where idCredito='" + idCredito + @"' and TipoDoc=(select id from TipoDoc where Nombre='Liquidación Insoluto')) and idPago in (select idpago from CalendarioConveniosSac where idConvenio=(select id from ConveniosSac where idCredito='" + idCredito + @"') and Fecha<=(select fecha from ticket where idCredito='" + idCredito + @"' and TipoDoc=(select id from TipoDoc where Nombre='Liquidación Insoluto')) and Abonado<>0) then 1 when not exists(select fecha from ticket where idCredito='" + idCredito + @"' and TipoDoc=(select id from TipoDoc where Nombre='Liquidación Insoluto')) and idpago in (select idPago from CalendarioConveniosSac where idConvenio=(select id from ConveniosSac where idCredito='" + idCredito + @"')) then 1 end then 3  when TipoDePago='Liquidación Insoluto' then 4 when exists(select id from Ticket where idCredito='" + idCredito + @"' and TipoDoc=(select id from TipoDoc where nombre='Liquidación Insoluto') and idPago in (select idPago from CalendarioNormal where id_credito='" + idCredito + @"' and FechaUltimoPago>=(select Fecha from ticket where idCredito='" + idCredito + @"' and TipoDoc=(select id from TipoDoc where Nombre='Liquidación Insoluto')))) then 5 end  ) asc,idPago asc
end
else if exists(select * from ticket where idcredito = '" + idCredito + @"' and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio') and estado = 'A')
select * from
(select 'Normal' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,FechaUltimoPago from CalendarioNormal where id_credito = '" + idCredito + @"' and Estado = 'L' and fechaultimopago <= (select fecha from conveniossac where idcredito = '" + idCredito + @"') 
union
select 'Creación de convenio' as TipoDePago,'','',DeudaCredito,Moratorios,'',TotalDeuda,Fecha,'' from ConveniosSac where idCredito = '" + idCredito + @"'
union
select 'Convenio' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,Fecha from CalendarioConveniosSac where idConvenio = (select id from ConveniosSac where idCredito = '" + idCredito + @"') and abonado <> 0 and fecha <= (select fecha from ticket where idcredito = '" + idCredito + @"' and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio') and estado = 'A') and fecha <= (select fecha from ticket where idCredito='" + idCredito + @"' and TipoDoc = (select id from TipoDoc where Nombre='Liquidación Insoluto'))
union
select 'Cancelación de convenio' as TipoDePago,'','',PagoNormal,Intereses,'',Total,Fecha,'' from Ticket where idcredito = '" + idCredito + @"' and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio') and estado = 'A'
union
	
select 'Normal' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,FechaUltimoPago from CalendarioNormal where id_credito = '" + idCredito + @"' and 1= case when exists(select id from ReestructurasSac where idCredito = '" + idCredito + @"')  and idpago in (select idPago from CalendarioNormal where id_credito = '" + idCredito + @"' and (fechaultimopago >= (select fecha from ticket where idcredito = '" + idCredito + @"' and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio') and estado = 'A') AND FechaUltimoPago<=(select fecha from ReestructurasSac where idCredito='" + idCredito + @"'))) then 1 
when not exists(select id from ReestructurasSac where idCredito = '" + idCredito + @"') and idpago in (select idPago from CalendarioNormal where id_credito = '" + idCredito + @"' and (fechaultimopago >= (select fecha from ticket where idcredito = '" + idCredito + @"' and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio') and estado = 'A')) OR FechaUltimoPago = '1900-01-01')  then 1
 end

    
union

select 'Creación de reestructura' as TipoDePago,'','',DeudaCredito,Moratorios,'',TotalDeuda,Fecha,'' from reestructurassac where idCredito = '" + idCredito + @"' 
union
select 'Reestructura' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,Fecha from calendarioreestructurassac where idConvenio = (select id from reestructurassac where idCredito = '" + idCredito + @"')  and 1= case when exists(select id from ticket where idcredito = '" + idCredito + @"' and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Reestructura') and estado = 'A') and idpago in (select idPago from calendarioreestructurassac where idconvenio = (select id from reestructurassac where idcredito= '" + idCredito + @"') and abonado <> 0 and (fecha <=(select fecha from ticket where idcredito = '" + idCredito + @"' and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Reestructura') and estado = 'A')) ) then 1
when not exists(select id from ticket where idcredito = '" + idCredito + @"' and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Reestructura') and estado = 'A') and idpago in (select idpago from calendarioreestructurassac where idconvenio=(select id from reestructurassac where idcredito=' " + idCredito + @" ')) then 1 end
union
select 'Cancelación de Reestructura' as TipoDePago,'','',PagoNormal,Intereses,'',Total,Fecha,'' from Ticket where idcredito = '" + idCredito + @"' and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Reestructura') and estado = 'A'
union
	
select 'Normal' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,FechaUltimoPago from CalendarioNormal where id_credito = '" + idCredito + @"' and 1= case when exists(select id from ConveniosTerminalesSac where idCredito = '" + idCredito + @"')  and idpago in (select idPago from CalendarioNormal where id_credito = '" + idCredito + @"' and (fechaultimopago >= (select fecha from ticket where idcredito = '" + idCredito + @"' and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Reestructura') and estado = 'A'))) then 1 
when not exists(select id from ConveniosTerminalesSac where idCredito = '" + idCredito + @"') and exists(select id from ticket where idCredito=' " + idCredito + @" 'and TipoDoc=(select id from TipoDoc where Nombre='Cancelación de Reestructura') and Estado='A') and idpago in (select idPago from CalendarioNormal where id_credito = '" + idCredito + @"' and (fechaultimopago >= (select fecha from ticket where idcredito = '" + idCredito + @"' and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Reestructura') and estado = 'A')) OR FechaUltimoPago = '1900-01-01')  then 1
 end
union

select 'Creación de Convenio Terminal' as TipoDePago,'','',DeudaCredito,Moratorios,'',TotalDeuda,Fecha,'' from ConveniosTerminalesSac where idCredito = '" + idCredito + @"'
union
select 'Terminal' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,Fecha from CalendarioConveniosTerminalesSac where idConvenio = (select id from ConveniosTerminalesSac where idCredito = '" + idCredito + @"') 
) Comportamiento order by  (case  when idPago in (select idPago from CalendarioNormal where id_credito = '" + idCredito + @"' and Estado = 'L' and fechaultimopago <= (select fecha from conveniossac where idcredito = '" + idCredito + @"') ) then 1   when TipoDePago = 'Creación de convenio' then 2 when TipoDePago = 'Convenio' then 3 when TipoDePago = 'Cancelación de convenio' then 4 when 1=case when not exists(select id from ReestructurasSac where idCredito='" + idCredito + @"') and  idpago in (select idPago from CalendarioNormal where id_credito = '" + idCredito + @"' and (fechaultimopago >= (select fecha from ticket where idcredito = '" + idCredito + @"' and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio') and estado = 'A') or FechaUltimoPago = '1900-01-01')) then 1 when exists(select id from ReestructurasSac where idCredito='" + idCredito + @"') and idpago in (select idPago from CalendarioNormal where id_credito = '" + idCredito + @"' and (fechaultimopago >= (select fecha from ticket where idcredito = '" + idCredito + @"' and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Convenio') and estado = 'A') and FechaUltimoPago<=(select Fecha from ReestructurasSac where idCredito='" + idCredito + @"') )) then 1 end    then 5 when TipoDePago = 'Creación de reestructura' then 6 when TipoDePago = 'Reestructura' then 7 when TipoDePago = 'Cancelación de Reestructura' then 8 when idpago in (select idPago from CalendarioNormal where id_credito = '" + idCredito + @"' and (fechaultimopago >= (select fecha from ticket where idcredito = '" + idCredito + @"' and tipodoc = (select id from tipodoc where nombre = 'Cancelación de Reestructura') and estado = 'A') or FechaUltimoPago = '1900-01-01')) then 9 when TipoDePago = 'Creación de Convenio Terminal' then 10 when TipoDePago = 'Terminal' then 11  end )asc, idPago asc


else if not exists(select * from ConveniosSac where idCredito = '" + idCredito + @"')
begin
select 'Normal' as TipoDePago,idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,FechaUltimoPago from CalendarioNormal where id_credito = '" + idCredito + @"'  and 1=(case when exists(select id from ticket where idCredito='" + idCredito + @"' and TipoDoc=(select id from TipoDoc where Nombre='Liquidación Insoluto')) and idPago not in(select idpago from TicketDetalle where idTicket=(select id from ticket where idCredito='" + idCredito + @"' and TipoDoc=(select id from TipoDoc where Nombre='Liquidación Insoluto'))) then 1 when not exists (select id from ticket where idCredito='" + idCredito + @"' and TipoDoc=(select id from TipoDoc where Nombre='Liquidación Insoluto'))  then 1 end)
union
select 'Liquidación Insoluto' as TipoDePago,'','',PagoNormal,Intereses,Total,'',Fecha,'' from Ticket where idCredito='" + idCredito + @"' and TipoDoc=(select id from TipoDoc where Nombre='Liquidación Insoluto')

end

";


            comandoTicket = new SqlCommand();
            comandoTicket.Connection = Module1.conexionempresa;
            comandoTicket.CommandText = consulta;
            readerTicket = comandoTicket.ExecuteReader();
            if (readerTicket.HasRows)
            {
                while (readerTicket.Read())
                {
                    var liItem = new TreeListNode(Conversions.ToString(readerTicket["TipoDePago"].ToString()));
                    {
                        var withBlock = liItem.SubItems;
                        withBlock.Add(readerTicket["idpago"].ToString());

                        withBlock.Add(readerTicket["Npago"].ToString());
                        withBlock.Add(Strings.FormatCurrency(readerTicket["Monto"].ToString()));
                        withBlock.Add(Strings.FormatCurrency(readerTicket["Interes"].ToString()));
                        withBlock.Add(Strings.FormatCurrency(readerTicket["Abonado"].ToString()));
                        withBlock.Add(Strings.FormatCurrency(readerTicket["Pendiente"].ToString()));
                        withBlock.Add(readerTicket["FechaPago"].ToString());

                        withBlock.Add(readerTicket["FechaUltimoPago"].ToString());

                    }
                    switch (readerTicket["TipoDePago"].ToString())
                    {
                        case "Normal":
                            {
                                SqlCommand COMANDOdetalle;
                                string consultaDetalle;
                                SqlDataReader readerDetalle;
                                consultaDetalle = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select Ticket.id,TicketDetalle.Monto,TicketDetalle.PagoNormal,TicketDetalle.Intereses,Ticket.Fecha,Ticket.Hora from TicketDetalle inner join Ticket on TicketDetalle.idTicket =  Ticket.id and TicketDetalle.idPago = '", readerTicket["idpago"]), "' and (ticket.tipodoc = 1 or ticket.tipodoc = (select id from tipodoc where nombre = 'Cancelación de Promesa') or ticket.tipodoc = (select id from tipodoc where nombre = 'Transferencia') or ticket.tipodoc = (select id from tipodoc where nombre = 'Depósito') or ticket.tipodoc = (select id from tipodoc where nombre = 'Promesa Aplicada')) order by Ticket.Fecha,Ticket.Hora asc"));
                                COMANDOdetalle = new SqlCommand();
                                COMANDOdetalle.Connection = Module1.conexionempresa;
                                COMANDOdetalle.CommandText = consultaDetalle;
                                readerDetalle = COMANDOdetalle.ExecuteReader();
                                if (readerDetalle.HasRows)
                                {
                                    while (readerDetalle.Read())
                                        // Me._addSubItems(liItem.Nodes.Add(readerDetalle("pago")), readerDetalle("pagonormal"), readerDetalle("intereses"), readerDetalle("monto"))
                                        _addSubItemsDetalle(liItem.Nodes.Add(""), Conversions.ToInteger(readerDetalle["id"]), "", Conversions.ToDouble(readerDetalle["pagonormal"]), Conversions.ToDouble(readerDetalle["intereses"]), "", "", readerDetalle["hora"].ToString(), "", Conversions.ToString(readerDetalle["fecha"]));
                                }

                                break;
                            }
                        case "Creación de convenio":
                            {
                                SqlCommand COMANDOdetalle;
                                string consultaDetalle;
                                SqlDataReader readerDetalle;
                                consultaDetalle = "select idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,FechaUltimoPago from CalendarioNormal where id_credito = '" + idCredito + "' and (Estado = 'V' or Estado = 'P')";
                                COMANDOdetalle = new SqlCommand();
                                COMANDOdetalle.Connection = Module1.conexionempresa;
                                COMANDOdetalle.CommandText = consultaDetalle;
                                readerDetalle = COMANDOdetalle.ExecuteReader();
                                if (readerDetalle.HasRows)
                                {
                                    while (readerDetalle.Read())
                                        // Me._addSubItems(liItem.Nodes.Add(readerDetalle("pago")), readerDetalle("pagonormal"), readerDetalle("intereses"), readerDetalle("monto"))
                                        _addSubItemsDetalle(liItem.Nodes.Add(""), Conversions.ToInteger(readerDetalle["idpago"]), Conversions.ToString(readerDetalle["Npago"]), Conversions.ToDouble(readerDetalle["monto"]), Conversions.ToDouble(readerDetalle["interes"]), Conversions.ToString(readerDetalle["Abonado"]), Conversions.ToString(readerDetalle["Pendiente"]), "", Conversions.ToString(readerDetalle["FechaPago"]), "");
                                }

                                break;
                            }
                        case "Convenio":
                            {
                                SqlCommand COMANDOdetalle;
                                string consultaDetalle;
                                SqlDataReader readerDetalle;
                                consultaDetalle = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select Ticket.id,TicketDetalle.Monto,TicketDetalle.PagoNormal,TicketDetalle.Intereses,Ticket.Fecha,Ticket.Hora from TicketDetalle inner join Ticket on TicketDetalle.idTicket =  Ticket.id and TicketDetalle.idPago = '", readerTicket["idpago"]), "' and (ticket.tipodoc = (select id from tipodoc where nombre = 'Convenio') or ticket.tipodoc = (select id from tipodoc where nombre = 'Transferencia Convenio') or ticket.tipodoc = (select id from tipodoc where nombre = 'Depósito Convenio') or ticket.tipodoc = (select id from tipodoc where nombre = 'Cancelación de Promesa Convenio') or ticket.tipodoc = (select id from tipodoc where nombre = 'Promesa Aplicada Convenio')) order by Ticket.Fecha,Ticket.Hora asc"));
                                COMANDOdetalle = new SqlCommand();
                                COMANDOdetalle.Connection = Module1.conexionempresa;
                                COMANDOdetalle.CommandText = consultaDetalle;
                                readerDetalle = COMANDOdetalle.ExecuteReader();
                                if (readerDetalle.HasRows)
                                {
                                    while (readerDetalle.Read())
                                        // Me._addSubItems(liItem.Nodes.Add(readerDetalle("pago")), readerDetalle("pagonormal"), readerDetalle("intereses"), readerDetalle("monto"))
                                        _addSubItemsDetalle(liItem.Nodes.Add(""), Conversions.ToInteger(readerDetalle["id"]), "", Conversions.ToDouble(readerDetalle["pagonormal"]), Conversions.ToDouble(readerDetalle["intereses"]), "", "", readerDetalle["hora"].ToString(), "", Conversions.ToString(readerDetalle["fecha"]));
                                }

                                break;
                            }
                        case "Reestructura":
                            {
                                SqlCommand COMANDOdetalle;
                                string consultaDetalle;
                                SqlDataReader readerDetalle;
                                consultaDetalle = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select Ticket.id,TicketDetalle.Monto,TicketDetalle.PagoNormal,TicketDetalle.Intereses,Ticket.Fecha,Ticket.Hora from TicketDetalle inner join Ticket on TicketDetalle.idTicket =  Ticket.id and TicketDetalle.idPago = '", readerTicket["idpago"]), "' and (ticket.tipodoc = (select id from tipodoc where nombre = 'Reestructura') or ticket.tipodoc = (select id from tipodoc where nombre = 'Transferencia Reestructura') or ticket.tipodoc = (select id from tipodoc where nombre = 'Depósito Reestructura') or ticket.tipodoc = (select id from tipodoc where nombre = 'Cancelación de Promesa Reestructura') or ticket.tipodoc = (select id from tipodoc where nombre = 'Promesa Aplicada Reestructura')) order by Ticket.Fecha,Ticket.Hora asc"));
                                COMANDOdetalle = new SqlCommand();
                                COMANDOdetalle.Connection = Module1.conexionempresa;
                                COMANDOdetalle.CommandText = consultaDetalle;
                                readerDetalle = COMANDOdetalle.ExecuteReader();
                                if (readerDetalle.HasRows)
                                {
                                    while (readerDetalle.Read())
                                        // Me._addSubItems(liItem.Nodes.Add(readerDetalle("pago")), readerDetalle("pagonormal"), readerDetalle("intereses"), readerDetalle("monto"))
                                        _addSubItemsDetalle(liItem.Nodes.Add(""), Conversions.ToInteger(readerDetalle["id"]), "", Conversions.ToDouble(readerDetalle["pagonormal"]), Conversions.ToDouble(readerDetalle["intereses"]), "", "", readerDetalle["hora"].ToString(), "", Conversions.ToString(readerDetalle["fecha"]));
                                }

                                break;
                            }
                        case "Terminal":
                            {
                                SqlCommand COMANDOdetalle;
                                string consultaDetalle;
                                SqlDataReader readerDetalle;
                                consultaDetalle = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select Ticket.id,TicketDetalle.Monto,TicketDetalle.PagoNormal,TicketDetalle.Intereses,Ticket.Fecha,Ticket.Hora from TicketDetalle inner join Ticket on TicketDetalle.idTicket =  Ticket.id and TicketDetalle.idPago = '", readerTicket["idpago"]), "' and (ticket.tipodoc = (select id from tipodoc where nombre = 'Terminal') or ticket.tipodoc = (select id from tipodoc where nombre = 'Transferencia Terminal') or ticket.tipodoc = (select id from tipodoc where nombre = 'Depósito Terminal') or ticket.tipodoc = (select id from tipodoc where nombre = 'Cancelación de Promesa Terminal') or ticket.tipodoc = (select id from tipodoc where nombre = 'Promesa Aplicada Terminal')) order by Ticket.Fecha,Ticket.Hora asc"));
                                COMANDOdetalle = new SqlCommand();
                                COMANDOdetalle.Connection = Module1.conexionempresa;
                                COMANDOdetalle.CommandText = consultaDetalle;
                                readerDetalle = COMANDOdetalle.ExecuteReader();
                                if (readerDetalle.HasRows)
                                {
                                    while (readerDetalle.Read())
                                        // Me._addSubItems(liItem.Nodes.Add(readerDetalle("pago")), readerDetalle("pagonormal"), readerDetalle("intereses"), readerDetalle("monto"))
                                        _addSubItemsDetalle(liItem.Nodes.Add(""), Conversions.ToInteger(readerDetalle["id"]), "", Conversions.ToDouble(readerDetalle["pagonormal"]), Conversions.ToDouble(readerDetalle["intereses"]), "", "", readerDetalle["hora"].ToString(), "", Conversions.ToString(readerDetalle["fecha"]));
                                }

                                break;
                            }
                        case "Liquidación Insoluto":
                            {
                                SqlCommand COMANDOdetalle;
                                string consultaDetalle;
                                SqlDataReader readerDetalle;
                                consultaDetalle = "select idPago,Npago,Monto,Interes,Abonado,Pendiente,FechaPago,FechaUltimoPago from CalendarioNormal where id_credito = '" + idCredito + "' and idpago in (select idpago from ticketdetalle where idticket =(select id from ticket where idcredito='"+ idCredito +"' and tipodoc =(select id from tipodoc where nombre='Liquidación Insoluto')))";
                                COMANDOdetalle = new SqlCommand();
                                COMANDOdetalle.Connection = Module1.conexionempresa;
                                COMANDOdetalle.CommandText = consultaDetalle;
                                readerDetalle = COMANDOdetalle.ExecuteReader();
                                if (readerDetalle.HasRows)
                                {
                                    while (readerDetalle.Read())
                                        // Me._addSubItems(liItem.Nodes.Add(readerDetalle("pago")), readerDetalle("pagonormal"), readerDetalle("intereses"), readerDetalle("monto"))
                                        _addSubItemsDetalle(liItem.Nodes.Add("Normal"), Conversions.ToInteger(readerDetalle["idpago"]), Conversions.ToString(readerDetalle["Npago"]), Conversions.ToDouble(readerDetalle["monto"]), Conversions.ToDouble(readerDetalle["interes"]), Conversions.ToString(readerDetalle["Abonado"]), Conversions.ToString(readerDetalle["Pendiente"]), "", Conversions.ToString(readerDetalle["FechaPago"]), "");
                                }

                                break;
                            }

                    }

                    TreeListView2.Nodes.Add(liItem);
                }
            }
        }

        private void _addSubItemsDetalle(ContainerListViewObject aObj, int id, string Npago, double pagonormal, double intereses, string Abonado, string Pendiente, string hora, string fechaPago, string fecha)
        {
            {
                var withBlock = aObj.SubItems;
                withBlock.Add(id.ToString());
                withBlock.Add(Npago);
                withBlock.Add(Strings.FormatCurrency(pagonormal));
                withBlock.Add(Strings.FormatCurrency(intereses));
                withBlock.Add(Abonado);
                withBlock.Add(Pendiente);
                withBlock.Add(fechaPago);
                withBlock.Add(fecha);
                withBlock.Add(hora);
            }
        }

        private void BackgroundComportamiento_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Consultando Promesas";
            BackgroundPromesas.RunWorkerAsync();

        }

        private void BackgroundPromesas_DoWork(object sender, DoWorkEventArgs e)
        {
            string consultaPromesas;
            consultaPromesas = "select credito.nombre,format(MontoPromesa,'C','es-mx') as 'Monto Promesa',format(Capital,'C','es-mx') as Capital, format(Moratorios,'C','es-mx') as Moratorios,format(Pendiente,'C','es-mx') as Pendiente, format(Abonado,'C','es-mx') as Abonado,FechaLimite as 'Fecha Límite',FechaUltimoPago as 'Fecha último Pago',promesadepago.Fecha,promesadepago.Hora,promesadepago.Usuario,promesadepago.Estado,TipoCredito as 'Tipo de Crédito' from PromesaDePago inner join credito on promesadepago.idcredito = credito.id where promesadepago.idcredito = '" + idCredito + "' and promesadepago.tipocredito = '" + estado + "'";
            adapterPromesas = new SqlDataAdapter(consultaPromesas, Module1.conexionempresa);
            dataPromesas = new DataTable();
            adapterPromesas.Fill(dataPromesas);

        }

        private void BackgroundPromesas_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtPromesas.DataSource = dataPromesas;
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Concentrado";
            BackgroundConcentrado.RunWorkerAsync();


        }

        private void dtPromesas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtPromesas_SelectionChanged(object sender, EventArgs e)
        {
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(dtPromesas.Rows[dtPromesas.CurrentRow.Index].Cells[11].Value, "", false)))
            {
                dtPromesas.ContextMenuStrip = ContextMenuPromesa;
            }
            else
            {
                dtPromesas.ContextMenuStrip = null;

            }
        }

        private void ReimprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
                {
                    My.MyProject.Forms.Cargando.Show();
                    My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Generando Promesa";
                }));


            FileSystem.FileCopy(@"C:\ConfiaAdmin\SATI\Promesa.docx", @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempPromesa.docx");
            var documento = DocX.Load(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempPromesa.docx");
            documento.ReplaceText("%%FECHAPROMESA%%", dtPromesas.Rows[dtPromesas.CurrentRow.Index].Cells[8].Value.ToString());
            documento.ReplaceText("%%NOMBRECLIENTE%%", dtPromesas.Rows[dtPromesas.CurrentRow.Index].Cells[0].Value.ToString());

            documento.ReplaceText("%%TOTALDEUDA%%", dtPromesas.Rows[dtPromesas.CurrentRow.Index].Cells[1].Value.ToString());

            documento.ReplaceText("%%FECHALIMITE%%", dtPromesas.Rows[dtPromesas.CurrentRow.Index].Cells[6].Value.ToString());
            documento.Save();
            documento.Dispose();
            My.MyProject.Forms.VistaPreviaDocumento.ruta = @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempPromesa.docx";
            My.MyProject.Forms.VistaPreviaDocumento.Show();
            My.MyProject.Forms.Cargando.Close();
        }

        private void BackgroundConcentrado_DoWork(object sender, DoWorkEventArgs e)
        {
            SqlCommand comandoConcentrado;
            string consultaConcentrado;
            consultaConcentrado = @"
select nombre,id,(AbonadoSinMultas -(case when exists(select id from Ticket where idCredito = CarteraTotal.id and TipoDoc = (select id from TipoDoc where Nombre='Cancelación de Convenio')) then (select PagoNormal from Ticket where idCredito = CarteraTotal.id and TipoDoc = (select id from TipoDoc where Nombre='Cancelación de Convenio'))else 0 end )-(case when exists(select id from Ticket where idCredito = CarteraTotal.id and TipoDoc = (select id from TipoDoc where Nombre='Cancelación de Reestructura')) then (select PagoNormal from Ticket where idCredito = CarteraTotal.id and TipoDoc = (select id from TipoDoc where Nombre='Cancelación de Reestructura'))else 0 end ))AbonadoSinMultas,
AbonadoSinMultasC,AbonadoSinMultasR,AbonadoSinMultasT,(AbonadoMultasL + AbonadoMultasV-(case when exists(select id from Ticket where idCredito = CarteraTotal.id and TipoDoc = (select id from TipoDoc where Nombre='Cancelación de Convenio')) then (select Intereses from Ticket where idCredito = CarteraTotal.id and TipoDoc = (select id from TipoDoc where Nombre='Cancelación de Convenio'))else 0 end )-(case when exists(select id from Ticket where idCredito = CarteraTotal.id and TipoDoc = (select id from TipoDoc where Nombre='Cancelación de Reestructura')) then (select Intereses from Ticket where idCredito = CarteraTotal.id and TipoDoc = (select id from TipoDoc where Nombre='Cancelación de Reestructura'))else 0 end )) as AbonadoMultas,
(AbonadoMultasLC + AbonadoMultasVC+AbonadoMultasPC) as AbonadoMultasC,(AbonadoMultasLR+AbonadoMultasVR+AbonadoMultasPR) as AbonadoMultasR,(AbonadoMultasLT+AbonadoMultasVT+AbonadoMultasPT) as AbonadoMultasT,
(AbonadoMultasL+AbonadoMultasV+AbonadoSinMultas-(case when exists(select id from Ticket where idCredito = CarteraTotal.id and TipoDoc = (select id from TipoDoc where Nombre='Cancelación de Convenio')) then (select Total from Ticket where idCredito = CarteraTotal.id and TipoDoc = (select id from TipoDoc where Nombre='Cancelación de Convenio'))else 0 end )-(case when exists(select id from Ticket where idCredito = CarteraTotal.id and TipoDoc = (select id from TipoDoc where Nombre='Cancelación de Reestructura')) then (select Total from Ticket where idCredito = CarteraTotal.id and TipoDoc = (select id from TipoDoc where Nombre='Cancelación de Reestructura'))else 0 end )) as TotalAbonadoNormal,
(AbonadoMultasLC+AbonadoMultasVC+AbonadoMultasPC+AbonadoSinMultasC) as TotalAbonadoC,
(AbonadoMultasLR+AbonadoMultasVR+AbonadoMultasPR+AbonadoSinMultasR) as TotalAbonadoR,
(AbonadoMultasLT+AbonadoMultasVT+AbonadoMultasPT+AbonadoSinMultasT) as TotalAbonadoT,
((AbonadoMultasL+AbonadoMultasLC+AbonadoMultasLR+AbonadoMultasV+AbonadoMultasVC+AbonadoMultasVR+AbonadoSinMultas+AbonadoSinMultasC+AbonadoSinMultasR+AbonadoMultasPC+AbonadoMultasPR+AbonadomultasLT+AbonadoMultasVT+AbonadoSinMultasT+AbonadoMultasPT)-(case when exists(select id from Ticket where idCredito = CarteraTotal.id and TipoDoc = (select id from TipoDoc where Nombre='Cancelación de Convenio')) then (select Total from Ticket where idCredito = CarteraTotal.id and TipoDoc = (select id from TipoDoc where Nombre='Cancelación de Convenio'))else 0 end ) -(case when exists(select id from Ticket where idCredito = CarteraTotal.id and TipoDoc = (select id from TipoDoc where Nombre='Cancelación de Reestructura')) then (select Total from Ticket where idCredito = CarteraTotal.id and TipoDoc = (select id from TipoDoc where Nombre='Cancelación de Reestructura'))else 0 end ) ) as TotalAbonado,
(AbonadoMultasL+AbonadoMultasLC+AbonadoMultasLR+AbonadoMultasPC+AbonadoMultasPR+AbonadoMultasV+AbonadoMultasVC+AbonadoMultasVR-(case when exists(select id from Ticket where idCredito = CarteraTotal.id and TipoDoc = (select id from TipoDoc where Nombre='Cancelación de Convenio')) then (select Intereses from Ticket where idCredito = CarteraTotal.id and TipoDoc = (select id from TipoDoc where Nombre='Cancelación de Convenio'))else 0 end )) as TotalAbonadoMultas,
(AbonadoSinMultas+AbonadoSinMultasC+AbonadoSinMultasR-(case when exists(select id from Ticket where idCredito = CarteraTotal.id and TipoDoc = (select id from TipoDoc where Nombre='Cancelación de Convenio')) then (select PagoNormal from Ticket where idCredito = CarteraTotal.id and TipoDoc = (select id from TipoDoc where Nombre='Cancelación de Convenio'))else 0 end )) as TotalAbonadoCredito,Estado from
(select Cartera.nombre,Cartera.id,case when exists(select id from ReestructurasSac where idCredito = Cartera.id)  then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where Abonado <> 0 and Abonado >= interes and ReestructurasSac.idcredito = Cartera.id group by idcredito),0)
 else '0' end as AbonadoSinMultasR,
 --Abonado sin multas terminal
 case when exists(select id from ConveniosTerminalesSac where idCredito = Cartera.id)  then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.IdConvenio = ConveniosTerminalesSac.id where Abonado <> 0 and Abonado >= interes and ConveniosTerminalesSac.idcredito = Cartera.id group by idcredito),0)
 else '0' end as AbonadoSinMultasT,
case when exists (select id from ConveniosSac where idCredito = Cartera.id) then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where Abonado <> 0 and Abonado >= interes and conveniossac.idcredito = Cartera.id group by idcredito),0)
else '0'
end as AbonadoSinMultasC,
isnull((select SUM(Abonado - interes)  as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id group by id_credito),0) as AbonadoSinMultas ,
case when exists(select id from ConveniosSac where idCredito = Cartera.id) then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConveniossac inner join Conveniossac on ConveniosSac.id = CalendarioConveniossac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioConveniossac.estado = 'V' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarioconveniossac.Interes) ))) )) as AbonadoInteres from calendarioconveniossac inner join conveniossac on calendarioconveniossac.idconvenio = conveniossac.id where calendarioconveniossac.estado = 'V' and Abonado >=calendarioconveniossac.Interes and conveniossac.idcredito =Cartera.id group by conveniossac.idcredito),0) 
else '0'
end as AbonadoMultasVC,
case when exists(select id from ReestructurasSac where idCredito = Cartera.id) then
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idconvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado <= CalendarioReestructurasSac.Interes and ReestructurasSac.idCredito =cartera.id group by CalendarioReestructurasSac.idConvenio),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioReestructurasSac.Interes) ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado >=CalendarioReestructurasSac.Interes and ReestructurasSac.idCredito =cartera.id group by CalendarioReestructurasSac.idConvenio),0)),0)
else '0' end as AbonadoMultasVR,
--Multas abonadas vencidas terminal
case when exists(select id from ConveniosTerminalesSac where idCredito = Cartera.id) then
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.idconvenio = ConveniosTerminalesSac.id where CalendarioConveniosTerminalesSac.estado = 'V' and Abonado <= CalendarioConveniosTerminalesSac.Interes and ConveniosTerminalesSac.idCredito =cartera.id group by CalendarioConveniosTerminalesSac.idConvenio),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioConveniosTerminalesSac.Interes) ))) )) as AbonadoInteres from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.idConvenio = ConveniosTerminalesSac.id where CalendarioConveniosTerminalesSac.estado = 'V' and Abonado >=CalendarioConveniosTerminalesSac.Interes and ConveniosTerminalesSac.idCredito =cartera.id group by CalendarioConveniosTerminalesSac.idConvenio),0)),0)
else '0' end as AbonadoMultasVT,
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)),0) AbonadoMultasV
,
case when exists(select id from ConveniosSac where idCredito = Cartera.id) then
isnull((select SUM(Abonado - CalendarioConveniossac.monto) as AbonadoMultas from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where  Pendiente=0 and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
else '0' end as AbonadoMultasLC,
case when exists(select id from ReestructurasSac where idCredito = Cartera.id ) then
isnull((select SUM(Abonado - CalendarioReestructurasSac.monto) as AbonadoMultas from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where  CalendarioReestructurasSac.estado IN ('L') and ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
else '0' end as AbonadoMultasLR,
--Multas Abonadas liquidadas terminal
case when exists(select id from conveniosTerminalesSac where idCredito = Cartera.id ) then
isnull((select SUM(Abonado - calendarioConveniosTerminalesSac.monto) as AbonadoMultas from calendarioConveniosTerminalesSac inner join conveniosTerminalesSac on ConveniosTerminalesSac.id = calendarioConveniosTerminalesSac.IdConvenio where  calendarioConveniosTerminalesSac.estado IN ('L') and ConveniosTerminalesSac.idcredito = Cartera.id group by ConveniosTerminalesSac.idcredito),0)
else '0' end as AbonadoMultasLT,
isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L'  and CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) as AbonadoMultasL,
case when exists (select id from ConveniosSac where idCredito = Cartera.id) then
 isnull((select SUM( case when Abonado >= Interes then Interes else Abonado end ) as pagonormal from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where Abonado <> 0  and calendarioconveniossac.Estado = 'P' and conveniossac.idcredito = Cartera.id group by idcredito),0)
else '0'
end as AbonadoMultasPC,
case when exists(select id from ReestructurasSac where idCredito = Cartera.id)  then
 isnull((select SUM( case when Abonado >= Interes then Interes else Abonado end) as pagonormal from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where Abonado <> 0  and calendarioreestructurassac.Estado = 'P' and ReestructurasSac.idcredito = Cartera.id group by idcredito),0)
 else '0' end as AbonadoMultasPR,
 --Multas Abonadas Pendientes Terminal
 case when exists(select id from conveniosTerminalesSac where idCredito = Cartera.id)  then
 isnull((select SUM( case when Abonado >= Interes then Interes else Abonado end) as pagonormal from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.IdConvenio = ConveniosTerminalesSac.id where Abonado <> 0  and CalendarioConveniosTerminalesSac.Estado = 'P' and ConveniosTerminalesSac.idcredito = Cartera.id group by idcredito),0)
 else '0' end as AbonadoMultasPT,
Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado from
(select credito.nombre,Credito.id,Credito.idgestor,Credito.IdPromotor,credito.Estado from Credito inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito where Credito.id = '" + idCredito + @"'  group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join 
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal order by nombre asc";
            SqlDataReader readerConcentrado;
            comandoConcentrado = new SqlCommand();
            comandoConcentrado.Connection = Module1.conexionempresa;
            comandoConcentrado.CommandText = consultaConcentrado;
            readerConcentrado = comandoConcentrado.ExecuteReader();
            if (readerConcentrado.HasRows)
            {
                while (readerConcentrado.Read())
                {
                    btnCreditoNormal.ButtonText = Strings.FormatCurrency(readerConcentrado["AbonadoSinMultas"], 2);
                    btnMultasNormal.ButtonText = Strings.FormatCurrency(readerConcentrado["AbonadoMultas"], 2);
                    btnTotalNormal.ButtonText = Strings.FormatCurrency(readerConcentrado["TotalAbonadoNormal"], 2);
                    btnCreditoConvenio.ButtonText = Strings.FormatCurrency(readerConcentrado["AbonadoSinMultasC"], 2);
                    btnMultasConvenio.ButtonText = Strings.FormatCurrency(readerConcentrado["AbonadoMultasC"], 2);
                    btnTotalConvenio.ButtonText = Strings.FormatCurrency(readerConcentrado["TotalAbonadoC"], 2);
                    btnCreditoReestructura.ButtonText = Strings.FormatCurrency(readerConcentrado["AbonadoSinMultasR"], 2);
                    btnMultasReestructura.ButtonText = Strings.FormatCurrency(readerConcentrado["AbonadoMultasR"], 2);
                    btnTotalReestructura.ButtonText = Strings.FormatCurrency(readerConcentrado["TotalAbonadoR"], 2);
                    btnCreditoTerminal.ButtonText = Strings.FormatCurrency(readerConcentrado["AbonadoSinMultasT"], 2);
                    btnMultasTerminal.ButtonText= Strings.FormatCurrency(readerConcentrado["AbonadoMultasT"], 2);
                    btnTotalTerminal.ButtonText =Strings.FormatCurrency(readerConcentrado["TotalAbonadoT"], 2);
                    btnCreditoTotal.ButtonText = Strings.FormatCurrency(readerConcentrado["TotalAbonadoCredito"], 2);
                    btnMultasTotal.ButtonText = Strings.FormatCurrency(readerConcentrado["TotalAbonadoMultas"], 2);
                    btnTotal.ButtonText = Strings.FormatCurrency(readerConcentrado["TotalAbonado"], 2);
                }
            }
            readerConcentrado.Close();

        }

        private void BackgroundConcentrado_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();

        }

        private void btn_Moto_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.ConsultarMotocicleta.idCredito = idCredito.ToString();
            My.MyProject.Forms.ConsultarMotocicleta.Show();

        }
    }
}