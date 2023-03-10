Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO

Public Class DatosVerificacion
    Public idSolicitud As Integer
    Public idDatosSolicitud As Integer
    Dim edad As Integer
    Dim dataCliente As DataTable
    Dim adapterCliente As SqlDataAdapter
    Dim pendientes As Integer = 0
    Dim dataDatos As DataTable
    Dim adapterDatos As SqlDataAdapter
    Dim estadoDatosSolicitud As String
    Dim dataDocumentos As DataTable
    Dim adapterDocumentos As SqlDataAdapter
    Public tipoSolicitud As Integer
    Public DocumentosCapturados As Boolean
    Dim DatosCapturados As Boolean
    Public autorizado As Boolean
    Private Sub DatosSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Height = 1600
        'Me.Width = 1600
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando Datos"
        BackgroundWorker1.RunWorkerAsync()
    End Sub
    Public Function calcularEdad(ByVal nacimiento As Date) As Integer
        Dim edad As Integer
        edad = Today.Year - nacimiento.Year
        If (nacimiento > Today.AddYears(-edad)) Then edad -= 1
        Return edad
    End Function

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        iniciarconexionempresa()
        Dim comandoDatosSolicitud As SqlCommand
        Dim consultaDatosSolicitud As String
        Dim readerDatosSolicitud As SqlDataReader
        consultaDatosSolicitud = "select datosSolicitud.id,datosSolicitud.idCliente,(clientes.nombre +' '+clientes.ApellidoPaterno+' '+clientes.ApellidoMaterno) as nombrecompleto,clientes.nombre,clientes.ApellidoPaterno,clientes.ApellidoMaterno,clientes.FechaNacimiento,clientes.Telefono,clientes.Celular,datosSolicitud.estado from datosSolicitud inner join clientes on datosSolicitud.idCliente = clientes.id where datosSolicitud.idSolicitud = '" & idSolicitud & "'"
        comandoDatosSolicitud = New SqlCommand
        comandoDatosSolicitud.Connection = conexionempresa
        comandoDatosSolicitud.CommandText = consultaDatosSolicitud
        readerDatosSolicitud = comandoDatosSolicitud.ExecuteReader
        While readerDatosSolicitud.Read
            Select Case readerDatosSolicitud("estado")
                Case "E"
                    dtdatos.Rows.Add(readerDatosSolicitud("id"), readerDatosSolicitud("idCliente"), readerDatosSolicitud("nombrecompleto"), "No")
                Case "V"
                    dtdatos.Rows.Add(readerDatosSolicitud("id"), readerDatosSolicitud("idCliente"), readerDatosSolicitud("nombrecompleto"), "Sí")
                Case "R"
                    dtdatos.Rows.Add(readerDatosSolicitud("id"), readerDatosSolicitud("idCliente"), readerDatosSolicitud("nombrecompleto"), "Sí")
            End Select

        End While
        readerDatosSolicitud.Close()
        adapterCliente = New SqlDataAdapter(consultaDatosSolicitud, conexionempresa)
        dataCliente = New DataTable
        adapterCliente.Fill(dataCliente)

    End Sub

    Private Sub ConsultarCliente(idCliente As String)


        For Each row As DataRow In dataDatos.Rows
            If row("idCliente").ToString = idCliente Then
                txtnombre.Text = row("Nombre").ToString

                txtApellidoP.Text = row("ApellidoPaterno").ToString
                txtApellidoM.Text = row("ApellidoMaterno").ToString
                txtEdad.Text = row("Edad").ToString
                txtTelefono.Text = row("Telefono").ToString
                txtCelular.Text = row("Celular").ToString
                TxtCasaDondeVive.Text = row("CasaDondeViveEs").ToString
                txtTiempoDomicilio.Text = row("TiempoEnDomicilio").ToString
                txtCalle.Text = row("Calle").ToString
                txtNoExterior.Text = row("Noext").ToString
                txtNoInterior.Text = row("Noint").ToString
                txtCodigoPostal.Text = row("CodigoPostal").ToString
                txtEntreCalles.Text = row("EntreCalles").ToString
                txtColonia.Text = row("Colonia").ToString
                txtCiudad.Text = row("Ciudad").ToString
                txtEstado.Text = row("EstadoCliente").ToString
                txtdatosConyuge.Text = row("Conyuge").ToString
                txtRelacionConyuge.Text = row("RelacionConyuge").ToString
                txtNombreLugarTrabajo.Text = row("DondeTrabaja").ToString
                txtSeDedica.Text = row("SeDedica").ToString
                txtVende.Text = row("QueVende").ToString
                txtAntiguedad.Text = row("Antiguedad").ToString
                txtHorariosTrabajo.Text = row("Horarios").ToString
                txtTipoEstablecimiento.Text = row("TipoEstablecimiento").ToString
                txtIngresoPromedio.Text = row("IngresoPmensual").ToString
                txtFrecuenciaCobro.Text = row("FrecuenciaCobro").ToString
                txtCalleTrabajo.Text = row("CalleTrabajo").ToString
                txtNoExteriorTrabajo.Text = row("NoextTrabajo").ToString
                txtNoInteriorTrabajo.Text = row("NointTrabajo").ToString
                txtCodigoPostalTrabajo.Text = row("CodigoPostalTrabajo").ToString
                txtJefeDirecto.Text = row("JefeDirecto").ToString
                txtColoniaTrabajo.Text = row("ColoniaTrabajo").ToString
                txtTelefonoTrabajo.Text = row("TelefonoTrabajo").ToString
                txtObjetivo.Text = row("Objetivo").ToString
                txtNombreR1.Text = row("NombreR1").ToString
                txtTelefonoR1.Text = row("TelefonoR1").ToString
                txtRelacionR1.Text = row("RelacionR1").ToString
                txtNombreR2.Text = row("NombreR2").ToString
                txtTelefonoR2.Text = row("TelefonoR2").ToString
                txtRelacionR2.Text = row("RelacionR2").ToString
                txtEnfermedad.Text = row("Enfermedad").ToString
                txtFamiliasEnCasa.Text = row("FamiliasEnCasa").ToString
                txtDeudas.Text = row("DeudasCon").ToString
                txtServicios.Text = row("Servicios").ToString
                txtPersonasDependientes.Text = row("PersonasDependientes").ToString
                txtEmpleados.Text = row("Empleados").ToString
                txtFrecuenciaInversion.Text = row("FrecuenciaInversion").ToString
                txtObservacionesDomicilio.Text = row("ObservacionesDomicilio").ToString
                txtHorarioVerificacion.Text = row("HorarioVerificacion").ToString
                txtMontoSolicitado.Text = row("Monto").ToString
                txtMontoVerificacion.Text = row("Monto").ToString
                Exit For
            End If
        Next

        BackgroundDocumentos.RunWorkerAsync()


    End Sub

    Private Sub dtdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtdatos.CellContentClick

    End Sub

    Private Sub dtdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtdatos.CellDoubleClick
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando Información"
        Cargando.TopMost = True
        idDatosSolicitud = dtdatos.CurrentRow.Cells(0).Value
        ConsultarCliente(dtdatos.CurrentRow.Cells(1).Value)

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        BackgroundDatosSolicitud.RunWorkerAsync()
    End Sub

    Private Sub btn_Procesar_Click(sender As Object, e As EventArgs) Handles btn_Procesar.Click
        For Each row As DataRow In dataPermisos.Rows
            If row("SatiModSolicitudesModificar") Then
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


        Dim comandoActDatos As SqlCommand
        Dim consultaActDatos As String
        consultaActDatos = "update DatosSolicitud set ComentariosVerificacion = '" & txtComentarios.Text & "', MontoVerificacion = '" & txtMontoVerificacion.Text & "' where id = '" & idDatosSolicitud & "'"
        comandoActDatos = New SqlCommand
        '  Dim croquis As New SqlParameter("@Croquis", SqlDbType.Image)
        ' Dim mscroquis As New MemoryStream
        'img_croquis.Image.Save(mscroquis, ImageFormat.Jpeg)
        'croquis.Value = mscroquis.GetBuffer
        comandoActDatos.Connection = conexionempresa
        comandoActDatos.CommandText = consultaActDatos
        'comandoActDatos.Parameters.Add(croquis)
        comandoActDatos.ExecuteNonQuery()


        ' ActDatosTabla()

    End Sub
    Private Sub ActDatosTabla()
        pendientes = 0
        dtdatos.Rows.Clear()
        iniciarconexionempresa()
        Dim comandoDatosSolicitud As SqlCommand
        Dim consultaDatosSolicitud As String
        Dim readerDatosSolicitud As SqlDataReader
        consultaDatosSolicitud = "select datosSolicitud.id,datosSolicitud.idCliente,(clientes.nombre +' '+clientes.ApellidoPaterno+' '+clientes.ApellidoMaterno) as nombrecompleto,clientes.nombre,clientes.ApellidoPaterno,clientes.ApellidoMaterno,clientes.FechaNacimiento,clientes.Telefono,clientes.Celular,datosSolicitud.estado from datosSolicitud inner join clientes on datosSolicitud.idCliente = clientes.id where datosSolicitud.idSolicitud = '" & idSolicitud & "'"
        comandoDatosSolicitud = New SqlCommand
        comandoDatosSolicitud.Connection = conexionempresa
        comandoDatosSolicitud.CommandText = consultaDatosSolicitud
        readerDatosSolicitud = comandoDatosSolicitud.ExecuteReader
        While readerDatosSolicitud.Read
            Select Case readerDatosSolicitud("estado")
                Case "E"
                    dtdatos.Rows.Add(readerDatosSolicitud("id"), readerDatosSolicitud("idCliente"), readerDatosSolicitud("nombrecompleto"), "No")
                    pendientes += 1
                Case "V"
                    dtdatos.Rows.Add(readerDatosSolicitud("id"), readerDatosSolicitud("idCliente"), readerDatosSolicitud("nombrecompleto"), "Sí")
                Case "R"
                    dtdatos.Rows.Add(readerDatosSolicitud("id"), readerDatosSolicitud("idCliente"), readerDatosSolicitud("nombrecompleto"), "Sí")
            End Select

        End While
        readerDatosSolicitud.Close()
        adapterCliente = New SqlDataAdapter(consultaDatosSolicitud, conexionempresa)
        dataCliente = New DataTable
        adapterCliente.Fill(dataCliente)
        If pendientes = 0 Then
            btn_a_verificacion.Visible = True
        End If
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        AgregarDocumentoVerificacion.Show()
    End Sub

    Private Sub BackgroundDocumentosSolicitud_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundDocumentosSolicitud.DoWork
        iniciarconexionempresa()

        For Each row As DataGridViewRow In dtdatosDocumentosNuevos.Rows
            Dim comandoDocumento As SqlCommand
            Dim consultaDocumento As String
            Dim imagen As Bitmap = TryCast(row.Cells(2).Value, Bitmap)

            consultaDocumento = "insert into DocumentosSolicitud values('" & idDatosSolicitud & "','" & row.Cells(0).Value & "',@Documento)"
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
        VerificaDatos()
        If DatosCapturados = True Then
            BackgroundCargaDocumentos.RunWorkerAsync()

            'BackgroundWorker2.RunWorkerAsync()
        Else
            MessageBox.Show("Faltan datos por capturar")
        End If
    End Sub

    Private Sub btn_a_verificacion_Click(sender As Object, e As EventArgs) Handles btn_a_verificacion.Click
        Autorizacion.tipoAutorizacion = "SatiModSolicitudesVerificar"
        Autorizacion.ShowDialog()
        If autorizado Then
            Cargando.Show()
            Cargando.MonoFlat_Label1.Text = "Enviando a autorización"
            BackgroundVerificacion.RunWorkerAsync()
        Else
            MessageBox.Show("No fue autorizado")
        End If



    End Sub

    Private Sub BackgroundVerificacion_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundVerificacion.DoWork
        iniciarconexionempresa()
        Dim tiempo As String = TimeOfDay.ToString("HH:mm:ss")
        Dim comandoActEstado As SqlCommand
        Dim consultaActEstado As String
        consultaActEstado = "update Solicitud set estado = 'V' where id = '" & idSolicitud & "'"
        comandoActEstado = New SqlCommand
        comandoActEstado.Connection = conexionempresa
        comandoActEstado.CommandText = consultaActEstado
        comandoActEstado.ExecuteNonQuery()



        Dim insertCronogramaSolicitud As SqlCommand
        Dim consultaInsertCronogramaSolicitud As String
        consultaInsertCronogramaSolicitud = "insert into CronogramaSolicitud values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & idSolicitud & "','Se envió a autorización por " & nmusr & "')"
        insertCronogramaSolicitud = New SqlCommand
        insertCronogramaSolicitud.Connection = conexionempresa
        insertCronogramaSolicitud.CommandText = consultaInsertCronogramaSolicitud
        insertCronogramaSolicitud.ExecuteNonQuery()

    End Sub

    Private Sub BackgroundVerificacion_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundVerificacion.RunWorkerCompleted
        Cargando.Close()
        Me.Invoke(Sub()
                      Solicitudes.cargarSolicitudes()

                  End Sub)
        Me.Close()

    End Sub

    Private Sub BackgroundDatosSolicitud_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundDatosSolicitud.DoWork
        iniciarconexionempresa()

        Dim consultaDatosSolicitud As String
        consultaDatosSolicitud = "select datosSolicitud.*, (clientes.nombre +' '+clientes.ApellidoPaterno+' '+clientes.ApellidoMaterno) as nombrecompleto,clientes.nombre,clientes.ApellidoPaterno,clientes.ApellidoMaterno,clientes.FechaNacimiento,clientes.Telefono,clientes.Celular from datosSolicitud inner join clientes on datosSolicitud.idCliente = clientes.id where datosSolicitud.idSolicitud = '" & idSolicitud & "'"
        adapterDatos = New SqlDataAdapter(consultaDatosSolicitud, conexionempresa)
        dataDatos = New DataTable
        adapterDatos.Fill(dataDatos)
    End Sub

    Private Sub BackgroundDatosSolicitud_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundDatosSolicitud.RunWorkerCompleted
        Cargando.Close()
    End Sub

    Private Sub RadioVerificado_CheckedChanged(sender As Object, e As EventArgs) Handles RadioVerificado.CheckedChanged
        If RadioVerificado.Checked Then
            estadoDatosSolicitud = "V"
        End If
    End Sub

    Private Sub RadioRechazado_CheckedChanged(sender As Object, e As EventArgs) Handles RadioRechazado.CheckedChanged
        If RadioRechazado.Checked Then
            estadoDatosSolicitud = "R"
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub BackgroundDocumentos_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundDocumentos.DoWork
        iniciarconexionempresa()
        Dim consultaDocumentos As String
        consultaDocumentos = "Select DocumentosSolicitud.Tipo,TiposdeDocumentosSolicitud.Nombre,DocumentosSolicitud.Imagen from DocumentosSolicitud inner join TiposdeDocumentosSolicitud on DocumentosSolicitud.Tipo = TiposdeDocumentosSolicitud.id where idDatosSolicitud = '" & idDatosSolicitud & "'"
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
                          sql = "select ajas.idTipo,ajas.Nombre,case when (select top 1 Tipo from DocumentosSolicitud where Tipo = ajas.idTipo and DocumentosSolicitud.IdDatosSolicitud = '" & idDatosSolicitud & "') IS  null then 0 else 1 end as Cargado from
