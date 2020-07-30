Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO

Public Class DatosSolicitudBoleta
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

    Private Sub DatosSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando Datos"
        Cargando.TopMost = True
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        iniciarconexionempresa()

        Dim consultaDatosSolicitud As String
        Dim ComandoDatosSolicitud As SqlCommand
        Dim readerDatosSolicitud As SqlDataReader
        consultaDatosSolicitud = "select SolicitudBoleta.id,SolicitudBoleta.Nombre,SolicitudBoleta.Telefono, SolicitudBoleta.Domicilio,SolicitudBoleta.CodigoPostal,SolicitudBoleta.Colonia,SolicitudBoleta.Municipio,SolicitudBoleta.Entidad,SolicitudBoleta.CURP,SolicitudBoleta.MontoValuado,SolicitudBoleta.MontoSugerido,SolicitudBoleta.Fecha,SolicitudBoleta.Estado,SolicitudBoleta.idTipoEmpeño,SolicitudBoleta.Ine,Clientes.Nombre as nombres,Clientes.ApellidoPaterno,Clientes.ApellidoMaterno from SolicitudBoleta inner join Clientes on SolicitudBoleta.idCliente=Clientes.id where SolicitudBoleta.id='" & idSolicitud & "'"
        ComandoDatosSolicitud = New SqlCommand
        ComandoDatosSolicitud.Connection = conexionempresa
        ComandoDatosSolicitud.CommandText = consultaDatosSolicitud
        readerDatosSolicitud = ComandoDatosSolicitud.ExecuteReader
        If readerDatosSolicitud.HasRows Then
            While readerDatosSolicitud.Read
                txtnombre.Text = readerDatosSolicitud("nombres")
                txtApellidoP.Text = readerDatosSolicitud("ApellidoPaterno")
                txtApellidoM.Text = readerDatosSolicitud("ApellidoMaterno")
                txtCelular.Text = readerDatosSolicitud("Telefono")
                txtDomicilio.Text = readerDatosSolicitud("Domicilio")
                txtCodigoPostal.Text = readerDatosSolicitud("CodigoPostal")
                ConsultaColoniasPersonal()
                txtIne.Text = readerDatosSolicitud("Ine")
                ComboColonia.Text = readerDatosSolicitud("colonia")
                txtCiudad.Text = readerDatosSolicitud("Municipio")
                txtEstado.Text = readerDatosSolicitud("Entidad")
                txtCurp.Text = readerDatosSolicitud("curp")
                tipoSolicitud = readerDatosSolicitud("idtipoempeño")
            End While
        End If
        readerDatosSolicitud.Close()



        Dim consultaArticulos As String
        consultaArticulos = "select ArticulosEmpeños.id, ArticulosEmpeños.Descripcion, ArticulosEmpeños.idSolicitud,ArticulosEmpeños.Imagen,ArticulosEmpeños.Marca,ArticulosEmpeños.Modelo,ArticulosEmpeños.MontoValuado,ArticulosEmpeños.MontoSugerido,ArticulosEmpeños.NoSerie, TipoArticulosEmpeño.Nombre from ArticulosEmpeños inner join tipoarticulosempeño on tipoarticulosempeño.id=ArticulosEmpeños.Tipo where ArticulosEmpeños.idSolicitud = '" & idSolicitud & "'"
        adapterArticulos = New SqlDataAdapter(consultaArticulos, conexionempresa)
        dataArticulos = New DataTable
        adapterArticulos.Fill(dataArticulos)
        dtdatos.DataSource = dataArticulos


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
        dtdatos.Columns(1).DefaultCellStyle.WrapMode = DataGridViewTriState.True

        'Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando Documentos..."
        ' Cargando.TopMost = True
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
                MessageBox.Show("La captura no fue autorizada")
            End If
        Next

    End Sub

    Private Sub BackgroundAct_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundAct.DoWork
        iniciarconexionempresa()
        Dim comandoActDatos As SqlCommand
        Dim consultaActDatos As String
        consultaActDatos = "update solicitudboleta SET
       [Telefono]='" & txtCelular.Text & "'
      ,[Domicilio]='" & txtDomicilio.Text & "'
      ,[CodigoPostal]='" & txtCodigoPostal.Text & "'
      ,[Colonia]='" & ComboColonia.Text & "'
      ,[Municipio]='" & txtCiudad.Text & "'
      ,[Entidad]='" & txtEstado.Text & "'
      ,[Ine]='" & txtIne.Text & "'
      ,[CURP]='" & txtCurp.Text & "'
           where id = '" & idSolicitud & "'
      "
        comandoActDatos = New SqlCommand
        comandoActDatos.Connection = conexionempresa
        comandoActDatos.CommandText = consultaActDatos
        comandoActDatos.ExecuteNonQuery()

    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        AgregarDocumentoDatosSolicitudBoleta.Show()
    End Sub

    Private Sub BackgroundDocumentosSolicitud_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundDocumentosSolicitud.DoWork
        iniciarconexionempresa()

        For Each row As DataGridViewRow In dtdatosDocumentosNuevos.Rows
            Dim comandoDocumento As SqlCommand
            Dim consultaDocumento As String
            Dim imagen As Bitmap = TryCast(row.Cells(2).Value, Bitmap)

            consultaDocumento = "insert into DocumentosSolicitudBoleta values('" & idSolicitud & "','" & row.Cells(0).Value & "',@Documento)"
            Dim imgDocumento As New SqlParameter("@Documento", SqlDbType.Image)
            Dim msImgDocumento As New MemoryStream
            imagen.Save(msImgDocumento, ImageFormat.Jpeg)
            imgDocumento.Value = msImgDocumento.GetBuffer
            comandoDocumento = New SqlCommand
            comandoDocumento.Connection = conexionempresa
            comandoDocumento.CommandText = consultaDocumento
            comandoDocumento.Parameters.Add(imgDocumento)
            comandoDocumento.ExecuteNonQuery()

        Next

    End Sub

    Private Sub BackgroundAct_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundAct.RunWorkerCompleted
        Cargando.MonoFlat_Label1.Text = "Insertando Documentos"
        BackgroundDocumentosSolicitud.RunWorkerAsync()
    End Sub

    Private Sub BackgroundDocumentosSolicitud_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundDocumentosSolicitud.RunWorkerCompleted

        ' Cargando.Close()

        'If VerificaDatos() = True Then
        BackgroundCargaDocumentos.RunWorkerAsync()

        'BackgroundWorker2.RunWorkerAsync()
        'Else
        'Cargando.Close()
        'End If
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
        consultaActEstado = "update Solicitudboleta set estado = 'E' where id = '" & idSolicitud & "'"
        comandoActEstado = New SqlCommand
        comandoActEstado.Connection = conexionempresa
        comandoActEstado.CommandText = consultaActEstado
        comandoActEstado.ExecuteNonQuery()

        Dim insertCronogramaSolicitud As SqlCommand
        Dim consultaInsertCronogramaSolicitud As String
        consultaInsertCronogramaSolicitud = "insert into CronogramaSolicitudEmpeño values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & idSolicitud & "','Se envió a autorización por " & nmusr & "')"
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
                CType(dtdatosDocumentos.Columns(2), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
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
        dtdatos.Columns.Item(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

        dtdatos.Columns.Item(3).FillWeight = 150
        dtdatos.Columns.Item(3).Width = 200
        Dim imagecolumn As DataGridViewImageColumn
        imagecolumn = dtdatos.Columns.Item(3)
        imagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch
        For Each row As DataGridViewRow In dtdatos.Rows
            row.Height = 200

        Next
        Cargando.Close()
    End Sub

    Private Function VerificaDatos() As Boolean
        Dim sintexto As Integer = 0
        Dim listacontroles As New List(Of Control)
        listacontroles.Add(txtnombre)
        listacontroles.Add(txtApellidoP)
        listacontroles.Add(txtApellidoM)
        listacontroles.Add(txtIne)
        listacontroles.Add(txtCurp)
        listacontroles.Add(txtCodigoPostal)
        listacontroles.Add(ComboColonia)
        listacontroles.Add(txtDomicilio)
        listacontroles.Add(txtCiudad)
        listacontroles.Add(txtEstado)
        listacontroles.Add(txtCelular)
        For Each ctrl As Control In listacontroles
            If Len(Trim(ctrl.Text)) = 0 Then
                Select Case ctrl.Name
                    Case "txtnombre"
                        MessageBox.Show("El campo Nombre está vacío")
                        sintexto += 1
                        Exit For
                    Case "txtApellidoP"
                        MessageBox.Show("El campo Apellido Paterno está vacío")
                        sintexto += 1
                        Exit For
                    Case "txtApellidoM"
                        MessageBox.Show("El campo Apellido Materno está vacío")
                        sintexto += 1
                        Exit For
                    Case "txtIne"
                        MessageBox.Show("El campo No. de Identificación está vacío")
                        sintexto += 1
                        Exit For
                    Case "txtCurp"
                        MessageBox.Show("El campo CURP está vacío")
                        sintexto += 1
                        Exit For
                    Case "txtCodigoPostal"
                        MessageBox.Show("El campo Código Postal está vacío")
                        sintexto += 1
                        Exit For
                    Case "txtDomicilio"
                        MessageBox.Show("El campo Domicilio está vacío")
                        sintexto += 1
                        Exit For
                    Case "txtCiudad"
                        MessageBox.Show("El campo Ciudad está vacío")
                        sintexto += 1
                        Exit For
                    Case "txtEstado"
                        MessageBox.Show("El campo Estado está vacío")
                        sintexto += 1
                        Exit For
                    Case "txtCelular"
                        MessageBox.Show("El campo Celular está vacío")
                        sintexto += 1
                        Exit For
                    Case "ComboColonia"
                        MessageBox.Show("El campo Colonia está vacío")
                        sintexto += 1
                        Exit For
                End Select
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
        dtdatosDocumentosNuevos.Rows.Clear()
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
            'VerificaDatos()
            If VerificaDatos() Then
                btn_a_autorizacion.Visible = True

            End If

        Else
                MessageBox.Show("Faltan Documentos por cargar")
        End If
        Cargando.Close()
        'MessageBox.Show("El largo es: " & Len(Trim(txtIne.Text)))
    End Sub





    Private Sub dtdatosDocumentos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtdatosDocumentos.CellContentDoubleClick
        VistaDocumento.PictureBox1.Image = dtdatosDocumentos.Rows(dtdatosDocumentos.CurrentRow.Index).Cells(2).FormattedValue
        VistaDocumento.ShowDialog()
    End Sub



    Private Sub dtdatosDocumentosNuevos_KeyDown(sender As Object, e As KeyEventArgs) Handles dtdatosDocumentosNuevos.KeyDown
        If e.KeyCode = Keys.Delete Then
            dtdatosDocumentosNuevos.Rows.RemoveAt(dtdatosDocumentosNuevos.CurrentRow.Index)
        End If
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

    Private Sub txtIne_OnValueChanged(sender As Object, e As EventArgs) Handles txtIne.OnValueChanged
        If txtIne.Text.Length > 13 Then
            MessageBox.Show("El No. de Identificación no puede ser de más de 13 caracteres")
            Dim strIne As String = txtIne.Text
            ' strIne.Remove(12, 1)

            txtIne.Text = strIne.Remove(13, 1)
        End If
    End Sub

    Private Sub txtCurp_OnValueChanged(sender As Object, e As EventArgs) Handles txtCurp.OnValueChanged
        If txtCurp.Text.Length > 18 Then
            MessageBox.Show("La CURP no puede contener más de 18 caracteres")
            Dim strCurp As String = txtCurp.Text
            txtCurp.Text = strCurp.Remove(18, 1)
        End If
    End Sub

    Private Sub txtCelular_OnValueChanged(sender As Object, e As EventArgs) Handles txtCelular.OnValueChanged
        If txtCelular.Text.Length > 20 Then
            MessageBox.Show("El número de celular no puede contener más de 20 caracteres")
            Dim strCelular As String = txtCelular.Text
            txtCelular.Text = strCelular.Remove(20, 1)
        End If
    End Sub

    Private Sub txtCodigoPostal_OnValueChanged(sender As Object, e As EventArgs) Handles txtCodigoPostal.OnValueChanged
        If txtCodigoPostal.Text.Length > 5 Then
            MessageBox.Show("El Código Postal no puede contener más de 5 caracteres")
            Dim strCodigoPostal As String = txtCodigoPostal.Text
            txtCodigoPostal.Text = strCodigoPostal.Remove(5, 1)
        End If
    End Sub
End Class