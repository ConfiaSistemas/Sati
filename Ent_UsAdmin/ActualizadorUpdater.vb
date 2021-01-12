Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.IO.Compression
Imports System.IO.Compression.ZipFile
Imports Ionic.Zip
Public Class ActualizadorUpdater
    Dim tamañoA As Double
    Dim NombreA As String
    Dim NuevoTam As Double
    Dim arg As String
    Dim TipoEquipo As String
    Dim zip1 As Ionic.Zip.ZipFile
    Private TotalSize As ULong = 0

    Private ExtractedSize As ULong = 0

    Private LastBtsTransfered As ULong = 0

    Private BufferSize As ULong = 0

    Dim TargetDir As String = ""
    Public Function DownloadSingleFile(ftpAddress As String,
                                          ftpUser As String,
                                          ftpPassword As String,
                                          fileToDownload As String,
                                          downloadTargetFolder As String,
                                          deleteAfterDownload As Boolean,
                                          ExceptionInfo As Exception) As Boolean

        Dim FileDownloaded As Boolean = False

        Try
            Dim sFtpFile As String

            sFtpFile = ftpAddress & fileToDownload

            Dim sTargetFileName = System.IO.Path.GetFileName(sFtpFile)
            sTargetFileName = sTargetFileName.Replace("/", "\")
            sTargetFileName = downloadTargetFolder & sTargetFileName
            Dim wtotalsize As Double

            Dim clsRequest As System.Net.FtpWebRequest = System.Net.WebRequest.Create(sFtpFile)
            clsRequest.Credentials = New Net.NetworkCredential("rc0wqsx371ca", "Si5t3Ma$")
            clsRequest.Method = System.Net.WebRequestMethods.Ftp.GetFileSize


            Dim listResponse As System.Net.FtpWebResponse = clsRequest.GetResponse
            wtotalsize = listResponse.ContentLength
            tamañoA = wtotalsize
            NombreA = sTargetFileName
            If System.IO.File.Exists(NombreA) = True Then
                System.IO.File.Delete(NombreA)
            End If

            'ProgressDescarga.MaxValue = tamañoA
            ' Timer1.Start()
            My.Computer.Network.DownloadFile(sFtpFile, sTargetFileName, ftpUser, ftpPassword)

            If deleteAfterDownload Then
                Dim ftpRequest As FtpWebRequest = Nothing

                ftpRequest = CType(WebRequest.Create(sFtpFile), FtpWebRequest)

                With ftpRequest
                    .Credentials = New NetworkCredential(ftpUser, ftpPassword)
                    .Method = WebRequestMethods.Ftp.DeleteFile
                End With

                Dim response As FtpWebResponse = CType(ftpRequest.GetResponse(), FtpWebResponse)
                response.Close()

                ftpRequest = Nothing

                FileDownloaded = True

            End If

        Catch ex As Exception
            ExceptionInfo = ex
        End Try

        Return FileDownloaded
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Label1.Text = tamañoA
        If (tamañoA / 1024) > 1024 Then
            lblTamaño.Text = Math.Round(((tamañoA / 1024) / 1024), 2).ToString() & " Mb"
        Else
            lblTamaño.Text = Math.Round((tamañoA / 1024), 2).ToString() & " Kb"
        End If
        lblDescargado.Text = getTamFile(NombreA)
        If NombreA <> "" Then
            Dim fi As New FileInfo(NombreA)
            If fi.Exists Then
                lblProgreso.Text = Convert.ToInt32((fi.Length * 100) / tamañoA) & "%"
            End If

        Else

        End If

    End Sub
    Public Function getTamFile(ByVal path As String) As String
        If path IsNot Nothing Then
            Dim fi As New FileInfo(path)
            If fi.Exists Then
                If (fi.Length / 1024) > 1024 Then
                    Return Math.Round(((fi.Length / 1024) / 1024), 2).ToString() & " Mb"
                Else
                    Return Math.Round((fi.Length / 1024), 2).ToString() & " Kb"
                End If
            Else
                Return String.Empty
            End If
        End If

    End Function

    Private Sub ActualizadorUpdater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSistema.Text = "UPDATER"
        lblEstado.Text = "Descargando"
        Panel1.BackColor = Color.FromArgb(13, 74, 235)
        Panel2.BackColor = Color.FromArgb(214, 220, 237)
        RadLabel1.ForeColor = Color.FromArgb(214, 220, 237)
        RadLabel2.ForeColor = Color.FromArgb(214, 220, 237)
        lblDescargado.ForeColor = Color.FromArgb(214, 220, 237)
        lblProgreso.ForeColor = Color.FromArgb(214, 220, 237)
        lblTamaño.ForeColor = Color.FromArgb(214, 220, 237)



        Timer1.Start()
        BackgroundWorker1.RunWorkerAsync()
    End Sub
    Dim FicheiroJaExtraidos As Integer = 0

    Private Sub BackgroundDescomprimir_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundDescomprimir.DoWork
        Dim ZipToUnpack As String = NombreA
        Dim TargetDir As String = "C1P3SML"

        Using zip1 = Ionic.Zip.ZipFile.Read(ZipToUnpack)
            AddHandler zip1.ExtractProgress, AddressOf FileExtractProgress
            Dim se As ZipEntry

            ' here, we extract every entry, but we could extract    
            ' based on entry name, size, date, etc.   
            For Each se In zip1


                se.Extract("C:\ConfiaAdmin\Updater\", ExtractExistingFileAction.OverwriteSilently)


                FicheiroJaExtraidos = FicheiroJaExtraidos + 1
                Dim Porcentagem As Integer

                ' Porcentagem = ProgressBar1.Value / ProgressBar1.Maximum * 100 ' get percentage

                lblDescompreso.Text = String.Format("{0}", (FicheiroJaExtraidos))
                lblTotalArchivos.Text = String.Format("{0}", zip1.EntryFileNames.Count)
                lblProgresoDescompresion.Text = Convert.ToInt32((FicheiroJaExtraidos * 100) / zip1.EntryFileNames.Count) & "%"
                lblArchivo.Text = String.Format("{0}", se.FileName)
                'SetStatusText(String.Format(Porcentagem & "%" & "  ---->  " & "{0} of {1} files...({2})", (FicheiroJaExtraidos), zip1.EntryFileNames.Count, se.FileName))
            Next
        End Using
        zip1.Dispose()

    End Sub

    Private Delegate Sub FileExtractProgressDel(ByVal sender As Object, ByVal e As ExtractProgressEventArgs)



    Private Sub FileExtractProgress(ByVal sender As Object, ByVal e As ExtractProgressEventArgs)

        'check if the form requires to be invoked and invoke a new FileExtractProgressDel delagate

        If Me.InvokeRequired Then

            Me.Invoke(New FileExtractProgressDel(AddressOf FileExtractProgress), New Object() {sender, e})

        Else

            'if the reported BytesTransferred is greater than 0 then add the number of bytes that where transferred to the ExtractedSize variable

            'and set the LastBtsTransfered to the number of bytes that have been transferred so far. Else reset the LastBtsTransfered to 0.

            If e.BytesTransferred > 0 Then

                ExtractedSize += CULng(e.BytesTransferred - LastBtsTransfered)

                LastBtsTransfered = CULng(e.BytesTransferred)

            Else

                LastBtsTransfered = 0

            End If



            'again, if the total size is greater than Integer.MaxValue then divide the ExtractedSize by 1024 before setting the ProgressBar.Value

            If TotalSize >= Integer.MaxValue Then

                'ProgressBar1.Value = CInt(ExtractedSize / 1024)

            Else

                'ProgressBar1.Value = CInt(ExtractedSize)

            End If

        End If

    End Sub
    Private Delegate Sub SetStatusTextInvoker(ByVal Text As String)




    Private Sub SetStatusText(ByVal Text As String)

        ' System.Threading.Thread.Sleep(6) ' not needed but here for future reference

        If Me.InvokeRequired Then

            Me.Invoke(New SetStatusTextInvoker(AddressOf SetStatusText), Text)

        Else

            lblArchivo.Text = Text

        End If

    End Sub

    Private Sub BackgroundDescomprimir_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundDescomprimir.RunWorkerCompleted
        lblEstado.Text = "Terminado"
        'zip1 = Nothing
        Timer1.Stop()

        Timer1.Enabled = False
        If System.IO.File.Exists(NombreA) = True Then
            System.IO.File.Delete(NombreA)
        End If




    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim ex As Exception
        ex = New Exception


        ' Timer1.Start()

        If System.IO.File.Exists("C:\ConfiaAdmin\Actualizaciones\Updater\Debug.zip") = True Then
            System.IO.File.Delete("C:\ConfiaAdmin\Actualizaciones\Updater\Debug.zip")
        End If
        DownloadSingleFile("ftp://prestamosconfia.com/actualizaciones/Updater/", "rc0wqsx371ca", "Si5t3Ma$", "Debug.zip", "C:\ConfiaAdmin\Actualizaciones\Updater\", False, ex)

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Dim ZipToUnpack As String = NombreA

        TargetDir = "C:\ConfiaAdmin\Updater\"





        zip1 = Ionic.Zip.ZipFile.Read(ZipToUnpack)



        AddHandler zip1.ExtractProgress, AddressOf FileExtractProgress



        'reset these values each time you unzip a folder

        BufferSize = CULng(zip1.BufferSize)

        TotalSize = 0

        ExtractedSize = 0



        'get the total size in bytes to be extracted

        For Each ent As ZipEntry In zip1

            TotalSize += CULng(ent.UncompressedSize)

        Next


        'if the total size is greater than Integer.MaxValue then divide it down by 1024 before setting the ProgressBar.Maximum

        If TotalSize >= Integer.MaxValue Then

            'ProgressBar1.Maximum = CInt(TotalSize / 1024)

        Else

            ' ProgressBar1.Maximum = CInt(TotalSize)

        End If
        Panel2.BackColor = Color.FromArgb(13, 74, 235)
        Panel1.BackColor = Color.FromArgb(214, 220, 237)
        RadLabel1.ForeColor = Color.FromArgb(13, 74, 235)
        RadLabel2.ForeColor = Color.FromArgb(13, 74, 235)
        lblDescargado.ForeColor = Color.FromArgb(13, 74, 235)
        lblProgreso.ForeColor = Color.FromArgb(13, 74, 235)
        lblTamaño.ForeColor = Color.FromArgb(13, 74, 235)

        RadLabel5.ForeColor = Color.FromArgb(214, 220, 237)
        RadLabel4.ForeColor = Color.FromArgb(214, 220, 237)
        lblDescompreso.ForeColor = Color.FromArgb(214, 220, 237)
        lblProgresoDescompresion.ForeColor = Color.FromArgb(214, 220, 237)
        lblTotalArchivos.ForeColor = Color.FromArgb(214, 220, 237)
        lblArchivo.ForeColor = Color.FromArgb(214, 220, 237)


        lblEstado.Text = "Descomprimiendo"
        'Panel1.Visible = False

        BackgroundDescomprimir.RunWorkerAsync()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()

    End Sub
End Class