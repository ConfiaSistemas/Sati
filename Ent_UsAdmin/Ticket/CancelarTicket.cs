using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace ConfiaAdmin
{

    public partial class CancelarTicket
    {
        public bool Autorizado;
        private string cnsEmpresaMysql;
        public string idTicket;
        public string idNotificacion;
        private string localRemoto;
        private string ipLocalTicket;
        private string nombreRemoto;
        private string ipRemotoTicket;
        private string bdTicket;
        private string estadoNotificacion;
        private string tipoDoc;
        private string estado;
        private Cargando nCargando;
        private Cargando nCargando1;
        private bool conectado;
        private bool aplicado;

        public CancelarTicket()
        {
            InitializeComponent();
        }
        private void CancelarTicket_Load(object sender, EventArgs e)
        {
            txtComentario.BackColor = BackColor;
            nCargando = new Cargando();
            nCargando.Show();
            nCargando.MonoFlat_Label1.Text = "Consultando estado de notificación";
            nCargando.TopMost = true;
            dtDetalle.ScrollBars = ScrollBars.None;
            BackgroundVerificaNotificacion.RunWorkerAsync();

        }


        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            MySqlConnection conexionLogin;
            conexionLogin = new MySqlConnection();
            conexionLogin.ConnectionString = "server=www.prestamosconfia.com;user id=ajas;pwd=123456;port=3306;database=USRS";
            conexionLogin.Open();

            MySqlCommand comandoComentarioMysql;
            string consultaComentarioMysql;
            MySqlDataReader readerComentarioMysql;
            consultaComentarioMysql = "select Comentario,Empresa from Notificaciones where id = '" + idNotificacion + "'";
            comandoComentarioMysql = new MySqlCommand();
            comandoComentarioMysql.Connection = conexionLogin;
            comandoComentarioMysql.CommandText = consultaComentarioMysql;
            readerComentarioMysql = comandoComentarioMysql.ExecuteReader();
            if (readerComentarioMysql.HasRows)
            {
                while (readerComentarioMysql.Read())
                {
                    txtComentario.Text = Conversions.ToString(readerComentarioMysql["comentario"]);
                    nombreRemoto = Conversions.ToString(readerComentarioMysql["Empresa"]);
                }
            }
            readerComentarioMysql.Close();

            MySqlCommand comandoEmpresaMysql;
            string consultaEmpresaMysql;
            MySqlDataReader readerEmpresaMysql;
            consultaEmpresaMysql = "select IP,BD,IPREMOTA from Empresas where Nombre = '" + nombreRemoto + "'";
            comandoEmpresaMysql = new MySqlCommand();
            comandoEmpresaMysql.Connection = conexionLogin;
            comandoEmpresaMysql.CommandText = consultaEmpresaMysql;
            readerEmpresaMysql = comandoEmpresaMysql.ExecuteReader();
            if (readerEmpresaMysql.HasRows)
            {
                while (readerEmpresaMysql.Read())
                {
                    ipLocalTicket = Conversions.ToString(readerEmpresaMysql["IP"]);
                    bdTicket = Conversions.ToString(readerEmpresaMysql["BD"]);
                    ipRemotoTicket = Conversions.ToString(readerEmpresaMysql["IPREMOTA"]);

                }
            }

            readerEmpresaMysql.Close();




            conexionLogin.Close();

            if (Module1.ProbarConexionEmpresa(ipLocalTicket, bdTicket))
            {
                conectado = true;
                cnsEmpresaMysql = Module1.iniciarconexionRMysql(ipLocalTicket, bdTicket);
            }
            else
            {
                conectado = Module1.ProbarConexionEmpresa(ipRemotoTicket, bdTicket);
                if (conectado == true)
                {
                    cnsEmpresaMysql = Module1.iniciarconexionRMysql(ipRemotoTicket, bdTicket);
                }
                else
                {

                }

            }


            if (conectado)
            {
            }
            else
            {

            }

            SqlConnection conex;
            conex = new SqlConnection(cnsEmpresaMysql);
            conex.Open();

            SqlCommand comandoTicket;
            string consultaTicket;
            SqlDataReader readerTicket;
            consultaTicket = @"select *,case tick.nombredoc when 'Pago' then(select nombre from Credito where id = tick.idCredito)
when 'Apertura' then
(select nombre from Credito where id = tick.idCredito)
when 'Extra' then
tick.Concepto
when 'Convenio' then
(select credito.nombre from Credito inner join ConveniosSac on Credito.id = ConveniosSac.idCredito where ConveniosSac.id = tick.idCredito)
when 'Legal' then
(select nombre from Legales where id = tick.idCredito)
when 'Refrendo' then
(select nombre from Empeños where id = Tick.idCredito)
when 'Comisión por avalúo' then
(select nombre from Empeños where id = Tick.idCredito)
when 'Desempeño' then
(select nombre from Empeños where id = Tick.idCredito)
when 'Cancelación de Convenio' then 
(select nombre from Credito where id = tick.idCredito)
when 'Reestructura' then
(select Credito.Nombre from Credito inner join ReestructurasSac on Credito.id = ReestructurasSac.idCredito where ReestructurasSac.id = tick.idCredito)

 end as NombreCliente from 
(select Ticket.*,TipoDoc.Nombre as nombredoc from ticket inner join TipoDoc on Ticket.TipoDoc = TipoDoc.id where ticket.id = '" + idTicket + "')tick";
            comandoTicket = new SqlCommand();
            comandoTicket.Connection = conex;
            comandoTicket.CommandText = consultaTicket;
            readerTicket = comandoTicket.ExecuteReader();
            while (readerTicket.Read())
            {
                lblNombre.Text = Conversions.ToString(readerTicket["NombreCliente"]);
                lblMonto.Text = Strings.FormatCurrency(readerTicket["Total"], 2);
                lblNoTicket.Text = idTicket;

                tipoDoc = Conversions.ToString(readerTicket["NombreDoc"]);
            }
            readerTicket.Close();




            SqlCommand comandoDetalle;
            string consultaDetalle;
            SqlDataAdapter adapterDetalle;
            DataTable dataDetalle;

            switch (tipoDoc ?? "")
            {
                case "Pago":
                    {
                        consultaDetalle = "select concat(ticketdetalle.concepto,' de ','Pago ', calendarionormal.NPago) as pago,pagonormal,intereses,ticketdetalle.monto,ticketdetalle.Estado from ticketdetalle inner join calendarionormal on ticketdetalle.idpago = calendarionormal.idpago where  idTicket = '" + idTicket + "'";

                        adapterDetalle = new SqlDataAdapter(consultaDetalle, conex);
                        dataDetalle = new DataTable();
                        adapterDetalle.Fill(dataDetalle);

                        dtDetalle.DataSource = dataDetalle;

                        foreach (DataRow drFila in dataDetalle.Rows)
                        {
                            estado = drFila["Estado"].ToString();
                            break;

                        }
                        if (estado == "C")
                        {

                            MonoFlat_HeaderLabel10.Text = "CANCELADO";
                            MonoFlat_HeaderLabel10.ForeColor = Color.Red;
                        }
                        else
                        {
                            MonoFlat_HeaderLabel10.Text = "ACTIVO";
                            MonoFlat_HeaderLabel10.ForeColor = Color.Green;
                        }

                        break;
                    }

                case "Convenio":
                    {
                        consultaDetalle = "select concat(ticketdetalle.concepto,' de ','Pago ', calendarioconveniossac.NPago) as pago,pagonormal,intereses,ticketdetalle.monto,ticketdetalle.Estado  from ticketdetalle inner join calendarioconveniossac on ticketdetalle.idpago = calendarioconveniossac.idpago where  idTicket = '" + idTicket + "'";

                        adapterDetalle = new SqlDataAdapter(consultaDetalle, conex);
                        dataDetalle = new DataTable();
                        adapterDetalle.Fill(dataDetalle);

                        dtDetalle.DataSource = dataDetalle;
                        foreach (DataRow drFila in dataDetalle.Rows)
                        {
                            estado = drFila["Estado"].ToString();
                            break;

                        }
                        if (estado == "C")
                        {

                            MonoFlat_HeaderLabel10.Text = "CANCELADO";
                            MonoFlat_HeaderLabel10.ForeColor = Color.Red;
                        }
                        else
                        {
                            MonoFlat_HeaderLabel10.Text = "ACTIVO";
                            MonoFlat_HeaderLabel10.ForeColor = Color.Green;
                        }

                        break;
                    }
                case "Legal":
                    {
                        consultaDetalle = "select concat(ticketdetalle.concepto,' de ','Pago ', calendariolegales.NPago) as pago,pagonormal,intereses,ticketdetalle.monto,ticketdetalle.Estado  from ticketdetalle inner join calendariolegales on ticketdetalle.idpago = calendariolegales.idpago where  idTicket = '" + idTicket + "'";

                        adapterDetalle = new SqlDataAdapter(consultaDetalle, conex);
                        dataDetalle = new DataTable();
                        adapterDetalle.Fill(dataDetalle);

                        dtDetalle.DataSource = dataDetalle;
                        foreach (DataRow drFila in dataDetalle.Rows)
                        {
                            estado = drFila["Estado"].ToString();
                            break;

                        }
                        if (estado == "C")
                        {

                            MonoFlat_HeaderLabel10.Text = "CANCELADO";
                            MonoFlat_HeaderLabel10.ForeColor = Color.Red;
                        }
                        else
                        {
                            MonoFlat_HeaderLabel10.Text = "ACTIVO";
                            MonoFlat_HeaderLabel10.ForeColor = Color.Green;
                        }

                        break;
                    }
                // TreeListView1.Nodes.Add(liItem)
                case "Apertura":
                    {
                        break;
                    }

                // adapterDetalle = New SqlDataAdapter(consultaDetalle, conex)
                // dataDetalle = New DataTable
                // adapterDetalle.Fill(dataDetalle)

                // dtDetalle.DataSource = dataDetalle

                // TreeListView1.Nodes.Add(liItem)
                case "Renovación Insoluto":
                    {
                        consultaDetalle = "select concat(ticketdetalle.concepto,' de ','Pago ', calendarionormal.NPago) as pago,pagonormal,intereses,ticketdetalle.monto,ticketdetalle.Estado  from ticketdetalle inner join calendarionormal on ticketdetalle.idpago = calendarionormal.idpago where  idTicket = '" + idTicket + "'";

                        adapterDetalle = new SqlDataAdapter(consultaDetalle, conex);
                        dataDetalle = new DataTable();
                        adapterDetalle.Fill(dataDetalle);

                        dtDetalle.DataSource = dataDetalle;
                        foreach (DataRow drFila in dataDetalle.Rows)
                        {
                            estado = drFila["Estado"].ToString();
                            break;

                        }
                        if (estado == "C")
                        {

                            MonoFlat_HeaderLabel10.Text = "CANCELADO";
                            MonoFlat_HeaderLabel10.ForeColor = Color.Red;
                        }
                        else
                        {
                            MonoFlat_HeaderLabel10.Text = "ACTIVO";
                            MonoFlat_HeaderLabel10.ForeColor = Color.Green;
                        }

                        break;
                    }

                case "Liquidación Insoluto":
                    {
                        consultaDetalle = "select concat(ticketdetalle.concepto,' de ','Pago ', calendarionormal.NPago) as pago,pagonormal,intereses,ticketdetalle.monto,ticketdetalle.Estado  from ticketdetalle inner join calendarionormal on ticketdetalle.idpago = calendarionormal.idpago where  idTicket = '" + idTicket + "'";

                        adapterDetalle = new SqlDataAdapter(consultaDetalle, conex);
                        dataDetalle = new DataTable();
                        adapterDetalle.Fill(dataDetalle);

                        dtDetalle.DataSource = dataDetalle;
                        foreach (DataRow drFila in dataDetalle.Rows)
                        {
                            estado = drFila["Estado"].ToString();
                            break;

                        }
                        if (estado == "C")
                        {

                            MonoFlat_HeaderLabel10.Text = "CANCELADO";
                            MonoFlat_HeaderLabel10.ForeColor = Color.Red;
                        }
                        else
                        {
                            MonoFlat_HeaderLabel10.Text = "ACTIVO";
                            MonoFlat_HeaderLabel10.ForeColor = Color.Green;
                        }

                        break;
                    }
                case "Cancelación de Convenio":
                    {
                        consultaDetalle = "select concat(ticketdetalle.concepto,' de ','Pago ', calendarionormal.NPago) as pago,pagonormal,intereses,ticketdetalle.monto,ticketdetalle.Estado  from ticketdetalle inner join calendarionormal on ticketdetalle.idpago = calendarionormal.idpago where  idTicket = '" + idTicket + "'";

                        adapterDetalle = new SqlDataAdapter(consultaDetalle, conex);
                        dataDetalle = new DataTable();
                        adapterDetalle.Fill(dataDetalle);

                        dtDetalle.DataSource = dataDetalle;
                        foreach (DataRow drFila in dataDetalle.Rows)
                        {
                            estado = drFila["Estado"].ToString();
                            break;

                        }
                        if (estado == "C")
                        {

                            MonoFlat_HeaderLabel10.Text = "CANCELADO";
                            MonoFlat_HeaderLabel10.ForeColor = Color.Red;
                        }
                        else
                        {
                            MonoFlat_HeaderLabel10.Text = "ACTIVO";
                            MonoFlat_HeaderLabel10.ForeColor = Color.Green;
                        }

                        break;
                    }

                case "Reestructura":
                    {
                        consultaDetalle = "select concat(ticketdetalle.concepto,' de ','Pago ', calendarioreestructurassac.NPago) as pago,pagonormal,intereses,ticketdetalle.monto,ticketdetalle.Estado  from ticketdetalle inner join calendarioreestructurassac on ticketdetalle.idpago = calendarioreestructurassac.idpago where  idTicket = '" + idTicket + "'";

                        adapterDetalle = new SqlDataAdapter(consultaDetalle, conex);
                        dataDetalle = new DataTable();
                        adapterDetalle.Fill(dataDetalle);

                        dtDetalle.DataSource = dataDetalle;
                        foreach (DataRow drFila in dataDetalle.Rows)
                        {
                            estado = drFila["Estado"].ToString();
                            break;

                        }
                        if (estado == "C")
                        {

                            MonoFlat_HeaderLabel10.Text = "CANCELADO";
                            MonoFlat_HeaderLabel10.ForeColor = Color.Red;
                        }
                        else
                        {
                            MonoFlat_HeaderLabel10.Text = "ACTIVO";
                            MonoFlat_HeaderLabel10.ForeColor = Color.Green;
                        }

                        break;
                    }

                case "Liquidación Promoción 90%":
                    {
                        consultaDetalle = "select concat(ticketdetalle.concepto,' de ','Pago ', calendarionormal.NPago) as pago,pagonormal,intereses,ticketdetalle.monto,ticketdetalle.Estado  from ticketdetalle inner join calendarionormal on ticketdetalle.idpago = calendarionormal.idpago where  idTicket = '" + idTicket + "'";

                        adapterDetalle = new SqlDataAdapter(consultaDetalle, conex);
                        dataDetalle = new DataTable();
                        adapterDetalle.Fill(dataDetalle);

                        dtDetalle.DataSource = dataDetalle;
                        foreach (DataRow drFila in dataDetalle.Rows)
                        {
                            estado = drFila["Estado"].ToString();
                            break;

                        }
                        if (estado == "C")
                        {

                            MonoFlat_HeaderLabel10.Text = "CANCELADO";
                            MonoFlat_HeaderLabel10.ForeColor = Color.Red;
                        }
                        else
                        {
                            MonoFlat_HeaderLabel10.Text = "ACTIVO";
                            MonoFlat_HeaderLabel10.ForeColor = Color.Green;
                        }

                        break;
                    }

                case "Liquidación Convenio 90%":
                    {
                        consultaDetalle = "select concat(ticketdetalle.concepto,' de ','Pago ', calendarioconveniossac.NPago) as pago,pagonormal,intereses,ticketdetalle.monto,ticketdetalle.Estado  from ticketdetalle inner join calendarioconveniossac on ticketdetalle.idpago = calendarioconveniossac.idpago where  idTicket = '" + idTicket + "'";

                        adapterDetalle = new SqlDataAdapter(consultaDetalle, conex);
                        dataDetalle = new DataTable();
                        adapterDetalle.Fill(dataDetalle);

                        dtDetalle.DataSource = dataDetalle;
                        foreach (DataRow drFila in dataDetalle.Rows)
                        {
                            estado = drFila["Estado"].ToString();
                            break;

                        }
                        if (estado == "C")
                        {

                            MonoFlat_HeaderLabel10.Text = "CANCELADO";
                            MonoFlat_HeaderLabel10.ForeColor = Color.Red;
                        }
                        else
                        {
                            MonoFlat_HeaderLabel10.Text = "ACTIVO";
                            MonoFlat_HeaderLabel10.ForeColor = Color.Green;
                        }

                        break;
                    }

            }




        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtDetalle.ScrollBars = ScrollBars.Both;
            nCargando.Close();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.AutorizacionNotificacion.tipoAutorizacion = "SacCancelarTicket";
            My.MyProject.Forms.AutorizacionNotificacion.ShowDialog();
            if (Autorizado)
            {
                estadoNotificacion = "A";
                nCargando = new Cargando();
                nCargando.Show();
                nCargando.MonoFlat_Label1.Text = "Actualizando notificación";
                BackgroundActNotificacion.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("No fue autorizado");
            }
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.AutorizacionNotificacion.tipoAutorizacion = "SacCancelarTicket";
            My.MyProject.Forms.AutorizacionNotificacion.ShowDialog();
            if (Autorizado)
            {
                estadoNotificacion = "R";
                nCargando = new Cargando();
                nCargando.Show();
                nCargando.MonoFlat_Label1.Text = "Actualizando notificación";
                BackgroundActNotificacion.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("No fue autorizado");
            }
        }

        private void BackgroundActNotificacion_DoWork(object sender, DoWorkEventArgs e)
        {
            MySqlConnection conexionLogin;
            conexionLogin = new MySqlConnection();
            conexionLogin.ConnectionString = "server=www.prestamosconfia.com;user id=ajas;pwd=123456;port=3306;database=USRS";
            conexionLogin.Open();

            if (Module1.ProbarConexionEmpresa(ipLocalTicket, bdTicket))
            {
                conectado = true;
                cnsEmpresaMysql = Module1.iniciarconexionRMysql(ipLocalTicket, bdTicket);
            }
            else
            {
                conectado = Module1.ProbarConexionEmpresa(ipRemotoTicket, bdTicket);
                if (conectado)
                {
                    cnsEmpresaMysql = Module1.iniciarconexionRMysql(ipRemotoTicket, bdTicket);
                }
                else
                {

                }

            }
            SqlConnection conex =null;
            try
            {

                conex = new SqlConnection(cnsEmpresaMysql);
                conex.Open();
                conectado = true;
            }
            catch (Exception ex)
            {
                conectado = false;
            }



            if (estadoNotificacion == "A")
            {
                if (conectado)
                {
                    if (tipoDoc == "Refrendo")
                    {
                        SqlCommand comandoFechaUpagoTicket;
                        DateTime fechaUpagoTicket;
                        string consultaUfechaTicket;
                        consultaUfechaTicket = "select fecha from ticket where id = '" + idTicket + "'";
                        comandoFechaUpagoTicket = new SqlCommand();
                        comandoFechaUpagoTicket.CommandText = consultaUfechaTicket;
                        comandoFechaUpagoTicket.Connection = conex;
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
                        comandoFechaPosterior.Connection = conex;
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
                            comandoFechaUpago.Connection = conex;
                            comandoFechaUpago.CommandText = consultaFechaUpago;
                            fechaUpago = Conversions.ToDate(comandoFechaUpago.ExecuteScalar());

                            SqlCommand comandoConsultaTicketDetalle;
                            string consultaTicketDetalle;
                            SqlDataReader readerTicketDetalle;
                            consultaTicketDetalle = "CancelarTicket";
                            comandoConsultaTicketDetalle = new SqlCommand();
                            comandoConsultaTicketDetalle.Connection = conex;
                            comandoConsultaTicketDetalle.CommandText = consultaTicketDetalle;
                            comandoConsultaTicketDetalle.CommandType = CommandType.StoredProcedure;
                            comandoConsultaTicketDetalle.Parameters.AddWithValue("idTicket", idTicket);
                            comandoConsultaTicketDetalle.Parameters.AddWithValue("Tipo", tipoDoc);
                            comandoConsultaTicketDetalle.Parameters.AddWithValue("FechaUPago", fechaUpago.Date.ToString("yyyy-MM-dd"));
                            comandoConsultaTicketDetalle.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("No se puede cancelar éste ticket, existen tickets activos con fechas posteriores");
                        }
                    }



                    else if (tipoDoc == "Desempeño")
                    {
                        SqlCommand comandoFechaUpagoTicket;
                        DateTime fechaUpagoTicket;
                        string consultaUfechaTicket;
                        consultaUfechaTicket = "select fecha from ticket where id = '" + idTicket + "'";
                        comandoFechaUpagoTicket = new SqlCommand();
                        comandoFechaUpagoTicket.CommandText = consultaUfechaTicket;
                        comandoFechaUpagoTicket.Connection = conex;
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
                        comandoFechaUpago.Connection = conex;
                        comandoFechaUpago.CommandText = consultaFechaUpago;
                        fechaUpago = Conversions.ToDate(comandoFechaUpago.ExecuteScalar());

                        SqlCommand comandoConsultaTicketDetalle;
                        string consultaTicketDetalle;
                        SqlDataReader readerTicketDetalle;
                        consultaTicketDetalle = "CancelarTicket";
                        comandoConsultaTicketDetalle = new SqlCommand();
                        comandoConsultaTicketDetalle.Connection = conex;
                        comandoConsultaTicketDetalle.CommandText = consultaTicketDetalle;
                        comandoConsultaTicketDetalle.CommandType = CommandType.StoredProcedure;
                        comandoConsultaTicketDetalle.Parameters.AddWithValue("idTicket", idTicket);
                        comandoConsultaTicketDetalle.Parameters.AddWithValue("Tipo", tipoDoc);
                        comandoConsultaTicketDetalle.Parameters.AddWithValue("FechaUPago", fechaUpago.Date.ToString("yyyy-MM-dd"));
                        comandoConsultaTicketDetalle.ExecuteNonQuery();
                    }


                    else if (tipoDoc == "Comisión por avalúo")
                    {
                        SqlCommand comandoFechaUpagoTicket;
                        DateTime fechaUpagoTicket;
                        string consultaUfechaTicket;
                        consultaUfechaTicket = "select fecha from ticket where id = '" + idTicket + "'";
                        comandoFechaUpagoTicket = new SqlCommand();
                        comandoFechaUpagoTicket.CommandText = consultaUfechaTicket;
                        comandoFechaUpagoTicket.Connection = conex;
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
                        comandoFechaPosterior.Connection = conex;
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
                            comandoFechaUpago.Connection = conex;
                            comandoFechaUpago.CommandText = consultaFechaUpago;
                            fechaUpago = Conversions.ToDate(comandoFechaUpago.ExecuteScalar());

                            SqlCommand comandoConsultaTicketDetalle;
                            string consultaTicketDetalle;
                            SqlDataReader readerTicketDetalle;
                            consultaTicketDetalle = "CancelarTicket";
                            comandoConsultaTicketDetalle = new SqlCommand();
                            comandoConsultaTicketDetalle.Connection = conex;
                            comandoConsultaTicketDetalle.CommandText = consultaTicketDetalle;
                            comandoConsultaTicketDetalle.CommandType = CommandType.StoredProcedure;
                            comandoConsultaTicketDetalle.Parameters.AddWithValue("idTicket", idTicket);
                            comandoConsultaTicketDetalle.Parameters.AddWithValue("Tipo", tipoDoc);
                            comandoConsultaTicketDetalle.Parameters.AddWithValue("FechaUPago", fechaUpago.Date.ToString("yyyy-MM-dd"));
                            comandoConsultaTicketDetalle.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("No se puede cancelar éste ticket, existen tickets activos con fechas posteriores");
                        }
                    }
                    else if (tipoDoc == "Promesa de pago")
                    {
                        SqlCommand comandoFechaUpagoTicket;
                        DateTime fechaUpagoTicket;
                        string consultaUfechaTicket;
                        consultaUfechaTicket = "select fecha from ticket where id = '" + idTicket + "'";
                        comandoFechaUpagoTicket = new SqlCommand();
                        comandoFechaUpagoTicket.CommandText = consultaUfechaTicket;
                        comandoFechaUpagoTicket.Connection = conex;
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
                        comandoFechaPosterior.Connection = conex;
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
                            comandoFechaUpago.Connection = conex;
                            comandoFechaUpago.CommandText = consultaFechaUpago;
                            fechaUpago = Conversions.ToDate(comandoFechaUpago.ExecuteScalar());

                            SqlCommand comandoConsultaTicketDetalle;
                            string consultaTicketDetalle;
                            SqlDataReader readerTicketDetalle;
                            consultaTicketDetalle = "CancelarTicket";
                            comandoConsultaTicketDetalle = new SqlCommand();
                            comandoConsultaTicketDetalle.Connection = conex;
                            comandoConsultaTicketDetalle.CommandText = consultaTicketDetalle;
                            comandoConsultaTicketDetalle.CommandType = CommandType.StoredProcedure;
                            comandoConsultaTicketDetalle.Parameters.AddWithValue("idTicket", idTicket);
                            comandoConsultaTicketDetalle.Parameters.AddWithValue("Tipo", tipoDoc);
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
                        comandoConsultaTicketDetalle.Connection = conex;
                        comandoConsultaTicketDetalle.CommandText = consultaTicketDetalle;
                        comandoConsultaTicketDetalle.CommandType = CommandType.StoredProcedure;
                        comandoConsultaTicketDetalle.Parameters.AddWithValue("idTicket", idTicket);
                        comandoConsultaTicketDetalle.Parameters.AddWithValue("Tipo", tipoDoc);
                        comandoConsultaTicketDetalle.Parameters.AddWithValue("FechaUPago", "");
                        comandoConsultaTicketDetalle.ExecuteNonQuery();

                    }
                    MySqlCommand comandoComentarioMysql;
                    string consultaComentarioMysql;
                    MySqlDataReader readerComentarioMysql;
                    consultaComentarioMysql = "update Notificaciones set Aplicado=1, FechaAplicacion= '" + DateTime.Now.ToString("yyyy-MM-dd") + "',HoraAplicacion='" + DateTime.Now.ToString("HH:mm:ss") + "',ComentarioUsuarioDestino='" + txtAddComentario.Text + "',Estado = '" + estadoNotificacion + "' where id = '" + idNotificacion + "'";
                    comandoComentarioMysql = new MySqlCommand();
                    comandoComentarioMysql.Connection = conexionLogin;
                    comandoComentarioMysql.CommandText = consultaComentarioMysql;
                    comandoComentarioMysql.ExecuteNonQuery();
                }

                else
                {
                    MessageBox.Show("Ha habido un error, inténtelo de nuevo");
                }
            }

            else
            {
                MySqlCommand comandoComentarioMysql;
                string consultaComentarioMysql;
                MySqlDataReader readerComentarioMysql;
                consultaComentarioMysql = "update Notificaciones set Aplicado = 1, FechaAplicacion= '" + DateTime.Now.ToString("yyyy-MM-dd") + "',HoraAplicacion='" + DateTime.Now.ToString("HH:mm:ss") + "',ComentarioUsuarioDestino='" + txtAddComentario.Text + "',Estado = '" + estadoNotificacion + "' where id = '" + idNotificacion + "'";
                comandoComentarioMysql = new MySqlCommand();
                comandoComentarioMysql.Connection = conexionLogin;
                comandoComentarioMysql.CommandText = consultaComentarioMysql;
                comandoComentarioMysql.ExecuteNonQuery();
            }

        }

        private void BackgroundActNotificacion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            for (int i = My.MyProject.Forms.CentroDeNotificaciones.FlowLayoutPanel1.Controls.Count - 1; i >= 0; i -= 1)
            {
                if (My.MyProject.Forms.CentroDeNotificaciones.FlowLayoutPanel1.Controls[i] is Panel)
                {
                    Panel ctr = (Panel)My.MyProject.Forms.CentroDeNotificaciones.FlowLayoutPanel1.Controls[i];
                    if ((ctr.Name ?? "") == (idNotificacion ?? ""))
                    {

                        Invoke(new Action(() => { for (int a = My.MyProject.Forms.frm_adm.array.Count - 1; a >= 0; a -= 1) { Notificaciones r = (Notificaciones)My.MyProject.Forms.frm_adm.array[a]; if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(ctr.Name, r.id, false))) { My.MyProject.Forms.frm_adm.array.RemoveAt(a); My.MyProject.Forms.frm_adm.CantNotificaciones -= 1; My.MyProject.Forms.frm_adm.notificaciones.Text = "Tienes " + My.MyProject.Forms.frm_adm.array.Count + " notificaciones"; My.MyProject.Forms.frm_adm.notificaciones.Refresh(); break; } } }));

                        My.MyProject.Forms.CentroDeNotificaciones.FlowLayoutPanel1.Controls.RemoveAt(i);

                    }
                }
            }
            nCargando.Close();
            Close();

        }

        private void BackgroundVerificaNotificacion_DoWork(object sender, DoWorkEventArgs e)
        {
            MySqlConnection conexionNotificaciones;
            conexionNotificaciones = new MySqlConnection();
            conexionNotificaciones.ConnectionString = "server=www.prestamosconfia.com;user id=ajas;pwd=123456;port=3306;database=USRS";
            conexionNotificaciones.Open();

            // Revisar notificaciones no aplicadas


            MySqlCommand mysqlcomandoexiste;
            string consultaExiste;


            consultaExiste = "select Aplicado from Notificaciones where id = '" + idNotificacion + "'";
            mysqlcomandoexiste = new MySqlCommand();
            mysqlcomandoexiste.Connection = conexionNotificaciones;
            mysqlcomandoexiste.CommandText = consultaExiste;
            aplicado = Conversions.ToBoolean(mysqlcomandoexiste.ExecuteScalar());



        }

        private void BackgroundVerificaNotificacion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (aplicado)
            {
                nCargando.Close();
                Invoke(new Action(() =>
                    {
                        var nAlertas = new Alertas();


                        nAlertas.cadena = "La notificación ya fue eliminada";
                        for (int i = My.MyProject.Forms.CentroDeNotificaciones.FlowLayoutPanel1.Controls.Count - 1; i >= 0; i -= 1)
                        {
                            if (My.MyProject.Forms.CentroDeNotificaciones.FlowLayoutPanel1.Controls[i] is Panel)
                            {
                                Panel ctr = (Panel)My.MyProject.Forms.CentroDeNotificaciones.FlowLayoutPanel1.Controls[i];
                                if ((ctr.Name ?? "") == (idNotificacion ?? ""))
                                {

                                    Invoke(new Action(() => { for (int a = My.MyProject.Forms.frm_adm.array.Count - 1; a >= 0; a -= 1) { Notificaciones r = (Notificaciones)My.MyProject.Forms.frm_adm.array[a]; if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(ctr.Name, r.id, false))) { My.MyProject.Forms.frm_adm.array.RemoveAt(a); My.MyProject.Forms.frm_adm.CantNotificaciones -= 1; My.MyProject.Forms.frm_adm.notificaciones.Text = "Tienes " + My.MyProject.Forms.frm_adm.array.Count + " notificaciones"; My.MyProject.Forms.frm_adm.notificaciones.Refresh(); break; } } }));

                                    My.MyProject.Forms.CentroDeNotificaciones.FlowLayoutPanel1.Controls.RemoveAt(i);

                                }
                            }
                        }



                    // frm_adm.array.RemoveAt(a)
                    nAlertas.ShowDialog();
                        nAlertas.TopMost = true;
                    }));


                Close();
            }
            else
            {

                BackgroundWorker1.RunWorkerAsync();

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

        private void MonoFlat_HeaderLabel3_Click(object sender, EventArgs e)
        {

        }

        private void MonoFlat_HeaderLabel11_Click(object sender, EventArgs e)
        {

        }
    }
}