using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class EmpresasPermitidas : Form
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.EvolveControlBox1 = new ConfiaAdmin.EvolveControlBox();
            this.MonoFlat_HeaderLabel1 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.FlowEmpresasPermitidas = new System.Windows.Forms.FlowLayoutPanel();
            this.FlowEmpresasRestringidas = new System.Windows.Forms.FlowLayoutPanel();
            this.MonoFlat_HeaderLabel2 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.MonoFlat_HeaderLabel3 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Button1 = new System.Windows.Forms.Button();
            this.BackgroundAplicar = new System.ComponentModel.BackgroundWorker();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.Panel1.Controls.Add(this.EvolveControlBox1);
            this.Panel1.Controls.Add(this.MonoFlat_HeaderLabel1);
            this.Panel1.Location = new System.Drawing.Point(1, 1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(461, 36);
            this.Panel1.TabIndex = 6;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // EvolveControlBox1
            // 
            this.EvolveControlBox1.Colors = new ConfiaAdmin.Bloom[0];
            this.EvolveControlBox1.Customization = "";
            this.EvolveControlBox1.Font = new System.Drawing.Font("Verdana", 8F);
            this.EvolveControlBox1.Image = null;
            this.EvolveControlBox1.Location = new System.Drawing.Point(392, 3);
            this.EvolveControlBox1.MaxButton = false;
            this.EvolveControlBox1.MinButton = true;
            this.EvolveControlBox1.Name = "EvolveControlBox1";
            this.EvolveControlBox1.NoRounding = false;
            this.EvolveControlBox1.Size = new System.Drawing.Size(66, 16);
            this.EvolveControlBox1.TabIndex = 31;
            this.EvolveControlBox1.Text = "EvolveControlBox1";
            this.EvolveControlBox1.Transparent = false;
            // 
            // MonoFlat_HeaderLabel1
            // 
            this.MonoFlat_HeaderLabel1.AutoSize = true;
            this.MonoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel1.Location = new System.Drawing.Point(3, 3);
            this.MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            this.MonoFlat_HeaderLabel1.Size = new System.Drawing.Size(155, 20);
            this.MonoFlat_HeaderLabel1.TabIndex = 1;
            this.MonoFlat_HeaderLabel1.Text = "Empresas Permitidas";
            // 
            // FlowEmpresasPermitidas
            // 
            this.FlowEmpresasPermitidas.AutoScroll = true;
            this.FlowEmpresasPermitidas.BackColor = System.Drawing.Color.White;
            this.FlowEmpresasPermitidas.Location = new System.Drawing.Point(7, 110);
            this.FlowEmpresasPermitidas.Name = "FlowEmpresasPermitidas";
            this.FlowEmpresasPermitidas.Size = new System.Drawing.Size(200, 464);
            this.FlowEmpresasPermitidas.TabIndex = 7;
            this.FlowEmpresasPermitidas.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnFlowLayoutPanelDragDrop);
            this.FlowEmpresasPermitidas.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnFlowLayoutPanelDragEnter);
            this.FlowEmpresasPermitidas.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.OnFlowLayoutPanelGiveFeedback);
            // 
            // FlowEmpresasRestringidas
            // 
            this.FlowEmpresasRestringidas.AutoScroll = true;
            this.FlowEmpresasRestringidas.BackColor = System.Drawing.Color.White;
            this.FlowEmpresasRestringidas.Location = new System.Drawing.Point(253, 110);
            this.FlowEmpresasRestringidas.Name = "FlowEmpresasRestringidas";
            this.FlowEmpresasRestringidas.Size = new System.Drawing.Size(200, 464);
            this.FlowEmpresasRestringidas.TabIndex = 8;
            this.FlowEmpresasRestringidas.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnFlowLayoutPanelDragDrop);
            this.FlowEmpresasRestringidas.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnFlowLayoutPanelDragEnter);
            this.FlowEmpresasRestringidas.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.OnFlowLayoutPanelGiveFeedback);
            // 
            // MonoFlat_HeaderLabel2
            // 
            this.MonoFlat_HeaderLabel2.AutoSize = true;
            this.MonoFlat_HeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel2.Location = new System.Drawing.Point(4, 87);
            this.MonoFlat_HeaderLabel2.Name = "MonoFlat_HeaderLabel2";
            this.MonoFlat_HeaderLabel2.Size = new System.Drawing.Size(155, 20);
            this.MonoFlat_HeaderLabel2.TabIndex = 32;
            this.MonoFlat_HeaderLabel2.Text = "Empresas Permitidas";
            // 
            // MonoFlat_HeaderLabel3
            // 
            this.MonoFlat_HeaderLabel3.AutoSize = true;
            this.MonoFlat_HeaderLabel3.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel3.Location = new System.Drawing.Point(249, 87);
            this.MonoFlat_HeaderLabel3.Name = "MonoFlat_HeaderLabel3";
            this.MonoFlat_HeaderLabel3.Size = new System.Drawing.Size(167, 20);
            this.MonoFlat_HeaderLabel3.TabIndex = 33;
            this.MonoFlat_HeaderLabel3.Text = "Empresas Restringidas";
            // 
            // BackgroundWorker1
            // 
            this.BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Silver;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Location = new System.Drawing.Point(376, 52);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 34;
            this.Button1.Text = "Aplicar";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BackgroundAplicar
            // 
            this.BackgroundAplicar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundAplicar_DoWork);
            this.BackgroundAplicar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundAplicar_RunWorkerCompleted);
            // 
            // EmpresasPermitidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(463, 583);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.MonoFlat_HeaderLabel3);
            this.Controls.Add(this.MonoFlat_HeaderLabel2);
            this.Controls.Add(this.FlowEmpresasRestringidas);
            this.Controls.Add(this.FlowEmpresasPermitidas);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpresasPermitidas";
            this.Text = "Empresas Permitidas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmpresasPermitidas_FormClosing);
            this.Load += new System.EventHandler(this.EmpresasPermitidas_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal Panel Panel1;
        internal EvolveControlBox EvolveControlBox1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal FlowLayoutPanel FlowEmpresasPermitidas;
        internal FlowLayoutPanel FlowEmpresasRestringidas;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel2;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel3;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
        internal Button Button1;
        internal System.ComponentModel.BackgroundWorker BackgroundAplicar;
    }
}