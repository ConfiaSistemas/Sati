Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Threading.Tasks

Public Class Levantar_Solicitud
    Dim idtipo, tipo, nombreTipo, Modalidad, tipocredito As String
    Dim plazoTipo, interesTipo As Double
    Dim consultadoTipo As Boolean
    Dim nombreCliente, idCliente As String
    Dim consultadoCliente As Boolean
    Dim totalintegrantes As Integer = 0
    Dim dataGestores As DataSet
    Dim dataPromotores As DataSet
    Dim adapterGestores As SqlDataAdapter
    Dim adapterPromotores As SqlDataAdapter
    Dim dataLegal As DataSet
    Dim adapterLegal As SqlDataAdapter
    Dim totalMoratorios As Double
    Dim empezar As Boolean
    Dim MontoTotal As Double = 0
    Dim idSolicitud As Integer
    Dim esta As String
    Dim usarNombre As Boolean
    Public autorizado As Boolean
    Private Sub txtTipo_OnValueChanged(sender As Object, e As EventArgs) Handles txtTipo.OnValueChanged

    End Sub

    Private Sub Levantar_Solicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando Gestores"
        BackgroundGestores.RunWorkerAsync()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BuscarClienteSolicitud.Show()
    End Sub

    Private Sub txtIdCliente_OnValueChanged(sender As Object, e As EventArgs) Handles txtIdCliente.OnValueChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Async Sub btn_agregar_ClickAsync(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Select Case tipocredito
            Case "G"
                dtdatos.Rows.Add(idCliente, nombreCliente, txtMontopPersona.Text)
                totalintegrantes += 1
                MontoTotal = MontoTotal + Val(txtMontopPersona.Text)
                btn_agregar.Visible = False
            Case "I"
                If totalintegrantes >= 1 Then
                    MessageBox.Show("El tipo de crédito es individual, sólo puede tener un integrante")
                    btn_agregar.Visible = False
                Else
                    Await Task.Factory.StartNew(Sub()
                                                    iniciarconexionempresa()
                                                    Dim comandoTiene As SqlCommand
                                                    Dim consultaTiene As String
                                                    consultaTiene = "if exists(select Solicitud.id from Solicitud inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud where DatosSolicitud.IdCliente = '" & txtIdCliente.Text & "' and (Solicitud.Estado = 'I' or Solicitud.Estado = 'E' or Solicitud.Estado = 'V'))
begin 
select concat('Solicitud con Número ',Solicitud.id) as solicitud from Solicitud inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud where DatosSolicitud.IdCliente = '" & txtIdCliente.Text & "' and (Solicitud.Estado = 'I' or Solicitud.Estado = 'E' or Solicitud.Estado = 'V')
end
else if exists(select Credito.id from Credito inner join Solicitud on Credito.IdSolicitud = Solicitud.id inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud where DatosSolicitud.IdCliente ='" & txtIdCliente.Text & "' and (credito.estado = 'A' or credito.estado = 'C' or credito.estado = 'L' or credito.estado = 'E' or credito.estado = 'P'))
begin
select concat('Credito con Número ',Credito.id) as credito from Credito inner join Solicitud on Credito.IdSolicitud = Solicitud.id inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud where DatosSolicitud.IdCliente = '" & txtIdCliente.Text & "' and (credito.estado = 'A' or credito.estado = 'C' or credito.estado = 'L' or credito.estado = 'E' or credito.estado = 'P')
end
else if exists(select Solicitud.id,Fecha,Solicitud.Estado from Solicitud inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud where DatosSolicitud.IdCliente = '" & txtIdCliente.Text & "' and Solicitud.Estado = 'R' and Solicitud.Fecha >= DATEADD(MONTH,-4,GETDATE()) AND Solicitud.Fecha <= GETDATE())
begin
select 'R'
end
else if exists(select Solicitud.id,Fecha,Solicitud.Estado from Solicitud inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud where DatosSolicitud.IdCliente = '" & txtIdCliente.Text & "' and DatosSolicitud.Estado = 'R' and Solicitud.Fecha >= DATEADD(MONTH,-4,GETDATE()) AND Solicitud.Fecha <= GETDATE())
begin 
select 'DSR'
end
else
begin
select 'No tiene'
end"
                                                    comandoTiene = New SqlCommand
                                                    comandoTiene.Connection = conexionempresa
                                                    comandoTiene.CommandText = consultaTiene
                                                    esta = comandoTiene.ExecuteScalar
                                                End Sub)
                    Select Case esta
                        Case "No tiene"
                            dtdatos.Rows.Add(idCliente, nombreCliente, txtMontopPersona.Text)
                            totalintegrantes += 1
                            MontoTotal = MontoTotal + Val(txtMontopPersona.Text)
                            txtNombreSolicitud.Text = nombreCliente
                            txtNombreSolicitud.Enabled = False
                            btn_agregar.Visible = False
                        Case "R"
                            MessageBox.Show("El cliente tiene solicitudes rechazadas con fecha menor a 4 meses")
                            SolicitudesRechazadasCliente.tipoRechazo = "R"
                            SolicitudesRechazadasCliente.Idcliente = txtIdCliente.Text
                            SolicitudesRechazadasCliente.ShowDialog()
                            Dim result As DialogResult = MessageBox.Show("¿Desea agregarlo a la solicitud de todos modos?",
                                                        "Cliente Rechazado",
                                                        MessageBoxButtons.YesNo)

                            If (result = DialogResult.Yes) Then
                                Autorizacion.tipoAutorizacion = "SatiModSolicitudesAgregarRechazados"
                                Autorizacion.ShowDialog()
                                If autorizado Then
                                    dtdatos.Rows.Add(idCliente, nombreCliente, txtMontopPersona.Text)
                                    totalintegrantes += 1
                                    MontoTotal = MontoTotal + Val(txtMontopPersona.Text)
                                    txtNombreSolicitud.Text = nombreCliente
                                    txtNombreSolicitud.Enabled = False
                                    btn_agregar.Visible = False
                                Else
                                    MessageBox.Show("No fue autorizado")
                                End If

                            Else

                            End If
                        Case "DSR"
                            MessageBox.Show("El cliente fue rechazado de algunas solicitudes con fecha menor a 4 meses")
                            SolicitudesRechazadasCliente.tipoRechazo = "DSR"
                            SolicitudesRechazadasCliente.Idcliente = txtIdCliente.Text
                            SolicitudesRechazadasCliente.ShowDialog()
                            Dim result As DialogResult = MessageBox.Show("¿Desea agregarlo a la solicitud de todos modos?",
                                                        "Cliente Rechazado",
                                                        MessageBoxButtons.YesNo)

                            If (result = DialogResult.Yes) Then
                                Autorizacion.tipoAutorizacion = "SatiModSolicitudesAgregarRechazados"
                                Autorizacion.ShowDialog()
                                If autorizado Then
                                    dtdatos.Rows.Add(idCliente, nombreCliente, txtMontopPersona.Text)
                                    totalintegrantes += 1
                                    MontoTotal = MontoTotal + Val(txtMontopPersona.Text)
                                    txtNombreSolicitud.Text = nombreCliente
                                    txtNombreSolicitud.Enabled = False
                                    btn_agregar.Visible = False
                                Else
                                    MessageBox.Show("No fue autorizado")
                                End If

                            Else

                            End If
                        Case Else
                            MessageBox.Show("El cliente ya cuenta con " & esta)
                            Dim result As DialogResult = MessageBox.Show("¿Desea agregarlo a la solicitud de todos modos?",
                                                       "Cliente Rechazado",
                                                       MessageBoxButtons.YesNo)
                            If (result = DialogResult.Yes) Then
                                dtdatos.Rows.Add(idCliente, nombreCliente, txtMontopPersona.Text)
                                totalintegrantes += 1
                                MontoTotal = MontoTotal + Val(txtMontopPersona.Text)
                                txtNombreSolicitud.Text = nombreCliente
                                txtNombreSolicitud.Enabled = False
                                btn_agregar.Visible = False
                            End If
                    End Select

                End If
            Case "L"
                dtdatos.Rows.Add(idCliente, nombreCliente, Val(txtMontopPersona.Text) + Val(txtMoratorios.Text))
                totalintegrantes += 1
                MontoTotal = MontoTotal + Val(txtMontopPersona.Text)
                btn_agregar.Visible = False
                txtMoratorios.Visible = False
                lblMoratorios.Visible = False
                If usarNombre Then
                    txtNombreSolicitud.Text = nombreCliente
                    txtNombreSolicitud.Enabled = False
                Else
                    txtNombreSolicitud.Text = ""
                    txtNombreSolicitud.Enabled = True
                End If
                totalMoratorios = totalMoratorios + Val(txtMoratorios.Text)
                'txtTotal.Visible = False
                'lblTotal.Visible = False
        End Select
        txtIntegrantes.Text = totalintegrantes
        txtMontoTotal.Text = MontoTotal
        If tipocredito = "L" Then
            txtTotal.Text = (MontoTotal + totalMoratorios) * 1.3
            txtTotalMoratorios.Text = totalMoratorios
        End If
    End Sub

    Private Sub dtdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtdatos.CellContentClick

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub BackgroundGestores_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundGestores.DoWork

        Try
            iniciarconexionempresa()
            Dim consulta As String
            consulta = "Select id,nombre from empleados where tipo = 'G'"
            adapterGestores = New SqlDataAdapter(consulta, conexionempresa)
            dataGestores = New DataSet
            adapterGestores.Fill(dataGestores)
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error " & ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TiposDeCreditos.Show()
    End Sub

    Private Sub BackgroundPromotores_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundPromotores.DoWork
        Try
            iniciarconexionempresa()
            Dim consulta As String
            consulta = "Select id,nombre from empleados where tipo = 'P'"
            adapterPromotores = New SqlDataAdapter(consulta, conexionempresa)
            dataPromotores = New DataSet
            adapterPromotores.Fill(dataPromotores)
            empezar = True
        Catch ex As Exception
            empezar = False
            MessageBox.Show("Ha ocurrido un error " & ex.Message)
        End Try

    End Sub

    Public Sub ConsultarTipocredito()
        Try
            iniciarconexionempresa()
            Dim comando As SqlCommand
            Dim consulta As String
            Dim reader As SqlDataReader
            consulta = "select nombre,modalidad,tipo,plazo,interes from TiposDeCredito where id = '" & txtTipo.Text & "'"
            comando = New SqlCommand
            comando.Connection = conexionempresa
            comando.CommandText = consulta
            reader = comando.ExecuteReader
            If reader.HasRows Then
                While reader.Read

                    nombreTipo = reader("nombre")
                    Modalidad = reader("modalidad")
                    tipocredito = reader("tipo")
                    idtipo = txtTipo.Text
                    plazoTipo = reader("plazo")
                    interesTipo = reader("interes")
                End While
                lblTipo.Text = nombreTipo
                txtplazo.Text = plazoTipo
                txtInteres.Text = interesTipo

            Else
                lblTipo.Text = "No se encontró"
            End If


            consultadoTipo = True
        Catch ex As Exception
            lblTipo.Text = "..."
            consultadoTipo = False
            MessageBox.Show("Ha ocurrido un error " & ex.Message)
        End Try

    End Sub

    Private Sub txtTipo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTipo.KeyDown
        If empezar Then
            If e.KeyCode = Keys.Enter Then
                ConsultarTipocredito()

            End If

            If e.KeyCode = Keys.F2 Then
                TiposDeCreditos.Show()
            End If
        Else
            MessageBox.Show("No se han cargado los valores, espere")
        End If

    End Sub

    Public Sub ConsultarCliente()
        iniciarconexionempresa()
        Dim comando As SqlCommand
        Dim consulta As String
        Dim reader As SqlDataReader
        consulta = "select id,id,(nombre+' '+apellidoPaterno+' '+apellidoMaterno) as nombre from clientes where id = '" & txtIdCliente.Text & "'"
        comando = New SqlCommand
        comando.Connection = conexionempresa
        comando.CommandText = consulta
        reader = comando.ExecuteReader
        If reader.HasRows Then
            While reader.Read
                idCliente = reader("id")
                nombreCliente = reader("nombre")
            End While

            lblCliente.Text = nombreCliente
            consultadoCliente = True
        Else
            consultadoCliente = False
            lblCliente.Text = "No se encontró"
        End If
    End Sub

    Private Sub txtIdCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdCliente.KeyDown
        If empezar Then
            If e.KeyCode = Keys.Enter Then
                ConsultarCliente()
                If consultadoCliente Then
                    If tipocredito = "L" Then

                        btn_agregar.Visible = True
                        txtMoratorios.Visible = True
                        lblMoratorios.Visible = True
                        txtTotal.Visible = True
                        lblTotal.Visible = True
                        CheckNombre.Visible = True
                        ComboLegal.Visible = True
                        lblGestorLegal.Visible = True
                        txtTotalMoratorios.Visible = True
                        lblTotalMoratorios.Visible = True
                    Else
                        btn_agregar.Visible = True
                        txtMoratorios.Visible = False
                        lblMoratorios.Visible = False
                        txtTotal.Visible = False
                        lblTotal.Visible = False
                        CheckNombre.Visible = False
                        ComboLegal.Visible = False
                        lblGestorLegal.Visible = False
                        txtTotalMoratorios.Visible = False
                        lblTotalMoratorios.Visible = False
                    End If


                End If
            End If
        Else
            MessageBox.Show("No se han cargado los valores, espere")
        End If

    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs)

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        iniciarconexionempresa()
        Dim comandoSolicitud As SqlCommand
        Dim consultaSolicitud As String

        Dim idpromotor As Integer
        Dim idgestor As Integer
        idpromotor = ConsultarIdPromotor(ComboPromotor.Text)
        idgestor = ConsultarIdGestor(ComboGestor.Text)
        consultaSolicitud = "Insert into Solicitud(Fecha,Nombre,Monto,Tipo,Plazo,Interes,PagoIndividual,Integrantes,IDcliente,IdPromotor,IdGestor,Estado)
                             values('" & Now.ToString("yyyy-MM-dd") & "','" & txtNombreSolicitud.Text & "','" & txtMontoTotal.Text & "', '" & txtTipo.Text & "','" & txtplazo.Text & "','" & txtInteres.Text & "','" & (Val(txtMontoTotal.Text) / 1000) * Val(txtInteres.Text) & "','" & txtIntegrantes.Text & "','" & txtResponsable.Text & "','" & idpromotor & "','" & idgestor & "','I') 
                             SELECT SCOPE_IDENTITY()"
        comandoSolicitud = New SqlCommand
        comandoSolicitud.Connection = conexionempresa
        comandoSolicitud.CommandText = consultaSolicitud
        idSolicitud = comandoSolicitud.ExecuteScalar

        Dim comandoCronograma As SqlCommand
        Dim consultaCronograma As String
        Dim tiempo As String = TimeOfDay.ToString("HH:mm:ss")
        consultaCronograma = "insert into CronogramaSolicitud values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & idSolicitud & "','Se registró la solicitud por " & nmusr & "')"
        comandoCronograma = New SqlCommand
        comandoCronograma.Connection = conexionempresa
        comandoCronograma.CommandText = consultaCronograma
        comandoCronograma.ExecuteNonQuery()


        For Each row As DataGridViewRow In dtdatos.Rows
            Dim comandoDatosSolicitud As SqlCommand
            Dim consultaDatosSolicitud As String
            consultaDatosSolicitud = "INSERT INTO [dbo].[DatosSolicitud]
           ([IdSolicitud]
           ,[Monto]
           ,[IdCliente]
           ,[Edad]
           ,[Telefono]
           ,[Celular]
           ,[TiempoEnDomicilio]
           ,[Calle]
           ,[Noext]
           ,[Noint]
           ,[CodigoPostal]
           ,[Colonia]
           ,[Ciudad]
           ,[EstadoCliente]
           ,[EntreCalles]
           ,[Conyuge]
           ,[RelacionConyuge]
           ,[DondeTrabaja]
           ,[SeDedica]
           ,[QueVende]
           ,[Antiguedad]
           ,[Horarios]
           ,[TipoEstablecimiento]
           ,[IngresoPmensual]
           ,[FrecuenciaCobro]
           ,[CalleTrabajo]
           ,[NoextTrabajo]
           ,[NointTrabajo]
           ,[CodigoPostalTrabajo]
           ,[ColoniaTrabajo]
           ,[TelefonoTrabajo]
           ,[JefeDirecto]
           ,[Objetivo]
           ,[NombreR1]
           ,[TelefonoR1]
           ,[RelacionR1]
           ,[NombreR2]
           ,[TelefonoR2]
           ,[RelacionR2]
           ,[Enfermedad]
           ,[FamiliasEnCasa]
           ,[DeudasCon]
           ,[Servicios]
           ,[PersonasDependientes]
           ,[Empleados]
           ,[FrecuenciaInversion]
           ,[ObservacionesDomicilio]
           ,[HorarioVerificacion]
           ,[MontoAutorizado]
           ,[Comentarios]
           ,[Estado])
     VALUES
           ('" & idSolicitud & "','" & row.Cells(2).Value & "','" & row.Cells(0).Value & "','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','P')"
            comandoDatosSolicitud = New SqlCommand
            comandoDatosSolicitud.Connection = conexionempresa
            comandoDatosSolicitud.CommandText = consultaDatosSolicitud
            comandoDatosSolicitud.ExecuteNonQuery()

        Next

    End Sub

    Private Sub btn_Procesar_Click(sender As Object, e As EventArgs) Handles btn_Procesar.Click

        If dtdatos.Rows.Count > 0 Then
            If tipocredito = "L" Then
                Autorizacion.tipoAutorizacion = "SatiModSolicitudesAgregarLegales"
                Autorizacion.ShowDialog()
                If autorizado Then
                    Cargando.Show()
                    Cargando.MonoFlat_Label1.Text = "Procesando"
                    BackgroundSolicitudLegal.RunWorkerAsync()
                Else
                    MessageBox.Show("No fue autorizado")
                End If
            Else

                Autorizacion.tipoAutorizacion = "SatiModSolicitudesAgregar"
                Autorizacion.ShowDialog()
                If autorizado Then
                    Cargando.Show()
                    Cargando.MonoFlat_Label1.Text = "Procesando"
                    BackgroundWorker1.RunWorkerAsync()
                Else
                    MessageBox.Show("No fue autorizado")
                End If

            End If

        Else
            MessageBox.Show("La solicitud no cuenta con ningún integrante")
        End If

    End Sub

    Private Sub dtdatos_KeyDown(sender As Object, e As KeyEventArgs) Handles dtdatos.KeyDown
        If e.KeyCode = Keys.Delete Then
            If dtdatos.Rows.Count <> 0 Then
                dtdatos.Rows.RemoveAt(dtdatos.CurrentCell.RowIndex)
                totalintegrantes -= 1
                txtIntegrantes.Text = totalintegrantes
            End If

        End If
    End Sub

    Private Sub CheckNombre_CheckedChanged(sender As Object) Handles CheckNombre.CheckedChanged
        If CheckNombre.Checked Then
            usarNombre = True
        Else

            usarNombre = False

        End If
    End Sub

    Private Sub BackgroundLegal_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundLegal.DoWork
        Try
            iniciarconexionempresa()
            Dim consulta As String
            consulta = "Select id,nombre from empleados where tipo = 'L'"
            adapterLegal = New SqlDataAdapter(consulta, conexionempresa)
            dataLegal = New DataSet
            adapterLegal.Fill(dataLegal)
            empezar = True
        Catch ex As Exception
            empezar = False
            MessageBox.Show("Ha ocurrido un error " & ex.Message)
        End Try
    End Sub

    Private Sub ComboLegal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboLegal.SelectedIndexChanged

    End Sub

    Private Sub BackgroundGestores_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundGestores.RunWorkerCompleted
        Cargando.MonoFlat_Label1.Text = "Cargando Promotores"
        BackgroundPromotores.RunWorkerAsync()

    End Sub

    Private Sub BackgroundSolicitudLegal_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundSolicitudLegal.DoWork
        iniciarconexionempresa()
        Dim comandoSolicitud As SqlCommand
        Dim consultaSolicitud As String

        Dim idpromotor As Integer
        Dim idgestor As Integer
        idpromotor = ConsultarIdPromotor(ComboPromotor.Text)
        idgestor = ConsultarIdGestor(ComboGestor.Text)
        consultaSolicitud = "Insert into Solicitud(Fecha,Nombre,Monto,Tipo,Plazo,Interes,PagoIndividual,Integrantes,IDcliente,IdPromotor,IdGestor,Estado)
                             values('" & Now.ToString("yyyy-MM-dd") & "','" & txtNombreSolicitud.Text & "','" & txtMontoTotal.Text & "', '" & txtTipo.Text & "','" & txtplazo.Text & "','" & txtInteres.Text & "','" & (Val(txtMontoTotal.Text) / 1000) * Val(txtInteres.Text) & "','" & txtIntegrantes.Text & "','" & txtResponsable.Text & "','" & idpromotor & "','" & idgestor & "','N') 
                             SELECT SCOPE_IDENTITY()"
        comandoSolicitud = New SqlCommand
        comandoSolicitud.Connection = conexionempresa
        comandoSolicitud.CommandText = consultaSolicitud
        idSolicitud = comandoSolicitud.ExecuteScalar

        Dim comandoCronograma As SqlCommand
        Dim consultaCronograma As String
        Dim tiempo As String = TimeOfDay.ToString("HH:mm:ss")
        consultaCronograma = "insert into CronogramaSolicitud values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & idSolicitud & "','Se registró la solicitud por " & nmusr & "')"
        comandoCronograma = New SqlCommand
        comandoCronograma.Connection = conexionempresa
        comandoCronograma.CommandText = consultaCronograma
        comandoCronograma.ExecuteNonQuery()


        For Each row As DataGridViewRow In dtdatos.Rows
            Dim comandoDatosSolicitud As SqlCommand
            Dim consultaDatosSolicitud As String
            consultaDatosSolicitud = "INSERT INTO [dbo].[DatosSolicitud]
           ([IdSolicitud]
           ,[Monto]
           ,[IdCliente]
           ,[Edad]
           ,[Telefono]
           ,[Celular]
           ,[TiempoEnDomicilio]
           ,[Calle]
           ,[Noext]
           ,[Noint]
           ,[CodigoPostal]
           ,[Colonia]
           ,[Ciudad]
           ,[EstadoCliente]
           ,[EntreCalles]
           ,[Conyuge]
           ,[RelacionConyuge]
           ,[DondeTrabaja]
           ,[SeDedica]
           ,[QueVende]
           ,[Antiguedad]
           ,[Horarios]
           ,[TipoEstablecimiento]
           ,[IngresoPmensual]
           ,[FrecuenciaCobro]
           ,[CalleTrabajo]
           ,[NoextTrabajo]
           ,[NointTrabajo]
           ,[CodigoPostalTrabajo]
           ,[ColoniaTrabajo]
           ,[TelefonoTrabajo]
           ,[JefeDirecto]
           ,[Objetivo]
           ,[NombreR1]
           ,[TelefonoR1]
           ,[RelacionR1]
           ,[NombreR2]
           ,[TelefonoR2]
           ,[RelacionR2]
           ,[Enfermedad]
           ,[FamiliasEnCasa]
           ,[DeudasCon]
           ,[Servicios]
           ,[PersonasDependientes]
           ,[Empleados]
           ,[FrecuenciaInversion]
           ,[ObservacionesDomicilio]
           ,[HorarioVerificacion]
           ,[MontoAutorizado]
           ,[Comentarios]
           ,[Estado])
            VALUES
           ('" & idSolicitud & "','" & row.Cells(2).Value & "','" & row.Cells(0).Value & "','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','P')"
            comandoDatosSolicitud = New SqlCommand
            comandoDatosSolicitud.Connection = conexionempresa
            comandoDatosSolicitud.CommandText = consultaDatosSolicitud
            comandoDatosSolicitud.ExecuteNonQuery()

        Next


        Dim comandoLegal As SqlCommand
        Dim consultaLegal As String
        Dim idGestorLegal As Integer
        idGestorLegal = ConsultarIdGestorLegal(ComboLegal.Text)
        consultaLegal = "insert into Legales values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & txtNombreSolicitud.Text & "','" & txtMontoTotal.Text & "','" & txtTotalMoratorios.Text & "','" & Val(txtMontoTotal.Text) + Val(txtTotalMoratorios.Text) & "','" & txtTotal.Text & "','" & txtTipo.Text & "','" & txtIntegrantes.Text & "','" & txtResponsable.Text & "','" & idGestorLegal & "','" & idSolicitud & "','E','" & txtplazo.Text & "','','','','','','','')"
        comandoLegal = New SqlCommand
        comandoLegal.Connection = conexionempresa
        comandoLegal.CommandText = consultaLegal
        comandoLegal.ExecuteNonQuery()

    End Sub

    Private Sub BackgroundPromotores_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundPromotores.RunWorkerCompleted
        Cargando.MonoFlat_Label1.Text = "Cargando Legales"
        BackgroundLegal.RunWorkerAsync()
    End Sub


    Private Function ConsultarIdPromotor(nombre As String) As Integer
        Dim idEmpleado As Integer

        For Each row As DataRow In dataPromotores.Tables(0).Rows
            If row("nombre").ToString = nombre Then
                idEmpleado = Val(row("id").ToString)
                Exit For
            End If
        Next



        Return idEmpleado
    End Function
    Private Function ConsultarIdGestor(nombre As String) As Integer
        Dim idEmpleado As Integer

        For Each row As DataRow In dataGestores.Tables(0).Rows
            If row("nombre").ToString = nombre Then
                idEmpleado = Val(row("id").ToString)
                Exit For
            End If
        Next



        Return idEmpleado
    End Function

    Private Function ConsultarIdGestorLegal(nombre As String) As Integer
        Dim idEmpleado As Integer

        For Each row As DataRow In dataLegal.Tables(0).Rows
            If row("nombre").ToString = nombre Then
                idEmpleado = Val(row("id").ToString)
                Exit For
            End If
        Next



        Return idEmpleado
    End Function


    Private Sub dtdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtdatos.CellDoubleClick
        If dtdatos.Rows.Count <> 0 Then
            txtResponsable.Text = dtdatos.CurrentRow.Cells(0).Value
        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Cargando.Close()
        DatosSolicitud.idSolicitud = idSolicitud
        DatosSolicitud.tipoSolicitud = txtTipo.Text
        DatosSolicitud.Show()
        Me.Close()
    End Sub

    Private Sub BackgroundLegal_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundLegal.RunWorkerCompleted
        ComboPromotor.Items.Clear()

        For Each row As DataRow In dataPromotores.Tables(0).Rows

            ComboPromotor.Items.Add(row("nombre"))
        Next
        ComboPromotor.SelectedIndex = 0

        ComboGestor.Items.Clear()

        For Each row As DataRow In dataGestores.Tables(0).Rows

            ComboGestor.Items.Add(row("nombre"))
        Next
        ComboGestor.SelectedIndex = 0


        ComboLegal.Items.Clear()

        For Each row As DataRow In dataLegal.Tables(0).Rows

            ComboLegal.Items.Add(row("nombre"))
        Next
        ComboLegal.SelectedIndex = 0

        Cargando.Close()
    End Sub

    Private Sub BackgroundSolicitudLegal_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundSolicitudLegal.RunWorkerCompleted
        Cargando.Close()
        DatosSolicitud.idSolicitud = idSolicitud
        DatosSolicitud.tipoSolicitud = txtTipo.Text
        DatosSolicitud.Show()
        Me.Close()
    End Sub
End Class