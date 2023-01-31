using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]

    public partial class ImprimirTarjeta : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ImprimirTarjeta));
            Panel1 = new Panel();
            Panel1.Paint += new PaintEventHandler(Panel1_Paint);
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            EvolveControlBox1 = new EvolveControlBox();
            btn_convenio = new Zeroit.Framework.Metro.ZeroitMetroButton();
            btn_convenio.Click += new EventHandler(btn_convenio_Click);
            btn_calendario = new Zeroit.Framework.Metro.ZeroitMetroButton();
            btn_calendario.Click += new EventHandler(btn_calendario_Click);
            ClickAnimator1 = new Zeroit.Framework.Metro.ClickAnimator();
            ClickAnimator2 = new Zeroit.Framework.Metro.ClickAnimator();
            BackgroundConvenio = new System.ComponentModel.BackgroundWorker();
            BackgroundConvenio.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundConvenio_DoWork);
            BackgroundConvenio.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundConvenio_RunWorkerCompleted);
            BackgroundImprimirAtras = new System.ComponentModel.BackgroundWorker();
            BackgroundImprimirAtras.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundImprimirAtras_DoWork);
            BackgroundImprimirAtras.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundImprimirAtras_RunWorkerCompleted);
            BackgroundImprimirFrente = new System.ComponentModel.BackgroundWorker();
            BackgroundImprimirFrente.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundImprimirFrente_DoWork);
            BackgroundImprimirFrente.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundImprimirFrente_RunWorkerCompleted);
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Location = new Point(3, 3);
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
            MonoFlat_HeaderLabel1.Location = new Point(12, 3);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(192, 20);
            MonoFlat_HeaderLabel1.TabIndex = 2;
            MonoFlat_HeaderLabel1.Text = "Imprimir tarjeta de cliente";
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(390, 7);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 1;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // btn_convenio
            // 
            btn_convenio.BackColor = Color.Transparent;
            btn_convenio.BackgroundImageLayout = ImageLayout.None;
            btn_convenio.BorderColor = Color.FromArgb(98, 98, 98);
            btn_convenio.DefaultColor = Color.White;
            btn_convenio.DisabledColor = Color.FromArgb(250, 250, 250);
            btn_convenio.Font = new Font("Segoe UI", 9.0f);
            btn_convenio.HoverColor = Color.White;
            btn_convenio.IsRound = true;
            btn_convenio.Location = new Point(80, 81);
            btn_convenio.Name = "btn_convenio";
            btn_convenio.PressedColor = Color.FromArgb(0, 122, 204);
            btn_convenio.RoundingArc = 106;
            btn_convenio.Size = new Size(106, 106);
            btn_convenio.TabIndex = 2;
            btn_convenio.Text = "Frente";
            // 
            // btn_calendario
            // 
            btn_calendario.BackColor = Color.Transparent;
            btn_calendario.BackgroundImageLayout = ImageLayout.None;
            btn_calendario.BorderColor = Color.FromArgb(98, 98, 98);
            btn_calendario.DefaultColor = Color.White;
            btn_calendario.DisabledColor = Color.FromArgb(250, 250, 250);
            btn_calendario.Font = new Font("Segoe UI", 9.0f);
            btn_calendario.HoverColor = Color.White;
            btn_calendario.IsRound = true;
            btn_calendario.Location = new Point(256, 81);
            btn_calendario.Name = "btn_calendario";
            btn_calendario.PressedColor = Color.FromArgb(0, 122, 204);
            btn_calendario.RoundingArc = 106;
            btn_calendario.Size = new Size(106, 106);
            btn_calendario.TabIndex = 3;
            btn_calendario.Text = "Atrás";
            // 
            // ClickAnimator1
            // 
            ClickAnimator1.ClickControl = btn_convenio;
            ClickAnimator1.Shape = Zeroit.Framework.Metro.ClickAnimator.DrawMode.Circle;
            ClickAnimator1.Speed = 11;
            // 
            // ClickAnimator2
            // 
            ClickAnimator2.ClickControl = btn_calendario;
            ClickAnimator2.Shape = Zeroit.Framework.Metro.ClickAnimator.DrawMode.Rectangle;
            ClickAnimator2.Speed = 11;
            // 
            // BackgroundConvenio
            // 
            // 
            // BackgroundImprimirAtras
            // 
            // 
            // BackgroundImprimirFrente
            // 
            // 
            // ImprimirTarjeta
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(467, 231);
            Controls.Add(btn_calendario);
            Controls.Add(btn_convenio);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ImprimirTarjeta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ImprimirConvenio";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(ImprimirConvenio_Load);
            ResumeLayout(false);

        }

        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal EvolveControlBox EvolveControlBox1;
        internal Zeroit.Framework.Metro.ZeroitMetroButton btn_convenio;
        internal Zeroit.Framework.Metro.ZeroitMetroButton btn_calendario;
        internal Zeroit.Framework.Metro.ClickAnimator ClickAnimator1;
        internal Zeroit.Framework.Metro.ClickAnimator ClickAnimator2;
        internal System.ComponentModel.BackgroundWorker BackgroundConvenio;
        internal System.ComponentModel.BackgroundWorker BackgroundImprimirAtras;
        internal System.ComponentModel.BackgroundWorker BackgroundImprimirFrente;
    }
}