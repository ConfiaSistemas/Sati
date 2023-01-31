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

    public partial class PromPagoLegal
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

        public PromPagoLegal()
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

        }

        private void RadWizard1_Next(object sender, WizardCancelEventArgs e)
        {
            if (ReferenceEquals(RadWizard1.Pages[0], RadWizard1.SelectedPage))
            {

                if (dateFechaLimite.Value > DateTime.Now.AddMonths(2))
                {
                    MessageBox.Show("La fecha límite no puede ser mayor a 2 meses", "SATI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
                else
                {
                    ncargando = new Cargando();
                    ncargando.Show();

                    ncargando.MonoFlat_Label1.Text = "Consultando información";
                    ncargando.TopMost = true;
                    BackgroundTotal.RunWorkerAsync();

                }


            }
            if (ReferenceEquals(RadWizard1.Pages[1], RadWizard1.SelectedPage))
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





        private void BackgroundTotal_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();

            string consultaDeudaTotal;
            consultaDeudaTotal = @"select *,(interesL+AbonadoInteresV) as abonadoInteresTotal,(Abonado- (AbonadoInteresV+interesL)) as AbonadoSinInteres,(Intereses-(interesL+AbonadoInteresV)) as InteresPendiente,
case when multas <> 0 then
(PendienteLegal-(Intereses-(interesL+AbonadoInteresV)))
else ((PendienteLegal-(Intereses-(interesL+AbonadoInteresV))) ) - ((PendienteLegal-(Intereses-(interesL+AbonadoInteresV))) * PorcentajeMoratorio) end as PendienteSinteres,
 case when multas <> 0 then
 Intereses - (AbonadoInteresV + interesL)
 else
 ((PendienteLegal-(Intereses-(interesL+AbonadoInteresV))) * PorcentajeMoratorio) end as MoratoriosPendientes,
 case when multas <> 0 then
 Intereses - (AbonadoInteresV + interesL)
 else
 (((PendienteLegal-(Intereses-(interesL+AbonadoInteresV))) * PorcentajeMoratorio) + (Intereses-(interesL+AbonadoInteresV))) end as MoratorioMmultas from
(select *, case when DatosLegal.Gastos + DatosLegal.DeudaAP = DatosLegal.MontoConvenio
then Moratorios/MontoConvenio else (Moratorios*1.30) / MontoConvenio end as PorcentajeMoratorio,
Abonado - interesL as AbonadoSinteres,
case when DatosLegal.Multas <> 0 then
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioLegales  where CalendarioLegales.estado = 'V' and Abonado <= CalendarioLegales.Interes and CalendarioLegales.idcredito =datoslegal.id group by CalendarioLegales.idcredito),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioLegales.Interes) ))) )) as AbonadoInteres from CalendarioLegales  where CalendarioLegales.estado = 'V' and Abonado >=CalendarioLegales.Interes and CalendarioLegales.idCredito =DatosLegal.id group by CalendarioLegales.idcredito),0)),0)

 else
 case when AbonadoV<=InteresV1 then AbonadoV else InteresV1 end end as AbonadoInteresV
 from
