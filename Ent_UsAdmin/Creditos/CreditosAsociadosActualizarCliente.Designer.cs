using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class CreditosAsociadosActualizarCliente : Form
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
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditosAsociadosActualizarCliente));
            Panel1 = new Panel();
            Panel1.Paint += new PaintEventHandler(Panel1_Paint);
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            EvolveControlBox1 = new EvolveControlBox();
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            dtdatos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            MonoFlat_HeaderLabel2 = new MonoFlat.MonoFlat_HeaderLabel();
            btn_agregar = new Bunifu.Framework.UI.BunifuThinButton2();
            btn_agregar.Click += new EventHandler(btn_agregar_Click);
            BackgroundActualizar = new System.ComponentModel.BackgroundWorker();
            BackgroundActualizar.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundActualizar_DoWork);
            BackgroundActualizar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundActualizar_RunWorkerCompleted);
            BackgroundActualizarCnotificacion = new System.ComponentModel.BackgroundWorker();
            BackgroundActualizarCnotificacion.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundActualizarCnotificacion_DoWork);
            BackgroundActualizarCnotificacion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundActualizarCnotificacion_RunWorkerCompleted);
            BackgroundConsultarActualizacion = new System.ComponentModel.BackgroundWorker();
            BackgroundConsultarActualizacion.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundConsultarActualizacion_DoWork);
            BackgroundConsultarActualizacion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundConsultarActualizacion_RunWorkerCompleted);
            BackgroundConsultarActualizacionPendiente = new System.ComponentModel.BackgroundWorker();
            BackgroundConsultarActualizacionPendiente.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundConsultarActualizacionPendiente_DoWork);
            BackgroundConsultarActualizacionPendiente.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundConsultarActualizacionPendiente_RunWorkerCompleted);
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtdatos).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Location = new Point(1, 2);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(624, 36);
            Panel1.TabIndex = 27;
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(580, 8);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = false;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(41, 16);
            EvolveControlBox1.TabIndex = 2;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = true;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 4);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(142, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Créditos Asociados";
            // 
            // dtdatos
            // 
            dtdatos.AllowUserToAddRows = false;
            dtdatos.AllowUserToDeleteRows = false;
            DataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dtdatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            dtdatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            dtdatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtdatos.BackgroundColor = Color.Gainsboro;
            dtdatos.BorderStyle = BorderStyle.None;
            dtdatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.DarkSlateGray;
            DataGridViewCellStyle2.Font = new Font("Century Gothic", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle2.ForeColor = Color.FromArgb(223, 223, 223);
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtdatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            dtdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtdatos.DoubleBuffered = true;
            dtdatos.EnableHeadersVisualStyles = false;
            dtdatos.HeaderBgColor = Color.DarkSlateGray;
            dtdatos.HeaderForeColor = Color.FromArgb(223, 223, 223);
            dtdatos.Location = new Point(4, 88);
            dtdatos.Name = "dtdatos";
            dtdatos.ReadOnly = true;
            dtdatos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtdatos.RowHeadersVisible = false;
            dtdatos.Size = new Size(618, 259);
            dtdatos.TabIndex = 28;
            // 
            // MonoFlat_HeaderLabel2
            // 
            MonoFlat_HeaderLabel2.AutoSize = true;
            MonoFlat_HeaderLabel2.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel2.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel2.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel2.Location = new Point(4, 55);
            MonoFlat_HeaderLabel2.Name = "MonoFlat_HeaderLabel2";
            MonoFlat_HeaderLabel2.Size = new Size(233, 20);
            MonoFlat_HeaderLabel2.TabIndex = 3;
            MonoFlat_HeaderLabel2.Text = "Seleccione el crédito a actualizar";
            // 
            // btn_agregar
            // 
            btn_agregar.ActiveBorderThickness = 1;
            btn_agregar.ActiveCornerRadius = 20;
            btn_agregar.ActiveFillColor = Color.SeaGreen;
            btn_agregar.ActiveForecolor = Color.White;
            btn_agregar.ActiveLineColor = Color.SeaGreen;
            btn_agregar.BackColor = Color.FromArgb(0, 5, 11);
            btn_agregar.BackgroundImage = (Image)resources.GetObject("btn_agregar.BackgroundImage");
            btn_agregar.ButtonText = "Actualizar";
            btn_agregar.Cursor = Cursors.Hand;
            btn_agregar.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_agregar.ForeColor = Color.SeaGreen;
            btn_agregar.IdleBorderThickness = 1;
            btn_agregar.IdleCornerRadius = 20;
            btn_agregar.IdleFillColor = Color.White;
            btn_agregar.IdleForecolor = Color.SeaGreen;
            btn_agregar.IdleLineColor = Color.SeaGreen;
            btn_agregar.Location = new Point(202, 372);
            btn_agregar.Margin = new Padding(5);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(207, 38);
            btn_agregar.TabIndex = 29;
            btn_agregar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackgroundActualizar
            // 
            // 
            // BackgroundActualizarCnotificacion
            // 
            // 
            // BackgroundConsultarActualizacion
            // 
            // 
            // BackgroundConsultarActualizacionPendiente
            // 
            // 
            // CreditosAsociadosActualizarCliente
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(625, 437);
            Controls.Add(btn_agregar);
            Controls.Add(MonoFlat_HeaderLabel2);
            Controls.Add(dtdatos);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreditosAsociadosActualizarCliente";
            Text = "CreditosAsociadosActualizarCliente";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtdatos).EndInit();
            Load += new EventHandler(CreditosAsociadosActualizarCliente_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Panel Panel1;
        internal EvolveControlBox EvolveControlBox1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtdatos;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel2;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_agregar;
        internal System.ComponentModel.BackgroundWorker BackgroundActualizar;
        internal System.ComponentModel.BackgroundWorker BackgroundActualizarCnotificacion;
        internal System.ComponentModel.BackgroundWorker BackgroundConsultarActualizacion;
        internal System.ComponentModel.BackgroundWorker BackgroundConsultarActualizacionPendiente;
    }
}