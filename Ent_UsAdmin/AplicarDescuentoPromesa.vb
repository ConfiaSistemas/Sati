Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class AplicarDescuentoPromesa
    Public Autorizado As Boolean
    Dim cnsEmpresaMysql As String
    Public idPromesa As String
    Public idNotificacion As String
    Dim localRemoto As String
    Dim ipLocalTicket As String
    Dim nombreRemoto As String
    Dim ipRemotoTicket As String
    Dim bdTicket As String
    Dim estadoNotificacion As String
    Dim tipoDoc As String
    Dim nCargando As Cargando
    Dim conectado As Boolean
    Dim aplicado As Boolean
    Private Sub CancelarTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtComentario.BackColor = Me.BackColor
        lblNoTicket.Text = idPromesa
        nCargando = New Cargando
        nCargando.Show()
        nCargando.MonoFlat_Label1.Text = "Consultando estado de notificación"
        nCargando.TopMost = True
        BackgroundVerificaNotificacion.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim conexionLogin As MySqlConnection
        conexionLogin = New MySqlConnection()
        conexionLogin.ConnectionString = "server=www.prestamosconfia.com;user id=ajas;pwd=123456;port=3306;database=USRS"
        conexionLogin.Open()

        Dim comandoComentarioMysql As MySqlCommand
        Dim consultaComentarioMysql As String
        Dim readerComentarioMysql As MySqlDataReader
        consultaComentarioMysql = "select Comentario,Empresa from Notificaciones where id = '" & idNotificacion & "'"
        comandoComentarioMysql = New MySqlCommand
        comandoComentarioMysql.Connection = conexionLogin
        comandoComentarioMysql.CommandText = consultaComentarioMysql
        readerComentarioMysql = comandoComentarioMysql.ExecuteReader
        If readerComentarioMysql.HasRows Then
            While readerComentarioMysql.Read
                txtComentario.Text = readerComentarioMysql("comentario")
                nombreRemoto = readerComentarioMysql("Empresa")
            End While
        End If
        readerComentarioMysql.Close()

        Dim comandoEmpresaMysql As MySqlCommand
        Dim consultaEmpresaMysql As String
        Dim readerEmpresaMysql As MySqlDataReader
        consultaEmpresaMysql = "select IP,BD,IPREMOTA from Empresas where Nombre = '" & nombreRemoto & "'"
        comandoEmpresaMysql = New MySqlCommand
        comandoEmpresaMysql.Connection = conexionLogin
        comandoEmpresaMysql.CommandText = consultaEmpresaMysql
        readerEmpresaMysql = comandoEmpresaMysql.ExecuteReader
        If readerEmpresaMysql.HasRows Then
            While readerEmpresaMysql.Read
                ipLocalTicket = readerEmpresaMysql("IP")
                bdTicket = readerEmpresaMysql("BD")
                ipRemotoTicket = readerEmpresaMysql("IPREMOTA")

            End While
        End If

        readerEmpresaMysql.Close()




        conexionLogin.Close()

        If ProbarConexionEmpresa(ipLocalTicket, bdTicket) Then
            conectado = True
            cnsEmpresaMysql = iniciarconexionRMysql(ipLocalTicket, bdTicket)
        Else
            conectado = ProbarConexionEmpresa(ipRemotoTicket, bdTicket)
            If conectado = True Then
                cnsEmpresaMysql = iniciarconexionRMysql(ipRemotoTicket, bdTicket)
            Else

            End If

        End If


        If conectado Then
        Else

        End If

        Dim conex As SqlConnection
        conex = New SqlConnection(cnsEmpresaMysql)
        conex.Open()


        Dim consultaTicket As String

        consultaTicket = "select credito.nombre,format(subtotal,'C','es-mx') as 'Subtotal',format(Capital,'C','es-mx') as Capital, format(Moratorios,'C','es-mx') as Moratorios, format(Descuento,'C','es-mx') as Descuento,format(montopromesa,'C','es-mx') as 'MontoPromesa',FechaLimite as 'Fecha Límite',promesadepago.Fecha,promesadepago.Hora,promesadepago.Usuario,promesadepago.Estado,TipoCredito as 'Tipo de Crédito' from PromesaDePago inner join credito on promesadepago.idcredito = credito.id where promesadepago.id = '" & idPromesa & "'"

        Dim consultaDetalle As String
        Dim adapterDetalle As SqlDataAdapter
        Dim dataDetalle As DataTable
        adapterDetalle = New SqlDataAdapter(consultaTicket, conex)
        dataDetalle = New DataTable
        adapterDetalle.Fill(dataDetalle)
        dtDetalle.DataSource = dataDetalle


    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        dtDetalle.ScrollBars = ScrollBars.Both
        nCargando.Close()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        AutorizacionNotificacion.tipoAutorizacion = "SatiModCreditosDescuentoPromesa"
        AutorizacionNotificacion.ShowDialog()
        If Autorizado Then
            estadoNotificacion = "A"
            nCargando = New Cargando
            nCargando.Show()
            nCargando.MonoFlat_Label1.Text = "Actualizando notificación"
            BackgroundActNotificacion.RunWorkerAsync()
        Else
            MessageBox.Show("No fue autorizado")
        End If
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        AutorizacionNotificacion.tipoAutorizacion = "SatiModCreditosDescuentoPromesa"
        AutorizacionNotificacion.ShowDialog()
        If Autorizado Then
            estadoNotificacion = "R"
            nCargando = New Cargando
            nCargando.Show()
            nCargando.MonoFlat_Label1.Text = "Actualizando notificación"
            BackgroundActNotificacion.RunWorkerAsync()
        Else
            MessageBox.Show("No fue autorizado")
        End If
    End Sub

    Private Sub BackgroundActNotificacion_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundActNotificacion.DoWork
        Dim conexionLogin As MySqlConnection
        conexionLogin = New MySqlConnection()
        conexionLogin.ConnectionString = "server=www.prestamosconfia.com;user id=ajas;pwd=123456;port=3306;database=USRS"
        conexionLogin.Open()

        If ProbarConexionEmpresa(ipLocalTicket, bdTicket) Then
            conectado = True
            cnsEmpresaMysql = iniciarconexionRMysql(ipLocalTicket, bdTicket)
        Else
            conectado = ProbarConexionEmpresa(ipRemotoTicket, bdTicket)
            If conectado Then
                cnsEmpresaMysql = iniciarconexionRMysql(ipRemotoTicket, bdTicket)
            Else

            End If

        End If
        Dim conex As SqlConnection
        Try

            conex = New SqlConnection(cnsEmpresaMysql)
            conex.Open()
            conectado = True
        Catch ex As Exception
            conectado = False
        End Try



        If estadoNotificacion = "A" Then
            If conectado Then
                Dim comandoActualizaPromesa As SqlCommand
                Dim consultaActualizaPromesa As String
                consultaActualizaPromesa = "update promesadepago set estado = 'A' where id = '" & idPromesa & "'"
                comandoActualizaPromesa = New SqlCommand
                comandoActualizaPromesa.Connection = conex
                comandoActualizaPromesa.CommandText = consultaActualizaPromesa
                comandoActualizaPromesa.ExecuteNonQuery()

                For Each row As DataGridViewRow In dtDetalle.Rows
                    Dim comandoActualizaCalendarioPromesa As SqlCommand
                    Dim consultaActualizaCalendarioPromesa As String
                    Select Case row.Cells(11).Value
                        Case "C"
                            consultaActualizaCalendarioPromesa = "update calendarioconveniossac set convenio = 1 where idpago in ((select idpago from detallepromesa where idpromesa = '" & idPromesa & "'))"
                        Case "R"
                            consultaActualizaCalendarioPromesa = "update calendarioreestructurassac set convenio = 1 where idpago in ((select idpago from detallepromesa where idpromesa = '" & idPromesa & "'))"
                        Case "L"
                            consultaActualizaCalendarioPromesa = "update calendariolegales set convenio = 1 where idpago in ((select idpago from detallepromesa where idpromesa = '" & idPromesa & "'))"
                        Case Else
                            consultaActualizaCalendarioPromesa = "update calendarionormal set convenio = 1 where idpago in ((select idpago from detallepromesa where idpromesa = '" & idPromesa & "'))"
                    End Select
                    comandoActualizaCalendarioPromesa = New SqlCommand
                    comandoActualizaCalendarioPromesa.Connection = conex
                    comandoActualizaCalendarioPromesa.CommandText = consultaActualizaCalendarioPromesa
                    comandoActualizaCalendarioPromesa.ExecuteNonQuery()

                    Exit For
                Next





                Dim comandoComentarioMysql As MySqlCommand
                Dim consultaComentarioMysql As String
                Dim readerComentarioMysql As MySqlDataReader
                consultaComentarioMysql = "update Notificaciones set Aplicado=1, FechaAplicacion= '" & Date.Now.ToString("yyyy-MM-dd") & "',HoraAplicacion='" & Date.Now.ToString("HH:mm:ss") & "',ComentarioUsuarioDestino='" & txtAddComentario.Text & "',Estado = '" & estadoNotificacion & "' where id = '" & idNotificacion & "'"
                comandoComentarioMysql = New MySqlCommand
                comandoComentarioMysql.Connection = conexionLogin
                comandoComentarioMysql.CommandText = consultaComentarioMysql
                comandoComentarioMysql.ExecuteNonQuery()

            Else
                MessageBox.Show("Ha habido un error, inténtelo de nuevo")
            End If

        Else

            Dim comandoActualizaPromesa As SqlCommand
            Dim consultaActualizaPromesa As String
            consultaActualizaPromesa = "update promesadepago set estado = 'R' where id = '" & idPromesa & "'"
            comandoActualizaPromesa = New SqlCommand
            comandoActualizaPromesa.Connection = conex
            comandoActualizaPromesa.CommandText = consultaActualizaPromesa
            comandoActualizaPromesa.ExecuteNonQuery()

            Dim comandoComentarioMysql As MySqlCommand
            Dim consultaComentarioMysql As String
            Dim readerComentarioMysql As MySqlDataReader
            consultaComentarioMysql = "update Notificaciones set Aplicado = 1, FechaAplicacion= '" & Date.Now.ToString("yyyy-MM-dd") & "',HoraAplicacion='" & Date.Now.ToString("HH:mm:ss") & "',ComentarioUsuarioDestino='" & txtAddComentario.Text & "',Estado = '" & estadoNotificacion & "' where id = '" & idNotificacion & "'"
            comandoComentarioMysql = New MySqlCommand
            comandoComentarioMysql.Connection = conexionLogin
            comandoComentarioMysql.CommandText = consultaComentarioMysql
            comandoComentarioMysql.ExecuteNonQuery()
        End If

    End Sub

    Private Sub BackgroundActNotificacion_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundActNotificacion.RunWorkerCompleted
        For i As Integer = CentroDeNotificaciones.FlowLayoutPanel1.Controls.Count - 1 To 0 Step -1
            If TypeOf CentroDeNotificaciones.FlowLayoutPanel1.Controls(i) Is Panel Then
                Dim ctr As Panel = CentroDeNotificaciones.FlowLayoutPanel1.Controls(i)
                If ctr.Name = idNotificacion Then
                    Me.Invoke(Sub()
                                  For a As Integer = frm_adm.array.Count - 1 To 0 Step -1
                                      If ctr.Name = frm_adm.array(a).id Then
                                          frm_adm.array.RemoveAt(a)
                                          frm_adm.CantNotificaciones -= 1
                                          frm_adm.notificaciones.Text = "Tienes " & frm_adm.array.Count & " notificaciones"
                                          frm_adm.notificaciones.Refresh()

                                          Exit For
                                      End If
                                  Next
                              End Sub)

                    CentroDeNotificaciones.FlowLayoutPanel1.Controls.RemoveAt(i)

                End If
            End If
        Next
        nCargando.Close()
        Me.Close()

    End Sub

    Private Sub BackgroundVerificaNotificacion_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundVerificaNotificacion.DoWork
        Dim conexionNotificaciones As MySqlConnection
        conexionNotificaciones = New MySqlConnection()
        conexionNotificaciones.ConnectionString = "server=www.prestamosconfia.com;user id=ajas;pwd=123456;port=3306;database=USRS"
        conexionNotificaciones.Open()

        'Revisar notificaciones no aplicadas


        Dim mysqlcomandoexiste As MySqlCommand
        Dim consultaExiste As String


        consultaExiste = "select Aplicado from Notificaciones where id = '" & idNotificacion & "'"
        mysqlcomandoexiste = New MySqlCommand
        mysqlcomandoexiste.Connection = conexionNotificaciones
        mysqlcomandoexiste.CommandText = consultaExiste
        aplicado = mysqlcomandoexiste.ExecuteScalar



    End Sub

    Private Sub BackgroundVerificaNotificacion_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundVerificaNotificacion.RunWorkerCompleted
        If aplicado Then
            nCargando.Close()
            Me.Invoke(Sub()
                          Dim nAlertas As New Alertas


                          nAlertas.cadena = "La notificación ya fue eliminada"
                          For i As Integer = CentroDeNotificaciones.FlowLayoutPanel1.Controls.Count - 1 To 0 Step -1
                              If TypeOf CentroDeNotificaciones.FlowLayoutPanel1.Controls(i) Is Panel Then
                                  Dim ctr As Panel = CentroDeNotificaciones.FlowLayoutPanel1.Controls(i)
                                  If ctr.Name = idNotificacion Then
                                      Me.Invoke(Sub()
                                                    For a As Integer = frm_adm.array.Count - 1 To 0 Step -1
                                                        If ctr.Name = frm_adm.array(a).id Then
                                                            frm_adm.array.RemoveAt(a)
                                                            frm_adm.CantNotificaciones -= 1
                                                            frm_adm.notificaciones.Text = "Tienes " & frm_adm.array.Count & " notificaciones"
                                                            frm_adm.notificaciones.Refresh()

                                                            Exit For
                                                        End If
                                                    Next
                                                End Sub)

                                      CentroDeNotificaciones.FlowLayoutPanel1.Controls.RemoveAt(i)

                                  End If
                              End If
                          Next



                          ' frm_adm.array.RemoveAt(a)
                          nAlertas.ShowDialog()
                          nAlertas.TopMost = True
                      End Sub)


            Me.Close()
        Else
            dtDetalle.ScrollBars = ScrollBars.None
            BackgroundWorker1.RunWorkerAsync()

        End If
    End Sub



    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub
End Class