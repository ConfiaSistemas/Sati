<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_adm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_adm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton7 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton6 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.notificaciones = New ConfiaAdmin.MonoFlat.MonoFlat_NotificationBox()
        Me.Panelconfiguracion = New System.Windows.Forms.Panel()
        Me.btnconfiguracion = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.panelusuarios = New System.Windows.Forms.Panel()
        Me.btnusuarios = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.imgperfil = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.panelmenus = New System.Windows.Forms.Panel()
        Me.MonoFlat_Button2 = New ConfiaAdmin.MonoFlat.MonoFlat_Button()
        Me.MonoFlat_Button1 = New ConfiaAdmin.MonoFlat.MonoFlat_Button()
        Me.BunifuFlatButton8 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton5 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton4 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timerwidthmenos = New System.Windows.Forms.Timer(Me.components)
        Me.Timerwidthmas = New System.Windows.Forms.Timer(Me.components)
        Me.imgmostrarpanel = New Bunifu.Framework.UI.BunifuImageButton()
        Me.TimerLiberar = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panelconfiguracion.SuspendLayout()
        Me.panelusuarios.SuspendLayout()
        CType(Me.imgperfil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelmenus.SuspendLayout()
        CType(Me.imgmostrarpanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.notificaciones)
        Me.Panel1.Controls.Add(Me.Panelconfiguracion)
        Me.Panel1.Controls.Add(Me.panelusuarios)
        Me.Panel1.Controls.Add(Me.imgperfil)
        Me.Panel1.Controls.Add(Me.BunifuImageButton1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(890, 66)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.BunifuFlatButton7)
        Me.Panel4.Location = New System.Drawing.Point(437, 10)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(111, 45)
        Me.Panel4.TabIndex = 8
        '
        'BunifuFlatButton7
        '
        Me.BunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton7.BorderRadius = 0
        Me.BunifuFlatButton7.ButtonText = "Grupos"
        Me.BunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.Iconimage = Global.ConfiaAdmin.My.Resources.Resources.usuarios
        Me.BunifuFlatButton7.Iconimage_right = Nothing
        Me.BunifuFlatButton7.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton7.Iconimage_Selected = Nothing
        Me.BunifuFlatButton7.IconMarginLeft = 0
        Me.BunifuFlatButton7.IconMarginRight = 0
        Me.BunifuFlatButton7.IconRightVisible = True
        Me.BunifuFlatButton7.IconRightZoom = 0R
        Me.BunifuFlatButton7.IconVisible = True
        Me.BunifuFlatButton7.IconZoom = 90.0R
        Me.BunifuFlatButton7.IsTab = False
        Me.BunifuFlatButton7.Location = New System.Drawing.Point(3, -3)
        Me.BunifuFlatButton7.Name = "BunifuFlatButton7"
        Me.BunifuFlatButton7.Normalcolor = System.Drawing.Color.Empty
        Me.BunifuFlatButton7.OnHovercolor = System.Drawing.Color.Gray
        Me.BunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton7.selected = False
        Me.BunifuFlatButton7.Size = New System.Drawing.Size(111, 48)
        Me.BunifuFlatButton7.TabIndex = 5
        Me.BunifuFlatButton7.Text = "Grupos"
        Me.BunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton7.Textcolor = System.Drawing.Color.WhiteSmoke
        Me.BunifuFlatButton7.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BunifuFlatButton6)
        Me.Panel3.Location = New System.Drawing.Point(317, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(111, 45)
        Me.Panel3.TabIndex = 7
        '
        'BunifuFlatButton6
        '
        Me.BunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton6.BorderRadius = 0
        Me.BunifuFlatButton6.ButtonText = "Retiros"
        Me.BunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.Iconimage = Global.ConfiaAdmin.My.Resources.Resources._109846
        Me.BunifuFlatButton6.Iconimage_right = Nothing
        Me.BunifuFlatButton6.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton6.Iconimage_Selected = Nothing
        Me.BunifuFlatButton6.IconMarginLeft = 0
        Me.BunifuFlatButton6.IconMarginRight = 0
        Me.BunifuFlatButton6.IconRightVisible = True
        Me.BunifuFlatButton6.IconRightZoom = 0R
        Me.BunifuFlatButton6.IconVisible = True
        Me.BunifuFlatButton6.IconZoom = 90.0R
        Me.BunifuFlatButton6.IsTab = False
        Me.BunifuFlatButton6.Location = New System.Drawing.Point(0, -1)
        Me.BunifuFlatButton6.Name = "BunifuFlatButton6"
        Me.BunifuFlatButton6.Normalcolor = System.Drawing.Color.Empty
        Me.BunifuFlatButton6.OnHovercolor = System.Drawing.Color.Gray
        Me.BunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton6.selected = False
        Me.BunifuFlatButton6.Size = New System.Drawing.Size(122, 48)
        Me.BunifuFlatButton6.TabIndex = 5
        Me.BunifuFlatButton6.Text = "Retiros"
        Me.BunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton6.Textcolor = System.Drawing.Color.WhiteSmoke
        Me.BunifuFlatButton6.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'notificaciones
        '
        Me.notificaciones.BorderCurve = 8
        Me.notificaciones.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.notificaciones.Image = Nothing
        Me.notificaciones.Location = New System.Drawing.Point(675, 6)
        Me.notificaciones.MinimumSize = New System.Drawing.Size(100, 40)
        Me.notificaciones.Name = "notificaciones"
        Me.notificaciones.NotificationType = ConfiaAdmin.MonoFlat.MonoFlat_NotificationBox.Type.Notice
        Me.notificaciones.RoundCorners = False
        Me.notificaciones.ShowCloseButton = True
        Me.notificaciones.Size = New System.Drawing.Size(157, 52)
        Me.notificaciones.TabIndex = 3
        Me.notificaciones.Text = "MonoFlat_NotificationBox1"
        '
        'Panelconfiguracion
        '
        Me.Panelconfiguracion.Controls.Add(Me.btnconfiguracion)
        Me.Panelconfiguracion.Location = New System.Drawing.Point(172, 15)
        Me.Panelconfiguracion.Name = "Panelconfiguracion"
        Me.Panelconfiguracion.Size = New System.Drawing.Size(148, 45)
        Me.Panelconfiguracion.TabIndex = 6
        '
        'btnconfiguracion
        '
        Me.btnconfiguracion.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnconfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnconfiguracion.BorderRadius = 0
        Me.btnconfiguracion.ButtonText = "Configuración"
        Me.btnconfiguracion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnconfiguracion.DisabledColor = System.Drawing.Color.Gray
        Me.btnconfiguracion.Iconcolor = System.Drawing.Color.Transparent
        Me.btnconfiguracion.Iconimage = Global.ConfiaAdmin.My.Resources.Resources.config
        Me.btnconfiguracion.Iconimage_right = Nothing
        Me.btnconfiguracion.Iconimage_right_Selected = Nothing
        Me.btnconfiguracion.Iconimage_Selected = Nothing
        Me.btnconfiguracion.IconMarginLeft = 0
        Me.btnconfiguracion.IconMarginRight = 0
        Me.btnconfiguracion.IconRightVisible = True
        Me.btnconfiguracion.IconRightZoom = 0R
        Me.btnconfiguracion.IconVisible = True
        Me.btnconfiguracion.IconZoom = 90.0R
        Me.btnconfiguracion.IsTab = False
        Me.btnconfiguracion.Location = New System.Drawing.Point(3, -4)
        Me.btnconfiguracion.Name = "btnconfiguracion"
        Me.btnconfiguracion.Normalcolor = System.Drawing.Color.Empty
        Me.btnconfiguracion.OnHovercolor = System.Drawing.Color.Gray
        Me.btnconfiguracion.OnHoverTextColor = System.Drawing.Color.White
        Me.btnconfiguracion.selected = False
        Me.btnconfiguracion.Size = New System.Drawing.Size(145, 48)
        Me.btnconfiguracion.TabIndex = 5
        Me.btnconfiguracion.Text = "Configuración"
        Me.btnconfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnconfiguracion.Textcolor = System.Drawing.Color.WhiteSmoke
        Me.btnconfiguracion.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'panelusuarios
        '
        Me.panelusuarios.Controls.Add(Me.btnusuarios)
        Me.panelusuarios.Location = New System.Drawing.Point(52, 13)
        Me.panelusuarios.Name = "panelusuarios"
        Me.panelusuarios.Size = New System.Drawing.Size(111, 45)
        Me.panelusuarios.TabIndex = 4
        '
        'btnusuarios
        '
        Me.btnusuarios.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnusuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnusuarios.BorderRadius = 0
        Me.btnusuarios.ButtonText = "Usuarios"
        Me.btnusuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnusuarios.DisabledColor = System.Drawing.Color.Gray
        Me.btnusuarios.Iconcolor = System.Drawing.Color.Transparent
        Me.btnusuarios.Iconimage = Global.ConfiaAdmin.My.Resources.Resources.usuarios
        Me.btnusuarios.Iconimage_right = Nothing
        Me.btnusuarios.Iconimage_right_Selected = Nothing
        Me.btnusuarios.Iconimage_Selected = Nothing
        Me.btnusuarios.IconMarginLeft = 0
        Me.btnusuarios.IconMarginRight = 0
        Me.btnusuarios.IconRightVisible = True
        Me.btnusuarios.IconRightZoom = 0R
        Me.btnusuarios.IconVisible = True
        Me.btnusuarios.IconZoom = 90.0R
        Me.btnusuarios.IsTab = False
        Me.btnusuarios.Location = New System.Drawing.Point(3, -2)
        Me.btnusuarios.Name = "btnusuarios"
        Me.btnusuarios.Normalcolor = System.Drawing.Color.Empty
        Me.btnusuarios.OnHovercolor = System.Drawing.Color.Gray
        Me.btnusuarios.OnHoverTextColor = System.Drawing.Color.White
        Me.btnusuarios.selected = False
        Me.btnusuarios.Size = New System.Drawing.Size(111, 48)
        Me.btnusuarios.TabIndex = 5
        Me.btnusuarios.Text = "Usuarios"
        Me.btnusuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnusuarios.Textcolor = System.Drawing.Color.WhiteSmoke
        Me.btnusuarios.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'imgperfil
        '
        Me.imgperfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.imgperfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgperfil.Image = Global.ConfiaAdmin.My.Resources.Resources.usuario
        Me.imgperfil.ImageActive = Nothing
        Me.imgperfil.Location = New System.Drawing.Point(838, 13)
        Me.imgperfil.Name = "imgperfil"
        Me.imgperfil.Size = New System.Drawing.Size(45, 43)
        Me.imgperfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgperfil.TabIndex = 2
        Me.imgperfil.TabStop = False
        Me.imgperfil.Zoom = 10
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuImageButton1.Image = Global.ConfiaAdmin.My.Resources.Resources.menu_alt_256
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(3, 13)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(48, 47)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 1
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'panelmenus
        '
        Me.panelmenus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.panelmenus.Controls.Add(Me.MonoFlat_Button2)
        Me.panelmenus.Controls.Add(Me.MonoFlat_Button1)
        Me.panelmenus.Controls.Add(Me.BunifuFlatButton8)
        Me.panelmenus.Controls.Add(Me.BunifuFlatButton5)
        Me.panelmenus.Controls.Add(Me.BunifuFlatButton4)
        Me.panelmenus.Controls.Add(Me.BunifuFlatButton3)
        Me.panelmenus.Controls.Add(Me.BunifuFlatButton2)
        Me.panelmenus.Controls.Add(Me.BunifuFlatButton1)
        Me.panelmenus.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelmenus.Location = New System.Drawing.Point(0, 66)
        Me.panelmenus.Name = "panelmenus"
        Me.panelmenus.Size = New System.Drawing.Size(258, 424)
        Me.panelmenus.TabIndex = 1
        '
        'MonoFlat_Button2
        '
        Me.MonoFlat_Button2.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MonoFlat_Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MonoFlat_Button2.Image = Nothing
        Me.MonoFlat_Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MonoFlat_Button2.Location = New System.Drawing.Point(12, 386)
        Me.MonoFlat_Button2.Name = "MonoFlat_Button2"
        Me.MonoFlat_Button2.Size = New System.Drawing.Size(214, 26)
        Me.MonoFlat_Button2.TabIndex = 12
        Me.MonoFlat_Button2.Text = "Solicitudes de Empeño"
        Me.MonoFlat_Button2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'MonoFlat_Button1
        '
        Me.MonoFlat_Button1.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MonoFlat_Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MonoFlat_Button1.Image = Nothing
        Me.MonoFlat_Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MonoFlat_Button1.Location = New System.Drawing.Point(12, 338)
        Me.MonoFlat_Button1.Name = "MonoFlat_Button1"
        Me.MonoFlat_Button1.Size = New System.Drawing.Size(214, 26)
        Me.MonoFlat_Button1.TabIndex = 11
        Me.MonoFlat_Button1.Text = "Empeños por Entregar"
        Me.MonoFlat_Button1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'BunifuFlatButton8
        '
        Me.BunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuFlatButton8.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton8.BorderRadius = 0
        Me.BunifuFlatButton8.ButtonText = "Reportes"
        Me.BunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton8.Iconimage = Global.ConfiaAdmin.My.Resources.Resources.icono_reportes
        Me.BunifuFlatButton8.Iconimage_right = Nothing
        Me.BunifuFlatButton8.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton8.Iconimage_Selected = Nothing
        Me.BunifuFlatButton8.IconMarginLeft = 0
        Me.BunifuFlatButton8.IconMarginRight = 0
        Me.BunifuFlatButton8.IconRightVisible = True
        Me.BunifuFlatButton8.IconRightZoom = 0R
        Me.BunifuFlatButton8.IconVisible = True
        Me.BunifuFlatButton8.IconZoom = 90.0R
        Me.BunifuFlatButton8.IsTab = True
        Me.BunifuFlatButton8.Location = New System.Drawing.Point(3, 218)
        Me.BunifuFlatButton8.Name = "BunifuFlatButton8"
        Me.BunifuFlatButton8.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuFlatButton8.OnHovercolor = System.Drawing.Color.Gray
        Me.BunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton8.selected = False
        Me.BunifuFlatButton8.Size = New System.Drawing.Size(258, 48)
        Me.BunifuFlatButton8.TabIndex = 6
        Me.BunifuFlatButton8.Text = "Reportes"
        Me.BunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton8.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton8.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton5
        '
        Me.BunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuFlatButton5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton5.BorderRadius = 0
        Me.BunifuFlatButton5.ButtonText = "Cerrar Empresa"
        Me.BunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.Iconimage = Global.ConfiaAdmin.My.Resources.Resources.icono_cerrar_empresa
        Me.BunifuFlatButton5.Iconimage_right = Nothing
        Me.BunifuFlatButton5.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton5.Iconimage_Selected = Nothing
        Me.BunifuFlatButton5.IconMarginLeft = 0
        Me.BunifuFlatButton5.IconMarginRight = 0
        Me.BunifuFlatButton5.IconRightVisible = True
        Me.BunifuFlatButton5.IconRightZoom = 0R
        Me.BunifuFlatButton5.IconVisible = True
        Me.BunifuFlatButton5.IconZoom = 90.0R
        Me.BunifuFlatButton5.IsTab = False
        Me.BunifuFlatButton5.Location = New System.Drawing.Point(0, 272)
        Me.BunifuFlatButton5.Name = "BunifuFlatButton5"
        Me.BunifuFlatButton5.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuFlatButton5.OnHovercolor = System.Drawing.Color.Gray
        Me.BunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton5.selected = False
        Me.BunifuFlatButton5.Size = New System.Drawing.Size(258, 48)
        Me.BunifuFlatButton5.TabIndex = 5
        Me.BunifuFlatButton5.Text = "Cerrar Empresa"
        Me.BunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton5.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton5.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton4
        '
        Me.BunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuFlatButton4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton4.BorderRadius = 0
        Me.BunifuFlatButton4.ButtonText = "Créditos por entregar"
        Me.BunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.Iconimage = Global.ConfiaAdmin.My.Resources.Resources.eaad3b05_c22d_49fb_ae4f_2d0e4ff7b0cb
        Me.BunifuFlatButton4.Iconimage_right = Nothing
        Me.BunifuFlatButton4.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton4.Iconimage_Selected = Nothing
        Me.BunifuFlatButton4.IconMarginLeft = 0
        Me.BunifuFlatButton4.IconMarginRight = 0
        Me.BunifuFlatButton4.IconRightVisible = True
        Me.BunifuFlatButton4.IconRightZoom = 0R
        Me.BunifuFlatButton4.IconVisible = True
        Me.BunifuFlatButton4.IconZoom = 90.0R
        Me.BunifuFlatButton4.IsTab = True
        Me.BunifuFlatButton4.Location = New System.Drawing.Point(0, 164)
        Me.BunifuFlatButton4.Name = "BunifuFlatButton4"
        Me.BunifuFlatButton4.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuFlatButton4.OnHovercolor = System.Drawing.Color.Gray
        Me.BunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton4.selected = False
        Me.BunifuFlatButton4.Size = New System.Drawing.Size(258, 48)
        Me.BunifuFlatButton4.TabIndex = 4
        Me.BunifuFlatButton4.Text = "Créditos por entregar"
        Me.BunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton4.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton4.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuFlatButton3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "Solicitudes"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = Global.ConfiaAdmin.My.Resources.Resources.icono_solicitudes
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 90.0R
        Me.BunifuFlatButton3.IsTab = True
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(1, 110)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(258, 48)
        Me.BunifuFlatButton3.TabIndex = 3
        Me.BunifuFlatButton3.Text = "Solicitudes"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Catálogos"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = Global.ConfiaAdmin.My.Resources.Resources.icono_catalogos
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 90.0R
        Me.BunifuFlatButton2.IsTab = True
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(1, 56)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(258, 48)
        Me.BunifuFlatButton2.TabIndex = 2
        Me.BunifuFlatButton2.Text = "Catálogos"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Inicio"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Global.ConfiaAdmin.My.Resources.Resources.icono_home
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = True
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(1, 2)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(258, 48)
        Me.BunifuFlatButton1.TabIndex = 1
        Me.BunifuFlatButton1.Text = "Inicio"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Timer2
        '
        '
        'Timerwidthmenos
        '
        '
        'Timerwidthmas
        '
        '
        'imgmostrarpanel
        '
        Me.imgmostrarpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.imgmostrarpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgmostrarpanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgmostrarpanel.Image = Global.ConfiaAdmin.My.Resources.Resources.mostrar1
        Me.imgmostrarpanel.ImageActive = Nothing
        Me.imgmostrarpanel.Location = New System.Drawing.Point(561, 122)
        Me.imgmostrarpanel.Name = "imgmostrarpanel"
        Me.imgmostrarpanel.Size = New System.Drawing.Size(12, 47)
        Me.imgmostrarpanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgmostrarpanel.TabIndex = 9
        Me.imgmostrarpanel.TabStop = False
        Me.imgmostrarpanel.Zoom = 10
        '
        'TimerLiberar
        '
        Me.TimerLiberar.Enabled = True
        Me.TimerLiberar.Interval = 1000
        '
        'frm_adm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(890, 490)
        Me.Controls.Add(Me.imgmostrarpanel)
        Me.Controls.Add(Me.panelmenus)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(672, 480)
        Me.Name = "frm_adm"
        Me.Opacity = 0.1R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confía Admin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panelconfiguracion.ResumeLayout(False)
        Me.panelusuarios.ResumeLayout(False)
        CType(Me.imgperfil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelmenus.ResumeLayout(False)
        CType(Me.imgmostrarpanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents panelmenus As System.Windows.Forms.Panel
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents imgperfil As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents notificaciones As ConfiaAdmin.MonoFlat.MonoFlat_NotificationBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton4 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Timerwidthmenos As System.Windows.Forms.Timer
    Friend WithEvents Timerwidthmas As System.Windows.Forms.Timer
    Friend WithEvents panelusuarios As System.Windows.Forms.Panel
    Friend WithEvents btnusuarios As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panelconfiguracion As System.Windows.Forms.Panel
    Friend WithEvents btnconfiguracion As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton7 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents imgmostrarpanel As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuFlatButton5 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton8 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BunifuFlatButton6 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents TimerLiberar As Timer
    Friend WithEvents MonoFlat_Button1 As MonoFlat.MonoFlat_Button
    Friend WithEvents MonoFlat_Button2 As MonoFlat.MonoFlat_Button
End Class
