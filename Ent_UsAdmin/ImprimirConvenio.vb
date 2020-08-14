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

Public Class ImprimirConvenio
    Public idCredito As String
    Dim dataCalendario As Data.DataTable
    Dim adapterCalendario As SqlDataAdapter
    Dim idConvenio As String
    Dim canPagos As Integer
    Dim moratorios, DeudaCredito, TotalDeuda As Double
    Dim fechaInicio, FechaFin, FechaConvenio As Date
    Dim nombreCliente, nombreCredito, domicilio As String

    Private Sub ImprimirConvenio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando Información"
        Cargando.TopMost = True
        BackgroundConvenio.RunWorkerAsync()

    End Sub

    Private Sub BackgroundImprimirCalendario_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundImprimirCalendario.DoWork
        dataTableToWord(dataCalendario)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btn_calendario_Click(sender As Object, e As EventArgs) Handles btn_calendario.Click
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Generando Calendario"
        BackgroundImprimirCalendario.RunWorkerAsync()
    End Sub

    Private Sub BackgroundImprimirConvenio_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundImprimirConvenio.DoWork
        FileCopy("C:\ConfiaAdmin\SATI\Convenio.docx", "C:\ConfiaAdmin\SATI\TEMPDOCS\TempConvenio.docx")
        Dim documento As DocX = DocX.Load("C:\ConfiaAdmin\SATI\TEMPDOCS\TempConvenio.docx")
        documento.ReplaceText("%%FECHACONVENIO%%", FechaConvenio.ToString("dd/MM/yyyy"))

        documento.ReplaceText("%%NOMBRECLIENTE%%", nombreCliente)
        documento.ReplaceText("%%TOTALDEUDA%%", FormatCurrency(TotalDeuda))
        documento.ReplaceText("%%CANTPAGOS%%", canPagos)
        documento.ReplaceText("%%FECHAPRIMERPAGO%%", fechaInicio.ToString("dd/MM/yyyy"))
        documento.ReplaceText("%%FECHAULTIMOPAGO%%", FechaFin.ToString("dd/MM/yyyy"))
        documento.ReplaceText("%%DOMICILIOCLIENTE%%", domicilio)
        documento.Save()
        documento.Dispose()
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub btn_convenio_Click(sender As Object, e As EventArgs) Handles btn_convenio.Click
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Generando Convenio"
        Cargando.TopMost = True
        BackgroundImprimirConvenio.RunWorkerAsync()

    End Sub

    Private Sub BackgroundConvenio_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundConvenio.DoWork
        iniciarconexionempresa()
        Dim comandoConvenio As SqlCommand
        Dim consultaConvenio As String
        Dim readerConvenio As SqlDataReader

        consultaConvenio = "select ConveniosSac.*,Credito.Nombre as nombreCredito,CONCAT(Clientes.Nombre,' ',Clientes.ApellidoPaterno,' ',Clientes.ApellidoMaterno) as nombre, CONCAT(DatosSolicitud.Calle,' ',DatosSolicitud.Noext,' ',DatosSolicitud.Colonia) as domicilio from conveniosSac inner join  Credito on ConveniosSac.idCredito = Credito.id inner join Clientes on Credito.IdCliente = Clientes.id inner join DatosSolicitud on Credito.IdSolicitud = DatosSolicitud.IdSolicitud and Credito.IdCliente = DatosSolicitud.IdCliente where conveniossac.idcredito = '" & idCredito & "'"
        comandoConvenio = New SqlCommand
        comandoConvenio.Connection = conexionempresa
        comandoConvenio.CommandText = consultaConvenio
        readerConvenio = comandoConvenio.ExecuteReader
        If readerConvenio.HasRows Then
            While readerConvenio.Read
                moratorios = readerConvenio("moratorios")
                DeudaCredito = readerConvenio("deudacredito")
                TotalDeuda = readerConvenio("TotalDeuda")
                FechaConvenio = readerConvenio("fecha")
                fechaInicio = readerConvenio("FechaInicio")
                FechaFin = readerConvenio("fechafinal")
                idConvenio = readerConvenio("id")
                canPagos = readerConvenio("CanPagos")
                nombreCliente = readerConvenio("nombre")
                nombreCredito = readerConvenio("nombrecredito")
                domicilio = readerConvenio("domicilio")
            End While
        End If
        readerConvenio.Close()
        Dim consultaCalendario As String
        consultaCalendario = "select format(Fechapago,'dd/MM/yyyy') as 'Fecha de pago',npago as 'Número de pago',format(monto+multas,'C','es-mx') as Monto from calendarioConveniosSac where idconvenio = '" & idConvenio & "'"
        adapterCalendario = New SqlDataAdapter(consultaCalendario, conexionempresa)
        dataCalendario = New Data.DataTable
        adapterCalendario.Fill(dataCalendario)

    End Sub

    Private Sub BackgroundConvenio_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundConvenio.RunWorkerCompleted
        Cargando.Close()
    End Sub

    Private Sub dataTableToWord(ByVal dt As System.Data.DataTable)
        Dim Word As Application
        Dim Doc As Word.Document
        Dim Table As Word.Table
        Dim Rng As Range
        Dim Prf1 As Word.Paragraph
        Dim Prf2 As Word.Paragraph
        Dim Prf3 As Word.Paragraph

        Word = CreateObject("Word.Application")

        FileCopy("C:\ConfiaAdmin\SATI\Calendario Convenio.docx", "C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendarioConvenio.docx")
        Doc = Word.Documents.Open("C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendarioConvenio.docx")
        Dim NCol As Integer = dt.Columns.Count
        Dim NRow As Integer = dt.Rows.Count
        'alternativo

        Table = Doc.Tables.Add(Doc.Bookmarks.Item("\endofdoc").Range, dt.Rows.Count + 1, dt.Columns.Count)

        'Agregando Los Campos De La Grilla
        For i As Integer = 1 To NCol
            Table.Cell(1, i).Range.Text = dt.Columns(i - 1).ColumnName.ToString
        Next
        'Agregando Los Registros A La Tabla
        For Fila As Integer = 0 To NRow - 1
            For Col As Integer = 0 To NCol - 1
                If dt.Rows(NRow - 1)(Col).ToString IsNot DBNull.Value Then
                    Table.Cell(Fila + 2, Col + 1).Range.Text = dt.Rows(Fila)(Col).ToString
                End If
            Next
            'Incremento

        Next
        'Negrita y Kursiva Para Los Nombres De Los Campos
        Table.Rows.Item(1).Range.Font.Bold = True
        Table.Rows.Item(1).Range.Font.Italic = False
        For i As Integer = 1 To Table.Rows.Count
            Table.Rows.Item(i).Range.Font.Size = 10
        Next


        'Boder De La Tabla
        Table.Borders.InsideLineStyle = WdLineStyle.wdLineStyleEngrave3D
        Table.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleEngrave3D
        Table.Borders.InsideColor = WdColor.wdColorBlack
        Rng = Doc.Bookmarks.Item("\endofdoc").Range
        Rng.InsertParagraphAfter()

        Doc.Save()
        Doc.Close()
        ' Word = Nothing
        Word.Application.Quit()


    End Sub

    Private Sub BackgroundImprimirCalendario_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundImprimirCalendario.RunWorkerCompleted
        Dim NumeroLetra As New NumLetra
        'Dim MSWord As New Word.Application
        'Dim Documento As Word.Document
        'Dim fechaActual As Date
        'fechaActual = Now

        ' FileCopy("C:\ConfiaAdmin\SATI\Pagare.docx", "C:\ConfiaAdmin\SATI\TEMPDOCS\TempPagare.docx")
        Dim documento As DocX = DocX.Load("C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendarioConvenio.docx")
        documento.ReplaceText("%%FECHACONVENIO%%", FechaConvenio.ToString("dd/MM/yyyy"))
        documento.ReplaceText("%%NOMBRECREDITO%%", nombreCredito)
        documento.ReplaceText("%%NOMBRERESPONSABLE%%", nombreCliente)
        documento.ReplaceText("%%IDCONVENIO%%", idConvenio)



        documento.Save()
        documento.Dispose()
        'VistaPreviaDocumento.ruta = "C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendario.docx"
        'VistaPreviaDocumento.Show()
        Dim spDoc As New Spire.Doc.Document
        spDoc.LoadFromFile("C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendarioConvenio.docx")
        Dim dialog As New PrintPreviewDialog

        ' dialog.AllowCurrentPage = True
        ' dialog.AllowSomePages = True
        ' dialog.UseEXDialog = True
        Cargando.Close()

        Try
            '  spDoc.PrintDialog = dialog.
            spDoc.PrintDocument.PrinterSettings.PrinterName = ImpresoraPredeterminada

            dialog.Document = spDoc.PrintDocument
            dialog.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BackgroundImprimirConvenio_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundImprimirConvenio.RunWorkerCompleted
        Dim spDoc As New Spire.Doc.Document
        spDoc.LoadFromFile("C:\ConfiaAdmin\SATI\TEMPDOCS\TempConvenio.docx")


        Dim Dialog As New PrintPreviewDialog

        ' dialog.AllowCurrentPage = True
        ' dialog.AllowSomePages = True
        ' dialog.UseEXDialog = True
        Cargando.Close()

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