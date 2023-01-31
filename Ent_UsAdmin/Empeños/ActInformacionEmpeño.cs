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

    public partial class ActInformacionEmpeño
    {

        public string idEmpeño;
        private string domicilioActual;
        private string noExpedienteActual;
        private string JuzgadoActual;
        private string EtapaProcesalActual;
        private string ActuarioActual;
        private string consultaActualizacion;
        private string idSolicitud;
        private string idSolicitudBoleta;
        private string NuevoDomicilio;
        private DataTable datosSolicitud;
        private SqlDataAdapter adapterDatosSolicitud;
        private Cargando newCargando;

        public ActInformacionEmpeño()
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

        private void ActInformacionEmpeño_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            ComboTipo.selectedIndex = 0;
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Información...";
            BackgroundConsultaInformacion.RunWorkerAsync();

        }

        private void BackgroundConsultaInformacion_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();


            string consultaInformacion;

            consultaInformacion = "select SolicitudBoleta.id,SolicitudBoleta.Nombre,SolicitudBoleta.Domicilio,Telefono,SolicitudBoleta.INE,CURP from SolicitudBoleta inner join empeños on empeños.idSolicitudBoleta = SolicitudBoleta.id where Empeños.id = '" + idEmpeño + "'";


            adapterDatosSolicitud = new SqlDataAdapter(consultaInformacion, Module1.conexionempresa);
            datosSolicitud = new DataTable();
            adapterDatosSolicitud.Fill(datosSolicitud);

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
            try
            {
                string tiempo = DateAndTime.TimeOfDay.ToString("HH:mm:ss");
                idSolicitudBoleta = ObteneridDatosSolicitud(ComboCliente.selectedValue);
                switch (ComboTipo.selectedValue ?? "")
                {
                    case "Domicilio":
                        {
                            consultaActualizacion = "update SolicitudBoleta set Domicilio = '" + txtDomicilio.Text + "',CodigoPostal = '" + txtCodigoPostal.Text + "',Colonia = '" + txtColonia.Text + "',Municipio = '" + txtCiudad.Text + "',Entidad = '" + txtEstado.Text + "' where id = '" + idSolicitudBoleta + "'";
                            break;
                        }
                    case "Número de Teléfono":
                        {
                            consultaActualizacion = "update SolicitudBoleta set telefono = '" + txtValor.Text + "' where id = '" + idSolicitudBoleta + "'";
                            break;
                        }
                    case "Nombre":
                        {
                            consultaActualizacion = "update SolicitudBoleta set Nombre = '" + txtValor.Text + "' where id = '" + idSolicitudBoleta + @"'
                                        update Empeños set Nombre = '" + txtValor.Text + "' where idSolicitudBoleta = '" + idSolicitudBoleta + "'";
                            break;
                        }
                    case "CURP":
                        {
                            consultaActualizacion = "update SolicitudBoleta set CURP = '" + txtValor.Text + "' where id = '" + idSolicitudBoleta + "'";
                            break;
                        }
                    case "INE":
                        {
                            consultaActualizacion = "update SolicitudBoleta set INE = '" + txtValor.Text + "' where id = '" + idSolicitudBoleta + @"'
                                        update Empeños set INE ='" + txtValor.Text + "' where idSolicitudBoleta='" + idSolicitudBoleta + "'";
                            break;
                        }
                }
                SqlCommand comandoEmpeñoAnterior;
                string consultaEmpeñoAnterior ="";
                string valorAnteriorStr;

                switch (ComboTipo.selectedValue ?? "")
                {
                    case "Domicilio":
                        {
                            valorAnteriorStr = ValorAnterior(ComboTipo.selectedValue, idSolicitudBoleta);
                            NuevoDomicilio = "Domicilio " + txtDomicilio.Text + " Código Postal " + txtCodigoPostal.Text + " Colonia " + txtColonia.Text + " Estado " + txtEstado.Text + " Ciudad " + txtCiudad.Text;
                            consultaEmpeñoAnterior = $"insert into ActualizacionesEmpeño values('{idEmpeño}','{DateTime.Now.ToString("yyyy-MM-dd")}','{tiempo}','{ComboTipo.selectedValue}','{valorAnteriorStr}','{NuevoDomicilio}','{txtMotivo.Text}')";
                            break;
                        }
                    case "Número de Teléfono":
                        {
                            valorAnteriorStr = ValorAnterior(ComboTipo.selectedValue, idSolicitudBoleta);
                            consultaEmpeñoAnterior = $"insert into ActualizacionesEmpeño values('{idEmpeño}','{DateTime.Now.ToString("yyyy-MM-dd")}','{tiempo}','{ComboTipo.selectedValue}','{valorAnteriorStr}','{txtValor.Text}','{txtMotivo.Text}')";
                            break;
                        }
                    case "Nombre":
                        {
                            valorAnteriorStr = ValorAnterior(ComboTipo.selectedValue, idSolicitudBoleta);
                            consultaEmpeñoAnterior = $"insert into ActualizacionesEmpeño values('{idEmpeño}','{DateTime.Now.ToString("yyyy-MM-dd")}','{tiempo}','{ComboTipo.selectedValue}','{valorAnteriorStr}','{txtValor.Text}','{txtMotivo.Text}')";
                            break;
                        }
                    case "CURP":
                        {
                            valorAnteriorStr = ValorAnterior(ComboTipo.selectedValue, idSolicitudBoleta);
                            consultaEmpeñoAnterior = $"insert into ActualizacionesEmpeño values('{idEmpeño}','{DateTime.Now.ToString("yyyy-MM-dd")}','{tiempo}','{ComboTipo.selectedValue}','{valorAnteriorStr}','{txtValor.Text}','{txtMotivo.Text}')";
                            break;
                        }
                    case "INE":
                        {
                            valorAnteriorStr = ValorAnterior(ComboTipo.selectedValue, idSolicitudBoleta);
                            consultaEmpeñoAnterior = $"insert into ActualizacionesEmpeño values('{idEmpeño}','{DateTime.Now.ToString("yyyy-MM-dd")}','{tiempo}','{ComboTipo.selectedValue}','{valorAnteriorStr}','{txtValor.Text}','{txtMotivo.Text}')";
                            break;
                        }
                }
                // consultaLegalAnterior = "insert into ActualizacionLegal values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & ComboTipo.selectedValue & "','" &  & "')"
                comandoEmpeñoAnterior = new SqlCommand();
                comandoEmpeñoAnterior.Connection = Module1.conexionempresa;
                comandoEmpeñoAnterior.CommandText = consultaEmpeñoAnterior;
                comandoEmpeñoAnterior.ExecuteNonQuery();


                SqlCommand comandoAct;
                comandoAct = new SqlCommand();
                comandoAct.Connection = Module1.conexionempresa;
                comandoAct.CommandText = consultaActualizacion;
                comandoAct.ExecuteNonQuery();
            }

            catch (Exception a)
            {
                newCargando.Close();
                MessageBox.Show(a.ToString());
            }

        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMotivo.Text))
            {
                newCargando = new Cargando();
                newCargando.Show();
                newCargando.MonoFlat_Label1.Text = "Actualizando Información...";
                newCargando.TopMost = true;
                BackgroundActualizacion.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("El campo de motivo es obligatorio");
            }
        }

        private void BackgroundActualizacion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            newCargando.Close();
            Close();
        }

        private string ObteneridDatosSolicitud(string Nombre)
        {
            string datosSolicitudId ="";
            foreach (DataRow row in datosSolicitud.Rows)
            {
                if ((row["nombre"].ToString() ?? "") == (Nombre ?? ""))
                {
                    datosSolicitudId = Conversions.ToString(row["id"]);
                    break;
                }
            }
            return datosSolicitudId;
        }


        private string ValorAnterior(string campo, string aquien)
        {
            string retorno="";
            foreach (DataRow row in datosSolicitud.Rows)
            {
                bool exitFor = false;
                bool exitFor1 = false;
                bool exitFor2 = false;
                bool exitFor3 = false;
                bool exitFor4 = false;
                switch (campo ?? "")
                {

                    case "Domicilio":
                        {
                            if ((row["id"].ToString() ?? "") == (aquien ?? ""))
                            {
                                retorno = row["Domicilio"].ToString();
                                exitFor = true;
                                break;
                            }

                            break;
                        }
                    case "Número de Teléfono":
                        {
                            if ((row["id"].ToString() ?? "") == (aquien ?? ""))
                            {
                                retorno = row["Telefono"].ToString();
                                exitFor1 = true;
                                break;
                            }

                            break;
                        }
                    case "Nombre":
                        {
                            if ((row["id"].ToString() ?? "") == (aquien ?? ""))
                            {
                                retorno = row["Nombre"].ToString();
                                exitFor2 = true;
                                break;
                            }

                            break;
                        }
                    case "CURP":
                        {
                            if ((row["id"].ToString() ?? "") == (aquien ?? ""))
                            {
                                retorno = row["CURP"].ToString();
                                exitFor3 = true;
                                break;
                            }

                            break;
                        }
                    case "INE":
                        {
                            if ((row["id"].ToString() ?? "") == (aquien ?? ""))
                            {
                                retorno = row["INE"].ToString();
                                exitFor4 = true;
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
            }
            return retorno;
        }
    }
}