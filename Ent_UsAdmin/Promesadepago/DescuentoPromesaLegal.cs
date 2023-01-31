using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{
    public partial class DescuentoPromesaLegal
    {

        public double Maximo;
        public bool Total;

        public DescuentoPromesaLegal()
        {
            InitializeComponent();
        }

        private void DescuentoPromesa_Load(object sender, EventArgs e)
        {
            lblMaximo.Text = Strings.FormatCurrency(Maximo, 2);

        }

        private void txtOtraCantidad_Click(object sender, EventArgs e)
        {
            if (Conversions.ToDouble(txtcantidad.Text) > Maximo)
            {
                MessageBox.Show("No puedes ingresar un descuento mayor al máximo establecido");
            }
            else
            {
                Close();

            }
        }

        private void DescuentoPromesa_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (string.IsNullOrEmpty(txtcantidad.Text))
            {


                My.MyProject.Forms.PromPagoLegal.descuentoTotal = 0d;
            }

            else if (Conversions.ToDouble(txtcantidad.Text) > Maximo)
            {

                My.MyProject.Forms.PromPagoLegal.descuentoTotal = 0d;
            }
            else
            {

                My.MyProject.Forms.PromPagoLegal.descuentoTotal = Conversions.ToDouble(txtcantidad.Text);

            }



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