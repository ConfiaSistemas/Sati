using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class AgregarEmpresa
    {

        private string idEmpresaSeleccionada;
        public string bdEmpresaSeleccionada;
        public string ipEmpresaSeleccionada;
        public string nombreEmpresaSeleccionada;
        private Cargando ncargando;
        private int heightFlow;
        private bool grande;

        public AgregarEmpresa()
        {
            InitializeComponent();
        }




        private void ModificarEmpresa_Load(object sender, EventArgs e)
        {
            FlowUsuarios.Height = 0;

            ncargando = new Cargando();
            ncargando.MonoFlat_Label1.Text = "Cargando Información";
            ncargando.Show();
            BackgroundInformacionEmpresa.RunWorkerAsync();


        }

        private void BackgroundActualizar_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexion();
            int idEmpresaGenerado;
            OleDbCommand comandoActualizar;
            string consultaActualizar;
            consultaActualizar = "insert into empresas values('" + txtNombre.Text + "','" + txtRazonSocial.Text + "','" + txtRFC.Text + "','" + txtCalle.Text + "','" + txtNoExterior.Text + "','" + txtColonia.Text + "','" + txtCiudad.Text + "','" + txtEstado.Text + "','" + txtCP.Text + "','" + txtTelefono.Text + @"',
                               '" + txtIP.Text + "','" + txtBD.Text + "','" + txtPrefijo.Text + "','" + txtCorreo.Text + "','" + txtPassword.Text + "') select SCOPE_IDENTITY()";
            comandoActualizar = new OleDbCommand();
            comandoActualizar.Connection = Module1.conexion;
            comandoActualizar.CommandText = consultaActualizar;
            idEmpresaGenerado = Conversions.ToInteger(comandoActualizar.ExecuteScalar());


            int nCargar = 0;
            foreach (Control ctrlc in FlowUsuarios.Controls)
            {
                if (ctrlc is CheckBox)
                {
                    CheckBox checkE = (CheckBox)ctrlc;
                    if (checkE.CheckState == CheckState.Checked)
                    {
                        nCargar += 1;

                    }
                }
            }

            if (nCargar > 0)
            {
                foreach (Control ctrlc in FlowUsuarios.Controls)
                {
                    if (ctrlc is CheckBox)
                    {
                        CheckBox checkE = (CheckBox)ctrlc;
                        if (checkE.CheckState == CheckState.Checked)
                        {
                            OleDbCommand comandoEmpresasPermitidas;
                            string consultaEmpresasPermitidas;
                            consultaEmpresasPermitidas = "insert into empresaspermitidas values('" + idEmpresaGenerado + "','" + checkE.Name + "')";
                            comandoEmpresasPermitidas = new OleDbCommand();
                            comandoEmpresasPermitidas.Connection = Module1.conexion;
                            comandoEmpresasPermitidas.CommandText = consultaEmpresasPermitidas;
                            comandoEmpresasPermitidas.ExecuteNonQuery();


                        }
                    }
                }
            }
        }

        private void BackgroundActualizar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Empresas.Actualizado = true;


            ncargando.Close();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            ncargando = new Cargando();
            ncargando.MonoFlat_Label1.Text = "Agregando Empresa";
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

        private void BackgroundInformacionEmpresa_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexion();
            OleDbCommand comandoUsuarios;
            string consultaUsuarios;
            OleDbDataReader readerUsuarios;

            consultaUsuarios = "select idusr,nm,nm_complete from usr";
            comandoUsuarios = new OleDbCommand();
            comandoUsuarios.Connection = Module1.conexion;
            comandoUsuarios.CommandText = consultaUsuarios;
            readerUsuarios = comandoUsuarios.ExecuteReader();
            if (readerUsuarios.HasRows)
            {
                while (readerUsuarios.Read())
                {
                    var CheckUsuarios = new CheckBox();

                    CheckUsuarios.Visible = true;
                    // checkEmpresa.Location = New Point(botonempresa.Width - checkEmpresa.Width, botonempresa.Height - checkEmpresa.Height)
                    CheckUsuarios.BringToFront();
                    // checkEmpresa.Parent = botonempresa
                    CheckUsuarios.ForeColor = Color.White;
                    CheckUsuarios.Name = Conversions.ToString(readerUsuarios["idusr"]);
                    CheckUsuarios.Tag = readerUsuarios["nm"];
                    CheckUsuarios.Text = Conversions.ToString(readerUsuarios["nm_complete"]);
                    CheckUsuarios.AutoSize = true;
                    Invoke(new Action(() => FlowUsuarios.Controls.Add(CheckUsuarios)));

                }
            }
        }

        private void TimerGrande_Tick(object sender, EventArgs e)
        {
            if (heightFlow <= 272)
            {
                FlowUsuarios.Height = heightFlow;
                heightFlow += 10;
            }
            else
            {
                TimerGrande.Stop();
                TimerGrande.Enabled = false;

            }
        }

        private void TimerChico_Tick(object sender, EventArgs e)
        {
            if (heightFlow >= 0)
            {
                FlowUsuarios.Height = heightFlow;
                heightFlow -= 10;
            }
            else
            {
                TimerChico.Stop();
                TimerChico.Enabled = false;

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (grande == false)
            {
                grande = true;
                TimerGrande.Enabled = true;
                TimerGrande.Interval = 10;
                TimerGrande.Start();
            }

            else
            {
                grande = false;
                TimerChico.Enabled = true;
                TimerChico.Interval = 10;
                TimerChico.Start();

            }
        }

        private void BackgroundInformacionEmpresa_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ncargando.Close();
        }
    }
}