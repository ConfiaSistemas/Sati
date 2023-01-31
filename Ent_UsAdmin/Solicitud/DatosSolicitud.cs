using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class DatosSolicitud
    {
        public int idSolicitud;
        public int idDatosSolicitud;
        public string nombreSolicitud;
        private int edad;
        private DataTable dataCliente;
        private SqlDataAdapter adapterCliente;
        private int pendientes = 0;
        private DataTable dataDatos;
        private SqlDataAdapter adapterDatos;
        private DataTable dataDocumentos;
        private SqlDataAdapter adapterDocumentos;
        public int tipoSolicitud;
        private string tipoSolicitudString;
        public bool DocumentosCapturados;
        public string correoGestor;
        public string idGestor;
        private bool DatosCapturados;
        private bool errorCorreo;

        public DatosSolicitud()
        {
            InitializeComponent();
            idDatosSolicitud = Conversions.ToInteger(dtdatos.CurrentRow.Cells[0].Value);
            ConsultarCliente(Conversions.ToString(dtdatos.CurrentRow.Cells[1].Value));
        }
        private void DatosSolicitud_Load(object sender, EventArgs e)
        {

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
                    case "P":
                        {
                            dtdatos.Rows.Add(readerDatosSolicitud["id"], readerDatosSolicitud["idCliente"], readerDatosSolicitud["nombrecompleto"], "No");
                            break;
                        }
                    case "C":
                        {
                            dtdatos.Rows.Add(readerDatosSolicitud["id"], readerDatosSolicitud["idCliente"], readerDatosSolicitud["nombrecompleto"], "Sí");
                            break;
                        }
                }

            }
            readerDatosSolicitud.Close();

            SqlCommand comandoTipo;
            string consultaTipo;
            consultaTipo = "Select tipo from tiposdecredito where id = '" + tipoSolicitud + "'";
            comandoTipo = new SqlCommand();
            comandoTipo.Connection = Module1.conexionempresa;
            comandoTipo.CommandText = consultaTipo;
            tipoSolicitudString = Conversions.ToString(comandoTipo.ExecuteScalar());


            adapterCliente = new SqlDataAdapter(consultaDatosSolicitud, Module1.conexionempresa);
            dataCliente = new DataTable();
            adapterCliente.Fill(dataCliente);

            if (string.IsNullOrEmpty(idGestor))
            {
                SqlCommand comandoIdGestor;
                string consultaIdGestor;
                consultaIdGestor = "select idgestor from solicitud where id = '" + idSolicitud + "'";
                comandoIdGestor = new SqlCommand();
                comandoIdGestor.Connection = Module1.conexionempresa;
                comandoIdGestor.CommandText = consultaIdGestor;

                idGestor = Conversions.ToString(comandoIdGestor.ExecuteScalar());

            }

            if (string.IsNullOrEmpty(correoGestor))
            {
                SqlCommand comandoCorreoGestor;
                string consultaCorreoGestor;

                consultaCorreoGestor = "select correo from empleados where id = '" + idGestor + "'";
                comandoCorreoGestor = new SqlCommand();
                comandoCorreoGestor.Connection = Module1.conexionempresa;
                comandoCorreoGestor.CommandText = consultaCorreoGestor;
                correoGestor = Conversions.ToString(comandoCorreoGestor.ExecuteScalar());

            }

            SqlCommand comandoRen;
            string consultaRen;
            SqlDataReader readerRen;
            consultaRen = @"select FechaEntrega,id,Nombre,Monto,Pagaré,Tipo,Gestor,Promotor,case when CanCreditos > 1 then 'Renovación' else 'Nuevo' end as 'Nuevo o Renovación' from
