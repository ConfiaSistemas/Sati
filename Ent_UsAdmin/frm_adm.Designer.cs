using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class frm_adm : Form
    {

        // Form reemplaza a Dispose para limpiar la lista de componentes.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Requerido por el Diseñador de Windows Forms
        private System.ComponentModel.IContainer components;

        // NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        // Se puede modificar usando el Diseñador de Windows Forms.  
        // No lo modifique con el editor de código.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_adm));
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel1 = new System.Windows.Forms.Panel();
            this.BunifuFlatButton9 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Actualizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.BunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.BunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.notificaciones = new ConfiaAdmin.MonoFlat.MonoFlat_NotificationBox();
            this.Panelconfiguracion = new System.Windows.Forms.Panel();
            this.btnconfiguracion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelusuarios = new System.Windows.Forms.Panel();
            this.btnusuarios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.imgperfil = new Bunifu.Framework.UI.BunifuImageButton();
            this.BunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelmenus = new System.Windows.Forms.Panel();
            this.MonoFlat_Button2 = new ConfiaAdmin.MonoFlat.MonoFlat_Button();
            this.MonoFlat_Button1 = new ConfiaAdmin.MonoFlat.MonoFlat_Button();
            this.BunifuFlatButton8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.Timerwidthmenos = new System.Windows.Forms.Timer(this.components);
            this.Timerwidthmas = new System.Windows.Forms.Timer(this.components);
            this.TimerLiberar = new System.Windows.Forms.Timer(this.components);
            this.TimerActualizacion = new System.Windows.Forms.Timer(this.components);
            this.BackgroundActualizacion = new System.ComponentModel.BackgroundWorker();
            this.BackgroundNotificaciones = new System.ComponentModel.BackgroundWorker();
            this.TimerNotificaciones = new System.Windows.Forms.Timer(this.components);
            this.BackgroundActSesion = new System.ComponentModel.BackgroundWorker();
            this.TimerActSesion = new System.Windows.Forms.Timer(this.components);
            this.imgmostrarpanel = new Bunifu.Framework.UI.BunifuImageButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StripStatusLabelDolar = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundDolar = new System.ComponentModel.BackgroundWorker();
            this.timerDolar = new System.Windows.Forms.Timer(this.components);
            this.backgroundEuro = new System.ComponentModel.BackgroundWorker();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StripStatusLabelEuro = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerEuro = new System.Windows.Forms.Timer(this.components);
            this.Panel1.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panelconfiguracion.SuspendLayout();
            this.panelusuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgperfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BunifuImageButton1)).BeginInit();
            this.panelmenus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgmostrarpanel)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.BunifuFlatButton9);
            this.Panel1.Controls.Add(this.btn_Actualizar);
            this.Panel1.Controls.Add(this.Panel4);
            this.Panel1.Controls.Add(this.Panel3);
            this.Panel1.Controls.Add(this.notificaciones);
            this.Panel1.Controls.Add(this.Panelconfiguracion);
            this.Panel1.Controls.Add(this.panelusuarios);
            this.Panel1.Controls.Add(this.imgperfil);
            this.Panel1.Controls.Add(this.BunifuImageButton1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(890, 66);
            this.Panel1.TabIndex = 0;
            // 
            // BunifuFlatButton9
            // 
            this.BunifuFlatButton9.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BunifuFlatButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BunifuFlatButton9.BorderRadius = 0;
            this.BunifuFlatButton9.ButtonText = "Cierres";
            this.BunifuFlatButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuFlatButton9.DisabledColor = System.Drawing.Color.Gray;
            this.BunifuFlatButton9.Iconcolor = System.Drawing.Color.Transparent;
            this.BunifuFlatButton9.Iconimage = global::ConfiaAdmin.My.Resources.Resources._109846;
            this.BunifuFlatButton9.Iconimage_right = null;
            this.BunifuFlatButton9.Iconimage_right_Selected = null;
            this.BunifuFlatButton9.Iconimage_Selected = null;
            this.BunifuFlatButton9.IconMarginLeft = 0;
            this.BunifuFlatButton9.IconMarginRight = 0;
            this.BunifuFlatButton9.IconRightVisible = true;
            this.BunifuFlatButton9.IconRightZoom = 0D;
            this.BunifuFlatButton9.IconVisible = true;
            this.BunifuFlatButton9.IconZoom = 90D;
            this.BunifuFlatButton9.IsTab = false;
            this.BunifuFlatButton9.Location = new System.Drawing.Point(413, 11);
            this.BunifuFlatButton9.Name = "BunifuFlatButton9";
            this.BunifuFlatButton9.Normalcolor = System.Drawing.Color.Empty;
            this.BunifuFlatButton9.OnHovercolor = System.Drawing.Color.Gray;
            this.BunifuFlatButton9.OnHoverTextColor = System.Drawing.Color.White;
            this.BunifuFlatButton9.selected = false;
            this.BunifuFlatButton9.Size = new System.Drawing.Size(90, 48);
            this.BunifuFlatButton9.TabIndex = 6;
            this.BunifuFlatButton9.Text = "Cierres";
            this.BunifuFlatButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BunifuFlatButton9.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.BunifuFlatButton9.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunifuFlatButton9.Click += new System.EventHandler(this.BunifuFlatButton9_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Actualizar.BorderRadius = 0;
            this.btn_Actualizar.ButtonText = "Hay una actualización";
            this.btn_Actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Actualizar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Actualizar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Actualizar.Iconimage = global::ConfiaAdmin.My.Resources.Resources._9261;
            this.btn_Actualizar.Iconimage_right = null;
            this.btn_Actualizar.Iconimage_right_Selected = null;
            this.btn_Actualizar.Iconimage_Selected = null;
            this.btn_Actualizar.IconMarginLeft = 0;
            this.btn_Actualizar.IconMarginRight = 0;
            this.btn_Actualizar.IconRightVisible = true;
            this.btn_Actualizar.IconRightZoom = 0D;
            this.btn_Actualizar.IconVisible = true;
            this.btn_Actualizar.IconZoom = 90D;
            this.btn_Actualizar.IsTab = false;
            this.btn_Actualizar.Location = new System.Drawing.Point(629, 6);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Normalcolor = System.Drawing.Color.Empty;
            this.btn_Actualizar.OnHovercolor = System.Drawing.Color.Gray;
            this.btn_Actualizar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Actualizar.selected = false;
            this.btn_Actualizar.Size = new System.Drawing.Size(135, 48);
            this.btn_Actualizar.TabIndex = 6;
            this.btn_Actualizar.Text = "Hay una actualización";
            this.btn_Actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Actualizar.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btn_Actualizar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Actualizar.Visible = false;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // Panel4
            // 
            this.Panel4.Controls.Add(this.BunifuFlatButton7);
            this.Panel4.Location = new System.Drawing.Point(510, 12);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(102, 45);
            this.Panel4.TabIndex = 8;
            // 
            // BunifuFlatButton7
            // 
            this.BunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BunifuFlatButton7.BorderRadius = 0;
            this.BunifuFlatButton7.ButtonText = "Grupos";
            this.BunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.BunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.BunifuFlatButton7.Iconimage = global::ConfiaAdmin.My.Resources.Resources.usuarios;
            this.BunifuFlatButton7.Iconimage_right = null;
            this.BunifuFlatButton7.Iconimage_right_Selected = null;
            this.BunifuFlatButton7.Iconimage_Selected = null;
            this.BunifuFlatButton7.IconMarginLeft = 0;
            this.BunifuFlatButton7.IconMarginRight = 0;
            this.BunifuFlatButton7.IconRightVisible = true;
            this.BunifuFlatButton7.IconRightZoom = 0D;
            this.BunifuFlatButton7.IconVisible = true;
            this.BunifuFlatButton7.IconZoom = 90D;
            this.BunifuFlatButton7.IsTab = false;
            this.BunifuFlatButton7.Location = new System.Drawing.Point(3, -3);
            this.BunifuFlatButton7.Name = "BunifuFlatButton7";
            this.BunifuFlatButton7.Normalcolor = System.Drawing.Color.Empty;
            this.BunifuFlatButton7.OnHovercolor = System.Drawing.Color.Gray;
            this.BunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.BunifuFlatButton7.selected = false;
            this.BunifuFlatButton7.Size = new System.Drawing.Size(105, 48);
            this.BunifuFlatButton7.TabIndex = 5;
            this.BunifuFlatButton7.Text = "Grupos";
            this.BunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BunifuFlatButton7.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.BunifuFlatButton7.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunifuFlatButton7.Click += new System.EventHandler(this.BunifuFlatButton7_Click);
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.BunifuFlatButton6);
            this.Panel3.Location = new System.Drawing.Point(317, 12);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(90, 45);
            this.Panel3.TabIndex = 7;
            // 
            // BunifuFlatButton6
            // 
            this.BunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BunifuFlatButton6.BorderRadius = 0;
            this.BunifuFlatButton6.ButtonText = "Retiros";
            this.BunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.BunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.BunifuFlatButton6.Iconimage = global::ConfiaAdmin.My.Resources.Resources._109846;
            this.BunifuFlatButton6.Iconimage_right = null;
            this.BunifuFlatButton6.Iconimage_right_Selected = null;
            this.BunifuFlatButton6.Iconimage_Selected = null;
            this.BunifuFlatButton6.IconMarginLeft = 0;
            this.BunifuFlatButton6.IconMarginRight = 0;
            this.BunifuFlatButton6.IconRightVisible = true;
            this.BunifuFlatButton6.IconRightZoom = 0D;
            this.BunifuFlatButton6.IconVisible = true;
            this.BunifuFlatButton6.IconZoom = 90D;
            this.BunifuFlatButton6.IsTab = false;
            this.BunifuFlatButton6.Location = new System.Drawing.Point(0, -1);
            this.BunifuFlatButton6.Name = "BunifuFlatButton6";
            this.BunifuFlatButton6.Normalcolor = System.Drawing.Color.Empty;
            this.BunifuFlatButton6.OnHovercolor = System.Drawing.Color.Gray;
            this.BunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.BunifuFlatButton6.selected = false;
            this.BunifuFlatButton6.Size = new System.Drawing.Size(90, 48);
            this.BunifuFlatButton6.TabIndex = 5;
            this.BunifuFlatButton6.Text = "Retiros";
            this.BunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BunifuFlatButton6.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.BunifuFlatButton6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunifuFlatButton6.Click += new System.EventHandler(this.BunifuFlatButton6_Click);
            // 
            // notificaciones
            // 
            this.notificaciones.BorderCurve = 30;
            this.notificaciones.Font = new System.Drawing.Font("Tahoma", 9F);
            this.notificaciones.Image = null;
            this.notificaciones.Location = new System.Drawing.Point(675, 6);
            this.notificaciones.MinimumSize = new System.Drawing.Size(100, 40);
            this.notificaciones.Name = "notificaciones";
            this.notificaciones.NotificationType = ConfiaAdmin.MonoFlat.MonoFlat_NotificationBox.Type.Notice;
            this.notificaciones.RoundCorners = true;
            this.notificaciones.ShowCloseButton = false;
            this.notificaciones.Size = new System.Drawing.Size(157, 52);
            this.notificaciones.TabIndex = 3;
            this.notificaciones.Text = ".";
            this.notificaciones.Click += new System.EventHandler(this.notificaciones_Click);
            // 
            // Panelconfiguracion
            // 
            this.Panelconfiguracion.Controls.Add(this.btnconfiguracion);
            this.Panelconfiguracion.Location = new System.Drawing.Point(172, 15);
            this.Panelconfiguracion.Name = "Panelconfiguracion";
            this.Panelconfiguracion.Size = new System.Drawing.Size(148, 45);
            this.Panelconfiguracion.TabIndex = 6;
            // 
            // btnconfiguracion
            // 
            this.btnconfiguracion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnconfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnconfiguracion.BorderRadius = 0;
            this.btnconfiguracion.ButtonText = "Configuración";
            this.btnconfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconfiguracion.DisabledColor = System.Drawing.Color.Gray;
            this.btnconfiguracion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnconfiguracion.Iconimage = global::ConfiaAdmin.My.Resources.Resources.config;
            this.btnconfiguracion.Iconimage_right = null;
            this.btnconfiguracion.Iconimage_right_Selected = null;
            this.btnconfiguracion.Iconimage_Selected = null;
            this.btnconfiguracion.IconMarginLeft = 0;
            this.btnconfiguracion.IconMarginRight = 0;
            this.btnconfiguracion.IconRightVisible = true;
            this.btnconfiguracion.IconRightZoom = 0D;
            this.btnconfiguracion.IconVisible = true;
            this.btnconfiguracion.IconZoom = 90D;
            this.btnconfiguracion.IsTab = false;
            this.btnconfiguracion.Location = new System.Drawing.Point(3, -4);
            this.btnconfiguracion.Name = "btnconfiguracion";
            this.btnconfiguracion.Normalcolor = System.Drawing.Color.Empty;
            this.btnconfiguracion.OnHovercolor = System.Drawing.Color.Gray;
            this.btnconfiguracion.OnHoverTextColor = System.Drawing.Color.White;
            this.btnconfiguracion.selected = false;
            this.btnconfiguracion.Size = new System.Drawing.Size(145, 48);
            this.btnconfiguracion.TabIndex = 5;
            this.btnconfiguracion.Text = "Configuración";
            this.btnconfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconfiguracion.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnconfiguracion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfiguracion.Click += new System.EventHandler(this.btnconfiguracion_Click_1);
            // 
            // panelusuarios
            // 
            this.panelusuarios.Controls.Add(this.btnusuarios);
            this.panelusuarios.Location = new System.Drawing.Point(52, 13);
            this.panelusuarios.Name = "panelusuarios";
            this.panelusuarios.Size = new System.Drawing.Size(111, 45);
            this.panelusuarios.TabIndex = 4;
            // 
            // btnusuarios
            // 
            this.btnusuarios.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnusuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnusuarios.BorderRadius = 0;
            this.btnusuarios.ButtonText = "Usuarios";
            this.btnusuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnusuarios.DisabledColor = System.Drawing.Color.Gray;
            this.btnusuarios.Iconcolor = System.Drawing.Color.Transparent;
            this.btnusuarios.Iconimage = global::ConfiaAdmin.My.Resources.Resources.usuarios;
            this.btnusuarios.Iconimage_right = null;
            this.btnusuarios.Iconimage_right_Selected = null;
            this.btnusuarios.Iconimage_Selected = null;
            this.btnusuarios.IconMarginLeft = 0;
            this.btnusuarios.IconMarginRight = 0;
            this.btnusuarios.IconRightVisible = true;
            this.btnusuarios.IconRightZoom = 0D;
            this.btnusuarios.IconVisible = true;
            this.btnusuarios.IconZoom = 90D;
            this.btnusuarios.IsTab = false;
            this.btnusuarios.Location = new System.Drawing.Point(3, -2);
            this.btnusuarios.Name = "btnusuarios";
            this.btnusuarios.Normalcolor = System.Drawing.Color.Empty;
            this.btnusuarios.OnHovercolor = System.Drawing.Color.Gray;
            this.btnusuarios.OnHoverTextColor = System.Drawing.Color.White;
            this.btnusuarios.selected = false;
            this.btnusuarios.Size = new System.Drawing.Size(111, 48);
            this.btnusuarios.TabIndex = 5;
            this.btnusuarios.Text = "Usuarios";
            this.btnusuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnusuarios.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnusuarios.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusuarios.Click += new System.EventHandler(this.btnusuarios_Click);
            // 
            // imgperfil
            // 
            this.imgperfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.imgperfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgperfil.Image = global::ConfiaAdmin.My.Resources.Resources.usuario;
            this.imgperfil.ImageActive = null;
            this.imgperfil.Location = new System.Drawing.Point(838, 13);
            this.imgperfil.Name = "imgperfil";
            this.imgperfil.Size = new System.Drawing.Size(45, 43);
            this.imgperfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgperfil.TabIndex = 2;
            this.imgperfil.TabStop = false;
            this.imgperfil.Zoom = 10;
            this.imgperfil.Click += new System.EventHandler(this.imgperfil_Click);
            // 
            // BunifuImageButton1
            // 
            this.BunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.BunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuImageButton1.Image = global::ConfiaAdmin.My.Resources.Resources.menu_alt_256;
            this.BunifuImageButton1.ImageActive = null;
            this.BunifuImageButton1.Location = new System.Drawing.Point(3, 13);
            this.BunifuImageButton1.Name = "BunifuImageButton1";
            this.BunifuImageButton1.Size = new System.Drawing.Size(48, 47);
            this.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BunifuImageButton1.TabIndex = 1;
            this.BunifuImageButton1.TabStop = false;
            this.BunifuImageButton1.Zoom = 10;
            this.BunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // panelmenus
            // 
            this.panelmenus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelmenus.Controls.Add(this.MonoFlat_Button2);
            this.panelmenus.Controls.Add(this.MonoFlat_Button1);
            this.panelmenus.Controls.Add(this.BunifuFlatButton8);
            this.panelmenus.Controls.Add(this.BunifuFlatButton5);
            this.panelmenus.Controls.Add(this.BunifuFlatButton4);
            this.panelmenus.Controls.Add(this.BunifuFlatButton3);
            this.panelmenus.Controls.Add(this.BunifuFlatButton2);
            this.panelmenus.Controls.Add(this.BunifuFlatButton1);
            this.panelmenus.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenus.Location = new System.Drawing.Point(0, 66);
            this.panelmenus.Name = "panelmenus";
            this.panelmenus.Size = new System.Drawing.Size(258, 424);
            this.panelmenus.TabIndex = 1;
            // 
            // MonoFlat_Button2
            // 
            this.MonoFlat_Button2.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MonoFlat_Button2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MonoFlat_Button2.Image = null;
            this.MonoFlat_Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MonoFlat_Button2.Location = new System.Drawing.Point(12, 386);
            this.MonoFlat_Button2.Name = "MonoFlat_Button2";
            this.MonoFlat_Button2.Size = new System.Drawing.Size(214, 26);
            this.MonoFlat_Button2.TabIndex = 12;
            this.MonoFlat_Button2.Text = "Solicitudes de Empeño";
            this.MonoFlat_Button2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.MonoFlat_Button2.Click += new System.EventHandler(this.MonoFlat_Button2_Click);
            // 
            // MonoFlat_Button1
            // 
            this.MonoFlat_Button1.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MonoFlat_Button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MonoFlat_Button1.Image = null;
            this.MonoFlat_Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MonoFlat_Button1.Location = new System.Drawing.Point(12, 338);
            this.MonoFlat_Button1.Name = "MonoFlat_Button1";
            this.MonoFlat_Button1.Size = new System.Drawing.Size(214, 26);
            this.MonoFlat_Button1.TabIndex = 11;
            this.MonoFlat_Button1.Text = "Empeños por Entregar";
            this.MonoFlat_Button1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.MonoFlat_Button1.Click += new System.EventHandler(this.MonoFlat_Button1_Click);
            // 
            // BunifuFlatButton8
            // 
            this.BunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.BunifuFlatButton8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BunifuFlatButton8.BorderRadius = 0;
            this.BunifuFlatButton8.ButtonText = "Reportes";
            this.BunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray;
            this.BunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.BunifuFlatButton8.Iconimage = global::ConfiaAdmin.My.Resources.Resources.icono_reportes;
            this.BunifuFlatButton8.Iconimage_right = null;
            this.BunifuFlatButton8.Iconimage_right_Selected = null;
            this.BunifuFlatButton8.Iconimage_Selected = null;
            this.BunifuFlatButton8.IconMarginLeft = 0;
            this.BunifuFlatButton8.IconMarginRight = 0;
            this.BunifuFlatButton8.IconRightVisible = true;
            this.BunifuFlatButton8.IconRightZoom = 0D;
            this.BunifuFlatButton8.IconVisible = true;
            this.BunifuFlatButton8.IconZoom = 90D;
            this.BunifuFlatButton8.IsTab = true;
            this.BunifuFlatButton8.Location = new System.Drawing.Point(3, 218);
            this.BunifuFlatButton8.Name = "BunifuFlatButton8";
            this.BunifuFlatButton8.Normalcolor = System.Drawing.SystemColors.ButtonFace;
            this.BunifuFlatButton8.OnHovercolor = System.Drawing.Color.Gray;
            this.BunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White;
            this.BunifuFlatButton8.selected = false;
            this.BunifuFlatButton8.Size = new System.Drawing.Size(258, 48);
            this.BunifuFlatButton8.TabIndex = 6;
            this.BunifuFlatButton8.Text = "Reportes";
            this.BunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BunifuFlatButton8.Textcolor = System.Drawing.Color.Black;
            this.BunifuFlatButton8.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunifuFlatButton8.Click += new System.EventHandler(this.BunifuFlatButton8_Click);
            // 
            // BunifuFlatButton5
            // 
            this.BunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.BunifuFlatButton5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BunifuFlatButton5.BorderRadius = 0;
            this.BunifuFlatButton5.ButtonText = "Cerrar Empresa";
            this.BunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.BunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.BunifuFlatButton5.Iconimage = global::ConfiaAdmin.My.Resources.Resources.icono_cerrar_empresa;
            this.BunifuFlatButton5.Iconimage_right = null;
            this.BunifuFlatButton5.Iconimage_right_Selected = null;
            this.BunifuFlatButton5.Iconimage_Selected = null;
            this.BunifuFlatButton5.IconMarginLeft = 0;
            this.BunifuFlatButton5.IconMarginRight = 0;
            this.BunifuFlatButton5.IconRightVisible = true;
            this.BunifuFlatButton5.IconRightZoom = 0D;
            this.BunifuFlatButton5.IconVisible = true;
            this.BunifuFlatButton5.IconZoom = 90D;
            this.BunifuFlatButton5.IsTab = false;
            this.BunifuFlatButton5.Location = new System.Drawing.Point(0, 272);
            this.BunifuFlatButton5.Name = "BunifuFlatButton5";
            this.BunifuFlatButton5.Normalcolor = System.Drawing.SystemColors.ButtonFace;
            this.BunifuFlatButton5.OnHovercolor = System.Drawing.Color.Gray;
            this.BunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.BunifuFlatButton5.selected = false;
            this.BunifuFlatButton5.Size = new System.Drawing.Size(258, 48);
            this.BunifuFlatButton5.TabIndex = 5;
            this.BunifuFlatButton5.Text = "Cerrar Empresa";
            this.BunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BunifuFlatButton5.Textcolor = System.Drawing.Color.Black;
            this.BunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunifuFlatButton5.Visible = false;
            this.BunifuFlatButton5.Click += new System.EventHandler(this.BunifuFlatButton5_Click);
            // 
            // BunifuFlatButton4
            // 
            this.BunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.BunifuFlatButton4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BunifuFlatButton4.BorderRadius = 0;
            this.BunifuFlatButton4.ButtonText = "Créditos por entregar";
            this.BunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.BunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.BunifuFlatButton4.Iconimage = global::ConfiaAdmin.My.Resources.Resources.eaad3b05_c22d_49fb_ae4f_2d0e4ff7b0cb;
            this.BunifuFlatButton4.Iconimage_right = null;
            this.BunifuFlatButton4.Iconimage_right_Selected = null;
            this.BunifuFlatButton4.Iconimage_Selected = null;
            this.BunifuFlatButton4.IconMarginLeft = 0;
            this.BunifuFlatButton4.IconMarginRight = 0;
            this.BunifuFlatButton4.IconRightVisible = true;
            this.BunifuFlatButton4.IconRightZoom = 0D;
            this.BunifuFlatButton4.IconVisible = true;
            this.BunifuFlatButton4.IconZoom = 90D;
            this.BunifuFlatButton4.IsTab = true;
            this.BunifuFlatButton4.Location = new System.Drawing.Point(0, 164);
            this.BunifuFlatButton4.Name = "BunifuFlatButton4";
            this.BunifuFlatButton4.Normalcolor = System.Drawing.SystemColors.ButtonFace;
            this.BunifuFlatButton4.OnHovercolor = System.Drawing.Color.Gray;
            this.BunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.BunifuFlatButton4.selected = false;
            this.BunifuFlatButton4.Size = new System.Drawing.Size(258, 48);
            this.BunifuFlatButton4.TabIndex = 4;
            this.BunifuFlatButton4.Text = "Créditos por entregar";
            this.BunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BunifuFlatButton4.Textcolor = System.Drawing.Color.Black;
            this.BunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunifuFlatButton4.Click += new System.EventHandler(this.BunifuFlatButton4_Click);
            // 
            // BunifuFlatButton3
            // 
            this.BunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.BunifuFlatButton3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BunifuFlatButton3.BorderRadius = 0;
            this.BunifuFlatButton3.ButtonText = "Solicitudes";
            this.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.BunifuFlatButton3.Iconimage = global::ConfiaAdmin.My.Resources.Resources.icono_solicitudes;
            this.BunifuFlatButton3.Iconimage_right = null;
            this.BunifuFlatButton3.Iconimage_right_Selected = null;
            this.BunifuFlatButton3.Iconimage_Selected = null;
            this.BunifuFlatButton3.IconMarginLeft = 0;
            this.BunifuFlatButton3.IconMarginRight = 0;
            this.BunifuFlatButton3.IconRightVisible = true;
            this.BunifuFlatButton3.IconRightZoom = 0D;
            this.BunifuFlatButton3.IconVisible = true;
            this.BunifuFlatButton3.IconZoom = 90D;
            this.BunifuFlatButton3.IsTab = true;
            this.BunifuFlatButton3.Location = new System.Drawing.Point(1, 110);
            this.BunifuFlatButton3.Name = "BunifuFlatButton3";
            this.BunifuFlatButton3.Normalcolor = System.Drawing.SystemColors.ButtonFace;
            this.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.Gray;
            this.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.BunifuFlatButton3.selected = false;
            this.BunifuFlatButton3.Size = new System.Drawing.Size(258, 48);
            this.BunifuFlatButton3.TabIndex = 3;
            this.BunifuFlatButton3.Text = "Solicitudes";
            this.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BunifuFlatButton3.Textcolor = System.Drawing.Color.Black;
            this.BunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunifuFlatButton3.Click += new System.EventHandler(this.BunifuFlatButton3_Click);
            // 
            // BunifuFlatButton2
            // 
            this.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.BunifuFlatButton2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BunifuFlatButton2.BorderRadius = 0;
            this.BunifuFlatButton2.ButtonText = "Catálogos";
            this.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.BunifuFlatButton2.Iconimage = global::ConfiaAdmin.My.Resources.Resources.icono_catalogos;
            this.BunifuFlatButton2.Iconimage_right = null;
            this.BunifuFlatButton2.Iconimage_right_Selected = null;
            this.BunifuFlatButton2.Iconimage_Selected = null;
            this.BunifuFlatButton2.IconMarginLeft = 0;
            this.BunifuFlatButton2.IconMarginRight = 0;
            this.BunifuFlatButton2.IconRightVisible = true;
            this.BunifuFlatButton2.IconRightZoom = 0D;
            this.BunifuFlatButton2.IconVisible = true;
            this.BunifuFlatButton2.IconZoom = 90D;
            this.BunifuFlatButton2.IsTab = true;
            this.BunifuFlatButton2.Location = new System.Drawing.Point(1, 56);
            this.BunifuFlatButton2.Name = "BunifuFlatButton2";
            this.BunifuFlatButton2.Normalcolor = System.Drawing.SystemColors.ButtonFace;
            this.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.Gray;
            this.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.BunifuFlatButton2.selected = false;
            this.BunifuFlatButton2.Size = new System.Drawing.Size(258, 48);
            this.BunifuFlatButton2.TabIndex = 2;
            this.BunifuFlatButton2.Text = "Catálogos";
            this.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BunifuFlatButton2.Textcolor = System.Drawing.Color.Black;
            this.BunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunifuFlatButton2.Click += new System.EventHandler(this.BunifuFlatButton2_Click);
            // 
            // BunifuFlatButton1
            // 
            this.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.BunifuFlatButton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BunifuFlatButton1.BorderRadius = 0;
            this.BunifuFlatButton1.ButtonText = "Inicio";
            this.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.BunifuFlatButton1.Iconimage = global::ConfiaAdmin.My.Resources.Resources.icono_home;
            this.BunifuFlatButton1.Iconimage_right = null;
            this.BunifuFlatButton1.Iconimage_right_Selected = null;
            this.BunifuFlatButton1.Iconimage_Selected = null;
            this.BunifuFlatButton1.IconMarginLeft = 0;
            this.BunifuFlatButton1.IconMarginRight = 0;
            this.BunifuFlatButton1.IconRightVisible = true;
            this.BunifuFlatButton1.IconRightZoom = 0D;
            this.BunifuFlatButton1.IconVisible = true;
            this.BunifuFlatButton1.IconZoom = 90D;
            this.BunifuFlatButton1.IsTab = true;
            this.BunifuFlatButton1.Location = new System.Drawing.Point(1, 2);
            this.BunifuFlatButton1.Name = "BunifuFlatButton1";
            this.BunifuFlatButton1.Normalcolor = System.Drawing.SystemColors.ButtonFace;
            this.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.Gray;
            this.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.BunifuFlatButton1.selected = false;
            this.BunifuFlatButton1.Size = new System.Drawing.Size(258, 48);
            this.BunifuFlatButton1.TabIndex = 1;
            this.BunifuFlatButton1.Text = "Inicio";
            this.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BunifuFlatButton1.Textcolor = System.Drawing.Color.Black;
            this.BunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunifuFlatButton1.Click += new System.EventHandler(this.BunifuFlatButton1_Click);
            // 
            // Timer2
            // 
            this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Timerwidthmenos
            // 
            this.Timerwidthmenos.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // Timerwidthmas
            // 
            this.Timerwidthmas.Tick += new System.EventHandler(this.Timerwidthmas_Tick);
            // 
            // TimerLiberar
            // 
            this.TimerLiberar.Enabled = true;
            this.TimerLiberar.Interval = 1000;
            this.TimerLiberar.Tick += new System.EventHandler(this.TimerLiberar_Tick);
            // 
            // TimerActualizacion
            // 
            this.TimerActualizacion.Enabled = true;
            this.TimerActualizacion.Interval = 1000;
            this.TimerActualizacion.Tick += new System.EventHandler(this.TimerActualizacion_Tick);
            // 
            // BackgroundActualizacion
            // 
            this.BackgroundActualizacion.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundActualizacion_DoWork);
            this.BackgroundActualizacion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundActualizacion_RunWorkerCompleted);
            // 
            // BackgroundNotificaciones
            // 
            this.BackgroundNotificaciones.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundNotificaciones_DoWork);
            // 
            // TimerNotificaciones
            // 
            this.TimerNotificaciones.Enabled = true;
            this.TimerNotificaciones.Interval = 1000;
            this.TimerNotificaciones.Tick += new System.EventHandler(this.TimerNotificaciones_Tick);
            // 
            // BackgroundActSesion
            // 
            this.BackgroundActSesion.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundActSesion_DoWork);
            // 
            // TimerActSesion
            // 
            this.TimerActSesion.Enabled = true;
            this.TimerActSesion.Interval = 1000;
            this.TimerActSesion.Tick += new System.EventHandler(this.TimerActSesion_Tick);
            // 
            // imgmostrarpanel
            // 
            this.imgmostrarpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.imgmostrarpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgmostrarpanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgmostrarpanel.Image = global::ConfiaAdmin.My.Resources.Resources.mostrar1;
            this.imgmostrarpanel.ImageActive = null;
            this.imgmostrarpanel.Location = new System.Drawing.Point(561, 122);
            this.imgmostrarpanel.Name = "imgmostrarpanel";
            this.imgmostrarpanel.Size = new System.Drawing.Size(12, 47);
            this.imgmostrarpanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgmostrarpanel.TabIndex = 9;
            this.imgmostrarpanel.TabStop = false;
            this.imgmostrarpanel.Zoom = 10;
            this.imgmostrarpanel.Click += new System.EventHandler(this.imgmostrarpanel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel1,
            this.StripStatusLabelDolar,
            this.toolStripStatusLabel1,
            this.StripStatusLabelEuro});
            this.statusStrip1.Location = new System.Drawing.Point(258, 468);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(632, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(89, 17);
            this.StatusLabel1.Text = "Precio del dólar";
            // 
            // StripStatusLabelDolar
            // 
            this.StripStatusLabelDolar.BackColor = System.Drawing.Color.Transparent;
            this.StripStatusLabelDolar.Name = "StripStatusLabelDolar";
            this.StripStatusLabelDolar.Size = new System.Drawing.Size(16, 17);
            this.StripStatusLabelDolar.Text = "...";
            // 
            // backgroundDolar
            // 
            this.backgroundDolar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundDolar_DoWork);
            this.backgroundDolar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundDolar_Completed);
            // 
            // timerDolar
            // 
            this.timerDolar.Interval = 1000;
            this.timerDolar.Tick += new System.EventHandler(this.timerDolar_Tick);
            // 
            // backgroundEuro
            // 
            this.backgroundEuro.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundEuro_DoWork);
            this.backgroundEuro.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundEuro_RunWorkerCompleted);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(89, 17);
            this.toolStripStatusLabel1.Text = "Precio del euro:";
            // 
            // StripStatusLabelEuro
            // 
            this.StripStatusLabelEuro.BackColor = System.Drawing.Color.Transparent;
            this.StripStatusLabelEuro.Name = "StripStatusLabelEuro";
            this.StripStatusLabelEuro.Size = new System.Drawing.Size(16, 17);
            this.StripStatusLabelEuro.Text = "...";
            // 
            // timerEuro
            // 
            this.timerEuro.Interval = 1000;
            this.timerEuro.Tick += new System.EventHandler(this.timer3_Tick_1);
            // 
            // frm_adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(890, 490);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.imgmostrarpanel);
            this.Controls.Add(this.panelmenus);
            this.Controls.Add(this.Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(672, 480);
            this.Name = "frm_adm";
            this.Opacity = 0.1D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confía Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frm_adm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_adm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_adm_FormClosed);
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.LocationChanged += new System.EventHandler(this.frm_adm_LocationChanged);
            this.SizeChanged += new System.EventHandler(this.frm_adm_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_adm_KeyDown);
            this.LostFocus += new System.EventHandler(this.frm_adm_LostFocus);
            this.ImeModeChanged += new System.EventHandler(this.frm_adm_ImeModeChanged);
            this.Disposed += new System.EventHandler(this.frm_adm_Disposed);
            this.Panel1.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panelconfiguracion.ResumeLayout(false);
            this.panelusuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgperfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BunifuImageButton1)).EndInit();
            this.panelmenus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgmostrarpanel)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal Timer Timer1;
        internal Panel Panel1;
        internal Bunifu.Framework.UI.BunifuImageButton BunifuImageButton1;
        internal Panel panelmenus;
        internal Bunifu.Framework.UI.BunifuFlatButton BunifuFlatButton1;
        internal Bunifu.Framework.UI.BunifuFlatButton BunifuFlatButton2;
        internal Bunifu.Framework.UI.BunifuImageButton imgperfil;
        internal MonoFlat.MonoFlat_NotificationBox notificaciones;
        internal Timer Timer2;
        internal Bunifu.Framework.UI.BunifuFlatButton BunifuFlatButton3;
        internal Bunifu.Framework.UI.BunifuFlatButton BunifuFlatButton4;
        internal Timer Timerwidthmenos;
        internal Timer Timerwidthmas;
        internal Panel panelusuarios;
        internal Bunifu.Framework.UI.BunifuFlatButton btnusuarios;
        internal Panel Panelconfiguracion;
        internal Bunifu.Framework.UI.BunifuFlatButton btnconfiguracion;
        internal Bunifu.Framework.UI.BunifuImageButton imgmostrarpanel;
        internal Bunifu.Framework.UI.BunifuFlatButton BunifuFlatButton5;
        internal Bunifu.Framework.UI.BunifuFlatButton BunifuFlatButton8;
        internal Panel Panel3;
        internal Bunifu.Framework.UI.BunifuFlatButton BunifuFlatButton6;
        internal Timer TimerLiberar;
        internal MonoFlat.MonoFlat_Button MonoFlat_Button1;
        internal MonoFlat.MonoFlat_Button MonoFlat_Button2;
        internal Bunifu.Framework.UI.BunifuFlatButton btn_Actualizar;
        internal Timer TimerActualizacion;
        internal System.ComponentModel.BackgroundWorker BackgroundActualizacion;
        internal System.ComponentModel.BackgroundWorker BackgroundNotificaciones;
        internal Timer TimerNotificaciones;
        internal System.ComponentModel.BackgroundWorker BackgroundActSesion;
        internal Timer TimerActSesion;
        internal Bunifu.Framework.UI.BunifuFlatButton BunifuFlatButton9;
        internal Panel Panel4;
        internal Bunifu.Framework.UI.BunifuFlatButton BunifuFlatButton7;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StatusLabel1;
        private ToolStripStatusLabel StripStatusLabelDolar;
        private System.ComponentModel.BackgroundWorker backgroundDolar;
        private Timer timerDolar;
        private System.ComponentModel.BackgroundWorker backgroundEuro;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel StripStatusLabelEuro;
        private Timer timerEuro;
    }
}