using System;
using System.Collections.Generic;
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

    public partial class DatosSolicitudBoleta
    {
        public int idSolicitud;
        public int idDatosSolicitud;
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
        private bool DatosCapturados;
        private DataTable dataArticulos;
        private SqlDataAdapter adapterArticulos;

        public DatosSolicitudBoleta()
        {
            InitializeComponent();
        }

        private void DatosSolicitud_Load(object sender, EventArgs e)
        {

            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Datos";
            My.MyProject.Forms.Cargando.TopMost = true;
            BackgroundWorker1.RunWorkerAsync();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();

            string consultaDatosSolicitud;
            SqlCommand ComandoDatosSolicitud;
            SqlDataReader readerDatosSolicitud;
            consultaDatosSolicitud = "select SolicitudBoleta.id,SolicitudBoleta.Nombre,SolicitudBoleta.Telefono, SolicitudBoleta.Domicilio,SolicitudBoleta.CodigoPostal,SolicitudBoleta.Colonia,SolicitudBoleta.Municipio,SolicitudBoleta.Entidad,SolicitudBoleta.CURP,SolicitudBoleta.MontoValuado,SolicitudBoleta.MontoSugerido,SolicitudBoleta.Fecha,SolicitudBoleta.Estado,SolicitudBoleta.idTipoEmpeño,SolicitudBoleta.Ine,Clientes.Nombre as nombres,Clientes.ApellidoPaterno,Clientes.ApellidoMaterno from SolicitudBoleta inner join Clientes on SolicitudBoleta.idCliente=Clientes.id where SolicitudBoleta.id='" + idSolicitud + "'";
            ComandoDatosSolicitud = new SqlCommand();
            ComandoDatosSolicitud.Connection = Module1.conexionempresa;
            ComandoDatosSolicitud.CommandText = consultaDatosSolicitud;
            readerDatosSolicitud = ComandoDatosSolicitud.ExecuteReader();
            if (readerDatosSolicitud.HasRows)
            {
                while (readerDatosSolicitud.Read())
                {
                    txtnombre.Text = Conversions.ToString(readerDatosSolicitud["nombres"]);
                    txtApellidoP.Text = Conversions.ToString(readerDatosSolicitud["ApellidoPaterno"]);
                    txtApellidoM.Text = Conversions.ToString(readerDatosSolicitud["ApellidoMaterno"]);
                    txtCelular.Text = Conversions.ToString(readerDatosSolicitud["Telefono"]);
                    txtDomicilio.Text = Conversions.ToString(readerDatosSolicitud["Domicilio"]);
                    txtCodigoPostal.Text = Conversions.ToString(readerDatosSolicitud["CodigoPostal"]);
                    ConsultaColoniasPersonal();
                    txtIne.Text = Conversions.ToString(readerDatosSolicitud["Ine"]);
                    ComboColonia.Text = Conversions.ToString(readerDatosSolicitud["colonia"]);
                    txtCiudad.Text = Conversions.ToString(readerDatosSolicitud["Municipio"]);
                    txtEstado.Text = Conversions.ToString(readerDatosSolicitud["Entidad"]);
                    txtCurp.Text = Conversions.ToString(readerDatosSolicitud["curp"]);
                    tipoSolicitud = Conversions.ToInteger(readerDatosSolicitud["idtipoempeño"]);
                }
            }
            readerDatosSolicitud.Close();



            string consultaArticulos;
            consultaArticulos = "select ArticulosEmpeños.id, ArticulosEmpeños.Descripcion, ArticulosEmpeños.idSolicitud,ArticulosEmpeños.Imagen,ArticulosEmpeños.Marca,ArticulosEmpeños.Modelo,ArticulosEmpeños.MontoValuado,ArticulosEmpeños.MontoSugerido,ArticulosEmpeños.NoSerie, TipoArticulosEmpeño.Nombre from ArticulosEmpeños inner join tipoarticulosempeño on tipoarticulosempeño.id=ArticulosEmpeños.Tipo where ArticulosEmpeños.idSolicitud = '" + idSolicitud + "'";
            adapterArticulos = new SqlDataAdapter(consultaArticulos, Module1.conexionempresa);
            dataArticulos = new DataTable();
            adapterArticulos.Fill(dataArticulos);
            dtdatos.DataSource = dataArticulos;


            SqlCommand comandoTipo;
            string consultaTipo;
            consultaTipo = "Select nombre from tiposdeempeño where id = '" + tipoSolicitud + "'";
            comandoTipo = new SqlCommand();
            comandoTipo.Connection = Module1.conexionempresa;
            comandoTipo.CommandText = consultaTipo;
            tipoSolicitudString = Conversions.ToString(comandoTipo.ExecuteScalar());





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

                    break;
                }
            }

            BackgroundDocumentos.RunWorkerAsync();

        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtdatos.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Cargando.Show()
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Documentos...";
            // Cargando.TopMost = True
            BackgroundDocumentos.RunWorkerAsync();

        }

        private void btn_Procesar_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in Module1.dataPermisos.Rows)
            {
                if (Conversions.ToBoolean(row["SatiModSolicitudesEmpeñoModificar"]))
                {
                    My.MyProject.Forms.Cargando.Show();
                    My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Registrando Captura";
                    BackgroundAct.RunWorkerAsync();
                    break;
                }
                else
                {
                    MessageBox.Show("La captura no fue autorizada");
                }
            }

        }

        private void BackgroundAct_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            SqlCommand comandoActDatos;
            string consultaActDatos;
            consultaActDatos = @"update solicitudboleta SET
       [Telefono]='" + txtCelular.Text + @"'
      ,[Domicilio]='" + txtDomicilio.Text + @"'
      ,[CodigoPostal]='" + txtCodigoPostal.Text + @"'
      ,[Colonia]='" + ComboColonia.Text + @"'
      ,[Municipio]='" + txtCiudad.Text + @"'
      ,[Entidad]='" + txtEstado.Text + @"'
      ,[Ine]='" + txtIne.Text + @"'
      ,[CURP]='" + txtCurp.Text + @"'
           where id = '" + idSolicitud + @"'
      ";
            comandoActDatos = new SqlCommand();
            comandoActDatos.Connection = Module1.conexionempresa;
            comandoActDatos.CommandText = consultaActDatos;
            comandoActDatos.ExecuteNonQuery();

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.AgregarDocumentoDatosSolicitudBoleta.Show();
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
                consultaDocumento = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into DocumentosSolicitudBoleta values('" + idSolicitud + "','", row.Cells[0].Value), "',@Documento)"));
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

            // Cargando.Close()

            // If VerificaDatos() = True Then
            BackgroundCargaDocumentos.RunWorkerAsync();

            // BackgroundWorker2.RunWorkerAsync()
            // Else
            // Cargando.Close()
            // End If
        }

        private void btn_a_verificacion_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Enviando a verificación";
            BackgroundVerificacion.RunWorkerAsync();

        }

        private void BackgroundVerificacion_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string tiempo = DateAndTime.TimeOfDay.ToString("HH:mm:ss");
            SqlCommand comandoActEstado;
            string consultaActEstado;
            consultaActEstado = "update Solicitudboleta set estado = 'E' where id = '" + idSolicitud + "'";
            comandoActEstado = new SqlCommand();
            comandoActEstado.Connection = Module1.conexionempresa;
            comandoActEstado.CommandText = consultaActEstado;
            comandoActEstado.ExecuteNonQuery();

            SqlCommand insertCronogramaSolicitud;
            string consultaInsertCronogramaSolicitud;
            consultaInsertCronogramaSolicitud = "insert into CronogramaSolicitudEmpeño values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tiempo + "','" + idSolicitud + "','Se envió a autorización por " + Module1.nmusr + "')";
            insertCronogramaSolicitud = new SqlCommand();
            insertCronogramaSolicitud.Connection = Module1.conexionempresa;
            insertCronogramaSolicitud.CommandText = consultaInsertCronogramaSolicitud;
            insertCronogramaSolicitud.ExecuteNonQuery();

        }

        private void BackgroundVerificacion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();

            Invoke(new Action(() => My.MyProject.Forms.SolicitudesEmpeños.cargarSolicitudes()));
            Close();

        }



        private void BackgroundDocumentos_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consultaDocumentos;
            consultaDocumentos = "Select DocumentosSolicitudboleta.Tipo,TiposdeDocumentosSolicitud.Nombre,DocumentosSolicitudboleta.Imagen from DocumentosSolicitudboleta inner join TiposdeDocumentosSolicitud on DocumentosSolicitudboleta.Tipo = TiposdeDocumentosSolicitud.id where idsolicitudboleta = '" + idSolicitud + "'";
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
                        sql = "select ajas.idTipo,ajas.Nombre,case when (select top 1 Tipo from DocumentosSolicitudboleta where Tipo = ajas.idTipo and DocumentosSolicitudboleta.idSolicitudBoleta = '" + idSolicitud + @"') IS  null then 0 else 1 end as Cargado from
