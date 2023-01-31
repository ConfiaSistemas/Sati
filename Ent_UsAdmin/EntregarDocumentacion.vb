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
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Public Class EntregarDocumentacion
    Public NombreCreditoAentregar As String
    Public MontoAentregar As Double
    Public PagareAentregar As Double
    Public integrantesAentregar As Integer
    Public pagoIndividualAentregar As Double
    Public plazoAentregar As Integer
    Public interesAentregar As Double
    Public idSolicitudAentregar As Integer
    Public idCreditoAentregar As Integer
    Public idClienteAentregar As Integer
    Public NombreClienteAentregar As String
    Public modalidadAentregar As String
    Dim dataIntegrantes As Data.DataTable
    Dim adapterIntegrantes As SqlDataAdapter
    Dim diaDepago As String
    Public estadoCredito As String
    Dim fechaCredito As Date
    Dim fechaPimerPago As Date
    Dim moto As Boolean = False
    Dim motoCapturada As Boolean = False
    Public MotoActualizada As Boolean = False
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
        consulta = "select credito.Nombre,Monto,Pagare,Integrantes,PagoIndividual,credito.Plazo,credito.Interes,IdSolicitud,idCLiente,Clientes.Nombre + ' ' + Clientes.ApellidoPaterno + ' ' + Clientes.ApellidoMaterno as nombreCliente,tiposdecredito.modalidad,tiposdecredito.moto,Credito.estado from Credito inner join Clientes on Credito.IdCliente = Clientes.id inner join tiposdecredito on credito.tipo = tiposdecredito.id where credito.id = '" & idCreditoAentregar & "'"
        comando = New SqlCommand
        comando.Connection = conexionempresa
        comando.CommandText = consulta
        reader = comando.ExecuteReader
        While reader.Read
            NombreCreditoAentregar = reader("Nombre")
            MontoAentregar = reader("Monto")
            PagareAentregar = reader("Pagare")
            integrantesAentregar = reader("Integrantes")
            pagoIndividualAentregar = reader("PagoIndividual")
            plazoAentregar = reader("Plazo")
            interesAentregar = reader("Interes")
            idSolicitudAentregar = reader("IdSolicitud")
            idClienteAentregar = reader("idCliente")
            NombreClienteAentregar = reader("nombreCliente")
            modalidadAentregar = reader("modalidad")
            estadoCredito = reader("Estado")
            moto = reader("moto")
        End While
        reader.Close()

        Dim comandoMotoCapturada As SqlCommand
        Dim consultaMotoCapturada As String
        consultaMotoCapturada = "if exists(select Motocicletas.id from Motocicletas inner join credito on Motocicletas.idCredito= Credito.id inner join DocumentosCredito on Credito.id= DocumentosCredito.IdCredito where motocicletas.idCredito='" & idCreditoAentregar & "' and documentoscredito.tipo = (select id from tiposdedocumentosSolicitud where nombre='Motocicleta'))
begin
select 1
end
else
select 0"
        comandoMotoCapturada = New SqlCommand
        comandoMotoCapturada.Connection = conexionempresa
        comandoMotoCapturada.CommandText = consultaMotoCapturada
        motoCapturada = comandoMotoCapturada.ExecuteScalar


        Dim consultaIntegrantes As String
        consultaIntegrantes = "select IdCliente,Clientes.Nombre+' '+Clientes.ApellidoPaterno +' '+ Clientes.ApellidoMaterno as nombreCliente,montoAutorizado from DatosSolicitud inner join Clientes on DatosSolicitud.IdCliente = Clientes.id where datossolicitud.idsolicitud = '" & idSolicitudAentregar & "' and datossolicitud.estado = 'A'"
        adapterIntegrantes = New SqlDataAdapter(consultaIntegrantes, conexionempresa)
        dataIntegrantes = New Data.DataTable
        adapterIntegrantes.Fill(dataIntegrantes)
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        lblNombre.Text = NombreCreditoAentregar
        lblMonto.Text = FormatCurrency(MontoAentregar)
        Cargando.Close()
        Select Case estadoCredito
            Case "E"
                If moto Then
                    If motoCapturada Then
                        btnMoto.Visible = False
                    Else
                        btnMoto.Visible = True
                    End If
                Else
                    btnMoto.Visible = False
                End If
                BunifuThinButton22.Visible = True
                BunifuThinButton21.Visible = False
                btn_Procesar.Visible = False
                BunifuThinButton23.Visible = False
                BunifuImageButton1.Visible = False
                BunifuThinButton24.Visible = False
                labelimagen.Visible = False
                btn_activar.Visible = False

            Case "P"
                If moto Then
                    If motoCapturada Then
                        btnMoto.Visible = False
                    Else
                        btnMoto.Visible = True
                    End If
                Else
                    btnMoto.Visible = False
                End If
                BunifuThinButton22.Visible = False
                BunifuThinButton21.Visible = True
                btn_Procesar.Visible = True
                BunifuThinButton23.Visible = True
                BunifuImageButton1.Visible = True
                BunifuThinButton24.Visible = True
                labelimagen.Visible = True
                btn_activar.Visible = True
            Case "A"
                BunifuThinButton22.Visible = False
                BunifuThinButton21.Visible = True
                btn_Procesar.Visible = True
                BunifuThinButton24.Visible = True
                BunifuThinButton23.Visible = False
                BunifuImageButton1.Visible = False
                labelimagen.Visible = False
                btn_activar.Visible = False
            Case Else
                BunifuThinButton22.Visible = False
                BunifuThinButton21.Visible = True
                btn_Procesar.Visible = True
                BunifuThinButton24.Visible = True
                BunifuThinButton23.Visible = False
                BunifuImageButton1.Visible = False
                labelimagen.Visible = False
                btn_activar.Visible = False

        End Select
    End Sub


    Private Sub BackgroundPagare_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundPagare.DoWork
        Dim NumeroLetra As New NumLetra
        'Dim MSWord As New Word.Application
        Dim multas As Double
        Dim totalPagareCmultas As Double
        'Dim Documento As Word.Document
        ' Dim fechaActual As Date
        'fechaActual = Now
        Dim comandoFechaEntrega As SqlCommand
        Dim consultaFechaEntrega As String
        Dim readerpagareEntrega As SqlDataReader
        consultaFechaEntrega = "select *,
