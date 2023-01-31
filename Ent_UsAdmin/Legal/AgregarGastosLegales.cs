using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConfiaAdmin
{

    public partial class AgregarGastosLegales
    {
        public string idCredito;

        public AgregarGastosLegales()
        {
            InitializeComponent();
        }

        private void AgregarGastosLegales_Load(object sender, EventArgs e)
        {

        }

        private void BackgroundGastos_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            SqlCommand comandoGastos;
            string consultaGastos;
            consultaGastos = "insert into GastosLegales values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + idCredito + "','" + txtMonto.Text + "','" + txtConcepto.Text + "','" + Module1.nmusr + "','" + Module1.nm_completeusr + "')";
            comandoGastos = new SqlCommand();
            comandoGastos.Connection = Module1.conexionempresa;
            comandoGastos.CommandText = consultaGastos;
            comandoGastos.ExecuteNonQuery();

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Insertando Gastos";
            My.MyProject.Forms.Cargando.TopMost = true;
            BackgroundGastos.RunWorkerAsync();
        }

        private void BackgroundGastos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            Invoke(new Action(() => My.MyProject.Forms.InformacionLegal.BackgroundClientes.RunWorkerAsync()));
            My.MyProject.Forms.Cargando.Close();
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