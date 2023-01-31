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

    public partial class DatosVerificacion
    {
        public int idSolicitud;
        public int idDatosSolicitud;
        private int edad;
        private DataTable dataCliente;
        private SqlDataAdapter adapterCliente;
        private int pendientes = 0;
        private DataTable dataDatos;
        private SqlDataAdapter adapterDatos;
        private string estadoDatosSolicitud;
        private DataTable dataDocumentos;
        private SqlDataAdapter adapterDocumentos;
        public int tipoSolicitud;
        public bool DocumentosCapturados;
        private bool DatosCapturados;
        public bool autorizado;

        public DatosVerificacion()
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
            consultaDatosSolicitud = "select datosSolicitud.id,datosSolicitud.idCliente,(clientes.nombre +' '+clientes.ApellidoPaterno+' '+clientes.ApellidoMaterno) as nombrecompleto,clientes.nombre,clientes.ApellidoPaterno,clientes.ApellidoMaterno,clientes.FechaNacimiento,clientes.Telefono,clientes.Celular,datosSolicitud.estado from datosSolicitud inner join clientes on datosSolicitud.idCliente = clientes.id where datosSolicitud.idSolicitud = '" + idSolicitud + "'";
            comandoDatosSolicitud = new SqlCommand();
            comandoDatosSolicitud.Connection = Module1.conexionempresa;
            comandoDatosSolicitud.CommandText = consultaDatosSolicitud;
            readerDatosSolicitud = comandoDatosSolicitud.ExecuteReader();
            while (readerDatosSolicitud.Read())
            {
                switch (readerDatosSolicitud["estado"])
                {
                    case "E":
                        {
                            dtdatos.Rows.Add(readerDatosSolicitud["id"], readerDatosSolicitud["idCliente"], readerDatosSolicitud["nombrecompleto"], "No");
                            break;
                        }
                    case "V":
                        {
                            dtdatos.Rows.Add(readerDatosSolicitud["id"], readerDatosSolicitud["idCliente"], readerDatosSolicitud["nombrecompleto"], "Sí");
                            break;
                        }
                    case "R":
                        {
                            dtdatos.Rows.Add(readerDatosSolicitud["id"], readerDatosSolicitud["idCliente"], readerDatosSolicitud["nombrecompleto"], "Sí");
                            break;
                        }
                }

            }
            readerDatosSolicitud.Close();
            adapterCliente = new SqlDataAdapter(consultaDatosSolicitud, Module1.conexionempresa);
            dataCliente = new DataTable();
            adapterCliente.Fill(dataCliente);

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
                    txtMontoSolicitado.Text = row["Monto"].ToString();
                    txtMontoVerificacion.Text = row["Monto"].ToString();
                    txtHijos.Text = row["Hijos"].ToString();
                    txtColoniaReal.Text = row["ColoniaReal"].ToString();
                    txtDomicilioAlterno.Text = row["DomicilioAlterno"].ToString();
                    txtTelefonoConyuge.Text = row["TelefonoConyuge"].ToString();
                    txtOcupacionConyuge.Text = row["OcupacionConyuge"].ToString();
                    txtMontoMaximoAutorizado.Text = row["MontoMaximo"].ToString();

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
            if (Operators.CompareString(txtMontoVerificacion.Text, txtMontoMaximoAutorizado.Text, false) > 0)
            {
                MessageBox.Show("El monto autorizado no puede ser mayor a monto autorizado máximo");
            }
            else
            {
                foreach (DataRow row in Module1.dataPermisos.Rows)
                {
                    if (Conversions.ToBoolean(row["SatiModSolicitudesModificar"]))
                    {
                        My.MyProject.Forms.Cargando.Show();
                        My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Registrando Captura";
                        BackgroundAct.RunWorkerAsync();
                        break;
                    }
                    else
                    {

                    }
                }

            }

        }

        private void BackgroundAct_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();


            SqlCommand comandoActDatos;
            string consultaActDatos;
            consultaActDatos = "update DatosSolicitud set ComentariosVerificacion = '" + txtComentarios.Text + "', MontoVerificacion = '" + txtMontoVerificacion.Text + "',MontoMaximoAutorizado = '" + txtMontoMaximoAutorizado.Text + "' where id = '" + idDatosSolicitud + "'";
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
            dtdatos.Rows.Clear();
            Module1.iniciarconexionempresa();
            SqlCommand comandoDatosSolicitud;
            string consultaDatosSolicitud;
            SqlDataReader readerDatosSolicitud;
            consultaDatosSolicitud = "select datosSolicitud.id,datosSolicitud.idCliente,(clientes.nombre +' '+clientes.ApellidoPaterno+' '+clientes.ApellidoMaterno) as nombrecompleto,clientes.nombre,clientes.ApellidoPaterno,clientes.ApellidoMaterno,clientes.FechaNacimiento,clientes.Telefono,clientes.Celular,datosSolicitud.estado from datosSolicitud inner join clientes on datosSolicitud.idCliente = clientes.id where datosSolicitud.idSolicitud = '" + idSolicitud + "'";
            comandoDatosSolicitud = new SqlCommand();
            comandoDatosSolicitud.Connection = Module1.conexionempresa;
            comandoDatosSolicitud.CommandText = consultaDatosSolicitud;
            readerDatosSolicitud = comandoDatosSolicitud.ExecuteReader();
            while (readerDatosSolicitud.Read())
            {
                switch (readerDatosSolicitud["estado"])
                {
                    case "E":
                        {
                            dtdatos.Rows.Add(readerDatosSolicitud["id"], readerDatosSolicitud["idCliente"], readerDatosSolicitud["nombrecompleto"], "No");
                            pendientes += 1;
                            break;
                        }
                    case "V":
                        {
                            dtdatos.Rows.Add(readerDatosSolicitud["id"], readerDatosSolicitud["idCliente"], readerDatosSolicitud["nombrecompleto"], "Sí");
                            break;
                        }
                    case "R":
                        {
                            dtdatos.Rows.Add(readerDatosSolicitud["id"], readerDatosSolicitud["idCliente"], readerDatosSolicitud["nombrecompleto"], "Sí");
                            break;
                        }
                }

            }
            readerDatosSolicitud.Close();
            adapterCliente = new SqlDataAdapter(consultaDatosSolicitud, Module1.conexionempresa);
            dataCliente = new DataTable();
            adapterCliente.Fill(dataCliente);
            if (pendientes == 0)
            {
                btn_a_verificacion.Visible = true;
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.AgregarDocumentoVerificacion.Show();
        }

        private void BackgroundDocumentosSolicitud_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();

            foreach (DataGridViewRow row in dtdatosDocumentosNuevos.Rows)
            {
                SqlCommand comandoDocumento;
                string consultaDocumento;
                Bitmap imagen = row.Cells[2].Value as Bitmap;
                var NuevaImagen = ImagenComprimida(imagen);
                consultaDocumento = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into DocumentosSolicitud values('" + idDatosSolicitud + "','", row.Cells[0].Value), "',@Documento)"));
                var imgDocumento = new SqlParameter("@Documento", SqlDbType.Image);
                var msImgDocumento = new MemoryStream();
                NuevaImagen.Save(msImgDocumento, ImageFormat.Jpeg);
                imgDocumento.Value = msImgDocumento.GetBuffer();
                comandoDocumento = new SqlCommand();
                comandoDocumento.Connection = Module1.conexionempresa;
                comandoDocumento.CommandText = consultaDocumento;
                comandoDocumento.Parameters.Add(imgDocumento);
                comandoDocumento.ExecuteNonQuery();

            }

        }
        private Bitmap ImagenComprimida(Bitmap bmp)
        {
            try
            {

                int Width = bmp.Width;
                int Height = bmp.Height;
                // next we declare the maximum size of the resized image. 
                // In this case, all resized images need to be constrained to a 173x173 square.
                int Heightmax = 1572;
                int Widthmax = 1826;
                // declare the minimum value af the resizing factor before proceeding. 
                // All images with a lower factor than this will actually be resized
                decimal Factorlimit = 1m;
                // determine if it is a portrait or landscape image
                decimal Relative = (decimal)(Height / (double)Width);
                decimal Factor;
                // if the image is a portrait image, calculate the resizing factor based on its height. 
                // else the image is a landscape image, 
                // and we calculate the resizing factor based on its width.
                if (Relative > 1m)
                {
                    if (Height < Heightmax + 1)
                    {
                        Factor = 1m;
                    }
                    else
                    {
                        Factor = (decimal)(Heightmax / (double)Height);
                    }
                }
                // 
                else if (Width < Widthmax + 1)
                {
                    Factor = 1m;
                }
                else
                {
                    Factor = (decimal)(Widthmax / (double)Width);
                }
                if (Factor < Factorlimit)
                {
                    // draw a new image with the dimensions that result from the resizing
                    var bmpnew = new Bitmap((int)Math.Round(bmp.Width * Factor), (int)Math.Round(bmp.Height * Factor), PixelFormat.Format24bppRgb);
                    var g = Graphics.FromImage(bmpnew);
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    // and paste the resized image into it
                    g.DrawImage(bmp, 0, 0, bmpnew.Width, bmpnew.Height);
                    return bmpnew;
                }
                else
                {
                    return bmp;
                }
            }

            catch (Exception ex)
            {
                return null;
                MessageBox.Show(ex.Message);
            }

            
        }


        private void BackgroundAct_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Insertando Documentos";
            BackgroundDocumentosSolicitud.RunWorkerAsync();
        }

        private void BackgroundDocumentosSolicitud_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            VerificaDatos();
            if (DatosCapturados == true)
            {
                BackgroundCargaDocumentos.RunWorkerAsync();
            }

            // BackgroundWorker2.RunWorkerAsync()
            else
            {
                MessageBox.Show("Faltan datos por capturar");
            }
        }

        private void btn_a_verificacion_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Autorizacion.tipoAutorizacion = "SatiModSolicitudesVerificar";
            My.MyProject.Forms.Autorizacion.ShowDialog();
            if (autorizado)
            {
                My.MyProject.Forms.Cargando.Show();
                My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Enviando a autorización";
                BackgroundVerificacion.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("No fue autorizado");
            }



        }

        private void BackgroundVerificacion_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string tiempo = DateAndTime.TimeOfDay.ToString("HH:mm:ss");
            SqlCommand comandoActEstado;
            string consultaActEstado;
            consultaActEstado = "update Solicitud set estado = 'V' where id = '" + idSolicitud + "'";
            comandoActEstado = new SqlCommand();
            comandoActEstado.Connection = Module1.conexionempresa;
            comandoActEstado.CommandText = consultaActEstado;
            comandoActEstado.ExecuteNonQuery();



            SqlCommand insertCronogramaSolicitud;
            string consultaInsertCronogramaSolicitud;
            consultaInsertCronogramaSolicitud = "insert into CronogramaSolicitud values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tiempo + "','" + idSolicitud + "','Se envió a autorización por " + Module1.nmusr + "')";
            insertCronogramaSolicitud = new SqlCommand();
            insertCronogramaSolicitud.Connection = Module1.conexionempresa;
            insertCronogramaSolicitud.CommandText = consultaInsertCronogramaSolicitud;
            insertCronogramaSolicitud.ExecuteNonQuery();

        }

        private void BackgroundVerificacion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();

            Invoke(new Action(() => My.MyProject.Forms.Solicitudes.cargarSolicitudes()));
            Close();

        }

        private void BackgroundDatosSolicitud_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();

            string consultaDatosSolicitud;
            consultaDatosSolicitud = @"select datos.*,ISNULL((select top 1 MontoMaximoAutorizado from DatosSolicitud inner join Solicitud on DatosSolicitud.IdSolicitud = Solicitud.id where datossolicitud.IdCliente =Datos.idCliente order by Fecha asc),0) as MontoMaximo from
