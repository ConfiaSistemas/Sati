using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ConfiaAdmin
{
    public partial class vistPreviaSolicitud
    {
        public DataTable dataIntegrantes;
        public string nombre;
        public double Monto;
        public int plazo;
        public string tipo;
        public double intere;
        public string promotor;
        public string gestor;
        private bool continuar;

        public vistPreviaSolicitud()
        {
            InitializeComponent();
        }
        private void vistPreviaSolicitud_Load(object sender, EventArgs e)
        {
            continuar = false;
            lblNombre.Text = nombre;
            lblMonto.Text = Strings.FormatCurrency(Monto, 2);
            lblPlazo.Text = plazo.ToString();
            lblTipo.Text = tipo;
            lblInteres.Text = Strings.FormatCurrency(intere, 2);
            lblPromotor.Text = promotor;
            lblGestor.Text = gestor;
            dtdatos.DataSource = dataIntegrantes;

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Resize(object sender, EventArgs e)
        {

        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Module_resize.MoveForm(this);
            }
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            continuar = true;
            My.MyProject.Forms.Levantar_Solicitud.continuar = true;
            Close();

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            continuar = false;
            My.MyProject.Forms.Levantar_Solicitud.continuar = false;

            Close();
        }

        private void vistPreviaSolicitud_FormClosing(object sender, FormClosingEventArgs e)
        {
            My.MyProject.Forms.Levantar_Solicitud.continuar = continuar;

        }
    }
}