case pagareconmultas.Modalidad when 'S' then
((DATEDIFF(day,FechaPrimerPago,dateadd(day,7,fechaultimopago))) * 50)
when 'Q' then
			--el primero del mes
			case when DATEDIFF(DAY,fechaultimopago,EOMONTH(fechaultimopago))>16
			then
				((DATEDIFF(day,FechaPrimerPago,dateadd(day,15,fechaultimopago))) * 50)
			else --El día de pago es el 16 del mes
				((DATEDIFF(day,FechaPrimerPago,dateadd(day,DATEDIFF(day,fechaultimopago,dateadd(day,1,eomonth(fechaultimopago))),fechaultimopago))) * 50)
				 
			end
 END as multas from
(select *,isnull((select top 1 fechapago from CalendarioNormal where id_credito = fechas.id order by FechaPago desc),'1900-01-01') as fechaultimopago from
(select credito.id,fechaEntrega,fechaprimerpago,TiposDeCredito.Modalidad from credito inner join TiposDeCredito on credito.Tipo = TiposDeCredito.id where credito.id = '" & idCreditoAentregar & "') fechas) pagareconmultas"
        Dim fechaEntrega As Date
        comandoFechaEntrega = New SqlCommand
        comandoFechaEntrega.Connection = conexionempresa
        comandoFechaEntrega.CommandText = consultaFechaEntrega
        readerpagareEntrega = comandoFechaEntrega.ExecuteReader
        If readerpagareEntrega.HasRows Then
            While readerpagareEntrega.Read
                fechaEntrega = readerpagareEntrega("fechaentrega")
                multas = readerpagareEntrega("multas")
            End While
        End If
        totalPagareCmultas = PagareAentregar + multas

        FileCopy("C:\ConfiaAdmin\SATI\Pagare.docx", "C:\ConfiaAdmin\SATI\TEMPDOCS\TempPagare.docx")
        Dim documento As DocX = DocX.Load("C:\ConfiaAdmin\SATI\TEMPDOCS\TempPagare.docx")
        documento.ReplaceText("%%MontoTotal%%", FormatCurrency(totalPagareCmultas))
        documento.ReplaceText("%%MontoTotalLetra%%", NumeroLetra.Convertir(totalPagareCmultas, True))
        documento.ReplaceText("%%Ciudad%%", CiudadEmpresa)
        documento.ReplaceText("%%Estado%%", EstadoEmpresa)
        documento.ReplaceText("%%Dia%%", CDate(fechaEntrega).ToString("dd"))
        documento.ReplaceText("%%Mes%%", CDate(fechaEntrega).ToString("MMMM"))
        documento.ReplaceText("%%Año%%", CDate(fechaEntrega).ToString("yyyy"))
        documento.ReplaceText("%%Diad%%", CDate(fechaEntrega.AddMonths(1)).ToString("dd"))
        documento.ReplaceText("%%Mesd%%", CDate(fechaEntrega.AddMonths(1)).ToString("MMMM"))
        documento.ReplaceText("%%Añod%%", CDate(fechaEntrega.AddMonths(1)).ToString("yyyy"))
        Dim integrantes As String = ""
        documento.ReplaceText("%%Responsable%%", NombreClienteAentregar)
        If integrantesAentregar > 1 Then

            For Each row As DataRow In dataIntegrantes.Rows
                If row("nombreCliente").ToString <> NombreClienteAentregar Then
                    integrantes = integrantes & row("nombreCliente").ToString & ","
                End If

            Next
        Else

        End If
        Dim linea As String = "__________________________________"
        Dim firmaintegrantes As String = ""
        documento.ReplaceText("%%Avales%%", integrantes)
        If integrantesAentregar > 1 Then
            For Each row As DataRow In dataIntegrantes.Rows
                If row("nombreCliente").ToString <> NombreClienteAentregar Then
                    'firmaintegrantes = firmaintegrantes & linea & Environment.NewLine & row("nombreCliente").ToString & Environment.NewLine
                    documento.InsertParagraph(linea).Alignment = Alignment.center
                    documento.InsertParagraph(row("nombreCliente").ToString).Alignment = Alignment.center
                End If

            Next
        End If

        documento.InsertParagraph(firmaintegrantes).Alignment = Alignment.center

        documento.Save()
        documento.Dispose()


    End Sub

    Private Sub btn_Procesar_Click(sender As Object, e As EventArgs) Handles btn_Procesar.Click

        BackgroundPagare.RunWorkerAsync()
    End Sub

    Private Sub BackgroundPagare_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundPagare.RunWorkerCompleted
        VistaPreviaDocumento.ruta = "C:\ConfiaAdmin\SATI\TEMPDOCS\TempPagare.docx"
        VistaPreviaDocumento.Show()
        ' BackgroundCalendario.RunWorkerAsync()
    End Sub

    Private Sub BackgroundEntrega_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundEntrega.DoWork
        iniciarconexionempresa()
        Dim ci As CultureInfo = CultureInfo.InvariantCulture
        Dim comandoDia As SqlCommand
        Dim consultaDia As String
        Dim diaCreditoAnterior As String
        Dim diaDeHoy As Date = Now
        Dim Numerodiahoy As DayOfWeek = ci.Calendar.GetDayOfWeek(diaDeHoy)
        Dim numeroDiaMes As Integer = diaDeHoy.Day
        Dim primerPago As Date
        consultaDia = "select isnull((select top 1 DATENAME(dw,fechaPrimerPago) from Credito inner join tiposdecredito on credito.tipo = tiposdecredito.id where FechaEntrega is not null and tiposdecredito.modalidad = 'S' order by credito.id desc),0)"
        comandoDia = New SqlCommand
        comandoDia.Connection = conexionempresa
        comandoDia.CommandText = consultaDia
        diaCreditoAnterior = comandoDia.ExecuteScalar

        Select Case modalidadAentregar
            Case "S"
                Select Case diaCreditoAnterior
                    Case "0"
                        diaDepago = "Lunes"
                        Select Case Numerodiahoy
                            Case "0"
                                primerPago = diaDeHoy.AddDays(1)
                            Case "1"
                                primerPago = diaDeHoy.AddDays(7)
                            Case "2"
                                primerPago = diaDeHoy.AddDays(6)
                            Case "3"
                                primerPago = diaDeHoy.AddDays(5)
                            Case "4"
                                primerPago = diaDeHoy.AddDays(4)
                            Case "5"
                                primerPago = diaDeHoy.AddDays(3)
                            Case "6"
                                primerPago = diaDeHoy.AddDays(2)
                        End Select
                    Case "Lunes"
                        diaDepago = "Martes"
                        Select Case Numerodiahoy
                            Case "0"
                                primerPago = diaDeHoy.AddDays(2)
                            Case "1"
                                primerPago = diaDeHoy.AddDays(8)
                            Case "2"
                                primerPago = diaDeHoy.AddDays(7)
                            Case "3"
                                primerPago = diaDeHoy.AddDays(6)
                            Case "4"
                                primerPago = diaDeHoy.AddDays(5)
                            Case "5"
                                primerPago = diaDeHoy.AddDays(4)
                            Case "6"
                                primerPago = diaDeHoy.AddDays(3)
                        End Select
                    Case "Martes"
                        diaDepago = "Lunes"
                        Select Case Numerodiahoy
                            Case "0"
                                primerPago = diaDeHoy.AddDays(1)
                            Case "1"
                                primerPago = diaDeHoy.AddDays(7)
                            Case "2"
                                primerPago = diaDeHoy.AddDays(6)
                            Case "3"
                                primerPago = diaDeHoy.AddDays(5)
                            Case "4"
                                primerPago = diaDeHoy.AddDays(4)
                            Case "5"
                                primerPago = diaDeHoy.AddDays(3)
                            Case "6"
                                primerPago = diaDeHoy.AddDays(2)
                        End Select
                End Select
                Dim comandoActCredito As SqlCommand
                Dim consultaActCredito As String
                Dim fechaPago As Date
                consultaActCredito = "update credito set fechaentrega = '" & diaDeHoy.ToString("yyyy-MM-dd") & "',fechaprimerpago = '" & primerPago.ToString("yyyy-MM-dd") & "', estado = 'P',DiaDePago = '" & diaDepago & "' where id = '" & idCreditoAentregar & "'"
                comandoActCredito = New SqlCommand
                comandoActCredito.Connection = conexionempresa
                comandoActCredito.CommandText = consultaActCredito
                comandoActCredito.ExecuteNonQuery()

                For i As Integer = 0 To plazoAentregar - 1
                    Dim comandoCalendario As SqlCommand
                    Dim consultaCalendario As String
                    fechaPago = primerPago.AddDays(i * 7)
                    consultaCalendario = "insert into CalendarioNormal values('" & fechaPago.ToString("yyyy-MM-dd") & "','" & pagoIndividualAentregar & "',0,'" & pagoIndividualAentregar & "',0,'" & i + 1 & "','" & idCreditoAentregar & "','P',0,'')"
                    comandoCalendario = New SqlCommand
                    comandoCalendario.Connection = conexionempresa
                    comandoCalendario.CommandText = consultaCalendario
                    comandoCalendario.ExecuteNonQuery()

                Next

            Case "Q"
                ' MessageBox.Show("Hola")
                If numeroDiaMes >= 9 And numeroDiaMes <= 23 Then
                    If diaDeHoy.Month = 12 Then
                        primerPago = Convert.ToDateTime(diaDeHoy.AddYears(1).Year.ToString & "-" & diaDeHoy.AddMonths(1).Month.ToString & "-" & "01")
                    Else
                        primerPago = Convert.ToDateTime(diaDeHoy.Year.ToString & "-" & diaDeHoy.AddMonths(1).Month.ToString & "-" & "01")
                    End If
                ElseIf numeroDiaMes >= 1 And numeroDiaMes <= 8 Then
                    primerPago = Convert.ToDateTime(diaDeHoy.Year.ToString & "-" & diaDeHoy.Month.ToString & "-" & "16")
                ElseIf numeroDiaMes >= 24 And numeroDiaMes <= DateTime.DaysInMonth(diaDeHoy.Year, diaDeHoy.Month) Then
                    If diaDeHoy.Month = 12 Then
                        primerPago = Convert.ToDateTime(diaDeHoy.AddYears(1).Year.ToString & "-" & diaDeHoy.AddMonths(1).Month.ToString & "-" & "16")
                    Else
                        primerPago = Convert.ToDateTime(diaDeHoy.Year.ToString & "-" & diaDeHoy.AddMonths(1).Month.ToString & "-" & "16")
                    End If

                End If
                Dim comandoActCredito As SqlCommand
                Dim consultaActCredito As String
                '   Dim fechaPago As Date
                consultaActCredito = "update credito set fechaentrega = '" & diaDeHoy.ToString("yyyy-MM-dd") & "',fechaprimerpago = '" & primerPago.ToString("yyyy-MM-dd") & "', estado = 'P',DiaDePago = '" & diaDepago & "' where id = '" & idCreditoAentregar & "'"
                comandoActCredito = New SqlCommand
                comandoActCredito.Connection = conexionempresa
                comandoActCredito.CommandText = consultaActCredito
                comandoActCredito.ExecuteNonQuery()
                Dim fechapago As Date
                For i As Integer = 0 To plazoAentregar - 1
                    Dim comandoCalendario As SqlCommand
                    Dim consultaCalendario As String
                    If primerPago.Day = 16 Then
                        fechapago = primerPago
                        consultaCalendario = "insert into CalendarioNormal values('" & fechapago.ToString("yyyy-MM-dd") & "','" & pagoIndividualAentregar & "',0,'" & pagoIndividualAentregar & "',0,'" & i + 1 & "','" & idCreditoAentregar & "','P',0,'')"
                        comandoCalendario = New SqlCommand
                        comandoCalendario.Connection = conexionempresa
                        comandoCalendario.CommandText = consultaCalendario
                        comandoCalendario.ExecuteNonQuery()
                        '  dtdatos.Rows.Add(fechapago.ToString("yyyy-MM-dd"), MontoPago)
                        If primerPago.Month = 12 Then
                            primerPago = Convert.ToDateTime(primerPago.AddYears(1).Year.ToString & "-" & primerPago.AddMonths(1).Month.ToString & "-" & "01")
                        Else
                            primerPago = Convert.ToDateTime(primerPago.Year.ToString & "-" & primerPago.AddMonths(1).Month.ToString & "-" & "01")
                        End If

                        'deuda = deuda - MontoPago
                    Else
                        fechapago = primerPago
                        consultaCalendario = "insert into CalendarioNormal values('" & fechapago.ToString("yyyy-MM-dd") & "','" & pagoIndividualAentregar & "',0,'" & pagoIndividualAentregar & "',0,'" & i + 1 & "','" & idCreditoAentregar & "','P',0,'')"
                        comandoCalendario = New SqlCommand
                        comandoCalendario.Connection = conexionempresa
                        comandoCalendario.CommandText = consultaCalendario
                        comandoCalendario.ExecuteNonQuery()
                        'dtdatos.Rows.Add(fechapago.ToString("yyyy-MM-dd"), MontoPago)
                        primerPago = Convert.ToDateTime(primerPago.Year.ToString & "-" & primerPago.Month.ToString & "-" & "16")
                        ' deuda = deuda - MontoPago
                    End If
                Next


        End Select


    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
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
        Dim Prf1 As Word.Paragraph
        Dim Prf2 As Word.Paragraph
        Dim Prf3 As Word.Paragraph

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
    Private Sub dataTableToWordGrupal(ByVal dt As System.Data.DataTable)
        Dim Word As Application
        Dim Doc As Word.Document
        Dim Table As Word.Table
        Dim Rng As Range
        Dim Prf1 As Word.Paragraph
        Dim Prf2 As Word.Paragraph
        Dim Prf3 As Word.Paragraph

        Word = CreateObject("Word.Application")

        FileCopy("C:\ConfiaAdmin\SATI\CalendarioGrupal.docx", "C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendarioGrupal.docx")
        Doc = Word.Documents.Open("C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendarioGrupal.docx")
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
            Table.Rows.Item(i).Range.Font.Size = 14
        Next
        Table.AllowAutoFit = True
        Table.AutoFitBehavior(WdAutoFitBehavior.wdAutoFitContent)

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

    Private Sub BackgroundCalendario_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundCalendario.DoWork
        iniciarconexionempresa()

        Dim comandoFechaEntrega As SqlCommand
        Dim consultaFechaEntrega As String
        consultaFechaEntrega = "Select fechaEntrega,fechaPrimerPago,DiaDePago from credito where id = '" & idCreditoAentregar & "'"
        Dim readerFechaEntrega As SqlDataReader
        comandoFechaEntrega = New SqlCommand
        comandoFechaEntrega.Connection = conexionempresa
        comandoFechaEntrega.CommandText = consultaFechaEntrega
        readerFechaEntrega = comandoFechaEntrega.ExecuteReader
        While readerFechaEntrega.Read
            fechaCredito = readerFechaEntrega("FechaEntrega")
            fechaPimerPago = readerFechaEntrega("fechaPrimerPago")
            diaDepago = readerFechaEntrega("DiaDePago")
        End While
        readerFechaEntrega.Close()
        Dim dataCalendario As System.Data.DataTable
        Dim adapterCalendario As SqlDataAdapter
        Dim consultaCalendario As String

        consultaCalendario = "select format(Fechapago,'dd/MM/yyyy') as 'Fecha de pago',npago as 'Número de pago',format(Monto,'C','es-mx') as Monto from calendarioNormal where id_credito = '" & idCreditoAentregar & "'"
        adapterCalendario = New SqlDataAdapter(consultaCalendario, conexionempresa)
        dataCalendario = New Data.DataTable
        adapterCalendario.Fill(dataCalendario)
        dataTableToWord(dataCalendario)

    End Sub

    Private Sub BackgroundEntrega_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundEntrega.ProgressChanged

    End Sub

    Private Sub BackgroundCalendario_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundCalendario.RunWorkerCompleted
        Dim NumeroLetra As New NumLetra
        'Dim MSWord As New Word.Application
        'Dim Documento As Word.Document
        'Dim fechaActual As Date
        'fechaActual = Now

        ' FileCopy("C:\ConfiaAdmin\SATI\Pagare.docx", "C:\ConfiaAdmin\SATI\TEMPDOCS\TempPagare.docx")
        Dim documento As DocX = DocX.Load("C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendario.docx")
        documento.ReplaceText("%%FECHACREDITO%%", fechaCredito.ToString("dd/MM/yyyy"))
        documento.ReplaceText("%%NOMBRECREDITO%%", NombreCreditoAentregar)
        documento.ReplaceText("%%NOMBRERESPONSABLE%%", NombreClienteAentregar)
        documento.ReplaceText("%%IDCREDITO%%", idCreditoAentregar)
        documento.ReplaceText("%%DIAPAGO%%", diaDepago)

        Dim para As String = "Por medio del presente he sido debidamente notificado respecto a el pago diario, en caso de incumplimiento que asciende a la cantidad de $ 50.00 (CINCUENTA PESOS 00/100 M.N.). La cual se pagará de forma obligatoria juntamente con los pagos amortizados del calendario anteriormente descritos.


