using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class ActInformacionLegal
    {
        public string idCreditoLegal;
        private string domicilioActual;
        private string noExpedienteActual;
        private string JuzgadoActual;
        private string EtapaProcesalActual;
        private string ActuarioActual;
        private string consultaActualizacion;
        private string idSolicitud;
        private string idDatosSolicitud;
        private string NuevoDomicilio;

        public ActInformacionLegal()
        {
            InitializeComponent();
        }
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Module_resize.MoveForm(this);
            }
        }

        private void ComboTipo_onItemSelected(object sender, EventArgs e)
        {
            switch (ComboTipo.selectedValue ?? "")
            {
                case "Domicilio":
                    {
                        PanelDomicilio.Location = new Point(41, 124);
                        PanelDomicilio.Visible = true;
                        PanelValor.Visible = false;
                        break;
                    }

                default:
                    {
                        PanelValor.Location = new Point(41, 124);
                        PanelValor.Visible = true;
                        PanelDomicilio.Visible = false;
                        break;
                    }
            }
        }

        private void ActInformacionLegal_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Información";
            BackgroundConsultaInformacion.RunWorkerAsync();

        }

        private void BackgroundConsultaInformacion_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();

            SqlCommand comandoInformacion;
            string consultaInformacion;
            SqlDataReader readerInformacion;
            consultaInformacion = "select NoExpediente,Juzgado,EtapaProcesal,Actuario,datosSolicitud.id as idDatosSolicitud from legales inner join Solicitud on Legales.idSolicitud = Solicitud.id inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud where legales.id= '" + idCreditoLegal + "'";
            comandoInformacion = new SqlCommand();
            comandoInformacion.Connection = Module1.conexionempresa;
            comandoInformacion.CommandText = consultaInformacion;
            readerInformacion = comandoInformacion.ExecuteReader();
            if (readerInformacion.HasRows)
            {
                while (readerInformacion.Read())
                {
                    noExpedienteActual = Conversions.ToString(readerInformacion["Noexpediente"]);
                    JuzgadoActual = Conversions.ToString(readerInformacion["Juzgado"]);
                    EtapaProcesalActual = Conversions.ToString(readerInformacion["EtapaProcesal"]);
                    ActuarioActual = Conversions.ToString(readerInformacion["Actuario"]);
                    idDatosSolicitud = Conversions.ToString(readerInformacion["idDatosSolicitud"]);
                }
            }
            readerInformacion.Close();

            SqlCommand comandoDomicilio;
            string consultaDomicilio;
            consultaDomicilio = "select concat('Calle ',DatosSolicitud.Calle,' Número Exterior ',DatosSolicitud.Noext,' Número Interior ',DatosSolicitud.Noint,' Colonia ',DatosSolicitud.Colonia,' Código Postal ',DatosSolicitud.CodigoPostal) as Domicilio from Legales inner join Solicitud on legales.idSolicitud = Solicitud.id inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud where legales.id = '" + idCreditoLegal + "'";
            comandoDomicilio = new SqlCommand();
            comandoDomicilio.Connection = Module1.conexionempresa;
            comandoDomicilio.CommandText = consultaDomicilio;
            domicilioActual = Conversions.ToString(comandoDomicilio.ExecuteScalar());

        }

        private void BackgroundConsultaInformacion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();
        }

        private void BackgroundActualizacion_DoWork(object sender, DoWorkEventArgs e)
        {

            string tiempo = DateAndTime.TimeOfDay.ToString("HH:mm:ss");
            switch (ComboTipo.selectedValue ?? "")
            {
                case "Domicilio":
                    {
                        consultaActualizacion = "update datosSolicitud set calle = '" + txtCalle.Text + "',noext = '" + txtNoExt.Text + "',noint = '" + txtNoInt.Text + "',codigopostal = '" + txtCodigoPostal.Text + "',colonia = '" + txtColonia.Text + "' where id = '" + idDatosSolicitud + "'";
                        break;
                    }
                case "Número de Expediente":
                    {
                        consultaActualizacion = "update legales set NoExpediente = '" + txtValor.Text + "' where id = '" + idCreditoLegal + "'";
                        break;
                    }
                case "Juzgado":
                    {
                        consultaActualizacion = "update legales set Juzgado = '" + txtValor.Text + "' where id = '" + idCreditoLegal + "'";
                        break;
                    }
                case "Etapa Procesal":
                    {
                        consultaActualizacion = "update legales set EtapaProcesal = '" + txtValor.Text + "' where id = '" + idCreditoLegal + "'";
                        break;
                    }
                case "Actuario":
                    {
                        consultaActualizacion = "update legales set actuario = '" + txtValor.Text + "' where id = '" + idCreditoLegal + "'";
                        break;
                    }
            }
            SqlCommand comandoLegalAnterior;
            string consultaLegalAnterior ="";

            switch (ComboTipo.selectedValue ?? "")
            {
                case "Domicilio":
                    {
                        NuevoDomicilio = "Calle " + txtCalle.Text + " Número Exterior " + txtNoExt.Text + " Número Interior " + txtNoInt.Text + " Colonia " + txtColonia.Text + " Código Postal " + txtCodigoPostal.Text;
                        consultaLegalAnterior = "insert into ActualizacionesLegal values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tiempo + "','" + ComboTipo.selectedValue + "','" + domicilioActual + "','" + NuevoDomicilio + "','" + txtMotivo.Text + "','" + idCreditoLegal + "')";
                        break;
                    }
                case "Número de Expediente":
                    {
                        consultaLegalAnterior = "insert into ActualizacionesLegal values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tiempo + "','" + ComboTipo.selectedValue + "','" + noExpedienteActual + "','" + txtValor.Text + "','" + txtMotivo.Text + "','" + idCreditoLegal + "')";
                        break;
                    }
                case "Juzgado":
                    {
                        consultaLegalAnterior = "insert into ActualizacionesLegal values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tiempo + "','" + ComboTipo.selectedValue + "','" + JuzgadoActual + "','" + txtValor.Text + "','" + txtMotivo.Text + "','" + idCreditoLegal + "')";
                        break;
                    }
                case "Etapa Procesal":
                    {
                        consultaLegalAnterior = "insert into ActualizacionesLegal values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tiempo + "','" + ComboTipo.selectedValue + "','" + EtapaProcesalActual + "','" + txtValor.Text + "','" + txtMotivo.Text + "','" + idCreditoLegal + "')";
                        break;
                    }
                case "Actuario":
                    {
                        consultaLegalAnterior = "insert into ActualizacionesLegal values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tiempo + "','" + ComboTipo.selectedValue + "','" + ActuarioActual + "','" + txtValor.Text + "','" + txtMotivo.Text + "','" + idCreditoLegal + "')";
                        break;
                    }
            }
            // consultaLegalAnterior = "insert into ActualizacionLegal values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & ComboTipo.selectedValue & "','" &  & "')"
            comandoLegalAnterior = new SqlCommand();
            comandoLegalAnterior.Connection = Module1.conexionempresa;
            comandoLegalAnterior.CommandText = consultaLegalAnterior;
            comandoLegalAnterior.ExecuteNonQuery();


            SqlCommand comandoAct;
            comandoAct = new SqlCommand();
            comandoAct.Connection = Module1.conexionempresa;
            comandoAct.CommandText = consultaActualizacion;
            comandoAct.ExecuteNonQuery();




        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Actualizando Información";
            My.MyProject.Forms.Cargando.TopMost = true;
            BackgroundActualizacion.RunWorkerAsync();

        }

        private void BackgroundActualizacion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();
            Close();
        }
    }
}