(select DocumentosNecesariosEmpeño.idTipo,TiposdeDocumentosSolicitud.Nombre from DocumentosNecesariosEmpeño inner join TiposdeDocumentosSolicitud on DocumentosNecesariosEmpeño.idTipo = TiposdeDocumentosSolicitud.id where idTipoEmpeño = '" + tipoSolicitud + "' and TiposdeDocumentosSolicitud.Tipo = 'A') ajas";
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
            dtdatos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            dtdatos.Columns[3].FillWeight = 150f;
            dtdatos.Columns[3].Width = 200;
            DataGridViewImageColumn imagecolumn;
            imagecolumn = (DataGridViewImageColumn)dtdatos.Columns[3];
            imagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            foreach (DataGridViewRow row in dtdatos.Rows)

                row.Height = 200;
            My.MyProject.Forms.Cargando.Close();
        }

        private bool VerificaDatos()
        {
            int sintexto = 0;
            var listacontroles = new List<Control>();
            listacontroles.Add(txtnombre);
            listacontroles.Add(txtApellidoP);
            listacontroles.Add(txtApellidoM);
            listacontroles.Add(txtIne);
            listacontroles.Add(txtCurp);
            listacontroles.Add(txtCodigoPostal);
            listacontroles.Add(ComboColonia);
            listacontroles.Add(txtDomicilio);
            listacontroles.Add(txtCiudad);
            listacontroles.Add(txtEstado);
            listacontroles.Add(txtCelular);
            foreach (Control ctrl in listacontroles)
            {
                if (Strings.Len(Strings.Trim(ctrl.Text)) == 0)
                {
                    bool exitFor = false;
                    bool exitFor1 = false;
                    bool exitFor2 = false;
                    bool exitFor3 = false;
                    bool exitFor4 = false;
                    bool exitFor5 = false;
                    bool exitFor6 = false;
                    bool exitFor7 = false;
                    bool exitFor8 = false;
                    bool exitFor9 = false;
                    bool exitFor10 = false;
                    switch (ctrl.Name ?? "")
                    {
                        case "txtnombre":
                            {
                                MessageBox.Show("El campo Nombre está vacío");
                                sintexto += 1;
                                exitFor = true;
                                break;
                            }
                        case "txtApellidoP":
                            {
                                MessageBox.Show("El campo Apellido Paterno está vacío");
                                sintexto += 1;
                                exitFor1 = true;
                                break;
                            }
                        case "txtApellidoM":
                            {
                                MessageBox.Show("El campo Apellido Materno está vacío");
                                sintexto += 1;
                                exitFor2 = true;
                                break;
                            }
                        case "txtIne":
                            {
                                MessageBox.Show("El campo No. de Identificación está vacío");
                                sintexto += 1;
                                exitFor3 = true;
                                break;
                            }
                        case "txtCurp":
                            {
                                MessageBox.Show("El campo CURP está vacío");
                                sintexto += 1;
                                exitFor4 = true;
                                break;
                            }
                        case "txtCodigoPostal":
                            {
                                MessageBox.Show("El campo Código Postal está vacío");
                                sintexto += 1;
                                exitFor5 = true;
                                break;
                            }
                        case "txtDomicilio":
                            {
                                MessageBox.Show("El campo Domicilio está vacío");
                                sintexto += 1;
                                exitFor6 = true;
                                break;
                            }
                        case "txtCiudad":
                            {
                                MessageBox.Show("El campo Ciudad está vacío");
                                sintexto += 1;
                                exitFor7 = true;
                                break;
                            }
                        case "txtEstado":
                            {
                                MessageBox.Show("El campo Estado está vacío");
                                sintexto += 1;
                                exitFor8 = true;
                                break;
                            }
                        case "txtCelular":
                            {
                                MessageBox.Show("El campo Celular está vacío");
                                sintexto += 1;
                                exitFor9 = true;
                                break;
                            }
                        case "ComboColonia":
                            {
                                MessageBox.Show("El campo Colonia está vacío");
                                sintexto += 1;
                                exitFor10 = true;
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

                    if (exitFor7)
                    {
                        break;
                    }

                    if (exitFor8)
                    {
                        break;
                    }

                    if (exitFor9)
                    {
                        break;
                    }

                    if (exitFor10)
                    {
                        break;
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
            consultaDocumentos = "Select DocumentosSolicitudboleta.Tipo,TiposdeDocumentosSolicitud.Nombre,DocumentosSolicitudboleta.Imagen from DocumentosSolicitudboleta inner join TiposdeDocumentosSolicitud on DocumentosSolicitudboleta.Tipo = TiposdeDocumentosSolicitud.id where idsolicitudboleta = '" + idSolicitud + "'";
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
                        sql = "select ajas.idTipo,ajas.Nombre,case when (select top 1 Tipo from DocumentosSolicitudboleta where Tipo = ajas.idTipo and DocumentosSolicitudboleta.idSolicitudBoleta = '" + idSolicitud + @"') IS  null then 0 else 1 end as Cargado from
(select DocumentosNecesariosEmpeño.idTipo,TiposdeDocumentosSolicitud.Nombre from DocumentosNecesariosEmpeño inner join TiposdeDocumentosSolicitud on DocumentosNecesariosEmpeño.idTipo = TiposdeDocumentosSolicitud.id where idTipoEmpeño = '" + tipoSolicitud + "' and TiposdeDocumentosSolicitud.Tipo = 'A') ajas";
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
                // VerificaDatos()
                if (VerificaDatos())
                {
                    btn_a_autorizacion.Visible = true;

                }
            }

            else
            {
                MessageBox.Show("Faltan Documentos por cargar");
            }
            My.MyProject.Forms.Cargando.Close();
            // MessageBox.Show("El largo es: " & Len(Trim(txtIne.Text)))
        }





        private void dtdatosDocumentos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            My.MyProject.Forms.VistaDocumento.PictureBox1.Image = (Image)dtdatosDocumentos.Rows[dtdatosDocumentos.CurrentRow.Index].Cells[2].FormattedValue;
            My.MyProject.Forms.VistaDocumento.ShowDialog();
        }



        private void dtdatosDocumentosNuevos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                dtdatosDocumentosNuevos.Rows.RemoveAt(dtdatosDocumentosNuevos.CurrentRow.Index);
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

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Module_resize.MoveForm(this);
            }
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

        private void txtIne_OnValueChanged(object sender, EventArgs e)
        {
            if (txtIne.Text.Length > 13)
            {
                MessageBox.Show("El No. de Identificación no puede ser de más de 13 caracteres");
                string strIne = txtIne.Text;
                // strIne.Remove(12, 1)

                txtIne.Text = strIne.Remove(13, 1);
            }
        }

        private void txtCurp_OnValueChanged(object sender, EventArgs e)
        {
            if (txtCurp.Text.Length > 18)
            {
                MessageBox.Show("La CURP no puede contener más de 18 caracteres");
                string strCurp = txtCurp.Text;
                txtCurp.Text = strCurp.Remove(18, 1);
            }
        }

        private void txtCelular_OnValueChanged(object sender, EventArgs e)
        {
            if (txtCelular.Text.Length > 20)
            {
                MessageBox.Show("El número de celular no puede contener más de 20 caracteres");
                string strCelular = txtCelular.Text;
                txtCelular.Text = strCelular.Remove(20, 1);
            }
        }

        private void txtCodigoPostal_OnValueChanged(object sender, EventArgs e)
        {
            if (txtCodigoPostal.Text.Length > 5)
            {
                MessageBox.Show("El Código Postal no puede contener más de 5 caracteres");
                string strCodigoPostal = txtCodigoPostal.Text;
                txtCodigoPostal.Text = strCodigoPostal.Remove(5, 1);
            }
        }
    }
}