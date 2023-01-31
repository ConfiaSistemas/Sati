using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class CrearNotificacion : Form
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
            ComboTipo = new ComboBox();
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            txtIdSesion = new TextBox();
            txtUsuario = new TextBox();
            txtMensaje = new RichTextBox();
            btnSesiones = new Button();
            btnSesiones.Click += new EventHandler(btnSesiones_Click);
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            BackgroundNotificacion = new System.ComponentModel.BackgroundWorker();
            BackgroundNotificacion.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundNotificacion_DoWork);
            BackgroundNotificacion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundNotificacion_RunWorkerCompleted);
            SuspendLayout();
            // 
            // ComboTipo
            // 
            ComboTipo.FormattingEnabled = true;
            ComboTipo.Items.AddRange(new object[] { "Logout", "Message", "CargarPermisos", "Update", "UpdateUpdater" });
            ComboTipo.Location = new Point(179, 34);
            ComboTipo.Name = "ComboTipo";
            ComboTipo.Size = new Size(144, 21);
            ComboTipo.TabIndex = 0;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(41, 34);
            Label1.Name = "Label1";
            Label1.Size = new Size(28, 13);
            Label1.TabIndex = 1;
            Label1.Text = "Tipo";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(41, 73);
            Label2.Name = "Label2";
            Label2.Size = new Size(39, 13);
            Label2.TabIndex = 2;
            Label2.Text = "Sesión";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(41, 114);
            Label3.Name = "Label3";
            Label3.Size = new Size(43, 13);
            Label3.TabIndex = 3;
            Label3.Text = "Usuario";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(41, 155);
            Label4.Name = "Label4";
            Label4.Size = new Size(47, 13);
            Label4.TabIndex = 4;
            Label4.Text = "Mensaje";
            // 
            // txtIdSesion
            // 
            txtIdSesion.Location = new Point(179, 70);
            txtIdSesion.Name = "txtIdSesion";
            txtIdSesion.Size = new Size(100, 20);
            txtIdSesion.TabIndex = 5;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(179, 107);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 20);
            txtUsuario.TabIndex = 6;
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(179, 152);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(237, 96);
            txtMensaje.TabIndex = 7;
            txtMensaje.Text = "";
            // 
            // btnSesiones
            // 
            btnSesiones.Location = new Point(294, 67);
            btnSesiones.Name = "btnSesiones";
            btnSesiones.Size = new Size(29, 23);
            btnSesiones.TabIndex = 8;
            btnSesiones.Text = "...";
            btnSesiones.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            Button1.Location = new Point(262, 306);
            Button1.Name = "Button1";
            Button1.Size = new Size(61, 23);
            Button1.TabIndex = 9;
            Button1.Text = "Crear";
            Button1.UseVisualStyleBackColor = true;
            // 
            // BackgroundNotificacion
            // 
            // 
            // CrearNotificacion
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 391);
            Controls.Add(Button1);
            Controls.Add(btnSesiones);
            Controls.Add(txtMensaje);
            Controls.Add(txtUsuario);
            Controls.Add(txtIdSesion);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(ComboTipo);
            Name = "CrearNotificacion";
            Text = "CrearNotificacion";
            ResumeLayout(false);
            PerformLayout();

        }

        internal ComboBox ComboTipo;
        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal Label Label4;
        internal TextBox txtIdSesion;
        internal TextBox txtUsuario;
        internal RichTextBox txtMensaje;
        internal Button btnSesiones;
        internal Button Button1;
        internal System.ComponentModel.BackgroundWorker BackgroundNotificacion;
    }
}