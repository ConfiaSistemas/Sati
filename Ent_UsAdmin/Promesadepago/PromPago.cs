using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.WinControls.UI;
using Xceed.Words.NET;

namespace ConfiaAdmin
{

    public partial class PromPago
    {
        public int idCredito;
        public string estadoCredito;
        private string nombreCredito;
        public double descuentoTotal;
        private double TotalTotal;
        private double subTotalTotal;
        public double descuentoParcial;
        private double totalParcial;
        private double subTotalParcial;
        public bool creada;
        private DataTable dataVencidos;
        private SqlDataAdapter adapterVencidos;
        private DataTable dataTotal;
        private SqlDataAdapter adapterTotal;
        private double pagoNormalTotal;
        private double multasTotal;
        private double pagonormalParcial;
        private double multasParcial;
        private string existePromesa;
        private Cargando ncargando;
        private string idPromesa;
        public string TipoCredito;

        public PromPago()
        {
            InitializeComponent();
        }

        private void PromPago_Load(object sender, EventArgs e)
        {
            creada = false;
            DoubleBuffered = true;
            dateFechaLimite.Value = DateTime.Now.Date.AddDays(7d);
            TextBox1.BackColor = Color.FromArgb(191, 219, 255);
            TextBox1.ForeColor = Color.FromArgb(21, 66, 139);
            Panel1.BackColor = Color.FromArgb(191, 219, 255);
            Panel2.BackColor = Color.FromArgb(191, 219, 255);
            Panel3.BackColor = Color.FromArgb(191, 219, 255);
            ncargando = new Cargando();
            ncargando.Show();
            ncargando.MonoFlat_Label1.Text = "Consultando promesas";
            ncargando.TopMost = true;
            BackgroundConsultarPromesa.RunWorkerAsync();

        }

        private void RadCollapsiblePanel1_Expanded(object sender, EventArgs e)
        {
            ResumeLayout();
            dtTotal.Visible = true;
        }

        private void RadCollapsiblePanel1_Expanding(object sender, CancelEventArgs e)
        {
            SuspendLayout();
            dtTotal.Visible = false;
        }

        private void RadCollapsiblePanel1_SizeChanged(object sender, EventArgs e)
        {
            if (RadCollapsiblePanel1.IsExpanded)
            {
            }
            else
            {
                dtTotal.Visible = false;
            }
            RadCollapsiblePanel2.IsExpanded = false;

            GroupVencidos.Location = new Point(RadCollapsiblePanel1.Location.X, RadCollapsiblePanel1.Location.Y + RadCollapsiblePanel1.Size.Height + 4);
            RadCollapsiblePanel2.Location = new Point(GroupVencidos.Location.X, GroupVencidos.Location.Y + GroupVencidos.Size.Height + 5);
        }

