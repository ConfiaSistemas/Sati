Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word
Imports WinControls.ListView
Imports Xceed.Words.NET

Public Class InformacionLegal
    Public idCredito As Integer
    Dim dataClientes As System.Data.DataTable
    Dim adapterClientes As SqlDataAdapter
    Dim dataCalendario As Data.DataTable
    Dim adapterCalendario As SqlDataAdapter
    Dim dataDocumentos As Data.DataTable
    Dim adapterDocumentos As SqlDataAdapter
    Dim bloqueado As Boolean = False
    Dim DeudaTotal As Double
    Dim Pagado As Double
    Dim restante As Double
    Dim dataGestiones As Data.DataTable
    Dim adapterGestiones As SqlDataAdapter
    Dim dataActualizaciones As Data.DataTable
    Dim adapterActualizaciones As SqlDataAdapter
    Dim dataGastos As Data.DataTable
    Dim adapterGastos As SqlDataAdapter
    Dim estado As String
    Dim FechaConvenio As Date
    Dim fechaInicio As Date
    Dim fechaFin As Date
    Dim plazo As Integer
    Dim dataCalConvenio As Data.DataTable
    Dim adapterCalConvenio As SqlDataAdapter
    Dim domicilio As String
    Dim nombreResponsable As String
    Dim Celular, telefono As String
    Private Sub InformacionSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Size = New Size(51, 85)
        Panel2.Location = New Drawing.Point(Me.Width - Panel2.Width, TabControl1.Location.Y - Panel2.Height)
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando Información"
        Cargando.TopMost = True
        BackgroundClientes.RunWorkerAsync()

    End Sub

    Private Sub BackgroundClientes_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundClientes.DoWork
        iniciarconexionempresa()
        Dim consultaCredito As String
        Dim comandoCredito As SqlCommand
        Dim readerCredito As SqlDataReader

        consultaCredito = "select id,Fecha,Nombre,Credito,Moratorios,DeudaAP,TotalDeuda,Estado,FechaInicio,FechaFin,FechaConvenio,estado,plazo from legales where id = '" & idCredito & "'"
        comandoCredito = New SqlCommand
        comandoCredito.Connection = conexionempresa
        comandoCredito.CommandText = consultaCredito
        readerCredito = comandoCredito.ExecuteReader
        While readerCredito.Read
            lblnombre.Text = readerCredito("Nombre")
            lblfecha.Text = readerCredito("fecha")
            lblParteCredito.Text = FormatCurrency(readerCredito("credito"))
            lblParteMoratorios.Text = FormatCurrency(readerCredito("moratorios"))
            lblSubTotal.Text = FormatCurrency(readerCredito("deudaAp"), 2)
            lblTotal.Text = FormatCurrency(readerCredito("TotalDeuda"), 2)
            DeudaTotal = readerCredito("TotalDeuda")
            estado = readerCredito("Estado")
            FechaConvenio = readerCredito("FechaConvenio")
            fechaInicio = readerCredito("FechaInicio")
            fechaFin = readerCredito("FechaFin")
            plazo = readerCredito("Plazo")
        End While

        readerCredito.Close()
        Dim tipoDoc As Integer
        tipoDoc = ObtenerTipoDoc("Legal")
        Dim comandoPagos As SqlCommand
        Dim consultaPagos As String
        consultaPagos = "select sum(subtotal) AS pagado from ticket where idCredito = '" & idCredito & "' and tipoDoc = '" & tipoDoc & "' and estado = 'A'"
        comandoPagos = New SqlCommand
        comandoPagos.Connection = conexionempresa
        comandoPagos.CommandText = consultaPagos
        If IsDBNull(comandoPagos.ExecuteScalar) Then
            Pagado = 0
        Else
            Pagado = comandoPagos.ExecuteScalar
        End If


        restante = DeudaTotal - Pagado

        lblRestante.Text = FormatCurrency(restante)
        lblAbonado.Text = FormatCurrency(Pagado)

        Dim comandoDomicilio As SqlCommand
        Dim consultaDomicilio As String
        Dim readerNombre As SqlDataReader
        consultaDomicilio = "select CONCAT(domicilioCompleto.Calle,' ',domicilioCompleto.Noext,' ',domicilioCompleto.Noint,' ',domicilioCompleto.Colonia) as Domicilio,CONCAT(Nombre,' ',ApellidoPaterno,' ',ApellidoMaterno) as nombre,Celular,Telefono from
