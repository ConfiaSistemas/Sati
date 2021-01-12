﻿Imports System.ComponentModel
Imports System.Data.SqlClient

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
        Timer2.Stop()

        perfilalt.Close()
        abierto = False
        Try
            If actualizar Then
            Else
                If cerrarEmpresa Then
                    If MessageBox.Show("¿Está seguro que desea cerrar la empresa?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        perfilalt.TopMost = False

                        'Application.ExitThread()

                        Empresas.Show()
                        'System.Threading.Thread.Sleep(1000)
                        ' System.Threading.Thread.Sleep(1000)
                        'cerrarSesion = False
                        cerrarEmpresa = False
                        cerrandoEmpresa = True
                        'cerrandoSesion = True
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
                            If ctrl.Name <> "Empresas" Or ctrl.Name <> Me.Name Then
                                'MessageBox.Show(ctrl.Name)
                                ctrl.Close()
                            End If

                            ' ctrl.Dispose()
                        Next
                        'MessageBox.Show("hola")
                        Empresas.Show()
                        Me.Close()

                    Else
                        cerrarEmpresa = False

                        e.Cancel = True

                    End If

                Else
                    If cerrandoEmpresa Then
                        MessageBox.Show("hola")
                        'Me.Close()


                    Else

                        If cerrarSesion Then

                            If MessageBox.Show("¿Está seguro que desea cerrar sesión?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                perfilalt.TopMost = False

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
                        Else
                            If cerrandoSesion Then

                            Else
                                'MessageBox.Show("hola")
                                If MessageBox.Show("¿Está seguro que desea salir?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                    perfilalt.TopMost = False

                                    Application.ExitThread()



                                Else
                                    e.Cancel = True

                                End If
                            End If

                        End If
                    End If


                End If
            End If

        Catch ex As Exception

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

        notificaciones.Text = "Tiene n notificaciones"

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
            cerrarEmpresa = True
            'Empresas.ShowDialog()
            Me.Close()
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
            If row("SatiModSolicitudes") Then
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
            Dim cnActualizacion As String
            cnActualizacion = "Data Source=  " & ipser & "\confia;" &
                         "Initial Catalog=" & bdser & ";" &
                         "User Id=sa;Password=BSi5t3Ma$CFAD;MultipleActiveResultSets=true"
            Dim connectActualizacion As New SqlConnection(cnActualizacion)
            connectActualizacion.Open()
            Dim consultaActualizacion As String
            Dim comandoActualizacion As SqlCommand
            consultaActualizacion = "Select nversion from versiones where Sistema = 'SATI'"
            comandoActualizacion = New SqlCommand
            comandoActualizacion.Connection = connectActualizacion
            comandoActualizacion.CommandText = consultaActualizacion
            Dim versionActualizacion As String
            versionActualizacion = comandoActualizacion.ExecuteScalar
            connectActualizacion.Close()

            If Application.ProductVersion <> versionActualizacion Then
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

        BackgroundActualizacion.RunWorkerAsync()

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

    Private Sub frm_adm_MaximizedBoundsChanged(sender As Object, e As EventArgs) Handles Me.MaximizedBoundsChanged

    End Sub
End Class