(select FechaEntrega,cred.id,cred.Nombre,format(cred.Monto,'C','es-mx') as Monto,format(cred.Pagare,'C','es-mx') as Pagaré,cred.Tipo,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,isnull((select COUNT(credito.id) from Credito inner join Solicitud on Credito.IdSolicitud = Solicitud.id inner join DatosSolicitud on DatosSolicitud.IdSolicitud = Solicitud.id where DatosSolicitud.IdCliente = cred.IdCliente and Credito.Estado <> 'E'),0) as CanCreditos from
(select FechaEntrega,Credito.id,credito.Nombre,Monto,Pagare,TiposDeCredito.Nombre as tipo,IdPromotor,IdGestor,IdCliente,Estado from Credito inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id  where Credito.Nombre = '" + nombreSolicitud + @"') cred inner join
(select * from Empleados where Tipo = 'G') Gestores on cred.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on cred.IdPromotor = Promotores.id) desembolsos";

            comandoRen = new SqlCommand();
            comandoRen.Connection = Module1.conexionempresa;
            comandoRen.CommandText = consultaRen;
            readerRen = comandoRen.ExecuteReader();
            if (readerRen.HasRows)
            {
                CheckCorreo.Checked = false;
            }
            else
            {
                CheckCorreo.Checked = true;
            }
        }

        private void ConsultarCliente(string idCliente)
        {


            // For Each row As DataRow In dataCliente.Rows
            // If row("idCliente").ToString = idCliente Then
            // txtnombre.Text = row("nombre").ToString
            // txtApellidoP.Text = row("ApellidoPaterno").ToString
            // txtApellidoM.Text = row("ApellidoMaterno").ToString
            // edad = calcularEdad(Convert.ToDateTime(row("FechaNacimiento").ToString))
            // txtEdad.Text = edad
            // txtTelefono.Text = row("Telefono").ToString
            // txtCelular.Text = row("Celular").ToString
            // Exit For
            // End If
            // Next

            foreach (DataRow row in dataDatos.Rows)
            {
                if ((row["idCliente"].ToString() ?? "") == (idCliente ?? ""))
                {
                    txtnombre.Text = row["Nombre"].ToString();

                    txtApellidoP.Text = row["ApellidoPaterno"].ToString();
                    txtApellidoM.Text = row["ApellidoMaterno"].ToString();
                    foreach (DataRow rowEdad in dataCliente.Rows)
                    {
                        if ((row["idCliente"].ToString() ?? "") == (idCliente ?? ""))
                        {
                            edad = calcularEdad(Convert.ToDateTime(row["FechaNacimiento"].ToString()));
                            txtEdad.Text = edad.ToString();
                            break;
                        }
                    }
                    // txtEdad.Text = row("Edad").ToString
                    txtTelefono.Text = row["Telefono"].ToString();
                    txtCelular.Text = row["Celular"].ToString();
                    TxtCasaDondeVive.Text = row["CasaDondeViveEs"].ToString();
                    txtTiempoDomicilio.Text = row["TiempoEnDomicilio"].ToString();
                    txtCalle.Text = row["Calle"].ToString();
                    txtNoExterior.Text = row["Noext"].ToString();
                    txtNoInterior.Text = row["Noint"].ToString();
                    txtCodigoPostal.Text = row["CodigoPostal"].ToString();
                    ConsultaColoniasPersonal();

                    txtEntreCalles.Text = row["EntreCalles"].ToString();
                    // txtColonia.Text = row("Colonia").ToString


                    ComboColonia.Text = row["Colonia"].ToString();


                    // ComboColonia.selectedValue = row("Colonia").ToString
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
                    ConsultaColoniasTrabajo();
                    txtJefeDirecto.Text = row["JefeDirecto"].ToString();
                    // txtColoniaTrabajo.Text = row("ColoniaTrabajo").ToString
                    ComboColoniaTrabajo.Text = row["ColoniaTrabajo"].ToString();
                    txtTelefonoTrabajo.Text = row["TelefonoTrabajo"].ToString();
                    txtObjetivo.Text = row["Objetivo"].ToString();
                    txtNombreR1.Text = row["NombreR1"].ToString();
                    txtTelefonoR1.Text = row["TelefonoR1"].ToString();
                    txtRelacionR1.Text = row["RelacionR1"].ToString();
                    txtCodigoPostalR1.Text = row["CodigoPostalR1"].ToString();
                    ConsultaColoniasR1();
                    txtCalleR1.Text = row["CalleR1"].ToString();
                    txtNoExtR1.Text = row["NoExtR1"].ToString();
                    txtNoIntR1.Text = row["NoIntR1"].ToString();
                    ComboColoniaR1.Text = row["ColoniaR1"].ToString();
                    txtNombreR2.Text = row["NombreR2"].ToString();
                    txtTelefonoR2.Text = row["TelefonoR2"].ToString();
                    txtRelacionR2.Text = row["RelacionR2"].ToString();
                    txtCodigoPostalR2.Text = row["CodigoPostalR2"].ToString();
                    ConsultaColoniasR2();
                    txtCalleR2.Text = row["CalleR2"].ToString();
                    txtNoExtR2.Text = row["NoExtR2"].ToString();
                    txtNoIntR2.Text = row["NoIntR2"].ToString();
                    ComboColoniaR2.Text = row["ColoniaR2"].ToString();
                    txtEnfermedad.Text = row["Enfermedad"].ToString();
                    txtFamiliasEnCasa.Text = row["FamiliasEnCasa"].ToString();
                    txtDeudas.Text = row["DeudasCon"].ToString();
                    txtServicios.Text = row["Servicios"].ToString();
                    txtPersonasDependientes.Text = row["PersonasDependientes"].ToString();
                    txtEmpleados.Text = row["Empleados"].ToString();
                    txtFrecuenciaInversion.Text = row["FrecuenciaInversion"].ToString();
                    txtObservacionesDomicilio.Text = row["ObservacionesDomicilio"].ToString();
                    txtHorarioVerificacion.Text = row["HorarioVerificacion"].ToString();
                    txtHijos.Text = row["Hijos"].ToString();
                    txtDomicilioAlterno.Text = row["DomicilioAlterno"].ToString();
                    txtColoniaReal.Text = row["ColoniaReal"].ToString();
                    txtTelefonoConyuge.Text = row["TelefonoConyuge"].ToString();
                    txtOcupacionConyuge.Text = row["OcupacionConyuge"].ToString();

                    // txtMontoAutorizado.Text = row("Monto").ToString
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

        private void BackgroundAct_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            SqlCommand comandoActDatos;
            string consultaActDatos;
            consultaActDatos = @"UPDATE [dbo].[DatosSolicitud]
   SET 
      [Edad] = '" + txtEdad.Text + @"'
      ,[Telefono] = '" + txtTelefono.Text + @"'
      ,[Celular] = '" + txtCelular.Text + @"'
      ,[TiempoEnDomicilio] =  '" + txtTiempoDomicilio.Text + @"'
      ,[Calle] =  '" + txtCalle.Text + @"'
      ,[Noext] =  '" + txtNoExterior.Text + @"'
      ,[Noint] =  '" + txtNoInterior.Text + @"'
      ,[CodigoPostal] =  '" + txtCodigoPostal.Text + @"'
      ,[Colonia] = '" + ComboColonia.Text + @"'
      ,[Ciudad] =  '" + txtCiudad.Text + @"'
      ,[EstadoCliente] =  '" + txtEstado.Text + @"'
      ,[EntreCalles] =  '" + txtEntreCalles.Text + @"'
      ,[Conyuge] =  '" + txtdatosConyuge.Text + @"'
      ,[RelacionConyuge] =  '" + txtRelacionConyuge.Text + @"'
      ,[DondeTrabaja] = '" + txtNombreLugarTrabajo.Text + @"'
      ,[SeDedica] =  '" + txtSeDedica.Text + @"'
      ,[QueVende] =  '" + txtVende.Text + @"'
      ,[Antiguedad] =  '" + txtAntiguedad.Text + @"'
      ,[Horarios] =  '" + txtHorariosTrabajo.Text + @"'
      ,[TipoEstablecimiento] =  '" + txtTipoEstablecimiento.Text + @"'
      ,[IngresoPmensual] =  '" + txtIngresoPromedio.Text + @"'
      ,[FrecuenciaCobro] = '" + txtFrecuenciaCobro.Text + @"'
      ,[CalleTrabajo] =  '" + txtCalleTrabajo.Text + @"'
      ,[NoextTrabajo] =  '" + txtNoExteriorTrabajo.Text + @"'
      ,[NointTrabajo] =  '" + txtNoInteriorTrabajo.Text + @"'
      ,[CodigoPostalTrabajo] = '" + txtCodigoPostalTrabajo.Text + @"' 
      ,[ColoniaTrabajo] =  '" + ComboColoniaTrabajo.Text + @"'
      ,[TelefonoTrabajo] =  '" + txtTelefonoTrabajo.Text + @"'
      ,[JefeDirecto] =  '" + txtJefeDirecto.Text + @"'
      ,[Objetivo] =  '" + txtObjetivo.Text + @"'
      ,[NombreR1] = '" + txtNombreR1.Text + @"'
      ,[TelefonoR1] =  '" + txtTelefonoR1.Text + @"'
      ,[RelacionR1] =  '" + txtRelacionR1.Text + @"'
      ,[CodigoPostalR1] = '" + txtCodigoPostalR1.Text + @"'
      ,[ColoniaR1] = '" + ComboColoniaR1.Text + @"'
      ,[CalleR1] =  '" + txtCalleR1.Text + @"'
      ,[NoIntR1] = '" + txtNoIntR1.Text + @"'
      ,[NoExtR1] = '" + txtNoExtR1.Text + @"'

      ,[NombreR2] =  '" + txtNombreR2.Text + @"'
      ,[TelefonoR2] =  '" + txtTelefonoR2.Text + @"'
      ,[RelacionR2] =  '" + txtRelacionR2.Text + @"'
      ,[CodigoPostalR2] = '" + txtCodigoPostalR2.Text + @"'
      ,[ColoniaR2] = '" + ComboColoniaR2.Text + @"'
      ,[CalleR2] =  '" + txtCalleR2.Text + @"'
      ,[NoIntR2] = '" + txtNoIntR2.Text + @"'
      ,[NoExtR2] = '" + txtNoExtR2.Text + @"'
      ,[Enfermedad] =  '" + txtEnfermedad.Text + @"'
      ,[FamiliasEnCasa] = '" + txtFamiliasEnCasa.Text + @"' 
      ,[DeudasCon] =  '" + txtDeudas.Text + @"'
      ,[Servicios] =  '" + txtServicios.Text + @"'
      ,[PersonasDependientes] =  '" + txtPersonasDependientes.Text + @"'
      ,[Empleados] =  '" + txtEmpleados.Text + @"'
      ,[FrecuenciaInversion] =  '" + txtFrecuenciaInversion.Text + @"'
      ,[ObservacionesDomicilio] =  '" + txtObservacionesDomicilio.Text + @"'
      ,[HorarioVerificacion] =  '" + txtHorarioVerificacion.Text + @"'
          
      ,[CasaDondeViveEs] = '" + TxtCasaDondeVive.Text + @"'
      ,[Hijos]='" + txtHijos.Text + @"'
      ,[ColoniaReal]='" + txtColoniaReal.Text + @"'
      ,[TelefonoConyuge]='" + txtTelefonoConyuge.Text + @"'
      ,[OcupacionConyuge]='" + txtOcupacionConyuge.Text + @"'
      ,[DomicilioAlterno]='" + txtDomicilioAlterno.Text + @"'
 WHERE ID = '" + idDatosSolicitud + "'";
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
                    case "P":
                        {
                            dtdatos.Rows.Add(readerDatosSolicitud["id"], readerDatosSolicitud["idCliente"], readerDatosSolicitud["nombrecompleto"], "No");
                            pendientes += 1;
                            break;
                        }
                    case "C":
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
                if (tipoSolicitudString == "L")
                {
                    btnActivarLegal.Visible = true;
                }
                else
                {
                    btn_a_verificacion.Visible = true;
                }

            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.AgregarDocumentoDatosSolicitud.Show();
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
            // ActDatosTabla()

            // Cargando.Close()

            if (VerificaDatos() == true)
            {
                BackgroundCargaDocumentos.RunWorkerAsync();
            }

            // BackgroundWorker2.RunWorkerAsync()
            else
            {
                MessageBox.Show("Faltan datos por capturar");
                My.MyProject.Forms.Cargando.Close();
            }
        }

        private void btn_a_verificacion_Click(object sender, EventArgs e)
        {
            if (CheckCorreo.Checked)
            {
                My.MyProject.Forms.Cargando.Show();
                My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Enviando correo";

                BackgroundCorreo.RunWorkerAsync();
            }
            else
            {
                My.MyProject.Forms.Cargando.Show();
                My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Enviando a verificación";

                BackgroundVerificacion.RunWorkerAsync();
            }


        }

        private void BackgroundVerificacion_DoWork(object sender, DoWorkEventArgs e)
        {



            string tiempo = DateAndTime.TimeOfDay.ToString("HH:mm:ss");
            SqlCommand comandoActEstado;
            string consultaActEstado;
            consultaActEstado = "update Solicitud set estado = 'E' where id = '" + idSolicitud + "'";
            comandoActEstado = new SqlCommand();
            comandoActEstado.Connection = Module1.conexionempresa;
            comandoActEstado.CommandText = consultaActEstado;
            comandoActEstado.ExecuteNonQuery();

            foreach (DataGridViewRow row in dtdatos.Rows)
            {
                SqlCommand comandoActEstadoDatosSolicitud;
                string consultaActEstadoDatosSolicitud;
                consultaActEstadoDatosSolicitud = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("update datosSolicitud set estado = 'E' where id = '", row.Cells[0].Value), "'"));
                comandoActEstadoDatosSolicitud = new SqlCommand();
                comandoActEstadoDatosSolicitud.Connection = Module1.conexionempresa;
                comandoActEstadoDatosSolicitud.CommandText = consultaActEstadoDatosSolicitud;
                comandoActEstadoDatosSolicitud.ExecuteNonQuery();
            }


            SqlCommand insertCronogramaSolicitud;
            string consultaInsertCronogramaSolicitud;
            consultaInsertCronogramaSolicitud = "insert into CronogramaSolicitud values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tiempo + "','" + idSolicitud + "','Se envió a verificación por " + Module1.nmusr + "')";
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
            consultaDatosSolicitud = "select datosSolicitud.*, (clientes.nombre +' '+clientes.ApellidoPaterno+' '+clientes.ApellidoMaterno) as nombrecompleto,clientes.nombre,clientes.ApellidoPaterno,clientes.ApellidoMaterno,clientes.FechaNacimiento,clientes.Telefono,clientes.Celular from datosSolicitud inner join clientes on datosSolicitud.idCliente = clientes.id where datosSolicitud.idSolicitud = '" + idSolicitud + "'";
            adapterDatos = new SqlDataAdapter(consultaDatosSolicitud, Module1.conexionempresa);
            dataDatos = new DataTable();
            adapterDatos.Fill(dataDatos);
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
(select DocumentosNecesariosTipo.idTipo,TiposdeDocumentosSolicitud.Nombre from DocumentosNecesariosTipo inner join TiposdeDocumentosSolicitud on DocumentosNecesariosTipo.idTipo = TiposdeDocumentosSolicitud.id where idTipoCredito = '" + tipoSolicitud + "' and TiposdeDocumentosSolicitud.Tipo = 'A') ajas";
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

            My.MyProject.Forms.Cargando.Close();
        }

        private bool VerificaDatos()
        {
            int sintexto = 0;
            foreach (Control ctrl in Controls)
            {
                if (ctrl is Bunifu.Framework.UI.BunifuMaterialTextbox)
                {
                    Bunifu.Framework.UI.BunifuMaterialTextbox txtctrl = (Bunifu.Framework.UI.BunifuMaterialTextbox)ctrl;
                    if (Strings.Len(Strings.Trim(txtctrl.Text)) == 0)
                    {
                        MessageBox.Show("No puedes dejar campos vacíos");
                        txtctrl.Select();
                        sintexto = sintexto + 1;
                        break;
                    }
                    else
                    {


                    }
                }
            }

            if (sintexto == 0)
            {
                return true;
            }
            else
            {
                return false;
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
(select DocumentosNecesariosTipo.idTipo,TiposdeDocumentosSolicitud.Nombre from DocumentosNecesariosTipo inner join TiposdeDocumentosSolicitud on DocumentosNecesariosTipo.idTipo = TiposdeDocumentosSolicitud.id where idTipoCredito = '" + tipoSolicitud + "' and TiposdeDocumentosSolicitud.Tipo = 'A') ajas";
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
                consultaCapturaSolicitud = "Update datosSolicitud set Estado = 'C' where id = '" + idDatosSolicitud + "'";
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

        private void BackgroundDatosSolicitud_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();
        }



        private void dtdatosDocumentos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            My.MyProject.Forms.VistaDocumento.PictureBox1.Image = (Image)dtdatosDocumentos.Rows[dtdatosDocumentos.CurrentRow.Index].Cells[2].FormattedValue;
            My.MyProject.Forms.VistaDocumento.ShowDialog();
        }

        private void dtdatosDocumentosNuevos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtdatosDocumentosNuevos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                dtdatosDocumentosNuevos.Rows.RemoveAt(dtdatosDocumentosNuevos.CurrentRow.Index);
            }
        }

        private void txtEdad_OnValueChanged(object sender, EventArgs e)
        {

        }



        private void txtCodigoPostal_OnValueChanged(object sender, EventArgs e)
        {
            ComboColonia.Items.Clear();
            ComboColonia.Items.Add("");
            foreach (DataRow row in Module1.dataColonias.Rows)
            {
                if ((row["CP"].ToString() ?? "") == (txtCodigoPostal.Text ?? ""))
                {
                    ComboColonia.Items.Add(row["Colonia"].ToString());
                }
            }
        }



        private void txtIngresoPromedio_OnValueChanged(object sender, EventArgs e)
        {

        }




        private void txtFamiliasEnCasa_OnValueChanged(object sender, EventArgs e)
        {

        }



        private void txtDeudas_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPersonasDependientes_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPersonasDependientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Strings.Asc(e.KeyChar) == 8))
            {
                if (!Information.IsNumeric(e.KeyChar))
                {
                    e.Handled = true;
                }
            }


        }

        private void txtFamiliasEnCasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Strings.Asc(e.KeyChar) == 8))
            {
                if (!Information.IsNumeric(e.KeyChar))
                {
                    e.Handled = true;
                }
            }


        }

        private void txtCodigoPostalTrabajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Strings.Asc(e.KeyChar) == 8))
            {
                if (!Information.IsNumeric(e.KeyChar))
                {
                    e.Handled = true;
                }
            }


        }

        private void txtIngresoPromedio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Strings.Asc(e.KeyChar) == 8))
            {
                if (!Information.IsNumeric(e.KeyChar))
                {
                    e.Handled = true;
                }
            }


        }

        private void txtCodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Strings.Asc(e.KeyChar) == 8))
            {
                if (!Information.IsNumeric(e.KeyChar))
                {
                    e.Handled = true;
                }
            }




        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Strings.Asc(e.KeyChar) == 8))
            {
                if (!Information.IsNumeric(e.KeyChar))
                {
                    e.Handled = true;
                }
            }


        }


        private void txtEmpleados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Strings.Asc(e.KeyChar) == 8))
            {
                if (!Information.IsNumeric(e.KeyChar))
                {
                    e.Handled = true;
                }
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

        private void BackgroundActivarLegal_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string tiempo = DateAndTime.TimeOfDay.ToString("HH:mm:ss");
            SqlCommand comandoActEstado;
            string consultaActEstado;
            consultaActEstado = "update Solicitud set estado = 'L' where id = '" + idSolicitud + "'";
            comandoActEstado = new SqlCommand();
            comandoActEstado.Connection = Module1.conexionempresa;
            comandoActEstado.CommandText = consultaActEstado;
            comandoActEstado.ExecuteNonQuery();

            foreach (DataGridViewRow row in dtdatos.Rows)
            {
                SqlCommand comandoActEstadoDatosSolicitud;
                string consultaActEstadoDatosSolicitud;
                consultaActEstadoDatosSolicitud = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("update datosSolicitud set estado = 'L' where id = '", row.Cells[0].Value), "'"));
                comandoActEstadoDatosSolicitud = new SqlCommand();
                comandoActEstadoDatosSolicitud.Connection = Module1.conexionempresa;
                comandoActEstadoDatosSolicitud.CommandText = consultaActEstadoDatosSolicitud;
                comandoActEstadoDatosSolicitud.ExecuteNonQuery();
            }

            SqlCommand comandoActLegal;
            string consultaActLegal;
            consultaActLegal = "update legales set estado = 'A' where idsolicitud = '" + idSolicitud + "'";
            comandoActLegal = new SqlCommand();
            comandoActLegal.Connection = Module1.conexionempresa;
            comandoActLegal.CommandText = consultaActLegal;
            comandoActLegal.ExecuteNonQuery();


            SqlCommand insertCronogramaSolicitud;
            string consultaInsertCronogramaSolicitud;
            consultaInsertCronogramaSolicitud = "insert into CronogramaSolicitud values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tiempo + "','" + idSolicitud + "','Se terminó de capturar por " + Module1.nmusr + "')";
            insertCronogramaSolicitud = new SqlCommand();
            insertCronogramaSolicitud.Connection = Module1.conexionempresa;
            insertCronogramaSolicitud.CommandText = consultaInsertCronogramaSolicitud;
            insertCronogramaSolicitud.ExecuteNonQuery();
        }

        private void btnActivarLegal_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Activando Solicitud Legal";
            BackgroundActivarLegal.RunWorkerAsync();

        }


        private void txtCodigoPostal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // ComboColonia.Clear()
                // ComboColonia.AddItem("")
                ComboColonia.Items.Clear();
                ComboColonia.Items.Add("");
                foreach (DataRow row in Module1.dataColonias.Rows)
                {
                    if ((row["CP"].ToString() ?? "") == (txtCodigoPostal.Text ?? ""))
                    {
                        ComboColonia.Items.Add(row["Colonia"].ToString());
                    }

                }
            }
        }


        private void ConsultaColoniasPersonal()
        {
            // If e.KeyCode = Keys.Enter Then
            // ComboColonia.Clear()
            ComboColonia.Items.Clear();
            ComboColonia.Items.Add("");
            // ComboColonia.AddItem("")
            foreach (DataRow row in Module1.dataColonias.Rows)
            {
                if ((row["CP"].ToString() ?? "") == (txtCodigoPostal.Text ?? ""))
                {
                    ComboColonia.Items.Add(row["Colonia"].ToString());
                }
                // 
            }
            // End If
        }

        private void ComboColonia_onItemSelected(object sender, EventArgs e)
        {

        }

        private void txtCodigoPostalTrabajo_OnValueChanged(object sender, EventArgs e)
        {
            ComboColoniaTrabajo.Items.Clear();
            ComboColoniaTrabajo.Items.Add("");
            foreach (DataRow row in Module1.dataColonias.Rows)
            {
                if ((row["CP"].ToString() ?? "") == (txtCodigoPostalTrabajo.Text ?? ""))
                {
                    ComboColoniaTrabajo.Items.Add(row["Colonia"].ToString());
                }

            }
        }

        private void ConsultaColoniasTrabajo()
        {
            // If e.KeyCode = Keys.Enter Then
            // ComboColonia.Clear()
            ComboColoniaTrabajo.Items.Clear();
            ComboColoniaTrabajo.Items.Add("");
            // ComboColonia.AddItem("")
            foreach (DataRow row in Module1.dataColonias.Rows)
            {
                if ((row["CP"].ToString() ?? "") == (txtCodigoPostalTrabajo.Text ?? ""))
                {
                    ComboColoniaTrabajo.Items.Add(row["Colonia"].ToString());
                }
                // 
            }
            // End If
        }
        private void ConsultaColoniasR1()
        {
            // If e.KeyCode = Keys.Enter Then
            // ComboColonia.Clear()
            ComboColoniaR1.Items.Clear();
            ComboColoniaR1.Items.Add("");
            // ComboColonia.AddItem("")
            foreach (DataRow row in Module1.dataColonias.Rows)
            {
                if ((row["CP"].ToString() ?? "") == (txtCodigoPostalR1.Text ?? ""))
                {
                    ComboColoniaR1.Items.Add(row["Colonia"].ToString());
                }
                // 
            }
            // End If

        }
        private void ConsultaColoniasR2()
        {
            // If e.KeyCode = Keys.Enter Then
            // ComboColonia.Clear()
            ComboColoniaR2.Items.Clear();
            ComboColoniaR2.Items.Add("");
            // ComboColonia.AddItem("")
            foreach (DataRow row in Module1.dataColonias.Rows)
            {
                if ((row["CP"].ToString() ?? "") == (txtCodigoPostalR2.Text ?? ""))
                {
                    ComboColoniaR2.Items.Add(row["Colonia"].ToString());
                }
                // 
            }
            // End If
        }

        private void txtCodigoPostalTrabajo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // ComboColonia.Clear()
                // ComboColonia.AddItem("")
                ComboColoniaTrabajo.Items.Clear();
                ComboColoniaTrabajo.Items.Add("");
                foreach (DataRow row in Module1.dataColonias.Rows)
                {
                    if ((row["CP"].ToString() ?? "") == (txtCodigoPostalTrabajo.Text ?? ""))
                    {
                        ComboColoniaTrabajo.Items.Add(row["Colonia"].ToString());
                    }

                }
            }
        }

        private void TabPage5_Click(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigoPostalR2_OnValueChanged(object sender, EventArgs e)
        {
            ComboColoniaR2.Items.Clear();
            ComboColoniaR2.Items.Add("");
            foreach (DataRow row in Module1.dataColonias.Rows)
            {
                if ((row["CP"].ToString() ?? "") == (txtCodigoPostalR2.Text ?? ""))
                {
                    ComboColoniaR2.Items.Add(row["Colonia"].ToString());
                }

            }
        }

        private void txtCodigoPostalR2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // ComboColonia.Clear()
                // ComboColonia.AddItem("")
                ComboColoniaR2.Items.Clear();
                ComboColoniaR2.Items.Add("");
                foreach (DataRow row in Module1.dataColonias.Rows)
                {
                    if ((row["CP"].ToString() ?? "") == (txtCodigoPostalR2.Text ?? ""))
                    {
                        ComboColoniaR2.Items.Add(row["Colonia"].ToString());
                    }

                }
            }
        }

        private void txtCodigoPostalR1_OnValueChanged(object sender, EventArgs e)
        {
            ComboColoniaR1.Items.Clear();
            ComboColoniaR1.Items.Add("");
            foreach (DataRow row in Module1.dataColonias.Rows)
            {
                if ((row["CP"].ToString() ?? "") == (txtCodigoPostalR1.Text ?? ""))
                {
                    ComboColoniaR1.Items.Add(row["Colonia"].ToString());
                }

            }
        }

        private void txtCodigoPostalR1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Strings.Asc(e.KeyChar) == 8))
            {
                if (!Information.IsNumeric(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

        }

        private void txtCodigoPostalR1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // ComboColonia.Clear()
                // ComboColonia.AddItem("")
                ComboColoniaR1.Items.Clear();
                ComboColoniaR1.Items.Add("");
                foreach (DataRow row in Module1.dataColonias.Rows)
                {
                    if ((row["CP"].ToString() ?? "") == (txtCodigoPostalR1.Text ?? ""))
                    {
                        ComboColoniaR1.Items.Add(row["Colonia"].ToString());
                    }

                }
            }
        }

        private void txtCodigoPostalR2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Strings.Asc(e.KeyChar) == 8))
            {
                if (!Information.IsNumeric(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void ComboColonia_GotFocus(object sender, EventArgs e)
        {
            // ComboColonia.Items.Clear()
            // ComboColonia.Items.Add("")
            // For Each row As DataRow In dataColonias.Rows
            // If row("CP").ToString = txtCodigoPostal.Text Then
            // ComboColonia.Items.Add(row("Colonia").ToString)
            // End If
            // Next
        }

        private void txtTelefonoTrabajo_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void BackgroundCorreo_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            try
            {
                DataTable dataDocumentosCorreo;
                SqlDataAdapter adapterDocumentosCorreo;
                string consultaDocumentosCorreo;
                consultaDocumentosCorreo = "select documentossolicitud.IdDatosSolicitud,DocumentosSolicitud.Imagen,td.nombre from DocumentosSolicitud inner join DatosSolicitud on DocumentosSolicitud.IdDatosSolicitud = DatosSolicitud.Id inner join tiposdedocumentossolicitud td on documentossolicitud.tipo = td.id where DatosSolicitud.IdSolicitud = '" + idSolicitud + "' ";
                adapterDocumentosCorreo = new SqlDataAdapter(consultaDocumentosCorreo, Module1.conexionempresa);
                dataDocumentosCorreo = new DataTable();
                adapterDocumentosCorreo.Fill(dataDocumentosCorreo);
                // Creamos un nuevo objeto MailMessage donde especificamos el "From" y el "To"
                var correo = new System.Net.Mail.MailMessage(Module1.correoEmpresa, correoGestor);
                correo.Subject = nombreSolicitud;
                foreach (DataRow row in Module1.dataCorreos.Rows)
                    correo.To.Add(row["Correo"].ToString());
                // correo.To.Add("danielafernandez@prestamosconfia.com")
                // correo.To.Add("opaniahua@prestamosconfia.com")
                var sb = new StringBuilder();
                foreach (DataGridViewRow row in dtdatos.Rows)
                {

                    foreach (DataRow rowDocumento in dataDocumentosCorreo.Rows)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rowDocumento["IdDatosSolicitud"].ToString(), row.Cells[0].Value, false)))
                        {

                            byte[] byteArray = (byte[])rowDocumento["Imagen"];
                            var stream = new MemoryStream(byteArray, 0, byteArray.Length);
                            stream.Write(byteArray, 0, byteArray.Length);
                            Bitmap bitmapDocumento;
                            bitmapDocumento = new Bitmap(stream);
                            bitmapDocumento.Save(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(@"C:\ConfiaAdmin\SATI\TempPhotos\", rowDocumento["nombre"]), " "), row.Cells[2].Value), ".jpg")));
                            correo.Attachments.Add(new System.Net.Mail.Attachment(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(@"C:\ConfiaAdmin\SATI\TempPhotos\", rowDocumento["nombre"]), " "), row.Cells[2].Value), ".jpg"))));
                        }

                        // Exit For
                        else
                        {

                        }
                    }

                    foreach (DataRow rowcliente in dataDatos.Rows)
                    {

                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rowcliente["idCliente"].ToString(), row.Cells[1].Value, false)))
                        {
                            sb.AppendLine(Conversions.ToString(Operators.ConcatenateObject("Nombre: ", row.Cells[2].Value)));
                            sb.AppendLine("Teléfono: " + rowcliente["Telefono"].ToString());
                            sb.AppendLine("Celular: " + rowcliente["Celular"].ToString());
                            sb.AppendLine("Casa donde vive es: " + rowcliente["CasaDondeViveEs"].ToString());
                            sb.AppendLine("Tiempo en el domicilio: " + rowcliente["TiempoEnDomicilio"].ToString());
                            sb.AppendLine("Domicilio: " + rowcliente["Calle"].ToString() + " ext " + rowcliente["Noext"].ToString() + " Int " + rowcliente["NoInt"].ToString() + " C.P. " + rowcliente["CodigoPostal"].ToString() + " " + rowcliente["Colonia"].ToString());
                            sb.AppendLine("Ciudad: " + rowcliente["Ciudad"].ToString());
                            sb.AppendLine("Estado: " + rowcliente["EstadoCliente"].ToString());
                            sb.AppendLine("Entre calles: " + rowcliente["EntreCalles"].ToString());
                            sb.AppendLine("Conyuge: " + rowcliente["Conyuge"].ToString());
                            sb.AppendLine("Relación con el conyuge: " + rowcliente["RelacionConyuge"].ToString());
                            sb.AppendLine("Donde Trabaja: " + rowcliente["DondeTrabaja"].ToString());
                            sb.AppendLine("Se dedica a: " + rowcliente["SeDedica"].ToString());
                            sb.AppendLine("Qué vende: " + rowcliente["QueVende"].ToString());
                            sb.AppendLine("Antigüedad: " + rowcliente["Antiguedad"].ToString());
                            sb.AppendLine("Horarios: " + rowcliente["Horarios"].ToString());
                            sb.AppendLine("Tipo de Establecimiento: " + rowcliente["TipoEstablecimiento"].ToString());
                            sb.AppendLine("Ingreso: " + rowcliente["IngresoPmensual"].ToString());
                            sb.AppendLine("Frecuencia: " + rowcliente["FrecuenciaCobro"].ToString());
                            sb.AppendLine("Domicilio del trabajo: " + rowcliente["CalleTrabajo"].ToString() + " ext " + rowcliente["NoextTrabajo"].ToString() + " Int " + rowcliente["NoIntTrabajo"].ToString() + " C.P. " + rowcliente["CodigoPostalTrabajo"].ToString() + " " + rowcliente["ColoniaTrabajo"].ToString());
                            sb.AppendLine("Teléfono del trabajo: " + rowcliente["TelefonoTrabajo"].ToString());
                            sb.AppendLine("Objetivo: " + rowcliente["Objetivo"].ToString());
                            sb.AppendLine("Nombre Referencia 1: " + rowcliente["NombreR1"].ToString());
                            sb.AppendLine("Teléfono Referencia 1: " + rowcliente["TelefonoR1"].ToString());
                            sb.AppendLine("Domicilio de Referencia 1: " + rowcliente["CalleR1"].ToString() + " ext " + rowcliente["NoExtR1"].ToString() + " Int " + rowcliente["NoIntR1"].ToString() + " C.P. " + rowcliente["CodigoPostalR1"].ToString() + " " + rowcliente["ColoniaR1"].ToString());
                            sb.AppendLine("Relación R1: " + rowcliente["RelacionR1"].ToString());
                            sb.AppendLine("Nombre Referencia 2: " + rowcliente["NombreR2"].ToString());
                            sb.AppendLine("Teléfono Referencia 2: " + rowcliente["TelefonoR2"].ToString());
                            sb.AppendLine("Domicilio de Referencia 2: " + rowcliente["CalleR2"].ToString() + " ext " + rowcliente["NoExtR2"].ToString() + " Int " + rowcliente["NoIntR2"].ToString() + " C.P. " + rowcliente["CodigoPostalR2"].ToString() + " " + rowcliente["ColoniaR2"].ToString());
                            sb.AppendLine("Relación R2: " + rowcliente["RelacionR2"].ToString());
                            sb.AppendLine("Enfermedad: " + rowcliente["Enfermedad"].ToString());
                            sb.AppendLine("Familias en casa: " + rowcliente["FamiliasEnCasa"].ToString());
                            sb.AppendLine("Deudas con: " + rowcliente["DeudasCon"].ToString());
                            sb.AppendLine("Servicios con los que cuenta: " + rowcliente["Servicios"].ToString());
                            sb.AppendLine("Personas dependientes: " + rowcliente["PersonasDependientes"].ToString());
                            sb.AppendLine("Empleados: " + rowcliente["Empleados"].ToString());
                            sb.AppendLine("Frecuencia Inversión: " + rowcliente["FrecuenciaInversion"].ToString());
                            sb.AppendLine("Observaciones en el domicilio: " + rowcliente["ObservacionesDomicilio"].ToString());
                            sb.AppendLine("Horario Verificación: " + rowcliente["HorarioVerificacion"].ToString());
                            sb.AppendLine("  ");
                            sb.AppendLine("------------------------------------");
                            sb.AppendLine("  ");
                        }

                    }

                }
                correo.Body = sb.ToString();
                var cliente = new System.Net.Mail.SmtpClient();
                // Creamos el objeto que va a "preparar" la autentificación
                var autentificacion = new System.Net.NetworkCredential(Module1.correoEmpresa, Module1.passwordCorreoEmpresa);
                var smtp = new System.Net.Mail.SmtpClient();
                // Incluimos esta información a la hora de loguearnos en el servidor
                smtp.Host = "p3plcpnl0962.prod.phx3.secureserver.net";
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = autentificacion;
                smtp.Port = 587;
                smtp.Send(correo);

                SqlCommand comandoCorreoEnviado;
                string consultaCorreoEnviado;
                consultaCorreoEnviado = "update solicitud set correo = 1 where id = '" + idSolicitud + "'";
                comandoCorreoEnviado = new SqlCommand();
                comandoCorreoEnviado.Connection = Module1.conexionempresa;
                comandoCorreoEnviado.CommandText = consultaCorreoEnviado;
                comandoCorreoEnviado.ExecuteNonQuery();


                errorCorreo = false;
            }



            catch (Exception ex)
            {
                errorCorreo = true;
                MessageBox.Show(ex.Message);

            }
        }

        private void BackgroundCorreo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (errorCorreo)
            {
                if (MessageBox.Show("El correo no pudo ser enviado satisfactoriamente, ¿deseas cambiar el estado de todos modos?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Enviando a verificación";
                    BackgroundVerificacion.RunWorkerAsync();
                }
                else
                {
                    My.MyProject.Forms.Cargando.Close();

                }
            }
            else
            {
                foreach (string fichero in Directory.GetFiles(@"C:\ConfiaAdmin\SATI\TempPhotos", "*.jpg"))
                    File.Delete(fichero);
                My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Enviando a verificación";
                BackgroundVerificacion.RunWorkerAsync();

            }
        }
    }
}