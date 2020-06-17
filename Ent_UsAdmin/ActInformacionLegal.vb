Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class ActInformacionLegal
    Public idCreditoLegal As String
    Dim domicilioActual As String
    Dim noExpedienteActual As String
    Dim JuzgadoActual As String
    Dim EtapaProcesalActual As String
    Dim ActuarioActual As String
    Dim consultaActualizacion As String
    Dim idSolicitud As String
    Dim idDatosSolicitud As String
    Dim NuevoDomicilio As String
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
            Case Else
                PanelValor.Location = New Point(41, 124)
                PanelValor.Visible = True
                PanelDomicilio.Visible = False
        End Select
    End Sub

    Private Sub ActInformacionLegal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando Información"
        BackgroundConsultaInformacion.RunWorkerAsync()

    End Sub

    Private Sub BackgroundConsultaInformacion_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundConsultaInformacion.DoWork
        iniciarconexionempresa()

        Dim comandoInformacion As SqlCommand
        Dim consultaInformacion As String
        Dim readerInformacion As SqlDataReader
        consultaInformacion = "select NoExpediente,Juzgado,EtapaProcesal,Actuario,datosSolicitud.id as idDatosSolicitud from legales inner join Solicitud on Legales.idSolicitud = Solicitud.id inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud where legales.id= '" & idCreditoLegal & "'"
        comandoInformacion = New SqlCommand
        comandoInformacion.Connection = conexionempresa
        comandoInformacion.CommandText = consultaInformacion
        readerInformacion = comandoInformacion.ExecuteReader
        If readerInformacion.HasRows Then
            While readerInformacion.Read
                noExpedienteActual = readerInformacion("Noexpediente")
                JuzgadoActual = readerInformacion("Juzgado")
                EtapaProcesalActual = readerInformacion("EtapaProcesal")
                ActuarioActual = readerInformacion("Actuario")
                idDatosSolicitud = readerInformacion("idDatosSolicitud")
            End While
        End If
        readerInformacion.Close()

        Dim comandoDomicilio As SqlCommand
        Dim consultaDomicilio As String
        consultaDomicilio = "select concat('Calle ',DatosSolicitud.Calle,' Número Exterior ',DatosSolicitud.Noext,' Número Interior ',DatosSolicitud.Noint,' Colonia ',DatosSolicitud.Colonia,' Código Postal ',DatosSolicitud.CodigoPostal) as Domicilio from Legales inner join Solicitud on legales.idSolicitud = Solicitud.id inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud where legales.id = '" & idCreditoLegal & "'"
        comandoDomicilio = New SqlCommand
        comandoDomicilio.Connection = conexionempresa
        comandoDomicilio.CommandText = consultaDomicilio
        domicilioActual = comandoDomicilio.ExecuteScalar

    End Sub

    Private Sub BackgroundConsultaInformacion_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundConsultaInformacion.RunWorkerCompleted
        Cargando.Close()
    End Sub

    Private Sub BackgroundActualizacion_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundActualizacion.DoWork

        Dim tiempo As String = TimeOfDay.ToString("HH:mm:ss")
        Select Case ComboTipo.selectedValue
            Case "Domicilio"
                consultaActualizacion = "update datosSolicitud set calle = '" & txtCalle.Text & "',noext = '" & txtNoExt.Text & "',noint = '" & txtNoInt.Text & "',codigopostal = '" & txtCodigoPostal.Text & "',colonia = '" & txtColonia.Text & "' where id = '" & idDatosSolicitud & "'"
            Case "Número de Expediente"
                consultaActualizacion = "update legales set NoExpediente = '" & txtValor.Text & "' where id = '" & idCreditoLegal & "'"
            Case "Juzgado"
                consultaActualizacion = "update legales set Juzgado = '" & txtValor.Text & "' where id = '" & idCreditoLegal & "'"
            Case "Etapa Procesal"
                consultaActualizacion = "update legales set EtapaProcesal = '" & txtValor.Text & "' where id = '" & idCreditoLegal & "'"
            Case "Actuario"
                consultaActualizacion = "update legales set actuario = '" & txtValor.Text & "' where id = '" & idCreditoLegal & "'"
        End Select
        Dim comandoLegalAnterior As SqlCommand
        Dim consultaLegalAnterior As String

        Select Case ComboTipo.selectedValue
            Case "Domicilio"
                NuevoDomicilio = "Calle " & txtCalle.Text & " Número Exterior " & txtNoExt.Text & " Número Interior " & txtNoInt.Text & " Colonia " & txtColonia.Text & " Código Postal " & txtCodigoPostal.Text
                consultaLegalAnterior = "insert into ActualizacionesLegal values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & ComboTipo.selectedValue & "','" & domicilioActual & "','" & NuevoDomicilio & "','" & txtMotivo.Text & "','" & idCreditoLegal & "')"
            Case "Número de Expediente"
                consultaLegalAnterior = "insert into ActualizacionesLegal values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & ComboTipo.selectedValue & "','" & noExpedienteActual & "','" & txtValor.Text & "','" & txtMotivo.Text & "','" & idCreditoLegal & "')"
            Case "Juzgado"
                consultaLegalAnterior = "insert into ActualizacionesLegal values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & ComboTipo.selectedValue & "','" & JuzgadoActual & "','" & txtValor.Text & "','" & txtMotivo.Text & "','" & idCreditoLegal & "')"
            Case "Etapa Procesal"
                consultaLegalAnterior = "insert into ActualizacionesLegal values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & ComboTipo.selectedValue & "','" & EtapaProcesalActual & "','" & txtValor.Text & "','" & txtMotivo.Text & "','" & idCreditoLegal & "')"
            Case "Actuario"
                consultaLegalAnterior = "insert into ActualizacionesLegal values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & ComboTipo.selectedValue & "','" & ActuarioActual & "','" & txtValor.Text & "','" & txtMotivo.Text & "','" & idCreditoLegal & "')"
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
End Class