using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MadMilkman.Ini;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class Run
    {
        private string comando;
        private string[] comandoArray;

        public Run()
        {
            InitializeComponent();
        }

        // Dim i As Integer
        private void txtcmd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                comando = txtcmd.Text;
                int x;
                int cantItems = 0;
                x = 0;
                // comando = comando.Replace(" "c, String.Empty)
                var regex = new Regex(@"[\s*]|([=])");
                comandoArray = regex.Split(comando);
                for (int i = 0, loopTo = comandoArray.Count() - 1; i <= loopTo; i++)
                {
                    if (!string.IsNullOrEmpty(comandoArray[i]))
                    {
                        cantItems += 1;

                    }
                }


                // comandoArray = Regex.Split(comando, "\s+")
                var tempArray = new string[cantItems + 1];
                for (int i = 0, loopTo1 = comandoArray.Count() - 1; i <= loopTo1; i++)
                {
                    if (!string.IsNullOrEmpty(comandoArray[i]))
                    {
                        tempArray[x] = comandoArray[i];
                        x = x + 1;

                    }
                }

                for (int i = 0, loopTo2 = tempArray.Count() - 1; i <= loopTo2; i++)
                {
                    // MessageBox.Show(tempArray(i))
                    if (tempArray[i].Equals("SET", StringComparison.InvariantCultureIgnoreCase))
                    {
                        if (!string.IsNullOrEmpty(tempArray[i + 1]))
                        {

                            if (tempArray[i + 1].Equals("TYPE", StringComparison.InvariantCultureIgnoreCase))
                            {
                                if (tempArray[i + 2] == "=")
                                {
                                    Module1.TipoEquipo = tempArray[i + 3];
                                    var options = new IniOptions() { EncryptionPassword = "EntUs01pos" };
                                    var file = new IniFile(options);

                                    var section = file.Sections.Add("Conexión");
                                    section.Keys.Add("Ip", Module1.ipser);
                                    section.Keys.Add("Base", Module1.bdser);
                                    // section.Keys.Add("Caja", txtcaja.Text)
                                    section.Keys.Add("Impresora", Module1.ImpresoraPredeterminada);
                                    section.Keys.Add("Tipo", Module1.TipoEquipo);
                                    // Save and encrypt the file.
                                    file.Save(@"C:\ConfiaAdmin\SATI\SetConfig.ini");

                                    file.Sections.Clear();
                                    // ipser = txtIp.Text
                                    // bdser = txtBD.Text
                                    // ImpresoraPredeterminada = ComboImpresora.Text
                                    MessageBox.Show("Se ha marcado este equipo como " + Module1.TipoEquipo);
                                    Close();
                                    break;
                                }
                                else
                                {
                                    MessageBox.Show("No se reconoce el caracter " + tempArray[i + 2]);
                                    break;
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se reconoce el comando " + tempArray[i + 1]);
                                break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("SET necesita más argumentos");
                        }
                    }


                    else if (tempArray[i].Equals("Migrate", StringComparison.InvariantCultureIgnoreCase))
                    {

                        My.MyProject.Forms.Migrar.Show();


                        Close();
                        break;
                    }
                    else if (tempArray[i].Equals("PruebaDatosSolicitud", StringComparison.InvariantCultureIgnoreCase))
                    {

                        My.MyProject.Forms.DatosSolicitud.Show();
                        Close();
                        break;
                    }
                    else if (tempArray[i].Equals("INFO", StringComparison.InvariantCultureIgnoreCase))
                    {
                        if (!string.IsNullOrEmpty(tempArray[i + 1]))
                        {
                            if (tempArray[i + 1].Equals("credito", StringComparison.InvariantCultureIgnoreCase))
                            {
                                if (tempArray[i + 2].Equals("/id", StringComparison.InvariantCultureIgnoreCase))
                                {

                                    if (tempArray[i + 3] == "=")
                                    {
                                        var frmInformacion = new InformacionSolicitud();
                                        frmInformacion.idCredito = Conversions.ToInteger(tempArray[i + 4]);
                                        frmInformacion.Show();
                                        Close();
                                        break;
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se reconoce el caracter " + tempArray[i + 3]);
                                        break;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No se reconoce el caracter " + tempArray[i + 2]);
                                    break;
                                }
                            }
                            else if (tempArray[i + 1].Equals("solicitud", StringComparison.InvariantCultureIgnoreCase))
                            {
                                if (tempArray[i + 2].Equals("/id", StringComparison.InvariantCultureIgnoreCase))
                                {

                                    if (tempArray[i + 3] == "=")
                                    {

                                        My.MyProject.Forms.DatosConsultaSolicitud.idSolicitud = Conversions.ToInteger(tempArray[i + 4]);
                                        My.MyProject.Forms.DatosConsultaSolicitud.Show();
                                        Close();
                                        break;
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se reconoce el caracter " + tempArray[i + 3]);
                                        break;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No se reconoce el caracter " + tempArray[i + 2]);
                                    break;
                                }
                            }
                            else
                            {

                                MessageBox.Show("No se reconoce el comando " + tempArray[i + 1]);
                                break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Info necesita más argumentos");
                            break;
                        }
                    }

                    else if (tempArray[i].Equals("GET", StringComparison.InvariantCultureIgnoreCase))
                    {

                        if (!string.IsNullOrEmpty(tempArray[i + 1]))
                        {
                            if (tempArray[i + 1].Equals("type", StringComparison.InvariantCultureIgnoreCase))
                            {
                                MessageBox.Show("Éste equipo es: " + Module1.TipoEquipo);
                                break;
                            }

                            else
                            {
                                MessageBox.Show("No se reconoce el comando " + tempArray[i + 1]);
                                break;
                            }
                        }

                        else
                        {
                            MessageBox.Show("Get necesita más argumentos");
                            break;
                        }
                    }
                    else if (tempArray[i].Equals("RESIZEimage", StringComparison.InvariantCultureIgnoreCase))
                    {
                        My.MyProject.Forms.ComprimirImagenes.Show();
                        break;
                        Close();
                    }
                    else if (tempArray[i].Equals("mysql", StringComparison.InvariantCultureIgnoreCase))
                    {
                        My.MyProject.Forms.mysql.Show();
                        Close();
                        break;
                    }

                    else if (tempArray[i].Equals("Notificacion", StringComparison.InvariantCultureIgnoreCase))
                    {
                        My.MyProject.Forms.CrearNotificacion.Show();
                        Close();
                        break;
                    }
                    else if (tempArray[i].Equals("Sesiones", StringComparison.InvariantCultureIgnoreCase))
                    {
                        My.MyProject.Forms.SesionesActivas.Show();
                        Close();
                        break;
                    }
                    else if (tempArray[i].Equals("TraspasoDocumentos", StringComparison.InvariantCultureIgnoreCase))
                    {
                        My.MyProject.Forms.TraspasarDocumentosSolicitud.Show();
                        Close();
                        break;
                    }
                    else if (tempArray[i].Equals("EmpresasPermitidas", StringComparison.InvariantCultureIgnoreCase))
                    {
                        My.MyProject.Forms.EmpresasPermitidas.Show();
                        Close();
                        break;
                    }
                    else if (tempArray[i].Equals("DisableSession", StringComparison.InvariantCultureIgnoreCase))
                    {
                        My.MyProject.Forms.frm_adm.TimerActSesion.Stop();

                        My.MyProject.Forms.frm_adm.TimerActSesion.Enabled = false;
                        MessageBox.Show("Sesión deshabilitada");
                        break;
                    }

                    else if (tempArray[i].Equals("EnableSession", StringComparison.InvariantCultureIgnoreCase))
                    {
                        My.MyProject.Forms.frm_adm.TimerActSesion.Enabled = true;
                        My.MyProject.Forms.frm_adm.TimerActSesion.Start();
                        MessageBox.Show("Sesión habilitada");
                        break;
                    }


                    else if (tempArray[i].Equals("La-niña-mas-hermosa-del-mundo-mundial", StringComparison.InvariantCultureIgnoreCase))
                    {
                        My.MyProject.Forms.VistaDocumento.PictureBox1.Image = Image.FromFile(@"C:\Users\SVRCONFIAUPN\Downloads\WhatsApp Image 2021-05-20 at 12.41.42 AM.jpeg");
                        My.MyProject.Forms.VistaDocumento.ShowDialog();
                        Close();
                        break;
                    }
                    else if (tempArray[i].Equals("tcp", StringComparison.InvariantCultureIgnoreCase))
                    {
                        ClienteTCP tc = new ClienteTCP();
                        tc.Show();

                        Close();
                        break;
                    }
                    else
                    {



                        MessageBox.Show("No se reconoce el comando " + tempArray[i]);
                        break;
                    }
                }


                // If txtcmd.Text.Equals("Migrate", StringComparison.InvariantCultureIgnoreCase) Then
                // Migrar.Show()
                // Me.Close()

                // End If
                // If txtcmd.Text.Equals("PruebaDatosSolicitud", StringComparison.InvariantCultureIgnoreCase) Then
                // DatosSolicitud.Show()
                // Me.Close()

                // End If
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

        private void txtcmd_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Run_Load(object sender, EventArgs e)
        {

        }
    }
}