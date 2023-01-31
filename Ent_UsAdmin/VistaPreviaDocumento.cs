using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    public partial class VistaPreviaDocumento
    {
        private FileStream fs;
        public string ruta;

        public VistaPreviaDocumento()
        {
            InitializeComponent();
        }
        private void VistaPreviaDocumento_Load(object sender, EventArgs e)
        {
            // Gnostice.Documents.Framework.ActivateLicense("91AC-D09C-5AC7-097C-A379-1765-615B-D9E2")
            // Dim fs As FileStream
            fs = File.OpenRead(ruta);
            // Dim fs As StreamReader
            // fs = New StreamReader(ruta)
            DocumentViewer1.LoadDocument(fs);
            // fs.Close()
            // DocumentPrinter1.LoadDocument("C:\ConfiaAdmin\SATI\TEMPDOCS\TempPagare.docx")
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DocumentPrinter1.PrintDocument.PrinterSettings.PrinterName = Module1.ImpresoraPredeterminada;

            DocumentPrinter1.Print(fs);
            // DocumentPrinter1.PageScaling = Gnostice.Core.Printer.PageScalingOptions.Fit
            // DocumentPrinter1.Print("C:\ConfiaAdmin\SATI\TEMPDOCS\TempPagare.docx")
        }

        private void VistaPreviaDocumento_Closing(object sender, CancelEventArgs e)
        {
            fs.Close();
            DocumentViewer1.CloseDocument();
            // DocumentViewer1.CloseDocument()
            // DocumentViewer1.ActiveDocument.CloseDocument()
            // DocumentViewer1.Dispose()
        }

        private void VistaPreviaDocumento_FormClosed(object sender, FormClosedEventArgs e)
        {

            // DocumentViewer1.ActiveDocument.CloseDocument()

            // DocumentViewer1.LoadDocument("C:\ConfiaAdmin\SATI\Calendario.docx")
            // My.Computer.FileSystem.DeleteFile("C:\ConfiaAdmin\SATI\TEMPDOCS\TempPagare.docx",
            // Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
            // Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently,
            // Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DocumentViewer1.CloseDocument();
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
    }
}