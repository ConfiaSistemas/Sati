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

    public partial class Tickets
    {
        private DataTable dataCajas;
        private SqlDataAdapter adapterCajas;
        public bool autorizado;

        public Tickets()
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
                string fechainserciondesde;
                fechainserciondesde = dateDesde.Value.ToShortDateString();

                DateTime fechasqldesde;
                fechasqldesde = Conversions.ToDate(fechainserciondesde);
                fechainserciondesde = Strings.Format(fechasqldesde, "yyyy-MM-dd");


                string fechainsercionhasta;
                fechainsercionhasta = dateHasta.Value.ToShortDateString();

                DateTime fechasqlhasta;
                fechasqlhasta = Conversions.ToDate(fechainsercionhasta);
                fechainsercionhasta = Strings.Format(fechasqlhasta, "yyyy-MM-dd");

                string cajaConsultar;

                // consulta = "select Ticket.id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id where Ticket.fecha >= convert(date,'" & fechainserciondesde & "',102) and Ticket.fecha <= convert(date,'" & fechainsercionhasta & "',102)  order by Ticket.fecha,Ticket.hora asc "

                cajaConsultar = CheckedCajas.Text;
                consulta = "select Ticket.id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja,ticket.estado from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id where Ticket.fecha >= convert(date,'" + fechainserciondesde + "',102) and Ticket.fecha <= convert(date,'" + fechainsercionhasta + "',102) and ticket.caja in (" + cajaConsultar + ")  order by Ticket.fecha,Ticket.hora asc ";

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


                        case "Terminal":
                            {
                                SqlCommand comandonombre;
                                comandonombre = new SqlCommand();

                                string consultaNombre;
                                consultaNombre = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select credito.nombre from conveniosterminalessac inner join credito on credito.id = conveniosterminalessac.idcredito where conveniosterminalessac.id = '", reader["idcredito"]), "'"));
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
            dateDesde.Value = DateTime.Now;
            dateHasta.Value = DateTime.Now;
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

        private void CancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in Module1.dataPermisos.Rows)
            {
                if (Conversions.ToBoolean(row["SacCancelarTicket"]))
                {
                    My.MyProject.Forms.Autorizacion.tipoAutorizacion = "SacCancelarTicket";
                    My.MyProject.Forms.Autorizacion.ShowDialog();
                    if (autorizado)
                    {
                        My.MyProject.Forms.Cargando.Show();
                        My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cancelando Ticket";
                        BackgroundCancelar.RunWorkerAsync();
                    }
                    else
                    {
                        MessageBox.Show("No fue autorizado");
                    }
                    break;
                }
                else if (MessageBox.Show("¿No cuenta con los permisos, desea notificar a un usuario?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    My.MyProject.Forms.CrearNotificacionCancelarTicket.idTicket = Conversions.ToString(dtdatos.Rows[dtdatos.CurrentRow.Index].Cells[0].Value);
                    My.MyProject.Forms.CrearNotificacionCancelarTicket.Show();

                }
            }




        }

        private void BackgroundCancelar_DoWork(object sender, DoWorkEventArgs e)
        {

            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dtdatos.Rows[dtdatos.CurrentRow.Index].Cells[6].Value, "Refrendo", false)))
            {
                SqlCommand comandoFechaUpagoTicket;
                DateTime fechaUpagoTicket;
                string consultaUfechaTicket;
                consultaUfechaTicket = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select fecha from ticket where id = '", dtdatos.Rows[dtdatos.CurrentRow.Index].Cells[0].Value), "'"));
                comandoFechaUpagoTicket = new SqlCommand();
                comandoFechaUpagoTicket.CommandText = consultaUfechaTicket;
                comandoFechaUpagoTicket.Connection = Module1.conexionempresa;
                fechaUpagoTicket = Conversions.ToDate(comandoFechaUpagoTicket.ExecuteScalar());

                string fechaPosterior;
                SqlCommand comandoFechaPosterior;
                string consultaFechaPosterior;
                consultaFechaPosterior = "if exists (select top 1 fecha from ticket where fecha > '" + fechaUpagoTicket.Date.ToString("yyyy-MM-dd") + @"' and estado = 'A' and tipodoc = (select id from tipodoc where nombre = 'Refrendo') order by fecha desc)
                                           begin
                                           select 'Sí hay' as ss
                                           end
                                           else 
                                           begin
                                           select 'No hay' as ss
                                           end";

                comandoFechaPosterior = new SqlCommand();
                comandoFechaPosterior.Connection = Module1.conexionempresa;
                comandoFechaPosterior.CommandText = consultaFechaPosterior;
                fechaPosterior = Conversions.ToString(comandoFechaPosterior.ExecuteScalar());

                if (fechaPosterior == "No hay")
                {
                    DateTime fechaUpago;
                    SqlCommand comandoFechaUpago;
                    string consultaFechaUpago;
                    consultaFechaUpago = "if exists (select top 1 fecha from ticket where fecha < '" + fechaUpagoTicket.Date.ToString("yyyy-MM-dd") + @"' and estado = 'A' and tipodoc = (select id from tipodoc where nombre = 'Refrendo') order by fecha desc)
                                           begin
                                           select top 1 fecha from ticket where fecha < '" + fechaUpagoTicket.Date.ToString("yyyy-MM-dd") + @"' and estado = 'A' and tipodoc = (select id from tipodoc where nombre = 'Refrendo') order by fecha desc
                                           end
                                           else 
                                           begin
                                           select '1900-01-01' as fecha
                                           end";
                    comandoFechaUpago = new SqlCommand();
                    comandoFechaUpago.Connection = Module1.conexionempresa;
                    comandoFechaUpago.CommandText = consultaFechaUpago;
                    fechaUpago = Conversions.ToDate(comandoFechaUpago.ExecuteScalar());

                    SqlCommand comandoConsultaTicketDetalle;
                    string consultaTicketDetalle;
                    SqlDataReader readerTicketDetalle;
                    consultaTicketDetalle = "CancelarTicket";
                    comandoConsultaTicketDetalle = new SqlCommand();
                    comandoConsultaTicketDetalle.Connection = Module1.conexionempresa;
                    comandoConsultaTicketDetalle.CommandText = consultaTicketDetalle;
                    comandoConsultaTicketDetalle.CommandType = CommandType.StoredProcedure;
                    comandoConsultaTicketDetalle.Parameters.AddWithValue("idTicket", dtdatos.Rows[dtdatos.CurrentRow.Index].Cells[0].Value);
                    comandoConsultaTicketDetalle.Parameters.AddWithValue("Tipo", dtdatos.Rows[dtdatos.CurrentRow.Index].Cells[6].Value);
                    comandoConsultaTicketDetalle.Parameters.AddWithValue("FechaUPago", fechaUpago.Date.ToString("yyyy-MM-dd"));
                    comandoConsultaTicketDetalle.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("No se puede cancelar éste ticket, existen tickets activos con fechas posteriores");
                }
            }



            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dtdatos.Rows[dtdatos.CurrentRow.Index].Cells[6].Value, "Desempeño", false)))
            {
                SqlCommand comandoFechaUpagoTicket;
                DateTime fechaUpagoTicket;
                string consultaUfechaTicket;
                consultaUfechaTicket = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select fecha from ticket where id = '", dtdatos.Rows[dtdatos.CurrentRow.Index].Cells[0].Value), "'"));
                comandoFechaUpagoTicket = new SqlCommand();
                comandoFechaUpagoTicket.CommandText = consultaUfechaTicket;
                comandoFechaUpagoTicket.Connection = Module1.conexionempresa;
                fechaUpagoTicket = Conversions.ToDate(comandoFechaUpagoTicket.ExecuteScalar());




                DateTime fechaUpago;
                SqlCommand comandoFechaUpago;
                string consultaFechaUpago;
                consultaFechaUpago = "if exists (select top 1 fecha from ticket where fecha < '" + fechaUpagoTicket.Date.ToString("yyyy-MM-dd") + @"' and estado = 'A' and tipodoc = (select id from tipodoc where nombre = 'Refrendo') order by fecha desc)
                                           begin
                                           select top 1 fecha from ticket where fecha < '" + fechaUpagoTicket.Date.ToString("yyyy-MM-dd") + @"' and estado = 'A' and tipodoc = (select id from tipodoc where nombre = 'Refrendo') order by fecha desc
                                           end
                                           else 
                                           begin
                                           select '1900-01-01' as fecha
                                           end";
                comandoFechaUpago = new SqlCommand();
                comandoFechaUpago.Connection = Module1.conexionempresa;
                comandoFechaUpago.CommandText = consultaFechaUpago;
                fechaUpago = Conversions.ToDate(comandoFechaUpago.ExecuteScalar());

                SqlCommand comandoConsultaTicketDetalle;
                string consultaTicketDetalle;
                SqlDataReader readerTicketDetalle;
                consultaTicketDetalle = "CancelarTicket";
                comandoConsultaTicketDetalle = new SqlCommand();
                comandoConsultaTicketDetalle.Connection = Module1.conexionempresa;
                comandoConsultaTicketDetalle.CommandText = consultaTicketDetalle;
                comandoConsultaTicketDetalle.CommandType = CommandType.StoredProcedure;
                comandoConsultaTicketDetalle.Parameters.AddWithValue("idTicket", dtdatos.Rows[dtdatos.CurrentRow.Index].Cells[0].Value);
                comandoConsultaTicketDetalle.Parameters.AddWithValue("Tipo", dtdatos.Rows[dtdatos.CurrentRow.Index].Cells[6].Value);
                comandoConsultaTicketDetalle.Parameters.AddWithValue("FechaUPago", fechaUpago.Date.ToString("yyyy-MM-dd"));
                comandoConsultaTicketDetalle.ExecuteNonQuery();
            }


            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dtdatos.Rows[dtdatos.CurrentRow.Index].Cells[6].Value, "Comisión por avalúo", false)))
            {
                SqlCommand comandoFechaUpagoTicket;
                DateTime fechaUpagoTicket;
                string consultaUfechaTicket;
                consultaUfechaTicket = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select fecha from ticket where id = '", dtdatos.Rows[dtdatos.CurrentRow.Index].Cells[0].Value), "'"));
                comandoFechaUpagoTicket = new SqlCommand();
                comandoFechaUpagoTicket.CommandText = consultaUfechaTicket;
                comandoFechaUpagoTicket.Connection = Module1.conexionempresa;
                fechaUpagoTicket = Conversions.ToDate(comandoFechaUpagoTicket.ExecuteScalar());

                string fechaPosterior;
                SqlCommand comandoFechaPosterior;
                string consultaFechaPosterior;
                consultaFechaPosterior = "if exists (select top 1 fecha from ticket where fecha >= '" + fechaUpagoTicket.Date.ToString("yyyy-MM-dd") + @"' and estado = 'A' and tipodoc = (select id from tipodoc where nombre = 'Refrendo') order by fecha desc)
                                           begin
                                           select 'Sí hay' as ss
                                           end
                                           else 
                                           begin
                                           select 'No hay' as ss
                                           end";

                comandoFechaPosterior = new SqlCommand();
                comandoFechaPosterior.Connection = Module1.conexionempresa;
                comandoFechaPosterior.CommandText = consultaFechaPosterior;
                fechaPosterior = Conversions.ToString(comandoFechaPosterior.ExecuteScalar());

                if (fechaPosterior == "No hay")
                {
                    DateTime fechaUpago;
                    SqlCommand comandoFechaUpago;
                    string consultaFechaUpago;
                    consultaFechaUpago = "if exists (select top 1 fecha from ticket where fecha < '" + fechaUpagoTicket.Date.ToString("yyyy-MM-dd") + @"' and estado = 'A' and tipodoc = (select id from tipodoc where nombre = 'Refrendo') order by fecha desc)
                                           begin
                                           select top 1 fecha from ticket where fecha < '" + fechaUpagoTicket.Date.ToString("yyyy-MM-dd") + @"' and estado = 'A' and tipodoc = (select id from tipodoc where nombre = 'Refrendo') order by fecha desc
                                           end
                                           else 
                                           begin
                                           select '1900-01-01' as fecha
                                           end";
                    comandoFechaUpago = new SqlCommand();
                    comandoFechaUpago.Connection = Module1.conexionempresa;
                    comandoFechaUpago.CommandText = consultaFechaUpago;
                    fechaUpago = Conversions.ToDate(comandoFechaUpago.ExecuteScalar());

                    SqlCommand comandoConsultaTicketDetalle;
                    string consultaTicketDetalle;
                    SqlDataReader readerTicketDetalle;
                    consultaTicketDetalle = "CancelarTicket";
                    comandoConsultaTicketDetalle = new SqlCommand();
                    comandoConsultaTicketDetalle.Connection = Module1.conexionempresa;
                    comandoConsultaTicketDetalle.CommandText = consultaTicketDetalle;
                    comandoConsultaTicketDetalle.CommandType = CommandType.StoredProcedure;
                    comandoConsultaTicketDetalle.Parameters.AddWithValue("idTicket", dtdatos.Rows[dtdatos.CurrentRow.Index].Cells[0].Value);
                    comandoConsultaTicketDetalle.Parameters.AddWithValue("Tipo", dtdatos.Rows[dtdatos.CurrentRow.Index].Cells[6].Value);
                    comandoConsultaTicketDetalle.Parameters.AddWithValue("FechaUPago", fechaUpago.Date.ToString("yyyy-MM-dd"));
                    comandoConsultaTicketDetalle.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("No se puede cancelar éste ticket, existen tickets activos con fechas posteriores");
                }
            }
            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dtdatos.Rows[dtdatos.CurrentRow.Index].Cells[6].Value, "Promesa de pago", false)))
            {
                SqlCommand comandoFechaUpagoTicket;
                DateTime fechaUpagoTicket;
                string consultaUfechaTicket;
                consultaUfechaTicket = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select fecha from ticket where id = '", dtdatos.Rows[dtdatos.CurrentRow.Index].Cells[0].Value), "'"));
                comandoFechaUpagoTicket = new SqlCommand();
                comandoFechaUpagoTicket.CommandText = consultaUfechaTicket;
                comandoFechaUpagoTicket.Connection = Module1.conexionempresa;
                fechaUpagoTicket = Conversions.ToDate(comandoFechaUpagoTicket.ExecuteScalar());

                string fechaPosterior;
                SqlCommand comandoFechaPosterior;
                string consultaFechaPosterior;
                consultaFechaPosterior = "if exists (select top 1 fecha from ticket where fecha > '" + fechaUpagoTicket.Date.ToString("yyyy-MM-dd") + @"' and estado = 'A' and tipodoc = (select id from tipodoc where nombre = 'Promesa de pago') order by fecha desc)
                                           begin
                                           select 'Sí hay' as ss
                                           end
                                           else 
                                           begin
                                           select 'No hay' as ss
                                           end";

                comandoFechaPosterior = new SqlCommand();
                comandoFechaPosterior.Connection = Module1.conexionempresa;
                comandoFechaPosterior.CommandText = consultaFechaPosterior;
                fechaPosterior = Conversions.ToString(comandoFechaPosterior.ExecuteScalar());
                if (fechaPosterior == "No hay")
                {
                    DateTime fechaUpago;
                    SqlCommand comandoFechaUpago;
                    string consultaFechaUpago;
                    consultaFechaUpago = "if exists (select top 1 fecha from ticket where fecha < '" + fechaUpagoTicket.Date.ToString("yyyy-MM-dd") + @"' and estado = 'A' and tipodoc = (select id from tipodoc where nombre = 'Promesa de pago') order by fecha desc)
                                           begin
                                           select top 1 fecha from ticket where fecha < '" + fechaUpagoTicket.Date.ToString("yyyy-MM-dd") + @"' and estado = 'A' and tipodoc = (select id from tipodoc where nombre = 'Promesa de pago') order by fecha desc
                                           end
                                           else 
                                           begin
                                           select '1900-01-01' as fecha
                                           end";
                    comandoFechaUpago = new SqlCommand();
                    comandoFechaUpago.Connection = Module1.conexionempresa;
                    comandoFechaUpago.CommandText = consultaFechaUpago;
                    fechaUpago = Conversions.ToDate(comandoFechaUpago.ExecuteScalar());

                    SqlCommand comandoConsultaTicketDetalle;
                    string consultaTicketDetalle;
                    SqlDataReader readerTicketDetalle;
                    consultaTicketDetalle = "CancelarTicket";
                    comandoConsultaTicketDetalle = new SqlCommand();
                    comandoConsultaTicketDetalle.Connection = Module1.conexionempresa;
                    comandoConsultaTicketDetalle.CommandText = consultaTicketDetalle;
                    comandoConsultaTicketDetalle.CommandType = CommandType.StoredProcedure;
                    comandoConsultaTicketDetalle.Parameters.AddWithValue("idTicket", dtdatos.Rows[dtdatos.CurrentRow.Index].Cells[0].Value);
                    comandoConsultaTicketDetalle.Parameters.AddWithValue("Tipo", dtdatos.Rows[dtdatos.CurrentRow.Index].Cells[6].Value);
                    comandoConsultaTicketDetalle.Parameters.AddWithValue("FechaUPago", fechaUpago.Date.ToString("yyyy-MM-dd"));
                    comandoConsultaTicketDetalle.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("No se puede cancelar éste ticket, existen tickets activos con fechas posteriores");
                }
            }

            else
            {



                SqlCommand comandoConsultaTicketDetalle;
                string consultaTicketDetalle;
                SqlDataReader readerTicketDetalle;
                consultaTicketDetalle = "CancelarTicket";
                comandoConsultaTicketDetalle = new SqlCommand();
                comandoConsultaTicketDetalle.Connection = Module1.conexionempresa;
                comandoConsultaTicketDetalle.CommandText = consultaTicketDetalle;
                comandoConsultaTicketDetalle.CommandType = CommandType.StoredProcedure;
                comandoConsultaTicketDetalle.Parameters.AddWithValue("idTicket", dtdatos.Rows[dtdatos.CurrentRow.Index].Cells[0].Value);
                comandoConsultaTicketDetalle.Parameters.AddWithValue("Tipo", dtdatos.Rows[dtdatos.CurrentRow.Index].Cells[6].Value);
                comandoConsultaTicketDetalle.Parameters.AddWithValue("FechaUPago", "");
                comandoConsultaTicketDetalle.ExecuteNonQuery();

            }



        }

        private void dtdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtdatos_SelectionChanged(object sender, EventArgs e)
        {
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dtdatos.Rows[dtdatos.CurrentRow.Index].Cells[8].Value, "A", false)))
            {
                dtdatos.ContextMenuStrip = ContextMenuCancelar;
            }
            else
            {
                dtdatos.ContextMenuStrip = null;

            }
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

        private void ContextMenuCancelar_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}