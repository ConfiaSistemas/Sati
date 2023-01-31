using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

using MySql.Data.MySqlClient;

namespace ConfiaAdmin
{
    public partial class SesionesActivas
    {

        private DataTable dataConsulta;
        private MySqlDataAdapter adapterConsulta;
        private string consulta;
        private bool consultar;
        private bool Cerrar;
        private Cargando ncargando;

        public SesionesActivas()
        {
            InitializeComponent();
        }
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                MySqlConnection conexionSesiones;
                conexionSesiones = new MySqlConnection();
                conexionSesiones.ConnectionString = "server=www.prestamosconfia.com;user id=SATISesiones;pwd=123456;port=3306;database=USRS;Convert Zero Datetime=True";
                conexionSesiones.Open();
                adapterConsulta = new MySqlDataAdapter(consulta, conexionSesiones);
                dataConsulta = new DataTable();
                adapterConsulta.Fill(dataConsulta);
                conexionSesiones.Close();
            }


            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BuscarClienteSolicitud_Load(object sender, EventArgs e)
        {
            consulta = "select id,Usuario as Usuario,Empresa,Fecha,Hora,UltimoAcceso,Sistema,ip,Equipo  from Sesiones where Activo = 1";
            ncargando = new Cargando();
            ncargando.Show();

            ncargando.MonoFlat_Label1.Text = "Consultando";
            BackgroundWorker1.RunWorkerAsync();
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtdatos.DataSource = dataConsulta;
            consultar = false;
            ncargando.Close();

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
                    consulta = "select  id,Usuario as Usuario,Empresa,Fecha,Hora,UltimoAcceso,Sistema,ip,Equipo  from Sesiones where Activo = 1 and usuario like '%" + txtnombre.Text + "%'";
                    consultar = true;
                    ncargando = new Cargando();
                    ncargando.MonoFlat_Label1.Text = "Consultando";
                    ncargando.Show();
                    ncargando.TopMost = true;

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





        private void CerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ncargando = new Cargando();
            ncargando.Show();
            ncargando.TopMost = true;
            ncargando.MonoFlat_Label1.Text = "Cerrando la sesión del usuario";
            BackgroundCerrarSesion.RunWorkerAsync();

        }

        private void BackgroundCerrarSesion_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                MySqlConnection conexionSesiones;
                conexionSesiones = new MySqlConnection();
                conexionSesiones.ConnectionString = "server=www.prestamosconfia.com;user id=SATISesiones;pwd=123456;port=3306;database=USRS;Convert Zero Datetime=True";
                conexionSesiones.Open();

                MySqlCommand comandoCerrarSesion;
                string consultaCerrarSesion;
                consultaCerrarSesion = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("update Sesiones set Activo = 0 where id = '", dtdatos.Rows[dtdatos.CurrentRow.Index].Cells[0].Value), "'"));
                comandoCerrarSesion = new MySqlCommand();
                comandoCerrarSesion.CommandText = consultaCerrarSesion;
                comandoCerrarSesion.Connection = conexionSesiones;
                comandoCerrarSesion.ExecuteNonQuery();
                conexionSesiones.Close();
                Cerrar = true;
            }
            catch (MySqlException ex)
            {
                Cerrar = false;
                MessageBox.Show(ex.Message);
            }


        }

        private void BackgroundCerrarSesion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Cerrar)
            {
                MessageBox.Show("Se cerró la sesión del usuario");
                ncargando.MonoFlat_Label1.Text = "Consultando";
                BackgroundWorker1.RunWorkerAsync();
            }

            else
            {
                MessageBox.Show("Hubo un error");
                ncargando.Close();
                ncargando.Dispose();
            }



        }

        private void dtdatos_SelectionChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dtdatos.Rows[dtdatos.CurrentRow.Index].Cells[0].Value.ToString()))
            {
                dtdatos.ContextMenuStrip = ContextCerrarSesion;
            }
            else
            {
                dtdatos.ContextMenuStrip = null;

            }
        }
    }
}