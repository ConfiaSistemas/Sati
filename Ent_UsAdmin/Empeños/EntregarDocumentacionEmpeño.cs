using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Spire.Doc;
using Xceed.Words.NET;

namespace ConfiaAdmin
{

    public partial class EntregarDocumentacionEmpeño
    {
        public string nombreEmpeñoAentregar;
        public double montoAentregar;
        public double montoRefrendo;
        private double montoValuado;
        public int plazoRefrendo;
        public double porcentajeRefrendo;
        private int idSolicitudAentregar;
        public int idEmpeñoAentregar;
        public int idClienteAentregar;
        public string NombreClienteAentregar;
        // Public modalidadAentregar As String
        private System.Data.DataTable dataArticulos;
        private SqlDataAdapter adapterArticulos;
        private string diaDepago, Ine, Domicilio, Colonia, Entidad, Municipio, Telefono;
        private int CodigoPostal;
        public string estadoCredito;
        // Dim fechaCredito As Date
        private DateTime fechaPimerPago;
        private DateTime fechaEntrega;
        private double interes;
        private string NombreUsuario, UsuarioCaptura;
        private Cargando nCargando;

        public EntregarDocumentacionEmpeño()
        {
            InitializeComponent();
        }
        private void EntregarDocumentacion_Load(object sender, EventArgs e)
        {
            BunifuImageButton1.Image = null;
            CheckForIllegalCrossThreadCalls = false;
            BunifuImageButton1.AllowDrop = true;
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando datos";
            BackgroundWorker1.RunWorkerAsync();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            SqlCommand comando;
            string consulta;
            SqlDataReader reader;
            consulta = "select Empeños.Nombre,MontoPrestado,Montorefrendo,Empeños.MontoValuado,Empeños.PlazoRefrendo,Empeños.PorcentajeRefrendo,IdSolicitudBoleta,Empeños.idCLiente,Clientes.Nombre + ' ' + Clientes.ApellidoPaterno + ' ' + Clientes.ApellidoMaterno as nombreCliente,Empeños.estado,empeños.fechaentrega,DATENAME(dw, empeños.fechaentrega)as diaDePago, " + "SolicitudBoleta.Ine, SolicitudBoleta.Domicilio, SolicitudBoleta.CodigoPostal, SolicitudBoleta.Colonia, SolicitudBoleta.Municipio, SolicitudBoleta.Entidad, SolicitudBoleta.Telefono, SolicitudBoleta.UsuarioCaptura from Empeños inner join Clientes on Empeños.IdCliente = Clientes.id inner join SolicitudBoleta on SolicitudBoleta.id=Empeños.idSolicitudBoleta" + " where Empeños.id = '" + idEmpeñoAentregar + "'";
            comando = new SqlCommand();
            comando.Connection = Module1.conexionempresa;
            comando.CommandText = consulta;
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                nombreEmpeñoAentregar = Conversions.ToString(reader["Nombre"]);
                montoAentregar = Conversions.ToDouble(reader["MontoPrestado"]);
                if (!(reader["Fechaentrega"] is DBNull))
                {
                    fechaEntrega = Conversions.ToDate(reader["fechaentrega"]);
                }
                montoRefrendo = Conversions.ToDouble(reader["MontoRefrendo"]);
                plazoRefrendo = Conversions.ToInteger(reader["PlazoRefrendo"]);
                porcentajeRefrendo = Conversions.ToDouble(reader["PorcentajeRefrendo"]);
                idSolicitudAentregar = Conversions.ToInteger(reader["IdSolicitudBoleta"]);
                idClienteAentregar = Conversions.ToInteger(reader["idCliente"]);
                NombreClienteAentregar = Conversions.ToString(reader["nombreCliente"]);
                estadoCredito = Conversions.ToString(reader["Estado"]);
                Ine = Conversions.ToString(reader["Ine"]);
                Domicilio = Conversions.ToString(reader["Domicilio"]);
                Colonia = Conversions.ToString(reader["Colonia"]);
                CodigoPostal = Conversions.ToInteger(reader["CodigoPostal"]);
                Entidad = Conversions.ToString(reader["Entidad"]);
                Municipio = Conversions.ToString(reader["Municipio"]);
                Telefono = Conversions.ToString(reader["Telefono"]);
                interes = Conversions.ToDouble(reader["PorcentajeRefrendo"]);
                diaDepago = Conversions.ToString(reader["diaDePago"]);
                montoValuado = Conversions.ToDouble(reader["MontoValuado"]);
                UsuarioCaptura = Conversions.ToString(reader["UsuarioCaptura"]);

            }
            reader.Close();
            string consultaArticulos;
            consultaArticulos = "select Descripcion,TipoArticulosEmpeño.nombre as Tipo,Marca,Modelo,NoSerie,MontoValuado,MontoPrestado from ArticulosEmpeños inner join TipoArticulosEmpeño on TipoArticulosEmpeño.id=articulosempeños.tipo where idSolicitud=" + idSolicitudAentregar;
            adapterArticulos = new SqlDataAdapter(consultaArticulos, Module1.conexionempresa);
            dataArticulos = new System.Data.DataTable();
            adapterArticulos.Fill(dataArticulos);

