using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class mysql : Form
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
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            ServerTXT = new TextBox();
            UsuarioTxt = new TextBox();
            PswdTxt = new TextBox();
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            txtfbeep1 = new TextBox();
            txtfbeep2 = new TextBox();
            txtfbeep3 = new TextBox();
            txtDbeep1 = new TextBox();
            txtDbeep2 = new TextBox();
            txtDbeep3 = new TextBox();
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click);
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.Location = new Point(170, 179);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 0;
            Button1.Text = "Button1";
            Button1.UseVisualStyleBackColor = true;
            // 
            // ServerTXT
            // 
            ServerTXT.Location = new Point(153, 77);
            ServerTXT.Name = "ServerTXT";
            ServerTXT.Size = new Size(100, 20);
            ServerTXT.TabIndex = 1;
            // 
            // UsuarioTxt
            // 
            UsuarioTxt.Location = new Point(305, 77);
            UsuarioTxt.Name = "UsuarioTxt";
            UsuarioTxt.Size = new Size(100, 20);
            UsuarioTxt.TabIndex = 2;
            // 
            // PswdTxt
            // 
            PswdTxt.Location = new Point(455, 77);
            PswdTxt.Name = "PswdTxt";
            PswdTxt.Size = new Size(100, 20);
            PswdTxt.TabIndex = 3;
            // 
            // Button2
            // 
            Button2.Location = new Point(440, 279);
            Button2.Name = "Button2";
            Button2.Size = new Size(75, 23);
            Button2.TabIndex = 4;
            Button2.Text = "Button2";
            Button2.UseVisualStyleBackColor = true;
            // 
            // txtfbeep1
            // 
            txtfbeep1.Location = new Point(440, 150);
            txtfbeep1.Name = "txtfbeep1";
            txtfbeep1.Size = new Size(100, 20);
            txtfbeep1.TabIndex = 5;
            // 
            // txtfbeep2
            // 
            txtfbeep2.Location = new Point(440, 182);
            txtfbeep2.Name = "txtfbeep2";
            txtfbeep2.Size = new Size(100, 20);
            txtfbeep2.TabIndex = 6;
            // 
            // txtfbeep3
            // 
            txtfbeep3.Location = new Point(440, 221);
            txtfbeep3.Name = "txtfbeep3";
            txtfbeep3.Size = new Size(100, 20);
            txtfbeep3.TabIndex = 7;
            // 
            // txtDbeep1
            // 
            txtDbeep1.Location = new Point(555, 150);
            txtDbeep1.Name = "txtDbeep1";
            txtDbeep1.Size = new Size(100, 20);
            txtDbeep1.TabIndex = 8;
            // 
            // txtDbeep2
            // 
            txtDbeep2.Location = new Point(555, 182);
            txtDbeep2.Name = "txtDbeep2";
            txtDbeep2.Size = new Size(100, 20);
            txtDbeep2.TabIndex = 9;
            // 
            // txtDbeep3
            // 
            txtDbeep3.Location = new Point(555, 221);
            txtDbeep3.Name = "txtDbeep3";
            txtDbeep3.Size = new Size(100, 20);
            txtDbeep3.TabIndex = 10;
            // 
            // Button3
            // 
            Button3.Location = new Point(250, 260);
            Button3.Name = "Button3";
            Button3.Size = new Size(75, 23);
            Button3.TabIndex = 11;
            Button3.Text = "Button3";
            Button3.UseVisualStyleBackColor = true;
            // 
            // mysql
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 338);
            Controls.Add(Button3);
            Controls.Add(txtDbeep3);
            Controls.Add(txtDbeep2);
            Controls.Add(txtDbeep1);
            Controls.Add(txtfbeep3);
            Controls.Add(txtfbeep2);
            Controls.Add(txtfbeep1);
            Controls.Add(Button2);
            Controls.Add(PswdTxt);
            Controls.Add(UsuarioTxt);
            Controls.Add(ServerTXT);
            Controls.Add(Button1);
            Name = "mysql";
            Text = "mysql";
            Load += new EventHandler(mysql_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Button Button1;
        internal TextBox ServerTXT;
        internal TextBox UsuarioTxt;
        internal TextBox PswdTxt;
        internal Button Button2;
        internal TextBox txtfbeep1;
        internal TextBox txtfbeep2;
        internal TextBox txtfbeep3;
        internal TextBox txtDbeep1;
        internal TextBox txtDbeep2;
        internal TextBox txtDbeep3;
        internal Button Button3;
    }
}