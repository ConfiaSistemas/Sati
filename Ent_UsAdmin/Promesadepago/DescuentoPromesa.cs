using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{
    public partial class DescuentoPromesa
    {
        public double Maximo;
        public bool Total;

        public DescuentoPromesa()
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
            if (Total)
            {
                if (string.IsNullOrEmpty(txtcantidad.Text))
                {

                    My.MyProject.Forms.PromPago.descuentoTotal = 0d;
                }
                else if (Conversions.ToDouble(txtcantidad.Text) > Maximo)
                {
                    My.MyProject.Forms.PromPago.descuentoTotal = 0d;
                }
                else
                {
                    My.MyProject.Forms.PromPago.descuentoTotal = Conversions.ToDouble(txtcantidad.Text);

                }
            }

            else if (string.IsNullOrEmpty(txtcantidad.Text))
            {
                My.MyProject.Forms.PromPago.descuentoParcial = 0d;
            }
            else if (Conversions.ToDouble(txtcantidad.Text) > Maximo)
            {
                My.MyProject.Forms.PromPago.descuentoParcial = 0d;
            }
            else
            {
                My.MyProject.Forms.PromPago.descuentoParcial = Conversions.ToDouble(txtcantidad.Text);



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