(select domicilio.Calle,domicilio.Noext, (case when 
domicilio.Noint = 0 then
'' else
CONCAT('Interior ',domicilio.Noint) end) as Noint,Colonia,Nombre,ApellidoPaterno,ApellidoMaterno,Celular,Telefono
 from
(select DatosSolicitud.Calle,DatosSolicitud.Noext,DatosSolicitud.Noint,DatosSolicitud.Colonia,Clientes.Nombre,Clientes.ApellidoPaterno,Clientes.ApellidoMaterno,DatosSolicitud.Celular,DatosSolicitud.Telefono from legales inner join Solicitud on legales.IdSolicitud =  Solicitud.id inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud inner join Clientes on DatosSolicitud.IdCliente = Clientes.id where legales.id = '" & idCredito & "') domicilio) domicilioCompleto"
        comandoDomicilio = New SqlCommand
        comandoDomicilio.Connection = conexionempresa
        comandoDomicilio.CommandText = consultaDomicilio
        readerNombre = comandoDomicilio.ExecuteReader
        If readerNombre.HasRows Then
            While readerNombre.Read
                domicilio = readerNombre("Domicilio")
                nombreResponsable = readerNombre("nombre")
                telefono = readerNombre("Telefono")
                Celular = readerNombre("celular")
            End While
        End If

        readerNombre.Close()
        Dim consultaClientes As String
        consultaClientes = "select Clientes.id,Clientes.Nombre,Clientes.Apellidopaterno,Clientes.ApellidoMaterno from legales inner join Solicitud on legales.IdSolicitud =  Solicitud.id inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud inner join Clientes on DatosSolicitud.IdCliente = Clientes.id where legales.id = '" & idCredito & "'"
        adapterClientes = New SqlDataAdapter(consultaClientes, conexionempresa)
        dataClientes = New Data.DataTable
        adapterClientes.Fill(dataClientes)

    End Sub

    Private Sub BackgroundClientes_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundClientes.RunWorkerCompleted
        dtClientes.DataSource = dataClientes
        BackgroundSolicitud.RunWorkerAsync()
        dtSolicitud.Rows.Clear()
        dtSolicitud.ScrollBars = ScrollBars.None
    End Sub

    Private Sub BackgroundSolicitud_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundSolicitud.DoWork

        Try
            Dim strimpuestos As String
            iniciarconexionempresa()

            strimpuestos = "select Solicitud.id,format(Solicitud.Fecha,'dd-MM-yy') as Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo from legales inner join Solicitud on legales.IdSolicitud = Solicitud.id where legales.id = '" & idCredito & "'"




            Dim ejec = New SqlCommand(strimpuestos)
            ejec.Connection = conexionempresa
            Dim id, nombre, valor, factor, tipo As String

            Dim myreaderimpuestos As SqlDataReader = ejec.ExecuteReader()
            While myreaderimpuestos.Read
                id = myreaderimpuestos("id")
                If IsDBNull(myreaderimpuestos("montoAutorizado")) Then
                    valor = 0
                Else
                    valor = myreaderimpuestos("montoAutorizado")
                End If

                dtSolicitud.Rows.Add(id, myreaderimpuestos("fecha"), FormatCurrency(myreaderimpuestos("Monto"), 2), FormatCurrency(valor, 2), myreaderimpuestos("tipo"))
            End While
            myreaderimpuestos.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundSolicitud_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundSolicitud.RunWorkerCompleted
        dtSolicitud.ScrollBars = ScrollBars.Both
        BackgroundCalendario.RunWorkerAsync()

    End Sub

    Private Sub BackgroundCalendario_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundCalendario.DoWork
        Dim consultaCalendario As String
        consultaCalendario = "select format(calendariolegales.FechaPago,'dd-MM-yy') as FechaPago,calendariolegales.Npago,calendariolegales.Monto,calendariolegales.Interes,Calendariolegales.Pendiente from legales inner join calendarioLegales on legales.id = calendariolegales.idcredito where legales.id = '" & idCredito & "'"
        adapterCalendario = New SqlDataAdapter(consultaCalendario, conexionempresa)
        dataCalendario = New Data.DataTable
        adapterCalendario.Fill(dataCalendario)
    End Sub

    Private Sub BackgroundCalendario_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundCalendario.RunWorkerCompleted
        dtCalendarios.DataSource = dataCalendario
        BackgroundDocumentos.RunWorkerAsync()

    End Sub

    Private Sub BackgroundDocumentos_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundDocumentos.DoWork
        Dim consultaDocumentos As String
        consultaDocumentos = "select TiposdeDocumentosSolicitud.Nombre,DocumentosLegales.imagen from legales inner join DocumentosLegales on legales.id = DocumentosLegales.IdCredito inner join TiposdeDocumentosSolicitud on DocumentosLegales.Tipo = TiposdeDocumentosSolicitud.id where legales.id = '" & idCredito & "'"
        adapterDocumentos = New SqlDataAdapter(consultaDocumentos, conexionempresa)
        dataDocumentos = New Data.DataTable
        adapterDocumentos.Fill(dataDocumentos)
    End Sub

    Private Sub BackgroundDocumentos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundDocumentos.RunWorkerCompleted
        dtdatosDocumentos.DataSource = dataDocumentos
        BackgroundPagos.RunWorkerAsync()

        'Cargando.Close()
    End Sub

    Private Sub dtSolicitud_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtSolicitud.CellContentClick

    End Sub

    Private Sub dtSolicitud_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtSolicitud.CellContentDoubleClick
        DatosConsultaSolicitud.idSolicitud = dtSolicitud.Rows(dtSolicitud.CurrentRow.Index).Cells(0).Value
        '  DatosConsultaSolicitud.TipoSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(5).Value
        DatosConsultaSolicitud.Show()
    End Sub



    Private Sub dtdatosDocumentos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtdatosDocumentos.CellContentDoubleClick
        VistaDocumento.PictureBox1.Image = dtdatosDocumentos.Rows(dtdatosDocumentos.CurrentRow.Index).Cells(1).FormattedValue
        VistaDocumento.ShowDialog()
    End Sub

    Private Sub BackgroundPagos_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundPagos.DoWork
        iniciarconexionempresa()
        TreeListView1.Nodes.Clear()


        Dim tipoDocLegal As Integer
        tipoDocLegal = ObtenerTipoDoc("Legal")
        Dim comandoTicket As SqlCommand
        Dim consulta As String
        Dim readerTicket As SqlDataReader



        consulta = "select id,Recibido,(case when tipo = 'Legal' then  ISNULL((select nombre from Legales where id = pagos.idCredito),0) 		
							   when tipo = 'Extra' then Concepto
							  
							   else ISNULL((select nombre from Credito where id = pagos.idCredito),0) 		end) as nombre,idCredito,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja from
