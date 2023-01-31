using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace ConfiaAdmin
{

    public partial class Empresas
    {
        private bool conectado;
        public bool Actualizado;
        private int heightAgregarEmpresa = 0;

        private bool Dabajo = false;

        public Empresas()
        {
            InitializeComponent();
        }
        private void MonoFlat_ThemeContainer1_Click(object sender, EventArgs e)
        {

        }

        private void Empresas_Load(object sender, EventArgs e)
        {
            Panel2.Height = 0;

            try
            {
                bool acceso =false;
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
                        sql = "select rs,ip,bd,nombre,id from empresas where id in (select idempresa from empresaspermitidas where idusuario = '" + Module1.idusr + "')";
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
                            var checkEmpresa = new CheckBox();
                            checkEmpresa.Text = "holaaaaa";
                            checkEmpresa.Visible = false;
                            // checkEmpresa.Location = New Point(botonempresa.Width - checkEmpresa.Width, botonempresa.Height - checkEmpresa.Height)
                            checkEmpresa.BringToFront();
                            // checkEmpresa.Parent = botonempresa
                            checkEmpresa.ForeColor = Color.White;
                            checkEmpresa.Name = Conversions.ToString(milector["nombre"]);
                            checkEmpresa.Tag = milector["id"];
                            checkEmpresa.Size = new Size(20, 20);
                            Invoke(new Action(() => FlowLayoutPanel1.Controls.Add(checkEmpresa)));


                        }
                        milector.Close();
                        OleDbDataAdapter adapterEmpresas;
                        adapterEmpresas = new OleDbDataAdapter(sql, Module1.conexion);
                        Module1.dataEmpresas = new DataTable();
                        adapterEmpresas.Fill(Module1.dataEmpresas);
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
            Bunifu.Framework.UI.BunifuFlatButton b = (Bunifu.Framework.UI.BunifuFlatButton)sender;
            if (ModifierKeys == Keys.Control)
            {
                My.MyProject.Forms.ModificarEmpresa.nombreEmpresaSeleccionada = Conversions.ToString(b.Text);
                My.MyProject.Forms.ModificarEmpresa.ipEmpresaSeleccionada = Conversions.ToString(b.Tag);
                My.MyProject.Forms.ModificarEmpresa.bdEmpresaSeleccionada = Conversions.ToString(b.Name);
                My.MyProject.Forms.ModificarEmpresa.Show();
            }


            else if (Module1.usuarioActivo)
            {
                try
                {
                    // Dim iniFile As New IniFile()
                    // iniFile.Load("C:\Modulo\SetConfig.ini")
                    // Dim section As IniSection = iniFile.Sections.Add("Sucursal")
                    // section.Keys.Add("BdSucursal", sender.name)

                    Module1.bdconsultas = Conversions.ToString(b.Name);
                    // Save and encrypt the file.
                    // iniFile.Save("C:\Modulo\SetConfig.ini")
                    Module1.ipconsultas = Conversions.ToString(b.Tag);

                    // iniFile.Sections.Clear()
                    // MessageBox.Show("Listo")
                    // iniciarconexionempresa()
                    My.MyProject.Forms.Cargando.Show();
                    My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Intentando Conexión";
                    FlowLayoutPanel1.Enabled = false;







                    await Task.Factory.StartNew(() =>
                    {
                        if (IntentaConexion() == true)
                        {
                            OleDbCommand comando; string consulta; OleDbDataReader reader; comando = new OleDbCommand(); consulta = "select id,rs,RFC,Calle,Nex,Col,Ciudad,Estado,CP,nombre,telefono,prefijo,correo,passwordcorreo FROM empresas where BD = '" + Module1.bdconsultas + "' and ip = '" + Module1.ipconsultas + "'"; comando.Connection = Module1.conexion; comando.CommandText = consulta; reader = comando.ExecuteReader(); while (reader.Read()) { Module1.NombreEmpresa = Conversions.ToString(reader["rs"]); Module1.RFCEmpresa = Conversions.ToString(reader["RFC"]); Module1.CalleEmpresa = Conversions.ToString(reader["Calle"]); Module1.NumeroEmpresa = Conversions.ToString(reader["Nex"]); Module1.ColEmpresa = Conversions.ToString(reader["Col"]); Module1.CiudadEmpresa = Conversions.ToString(reader["Ciudad"]); Module1.EstadoEmpresa = Conversions.ToString(reader["Estado"]); Module1.CPEmpresa = Conversions.ToString(reader["CP"]); Module1.nombreAmostrar = Conversions.ToString(reader["Nombre"]); Module1.idEmpresa = Conversions.ToString(reader["id"]); Module1.telEmpresa = Conversions.ToString(reader["Telefono"]); Module1.prefijoEmpresa = Conversions.ToString(reader["prefijo"]); Module1.correoEmpresa = Conversions.ToString(reader["correo"]); Module1.passwordCorreoEmpresa = Conversions.ToString(reader["passwordcorreo"]); }
                            string consultaCorreos; consultaCorreos = "select * from correosempresas where idempresa = (select id from empresas where BD = '" + Module1.bdconsultas + "' and ip = '" + Module1.ipconsultas + "')"; Module1.adapterCorreos = new OleDbDataAdapter(consultaCorreos, Module1.conexion); Module1.dataCorreos = new DataTable(); Module1.adapterCorreos.Fill(Module1.dataCorreos); Module1.iniciarconexionempresa(); SqlCommand comandoEmpleado; string consultaEmpleado; consultaEmpleado = "IF EXISTS((select * from empleadosAsignados where usr = '" + Module1.nmusr + @"'))
BEGIN
select idempleado from empleadosAsignados where usr = '" + Module1.nmusr +                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     // MessageBox.Show(ip.AddressList(4).ToString)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               // MessageBox.Show(My.Computer.Name.ToString)

// IO.File.AppendAllText("C:\ConfiaAdmin\SATI\Log.txt", String.Format("{0}{1}", Environment.NewLine, ex.ToString()))





@"' end
else
begin
select '0'
end"; comandoEmpleado = new SqlCommand(); comandoEmpleado.Connection = Module1.conexionempresa; comandoEmpleado.CommandText = consultaEmpleado; Module1.EmpleadoAsignado = Conversions.ToInteger(comandoEmpleado.ExecuteScalar()); Module1.Docs(); Module1.Colonias(); conectado = true; try { System.Net.IPHostEntry ip; ip = System.Net.Dns.GetHostEntry(My.MyProject.Computer.Name); MySqlConnection conexionLogin; conexionLogin = new MySqlConnection(); conexionLogin.ConnectionString = "server=www.prestamosconfia.com;user id=SATISesiones;password=123456;persistsecurityinfo=True;port=3306;database=USRS"; conexionLogin.Open(); MySqlCommand comandoEmpresaLogin; string consultaEmpresaLogin; consultaEmpresaLogin = "update Sesiones set Empresa = '" + Module1.nombreAmostrar + "',ip='" + ip.AddressList[4].ToString() + "',Equipo='" + My.MyProject.Computer.Name.ToString() + "' where id = '" + Module1.idSesion + "'"; comandoEmpresaLogin = new MySqlCommand(); comandoEmpresaLogin.Connection = conexionLogin; comandoEmpresaLogin.CommandText = consultaEmpresaLogin; comandoEmpresaLogin.ExecuteNonQuery(); conexionLogin.Close(); } catch (Exception ex) { }
                            Invoke(new Action(() => My.MyProject.Forms.frm_adm.BackgroundNotificaciones.RunWorkerAsync()));
                        }
                        else { MessageBox.Show("Pruebe de nuevo o verifique su configuración"); FlowLayoutPanel1.Enabled = true; conectado = false; My.MyProject.Forms.Cargando.Close(); }
                    });


                    if (conectado)
                    {


                        My.MyProject.Forms.Cargando.Close();
                        My.MyProject.Forms.frm_adm.Show();
                        Close();
                    }
                    else
                    {
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
                OleDbConnection IntentoConexion;
                string cnConexion;
                cnConexion = "Provider=sqloledb;" + "Data Source=  " + Module1.ipconsultas + @"\confia;" + "Initial Catalog=" + Module1.bdconsultas + ";" + "User Id=sa;Password=BSi5t3Ma$CFAD;";
                IntentoConexion = new OleDbConnection(cnConexion);
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
        public void CargarEmpresas()
        {
            int num_controles = FlowLayoutPanel1.Controls.Count - 1;
            for (int n = num_controles; n >= 0; n -= 1)
            {
                var ctrl = FlowLayoutPanel1.Controls[n];
                FlowLayoutPanel1.Controls.Remove(ctrl);
                ctrl.Dispose();
            }
            try
            {
                bool acceso=false;
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
                        sql = "select rs,ip,bd,nombre,id from empresas where id in (select idempresa from empresaspermitidas where idusuario = '" + Module1.idusr + "')";
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
                            var checkEmpresa = new CheckBox();

                            checkEmpresa.Visible = false;
                            // checkEmpresa.Location = New Point(botonempresa.Width - checkEmpresa.Width, botonempresa.Height - checkEmpresa.Height)
                            checkEmpresa.BringToFront();
                            // checkEmpresa.Parent = botonempresa
                            checkEmpresa.ForeColor = Color.White;
                            checkEmpresa.Name = Conversions.ToString(milector["nombre"]);
                            checkEmpresa.Tag = milector["id"];
                            checkEmpresa.Size = new Size(20, 20);
                            Invoke(new Action(() => FlowLayoutPanel1.Controls.Add(checkEmpresa)));

                        }



                        milector.Close();
                        OleDbDataAdapter adapterEmpresas;
                        adapterEmpresas = new OleDbDataAdapter(sql, Module1.conexion);
                        Module1.dataEmpresas = new DataTable();
                        adapterEmpresas.Fill(Module1.dataEmpresas);
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

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (heightAgregarEmpresa <= 30)
            {
                Panel2.Height = heightAgregarEmpresa;
                heightAgregarEmpresa += 5;
            }
            else
            {
                Timer1.Stop();
                Timer1.Enabled = false;

            }
        }

        private async void Empresas_KeyDownAsync(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.A)
            {
                Timer1.Enabled = true;
                Timer1.Interval = 1;
                Timer1.Start();
            }
            if (e.KeyCode == Keys.D)
            {
                Dabajo = true;
                foreach (Control ctrl in FlowLayoutPanel1.Controls)
                {
                    if (ctrl is CheckBox)
                    {
                        CheckBox checkEmpresa = (CheckBox)ctrl;
                        checkEmpresa.Visible = true;

                    }


                }

            }
            if (e.KeyCode == Keys.Delete)
            {
                int nDelete = 0;
                if (Dabajo)
                {
                    foreach (Control ctrlc in FlowLayoutPanel1.Controls)
                    {
                        if (ctrlc is CheckBox)
                        {
                            CheckBox checkE = (CheckBox)ctrlc;
                            if (checkE.CheckState == CheckState.Checked)
                            {
                                nDelete += 1;

                            }
                        }
                    }
                    if (nDelete > 0)
                    {
                        if (MessageBox.Show("¿Está seguro que desea eliminar la(s) empresa(s) seleccionada(s)?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            await Task.Factory.StartNew(() =>
                                {
                                    Invoke(new Action(() =>
        {
                                        My.MyProject.Forms.Cargando.Show();
                                        My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Eliminando Empresas";
                                        My.MyProject.Forms.Cargando.TopMost = true;
                                    }));
                                    Module1.iniciarconexion();
                                    foreach (Control ctrlc in FlowLayoutPanel1.Controls)
                                    {
                                        if (ctrlc is CheckBox)
                                        {
                                            CheckBox checkE = (CheckBox)ctrlc;
                                            if (checkE.CheckState == CheckState.Checked)
                                            {
                                                OleDbCommand EliminarEmpresaPermitida;
                                                string consultaEliminarEmpresaPermitida;
                                                consultaEliminarEmpresaPermitida = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Delete from empresaspermitidas where idempresa = '", checkE.Tag), "'"));
                                                EliminarEmpresaPermitida = new OleDbCommand();
                                                EliminarEmpresaPermitida.Connection = Module1.conexion;
                                                EliminarEmpresaPermitida.CommandText = consultaEliminarEmpresaPermitida;
                                                EliminarEmpresaPermitida.ExecuteNonQuery();

                                                OleDbCommand comandoEliminarEmpresa;
                                                string consultaEliminarEmpresa;
                                                consultaEliminarEmpresa = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Delete from empresas where id = '", checkE.Tag), "'"));
                                                comandoEliminarEmpresa = new OleDbCommand();
                                                comandoEliminarEmpresa.Connection = Module1.conexion;
                                                comandoEliminarEmpresa.CommandText = consultaEliminarEmpresa;
                                                comandoEliminarEmpresa.ExecuteNonQuery();

                                            }

                                        }
                                    }
                                    My.MyProject.Forms.Cargando.Close();

                                    Invoke(new Action(() => CargarEmpresas()));
                                });
                        }
                        else
                        {
                            foreach (Control ctrl in FlowLayoutPanel1.Controls)
                            {
                                if (ctrl is CheckBox)
                                {
                                    CheckBox checkEmpresa = (CheckBox)ctrl;
                                    checkEmpresa.Visible = false;

                                }


                            }
                        }
                    }

                }

            }

        }

        private void Empresas_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                Timer1.Stop();
                Timer1.Enabled = false;
                Timer2.Enabled = true;
                Timer2.Interval = 1;
                Timer2.Start();
            }
            if (e.KeyCode == Keys.D)
            {
                Dabajo = false;
                foreach (Control ctrl in FlowLayoutPanel1.Controls)
                {
                    if (ctrl is CheckBox)
                    {
                        CheckBox checkEmpresa = (CheckBox)ctrl;
                        checkEmpresa.Visible = false;

                    }


                }
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (heightAgregarEmpresa >= 0)
            {
                Panel2.Height = heightAgregarEmpresa;
                heightAgregarEmpresa -= 5;
            }
            else
            {
                Timer2.Stop();
                Timer2.Enabled = false;

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.AgregarEmpresa.Show();

            Timer1.Stop();
            Timer1.Enabled = false;
            Timer2.Enabled = true;
            Timer2.Interval = 1;
            Timer2.Start();
        }
    }
}