            Module1.iniciarconexion();
            System.Data.OleDb.OleDbCommand comandoUsuario;
            string consultaUsuario;
            consultaUsuario = "select nm_complete from usr where nm='" + UsuarioCaptura + "'";
            comandoUsuario = new System.Data.OleDb.OleDbCommand();
            comandoUsuario.Connection = Module1.conexion;
            comandoUsuario.CommandText = consultaUsuario;
            NombreUsuario = Conversions.ToString(comandoUsuario.ExecuteScalar());
            Module1.conexion.Close();


        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            lblNombre.Text = nombreEmpeñoAentregar;
            lblMonto.Text = Strings.FormatCurrency(montoAentregar);
            My.MyProject.Forms.Cargando.Close();
            switch (estadoCredito ?? "")
            {
                case "E":
                    {
                        if (fechaEntrega != Conversions.ToDate("1900-01-01"))
                        {
                            btn_Testimonial.Visible = true;
                            btn_Contrato.Visible = true;
                            btn_Webcam.Visible = true;
                            BunifuImageButton1.Visible = true;
                            btn_Boleta.Visible = true;
                            labelimagen.Visible = true;
                            btn_activarEmpeño.Visible = true;
                            btn_EntregarEmpeño.Visible = false;
                        }
                        else
                        {
                            btn_EntregarEmpeño.Visible = true;
                        }

                        break;
                    }
                case "A":
                    {

                        btn_Testimonial.Visible = true;
                        btn_Contrato.Visible = true;
                        btn_Boleta.Visible = true;
                        break;
                    }
                    // BunifuThinButton23.Visible = False
                    // BunifuImageButton1.Visible = False
                    // labelimagen.Visible = False
                    // btn_activar.Visible = False
            }
        }


