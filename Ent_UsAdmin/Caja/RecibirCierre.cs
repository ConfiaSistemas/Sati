using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class RecibirCierre
    {

        public bool autorizado;
        public int idRetiro;
        public double Cantidad;
        private DataTable dataTickets;
        private SqlDataAdapter adapterTickets;
        private Cargando nCargando;

        public RecibirCierre()
        {
            InitializeComponent();
        }
        private void RecibirRetiro_Load(object sender, EventArgs e)
        {
            lblMonto.Text = Strings.FormatCurrency(Cantidad, 2);
            nCargando = new Cargando();
            nCargando.MonoFlat_Label1.Text = "Cargando";
            nCargando.Show();
            BackgroundDetalleCierre.RunWorkerAsync();
        }

        private void MonoFlat_Button1_Click(object sender, EventArgs e)
        {

            BackgroundWorker1.RunWorkerAsync();


        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string fechainsercionhasta;
            double monto;
            string fechaRetiro;
            string concepto;
            monto = Conversions.ToDouble(txtmonto.Text);
            string tiempo = DateAndTime.TimeOfDay.ToString("HH:mm:ss");
            fechainsercionhasta = Conversions.ToString(DateTime.Now.Date);

            DateTime fechasqlhasta;
            fechasqlhasta = Conversions.ToDate(fechainsercionhasta);
            fechainsercionhasta = Strings.Format(fechasqlhasta, "yyyy-MM-dd");
            fechaRetiro = Strings.Format(fechasqlhasta, "dd/MM/yyyy");
            SqlCommand comandoRecibirRetiro;
            string consultaRetiro;
            consultaRetiro = "update cierrecajagestores set MontoRecibido = '" + txtmonto.Text + "',fechaRecibido = '" + fechainsercionhasta + "',usuariorecibe = '" + Module1.nmusr + "',horarecibido = '" + tiempo + "' where id = '" + idRetiro + "'";
            comandoRecibirRetiro = new SqlCommand();
            comandoRecibirRetiro.Connection = Module1.conexionempresa;
            comandoRecibirRetiro.CommandText = consultaRetiro;
            comandoRecibirRetiro.ExecuteNonQuery();

        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            My.MyProject.Forms.Cargando.Close();
            Invoke(new Action(() => My.MyProject.Forms.CierresSinRecibir.CargarRetiros()));

            Close();
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

        private void BackgroundDetalleCierre_DoWork(object sender, DoWorkEventArgs e)
        {
            string consultaDetalleCierre;
            Module1.iniciarconexionempresa();
            consultaDetalleCierre = "select dc.id,dc.idTicket,dc.MontoTicket,Ticket.Fecha from detallecierrecajagestores dc inner join ticket on dc.idticket = ticket.id where dc.idcierre = '" + idRetiro + "'";
            adapterTickets = new SqlDataAdapter(consultaDetalleCierre, Module1.conexionempresa);
            dataTickets = new DataTable();
            adapterTickets.Fill(dataTickets);

        }

        private void BackgroundDetalleCierre_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtimpuestos.DataSource = dataTickets;
            nCargando.Close();
        }
    }
}