(select datosSolicitud.*, (clientes.nombre +' '+clientes.ApellidoPaterno+' '+clientes.ApellidoMaterno) as nombrecompleto,clientes.nombre,clientes.ApellidoPaterno,clientes.ApellidoMaterno,clientes.FechaNacimiento from datosSolicitud inner join clientes on datosSolicitud.idCliente = clientes.id where datosSolicitud.idSolicitud = '" + idSolicitud + "') datos";
            adapterDatos = new SqlDataAdapter(consultaDatosSolicitud, Module1.conexionempresa);
            dataDatos = new DataTable();
            adapterDatos.Fill(dataDatos);
        }

        private void BackgroundDatosSolicitud_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();
        }

        private void RadioVerificado_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioVerificado.Checked)
            {
                estadoDatosSolicitud = "V";
            }
        }

        private void RadioRechazado_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioRechazado.Checked)
            {
                estadoDatosSolicitud = "R";
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
            BackgroundWorker2.RunWorkerAsync();
        }

        private void BackgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Invoke(new Action(() =>
                {
                    int num_controles = FlowLayoutPanel1.Controls.Count - 1;
                    for (int n = num_controles; n >= 0; n -= 1)
                    {
                        var ctrl = FlowLayoutPanel1.Controls[n];
                        FlowLayoutPanel1.Controls.Remove(ctrl);
                        ctrl.Dispose();
                    }
                    try
                    {
                        Module1.iniciarconexion();
                        string sql;
                        SqlCommand comando;

                        SqlDataReader milector;
                        comando = new SqlCommand();

                        comando.Connection = Module1.conexionempresa;
                        sql = "select ajas.idTipo,ajas.Nombre,case when (select top 1 Tipo from DocumentosSolicitud where Tipo = ajas.idTipo and DocumentosSolicitud.IdDatosSolicitud = '" + idDatosSolicitud + @"') IS  null then 0 else 1 end as Cargado from
(select DocumentosNecesariosTipo.idTipo,TiposdeDocumentosSolicitud.Nombre from DocumentosNecesariosTipo inner join TiposdeDocumentosSolicitud on DocumentosNecesariosTipo.idTipo = TiposdeDocumentosSolicitud.id where idTipoCredito = '" + tipoSolicitud + "' and TiposdeDocumentosSolicitud.Tipo = 'V') ajas";
                        comando.CommandText = sql;
                        milector = comando.ExecuteReader();
                        while (milector.Read())
                        {
                            var checkTipo = new CheckBox();

                            checkTipo.ForeColor = Color.FromKnownColor(KnownColor.Window);
                            checkTipo.Name = Conversions.ToString(milector["idtipo"]);
                            checkTipo.Text = Conversions.ToString(milector["nombre"]);
                            checkTipo.CheckState = (CheckState)milector["Cargado"];
                            checkTipo.AutoSize = true;

                            checkTipo.Enabled = false;

                        // checkTipo.Tag = milector("ip")

                        FlowLayoutPanel1.Controls.Add(checkTipo);
                        }
                        milector.Close();
                    }
                    catch (Exception ex)
                    {

                    }
                // 

            }));


        }

        private void BackgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            My.MyProject.Forms.Cargando.TopMost = false;
            My.MyProject.Forms.Cargando.Close();
        }

        private void BackgroundCargaDocumentos_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consultaDocumentos;
            consultaDocumentos = "Select DocumentosSolicitud.Tipo,TiposdeDocumentosSolicitud.Nombre,DocumentosSolicitud.Imagen from DocumentosSolicitud inner join TiposdeDocumentosSolicitud on DocumentosSolicitud.Tipo = TiposdeDocumentosSolicitud.id where idDatosSolicitud = '" + idDatosSolicitud + "'";
            adapterDocumentos = new SqlDataAdapter(consultaDocumentos, Module1.conexionempresa);
            dataDocumentos = new DataTable();
            adapterDocumentos.Fill(dataDocumentos);
        }

        private void BackgroundCargaDocumentos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
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
            dtdatosDocumentosNuevos.Rows.Clear();
            BackgroundVerificaDocumentos.RunWorkerAsync();
        }

        private void BackgroundVerificaDocumentos_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Invoke(new Action(() =>
                {
                    int num_controles = FlowLayoutPanel1.Controls.Count - 1;
                    for (int n = num_controles; n >= 0; n -= 1)
                    {
                        var ctrl = FlowLayoutPanel1.Controls[n];
                        FlowLayoutPanel1.Controls.Remove(ctrl);
                        ctrl.Dispose();
                    }
                    try
                    {
                        Module1.iniciarconexion();
                        string sql;
                        SqlCommand comando;

                        SqlDataReader milector;
                        comando = new SqlCommand();

                        comando.Connection = Module1.conexionempresa;
                        sql = "select ajas.idTipo,ajas.Nombre,case when (select top 1 Tipo from DocumentosSolicitud where Tipo = ajas.idTipo and DocumentosSolicitud.IdDatosSolicitud = '" + idDatosSolicitud + @"') IS  null then 0 else 1 end as Cargado from
(select DocumentosNecesariosTipo.idTipo,TiposdeDocumentosSolicitud.Nombre from DocumentosNecesariosTipo inner join TiposdeDocumentosSolicitud on DocumentosNecesariosTipo.idTipo = TiposdeDocumentosSolicitud.id where idTipoCredito = '" + tipoSolicitud + "' and TiposdeDocumentosSolicitud.Tipo = 'V') ajas";
                        comando.CommandText = sql;
                        milector = comando.ExecuteReader();
                        while (milector.Read())
                        {
                            var checkTipo = new CheckBox();

                            checkTipo.ForeColor = Color.FromKnownColor(KnownColor.Window);
                            checkTipo.Name = Conversions.ToString(milector["idtipo"]);
                            checkTipo.Text = Conversions.ToString(milector["nombre"]);
                            checkTipo.CheckState = (CheckState)milector["Cargado"];
                            checkTipo.AutoSize = true;

                            checkTipo.Enabled = false;

                        // checkTipo.Tag = milector("ip")

                        FlowLayoutPanel1.Controls.Add(checkTipo);
                        }
                        milector.Close();
                    }
                    catch (Exception ex)
                    {

                    }
                // 

            }));
        }

        private void BackgroundVerificaDocumentos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            VerificaDocumentos();
            if (DocumentosCapturados)
            {
                Module1.iniciarconexionempresa();
                SqlCommand comandoCapturaSolicitud;
                string consultaCapturaSolicitud;
                consultaCapturaSolicitud = "Update datosSolicitud set Estado = '" + estadoDatosSolicitud + "' where id = '" + idDatosSolicitud + "'";
                comandoCapturaSolicitud = new SqlCommand();
                comandoCapturaSolicitud.Connection = Module1.conexionempresa;
                comandoCapturaSolicitud.CommandText = consultaCapturaSolicitud;
                comandoCapturaSolicitud.ExecuteNonQuery();
                ActDatosTabla();
            }

            else
            {
                MessageBox.Show("Faltan Documentos por cargar");
            }
            My.MyProject.Forms.Cargando.Close();
        }

        private void VerificaDatos()
        {
            int sintexto = 0;
            foreach (Control ctrl in Controls)
            {
                if (ctrl is Bunifu.Framework.UI.BunifuMaterialTextbox)
                {
                    Bunifu.Framework.UI.BunifuMaterialTextbox txtctrl = (Bunifu.Framework.UI.BunifuMaterialTextbox)ctrl;
                    if (string.IsNullOrEmpty(txtctrl.Text))
                    {
                        sintexto += 1;

                    }
                }
            }

            if (sintexto > 0)
            {
                DatosCapturados = false;
            }
            else
            {
                DatosCapturados = true;

            }
        }


        private void VerificaDocumentos()
        {
            int sinCarga = 0;

            foreach (Control ctrl in FlowLayoutPanel1.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox ctrlcheck = (CheckBox)ctrl;
                    switch (ctrlcheck.CheckState)
                    {
                        case CheckState.Unchecked:
                            {
                                sinCarga += 1;
                                break;
                            }

                    }
                }
            }
            if (sinCarga > 0)
            {
                DocumentosCapturados = false;
            }
            else
            {
                DocumentosCapturados = true;
            }
        }

        private void dtdatosDocumentosNuevos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtdatosDocumentos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            My.MyProject.Forms.VistaDocumento.PictureBox1.Image = (Image)dtdatosDocumentos.Rows[dtdatosDocumentos.CurrentRow.Index].Cells[2].FormattedValue;
            My.MyProject.Forms.VistaDocumento.ShowDialog();
        }

        private void dtdatosDocumentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtdatosDocumentosNuevos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                dtdatosDocumentosNuevos.Rows.RemoveAt(dtdatosDocumentosNuevos.CurrentRow.Index);
            }
        }

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }

    }
}