(select DocumentosNecesariosTipo.idTipo,TiposdeDocumentosSolicitud.Nombre from DocumentosNecesariosTipo inner join TiposdeDocumentosSolicitud on DocumentosNecesariosTipo.idTipo = TiposdeDocumentosSolicitud.id where idTipoCredito = '" & tipoSolicitud & "' and TiposdeDocumentosSolicitud.Tipo = 'V') ajas"
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
       
        Cargando.TopMost = False
        Cargando.Close()
    End Sub

    Private Sub BackgroundCargaDocumentos_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundCargaDocumentos.DoWork
        iniciarconexionempresa()
        Dim consultaDocumentos As String
        consultaDocumentos = "Select DocumentosSolicitud.Tipo,TiposdeDocumentosSolicitud.Nombre,DocumentosSolicitud.Imagen from DocumentosSolicitud inner join TiposdeDocumentosSolicitud on DocumentosSolicitud.Tipo = TiposdeDocumentosSolicitud.id where idDatosSolicitud = '" & idDatosSolicitud & "'"
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
                          sql = "select ajas.idTipo,ajas.Nombre,case when (select top 1 Tipo from DocumentosSolicitud where Tipo = ajas.idTipo and DocumentosSolicitud.IdDatosSolicitud = '" & idDatosSolicitud & "') IS  null then 0 else 1 end as Cargado from
