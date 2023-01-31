Imports System.ComponentModel
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class frm_adm
    Dim ventana As New Form
    Public abierto As Boolean = False
    Dim widthmenu As Integer = 0
    Dim widthmenubool As Boolean = False
    Dim widthmenuperfilbool As Boolean = False
    Dim sizeventanas As Size
    Dim op As Double = 0
    Public cerrarEmpresa As Boolean
    Public mostrarpanelsecundario As Boolean = False
    Public cerrarSesion As Boolean
    Public cerrandoSesion As Boolean
    Public cerrandoEmpresa As Boolean
    Dim hayActualizacion As Boolean
    Dim actualizar As Boolean
    Public array As ArrayList = New ArrayList
    Friend conexionsql As MySqlConnection
    Public CantNotificaciones As Integer = 0
    Dim music As String = "C:\ConfiaAdmin\NOTIFICACION.wav" ' *.wav file location
    Dim media As New Media.SoundPlayer(music)

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Interval = 150


        Timer1.Start()
        Me.Opacity = op
        If op < 1 Then
            op = op + 0.1
            Me.Opacity = op

            'MessageBox.Show(Str(op))
        Else
            op = 0
            Timer1.Stop()
            Timer1.Enabled = False


        End If
    End Sub

    Private Sub frm_adm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If imgstrusr = "" Then
            imgperfil.Image = ConfiaAdmin.My.Resources.Resources.usuario
        Else
            imgperfil.Image = bitmapimgusr
        End If
    End Sub

    Private Sub frm_adm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'perfilalt.Close()

    End Sub

    Private Sub frm_adm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Try
            Timer2.Stop()
            CierraEmpresa.Close()
            perfilalt.Close()
            abierto = False
            If actualizar Then
            Else

                If cerrarSesion Then
                            If cerrarEmpresa Then
                                If MessageBox.Show("¿Está seguro que desea cerrar la empresa?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                    perfilalt.TopMost = False

                            'Application.ExitThread()
                            Empresas.Show()
                                    cerrarSesion = False
                                    cerrandoSesion = True
                                    ' Dim i As Integer = 0
                                    'i = Application.OpenForms.Count
                                    ' For a As Integer = 0 To i
                                    'Dim frm As Form
                                    'frm = New Form
                                    'frm = Application.OpenForms.Item(a)
                                    'If frm.Name <> "login" And frm.Name <> Me.Name Then
                                    'frm.Close()
                                    'End If
                                    'Next

                                    Dim num_controles As Integer = Application.OpenForms.Count - 1
                                    For n As Integer = num_controles To 0 Step -1
                                        Dim ctrl As Form = Application.OpenForms.Item(n)
                                        If ctrl.Name <> "Empresas" And ctrl.Name <> Me.Name Then
                                            ctrl.Close()
                                        End If

                                        'ctrl.Dispose()
                                    Next

                                    Me.Close()

                                Else
                                    cerrarSesion = False

                                    e.Cancel = True

                                End If
                            Else
                                If MessageBox.Show("¿Está seguro que desea cerrar sesión?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                    perfilalt.TopMost = False
                                    Dim conexionSesion As MySqlConnection
                                    conexionSesion = New MySqlConnection()
                                    conexionSesion.ConnectionString = "server=www.prestamosconfia.com;user id=ajas;pwd=123456;port=3306;database=USRS"
                                    conexionSesion.Open()
                                    Dim comandoActSesion As MySqlCommand
                                    Dim consultaActSesion As String
                                    consultaActSesion = "update Sesiones set Activo = 0 where id = '" & idSesion & "'"
                                    comandoActSesion = New MySqlCommand
                                    comandoActSesion.Connection = conexionSesion
                                    comandoActSesion.CommandText = consultaActSesion
                                    comandoActSesion.ExecuteNonQuery()
                                    conexionSesion.Close()
                                    'Application.ExitThread()
                                    login.Show()
                                    cerrarSesion = False
                                    cerrandoSesion = True
                                    ' Dim i As Integer = 0
                                    'i = Application.OpenForms.Count
                                    ' For a As Integer = 0 To i
                                    'Dim frm As Form
                                    'frm = New Form
                                    'frm = Application.OpenForms.Item(a)
                                    'If frm.Name <> "login" And frm.Name <> Me.Name Then
                                    'frm.Close()
                                    'End If
                                    'Next

                                    Dim num_controles As Integer = Application.OpenForms.Count - 1
                                    For n As Integer = num_controles To 0 Step -1
                                        Dim ctrl As Form = Application.OpenForms.Item(n)
                                        If ctrl.Name <> "login" And ctrl.Name <> Me.Name Then
                                            ctrl.Close()
                                        End If

                                        'ctrl.Dispose()
                                    Next

                                    Me.Close()

                                Else
                                    cerrarSesion = False

                                    e.Cancel = True

                                End If
                            End If

                        Else
                            If cerrandoSesion Then
                                'MessageBox.Show("hola")
                            Else
                                'MessageBox.Show("hola")
                                If MessageBox.Show("¿Está seguro que desea salir?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                    perfilalt.TopMost = False
                                    Dim conexionSesion As MySqlConnection
                                    conexionSesion = New MySqlConnection()
                                    conexionSesion.ConnectionString = "server=www.prestamosconfia.com;user id=ajas;pwd=123456;port=3306;database=USRS"
                                    conexionSesion.Open()
                                    Dim comandoActSesion As MySqlCommand
                                    Dim consultaActSesion As String
                                    consultaActSesion = "update Sesiones set Activo = 0 where id = '" & idSesion & "'"
                                    comandoActSesion = New MySqlCommand
                                    comandoActSesion.Connection = conexionSesion
                                    comandoActSesion.CommandText = consultaActSesion
                                    comandoActSesion.ExecuteNonQuery()
                                    conexionSesion.Close()
                                    Application.ExitThread()



                                Else
                                    e.Cancel = True

                                End If
                            End If

                        End If
                    End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub frm_adm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Control + Keys.L Then
            login.bloqueado = True
            login.ShowDialog()
        End If

        If e.KeyData = Keys.Control + Keys.R Then

            Run.ShowDialog()
        End If

    End Sub
    Private sqlDependency As SqlDependency
    Private Sub frm_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        TimerActualizacion.Interval = 60000
        TimerActualizacion.Enabled = True
        TimerActualizacion.Start()
        TimerNotificaciones.Interval = 10000
        TimerNotificaciones.Enabled = True
        TimerNotificaciones.Start()
        TimerActSesion.Interval = 60000
        TimerActSesion.Enabled = True
        TimerActSesion.Start()
        DoubleBuffered = True

        TimerLiberar.Enabled = True
        TimerLiberar.Start()

        For Each row As DataRow In dataPermisos.Rows





            If row("SatiModSolicitudes") Then
                BunifuFlatButton3.Enabled = True
            Else
                BunifuFlatButton3.Enabled = False
            End If

            If row("SatiModCreditos") Then
                BunifuFlatButton4.Enabled = True
            Else
                BunifuFlatButton4.Enabled = False
            End If

            If row("SatiModReportes") Then
                BunifuFlatButton8.Enabled = True
            Else
                BunifuFlatButton8.Enabled = False
            End If
            If row("SatiModEmpeñosAgregarSolicitud") Then
                MonoFlat_Button1.Visible = True
                MonoFlat_Button2.Visible = True
            Else
                MonoFlat_Button1.Visible = False
                MonoFlat_Button2.Visible = False

            End If
        Next

        FlushMemory()
        Me.Text = "SATI" & " - " & nombreAmostrar
        sizeventanas = New Size(Me.Width - panelmenus.Width - 20, Me.Height - Panel1.Height - 43)
        If imgstrusr = "" Then
            imgperfil.Image = ConfiaAdmin.My.Resources.Resources.usuario
        Else
            imgperfil.Image = bitmapimgusr
        End If

        notificaciones.Text = "Tienes " & array.Count & " notificaciones"
        notificaciones.Refresh()

        Timer1.Enabled = True
        Timer2.Enabled = True


        Me.Opacity = 0
        inicio.MdiParent = Me

        inicio.Height = Me.Height - Panel1.Height - 10
        inicio.Width = Me.Width - panelmenus.Width + 1000
        inicio.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        inicio.AutoScroll = False

        inicio.Location = New Point(panelmenus.Width + 10, Panel1.Height + 10)
        inv.Height = Me.Height - Panel1.Height
        inv.Width = Me.Width - panelmenus.Width
        panelmenus.Width = 0


        inv.AutoScroll = False
        inicio.Show()
        ventana.Name = inicio.Name
        acomodar()
        ' inicio.Panelsecundario.BackColor = Color.FromArgb(0, 100, 100, 100)
        inicio.Panelsecundario.Left = panelusuarios.Width + Panelconfiguracion.Width + BunifuImageButton1.Width + 10
        inicio.Panelsecundario.Top = 0
        If BunifuImageButton1.Width + panelusuarios.Width + Panelconfiguracion.Width + Panel3.Width + Panel4.Width + notificaciones.Width + imgperfil.Width + 30 > Panel1.Width Then




            imgmostrarpanel.Visible = True




        Else



            imgmostrarpanel.Visible = False





        End If
        imgmostrarpanel.Left = panelusuarios.Width + Panelconfiguracion.Width + BunifuImageButton1.Width + 12 + Panel4.Width
        imgmostrarpanel.Top = panelusuarios.Top
    End Sub

    Private Sub frm_adm_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LocationChanged
        perfilalt.SetDesktopLocation(Me.Location.X + Me.Width - perfilalt.Width, Me.Location.Y + Panel1.Height + 20)
    End Sub

    Private Sub frm_adm_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        perfilalt.TopMost = False
    End Sub

    Private Sub OnChange(sender As Object, e As EventArgs)
        notificaciones.Text = "Tienes una notificación"
    End Sub



    Private Sub frm_adm_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        'inicio.Height = Me.Height - Panel1.Height
        ' inicio.Width = Me.Width - panelmenus.Width
        'inv.Height = Me.Height - Panel1.Height - 43
        'inv.Width = Me.Width - panelmenus.Width - 20
        ' ventana.Height = Me.Height - Panel1.Height - 43
        ' ventana.Width = Me.Width - panelmenus.Width - 20
        acomodar()
        imgperfil.Left = Panel1.Width - imgperfil.Width - 10
        notificaciones.Left = Panel1.Width - imgperfil.Width - 10 - notificaciones.Width
        perfilalt.SetDesktopLocation(Me.Location.X + Me.Width - perfilalt.Width, Me.Location.Y + Panel1.Height + 20)
        If BunifuImageButton1.Width + panelusuarios.Width + Panelconfiguracion.Width + Panel3.Width + Panel4.Width + notificaciones.Width + imgperfil.Width + 30 > Panel1.Width Then



            Panel4.Visible = False
            'inicio.Panelsecundario.Visible = True
            imgmostrarpanel.Visible = True




        Else


            Panel4.Visible = True
            inicio.Panelsecundario.Visible = False
            mostrarpanelsecundario = False
            imgmostrarpanel.Visible = False
            imgmostrarpanel.Image = ConfiaAdmin.My.Resources.Resources.mostrar1
            imgmostrarpanel.BackColor = Color.FromArgb(51, 0, 204)


        End If
    End Sub

    Private Sub BunifuFlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton2.Click
        BunifuFlatButton2.Textcolor = Color.White

        For Each row As DataRow In dataPermisos.Rows
            If row("SatiModCatalogos") Then
                For Each frmForm As Form In My.Application.OpenForms


                    If frmForm.Name = ventana.Name Then
                        frmForm.Close()
                        Exit For
                    End If
                Next
                ventana.Name = inv.Name

                inv.MdiParent = Me
                inv.Height = Me.Height - Panel1.Height
                inv.Width = Me.Width - panelmenus.Width


                inv.Top = 0
                inv.Left = 0
                inv.Show()
                inv.Top = 0
                inv.Left = 0
                inv.Height = Me.Height - Panel1.Height - 43
                inv.Width = Me.Width - panelmenus.Width - 20
                'inv.Size = sizeventanas
                inv.Show()

                If inv.Top > 0 Then
                    inv.Top = 0

                End If
                inv.Update()
            Else

            End If
        Next

        BunifuFlatButton1.Textcolor = Color.Black
        BunifuFlatButton3.Textcolor = Color.Black
        BunifuFlatButton4.Textcolor = Color.Black
        BunifuFlatButton8.Textcolor = Color.Black
        BunifuFlatButton5.Textcolor = Color.Black


    End Sub

    Private Sub BunifuFlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton1.Click
        BunifuFlatButton1.Textcolor = Color.White

        For Each frmForm As Form In My.Application.OpenForms


            If frmForm.Name = ventana.Name Then
                frmForm.Close()
                Exit For
            End If
        Next
        ventana.Name = inicio.Name
        inicio.MdiParent = Me
        inicio.Height = Me.Height - Panel1.Height - 43
        inicio.Width = Me.Width - panelmenus.Width - 20


        inicio.Top = 0
        inicio.Left = 0
        inicio.Show()
        inicio.Top = 0
        inicio.Left = 0
        ' inicio.Height = Me.Height - Panel1.Height + 1
        'inicio.Width = Me.Width - panelmenus.Width + 1

        inicio.Show()

        If inicio.Top > 0 Then
            inicio.Top = 0

        End If

        BunifuFlatButton2.Textcolor = Color.Black
        BunifuFlatButton3.Textcolor = Color.Black
        BunifuFlatButton4.Textcolor = Color.Black
        BunifuFlatButton8.Textcolor = Color.Black
        BunifuFlatButton5.Textcolor = Color.Black
    End Sub

    Private Sub BunifuImageButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuImageButton1.Click
        'If panelmenus.Width = 258 Then
        'antes era width 51

        'panelmenus.Width = 0
        'acomodar()
        'Else
        'panelmenus.Width = 258
        'acomodar()

        'End If
        If widthmenubool = False Then
            BunifuImageButton1.BackColor = Color.FromArgb(0, 0, 153)
            Timerwidthmas.Enabled = True
            Timerwidthmenos.Enabled = False
        Else
            BunifuImageButton1.BackColor = Color.FromArgb(51, 0, 204)
            Timerwidthmenos.Enabled = True
            Timerwidthmas.Enabled = False


        End If
    End Sub
    Public Sub acomodar()
        For Each vent As Form In My.Application.OpenForms

            If vent.Name = ventana.Name Then
                ' vent.Height = Me.Height - Panel1.Height
                'vent.Width = Me.Width - panelmenus.Width
                vent.Height = Me.Height - Panel1.Height - 43
                vent.Width = Me.Width - panelmenus.Width - 20
            End If

        Next


    End Sub



    Private Sub imgperfil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgperfil.Click

        perfilalt.SetDesktopLocation(Me.Location.X + Me.Width - perfilalt.Width, Me.Location.Y + Panel1.Height + 20)
        If abierto = False Then
            perfilalt.Show()
            Timer2.Start()

            perfilalt.SetDesktopLocation(Me.Location.X + Me.Width - perfilalt.Width, Me.Location.Y + Panel1.Height + 20)
            abierto = True

        Else
            perfilalt.TopMost = False
            Timer2.Stop()

            perfilalt.Close()
            abierto = False


        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Timer2.Interval = 1
        Timer2.Start()
        If Me IsNot ActiveForm Then
            perfilalt.TopMost = False


        Else
            perfilalt.TopMost = True

        End If
    End Sub


    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timerwidthmenos.Tick
        ' If panelmenus.Width = 258 Then
        'antes era width 51

        'panelmenus.Width = 0
        'acomodar()
        'End If

        'If panelmenus.Width < 258 Then
        'panelmenus.Width = 258
        'acomodar()

        'End If

        Timerwidthmenos.Interval = 1
        sizeventanas = New Size(Me.Width - panelmenus.Width - 20, Me.Height - Panel1.Height - 43)
        panelmenus.Enabled = False
        panelmenus.Width = widthmenu
        If panelmenus.Width > 0 Then
            widthmenu = widthmenu - 10
            inicio.Panelsecundario.Left = panelusuarios.Width + Panelconfiguracion.Width - BunifuImageButton1.Width + 10

        Else
            widthmenubool = False
            Timerwidthmenos.Stop()
            Timerwidthmenos.Enabled = False
            panelmenus.Enabled = True
            inicio.Panelsecundario.Left = panelusuarios.Width + Panelconfiguracion.Width + BunifuImageButton1.Width + panelmenus.Width + 10
            acomodar()
        End If

    End Sub

    Private Sub Timerwidthmas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timerwidthmas.Tick
        Timerwidthmas.Interval = 1
        sizeventanas = New Size(Me.Width - panelmenus.Width - 20, Me.Height - Panel1.Height - 43)
        panelmenus.Enabled = False

        panelmenus.Width = widthmenu
        If panelmenus.Width < 258 Then
            widthmenu = widthmenu + 30
            inicio.Panelsecundario.Left = panelusuarios.Width + Panelconfiguracion.Width + BunifuImageButton1.Width - panelmenus.Width + 10

            acomodar()
        Else
            widthmenubool = True
            Timerwidthmas.Stop()
            Timerwidthmas.Enabled = False
            inicio.Panelsecundario.Left = panelusuarios.Width + Panelconfiguracion.Width + BunifuImageButton1.Width - panelmenus.Width + 10
            acomodar()
            panelmenus.Enabled = True
        End If
    End Sub


    Private Sub imgmostrarpanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgmostrarpanel.Click
        If mostrarpanelsecundario = False Then

            inicio.Panelsecundario.Visible = True
            imgmostrarpanel.Image = ConfiaAdmin.My.Resources.Resources.ocultar1
            imgmostrarpanel.BackColor = Color.FromArgb(46, 139, 87)

            mostrarpanelsecundario = True
        Else
            inicio.Panelsecundario.Visible = False
            imgmostrarpanel.Image = ConfiaAdmin.My.Resources.Resources.mostrar1
            imgmostrarpanel.BackColor = Color.FromArgb(51, 0, 204)
            mostrarpanelsecundario = False

        End If
    End Sub



    Private Sub btnusuarios_Click(sender As Object, e As EventArgs) Handles btnusuarios.Click
        For Each row As DataRow In dataPermisos.Rows
            If row("SatiModUsuarios") Then
                usuarios.Show()

            Else

            End If
        Next



    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        For Each row As DataRow In dataPermisos.Rows
            If row("SatiModGrupos") Then
                grupos.Show()
            Else

            End If
        Next

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        BunifuFlatButton3.Textcolor = Color.White

        For Each row As DataRow In dataPermisos.Rows
            If row("SatiModSolicitudes") Then
                inicio.Close()
                inv.Close()

                ventana.Name = Solicitudes.Name

                Solicitudes.MdiParent = Me
                Solicitudes.Height = Me.Height - Panel1.Height
                Solicitudes.Width = Me.Width - panelmenus.Width


                Solicitudes.Top = 0
                Solicitudes.Left = 0
                Solicitudes.Show()
                Solicitudes.Top = 0
                Solicitudes.Left = 0
                Solicitudes.Height = Me.Height - Panel1.Height - 43
                Solicitudes.Width = Me.Width - panelmenus.Width - 20
                'inv.Size = sizeventanas
                Solicitudes.Show()

                If Solicitudes.Top > 0 Then
                    Solicitudes.Top = 0

                End If
                Solicitudes.Update()
            Else

            End If
        Next

        BunifuFlatButton1.Textcolor = Color.Black
        BunifuFlatButton2.Textcolor = Color.Black
        BunifuFlatButton4.Textcolor = Color.Black
        BunifuFlatButton8.Textcolor = Color.Black
        BunifuFlatButton5.Textcolor = Color.Black
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        BunifuFlatButton4.Textcolor = Color.White

        For Each frmForm As Form In My.Application.OpenForms


            If frmForm.Name = ventana.Name Then
                frmForm.Close()
                Exit For
            End If
        Next

        ventana.Name = CreditosPorEntregar.Name

        CreditosPorEntregar.MdiParent = Me
        CreditosPorEntregar.Height = Me.Height - Panel1.Height
        CreditosPorEntregar.Width = Me.Width - panelmenus.Width


        CreditosPorEntregar.Top = 0
        CreditosPorEntregar.Left = 0
        CreditosPorEntregar.Show()
        CreditosPorEntregar.Top = 0
        CreditosPorEntregar.Left = 0
        CreditosPorEntregar.Height = Me.Height - Panel1.Height - 43
        CreditosPorEntregar.Width = Me.Width - panelmenus.Width - 20
        'inv.Size = sizeventanas
        CreditosPorEntregar.Show()

        If CreditosPorEntregar.Top > 0 Then
            CreditosPorEntregar.Top = 0

        End If
        CreditosPorEntregar.Update()
        BunifuFlatButton1.Textcolor = Color.Black
        BunifuFlatButton2.Textcolor = Color.Black
        BunifuFlatButton3.Textcolor = Color.Black
        BunifuFlatButton8.Textcolor = Color.Black
        BunifuFlatButton5.Textcolor = Color.Black
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        BunifuFlatButton5.Textcolor = Color.White
        Try
            CierraEmpresa.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        BunifuFlatButton5.Textcolor = Color.Black
        BunifuFlatButton1.Textcolor = Color.Black
        BunifuFlatButton2.Textcolor = Color.Black
        BunifuFlatButton3.Textcolor = Color.Black
        BunifuFlatButton4.Textcolor = Color.Black
        BunifuFlatButton8.Textcolor = Color.Black
    End Sub

    Private Sub frm_adm_ImeModeChanged(sender As Object, e As EventArgs) Handles Me.ImeModeChanged

    End Sub

    Private Sub btnconfiguracion_Click(sender As Object, e As EventArgs)
        Configuraciones.Show()
    End Sub

    Private Sub btnconfiguracion_Click_1(sender As Object, e As EventArgs) Handles btnconfiguracion.Click
        Configuraciones.Show()
    End Sub

    Private Sub BunifuFlatButton8_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton8.Click
        BunifuFlatButton8.Textcolor = Color.White
        For Each row As DataRow In dataPermisos.Rows
            If row("SatiModReportes") Then
                For Each frmForm As Form In My.Application.OpenForms


                    If frmForm.Name = ventana.Name Then
                        frmForm.Close()
                        Exit For
                    End If
                Next
                ventana.Name = Reportes.Name
                Reportes.MdiParent = Me
                Reportes.Height = Me.Height - Panel1.Height
                Reportes.Width = Me.Width - panelmenus.Width


                Reportes.Top = 0
                Reportes.Left = 0
                Reportes.Show()
                Reportes.Top = 0
                Reportes.Left = 0
                Reportes.Height = Me.Height - Panel1.Height - 43
                Reportes.Width = Me.Width - panelmenus.Width - 20
                'inv.Size = sizeventanas
                Reportes.Show()

                If Reportes.Top > 0 Then
                    Reportes.Top = 0

                End If
                Reportes.Update()
            Else

            End If
        Next

        BunifuFlatButton1.Textcolor = Color.Black
        BunifuFlatButton2.Textcolor = Color.Black
        BunifuFlatButton3.Textcolor = Color.Black
        BunifuFlatButton4.Textcolor = Color.Black
        BunifuFlatButton5.Textcolor = Color.Black

    End Sub

    Private Sub TimerLiberar_Tick(sender As Object, e As EventArgs) Handles TimerLiberar.Tick
        FlushMemory()
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        Retiros.Show()
    End Sub

    Private Sub MonoFlat_Button1_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button1.Click
        For Each frmForm As Form In My.Application.OpenForms


            If frmForm.Name = ventana.Name Then
                frmForm.Close()
                Exit For
            End If
        Next
        ventana.Name = EmpeñosPorEntregar.Name

        EmpeñosPorEntregar.MdiParent = Me
        EmpeñosPorEntregar.Height = Me.Height - Panel1.Height
        EmpeñosPorEntregar.Width = Me.Width - panelmenus.Width


        EmpeñosPorEntregar.Top = 0
        EmpeñosPorEntregar.Left = 0
        EmpeñosPorEntregar.Show()
        EmpeñosPorEntregar.Top = 0
        EmpeñosPorEntregar.Left = 0
        EmpeñosPorEntregar.Height = Me.Height - Panel1.Height - 43
        EmpeñosPorEntregar.Width = Me.Width - panelmenus.Width - 20
        'inv.Size = sizeventanas
        EmpeñosPorEntregar.Show()

        If EmpeñosPorEntregar.Top > 0 Then
            EmpeñosPorEntregar.Top = 0

        End If
        EmpeñosPorEntregar.Update()
        BunifuFlatButton1.Textcolor = Color.Black
        BunifuFlatButton1.selected = False
        BunifuFlatButton2.Textcolor = Color.Black
        BunifuFlatButton2.selected = False
        BunifuFlatButton3.Textcolor = Color.Black
        BunifuFlatButton3.selected = False
        BunifuFlatButton4.Textcolor = Color.Black
        BunifuFlatButton4.selected = False
        BunifuFlatButton8.Textcolor = Color.Black
        BunifuFlatButton8.selected = False
        BunifuFlatButton5.Textcolor = Color.Black
    End Sub

    Private Sub MonoFlat_Button2_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button2.Click
        For Each frmForm As Form In My.Application.OpenForms


            If frmForm.Name = ventana.Name Then
                frmForm.Close()
                Exit For
            End If
        Next

        ventana.Name = SolicitudesEmpeños.Name

        SolicitudesEmpeños.MdiParent = Me
        SolicitudesEmpeños.Height = Me.Height - Panel1.Height
        SolicitudesEmpeños.Width = Me.Width - panelmenus.Width


        SolicitudesEmpeños.Top = 0
        SolicitudesEmpeños.Left = 0
        SolicitudesEmpeños.Show()
        SolicitudesEmpeños.Top = 0
        SolicitudesEmpeños.Left = 0
        SolicitudesEmpeños.Height = Me.Height - Panel1.Height - 43
        SolicitudesEmpeños.Width = Me.Width - panelmenus.Width - 20
        'inv.Size = sizeventanas
        SolicitudesEmpeños.Show()

        If SolicitudesEmpeños.Top > 0 Then
            SolicitudesEmpeños.Top = 0

        End If
        SolicitudesEmpeños.Update()
        BunifuFlatButton1.Textcolor = Color.Black
        BunifuFlatButton1.selected = False
        BunifuFlatButton2.Textcolor = Color.Black
        BunifuFlatButton2.selected = False
        BunifuFlatButton3.Textcolor = Color.Black
        BunifuFlatButton3.selected = False
        BunifuFlatButton4.Textcolor = Color.Black
        BunifuFlatButton4.selected = False
        BunifuFlatButton8.Textcolor = Color.Black
        BunifuFlatButton8.selected = False
        BunifuFlatButton5.Textcolor = Color.Black
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MessageBox.Show(Application.ProductVersion)
    End Sub

    Private Sub BackgroundActualizacion_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundActualizacion.DoWork
        Try
            conexionsql = New MySqlConnection()
            conexionsql.ConnectionString = "server=www.prestamosconfia.com;user id=SATIVersiones;pwd=123456;port=3306;database=Versiones"
            conexionsql.Open()

            Dim mysqlcomando As MySqlCommand
            Dim consulta As String

            consulta = "select Nversion from Versiones where Sistema = 'SATI'"
            mysqlcomando = New MySqlCommand
            mysqlcomando.Connection = conexionsql
            mysqlcomando.CommandText = consulta
            Dim versionAct As String
            versionAct = mysqlcomando.ExecuteScalar


            conexionsql.Close()

            If Application.ProductVersion <> versionAct Then
                hayActualizacion = True


            End If
        Catch ex As Exception
            hayActualizacion = False

        End Try


    End Sub

    Private Sub BackgroundActualizacion_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundActualizacion.RunWorkerCompleted
        If hayActualizacion Then
            btn_Actualizar.Visible = True

        End If

    End Sub

    Private Sub TimerActualizacion_Tick(sender As Object, e As EventArgs) Handles TimerActualizacion.Tick
        If BackgroundActualizacion.IsBusy = True Then
        Else
            BackgroundActualizacion.RunWorkerAsync()
        End If


    End Sub

    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click
        If MessageBox.Show("¿Desea aplicar la actualización?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            actualizar = True

            Dim Proceso As Process = New Process
            Dim ruta As String = "C:\ConfiaAdmin\Updater\Updater.exe"
            Proceso.StartInfo.FileName = ruta
            Proceso.StartInfo.Arguments = "/S SATI /T " & TipoEquipo
            Proceso.Start()
            Application.Exit()
        Else
            actualizar = False

        End If

    End Sub



    Private Sub BackgroundNotificaciones_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundNotificaciones.DoWork
        Try



            Dim conexionNotificaciones As MySqlConnection
            conexionNotificaciones = New MySqlConnection()
            conexionNotificaciones.ConnectionString = "server=www.prestamosconfia.com;user id=SatiNotificacion;pwd=123456;port=3306;database=USRS"
            conexionNotificaciones.Open()

            'Revisar notificaciones no aplicadas

            For a As Integer = array.Count - 1 To 0 Step -1
                If array(a).estado = "" Then
                    Dim mysqlcomandoexiste As MySqlCommand
                    Dim consultaExiste As String
                    Dim aplicado As Boolean

                    consultaExiste = "select Aplicado from Notificaciones where id = '" & array(a).id & "'"
                    mysqlcomandoexiste = New MySqlCommand
                    mysqlcomandoexiste.Connection = conexionNotificaciones
                    mysqlcomandoexiste.CommandText = consultaExiste
                    aplicado = mysqlcomandoexiste.ExecuteScalar
                    If aplicado Then
                        array.RemoveAt(a)

                    End If

                End If
            Next


            'Revisar notificaciones aplicadas

            For a As Integer = array.Count - 1 To 0 Step -1
                If array(a).estado <> "" Then
                    Dim mysqlcomandoexiste As MySqlCommand
                    Dim consultaExiste As String
                    Dim Visto As Boolean

                    consultaExiste = "select Visto from Notificaciones where id = '" & array(a).id & "'"
                    mysqlcomandoexiste = New MySqlCommand
                    mysqlcomandoexiste.Connection = conexionNotificaciones
                    mysqlcomandoexiste.CommandText = consultaExiste
                    Visto = mysqlcomandoexiste.ExecuteScalar
                    If Visto Then
                        array.RemoveAt(a)

                    End If

                End If
            Next





            Dim mysqlcomando As MySqlCommand
            Dim consulta As String
            Dim readerNotificacion As MySqlDataReader

            consulta = "select * from Notificaciones where UsuarioDestino = '" & nmusr & "' and Aplicado = 0 and idSesion='" & idSesion & "'"
            mysqlcomando = New MySqlCommand
            mysqlcomando.Connection = conexionNotificaciones
            mysqlcomando.CommandText = consulta
            readerNotificacion = mysqlcomando.ExecuteReader
            Dim existe As Boolean
            While readerNotificacion.Read
                Dim Nnotificacion As New Notificaciones
                Nnotificacion.id = readerNotificacion("id")
                Nnotificacion.Tipo = readerNotificacion("tipo")
                Nnotificacion.Usuario = readerNotificacion("Usuario")
                Nnotificacion.UsuarioDestino = readerNotificacion("usuariodestino")
                Nnotificacion.Notificacion = readerNotificacion("notificacion")
                Nnotificacion.Mensaje = readerNotificacion("Mensaje")
                Nnotificacion.Fecha = readerNotificacion("Fecha")
                Nnotificacion.Hora = readerNotificacion("Hora").ToString
                Nnotificacion.Empresa = readerNotificacion("Empresa")
                For a As Integer = array.Count - 1 To 0 Step -1
                    If array(a).id = Nnotificacion.id Then
                        existe = True
                        '  MessageBox.Show("existe")
                        Exit For
                    Else
                        'MessageBox.Show("No existe")
                        existe = False

                    End If

                Next
                If existe = False Then
                    ' media.Play() ' Async, creates a new thread
                    array.Add(Nnotificacion)
                End If

            End While
            readerNotificacion.Close()








            Dim mysqlcomandoConNotificacion As MySqlCommand
            Dim consultaConNotificacion As String
            Dim readerConNotificacion As MySqlDataReader

            consultaConNotificacion = "select * from Notificaciones where UsuarioDestino = '" & nmusr & "' and Notificacion = 1 and Aplicado = 0 "
            mysqlcomandoConNotificacion = New MySqlCommand
            mysqlcomandoConNotificacion.Connection = conexionNotificaciones
            mysqlcomandoConNotificacion.CommandText = consultaConNotificacion
            readerConNotificacion = mysqlcomandoConNotificacion.ExecuteReader
            Dim existeConNotificacion As Boolean
            While readerConNotificacion.Read
                Dim Nnotificacion As New Notificaciones
                Nnotificacion.id = readerConNotificacion("id")
                Nnotificacion.Tipo = readerConNotificacion("tipo")
                Nnotificacion.Usuario = readerConNotificacion("Usuario")
                Nnotificacion.UsuarioDestino = readerConNotificacion("usuariodestino")
                Nnotificacion.Notificacion = readerConNotificacion("notificacion")
                Nnotificacion.Mensaje = readerConNotificacion("Mensaje")
                Nnotificacion.Fecha = readerConNotificacion("Fecha")
                Nnotificacion.Hora = readerConNotificacion("Hora").ToString
                Nnotificacion.Valor = readerConNotificacion("valor")
                Nnotificacion.Estado = readerConNotificacion("Estado")
                Nnotificacion.Empresa = readerConNotificacion("Empresa")
                For a As Integer = array.Count - 1 To 0 Step -1
                    If array(a).id = Nnotificacion.id And array(a).estado = Nnotificacion.Estado Then
                        existeConNotificacion = True

                        Exit For
                    Else

                        existeConNotificacion = False

                    End If

                Next
                If existeConNotificacion = False Then
                    CantNotificaciones += 1
                    ' media.Play() ' Async, creates a new thread
                    array.Add(Nnotificacion)
                End If

            End While
            readerConNotificacion.Close()


            Dim mysqlcomandoConNotificacionAplicado As MySqlCommand
            Dim consultaConNotificacionAplicado As String
            Dim readerConNotificacionAplicado As MySqlDataReader

            consultaConNotificacionAplicado = "select * from Notificaciones where Usuario = '" & nmusr & "' and Notificacion = 1 and Aplicado = 1 and Visto = 0"
            mysqlcomandoConNotificacionAplicado = New MySqlCommand
            mysqlcomandoConNotificacionAplicado.Connection = conexionNotificaciones
            mysqlcomandoConNotificacionAplicado.CommandText = consultaConNotificacionAplicado
            readerConNotificacionAplicado = mysqlcomandoConNotificacionAplicado.ExecuteReader
            Dim existeConNotificacionAplicado As Boolean
            While readerConNotificacionAplicado.Read
                Dim Nnotificacion As New Notificaciones
                Nnotificacion.id = readerConNotificacionAplicado("id")
                Nnotificacion.Tipo = readerConNotificacionAplicado("tipo")
                Nnotificacion.Usuario = readerConNotificacionAplicado("Usuario")
                Nnotificacion.UsuarioDestino = readerConNotificacionAplicado("usuariodestino")
                Nnotificacion.Notificacion = readerConNotificacionAplicado("notificacion")
                Nnotificacion.Mensaje = readerConNotificacionAplicado("Mensaje")
                Nnotificacion.FechaAplicacion = readerConNotificacionAplicado("FechaAplicacion")
                Nnotificacion.HoraAplicacion = readerConNotificacionAplicado("HoraAplicacion").ToString
                Nnotificacion.Valor = readerConNotificacionAplicado("valor")
                Nnotificacion.Estado = readerConNotificacionAplicado("Estado")
                Nnotificacion.ComentarioUsuarioDestino = readerConNotificacionAplicado("ComentarioUsuarioDestino")
                Nnotificacion.Empresa = readerConNotificacionAplicado("Empresa")
                For a As Integer = array.Count - 1 To 0 Step -1
                    If array(a).id = Nnotificacion.id And array(a).Estado = Nnotificacion.Estado Then

                        existeConNotificacionAplicado = True

                        Exit For
                    Else

                        existeConNotificacionAplicado = False

                    End If

                Next
                If existeConNotificacionAplicado = False Then
                    CantNotificaciones += 1
                    '   media.Play() ' Async, creates a new thread
                    array.Add(Nnotificacion)
                End If

            End While
            readerConNotificacionAplicado.Close()




            Me.Invoke(Sub()
                          notificaciones.Text = "Tienes " & array.Count & " notificaciones"
                          notificaciones.Refresh()

                      End Sub)

            ' conexionNotificaciones.Close()

            For a As Integer = array.Count - 1 To 0 Step -1


                If array(a).Notificacion = "0" Then
                    If array(a).Tipo = "Logout" Then
                        Dim comandoActNotificacion As MySqlCommand
                        Dim consultaActNotificacion As String
                        comandoActNotificacion = New MySqlCommand
                        consultaActNotificacion = "update Notificaciones set Aplicado = 1 where id = '" & array(a).id & "'"
                        comandoActNotificacion.Connection = conexionNotificaciones
                        comandoActNotificacion.CommandText = consultaActNotificacion
                        comandoActNotificacion.ExecuteNonQuery()
                        If array(a).Mensaje <> "" Then

                            Me.Invoke(Sub()
                                          Dim nAlertas As New Alertas
                                          nAlertas.cadena = array(a).Mensaje
                                          nAlertas.ShowDialog()
                                          nAlertas.TopMost = True
                                      End Sub)
                        End If
                        Me.actualizar = True
                        Dim num_controles As Integer = Application.OpenForms.Count - 1
                        For n As Integer = num_controles To 0 Step -1
                            Dim ctrl As Form = Application.OpenForms.Item(n)
                            If ctrl.Name <> "login" And ctrl.Name <> Me.Name Then
                                ctrl.Close()
                            End If

                            'ctrl.Dispose()
                        Next
                        Me.Invoke(Sub()
                                      login.Show()
                                  End Sub)


                        Me.Close()
                    End If
                    If array(a).Tipo = "Message" Then
                        Dim comandoActNotificacion As MySqlCommand
                        Dim consultaActNotificacion As String
                        comandoActNotificacion = New MySqlCommand
                        consultaActNotificacion = "update Notificaciones set Aplicado = 1 where id = '" & array(a).id & "'"
                        comandoActNotificacion.Connection = conexionNotificaciones
                        comandoActNotificacion.CommandText = consultaActNotificacion
                        comandoActNotificacion.ExecuteNonQuery()

                        Me.Invoke(Sub()
                                      Dim nAlertas As New Alertas


                                      nAlertas.cadena = array(a).Mensaje
                                      array.RemoveAt(a)
                                      nAlertas.ShowDialog()
                                      nAlertas.TopMost = True

                                  End Sub)
                        If array.Count = 0 Then
                            Exit For
                        End If
                    End If
                    If array(a).Tipo = "CargarPermisos" Then
                        If array(a).Mensaje <> "" Then

                            Me.Invoke(Sub()
                                          Dim nAlertas As New Alertas
                                          nAlertas.cadena = array(a).Mensaje
                                          nAlertas.ShowDialog()
                                          nAlertas.TopMost = True
                                      End Sub)
                        End If
                        cargarperfil()
                        Dim comandoActNotificacion As MySqlCommand
                        Dim consultaActNotificacion As String
                        comandoActNotificacion = New MySqlCommand
                        consultaActNotificacion = "update Notificaciones set Aplicado = 1 where id = '" & array(a).id & "'"
                        comandoActNotificacion.Connection = conexionNotificaciones
                        comandoActNotificacion.CommandText = consultaActNotificacion
                        comandoActNotificacion.ExecuteNonQuery()
                        array.RemoveAt(a)
                        If array.Count = 0 Then
                            Exit For
                        End If
                    End If
                    If array(a).Tipo = "Update" Then
                        If array(a).Mensaje <> "" Then

                            Me.Invoke(Sub()
                                          Dim nAlertas As New Alertas
                                          nAlertas.cadena = array(a).Mensaje
                                          nAlertas.ShowDialog()
                                          nAlertas.TopMost = True
                                      End Sub)
                        End If

                        Dim comandoActNotificacion As MySqlCommand
                        Dim consultaActNotificacion As String
                        comandoActNotificacion = New MySqlCommand
                        consultaActNotificacion = "update Notificaciones set Aplicado = 1 where id = '" & array(a).id & "'"
                        comandoActNotificacion.Connection = conexionNotificaciones
                        comandoActNotificacion.CommandText = consultaActNotificacion
                        comandoActNotificacion.ExecuteNonQuery()
                        actualizar = True

                        Dim ruta As String = "C:\ConfiaAdmin\Updater\Updater.exe"
                        Dim Proceso As Process = New Process
                        Proceso.StartInfo.FileName = ruta
                        Proceso.StartInfo.Arguments = "/S SATI /T " & TipoEquipo
                        Proceso.Start()

                        Application.Exit()
                    End If
                    If array(a).Tipo = "UpdateUpdater" Then
                        If array(a).Mensaje <> "" Then

                            Dim nAlertas As New Alertas
                            nAlertas.cadena = array(a).Mensaje
                            nAlertas.ShowDialog()
                            nAlertas.TopMost = True
                        End If

                        Dim comandoActNotificacion As MySqlCommand
                        Dim consultaActNotificacion As String
                        comandoActNotificacion = New MySqlCommand
                        consultaActNotificacion = "update Notificaciones set Aplicado = 1 where id = '" & array(a).id & "'"
                        comandoActNotificacion.Connection = conexionNotificaciones
                        comandoActNotificacion.CommandText = consultaActNotificacion
                        comandoActNotificacion.ExecuteNonQuery()
                        Me.Invoke(Sub()
                                      ActualizadorUpdater.Show()
                                  End Sub)

                        array.RemoveAt(a)
                        If array.Count = 0 Then
                            Exit For
                        End If
                    End If
                End If



            Next
            conexionNotificaciones.Close()


        Catch ex As Exception

        End Try
    End Sub


    Public Sub VerificaNotificaciones()
        For a As Integer = array.Count - 1 To 0 Step -1

        Next
    End Sub


    Private Sub TimerNotificaciones_Tick(sender As Object, e As EventArgs) Handles TimerNotificaciones.Tick
        If BackgroundNotificaciones.IsBusy = True Then
        Else
            BackgroundNotificaciones.RunWorkerAsync()
        End If


    End Sub

    Private Sub BackgroundActSesion_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundActSesion.DoWork
        Try
            Dim conexionSesion As MySqlConnection
            conexionSesion = New MySqlConnection()
            conexionSesion.ConnectionString = "server=www.prestamosconfia.com;user id=confia1;pwd=123456;port=3306;database=USRS"
            conexionSesion.Open()

            Dim mysqlcomando As MySqlCommand
            Dim consulta As String
            Dim sesionActiva As Boolean

            consulta = "select Activo from Sesiones where Usuario = '" & nmusr & "' and id='" & idSesion & "'"
            mysqlcomando = New MySqlCommand
            mysqlcomando.Connection = conexionSesion
            mysqlcomando.CommandText = consulta
            sesionActiva = mysqlcomando.ExecuteScalar

            If sesionActiva Then
                Dim comandoActSesion As MySqlCommand
                Dim consultaActSesion As String
                consultaActSesion = "update Sesiones set UltimoAcceso = '" & Date.Now.ToString("yyyy-MM-dd HH:mm:ss") & "' where id = '" & idSesion & "'"
                comandoActSesion = New MySqlCommand
                comandoActSesion.Connection = conexionSesion
                comandoActSesion.CommandText = consultaActSesion
                comandoActSesion.ExecuteNonQuery()
                conexionSesion.Close()
            Else
                'quitar comentarios
                Me.Invoke(Sub()

                              Dim nAlertas As New Alertas
                              nAlertas.cadena = "Han pasado más de 5 minutos sin conexión, la sesión se cerrará"

                              nAlertas.ShowDialog()
                              nAlertas.TopMost = True
                          End Sub)

                Me.actualizar = True

                login.Show()
                Dim num_controles As Integer = Application.OpenForms.Count - 1
                For n As Integer = num_controles To 0 Step -1
                    Dim ctrl As Form = Application.OpenForms.Item(n)
                    If ctrl.Name <> "login" And ctrl.Name <> Me.Name Then
                        ctrl.Close()
                    End If

                    ctrl.Dispose()
                Next
                Me.Invoke(Sub()
                              login.Show()
                          End Sub)
                Me.Close()


            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub TimerActSesion_Tick(sender As Object, e As EventArgs) Handles TimerActSesion.Tick
        If BackgroundActSesion.IsBusy Then
        Else
            BackgroundActSesion.RunWorkerAsync()

        End If
    End Sub

    Private Sub frm_adm_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed

    End Sub

    Private Sub notificaciones_Click(sender As Object, e As EventArgs) Handles notificaciones.Click
        CentroDeNotificaciones.Show()

    End Sub

    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton9.Click
        CierresSinRecibir.Show()
    End Sub
End Class