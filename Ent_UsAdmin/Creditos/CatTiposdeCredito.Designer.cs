﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class CatTiposdeCredito : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(CatTiposdeCredito));
            dtimpuestos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            dtimpuestos.CellContentClick += new DataGridViewCellEventHandler(dtimpuestos_CellContentClick);
            dtimpuestos.CellContentDoubleClick += new DataGridViewCellEventHandler(dtimpuestos_CellContentDoubleClick);
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Modalidad = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Plazo = new DataGridViewTextBoxColumn();
            Panel1 = new Panel();
            BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton21.Click += new EventHandler(BunifuThinButton21_Click);
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            btn_agregar = new Button();
            btn_agregar.Click += new EventHandler(btn_agregar_Click);
            ((System.ComponentModel.ISupportInitialize)dtimpuestos).BeginInit();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtimpuestos
            // 
            dtimpuestos.AllowUserToAddRows = false;
            dtimpuestos.AllowUserToDeleteRows = false;
            DataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dtimpuestos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            dtimpuestos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            dtimpuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtimpuestos.BackgroundColor = Color.Gainsboro;
            dtimpuestos.BorderStyle = BorderStyle.None;
            dtimpuestos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.DarkSlateGray;
            DataGridViewCellStyle2.Font = new Font("Century Gothic", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle2.ForeColor = Color.FromArgb(223, 223, 223);
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtimpuestos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            dtimpuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtimpuestos.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Modalidad, Tipo, Plazo });
            dtimpuestos.DoubleBuffered = true;
            dtimpuestos.EnableHeadersVisualStyles = false;
            dtimpuestos.HeaderBgColor = Color.DarkSlateGray;
            dtimpuestos.HeaderForeColor = Color.FromArgb(223, 223, 223);
            dtimpuestos.Location = new Point(55, 45);
            dtimpuestos.Name = "dtimpuestos";
            dtimpuestos.ReadOnly = true;
            dtimpuestos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtimpuestos.RowHeadersVisible = false;
            dtimpuestos.Size = new Size(708, 473);
            dtimpuestos.TabIndex = 7;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 42;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 79;
            // 
            // Modalidad
            // 
            Modalidad.HeaderText = "Modalidad";
            Modalidad.Name = "Modalidad";
            Modalidad.ReadOnly = true;
            Modalidad.Width = 96;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Width = 55;
            // 
            // Plazo
            // 
            Plazo.HeaderText = "Plazo";
            Plazo.Name = "Plazo";
            Plazo.ReadOnly = true;
            Plazo.Width = 62;
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(BunifuThinButton21);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Location = new Point(3, 3);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(765, 36);
            Panel1.TabIndex = 6;
            // 
            // BunifuThinButton21
            // 
            BunifuThinButton21.ActiveBorderThickness = 1;
            BunifuThinButton21.ActiveCornerRadius = 20;
            BunifuThinButton21.ActiveFillColor = Color.SeaGreen;
            BunifuThinButton21.ActiveForecolor = Color.White;
            BunifuThinButton21.ActiveLineColor = Color.SeaGreen;
            BunifuThinButton21.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BunifuThinButton21.BackColor = Color.FromArgb(14, 21, 38);
            BunifuThinButton21.BackgroundImage = (Image)resources.GetObject("BunifuThinButton21.BackgroundImage");
            BunifuThinButton21.ButtonText = "Actualizar";
            BunifuThinButton21.Cursor = Cursors.Hand;
            BunifuThinButton21.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BunifuThinButton21.ForeColor = Color.SeaGreen;
            BunifuThinButton21.IdleBorderThickness = 1;
            BunifuThinButton21.IdleCornerRadius = 20;
            BunifuThinButton21.IdleFillColor = Color.White;
            BunifuThinButton21.IdleForecolor = Color.SeaGreen;
            BunifuThinButton21.IdleLineColor = Color.SeaGreen;
            BunifuThinButton21.Location = new Point(668, 3);
            BunifuThinButton21.Margin = new Padding(5);
            BunifuThinButton21.Name = "BunifuThinButton21";
            BunifuThinButton21.Size = new Size(92, 31);
            BunifuThinButton21.TabIndex = 4;
            BunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 3);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(123, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Tipos de Crédito";
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = Color.FromArgb(233, 233, 233);
            btn_agregar.BackgroundImage = My.Resources.Resources.impuestos_mas;
            btn_agregar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_agregar.FlatAppearance.MouseDownBackColor = Color.Silver;
            btn_agregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 246, 245);
            btn_agregar.FlatStyle = FlatStyle.Flat;
            btn_agregar.Location = new Point(7, 54);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(40, 35);
            btn_agregar.TabIndex = 8;
            btn_agregar.UseVisualStyleBackColor = false;
            // 
            // CatTiposdeCredito
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(773, 530);
            Controls.Add(btn_agregar);
            Controls.Add(dtimpuestos);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CatTiposdeCredito";
            Text = "CatTiposdeCredito";
            ((System.ComponentModel.ISupportInitialize)dtimpuestos).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(CatTiposdeCredito_Load);
            ResumeLayout(false);

        }

        internal Button btn_agregar;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtimpuestos;
        internal Panel Panel1;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton21;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal DataGridViewTextBoxColumn Id;
        internal DataGridViewTextBoxColumn Nombre;
        internal DataGridViewTextBoxColumn Modalidad;
        internal DataGridViewTextBoxColumn Tipo;
        internal DataGridViewTextBoxColumn Plazo;
    }
}