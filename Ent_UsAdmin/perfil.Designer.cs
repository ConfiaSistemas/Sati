using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class perfil : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(perfil));
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            Label5 = new Label();
            Label6 = new Label();
            Label7 = new Label();
            Label8 = new Label();
            PictureBox1 = new PictureBox();
            linklabeleditar = new MonoFlat.MonoFlat_LinkLabel();
            linklabeleditar.LinkClicked += new LinkLabelLinkClickedEventHandler(linklabeleditar_LinkClicked);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = SystemColors.ButtonShadow;
            Label1.Location = new Point(32, 41);
            Label1.Name = "Label1";
            Label1.Size = new Size(42, 13);
            Label1.TabIndex = 1;
            Label1.Text = "Imagen";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(100, 21);
            Label2.Name = "Label2";
            Label2.Size = new Size(46, 13);
            Label2.TabIndex = 2;
            Label2.Text = "Usuario:";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(161, 21);
            Label3.Name = "Label3";
            Label3.Size = new Size(86, 13);
            Label3.TabIndex = 3;
            Label3.Text = "Nombre_Usuario";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(103, 66);
            Label4.Name = "Label4";
            Label4.Size = new Size(39, 13);
            Label4.TabIndex = 4;
            Label4.Text = "Grupo:";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(164, 65);
            Label5.Name = "Label5";
            Label5.Size = new Size(78, 13);
            Label5.TabIndex = 5;
            Label5.Text = "Grupo_Usuario";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(12, 112);
            Label6.Name = "Label6";
            Label6.Size = new Size(44, 13);
            Label6.TabIndex = 6;
            Label6.Text = "Nombre";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Location = new Point(12, 150);
            Label7.Name = "Label7";
            Label7.Size = new Size(52, 13);
            Label7.TabIndex = 7;
            Label7.Text = "Dirección";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Location = new Point(15, 192);
            Label8.Name = "Label8";
            Label8.Size = new Size(49, 13);
            Label8.TabIndex = 8;
            Label8.Text = "Teléfono";
            // 
            // PictureBox1
            // 
            PictureBox1.BackColor = SystemColors.ButtonShadow;
            PictureBox1.Location = new Point(12, 12);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(82, 68);
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            // 
            // linklabeleditar
            // 
            linklabeleditar.ActiveLinkColor = Color.FromArgb(153, 34, 34);
            linklabeleditar.AutoSize = true;
            linklabeleditar.BackColor = Color.Transparent;
            linklabeleditar.Font = new Font("Segoe UI", 9.0f);
            linklabeleditar.LinkBehavior = LinkBehavior.HoverUnderline;
            linklabeleditar.LinkColor = Color.FromArgb(181, 41, 42);
            linklabeleditar.Location = new Point(100, 223);
            linklabeleditar.Name = "linklabeleditar";
            linklabeleditar.Size = new Size(67, 15);
            linklabeleditar.TabIndex = 9;
            linklabeleditar.TabStop = true;
            linklabeleditar.Text = "Editar Perfil";
            linklabeleditar.VisitedLinkColor = Color.FromArgb(181, 41, 42);
            // 
            // perfil
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 262);
            Controls.Add(linklabeleditar);
            Controls.Add(Label8);
            Controls.Add(Label7);
            Controls.Add(Label6);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(PictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "perfil";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(perfil_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal PictureBox PictureBox1;
        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal Label Label4;
        internal Label Label5;
        internal Label Label6;
        internal Label Label7;
        internal Label Label8;
        internal MonoFlat.MonoFlat_LinkLabel linklabeleditar;
    }
}