(select Ticket.Id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.PagoNormal,Ticket.Intereses,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id  where  ticket.idcredito = '" & idCredito & "' and Ticket.TipoDoc = '" & tipoDocLegal & "'  )pagos order by Fecha,Hora asc"


        comandoTicket = New SqlCommand
        comandoTicket.Connection = conexionempresa
        comandoTicket.CommandText = consulta
        readerTicket = comandoTicket.ExecuteReader
        If readerTicket.HasRows Then
            While readerTicket.Read
                Dim liItem As New TreeListNode(readerTicket("id"))
                With liItem.SubItems
                    .Add(readerTicket("idcredito"))
                    .Add(readerTicket("nombre"))
                    .Add(readerTicket("pagonormal"))
                    .Add(readerTicket("Intereses"))
                    .Add(readerTicket("total"))
                    .Add(readerTicket("Fecha"))
                    .Add(readerTicket("Hora").ToString)
                    .Add(readerTicket("Tipo"))
                    .Add(readerTicket("Caja"))
                End With

                Dim COMANDOdetalle As SqlCommand
                Dim consultaDetalle As String
                Dim readerDetalle As SqlDataReader
                consultaDetalle = "select concat(ticketdetalle.concepto,' de ','Pago ', calendariolegales.NPago) as pago,pagonormal,intereses,ticketdetalle.monto from ticketdetalle inner join calendariolegales on ticketdetalle.idpago = CalendarioLegales.idpago where  idTicket = '" & readerTicket("id") & "'"
                COMANDOdetalle = New SqlCommand
                COMANDOdetalle.Connection = conexionempresa
                COMANDOdetalle.CommandText = consultaDetalle
                readerDetalle = COMANDOdetalle.ExecuteReader
                If readerDetalle.HasRows Then
                    While readerDetalle.Read
                        Me._addSubItems(liItem.Nodes.Add(readerDetalle("pago")), readerDetalle("pagonormal"), readerDetalle("intereses"), readerDetalle("monto"))
                    End While
                End If
                TreeListView1.Nodes.Add(liItem)
            End While
        End If
    End Sub
    Private Sub _addSubItems(ByVal aObj As ContainerListViewObject, ByVal pagonormal As Double, ByVal intereses As Double, ByVal total As Double)
        With aObj.SubItems
            .Add("")
            .Add("")
            .Add(pagonormal)
            .Add(intereses)
            .Add(total)
        End With
    End Sub

    Private Sub BackgroundPagos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundPagos.RunWorkerCompleted
        Cargando.MonoFlat_Label1.Text = "Cargando Gestiones"
        BackgroundGestiones.RunWorkerAsync()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel2_MouseHover(sender As Object, e As EventArgs) Handles Panel2.MouseHover

    End Sub

    Private Sub Panel2_MouseLeave(sender As Object, e As EventArgs) Handles Panel2.MouseLeave

    End Sub

    Private Sub InformacionLegal_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        For i As Integer = Panel2.Width To 51 Step -10
            Panel2.Width = i
            Panel2.Location = New Drawing.Point(Me.Width - Panel2.Width, TabControl1.Location.Y - Panel2.Height)
        Next
        bloqueado = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        If bloqueado Then

        Else
            For i As Integer = 51 To 615 Step 10
                Panel2.Width = i
                Panel2.Location = New Drawing.Point(Me.Width - Panel2.Width, TabControl1.Location.Y - Panel2.Height)
            Next
            bloqueado = True
        End If

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        ActInformacionLegal.idCreditoLegal = Me.idCredito
        ActInformacionLegal.Show()

    End Sub

    Private Sub btnGenerarCalendario_Click(sender As Object, e As EventArgs) Handles btnGenerarCalendario.Click
        DocumentosCreditoLegal.idCredito = idCredito
        DocumentosCreditoLegal.Show()
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        AgregarGestionLegal.idCredito = idCredito
        AgregarGestionLegal.Show()

    End Sub

    Private Sub BackgroundGestiones_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundGestiones.DoWork
        Dim consultaGestiones As String
        iniciarconexionempresa()
        consultaGestiones = "select id,Fecha,Concepto from gestioneslegales where idcredito = '" & idCredito & "'"
        adapterGestiones = New SqlDataAdapter(consultaGestiones, conexionempresa)
        dataGestiones = New Data.DataTable
        adapterGestiones.Fill(dataGestiones)
    End Sub

    Private Sub BackgroundGestiones_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundGestiones.RunWorkerCompleted
        dtGestiones.DataSource = dataGestiones
        Cargando.MonoFlat_Label1.Text = "Cargando Actualizaciones"
        BackgroundActualizaciones.RunWorkerAsync()

    End Sub

    Private Sub BackgroundActualizaciones_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundActualizaciones.DoWork
        iniciarconexionempresa()
        Dim consultaActualizaciones As String
        consultaActualizaciones = "select Fecha,Hora,Campo,ValorAnterior,NuevoValor,Motivo from ActualizacionesLegal where idCreditoLegal = '" & idCredito & "'"
        adapterActualizaciones = New SqlDataAdapter(consultaActualizaciones, conexionempresa)
        dataActualizaciones = New Data.DataTable
        adapterActualizaciones.Fill(dataActualizaciones)

    End Sub

    Private Sub BackgroundActualizaciones_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundActualizaciones.RunWorkerCompleted
        dtActualizaciones.DataSource = dataActualizaciones
        Cargando.MonoFlat_Label1.Text = "Cargando Gastos"
        BackgroundGastos.RunWorkerAsync()

    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        AgregarGastosLegales.idCredito = idCredito
        AgregarGastosLegales.Show()

    End Sub

    Private Sub BackgroundGastos_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundGastos.DoWork
        iniciarconexionempresa()
        Dim consultaGastos As String
        consultaGastos = "select Fecha,Monto,Concepto,Usuario,NombreUsuario from gastoslegales where idcredito = '" & idCredito & "'"
        adapterGastos = New SqlDataAdapter(consultaGastos, conexionempresa)
        dataGastos = New System.Data.DataTable
        adapterGastos.Fill(dataGastos)
    End Sub

    Private Sub BackgroundGastos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundGastos.RunWorkerCompleted
        dtGastos.DataSource = dataGastos
        If estado = "C" Then
            BunifuThinButton22.Enabled = True
        Else
            BunifuThinButton22.Enabled = False
        End If
        Cargando.Close()
    End Sub

    Private Sub BackgroundCalConvenio_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundCalConvenio.DoWork
        iniciarconexionempresa()




        Dim consultaCalendario As String

        consultaCalendario = "select format(Fechapago,'dd/MM/yyyy') as 'Fecha de pago',npago as 'Número de pago',format(Monto+interes,'C','es-mx') as Monto from calendarioLegales where idcredito = '" & idCredito & "'"
        adapterCalConvenio = New SqlDataAdapter(consultaCalendario, conexionempresa)
        dataCalConvenio = New Data.DataTable
        adapterCalConvenio.Fill(dataCalConvenio)
        dataTableToWord(dataCalConvenio)

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

        FileCopy("C:\ConfiaAdmin\SATI\PagareLegal.docx", "C:\ConfiaAdmin\SATI\TEMPDOCS\TempLegal.docx")
        Doc = Word.Documents.Open("C:\ConfiaAdmin\SATI\TEMPDOCS\TempLegal.docx")
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
            Table.Rows.Item(i).Range.Font.Size = 8
        Next


        'Boder De La Tabla
        Table.Borders.InsideLineStyle = WdLineStyle.wdLineStyleEngrave3D
        Table.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleEngrave3D
        Table.Borders.InsideColor = WdColor.wdColorBlack
        Rng = Doc.Bookmarks.Item("\endofdoc").Range
        'Rng.InsertParagraphAfter()

        Doc.Save()
        Doc.Close()
        ' Word = Nothing
        Word.Application.Quit()


    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Generando Convenio"
        Cargando.TopMost = True
        BackgroundCalConvenio.RunWorkerAsync()
    End Sub

    Private Sub BackgroundCalConvenio_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundCalConvenio.RunWorkerCompleted
        Dim NumeroLetra As New NumLetra
        'Dim MSWord As New Word.Application
        'Dim Documento As Word.Document
        'Dim fechaActual As Date
        'fechaActual = Now

        ' FileCopy("C:\ConfiaAdmin\SATI\Pagare.docx", "C:\ConfiaAdmin\SATI\TEMPDOCS\TempPagare.docx")
        Dim documento As DocX = DocX.Load("C:\ConfiaAdmin\SATI\TEMPDOCS\TempLegal.docx")
        documento.ReplaceText("%%FECHACREDITO%%", FechaConvenio.ToString("dd/MM/yyyy"))
        documento.ReplaceText("%%TELEFONORESPONSABLE%%", telefono)
        documento.ReplaceText("%%CELULARRESPONSABLE%%", Celular)
        'documento.ReplaceText("%%DOMICILIORESPONSABLE%%", domicilio)
        documento.ReplaceText("%%DOMICILIORESPONSABLE%%", domicilio)
        documento.ReplaceText("%%NOMBRERESPONSABLE%%", nombreResponsable)
        documento.ReplaceText("%%TOTALDEUDALETRAS%%", NumeroLetra.Convertir(DeudaTotal, True))
        documento.ReplaceText("%%TOTALDEUDA%%", FormatCurrency(DeudaTotal, 2))

        Dim para As String = "Bueno por " & FormatCurrency(DeudaTotal, 2) & " " & NumeroLetra.Convertir(DeudaTotal, True) & " En la ciudad de URUAPAN MICHOACAN, a " & CDate(FechaConvenio).ToString("dd") & " de " & CDate(FechaConvenio).ToString("MMMM") & " " & CDate(FechaConvenio).ToString("yyyy") & ";  La titular " & nombreResponsable & " debo (emos) pagare (emos) incondicionalmente por este PAGARE a la orden de   Prestamos Confía S.A. de C.V. EN URUAPAN Estado MICHOACAN, EL DIA " & CDate(FechaConvenio.AddDays(5)).ToString("dd") & " de " & CDate(FechaConvenio.AddDays(5)).ToString("MMMM") & " " & CDate(FechaConvenio.AddDays(5)).ToString("yyyy") & ", la cantidad de por " & FormatCurrency(DeudaTotal, 2) & " (" & NumeroLetra.Convertir(DeudaTotal, True) & ") Valor recibido a nuestra satisfacción. 
