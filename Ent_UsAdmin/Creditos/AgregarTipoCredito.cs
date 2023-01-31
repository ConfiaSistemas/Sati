using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class AgregarTipoCredito
    {
        private bool insertar;
        public bool autorizado;
        private int plazo;

        public AgregarTipoCredito()
        {
            InitializeComponent();
        }

        private void btn_Procesar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Autorizacion.tipoAutorizacion = "SatiModTiposCreditosAgregar";
            My.MyProject.Forms.Autorizacion.ShowDialog();
            if (autorizado)
            {
                try
                {

                    Module1.iniciarconexionempresa();
                    SqlCommand comando;
                    if (ComboPlazo.Text == "Otro")
                    {
                        plazo = Conversions.ToInteger(txtOtroPlazo.Text);
                    }
                    else
                    {
                        plazo = Conversions.ToInteger(ComboPlazo.Text);
                    }

                    string consulta;

                    consulta = "Insert into TiposDecredito values('" + txtNombre.Text + "','" + ComboModalidad.Text + "','" + ComboTipo.Text + "','" + plazo + "','" + txtInteres.Text + "','" + checkMotocicleta.Checked + "','" + txtApertura.Text + "','" + txtEnganche.Text + "')";
                    comando = new SqlCommand();
                    comando.Connection = Module1.conexionempresa;
                    comando.CommandText = consulta;
                    comando.ExecuteNonQuery();
                    insertar = true;
                    MessageBox.Show("Listo");
                    txtNombre.Text = "";
                }
                catch (Exception ex)
                {
                    insertar = false;
                    MessageBox.Show("Ha ocurrido un error " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No fue autorizado");
            }

        }

        private void AgregarTipoCredito_Load(object sender, EventArgs e)
        {
            ComboModalidad.Items.Add("S");
            ComboModalidad.Items.Add("Q");
            ComboModalidad.SelectedIndex = 0;

            ComboTipo.Items.Add("I");
            ComboTipo.Items.Add("G");
            ComboTipo.Items.Add("L");
            ComboTipo.SelectedIndex = 0;


        }

        private void ComboModalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboTipo.Text == "L")
            {
                ComboPlazo.Items.Clear();
                ComboPlazo.Items.Add("0");
                ComboPlazo.SelectedIndex = 0;
            }
            else
            {
                switch (ComboModalidad.Text ?? "")
                {
                    case "S":
                        {
                            ComboPlazo.Items.Clear();
                            ComboPlazo.Items.Add("16");
                            ComboPlazo.Items.Add("18");
                            ComboPlazo.Items.Add("22");
                            ComboPlazo.Items.Add("Otro");
                            ComboPlazo.SelectedIndex = 0;
                            break;
                        }
                    case "Q":
                        {
                            ComboPlazo.Items.Clear();
                            ComboPlazo.Items.Add("8");
                            ComboPlazo.Items.Add("11");
                            ComboPlazo.Items.Add("Otro");

                            ComboPlazo.SelectedIndex = 0;
                            break;
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

        private void ComboPlazo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboPlazo.Text == "Otro")
            {
                lblOtroPlazo.Visible = true;
                txtOtroPlazo.Visible = true;
            }
            else
            {
                lblOtroPlazo.Visible = false;
                txtOtroPlazo.Visible = false;
            }
        }


    }
}