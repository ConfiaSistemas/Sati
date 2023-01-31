using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class SplashScreen1 : Form
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
            var Animation2 = new BunifuAnimatorNS.Animation();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen1));
            Timer1 = new Timer(components);
            Timer1.Tick += new EventHandler(Timer1_Tick);
            BunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(components);
            Label1 = new Label();
            BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundWorker1_DoWork);
            BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundWorker1_RunWorkerCompleted);
            Backgroundmysql = new System.ComponentModel.BackgroundWorker();
            Backgroundmysql.DoWork += new System.ComponentModel.DoWorkEventHandler(Backgroundmysql_DoWork);
            Backgroundmysql.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(Backgroundmysql_RunWorkerCompleted);
            SuspendLayout();
            // 
            // Timer1
            // 
            // 
            // BunifuTransition1
            // 
            BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            BunifuTransition1.Cursor = null;
            Animation2.AnimateOnlyDifferences = true;
            Animation2.BlindCoeff = (PointF)resources.GetObject("Animation2.BlindCoeff");
            Animation2.LeafCoeff = 0f;
            Animation2.MaxTime = 1.0f;
            Animation2.MinTime = 0f;
            Animation2.MosaicCoeff = (PointF)resources.GetObject("Animation2.MosaicCoeff");
            Animation2.MosaicShift = (PointF)resources.GetObject("Animation2.MosaicShift");
            Animation2.MosaicSize = 20;
            Animation2.Padding = new Padding(30);
            Animation2.RotateCoeff = 0f;
            Animation2.RotateLimit = 0f;
            Animation2.ScaleCoeff = (PointF)resources.GetObject("Animation2.ScaleCoeff");
            Animation2.SlideCoeff = (PointF)resources.GetObject("Animation2.SlideCoeff");
            Animation2.TimeCoeff = 0f;
            Animation2.TransparencyCoeff = 0f;
            BunifuTransition1.DefaultAnimation = Animation2;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            BunifuTransition1.SetDecoration(Label1, BunifuAnimatorNS.DecorationType.None);
            Label1.Location = new Point(327, 64);
            Label1.Name = "Label1";
            Label1.Size = new Size(50, 13);
            Label1.TabIndex = 0;
            Label1.Text = "Iniciando";
            // 
            // BackgroundWorker1
            // 
            // 
            // Backgroundmysql
            // 
            // 
            // SplashScreen1
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = My.Resources.Resources.SATI;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(496, 303);
            ControlBox = false;
            Controls.Add(Label1);
            BunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SplashScreen1";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += new EventHandler(SplashScreen1_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Timer Timer1;
        internal BunifuAnimatorNS.BunifuTransition BunifuTransition1;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
        internal Label Label1;
        internal System.ComponentModel.BackgroundWorker Backgroundmysql;
    }
}