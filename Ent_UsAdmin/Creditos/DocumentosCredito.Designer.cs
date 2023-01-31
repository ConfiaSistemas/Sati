using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class DocumentosCredito : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentosCredito));
            dtdatosDocumentosNuevos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            dtdatosDocumentosNuevos.KeyDown += new KeyEventHandler(dtdatosDocumentosNuevos_KeyDown);
            idTipoDocumento = new DataGridViewTextBoxColumn();
            NombreDocumento = new DataGridViewTextBoxColumn();
            Imagen = new DataGridViewImageColumn();
            Panel1 = new Panel();
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            EvolveControlBox1 = new EvolveControlBox();
            btn_actualizar = new Bunifu.Framework.UI.BunifuThinButton2();
            btn_actualizar.Click += new EventHandler(btn_actualizar_Click);
            btn_agregar = new Button();
            btn_agregar.Click += new EventHandler(btn_agregar_Click);
            BackgroundDocumentos = new System.ComponentModel.BackgroundWorker();
            BackgroundDocumentos.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundDocumentos_DoWork);
            BackgroundDocumentos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundDocumentos_RunWorkerCompleted);
            ((System.ComponentModel.ISupportInitialize)dtdatosDocumentosNuevos).BeginInit();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtdatosDocumentosNuevos
            // 
            dtdatosDocumentosNuevos.AllowUserToAddRows = false;
            dtdatosDocumentosNuevos.AllowUserToDeleteRows = false;
            DataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dtdatosDocumentosNuevos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            dtdatosDocumentosNuevos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            dtdatosDocumentosNuevos.BackgroundColor = Color.Gainsboro;
            dtdatosDocumentosNuevos.BorderStyle = BorderStyle.None;
            dtdatosDocumentosNuevos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.DarkSlateGray;
            DataGridViewCellStyle2.Font = new Font("Century Gothic", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle2.ForeColor = Color.FromArgb(223, 223, 223);
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtdatosDocumentosNuevos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            dtdatosDocumentosNuevos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtdatosDocumentosNuevos.Columns.AddRange(new DataGridViewColumn[] { idTipoDocumento, NombreDocumento, Imagen });
            dtdatosDocumentosNuevos.DoubleBuffered = true;
            dtdatosDocumentosNuevos.EnableHeadersVisualStyles = false;
            dtdatosDocumentosNuevos.HeaderBgColor = Color.DarkSlateGray;
            dtdatosDocumentosNuevos.HeaderForeColor = Color.FromArgb(223, 223, 223);
            dtdatosDocumentosNuevos.Location = new Point(12, 117);
            dtdatosDocumentosNuevos.Name = "dtdatosDocumentosNuevos";
            dtdatosDocumentosNuevos.ReadOnly = true;
            dtdatosDocumentosNuevos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtdatosDocumentosNuevos.RowHeadersVisible = false;
            dtdatosDocumentosNuevos.Size = new Size(685, 327);
            dtdatosDocumentosNuevos.TabIndex = 28;
            // 
            // idTipoDocumento
            // 
            idTipoDocumento.HeaderText = "idTipoDocumento";
            idTipoDocumento.Name = "idTipoDocumento";
            idTipoDocumento.ReadOnly = true;
            // 
            // NombreDocumento
            // 
            NombreDocumento.HeaderText = "NombreDocumento";
            NombreDocumento.Name = "NombreDocumento";
            NombreDocumento.ReadOnly = true;
            // 
            // Imagen
            // 
            Imagen.FillWeight = 300.0f;
            Imagen.HeaderText = "Imagen";
            Imagen.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Imagen.Name = "Imagen";
            Imagen.ReadOnly = true;
            Imagen.Width = 300;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Location = new Point(2, 2);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(705, 36);
            Panel1.TabIndex = 29;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 0);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(159, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Agregar Documentos";
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(636, 4);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 0;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // btn_actualizar
            // 
            btn_actualizar.ActiveBorderThickness = 1;
            btn_actualizar.ActiveCornerRadius = 20;
            btn_actualizar.ActiveFillColor = Color.FromArgb(14, 21, 38);
            btn_actualizar.ActiveForecolor = Color.White;
            btn_actualizar.ActiveLineColor = Color.SeaGreen;
            btn_actualizar.BackColor = Color.FromArgb(0, 5, 11);
            btn_actualizar.BackgroundImage = (Image)resources.GetObject("btn_actualizar.BackgroundImage");
            btn_actualizar.ButtonText = "Insertar";
            btn_actualizar.Cursor = Cursors.Hand;
            btn_actualizar.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_actualizar.ForeColor = Color.DarkBlue;
            btn_actualizar.IdleBorderThickness = 1;
            btn_actualizar.IdleCornerRadius = 20;
            btn_actualizar.IdleFillColor = Color.White;
            btn_actualizar.IdleForecolor = Color.Gray;
            btn_actualizar.IdleLineColor = Color.FromArgb(14, 21, 38);
            btn_actualizar.Location = new Point(230, 468);
            btn_actualizar.Margin = new Padding(5);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(207, 38);
            btn_actualizar.TabIndex = 30;
            btn_actualizar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(12, 76);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(27, 21);
            btn_agregar.TabIndex = 53;
            btn_agregar.Text = "+";
            btn_agregar.UseVisualStyleBackColor = true;
            // 
            // BackgroundDocumentos
            // 
            // 
            // DocumentosCredito
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(709, 530);
            Controls.Add(btn_agregar);
            Controls.Add(btn_actualizar);
            Controls.Add(Panel1);
            Controls.Add(dtdatosDocumentosNuevos);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DocumentosCredito";
            Text = "DocumentosCreditoLegal";
            ((System.ComponentModel.ISupportInitialize)dtdatosDocumentosNuevos).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ResumeLayout(false);

        }

        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtdatosDocumentosNuevos;
        internal DataGridViewTextBoxColumn idTipoDocumento;
        internal DataGridViewTextBoxColumn NombreDocumento;
        internal DataGridViewImageColumn Imagen;
        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal EvolveControlBox EvolveControlBox1;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_actualizar;
        internal Button btn_agregar;
        internal System.ComponentModel.BackgroundWorker BackgroundDocumentos;
    }
}