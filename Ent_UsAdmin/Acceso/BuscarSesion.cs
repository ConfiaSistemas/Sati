using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

using MySql.Data.MySqlClient;

namespace ConfiaAdmin
{
    public partial class BuscarSesion
    {

        private DataTable dataConsulta;
        private MySqlDataAdapter adapterConsulta;
        private string consulta;
        private bool consultar;

        public BuscarSesion()
        {
            InitializeComponent();
        }
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            MySqlConnection conexionSesiones;
            conexionSesiones = new MySqlConnection();
            conexionSesiones.ConnectionString = "server=www.prestamosconfia.com;user id=ajas;pwd=123456;port=3306;database=USRS;Convert Zero Datetime=True";
            conexionSesiones.Open();
            adapterConsulta = new MySqlDataAdapter(consulta, conexionSesiones);
            dataConsulta = new DataTable();
            adapterConsulta.Fill(dataConsulta);
        }

        private void BuscarClienteSolicitud_Load(object sender, EventArgs e)
        {
            consulta = "select id,Usuario as Usuario,Empresa,UltimoAcceso,Sistema  from Sesiones where Activo = 1";
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Consultando";
            BackgroundWorker1.RunWorkerAsync();
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtdatos.DataSource = dataConsulta;
            consultar = false;
            My.MyProject.Forms.Cargando.Close();
        }



        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (consultar)
                {
                    MessageBox.Show("Consultando espere...");
                }
                else
                {
                    consulta = "select id,Usuario as Usuario,Empresa,UltimoAcceso,Sistema  from Sesiones where Activo = 1 and usuario like '%" + txtnombre.Text + "%'";
                    consultar = true;
                    My.MyProject.Forms.Cargando.Show();
                    My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Consultando";
                    if (BackgroundWorker1.IsBusy == true)
                    {
                    }
                    else
                    {
                        BackgroundWorker1.RunWorkerAsync();
                    }

                }

            }
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

        private void txtnombre_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void dtdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtdatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            My.MyProject.Forms.CrearNotificacion.txtIdSesion.Text = Conversions.ToString(dtdatos.CurrentRow.Cells[0].Value);
            My.MyProject.Forms.CrearNotificacion.txtUsuario.Text = Conversions.ToString(dtdatos.CurrentRow.Cells[1].Value);

            Close();
        }

        private void dtdatos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                My.MyProject.Forms.CrearNotificacion.txtIdSesion.Text = Conversions.ToString(dtdatos.CurrentRow.Cells[0].Value);
                My.MyProject.Forms.CrearNotificacion.txtUsuario.Text = Conversions.ToString(dtdatos.CurrentRow.Cells[1].Value);

                Close();
            }
        }
    }
}