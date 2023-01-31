Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Threading.Tasks

Public Class CreditosAsociadosActualizarCliente
    Public dataCreditos As DataTable
    Public nombre As String
    Public aPaterno As String
    Public aMaterno As String
    Public Curp As String
    Public telefono As String
    Public Celular As String
    Public valorAnterior As String
    Public idCliente As String
    Public EstadoValidacionCurp As String
    Public ValidadoCurp As Boolean
    Public FechaNacimiento As Date
    Public Autorizado As Boolean
    Dim idActualizacion As String
    Dim err As Boolean
    Dim ncargando As Cargando
    Public creada As Boolean
    Dim existeActualizacion As String
    Private Sub CreditosAsociadosActualizarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtdatos.DataSource = dataCreditos
        btn_agregar.Enabled = False

        ncargando = New Cargando
        ncargando.MonoFlat_Label1.Text = "Consultando información"
        ncargando.Show()

        BackgroundConsultarActualizacion.RunWorkerAsync()


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        btn_agregar.Enabled = False

        For Each row As DataRow In dataPermisos.Rows
            If row("SatiModCreditosModificar") Then
                Autorizacion.tipoAutorizacion = "SatiModCreditosModificar"
                Autorizacion.ShowDialog()
                If Autorizado Then
                    ncargando = New Cargando

                    ncargando.MonoFlat_Label1.Text = "Actualizando cliente"
                    ncargando.Show()
                    BackgroundActualizar.RunWorkerAsync()
                Else
                    MessageBox.Show("No fue autorizado")
                End If
                Exit For
            Else
                If MessageBox.Show("¿No cuenta con los permisos, desea notificar a un usuario?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    ncargando = New Cargando
                    ncargando.MonoFlat_Label1.Text = "Creando actualización"
                    ncargando.Show()
                    BackgroundActualizarCnotificacion.RunWorkerAsync()


                End If
            End If
        Next
    End Sub

    Private Sub BackgroundActualizar_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundActualizar.DoWork
        Try
            iniciarconexionempresa()

            Dim comandoActualizar As SqlCommand
            Dim consultaActualizar As String

            consultaActualizar = "INSERT INTO [dbo].[ActualizacionesClientes]
          
     VALUES
           (" & idCliente & "
           ,'" & nombre & "'
           ,'" & aPaterno & "'
           ,'" & aMaterno & "'
           ,'" & Curp & "'
           ,'" & EstadoValidacionCurp & "'
           ,'" & ValidadoCurp & "'
           ,'" & telefono & "'
           ,'" & Celular & "'
           ,'" & FechaNacimiento.ToString("yyyy-MM-dd") & "'
           ,'" & dtdatos.Rows(dtdatos.CurrentRow.Index).Cells(0).Value & "'
           ,'" & valorAnterior & "'
           ,GETDATE()
           ,GETDATE()
           ,'" & nmusr & "'
           ,''
           ,''
           ,''
           ,'E','0') Select SCOPE_IDENTITY()"
            comandoActualizar = New SqlCommand
            comandoActualizar.Connection = conexionempresa
            comandoActualizar.CommandText = consultaActualizar
            idActualizacion = comandoActualizar.ExecuteScalar

            Dim comandoProdActualizar As SqlCommand
            Dim consultaProdActualizar As String
            consultaProdActualizar = "ActualizarCliente"
            comandoProdActualizar = New SqlCommand
            comandoProdActualizar.Connection = conexionempresa
            comandoProdActualizar.CommandText = consultaProdActualizar

            comandoProdActualizar.CommandType = CommandType.StoredProcedure
            comandoProdActualizar.Parameters.AddWithValue("idActualizacion", idActualizacion)
            comandoProdActualizar.Parameters.AddWithValue("usr", nmusr)
            comandoProdActualizar.ExecuteNonQuery()
            err = False


        Catch ex As Exception
            err = True
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub BackgroundActualizar_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundActualizar.RunWorkerCompleted
        ncargando.Close()

        If err Then
            MessageBox.Show("Hubo un error inténtalo de nuevo")
        Else
            MessageBox.Show("Actualizado con éxito")
            Me.Close()

        End If
        btn_agregar.Enabled = True

    End Sub

    Private Sub BackgroundActualizarCnotificacion_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundActualizarCnotificacion.DoWork
        iniciarconexionempresa()

        Dim comandoActualizar As SqlCommand
        Dim consultaActualizar As String

        consultaActualizar = "INSERT INTO [dbo].[ActualizacionesClientes]
          
     VALUES  (" & idCliente & ",'" & nombre & "','" & aPaterno & "','" & aMaterno & "','" & Curp & "','" & EstadoValidacionCurp & "','" & ValidadoCurp & "','" & telefono & "','" & Celular & "','" & FechaNacimiento.ToString("yyyy-MM-dd") & "','" & dtdatos.Rows(dtdatos.CurrentRow.Index).Cells(0).Value & "','" & valorAnterior & "',GETDATE(),GETDATE(),'" & nmusr & "','','','','E','0'); Select SCOPE_IDENTITY()"
        comandoActualizar = New SqlCommand
        comandoActualizar.Connection = conexionempresa
        comandoActualizar.CommandText = consultaActualizar
        idActualizacion = comandoActualizar.ExecuteScalar
    End Sub

    Private Sub BackgroundActualizarCnotificacion_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundActualizarCnotificacion.RunWorkerCompleted
        ncargando.Close()
        CrearNotificacionActualizarCliente.idActualizacion = idActualizacion
        '  CrearNotificacionDescuentoPromesa.tipoCredito = TipoCredito
        CrearNotificacionActualizarCliente.ShowDialog()

        If creada Then
            Task.Factory.StartNew(Sub()
                                      Dim comandoActualizaPromesa As SqlCommand
                                      Dim consultaActualizaPromesa As String
                                      consultaActualizaPromesa = "update ActualizacionesClientes set notificado = 1 where id = '" & idActualizacion & "'"
                                      comandoActualizaPromesa = New SqlCommand
                                      comandoActualizaPromesa.Connection = conexionempresa
                                      comandoActualizaPromesa.CommandText = consultaActualizaPromesa
                                      comandoActualizaPromesa.ExecuteNonQuery()


                                  End Sub)
            Me.Close()
        Else
            If MessageBox.Show("¿La notificación no fue creada, desea volver a intentarlo?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                CrearNotificacionActualizarCliente.idActualizacion = idActualizacion
                'CrearNotificacionDescuentoPromesa.tipoCredito = TipoCredito
                CrearNotificacionActualizarCliente.ShowDialog()
                If creada Then
                    Task.Factory.StartNew(Sub()
                                              Dim comandoActualizaPromesa As SqlCommand
                                              Dim consultaActualizaPromesa As String
                                              consultaActualizaPromesa = "update ActualizacionesClientes set notificado = 1 where id = '" & idActualizacion & "'"
                                              comandoActualizaPromesa = New SqlCommand
                                              comandoActualizaPromesa.Connection = conexionempresa
                                              comandoActualizaPromesa.CommandText = consultaActualizaPromesa
                                              comandoActualizaPromesa.ExecuteNonQuery()


                                          End Sub)
                    Me.Close()
                Else
                    MessageBox.Show("La notificación no fue creada, puedes intentarlo más tarde")
                    Me.Close()

                End If
            Else
                Me.Close()
            End If

        End If
        btn_agregar.Enabled = True


    End Sub

    Private Sub BackgroundConsultarActualizacion_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundConsultarActualizacion.DoWork
        iniciarconexionempresa()
        Dim consultaActualizacion As String
        consultaActualizacion = " if exists(Select * from actualizacionesClientes where idcliente = '" & idCliente & "' and estado = 'E' and notificado = 0)
							begin
							 select 'Pendiente'
							end
							else if exists(select * from actualizacionesClientes where idcliente = '" & idCliente & "' and estado = 'E' and Notificado = 1)
                            begin
                             Select 'Notificado'
                            end
                            else
							select 'Noexiste'
"


        Dim comandoActualizacion As SqlCommand
        comandoActualizacion = New SqlCommand
        comandoActualizacion.Connection = conexionempresa
        comandoActualizacion.CommandText = consultaActualizacion
        existeActualizacion = comandoActualizacion.ExecuteScalar
    End Sub

    Private Sub BackgroundConsultarActualizacion_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundConsultarActualizacion.RunWorkerCompleted
        ncargando.Close()

        If existeActualizacion = "Existe" Then

            MessageBox.Show("El crédito ya cuenta con una actualización activa")
            Me.Close()
        ElseIf existeActualizacion = "Pendiente" Then
            MessageBox.Show("El cliente cuenta con una actualización pendiente de notificar, se intentará notificar de nuevo")

            ncargando = New Cargando
            ncargando.Show()
            ncargando.MonoFlat_Label1.Text = "Consultando Actualización"
            ncargando.TopMost = True
            BackgroundConsultarActualizacionPendiente.RunWorkerAsync()

        ElseIf existeActualizacion = "Notificado" Then
            MessageBox.Show("El cliente cuenta con una notificación pendiente de autorizar")
            Me.Close()
        Else
            btn_agregar.Enabled = True


        End If
    End Sub

    Private Sub BackgroundConsultarActualizacionPendiente_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundConsultarActualizacionPendiente.DoWork
        iniciarconexionempresa()
        Dim consultaActualizacion As String
        consultaActualizacion = "select id from actualizacionesClientes where idcliente = '" & idCliente & "' and estado = 'E' and notificado = 0"
        Dim comandoActualizacion As SqlCommand
        comandoActualizacion = New SqlCommand
        comandoActualizacion.Connection = conexionempresa
        comandoActualizacion.CommandText = consultaActualizacion
        idActualizacion = comandoActualizacion.ExecuteScalar
    End Sub

    Private Sub BackgroundConsultarActualizacionPendiente_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundConsultarActualizacionPendiente.RunWorkerCompleted
        ncargando.Close()
        CrearNotificacionActualizarCliente.idActualizacion = idActualizacion
        '  CrearNotificacionDescuentoPromesa.tipoCredito = TipoCredito
        CrearNotificacionActualizarCliente.ShowDialog()

        If creada Then
            Task.Factory.StartNew(Sub()
                                      Dim comandoActualizaPromesa As SqlCommand
                                      Dim consultaActualizaPromesa As String
                                      consultaActualizaPromesa = "update ActualizacionesClientes set notificado = 1 where id = '" & idActualizacion & "'"
                                      comandoActualizaPromesa = New SqlCommand
                                      comandoActualizaPromesa.Connection = conexionempresa
                                      comandoActualizaPromesa.CommandText = consultaActualizaPromesa
                                      comandoActualizaPromesa.ExecuteNonQuery()


                                  End Sub)
            Me.Close()
        Else
            If MessageBox.Show("¿La notificación no fue creada, desea volver a intentarlo?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                CrearNotificacionActualizarCliente.idActualizacion = idActualizacion
                'CrearNotificacionDescuentoPromesa.tipoCredito = TipoCredito
                CrearNotificacionActualizarCliente.ShowDialog()
                If creada Then
                    Task.Factory.StartNew(Sub()
                                              Dim comandoActualizaPromesa As SqlCommand
                                              Dim consultaActualizaPromesa As String
                                              consultaActualizaPromesa = "update ActualizacionesClientes set notificado = 1 where id = '" & idActualizacion & "'"
                                              comandoActualizaPromesa = New SqlCommand
                                              comandoActualizaPromesa.Connection = conexionempresa
                                              comandoActualizaPromesa.CommandText = consultaActualizaPromesa
                                              comandoActualizaPromesa.ExecuteNonQuery()


                                          End Sub)
                    Me.Close()
                Else
                    MessageBox.Show("La notificación no fue creada, puedes intentarlo más tarde")
                    Me.Close()

                End If
            Else
                Me.Close()
            End If

        End If
    End Sub
End Class