(select DocumentosNecesariosTipo.idTipo,TiposdeDocumentosSolicitud.Nombre from DocumentosNecesariosTipo inner join TiposdeDocumentosSolicitud on DocumentosNecesariosTipo.idTipo = TiposdeDocumentosSolicitud.id where idTipoCredito = '" & tipoSolicitud & "' and TiposdeDocumentosSolicitud.Tipo = 'V') ajas"
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
            iniciarconexionempresa()
            Dim comandoCapturaSolicitud As SqlCommand
            Dim consultaCapturaSolicitud As String
            consultaCapturaSolicitud = "Update datosSolicitud set Estado = '" & estadoDatosSolicitud & "' where id = '" & idDatosSolicitud & "'"
            comandoCapturaSolicitud = New SqlCommand
            comandoCapturaSolicitud.Connection = conexionempresa
            comandoCapturaSolicitud.CommandText = consultaCapturaSolicitud
            comandoCapturaSolicitud.ExecuteNonQuery()
            ActDatosTabla()

        Else
            MessageBox.Show("Faltan Documentos por cargar")
        End If
        Cargando.Close()
    End Sub

    Private Sub VerificaDatos()
        Dim sintexto As Integer = 0
        For Each ctrl As Control In Me.Controls
            If TypeOf (ctrl) Is Bunifu.Framework.UI.BunifuMaterialTextbox Then
                Dim txtctrl As Bunifu.Framework.UI.BunifuMaterialTextbox = ctrl
                If txtctrl.Text = "" Then
                    sintexto += 1

                End If
            End If
        Next

        If sintexto > 0 Then
            DatosCapturados = False
        Else
            DatosCapturados = True

        End If
    End Sub


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

    Private Sub dtdatosDocumentosNuevos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtdatosDocumentosNuevos.CellContentClick

    End Sub

    Private Sub dtdatosDocumentos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtdatosDocumentos.CellContentDoubleClick
        VistaDocumento.PictureBox1.Image = dtdatosDocumentos.Rows(dtdatosDocumentos.CurrentRow.Index).Cells(2).FormattedValue
        VistaDocumento.ShowDialog()
    End Sub

    Private Sub dtdatosDocumentos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtdatosDocumentos.CellContentClick

    End Sub

    Private Sub dtdatosDocumentosNuevos_KeyDown(sender As Object, e As KeyEventArgs) Handles dtdatosDocumentosNuevos.KeyDown
        If e.KeyCode = Keys.Delete Then
            dtdatosDocumentosNuevos.Rows.RemoveAt(dtdatosDocumentosNuevos.CurrentRow.Index)
        End If
    End Sub
End Class