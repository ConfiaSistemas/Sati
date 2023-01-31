using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Agregar_Usuario : Form
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_Usuario));
            Label1 = new Label();
            Panel1 = new Panel();
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            EvolveControlBox1 = new EvolveControlBox();
            txtnombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            txtcontra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            lblcontraseña = new Label();
            dateusr = new Bunifu.Framework.UI.BunifuDatepicker();
            Label2 = new Label();
            Label3 = new Label();
            txtusuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label4 = new Label();
            lblgrupo = new Label();
            lblcdggrp = new Label();
            lblnmgrp = new Label();
            txtgrupo = new TextBox();
            txtgrupo.TextChanged += new EventHandler(txtgrupo_TextChanged);
            FlowLayoutPanel1 = new FlowLayoutPanel();
            timerformato = new Timer(components);
            timerformato.Tick += new EventHandler(timerformato_Tick);
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Switchactivo = new Bunifu.Framework.UI.BunifuiOSSwitch();
            Label5 = new Label();
            Label5.Click += new EventHandler(Label5_Click);
            btn_agregar = new Bunifu.Framework.UI.BunifuThinButton2();
            btn_agregar.Click += new EventHandler(btn_actualizar_Click);
            txtempleado = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            txtempleado.OnValueChanged += new EventHandler(txtempleado_OnValueChanged);
            txtempleado.KeyDown += new KeyEventHandler(txtempleado_KeyDown);
            Label6 = new Label();
            lblempleado = new Label();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(35, 114);
            Label1.Name = "Label1";
            Label1.Size = new Size(44, 13);
            Label1.TabIndex = 0;
            Label1.Text = "Nombre";
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Location = new Point(0, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(463, 36);
            Panel1.TabIndex = 1;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 0);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(148, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Dar de alta usuarios";
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(392, 4);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 0;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // txtnombre
            // 
            txtnombre.Cursor = Cursors.IBeam;
            txtnombre.Font = new Font("Century Gothic", 9.75f);
            txtnombre.ForeColor = Color.FromArgb(223, 223, 223);
            txtnombre.HintForeColor = Color.White;
            txtnombre.HintText = "";
            txtnombre.isPassword = false;
            txtnombre.LineFocusedColor = Color.Blue;
            txtnombre.LineIdleColor = Color.Gray;
            txtnombre.LineMouseHoverColor = Color.Blue;
            txtnombre.LineThickness = 3;
            txtnombre.Location = new Point(38, 131);
            txtnombre.Margin = new Padding(4);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(379, 33);
            txtnombre.TabIndex = 2;
            txtnombre.TextAlign = HorizontalAlignment.Left;
            // 
            // txtcontra
            // 
            txtcontra.Cursor = Cursors.IBeam;
            txtcontra.Font = new Font("Century Gothic", 9.75f);
            txtcontra.ForeColor = Color.FromArgb(223, 223, 223);
            txtcontra.HintForeColor = Color.White;
            txtcontra.HintText = "";
            txtcontra.isPassword = true;
            txtcontra.LineFocusedColor = Color.Blue;
            txtcontra.LineIdleColor = Color.Gray;
            txtcontra.LineMouseHoverColor = Color.Blue;
            txtcontra.LineThickness = 3;
            txtcontra.Location = new Point(38, 194);
            txtcontra.Margin = new Padding(4);
            txtcontra.Name = "txtcontra";
            txtcontra.Size = new Size(379, 33);
            txtcontra.TabIndex = 4;
            txtcontra.TextAlign = HorizontalAlignment.Left;
            // 
            // lblcontraseña
            // 
            lblcontraseña.AutoSize = true;
            lblcontraseña.ForeColor = Color.White;
            lblcontraseña.Location = new Point(35, 182);
            lblcontraseña.Name = "lblcontraseña";
            lblcontraseña.Size = new Size(61, 13);
            lblcontraseña.TabIndex = 3;
            lblcontraseña.Text = "Contraseña";
            // 
            // dateusr
            // 
            dateusr.BackColor = Color.FromArgb(0, 5, 11);
            dateusr.BorderRadius = 0;
            dateusr.ForeColor = Color.White;
            dateusr.Format = DateTimePickerFormat.Custom;
            dateusr.FormatCustom = null;
            dateusr.Location = new Point(26, 279);
            dateusr.Name = "dateusr";
            dateusr.Size = new Size(177, 36);
            dateusr.TabIndex = 5;
            dateusr.Value = new DateTime(2018, 2, 8, 0, 0, 0, 0);
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(35, 249);
            Label2.Name = "Label2";
            Label2.Size = new Size(73, 13);
            Label2.TabIndex = 6;
            Label2.Text = "Fecha de Alta";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.ForeColor = Color.White;
            Label3.Location = new Point(339, 45);
            Label3.Name = "Label3";
            Label3.Size = new Size(37, 13);
            Label3.TabIndex = 8;
            Label3.Text = "Activo";
            // 
            // txtusuario
            // 
            txtusuario.Cursor = Cursors.IBeam;
            txtusuario.Font = new Font("Century Gothic", 9.75f);
            txtusuario.ForeColor = Color.FromArgb(223, 223, 223);
            txtusuario.HintForeColor = Color.White;
            txtusuario.HintText = "";
            txtusuario.isPassword = false;
            txtusuario.LineFocusedColor = Color.Blue;
            txtusuario.LineIdleColor = Color.Gray;
            txtusuario.LineMouseHoverColor = Color.Blue;
            txtusuario.LineThickness = 3;
            txtusuario.Location = new Point(38, 69);
            txtusuario.Margin = new Padding(4);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(379, 33);
            txtusuario.TabIndex = 10;
            txtusuario.TextAlign = HorizontalAlignment.Left;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.ForeColor = Color.White;
            Label4.Location = new Point(35, 52);
            Label4.Name = "Label4";
            Label4.Size = new Size(43, 13);
            Label4.TabIndex = 9;
            Label4.Text = "Usuario";
            // 
            // lblgrupo
            // 
            lblgrupo.AutoSize = true;
            lblgrupo.ForeColor = Color.White;
            lblgrupo.Location = new Point(219, 249);
            lblgrupo.Name = "lblgrupo";
            lblgrupo.Size = new Size(36, 13);
            lblgrupo.TabIndex = 11;
            lblgrupo.Text = "Grupo";
            // 
            // lblcdggrp
            // 
            lblcdggrp.AutoSize = true;
            lblcdggrp.ForeColor = Color.White;
            lblcdggrp.Location = new Point(297, 269);
            lblcdggrp.Name = "lblcdggrp";
            lblcdggrp.Size = new Size(33, 13);
            lblcdggrp.TabIndex = 13;
            lblcdggrp.Text = "Label";
            // 
            // lblnmgrp
            // 
            lblnmgrp.ForeColor = Color.White;
            lblnmgrp.Location = new Point(297, 287);
            lblnmgrp.Name = "lblnmgrp";
            lblnmgrp.Size = new Size(133, 43);
            lblnmgrp.TabIndex = 14;
            lblnmgrp.Text = "Label";
            // 
            // txtgrupo
            // 
            txtgrupo.Location = new Point(222, 279);
            txtgrupo.Name = "txtgrupo";
            txtgrupo.Size = new Size(47, 20);
            txtgrupo.TabIndex = 15;
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.AutoScroll = true;
            FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            FlowLayoutPanel1.Location = new Point(55, 109);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(200, 151);
            FlowLayoutPanel1.TabIndex = 17;
            FlowLayoutPanel1.Visible = false;
            // 
            // timerformato
            // 
            // 
            // Button1
            // 
            Button1.BackColor = Color.FromArgb(233, 233, 233);
            Button1.BackgroundImage = My.Resources.Resources._196766_200;
            Button1.BackgroundImageLayout = ImageLayout.Stretch;
            Button1.FlatAppearance.MouseDownBackColor = Color.Silver;
            Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 246, 245);
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.Location = new Point(267, 279);
            Button1.Name = "Button1";
            Button1.Size = new Size(16, 20);
            Button1.TabIndex = 16;
            Button1.UseVisualStyleBackColor = false;
            // 
            // Switchactivo
            // 
            Switchactivo.BackColor = Color.Transparent;
            Switchactivo.BackgroundImage = (Image)resources.GetObject("Switchactivo.BackgroundImage");
            Switchactivo.BackgroundImageLayout = ImageLayout.Stretch;
            Switchactivo.Cursor = Cursors.Hand;
            Switchactivo.Location = new Point(382, 42);
            Switchactivo.Name = "Switchactivo";
            Switchactivo.OffColor = Color.Gray;
            Switchactivo.OnColor = Color.FromArgb(82, 60, 53);
            Switchactivo.Size = new Size(35, 20);
            Switchactivo.TabIndex = 7;
            Switchactivo.Value = true;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = Color.DimGray;
            Label5.FlatStyle = FlatStyle.Flat;
            Label5.Image = My.Resources.Resources.ojochico;
            Label5.Location = new Point(389, 182);
            Label5.Name = "Label5";
            Label5.Size = new Size(28, 13);
            Label5.TabIndex = 18;
            Label5.Text = "       ";
            // 
            // btn_agregar
            // 
            btn_agregar.ActiveBorderThickness = 1;
            btn_agregar.ActiveCornerRadius = 20;
            btn_agregar.ActiveFillColor = Color.FromArgb(14, 21, 38);
            btn_agregar.ActiveForecolor = Color.White;
            btn_agregar.ActiveLineColor = Color.SeaGreen;
            btn_agregar.BackColor = Color.FromArgb(0, 5, 11);
            btn_agregar.BackgroundImage = (Image)resources.GetObject("btn_agregar.BackgroundImage");
            btn_agregar.ButtonText = "Dar de alta";
            btn_agregar.Cursor = Cursors.Hand;
            btn_agregar.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_agregar.ForeColor = Color.DarkBlue;
            btn_agregar.IdleBorderThickness = 1;
            btn_agregar.IdleCornerRadius = 20;
            btn_agregar.IdleFillColor = Color.White;
            btn_agregar.IdleForecolor = Color.Gray;
            btn_agregar.IdleLineColor = Color.FromArgb(14, 21, 38);
            btn_agregar.Location = new Point(123, 411);
            btn_agregar.Margin = new Padding(5);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(207, 38);
            btn_agregar.TabIndex = 19;
            btn_agregar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtempleado
            // 
            txtempleado.Cursor = Cursors.IBeam;
            txtempleado.Font = new Font("Century Gothic", 9.75f);
            txtempleado.ForeColor = Color.FromArgb(223, 223, 223);
            txtempleado.HintForeColor = Color.White;
            txtempleado.HintText = "";
            txtempleado.isPassword = false;
            txtempleado.LineFocusedColor = Color.Blue;
            txtempleado.LineIdleColor = Color.Gray;
            txtempleado.LineMouseHoverColor = Color.Blue;
            txtempleado.LineThickness = 3;
            txtempleado.Location = new Point(38, 334);
            txtempleado.Margin = new Padding(4);
            txtempleado.Name = "txtempleado";
            txtempleado.Size = new Size(143, 33);
            txtempleado.TabIndex = 21;
            txtempleado.Text = "0";
            txtempleado.TextAlign = HorizontalAlignment.Left;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.ForeColor = Color.White;
            Label6.Location = new Point(35, 317);
            Label6.Name = "Label6";
            Label6.Size = new Size(54, 13);
            Label6.TabIndex = 20;
            Label6.Text = "Empleado";
            // 
            // lblempleado
            // 
            lblempleado.AutoSize = true;
            lblempleado.ForeColor = Color.White;
            lblempleado.Location = new Point(201, 354);
            lblempleado.Name = "lblempleado";
            lblempleado.Size = new Size(16, 13);
            lblempleado.TabIndex = 22;
            lblempleado.Text = "...";
            // 
            // Agregar_Usuario
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(463, 463);
            Controls.Add(lblempleado);
            Controls.Add(txtempleado);
            Controls.Add(Label6);
            Controls.Add(btn_agregar);
            Controls.Add(Label5);
            Controls.Add(FlowLayoutPanel1);
            Controls.Add(Button1);
            Controls.Add(txtgrupo);
            Controls.Add(lblnmgrp);
            Controls.Add(lblcdggrp);
            Controls.Add(lblgrupo);
            Controls.Add(txtusuario);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Switchactivo);
            Controls.Add(Label2);
            Controls.Add(dateusr);
            Controls.Add(txtcontra);
            Controls.Add(lblcontraseña);
            Controls.Add(txtnombre);
            Controls.Add(Panel1);
            Controls.Add(Label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Agregar_Usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dar de alta usuarios";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(Editar_Usuario_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Label Label1;
        internal Panel Panel1;
        internal EvolveControlBox EvolveControlBox1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtnombre;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtcontra;
        internal Label lblcontraseña;
        internal Bunifu.Framework.UI.BunifuDatepicker dateusr;
        internal Label Label2;
        internal Bunifu.Framework.UI.BunifuiOSSwitch Switchactivo;
        internal Label Label3;
        internal Label Label4;
        internal Label lblgrupo;
        internal Label lblcdggrp;
        internal Label lblnmgrp;
        internal TextBox txtgrupo;
        internal Button Button1;
        internal FlowLayoutPanel FlowLayoutPanel1;
        internal Timer timerformato;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtusuario;
        internal Label Label5;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_agregar;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtempleado;
        internal Label Label6;
        internal Label lblempleado;
    }
}