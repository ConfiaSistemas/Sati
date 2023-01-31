using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class CalendarioConvenioLegal
    {
        public int idCredito;
        public double deuda;
        public int cantPagos;
        public double MontoPago;
        public DateTime PrimerPago;
        public string Modalidad;
        public double deudaTotal;
        public int gestor;
        public string Estado;
        public double Moratorios = 0d;
        public bool personalizado;
        public double Capital = 0d;

        public CalendarioConvenioLegal()
        {
            InitializeComponent();
        }
        private void CalendarioConvenioLegal_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            double proporcionMoratorio;
            proporcionMoratorio = ProporcionMoratorios(Moratorios, deudaTotal);

            DateTime fechapago;
            int numero = 0;
            double parteMora;
            double parteCred;

            if (Modalidad == "S")
            {
                for (int i = 1, loopTo = cantPagos - 1; i <= loopTo; i++)
                {
                    parteMora = MontoPago * proporcionMoratorio;
                    parteCred = MontoPago - parteMora;
                    fechapago = PrimerPago.AddDays(numero * 7);
                    deuda = deuda - MontoPago;
                    dtimpuestos.Rows.Add(fechapago.ToString("yyyy-MM-dd"), MontoPago, parteCred, parteMora);
                    numero += 1;

                }
                parteMora = deuda * proporcionMoratorio;
                parteCred = deuda - parteMora;
                fechapago = PrimerPago.AddDays(numero * 7);
                dtimpuestos.Rows.Add(fechapago.ToString("yyyy-MM-dd"), deuda, parteCred, parteMora);
            }
            else
            {
                for (int i = 1, loopTo1 = cantPagos - 1; i <= loopTo1; i++)
                {
                    parteMora = MontoPago * proporcionMoratorio;
                    parteCred = MontoPago - parteMora;
                    if (PrimerPago.Day == 16)
                    {
                        fechapago = PrimerPago;
                        dtimpuestos.Rows.Add(fechapago.ToString("yyyy-MM-dd"), MontoPago, parteCred, parteMora);
                        if (PrimerPago.Month == 12)
                        {
                            PrimerPago = Convert.ToDateTime(PrimerPago.AddYears(1).Year.ToString() + "-" + PrimerPago.AddMonths(1).Month.ToString() + "-" + "01");
                        }
                        else
                        {
                            PrimerPago = Convert.ToDateTime(PrimerPago.Year.ToString() + "-" + PrimerPago.AddMonths(1).Month.ToString() + "-" + "01");
                        }

                        deuda = deuda - MontoPago;
                    }
                    else
                    {
                        fechapago = PrimerPago;
                        dtimpuestos.Rows.Add(fechapago.ToString("yyyy-MM-dd"), MontoPago, parteCred, parteMora);
                        PrimerPago = Convert.ToDateTime(PrimerPago.Year.ToString() + "-" + PrimerPago.Month.ToString() + "-" + "16");
                        deuda = deuda - MontoPago;
                    }
                }
                parteMora = deuda * proporcionMoratorio;
                parteCred = deuda - parteMora;
                fechapago = PrimerPago;
                dtimpuestos.Rows.Add(fechapago.ToString("yyyy-MM-dd"), deuda, parteCred, parteMora);

            }
        }
        private double ProporcionMoratorios(double Moratorios, double deuda)
        {
            double proporcion;
            proporcion = Moratorios / deuda;
            return proporcion;
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

        private void dtimpuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtimpuestos_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                // Captura el numero de filas del datagridview
                string RowsNumber = (e.RowIndex + 1).ToString();
                while (RowsNumber.Length < dtimpuestos.RowCount.ToString().Length)
                    RowsNumber = "0" + RowsNumber;
                var size = e.Graphics.MeasureString(RowsNumber, Font);
                if (dtimpuestos.RowHeadersWidth < (int)Math.Round(size.Width + 20f))
                {
                    dtimpuestos.RowHeadersWidth = (int)Math.Round(size.Width + 20f);
                }
                var ob = SystemBrushes.ControlDark;
                e.Graphics.DrawString(RowsNumber, Font, ob, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + (e.RowBounds.Height - size.Height) / 2f);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "vb.net", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackgroundConvenio_DoWork(object sender, DoWorkEventArgs e)
        {
            // Dim consultaConvenio As String
            string pagoprimero ="";
            string ultimopago ="";

            foreach (DataGridViewRow row in dtimpuestos.Rows)
            {
                if (row.Index == 0)
                {
                    pagoprimero = Conversions.ToString(row.Cells[0].Value);
                }
                ultimopago = Conversions.ToString(row.Cells[0].Value);
            }
            int numero = 1;
            foreach (DataGridViewRow row in dtimpuestos.Rows)
            {
                SqlCommand comandoCalendario;

                string consultaCalendario;
                consultaCalendario = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert into calendariolegales values('", row.Cells[0].Value), "','"), row.Cells[2].Value), "','"), row.Cells[3].Value), "','"), row.Cells[1].Value), "','0','"), numero), "','"), idCredito), "','P','','0','"), row.Cells[3].Value), "')"));
                comandoCalendario = new SqlCommand();
                comandoCalendario.Connection = Module1.conexionempresa;
                comandoCalendario.CommandText = consultaCalendario;
                comandoCalendario.ExecuteNonQuery();
                numero += 1;
            }

            SqlCommand comandoActCreditoLegal;
            string consultaActCreditoLegal;
            if (Estado == "X")
            {
                consultaActCreditoLegal = "update legales set estado = 'Y', FechaInicio = '" + pagoprimero + "',FechaFin = '" + ultimopago + "',fechaConvenio = '" + DateTime.Now.ToString("yyyy-MM-dd") + "',plazo = '" + numero + "',montoconvenio = '" + deudaTotal + "' where id = '" + idCredito + "'";
            }

            else
            {
                consultaActCreditoLegal = "update legales set estado = 'C', FechaInicio = '" + pagoprimero + "',FechaFin = '" + ultimopago + "',fechaConvenio = '" + DateTime.Now.ToString("yyyy-MM-dd") + "',plazo = '" + numero + "',montoconvenio = '" + deudaTotal + "' where id = '" + idCredito + "'";

            }
            comandoActCreditoLegal = new SqlCommand();
            comandoActCreditoLegal.Connection = Module1.conexionempresa;
            comandoActCreditoLegal.CommandText = consultaActCreditoLegal;
            comandoActCreditoLegal.ExecuteNonQuery();


        }

        private void btn_Procesar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Generando Convenio";
            My.MyProject.Forms.Cargando.TopMost = true;
            BackgroundConvenio.RunWorkerAsync();

        }

        private void BackgroundConvenio_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.InformacionLegal.idCredito = idCredito;
            My.MyProject.Forms.InformacionLegal.Show();
            My.MyProject.Forms.Cargando.Close();
            Close();

        }
    }
}