using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class EmpresasOrigenDocSolicitud
    {

        private bool conectado;
        private string ipPrueba;
        private string bdPrueba;

        public EmpresasOrigenDocSolicitud()
        {
            InitializeComponent();
        }
        private void MonoFlat_ThemeContainer1_Click(object sender, EventArgs e)
        {

        }

        private void Empresas_Load(object sender, EventArgs e)
        {
            try
            {
                bool acceso=false ;
                foreach (DataRow row in Module1.dataPermisos.Rows)
                    acceso = Conversions.ToBoolean(row["SatiAcceso"]);
                CheckForIllegalCrossThreadCalls = false;
                if (acceso)
                {
                    try
                    {
                        // 
                        Module1.iniciarconexion();
                        string sql;
                        OleDbCommand comando;
                        OleDbDataReader milector;

                        comando = new OleDbCommand();

                        comando.Connection = Module1.conexion;
                        sql = "select rs,ip,bd,nombre from empresas";
                        comando.CommandText = sql;
                        milector = comando.ExecuteReader();
                        while (milector.Read())
                        {
                            var botonempresa = new Bunifu.Framework.UI.BunifuFlatButton();

                            botonempresa.Normalcolor = Color.FromArgb(48, 55, 76);
                            botonempresa.Iconimage = My.Resources.Resources.empresa_azul;
                            botonempresa.Size = new Size(390, 48);
                            botonempresa.Name = Conversions.ToString(milector["bd"]);
                            botonempresa.Text = Conversions.ToString(milector["nombre"]);
                            botonempresa.Tag = milector["ip"];
                            botonempresa.Click += clickevenntAsync;
                            FlowLayoutPanel1.Controls.Add(botonempresa);
                        }
                        milector.Close();
                    }


                    // Timer1.Enabled = True
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("El usuario no tiene acceso al sistema");
                    Close();
                }
            }
            catch (Exception ex)
            {

            }



        }
        private async void clickevenntAsync(object sender, EventArgs e)
        {
            if (ModifierKeys == Keys.Control)
            {

            }
            if (Module1.usuarioActivo)
            {
                try
                {
                    // Dim iniFile As New IniFile()
                    // iniFile.Load("C:\Modulo\SetConfig.ini")
                    // Dim section As IniSection = iniFile.Sections.Add("Sucursal")
                    // section.Keys.Add("BdSucursal", sender.name)
                    Bunifu.Framework.UI.BunifuFlatButton b = (Bunifu.Framework.UI.BunifuFlatButton)sender;
                    My.MyProject.Forms.TraspasarDocumentosSolicitud.ipOrigen = Conversions.ToString(b.Tag);
                    // Save and encrypt the file.
                    // iniFile.Save("C:\Modulo\SetConfig.ini")
                    My.MyProject.Forms.TraspasarDocumentosSolicitud.bdOrigen = Conversions.ToString(b.Name);

                    ipPrueba = Conversions.ToString(b.Tag);
                    bdPrueba = Conversions.ToString(b.Name);
                    // iniFile.Sections.Clear()
                    // MessageBox.Show("Listo")
                    // iniciarconexionempresa()

                    My.MyProject.Forms.Cargando.Show();
                    My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Intentando Conexión";
                    FlowLayoutPanel1.Enabled = false;







                    await Task.Factory.StartNew(() => { if (IntentaConexion() == true) { conectado = true; } else { MessageBox.Show("Pruebe de nuevo o verifique su configuración"); FlowLayoutPanel1.Enabled = true; conectado = false; My.MyProject.Forms.Cargando.Close(); } });


                    if (conectado)
                    {


                        My.MyProject.Forms.Cargando.Close();
                        My.MyProject.Forms.TraspasarDocumentosSolicitud.lblOrigen.Text = Conversions.ToString(b.Text);

                        Close();
                    }
                    else
                    {
                        My.MyProject.Forms.TraspasarDocumentosSolicitud.lblOrigen.Text = "No se pudo conectar";
                        My.MyProject.Forms.Cargando.Close();
                    }
                }

                // Me.Close()


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else
            {
                MessageBox.Show("El usuario no está activo, no puedes acceder");
            }

        }

        private bool IntentaConexion()
        {

            try
            {
                SqlConnection IntentoConexion;
                string cnConexion;
                cnConexion = "Data Source=  " + ipPrueba + @"\confia;" + "Initial Catalog=" + bdPrueba + ";" + "User Id=sa;Password=BSi5t3Ma$CFAD;MultipleActiveResultSets=true";
                IntentoConexion = new SqlConnection(cnConexion);
                IntentoConexion.Open();
                return true;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("No se puede conectar con el servidor");
                return false;
            }


        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public object getMacAddress()
        {
            var nics = NetworkInterface.GetAllNetworkInterfaces();
            return nics[1].GetPhysicalAddress().ToString();
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