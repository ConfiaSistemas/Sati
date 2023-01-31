using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Spire.Doc;
using Xceed.Words.NET;

namespace ConfiaAdmin
{

    public partial class ImprimirReestructura
    {
        public string idCredito;
        private System.Data.DataTable dataCalendario;
        private SqlDataAdapter adapterCalendario;
        private string idConvenio;
        private int canPagos;
        private double moratorios, DeudaCredito, TotalDeuda;
        private DateTime fechaInicio, FechaFin, FechaConvenio;
        private string nombreCliente, nombreCredito, domicilio;

        public ImprimirReestructura()
        {
            InitializeComponent();
        }

        private void ImprimirConvenio_Load(object sender, EventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Información";
            My.MyProject.Forms.Cargando.TopMost = true;
            BackgroundConvenio.RunWorkerAsync();

        }

        private void BackgroundImprimirCalendario_DoWork(object sender, DoWorkEventArgs e)
        {
            dataTableToWord(dataCalendario);

        }

        private void btn_calendario_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Generando Calendario";
            BackgroundImprimirCalendario.RunWorkerAsync();
        }

        private void BackgroundImprimirConvenio_DoWork(object sender, DoWorkEventArgs e)
        {
            FileSystem.FileCopy(@"C:\ConfiaAdmin\SATI\Reestructura.docx", @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempReestructura.docx");
            var documento = DocX.Load(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempReestructura.docx");
            documento.ReplaceText("%%FECHACONVENIO%%", FechaConvenio.ToString("dd/MM/yyyy"));

            documento.ReplaceText("%%NOMBRECLIENTE%%", nombreCliente);
            documento.ReplaceText("%%TOTALDEUDA%%", Strings.FormatCurrency(TotalDeuda));
            documento.ReplaceText("%%CANTPAGOS%%", canPagos.ToString());
            documento.ReplaceText("%%FECHAPRIMERPAGO%%", fechaInicio.ToString("dd/MM/yyyy"));
            documento.ReplaceText("%%FECHAULTIMOPAGO%%", FechaFin.ToString("dd/MM/yyyy"));
            documento.ReplaceText("%%DOMICILIOCLIENTE%%", domicilio);
            documento.Save();
            documento.Dispose();
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Module_resize.MoveForm(this);
            }
        }

        private void btn_convenio_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Generando Convenio";
            My.MyProject.Forms.Cargando.TopMost = true;
            BackgroundImprimirConvenio.RunWorkerAsync();

        }

        private void BackgroundConvenio_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            SqlCommand comandoConvenio;
            string consultaConvenio;
            SqlDataReader readerConvenio;