(select *,ISNULL((select sum(monto) as monto from CalendarioLegales where idCredito = legal.id),0) as Monto,isnull((select sum(abonado) from CalendarioLegales where idCredito = legal.id),0) as Abonado,isnull((select sum(Interes) from CalendarioLegales where idCredito = legal.id),0) as Intereses,isnull((select sum(Multas) from CalendarioLegales where idCredito = legal.id),0) as Multas,isnull((select sum(abonado) from CalendarioLegales where idCredito = legal.id and Estado = 'L'),0) as AbonadoL,isnull((select sum(abonado) from CalendarioLegales where idCredito = legal.id and Estado = 'V'),0) as AbonadoV,isnull((select sum(abonado) from CalendarioLegales where idCredito = legal.id and Estado = 'P'),0) as Abonadop,isnull((select sum(Interes) from CalendarioLegales where idCredito = legal.id and Estado = 'V'),0) as interesV,

isnull((select sum(Interes) from CalendarioLegales where idCredito = legal.id and Estado = 'L'),0) as interesL,
ISNULL((SELECT SUM(pendiente) from CalendarioLegales where idCredito = legal.id and Estado in ('P','V')),0) as PendienteLegal, ISNULL((select SUM(Monto) from GastosLegales where idCredito = Legal.id),0) as Gastos,
ISNULL((select top 1 Interes from CalendarioLegales where Estado = 'V' and idCredito = legal.id order by NPago asc),0) as InteresV1
 from
(select * from legales where Estado = 'C' and id = '" + idCredito + "') legal) DatosLegal) DatosPlegal";

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
                    pagoNormalTotal = Conversions.ToDouble(readerDeudaTotal["pendientesinteres"]);
                    multasTotal = Conversions.ToDouble(readerDeudaTotal["moratoriommultas"]);
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

            consultaTotal = "select idPago,Monto, interes as interés,Abonado,Pendiente,calendariolegales.Estado,fechapago,calendariolegales.fechaultimopago from calendariolegales  where idcredito ='" + idCredito + "' and calendariolegales.estado <> 'L'";



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





        private void BackgroundTotal_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtTotal.DataSource = dataTotal;
            ncargando.Close();
        }







        private void RadWizard1_Finish(object sender, EventArgs e)
        {


            if (descuentoTotal == 0d)
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


            consultaCrearPromesa = "insert into PromesaDePago values('" + idCredito + "','" + TotalTotal + "','" + pagoNormalTotal + "','" + multasTotal + "','" + TotalTotal + "',0,'" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + "','','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("HH:mm:ss") + "','" + Module1.nmusr + "','A','" + estadoCredito + "','" + subTotalTotal + "','" + descuentoTotal + "',0) SELECT SCOPE_IDENTITY()";


            comandoCrearPromesa = new SqlCommand();
            comandoCrearPromesa.Connection = Module1.conexionempresa;
            comandoCrearPromesa.CommandText = consultaCrearPromesa;
            idPromesa = Conversions.ToString(comandoCrearPromesa.ExecuteScalar());


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

                consultaActualizaCalConvenio = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Update calendariolegales set convenio = 1 where idpago = '", row.Cells[0].Value), "'"));

                comandoActualizaCalConvenios = new SqlCommand();
                comandoActualizaCalConvenios.Connection = Module1.conexionempresa;
                comandoActualizaCalConvenios.CommandText = consultaActualizaCalConvenio;
                comandoActualizaCalConvenios.ExecuteNonQuery();

            }





        }

        private void BackgroundCrearPromesa_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ncargando.MonoFlat_Label1.Text = "Generando Formato";

            FileSystem.FileCopy(@"C:\ConfiaAdmin\SATI\Promesa.docx", @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempPromesa.docx");
            var documento = DocX.Load(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempPromesa.docx");
            documento.ReplaceText("%%FECHAPROMESA%%", DateTime.Now.ToShortDateString());
            documento.ReplaceText("%%NOMBRECLIENTE%%", nombreCredito);

            documento.ReplaceText("%%TOTALDEUDA%%", Strings.FormatCurrency(TotalTotal, 2));

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
            consultaPromesa = "if exists(Select * from promesadepago where idcredito = '" + idCredito + "' and estado = 'A' and tipocredito = '" + estadoCredito + @"')
                            begin
                                select 'Existe'
                            end
                            else if exists(Select * from promesadepago where idcredito = '" + idCredito + "' and estado = 'E' and notificado = 0 and tipocredito = '" + estadoCredito + @"')
							begin
							 select 'Pendiente'
							end
							else if exists(select * from promesadepago where idcredito = '" + idCredito + "' and estado = 'E' and Notificado = 1 and tipocredito = '" + estadoCredito + @"')
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

                    My.MyProject.Forms.DescuentoPromesaLegal.Maximo = multasTotal;
                    My.MyProject.Forms.DescuentoPromesaLegal.Total = true;
                    My.MyProject.Forms.DescuentoPromesaLegal.ShowDialog();
                    TotalTotal = pagoNormalTotal + multasTotal - descuentoTotal;
                    lblDescuentoTotal.Text = Strings.FormatCurrency(descuentoTotal, 2);
                    lblTotalTotal.Text = Strings.FormatCurrency(TotalTotal, 2);

                }
            }
        }

        private void BackgroundPromesaNotificacion_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consultaCrearPromesa;

            SqlCommand comandoCrearPromesa;


            consultaCrearPromesa = "insert into PromesaDePago values('" + idCredito + "','" + TotalTotal + "','" + pagoNormalTotal + "','" + multasTotal + "','" + TotalTotal + "',0,'" + dateFechaLimite.Value.ToString("yyyy-MM-dd") + "','','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("HH:mm:ss") + "','" + Module1.nmusr + "','E','" + estadoCredito + "','" + subTotalTotal + "','" + descuentoTotal + "',0) SELECT SCOPE_IDENTITY()";


            comandoCrearPromesa = new SqlCommand();
            comandoCrearPromesa.Connection = Module1.conexionempresa;
            comandoCrearPromesa.CommandText = consultaCrearPromesa;
            idPromesa = Conversions.ToString(comandoCrearPromesa.ExecuteScalar());


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

                consultaActualizaCalConvenio = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Update calendariolegales set convenio = 1 where idpago = '", row.Cells[0].Value), "'"));

                comandoActualizaCalConvenios = new SqlCommand();
                comandoActualizaCalConvenios.Connection = Module1.conexionempresa;
                comandoActualizaCalConvenios.CommandText = consultaActualizaCalConvenio;
                comandoActualizaCalConvenios.ExecuteNonQuery();


            }


        }

        private void BackgroundPromesaNotificacion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ncargando.Close();
            My.MyProject.Forms.CrearNotificacionDescuentoPromesa.idPromesa = idPromesa;
            My.MyProject.Forms.CrearNotificacionDescuentoPromesa.tipoCredito = "L";
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
                My.MyProject.Forms.CrearNotificacionDescuentoPromesa.tipoCredito = "L";
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
            consultaPromesa = "select id from promesadepago where idcredito = '" + idCredito + "' and estado = 'E' and notificado = 0 and tipocredito = '" + estadoCredito + "'";
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
            My.MyProject.Forms.CrearNotificacionDescuentoPromesa.tipoCredito = "L";
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
                My.MyProject.Forms.CrearNotificacionDescuentoPromesa.tipoCredito = "L";
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