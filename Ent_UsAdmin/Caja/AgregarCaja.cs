using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConfiaAdmin
{

    public partial class AgregarCaja
    {
        private bool conerror;
        public bool autorizado;

        public AgregarCaja()
        {
            InitializeComponent();
        }
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {
                Module1.iniciarconexionempresa();
                SqlCommand comandoInsertaCaja;
                string consultaInsertaCaja;
                consultaInsertaCaja = "insert into CajasSucursal values('" + txtNocaja.Text + "','" + txtFondo.Text + "','" + txtlimite.Text + "')";
                comandoInsertaCaja = new SqlCommand();
                comandoInsertaCaja.Connection = Module1.conexionempresa;
                comandoInsertaCaja.CommandText = consultaInsertaCaja;
                comandoInsertaCaja.ExecuteNonQuery();
                conerror = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conerror = true;
            }


        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();
            if (conerror)
            {
            }
            else
            {
                txtFondo.Text = "";
                txtNocaja.Text = "";
                txtNocaja.Select();
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Autorizacion.tipoAutorizacion = "SatiModCajasAgregar";
            My.MyProject.Forms.Autorizacion.ShowDialog();
            if (autorizado)
            {
                My.MyProject.Forms.Cargando.Show();
                My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Insertando Caja";
                BackgroundWorker1.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("No fue autorizado");
            }

        }

        private void AgregarCaja_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

        }

        private void AgregarCaja_FormClosing(object sender, FormClosingEventArgs e)
        {
            Invoke(new Action(() => My.MyProject.Forms.Cajas.cargarCajas()));
        }
    }
}