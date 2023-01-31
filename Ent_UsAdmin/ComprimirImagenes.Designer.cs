using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ComprimirImagenes : Form
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
            BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundWorker1_DoWork);
            BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundWorker1_RunWorkerCompleted);
            Label1 = new Label();
            RadioSolicitud = new RadioButton();
            RadioCredito = new RadioButton();
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.Location = new Point(65, 142);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 0;
            Button1.Text = "Button1";
            Button1.UseVisualStyleBackColor = true;
            // 
            // BackgroundWorker1
            // 
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(62, 209);
            Label1.Name = "Label1";
            Label1.Size = new Size(39, 13);
            Label1.TabIndex = 1;
            Label1.Text = "Label1";
            // 
            // RadioSolicitud
            // 
            RadioSolicitud.AutoSize = true;
            RadioSolicitud.Location = new Point(65, 64);
            RadioSolicitud.Name = "RadioSolicitud";
            RadioSolicitud.Size = new Size(128, 17);
            RadioSolicitud.TabIndex = 2;
            RadioSolicitud.TabStop = true;
            RadioSolicitud.Text = "Documentos Solicitud";
            RadioSolicitud.UseVisualStyleBackColor = true;
            // 
            // RadioCredito
            // 
            RadioCredito.AutoSize = true;
            RadioCredito.Location = new Point(220, 64);
            RadioCredito.Name = "RadioCredito";
            RadioCredito.Size = new Size(121, 17);
            RadioCredito.TabIndex = 3;
            RadioCredito.TabStop = true;
            RadioCredito.Text = "Documentos Crédito";
            RadioCredito.UseVisualStyleBackColor = true;
            // 
            // ComprimirImagenes
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 333);
            Controls.Add(RadioCredito);
            Controls.Add(RadioSolicitud);
            Controls.Add(Label1);
            Controls.Add(Button1);
            Name = "ComprimirImagenes";
            Text = "ComprimirImagenes";
            Load += new EventHandler(ComprimirImagenes_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Button Button1;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
        internal Label Label1;
        internal RadioButton RadioSolicitud;
        internal RadioButton RadioCredito;
    }
}