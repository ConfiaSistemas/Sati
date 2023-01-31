using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class CrearConvenioLegal
    {
        private string Modalidad;
        public string idCreditoLegal;
        public double ParteCredito;
        public double ParteMoratorios;
        public double DeudaAP;
        public double DeudaTotal;
        public double Gastos;
        public double DeudaApCgastos;
        public double DeudaTotalCgastos;
        public double DeudaConvenio;
        public string estado;
        public bool incluyePorcentaje;

        public CrearConvenioLegal()
        {
            InitializeComponent();
        }
        private void ZeroitMetroSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (ZeroitMetroSwitch1.Checked)
            {
                lblTipoPagos.Text = "Pago";
                txtPago.Enabled = true;
                txtCantPagos.Enabled = false;
            }
            else
            {
                lblTipoPagos.Text = "Cantidad de Pagos";
                txtPago.Enabled = false;
                txtCantPagos.Enabled = true;
            }
        }

        private void SwitchModalidad_CheckedChanged(object sender, EventArgs e)
        {
            if (SwitchModalidad.Checked)
            {
                lblModalidad.Text = "Semanal";
                Modalidad = "S";
            }
            else
            {
                lblModalidad.Text = "Quincenal";
                Modalidad = "Q";
            }
        }

        private void BackgroundDatos_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            SqlCommand comandoCreditoLegal;
            string consultaCreditoLegal;
            SqlDataReader readerCreditoLegal;
            consultaCreditoLegal = @"select legal.*,ISNULL((select sum(monto) from gastoslegales where idCredito = legal.id),0) as gastos from
(select id,nombre,credito,Moratorios,deudaAP,TotalDeuda,incluyeporcentaje,estado from legales where id = '" + idCreditoLegal + "')legal";
            comandoCreditoLegal = new SqlCommand();
            comandoCreditoLegal.Connection = Module1.conexionempresa;
            comandoCreditoLegal.CommandText = consultaCreditoLegal;
            readerCreditoLegal = comandoCreditoLegal.ExecuteReader();
            if (readerCreditoLegal.HasRows)
            {
                while (readerCreditoLegal.Read())
                {
                    ParteCredito = Conversions.ToDouble(readerCreditoLegal["credito"]);
                    ParteMoratorios = Conversions.ToDouble(readerCreditoLegal["Moratorios"]);
                    DeudaAP = Conversions.ToDouble(readerCreditoLegal["deudaAP"]);
                    DeudaTotal = Conversions.ToDouble(readerCreditoLegal["TotalDeuda"]);
                    Gastos = Conversions.ToDouble(readerCreditoLegal["Gastos"]);
                    estado = Conversions.ToString(readerCreditoLegal["estado"]);
                    lblnombre.Text = Conversions.ToString(readerCreditoLegal["Nombre"]);

                    incluyePorcentaje = Conversions.ToBoolean(readerCreditoLegal["incluyeporcentaje"]);
                }
            }

            DeudaApCgastos = DeudaAP + Gastos;
            DeudaTotalCgastos = DeudaTotal + Gastos;
            DeudaConvenio = DeudaTotalCgastos;
            CheckPorcentaje.Checked = incluyePorcentaje;
            lblGastos.Text = Strings.FormatCurrency(Gastos);
            lblParteCredito.Text = Strings.FormatCurrency(ParteCredito);
            lblParteMoratorios.Text = Strings.FormatCurrency(ParteMoratorios);
            lblSubtotal.Text = Strings.FormatCurrency(DeudaApCgastos);
            lblTotal.Text = Strings.FormatCurrency(DeudaTotalCgastos);

        }

        private void BackgroundDatos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();
            CheckTotal.Checked = true;
        }

        private void CrearConvenioLegal_Load(object sender, EventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Datos";
            My.MyProject.Forms.Cargando.TopMost = true;
            datePrimerPago.Value = DateTime.Now;
            BackgroundDatos.RunWorkerAsync();

        }

        private void txtPago_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCantPagos.Text = ((int)Math.Round(Math.Ceiling(DeudaConvenio / Conversion.Val(txtPago.Text)))).ToString();
            }
        }

        private void txtCantPagos_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCantPagos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPago.Text = ((int)Math.Round(Math.Ceiling(Conversion.Val(DeudaConvenio) / Conversion.Val(txtCantPagos.Text)))).ToString();
            }
        }

        private void MonoFlat_LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            double deuda;
            deuda = DeudaConvenio;
            int canPagos;
            canPagos = (int)Math.Round(Conversion.Val(txtCantPagos.Text));
            int numero = 0;
            if (DeudaTotal % canPagos == 0d)
            {
                MessageBox.Show(canPagos + " pagos de " + txtPago.Text);
            }
            else
            {
                for (int i = 1, loopTo = canPagos - 1; i <= loopTo; i++)
                {
                    deuda = deuda - Conversion.Val(txtPago.Text);
                    numero += 1;

                }
                MessageBox.Show(numero + " pagos de " + txtPago.Text + " y 1 pago de " + deuda);
            }
        }

        private void btnGenerarCalendario_Click(object sender, EventArgs e)
        {
            if (incluyePorcentaje)
            {
                My.MyProject.Forms.CalendarioConvenioLegal.Moratorios = ParteMoratorios;
                My.MyProject.Forms.CalendarioConvenioLegal.Capital = ParteCredito;
            }
            else
            {
                My.MyProject.Forms.CalendarioConvenioLegal.Moratorios = ParteMoratorios * 1.3d;
                My.MyProject.Forms.CalendarioConvenioLegal.Capital = ParteCredito * 1.3d;
            }

            // CalendarioConvenioLegal.personalizado = personalizado
            My.MyProject.Forms.CalendarioConvenioLegal.Estado = estado;
            My.MyProject.Forms.CalendarioConvenioLegal.idCredito = Conversions.ToInteger(idCreditoLegal);
            My.MyProject.Forms.CalendarioConvenioLegal.deuda = DeudaConvenio;
            My.MyProject.Forms.CalendarioConvenioLegal.cantPagos = Conversions.ToInteger(txtCantPagos.Text);
            My.MyProject.Forms.CalendarioConvenioLegal.MontoPago = Conversions.ToDouble(txtPago.Text);
            My.MyProject.Forms.CalendarioConvenioLegal.PrimerPago = Convert.ToDateTime(datePrimerPago.Value.ToShortDateString());
            My.MyProject.Forms.CalendarioConvenioLegal.Modalidad = Modalidad;
            My.MyProject.Forms.CalendarioConvenioLegal.deudaTotal = DeudaConvenio;
            // CalendarioConvenioLegal.gestor = gestor
            My.MyProject.Forms.CalendarioConvenioLegal.Show();
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

        private void CheckPorcentaje_CheckedChanged(object sender)
        {

        }

        private void CheckPorcentaje_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }

        private void CheckSubtotal_CheckedChanged(object sender)
        {
            if (CheckSubtotal.Checked)
            {
                CheckTotal.Checked = false;
                DeudaConvenio = DeudaApCgastos;

            }
        }

        private void CheckTotal_CheckedChanged(object sender)
        {
            if (CheckTotal.Checked)
            {
                CheckSubtotal.Checked = false;
                DeudaConvenio = DeudaTotalCgastos;

            }
        }
    }
}