using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Xceed.Words.NET;

namespace ConfiaAdmin
{

    public partial class ImprimirTarjeta
    {
        private Cargando ncargando;
        public string idCredito;

        private string idCliente, idClienteStr;


        private string nombreCliente;

        public ImprimirTarjeta()
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

        private void BackgroundImprimirAtras_DoWork(object sender, DoWorkEventArgs e)
        {
            var spDoc = new Spire.Doc.Document();
            spDoc.LoadFromFile(@"C:\ConfiaAdmin\SATI\Tarjeta atras.docx");
            var dialog = new PrintPreviewDialog();

            // dialog.AllowCurrentPage = True
            // dialog.AllowSomePages = True
            // dialog.UseEXDialog = True
            ncargando.Close();

            try
            {
                // spDoc.PrintDialog = dialog.
                spDoc.PrintDocument.PrinterSettings.PrinterName = Module1.ImpresoraTarjetas;

                dialog.Document = spDoc.PrintDocument;
                dialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_calendario_Click(object sender, EventArgs e)
        {
            ncargando = new Cargando();

            ncargando.Show();
            ncargando.MonoFlat_Label1.Text = "Generando Formato";
            BackgroundImprimirAtras.RunWorkerAsync();
        }

        private void BackgroundImprimirFrente_DoWork(object sender, DoWorkEventArgs e)
        {
            FileSystem.FileCopy(@"C:\ConfiaAdmin\SATI\Tarjeta frente.docx", @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempTarjetaFrente.docx");
            var documento = DocX.Load(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempTarjetaFrente.docx");
            documento.ReplaceText("%%NOMBRECLIENTE%%", nombreCliente);
            documento.Save();
            documento.Dispose();

            var document = new Spire.Doc.Document();
            document.LoadFromFile(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempTarjetafrente.docx");
            var selections = document.FindAllString("%%QR%%", true, true);
            int index = 0;
            TextRange range = null;
            gen_qr_file(@"C:\ConfiaAdmin\SATI\TEMPDOCS\QR", idClienteStr, 50);
            var qr = new Bitmap(@"C:\ConfiaAdmin\SATI\TEMPDOCS\QR.png");

            foreach (TextSelection selection in selections)
            {
                var pic = new DocPicture(document);
                pic.LoadImage(qr);
                range = selection.GetAsOneRange();
                index = range.OwnerParagraph.ChildObjects.IndexOf(range);
                range.OwnerParagraph.ChildObjects.Insert(index, pic);
                range.OwnerParagraph.ChildObjects.Remove(range);
            }

            document.SaveToFile(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempTarjetafrente.docx", FileFormat.Doc);
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Module_resize.MoveForm(this);
            }
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

        private void btn_convenio_Click(object sender, EventArgs e)
        {
            ncargando = new Cargando();

            ncargando.Show();
            ncargando.MonoFlat_Label1.Text = "Generando Formato";
            ncargando.TopMost = true;
            BackgroundImprimirFrente.RunWorkerAsync();

        }

        private void BackgroundConvenio_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            SqlCommand comandoCliente;
            string consultaCliente;
            SqlDataReader readerCliente;

            consultaCliente = "select id,CONCAT(Clientes.Nombre,' ',Clientes.ApellidoPaterno,' ',Clientes.ApellidoMaterno) as nombre,idstr from clientes  where id= '" + idCredito + "'";
            comandoCliente = new SqlCommand();
            comandoCliente.Connection = Module1.conexionempresa;
            comandoCliente.CommandText = consultaCliente;
            readerCliente = comandoCliente.ExecuteReader();
            if (readerCliente.HasRows)
            {
                while (readerCliente.Read())
                {

                    idCliente = Conversions.ToString(readerCliente["id"]);
                    idClienteStr = Conversions.ToString(readerCliente["idstr"]);

                    nombreCliente = Conversions.ToString(readerCliente["nombre"]);

                }
            }
            readerCliente.Close();


        }

        private void BackgroundConvenio_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();
        }



        private void BackgroundImprimirAtras_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            ncargando.Close();



        }

        private void BackgroundImprimirFrente_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var spDoc = new Spire.Doc.Document();
            spDoc.LoadFromFile(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempTarjetaFrente.docx");


            var Dialog = new PrintPreviewDialog();

            // dialog.AllowCurrentPage = True
            // dialog.AllowSomePages = True
            // dialog.UseEXDialog = True
            ncargando.Close();

            try
            {
                // spDoc.PrintDialog = dialog.
                spDoc.PrintDocument.PrinterSettings.PrinterName = Module1.ImpresoraTarjetas;

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