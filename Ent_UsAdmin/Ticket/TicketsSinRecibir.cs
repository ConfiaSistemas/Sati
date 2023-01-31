using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{
    // Imports ConfiaAdmin.CustomControl

    public partial class TicketsSinRecibir
    {
        private DataTable dataCajas;
        private SqlDataAdapter adapterCajas;
        public bool autorizado;

        public TicketsSinRecibir()
        {
            InitializeComponent();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            dtdatos.Rows.Clear();
            try
            {
                Module1.iniciarconexionempresa();
                SqlCommand comando;

                SqlDataReader reader;
                string consulta;


                string cajaConsultar;

                // consulta = "select Ticket.id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id where Ticket.fecha >= convert(date,'" & fechainserciondesde & "',102) and Ticket.fecha <= convert(date,'" & fechainsercionhasta & "',102)  order by Ticket.fecha,Ticket.hora asc "

                cajaConsultar = CheckedCajas.Text;
                consulta = "select Ticket.id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja,ticket.estado from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id where ticket.caja in (" + cajaConsultar + ") and ticket.id not in (select idticket from DetalleCierreCajaGestores) order by Ticket.fecha,Ticket.hora asc ";

                // End Select


                comando = new SqlCommand();
                comando.Connection = Module1.conexionempresa;
                // comando.CommandTimeout = 120
                comando.CommandText = consulta;
                reader = comando.ExecuteReader();
                double recibido = 0d;
                double totalPago = 0d;
                while (reader.Read())
                {

                    string nombrecredito;

                    switch (reader["tipo"])
                    {
                        case "Convenio":
                        case "Transferencia Convenio":
                        case "Depósito Convenio":
                            {
                                SqlCommand comandonombre;
                                comandonombre = new SqlCommand();

                                string consultaNombre;
                                consultaNombre = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select credito.nombre from conveniossac inner join credito on credito.id = conveniossac.idcredito where conveniossac.id = '", reader["idcredito"]), "'"));
                                comandonombre.Connection = Module1.conexionempresa;
                                comandonombre.CommandText = consultaNombre;
                                nombrecredito = Conversions.ToString(comandonombre.ExecuteScalar());
                                break;
                            }
                        case "Legal":
                        case "Depósito Legal":
                        case "Promesa de pago legal":
                        case "Promesa Aplicada Legal":
                        case "Cancelación de Promesa Legal":
                            {
                                SqlCommand comandonombre;
                                comandonombre = new SqlCommand();

                                string consultaNombre;
                                consultaNombre = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select nombre from legales  where id = '", reader["idcredito"]), "'"));
                                comandonombre.Connection = Module1.conexionempresa;
                                comandonombre.CommandText = consultaNombre;
                                nombrecredito = Conversions.ToString(comandonombre.ExecuteScalar());
                                break;
                            }
                        case "Refrendo":
                        case "Comisión por avalúo":
                        case "Desempeño":
                            {
                                SqlCommand comandonombre;
                                comandonombre = new SqlCommand();

                                string consultaNombre;
                                consultaNombre = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select nombre from empeños  where id = '", reader["idcredito"]), "'"));
                                comandonombre.Connection = Module1.conexionempresa;
                                comandonombre.CommandText = consultaNombre;
                                nombrecredito = Conversions.ToString(comandonombre.ExecuteScalar());
                                break;
                            }
                        case "Reestructura":
                        case "Transferencia Reestructura":
                        case "Depósito Reestructura":
                            {
                                SqlCommand comandonombre;
                                comandonombre = new SqlCommand();

                                string consultaNombre;
                                consultaNombre = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select credito.nombre from reestructurassac inner join credito on credito.id = reestructurassac.idcredito where reestructurassac.id = '", reader["idcredito"]), "'"));
                                comandonombre.Connection = Module1.conexionempresa;
                                comandonombre.CommandText = consultaNombre;
                                nombrecredito = Conversions.ToString(comandonombre.ExecuteScalar());
                                break;
                            }
                        case "Liquidación Convenio 90%":
                            {
                                SqlCommand comandonombre;
                                comandonombre = new SqlCommand();

                                string consultaNombre;
                                consultaNombre = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select credito.nombre from conveniossac inner join credito on credito.id = conveniossac.idcredito where conveniossac.id = '", reader["idcredito"]), "'"));
                                comandonombre.Connection = Module1.conexionempresa;
                                comandonombre.CommandText = consultaNombre;
                                nombrecredito = Conversions.ToString(comandonombre.ExecuteScalar());
                                break;
                            }

                        default:
                            {
                                SqlCommand comandonombre;
                                comandonombre = new SqlCommand();

                                string consultaNombre;
                                consultaNombre = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select nombre from credito  where id = '", reader["idcredito"]), "'"));
                                comandonombre.Connection = Module1.conexionempresa;
                                comandonombre.CommandText = consultaNombre;
                                nombrecredito = Conversions.ToString(comandonombre.ExecuteScalar());
                                break;
                            }
                    }

                    recibido = Conversions.ToDouble(reader["recibido"]);
                    totalPago = Conversions.ToDouble(reader["total"]);
                    if (recibido > totalPago)
                    {
                        switch (reader["tipo"])
                        {
                            case "Convenio":
                                {
                                    dtdatos.Rows.Add(reader["id"], reader["idcredito"], nombrecredito, Strings.FormatCurrency(reader["Total"]), Strings.Format(reader["Fecha"], "yyyy-MM-dd"), reader["hora"], reader["tipo"], reader["Caja"], reader["Estado"]);
                                    break;
                                }
                            case "Legal":
                                {

                                    dtdatos.Rows.Add(reader["id"], reader["idcredito"], nombrecredito, Strings.FormatCurrency(reader["Total"]), Strings.Format(reader["Fecha"], "yyyy-MM-dd"), reader["hora"], reader["tipo"], reader["Caja"], reader["Estado"]);
                                    break;
                                }
                            case "Extra":
                                {
                                    dtdatos.Rows.Add(reader["id"], reader["idcredito"], reader["concepto"], Strings.FormatCurrency(reader["Total"]), Strings.Format(reader["Fecha"], "yyyy-MM-dd"), reader["hora"], reader["tipo"], reader["Caja"], reader["Estado"]);
                                    break;
                                }

                            default:
                                {
                                    dtdatos.Rows.Add(reader["id"], reader["idcredito"], nombrecredito, Strings.FormatCurrency(reader["Total"]), Strings.Format(reader["Fecha"], "yyyy-MM-dd"), reader["hora"], reader["tipo"], reader["Caja"], reader["Estado"]);
                                    break;
                                }
                        }
                    }



                    else
                    {
                        switch (reader["tipo"])
                        {

                            case "Convenio":
                                {
                                    dtdatos.Rows.Add(reader["id"], reader["idcredito"], nombrecredito, Strings.FormatCurrency(reader["recibido"]), Strings.Format(reader["Fecha"], "yyyy-MM-dd"), reader["hora"], reader["tipo"], reader["Caja"], reader["Estado"]);
                                    break;
                                }
                            case "Legal":
                                {

                                    dtdatos.Rows.Add(reader["id"], reader["idcredito"], nombrecredito, Strings.FormatCurrency(reader["recibido"]), Strings.Format(reader["Fecha"], "yyyy-MM-dd"), reader["hora"], reader["tipo"], reader["Caja"], reader["Estado"]);
                                    break;
                                }
                            case "Extra":
                                {
                                    dtdatos.Rows.Add(reader["id"], reader["idcredito"], reader["concepto"], Strings.FormatCurrency(reader["recibido"]), Strings.Format(reader["Fecha"], "yyyy-MM-dd"), reader["hora"], reader["tipo"], reader["Caja"], reader["Estado"]);
                                    break;
                                }

                            default:
                                {
                                    dtdatos.Rows.Add(reader["id"], reader["idcredito"], nombrecredito, Strings.FormatCurrency(reader["recibido"]), Strings.Format(reader["Fecha"], "yyyy-MM-dd"), reader["hora"], reader["tipo"], reader["Caja"], reader["Estado"]);
                                    break;
                                }
                        }


                    }



                }

                double total;
                total = 0d;
                bool afecta;
                foreach (DataGridViewRow row in dtdatos.Rows)
                {
                    afecta = Module1.AfectaCaja(Conversions.ToString(row.Cells[6].Value));
                    if (Conversions.ToBoolean(Operators.AndObject(afecta, Operators.ConditionalCompareObjectNotEqual(row.Cells[8].Value, "C", false))))
                    {
                        total = Conversions.ToDouble(Operators.AddObject(total, row.Cells[3].Value));
                    }
                    else
                    {

                    }


                }
                lbltotal.Text = Strings.FormatCurrency(total);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void MonoFlat_HeaderLabel3_Click(object sender, EventArgs e)
        {

        }

        private void BackgroundCajas_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consultaCajas;
            consultaCajas = "Select Nocaja from cajasSucursal";
            adapterCajas = new SqlDataAdapter(consultaCajas, Module1.conexionempresa);
            dataCajas = new DataTable();
            adapterCajas.Fill(dataCajas);

        }

        private void BackgroundCajas_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ComboFiltro.Items.Clear();
            ComboFiltro.Items.Add("Todas");
            foreach (DataRow row in dataCajas.Rows)
            {
                ComboFiltro.Items.Add(row["Nocaja"].ToString());
                CheckedCajas.Items.Add(row["Nocaja"].ToString());
                // PopupComboBox1.Items.Add(row("Nocaja").ToString)
            }
            ComboFiltro.SelectedIndex = 0;
            for (int i = 0, loopTo = CheckedCajas.Items.Count - 1; i <= loopTo; i++)

                CheckedCajas.CheckBoxItems[i].CheckState = CheckState.Checked;
            My.MyProject.Forms.Cargando.Close();
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            dtdatos.Rows.Clear();
            dtdatos.ScrollBars = ScrollBars.None;
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Consultando";
            My.MyProject.Forms.Cargando.TopMost = true;
            BackgroundWorker1.RunWorkerAsync();

        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtdatos.ScrollBars = ScrollBars.Both;
            My.MyProject.Forms.Cargando.Close();

            My.MyProject.Forms.Cargando.TopMost = false;
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            dtdatos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            CheckForIllegalCrossThreadCalls = false;
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Consultando cajas";
            My.MyProject.Forms.Cargando.TopMost = true;
            BackgroundCajas.RunWorkerAsync();

        }

        private void BunifuThinButton23_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.TicketsPfecha.Show();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Exportando a Excel";
            My.MyProject.Forms.Cargando.TopMost = true;
            BackgroundExcel.RunWorkerAsync();
        }

        private void BackgroundExcel_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.nuevolibro();
            Module1.GridAExcel(dtdatos);
        }

        private void BackgroundExcel_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();
            Module1.cerrarlibro();

        }

        private void dateDesde_onValueChanged(object sender, EventArgs e)
        {

        }





        private void dtdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void BackgroundCancelar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Consultando";
            BackgroundWorker1.RunWorkerAsync();

        }



        private void Button1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Reportes.Panel1.Visible = false;
            My.MyProject.Forms.Reportes.RadPanorama1.Visible = true;
        }
    }
}