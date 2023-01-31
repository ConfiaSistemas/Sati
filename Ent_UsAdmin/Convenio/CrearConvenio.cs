using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class CrearConvenio
    {

        private string Modalidad = "S";
        public string idCredito;
        public double ParteCredito;
        public double ParteMoratorios;
        private double pagare;
        private double abonadoSmultas;
        private double PendienteSmultas;
        private double multas;
        private double abonadoMultas;
        private double multasPendientes;
        private int gestor;
        private string diasAtraso;
        private int pagosVencidos;
        private string modalidadCredito;
        public double DeudaAP;
        public double DeudaTotal;
        public bool incluyePorcentaje;
        public bool Autorizado;

        public CrearConvenio()
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
            consultaCreditoLegal = @"select nombre,id,pagare,AbonadoSinMultas,(pagare-AbonadoSinMultas) as valorCarteraSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,((Multas-(AbonadoMultasL+AbonadoMultasV))+(pagare-AbonadoSinMultas)) as ValorCarteraConMultas, case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,
case when FechaDeAtraso = 'Nunca' then
	
		DATEDIFF(day,(select fechapago from CalendarioNormal  where CalendarioNormal.id_Credito = CarteraTotal.id and Npago = 1),GETDATE())

	
else (case when carteratotal.Estado = 'C' then
	datediff(day,fechadeatraso,GETDATE())
	when carteratotal.Estado = 'R' then
	datediff(day,fechadeatraso,GETDATE())
	else 
	datediff(day,fechadeatraso,GETDATE())
	end)
end as Diasdeatraso,PagosVencidos,Modalidad,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Promotor,Estado,FechaDeAtraso,IdGestor from
(select Cartera.nombre,Cartera.id,

isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id group by id_credito),0)  as AbonadoSinMultas,

isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)),0) as AbonadoMultasV,

isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L' and CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) as AbonadoMultasL,

isnull((select SUM(CalendarioNormal.interes) as Multas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0)  as Multas,

(select Pagare from credito where id = Cartera.id) as pagare,

isnull(convert(varchar,(select top 1 FechaUltimoPago from CalendarioNormal where FechaUltimoPago>'1900-01-01' and CalendarioNormal.id_credito = Cartera.id order by FechaUltimoPago desc),23),'Nunca')
 as FechaDeAtraso,
isnull((select COUNT(Npago) from CalendarioNormal where Estado='V' and CalendarioNormal.id_credito = Cartera.id),0)as PagosVencidos,
isnull((select Modalidad from TiposDeCredito where id=Cartera.Tipo),'')Modalidad,

isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) as pendiente,
 '0'  as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado,Cartera.IdGestor from
