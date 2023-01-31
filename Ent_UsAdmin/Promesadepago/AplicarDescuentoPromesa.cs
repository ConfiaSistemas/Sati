using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace ConfiaAdmin
{

    public partial class AplicarDescuentoPromesa
    {
        public bool Autorizado;
        private string cnsEmpresaMysql;
        public string idPromesa;
        public string idNotificacion;
        private string localRemoto;
        private string ipLocalTicket;
        private string nombreRemoto;
        private string ipRemotoTicket;
        private string bdTicket;
        private string estadoNotificacion;
        private string tipoDoc;
        private Cargando nCargando;
        private bool conectado;
        private bool aplicado;

        public AplicarDescuentoPromesa()
        {
            InitializeComponent();
        }
        private void CancelarTicket_Load(object sender, EventArgs e)
        {
            txtComentario.BackColor = BackColor;
            lblNoTicket.Text = idPromesa;
            nCargando = new Cargando();
            nCargando.Show();
            nCargando.MonoFlat_Label1.Text = "Consultando estado de notificación";
            nCargando.TopMost = true;
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


            string consultaTicket;

            consultaTicket = "select credito.nombre,format(subtotal,'C','es-mx') as 'Subtotal',format(Capital,'C','es-mx') as Capital, format(Moratorios,'C','es-mx') as Moratorios, format(Descuento,'C','es-mx') as Descuento,format(montopromesa,'C','es-mx') as 'MontoPromesa',FechaLimite as 'Fecha Límite',promesadepago.Fecha,promesadepago.Hora,promesadepago.Usuario,promesadepago.Estado,TipoCredito as 'Tipo de Crédito' from PromesaDePago inner join credito on promesadepago.idcredito = credito.id where promesadepago.id = '" + idPromesa + "'";

            string consultaDetalle;
            SqlDataAdapter adapterDetalle;
            DataTable dataDetalle;
            adapterDetalle = new SqlDataAdapter(consultaTicket, conex);
            dataDetalle = new DataTable();
            adapterDetalle.Fill(dataDetalle);
            dtDetalle.DataSource = dataDetalle;


        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtDetalle.ScrollBars = ScrollBars.Both;
            nCargando.Close();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.AutorizacionNotificacion.tipoAutorizacion = "SatiModCreditosDescuentoPromesa";
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
            My.MyProject.Forms.AutorizacionNotificacion.tipoAutorizacion = "SatiModCreditosDescuentoPromesa";
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
            SqlConnection conex = null ;
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
                    SqlCommand comandoActualizaPromesa;
                    string consultaActualizaPromesa;
                    consultaActualizaPromesa = "update promesadepago set estado = 'A' where id = '" + idPromesa + "'";
                    comandoActualizaPromesa = new SqlCommand();
                    comandoActualizaPromesa.Connection = conex;
                    comandoActualizaPromesa.CommandText = consultaActualizaPromesa;
                    comandoActualizaPromesa.ExecuteNonQuery();

                    foreach (DataGridViewRow row in dtDetalle.Rows)
                    {
                        SqlCommand comandoActualizaCalendarioPromesa;
                        string consultaActualizaCalendarioPromesa;
                        switch (row.Cells[11].Value)
                        {
                            case "C":
                                {
                                    consultaActualizaCalendarioPromesa = "update calendarioconveniossac set convenio = 1 where idpago in ((select idpago from detallepromesa where idpromesa = '" + idPromesa + "'))";
                                    break;
                                }
                            case "R":
                                {
                                    consultaActualizaCalendarioPromesa = "update calendarioreestructurassac set convenio = 1 where idpago in ((select idpago from detallepromesa where idpromesa = '" + idPromesa + "'))";
                                    break;
                                }
                            case "L":
                                {
                                    consultaActualizaCalendarioPromesa = "update calendariolegales set convenio = 1 where idpago in ((select idpago from detallepromesa where idpromesa = '" + idPromesa + "'))";
                                    break;
                                }

                            default:
                                {
                                    consultaActualizaCalendarioPromesa = "update calendarionormal set convenio = 1 where idpago in ((select idpago from detallepromesa where idpromesa = '" + idPromesa + "'))";
                                    break;
                                }
                        }
                        comandoActualizaCalendarioPromesa = new SqlCommand();
                        comandoActualizaCalendarioPromesa.Connection = conex;
                        comandoActualizaCalendarioPromesa.CommandText = consultaActualizaCalendarioPromesa;
                        comandoActualizaCalendarioPromesa.ExecuteNonQuery();

                        break;
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

                SqlCommand comandoActualizaPromesa;
                string consultaActualizaPromesa;
                consultaActualizaPromesa = "update promesadepago set estado = 'R' where id = '" + idPromesa + "'";
                comandoActualizaPromesa = new SqlCommand();
                comandoActualizaPromesa.Connection = conex;
                comandoActualizaPromesa.CommandText = consultaActualizaPromesa;
                comandoActualizaPromesa.ExecuteNonQuery();

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
                dtDetalle.ScrollBars = ScrollBars.None;
                BackgroundWorker1.RunWorkerAsync();

            }
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