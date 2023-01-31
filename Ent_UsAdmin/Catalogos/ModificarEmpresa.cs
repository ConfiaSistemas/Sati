using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class ModificarEmpresa
    {
        private string idEmpresaSeleccionada;
        public string bdEmpresaSeleccionada;
        public string ipEmpresaSeleccionada;
        public string nombreEmpresaSeleccionada;
        private Cargando ncargando;

        public ModificarEmpresa()
        {
            InitializeComponent();
        }


        private void BackgroundInformacionEmpresa_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexion();
            OleDbCommand comandoInformacion;
            string consultaInformacion;
            OleDbDataReader readerInformacion;
            consultaInformacion = "select * from empresas where nombre = '" + nombreEmpresaSeleccionada + "' and ip = '" + ipEmpresaSeleccionada + "' and bd = '" + bdEmpresaSeleccionada + "'";
            comandoInformacion = new OleDbCommand();
            comandoInformacion.Connection = Module1.conexion;
            comandoInformacion.CommandText = consultaInformacion;
            readerInformacion = comandoInformacion.ExecuteReader();
            if (readerInformacion.HasRows)
            {
                while (readerInformacion.Read())
                {
                    txtNombre.Text = Conversions.ToString(readerInformacion["Nombre"]);
                    txtRazonSocial.Text = Conversions.ToString(readerInformacion["RS"]);
                    txtRFC.Text = Conversions.ToString(readerInformacion["RFC"]);
                    txtCalle.Text = Conversions.ToString(readerInformacion["Calle"]);
                    txtNoExterior.Text = Conversions.ToString(readerInformacion["Nex"]);
                    txtCP.Text = Conversions.ToString(readerInformacion["CP"]);
                    txtColonia.Text = Conversions.ToString(readerInformacion["COl"]);
                    txtCiudad.Text = Conversions.ToString(readerInformacion["ciudad"]);
                    txtEstado.Text = Conversions.ToString(readerInformacion["Estado"]);
                    txtTelefono.Text = Conversions.ToString(readerInformacion["Telefono"]);
                    txtIP.Text = Conversions.ToString(readerInformacion["IP"]);
                    txtBD.Text = Conversions.ToString(readerInformacion["BD"]);
                    txtPrefijo.Text = Conversions.ToString(readerInformacion["Prefijo"]);
                    txtCorreo.Text = Conversions.ToString(readerInformacion["Correo"]);
                    txtPassword.Text = Conversions.ToString(readerInformacion["passwordCorreo"]);
                    idEmpresaSeleccionada = Conversions.ToString(readerInformacion["id"]);
                }
            }
        }

        private void BackgroundInformacionEmpresa_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ncargando.Close();

        }

        private void ModificarEmpresa_Load(object sender, EventArgs e)
        {
            ncargando = new Cargando();
            ncargando.MonoFlat_Label1.Text = "Cargando Información";
            ncargando.Show();
            BackgroundInformacionEmpresa.RunWorkerAsync();

        }

        private void BackgroundActualizar_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexion();
            OleDbCommand comandoActualizar;
            string consultaActualizar;
            consultaActualizar = "update empresas set Nombre = '" + txtNombre.Text + "',RS = '" + txtRazonSocial.Text + "',RFC = '" + txtRFC.Text + "',Calle = '" + txtCalle.Text + "',nex = '" + txtNoExterior.Text + "',col = '" + txtColonia.Text + "',ciudad = '" + txtCiudad.Text + "',estado = '" + txtEstado.Text + "',cp = '" + txtCP.Text + "',telefono = '" + txtTelefono.Text + @"',
                               IP = '" + txtIP.Text + "',BD='" + txtBD.Text + "',prefijo = '" + txtPrefijo.Text + "',correo = '" + txtCorreo.Text + "',passwordCorreo = '" + txtPassword.Text + "' where id = '" + idEmpresaSeleccionada + "'";
            comandoActualizar = new OleDbCommand();
            comandoActualizar.Connection = Module1.conexion;
            comandoActualizar.CommandText = consultaActualizar;
            comandoActualizar.ExecuteNonQuery();

        }

        private void BackgroundActualizar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Empresas.Actualizado = true;


            ncargando.Close();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            ncargando = new Cargando();
            ncargando.MonoFlat_Label1.Text = "Actualizando Información";
            ncargando.Show();
            BackgroundActualizar.RunWorkerAsync();

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

        private void ModificarEmpresa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Invoke(new Action(() => My.MyProject.Forms.Empresas.CargarEmpresas()));

        }
    }
}