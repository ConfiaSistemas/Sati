using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Windows.Forms;
using MadMilkman.Ini;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace ConfiaAdmin
{
    public sealed partial class SplashScreen1
    {
        private bool hayActualizaciones;
        internal MySqlConnection conexionsql;

        public SplashScreen1()
        {
            InitializeComponent();
        }
        // TODO: Este formulario se puede establecer fácilmente como pantalla de presentación para la aplicación desde la pestaña "Aplicación"
        // del Diseñador de proyectos ("Propiedades" bajo el menú "Proyecto").


        private void SplashScreen1_Load(object sender, EventArgs e)
        {
            // Configure el texto del cuadro de diálogo en tiempo de ejecución según la información del ensamblado de la aplicación.  

            // TODO: Personalice la información del ensamblado de la aplicación en el panel "Aplicación" del cuadro de diálogo 
            // propiedades del proyecto (bajo el menú "Proyecto").

            // Título de la aplicación


            // Dé formato a la información de versión usando el texto establecido en el control de versiones en tiempo de diseño como
            // cadena de formato.  Esto le permite una localización efectiva si lo desea.
            // Se pudo incluir la información de compilación y revisión usando el siguiente código y cambiando el 
            // texto en tiempo de diseño del control de versiones a "Versión {0}.{1:00}.{2}.{3}" o algo parecido.  Consulte
            // String.Format() en la Ayuda para obtener más información.
            // 
            // Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

            // Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

            // Información de Copyright
            // Copyright.Text = My.Application.Info.Copyright
            CheckForIllegalCrossThreadCalls = false;

            Label1.Text = "Buscando Actualizaciones";
            Backgroundmysql.RunWorkerAsync();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            // BunifuTransition1.Hide(Me)
            My.MyProject.Forms.login.Show();
            Close();

        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var options = new IniOptions() { EncryptionPassword = "EntUs01pos" };
            var iniFile = new IniFile(options);
            iniFile.Load(@"C:\ConfiaAdmin\SATI\SetConfig.ini");
            string bdAct;
            string serverAct;
            string cnAct;
            OleDbConnection conexionAct;
            serverAct = iniFile.Sections[0].Keys[0].Value;
            bdAct = iniFile.Sections[0].Keys[1].Value;
            try
            {
                Module1.TipoEquipo = iniFile.Sections[0].Keys["Tipo"].Value;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Module1.TipoEquipo = "";
            }
            // MessageBox.Show("No se encontró el valor leyenda configurado, se recomienda revisar la configuración")
            catch (NullReferenceException ex)
            {
                Module1.TipoEquipo = "";
                // MessageBox.Show("No se encontró el valor leyenda configurado, se recomienda revisar la configuración")
            }

            // TipoEquipo = iniFile.Sections(0).Keys("Tipo").Value

            cnAct = "Provider=sqloledb;" + "Data Source=  " + serverAct + @"\confia;" + "Initial Catalog=" + bdAct + ";" + "User Id=sa;Password=BSi5t3Ma$CFAD;";
            conexionAct = new OleDbConnection(cnAct);
            conexionAct.Open();

            OleDbCommand comandoVersion;
            string consultaVersion;
            string versionAct;
            consultaVersion = "select nversion from versiones where sistema = 'SATI'";
            comandoVersion = new OleDbCommand();
            comandoVersion.Connection = conexionAct;
            comandoVersion.CommandText = consultaVersion;
            versionAct = Conversions.ToString(comandoVersion.ExecuteScalar());


            conexionAct.Close();

            if ((Application.ProductVersion ?? "") != (versionAct ?? ""))
            {
                hayActualizaciones = true;


            }

        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (hayActualizaciones)
            {
                if (MessageBox.Show("Hay una actualización disponible ¿Desea actualizar ahora?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var Proceso = new Process();
                    string ruta = @"C:\ConfiaAdmin\Updater\Updater.exe";
                    Proceso.StartInfo.FileName = ruta;
                    Proceso.StartInfo.Arguments = "/S SATI /T " + Module1.TipoEquipo;
                    Proceso.Start();
                    Application.Exit();
                }
                else
                {
                    Timer1.Interval = 500;
                    Timer1.Enabled = true;
                }
            }


            else
            {
                Timer1.Interval = 500;
                Timer1.Enabled = true;
            }
        }

        private void Backgroundmysql_DoWork(object sender, DoWorkEventArgs e)
        {
            var options = new IniOptions() { EncryptionPassword = "EntUs01pos" };
            var iniFile = new IniFile(options);
            iniFile.Load(@"C:\ConfiaAdmin\SATI\SetConfig.ini");
            string bdAct;
            string serverAct;

            serverAct = iniFile.Sections[0].Keys[0].Value;
            bdAct = iniFile.Sections[0].Keys[1].Value;
            try
            {
                Module1.TipoEquipo = iniFile.Sections[0].Keys["Tipo"].Value;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Module1.TipoEquipo = "";
            }
            // MessageBox.Show("No se encontró el valor leyenda configurado, se recomienda revisar la configuración")
            catch (NullReferenceException ex)
            {
                Module1.TipoEquipo = "";
                // MessageBox.Show("No se encontró el valor leyenda configurado, se recomienda revisar la configuración")
            }
            string versionAct;
            try
            {
                conexionsql = new MySqlConnection();
                conexionsql.ConnectionString = "server=www.prestamosconfia.com;user id=ajas;pwd=123456;port=3306;database=Versiones";
                conexionsql.Open();

                MySqlCommand mysqlcomando;
                string consulta;

                consulta = "select Nversion from Versiones where Sistema = 'SATI'";
                mysqlcomando = new MySqlCommand();
                mysqlcomando.Connection = conexionsql;
                mysqlcomando.CommandText = consulta;

                versionAct = Conversions.ToString(mysqlcomando.ExecuteScalar());
                if ((Application.ProductVersion ?? "") != (versionAct ?? ""))
                {
                    hayActualizaciones = true;


                }

                conexionsql.Close();
            }
            catch (Exception ex)
            {
                hayActualizaciones = false;
            }



        }

        private void Backgroundmysql_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (hayActualizaciones)
            {
                if (MessageBox.Show("Hay una actualización disponible ¿Desea actualizar ahora?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var Proceso = new Process();
                    string ruta = @"C:\ConfiaAdmin\Updater\Updater.exe";
                    Proceso.StartInfo.FileName = ruta;
                    Proceso.StartInfo.Arguments = "/S SATI /T " + Module1.TipoEquipo;
                    Proceso.Start();
                    Application.Exit();
                }
                else
                {
                    Timer1.Interval = 500;
                    Timer1.Enabled = true;
                }
            }


            else
            {
                Timer1.Interval = 500;
                Timer1.Enabled = true;
            }
        }
    }
}