using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class EstadoDeCuenta : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(EstadoDeCuenta));
            Panel1 = new Panel();
            EvolveControlBox1 = new EvolveControlBox();
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            BunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton22.Click += new EventHandler(BunifuThinButton22_Click);
            MonoFlat_Label2 = new MonoFlat.MonoFlat_Label();
            MonoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            dateHasta = new Bunifu.Framework.UI.BunifuDatepicker();
            dateDesde = new Bunifu.Framework.UI.BunifuDatepicker();
            BackgroundInformacion = new System.ComponentModel.BackgroundWorker();
            BackgroundInformacion.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundInformacion_DoWork);
            BackgroundInformacion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundInformacion_RunWorkerCompleted);
            BackgroundEstadodeCuenta = new System.ComponentModel.BackgroundWorker();
            BackgroundEstadodeCuenta.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundEstadodeCuenta_DoWork);
            BackgroundEstadodeCuenta.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundEstadodeCuenta_RunWorkerCompleted);
            CheckGeneral = new MonoFlat.MonoFlat_CheckBox();
            BackgroundGeneral = new System.ComponentModel.BackgroundWorker();
            BackgroundGeneral.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundGeneral_DoWork);
            BackgroundGeneral.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundGeneral_RunWorkerCompleted);
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Location = new Point(2, 3);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(719, 36);
            Panel1.TabIndex = 12;
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(650, 3);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 13;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 3);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(188, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Generar estado de cuenta";
            // 
            // BunifuThinButton22
            // 
            BunifuThinButton22.ActiveBorderThickness = 1;
            BunifuThinButton22.ActiveCornerRadius = 20;
            BunifuThinButton22.ActiveFillColor = Color.SeaGreen;
            BunifuThinButton22.ActiveForecolor = Color.White;
            BunifuThinButton22.ActiveLineColor = Color.SeaGreen;
            BunifuThinButton22.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BunifuThinButton22.BackColor = Color.FromArgb(0, 5, 11);
            BunifuThinButton22.BackgroundImage = (Image)resources.GetObject("BunifuThinButton22.BackgroundImage");
            BunifuThinButton22.ButtonText = "Generar";
            BunifuThinButton22.Cursor = Cursors.Hand;
            BunifuThinButton22.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BunifuThinButton22.ForeColor = Color.SeaGreen;
            BunifuThinButton22.IdleBorderThickness = 1;
            BunifuThinButton22.IdleCornerRadius = 20;
            BunifuThinButton22.IdleFillColor = Color.White;
            BunifuThinButton22.IdleForecolor = Color.SeaGreen;
            BunifuThinButton22.IdleLineColor = Color.SeaGreen;
            BunifuThinButton22.Location = new Point(515, 80);
            BunifuThinButton22.Margin = new Padding(5);
            BunifuThinButton22.Name = "BunifuThinButton22";
            BunifuThinButton22.Size = new Size(92, 31);
            BunifuThinButton22.TabIndex = 13;
            BunifuThinButton22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MonoFlat_Label2
            // 
            MonoFlat_Label2.AutoSize = true;
            MonoFlat_Label2.BackColor = Color.Transparent;
            MonoFlat_Label2.Font = new Font("Segoe UI", 9.0f);
            MonoFlat_Label2.ForeColor = Color.FromArgb(116, 125, 132);
            MonoFlat_Label2.Location = new Point(291, 62);
            MonoFlat_Label2.Name = "MonoFlat_Label2";
            MonoFlat_Label2.Size = new Size(37, 15);
            MonoFlat_Label2.TabIndex = 17;
            MonoFlat_Label2.Text = "Hasta";
            // 
            // MonoFlat_Label1
            // 
            MonoFlat_Label1.AutoSize = true;
            MonoFlat_Label1.BackColor = Color.Transparent;
            MonoFlat_Label1.Font = new Font("Segoe UI", 9.0f);
            MonoFlat_Label1.ForeColor = Color.FromArgb(116, 125, 132);
            MonoFlat_Label1.Location = new Point(48, 62);
            MonoFlat_Label1.Name = "MonoFlat_Label1";
            MonoFlat_Label1.Size = new Size(39, 15);
            MonoFlat_Label1.TabIndex = 16;
            MonoFlat_Label1.Text = "Desde";
            // 
            // dateHasta
            // 
            dateHasta.BackColor = Color.FromArgb(0, 5, 11);
            dateHasta.BorderRadius = 0;
            dateHasta.ForeColor = Color.White;
            dateHasta.Format = DateTimePickerFormat.Short;
            dateHasta.FormatCustom = null;
            dateHasta.Location = new Point(294, 80);
            dateHasta.Name = "dateHasta";
            dateHasta.Size = new Size(177, 33);
            dateHasta.TabIndex = 15;
            dateHasta.Value = new DateTime(2020, 2, 20, 0, 0, 0, 0);
            // 
            // dateDesde
            // 
            dateDesde.BackColor = Color.FromArgb(0, 5, 11);
            dateDesde.BorderRadius = 0;
            dateDesde.ForeColor = Color.White;
            dateDesde.Format = DateTimePickerFormat.Short;
            dateDesde.FormatCustom = null;
            dateDesde.Location = new Point(51, 80);
            dateDesde.Name = "dateDesde";
            dateDesde.Size = new Size(177, 33);
            dateDesde.TabIndex = 14;
            dateDesde.Value = new DateTime(2020, 2, 20, 0, 0, 0, 0);
            // 
            // BackgroundInformacion
            // 
            // 
            // BackgroundEstadodeCuenta
            // 
            // 
            // CheckGeneral
            // 
            CheckGeneral.Checked = false;
            CheckGeneral.Font = new Font("Microsoft Sans Serif", 9.0f);
            CheckGeneral.Location = new Point(61, 131);
            CheckGeneral.Name = "CheckGeneral";
            CheckGeneral.Size = new Size(167, 16);
            CheckGeneral.TabIndex = 18;
            CheckGeneral.Text = "Estado de cuenta general";
            // 
            // BackgroundGeneral
            // 
            // 
            // EstadoDeCuenta
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(722, 159);
            Controls.Add(CheckGeneral);
            Controls.Add(BunifuThinButton22);
            Controls.Add(MonoFlat_Label2);
            Controls.Add(MonoFlat_Label1);
            Controls.Add(dateHasta);
            Controls.Add(dateDesde);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EstadoDeCuenta";
            Text = "EstadoDeCuenta";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(EstadoDeCuenta_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal EvolveControlBox EvolveControlBox1;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton22;
        internal MonoFlat.MonoFlat_Label MonoFlat_Label2;
        internal MonoFlat.MonoFlat_Label MonoFlat_Label1;
        internal Bunifu.Framework.UI.BunifuDatepicker dateHasta;
        internal Bunifu.Framework.UI.BunifuDatepicker dateDesde;
        internal System.ComponentModel.BackgroundWorker BackgroundInformacion;
        internal System.ComponentModel.BackgroundWorker BackgroundEstadodeCuenta;
        internal MonoFlat.MonoFlat_CheckBox CheckGeneral;
        internal System.ComponentModel.BackgroundWorker BackgroundGeneral;
    }
}