        private void RadWizard1_Next(object sender, WizardCancelEventArgs e)
        {
            if (ReferenceEquals(RadWizard1.Pages[0], RadWizard1.SelectedPage))
            {
                if (TipoCredito == "Legal")
                {
                    if (dateFechaLimite.Value > DateTime.Now.AddMonths(2))
                    {
                        MessageBox.Show("La fecha límite no puede ser mayor a 2 meses", "SATI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    else
                    {

                    }
                }
                else if (dateFechaLimite.Value > DateTime.Now.AddMonths(1))
                {
                    MessageBox.Show("La fecha límite no puede ser mayor a 1 mes", "SATI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
                else
                {
                    ncargando = new Cargando();
                    ncargando.Show();

                    ncargando.MonoFlat_Label1.Text = "Consultando información";
                    ncargando.TopMost = true;
                    BackgroundVencidos.RunWorkerAsync();

                }

            }
            if (ReferenceEquals(RadWizard1.Pages[1], RadWizard1.SelectedPage))
            {
                if (CheckVencidos.CheckState == CheckState.Checked)
                {

                    TextBox1.Text = "El cliente deberá pagar " + Strings.FormatCurrency(totalParcial, 2) + " antes de la fecha " + dateFechaLimite.Value.ToLongDateString();
                    if (TextBox1.Text.Length > TextBox1.Height)
                    {

                        TextBox1.ScrollBars = ScrollBars.Vertical;
                    }
                    else
                    {
                        TextBox1.ScrollBars = ScrollBars.None;

                    }
                }

                else
                {

                    TextBox1.Text = "El cliente deberá pagar " + Strings.FormatCurrency(TotalTotal, 2) + " antes de la fecha " + dateFechaLimite.Value.ToLongDateString();
                    if (TextBox1.Text.Length > TextBox1.Height)
                    {
                        TextBox1.ScrollBars = ScrollBars.Vertical;
                    }
                    else
                    {
                        TextBox1.ScrollBars = ScrollBars.None;

                    }

                }

            }


        }

        private void BackgroundVencidos_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();

            string consultaDeudaTotal;
            consultaDeudaTotal = @"select nombre, id, pagare, AbonadoSinMultas, (pagare - AbonadoSinMultas) As valorCarteraSinMultas, Multas, (AbonadoMultasL + AbonadoMultasV) As AbonadoMultas, (Multas - (AbonadoMultasL + AbonadoMultasV)) As multasPendientes, ((Multas - (AbonadoMultasL + AbonadoMultasV)) + (pagare - AbonadoSinMultas)) As ValorCarteraConMultas, case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.Estado = 'R' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Promotor,Estado,IdGestor from
(select Cartera.nombre,Cartera.id,
case when Cartera.Estado = 'C' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.IdConvenio = ConveniosSac.id where Abonado <> 0 and Abonado >= interes and ConveniosSac.idcredito = Cartera.id and fechapago <= '" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + @"' group by idcredito),0)
when Cartera.Estado = 'R' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where Abonado <> 0 and Abonado >= interes and ReestructurasSac.idcredito = Cartera.id and fechapago <= '" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + @"' group by idcredito),0)
else
isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id and fechapago <= '" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + @"' group by id_credito),0) end as AbonadoSinMultas,
case when Cartera.Estado = 'C' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConveniosSac inner join ConveniosSac on ConveniosSac.id = CalendarioConveniosSac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioConveniosSac.estado = 'V' and fechapago <= '" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + @"' and ConveniosSac.idcredito = Cartera.id group by ConveniosSac.idcredito),0) 
when Cartera.Estado = 'R' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioReestructurasSac.estado = 'V' and ReestructurasSac.idcredito = Cartera.id and fechapago <= '" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + @"' group by ReestructurasSac.idcredito),0) 
else
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id and fechapago <= '" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + @"' group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id and fechapago <= '" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + @"' group by CalendarioNormal.id_credito),0)),0)end as AbonadoMultasV,
case when Cartera.Estado = 'C' then
isnull((select SUM(Abonado - CalendarioConveniosSac.monto) as AbonadoMultas from CalendarioConveniosSac inner join ConveniosSac on ConveniosSac.id = CalendarioConveniosSac.IdConvenio where  CalendarioConveniosSac.estado = 'L' and ConveniosSac.idcredito = Cartera.id and fechapago <= '" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + @"' group by ConveniosSac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(Abonado - CalendarioReestructurasSac.monto) as AbonadoMultas from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where  CalendarioReestructurasSac.estado = 'L' and ReestructurasSac.idcredito = Cartera.id and fechapago <= '" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + @"' group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L' and CalendarioNormal.id_credito = Cartera.id and fechapago <= '" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + @"' group by CalendarioNormal.id_credito),0) end as AbonadoMultasL,
case when Cartera.Estado = 'C' THEN 
isnull((select SUM(CalendarioConveniosSac.interes) as Multas from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.IdConvenio = ConveniosSac.id where  ConveniosSac.idcredito = Cartera.id and  fechapago <= '" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + @"' group by ConveniosSac.idcredito),0)
when Cartera.Estado = 'R' THEN 
isnull((select SUM(CalendarioReestructurasSac.interes) as Multas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where  ReestructurasSac.idcredito = Cartera.id  and fechapago <= '" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + @"' group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(CalendarioNormal.interes) as Multas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.id_credito = Cartera.id and fechapago <= '" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + @"' group by CalendarioNormal.id_credito),0) end as Multas,
case when cartera.Estado = 'C' THEN 
(select SUM(CalendarioConveniosSac.monto) from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.IdConvenio = ConveniosSac.id where ConveniosSac.idcredito = Cartera.id and fechapago <= '" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + @"')
when cartera.Estado = 'R' THEN 
(select SUM(CalendarioReestructurasSac.monto) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where ReestructurasSac.idcredito = Cartera.id and fechapago <= '" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + @"')
else
(select SUM(CalendarioNormal.monto) from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.id_credito = Cartera.id and fechapago <= '" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + @"') end as pagare,
case when Cartera.Estado = 'C' then
isnull((select SUM(CalendarioConveniosSac.pendiente) from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.IdConvenio = ConveniosSac.id where CalendarioConveniosSac.Estado = 'V' and ConveniosSac.idcredito = Cartera.id and fechapago <= '" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + @"'),0)
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.pendiente) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = Cartera.id and fechapago <= '" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + @"'),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id and fechapago <= '" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + @"'),0) end as pendiente,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.IdConvenio = ConveniosSac.id where CalendarioConveniosSac.Estado ='V' and ConveniosSac.idcredito = Cartera.id and fechapago <= '" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + @"')
when Cartera.Estado = 'R' then
(select SUM(interes) as MultasVencidas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado ='V' and ReestructurasSac.idcredito = Cartera.id and fechapago <= '" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + @"')
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado,Cartera.IdGestor from
(select credito.nombre,Credito.id,Credito.idgestor,Credito.IdPromotor,credito.Estado from Credito inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito where Credito.Estado <> 'L' and Credito.id = '" + idCredito + @"'  group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal order by nombre asc";

            SqlCommand comandoDeudaParcial;
            SqlDataReader readerDeudaParcial;
            comandoDeudaParcial = new SqlCommand();
            comandoDeudaParcial.Connection = Module1.conexionempresa;
            comandoDeudaParcial.CommandText = consultaDeudaTotal;
            readerDeudaParcial = comandoDeudaParcial.ExecuteReader();
            if (readerDeudaParcial.HasRows)
            {
                while (readerDeudaParcial.Read())
                {
                    pagonormalParcial = Conversions.ToDouble(readerDeudaParcial["valorcarterasinmultas"]);
                    multasParcial = Conversions.ToDouble(readerDeudaParcial["multaspendientes"]);
                    nombreCredito = Conversions.ToString(readerDeudaParcial["nombre"]);
                }


            }
            subTotalParcial = pagonormalParcial + multasParcial;
            totalParcial = pagonormalParcial + multasParcial - descuentoParcial;
            lblPagoNormalParcial.Text = Strings.FormatCurrency(pagonormalParcial, 2);
            lblMultasParcial.Text = Strings.FormatCurrency(multasParcial, 2);
            lblDescuentoParcial.Text = Strings.FormatCurrency(descuentoParcial, 2);
            lblTotalParcial.Text = Strings.FormatCurrency(totalParcial, 2);





            string consultaVencidos;
            switch (estadoCredito ?? "")
            {
                case "R":
                    {
                        consultaVencidos = "select idPago,Monto, interes as interés,Abonado,Pendiente,calendarioreestructurassac.Estado,fechapago,calendarioreestructurassac.fecha from calendarioreestructurassac inner join reestructurassac on calendarioreestructurassac.idconvenio = reestructurassac.id where idcredito ='" + idCredito + "' and calendarioreestructurassac.estado <> 'L' and fechapago <='" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + "'";
                        break;
                    }

                case "C":
                    {
                        consultaVencidos = "select idPago,Monto, interes as interés,Abonado,Pendiente,calendarioconveniossac.Estado,fechapago,calendarioconveniossac.fecha from calendarioconveniossac inner join conveniossac on calendarioconveniossac.idconvenio = conveniossac.id where idcredito ='" + idCredito + "' and calendarioconveniossac.estado <> 'L' and fechapago <='" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + "'";
                        break;
                    }

                default:
                    {

                        consultaVencidos = "select idPago,Monto, interes as interés,Abonado,Pendiente,Estado,fechapago,fechaultimopago from calendarionormal where id_credito ='" + idCredito + "' and estado <> 'L' and fechapago <='" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + "'";
                        break;
                    }

            }

            adapterVencidos = new SqlDataAdapter(consultaVencidos, Module1.conexionempresa);
            dataVencidos = new DataTable();
            adapterVencidos.Fill(dataVencidos);

        }

        private void BackgroundVencidos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtVencidos.DataSource = dataVencidos;
            BackgroundTotal.RunWorkerAsync();


        }

        private void BackgroundTotal_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();

            string consultaDeudaTotal;
            consultaDeudaTotal = @"select nombre,id,pagare,AbonadoSinMultas,(pagare-AbonadoSinMultas) as valorCarteraSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,((Multas-(AbonadoMultasL+AbonadoMultasV))+(pagare-AbonadoSinMultas)) as ValorCarteraConMultas, case when carteratotal.Estado = 'C' then
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

            SqlCommand comandoDeudaTotal;
            SqlDataReader readerDeudaTotal;
            comandoDeudaTotal = new SqlCommand();
            comandoDeudaTotal.Connection = Module1.conexionempresa;
            comandoDeudaTotal.CommandText = consultaDeudaTotal;
            readerDeudaTotal = comandoDeudaTotal.ExecuteReader();
            if (readerDeudaTotal.HasRows)
            {
                while (readerDeudaTotal.Read())
                {
                    pagoNormalTotal = Conversions.ToDouble(readerDeudaTotal["valorcarterasinmultas"]);
                    multasTotal = Conversions.ToDouble(readerDeudaTotal["multaspendientes"]);
                    nombreCredito = Conversions.ToString(readerDeudaTotal["nombre"]);
                }


            }

            TotalTotal = pagoNormalTotal + multasTotal - descuentoTotal;
            subTotalTotal = pagoNormalTotal + multasTotal;
            lblPagoNormalTotal.Text = Strings.FormatCurrency(pagoNormalTotal, 2);
            lblMultasTotal.Text = Strings.FormatCurrency(multasTotal, 2);
            lblDescuentoTotal.Text = Strings.FormatCurrency(descuentoTotal, 2);
            lblTotalTotal.Text = Strings.FormatCurrency(TotalTotal, 2);

            string consultaTotal;
            switch (estadoCredito ?? "")
            {
                case "R":
                    {
                        consultaTotal = "select idPago,Monto, interes as interés,Abonado,Pendiente,calendarioreestructurassac.Estado,fechapago,calendarioreestructurassac.fecha from calendarioreestructurassac inner join reestructurassac on calendarioreestructurassac.idconvenio = reestructurassac.id where idcredito ='" + idCredito + "' and calendarioreestructurassac.estado <> 'L'";
                        break;
                    }

                case "C":
                    {
                        consultaTotal = "select idPago,Monto, interes as interés,Abonado,Pendiente,calendarioconveniossac.Estado,fechapago,calendarioconveniossac.fecha from calendarioconveniossac inner join conveniossac on calendarioconveniossac.idconvenio = conveniossac.id where idcredito ='" + idCredito + "' and calendarioconveniossac.estado <> 'L' ";
                        break;
                    }

                default:
                    {
                        consultaTotal = "select idPago,Monto, interes as interés,Abonado,Pendiente,Estado,FechaPago,FechaUltimoPago from calendarionormal where id_credito ='" + idCredito + "' and estado <> 'L' ";
                        break;
                    }

            }

            adapterTotal = new SqlDataAdapter(consultaTotal, Module1.conexionempresa);
            dataTotal = new DataTable();
            adapterTotal.Fill(dataTotal);
        }

        private void RadCollapsiblePanel2_SizeChanged(object sender, EventArgs e)
        {
            RadCollapsiblePanel1.IsExpanded = false;

            // GroupVencidos.Location = New Point(RadCollapsiblePanel1.Location.X, RadCollapsiblePanel1.Location.Y + RadCollapsiblePanel1.Size.Height + 4)
            // RadCollapsiblePanel2.Location = New Point(GroupVencidos.Location.X, GroupVencidos.Location.Y + GroupVencidos.Size.Height + 5)
        }

        private void RadCollapsiblePanel2_Expanding(object sender, CancelEventArgs e)
        {
            SuspendLayout();
            dtVencidos.Visible = false;

        }

        private void RadCollapsiblePanel2_Expanded(object sender, EventArgs e)
        {
            ResumeLayout();
            dtVencidos.Visible = true;
        }

        private void BackgroundTotal_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtTotal.DataSource = dataTotal;
            ncargando.Close();
        }

        private void RadWizard1_Help(object sender, EventArgs e)
        {

        }

        private void CheckTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckTotal.CheckState == CheckState.Checked)
            {
                CheckVencidos.CheckState = CheckState.Unchecked;

            }
        }

        private void CheckVencidos_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckVencidos.CheckState == CheckState.Checked)
            {
                CheckTotal.CheckState = CheckState.Unchecked;

            }
        }

        private void RadWizard1_Finish(object sender, EventArgs e)
        {

            if (CheckVencidos.CheckState == CheckState.Checked)
            {
                if (descuentoParcial == 0d)
                {
                    ncargando = new Cargando();
                    ncargando.Show();
                    ncargando.MonoFlat_Label1.Text = "Creando Promesa";
                    ncargando.TopMost = true;
                    BackgroundCrearPromesa.RunWorkerAsync();
                }
                else
                {
                    foreach (DataRow row in Module1.dataPermisos.Rows)
                    {
                        if (Conversions.ToBoolean(row["SatiModCreditosDescuentoPromesa"]))
                        {
                            ncargando = new Cargando();
                            ncargando.Show();
                            ncargando.MonoFlat_Label1.Text = "Creando Promesa";
                            ncargando.TopMost = true;
                            BackgroundCrearPromesa.RunWorkerAsync();
                            break;
                        }
                        else if (MessageBox.Show("¿No cuenta con los permisos para aplicar descuento, desea notificar a un usuario?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            ncargando = new Cargando();
                            ncargando.Show();
                            ncargando.MonoFlat_Label1.Text = "Creando Promesa";
                            ncargando.TopMost = true;
                            BackgroundPromesaNotificacion.RunWorkerAsync();


                        }
                    }

                }
            }
            else if (descuentoTotal == 0d)
            {
                ncargando = new Cargando();
                ncargando.Show();
                ncargando.MonoFlat_Label1.Text = "Creando Promesa";
                ncargando.TopMost = true;
                BackgroundCrearPromesa.RunWorkerAsync();
            }
            else
            {
                foreach (DataRow row in Module1.dataPermisos.Rows)
                {
                    if (Conversions.ToBoolean(row["SatiModCreditosDescuentoPromesa"]))
                    {
                        ncargando = new Cargando();
                        ncargando.Show();
                        ncargando.MonoFlat_Label1.Text = "Creando Promesa";
                        ncargando.TopMost = true;
                        BackgroundCrearPromesa.RunWorkerAsync();
                        break;
                    }
                    else if (MessageBox.Show("¿No cuenta con los permisos para aplicar descuento, desea notificar a un usuario?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ncargando = new Cargando();
                        ncargando.Show();
                        ncargando.MonoFlat_Label1.Text = "Creando Promesa";
                        ncargando.TopMost = true;
                        BackgroundPromesaNotificacion.RunWorkerAsync();


                    }
                }

            }


        }

        private void BackgroundCrearPromesa_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consultaCrearPromesa;

            SqlCommand comandoCrearPromesa;

            if (CheckVencidos.CheckState == CheckState.Checked)
            {
                consultaCrearPromesa = "insert into PromesaDePago values('" + idCredito + "','" + totalParcial + "','" + pagonormalParcial + "','" + multasParcial + "','" + totalParcial + "',0,'" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + "','','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("HH:mm:ss") + "','" + Module1.nmusr + "','A','" + estadoCredito + "','" + subTotalParcial + "','" + descuentoParcial + "',0) SELECT SCOPE_IDENTITY()";
            }
            else
            {
                consultaCrearPromesa = "insert into PromesaDePago values('" + idCredito + "','" + TotalTotal + "','" + pagoNormalTotal + "','" + multasTotal + "','" + TotalTotal + "',0,'" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + "','','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("HH:mm:ss") + "','" + Module1.nmusr + "','A','" + estadoCredito + "','" + subTotalTotal + "','" + descuentoTotal + "',0) SELECT SCOPE_IDENTITY()";
            }

            comandoCrearPromesa = new SqlCommand();
            comandoCrearPromesa.Connection = Module1.conexionempresa;
            comandoCrearPromesa.CommandText = consultaCrearPromesa;
            idPromesa = Conversions.ToString(comandoCrearPromesa.ExecuteScalar());

            if (CheckVencidos.CheckState == CheckState.Checked)
            {
                foreach (DataGridViewRow row in dtVencidos.Rows)
                {
                    string consultaDetallePromesa;
                    SqlCommand comandoDetallePromesa;
                    consultaDetallePromesa = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into DetallePromesa values('" + idPromesa + "','", row.Cells[0].Value), "','"), row.Cells[1].Value), "','"), row.Cells[2].Value), "','"), row.Cells[3].Value), "','"), row.Cells[4].Value), "','"), row.Cells[5].Value), "','"), row.Cells[6].Value), "','"), row.Cells[7].Value), "','"), estadoCredito), "')"));
                    comandoDetallePromesa = new SqlCommand();
                    comandoDetallePromesa.Connection = Module1.conexionempresa;
                    comandoDetallePromesa.CommandText = consultaDetallePromesa;
                    comandoDetallePromesa.ExecuteNonQuery();


                    string consultaActualizaCalConvenio;
                    SqlCommand comandoActualizaCalConvenios;
                    switch (estadoCredito ?? "")
                    {
                        case "C":
                            {
                                consultaActualizaCalConvenio = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Update calendarioConveniossac set convenio = 1 where idpago = '", row.Cells[0].Value), "'"));
                                break;
                            }


                        case "R":
                            {
                                consultaActualizaCalConvenio = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Update calendarioReestructurasSac set convenio = 1 where idpago = '", row.Cells[0].Value), "'"));
                                break;
                            }

                        default:
                            {
                                consultaActualizaCalConvenio = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Update calendarioNormal set convenio = 1 where idpago = '", row.Cells[0].Value), "'"));
                                break;
                            }
                    }
                    comandoActualizaCalConvenios = new SqlCommand();
                    comandoActualizaCalConvenios.Connection = Module1.conexionempresa;
                    comandoActualizaCalConvenios.CommandText = consultaActualizaCalConvenio;
                    comandoActualizaCalConvenios.ExecuteNonQuery();

                }
            }
            else
            {
                foreach (DataGridViewRow row in dtTotal.Rows)
                {
                    string consultaDetallePromesa;
                    SqlCommand comandoDetallePromesa;
                    consultaDetallePromesa = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into DetallePromesa values('" + idPromesa + "','", row.Cells[0].Value), "','"), row.Cells[1].Value), "','"), row.Cells[2].Value), "','"), row.Cells[3].Value), "','"), row.Cells[4].Value), "','"), row.Cells[5].Value), "','"), row.Cells[6].Value), "','"), row.Cells[7].Value), "','"), estadoCredito), "')"));
                    comandoDetallePromesa = new SqlCommand();
                    comandoDetallePromesa.Connection = Module1.conexionempresa;
                    comandoDetallePromesa.CommandText = consultaDetallePromesa;
                    comandoDetallePromesa.ExecuteNonQuery();

                    string consultaActualizaCalConvenio;
                    SqlCommand comandoActualizaCalConvenios;
                    switch (estadoCredito ?? "")
                    {
                        case "C":
                            {
                                consultaActualizaCalConvenio = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Update calendarioConveniossac set convenio = 1 where idpago = '", row.Cells[0].Value), "'"));
                                break;
                            }


                        case "R":
                            {
                                consultaActualizaCalConvenio = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Update calendarioReestructurasSac set convenio = 1 where idpago = '", row.Cells[0].Value), "'"));
                                break;
                            }

                        default:
                            {
                                consultaActualizaCalConvenio = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Update calendarioNormal set convenio = 1 where idpago = '", row.Cells[0].Value), "'"));
                                break;
                            }
                    }
                    comandoActualizaCalConvenios = new SqlCommand();
                    comandoActualizaCalConvenios.Connection = Module1.conexionempresa;
                    comandoActualizaCalConvenios.CommandText = consultaActualizaCalConvenio;
                    comandoActualizaCalConvenios.ExecuteNonQuery();

                }
            }





        }

        private void BackgroundCrearPromesa_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ncargando.MonoFlat_Label1.Text = "Generando Formato";

            FileSystem.FileCopy(@"C:\ConfiaAdmin\SATI\Promesa.docx", @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempPromesa.docx");
            var documento = DocX.Load(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempPromesa.docx");
            documento.ReplaceText("%%FECHAPROMESA%%", DateTime.Now.ToShortDateString());
            documento.ReplaceText("%%NOMBRECLIENTE%%", nombreCredito);
            if (CheckVencidos.CheckState == CheckState.Checked)
            {
                documento.ReplaceText("%%TOTALDEUDA%%", Strings.FormatCurrency(totalParcial, 2));
            }
            else
            {
                documento.ReplaceText("%%TOTALDEUDA%%", Strings.FormatCurrency(TotalTotal, 2));
            }
            documento.ReplaceText("%%FECHALIMITE%%", dateFechaLimite.Value.ToShortDateString());
            documento.Save();
            documento.Dispose();
            My.MyProject.Forms.VistaPreviaDocumento.ruta = @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempPromesa.docx";
            My.MyProject.Forms.VistaPreviaDocumento.Show();
            ncargando.Close();
            Close();

        }

        private void BackgroundConsultarPromesa_DoWork(object sender, DoWorkEventArgs e)
        {
            string consultaPromesa;
            consultaPromesa = "if exists(Select * from promesadepago where idcredito = '" + idCredito + @"' and estado = 'A')
                            begin
                                select 'Existe'
                            end
                            else if exists(Select * from promesadepago where idcredito = '" + idCredito + @"' and estado = 'E' and notificado = 0)
							begin
							 select 'Pendiente'
							end
							else if exists(select * from promesadepago where idcredito = '" + idCredito + @"' and estado = 'E' and Notificado = 1)
                            begin
                             Select 'Notificado'
                            end
                            else
							select 'Noexiste'
";


            SqlCommand comandoPromesa;
            comandoPromesa = new SqlCommand();
            comandoPromesa.Connection = Module1.conexionempresa;
            comandoPromesa.CommandText = consultaPromesa;
            existePromesa = Conversions.ToString(comandoPromesa.ExecuteScalar());

        }

        private void BackgroundConsultarPromesa_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ncargando.Close();
            if (existePromesa == "Existe")
            {

                MessageBox.Show("El crédito ya cuenta con una promesa activa");
                Close();
            }
            else if (existePromesa == "Pendiente")
            {
                MessageBox.Show("El crédito cuenta con una promesa pendiente, se intentará notificar de nuevo");

                ncargando = new Cargando();
                ncargando.Show();
                ncargando.MonoFlat_Label1.Text = "Consultando Promesa";
                ncargando.TopMost = true;
                BackgroundConsultaPromesaPendiente.RunWorkerAsync();
            }

            else if (existePromesa == "Notificado")
            {
                MessageBox.Show("El crédito cuenta con una notificación pendiente de autorizar");
                Close();
            }
            else
            {


            }
        }

        private void PromPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {

                if (ReferenceEquals(RadWizard1.Pages[1], RadWizard1.SelectedPage))
                {
                    if (CheckVencidos.CheckState == CheckState.Checked)
                    {
                        My.MyProject.Forms.DescuentoPromesa.Maximo = multasParcial;
                        My.MyProject.Forms.DescuentoPromesa.Total = false;
                        My.MyProject.Forms.DescuentoPromesa.ShowDialog();
                        totalParcial = pagonormalParcial + multasParcial - descuentoParcial;
                        lblDescuentoParcial.Text = Strings.FormatCurrency(descuentoParcial, 2);
                        lblTotalParcial.Text = Strings.FormatCurrency(totalParcial, 2);
                    }
                    else
                    {
                        My.MyProject.Forms.DescuentoPromesa.Maximo = multasTotal;
                        My.MyProject.Forms.DescuentoPromesa.Total = true;
                        My.MyProject.Forms.DescuentoPromesa.ShowDialog();
                        TotalTotal = pagoNormalTotal + multasTotal - descuentoTotal;
                        lblDescuentoTotal.Text = Strings.FormatCurrency(descuentoTotal, 2);
                        lblTotalTotal.Text = Strings.FormatCurrency(TotalTotal, 2);
                    }
                }
            }
        }

        private void BackgroundPromesaNotificacion_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consultaCrearPromesa;

            SqlCommand comandoCrearPromesa;

            if (CheckVencidos.CheckState == CheckState.Checked)
            {
                consultaCrearPromesa = "insert into PromesaDePago values('" + idCredito + "','" + totalParcial + "','" + pagonormalParcial + "','" + multasParcial + "','" + totalParcial + "',0,'" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + "','','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("HH:mm:ss") + "','" + Module1.nmusr + "','E','" + estadoCredito + "','" + subTotalParcial + "','" + descuentoParcial + "',0) SELECT SCOPE_IDENTITY()";
            }
            else
            {
                consultaCrearPromesa = "insert into PromesaDePago values('" + idCredito + "','" + TotalTotal + "','" + pagoNormalTotal + "','" + multasTotal + "','" + TotalTotal + "',0,'" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + "','','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("HH:mm:ss") + "','" + Module1.nmusr + "','E','" + estadoCredito + "','" + subTotalTotal + "','" + descuentoTotal + "',0) SELECT SCOPE_IDENTITY()";
            }

            comandoCrearPromesa = new SqlCommand();
            comandoCrearPromesa.Connection = Module1.conexionempresa;
            comandoCrearPromesa.CommandText = consultaCrearPromesa;
            idPromesa = Conversions.ToString(comandoCrearPromesa.ExecuteScalar());

            if (CheckVencidos.CheckState == CheckState.Checked)
            {
                foreach (DataGridViewRow row in dtVencidos.Rows)
                {
                    string consultaDetallePromesa;
                    SqlCommand comandoDetallePromesa;
                    consultaDetallePromesa = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into DetallePromesa values('" + idPromesa + "','", row.Cells[0].Value), "','"), row.Cells[1].Value), "','"), row.Cells[2].Value), "','"), row.Cells[3].Value), "','"), row.Cells[4].Value), "','"), row.Cells[5].Value), "','"), row.Cells[6].Value), "','"), row.Cells[7].Value), "','"), estadoCredito), "')"));
                    comandoDetallePromesa = new SqlCommand();
                    comandoDetallePromesa.Connection = Module1.conexionempresa;
                    comandoDetallePromesa.CommandText = consultaDetallePromesa;
                    comandoDetallePromesa.ExecuteNonQuery();


                    string consultaActualizaCalConvenio;
                    SqlCommand comandoActualizaCalConvenios;
                    switch (estadoCredito ?? "")
                    {
                        case "C":
                            {
                                consultaActualizaCalConvenio = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Update calendarioConveniossac set convenio = 1 where idpago = '", row.Cells[0].Value), "'"));
                                break;
                            }


                        case "R":
                            {
                                consultaActualizaCalConvenio = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Update calendarioReestructurasSac set convenio = 1 where idpago = '", row.Cells[0].Value), "'"));
                                break;
                            }

                        default:
                            {
                                consultaActualizaCalConvenio = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Update calendarioNormal set convenio = 1 where idpago = '", row.Cells[0].Value), "'"));
                                break;
                            }
                    }
                    comandoActualizaCalConvenios = new SqlCommand();
                    comandoActualizaCalConvenios.Connection = Module1.conexionempresa;
                    comandoActualizaCalConvenios.CommandText = consultaActualizaCalConvenio;
                    comandoActualizaCalConvenios.ExecuteNonQuery();

                }
            }
            else
            {
                foreach (DataGridViewRow row in dtTotal.Rows)
                {
                    string consultaDetallePromesa;
                    SqlCommand comandoDetallePromesa;
                    consultaDetallePromesa = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into DetallePromesa values('" + idPromesa + "','", row.Cells[0].Value), "','"), row.Cells[1].Value), "','"), row.Cells[2].Value), "','"), row.Cells[3].Value), "','"), row.Cells[4].Value), "','"), row.Cells[5].Value), "','"), row.Cells[6].Value), "','"), row.Cells[7].Value), "','"), estadoCredito), "')"));
                    comandoDetallePromesa = new SqlCommand();
                    comandoDetallePromesa.Connection = Module1.conexionempresa;
                    comandoDetallePromesa.CommandText = consultaDetallePromesa;
                    comandoDetallePromesa.ExecuteNonQuery();
                    string consultaActualizaCalConvenio;
                    SqlCommand comandoActualizaCalConvenios;
                    switch (estadoCredito ?? "")
                    {
                        case "C":
                            {
                                consultaActualizaCalConvenio = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Update calendarioConveniossac set convenio = 1 where idpago = '", row.Cells[0].Value), "'"));
                                break;
                            }


                        case "R":
                            {
                                consultaActualizaCalConvenio = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Update calendarioReestructurasSac set convenio = 1 where idpago = '", row.Cells[0].Value), "'"));
                                break;
                            }

                        default:
                            {
                                consultaActualizaCalConvenio = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Update calendarioNormal set convenio = 1 where idpago = '", row.Cells[0].Value), "'"));
                                break;
                            }
                    }
                    comandoActualizaCalConvenios = new SqlCommand();
                    comandoActualizaCalConvenios.Connection = Module1.conexionempresa;
                    comandoActualizaCalConvenios.CommandText = consultaActualizaCalConvenio;
                    comandoActualizaCalConvenios.ExecuteNonQuery();


                }
            }

        }

        private void BackgroundPromesaNotificacion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ncargando.Close();
            My.MyProject.Forms.CrearNotificacionDescuentoPromesa.idPromesa = idPromesa;
            My.MyProject.Forms.CrearNotificacionDescuentoPromesa.tipoCredito = TipoCredito;
            My.MyProject.Forms.CrearNotificacionDescuentoPromesa.ShowDialog();

            if (creada)
            {
                Task.Factory.StartNew(() =>
                    {
                        SqlCommand comandoActualizaPromesa;
                        string consultaActualizaPromesa;
                        consultaActualizaPromesa = "update promesadepago set notificado = 1 where id = '" + idPromesa + "'";
                        comandoActualizaPromesa = new SqlCommand();
                        comandoActualizaPromesa.Connection = Module1.conexionempresa;
                        comandoActualizaPromesa.CommandText = consultaActualizaPromesa;
                        comandoActualizaPromesa.ExecuteNonQuery();


                    });
                Close();
            }
            else if (MessageBox.Show("¿La notificación no fue creada, desea volver a intentarlo?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                My.MyProject.Forms.CrearNotificacionDescuentoPromesa.idPromesa = idPromesa;
                My.MyProject.Forms.CrearNotificacionDescuentoPromesa.tipoCredito = TipoCredito;
                My.MyProject.Forms.CrearNotificacionDescuentoPromesa.ShowDialog();
                if (creada)
                {
                    Task.Factory.StartNew(() =>
                    {
                        SqlCommand comandoActualizaPromesa;
                        string consultaActualizaPromesa;
                        consultaActualizaPromesa = "update promesadepago set notificado = 1 where id = '" + idPromesa + "'";
                        comandoActualizaPromesa = new SqlCommand();
                        comandoActualizaPromesa.Connection = Module1.conexionempresa;
                        comandoActualizaPromesa.CommandText = consultaActualizaPromesa;
                        comandoActualizaPromesa.ExecuteNonQuery();


                    });
                    Close();
                }
                else
                {
                    MessageBox.Show("La notificación no fue creada, puedes intentarlo más tarde");
                    Close();

                }
            }
            else
            {
                Close();

            }


        }

        private void RadWizard1_Cancel(object sender, EventArgs e)
        {
            Close();

        }

        private void BackgroundConsultaPromesaPendiente_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consultaPromesa;
            consultaPromesa = "select id from promesadepago where idcredito = '" + idCredito + "' and estado = 'E' and notificado = 0";
            SqlCommand comandoPromesa;
            comandoPromesa = new SqlCommand();
            comandoPromesa.Connection = Module1.conexionempresa;
            comandoPromesa.CommandText = consultaPromesa;
            idPromesa = Conversions.ToString(comandoPromesa.ExecuteScalar());

        }

        private void BackgroundConsultaPromesaPendiente_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ncargando.Close();
            My.MyProject.Forms.CrearNotificacionDescuentoPromesa.idPromesa = idPromesa;
            My.MyProject.Forms.CrearNotificacionDescuentoPromesa.tipoCredito = TipoCredito;
            My.MyProject.Forms.CrearNotificacionDescuentoPromesa.ShowDialog();

            if (creada)
            {
                Task.Factory.StartNew(() =>
                    {
                        SqlCommand comandoActualizaPromesa;
                        string consultaActualizaPromesa;
                        consultaActualizaPromesa = "update promesadepago set notificado = 1 where id = '" + idPromesa + "'";
                        comandoActualizaPromesa = new SqlCommand();
                        comandoActualizaPromesa.Connection = Module1.conexionempresa;
                        comandoActualizaPromesa.CommandText = consultaActualizaPromesa;
                        comandoActualizaPromesa.ExecuteNonQuery();


                    });
                Close();
            }
            else if (MessageBox.Show("¿La notificación no fue creada, desea volver a intentarlo?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                My.MyProject.Forms.CrearNotificacionDescuentoPromesa.idPromesa = idPromesa;
                My.MyProject.Forms.CrearNotificacionDescuentoPromesa.tipoCredito = TipoCredito;
                My.MyProject.Forms.CrearNotificacionDescuentoPromesa.ShowDialog();
                if (creada)
                {
                    Task.Factory.StartNew(() =>
                    {
                        SqlCommand comandoActualizaPromesa;
                        string consultaActualizaPromesa;
                        consultaActualizaPromesa = "update promesadepago set notificado = 1 where id = '" + idPromesa + "'";
                        comandoActualizaPromesa = new SqlCommand();
                        comandoActualizaPromesa.Connection = Module1.conexionempresa;
                        comandoActualizaPromesa.CommandText = consultaActualizaPromesa;
                        comandoActualizaPromesa.ExecuteNonQuery();


                    });
                    Close();
                }
                else
                {
                    MessageBox.Show("La notificación no fue creada, puedes intentarlo más tarde");
                    Close();

                }
            }
            else
            {
                Close();

            }
        }


    }
}