Este pagaré forma parte de una serie de 1 a 1 y todos están sujetos a la condición de que, al no pagarse cualquiera de ellos a su vencimiento, serán exigibles todos los que se sigan en número, y desde la fecha de vencimiento de este documento hasta el día de su liquidación, causará interés moratorio del 7% siete por ciento mensual, pagadero en esta ciudad juntamente con el principal.
Se aplicará en lo conducente los numerales  1, 2, 3, 4, 5, 15, 21, 23, 24, 26, 29, 33, 109, 110, 111, 113, 114, 150, 151, 152, 170, 171, 172, 173, 174 y demás relativos aplicables de la Ley General de Títulos y Operaciones de crédito, así como los comprendidos del 1391 al 1414 del Código de Comercio en Vigor. "

        documento.InsertParagraph(para).FontSize(8).Alignment = Alignment.both
        Dim firma As String
        firma = "
__________________________   
" & nombreResponsable & ""
        documento.InsertParagraph(firma).FontSize(8).Alignment = Alignment.center
        documento.Save()
        documento.Dispose()
        'VistaPreviaDocumento.ruta = "C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendario.docx"
        'VistaPreviaDocumento.Show()
        Dim spDoc As New Spire.Doc.Document
        spDoc.LoadFromFile("C:\ConfiaAdmin\SATI\TEMPDOCS\TempLegal.docx")
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
End Class