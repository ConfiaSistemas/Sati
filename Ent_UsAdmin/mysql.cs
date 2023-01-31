using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace ConfiaAdmin
{
    public partial class mysql
    {
        public mysql()
        {
            InitializeComponent();
        }
        [DllImport("kernel32")]
        private static extern int Beep(int soundFrequency, int soundDuration);
        internal MySqlConnection conexionsql;
        private void mysql_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexionsql = new MySqlConnection();
                conexionsql.ConnectionString = "server=www.prestamosconfia.com;user id=" + UsuarioTxt.Text + ";pwd=" + PswdTxt.Text + ";port=3306;database=Versiones";
                conexionsql.Open();
                MessageBox.Show("Conectado al servidor");
                MySqlCommand mysqlcomando;
                string consulta;
                MySqlDataReader readermysql;
                consulta = "select * from Versiones";
                mysqlcomando = new MySqlCommand();
                mysqlcomando.Connection = conexionsql;
                mysqlcomando.CommandText = consulta;
                readermysql = mysqlcomando.ExecuteReader();
                while (readermysql.Read())
                    MessageBox.Show(Conversions.ToString(readermysql["sistema"]));
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Beep(Conversions.ToInteger(txtfbeep1.Text), Conversions.ToInteger(txtDbeep1.Text));
            Beep(Conversions.ToInteger(txtfbeep2.Text), Conversions.ToInteger(txtDbeep2.Text));
            Beep(Conversions.ToInteger(txtfbeep3.Text), Conversions.ToInteger(txtDbeep3.Text));
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // Creamos un nuevo objeto MailMessage donde especificamos el "From" y el "To"
            var correo = new System.Net.Mail.MailMessage("sistemas@prestamosconfia.com", "jjah.jairo@gmail.com");
            correo.Subject = "Probando el asunto";
            correo.Body = "Estamos realizando una prueba";
            var cliente = new System.Net.Mail.SmtpClient();
            // Creamos el objeto que va a "preparar" la autentificación
            var autentificacion = new System.Net.NetworkCredential("sistemas@prestamosconfia.com", "Si5t3Ma$CFIA");
            var smtp = new System.Net.Mail.SmtpClient();
            // Incluimos esta información a la hora de logarnos en el servidor
            smtp.Host = "p3plcpnl0962.prod.phx3.secureserver.net";
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = autentificacion;
            smtp.Port = 587;
            smtp.Send(correo);
        }
    }
}