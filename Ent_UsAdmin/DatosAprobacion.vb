Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO

Public Class DatosAprobacion
    Public idSolicitud As Integer
    Public idDatosSolicitud As Integer
    Dim edad As Integer
    Dim dataCliente As DataTable
    Dim adapterCliente As SqlDataAdapter
    Dim pendientes As Integer = 0
    Dim rechazados As Integer = 0
    Dim Aprobados As Integer = 0
    Dim dataDatos As DataTable
    Dim adapterDatos As SqlDataAdapter
    Dim estadoDatosSolicitud As String
    Dim dataDocumentos As DataTable
    Dim adapterDocumentos As SqlDataAdapter
    Dim montoAutorizadoTotal As Double
    Dim dataSolicitud As DataTable
    Dim adapterSolicitud As SqlDataAdapter
    Dim nombreSolicitud As String
    Dim montoSolicitud As Double
    Dim TipoSolicitud As Integer
    Dim PlazoSolicitud As Integer
    Dim InteresSolicitud As Double
    Dim idClienteSolicitud As Integer
    Dim idGestorSolicitud As Integer
    Dim idPromotorSolicitud As Integer
    Dim modalidadSolicitud As String
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
        consultaDatosSolicitud = "select datosSolicitud.id,datosSolicitud.idCliente,(clientes.nombre +' '+clientes.ApellidoPaterno+' '+clientes.ApellidoMaterno) as nombrecompleto,clientes.nombre,clientes.ApellidoPaterno,clientes.ApellidoMaterno,clientes.FechaNacimiento,clientes.Telefono,clientes.Celular,datosSolicitud.estado,datosSolicitud.MontoAutorizado from datosSolicitud inner join clientes on datosSolicitud.idCliente = clientes.id where datosSolicitud.idSolicitud = '" & idSolicitud & "'"
        comandoDatosSolicitud = New SqlCommand
        comandoDatosSolicitud.Connection = conexionempresa
        comandoDatosSolicitud.CommandText = consultaDatosSolicitud
        readerDatosSolicitud = comandoDatosSolicitud.ExecuteReader
        While readerDatosSolicitud.Read

            dtdatos.Rows.Add(readerDatosSolicitud("id"), readerDatosSolicitud("idCliente"), readerDatosSolicitud("nombrecompleto"), readerDatosSolicitud("estado"), readerDatosSolicitud("MontoAutorizado"))



        End While
        readerDatosSolicitud.Close()
        adapterCliente = New SqlDataAdapter(consultaDatosSolicitud, conexionempresa)
        dataCliente = New DataTable
        adapterCliente.Fill(dataCliente)

        Dim consultaSolicitud As String
        Dim comandoSolicitud As SqlCommand
        Dim readerSolicitud As SqlDataReader

        consultaSolicitud = "select solicitud.nombre,solicitud.Monto,solicitud.Tipo,solicitud.Plazo,solicitud.Interes,PagoIndividual,Integrantes,IdCliente,IdPromotor,IdGestor,TiposDeCredito.Modalidad From solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.id = '" & idSolicitud & "'"
        comandoSolicitud = New SqlCommand
        comandoSolicitud.Connection = conexionempresa
        comandoSolicitud.CommandText = consultaSolicitud
        readerSolicitud = comandoSolicitud.ExecuteReader
        While readerSolicitud.Read
            nombreSolicitud = readerSolicitud("nombre")
            TipoSolicitud = readerSolicitud("Tipo")
            PlazoSolicitud = readerSolicitud("Plazo")
            InteresSolicitud = readerSolicitud("Interes")
            idClienteSolicitud = readerSolicitud("IdCliente")
            idPromotorSolicitud = readerSolicitud("IdPromotor")
            idGestorSolicitud = readerSolicitud("IdGestor")
            modalidadSolicitud = readerSolicitud("Modalidad")
        End While

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
                txtCodigoPostalR1.Text = row("CodigoPostalR1").ToString
                txtColoniaR1.Text = row("ColoniaR1").ToString

                txtCalleR1.Text = row("CalleR1").ToString
                txtNoExtR1.Text = row("NoExtR1").ToString
                txtNoIntR1.Text = row("NoIntR1").ToString

                txtNombreR2.Text = row("NombreR2").ToString
                txtTelefonoR2.Text = row("TelefonoR2").ToString
                txtRelacionR2.Text = row("RelacionR2").ToString
                txtCodigoPostalR2.Text = row("CodigoPostalR2").ToString
                txtColoniaR2.Text = row("ColoniaR2").ToString
                txtCalleR2.Text = row("CalleR2").ToString
                txtNoExtR2.Text = row("NoExtR2").ToString
                txtNoIntR2.Text = row("NoIntR2").ToString
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
                txtMontoVerificacion.Text = row("MontoVerificacion")
                txtMontoAutorizado.Text = row("MontoVerificacion")
                txtComentariosVerificacion.Text = row("ComentariosVerificacion").ToString
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
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Registrando Captura"
        BackgroundAct.RunWorkerAsync()
    End Sub

    Private Sub BackgroundAct_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundAct.DoWork
        iniciarconexionempresa()


        Dim comandoActDatos As SqlCommand
        Dim consultaActDatos As String
        Select Case estadoDatosSolicitud
            Case "A"
                consultaActDatos = "update DatosSolicitud set Comentarios = '" & txtComentarios.Text & "',estado = '" & estadoDatosSolicitud & "', MontoAutorizado = '" & txtMontoAutorizado.Text & "' where id = '" & idDatosSolicitud & "'"
            Case "R"
                consultaActDatos = "update DatosSolicitud set Comentarios = '" & txtComentarios.Text & "',estado = '" & estadoDatosSolicitud & "', MontoAutorizado = 0 where id = '" & idDatosSolicitud & "'"

        End Select
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
        rechazados = 0
        Aprobados = 0
        montoAutorizadoTotal = 0
        dtdatos.Rows.Clear()
        iniciarconexionempresa()
        Dim comandoDatosSolicitud As SqlCommand
        Dim consultaDatosSolicitud As String
        Dim readerDatosSolicitud As SqlDataReader
        consultaDatosSolicitud = "select datosSolicitud.id,datosSolicitud.idCliente,(clientes.nombre +' '+clientes.ApellidoPaterno+' '+clientes.ApellidoMaterno) as nombrecompleto,clientes.nombre,clientes.ApellidoPaterno,clientes.ApellidoMaterno,clientes.FechaNacimiento,clientes.Telefono,clientes.Celular,datosSolicitud.estado,datosSolicitud.MontoAutorizado from datosSolicitud inner join clientes on datosSolicitud.idCliente = clientes.id where datosSolicitud.idSolicitud = '" & idSolicitud & "'"
        comandoDatosSolicitud = New SqlCommand
        comandoDatosSolicitud.Connection = conexionempresa
        comandoDatosSolicitud.CommandText = consultaDatosSolicitud
        readerDatosSolicitud = comandoDatosSolicitud.ExecuteReader
        While readerDatosSolicitud.Read
            Select Case readerDatosSolicitud("Estado")
                Case "V"
                    pendientes += 1
                Case "R"
                    rechazados += 1
                Case "A"
                    Aprobados += 1
            End Select
            dtdatos.Rows.Add(readerDatosSolicitud("id"), readerDatosSolicitud("idCliente"), readerDatosSolicitud("nombrecompleto"), readerDatosSolicitud("estado"), readerDatosSolicitud("MontoAutorizado"))
            montoAutorizadoTotal = montoAutorizadoTotal + readerDatosSolicitud("MontoAutorizado")
        End While
        readerDatosSolicitud.Close()
        adapterCliente = New SqlDataAdapter(consultaDatosSolicitud, conexionempresa)
        dataCliente = New DataTable
        adapterCliente.Fill(dataCliente)
        If pendientes = 0 And Aprobados >= 1 Then
            btn_a_verificacion.Visible = True
            btn_rechazar.Visible = True
        End If
        If pendientes = 0 And Aprobados = 0 Then
            btn_rechazar.Visible = True
            btn_a_verificacion.Visible = True
        End If
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs)
        AgregarDocumentoVerificacion.Show()
    End Sub

    Private Sub BackgroundDocumentosSolicitud_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundDocumentosSolicitud.DoWork
        iniciarconexionempresa()

        For Each row As DataGridViewRow In dtdatosDocumentos.Rows
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
        ActDatosTabla()
        Cargando.Close()

        'Cargando.MonoFlat_Label1.Text = "Insertando Documentos"
        'BackgroundDocumentosSolicitud.RunWorkerAsync()
    End Sub

    Private Sub BackgroundDocumentosSolicitud_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundDocumentosSolicitud.RunWorkerCompleted
        ActDatosTabla()

        Cargando.Close()

    End Sub

    Private Sub btn_a_verificacion_Click(sender As Object, e As EventArgs) Handles btn_a_verificacion.Click
        Autorizacion.tipoAutorizacion = "SatiModSolicitudesAprobar"
        Autorizacion.ShowDialog()
        If autorizado Then
            Cargando.Show()
            Cargando.MonoFlat_Label1.Text = "Autorizando Solicitud"
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
        consultaActEstado = "update Solicitud set estado = 'A',autorizadoPor='" & nmusr & "',montoAutorizado = '" & montoAutorizadoTotal & "' where id = '" & idSolicitud & "'"
        comandoActEstado = New SqlCommand
        comandoActEstado.Connection = conexionempresa
        comandoActEstado.CommandText = consultaActEstado
        comandoActEstado.ExecuteNonQuery()


        Dim comandoCredito As SqlCommand
        Dim consultaCredito As String
        Dim idCreditoCreado As Integer
        Dim pagoIndividualCredito As Double
        Select Case modalidadSolicitud
            Case "S"
                pagoIndividualCredito = (montoAutorizadoTotal / 1000) * InteresSolicitud
            Case "Q"
                pagoIndividualCredito = ((montoAutorizadoTotal / 1000) * InteresSolicitud) * 2
        End Select

        Dim PagareCredito As Double
        PagareCredito = pagoIndividualCredito * PlazoSolicitud
        consultaCredito = "insert into Credito(Fecha,Hora,Nombre,Monto,Pagare,Tipo,Integrantes,PagoIndividual,Plazo,Interes,IdCliente,IdPromotor,IdGestor,IdSolicitud,Estado) values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & nombreSolicitud & "','" & montoAutorizadoTotal & "','" & PagareCredito & "','" & TipoSolicitud & "','" & Aprobados & "','" & pagoIndividualCredito & "','" & PlazoSolicitud & "','" & InteresSolicitud & "','" & idClienteSolicitud & "','" & idPromotorSolicitud & "','" & idGestorSolicitud & "','" & idSolicitud & "','E') select SCOPE_IDENTITY()"
        comandoCredito = New SqlCommand
        comandoCredito.Connection = conexionempresa
        comandoCredito.CommandText = consultaCredito
        idCreditoCreado = comandoCredito.ExecuteScalar

        Dim insertCronogramaSolicitud As SqlCommand
        Dim consultaInsertCronogramaSolicitud As String
        consultaInsertCronogramaSolicitud = "insert into CronogramaSolicitud values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & idSolicitud & "','Se autorizó por " & nmusr & " y se creó el crédito con el id " & idCreditoCreado & "')"
        insertCronogramaSolicitud = New SqlCommand
        insertCronogramaSolicitud.Connection = conexionempresa
        insertCronogramaSolicitud.CommandText = consultaInsertCronogramaSolicitud
        insertCronogramaSolicitud.ExecuteNonQuery()

    End Sub

    Private Sub BackgroundVerificacion_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundVerificacion.RunWorkerCompleted
        Me.Invoke(Sub()
                      Solicitudes.cargarSolicitudes()

                  End Sub)

        Cargando.Close()
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
        ActDatosTabla()
    End Sub

    Private Sub RadioVerificado_CheckedChanged(sender As Object, e As EventArgs) Handles RadioAprobado.CheckedChanged
        If RadioAprobado.Checked Then
            estadoDatosSolicitud = "A"
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
    Public Function ByteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Dim ms As New MemoryStream(byteArrayIn)
        Return Image.FromStream(ms)
    End Function

    Private Sub BackgroundDocumentos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundDocumentos.RunWorkerCompleted
        dtdatosDocumentos.DataSource = dataDocumentos
        For Each column As DataGridViewColumn In dtdatosDocumentos.Columns
            If TypeOf dtdatosDocumentos.Columns(2) Is DataGridViewImageColumn Then 'resizes images
                CType(dtdatosDocumentos.Columns(2), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
            End If


        Next
        dtdatosDocumentos.Columns(2).Width = 200

        Cargando.TopMost = False
        Cargando.Close()
    End Sub

    Private Sub BackgroundRechazo_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundRechazo.DoWork
        iniciarconexionempresa()
        Dim tiempo As String = TimeOfDay.ToString("HH:mm:ss")
        Dim comandoActEstado As SqlCommand
        Dim consultaActEstado As String
        consultaActEstado = "update Solicitud set estado = 'R',autorizadoPor='" & nmusr & "',montoAutorizado = '0' where id = '" & idSolicitud & "'"
        comandoActEstado = New SqlCommand
        comandoActEstado.Connection = conexionempresa
        comandoActEstado.CommandText = consultaActEstado
        comandoActEstado.ExecuteNonQuery()




        Dim insertCronogramaSolicitud As SqlCommand
        Dim consultaInsertCronogramaSolicitud As String
        consultaInsertCronogramaSolicitud = "insert into CronogramaSolicitud values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & idSolicitud & "','Se rechazó por " & nmusr & "')"
        insertCronogramaSolicitud = New SqlCommand
        insertCronogramaSolicitud.Connection = conexionempresa
        insertCronogramaSolicitud.CommandText = consultaInsertCronogramaSolicitud
        insertCronogramaSolicitud.ExecuteNonQuery()
    End Sub

    Private Sub btn_rechazar_Click(sender As Object, e As EventArgs) Handles btn_rechazar.Click
        Autorizacion.tipoAutorizacion = "SatiModSolicitudesAprobar"
        Autorizacion.ShowDialog()
        If autorizado Then
            Cargando.Show()
            Cargando.MonoFlat_Label1.Text = "Rechazando Crédito"
            BackgroundRechazo.RunWorkerAsync()
        Else
            MessageBox.Show("No fue autorizado")
        End If


    End Sub

    Private Sub BackgroundRechazo_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundRechazo.RunWorkerCompleted
        Me.Invoke(Sub()
                      Solicitudes.cargarSolicitudes()

                  End Sub)

        Cargando.Close()
        Me.Close()

    End Sub

    Private Sub dtdatosDocumentos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtdatosDocumentos.CellContentClick

    End Sub

    Private Sub dtdatosDocumentos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtdatosDocumentos.CellContentDoubleClick
        VistaDocumento.PictureBox1.Image = dtdatosDocumentos.Rows(dtdatosDocumentos.CurrentRow.Index).Cells(2).FormattedValue
        VistaDocumento.ShowDialog()
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

End Class