        private void BackgroundContrato_DoWork(object sender, DoWorkEventArgs e)
        {
            var NumeroLetra = new NumLetra();

            FileSystem.FileCopy(@"C:\ConfiaAdmin\SATI\ContratoEmpeño.docx", @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempContratoEmpeño.docx");
            // Reemplazamos las etiquetas del contrato
            var documento = DocX.Load(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempContratoEmpeño.docx");
            documento.ReplaceText("%dia%", fechaEntrega.ToString("dd"));
            documento.ReplaceText("%mes%", Conversions.ToDate(fechaEntrega).ToString("MMMM"));
            documento.ReplaceText("%año%", Conversions.ToDate(fechaEntrega).ToString("yyyy"));
            documento.ReplaceText("%folio%", idEmpeñoAentregar.ToString());
            documento.ReplaceText("%nombreCliente%", NombreClienteAentregar);
            documento.ReplaceText("%numeroIdentificacion%", Ine);
            documento.ReplaceText("%domicilio%", Domicilio);
            documento.ReplaceText("%colonia%", Colonia);
            documento.ReplaceText("%codigoPostal%", CodigoPostal.ToString());
            documento.ReplaceText("%ciudad%", Municipio);
            documento.ReplaceText("%estado%", Entidad);
            documento.ReplaceText("%telefono%", Telefono);
            documento.ReplaceText("%correo%", "-");
            documento.ReplaceText("%cotitular%", "-");
            documento.ReplaceText("%domicilioCotitular%", "-");
            documento.ReplaceText("%coloniaCotitular%", "-");
            documento.ReplaceText("%codigoPostalCotitular%", "-");
            documento.ReplaceText("%ciudadCotitular%", "-");
            documento.ReplaceText("%nombreBeneficiario%", "-");
            documento.ReplaceText("%montoPrestado%", Strings.FormatCurrency(montoAentregar));
            documento.ReplaceText("%montoTotalDeuda%", Strings.FormatCurrency(montoAentregar + montoRefrendo * 52d));
            documento.ReplaceText("%fechaRefrendo%", Conversions.ToDate(fechaEntrega.AddDays(7d)).ToString("dd-MMMM-yyyy"));
            documento.ReplaceText("%numeroDeRefrendos%", "52");
            documento.ReplaceText("%interesRefrendo%", porcentajeRefrendo.ToString());
            documento.ReplaceText("%Iva%", Strings.FormatCurrency(montoRefrendo / 1.16d * 0.16d));
            documento.ReplaceText("%montoDesempeño%", Strings.FormatCurrency(montoRefrendo + montoAentregar));
            documento.ReplaceText("%montoRefrendo%", Strings.FormatCurrency(montoRefrendo));
            documento.ReplaceText("%diaDePago%", diaDepago);
            documento.ReplaceText("%montoValuadoTotal%", Strings.FormatCurrency(montoValuado));
            documento.ReplaceText("%montoValuadoLetra%", NumeroLetra.Convertir(montoValuado.ToString(), false));
            documento.ReplaceText("%porcentajePrestamo%", Strings.FormatNumber(montoAentregar * 100d / montoValuado, 2));
            documento.ReplaceText("%fechaVentaPrenda%", Conversions.ToDate(fechaEntrega.AddMonths(1)).ToString("dd-MMMM-yyyy"));
            documento.ReplaceText("%fechaLimiteFiniquito%", Conversions.ToDate(fechaEntrega.AddYears(1)).ToString("dd-MMMM-yyyy"));
            documento.ReplaceText("%nombreValuador%", NombreUsuario);
            // Definimos una variable que cuente el numero de articulo a empeñar
            int numeroArticulos = 0;
            foreach (DataRow row in dataArticulos.Rows)
            {
                // Sustituimos las etiquetas dentro de la tabla de artículos
                if (numeroArticulos == 0)
                {
                    documento.ReplaceText("%descripcion%", row["Descripcion"].ToString());
                    documento.ReplaceText("%caracteristicas%",string.Concat(row["Tipo"].ToString(), ", Marca: ", row["Marca"].ToString(), ", Modelo: ", row["Modelo"].ToString(), ", No. de Serie: ", row["NoSerie"].ToString()));
                    documento.ReplaceText("%montoValuadoPrenda%", Strings.FormatCurrency(row["MontoValuado"]));
                    documento.ReplaceText("%montoPrestadoPrenda%", Strings.FormatCurrency(row["MontoPrestado"]));
                    documento.ReplaceText("%porcentajePrestamoPrenda%", Strings.FormatNumber(Operators.DivideObject(Operators.MultiplyObject(row["MontoPrestado"], 100), row["MontoValuado"]), 2));
                }
                else // Insertamos una fila extra si hay más de un artículo, y añadimos los datos de dicho artículo
                {
                    Xceed.Words.NET.Row rowTable;
                    rowTable = documento.Tables[2].InsertRow(numeroArticulos);
                    rowTable.Cells[0].Paragraphs.First().Append(Conversions.ToString(row["Descripcion"]));
                    rowTable.Cells[1].Paragraphs.First().Append(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(row["Tipo"], ", Marca: "), row["Marca"]), ", Modelo: "), row["Modelo"]), ", No. de Serie: "), row["NoSerie"])));
                    rowTable.Cells[2].Paragraphs.First().Append(Strings.FormatCurrency(row["MontoValuado"]));
                    rowTable.Cells[3].Paragraphs.First().Append(Strings.FormatCurrency(row["MontoPrestado"]));
                    rowTable.Cells[4].Paragraphs.First().Append(Strings.FormatNumber(Operators.DivideObject(Operators.MultiplyObject(row["MontoPrestado"], 100), row["MontoValuado"]), 2) + "%");
                    documento.Tables[1].Rows.Add(rowTable);
                }
                numeroArticulos += 1;
            }
            documento.Save();
            documento.Dispose();
            // Abrimos el documento con word para acomodar el formato de las tablas
            var MSWord = new Microsoft.Office.Interop.Word.Application();
            var Doc = new Microsoft.Office.Interop.Word.Document();
            MSWord = (Microsoft.Office.Interop.Word.Application)Interaction.CreateObject("Word.Application");
            object argFileName = @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempContratoEmpeño.docx";
            Doc = MSWord.Documents.Open(ref argFileName);

            for (int i = 1, loopTo = numeroArticulos; i <= loopTo; i++)
            {
                Doc.Tables[3].Cell(i, 1).Select();
                MSWord.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                Doc.Tables[3].Cell(i, 2).Select();
                MSWord.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
            }
            // Fijamos el ancho de las columnas
            Doc.Tables[3].Columns[1].Width = 162.75f;
            Doc.Tables[3].Columns[2].Width = 155.95f;
            Doc.Tables[3].Columns[3].Width = 63.8f;
            Doc.Tables[3].Columns[4].Width = 63.8f;
            Doc.Tables[3].Columns[5].Width = 70.9f;
            Doc.Save();
            Doc.Close();
            MSWord.Application.Quit();
        }

        private void btn_Contrato_Click(object sender, EventArgs e)
        {
            nCargando = new Cargando();
            nCargando.MonoFlat_Label1.Text = "Generando Contrato...";
            nCargando.Show();
            nCargando.TopMost = true;
            BackgroundContrato.RunWorkerAsync();
        }

        private void BackgroundContrato_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            nCargando.Close();
            My.MyProject.Forms.VistaPreviaDocumento.ruta = @"C: \ConfiaAdmin\SATI\TEMPDOCS\TempContratoEmpeño.docx";
            My.MyProject.Forms.VistaPreviaDocumento.Show();
            // BackgroundCalendario.RunWorkerAsync()
        }

        private void BackgroundEntrega_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();

            SqlCommand comandoFecha;
            string consultaFecha;
            DateTime Fecha;
            consultaFecha = "select fechaEntrega from Empeños where id= '" + idEmpeñoAentregar + "'";
            comandoFecha = new SqlCommand();
            comandoFecha.Connection = Module1.conexionempresa;
            comandoFecha.CommandText = consultaFecha;
            Fecha = Conversions.ToDate(comandoFecha.ExecuteScalar());

            if (Fecha == Conversions.ToDate("1900-01-01"))
            {
                SqlCommand comandoActEmpeño;
                string consultaActEmpeño;
                consultaActEmpeño = "update Empeños set fechaEntrega = GETDATE() where id = '" + idEmpeñoAentregar + "'";
                comandoActEmpeño = new SqlCommand();
                comandoActEmpeño.Connection = Module1.conexionempresa;
                comandoActEmpeño.CommandText = consultaActEmpeño;
                comandoActEmpeño.ExecuteNonQuery();
            }
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            BackgroundEntrega.RunWorkerAsync();
        }

        private void BackgroundEntrega_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando datos";
            BackgroundWorker1.RunWorkerAsync();
            // BackgroundPagare.RunWorkerAsync()

        }

        private void dataTableToWord(System.Data.DataTable dt)
        {
            Microsoft.Office.Interop.Word.Application Word;
            Microsoft.Office.Interop.Word.Document Doc;
            Microsoft.Office.Interop.Word.Table Table;
            Range Rng;

            Word = (Microsoft.Office.Interop.Word.Application)Interaction.CreateObject("Word.Application");

            FileSystem.FileCopy(@"C:\ConfiaAdmin\SATI\Calendario.docx", @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendario.docx");
            object argFileName = @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendario.docx";
            Doc = Word.Documents.Open(ref argFileName);
            int NCol = dt.Columns.Count;
            int NRow = dt.Rows.Count;
            // alternativo

            object argIndex = @"\endofdoc";
            Table = Doc.Tables.Add(Doc.Bookmarks[ref argIndex].Range, dt.Rows.Count + 1, dt.Columns.Count);

            // Agregando Los Campos De La Grilla
            for (int i = 1, loopTo = NCol; i <= loopTo; i++)
                Table.Cell(1, i).Range.Text = dt.Columns[i - 1].ColumnName.ToString();
            // Agregando Los Registros A La Tabla
            for (int Fila = 0, loopTo1 = NRow - 1; Fila <= loopTo1; Fila++)
            {
                for (int Col = 0, loopTo2 = NCol - 1; Col <= loopTo2; Col++)
                {
                    if (!ReferenceEquals(dt.Rows[NRow - 1][Col].ToString(), DBNull.Value))
                    {
                        Table.Cell(Fila + 2, Col + 1).Range.Text = dt.Rows[Fila][Col].ToString();
                    }
                }
                // Incremento

            }
            // Negrita y Kursiva Para Los Nombres De Los Campos
            Table.Rows[1].Range.Font.Bold = Conversions.ToInteger(true);
            Table.Rows[1].Range.Font.Italic = Conversions.ToInteger(false);
            for (int i = 1, loopTo3 = Table.Rows.Count; i <= loopTo3; i++)
                Table.Rows[i].Range.Font.Size = 10f;


            // Boder De La Tabla
            Table.Borders.InsideLineStyle = WdLineStyle.wdLineStyleEngrave3D;
            Table.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleEngrave3D;
            Table.Borders.InsideColor = WdColor.wdColorBlack;
            object argIndex1 = @"\endofdoc";
            Rng = Doc.Bookmarks[ref argIndex1].Range;
            Rng.InsertParagraphAfter();

            Doc.Save();
            Doc.Close();
            // Word = Nothing
            Word.Application.Quit();
        }

        private void BackgroundTestimonial_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();

            SqlCommand comandoFechaEntrega;
            string consultaFechaEntrega;
            consultaFechaEntrega = "Select FechaEntrega, Nombre, idSolicitudBoleta from Empeños where id = '" + idEmpeñoAentregar + "'";
            SqlDataReader readerFechaEntrega;
            comandoFechaEntrega = new SqlCommand();
            comandoFechaEntrega.Connection = Module1.conexionempresa;
            comandoFechaEntrega.CommandText = consultaFechaEntrega;
            readerFechaEntrega = comandoFechaEntrega.ExecuteReader();
            while (readerFechaEntrega.Read())
            {
                fechaEntrega = Conversions.ToDate(readerFechaEntrega["FechaEntrega"]);
                nombreEmpeñoAentregar = Conversions.ToString(readerFechaEntrega["Nombre"]);
                idSolicitudAentregar = Conversions.ToInteger(readerFechaEntrega["idSolicitudBoleta"]);
            }
            readerFechaEntrega.Close();
            System.Data.DataTable dataArticulos;
            SqlDataAdapter adapterArticulos;
            string consultaArticulos;

            consultaArticulos = "select ArticulosEmpeños.Descripcion, ArticulosEmpeños.Marca, ArticulosEmpeños.Modelo, ArticulosEmpeños.NoSerie, ArticulosEmpeños.MontoValuado, TipoArticulosEmpeño.Nombre from ArticulosEmpeños inner join TipoArticulosEmpeño on TipoArticulosEmpeño.id=ArticulosEmpeños.Tipo where ArticulosEmpeños.idSolicitud = '" + idSolicitudAentregar + "'";
            adapterArticulos = new SqlDataAdapter(consultaArticulos, Module1.conexionempresa);
            dataArticulos = new System.Data.DataTable();
            adapterArticulos.Fill(dataArticulos);
            // dataTableToWord(dataCalendario)

            try
            {
                FileSystem.FileCopy(@"C:\ConfiaAdmin\SATI\TestimonialEmpeño.docx", @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempTestimonialEmpeño.docx");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo del formato");
                // Finally
                // BackgroundTestimonial.WorkerSupportsCancellation = True
                // BackgroundTestimonial.CancelAsync()
                // 'If BackgroundTestimonial.CancellationPending Then
                // e.Cancel = True
                // 'End If
            }

            var documento = DocX.Load(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempTestimonialEmpeño.docx");

            documento.ReplaceText("%dia%", fechaEntrega.ToString("dd"));
            documento.ReplaceText("%mes%", Conversions.ToDate(fechaEntrega).ToString("MMMM").ToUpper());
            documento.ReplaceText("%año%", Conversions.ToDate(fechaEntrega).ToString("yyyy"));
            documento.ReplaceText("%nombre%", nombreEmpeñoAentregar);

            int nArticulos = 0;
            foreach (DataRow row in dataArticulos.Rows)
            {
                if (nArticulos == 0)
                {
                    documento.ReplaceText("%descripcion%",string.Concat( "Tipo de Artículo: ", row["Nombre"].ToString(), "; Descripción: ", row["Descripcion"].ToString()));
                    documento.ReplaceText("%caracteristicas%",string.Concat("Marca: ", row["Marca"].ToString(), "; Modelo: ", row["Modelo"].ToString(), "; No. de Serie: ", row["NoSerie"].ToString()));
                    documento.ReplaceText("%montoValuadoPrenda%", Strings.FormatCurrency(row["MontoValuado"]));
                    nArticulos += 1;
                    documento.Save();
                    documento.Dispose();
                }
                else
                {
                    // Dim parrafo As String
                    // Dim parra As Xceed.Words.NET.Paragraph
                    // parrafo = "Descripción: " & row("Descripcion") & ", Marca: " & row("Marca") & ", Modelo: " & row("Modelo") & ", No de Serie: " & row("NoSerie") & ", Valuado en: " & FormatCurrency(row("MontoValuado"))
                    // documento.InsertParagraph(1, parrafo)
                    // parra = documento.InsertParagraph(3, parrafo, False)



                    nArticulos += 1;

                }
            }

            // Usamos word para agregar más elementos a la lista si hay más de un artículo
            if (nArticulos > 1)
            {
                Microsoft.Office.Interop.Word.Application Word;
                Microsoft.Office.Interop.Word.Document Doc;
                Word = (Microsoft.Office.Interop.Word.Application)Interaction.CreateObject("Word.Application");
                object argFileName = @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempTestimonialEmpeño.docx";
                Doc = Word.Documents.Open(ref argFileName);
                for (int i = 2, loopTo = nArticulos; i <= loopTo; i++)
                {
                    Doc.Paragraphs[i + 5].Range.InsertParagraphAfter();
                    // Doc.Lists(1).Range.InsertParagraphAfter()
                    // Word.Selection.InsertParagraphAfter()               
                    Doc.Paragraphs[i + 6].Range.ListFormat.ApplyNumberDefault();
                    Doc.Paragraphs[i + 5].Format.SpaceAfter = 10f;
                    if (i == nArticulos)
                    {
                        Doc.Paragraphs[i + 6].Format.SpaceAfter = 18f;
                    }
                    Doc.Paragraphs[i + 6].SelectNumber();
                    // Word.Selection.TypeText(Convert.ToString("werwerwerwer" & n(0)))
                    Word.Selection.Text = Convert.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Tipo de Articulo: ", dataArticulos.Rows[i - 1][5]), "; Descripción: "), dataArticulos.Rows[i - 1][0]), "; Marca: "), dataArticulos.Rows[i - 1][1]), "; Modelo: "), dataArticulos.Rows[i - 1][2]), "; No. de Serie: "), dataArticulos.Rows[i - 1][3]), "; Valuado en:"), Strings.FormatCurrency(dataArticulos.Rows[i - 1][4])));
                    // Doc.Paragraphs(i + 6).Range.ListFormat.ApplyNumberDefault()
                }
                Doc.Save();
                Doc.Close();
                Word.Application.Quit();
            }


        }

        private void BackgroundTestimonial_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            nCargando.Close();
            My.MyProject.Forms.VistaPreviaDocumento.ruta = @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempTestimonialEmpeño.docx";
            My.MyProject.Forms.VistaPreviaDocumento.Show();


        }
        private void BunifuImageButton1_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {

                    var strRutaArchivoImagen = e.Data.GetData(DataFormats.Text) as string;

                    int i;

                    // Asignamos la primera posición del array de ruta de archivos a la variable de tipo string

                    // declarada anteriormente ya que en este caso sólo mostraremos una imagen en el control.
                   // var textData = e.Data.GetData(DataFormats.Text) as string;
                  

                    // La cargamos al control
                  
                    BunifuImageButton1.Load(strRutaArchivoImagen);
                }
                labelimagen.Visible = false;
            }
            catch (ArgumentException ex)
            {
                Interaction.MsgBox("Archivo no válido", MsgBoxStyle.Exclamation);
            }

        }

        private void BunifuImageButton1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {

                // Los archivos son externos a nuestra aplicación por lo que de indicaremos All ya que dará lo mismo.

                e.Effect = DragDropEffects.All;

            }

        }


        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog();
            string nombre;
            openFileDialog1.Filter = "Imágenes (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg;*.jpeg;*.png";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.ShowDialog();
            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                nombre = openFileDialog1.FileName;
                BunifuImageButton1.Image = System.Drawing.Image.FromFile(nombre);
                labelimagen.Visible = false;
            }

            else
            {
                MessageBox.Show("No se seleccionó ningún archivo");

            }
        }

        private void BunifuThinButton23_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.webcamEmpeño.Show();
        }

        private void btn_activar_Click(object sender, EventArgs e)
        {
            if (BunifuImageButton1.Image != null)
            {
                My.MyProject.Forms.Cargando.Show();
                My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Activando Crédito";
                BackgroundActivar.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Para activar el crédito es necesario cargar una imagen del cliente");
            }

        }

        private void BackgroundActivar_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();

            SqlCommand comandoDocumento;
            string consultaDocumento;
            Bitmap imagen = BunifuImageButton1.Image as Bitmap;
            var NuevaImagen = ImagenComprimida(imagen);
            consultaDocumento = "insert into DocumentosEmpeño values('" + idEmpeñoAentregar + "','4',@Documento)";
            var imgDocumento = new SqlParameter("@Documento", SqlDbType.Image);
            var msImgDocumento = new MemoryStream();
            NuevaImagen.Save(msImgDocumento, ImageFormat.Jpeg);
            imgDocumento.Value = msImgDocumento.GetBuffer();
            comandoDocumento = new SqlCommand();
            comandoDocumento.Connection = Module1.conexionempresa;
            comandoDocumento.CommandText = consultaDocumento;
            comandoDocumento.Parameters.Add(imgDocumento);
            comandoDocumento.ExecuteNonQuery();

            SqlCommand comandoActCredito;
            string consultaActCredito;
            consultaActCredito = "Update Empeños set estado = 'A' where id = '" + idEmpeñoAentregar + "'";
            comandoActCredito = new SqlCommand();
            comandoActCredito.Connection = Module1.conexionempresa;
            comandoActCredito.CommandText = consultaActCredito;
            comandoActCredito.ExecuteNonQuery();



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
        private void BackgroundActivar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando datos";
            BackgroundWorker1.RunWorkerAsync();
        }

        private void Btn_Testimonial_Click(object sender, EventArgs e)
        {
            nCargando = new Cargando();
            nCargando.MonoFlat_Label1.Text = "Generando Documento Testimonial...";
            nCargando.Show();
            My.MyProject.Forms.Cargando.TopMost = true;

            BackgroundTestimonial.RunWorkerAsync();
        }
        private void WordDocViewer(string fileName)
        {
            try
            {
                Process.Start(fileName);
            }
            catch
            {

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

        private void BackgroundBoleta_DoWork(object sender, DoWorkEventArgs e)
        {
            var NumeroLetra = new NumLetra();

            FileSystem.FileCopy(@"C:\ConfiaAdmin\SATI\BoletaEmpeño.docx", @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempBoletaEmpeño.docx");
            // Reemplazamos las etiquetas del contrato
            var documento = DocX.Load(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempBoletaEmpeño.docx");
            documento.ReplaceText("%dia%", fechaEntrega.ToString("dd"));
            documento.ReplaceText("%mes%", Conversions.ToDate(fechaEntrega).ToString("MMMM"));
            documento.ReplaceText("%año%", Conversions.ToDate(fechaEntrega).ToString("yyyy"));
            documento.ReplaceText("%folio%", idEmpeñoAentregar.ToString());
            documento.ReplaceText("%nombreCliente%", NombreClienteAentregar);
            documento.ReplaceText("%numeroIdentificacion%", Ine);
            documento.ReplaceText("%domicilio%", Domicilio);
            documento.ReplaceText("%colonia%", Colonia);
            documento.ReplaceText("%codigoPostal%", CodigoPostal.ToString());
            documento.ReplaceText("%ciudad%", Municipio);
            documento.ReplaceText("%estado%", Entidad);
            documento.ReplaceText("%telefono%", Telefono);
            documento.ReplaceText("%correo%", "-");
            documento.ReplaceText("%cotitular%", "-");
            documento.ReplaceText("%domicilioCotitular%", "-");
            documento.ReplaceText("%coloniaCotitular%", "-");
            documento.ReplaceText("%codigoPostalCotitular%", "-");
            documento.ReplaceText("%ciudadCotitular%", "-");
            documento.ReplaceText("%nombreBeneficiario%", "-");
            documento.ReplaceText("%montoPrestado%", Strings.FormatCurrency(montoAentregar));
            documento.ReplaceText("%montoTotalDeuda%", Strings.FormatCurrency(montoAentregar + montoRefrendo * 52d));
            documento.ReplaceText("%fechaRefrendo%", Conversions.ToDate(fechaEntrega.AddDays(7d)).ToString("dd-MMMM-yyyy"));
            documento.ReplaceText("%numeroDeRefrendos%", "52");
            documento.ReplaceText("%interesRefrendo%", porcentajeRefrendo.ToString());
            documento.ReplaceText("%Iva%", Strings.FormatCurrency(montoRefrendo / 1.16d * 0.16d));
            documento.ReplaceText("%montoDesempeño%", Strings.FormatCurrency(montoRefrendo + montoAentregar));
            documento.ReplaceText("%montoRefrendo%", Strings.FormatCurrency(montoRefrendo));
            documento.ReplaceText("%diaDePago%", diaDepago);
            documento.ReplaceText("%montoValuadoTotal%", Strings.FormatCurrency(montoValuado));
            documento.ReplaceText("%montoValuadoLetra%", NumeroLetra.Convertir(montoValuado.ToString(), false));
            documento.ReplaceText("%porcentajePrestamo%", Strings.FormatNumber(montoAentregar * 100d / montoValuado, 2));
            documento.ReplaceText("%fechaVentaPrenda%", Conversions.ToDate(fechaEntrega.AddMonths(1)).ToString("dd-MMMM-yyyy"));
            documento.ReplaceText("%fechaLimiteFiniquito%", Conversions.ToDate(fechaEntrega.AddYears(1)).ToString("dd-MMMM-yyyy"));
            documento.ReplaceText("%nombreValuador%", NombreUsuario);
            // Definimos una variable que cuente el numero de articulo a empeñar
            int numeroArticulos = 0;
            foreach (DataRow row in dataArticulos.Rows)
            {
                // Sustituimos las etiquetas dentro de la tabla de artículos
                if (numeroArticulos == 0)
                {
                    documento.ReplaceText("%descripcion%", row["Descripcion"].ToString());
                    documento.ReplaceText("%caracteristicas%", string.Concat(row["Tipo"].ToString(), ", Marca: ", row["Marca"].ToString(), ", Modelo: ", row["Modelo"].ToString(), ", No. de Serie: ", row["NoSerie"].ToString()));
                    documento.ReplaceText("%montoValuadoPrenda%", Strings.FormatCurrency(row["MontoValuado"]));
                    documento.ReplaceText("%montoPrestadoPrenda%", Strings.FormatCurrency(row["MontoPrestado"]));
                    documento.ReplaceText("%porcentajePrestamoPrenda%", Strings.FormatNumber(Operators.DivideObject(Operators.MultiplyObject(row["MontoPrestado"], 100), row["MontoValuado"]), 2));
                }
                else // Insertamos una fila extra si hay más de un artículo, y añadimos los datos de dicho artículo
                {
                    Xceed.Words.NET.Row rowTable;
                    rowTable = documento.Tables[2].InsertRow(numeroArticulos);
                    rowTable.Cells[0].Paragraphs.First().Append(Conversions.ToString(row["Descripcion"]));
                    rowTable.Cells[1].Paragraphs.First().Append(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(row["Tipo"], ", Marca: "), row["Marca"]), ", Modelo: "), row["Modelo"]), ", No. de Serie: "), row["NoSerie"])));
                    rowTable.Cells[2].Paragraphs.First().Append(Strings.FormatCurrency(row["MontoValuado"]));
                    rowTable.Cells[3].Paragraphs.First().Append(Strings.FormatCurrency(row["MontoPrestado"]));
                    rowTable.Cells[4].Paragraphs.First().Append(Strings.FormatNumber(Operators.DivideObject(Operators.MultiplyObject(row["MontoPrestado"], 100), row["MontoValuado"]), 2) + "%");
                    documento.Tables[1].Rows.Add(rowTable);
                }
                numeroArticulos += 1;
            }
            documento.Save();
            documento.Dispose();
            // Abrimos el documento con word para acomodar el formato de las tablas
            var MSWord = new Microsoft.Office.Interop.Word.Application();
            var Doc = new Microsoft.Office.Interop.Word.Document();
            MSWord = (Microsoft.Office.Interop.Word.Application)Interaction.CreateObject("Word.Application");
            object argFileName = @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempBoletaEmpeño.docx";
            Doc = MSWord.Documents.Open(ref argFileName);

            for (int i = 1, loopTo = numeroArticulos; i <= loopTo; i++)
            {
                Doc.Tables[3].Cell(i, 1).Select();
                MSWord.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                Doc.Tables[3].Cell(i, 2).Select();
                MSWord.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
            }
            // Fijamos el ancho de las columnas
            Doc.Tables[3].Columns[1].Width = 162.75f;
            Doc.Tables[3].Columns[2].Width = 155.95f;
            Doc.Tables[3].Columns[3].Width = 63.8f;
            Doc.Tables[3].Columns[4].Width = 63.8f;
            Doc.Tables[3].Columns[5].Width = 70.9f;
            Doc.Save();
            Doc.Close();
            MSWord.Application.Quit();

        }

        private void BackgroundBoleta_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            nCargando.Close();
            My.MyProject.Forms.VistaPreviaDocumento.ruta = @"C: \ConfiaAdmin\SATI\TEMPDOCS\TempBoletaEmpeño.docx";
            My.MyProject.Forms.VistaPreviaDocumento.Show();

        }

        private void BunifuThinButton24_Click(object sender, EventArgs e)
        {
            nCargando = new Cargando();
            nCargando.Show();
            nCargando.MonoFlat_Label1.Text = "Generando Boleta de Empeño";
            nCargando.TopMost = true;
            BackgroundBoleta.RunWorkerAsync();

        }

  

        private void btnTarjeta_Click(object sender, EventArgs e)
        {
            BackgroundTarjeta.RunWorkerAsync();
        }
        private void gen_qr_file(string file_name, string content, int image_size)
        {
            string new_file_name = file_name;
            var qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            var qrCode = new QrCode();
            qrEncoder.TryEncode(content, out qrCode);
            var renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            var ms = new MemoryStream();
            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var imageTemp = new Bitmap(ms);
            var image = new Bitmap(imageTemp, new Size(new System.Drawing.Point(image_size, image_size)));
            image.Save(new_file_name + ".png", ImageFormat.Png);
        }

        private void btn_EntregarEmpeño_Click(object sender, EventArgs e)
        {
            BackgroundEntrega.RunWorkerAsync();
        }
    }
}