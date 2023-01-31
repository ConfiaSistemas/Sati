using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

using WinControls.ListView;

namespace ConfiaAdmin
{

    public partial class TicketsPfecha
    {
        private DataTable dataCajas;
        private SqlDataAdapter adapterCajas;

        public TicketsPfecha()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Module1.iniciarconexionempresa();
            TreeListView1.Nodes.Clear();
            string fechainserciondesde;
            fechainserciondesde = dateDesde.Value.ToShortDateString();

            DateTime fechasqldesde;
            fechasqldesde = Conversions.ToDate(fechainserciondesde);
            fechainserciondesde = Strings.Format(fechasqldesde, "yyyy-MM-dd");


            string fechainsercionhasta;
            fechainsercionhasta = dateHasta.Value.ToShortDateString();

            DateTime fechasqlhasta;
            fechasqlhasta = Conversions.ToDate(fechainsercionhasta);
            fechainsercionhasta = Strings.Format(fechasqlhasta, "yyyy-MM-dd");
            SqlCommand comandoTicket;
            string consulta;
            SqlDataReader readerTicket;
            consulta = @"select IdRecibo,Recibido,(case when tipo = 'Legal' then Concepto
							   when tipo = 'Extra' then Concepto
							   when tipo = 'Convenio' then
							   (select creditosext.nombre from Convenios inner join CreditosExt on Convenios.id_credito = CreditosExt.id_credito where Convenios.id = pagos.id_Credito)
							   else ISNULL((select nombre from CreditosExt where id_credito = pagos.id_Credito),0) 		end) as nombre,id_Credito,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja from
(select Recibos.IdRecibo,Recibos.Recibido,Recibos.Id_Credito,Recibos.Fecha,recibos.hora,Recibos.PagoNormal,Recibos.Intereses,recibos.total,tipodoc.Nombre as tipo,recibos.concepto,recibos.caja from recibos  inner join TipoDoc on recibos.tipodoc = TipoDoc.id  where recibos.fecha >= convert(date,'2020-02-12',102) and recibos.fecha <= convert(date,'2020-02-12',102)  )pagos";
            comandoTicket = new SqlCommand();
            comandoTicket.Connection = Module1.conexionempresa;
            comandoTicket.CommandText = consulta;
            readerTicket = comandoTicket.ExecuteReader();
            if (readerTicket.HasRows)
            {
                while (readerTicket.Read())
                {
                    var liItem = new TreeListNode(Conversions.ToString(readerTicket["idrecibo"].ToString()));
                    {
                        var withBlock = liItem.SubItems;
                        withBlock.Add(readerTicket["id_credito"].ToString());
                        withBlock.Add(readerTicket["nombre"].ToString());
                        withBlock.Add(readerTicket["pagonormal"].ToString());
                        withBlock.Add(readerTicket["Intereses"].ToString());
                        withBlock.Add(readerTicket["total"].ToString());
                        withBlock.Add(readerTicket["Fecha"].ToString());
                        withBlock.Add(readerTicket["Hora"].ToString());
                        withBlock.Add(readerTicket["Tipo"].ToString());
                        withBlock.Add(readerTicket["Caja"].ToString());
                    }

                    SqlCommand COMANDOdetalle;
                    string consultaDetalle;
                    SqlDataReader readerDetalle;
                    consultaDetalle = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select concat(abonosext.concepto,' de ','Pago ', PagosExt.NPago) as pago,pagonormal,intereses,abonosext.monto from AbonosExt inner join PagosExt on AbonosExt.idpago = PagosExt.idpago where  idrecibo = '", readerTicket["idrecibo"]), "'"));
                    COMANDOdetalle = new SqlCommand();
                    COMANDOdetalle.Connection = Module1.conexionempresa;
                    COMANDOdetalle.CommandText = consultaDetalle;
                    readerDetalle = COMANDOdetalle.ExecuteReader();
                    if (readerDetalle.HasRows)
                    {
                        while (readerDetalle.Read())
                            _addSubItems((ContainerListViewObject)liItem.Nodes.Add(readerDetalle["pago"].ToString()), Conversions.ToDouble(readerDetalle["pagonormal"].ToString()), Conversions.ToDouble(readerDetalle["intereses"].ToString()), Conversions.ToDouble(readerDetalle["monto"].ToString()));
                    }
                    TreeListView1.Nodes.Add(liItem);
                }
            }
        }
        private void _addSubItems(ContainerListViewObject aObj, double pagonormal, double intereses, double total)
        {
            {
                var withBlock = aObj.SubItems;
                withBlock.Add("");
                withBlock.Add("");
                withBlock.Add(pagonormal.ToString());
                withBlock.Add(intereses.ToString());
                withBlock.Add(total.ToString());
            }
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            TreeListView1.Nodes.Clear();
            string fechainserciondesde;
            fechainserciondesde = dateDesde.Value.ToShortDateString();

            DateTime fechasqldesde;
            fechasqldesde = Conversions.ToDate(fechainserciondesde);
            fechainserciondesde = Strings.Format(fechasqldesde, "yyyy-MM-dd");


            string fechainsercionhasta;
            fechainsercionhasta = dateHasta.Value.ToShortDateString();

            DateTime fechasqlhasta;
            fechasqlhasta = Conversions.ToDate(fechainsercionhasta);
            fechainsercionhasta = Strings.Format(fechasqlhasta, "yyyy-MM-dd");
            SqlCommand comandoTicket;
            string consulta;
            SqlDataReader readerTicket;
            string cajaConsultar;
            switch (ComboFiltro.Text ?? "")
            {
                case "Todas":
                    {
                        consulta = @"select id,Recibido,(case when tipo = 'Legal' then Concepto
							   when tipo = 'Extra' then Concepto
							  
							   else ISNULL((select nombre from Credito where id = pagos.idCredito),0) 		end) as nombre,idCredito,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja from
(select Ticket.Id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.PagoNormal,Ticket.Intereses,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id  where Ticket.fecha >= convert(date,'" + fechainserciondesde + "',102) and Ticket.fecha <= convert(date,'" + fechainsercionhasta + "',102)  )pagos order by Fecha,Hora asc";
                        break;
                    }

                default:
                    {
                        cajaConsultar = ComboFiltro.Text;
                        consulta = @"select id,Recibido,(case when tipo = 'Legal' then Concepto
							   when tipo = 'Extra' then Concepto
							  
							   else ISNULL((select nombre from Credito where id = pagos.idCredito),0) 		end) as nombre,idCredito,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja from
(select Ticket.Id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.PagoNormal,Ticket.Intereses,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id  where Ticket.fecha >= convert(date,'" + fechainserciondesde + "',102) and Ticket.fecha <= convert(date,'" + fechainsercionhasta + "',102) and ticket.caja = '" + cajaConsultar + "'  )pagos order by Fecha,Hora asc";
                        break;
                    }
            }

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
                        withBlock.Add(readerTicket["pagonormal"].ToString());
                        withBlock.Add(readerTicket["Intereses"].ToString());
                        withBlock.Add(readerTicket["total"].ToString());
                        withBlock.Add(readerTicket["Fecha"].ToString());
                        withBlock.Add(readerTicket["Hora"].ToString());
                        withBlock.Add(readerTicket["Tipo"].ToString());
                        withBlock.Add(readerTicket["Caja"].ToString());
                    }

                    SqlCommand COMANDOdetalle;
                    string consultaDetalle;
                    SqlDataReader readerDetalle;
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
                    TreeListView1.Nodes.Add(liItem);
                }
            }
        }


        private void BackgroundCajas_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consultaCajas;
            consultaCajas = "Select Nocaja from cajasSucursal";
            adapterCajas = new SqlDataAdapter(consultaCajas, Module1.conexionempresa);
            dataCajas = new DataTable();
            adapterCajas.Fill(dataCajas);
        }

        private void BackgroundCajas_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ComboFiltro.Items.Clear();
            ComboFiltro.Items.Add("Todas");
            foreach (DataRow row in dataCajas.Rows)
                ComboFiltro.Items.Add(row["Nocaja"].ToString());
            ComboFiltro.SelectedIndex = 0;
            My.MyProject.Forms.Cargando.Close();
        }

        private void TicketsPfecha_Load(object sender, EventArgs e)
        {
            dateDesde.Value = DateTime.Now;
            dateHasta.Value = DateTime.Now;
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Información";
            My.MyProject.Forms.Cargando.TopMost = true;
            BackgroundCajas.RunWorkerAsync();
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {

            BackgroundWorker1.RunWorkerAsync();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            foreach (TreeListNode nodee in TreeListView1.Nodes)
                MessageBox.Show(nodee.SubItems[4].Text);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Reportes.Panel1.Visible = false;
            My.MyProject.Forms.Reportes.RadPanorama1.Visible = true;
        }
    }
}