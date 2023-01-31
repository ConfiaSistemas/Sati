using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class CierresPorFecha
    {

        private DataTable dataCajas;
        private SqlDataAdapter adapterCajas;
        private DataTable dataRetiros;
        private SqlDataAdapter adapterRetiros;

        public CierresPorFecha()
        {
            InitializeComponent();
        }


        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // dtdatos.Rows.Clear()

            Module1.iniciarconexionempresa();

            string consulta;
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

            string cajaConsultar;
            switch (ComboFiltro.Text ?? "")
            {
                case "Todas":
                    {
                        consulta = "select id,Caja,UsuarioEntrega,Format(Monto,'C','es-mx') as Monto,Fecha,Hora,UsuarioRecibe,format(MontoRecibido,'C','es-mx') as MontoRecibido,FechaRecibido,HoraRecibido from cierrecajagestores where (fecha >= '" + fechainserciondesde + "' and fecha <= '" + fechainsercionhasta + "') and usuariorecibe<> ''";
                        break;
                    }

                default:
                    {
                        cajaConsultar = ComboFiltro.Text;
                        consulta = "select id,Caja,UsuarioEntrega,Format(Monto,'C','es-mx') as Monto,Fecha,Hora,UsuarioRecibe,format(MontoRecibido,'C','es-mx') as MontoRecibido,FechaRecibido,HoraRecibido from cierrecajagestores where (fecha >= '" + fechainserciondesde + "' and fecha <= '" + fechainsercionhasta + "') and usuariorecibe <> '' and caja = '" + cajaConsultar + "'";
                        break;
                    }

            }


            adapterRetiros = new SqlDataAdapter(consulta, Module1.conexionempresa);
            dataRetiros = new DataTable();
            adapterRetiros.Fill(dataRetiros);

        }

        private void MonoFlat_HeaderLabel3_Click(object sender, EventArgs e)
        {

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

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            // dtdatos.Rows.Clear()
            dtdatos.ScrollBars = ScrollBars.None;
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Consultando";
            My.MyProject.Forms.Cargando.TopMost = true;
            BackgroundWorker1.RunWorkerAsync();

        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtdatos.ScrollBars = ScrollBars.Both;
            dtdatos.DataSource = dataRetiros;
            double total;
            total = 0d;
            foreach (DataGridViewRow row in dtdatos.Rows)
            {
                if (Conversion.Val(row.Cells[7].Value) == 0d)
                {
                    total = Conversions.ToDouble(Operators.AddObject(total, row.Cells[1].Value));
                }
                else
                {
                    total = Conversions.ToDouble(Operators.AddObject(total, row.Cells[7].Value));
                }

            }
            lbltotal.Text = Strings.FormatCurrency(total, 2);
            My.MyProject.Forms.Cargando.Close();

            My.MyProject.Forms.Cargando.TopMost = false;
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            dateDesde.Value = DateTime.Now;
            dateHasta.Value = DateTime.Now;
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Consultando cajas";
            My.MyProject.Forms.Cargando.TopMost = true;
            BackgroundCajas.RunWorkerAsync();

        }

        private void BunifuThinButton23_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.TicketsPfecha.Show();
        }

        private void dtdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Reportes.Panel1.Visible = false;
            My.MyProject.Forms.Reportes.RadPanorama1.Visible = true;
        }
    }
}