(select credito.nombre,Credito.id,Credito.idgestor,Credito.IdPromotor,credito.Estado, Credito.Tipo from Credito inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito where Credito.Estado <> 'L' and Credito.id = '" + idCredito + @"'  group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado, Credito.Tipo) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal order by nombre asc";
            comandoCreditoLegal = new SqlCommand();
            comandoCreditoLegal.Connection = Module1.conexionempresa;
            comandoCreditoLegal.CommandText = consultaCreditoLegal;
            readerCreditoLegal = comandoCreditoLegal.ExecuteReader();
            if (readerCreditoLegal.HasRows)
            {
                while (readerCreditoLegal.Read())
                {
                    ParteCredito = Conversions.ToDouble(readerCreditoLegal["valorCarteraSinMultas"]);
                    ParteMoratorios = Conversions.ToDouble(readerCreditoLegal["MultasPendientes"]);
                    multas = Conversions.ToDouble(readerCreditoLegal["Multas"]);
                    abonadoMultas = Conversions.ToDouble(readerCreditoLegal["AbonadoMultas"]);
                    multasPendientes = Conversions.ToDouble(readerCreditoLegal["MultasPendientes"]);
                    pagare = Conversions.ToDouble(readerCreditoLegal["pagare"]);
                    abonadoSmultas = Conversions.ToDouble(readerCreditoLegal["AbonadoSinMultas"]);
                    gestor = Conversions.ToInteger(readerCreditoLegal["idgestor"]);
                    // DeudaAP = readerCreditoLegal("deudaAP")
                    DeudaTotal = Conversions.ToDouble(readerCreditoLegal["ValorCarteraConMultas"]);
                    lblnombre.Text = Conversions.ToString(readerCreditoLegal["Nombre"]);
                    diasAtraso = Conversions.ToString(readerCreditoLegal["diasdeatraso"]);
                    pagosVencidos = Conversions.ToInteger(readerCreditoLegal["PagosVencidos"]);
                    modalidadCredito = Conversions.ToString(readerCreditoLegal["Modalidad"]);
                    // incluyePorcentaje = readerCreditoLegal("incluyeporcentaje")
                }
            }
            // CheckPorcentaje.Checked = incluyePorcentaje
            lblpagare.Text = Strings.FormatCurrency(pagare);
            lblAbonadoSmultas.Text = Strings.FormatCurrency(abonadoSmultas);
            lblmultas.Text = Strings.FormatCurrency(multas);
            lblMultasAbonadas.Text = Strings.FormatCurrency(abonadoMultas);
            lblPagosVencidos.Text = pagosVencidos.ToString();
            lblDiasAtraso.Text = diasAtraso;
            lblParteCredito.Text = Strings.FormatCurrency(ParteCredito);
            lblParteMoratorios.Text = Strings.FormatCurrency(ParteMoratorios);
            // lblSubtotal.Text = FormatCurrency(DeudaAP)
            lblTotal.Text = Strings.FormatCurrency(DeudaTotal);

        }

        private void BackgroundDatos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();

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
                txtCantPagos.Text = ((int)Math.Round(Math.Ceiling(DeudaTotal / Conversion.Val(txtPago.Text)))).ToString();
            }
        }

        private void txtCantPagos_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCantPagos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPago.Text = ((int)Math.Round(Math.Ceiling(Conversion.Val(DeudaTotal) / Conversion.Val(txtCantPagos.Text)))).ToString();
            }
        }

        private void MonoFlat_LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            double deuda;
            deuda = DeudaTotal;
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

            switch (modalidadCredito ?? "")
            {
                case "S":
                    {
                        if (pagosVencidos > 3)
                        {
                            My.MyProject.Forms.CalendarioConvenio.Moratorios = ParteMoratorios;
                            My.MyProject.Forms.CalendarioConvenio.Capital = ParteCredito;


                            // CalendarioConvenioLegal.personalizado = personalizado
                            My.MyProject.Forms.CalendarioConvenio.idCredito = Conversions.ToInteger(idCredito);
                            My.MyProject.Forms.CalendarioConvenio.deuda = DeudaTotal;
                            My.MyProject.Forms.CalendarioConvenio.cantPagos = Conversions.ToInteger(txtCantPagos.Text);
                            My.MyProject.Forms.CalendarioConvenio.MontoPago = Conversions.ToDouble(txtPago.Text);
                            My.MyProject.Forms.CalendarioConvenio.PrimerPago = Convert.ToDateTime(datePrimerPago.Value.ToShortDateString());
                            My.MyProject.Forms.CalendarioConvenio.Modalidad = Modalidad;
                            My.MyProject.Forms.CalendarioConvenio.deudaTotal = DeudaTotal;
                            My.MyProject.Forms.CalendarioConvenio.gestor = gestor;
                            My.MyProject.Forms.CalendarioConvenio.Show();
                        }
                        else if (Module1.idGrp == 1)
                        {
                            My.MyProject.Forms.CalendarioConvenio.Moratorios = ParteMoratorios;
                            My.MyProject.Forms.CalendarioConvenio.Capital = ParteCredito;
                            My.MyProject.Forms.CalendarioConvenio.idCredito = Conversions.ToInteger(idCredito);
                            My.MyProject.Forms.CalendarioConvenio.deuda = DeudaTotal;
                            My.MyProject.Forms.CalendarioConvenio.cantPagos = Conversions.ToInteger(txtCantPagos.Text);
                            My.MyProject.Forms.CalendarioConvenio.MontoPago = Conversions.ToDouble(txtPago.Text);
                            My.MyProject.Forms.CalendarioConvenio.PrimerPago = Convert.ToDateTime(datePrimerPago.Value.ToShortDateString());
                            My.MyProject.Forms.CalendarioConvenio.Modalidad = Modalidad;
                            My.MyProject.Forms.CalendarioConvenio.deudaTotal = DeudaTotal;
                            My.MyProject.Forms.CalendarioConvenio.gestor = gestor;
                            My.MyProject.Forms.CalendarioConvenio.Show();
                        }
                        else if (Conversions.ToDouble(diasAtraso) < 30d)
                        {
                            MessageBox.Show("Para crear el convenio, el crédito debe tener por lo menos 4 pagos vencidos, o 30 días de atraso desde la última fecha de pago.");
                        }
                        else
                        {
                            My.MyProject.Forms.CalendarioConvenio.Moratorios = ParteMoratorios;
                            My.MyProject.Forms.CalendarioConvenio.Capital = ParteCredito;


                            // CalendarioConvenioLegal.personalizado = personalizado
                            My.MyProject.Forms.CalendarioConvenio.idCredito = Conversions.ToInteger(idCredito);
                            My.MyProject.Forms.CalendarioConvenio.deuda = DeudaTotal;
                            My.MyProject.Forms.CalendarioConvenio.cantPagos = Conversions.ToInteger(txtCantPagos.Text);
                            My.MyProject.Forms.CalendarioConvenio.MontoPago = Conversions.ToDouble(txtPago.Text);
                            My.MyProject.Forms.CalendarioConvenio.PrimerPago = Convert.ToDateTime(datePrimerPago.Value.ToShortDateString());
                            My.MyProject.Forms.CalendarioConvenio.Modalidad = Modalidad;
                            My.MyProject.Forms.CalendarioConvenio.deudaTotal = DeudaTotal;
                            My.MyProject.Forms.CalendarioConvenio.gestor = gestor;
                            My.MyProject.Forms.CalendarioConvenio.Show();
                        }

                        break;
                    }

                case "Q":
                    {
                        if (pagosVencidos > 1)
                        {
                            My.MyProject.Forms.CalendarioConvenio.Moratorios = ParteMoratorios;
                            My.MyProject.Forms.CalendarioConvenio.Capital = ParteCredito;


                            // CalendarioConvenioLegal.personalizado = personalizado
                            My.MyProject.Forms.CalendarioConvenio.idCredito = Conversions.ToInteger(idCredito);
                            My.MyProject.Forms.CalendarioConvenio.deuda = DeudaTotal;
                            My.MyProject.Forms.CalendarioConvenio.cantPagos = Conversions.ToInteger(txtCantPagos.Text);
                            My.MyProject.Forms.CalendarioConvenio.MontoPago = Conversions.ToDouble(txtPago.Text);
                            My.MyProject.Forms.CalendarioConvenio.PrimerPago = Convert.ToDateTime(datePrimerPago.Value.ToShortDateString());
                            My.MyProject.Forms.CalendarioConvenio.Modalidad = Modalidad;
                            My.MyProject.Forms.CalendarioConvenio.deudaTotal = DeudaTotal;
                            My.MyProject.Forms.CalendarioConvenio.gestor = gestor;
                            My.MyProject.Forms.CalendarioConvenio.Show();
                        }
                        else if (Module1.idGrp == 1)
                        {
                            My.MyProject.Forms.CalendarioConvenio.Moratorios = ParteMoratorios;
                            My.MyProject.Forms.CalendarioConvenio.Capital = ParteCredito;


                            // CalendarioConvenioLegal.personalizado = personalizado
                            My.MyProject.Forms.CalendarioConvenio.idCredito = Conversions.ToInteger(idCredito);
                            My.MyProject.Forms.CalendarioConvenio.deuda = DeudaTotal;
                            My.MyProject.Forms.CalendarioConvenio.cantPagos = Conversions.ToInteger(txtCantPagos.Text);
                            My.MyProject.Forms.CalendarioConvenio.MontoPago = Conversions.ToDouble(txtPago.Text);
                            My.MyProject.Forms.CalendarioConvenio.PrimerPago = Convert.ToDateTime(datePrimerPago.Value.ToShortDateString());
                            My.MyProject.Forms.CalendarioConvenio.Modalidad = Modalidad;
                            My.MyProject.Forms.CalendarioConvenio.deudaTotal = DeudaTotal;
                            My.MyProject.Forms.CalendarioConvenio.gestor = gestor;
                            My.MyProject.Forms.CalendarioConvenio.Show();
                        }
                        else if (Conversions.ToDouble(diasAtraso) < 30d)
                        {
                            MessageBox.Show("Para crear el convenio, el crédito debe tener por lo menos 2 pagos vencidos (quincenal), o 30 días de atraso desde la última fecha de pago.");
                        }
                        else
                        {
                            My.MyProject.Forms.CalendarioConvenio.Moratorios = ParteMoratorios;
                            My.MyProject.Forms.CalendarioConvenio.Capital = ParteCredito;


                            // CalendarioConvenioLegal.personalizado = personalizado
                            My.MyProject.Forms.CalendarioConvenio.idCredito = Conversions.ToInteger(idCredito);
                            My.MyProject.Forms.CalendarioConvenio.deuda = DeudaTotal;
                            My.MyProject.Forms.CalendarioConvenio.cantPagos = Conversions.ToInteger(txtCantPagos.Text);
                            My.MyProject.Forms.CalendarioConvenio.MontoPago = Conversions.ToDouble(txtPago.Text);
                            My.MyProject.Forms.CalendarioConvenio.PrimerPago = Convert.ToDateTime(datePrimerPago.Value.ToShortDateString());
                            My.MyProject.Forms.CalendarioConvenio.Modalidad = Modalidad;
                            My.MyProject.Forms.CalendarioConvenio.deudaTotal = DeudaTotal;
                            My.MyProject.Forms.CalendarioConvenio.gestor = gestor;
                            My.MyProject.Forms.CalendarioConvenio.Show();
                        }

                        break;
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
    }
}