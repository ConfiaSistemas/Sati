﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class agregarservicio : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(agregarservicio));
            EvolveControlBox1 = new EvolveControlBox();
            Panel1 = new Panel();
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            Panel1.Paint += new PaintEventHandler(Panel1_Paint);
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(515, 3);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 0;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Location = new Point(0, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(585, 36);
            Panel1.TabIndex = 1;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 3);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(121, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Agregar Grupos";
            // 
            // agregarservicio
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(583, 448);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(583, 448);
            MinimumSize = new Size(583, 448);
            Name = "agregarservicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Servicio";
            TransparencyKey = Color.Fuchsia;
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            FormClosed += new FormClosedEventHandler(agregarservicio_FormClosed);
            Load += new EventHandler(agregarservicio_Load);
            ResumeLayout(false);

        }
        internal EvolveControlBox EvolveControlBox1;
        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
    }
}