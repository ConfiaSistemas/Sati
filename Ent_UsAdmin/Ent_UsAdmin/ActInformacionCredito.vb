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
    Dim idSolicitud As String
    Dim idDatosSolicitud As String
    Dim NuevoDomicilio As String
    Dim datosSolicitud As DataTable
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
            Case Else
                PanelValor.Location = New Point(41, 124)
                PanelValor.Visible = True
                PanelDomicilio.Visible = False
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

        consultaInformacion = "select CONCAT(Clientes.Nombre,' ',Clientes.ApellidoPaterno,' ',Clientes.ApellidoMaterno) as nombre,concat('Calle ',DatosSolicitud.Calle,' Número Exterior ',DatosSolicitud.Noext,' Número Interior ',DatosSolicitud.Noint,' Colonia ',DatosSolicitud.Colonia,' Código Postal ',DatosSolicitud.CodigoPostal) as Domicilio,concat('Calle ',CalleTrabajo,' Número exterior ',NoextTrabajo,' Número Interior ',NointTrabajo,' Colonia ',ColoniaTrabajo,' Código postal ',CodigoPostalTrabajo) as domicilioTrabajo,DatosSolicitud.Telefono,DatosSolicitud.Celular,DatosSolicitud.TelefonoTrabajo,DatosSolicitud.id as idDatosSolicitud from credito inner join Solicitud on Credito.idSolicitud = Solicitud.id inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud inner join Clientes on DatosSolicitud.IdCliente = Clientes.id where Credito.id = '" & idCredito & "'"


        adapterDatosSolicitud = New SqlDataAdapter(consultaInformacion, conexionempresa)
        datosSolicitud = New DataTable
        adapterDatosSolicitud.Fill(datosSolicitud)

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
        Select Case ComboTipo.selectedValue
            Case "Domicilio"
                consultaActualizacion = "update datosSolicitud set calle = '" & txtCalle.Text & "',noext = '" & txtNoExt.Text & "',noint = '" & txtNoInt.Text & "',codigopostal = '" & txtCodigoPostal.Text & "',colonia = '" & txtColonia.Text & "' where id = '" & idDatosSolicitud & "'"
            Case "Número de Teléfono"
                consultaActualizacion = "update datosSolicitud set telefono = '" & txtValor.Text & "' where id = '" & idDatosSolicitud & "'"
            Case "Número de Celular"
                consultaActualizacion = "update datosSolicitud set celular = '" & txtValor.Text & "' where id = '" & idDatosSolicitud & "'"
            Case "Domicilio de Trabajo"
                consultaActualizacion = "update datosSolicitud set calletrabajo = '" & txtCalle.Text & "',noextTrabajo = '" & txtNoExt.Text & "',nointTrabajo = '" & txtNoInt.Text & "',codigopostalTrabajo = '" & txtCodigoPostal.Text & "',coloniaTrabajo = '" & txtColonia.Text & "' where id = '" & idDatosSolicitud & "'"
            Case "Teléfono de Trabajo"
                consultaActualizacion = "update datosSolicitud set telefonoTrabajo = '" & txtValor.Text & "' where id = '" & idDatosSolicitud & "'"
        End Select
        Dim comandoLegalAnterior As SqlCommand
        Dim consultaLegalAnterior As String
        Dim valorAnteriorStr As String
        Select Case ComboTipo.selectedValue
            Case "Domicilio"
                valorAnteriorStr = ValorAnterior(ComboTipo.selectedValue, idDatosSolicitud)
                NuevoDomicilio = "Calle " & txtCalle.Text & " Número Exterior " & txtNoExt.Text & " Número Interior " & txtNoInt.Text & " Colonia " & txtColonia.Text & " Código Postal " & txtCodigoPostal.Text
                consultaLegalAnterior = "insert into ActualizacionesCredito values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & ComboTipo.selectedValue & "','" & valorAnteriorStr & "','" & NuevoDomicilio & "','" & txtMotivo.Text & "','" & idCredito & "')"
            Case "Número de Teléfono"
                valorAnteriorStr = ValorAnterior(ComboTipo.selectedValue, idDatosSolicitud)
                consultaLegalAnterior = "insert into ActualizacionesCredito values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & ComboTipo.selectedValue & "','" & valorAnteriorStr & "','" & txtValor.Text & "','" & txtMotivo.Text & "','" & idCredito & "')"
            Case "Número de Celular"
                valorAnteriorStr = ValorAnterior(ComboTipo.selectedValue, idDatosSolicitud)
                consultaLegalAnterior = "insert into ActualizacionesCredito values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & ComboTipo.selectedValue & "','" & valorAnteriorStr & "','" & txtValor.Text & "','" & txtMotivo.Text & "','" & idCredito & "')"
            Case "Domicilio de Trabajo"
                valorAnteriorStr = ValorAnterior(ComboTipo.selectedValue, idDatosSolicitud)
                NuevoDomicilio = "Calle " & txtCalle.Text & " Número Exterior " & txtNoExt.Text & " Número Interior " & txtNoInt.Text & " Colonia " & txtColonia.Text & " Código Postal " & txtCodigoPostal.Text

                consultaLegalAnterior = "insert into ActualizacionesCredito values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & ComboTipo.selectedValue & "','" & valorAnteriorStr & "','" & NuevoDomicilio & "','" & txtMotivo.Text & "','" & idCredito & "')"
            Case "Teléfono de Trabajo"
                valorAnteriorStr = ValorAnterior(ComboTipo.selectedValue, idDatosSolicitud)
                consultaLegalAnterior = "insert into ActualizacionesCredito values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & ComboTipo.selectedValue & "','" & valorAnteriorStr & "','" & txtValor.Text & "','" & txtMotivo.Text & "','" & idCredito & "')"
        End Select
        'consultaLegalAnterior = "insert into ActualizacionLegal values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & ComboTipo.selectedValue & "','" &  & "')"
        comandoLegalAnterior = New SqlCommand
        comandoLegalAnterior.Connection = conexionempresa
        comandoLegalAnterior.CommandText = consultaLegalAnterior
        comandoLegalAnterior.ExecuteNonQuery()


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
        Dim datosSolicitudId As String
        For Each row As DataRow In datosSolicitud.Rows
            If row("nombre").ToString = Nombre Then
                datosSolicitudId = row("idDatosSolicitud")
                Exit For
            End If
        Next
        Return datosSolicitudId
    End Function


    Private Function ValorAnterior(campo As String, aquien As String) As String
        Dim retorno As String
        For Each row As DataRow In datosSolicitud.Rows
            Select Case campo

                Case "Domicilio"
                    If row("idDatosSolicitud").ToString = aquien Then
                        retorno = row("Domicilio").ToString
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
            End Select
        Next
        Return retorno
    End Function
End Class