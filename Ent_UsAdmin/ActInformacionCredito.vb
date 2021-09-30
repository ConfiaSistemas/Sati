Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class ActInformacionCredito

    Public idCredito As String
    Dim domicilioActual As String
    Dim noExpedienteActual As String
    Dim JuzgadoActual As String
    Dim EtapaProcesalActual As String
    Dim ActuarioActual As String
    Dim consultaActualizacion As String
    Dim datoscliente As String
    Dim idSolicitud As String
    Dim idDatosSolicitud As String
    Dim datosSolicitudId As String
    Dim NuevoDomicilio As String
    Dim consul As String
    Dim sol As String
    Dim retorno As String
    Dim datosSolicitud As DataTable
    Dim dom As DataTable
    Dim adapterDatosSolicitud As SqlDataAdapter


    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub ComboTipo_onItemSelected(sender As Object, e As EventArgs) Handles ComboTipo.onItemSelected
        Select Case ComboTipo.selectedValue
            Case "Domicilio"
                PanelDomicilio.Location = New Point(41, 124)
                PanelDomicilio.Visible = True
                PanelValor.Visible = False
            Case "Domicilio de Trabajo"
                PanelDomicilio.Location = New Point(41, 124)
                PanelDomicilio.Visible = True
                PanelValor.Visible = False
            Case "Referencia 1"
                PanelR.Location = New Point(41, 124)
                PanelR.Visible = True
                PanelValor.Visible = False
                PanelDomicilio.Visible = False
            Case "Referencia 2"
                PanelR.Location = New Point(41, 124)
                PanelR.Visible = True
                PanelValor.Visible = False
                PanelDomicilio.Visible = False
            Case Else
                PanelValor.Location = New Point(41, 124)
                PanelValor.Visible = True
                PanelDomicilio.Visible = False
                PanelR.Visible = False
        End Select
    End Sub

    Private Sub ActInformacionLegal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        ComboTipo.selectedIndex = 0
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando Información"
        BackgroundConsultaInformacion.RunWorkerAsync()

    End Sub

    Private Sub BackgroundConsultaInformacion_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundConsultaInformacion.DoWork
        iniciarconexionempresa()


        Dim consultaInformacion As String

        consultaInformacion = "select CONCAT(Clientes.Nombre,' ',Clientes.ApellidoPaterno,' ',Clientes.ApellidoMaterno) as nombre,concat('Calle ',DatosSolicitud.Calle,' Número Exterior ',DatosSolicitud.Noext,' Número Interior ',DatosSolicitud.Noint,' Colonia ',DatosSolicitud.Colonia,' Código Postal ',DatosSolicitud.CodigoPostal) as Domicilio,concat('Calle ',CalleTrabajo,' Número exterior ',NoextTrabajo,' Número Interior ',NointTrabajo,' Colonia ',ColoniaTrabajo,' Código postal ',CodigoPostalTrabajo) as domicilioTrabajo,DatosSolicitud.Telefono,DatosSolicitud.Celular,DatosSolicitud.TelefonoTrabajo,DatosSolicitud.id as idDatosSolicitud,concat('Nombre ',datossolicitud.NombreR1,' Teléfono ',datossolicitud.TelefonoR1,' Relación ',datossolicitud.RelacionR1,' Domicilio ',datossolicitud.CalleR1,' No. Ext. ',datossolicitud.NoExtR1,' No. Int. ',datossolicitud.NoIntR1,' Colonia ',datossolicitud.ColoniaR1,' C.P. ',datossolicitud.CodigoPostalR1) as Referencia1,concat('Nombre ',datossolicitud.NombreR2,' Teléfono ',datossolicitud.TelefonoR2,' Relación ',datossolicitud.RelacionR2,' Domicilio ',datossolicitud.CalleR2,' No. Ext. ',datossolicitud.NoExtR2,' No. Int. ',datossolicitud.NoIntR2,' Colonia ',datossolicitud.ColoniaR2,' C.P. ',datossolicitud.CodigoPostalR2) as Referencia2 from credito inner join Solicitud on Credito.idSolicitud = Solicitud.id inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud inner join Clientes on DatosSolicitud.IdCliente = Clientes.id where Credito.id = '" & idCredito & "'"


        adapterDatosSolicitud = New SqlDataAdapter(consultaInformacion, conexionempresa)
        datosSolicitud = New DataTable
        adapterDatosSolicitud.Fill(datosSolicitud)

        For Each row1 As DataRow In datosSolicitud.Rows

            datosSolicitudId = row1("idDatosSolicitud")

            Exit For

        Next

        ''sol = SOLUCION remplazo de "idDatosSolicitud"
    End Sub

    Private Sub BackgroundConsultaInformacion_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundConsultaInformacion.RunWorkerCompleted
        ComboCliente.Clear()


        For Each row As DataRow In datosSolicitud.Rows
            ComboCliente.AddItem(row("nombre").ToString)


        Next

        ComboCliente.selectedIndex = 0


        Cargando.Close()
    End Sub

    Private Sub BackgroundActualizacion_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundActualizacion.DoWork


        Dim tiempo As String = TimeOfDay.ToString("HH:mm:ss")
        idDatosSolicitud = ObteneridDatosSolicitud(ComboCliente.selectedValue)
        Dim comandoLegalAnterior As SqlCommand
        Dim consultaLegalAnterior As String
        Dim valorAnteriorStr As String


        Select Case ComboTipo.selectedValue
            Case "Domicilio"
                valorAnteriorStr = ValorAnterior(ComboTipo.selectedValue, datosSolicitudId)

                NuevoDomicilio = "Calle " & txtCalle.Text & " Número Exterior " & txtNoExt.Text & " Número Interior " & txtNoInt.Text & " Colonia " & txtColonia.Text & " Código Postal " & txtCodigoPostal.Text
                consultaLegalAnterior = "insert into ActualizacionesCredito values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & ComboTipo.selectedValue & "','" & valorAnteriorStr & "','" & NuevoDomicilio & "','" & txtMotivo.Text & "','" & idCredito & "')"
            Case "Número de Teléfono"
                valorAnteriorStr = ValorAnterior(ComboTipo.selectedValue, datosSolicitudId)
                consultaLegalAnterior = "insert into ActualizacionesCredito values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & ComboTipo.selectedValue & "','" & valorAnteriorStr & "','" & txtValor.Text & "','" & txtMotivo.Text & "','" & idCredito & "')"
            Case "Número de Celular"
                valorAnteriorStr = ValorAnterior(ComboTipo.selectedValue, datosSolicitudId)
                consultaLegalAnterior = "insert into ActualizacionesCredito values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & ComboTipo.selectedValue & "','" & valorAnteriorStr & "','" & txtValor.Text & "','" & txtMotivo.Text & "','" & idCredito & "')"
            Case "Domicilio de Trabajo"
                valorAnteriorStr = ValorAnterior(ComboTipo.selectedValue, datosSolicitudId)
                NuevoDomicilio = "Calle " & txtCalle.Text & " Número Exterior " & txtNoExt.Text & " Número Interior " & txtNoInt.Text & " Colonia " & txtColonia.Text & " Código Postal " & txtCodigoPostal.Text

                consultaLegalAnterior = "insert into ActualizacionesCredito values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & ComboTipo.selectedValue & "','" & valorAnteriorStr & "','" & NuevoDomicilio & "','" & txtMotivo.Text & "','" & idCredito & "')"
            Case "Teléfono de Trabajo"
                valorAnteriorStr = ValorAnterior(ComboTipo.selectedValue, datosSolicitudId)
                consultaLegalAnterior = "insert into ActualizacionesCredito values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & ComboTipo.selectedValue & "','" & valorAnteriorStr & "','" & txtValor.Text & "','" & txtMotivo.Text & "','" & idCredito & "')"
            Case "Referencia 1"
                valorAnteriorStr = ValorAnterior(ComboTipo.selectedValue, datosSolicitudId)
                NuevoDomicilio = "Nombre " & txtNombreR.Text & " Teléfono " & txtTelefonoR.Text & " Relación " & txtRelacionR.Text & " Domicilio " & txtCalleR.Text & " No. Ext. " & txtNoExtR.Text & " No. Int. " & txtNoIntR.Text & " Colonia " & ComboColoniaR.selectedValue & " C.P. " & txtCPR.Text

                consultaLegalAnterior = "insert into ActualizacionesCredito values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & ComboTipo.selectedValue & "','" & valorAnteriorStr & "','" & NuevoDomicilio & "','" & txtMotivo.Text & "','" & idCredito & "')"
            Case "Referencia 2"
                valorAnteriorStr = ValorAnterior(ComboTipo.selectedValue, datosSolicitudId)
                NuevoDomicilio = "Nombre " & txtNombreR.Text & " Teléfono " & txtTelefonoR.Text & " Relación " & txtRelacionR.Text & " Domicilio " & txtCalleR.Text & " No. Ext. " & txtNoExtR.Text & " No. Int. " & txtNoIntR.Text & " Colonia " & ComboColoniaR.selectedValue & " C.P. " & txtCPR.Text

                consultaLegalAnterior = "insert into ActualizacionesCredito values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & ComboTipo.selectedValue & "','" & valorAnteriorStr & "','" & NuevoDomicilio & "','" & txtMotivo.Text & "','" & idCredito & "')"
        End Select
        'consultaLegalAnterior = "insert into ActualizacionLegal values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & ComboTipo.selectedValue & "','" &  & "')"
        comandoLegalAnterior = New SqlCommand
        comandoLegalAnterior.Connection = conexionempresa
        comandoLegalAnterior.CommandText = consultaLegalAnterior
        comandoLegalAnterior.ExecuteNonQuery()


        Select Case ComboTipo.selectedValue
            Case "Domicilio"
                Cargando.Show()
                consultaActualizacion = "update datosSolicitud set calle = '" & txtCalle.Text & "',noext = '" & txtNoExt.Text & "',noint = '" & txtNoInt.Text & "',codigopostal = '" & txtCodigoPostal.Text & "',colonia = '" & txtColonia.Text & "' where id = '" & datosSolicitudId & "'"
                Cargando.Close()
            Case "Número de Teléfono"
                Cargando.Show()
                consultaActualizacion = "update datosSolicitud set telefono = '" & txtValor.Text & "' where id = '" & datosSolicitudId & "'"
                Cargando.Close()
            Case "Número de Celular"
                consultaActualizacion = "update datosSolicitud set celular = '" & txtValor.Text & "' where id = '" & datosSolicitudId & "'"
            Case "Domicilio de Trabajo"
                consultaActualizacion = "update datosSolicitud set calletrabajo = '" & txtCalle.Text & "',noextTrabajo = '" & txtNoExt.Text & "',nointTrabajo = '" & txtNoInt.Text & "',codigopostalTrabajo = '" & txtCodigoPostal.Text & "',coloniaTrabajo = '" & txtColonia.Text & "' where id = '" & sol & "'"
            Case "Teléfono de Trabajo"
                consultaActualizacion = "update datosSolicitud set telefonoTrabajo = '" & txtValor.Text & "' where id = '" & datosSolicitudId & "'"
            Case "Referencia 1"
                consultaActualizacion = "update datossolicitud set NombreR1 = '" & txtNombreR.Text & "',TelefonoR1 = '" & txtTelefonoR.Text & "',RelacionR1 = '" & txtRelacionR.Text & "',CodigoPostalR1 = '" & txtCPR.Text & "',ColoniaR1 = '" & ComboColoniaR.selectedValue & "',calleR1 ='" & txtCalleR.Text & "',NoExtR1 = '" & txtNoExtR.Text & "',NoIntR1 = '" & txtNoIntR.Text & "' where id = '" & datosSolicitudId & "'"
            Case "Referencia 2"
                consultaActualizacion = "update datossolicitud set NombreR2 = '" & txtNombreR.Text & "',TelefonoR2 = '" & txtTelefonoR.Text & "',RelacionR2 = '" & txtRelacionR.Text & "',CodigoPostalR2 = '" & txtCPR.Text & "',ColoniaR2 = '" & ComboColoniaR.selectedValue & "',calleR2 ='" & txtCalleR.Text & "',NoExtR2 = '" & txtNoExtR.Text & "',NoIntR2 = '" & txtNoIntR.Text & "' where id = '" & datosSolicitudId & "'"

        End Select





        Dim comandoAct As SqlCommand
        comandoAct = New SqlCommand
        comandoAct.Connection = conexionempresa
        comandoAct.CommandText = consultaActualizacion
        comandoAct.ExecuteNonQuery()








    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Actualizando Información"
        Cargando.TopMost = True
        BackgroundActualizacion.RunWorkerAsync()

    End Sub

    Private Sub BackgroundActualizacion_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundActualizacion.RunWorkerCompleted
        Cargando.Close()
        Me.Close()
    End Sub

    Private Function ObteneridDatosSolicitud(Nombre As String) As String

        For Each row As DataRow In datosSolicitud.Rows
            If row("nombre").ToString = Nombre Then
                datosSolicitudId = row("idDatosSolicitud")
                Exit For
            End If
        Next

    End Function


    Private Function ValorAnterior(campo As String, aquien As String) As String



        For Each row As DataRow In datosSolicitud.Rows


            Select Case campo

                Case "Domicilio"
                    If row("idDatosSolicitud").ToString = aquien Then
                        retorno = row("Domicilio").ToString

                        MessageBox.Show(retorno)

                        Exit For
                    End If
                Case "Número de Teléfono"
                    If row("idDatosSolicitud").ToString = aquien Then
                        retorno = row("Telefono").ToString
                        Exit For
                    End If
                Case "Número de Celular"
                    If row("idDatosSolicitud").ToString = aquien Then
                        retorno = row("Celular").ToString
                        Exit For
                    End If
                Case "Domicilio de Trabajo"
                    If row("idDatosSolicitud").ToString = aquien Then
                        retorno = row("domicilioTrabajo").ToString
                        Exit For
                    End If
                Case "Teléfono de Trabajo"
                    If row("idDatosSolicitud").ToString = aquien Then
                        retorno = row("TelefonoTrabajo").ToString
                        Exit For
                    End If
                Case "Referencia 1"
                    If row("idDatosSolicitud").ToString = aquien Then
                        retorno = row("Referencia1").ToString
                        Exit For
                    End If
                Case "Referencia 2"
                    If row("idDatosSolicitud").ToString = aquien Then
                        retorno = row("Referencia2").ToString
                        Exit For
                    End If
            End Select
        Next
        Return retorno
    End Function

    Private Sub txtCPR_OnValueChanged(sender As Object, e As EventArgs) Handles txtCPR.OnValueChanged

        ComboColoniaR.Clear()

        For Each row As DataRow In dataColonias.Rows
            If row("CP").ToString = txtCPR.Text Then
                ComboColoniaR.AddItem(row("Colonia").ToString)
            End If
        Next
    End Sub
End Class