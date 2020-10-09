Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO

Public Class DatosSolicitudBoletaVerificar
    Public idSolicitud As Integer
    Public idDatosSolicitud As Integer
    Dim edad As Integer
    Dim dataCliente As DataTable
    Dim adapterCliente As SqlDataAdapter
    Dim pendientes As Integer = 0
    Dim dataDatos As DataTable
    Dim adapterDatos As SqlDataAdapter
    Dim dataDocumentos As DataTable
    Dim adapterDocumentos As SqlDataAdapter
    Public tipoSolicitud As Integer
    Dim tipoSolicitudString As String
    Public DocumentosCapturados As Boolean
    Dim DatosCapturados As Boolean
    Dim dataArticulos As DataTable
    Dim adapterArticulos As SqlDataAdapter
    Dim montoTotalAutorizado As Double = 0
    Dim totalArticulosAutorizados As Integer = 0
    Dim idcliente, idPromotor As Integer
    Dim montoTotalValuado As Double
    Dim montoTotalSugerido As Double
    Dim porcentajeRefrendo As Double
    Dim nombreCliente As String
    Public verSolicitud As Boolean
    Private Sub DatosSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each ctrl As Control In TabPage1.Controls
            If TypeOf ctrl Is Bunifu.Framework.UI.BunifuMaterialTextbox Then
                Dim txtControl As Bunifu.Framework.UI.BunifuMaterialTextbox = ctrl
                txtControl.Enabled = False
            End If



        Next
        dtdatos.ScrollBars = ScrollBars.None
        Cargando.Show()
        Cargando.TopMost = True
        Cargando.MonoFlat_Label1.Text = "Cargando Datos"
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        iniciarconexionempresa()

        Dim consultaDatosSolicitud As String
        Dim ComandoDatosSolicitud As SqlCommand
        Dim readerDatosSolicitud As SqlDataReader
        consultaDatosSolicitud = "select SolicitudBoleta.id,SolicitudBoleta.Nombre,SolicitudBoleta.Telefono, SolicitudBoleta.Domicilio,SolicitudBoleta.CodigoPostal,SolicitudBoleta.Colonia,SolicitudBoleta.Municipio,SolicitudBoleta.Entidad,SolicitudBoleta.CURP,SolicitudBoleta.MontoValuado,SolicitudBoleta.MontoSugerido,SolicitudBoleta.MontoAutorizado,SolicitudBoleta.Fecha,SolicitudBoleta.Estado,SolicitudBoleta.idTipoEmpeño,SolicitudBoleta.idpromotor,SolicitudBoleta.Ine,Clientes.Nombre as nombres,Clientes.ApellidoPaterno,Clientes.ApellidoMaterno,solicitudboleta.idcliente,solicitudboleta.porcentajerefrendo from SolicitudBoleta inner join Clientes on SolicitudBoleta.idCliente=Clientes.id where SolicitudBoleta.id='" & idSolicitud & "'"
        ComandoDatosSolicitud = New SqlCommand
        ComandoDatosSolicitud.Connection = conexionempresa
        ComandoDatosSolicitud.CommandText = consultaDatosSolicitud
        readerDatosSolicitud = ComandoDatosSolicitud.ExecuteReader
        If readerDatosSolicitud.HasRows Then
            While readerDatosSolicitud.Read
                txtnombre.Text = readerDatosSolicitud("nombres")
                nombreCliente = readerDatosSolicitud("Nombre")
                txtApellidoP.Text = readerDatosSolicitud("ApellidoPaterno")
                txtApellidoM.Text = readerDatosSolicitud("ApellidoMaterno")
                txtCelular.Text = readerDatosSolicitud("Telefono")
                txtCodigoPostal.Text = readerDatosSolicitud("CodigoPostal")
                txtDomicilio.Text = readerDatosSolicitud("Domicilio")
                txtIne.Text = readerDatosSolicitud("Ine")
                ConsultaColoniasPersonal()
                idcliente = readerDatosSolicitud("idcliente")
                ComboColonia.Text = readerDatosSolicitud("colonia")
                txtCiudad.Text = readerDatosSolicitud("Municipio")
                txtEstado.Text = readerDatosSolicitud("Entidad")
                txtCurp.Text = readerDatosSolicitud("curp")
                tipoSolicitud = readerDatosSolicitud("idtipoempeño")
                montoTotalValuado = readerDatosSolicitud("MontoValuado")
                montoTotalSugerido = readerDatosSolicitud("montoSugerido")
                porcentajeRefrendo = readerDatosSolicitud("porcentajerefrendo")
                idPromotor = readerDatosSolicitud("idPromotor")
            End While
        End If
        readerDatosSolicitud.Close()



        'Dim consultaArticulos As String
        'consultaArticulos = "select ArticulosEmpeños.id, ArticulosEmpeños.Descripcion, ArticulosEmpeños.idSolicitud,ArticulosEmpeños.Imagen,ArticulosEmpeños.Marca,ArticulosEmpeños.Modelo,ArticulosEmpeños.MontoValuado,ArticulosEmpeños.MontoSugerido,ArticulosEmpeños.NoSerie, TipoArticulosEmpeño.Nombre from ArticulosEmpeños inner join tipoarticulosempeño on tipoarticulosempeño.id=ArticulosEmpeños.Tipo where ArticulosEmpeños.idSolicitud = '" & idSolicitud & "'"
        'adapterArticulos = New SqlDataAdapter(consultaArticulos, conexionempresa)
        'dataArticulos = New DataTable
        'adapterArticulos.Fill(dataArticulos)
        'dtdatos.DataSource = dataArticulos

        Dim consultaArticulos As String
        Dim comandoArticulos As SqlCommand
        Dim readerArticulos As SqlDataReader

        consultaArticulos = "select ArticulosEmpeños.id, ArticulosEmpeños.Descripcion, ArticulosEmpeños.idSolicitud,ArticulosEmpeños.Imagen,ArticulosEmpeños.Marca,ArticulosEmpeños.Modelo,ArticulosEmpeños.MontoValuado,ArticulosEmpeños.MontoSugerido,ArticulosEmpeños.NoSerie, TipoArticulosEmpeño.Nombre,articulosempeños.aprobado from ArticulosEmpeños inner join tipoarticulosempeño on tipoarticulosempeño.id=ArticulosEmpeños.Tipo where ArticulosEmpeños.idSolicitud = '" & idSolicitud & "'"

        comandoArticulos = New SqlCommand
        comandoArticulos.Connection = conexionempresa
        comandoArticulos.CommandText = consultaArticulos
        readerArticulos = comandoArticulos.ExecuteReader
        If readerArticulos.HasRows Then
            While readerArticulos.Read
                Dim bytBLOBData() As Byte = readerArticulos("imagen")
                Dim stmBLOBData As New IO.MemoryStream(bytBLOBData)
                Dim imagen As Image
                imagen = System.Drawing.Image.FromStream(stmBLOBData)
                dtdatos.Rows.Add(readerArticulos("id"), readerArticulos("idsolicitud"), readerArticulos("descripcion"), readerArticulos("Marca"), readerArticulos("Modelo"), readerArticulos("Noserie"), readerArticulos("MontoValuado"), readerArticulos("MontoSugerido"), "", imagen, readerArticulos("nombre"), readerArticulos("aprobado"))
                For Each row As DataGridViewRow In dtdatos.Rows
                    row.Height = 100
                Next
            End While
        End If

        Dim comandoTipo As SqlCommand
        Dim consultaTipo As String
        consultaTipo = "Select nombre from tiposdeempeño where id = '" & tipoSolicitud & "'"
        comandoTipo = New SqlCommand
        comandoTipo.Connection = conexionempresa
        comandoTipo.CommandText = consultaTipo
        tipoSolicitudString = comandoTipo.ExecuteScalar





    End Sub

    Private Sub ConsultarCliente(idCliente As String)


        For Each row As DataRow In dataDatos.Rows
            If row("idCliente").ToString = idCliente Then
                txtnombre.Text = row("Nombre").ToString

                txtApellidoP.Text = row("ApellidoPaterno").ToString
                txtApellidoM.Text = row("ApellidoMaterno").ToString

                Exit For
            End If
        Next

        BackgroundDocumentos.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        dtdatos.Columns(2).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        'Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando Documentos..."
        Cargando.TopMost = True
        BackgroundDocumentos.RunWorkerAsync()

    End Sub

    Private Sub btn_Procesar_Click(sender As Object, e As EventArgs) Handles btn_Procesar.Click
        For Each row As DataRow In dataPermisos.Rows
            If row("SatiModSolicitudesEmpeñoModificar") Then
                Cargando.Show()
                Cargando.MonoFlat_Label1.Text = "Registrando Captura"
                BackgroundAct.RunWorkerAsync()
                Exit For
            Else

            End If
        Next

    End Sub

    Private Sub BackgroundAct_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundAct.DoWork
        iniciarconexionempresa()

        For Each row As DataGridViewRow In dtdatos.Rows
            Dim comandoActArticulos As SqlCommand
            Dim consultaActArticulos As String
            consultaActArticulos = "update Articulosempeños set
                                     MontoPrestado = '" & row.Cells(8).Value & "',
                                     Aprobado = '" & row.Cells(11).FormattedValue & "'
                                      where id = '" & row.Cells(0).Value & "'"
            comandoActArticulos = New SqlCommand
            comandoActArticulos.Connection = conexionempresa
            comandoActArticulos.CommandText = consultaActArticulos
            comandoActArticulos.ExecuteNonQuery()

            Dim c As Boolean
            c = Convert.ToBoolean(row.Cells(11).GetEditedFormattedValue(row.Index, 11))
            If c Then
                totalArticulosAutorizados += 1

            End If

        Next


    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs)
        AgregarDocumentoDatosSolicitudBoleta.Show()
    End Sub

    Private Sub BackgroundDocumentosSolicitud_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundDocumentosSolicitud.DoWork
        iniciarconexionempresa()


    End Sub

    Private Sub BackgroundAct_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundAct.RunWorkerCompleted
        Cargando.Close()

        If totalArticulosAutorizados > 0 Then
            btn_a_autorizacion.Visible = True
            btn_rechazar.Visible = False
        Else
            btn_rechazar.Visible = True
            btn_a_autorizacion.Visible = False
        End If
        'BackgroundDocumentosSolicitud.RunWorkerAsync()
    End Sub

    Private Sub BackgroundDocumentosSolicitud_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundDocumentosSolicitud.RunWorkerCompleted
        'ActDatosTabla()

        ' Cargando.Close()

        If VerificaDatos() = True Then
            BackgroundCargaDocumentos.RunWorkerAsync()

            'BackgroundWorker2.RunWorkerAsync()
        Else
            MessageBox.Show("Faltan datos por capturar")
            Cargando.Close()
        End If
    End Sub

    Private Sub btn_a_verificacion_Click(sender As Object, e As EventArgs) Handles btn_a_autorizacion.Click
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Enviando a verificación"
        BackgroundVerificacion.RunWorkerAsync()

    End Sub

    Private Sub BackgroundVerificacion_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundVerificacion.DoWork
        iniciarconexionempresa()
        Dim tiempo As String = TimeOfDay.ToString("HH:mm:ss")
        Dim comandoActEstado As SqlCommand
        Dim consultaActEstado As String
        consultaActEstado = "update Solicitudboleta set estado = 'A', montoautorizado=" & montoTotalAutorizado & ", usuarioautoriza='" & nmusr & "' where id = '" & idSolicitud & "'"
        comandoActEstado = New SqlCommand
        comandoActEstado.Connection = conexionempresa
        comandoActEstado.CommandText = consultaActEstado
        comandoActEstado.ExecuteNonQuery()

        Dim MontoRefrendo As Double
        MontoRefrendo = ((porcentajeRefrendo * 0.01) * montoTotalAutorizado) * 1.16
        Dim comandoCreaEmpeño As SqlCommand
        Dim consultaCreaEmpeños As String
        Dim interesdiario As Double
        interesdiario = MontoRefrendo / 7

        consultaCreaEmpeños = "insert into Empeños values('" & idcliente & "','" & idSolicitud & "','" & nombreCliente & "','" & montoTotalValuado & "','" & montoTotalAutorizado & "','7','" & MontoRefrendo & "','" & porcentajeRefrendo & "','" & interesdiario & "','" & Now.Date.ToString("yyyy-MM-dd") & "','','','','" & idPromotor & "','E','" & txtIne.Text & "','" & montoTotalAutorizado & "','') select SCOPE_IDENTITY()"
        comandoCreaEmpeño = New SqlCommand
        comandoCreaEmpeño.Connection = conexionempresa
        comandoCreaEmpeño.CommandText = consultaCreaEmpeños
        Dim idEmpeñoCreado As Integer
        idEmpeñoCreado = comandoCreaEmpeño.ExecuteScalar

        Dim insertCronogramaSolicitud As SqlCommand
        Dim consultaInsertCronogramaSolicitud As String
        consultaInsertCronogramaSolicitud = "insert into CronogramaSolicitudEmpeño values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & idSolicitud & "','Se autorizó por " & nmusr & " y se creó el empeño con el id " & idEmpeñoCreado & "')"
        insertCronogramaSolicitud = New SqlCommand
        insertCronogramaSolicitud.Connection = conexionempresa
        insertCronogramaSolicitud.CommandText = consultaInsertCronogramaSolicitud
        insertCronogramaSolicitud.ExecuteNonQuery()

    End Sub

    Private Sub BackgroundVerificacion_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundVerificacion.RunWorkerCompleted
        Cargando.Close()
        Me.Invoke(Sub()
                      SolicitudesEmpeños.cargarSolicitudes()

                  End Sub)
        Me.Close()

    End Sub



    Private Sub BackgroundDocumentos_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundDocumentos.DoWork
        iniciarconexionempresa()
        Dim consultaDocumentos As String
        consultaDocumentos = "Select DocumentosSolicitudboleta.Tipo,TiposdeDocumentosSolicitud.Nombre,DocumentosSolicitudboleta.Imagen from DocumentosSolicitudboleta inner join TiposdeDocumentosSolicitud on DocumentosSolicitudboleta.Tipo = TiposdeDocumentosSolicitud.id where idsolicitudboleta = '" & idSolicitud & "'"
        adapterDocumentos = New SqlDataAdapter(consultaDocumentos, conexionempresa)
        dataDocumentos = New DataTable
        adapterDocumentos.Fill(dataDocumentos)
    End Sub

    Private Sub BackgroundDocumentos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundDocumentos.RunWorkerCompleted
        dtdatosDocumentos.DataSource = dataDocumentos
        For Each column As DataGridViewColumn In dtdatosDocumentos.Columns
            If TypeOf dtdatosDocumentos.Columns(2) Is DataGridViewImageColumn Then 'resizes images
                CType(dtdatosDocumentos.Columns(2), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom
            End If


        Next
        dtdatosDocumentos.Columns(2).Width = 200
        BackgroundWorker2.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        CheckForIllegalCrossThreadCalls = False
        Me.Invoke(Sub()
                      Dim num_controles As Integer = FlowLayoutPanel1.Controls.Count - 1
                      For n As Integer = num_controles To 0 Step -1
                          Dim ctrl As Control = FlowLayoutPanel1.Controls(n)
                          FlowLayoutPanel1.Controls.Remove(ctrl)
                          ctrl.Dispose()
                      Next
                      Try
                          iniciarconexion()
                          Dim sql As String
                          Dim comando As SqlCommand

                          Dim milector As SqlDataReader
                          comando = New SqlCommand

                          comando.Connection = conexionempresa
                          sql = "select ajas.idTipo,ajas.Nombre,case when (select top 1 Tipo from DocumentosSolicitudboleta where Tipo = ajas.idTipo and DocumentosSolicitudboleta.idSolicitudBoleta = '" & idSolicitud & "') IS  null then 0 else 1 end as Cargado from
(select DocumentosNecesariosEmpeño.idTipo,TiposdeDocumentosSolicitud.Nombre from DocumentosNecesariosEmpeño inner join TiposdeDocumentosSolicitud on DocumentosNecesariosEmpeño.idTipo = TiposdeDocumentosSolicitud.id where idTipoEmpeño = '" & tipoSolicitud & "' and TiposdeDocumentosSolicitud.Tipo = 'A') ajas"
                          comando.CommandText = sql
                          milector = comando.ExecuteReader
                          While milector.Read
                              Dim checkTipo As New CheckBox

                              checkTipo.ForeColor = Color.FromKnownColor(KnownColor.Window)
                              checkTipo.Name = milector("idtipo")
                              checkTipo.Text = milector("nombre")
                              checkTipo.CheckState = milector("Cargado")
                              checkTipo.AutoSize = True

                              checkTipo.Enabled = False

                              'checkTipo.Tag = milector("ip")

                              FlowLayoutPanel1.Controls.Add(checkTipo)
                          End While
                          milector.Close()
                      Catch ex As Exception

                      End Try
                      '

                  End Sub
            )


    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted

        dtdatos.ScrollBars = ScrollBars.Both

        'Deshabilitamos los botones si solo se tiene que ver la solicitud sin modificarla
        If verSolicitud Then
            btn_Procesar.Enabled = False
            btn_Procesar.Visible = False
            dtdatos.Columns(8).ReadOnly = True
            dtdatos.Columns(11).Visible = False
        End If
        Cargando.Close()
    End Sub

    Private Function VerificaDatos() As Boolean
        Dim sintexto As Integer = 0
        For Each ctrl As Control In Me.Controls
            If TypeOf (ctrl) Is Bunifu.Framework.UI.BunifuMaterialTextbox Then
                Dim txtctrl As Bunifu.Framework.UI.BunifuMaterialTextbox = ctrl
                If Len(Trim(txtctrl.Text)) = 0 Then
                    MessageBox.Show("No puedes dejar campos vacíos")
                    txtctrl.Select()
                    sintexto = sintexto + 1
                    Exit For
                Else


                End If
            End If
        Next

        If sintexto = 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Sub VerificaDocumentos()
        Dim sinCarga As Integer = 0

        For Each ctrl As Control In FlowLayoutPanel1.Controls
            If TypeOf (ctrl) Is CheckBox Then
                Dim ctrlcheck As CheckBox = ctrl
                Select Case ctrlcheck.CheckState
                    Case CheckState.Unchecked
                        sinCarga += 1

                End Select
            End If
        Next
        If sinCarga > 0 Then
            DocumentosCapturados = False
        Else
            DocumentosCapturados = True
        End If
    End Sub

    Private Sub BackgroundCargaDocumentos_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundCargaDocumentos.DoWork
        iniciarconexionempresa()
        Dim consultaDocumentos As String
        consultaDocumentos = "Select DocumentosSolicitudboleta.Tipo,TiposdeDocumentosSolicitud.Nombre,DocumentosSolicitudboleta.Imagen from DocumentosSolicitudboleta inner join TiposdeDocumentosSolicitud on DocumentosSolicitudboleta.Tipo = TiposdeDocumentosSolicitud.id where idsolicitudboleta = '" & idSolicitud & "'"
        adapterDocumentos = New SqlDataAdapter(consultaDocumentos, conexionempresa)
        dataDocumentos = New DataTable
        adapterDocumentos.Fill(dataDocumentos)
    End Sub

    Private Sub BackgroundCargaDocumentos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundCargaDocumentos.RunWorkerCompleted
        dtdatosDocumentos.DataSource = dataDocumentos
        For Each column As DataGridViewColumn In dtdatosDocumentos.Columns
            If TypeOf dtdatosDocumentos.Columns(2) Is DataGridViewImageColumn Then 'resizes images
                CType(dtdatosDocumentos.Columns(2), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
            End If


        Next
        dtdatosDocumentos.Columns(2).Width = 200
        'dtdatosDocumentosNuevos.Rows.Clear()
        BackgroundVerificaDocumentos.RunWorkerAsync()

    End Sub

    Private Sub BackgroundVerificaDocumentos_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundVerificaDocumentos.DoWork
        CheckForIllegalCrossThreadCalls = False
        Me.Invoke(Sub()
                      Dim num_controles As Integer = FlowLayoutPanel1.Controls.Count - 1
                      For n As Integer = num_controles To 0 Step -1
                          Dim ctrl As Control = FlowLayoutPanel1.Controls(n)
                          FlowLayoutPanel1.Controls.Remove(ctrl)
                          ctrl.Dispose()
                      Next
                      Try
                          iniciarconexion()
                          Dim sql As String
                          Dim comando As SqlCommand

                          Dim milector As SqlDataReader
                          comando = New SqlCommand

                          comando.Connection = conexionempresa
                          sql = "select ajas.idTipo,ajas.Nombre,case when (select top 1 Tipo from DocumentosSolicitudboleta where Tipo = ajas.idTipo and DocumentosSolicitudboleta.idSolicitudBoleta = '" & idSolicitud & "') IS  null then 0 else 1 end as Cargado from
(select DocumentosNecesariosEmpeño.idTipo,TiposdeDocumentosSolicitud.Nombre from DocumentosNecesariosEmpeño inner join TiposdeDocumentosSolicitud on DocumentosNecesariosEmpeño.idTipo = TiposdeDocumentosSolicitud.id where idTipoEmpeño = '" & tipoSolicitud & "' and TiposdeDocumentosSolicitud.Tipo = 'A') ajas"
                          comando.CommandText = sql
                          milector = comando.ExecuteReader
                          While milector.Read
                              Dim checkTipo As New CheckBox

                              checkTipo.ForeColor = Color.FromKnownColor(KnownColor.Window)
                              checkTipo.Name = milector("idtipo")
                              checkTipo.Text = milector("nombre")
                              checkTipo.CheckState = milector("Cargado")
                              checkTipo.AutoSize = True

                              checkTipo.Enabled = False

                              'checkTipo.Tag = milector("ip")

                              FlowLayoutPanel1.Controls.Add(checkTipo)
                          End While
                          milector.Close()
                      Catch ex As Exception

                      End Try
                      '

                  End Sub
            )
    End Sub

    Private Sub BackgroundVerificaDocumentos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundVerificaDocumentos.RunWorkerCompleted
        VerificaDocumentos()
        If DocumentosCapturados Then

            btn_a_autorizacion.Visible = True

        Else
            MessageBox.Show("Faltan Documentos por cargar")
        End If
        Cargando.Close()
    End Sub





    Private Sub dtdatosDocumentos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtdatosDocumentos.CellDoubleClick
        VistaDocumento.PictureBox1.Image = dtdatosDocumentos.Rows(dtdatosDocumentos.CurrentRow.Index).Cells(2).FormattedValue
        VistaDocumento.ShowDialog()
    End Sub





    Private Sub txtCodigoPostal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoPostal.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        End If




    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub txtCodigoPostal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigoPostal.KeyDown
        If e.KeyCode = Keys.Enter Then
            'ComboColonia.Clear()
            '  ComboColonia.AddItem("")
            ComboColonia.Items.Clear()
            ComboColonia.Items.Add("")
            For Each row As DataRow In dataColonias.Rows
                If row("CP").ToString = txtCodigoPostal.Text Then
                    ComboColonia.Items.Add(row("Colonia").ToString)
                End If

            Next
        End If
    End Sub

    Private Sub ConsultaColoniasPersonal()
        ' If e.KeyCode = Keys.Enter Then
        'ComboColonia.Clear()
        ComboColonia.Items.Clear()
        ComboColonia.Items.Add("")
        'ComboColonia.AddItem("")
        For Each row As DataRow In dataColonias.Rows
            If row("CP").ToString = txtCodigoPostal.Text Then
                ComboColonia.Items.Add(row("Colonia").ToString)
            End If
            '
        Next
        'End If
    End Sub

    Private Sub dtdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtdatos.CellDoubleClick
        VistaDocumento.PictureBox1.Image = dtdatos.CurrentRow.Cells(9).FormattedValue
        VistaDocumento.Show()
    End Sub

    Private Sub btn_rechazar_Click(sender As Object, e As EventArgs) Handles btn_rechazar.Click
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Rechazando Crédito..."
        BackgroundRechazarSolicitud.RunWorkerAsync()
    End Sub

    Private Sub BackgroundRechazarSolicitud_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundRechazarSolicitud.DoWork
        iniciarconexionempresa()
        Dim tiempo As String = TimeOfDay.ToString("HH:mm:ss")
        Dim comandoActEstado As SqlCommand
        Dim consultaActEstado As String
        consultaActEstado = "update SolicitudBoleta set estado = 'R',autorizadoPor='" & nmusr & "',montoAutorizado = '0' where id = '" & idSolicitud & "'"
        comandoActEstado = New SqlCommand
        comandoActEstado.Connection = conexionempresa
        comandoActEstado.CommandText = consultaActEstado
        comandoActEstado.ExecuteNonQuery()




        Dim insertCronogramaSolicitud As SqlCommand
        Dim consultaInsertCronogramaSolicitud As String
        consultaInsertCronogramaSolicitud = "insert into CronogramaSolicitudEmpeño values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & idSolicitud & "','Se rechazó por " & nmusr & "')"
        insertCronogramaSolicitud = New SqlCommand
        insertCronogramaSolicitud.Connection = conexionempresa
        insertCronogramaSolicitud.CommandText = consultaInsertCronogramaSolicitud
        insertCronogramaSolicitud.ExecuteNonQuery()
    End Sub

    Private Sub dtdatos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtdatos.CellEndEdit
        montoTotalAutorizado = 0
        For Each row As DataGridViewRow In dtdatos.Rows
            Dim c As Boolean
            c = Convert.ToBoolean(row.Cells(11).GetEditedFormattedValue(row.Index, 11))
            If c Then
                montoTotalAutorizado = montoTotalAutorizado + Val(row.Cells(8).Value)
            End If
        Next
    End Sub

    Private Sub BackgroundRechazarSolicitud_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundRechazarSolicitud.RunWorkerCompleted
        Me.Invoke(Sub()
                      SolicitudesEmpeños.cargarSolicitudes()

                  End Sub)

        Cargando.Close()
        Me.Close()
    End Sub
End Class