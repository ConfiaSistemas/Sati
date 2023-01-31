using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class PromesaPago
    {



        private string Modalidad;
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
        public double DeudaAP;
        public double DeudaTotal;
        public bool incluyePorcentaje;
        private double capitalPromesa;
        private double moratoriosPromesa;
        private Cargando ncargando;
        private bool conerror;
        public bool Autorizado;

        public PromesaPago()
        {
            InitializeComponent();
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
when CarteraTotal.Estado = 'R' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Promotor,Estado,IdGestor from
(select Cartera.nombre,Cartera.id,
case when Cartera.Estado = 'C' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.IdConvenio = ConveniosSac.id where Abonado <> 0 and Abonado >= interes and ConveniosSac.idcredito = Cartera.id group by idcredito),0)
when Cartera.Estado = 'R' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where Abonado <> 0 and Abonado >= interes and ReestructurasSac.idcredito = Cartera.id group by idcredito),0)
else
isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id group by id_credito),0) end as AbonadoSinMultas,
case when Cartera.Estado = 'C' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConveniosSac inner join ConveniosSac on ConveniosSac.id = CalendarioConveniosSac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioConveniosSac.estado = 'V' and ConveniosSac.idcredito = Cartera.id group by ConveniosSac.idcredito),0) 
when Cartera.Estado = 'R' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioReestructurasSac.estado = 'V' and ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0) 
else
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)),0)end as AbonadoMultasV,
case when Cartera.Estado = 'C' then
isnull((select SUM(Abonado - CalendarioConveniosSac.monto) as AbonadoMultas from CalendarioConveniosSac inner join ConveniosSac on ConveniosSac.id = CalendarioConveniosSac.IdConvenio where  CalendarioConveniosSac.estado = 'L' and ConveniosSac.idcredito = Cartera.id group by ConveniosSac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(Abonado - CalendarioReestructurasSac.monto) as AbonadoMultas from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where  CalendarioReestructurasSac.estado = 'L' and ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L' and CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as AbonadoMultasL,
case when Cartera.Estado = 'C' THEN 
isnull((select SUM(CalendarioConveniosSac.interes) as Multas from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.IdConvenio = ConveniosSac.id where  ConveniosSac.idcredito = Cartera.id group by ConveniosSac.idcredito),0)
when Cartera.Estado = 'R' THEN 
isnull((select SUM(CalendarioReestructurasSac.interes) as Multas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where  ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(CalendarioNormal.interes) as Multas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as Multas,
case when cartera.Estado = 'C' THEN 
(select SUM(CalendarioConveniosSac.monto) from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.IdConvenio = ConveniosSac.id where ConveniosSac.idcredito = Cartera.id)
when cartera.Estado = 'R' THEN 
(select SUM(CalendarioReestructurasSac.monto) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where ReestructurasSac.idcredito = Cartera.id)
else
(select Pagare from credito where id = Cartera.id) end as pagare,
case when Cartera.Estado = 'C' then
isnull((select SUM(CalendarioConveniosSac.pendiente) from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.IdConvenio = ConveniosSac.id where CalendarioConveniosSac.Estado = 'V' and ConveniosSac.idcredito = Cartera.id),0)
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.pendiente) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.IdConvenio = ConveniosSac.id where CalendarioConveniosSac.Estado ='V' and ConveniosSac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(interes) as MultasVencidas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado ='V' and ReestructurasSac.idcredito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado,Cartera.IdGestor from
(select credito.nombre,Credito.id,Credito.idgestor,Credito.IdPromotor,credito.Estado from Credito inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito where Credito.Estado <> 'L' and Credito.id = '" + idCredito + @"'  group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado) Cartera inner join
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
                    // incluyePorcentaje = readerCreditoLegal("incluyeporcentaje")
                }
            }
            // CheckPorcentaje.Checked = incluyePorcentaje
            lblpagare.Text = Strings.FormatCurrency(pagare);
            lblAbonadoSmultas.Text = Strings.FormatCurrency(abonadoSmultas);
            lblmultas.Text = Strings.FormatCurrency(multas);
            lblMultasAbonadas.Text = Strings.FormatCurrency(abonadoMultas);

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
            dateFechaLimite.Value = DateTime.Now;
            BackgroundDatos.RunWorkerAsync();

        }








        private void btnGenerarCalendario_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Autorizacion.tipoAutorizacion = "SatiModCreditosCrearPromesa";
            My.MyProject.Forms.Autorizacion.ShowDialog();
            if (Autorizado)
            {
                if (Conversions.ToDouble(txtPago.Text) < ParteCredito)
                {
                    MessageBox.Show("No puedes ingresar una cantidad menor a " + Strings.FormatCurrency(ParteCredito, 2));
                }
                else
                {
                    ncargando = new Cargando();
                    ncargando.Show();
                    ncargando.MonoFlat_Label1.Text = "Creando promesa de pago";
                    btnGenerarPromesa.Enabled = false;

                    BackgroundCreaPromesa.RunWorkerAsync();

                }
            }
            else
            {
                MessageBox.Show("No fue autorizado");
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

        private void BackgroundCreaPromesa_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {
                Module1.iniciarconexionempresa();
                SqlCommand comandoPromesa;
                string consultaPromesa;
                moratoriosPromesa = Conversions.ToDouble(txtPago.Text) - ParteCredito;
                capitalPromesa = Conversions.ToDouble(txtPago.Text) - moratoriosPromesa;

                consultaPromesa = "insert into promesadepago values('" + idCredito + "','" + txtPago.Text + "','" + capitalPromesa + "','" + moratoriosPromesa + "','" + txtPago.Text + "','0','" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + "','',GETDATE(),convert(char(8), getdate(), 108) ,'" + Module1.nmusr + "','A')";

                comandoPromesa = new SqlCommand();
                comandoPromesa.Connection = Module1.conexionempresa;
                comandoPromesa.CommandText = consultaPromesa;
                comandoPromesa.ExecuteNonQuery();
                conerror = false;
            }
            catch (Exception ex)
            {
                conerror = true;
                MessageBox.Show(ex.Message);
            }


        }

        private void BackgroundCreaPromesa_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ncargando.Close();

            if (conerror)
            {
                btnGenerarPromesa.Enabled = true;
                MessageBox.Show("Hubo un error, intenta de nuevo");
            }
            else
            {
                MessageBox.Show("Promesa generada con éxito");
                Close();

            }

        }
    }
}