Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class ActInformacionEmpeño

    Public idEmpeño As String
    Dim domicilioActual As String
    Dim noExpedienteActual As String
    Dim JuzgadoActual As String
    Dim EtapaProcesalActual As String
    Dim ActuarioActual As String
    Dim consultaActualizacion As String
    Dim idSolicitud As String
    Dim idSolicitudBoleta As String
    Dim NuevoDomicilio As String
    Dim datosSolicitud As DataTable
    Dim adapterDatosSolicitud As SqlDataAdapter
    Dim newCargando As Cargando

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

    Private Sub ActInformacionEmpeño_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        ComboTipo.selectedIndex = 0
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando Información..."
        BackgroundConsultaInformacion.RunWorkerAsync()

    End Sub

    Private Sub BackgroundConsultaInformacion_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundConsultaInformacion.DoWork
        iniciarconexionempresa()


        Dim consultaInformacion As String

        consultaInformacion = "select SolicitudBoleta.id,SolicitudBoleta.Nombre,SolicitudBoleta.Domicilio,Telefono,SolicitudBoleta.INE,CURP from SolicitudBoleta inner join empeños on empeños.idSolicitudBoleta = SolicitudBoleta.id where Empeños.id = '" & idEmpeño & "'"


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
        Try
            Dim tiempo As String = TimeOfDay.ToString("HH:mm:ss")
            idSolicitudBoleta = ObteneridDatosSolicitud(ComboCliente.selectedValue)
            Select Case ComboTipo.selectedValue
                Case "Domicilio"
                    consultaActualizacion = "update SolicitudBoleta set Domicilio = '" & txtDomicilio.Text & "',CodigoPostal = '" & txtCodigoPostal.Text & "',Colonia = '" & txtColonia.Text & "',Municipio = '" & txtCiudad.Text & "',Entidad = '" & txtEstado.Text & "' where id = '" & idSolicitudBoleta & "'"
                Case "Número de Teléfono"
                    consultaActualizacion = "update SolicitudBoleta set telefono = '" & txtValor.Text & "' where id = '" & idSolicitudBoleta & "'"
                Case "Nombre"
                    consultaActualizacion = "update SolicitudBoleta set Nombre = '" & txtValor.Text & "' where id = '" & idSolicitudBoleta & "'
                                        update Empeños set Nombre = '" & txtValor.Text & "' where idSolicitudBoleta = '" & idSolicitudBoleta & "'"
                Case "CURP"
                    consultaActualizacion = "update SolicitudBoleta set CURP = '" & txtValor.Text & "' where id = '" & idSolicitudBoleta & "'"
                Case "INE"
                    consultaActualizacion = "update SolicitudBoleta set INE = '" & txtValor.Text & "' where id = '" & idSolicitudBoleta & "'
                                        update Empeños set INE ='" & txtValor.Text & "' where idSolicitudBoleta='" & idSolicitudBoleta & "'"
            End Select
            Dim comandoEmpeñoAnterior As SqlCommand
            Dim consultaEmpeñoAnterior As String
            Dim valorAnteriorStr As String

            Select Case ComboTipo.selectedValue
                Case "Domicilio"
                    valorAnteriorStr = ValorAnterior(ComboTipo.selectedValue, idSolicitudBoleta)
                    NuevoDomicilio = "Domicilio " & txtDomicilio.Text & " Código Postal " & txtCodigoPostal.Text & " Colonia " & txtColonia.Text & " Estado " & txtEstado.Text & " Ciudad " & txtCiudad.Text
                    consultaEmpeñoAnterior = $"insert into ActualizacionesEmpeño values('{idEmpeño}','{Now.ToString("yyyy-MM-dd")}','{tiempo}','{ComboTipo.selectedValue}','{valorAnteriorStr}','{NuevoDomicilio}','{txtMotivo.Text}')"
                Case "Número de Teléfono"
                    valorAnteriorStr = ValorAnterior(ComboTipo.selectedValue, idSolicitudBoleta)
                    consultaEmpeñoAnterior = $"insert into ActualizacionesEmpeño values('{idEmpeño}','{Now.ToString("yyyy-MM-dd")}','{tiempo}','{ComboTipo.selectedValue}','{valorAnteriorStr}','{txtValor.Text}','{txtMotivo.Text}')"
                Case "Nombre"
                    valorAnteriorStr = ValorAnterior(ComboTipo.selectedValue, idSolicitudBoleta)
                    consultaEmpeñoAnterior = $"insert into ActualizacionesEmpeño values('{idEmpeño}','{Now.ToString("yyyy-MM-dd")}','{tiempo}','{ComboTipo.selectedValue}','{valorAnteriorStr}','{txtValor.Text}','{txtMotivo.Text}')"
                Case "CURP"
                    valorAnteriorStr = ValorAnterior(ComboTipo.selectedValue, idSolicitudBoleta)
                    consultaEmpeñoAnterior = $"insert into ActualizacionesEmpeño values('{idEmpeño}','{Now.ToString("yyyy-MM-dd")}','{tiempo}','{ComboTipo.selectedValue}','{valorAnteriorStr}','{txtValor.Text}','{txtMotivo.Text}')"
                Case "INE"
                    valorAnteriorStr = ValorAnterior(ComboTipo.selectedValue, idSolicitudBoleta)
                    consultaEmpeñoAnterior = $"insert into ActualizacionesEmpeño values('{idEmpeño}','{Now.ToString("yyyy-MM-dd")}','{tiempo}','{ComboTipo.selectedValue}','{valorAnteriorStr}','{txtValor.Text}','{txtMotivo.Text}')"
            End Select
            'consultaLegalAnterior = "insert into ActualizacionLegal values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & ComboTipo.selectedValue & "','" &  & "')"
            comandoEmpeñoAnterior = New SqlCommand
            comandoEmpeñoAnterior.Connection = conexionempresa
            comandoEmpeñoAnterior.CommandText = consultaEmpeñoAnterior
            comandoEmpeñoAnterior.ExecuteNonQuery()


            Dim comandoAct As SqlCommand
            comandoAct = New SqlCommand
            comandoAct.Connection = conexionempresa
            comandoAct.CommandText = consultaActualizacion
            comandoAct.ExecuteNonQuery()

        Catch a As Exception
            newCargando.Close()
            MessageBox.Show(a.ToString)
        End Try

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If txtMotivo.Text <> "" Then
            newCargando = New Cargando
            newCargando.Show()
            newCargando.MonoFlat_Label1.Text = "Actualizando Información..."
            newCargando.TopMost = True
            BackgroundActualizacion.RunWorkerAsync()
        Else
            MessageBox.Show("El campo de motivo es obligatorio")
        End If
    End Sub

    Private Sub BackgroundActualizacion_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundActualizacion.RunWorkerCompleted
        newCargando.Close()
        Me.Close()
    End Sub

    Private Function ObteneridDatosSolicitud(Nombre As String) As String
        Dim datosSolicitudId As String
        For Each row As DataRow In datosSolicitud.Rows
            If row("nombre").ToString = Nombre Then
                datosSolicitudId = row("id")
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
                    If row("id").ToString = aquien Then
                        retorno = row("Domicilio").ToString
                        Exit For
                    End If
                Case "Número de Teléfono"
                    If row("id").ToString = aquien Then
                        retorno = row("Telefono").ToString
                        Exit For
                    End If
                Case "Nombre"
                    If row("id").ToString = aquien Then
                        retorno = row("Nombre").ToString
                        Exit For
                    End If
                Case "CURP"
                    If row("id").ToString = aquien Then
                        retorno = row("CURP").ToString
                        Exit For
                    End If
                Case "INE"
                    If row("id").ToString = aquien Then
                        retorno = row("INE").ToString
                        Exit For
                    End If
            End Select
        Next
        Return retorno
    End Function
End Class