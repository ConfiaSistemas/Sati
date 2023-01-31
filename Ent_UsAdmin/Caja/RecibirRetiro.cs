using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class RecibirRetiro
    {
        public bool autorizado;
        public int idRetiro;
        public double Cantidad;

        public RecibirRetiro()
        {
            InitializeComponent();
        }
        private void RecibirRetiro_Load(object sender, EventArgs e)
        {
            lblMonto.Text = Strings.FormatCurrency(Cantidad, 2);
        }

        private void MonoFlat_Button1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.AutorizacionRetiro.ShowDialog();
            if (autorizado)
            {
                My.MyProject.Forms.Cargando.Show();
                My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Recibiendo";
                My.MyProject.Forms.Cargando.TopMost = true;
                BackgroundWorker1.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("No fue autorizado");
            }
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
            consultaRetiro = "update Retiros set MontoRecibido = '" + txtmonto.Text + "',fechaRecibido = '" + fechainsercionhasta + "',usuariorecibe = '" + Module1.nmusr + "',horarecibido = '" + tiempo + "' where id = '" + idRetiro + "'";
            comandoRecibirRetiro = new SqlCommand();
            comandoRecibirRetiro.Connection = Module1.conexionempresa;
            comandoRecibirRetiro.CommandText = consultaRetiro;
            comandoRecibirRetiro.ExecuteNonQuery();

        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            My.MyProject.Forms.Cargando.Close();
            Invoke(new Action(() => My.MyProject.Forms.Retiros.CargarRetiros()));

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
    }
}