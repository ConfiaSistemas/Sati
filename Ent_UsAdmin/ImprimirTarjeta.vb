Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports Xceed.Words.NET
Imports Microsoft.Office.Interop.Word
Imports System.Globalization
Imports System.Drawing.Imaging
Imports System.IO
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields
Imports Gma.QrCodeNet.Encoding
Imports Gma.QrCodeNet.Encoding.Windows.Render

Public Class ImprimirTarjeta
    Dim ncargando As Cargando
    Public idCredito As String

    Dim idCliente, idClienteStr As String


    Dim nombreCliente As String

    Private Sub ImprimirConvenio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando Información"
        Cargando.TopMost = True
        BackgroundConvenio.RunWorkerAsync()

    End Sub

    Private Sub BackgroundImprimirAtras_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundImprimirAtras.DoWork
        Dim spDoc As New Spire.Doc.Document
        spDoc.LoadFromFile("C:\ConfiaAdmin\SATI\Tarjeta atras.docx")
        Dim dialog As New PrintPreviewDialog

        ' dialog.AllowCurrentPage = True
        ' dialog.AllowSomePages = True
        ' dialog.UseEXDialog = True
        ncargando.Close()

        Try
            '  spDoc.PrintDialog = dialog.
            spDoc.PrintDocument.PrinterSettings.PrinterName = ImpresoraPredeterminada

            dialog.Document = spDoc.PrintDocument
            dialog.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btn_calendario_Click(sender As Object, e As EventArgs) Handles btn_calendario.Click
        ncargando = New Cargando

        ncargando.Show()
        ncargando.MonoFlat_Label1.Text = "Generando Formato"
        BackgroundImprimirAtras.RunWorkerAsync()
    End Sub

    Private Sub BackgroundImprimirFrente_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundImprimirFrente.DoWork
        FileCopy("C:\ConfiaAdmin\SATI\Tarjeta frente.docx", "C:\ConfiaAdmin\SATI\TEMPDOCS\TempTarjetaFrente.docx")
        Dim documento As DocX = DocX.Load("C:\ConfiaAdmin\SATI\TEMPDOCS\TempTarjetaFrente.docx")
        documento.ReplaceText("%%NOMBRECLIENTE%%", nombreCliente)
        documento.Save()
        documento.Dispose()

        Dim document As New Spire.Doc.Document
        document.LoadFromFile("C:\ConfiaAdmin\SATI\TEMPDOCS\TempTarjetafrente.docx")
        Dim selections As TextSelection() = document.FindAllString("%%QR%%", True, True)
        Dim index As Integer = 0
        Dim range As TextRange = Nothing
        gen_qr_file("C:\ConfiaAdmin\SATI\TEMPDOCS\QR", idClienteStr, 50)
        Dim qr As New Bitmap("C:\ConfiaAdmin\SATI\TEMPDOCS\QR.png")

        For Each selection As TextSelection In selections
            Dim pic As DocPicture = New DocPicture(document)
            pic.LoadImage(qr)
            range = selection.GetAsOneRange()
            index = range.OwnerParagraph.ChildObjects.IndexOf(range)
            range.OwnerParagraph.ChildObjects.Insert(index, pic)
            range.OwnerParagraph.ChildObjects.Remove(range)
        Next

        document.SaveToFile("C:\ConfiaAdmin\SATI\TEMPDOCS\TempTarjetafrente.docx", FileFormat.Doc)
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub gen_qr_file(ByVal file_name As String, ByVal content As String, ByVal image_size As Integer)
        Dim new_file_name As String = file_name
        Dim qrEncoder As QrEncoder = New QrEncoder(ErrorCorrectionLevel.H)
        Dim qrCode As QrCode = New QrCode()
        qrEncoder.TryEncode(content, qrCode)
        Dim renderer As GraphicsRenderer = New GraphicsRenderer(New FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White)
        Dim ms As MemoryStream = New MemoryStream()
        renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms)
        Dim imageTemp = New Bitmap(ms)
        Dim image = New Bitmap(imageTemp, New Size(New System.Drawing.Point(image_size, image_size)))
        image.Save(new_file_name & ".png", ImageFormat.Png)
    End Sub

    Private Sub btn_convenio_Click(sender As Object, e As EventArgs) Handles btn_convenio.Click
        ncargando = New Cargando

        ncargando.Show()
        ncargando.MonoFlat_Label1.Text = "Generando Formato"
        ncargando.TopMost = True
        BackgroundImprimirFrente.RunWorkerAsync()

    End Sub

    Private Sub BackgroundConvenio_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundConvenio.DoWork
        iniciarconexionempresa()
        Dim comandoCliente As SqlCommand
        Dim consultaCliente As String
        Dim readerCliente As SqlDataReader

        consultaCliente = "select id,CONCAT(Clientes.Nombre,' ',Clientes.ApellidoPaterno,' ',Clientes.ApellidoMaterno) as nombre,idstr from clientes  where id= '" & idCredito & "'"
        comandoCliente = New SqlCommand
        comandoCliente.Connection = conexionempresa
        comandoCliente.CommandText = consultaCliente
        readerCliente = comandoCliente.ExecuteReader
        If readerCliente.HasRows Then
            While readerCliente.Read

                idCliente = readerCliente("id")
                idClienteStr = readerCliente("idstr")

                nombreCliente = readerCliente("nombre")

            End While
        End If
        readerCliente.Close()


    End Sub

    Private Sub BackgroundConvenio_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundConvenio.RunWorkerCompleted
        Cargando.Close()
    End Sub



    Private Sub BackgroundImprimirAtras_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundImprimirAtras.RunWorkerCompleted

        ncargando.Close()



    End Sub

    Private Sub BackgroundImprimirFrente_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundImprimirFrente.RunWorkerCompleted
        Dim spDoc As New Spire.Doc.Document
        spDoc.LoadFromFile("C:\ConfiaAdmin\SATI\TEMPDOCS\TempTarjetaFrente.docx")


        Dim Dialog As New PrintPreviewDialog

        ' dialog.AllowCurrentPage = True
        ' dialog.AllowSomePages = True
        ' dialog.UseEXDialog = True
        ncargando.Close()

        Try
            '  spDoc.PrintDialog = dialog.
            spDoc.PrintDocument.PrinterSettings.PrinterName = ImpresoraPredeterminada

            Dialog.Document = spDoc.PrintDocument
            Dialog.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class