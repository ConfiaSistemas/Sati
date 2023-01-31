using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class usuarios : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(usuarios));
            Panel1 = new Panel();
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            Combogrupo = new ComboBox();
            Combogrupo.SelectedIndexChanged += new EventHandler(Combogrupo_SelectedIndexChanged);
            BunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            BunifuMaterialTextbox1.KeyDown += new KeyEventHandler(BunifuMaterialTextbox1_KeyDown);
            MonoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            Combofiltro = new ComboBox();
            Combofiltro.SelectedIndexChanged += new EventHandler(Combofiltro_SelectedIndexChanged);
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            EvolveControlBox1 = new EvolveControlBox();
            FlowLayoutPanel1 = new FlowLayoutPanel();
            panelcargando = new Panel();
            timercargando = new Timer(components);
            timercargando.Tick += new EventHandler(timercargando_Tick);
            BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundWorker1_DoWork);
            BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundWorker1_RunWorkerCompleted);
            Backgroundusuarios = new System.ComponentModel.BackgroundWorker();
            Backgroundusuarios.DoWork += new System.ComponentModel.DoWorkEventHandler(Backgroundusuarios_DoWork);
            Backgroundusuarios.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(Backgroundusuarios_RunWorkerCompleted);
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(Combogrupo);
            Panel1.Controls.Add(BunifuMaterialTextbox1);
            Panel1.Controls.Add(MonoFlat_Label1);
            Panel1.Controls.Add(Combofiltro);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Location = new Point(0, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(563, 36);
            Panel1.TabIndex = 0;
            // 
            // Combogrupo
            // 
            Combogrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            Combogrupo.FormattingEnabled = true;
            Combogrupo.Location = new Point(103, 7);
            Combogrupo.Name = "Combogrupo";
            Combogrupo.Size = new Size(51, 21);
            Combogrupo.TabIndex = 3;
            // 
            // BunifuMaterialTextbox1
            // 
            BunifuMaterialTextbox1.Cursor = Cursors.IBeam;
            BunifuMaterialTextbox1.Font = new Font("Century Gothic", 9.75f);
            BunifuMaterialTextbox1.ForeColor = Color.White;
            BunifuMaterialTextbox1.HintForeColor = Color.White;
            BunifuMaterialTextbox1.HintText = "";
            BunifuMaterialTextbox1.isPassword = false;
            BunifuMaterialTextbox1.LineFocusedColor = Color.Blue;
            BunifuMaterialTextbox1.LineIdleColor = Color.Gray;
            BunifuMaterialTextbox1.LineMouseHoverColor = Color.Blue;
            BunifuMaterialTextbox1.LineThickness = 3;
            BunifuMaterialTextbox1.Location = new Point(358, 4);
            BunifuMaterialTextbox1.Margin = new Padding(4);
            BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1";
            BunifuMaterialTextbox1.Size = new Size(111, 25);
            BunifuMaterialTextbox1.TabIndex = 0;
            BunifuMaterialTextbox1.TextAlign = HorizontalAlignment.Left;
            // 
            // MonoFlat_Label1
            // 
            MonoFlat_Label1.AutoSize = true;
            MonoFlat_Label1.BackColor = Color.Transparent;
            MonoFlat_Label1.Font = new Font("Segoe UI", 9.0f);
            MonoFlat_Label1.ForeColor = Color.FromArgb(116, 125, 132);
            MonoFlat_Label1.Location = new Point(169, 7);
            MonoFlat_Label1.Name = "MonoFlat_Label1";
            MonoFlat_Label1.Size = new Size(48, 15);
            MonoFlat_Label1.TabIndex = 0;
            MonoFlat_Label1.Text = "Mostrar";
            // 
            // Combofiltro
            // 
            Combofiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            Combofiltro.FormattingEnabled = true;
            Combofiltro.Location = new Point(225, 3);
            Combofiltro.Name = "Combofiltro";
            Combofiltro.Size = new Size(121, 21);
            Combofiltro.TabIndex = 2;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(4, 1);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(70, 20);
            MonoFlat_HeaderLabel1.TabIndex = 0;
            MonoFlat_HeaderLabel1.Text = "Usuarios";
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(489, 3);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 1;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.AutoScroll = true;
            FlowLayoutPanel1.Location = new Point(0, 42);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(555, 268);
            FlowLayoutPanel1.TabIndex = 1;
            FlowLayoutPanel1.WrapContents = false;
            // 
            // panelcargando
            // 
            panelcargando.BackColor = Color.FromArgb(0, 5, 11);
            panelcargando.Location = new Point(128, 328);
            panelcargando.Name = "panelcargando";
            panelcargando.Size = new Size(200, 68);
            panelcargando.TabIndex = 2;
            // 
            // timercargando
            // 
            // 
            // BackgroundWorker1
            // 
            // 
            // Backgroundusuarios
            // 
            // 
            // usuarios
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(559, 278);
            Controls.Add(panelcargando);
            Controls.Add(FlowLayoutPanel1);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "usuarios";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(usuarios_Load);
            ResumeLayout(false);

        }
        internal Panel Panel1;
        internal EvolveControlBox EvolveControlBox1;
        internal FlowLayoutPanel FlowLayoutPanel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal MonoFlat.MonoFlat_Label MonoFlat_Label1;
        internal ComboBox Combofiltro;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox BunifuMaterialTextbox1;
        internal ComboBox Combogrupo;
        internal Panel panelcargando;
        internal Timer timercargando;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
        internal System.ComponentModel.BackgroundWorker Backgroundusuarios;
    }
}