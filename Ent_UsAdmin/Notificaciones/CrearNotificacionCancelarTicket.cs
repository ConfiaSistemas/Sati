using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ConfiaAdmin
{

    public partial class CrearNotificacionCancelarTicket
    {
        public string idTicket;
        private DataTable dataUsuarios;
        private MySqlDataAdapter adapterUsuarios;
        private Cargando nCargando;
        private bool creada;

        public CrearNotificacionCancelarTicket()
        {
            InitializeComponent();
        }

        private void CrearNotificacionCancelarTicket_Load(object sender, EventArgs e)
        {
            lblTicket.Text = idTicket;
            nCargando = new Cargando();
            nCargando.Show();
            nCargando.MonoFlat_Label1.Text = "Consultando usuarios";
            nCargando.TopMost = true;
            BackgroundWorker1.RunWorkerAsync();


        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            MySqlConnection conexionUsuarios;
            conexionUsuarios = new MySqlConnection();
            conexionUsuarios.ConnectionString = "server=www.prestamosconfia.com;user id=ajas;pwd=123456;port=3306;database=USRS";
            conexionUsuarios.Open();


            string consulta;


            consulta = "select Usr.nm,Usr.nm_complete from Usr inner join grp on Usr.grp = grp.id inner join PermisosGrupo on grp.id = PermisosGrupo.idGrupo where PermisosGrupo.SacCancelarTicket = 1";
            adapterUsuarios = new MySqlDataAdapter(consulta, conexionUsuarios);
            dataUsuarios = new DataTable();
            adapterUsuarios.Fill(dataUsuarios);



        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ComboUsuarios.Clear();
            foreach (DataRow row in dataUsuarios.Rows)
                ComboUsuarios.AddItem(row["nm"].ToString());
            ComboUsuarios.selectedIndex = 0;
            nCargando.Close();
        }

        private void ComboUsuarios_onItemSelected(object sender, EventArgs e)
        {
            foreach (DataRow row in dataUsuarios.Rows)
            {
                if ((row["nm"].ToString() ?? "") == (ComboUsuarios.selectedValue ?? ""))
                {
                    lblNombreUsuario.Text = row["nm_complete"].ToString();
                    break;
                }
            }

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
                consultaLogin = "insert into Notificaciones values(null,'CancelarTicket',1,'" + Module1.nmusr + "','" + ComboUsuarios.selectedValue + "','" + idTicket + "','','" + txtComentario.Text + "',0,'0','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("HH:mm:ss") + "',0,'','','" + Module1.nombreAmostrar + "','',''); ";
                comandoLogin = new MySqlCommand();
                comandoLogin.Connection = conexionLogin;
                comandoLogin.CommandText = consultaLogin;
                comandoLogin.ExecuteNonQuery();
                conexionLogin.Close();
                creada = true;
            }
            catch (MySqlException ex)
            {
                creada = false;
                MessageBox.Show(ex.Message);
            }

        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            nCargando = new Cargando();
            nCargando.Show();
            nCargando.MonoFlat_Label1.Text = "Notificando";
            nCargando.TopMost = true;
            BunifuThinButton21.Enabled = false;

            BackgroundNotificacion.RunWorkerAsync();


        }

        private void BackgroundNotificacion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (creada)
            {
                MessageBox.Show("Notificación creada con éxito");
                BunifuThinButton21.Enabled = true;
                nCargando.Close();
                Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error, inténtelo de nuevo");
                BunifuThinButton21.Enabled = true;
                nCargando.Close();
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
    }
}