            consultaConvenio = "select ReestructurasSac.*,Credito.Nombre as nombreCredito,CONCAT(Clientes.Nombre,' ',Clientes.ApellidoPaterno,' ',Clientes.ApellidoMaterno) as nombre, CONCAT(DatosSolicitud.Calle,' ',DatosSolicitud.Noext,' ',DatosSolicitud.Colonia) as domicilio from ReestructurasSac inner join  Credito on ReestructurasSac.idCredito = Credito.id inner join Clientes on Credito.IdCliente = Clientes.id inner join DatosSolicitud on Credito.IdSolicitud = DatosSolicitud.IdSolicitud and Credito.IdCliente = DatosSolicitud.IdCliente where ReestructurasSac.idcredito = '" + idCredito + "'";
            comandoConvenio = new SqlCommand();
            comandoConvenio.Connection = Module1.conexionempresa;
            comandoConvenio.CommandText = consultaConvenio;
            readerConvenio = comandoConvenio.ExecuteReader();
            if (readerConvenio.HasRows)
            {
                while (readerConvenio.Read())
                {
                    moratorios = Conversions.ToDouble(readerConvenio["moratorios"]);
                    DeudaCredito = Conversions.ToDouble(readerConvenio["deudacredito"]);
                    TotalDeuda = Conversions.ToDouble(readerConvenio["TotalDeuda"]);
                    FechaConvenio = Conversions.ToDate(readerConvenio["fecha"]);
                    fechaInicio = Conversions.ToDate(readerConvenio["FechaInicio"]);
                    FechaFin = Conversions.ToDate(readerConvenio["fechafinal"]);
                    idConvenio = Conversions.ToString(readerConvenio["id"]);
                    canPagos = Conversions.ToInteger(readerConvenio["CanPagos"]);
                    nombreCliente = Conversions.ToString(readerConvenio["nombre"]);
                    nombreCredito = Conversions.ToString(readerConvenio["nombrecredito"]);
                    domicilio = Conversions.ToString(readerConvenio["domicilio"]);
                }
            }
            readerConvenio.Close();
            string consultaCalendario;
            consultaCalendario = "select format(Fechapago,'dd/MM/yyyy') as 'Fecha de pago',npago as 'Número de pago',format(monto+multas,'C','es-mx') as Monto from calendarioReestructurasSac where idconvenio = '" + idConvenio + "'";
            adapterCalendario = new SqlDataAdapter(consultaCalendario, Module1.conexionempresa);
            dataCalendario = new System.Data.DataTable();
            adapterCalendario.Fill(dataCalendario);

        }

        private void BackgroundConvenio_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();
        }

        private void dataTableToWord(System.Data.DataTable dt)
        {
            Microsoft.Office.Interop.Word.Application Word;
            Microsoft.Office.Interop.Word.Document Doc;
            Microsoft.Office.Interop.Word.Table Table;
            Range Rng;
            Microsoft.Office.Interop.Word.Paragraph Prf1;
            Microsoft.Office.Interop.Word.Paragraph Prf2;
            Microsoft.Office.Interop.Word.Paragraph Prf3;

            Word = (Microsoft.Office.Interop.Word.Application)Interaction.CreateObject("Word.Application");

            FileSystem.FileCopy(@"C:\ConfiaAdmin\SATI\Calendario Reestructura.docx", @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendarioReestructura.docx");
            object argFileName = @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendarioReestructura.docx";
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

        private void BackgroundImprimirCalendario_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var NumeroLetra = new NumLetra();
            // Dim MSWord As New Word.Application
            // Dim Documento As Word.Document
            // Dim fechaActual As Date
            // fechaActual = Now

            // FileCopy("C:\ConfiaAdmin\SATI\Pagare.docx", "C:\ConfiaAdmin\SATI\TEMPDOCS\TempPagare.docx")
            var documento = DocX.Load(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendarioReestructura.docx");
            documento.ReplaceText("%%FECHACONVENIO%%", FechaConvenio.ToString("dd/MM/yyyy"));
            documento.ReplaceText("%%NOMBRECREDITO%%", nombreCredito);
            documento.ReplaceText("%%NOMBRERESPONSABLE%%", nombreCliente);
            documento.ReplaceText("%%IDCONVENIO%%", idConvenio);



            documento.Save();
            documento.Dispose();
            // VistaPreviaDocumento.ruta = "C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendario.docx"
            // VistaPreviaDocumento.Show()
            var spDoc = new Spire.Doc.Document();
            spDoc.LoadFromFile(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendarioReestructura.docx");
            var dialog = new PrintPreviewDialog();

            // dialog.AllowCurrentPage = True
            // dialog.AllowSomePages = True
            // dialog.UseEXDialog = True
            My.MyProject.Forms.Cargando.Close();

            try
            {
                // spDoc.PrintDialog = dialog.
                spDoc.PrintDocument.PrinterSettings.PrinterName = Module1.ImpresoraPredeterminada;

                dialog.Document = spDoc.PrintDocument;
                dialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BackgroundImprimirConvenio_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var spDoc = new Spire.Doc.Document();
            spDoc.LoadFromFile(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempReestructura.docx");


            var Dialog = new PrintPreviewDialog();

            // dialog.AllowCurrentPage = True
            // dialog.AllowSomePages = True
            // dialog.UseEXDialog = True
            My.MyProject.Forms.Cargando.Close();

            try
            {
                // spDoc.PrintDialog = dialog.
                spDoc.PrintDocument.PrinterSettings.PrinterName = Module1.ImpresoraPredeterminada;

                Dialog.Document = spDoc.PrintDocument;
                Dialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}