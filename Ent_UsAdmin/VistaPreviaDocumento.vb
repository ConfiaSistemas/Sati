Imports System.ComponentModel
Imports System.IO
Imports Gnostice.Documents
Public Class VistaPreviaDocumento
    Dim fs As FileStream
    Public ruta As String
    Private Sub VistaPreviaDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  Gnostice.Documents.Framework.ActivateLicense("91AC-D09C-5AC7-097C-A379-1765-615B-D9E2")
        '  Dim fs As FileStream
        fs = System.IO.File.OpenRead(ruta)
        ' Dim fs As StreamReader
        ' fs = New StreamReader(ruta)
        DocumentViewer1.LoadDocument(fs)
        ' fs.Close()
        'DocumentPrinter1.LoadDocument("C:\ConfiaAdmin\SATI\TEMPDOCS\TempPagare.docx")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DocumentPrinter1.PrintDocument.PrinterSettings.PrinterName = ImpresoraPredeterminada

        DocumentPrinter1.Print(fs)
        ' DocumentPrinter1.PageScaling = Gnostice.Core.Printer.PageScalingOptions.Fit
        ' DocumentPrinter1.Print("C:\ConfiaAdmin\SATI\TEMPDOCS\TempPagare.docx")
    End Sub

    Private Sub VistaPreviaDocumento_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        fs.Close()
        DocumentViewer1.CloseDocument()
        ' DocumentViewer1.CloseDocument()
        'DocumentViewer1.ActiveDocument.CloseDocument()
        '  DocumentViewer1.Dispose()
    End Sub

    Private Sub VistaPreviaDocumento_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        'DocumentViewer1.ActiveDocument.CloseDocument()

        '   DocumentViewer1.LoadDocument("C:\ConfiaAdmin\SATI\Calendario.docx")
        ' My.Computer.FileSystem.DeleteFile("C:\ConfiaAdmin\SATI\TEMPDOCS\TempPagare.docx",
        'Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
        'Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently,
        'Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DocumentViewer1.CloseDocument()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub
End Class