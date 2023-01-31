using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class CrearConvenioTerminal

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
        private int diasCancelado;
        private double abonadoCancelado;
        public double DeudaAP;
        public double DeudaTotal;
        public bool incluyePorcentaje;

        public CrearConvenioTerminal()
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
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,case when FechaDeAtraso = 'Nunca' then
	'Nunca abonado'
else (case when carteratotal.Estado = 'C' then
	datediff(day,fechadeatraso,GETDATE())
	when carteratotal.Estado = 'R' then
	datediff(day,fechadeatraso,GETDATE())
	else 
	datediff(day,fechadeatraso,GETDATE())
	end)
end as Diasdeatraso,
FechaCancelacionConvenio,
datediff(day,FechaCancelacionConvenio,GETDATE())DiasCancelado,
isnull((select SUM(Total) from Ticket where TipoDoc=1 and idCredito=CarteraTotal.id and Fecha>FechaCancelacionConvenio),0)AbonadoEstadoI,
((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Promotor,Estado,IdGestor,fechadeatraso from
--<
(select Cartera.nombre,Cartera.id,
case when Cartera.Estado = 'C' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where Abonado <> 0 and Abonado >= interes and convenios.id_credito = Cartera.id group by id_credito),0)
else
isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id group by id_credito),0) end as AbonadoSinMultas,
case when Cartera.Estado = 'C' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConvenios inner join Convenios on Convenios.id = CalendarioConvenios.Id_Convenio where abonado <> 0 and abonado <= interes and CalendarioConvenios.estado = 'V' and Convenios.id_credito = Cartera.id group by Convenios.id_credito),0) 
else
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)),0)end as AbonadoMultasV,
case when Cartera.Estado = 'C' then
isnull((select SUM(Abonado - CalendarioConvenios.monto) as AbonadoMultas from CalendarioConvenios inner join Convenios on Convenios.id = CalendarioConvenios.Id_Convenio where  CalendarioConvenios.estado = 'L' and Convenios.id_credito = Cartera.id group by Convenios.id_credito),0)
else
isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L' and CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as AbonadoMultasL,
case when Cartera.Estado = 'C' THEN 
isnull((select SUM(CalendarioConvenios.interes) as Multas from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where  Convenios.id_credito = Cartera.id group by Convenios.id_credito),0)
else
isnull((select SUM(CalendarioNormal.interes) as Multas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as Multas,
case when cartera.Estado = 'C' THEN 
(select SUM(calendarioconvenios.monto) from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where convenios.id_credito = Cartera.id)
else
(select Pagare from credito where id = Cartera.id) end as pagare,
case when Cartera.Estado = 'C' then
isnull(convert(varchar,(select top 1 CalendarioConveniosSac.Fecha from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniosSac.Fecha>'1900-01-01' and ConveniosSac.idCredito = Cartera.id order by CalendarioConveniosSac.Fecha desc),23),'Nunca')
when Cartera.Estado = 'R' then
isnull(convert(varchar,(select top 1 CalendarioReestructurasSac.Fecha from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Fecha>'1900-01-01' and ReestructurasSac.idCredito = Cartera.id order by CalendarioReestructurasSac.Fecha desc),23),'Nunca')
else
isnull(convert(varchar,(select top 1 FechaUltimoPago from CalendarioNormal where FechaUltimoPago>'1900-01-01' and CalendarioNormal.id_credito = Cartera.id order by FechaUltimoPago desc),23),'Nunca')
end as FechaDeAtraso,
case when Cartera.Estado = 'C' then
isnull((select SUM(calendarioconvenios.pendiente) from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where calendarioconvenios.Estado = 'V' and convenios.id_credito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
isnull((select top 1 Ticket.fecha from Ticket inner join TipoDoc on TipoDoc.id=Ticket.TipoDoc where TipoDoc.Nombre='Cancelación de Reestructura' and Ticket.idCredito=Cartera.id and Ticket.Estado='A' order by Ticket.Fecha desc),'')FechaCancelacionConvenio,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where CalendarioConvenios.Estado ='V' and Convenios.id_credito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado,Cartera.IdGestor from
(select credito.nombre,Credito.id,Credito.idgestor,Credito.IdPromotor,credito.Estado from Credito inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito where Credito.Estado <> 'L' and Credito.id = " + idCredito + @"  group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado) Cartera inner join
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
                    DeudaTotal = Conversions.ToDouble(readerCreditoLegal["ValorCarteraConMultas"] ) - (ParteMoratorios / 2);
                    lblnombre.Text = Conversions.ToString(readerCreditoLegal["Nombre"]);
                    diasCancelado = Conversions.ToInteger(readerCreditoLegal["DiasCancelado"]);
                    abonadoCancelado = Conversions.ToDouble(readerCreditoLegal["AbonadoEstadoI"]);
                    // incluyePorcentaje = readerCreditoLegal("incluyeporcentaje")
                }
            }
            // CheckPorcentaje.Checked = incluyePorcentaje
            lblpagare.Text = Strings.FormatCurrency(pagare);
            lblAbonadoSmultas.Text = Strings.FormatCurrency(abonadoSmultas);
            lblmultas.Text = Strings.FormatCurrency(multas);
            lblMultasAbonadas.Text = Strings.FormatCurrency(abonadoMultas);
            lbldiasCancelado.Text = diasCancelado.ToString();
            lblParteCredito.Text = Strings.FormatCurrency(ParteCredito);
            lblParteMoratorios.Text = Strings.FormatCurrency(ParteMoratorios/2);
            lblMoratoriosOriginales.Text = Strings.FormatCurrency(ParteMoratorios);
            // lblSubtotal.Text = FormatCurrency(DeudaAP)
            lblTotal.Text = Strings.FormatCurrency(DeudaTotal);
            lblAbonadoCancelacion.Text = Strings.FormatCurrency(abonadoCancelado);

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
            // If diasAtraso = "Nunca abonado" Then
            // CalendarioReestructura.Moratorios = ParteMoratorios
            // CalendarioReestructura.Capital = ParteCredito


            // ' CalendarioConvenioLegal.personalizado = personalizado
            // CalendarioReestructura.idCredito = idCredito
            // CalendarioReestructura.deuda = DeudaTotal
            // CalendarioReestructura.cantPagos = txtCantPagos.Text
            // CalendarioReestructura.MontoPago = txtPago.Text
            // CalendarioReestructura.PrimerPago = Convert.ToDateTime(datePrimerPago.Value.ToShortDateString)
            // CalendarioReestructura.Modalidad = Modalidad
            // CalendarioReestructura.deudaTotal = DeudaTotal
            // CalendarioReestructura.gestor = gestor
            // CalendarioReestructura.Show()
            // Else
            if (Module1.idGrp == 1)
            {
                My.MyProject.Forms.CalendarioConvenioTerminal.Moratorios = ParteMoratorios/2;
                My.MyProject.Forms.CalendarioConvenioTerminal.Capital = ParteCredito;
                My.MyProject.Forms.CalendarioConvenioTerminal.idCredito = Conversions.ToInteger(idCredito);
                My.MyProject.Forms.CalendarioConvenioTerminal.deuda = DeudaTotal;
                My.MyProject.Forms.CalendarioConvenioTerminal.cantPagos = Conversions.ToInteger(txtCantPagos.Text);
                My.MyProject.Forms.CalendarioConvenioTerminal.MontoPago = Conversions.ToDouble(txtPago.Text);
                My.MyProject.Forms.CalendarioConvenioTerminal.PrimerPago = Convert.ToDateTime(datePrimerPago.Value.ToShortDateString());
                My.MyProject.Forms.CalendarioConvenioTerminal.Modalidad = Modalidad;
                My.MyProject.Forms.CalendarioConvenioTerminal.deudaTotal = DeudaTotal;
                My.MyProject.Forms.CalendarioConvenioTerminal.gestor = gestor;
                My.MyProject.Forms.CalendarioConvenioTerminal.Show();
            }

            else if (diasCancelado < 30 | abonadoCancelado < 1000d)
            {
                MessageBox.Show("Para crear el convenio terminal, deben haber pasado por lo menos 30 días desde la cancelación de, y tener abonados por lo menos $1,000.00 desde esa fecha.");
            }
            else
            {
                My.MyProject.Forms.CalendarioConvenioTerminal.Moratorios = ParteMoratorios;
                My.MyProject.Forms.CalendarioConvenioTerminal.Capital = ParteCredito;
                My.MyProject.Forms.CalendarioConvenioTerminal.idCredito = Conversions.ToInteger(idCredito);
                My.MyProject.Forms.CalendarioConvenioTerminal.deuda = DeudaTotal;
                My.MyProject.Forms.CalendarioConvenioTerminal.cantPagos = Conversions.ToInteger(txtCantPagos.Text);
                My.MyProject.Forms.CalendarioConvenioTerminal.MontoPago = Conversions.ToDouble(txtPago.Text);
                My.MyProject.Forms.CalendarioConvenioTerminal.PrimerPago = Convert.ToDateTime(datePrimerPago.Value.ToShortDateString());
                My.MyProject.Forms.CalendarioConvenioTerminal.Modalidad = Modalidad;
                My.MyProject.Forms.CalendarioConvenioTerminal.deudaTotal = DeudaTotal;
                My.MyProject.Forms.CalendarioConvenioTerminal.gestor = gestor;
                My.MyProject.Forms.CalendarioConvenioTerminal.Show();
            }

            // End If

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

        private void lblmultas_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

       
    }
}