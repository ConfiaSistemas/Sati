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
Imports ZXing
Imports Gma.QrCodeNet.Encoding
Imports Gma.QrCodeNet.Encoding.Windows
Imports Gma.QrCodeNet.Encoding.Windows.Render

Public Class EntregarDocumentacionEmpeño
    Public nombreEmpeñoAentregar As String
    Public montoAentregar As Double
    Public montoRefrendo As Double
    Dim montoValuado As Double
    Public plazoRefrendo As Integer
    Public porcentajeRefrendo As Double
    Dim idSolicitudAentregar As Integer
    Public idEmpeñoAentregar As Integer
    Public idClienteAentregar As Integer
    Public NombreClienteAentregar As String
    'Public modalidadAentregar As String
    Dim dataArticulos As Data.DataTable
    Dim adapterArticulos As SqlDataAdapter
    Dim diaDepago, Ine, Domicilio, Colonia, Entidad, Municipio, Telefono As String
    Dim CodigoPostal As Integer
    Public estadoCredito As String
    'Dim fechaCredito As Date
    Dim fechaPimerPago As Date
    Dim fechaEntrega As Date
    Dim interes As Double
    Dim NombreUsuario, UsuarioCaptura As String
    Dim nCargando As Cargando
    Private Sub EntregarDocumentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuImageButton1.Image = Nothing
        CheckForIllegalCrossThreadCalls = False
        BunifuImageButton1.AllowDrop = True
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando datos"
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        iniciarconexionempresa()
        Dim comando As SqlCommand
        Dim consulta As String
        Dim reader As SqlDataReader
        consulta = "select Empeños.Nombre,MontoPrestado,Montorefrendo,Empeños.MontoValuado,Empeños.PlazoRefrendo,Empeños.PorcentajeRefrendo,IdSolicitudBoleta,Empeños.idCLiente,Clientes.Nombre + ' ' + Clientes.ApellidoPaterno + ' ' + Clientes.ApellidoMaterno as nombreCliente,Empeños.estado,empeños.fechaentrega,DATENAME(dw, empeños.fechaentrega)as diaDePago, " &
        "SolicitudBoleta.Ine, SolicitudBoleta.Domicilio, SolicitudBoleta.CodigoPostal, SolicitudBoleta.Colonia, SolicitudBoleta.Municipio, SolicitudBoleta.Entidad, SolicitudBoleta.Telefono, SolicitudBoleta.UsuarioCaptura from Empeños inner join Clientes on Empeños.IdCliente = Clientes.id inner join SolicitudBoleta on SolicitudBoleta.id=Empeños.idSolicitudBoleta" & " where Empeños.id = '" & idEmpeñoAentregar & "'"
        comando = New SqlCommand
        comando.Connection = conexionempresa
        comando.CommandText = consulta
        reader = comando.ExecuteReader
        While reader.Read
            nombreEmpeñoAentregar = reader("Nombre")
            montoAentregar = reader("MontoPrestado")
            If Not IsDBNull(reader("Fechaentrega")) Then
                fechaEntrega = reader("fechaentrega")
            End If
            montoRefrendo = reader("MontoRefrendo")
            plazoRefrendo = reader("PlazoRefrendo")
            porcentajeRefrendo = reader("PorcentajeRefrendo")
            idSolicitudAentregar = reader("IdSolicitudBoleta")
            idClienteAentregar = reader("idCliente")
            NombreClienteAentregar = reader("nombreCliente")
            estadoCredito = reader("Estado")
            Ine = reader("Ine")
            Domicilio = reader("Domicilio")
            Colonia = reader("Colonia")
            CodigoPostal = reader("CodigoPostal")
            Entidad = reader("Entidad")
            Municipio = reader("Municipio")
            Telefono = reader("Telefono")
            interes = reader("PorcentajeRefrendo")
            diaDepago = reader("diaDePago")
            montoValuado = reader("MontoValuado")
            UsuarioCaptura = reader("UsuarioCaptura")

        End While
        reader.Close()
        Dim consultaArticulos As String
        consultaArticulos = "select Descripcion,TipoArticulosEmpeño.nombre as Tipo,Marca,Modelo,NoSerie,MontoValuado,MontoPrestado from ArticulosEmpeños inner join TipoArticulosEmpeño on TipoArticulosEmpeño.id=articulosempeños.tipo where idSolicitud=" & idSolicitudAentregar
        adapterArticulos = New SqlDataAdapter(consultaArticulos, conexionempresa)
        dataArticulos = New Data.DataTable
        adapterArticulos.Fill(dataArticulos)

        iniciarconexion()
        Dim comandoUsuario As OleDb.OleDbCommand
        Dim consultaUsuario As String
        consultaUsuario = "select nm_complete from usr where nm='" & UsuarioCaptura & "'"
        comandoUsuario = New OleDb.OleDbCommand
        comandoUsuario.Connection = conexion
        comandoUsuario.CommandText = consultaUsuario
        NombreUsuario = comandoUsuario.ExecuteScalar
        conexion.Close()


    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        lblNombre.Text = nombreEmpeñoAentregar
        lblMonto.Text = FormatCurrency(montoAentregar)
        Cargando.Close()
        Select Case estadoCredito
            Case "E"
                If fechaEntrega <> "1900-01-01" Then
                    btn_Testimonial.Visible = True
                    btn_Contrato.Visible = True
                    btn_Webcam.Visible = True
                    BunifuImageButton1.Visible = True
                    btn_Boleta.Visible = True
                    labelimagen.Visible = True
                    btn_activarEmpeño.Visible = True
                    btn_EntregarEmpeño.Visible = False
                Else
                    btn_EntregarEmpeño.Visible = True
                End If
            Case "A"

                btn_Testimonial.Visible = True
                btn_Contrato.Visible = True
                btn_Boleta.Visible = True
                '  BunifuThinButton23.Visible = False
                'BunifuImageButton1.Visible = False
                'labelimagen.Visible = False
                'btn_activar.Visible = False
        End Select
    End Sub


    Private Sub BackgroundContrato_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundContrato.DoWork
        Dim NumeroLetra As New NumLetra

        FileCopy("C:\ConfiaAdmin\SATI\ContratoEmpeño.docx", "C:\ConfiaAdmin\SATI\TEMPDOCS\TempContratoEmpeño.docx")
        'Reemplazamos las etiquetas del contrato
        Dim documento As DocX = DocX.Load("C:\ConfiaAdmin\SATI\TEMPDOCS\TempContratoEmpeño.docx")
        documento.ReplaceText("%dia%", fechaEntrega.ToString("dd"))
        documento.ReplaceText("%mes%", CDate(fechaEntrega).ToString("MMMM"))
        documento.ReplaceText("%año%", CDate(fechaEntrega).ToString("yyyy"))
        documento.ReplaceText("%folio%", idEmpeñoAentregar)
        documento.ReplaceText("%nombreCliente%", NombreClienteAentregar)
        documento.ReplaceText("%numeroIdentificacion%", Ine)
        documento.ReplaceText("%domicilio%", Domicilio)
        documento.ReplaceText("%colonia%", Colonia)
        documento.ReplaceText("%codigoPostal%", CodigoPostal)
        documento.ReplaceText("%ciudad%", Municipio)
        documento.ReplaceText("%estado%", Entidad)
        documento.ReplaceText("%telefono%", Telefono)
        documento.ReplaceText("%correo%", "-")
        documento.ReplaceText("%cotitular%", "-")
        documento.ReplaceText("%domicilioCotitular%", "-")
        documento.ReplaceText("%coloniaCotitular%", "-")
        documento.ReplaceText("%codigoPostalCotitular%", "-")
        documento.ReplaceText("%ciudadCotitular%", "-")
        documento.ReplaceText("%nombreBeneficiario%", "-")
        documento.ReplaceText("%montoPrestado%", FormatCurrency(montoAentregar))
        documento.ReplaceText("%montoTotalDeuda%", FormatCurrency(montoAentregar + (montoRefrendo * 52)))
        documento.ReplaceText("%fechaRefrendo%", CDate(fechaEntrega.AddDays(7)).ToString("dd-MMMM-yyyy"))
        documento.ReplaceText("%numeroDeRefrendos%", "52")
        documento.ReplaceText("%interesRefrendo%", porcentajeRefrendo)
        documento.ReplaceText("%Iva%", FormatCurrency((montoRefrendo / 1.16) * 0.16))
        documento.ReplaceText("%montoDesempeño%", FormatCurrency(montoRefrendo + montoAentregar))
        documento.ReplaceText("%montoRefrendo%", FormatCurrency(montoRefrendo))
        documento.ReplaceText("%diaDePago%", diaDepago)
        documento.ReplaceText("%montoValuadoTotal%", FormatCurrency(montoValuado))
        documento.ReplaceText("%montoValuadoLetra%", NumeroLetra.Convertir(montoValuado, False))
        documento.ReplaceText("%porcentajePrestamo%", FormatNumber(((montoAentregar * 100) / montoValuado), 2))
        documento.ReplaceText("%fechaVentaPrenda%", CDate(fechaEntrega.AddMonths(1)).ToString("dd-MMMM-yyyy"))
        documento.ReplaceText("%fechaLimiteFiniquito%", CDate(fechaEntrega.AddYears(1)).ToString("dd-MMMM-yyyy"))
        documento.ReplaceText("%nombreValuador%", NombreUsuario)
        'Definimos una variable que cuente el numero de articulo a empeñar
        Dim numeroArticulos As Integer = 0
        For Each row As DataRow In dataArticulos.Rows
            'Sustituimos las etiquetas dentro de la tabla de artículos
            If numeroArticulos = 0 Then
                documento.ReplaceText("%descripcion%", row("Descripcion"))
                documento.ReplaceText("%caracteristicas%", row("Tipo") & ", Marca: " & row("Marca") & ", Modelo: " & row("Modelo") & ", No. de Serie: " & row("NoSerie"))
                documento.ReplaceText("%montoValuadoPrenda%", FormatCurrency(row("MontoValuado")))
                documento.ReplaceText("%montoPrestadoPrenda%", FormatCurrency(row("MontoPrestado")))
                documento.ReplaceText("%porcentajePrestamoPrenda%", FormatNumber(((row("MontoPrestado") * 100) / row("MontoValuado")), 2))
            Else 'Insertamos una fila extra si hay más de un artículo, y añadimos los datos de dicho artículo
                Dim rowTable As Xceed.Words.NET.Row
                rowTable = documento.Tables(2).InsertRow(numeroArticulos)
                rowTable.Cells(0).Paragraphs.First.Append(row("Descripcion"))
                rowTable.Cells(1).Paragraphs.First.Append(row("Tipo") & ", Marca: " & row("Marca") & ", Modelo: " & row("Modelo") & ", No. de Serie: " & row("NoSerie"))
                rowTable.Cells(2).Paragraphs.First.Append(FormatCurrency(row("MontoValuado")))
                rowTable.Cells(3).Paragraphs.First.Append(FormatCurrency(row("MontoPrestado")))
                rowTable.Cells(4).Paragraphs.First.Append(FormatNumber((row("MontoPrestado") * 100) / row("MontoValuado"), 2) & "%")
                documento.Tables(1).Rows.Add(rowTable)
            End If
            numeroArticulos += 1
        Next
        documento.Save()
        documento.Dispose()
        'Abrimos el documento con word para acomodar el formato de las tablas
        Dim MSWord As New Word.Application
        Dim Doc As New Word.Document
        MSWord = CreateObject("Word.Application")
        Doc = MSWord.Documents.Open("C:\ConfiaAdmin\SATI\TEMPDOCS\TempContratoEmpeño.docx")

        For i As Integer = 1 To numeroArticulos
            Doc.Tables(3).Cell(i, 1).Select()
            MSWord.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft
            Doc.Tables(3).Cell(i, 2).Select()
            MSWord.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft
        Next
        'Fijamos el ancho de las columnas
        Doc.Tables(3).Columns(1).Width = 162.75
        Doc.Tables(3).Columns(2).Width = 155.95
        Doc.Tables(3).Columns(3).Width = 63.8
        Doc.Tables(3).Columns(4).Width = 63.8
        Doc.Tables(3).Columns(5).Width = 70.9
        Doc.Save()
        Doc.Close()
        MSWord.Application.Quit()
    End Sub

    Private Sub btn_Contrato_Click(sender As Object, e As EventArgs) Handles btn_Contrato.Click
        nCargando = New Cargando
        nCargando.MonoFlat_Label1.Text = "Generando Contrato..."
        nCargando.Show()
        nCargando.TopMost = True
        BackgroundContrato.RunWorkerAsync()
    End Sub

    Private Sub BackgroundContrato_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundContrato.RunWorkerCompleted
        nCargando.Close()
        VistaPreviaDocumento.ruta = "C: \ConfiaAdmin\SATI\TEMPDOCS\TempContratoEmpeño.docx"
        VistaPreviaDocumento.Show()
        ' BackgroundCalendario.RunWorkerAsync()
    End Sub

    Private Sub BackgroundEntrega_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundEntrega.DoWork
        iniciarconexionempresa()

        Dim comandoFecha As SqlCommand
        Dim consultaFecha As String
        Dim Fecha As Date
        consultaFecha = "select fechaEntrega from Empeños where id= '" & idEmpeñoAentregar & "'"
        comandoFecha = New SqlCommand
        comandoFecha.Connection = conexionempresa
        comandoFecha.CommandText = consultaFecha
        Fecha = comandoFecha.ExecuteScalar

        If Fecha = "1900-01-01" Then
            Dim comandoActEmpeño As SqlCommand
            Dim consultaActEmpeño As String
            consultaActEmpeño = "update Empeños set fechaEntrega = GETDATE() where id = '" & idEmpeñoAentregar & "'"
            comandoActEmpeño = New SqlCommand
            comandoActEmpeño.Connection = conexionempresa
            comandoActEmpeño.CommandText = consultaActEmpeño
            comandoActEmpeño.ExecuteNonQuery()
        End If
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs)
        BackgroundEntrega.RunWorkerAsync()
    End Sub

    Private Sub BackgroundEntrega_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundEntrega.RunWorkerCompleted
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando datos"
        BackgroundWorker1.RunWorkerAsync()
        'BackgroundPagare.RunWorkerAsync()

    End Sub

    Private Sub dataTableToWord(ByVal dt As System.Data.DataTable)
        Dim Word As Application
        Dim Doc As Word.Document
        Dim Table As Word.Table
        Dim Rng As Range

        Word = CreateObject("Word.Application")

        FileCopy("C:\ConfiaAdmin\SATI\Calendario.docx", "C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendario.docx")
        Doc = Word.Documents.Open("C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendario.docx")
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

    Private Sub BackgroundTestimonial_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundTestimonial.DoWork
        iniciarconexionempresa()

        Dim comandoFechaEntrega As SqlCommand
        Dim consultaFechaEntrega As String
        consultaFechaEntrega = "Select FechaEntrega, Nombre, idSolicitudBoleta from Empeños where id = '" & idEmpeñoAentregar & "'"
        Dim readerFechaEntrega As SqlDataReader
        comandoFechaEntrega = New SqlCommand
        comandoFechaEntrega.Connection = conexionempresa
        comandoFechaEntrega.CommandText = consultaFechaEntrega
        readerFechaEntrega = comandoFechaEntrega.ExecuteReader
        While readerFechaEntrega.Read
            fechaEntrega = readerFechaEntrega("FechaEntrega")
            nombreEmpeñoAentregar = readerFechaEntrega("Nombre")
            idSolicitudAentregar = readerFechaEntrega("idSolicitudBoleta")
        End While
        readerFechaEntrega.Close()
        Dim dataArticulos As System.Data.DataTable
        Dim adapterArticulos As SqlDataAdapter
        Dim consultaArticulos As String

        consultaArticulos = "select ArticulosEmpeños.Descripcion, ArticulosEmpeños.Marca, ArticulosEmpeños.Modelo, ArticulosEmpeños.NoSerie, ArticulosEmpeños.MontoValuado, TipoArticulosEmpeño.Nombre from ArticulosEmpeños inner join TipoArticulosEmpeño on TipoArticulosEmpeño.id=ArticulosEmpeños.Tipo where ArticulosEmpeños.idSolicitud = '" & idSolicitudAentregar & "'"
        adapterArticulos = New SqlDataAdapter(consultaArticulos, conexionempresa)
        dataArticulos = New Data.DataTable
        adapterArticulos.Fill(dataArticulos)
        'dataTableToWord(dataCalendario)

        Try
            FileCopy("C:\ConfiaAdmin\SATI\TestimonialEmpeño.docx", "C:\ConfiaAdmin\SATI\TEMPDOCS\TempTestimonialEmpeño.docx")
        Catch ex As Exception
            MessageBox.Show("Error al abrir el archivo del formato")
            'Finally
            '    BackgroundTestimonial.WorkerSupportsCancellation = True
            '    BackgroundTestimonial.CancelAsync()
            '    'If BackgroundTestimonial.CancellationPending Then
            '    e.Cancel = True
            '    'End If
        End Try

        Dim documento As DocX = DocX.Load("C:\ConfiaAdmin\SATI\TEMPDOCS\TempTestimonialEmpeño.docx")

        documento.ReplaceText("%dia%", fechaEntrega.ToString("dd"))
        documento.ReplaceText("%mes%", CDate(fechaEntrega).ToString("MMMM").ToUpper)
        documento.ReplaceText("%año%", CDate(fechaEntrega).ToString("yyyy"))
        documento.ReplaceText("%nombre%", nombreEmpeñoAentregar)

        Dim nArticulos As Integer = 0
        For Each row As DataRow In dataArticulos.Rows
            If nArticulos = 0 Then
                documento.ReplaceText("%descripcion%", ("Tipo de Artículo: " & row("Nombre") & "; Descripción: " & row("Descripcion")))
                documento.ReplaceText("%caracteristicas%", "Marca: " & row("Marca") & "; Modelo: " & row("Modelo") & "; No. de Serie: " & row("NoSerie"))
                documento.ReplaceText("%montoValuadoPrenda%", FormatCurrency(row("MontoValuado")))
                nArticulos += 1
                documento.Save()
                documento.Dispose()
            Else
                'Dim parrafo As String
                'Dim parra As Xceed.Words.NET.Paragraph
                'parrafo = "Descripción: " & row("Descripcion") & ", Marca: " & row("Marca") & ", Modelo: " & row("Modelo") & ", No de Serie: " & row("NoSerie") & ", Valuado en: " & FormatCurrency(row("MontoValuado"))
                'documento.InsertParagraph(1, parrafo)
                'parra = documento.InsertParagraph(3, parrafo, False)



                nArticulos += 1

            End If
        Next

        'Usamos word para agregar más elementos a la lista si hay más de un artículo
        If nArticulos > 1 Then
            Dim Word As Application
            Dim Doc As Word.Document
            Word = CreateObject("Word.Application")
            Doc = Word.Documents.Open("C:\ConfiaAdmin\SATI\TEMPDOCS\TempTestimonialEmpeño.docx")
            For i As Integer = 2 To nArticulos
                Doc.Paragraphs(i + 5).Range.InsertParagraphAfter()
                'Doc.Lists(1).Range.InsertParagraphAfter()
                'Word.Selection.InsertParagraphAfter()               
                Doc.Paragraphs(i + 6).Range.ListFormat.ApplyNumberDefault()
                Doc.Paragraphs(i + 5).Format.SpaceAfter = 10
                If i = nArticulos Then
                    Doc.Paragraphs(i + 6).Format.SpaceAfter = 18
                End If
                Doc.Paragraphs(i + 6).SelectNumber()
                'Word.Selection.TypeText(Convert.ToString("werwerwerwer" & n(0)))
                Word.Selection.Text = (Convert.ToString("Tipo de Articulo: " & dataArticulos.Rows(i - 1).Item(5) & "; Descripción: " & dataArticulos.Rows(i - 1).Item(0) & "; Marca: " & dataArticulos.Rows(i - 1).Item(1) & "; Modelo: " & dataArticulos.Rows(i - 1).Item(2) & "; No. de Serie: " & dataArticulos.Rows(i - 1).Item(3) & "; Valuado en:" & FormatCurrency(dataArticulos.Rows(i - 1).Item(4))))
                'Doc.Paragraphs(i + 6).Range.ListFormat.ApplyNumberDefault()
            Next
            Doc.Save()
            Doc.Close()
            Word.Application.Quit()
        End If


    End Sub

    Private Sub BackgroundTestimonial_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundTestimonial.RunWorkerCompleted
        nCargando.Close()
        VistaPreviaDocumento.ruta = "C:\ConfiaAdmin\SATI\TEMPDOCS\TempTestimonialEmpeño.docx"
        VistaPreviaDocumento.Show()


    End Sub
    Private Sub BunifuImageButton1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles BunifuImageButton1.DragDrop
        Try
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then

                Dim strRutaArchivoImagen As String

                Dim i As Integer

                'Asignamos la primera posición del array de ruta de archivos a la variable de tipo string

                'declarada anteriormente ya que en este caso sólo mostraremos una imagen en el control.

                strRutaArchivoImagen = e.Data.GetData(DataFormats.FileDrop)(0)

                'La cargamos al control

                BunifuImageButton1.Load(strRutaArchivoImagen)
            End If
            labelimagen.Visible = False
        Catch ex As ArgumentException
            MsgBox("Archivo no válido", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub BunifuImageButton1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles BunifuImageButton1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            'Los archivos son externos a nuestra aplicación por lo que de indicaremos All ya que dará lo mismo.

            e.Effect = DragDropEffects.All

        End If

    End Sub


    Private Sub BunifuImageButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuImageButton1.Click
        Dim openFileDialog1 As New OpenFileDialog()
        Dim nombre As String
        openFileDialog1.Filter = "Imágenes (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg;*.jpeg;*.png"
        openFileDialog1.FilterIndex = 1

        openFileDialog1.ShowDialog()
        If openFileDialog1.FileName <> "" Then
            nombre = openFileDialog1.FileName
            BunifuImageButton1.Image = System.Drawing.Image.FromFile(nombre)
            labelimagen.Visible = False

        Else
            MessageBox.Show("No se seleccionó ningún archivo")

        End If
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles btn_Webcam.Click
        webcamCredito.Show()
    End Sub

    Private Sub btn_activar_Click(sender As Object, e As EventArgs) Handles btn_activarEmpeño.Click
        If BunifuImageButton1.Image IsNot Nothing Then
            Cargando.Show()
            Cargando.MonoFlat_Label1.Text = "Activando Crédito"
            BackgroundActivar.RunWorkerAsync()
        Else
            MessageBox.Show("Para activar el crédito es necesario cargar una imagen del cliente")
        End If

    End Sub

    Private Sub BackgroundActivar_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundActivar.DoWork
        iniciarconexionempresa()

        Dim comandoDocumento As SqlCommand
        Dim consultaDocumento As String
        Dim imagen As Bitmap = TryCast(BunifuImageButton1.Image, Bitmap)

        consultaDocumento = "insert into DocumentosEmpeño values('" & idEmpeñoAentregar & "','4',@Documento)"
        Dim imgDocumento As New SqlParameter("@Documento", SqlDbType.Image)
        Dim msImgDocumento As New MemoryStream
        imagen.Save(msImgDocumento, ImageFormat.Jpeg)
        imgDocumento.Value = msImgDocumento.GetBuffer
        comandoDocumento = New SqlCommand
        comandoDocumento.Connection = conexionempresa
        comandoDocumento.CommandText = consultaDocumento
        comandoDocumento.Parameters.Add(imgDocumento)
        comandoDocumento.ExecuteNonQuery()

        Dim comandoActCredito As SqlCommand
        Dim consultaActCredito As String
        consultaActCredito = "Update Empeños set estado = 'A' where id = '" & idEmpeñoAentregar & "'"
        comandoActCredito = New SqlCommand
        comandoActCredito.Connection = conexionempresa
        comandoActCredito.CommandText = consultaActCredito
        comandoActCredito.ExecuteNonQuery()



    End Sub

    Private Sub BackgroundActivar_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundActivar.RunWorkerCompleted
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando datos"
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub Btn_Testimonial_Click(sender As Object, e As EventArgs) Handles btn_Testimonial.Click
        nCargando = New Cargando
        nCargando.MonoFlat_Label1.Text = "Generando Documento Testimonial..."
        nCargando.Show()
        Cargando.TopMost = True

        BackgroundTestimonial.RunWorkerAsync()
    End Sub
    Private Sub WordDocViewer(ByVal fileName As String)
        Try
            Process.Start(fileName)
        Catch

        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub BackgroundBoleta_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundBoleta.DoWork
        Dim NumeroLetra As New NumLetra

        FileCopy("C:\ConfiaAdmin\SATI\BoletaEmpeño.docx", "C:\ConfiaAdmin\SATI\TEMPDOCS\TempBoletaEmpeño.docx")
        'Reemplazamos las etiquetas del contrato
        Dim documento As DocX = DocX.Load("C:\ConfiaAdmin\SATI\TEMPDOCS\TempBoletaEmpeño.docx")
        documento.ReplaceText("%dia%", fechaEntrega.ToString("dd"))
        documento.ReplaceText("%mes%", CDate(fechaEntrega).ToString("MMMM"))
        documento.ReplaceText("%año%", CDate(fechaEntrega).ToString("yyyy"))
        documento.ReplaceText("%folio%", idEmpeñoAentregar)
        documento.ReplaceText("%nombreCliente%", NombreClienteAentregar)
        documento.ReplaceText("%numeroIdentificacion%", Ine)
        documento.ReplaceText("%domicilio%", Domicilio)
        documento.ReplaceText("%colonia%", Colonia)
        documento.ReplaceText("%codigoPostal%", CodigoPostal)
        documento.ReplaceText("%ciudad%", Municipio)
        documento.ReplaceText("%estado%", Entidad)
        documento.ReplaceText("%telefono%", Telefono)
        documento.ReplaceText("%correo%", "-")
        documento.ReplaceText("%cotitular%", "-")
        documento.ReplaceText("%domicilioCotitular%", "-")
        documento.ReplaceText("%coloniaCotitular%", "-")
        documento.ReplaceText("%codigoPostalCotitular%", "-")
        documento.ReplaceText("%ciudadCotitular%", "-")
        documento.ReplaceText("%nombreBeneficiario%", "-")
        documento.ReplaceText("%montoPrestado%", FormatCurrency(montoAentregar))
        documento.ReplaceText("%montoTotalDeuda%", FormatCurrency(montoAentregar + (montoRefrendo * 52)))
        documento.ReplaceText("%fechaRefrendo%", CDate(fechaEntrega.AddDays(7)).ToString("dd-MMMM-yyyy"))
        documento.ReplaceText("%numeroDeRefrendos%", "52")
        documento.ReplaceText("%interesRefrendo%", porcentajeRefrendo)
        documento.ReplaceText("%Iva%", FormatCurrency((montoRefrendo / 1.16) * 0.16))
        documento.ReplaceText("%montoDesempeño%", FormatCurrency(montoRefrendo + montoAentregar))
        documento.ReplaceText("%montoRefrendo%", FormatCurrency(montoRefrendo))
        documento.ReplaceText("%diaDePago%", diaDepago)
        documento.ReplaceText("%montoValuadoTotal%", FormatCurrency(montoValuado))
        documento.ReplaceText("%montoValuadoLetra%", NumeroLetra.Convertir(montoValuado, False))
        documento.ReplaceText("%porcentajePrestamo%", FormatNumber(((montoAentregar * 100) / montoValuado), 2))
        documento.ReplaceText("%fechaVentaPrenda%", CDate(fechaEntrega.AddMonths(1)).ToString("dd-MMMM-yyyy"))
        documento.ReplaceText("%fechaLimiteFiniquito%", CDate(fechaEntrega.AddYears(1)).ToString("dd-MMMM-yyyy"))
        documento.ReplaceText("%nombreValuador%", NombreUsuario)
        'Definimos una variable que cuente el numero de articulo a empeñar
        Dim numeroArticulos As Integer = 0
        For Each row As DataRow In dataArticulos.Rows
            'Sustituimos las etiquetas dentro de la tabla de artículos
            If numeroArticulos = 0 Then
                documento.ReplaceText("%descripcion%", row("Descripcion"))
                documento.ReplaceText("%caracteristicas%", row("Tipo") & ", Marca: " & row("Marca") & ", Modelo: " & row("Modelo") & ", No. de Serie: " & row("NoSerie"))
                documento.ReplaceText("%montoValuadoPrenda%", FormatCurrency(row("MontoValuado")))
                documento.ReplaceText("%montoPrestadoPrenda%", FormatCurrency(row("MontoPrestado")))
                documento.ReplaceText("%porcentajePrestamoPrenda%", FormatNumber(((row("MontoPrestado") * 100) / row("MontoValuado")), 2))
            Else 'Insertamos una fila extra si hay más de un artículo, y añadimos los datos de dicho artículo
                Dim rowTable As Xceed.Words.NET.Row
                rowTable = documento.Tables(2).InsertRow(numeroArticulos)
                rowTable.Cells(0).Paragraphs.First.Append(row("Descripcion"))
                rowTable.Cells(1).Paragraphs.First.Append(row("Tipo") & ", Marca: " & row("Marca") & ", Modelo: " & row("Modelo") & ", No. de Serie: " & row("NoSerie"))
                rowTable.Cells(2).Paragraphs.First.Append(FormatCurrency(row("MontoValuado")))
                rowTable.Cells(3).Paragraphs.First.Append(FormatCurrency(row("MontoPrestado")))
                rowTable.Cells(4).Paragraphs.First.Append(FormatNumber((row("MontoPrestado") * 100) / row("MontoValuado"), 2) & "%")
                documento.Tables(1).Rows.Add(rowTable)
            End If
            numeroArticulos += 1
        Next
        documento.Save()
        documento.Dispose()
        'Abrimos el documento con word para acomodar el formato de las tablas
        Dim MSWord As New Word.Application
        Dim Doc As New Word.Document
        MSWord = CreateObject("Word.Application")
        Doc = MSWord.Documents.Open("C:\ConfiaAdmin\SATI\TEMPDOCS\TempBoletaEmpeño.docx")

        For i As Integer = 1 To numeroArticulos
            Doc.Tables(3).Cell(i, 1).Select()
            MSWord.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft
            Doc.Tables(3).Cell(i, 2).Select()
            MSWord.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft
        Next
        'Fijamos el ancho de las columnas
        Doc.Tables(3).Columns(1).Width = 162.75
        Doc.Tables(3).Columns(2).Width = 155.95
        Doc.Tables(3).Columns(3).Width = 63.8
        Doc.Tables(3).Columns(4).Width = 63.8
        Doc.Tables(3).Columns(5).Width = 70.9
        Doc.Save()
        Doc.Close()
        MSWord.Application.Quit()

    End Sub

    Private Sub BackgroundBoleta_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundBoleta.RunWorkerCompleted
        nCargando.Close()
        VistaPreviaDocumento.ruta = "C: \ConfiaAdmin\SATI\TEMPDOCS\TempBoletaEmpeño.docx"
        VistaPreviaDocumento.Show()

    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles btn_Boleta.Click
        nCargando = New Cargando
        nCargando.Show()
        nCargando.MonoFlat_Label1.Text = "Generando Boleta de Empeño"
        nCargando.TopMost = True
        BackgroundBoleta.RunWorkerAsync()

    End Sub

    Private Sub BackgroundTarjeta_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundTarjeta.DoWork
        FileCopy("C:\ConfiaAdmin\SATI\Tarjeta.docx", "C:\ConfiaAdmin\SATI\TEMPDOCS\TempTarjeta.docx")
        Dim documento As DocX = DocX.Load("C:\ConfiaAdmin\SATI\TEMPDOCS\TempTarjeta.docx")
        documento.ReplaceText("%%NOMBRECLIENTE%%", NombreClienteAentregar)
        documento.ReplaceText("%%QR%%", "")
        documento.Save()
        documento.Dispose()
        'Dim GENERADOR As BarcodeWriter = New BarcodeWriter 'INICIALIZA EL GENERADOR
        'GENERADOR.Format = BarcodeFormat.QR_CODE
        ' Dim IMAGEN As Bitmap = New Bitmap(GENERADOR.Write("CF-URP-0001"), 50, 50)
        'IMAGEN.Save("C:\ConfiaAdmin\SATI\TEMPDOCS\QR.png")
        gen_qr_file("C:\ConfiaAdmin\SATI\TEMPDOCS\QR", "CF-URP-0001", 50)
        Dim Word As Application
        Dim Doc As Word.Document
        Word = CreateObject("Word.Application")
        Doc = Word.Documents.Open("C:\ConfiaAdmin\SATI\TEMPDOCS\TempTarjeta.docx")
        Dim para As Word.Paragraph = Doc.Paragraphs.Add()
        ' para.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
        With para.Range.InlineShapes.AddPicture("C:\ConfiaAdmin\SATI\TEMPDOCS\QR.png").ConvertToShape
            .WrapFormat.Type = Word.WdWrapType.wdWrapBehind
        End With
        para.Range.InsertParagraphAfter()
        'para.Range.ShapeRange.Item(1).WrapFormat.Type = WdWrapType.wdWrapInline
        'para.Range.InsertParagraph()
        'Word.ActiveDocument.InlineShapes(1).Range.ShapeRange.Item(0).WrapFormat.Type = WdWrapType.wdWrapInline
        'Dim _shape As Shape
        '_shape = Doc.Shapes.AddPicture(FileName:="C:\ConfiaAdmin\SATI\TEMPDOCS\QR.png", LinkToFile:=False, SaveWithDocument:=True)
        ' With _shape
        '.WrapFormat.Type = WdWrapType.wdWrapNone
        '.WrapFormat.Type = WdWrapType.wdWrapInline
        ' End With

        Doc.Save()
        Doc.Close()
        ' Word = Nothing
        Word.Application.Quit()
    End Sub

    Private Sub BackgroundTarjeta_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundTarjeta.RunWorkerCompleted
        Dim spDoc As New Spire.Doc.Document
        spDoc.LoadFromFile("C:\ConfiaAdmin\SATI\TEMPDOCS\TempTarjeta.docx")


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

    Private Sub btnTarjeta_Click(sender As Object, e As EventArgs)
        BackgroundTarjeta.RunWorkerAsync()
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

    Private Sub btn_EntregarEmpeño_Click(sender As Object, e As EventArgs) Handles btn_EntregarEmpeño.Click
        BackgroundEntrega.RunWorkerAsync()
    End Sub
End Class