___________________________________________
Acepto
PRÉSTAMOS CONFIA S.A. DE C.V.
TEL.:" & telEmpresa & "
HORARIOS: Lunes a Viernes 09:00 a.m. a 02:00 p.m. / 04:00 p.m. a 07:00 p.m.
Sábado 09:00 a.m. a 02:00 p.m."
        documento.InsertParagraph(para).Alignment = Alignment.center
        documento.Save()
        documento.Dispose()
        'VistaPreviaDocumento.ruta = "C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendario.docx"
        'VistaPreviaDocumento.Show()
        Dim spDoc As New Spire.Doc.Document
        spDoc.LoadFromFile("C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendario.docx")
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

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        webcamCredito.Show()
    End Sub

    Private Sub btn_activar_Click(sender As Object, e As EventArgs) Handles btn_activar.Click
        If moto Then
            If motoCapturada Then
                If BunifuImageButton1.Image IsNot Nothing Then
                    Cargando.Show()
                    Cargando.MonoFlat_Label1.Text = "Activando Crédito"
                    BackgroundActivar.RunWorkerAsync()
                Else
                    MessageBox.Show("Para activar el crédito es necesario cargar una imagen del cliente")
                End If
            Else
                MessageBox.Show("Éste crédito contiene una motocicleta que no ha sido capturada, captúrala para proseguir")
            End If

        Else
            If BunifuImageButton1.Image IsNot Nothing Then
                Cargando.Show()
                Cargando.MonoFlat_Label1.Text = "Activando Crédito"
                BackgroundActivar.RunWorkerAsync()
            Else
                MessageBox.Show("Para activar el crédito es necesario cargar una imagen del cliente")
            End If

        End If



    End Sub

    Private Sub BackgroundActivar_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundActivar.DoWork
        iniciarconexionempresa()

        Dim comandoDocumento As SqlCommand
        Dim consultaDocumento As String
        Dim imagen As Bitmap = TryCast(BunifuImageButton1.Image, Bitmap)
        Dim NuevaImagen As Bitmap = ImagenComprimida(imagen)
        consultaDocumento = "insert into DocumentosCredito values('" & idCreditoAentregar & "','4',@Documento)"
        Dim imgDocumento As New SqlParameter("@Documento", SqlDbType.Image)
        Dim msImgDocumento As New MemoryStream
        NuevaImagen.Save(msImgDocumento, ImageFormat.Jpeg)
        imgDocumento.Value = msImgDocumento.GetBuffer
        comandoDocumento = New SqlCommand
        comandoDocumento.Connection = conexionempresa
        comandoDocumento.CommandText = consultaDocumento
        comandoDocumento.Parameters.Add(imgDocumento)
        comandoDocumento.ExecuteNonQuery()

        Dim comandoActCredito As SqlCommand
        Dim consultaActCredito As String
        consultaActCredito = "Update credito set estado = 'A' where id = '" & idCreditoAentregar & "'"
        comandoActCredito = New SqlCommand
        comandoActCredito.Connection = conexionempresa
        comandoActCredito.CommandText = consultaActCredito
        comandoActCredito.ExecuteNonQuery()



    End Sub
    Private Function ImagenComprimida(bmp As Bitmap) As Bitmap
        Try

            Dim Width As Integer = bmp.Width
            Dim Height As Integer = bmp.Height
            'next we declare the maximum size of the resized image. 
            'In this case, all resized images need to be constrained to a 173x173 square.
            Dim Heightmax As Integer = 1572
            Dim Widthmax As Integer = 1826
            'declare the minimum value af the resizing factor before proceeding. 
            'All images with a lower factor than this will actually be resized
            Dim Factorlimit As Decimal = 1
            'determine if it is a portrait or landscape image
            Dim Relative As Decimal = Height / Width
            Dim Factor As Decimal
            'if the image is a portrait image, calculate the resizing factor based on its height. 
            'else the image is a landscape image, 
            'and we calculate the resizing factor based on its width.
            If Relative > 1 Then
                If Height < (Heightmax + 1) Then
                    Factor = 1
                Else
                    Factor = Heightmax / Height
                End If
                '
            Else
                If Width < (Widthmax + 1) Then
                    Factor = 1
                Else
                    Factor = Widthmax / Width
                End If
            End If
            If Factor < Factorlimit Then
                'draw a new image with the dimensions that result from the resizing
                Dim bmpnew As New Bitmap(bmp.Width * Factor, bmp.Height * Factor,
                    Imaging.PixelFormat.Format24bppRgb)
                Dim g As Graphics = Graphics.FromImage(bmpnew)
                g.InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
                'and paste the resized image into it
                g.DrawImage(bmp, 0, 0, bmpnew.Width, bmpnew.Height)
                Return bmpnew
            Else
                Return bmp
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Sub BackgroundActivar_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundActivar.RunWorkerCompleted
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando datos"
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Generando Calendario"
        Cargando.TopMost = True

        BackgroundCalendario.RunWorkerAsync()
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

    Private Sub BackgroundCatatula_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundCatatula.DoWork
        Dim comandoFechaEntrega As SqlCommand
        Dim consultaFechaEntrega As String
        consultaFechaEntrega = "select fechaEntrega from credito where id = '" & idCreditoAentregar & "'"
        Dim fechaEntrega As Date
        comandoFechaEntrega = New SqlCommand
        comandoFechaEntrega.Connection = conexionempresa
        comandoFechaEntrega.CommandText = consultaFechaEntrega
        fechaEntrega = comandoFechaEntrega.ExecuteScalar

        FileCopy("C:\ConfiaAdmin\SATI\Caratula Informativa.docx", "C:\ConfiaAdmin\SATI\TEMPDOCS\TempCaratula.docx")
        Dim documento As DocX = DocX.Load("C:\ConfiaAdmin\SATI\TEMPDOCS\TempCaratula.docx")
        documento.ReplaceText("%%FECHACREDITO%%", fechaEntrega.ToString("dd/MM/yyyy"))

        documento.ReplaceText("%%NOMBRERESPONSABLE%%", NombreClienteAentregar)
        documento.Save()
        documento.Dispose()

    End Sub

    Private Sub BackgroundCatatula_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundCatatula.RunWorkerCompleted
        Dim spDoc As New Spire.Doc.Document
        spDoc.LoadFromFile("C:\ConfiaAdmin\SATI\TEMPDOCS\TempCaratula.docx")


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

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Generando carátula informativa"
        Cargando.TopMost = True
        BackgroundCatatula.RunWorkerAsync()

    End Sub

    Private Sub BackgroundTarjeta_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundTarjeta.DoWork
        FileCopy("C:\ConfiaAdmin\SATI\Tarjeta.docx", "C:\ConfiaAdmin\SATI\TEMPDOCS\TempTarjeta.docx")
        Dim documento As DocX = DocX.Load("C:\ConfiaAdmin\SATI\TEMPDOCS\TempTarjeta.docx")
        documento.ReplaceText("%%NOMBRECLIENTE%%", NombreClienteAentregar)
        documento.Save()
        documento.Dispose()

        Dim document As New Spire.Doc.Document
        document.LoadFromFile("C:\ConfiaAdmin\SATI\TEMPDOCS\TempTarjeta.docx")
        Dim selections As TextSelection() = document.FindAllString("%%QR%%", True, True)
        Dim index As Integer = 0
        Dim range As TextRange = Nothing
        gen_qr_file("C:\ConfiaAdmin\SATI\TEMPDOCS\QR", "CF-URP-0001", 50)
        Dim qr As New Bitmap("C:\ConfiaAdmin\SATI\TEMPDOCS\QR.png")

        For Each selection As TextSelection In selections
            Dim pic As DocPicture = New DocPicture(document)
            pic.LoadImage(qr)
            range = selection.GetAsOneRange()
            index = range.OwnerParagraph.ChildObjects.IndexOf(range)
            range.OwnerParagraph.ChildObjects.Insert(index, pic)
            range.OwnerParagraph.ChildObjects.Remove(range)
        Next

        document.SaveToFile("C:\ConfiaAdmin\SATI\TEMPDOCS\TempTarjeta.docx", FileFormat.Doc)
        '  System.Diagnostics.Process.Start("Sample.doc")

        'Dim GENERADOR As BarcodeWriter = New BarcodeWriter 'INICIALIZA EL GENERADOR
        'GENERADOR.Format = BarcodeFormat.QR_CODE
        ' Dim IMAGEN As Bitmap = New Bitmap(GENERADOR.Write("CF-URP-0001"), 50, 50)
        'IMAGEN.Save("C:\ConfiaAdmin\SATI\TEMPDOCS\QR.png")
        '  gen_qr_file("C:\ConfiaAdmin\SATI\TEMPDOCS\QR", "CF-URP-0001", 50)
        ' Dim Word As Application
        ' Dim Doc As Word.Document
        'Word = CreateObject("Word.Application")
        'Doc = Word.Documents.Open("C:\ConfiaAdmin\SATI\TEMPDOCS\TempTarjeta.docx")
        'Dim para As Word.Paragraph = Doc.Paragraphs.Add()
        ' para.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
        ' With para.Range.InlineShapes.AddPicture("C:\ConfiaAdmin\SATI\TEMPDOCS\QR.png").ConvertToShape
        '.WrapFormat.Type = Word.WdWrapType.wdWrapBehind
        ' End With
        ' para.Range.InsertParagraphAfter()
        'para.Range.ShapeRange.Item(1).WrapFormat.Type = WdWrapType.wdWrapInline
        'para.Range.InsertParagraph()
        'Word.ActiveDocument.InlineShapes(1).Range.ShapeRange.Item(0).WrapFormat.Type = WdWrapType.wdWrapInline
        'Dim _shape As Shape
        '_shape = Doc.Shapes.AddPicture(FileName:="C:\ConfiaAdmin\SATI\TEMPDOCS\QR.png", LinkToFile:=False, SaveWithDocument:=True)
        ' With _shape
        '.WrapFormat.Type = WdWrapType.wdWrapNone
        '.WrapFormat.Type = WdWrapType.wdWrapInline
        ' End With

        ' Doc.Save()
        ' Doc.Close()
        ' Word = Nothing
        ' Word.Application.Quit()
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

    Private Sub btnTarjeta_Click(sender As Object, e As EventArgs) Handles btnMoto.Click
        CaputarMotocicleta.idCredito = idCreditoAentregar
        CaputarMotocicleta.ShowDialog()
        If MotoActualizada Then
            BackgroundWorker1.RunWorkerAsync()

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

    Private Sub BackgroundGrupal_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundGrupal.DoWork
        Dim dataCalendario As System.Data.DataTable
        Dim adapterCalendario As SqlDataAdapter
        Dim consultaCalendario As String

        consultaCalendario = "declare @cols nvarchar(max), @sql nvarchar(max)
