using System;
using System.ComponentModel;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ConfiaAdmin
{

    public partial class CrearNotificacion
    {
        private bool Creada;
        private Cargando ncargando;

        public CrearNotificacion()
        {
            InitializeComponent();
        }
        private void btnSesiones_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.BuscarSesion.Show();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ncargando = new Cargando();
            ncargando.Show();
            ncargando.MonoFlat_Label1.Text = "Creando Notificación";
            ncargando.TopMost = true;
            Button1.Enabled = false;
            BackgroundNotificacion.RunWorkerAsync();

        }

        private void BackgroundNotificacion_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                MySqlConnection conexionLogin;
                conexionLogin = new MySqlConnection();
                conexionLogin.ConnectionString = "server=www.prestamosconfia.com;user id=ajas;pwd=123456;port=3306;database=USRS";
                conexionLogin.Open();
                MySqlCommand comandoLogin;
                string consultaLogin;
                consultaLogin = "insert into Notificaciones values(null,'" + ComboTipo.Text + "',0,'" + Module1.nmusr + "','" + txtUsuario.Text + "','','" + txtMensaje.Text + "','',0,'" + txtIdSesion.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("HH:mm:ss") + "','0','','','','',''); ";
                comandoLogin = new MySqlCommand();
                comandoLogin.Connection = conexionLogin;
                comandoLogin.CommandText = consultaLogin;
                comandoLogin.ExecuteNonQuery();
                conexionLogin.Close();
                Creada = true;
            }
            catch (MySqlException ex)
            {
                Creada = false;
                MessageBox.Show(ex.Message);
            }

        }

        private void BackgroundNotificacion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Creada)
            {
                MessageBox.Show("Notificación creada con éxito");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error, inténtelo de nuevo");
            }
            Button1.Enabled = true;
            ncargando.Close();
        }
    }
}