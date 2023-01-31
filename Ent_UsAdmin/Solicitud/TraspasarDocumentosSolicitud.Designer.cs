using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class TraspasarDocumentosSolicitud : Form
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
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var DataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnOrigen = new Button();
            btnOrigen.Click += new EventHandler(btnOrigen_Click);
            lblOrigen = new Label();
            lblDestino = new Label();
            btnDestino = new Button();
            btnDestino.Click += new EventHandler(btnDestino_Click);
            Label3 = new Label();
            txtSQL = new RichTextBox();
            Label4 = new Label();
            btnConsulta = new Button();
            btnConsulta.Click += new EventHandler(btnConsulta_Click);
            dtDatos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            IdOrigen = new DataGridViewTextBoxColumn();
            idDestino = new DataGridViewTextBoxColumn();
            TextBox1 = new TextBox();
            TextBox1.TextChanged += new EventHandler(TextBox1_TextChanged);
            TextBox1.KeyDown += new KeyEventHandler(TextBox1_KeyDown);
            Label5 = new Label();
            btnCargar = new Button();
            btnCargar.Click += new EventHandler(btnCargar_Click);
            btnTraspasar = new Button();
            btnTraspasar.Click += new EventHandler(btnTraspasar_Click);
            BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundWorker1_DoWork);
            BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundWorker1_RunWorkerCompleted);
            BackgroundTraspaso = new System.ComponentModel.BackgroundWorker();
            BackgroundTraspaso.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundTraspaso_DoWork);
            BackgroundTraspaso.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundTraspaso_RunWorkerCompleted);
            RadioSolicitud = new RadioButton();
            RadioSolicitud.CheckedChanged += new EventHandler(RadioSolicitud_CheckedChanged);
            RadioCredito = new RadioButton();
            RadioCredito.CheckedChanged += new EventHandler(RadioCredito_CheckedChanged);
            ((System.ComponentModel.ISupportInitialize)dtDatos).BeginInit();
            SuspendLayout();
            // 
            // btnOrigen
            // 
            btnOrigen.Location = new Point(23, 21);
            btnOrigen.Name = "btnOrigen";
            btnOrigen.Size = new Size(75, 40);
            btnOrigen.TabIndex = 0;
            btnOrigen.Text = "Seleccionar Origen";
            btnOrigen.UseVisualStyleBackColor = true;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(20, 78);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(39, 13);
            lblOrigen.TabIndex = 1;
            lblOrigen.Text = "Label1";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(176, 78);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(39, 13);
            lblDestino.TabIndex = 3;
            lblDestino.Text = "Label2";
            // 
            // btnDestino
            // 
            btnDestino.Location = new Point(179, 21);
            btnDestino.Name = "btnDestino";
            btnDestino.Size = new Size(75, 40);
            btnDestino.TabIndex = 2;
            btnDestino.Text = "Seleccionar Destino";
            btnDestino.UseVisualStyleBackColor = true;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(14, 114);
            Label3.Name = "Label3";
            Label3.Size = new Size(72, 13);
            Label3.TabIndex = 5;
            Label3.Text = "Consulta SQL";
            // 
            // txtSQL
            // 
            txtSQL.Location = new Point(12, 130);
            txtSQL.Name = "txtSQL";
            txtSQL.Size = new Size(729, 160);
            txtSQL.TabIndex = 4;
            txtSQL.Text = "";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(12, 336);
            Label4.Name = "Label4";
            Label4.Size = new Size(96, 13);
            Label4.TabIndex = 6;
            Label4.Text = "id's Datos Solicitud";
            // 
            // btnConsulta
            // 
            btnConsulta.Location = new Point(666, 84);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(75, 40);
            btnConsulta.TabIndex = 7;
            btnConsulta.Text = "Ejecutar Consulta";
            btnConsulta.UseVisualStyleBackColor = true;
            // 
            // dtDatos
            // 
            dtDatos.AllowUserToAddRows = false;
            dtDatos.AllowUserToDeleteRows = false;
            DataGridViewCellStyle5.BackColor = Color.FromArgb(224, 224, 224);
            dtDatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5;
            dtDatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            dtDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtDatos.BackgroundColor = Color.Gainsboro;
            dtDatos.BorderStyle = BorderStyle.None;
            dtDatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle6.BackColor = Color.DarkSlateGray;
            DataGridViewCellStyle6.Font = new Font("Century Gothic", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle6.ForeColor = Color.FromArgb(223, 223, 223);
            DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dtDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6;
            dtDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtDatos.Columns.AddRange(new DataGridViewColumn[] { IdOrigen, idDestino });
            dtDatos.DoubleBuffered = true;
            dtDatos.EnableHeadersVisualStyles = false;
            dtDatos.HeaderBgColor = Color.DarkSlateGray;
            dtDatos.HeaderForeColor = Color.FromArgb(223, 223, 223);
            dtDatos.Location = new Point(12, 365);
            dtDatos.Name = "dtDatos";
            dtDatos.ReadOnly = true;
            dtDatos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtDatos.RowHeadersVisible = false;
            dtDatos.Size = new Size(488, 262);
            dtDatos.TabIndex = 8;
            // 
            // IdOrigen
            // 
            IdOrigen.HeaderText = "IdOrigen";
            IdOrigen.Name = "IdOrigen";
            IdOrigen.ReadOnly = true;
            IdOrigen.Width = 82;
            // 
            // idDestino
            // 
            idDestino.HeaderText = "idDestino";
            idDestino.Name = "idDestino";
            idDestino.ReadOnly = true;
            idDestino.Width = 87;
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(148, 336);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(303, 20);
            TextBox1.TabIndex = 9;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(145, 320);
            Label5.Name = "Label5";
            Label5.Size = new Size(59, 13);
            Label5.TabIndex = 10;
            Label5.Text = "Ruta Excel";
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(457, 329);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(54, 26);
            btnCargar.TabIndex = 11;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            // 
            // btnTraspasar
            // 
            btnTraspasar.Location = new Point(374, 666);
            btnTraspasar.Name = "btnTraspasar";
            btnTraspasar.Size = new Size(77, 26);
            btnTraspasar.TabIndex = 12;
            btnTraspasar.Text = "Traspasar";
            btnTraspasar.UseVisualStyleBackColor = true;
            // 
            // BackgroundWorker1
            // 
            // 
            // BackgroundTraspaso
            // 
            // 
            // RadioSolicitud
            // 
            RadioSolicitud.AutoSize = true;
            RadioSolicitud.Location = new Point(457, 43);
            RadioSolicitud.Name = "RadioSolicitud";
            RadioSolicitud.Size = new Size(65, 17);
            RadioSolicitud.TabIndex = 13;
            RadioSolicitud.TabStop = true;
            RadioSolicitud.Text = "Solicitud";
            RadioSolicitud.UseVisualStyleBackColor = true;
            // 
            // RadioCredito
            // 
            RadioCredito.AutoSize = true;
            RadioCredito.Location = new Point(553, 44);
            RadioCredito.Name = "RadioCredito";
            RadioCredito.Size = new Size(58, 17);
            RadioCredito.TabIndex = 14;
            RadioCredito.TabStop = true;
            RadioCredito.Text = "Crédito";
            RadioCredito.UseVisualStyleBackColor = true;
            // 
            // TraspasarDocumentosSolicitud
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 715);
            Controls.Add(RadioCredito);
            Controls.Add(RadioSolicitud);
            Controls.Add(btnTraspasar);
            Controls.Add(btnCargar);
            Controls.Add(Label5);
            Controls.Add(TextBox1);
            Controls.Add(dtDatos);
            Controls.Add(btnConsulta);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(txtSQL);
            Controls.Add(lblDestino);
            Controls.Add(btnDestino);
            Controls.Add(lblOrigen);
            Controls.Add(btnOrigen);
            Name = "TraspasarDocumentosSolicitud";
            Text = "TraspasarDocumentosSolicitud";
            ((System.ComponentModel.ISupportInitialize)dtDatos).EndInit();
            Load += new EventHandler(TraspasarDocumentosSolicitud_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Button btnOrigen;
        internal Label lblOrigen;
        internal Label lblDestino;
        internal Button btnDestino;
        internal Label Label3;
        internal RichTextBox txtSQL;
        internal Label Label4;
        internal Button btnConsulta;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtDatos;
        internal DataGridViewTextBoxColumn IdOrigen;
        internal DataGridViewTextBoxColumn idDestino;
        internal TextBox TextBox1;
        internal Label Label5;
        internal Button btnCargar;
        internal Button btnTraspasar;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
        internal System.ComponentModel.BackgroundWorker BackgroundTraspaso;
        internal RadioButton RadioSolicitud;
        internal RadioButton RadioCredito;
    }
}