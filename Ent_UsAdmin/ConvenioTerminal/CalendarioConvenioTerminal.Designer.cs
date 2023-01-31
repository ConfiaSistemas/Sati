using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]

    public partial class CalendarioConvenioTerminal : Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarioConvenioTerminal));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.EvolveControlBox1 = new ConfiaAdmin.EvolveControlBox();
            this.MonoFlat_HeaderLabel1 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.dtimpuestos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParteCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParteMoratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Procesar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BackgroundConvenio = new System.ComponentModel.BackgroundWorker();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtimpuestos)).BeginInit();
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
            this.Panel1.Size = new System.Drawing.Size(648, 36);
            this.Panel1.TabIndex = 5;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // EvolveControlBox1
            // 
            this.EvolveControlBox1.Colors = new ConfiaAdmin.Bloom[0];
            this.EvolveControlBox1.Customization = "";
            this.EvolveControlBox1.Font = new System.Drawing.Font("Verdana", 8F);
            this.EvolveControlBox1.Image = null;
            this.EvolveControlBox1.Location = new System.Drawing.Point(579, 3);
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
            this.MonoFlat_HeaderLabel1.Size = new System.Drawing.Size(217, 20);
            this.MonoFlat_HeaderLabel1.TabIndex = 1;
            this.MonoFlat_HeaderLabel1.Text = "Calendario Convenio Terminal";
            // 
            // dtimpuestos
            // 
            this.dtimpuestos.AllowUserToAddRows = false;
            this.dtimpuestos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtimpuestos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtimpuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtimpuestos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtimpuestos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtimpuestos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtimpuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtimpuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtimpuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Monto,
            this.ParteCredito,
            this.ParteMoratorio});
            this.dtimpuestos.DoubleBuffered = true;
            this.dtimpuestos.EnableHeadersVisualStyles = false;
            this.dtimpuestos.HeaderBgColor = System.Drawing.Color.DarkSlateGray;
            this.dtimpuestos.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dtimpuestos.Location = new System.Drawing.Point(12, 102);
            this.dtimpuestos.Name = "dtimpuestos";
            this.dtimpuestos.ReadOnly = true;
            this.dtimpuestos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtimpuestos.Size = new System.Drawing.Size(626, 437);
            this.dtimpuestos.TabIndex = 6;
            this.dtimpuestos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtimpuestos_CellContentClick);
            this.dtimpuestos.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtimpuestos_RowPostPaint);
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // ParteCredito
            // 
            this.ParteCredito.HeaderText = "Parte Crédito";
            this.ParteCredito.Name = "ParteCredito";
            this.ParteCredito.ReadOnly = true;
            // 
            // ParteMoratorio
            // 
            this.ParteMoratorio.HeaderText = "Parte Moratorio";
            this.ParteMoratorio.Name = "ParteMoratorio";
            this.ParteMoratorio.ReadOnly = true;
            // 
            // btn_Procesar
            // 
            this.btn_Procesar.ActiveBorderThickness = 1;
            this.btn_Procesar.ActiveCornerRadius = 20;
            this.btn_Procesar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btn_Procesar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Procesar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Procesar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.btn_Procesar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Procesar.BackgroundImage")));
            this.btn_Procesar.ButtonText = "Crear Convenio";
            this.btn_Procesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Procesar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Procesar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Procesar.IdleBorderThickness = 1;
            this.btn_Procesar.IdleCornerRadius = 20;
            this.btn_Procesar.IdleFillColor = System.Drawing.Color.White;
            this.btn_Procesar.IdleForecolor = System.Drawing.Color.Gray;
            this.btn_Procesar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btn_Procesar.Location = new System.Drawing.Point(8, 56);
            this.btn_Procesar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Procesar.Name = "btn_Procesar";
            this.btn_Procesar.Size = new System.Drawing.Size(143, 38);
            this.btn_Procesar.TabIndex = 14;
            this.btn_Procesar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Procesar.Click += new System.EventHandler(this.btn_Procesar_Click);
            // 
            // BackgroundConvenio
            // 
            this.BackgroundConvenio.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundConvenio_DoWork);
            this.BackgroundConvenio.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundConvenio_RunWorkerCompleted);
            // 
            // CalendarioConvenioTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(650, 551);
            this.Controls.Add(this.btn_Procesar);
            this.Controls.Add(this.dtimpuestos);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalendarioConvenioTerminal";
            this.Text = "CalendarioConvenioLegal";
            this.Load += new System.EventHandler(this.CalendarioConvenioLegal_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtimpuestos)).EndInit();
            this.ResumeLayout(false);

        }

        internal Panel Panel1;
        internal EvolveControlBox EvolveControlBox1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtimpuestos;
        internal DataGridViewTextBoxColumn Fecha;
        internal DataGridViewTextBoxColumn Monto;
        internal DataGridViewTextBoxColumn ParteCredito;
        internal DataGridViewTextBoxColumn ParteMoratorio;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_Procesar;
        internal System.ComponentModel.BackgroundWorker BackgroundConvenio;
    }
}