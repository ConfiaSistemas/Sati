using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class ActInformacionCredito
    {

        public string idCredito;
        private string domicilioActual;
        private string noExpedienteActual;
        private string JuzgadoActual;
        private string EtapaProcesalActual;
        private string ActuarioActual;
        private string consultaActualizacion;
        private string datoscliente;
        private string idSolicitud;
        private string idDatosSolicitud;
        private string datosSolicitudId;
        private string NuevoDomicilio;
        private string consul;
        private string sol;
        private string retorno;
        private DataTable datosSolicitud;
        private DataTable dom;
        private SqlDataAdapter adapterDatosSolicitud;

        public ActInformacionCredito()
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
                case "Domicilio de Trabajo":
                    {
                        PanelDomicilio.Location = new Point(41, 124);
                        PanelDomicilio.Visible = true;
                        PanelValor.Visible = false;
                        break;
                    }
                case "Referencia 1":
                    {
                        PanelR.Location = new Point(41, 124);
                        PanelR.Visible = true;
                        PanelValor.Visible = false;
                        PanelDomicilio.Visible = false;
                        break;
                    }
                case "Referencia 2":
                    {
                        PanelR.Location = new Point(41, 124);
                        PanelR.Visible = true;
                        PanelValor.Visible = false;
                        PanelDomicilio.Visible = false;
                        break;
                    }

                default:
                    {
                        PanelValor.Location = new Point(41, 124);
                        PanelValor.Visible = true;
                        PanelDomicilio.Visible = false;
                        PanelR.Visible = false;
                        break;
                    }
            }
        }

        private void ActInformacionLegal_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            ComboTipo.selectedIndex = 0;
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Información";
            BackgroundConsultaInformacion.RunWorkerAsync();

        }

        private void BackgroundConsultaInformacion_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();


            string consultaInformacion;

            consultaInformacion = "select CONCAT(Clientes.Nombre,' ',Clientes.ApellidoPaterno,' ',Clientes.ApellidoMaterno) as nombre,concat('Calle ',DatosSolicitud.Calle,' Número Exterior ',DatosSolicitud.Noext,' Número Interior ',DatosSolicitud.Noint,' Colonia ',DatosSolicitud.Colonia,' Código Postal ',DatosSolicitud.CodigoPostal) as Domicilio,concat('Calle ',CalleTrabajo,' Número exterior ',NoextTrabajo,' Número Interior ',NointTrabajo,' Colonia ',ColoniaTrabajo,' Código postal ',CodigoPostalTrabajo) as domicilioTrabajo,DatosSolicitud.Telefono,DatosSolicitud.Celular,DatosSolicitud.TelefonoTrabajo,DatosSolicitud.id as idDatosSolicitud,concat('Nombre ',datossolicitud.NombreR1,' Teléfono ',datossolicitud.TelefonoR1,' Relación ',datossolicitud.RelacionR1,' Domicilio ',datossolicitud.CalleR1,' No. Ext. ',datossolicitud.NoExtR1,' No. Int. ',datossolicitud.NoIntR1,' Colonia ',datossolicitud.ColoniaR1,' C.P. ',datossolicitud.CodigoPostalR1) as Referencia1,concat('Nombre ',datossolicitud.NombreR2,' Teléfono ',datossolicitud.TelefonoR2,' Relación ',datossolicitud.RelacionR2,' Domicilio ',datossolicitud.CalleR2,' No. Ext. ',datossolicitud.NoExtR2,' No. Int. ',datossolicitud.NoIntR2,' Colonia ',datossolicitud.ColoniaR2,' C.P. ',datossolicitud.CodigoPostalR2) as Referencia2 from credito inner join Solicitud on Credito.idSolicitud = Solicitud.id inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud inner join Clientes on DatosSolicitud.IdCliente = Clientes.id where Credito.id = '" + idCredito + "'";


            adapterDatosSolicitud = new SqlDataAdapter(consultaInformacion, Module1.conexionempresa);
            datosSolicitud = new DataTable();
            adapterDatosSolicitud.Fill(datosSolicitud);

            foreach (DataRow row1 in datosSolicitud.Rows)
            {

                datosSolicitudId = Conversions.ToString(row1["idDatosSolicitud"]);

                break;

            }

            // 'sol = SOLUCION remplazo de "idDatosSolicitud"
        }

        private void BackgroundConsultaInformacion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ComboCliente.Clear();


            foreach (DataRow row in datosSolicitud.Rows)


                ComboCliente.AddItem(row["nombre"].ToString());

            ComboCliente.selectedIndex = 0;


            My.MyProject.Forms.Cargando.Close();
        }

        private void BackgroundActualizacion_DoWork(object sender, DoWorkEventArgs e)
        {


            string tiempo = DateAndTime.TimeOfDay.ToString("HH:mm:ss");
            idDatosSolicitud = ObteneridDatosSolicitud(ComboCliente.selectedValue);
            SqlCommand comandoLegalAnterior;
            string consultaLegalAnterior ="";
            string valorAnteriorStr;


            switch (ComboTipo.selectedValue ?? "")
            {
                case "Domicilio":
                    {
                        valorAnteriorStr = ValorAnterior(ComboTipo.selectedValue, datosSolicitudId);

                        NuevoDomicilio = "Calle " + txtCalle.Text + " Número Exterior " + txtNoExt.Text + " Número Interior " + txtNoInt.Text + " Colonia " + txtColonia.Text + " Código Postal " + txtCodigoPostal.Text;
                        consultaLegalAnterior = "insert into ActualizacionesCredito values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tiempo + "','" + ComboTipo.selectedValue + "','" + valorAnteriorStr + "','" + NuevoDomicilio + "','" + txtMotivo.Text + "','" + idCredito + "')";
                        break;
                    }
                case "Número de Teléfono":
                    {
                        valorAnteriorStr = ValorAnterior(ComboTipo.selectedValue, datosSolicitudId);
                        consultaLegalAnterior = "insert into ActualizacionesCredito values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tiempo + "','" + ComboTipo.selectedValue + "','" + valorAnteriorStr + "','" + txtValor.Text + "','" + txtMotivo.Text + "','" + idCredito + "')";
                        break;
                    }
                case "Número de Celular":
                    {
                        valorAnteriorStr = ValorAnterior(ComboTipo.selectedValue, datosSolicitudId);
                        consultaLegalAnterior = "insert into ActualizacionesCredito values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tiempo + "','" + ComboTipo.selectedValue + "','" + valorAnteriorStr + "','" + txtValor.Text + "','" + txtMotivo.Text + "','" + idCredito + "')";
                        break;
                    }
                case "Domicilio de Trabajo":
                    {
                        valorAnteriorStr = ValorAnterior(ComboTipo.selectedValue, datosSolicitudId);
                        NuevoDomicilio = "Calle " + txtCalle.Text + " Número Exterior " + txtNoExt.Text + " Número Interior " + txtNoInt.Text + " Colonia " + txtColonia.Text + " Código Postal " + txtCodigoPostal.Text;

                        consultaLegalAnterior = "insert into ActualizacionesCredito values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tiempo + "','" + ComboTipo.selectedValue + "','" + valorAnteriorStr + "','" + NuevoDomicilio + "','" + txtMotivo.Text + "','" + idCredito + "')";
                        break;
                    }
                case "Teléfono de Trabajo":
                    {
                        valorAnteriorStr = ValorAnterior(ComboTipo.selectedValue, datosSolicitudId);
                        consultaLegalAnterior = "insert into ActualizacionesCredito values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tiempo + "','" + ComboTipo.selectedValue + "','" + valorAnteriorStr + "','" + txtValor.Text + "','" + txtMotivo.Text + "','" + idCredito + "')";
                        break;
                    }
                case "Referencia 1":
                    {
                        valorAnteriorStr = ValorAnterior(ComboTipo.selectedValue, datosSolicitudId);
                        NuevoDomicilio = "Nombre " + txtNombreR.Text + " Teléfono " + txtTelefonoR.Text + " Relación " + txtRelacionR.Text + " Domicilio " + txtCalleR.Text + " No. Ext. " + txtNoExtR.Text + " No. Int. " + txtNoIntR.Text + " Colonia " + ComboColoniaR.selectedValue + " C.P. " + txtCPR.Text;

                        consultaLegalAnterior = "insert into ActualizacionesCredito values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tiempo + "','" + ComboTipo.selectedValue + "','" + valorAnteriorStr + "','" + NuevoDomicilio + "','" + txtMotivo.Text + "','" + idCredito + "')";
                        break;
                    }
                case "Referencia 2":
                    {
                        valorAnteriorStr = ValorAnterior(ComboTipo.selectedValue, datosSolicitudId);
                        NuevoDomicilio = "Nombre " + txtNombreR.Text + " Teléfono " + txtTelefonoR.Text + " Relación " + txtRelacionR.Text + " Domicilio " + txtCalleR.Text + " No. Ext. " + txtNoExtR.Text + " No. Int. " + txtNoIntR.Text + " Colonia " + ComboColoniaR.selectedValue + " C.P. " + txtCPR.Text;

                        consultaLegalAnterior = "insert into ActualizacionesCredito values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tiempo + "','" + ComboTipo.selectedValue + "','" + valorAnteriorStr + "','" + NuevoDomicilio + "','" + txtMotivo.Text + "','" + idCredito + "')";
                        break;
                    }
            }
            // consultaLegalAnterior = "insert into ActualizacionLegal values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & ComboTipo.selectedValue & "','" &  & "')"
            comandoLegalAnterior = new SqlCommand();
            comandoLegalAnterior.Connection = Module1.conexionempresa;
            comandoLegalAnterior.CommandText = consultaLegalAnterior;
            comandoLegalAnterior.ExecuteNonQuery();


            switch (ComboTipo.selectedValue ?? "")
            {
                case "Domicilio":
                    {
                        My.MyProject.Forms.Cargando.Show();
                        consultaActualizacion = "update datosSolicitud set calle = '" + txtCalle.Text + "',noext = '" + txtNoExt.Text + "',noint = '" + txtNoInt.Text + "',codigopostal = '" + txtCodigoPostal.Text + "',colonia = '" + txtColonia.Text + "' where id = '" + datosSolicitudId + "'";
                        My.MyProject.Forms.Cargando.Close();
                        break;
                    }
                case "Número de Teléfono":
                    {
                        My.MyProject.Forms.Cargando.Show();
                        consultaActualizacion = "update datosSolicitud set telefono = '" + txtValor.Text + "' where id = '" + datosSolicitudId + "'";
                        My.MyProject.Forms.Cargando.Close();
                        break;
                    }
                case "Número de Celular":
                    {
                        consultaActualizacion = "update datosSolicitud set celular = '" + txtValor.Text + "' where id = '" + datosSolicitudId + "'";
                        break;
                    }
                case "Domicilio de Trabajo":
                    {
                        consultaActualizacion = "update datosSolicitud set calletrabajo = '" + txtCalle.Text + "',noextTrabajo = '" + txtNoExt.Text + "',nointTrabajo = '" + txtNoInt.Text + "',codigopostalTrabajo = '" + txtCodigoPostal.Text + "',coloniaTrabajo = '" + txtColonia.Text + "' where id = '" + sol + "'";
                        break;
                    }
                case "Teléfono de Trabajo":
                    {
                        consultaActualizacion = "update datosSolicitud set telefonoTrabajo = '" + txtValor.Text + "' where id = '" + datosSolicitudId + "'";
                        break;
                    }
                case "Referencia 1":
                    {
                        consultaActualizacion = "update datossolicitud set NombreR1 = '" + txtNombreR.Text + "',TelefonoR1 = '" + txtTelefonoR.Text + "',RelacionR1 = '" + txtRelacionR.Text + "',CodigoPostalR1 = '" + txtCPR.Text + "',ColoniaR1 = '" + ComboColoniaR.selectedValue + "',calleR1 ='" + txtCalleR.Text + "',NoExtR1 = '" + txtNoExtR.Text + "',NoIntR1 = '" + txtNoIntR.Text + "' where id = '" + datosSolicitudId + "'";
                        break;
                    }
                case "Referencia 2":
                    {
                        consultaActualizacion = "update datossolicitud set NombreR2 = '" + txtNombreR.Text + "',TelefonoR2 = '" + txtTelefonoR.Text + "',RelacionR2 = '" + txtRelacionR.Text + "',CodigoPostalR2 = '" + txtCPR.Text + "',ColoniaR2 = '" + ComboColoniaR.selectedValue + "',calleR2 ='" + txtCalleR.Text + "',NoExtR2 = '" + txtNoExtR.Text + "',NoIntR2 = '" + txtNoIntR.Text + "' where id = '" + datosSolicitudId + "'";
                        break;
                    }

            }





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

        private string ObteneridDatosSolicitud(string Nombre)
        {

            foreach (DataRow row in datosSolicitud.Rows)
            {
                if ((row["nombre"].ToString() ?? "") == (Nombre ?? ""))
                {
                    datosSolicitudId = Conversions.ToString(row["idDatosSolicitud"]);
                    break;
                }
            }

            return datosSolicitudId;

        }


        private string ValorAnterior(string campo, string aquien)
        {



            foreach (DataRow row in datosSolicitud.Rows)
            {


                bool exitFor = false;
                bool exitFor1 = false;
                bool exitFor2 = false;
                bool exitFor3 = false;
                bool exitFor4 = false;
                bool exitFor5 = false;
                bool exitFor6 = false;
                switch (campo ?? "")
                {

                    case "Domicilio":
                        {
                            if ((row["idDatosSolicitud"].ToString() ?? "") == (aquien ?? ""))
                            {
                                retorno = row["Domicilio"].ToString();

                                MessageBox.Show(retorno);

                                exitFor = true;
                                break;
                            }

                            break;
                        }
                    case "Número de Teléfono":
                        {
                            if ((row["idDatosSolicitud"].ToString() ?? "") == (aquien ?? ""))
                            {
                                retorno = row["Telefono"].ToString();
                                exitFor1 = true;
                                break;
                            }

                            break;
                        }
                    case "Número de Celular":
                        {
                            if ((row["idDatosSolicitud"].ToString() ?? "") == (aquien ?? ""))
                            {
                                retorno = row["Celular"].ToString();
                                exitFor2 = true;
                                break;
                            }

                            break;
                        }
                    case "Domicilio de Trabajo":
                        {
                            if ((row["idDatosSolicitud"].ToString() ?? "") == (aquien ?? ""))
                            {
                                retorno = row["domicilioTrabajo"].ToString();
                                exitFor3 = true;
                                break;
                            }

                            break;
                        }
                    case "Teléfono de Trabajo":
                        {
                            if ((row["idDatosSolicitud"].ToString() ?? "") == (aquien ?? ""))
                            {
                                retorno = row["TelefonoTrabajo"].ToString();
                                exitFor4 = true;
                                break;
                            }

                            break;
                        }
                    case "Referencia 1":
                        {
                            if ((row["idDatosSolicitud"].ToString() ?? "") == (aquien ?? ""))
                            {
                                retorno = row["Referencia1"].ToString();
                                exitFor5 = true;
                                break;
                            }

                            break;
                        }
                    case "Referencia 2":
                        {
                            if ((row["idDatosSolicitud"].ToString() ?? "") == (aquien ?? ""))
                            {
                                retorno = row["Referencia2"].ToString();
                                exitFor6 = true;
                                break;
                            }

                            break;
                        }
                }

                if (exitFor)
                {
                    break;
                }

                if (exitFor1)
                {
                    break;
                }

                if (exitFor2)
                {
                    break;
                }

                if (exitFor3)
                {
                    break;
                }

                if (exitFor4)
                {
                    break;
                }

                if (exitFor5)
                {
                    break;
                }

                if (exitFor6)
                {
                    break;
                }
            }
            return retorno;
        }

        private void txtCPR_OnValueChanged(object sender, EventArgs e)
        {

            ComboColoniaR.Clear();

            foreach (DataRow row in Module1.dataColonias.Rows)
            {
                if ((row["CP"].ToString() ?? "") == (txtCPR.Text ?? ""))
                {
                    ComboColoniaR.AddItem(row["Colonia"].ToString());
                }
            }
        }
    }
}