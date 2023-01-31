using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class DatosSolicitudBoletaVerificar
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
        private double montoTotalAutorizado = 0d;
        private int totalArticulosAutorizados = 0;
        private int idcliente, idPromotor;
        private double montoTotalValuado;
        private double montoTotalSugerido;
        private double porcentajeRefrendo;
        private string nombreCliente;
        public bool verSolicitud;

        public DatosSolicitudBoletaVerificar()
        {
            InitializeComponent();
        }
        private void DatosSolicitud_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in TabPage1.Controls)
            {
                if (ctrl is Bunifu.Framework.UI.BunifuMaterialTextbox)
                {
                    Bunifu.Framework.UI.BunifuMaterialTextbox txtControl = (Bunifu.Framework.UI.BunifuMaterialTextbox)ctrl;
                    txtControl.Enabled = false;
                }



            }
            dtdatos.ScrollBars = ScrollBars.None;
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.TopMost = true;
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Datos";
            BackgroundWorker1.RunWorkerAsync();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();

            string consultaDatosSolicitud;
            SqlCommand ComandoDatosSolicitud;
            SqlDataReader readerDatosSolicitud;
            consultaDatosSolicitud = "select SolicitudBoleta.id,SolicitudBoleta.Nombre,SolicitudBoleta.Telefono, SolicitudBoleta.Domicilio,SolicitudBoleta.CodigoPostal,SolicitudBoleta.Colonia,SolicitudBoleta.Municipio,SolicitudBoleta.Entidad,SolicitudBoleta.CURP,SolicitudBoleta.MontoValuado,SolicitudBoleta.MontoSugerido,SolicitudBoleta.MontoAutorizado,SolicitudBoleta.Fecha,SolicitudBoleta.Estado,SolicitudBoleta.idTipoEmpeño,SolicitudBoleta.idpromotor,SolicitudBoleta.Ine,Clientes.Nombre as nombres,Clientes.ApellidoPaterno,Clientes.ApellidoMaterno,solicitudboleta.idcliente,solicitudboleta.porcentajerefrendo from SolicitudBoleta inner join Clientes on SolicitudBoleta.idCliente=Clientes.id where SolicitudBoleta.id='" + idSolicitud + "'";
            ComandoDatosSolicitud = new SqlCommand();
            ComandoDatosSolicitud.Connection = Module1.conexionempresa;
            ComandoDatosSolicitud.CommandText = consultaDatosSolicitud;
            readerDatosSolicitud = ComandoDatosSolicitud.ExecuteReader();
            if (readerDatosSolicitud.HasRows)
            {
                while (readerDatosSolicitud.Read())
                {
                    txtnombre.Text = Conversions.ToString(readerDatosSolicitud["nombres"]);
                    nombreCliente = Conversions.ToString(readerDatosSolicitud["Nombre"]);
                    txtApellidoP.Text = Conversions.ToString(readerDatosSolicitud["ApellidoPaterno"]);
                    txtApellidoM.Text = Conversions.ToString(readerDatosSolicitud["ApellidoMaterno"]);
                    txtCelular.Text = Conversions.ToString(readerDatosSolicitud["Telefono"]);
                    txtCodigoPostal.Text = Conversions.ToString(readerDatosSolicitud["CodigoPostal"]);
                    txtDomicilio.Text = Conversions.ToString(readerDatosSolicitud["Domicilio"]);
                    txtIne.Text = Conversions.ToString(readerDatosSolicitud["Ine"]);
                    ConsultaColoniasPersonal();
                    idcliente = Conversions.ToInteger(readerDatosSolicitud["idcliente"]);
                    ComboColonia.Text = Conversions.ToString(readerDatosSolicitud["colonia"]);
                    txtCiudad.Text = Conversions.ToString(readerDatosSolicitud["Municipio"]);
                    txtEstado.Text = Conversions.ToString(readerDatosSolicitud["Entidad"]);
                    txtCurp.Text = Conversions.ToString(readerDatosSolicitud["curp"]);
                    tipoSolicitud = Conversions.ToInteger(readerDatosSolicitud["idtipoempeño"]);
                    montoTotalValuado = Conversions.ToDouble(readerDatosSolicitud["MontoValuado"]);
                    montoTotalSugerido = Conversions.ToDouble(readerDatosSolicitud["montoSugerido"]);
                    porcentajeRefrendo = Conversions.ToDouble(readerDatosSolicitud["porcentajerefrendo"]);
                    idPromotor = Conversions.ToInteger(readerDatosSolicitud["idPromotor"]);
                }
            }
            readerDatosSolicitud.Close();



            // Dim consultaArticulos As String
            // consultaArticulos = "select ArticulosEmpeños.id, ArticulosEmpeños.Descripcion, ArticulosEmpeños.idSolicitud,ArticulosEmpeños.Imagen,ArticulosEmpeños.Marca,ArticulosEmpeños.Modelo,ArticulosEmpeños.MontoValuado,ArticulosEmpeños.MontoSugerido,ArticulosEmpeños.NoSerie, TipoArticulosEmpeño.Nombre from ArticulosEmpeños inner join tipoarticulosempeño on tipoarticulosempeño.id=ArticulosEmpeños.Tipo where ArticulosEmpeños.idSolicitud = '" & idSolicitud & "'"
            // adapterArticulos = New SqlDataAdapter(consultaArticulos, conexionempresa)
            // dataArticulos = New DataTable
            // adapterArticulos.Fill(dataArticulos)
            // dtdatos.DataSource = dataArticulos

            string consultaArticulos;
            SqlCommand comandoArticulos;
            SqlDataReader readerArticulos;

            consultaArticulos = "select ArticulosEmpeños.id, ArticulosEmpeños.Descripcion, ArticulosEmpeños.idSolicitud,ArticulosEmpeños.Imagen,ArticulosEmpeños.Marca,ArticulosEmpeños.Modelo,ArticulosEmpeños.MontoValuado,ArticulosEmpeños.MontoSugerido,ArticulosEmpeños.NoSerie, TipoArticulosEmpeño.Nombre,articulosempeños.aprobado from ArticulosEmpeños inner join tipoarticulosempeño on tipoarticulosempeño.id=ArticulosEmpeños.Tipo where ArticulosEmpeños.idSolicitud = '" + idSolicitud + "'";

            comandoArticulos = new SqlCommand();
            comandoArticulos.Connection = Module1.conexionempresa;
            comandoArticulos.CommandText = consultaArticulos;
            readerArticulos = comandoArticulos.ExecuteReader();
            if (readerArticulos.HasRows)
            {
                while (readerArticulos.Read())
                {
                    byte[] bytBLOBData = (byte[])readerArticulos["imagen"];
                    var stmBLOBData = new MemoryStream(bytBLOBData);
                    Image imagen;
                    imagen = Image.FromStream(stmBLOBData);
                    dtdatos.Rows.Add(readerArticulos["id"], readerArticulos["idsolicitud"], readerArticulos["descripcion"], readerArticulos["Marca"], readerArticulos["Modelo"], readerArticulos["Noserie"], readerArticulos["MontoValuado"], readerArticulos["MontoSugerido"], "", imagen, readerArticulos["nombre"], readerArticulos["aprobado"]);
                    foreach (DataGridViewRow row in dtdatos.Rows)
                        row.Height = 100;
                }
            }

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

            dtdatos.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            // Cargando.Show()
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Documentos...";
            My.MyProject.Forms.Cargando.TopMost = true;
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

                }
            }

        }

        private void BackgroundAct_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();

            foreach (DataGridViewRow row in dtdatos.Rows)
            {
                SqlCommand comandoActArticulos;
                string consultaActArticulos;
                consultaActArticulos = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(@"update Articulosempeños set
                                     MontoPrestado = '", row.Cells[8].Value), @"',
                                     Aprobado = '"), row.Cells[11].FormattedValue), @"'
                                      where id = '"), row.Cells[0].Value), "'"));
                comandoActArticulos = new SqlCommand();
                comandoActArticulos.Connection = Module1.conexionempresa;
                comandoActArticulos.CommandText = consultaActArticulos;
                comandoActArticulos.ExecuteNonQuery();

                bool c;
                c = Convert.ToBoolean(row.Cells[11].GetEditedFormattedValue(row.Index, (DataGridViewDataErrorContexts)11));
                if (c)
                {
                    totalArticulosAutorizados += 1;

                }

            }


        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.AgregarDocumentoDatosSolicitudBoleta.Show();
        }

        private void BackgroundDocumentosSolicitud_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();


        }

        private void BackgroundAct_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();

            if (totalArticulosAutorizados > 0)
            {
                btn_a_autorizacion.Visible = true;
                btn_rechazar.Visible = false;
            }
            else
            {
                btn_rechazar.Visible = true;
                btn_a_autorizacion.Visible = false;
            }
            // BackgroundDocumentosSolicitud.RunWorkerAsync()
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
            consultaActEstado = "update Solicitudboleta set estado = 'A', montoautorizado=" + montoTotalAutorizado + ", usuarioautoriza='" + Module1.nmusr + "' where id = '" + idSolicitud + "'";
            comandoActEstado = new SqlCommand();
            comandoActEstado.Connection = Module1.conexionempresa;
            comandoActEstado.CommandText = consultaActEstado;
            comandoActEstado.ExecuteNonQuery();

            double MontoRefrendo;
            MontoRefrendo = porcentajeRefrendo * 0.01d * montoTotalAutorizado * 1.16d;
            SqlCommand comandoCreaEmpeño;
            string consultaCreaEmpeños;
            double interesdiario;
            interesdiario = MontoRefrendo / 7d;

            consultaCreaEmpeños = "insert into Empeños values('" + idcliente + "','" + idSolicitud + "','" + nombreCliente + "','" + montoTotalValuado + "','" + montoTotalAutorizado + "','7','" + MontoRefrendo + "','" + porcentajeRefrendo + "','" + interesdiario + "','" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "','','','','" + idPromotor + "','E','" + txtIne.Text + "','" + montoTotalAutorizado + "','') select SCOPE_IDENTITY()";
            comandoCreaEmpeño = new SqlCommand();
            comandoCreaEmpeño.Connection = Module1.conexionempresa;
            comandoCreaEmpeño.CommandText = consultaCreaEmpeños;
            int idEmpeñoCreado;
            idEmpeñoCreado = Conversions.ToInteger(comandoCreaEmpeño.ExecuteScalar());

            SqlCommand insertCronogramaSolicitud;
            string consultaInsertCronogramaSolicitud;
            consultaInsertCronogramaSolicitud = "insert into CronogramaSolicitudEmpeño values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tiempo + "','" + idSolicitud + "','Se autorizó por " + Module1.nmusr + " y se creó el empeño con el id " + idEmpeñoCreado + "')";
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
                    ((DataGridViewImageColumn)dtdatosDocumentos.Columns[2]).ImageLayout = DataGridViewImageCellLayout.Zoom;
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

            dtdatos.ScrollBars = ScrollBars.Both;

            // Deshabilitamos los botones si solo se tiene que ver la solicitud sin modificarla
            if (verSolicitud)
            {
                btn_Procesar.Enabled = false;
                btn_Procesar.Visible = false;
                dtdatos.Columns[8].ReadOnly = true;
                dtdatos.Columns[11].Visible = false;
            }
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
            // dtdatosDocumentosNuevos.Rows.Clear()
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

                btn_a_autorizacion.Visible = true;
            }

            else
            {
                MessageBox.Show("Faltan Documentos por cargar");
            }
            My.MyProject.Forms.Cargando.Close();
        }





        private void dtdatosDocumentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            My.MyProject.Forms.VistaDocumento.PictureBox1.Image = (Image)dtdatosDocumentos.Rows[dtdatosDocumentos.CurrentRow.Index].Cells[2].FormattedValue;
            My.MyProject.Forms.VistaDocumento.ShowDialog();
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

        private void dtdatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            My.MyProject.Forms.VistaDocumento.PictureBox1.Image = (Image)dtdatos.CurrentRow.Cells[9].FormattedValue;
            My.MyProject.Forms.VistaDocumento.Show();
        }

        private void btn_rechazar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Rechazando Crédito...";
            BackgroundRechazarSolicitud.RunWorkerAsync();
        }

        private void BackgroundRechazarSolicitud_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string tiempo = DateAndTime.TimeOfDay.ToString("HH:mm:ss");
            SqlCommand comandoActEstado;
            string consultaActEstado;
            consultaActEstado = "update SolicitudBoleta set estado = 'R',autorizadoPor='" + Module1.nmusr + "',montoAutorizado = '0' where id = '" + idSolicitud + "'";
            comandoActEstado = new SqlCommand();
            comandoActEstado.Connection = Module1.conexionempresa;
            comandoActEstado.CommandText = consultaActEstado;
            comandoActEstado.ExecuteNonQuery();




            SqlCommand insertCronogramaSolicitud;
            string consultaInsertCronogramaSolicitud;
            consultaInsertCronogramaSolicitud = "insert into CronogramaSolicitudEmpeño values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tiempo + "','" + idSolicitud + "','Se rechazó por " + Module1.nmusr + "')";
            insertCronogramaSolicitud = new SqlCommand();
            insertCronogramaSolicitud.Connection = Module1.conexionempresa;
            insertCronogramaSolicitud.CommandText = consultaInsertCronogramaSolicitud;
            insertCronogramaSolicitud.ExecuteNonQuery();
        }

        private void dtdatos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            montoTotalAutorizado = 0d;
            foreach (DataGridViewRow row in dtdatos.Rows)
            {
                bool c;
                c = Convert.ToBoolean(row.Cells[11].GetEditedFormattedValue(row.Index, (DataGridViewDataErrorContexts)11));
                if (c)
                {
                    montoTotalAutorizado = montoTotalAutorizado + Conversion.Val(row.Cells[8].Value);
                }
            }
        }

        private void BackgroundRechazarSolicitud_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            Invoke(new Action(() => My.MyProject.Forms.SolicitudesEmpeños.cargarSolicitudes()));

            My.MyProject.Forms.Cargando.Close();
            Close();
        }
    }
}