set @cols = STUFF((select ',' + QUOTENAME(Npago) from CalendarioNormal where id_credito =" & idCreditoAentregar & " FOR XML PATH('')),1,1,'')
set @sql = 'select row_number() over(order by integrante) as Numero,Integrante,format(Monto,'+ char(39) + 'C' + char(39) +','+ char(39) + 'es-mx' + char(39) +') as Monto,format(pago,'+ char(39) + 'C' + char(39) +','+ char(39) + 'es-mx' + char(39) +') as Pago,' + @cols + ' from 
(select credito.id,credito.nombre,concat(clientes.nombre,'+ char(39) + ' ' + char(39) + ',clientes.apellidopaterno,'+ char(39) + ' ' + char(39) + ',clientes.apellidomaterno) as Integrante,Npago,'+ char(39) + char(39) + ' as re,datossolicitud.montoautorizado as Monto,((datossolicitud.montoautorizado/ 1000) * credito.interes) as Pago from Credito inner join Solicitud on Credito.IdSolicitud = Solicitud.id inner join DatosSolicitud on DatosSolicitud.IdSolicitud = Solicitud.id inner join Clientes on DatosSolicitud.IdCliente = Clientes.id inner join calendarionormal on credito.id = calendarionormal.id_credito where Credito.id = " & idCreditoAentregar & " and datossolicitud.estado = '+ char(39) + 'A' + char(39) + ' ) s 
 pivot
 (
 max(re) FOR Npago in ('+ @cols +')
 )p'

 execute (@sql)"
        adapterCalendario = New SqlDataAdapter(consultaCalendario, conexionempresa)
        dataCalendario = New Data.DataTable
        adapterCalendario.Fill(dataCalendario)
        dataTableToWordGrupal(dataCalendario)
    End Sub

    Private Sub BackgroundGrupal_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundGrupal.RunWorkerCompleted
        Dim documento As DocX = DocX.Load("C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendarioGrupal.docx")
        documento.ReplaceText("%%GRUPO%%", NombreCreditoAentregar)
        documento.ReplaceText("%%MONTO%%", FormatCurrency(MontoAentregar, 2))
        documento.Save()
        documento.Dispose()


        Dim spDoc As New Spire.Doc.Document
        spDoc.LoadFromFile("C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendarioGrupal.docx")
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

    Private Sub btnGrupal_Click(sender As Object, e As EventArgs) Handles btnGrupal.Click
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Generando Calendario Grupal"
        BackgroundGrupal.RunWorkerAsync()

    End Sub

    Private Sub TileLayout1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TileLayout1_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub ImageStreamer1_Click(sender As Object, e As EventArgs)

    End Sub
End Class