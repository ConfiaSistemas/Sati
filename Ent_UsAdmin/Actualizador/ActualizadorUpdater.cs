using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Ionic.Zip;

namespace ConfiaAdmin
{
    public partial class ActualizadorUpdater
    {
        private double tamañoA;
        private string NombreA;
        private double NuevoTam;
        private string arg;
        private string TipoEquipo;
        private ZipFile zip1;
        private ulong TotalSize = 0UL;

        private ulong ExtractedSize = 0UL;

        private ulong LastBtsTransfered = 0UL;

        private ulong BufferSize = 0UL;

        private string TargetDir = "";

        public ActualizadorUpdater()
        {
            InitializeComponent();
        }
        public bool DownloadSingleFile(string ftpAddress, string ftpUser, string ftpPassword, string fileToDownload, string downloadTargetFolder, bool deleteAfterDownload, Exception ExceptionInfo)
        {

            bool FileDownloaded = false;

            try
            {
                string sFtpFile;

                sFtpFile = ftpAddress + fileToDownload;

                string sTargetFileName = Path.GetFileName(sFtpFile);
                sTargetFileName = sTargetFileName.Replace("/", @"\");
                sTargetFileName = downloadTargetFolder + sTargetFileName;
                double wtotalsize;

                FtpWebRequest clsRequest = (FtpWebRequest)WebRequest.Create(sFtpFile);
                clsRequest.Credentials = new NetworkCredential("rc0wqsx371ca", "Si5t3Ma$");
                clsRequest.Method = WebRequestMethods.Ftp.GetFileSize;


                FtpWebResponse listResponse = (FtpWebResponse)clsRequest.GetResponse();
                wtotalsize = listResponse.ContentLength;
                tamañoA = wtotalsize;
                NombreA = sTargetFileName;
                if (File.Exists(NombreA) == true)
                {
                    File.Delete(NombreA);
                }

                // ProgressDescarga.MaxValue = tamañoA
                // Timer1.Start()
                My.MyProject.Computer.Network.DownloadFile(sFtpFile, sTargetFileName, ftpUser, ftpPassword);

                if (deleteAfterDownload)
                {
                    FtpWebRequest ftpRequest = null;

                    ftpRequest = (FtpWebRequest)WebRequest.Create(sFtpFile);

                    {
                        ref var withBlock = ref ftpRequest;
                        withBlock.Credentials = new NetworkCredential(ftpUser, ftpPassword);
                        withBlock.Method = WebRequestMethods.Ftp.DeleteFile;
                    }

                    FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse();
                    response.Close();

                    ftpRequest = null;

                    FileDownloaded = true;

                }
            }

            catch (Exception ex)
            {
                ExceptionInfo = ex;
            }

            return FileDownloaded;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Label1.Text = tamañoA
            if (tamañoA / 1024d > 1024d)
            {
                lblTamaño.Text = Math.Round(tamañoA / 1024d / 1024d, 2).ToString() + " Mb";
            }
            else
            {
                lblTamaño.Text = Math.Round(tamañoA / 1024d, 2).ToString() + " Kb";
            }
            lblDescargado.Text = getTamFile(NombreA);
            if (!string.IsNullOrEmpty(NombreA))
            {
                var fi = new FileInfo(NombreA);
                if (fi.Exists)
                {
                    lblProgreso.Text = Convert.ToInt32(fi.Length * 100L / tamañoA) + "%";
                }
            }

            else
            {

            }

        }
        public string getTamFile(string path)
        {
            if (path != null)
            {
                var fi = new FileInfo(path);
                if (fi.Exists)
                {
                    if (fi.Length / 1024d > 1024d)
                    {
                        return Math.Round(fi.Length / 1024d / 1024d, 2).ToString() + " Mb";
                    }
                    else
                    {
                        return Math.Round(fi.Length / 1024d, 2).ToString() + " Kb";
                    }
                }
                else
                {
                    return string.Empty;
                }
            }
            else
            {
                return string.Empty;
            }

         

        }

        private void ActualizadorUpdater_Load(object sender, EventArgs e)
        {
            lblSistema.Text = "UPDATER";
            lblEstado.Text = "Descargando";
            Panel1.BackColor = Color.FromArgb(13, 74, 235);
            Panel2.BackColor = Color.FromArgb(214, 220, 237);
            RadLabel1.ForeColor = Color.FromArgb(214, 220, 237);
            RadLabel2.ForeColor = Color.FromArgb(214, 220, 237);
            lblDescargado.ForeColor = Color.FromArgb(214, 220, 237);
            lblProgreso.ForeColor = Color.FromArgb(214, 220, 237);
            lblTamaño.ForeColor = Color.FromArgb(214, 220, 237);



            Timer1.Start();
            BackgroundWorker1.RunWorkerAsync();
        }
        private int FicheiroJaExtraidos = 0;

        private void BackgroundDescomprimir_DoWork(object sender, DoWorkEventArgs e)
        {
            string ZipToUnpack = NombreA;
            string TargetDir = "C1P3SML";

            using (var zip1 = ZipFile.Read(ZipToUnpack))
            {
                zip1.ExtractProgress += FileExtractProgress;

                // here, we extract every entry, but we could extract    
                // based on entry name, size, date, etc.   
                foreach (var se in zip1)
                {


                    se.Extract(@"C:\ConfiaAdmin\Updater\", ExtractExistingFileAction.OverwriteSilently);


                    FicheiroJaExtraidos = FicheiroJaExtraidos + 1;
                    int Porcentagem;

                    // Porcentagem = ProgressBar1.Value / ProgressBar1.Maximum * 100 ' get percentage

                    lblDescompreso.Text = string.Format("{0}", FicheiroJaExtraidos);
                    lblTotalArchivos.Text = string.Format("{0}", zip1.EntryFileNames.Count);
                    lblProgresoDescompresion.Text = Convert.ToInt32(FicheiroJaExtraidos * 100 / (double)zip1.EntryFileNames.Count) + "%";
                    lblArchivo.Text = string.Format("{0}", se.FileName);
                    // SetStatusText(String.Format(Porcentagem & "%" & "  ---->  " & "{0} of {1} files...({2})", (FicheiroJaExtraidos), zip1.EntryFileNames.Count, se.FileName))
                }
            }
            zip1.Dispose();

        }

        private delegate void FileExtractProgressDel(object sender, ExtractProgressEventArgs e);



        private void FileExtractProgress(object sender, ExtractProgressEventArgs e)
        {

            // check if the form requires to be invoked and invoke a new FileExtractProgressDel delagate

            if (InvokeRequired)
            {

                Invoke(new FileExtractProgressDel(FileExtractProgress), new object[] { sender, e });
            }

            else
            {

                // if the reported BytesTransferred is greater than 0 then add the number of bytes that where transferred to the ExtractedSize variable

                // and set the LastBtsTransfered to the number of bytes that have been transferred so far. Else reset the LastBtsTransfered to 0.

                if (e.BytesTransferred > 0L)
                {

                    ExtractedSize += (ulong)Math.Round(e.BytesTransferred - (decimal)LastBtsTransfered);

                    LastBtsTransfered = (ulong)e.BytesTransferred;
                }

                else
                {

                    LastBtsTransfered = 0UL;

                }



                // again, if the total size is greater than Integer.MaxValue then divide the ExtractedSize by 1024 before setting the ProgressBar.Value

                if (TotalSize >= (decimal)int.MaxValue)
                {
                }

                // ProgressBar1.Value = CInt(ExtractedSize / 1024)

                else
                {

                    // ProgressBar1.Value = CInt(ExtractedSize)

                }

            }

        }
        private delegate void SetStatusTextInvoker(string Text);




        private void SetStatusText(string Text)
        {

            // System.Threading.Thread.Sleep(6) ' not needed but here for future reference

            if (InvokeRequired)
            {

                Invoke(new SetStatusTextInvoker(SetStatusText), Text);
            }

            else
            {

                lblArchivo.Text = Text;

            }

        }

        private void BackgroundDescomprimir_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblEstado.Text = "Terminado";
            // zip1 = Nothing
            Timer1.Stop();

            Timer1.Enabled = false;
            if (File.Exists(NombreA) == true)
            {
                File.Delete(NombreA);
            }




        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Exception ex;
            ex = new Exception();


            // Timer1.Start()

            if (File.Exists(@"C:\ConfiaAdmin\Actualizaciones\Updater\Debug.zip") == true)
            {
                File.Delete(@"C:\ConfiaAdmin\Actualizaciones\Updater\Debug.zip");
            }
            DownloadSingleFile("ftp://prestamosconfia.com/actualizaciones/Updater/", "rc0wqsx371ca", "Si5t3Ma$", "Debug.zip", @"C:\ConfiaAdmin\Actualizaciones\Updater\", false, ex);

        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string ZipToUnpack = NombreA;

            TargetDir = @"C:\ConfiaAdmin\Updater\";





            zip1 = ZipFile.Read(ZipToUnpack);



            zip1.ExtractProgress += FileExtractProgress;



            // reset these values each time you unzip a folder

            BufferSize = (ulong)zip1.BufferSize;

            TotalSize = 0UL;

            ExtractedSize = 0UL;



            // get the total size in bytes to be extracted

            foreach (ZipEntry ent in zip1)


                TotalSize += (ulong)ent.UncompressedSize;


            // if the total size is greater than Integer.MaxValue then divide it down by 1024 before setting the ProgressBar.Maximum

            if (TotalSize >= (decimal)int.MaxValue)
            {
            }

            // ProgressBar1.Maximum = CInt(TotalSize / 1024)

            else
            {

                // ProgressBar1.Maximum = CInt(TotalSize)

            }
            Panel2.BackColor = Color.FromArgb(13, 74, 235);
            Panel1.BackColor = Color.FromArgb(214, 220, 237);
            RadLabel1.ForeColor = Color.FromArgb(13, 74, 235);
            RadLabel2.ForeColor = Color.FromArgb(13, 74, 235);
            lblDescargado.ForeColor = Color.FromArgb(13, 74, 235);
            lblProgreso.ForeColor = Color.FromArgb(13, 74, 235);
            lblTamaño.ForeColor = Color.FromArgb(13, 74, 235);

            RadLabel5.ForeColor = Color.FromArgb(214, 220, 237);
            RadLabel4.ForeColor = Color.FromArgb(214, 220, 237);
            lblDescompreso.ForeColor = Color.FromArgb(214, 220, 237);
            lblProgresoDescompresion.ForeColor = Color.FromArgb(214, 220, 237);
            lblTotalArchivos.ForeColor = Color.FromArgb(214, 220, 237);
            lblArchivo.ForeColor = Color.FromArgb(214, 220, 237);


            lblEstado.Text = "Descomprimiendo";
            // Panel1.Visible = False

            BackgroundDescomprimir.RunWorkerAsync();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}