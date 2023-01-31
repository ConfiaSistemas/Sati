using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class DatosConsultaSolicitud
    {
        public int idSolicitud;
        public int idDatosSolicitud;
        private int edad;
        private DataTable dataCliente;
        private SqlDataAdapter adapterCliente;
        private int pendientes = 0;
        private int rechazados = 0;
        private int Aprobados = 0;
        private DataTable dataDatos;
        private SqlDataAdapter adapterDatos;
        private string estadoDatosSolicitud;
        private DataTable dataDocumentos;
        private SqlDataAdapter adapterDocumentos;
        private double montoAutorizadoTotal;
        private DataTable dataSolicitud;
        private SqlDataAdapter adapterSolicitud;
        private string nombreSolicitud;
        private double montoSolicitud;
        private int TipoSolicitud;
        private int PlazoSolicitud;
        private double InteresSolicitud;
        private int idClienteSolicitud;
        private int idGestorSolicitud;
        private int idPromotorSolicitud;
        private string modalidadSolicitud;

        public DatosConsultaSolicitud()
        {
            InitializeComponent();
        }
        private void DatosSolicitud_Load(object sender, EventArgs e)
        {
            // Me.Height = 1600
            // Me.Width = 1600
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Datos";
            dtdatos.ScrollBars = ScrollBars.None;
            BackgroundWorker1.RunWorkerAsync();
        }
        public int calcularEdad(DateTime nacimiento)
        {
            int edad;
            edad = DateTime.Today.Year - nacimiento.Year;
            if (nacimiento > DateTime.Today.AddYears(-edad))
                edad -= 1;
            return edad;
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            SqlCommand comandoDatosSolicitud;
            string consultaDatosSolicitud;
            SqlDataReader readerDatosSolicitud;
            consultaDatosSolicitud = "select datosSolicitud.id,datosSolicitud.idCliente,(clientes.nombre +' '+clientes.ApellidoPaterno+' '+clientes.ApellidoMaterno) as nombrecompleto,clientes.nombre,clientes.ApellidoPaterno,clientes.ApellidoMaterno,clientes.FechaNacimiento,clientes.Telefono,clientes.Celular,datosSolicitud.estado,datosSolicitud.MontoAutorizado from datosSolicitud inner join clientes on datosSolicitud.idCliente = clientes.id where datosSolicitud.idSolicitud = '" + idSolicitud + "'";
            comandoDatosSolicitud = new SqlCommand();
            comandoDatosSolicitud.Connection = Module1.conexionempresa;
            comandoDatosSolicitud.CommandText = consultaDatosSolicitud;
            readerDatosSolicitud = comandoDatosSolicitud.ExecuteReader();
            while (readerDatosSolicitud.Read())




                dtdatos.Rows.Add(readerDatosSolicitud["id"], readerDatosSolicitud["idCliente"], readerDatosSolicitud["nombrecompleto"], readerDatosSolicitud["estado"], readerDatosSolicitud["MontoAutorizado"]);
            readerDatosSolicitud.Close();
            adapterCliente = new SqlDataAdapter(consultaDatosSolicitud, Module1.conexionempresa);
            dataCliente = new DataTable();
            adapterCliente.Fill(dataCliente);

            string consultaSolicitud;
            SqlCommand comandoSolicitud;
            SqlDataReader readerSolicitud;

            consultaSolicitud = "select solicitud.nombre,solicitud.Monto,solicitud.Tipo,solicitud.Plazo,solicitud.Interes,PagoIndividual,Integrantes,IdCliente,IdPromotor,IdGestor,TiposDeCredito.Modalidad From solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.id = '" + idSolicitud + "'";
            comandoSolicitud = new SqlCommand();
            comandoSolicitud.Connection = Module1.conexionempresa;
            comandoSolicitud.CommandText = consultaSolicitud;
            readerSolicitud = comandoSolicitud.ExecuteReader();
            while (readerSolicitud.Read())
            {
                nombreSolicitud = Conversions.ToString(readerSolicitud["nombre"]);
                TipoSolicitud = Conversions.ToInteger(readerSolicitud["Tipo"]);
                PlazoSolicitud = Conversions.ToInteger(readerSolicitud["Plazo"]);
                InteresSolicitud = Conversions.ToDouble(readerSolicitud["Interes"]);
                idClienteSolicitud = Conversions.ToInteger(readerSolicitud["IdCliente"]);
                idPromotorSolicitud = Conversions.ToInteger(readerSolicitud["IdPromotor"]);
                idGestorSolicitud = Conversions.ToInteger(readerSolicitud["IdGestor"]);
                modalidadSolicitud = Conversions.ToString(readerSolicitud["Modalidad"]);
            }




        }

        private void ConsultarCliente(string idCliente)
        {


            foreach (DataRow row in dataDatos.Rows)
            {
                if ((row["idCliente"].ToString() ?? "") == (idCliente ?? ""))
                {
                    txtnombre.Text = row["Nombre"].ToString();

                    txtApellidoP.Text = row["ApellidoPaterno"].ToString();
                    txtApellidoM.Text = row["ApellidoMaterno"].ToString();
                    txtEdad.Text = row["Edad"].ToString();
                    txtTelefono.Text = row["Telefono"].ToString();
                    txtCelular.Text = row["Celular"].ToString();
                    TxtCasaDondeVive.Text = row["CasaDondeViveEs"].ToString();
                    txtTiempoDomicilio.Text = row["TiempoEnDomicilio"].ToString();
                    txtCalle.Text = row["Calle"].ToString();
                    txtNoExterior.Text = row["Noext"].ToString();
                    txtNoInterior.Text = row["Noint"].ToString();
                    txtCodigoPostal.Text = row["CodigoPostal"].ToString();
                    txtEntreCalles.Text = row["EntreCalles"].ToString();
                    txtColonia.Text = row["Colonia"].ToString();
                    txtCiudad.Text = row["Ciudad"].ToString();
                    txtEstado.Text = row["EstadoCliente"].ToString();
                    txtdatosConyuge.Text = row["Conyuge"].ToString();
                    txtRelacionConyuge.Text = row["RelacionConyuge"].ToString();
                    txtNombreLugarTrabajo.Text = row["DondeTrabaja"].ToString();
                    txtSeDedica.Text = row["SeDedica"].ToString();
                    txtVende.Text = row["QueVende"].ToString();
                    txtAntiguedad.Text = row["Antiguedad"].ToString();
                    txtHorariosTrabajo.Text = row["Horarios"].ToString();
                    txtTipoEstablecimiento.Text = row["TipoEstablecimiento"].ToString();
                    txtIngresoPromedio.Text = row["IngresoPmensual"].ToString();
                    txtFrecuenciaCobro.Text = row["FrecuenciaCobro"].ToString();
                    txtCalleTrabajo.Text = row["CalleTrabajo"].ToString();
                    txtNoExteriorTrabajo.Text = row["NoextTrabajo"].ToString();
                    txtNoInteriorTrabajo.Text = row["NointTrabajo"].ToString();
                    txtCodigoPostalTrabajo.Text = row["CodigoPostalTrabajo"].ToString();
                    txtJefeDirecto.Text = row["JefeDirecto"].ToString();
                    txtColoniaTrabajo.Text = row["ColoniaTrabajo"].ToString();
                    txtTelefonoTrabajo.Text = row["TelefonoTrabajo"].ToString();
                    txtObjetivo.Text = row["Objetivo"].ToString();
                    txtNombreR1.Text = row["NombreR1"].ToString();
                    txtTelefonoR1.Text = row["TelefonoR1"].ToString();
                    txtRelacionR1.Text = row["RelacionR1"].ToString();
                    txtCodigoPostalR1.Text = row["CodigoPostalR1"].ToString();
                    txtColoniaR1.Text = row["ColoniaR1"].ToString();

                    txtCalleR1.Text = row["CalleR1"].ToString();
                    txtNoExtR1.Text = row["NoExtR1"].ToString();
                    txtNoIntR1.Text = row["NoIntR1"].ToString();

                    txtNombreR2.Text = row["NombreR2"].ToString();
                    txtTelefonoR2.Text = row["TelefonoR2"].ToString();
                    txtRelacionR2.Text = row["RelacionR2"].ToString();
                    txtCodigoPostalR2.Text = row["CodigoPostalR2"].ToString();
                    txtColoniaR2.Text = row["ColoniaR2"].ToString();
                    txtCalleR2.Text = row["CalleR2"].ToString();
                    txtNoExtR2.Text = row["NoExtR2"].ToString();
                    txtNoIntR2.Text = row["NoIntR2"].ToString();

                    txtEnfermedad.Text = row["Enfermedad"].ToString();
                    txtFamiliasEnCasa.Text = row["FamiliasEnCasa"].ToString();
                    txtDeudas.Text = row["DeudasCon"].ToString();
                    txtServicios.Text = row["Servicios"].ToString();
                    txtPersonasDependientes.Text = row["PersonasDependientes"].ToString();
                    txtEmpleados.Text = row["Empleados"].ToString();
                    txtFrecuenciaInversion.Text = row["FrecuenciaInversion"].ToString();
                    txtObservacionesDomicilio.Text = row["ObservacionesDomicilio"].ToString();
                    txtHorarioVerificacion.Text = row["HorarioVerificacion"].ToString();
                    txtComentarios.Text = row["Comentarios"].ToString();
                    txtMontoAutorizado.Text = Strings.FormatCurrency(row["MontoAutorizado"].ToString());

                    txtMontoVerificacion.Text = Strings.FormatCurrency(row["MontoVerificacion"].ToString());
                    txtMontoSolicitado.Text = Strings.FormatCurrency(row["Monto"].ToString());
                    txtComentariosVerificacion.Text = row["ComentariosVerificacion"].ToString();
                    txtHijos.Text = row["Hijos"].ToString();
                    txtColoniaReal.Text = row["ColoniaReal"].ToString();
                    txtDomicilioAlterno.Text = row["DomicilioAlterno"].ToString();
                    txtTelefonoConyuge.Text = row["TelefonoConyuge"].ToString();
                    txtOcupacionConyuge.Text = row["OcupacionConyuge"].ToString();
                    txtMontoAutorizadoMaximo.Text = row["MontoMaximoAutorizado"].ToString();

                    break;
                }
            }

            BackgroundDocumentos.RunWorkerAsync();



        }

        private void dtdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtdatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Información";
            My.MyProject.Forms.Cargando.TopMost = true;
            idDatosSolicitud = Conversions.ToInteger(dtdatos.CurrentRow.Cells[0].Value);
            ConsultarCliente(Conversions.ToString(dtdatos.CurrentRow.Cells[1].Value));




        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtdatos.ScrollBars = ScrollBars.Both;
            BackgroundDatosSolicitud.RunWorkerAsync();
        }

        private void btn_Procesar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Registrando Captura";
            BackgroundAct.RunWorkerAsync();
        }

        private void BackgroundAct_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();


            SqlCommand comandoActDatos;
            string consultaActDatos="";
            switch (estadoDatosSolicitud ?? "")
            {
                case "A":
                    {
                        consultaActDatos = "update DatosSolicitud set Comentarios = '" + txtComentarios.Text + "',estado = '" + estadoDatosSolicitud + "', MontoAutorizado = '" + txtMontoAutorizado.Text + "' where id = '" + idDatosSolicitud + "'";
                        break;
                    }
                case "R":
                    {
                        consultaActDatos = "update DatosSolicitud set Comentarios = '" + txtComentarios.Text + "',estado = '" + estadoDatosSolicitud + "', MontoAutorizado = 0 where id = '" + idDatosSolicitud + "'";
                        break;
                    }

            }
            comandoActDatos = new SqlCommand();
            // Dim croquis As New SqlParameter("@Croquis", SqlDbType.Image)
            // Dim mscroquis As New MemoryStream
            // img_croquis.Image.Save(mscroquis, ImageFormat.Jpeg)
            // croquis.Value = mscroquis.GetBuffer
            comandoActDatos.Connection = Module1.conexionempresa;
            comandoActDatos.CommandText = consultaActDatos;
            // comandoActDatos.Parameters.Add(croquis)
            comandoActDatos.ExecuteNonQuery();


            // ActDatosTabla()

        }
        private void ActDatosTabla()
        {
            pendientes = 0;
            rechazados = 0;
            Aprobados = 0;
            montoAutorizadoTotal = 0d;
            dtdatos.Rows.Clear();
            Module1.iniciarconexionempresa();
            SqlCommand comandoDatosSolicitud;
            string consultaDatosSolicitud;
            SqlDataReader readerDatosSolicitud;
            consultaDatosSolicitud = "select datosSolicitud.id,datosSolicitud.idCliente,(clientes.nombre +' '+clientes.ApellidoPaterno+' '+clientes.ApellidoMaterno) as nombrecompleto,clientes.nombre,clientes.ApellidoPaterno,clientes.ApellidoMaterno,clientes.FechaNacimiento,clientes.Telefono,clientes.Celular,datosSolicitud.estado,datosSolicitud.MontoAutorizado from datosSolicitud inner join clientes on datosSolicitud.idCliente = clientes.id where datosSolicitud.idSolicitud = '" + idSolicitud + "'";
            comandoDatosSolicitud = new SqlCommand();
            comandoDatosSolicitud.Connection = Module1.conexionempresa;
            comandoDatosSolicitud.CommandText = consultaDatosSolicitud;
            readerDatosSolicitud = comandoDatosSolicitud.ExecuteReader();
            while (readerDatosSolicitud.Read())
            {
                switch (readerDatosSolicitud["Estado"])
                {
                    case "V":
                        {
                            pendientes += 1;
                            break;
                        }
                    case "R":
                        {
                            rechazados += 1;
                            break;
                        }
                    case "A":
                        {
                            Aprobados += 1;
                            break;
                        }
                }
                dtdatos.Rows.Add(readerDatosSolicitud["id"], readerDatosSolicitud["idCliente"], readerDatosSolicitud["nombrecompleto"], readerDatosSolicitud["estado"], readerDatosSolicitud["MontoAutorizado"]);
                montoAutorizadoTotal = Conversions.ToDouble(Operators.AddObject(montoAutorizadoTotal, readerDatosSolicitud["MontoAutorizado"]));
            }
            readerDatosSolicitud.Close();
            adapterCliente = new SqlDataAdapter(consultaDatosSolicitud, Module1.conexionempresa);
            dataCliente = new DataTable();
            adapterCliente.Fill(dataCliente);

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.AgregarDocumentoVerificacion.Show();
        }

        private void BackgroundDocumentosSolicitud_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();

            foreach (DataGridViewRow row in dtdatosDocumentos.Rows)
            {
                SqlCommand comandoDocumento;
                string consultaDocumento;
                Bitmap imagen = row.Cells[2].Value as Bitmap;

                consultaDocumento = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into DocumentosSolicitud values('" + idDatosSolicitud + "','", row.Cells[0].Value), "',@Documento)"));
                var imgDocumento = new SqlParameter("@Documento", SqlDbType.Image);
                var msImgDocumento = new MemoryStream();
                imagen.Save(msImgDocumento, ImageFormat.Jpeg);
                imgDocumento.Value = msImgDocumento.GetBuffer();
                comandoDocumento = new SqlCommand();
                comandoDocumento.Connection = Module1.conexionempresa;
                comandoDocumento.CommandText = consultaDocumento;
                comandoDocumento.Parameters.Add(imgDocumento);
                comandoDocumento.ExecuteNonQuery();

            }

        }

        private void BackgroundAct_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ActDatosTabla();
            My.MyProject.Forms.Cargando.Close();

            // Cargando.MonoFlat_Label1.Text = "Insertando Documentos"
            // BackgroundDocumentosSolicitud.RunWorkerAsync()
        }

        private void BackgroundDocumentosSolicitud_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ActDatosTabla();

            My.MyProject.Forms.Cargando.Close();

        }

        private void btn_a_verificacion_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Autorizando Solicitud";
            BackgroundVerificacion.RunWorkerAsync();

        }

        private void BackgroundVerificacion_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string tiempo = DateAndTime.TimeOfDay.ToString("HH:mm:ss");
            SqlCommand comandoActEstado;
            string consultaActEstado;
            consultaActEstado = "update Solicitud set estado = 'A',autorizadoPor='" + Module1.nmusr + "',montoAutorizado = '" + montoAutorizadoTotal + "' where id = '" + idSolicitud + "'";
            comandoActEstado = new SqlCommand();
            comandoActEstado.Connection = Module1.conexionempresa;
            comandoActEstado.CommandText = consultaActEstado;
            comandoActEstado.ExecuteNonQuery();


            SqlCommand comandoCredito;
            string consultaCredito;
            int idCreditoCreado;
            double pagoIndividualCredito =0;
            switch (modalidadSolicitud ?? "")
            {
                case "S":
                    {
                        pagoIndividualCredito = montoAutorizadoTotal / 1000d * InteresSolicitud;
                        break;
                    }
                case "Q":
                    {
                        pagoIndividualCredito = montoAutorizadoTotal / 1000d * InteresSolicitud * 2d;
                        break;
                    }
            }

            double PagareCredito;
            PagareCredito = pagoIndividualCredito * PlazoSolicitud;
            consultaCredito = "insert into Credito(Fecha,Hora,Nombre,Monto,Pagare,Tipo,Integrantes,PagoIndividual,Plazo,Interes,IdCliente,IdPromotor,IdGestor,IdSolicitud,Estado) values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tiempo + "','" + nombreSolicitud + "','" + montoAutorizadoTotal + "','" + PagareCredito + "','" + TipoSolicitud + "','" + Aprobados + "','" + pagoIndividualCredito + "','" + PlazoSolicitud + "','" + InteresSolicitud + "','" + idClienteSolicitud + "','" + idPromotorSolicitud + "','" + idGestorSolicitud + "','" + idSolicitud + "','E') select SCOPE_IDENTITY()";
            comandoCredito = new SqlCommand();
            comandoCredito.Connection = Module1.conexionempresa;
            comandoCredito.CommandText = consultaCredito;
            idCreditoCreado = Conversions.ToInteger(comandoCredito.ExecuteScalar());

            SqlCommand insertCronogramaSolicitud;
            string consultaInsertCronogramaSolicitud;
            consultaInsertCronogramaSolicitud = "insert into CronogramaSolicitud values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tiempo + "','" + idSolicitud + "','Se autorizó por " + Module1.nmusr + " y se creó el crédito con el id " + idCreditoCreado + "')";
            insertCronogramaSolicitud = new SqlCommand();
            insertCronogramaSolicitud.Connection = Module1.conexionempresa;
            insertCronogramaSolicitud.CommandText = consultaInsertCronogramaSolicitud;
            insertCronogramaSolicitud.ExecuteNonQuery();

        }

        private void BackgroundVerificacion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();
            Close();

        }

        private void BackgroundDatosSolicitud_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();

            string consultaDatosSolicitud;
            consultaDatosSolicitud = "select datosSolicitud.*, (clientes.nombre +' '+clientes.ApellidoPaterno+' '+clientes.ApellidoMaterno) as nombrecompleto,clientes.nombre,clientes.ApellidoPaterno,clientes.ApellidoMaterno,clientes.FechaNacimiento,clientes.Telefono,clientes.Celular from datosSolicitud inner join clientes on datosSolicitud.idCliente = clientes.id where datosSolicitud.idSolicitud = '" + idSolicitud + "'";
            adapterDatos = new SqlDataAdapter(consultaDatosSolicitud, Module1.conexionempresa);
            dataDatos = new DataTable();
            adapterDatos.Fill(dataDatos);




        }

        private void BackgroundDatosSolicitud_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();
            ActDatosTabla();
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

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void BackgroundDocumentos_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consultaDocumentos;
            consultaDocumentos = "Select DocumentosSolicitud.Tipo,TiposdeDocumentosSolicitud.Nombre,DocumentosSolicitud.Imagen from DocumentosSolicitud inner join TiposdeDocumentosSolicitud on DocumentosSolicitud.Tipo = TiposdeDocumentosSolicitud.id where idDatosSolicitud = '" + idDatosSolicitud + "'";
            adapterDocumentos = new SqlDataAdapter(consultaDocumentos, Module1.conexionempresa);
            dataDocumentos = new DataTable();
            adapterDocumentos.Fill(dataDocumentos);
        }
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            var ms = new MemoryStream(byteArrayIn);
            return Image.FromStream(ms);
        }

        private void BackgroundDocumentos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtdatosDocumentos.DataSource = dataDocumentos;
            foreach (DataGridViewColumn column in dtdatosDocumentos.Columns)
            {


                if (dtdatosDocumentos.Columns[2] is DataGridViewImageColumn) // resizes images
                {
                    ((DataGridViewImageColumn)dtdatosDocumentos.Columns[2]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                }


            }
            dtdatosDocumentos.Columns[2].Width = 200;
            My.MyProject.Forms.Cargando.TopMost = false;
            My.MyProject.Forms.Cargando.Close();
        }

        private void BackgroundRechazo_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string tiempo = DateAndTime.TimeOfDay.ToString("HH:mm:ss");
            SqlCommand comandoActEstado;
            string consultaActEstado;
            consultaActEstado = "update Solicitud set estado = 'R',autorizadoPor='" + Module1.nmusr + "',montoAutorizado = '0' where id = '" + idSolicitud + "'";
            comandoActEstado = new SqlCommand();
            comandoActEstado.Connection = Module1.conexionempresa;
            comandoActEstado.CommandText = consultaActEstado;
            comandoActEstado.ExecuteNonQuery();




            SqlCommand insertCronogramaSolicitud;
            string consultaInsertCronogramaSolicitud;
            consultaInsertCronogramaSolicitud = "insert into CronogramaSolicitud values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tiempo + "','" + idSolicitud + "','Se rechazó por " + Module1.nmusr + "')";
            insertCronogramaSolicitud = new SqlCommand();
            insertCronogramaSolicitud.Connection = Module1.conexionempresa;
            insertCronogramaSolicitud.CommandText = consultaInsertCronogramaSolicitud;
            insertCronogramaSolicitud.ExecuteNonQuery();
        }

        private void btn_rechazar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Rechazando Crédito";
            BackgroundRechazo.RunWorkerAsync();

        }

        private void BackgroundRechazo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();
            Close();

        }

        private void dtdatosDocumentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtdatosDocumentos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            My.MyProject.Forms.VistaDocumento.PictureBox1.Image = (Image)dtdatosDocumentos.Rows[dtdatosDocumentos.CurrentRow.Index].Cells[2].FormattedValue;
            My.MyProject.Forms.VistaDocumento.ShowDialog();
        }

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }

        private void TabPage5_Click(object sender, EventArgs e)
        {

        }
    }
}