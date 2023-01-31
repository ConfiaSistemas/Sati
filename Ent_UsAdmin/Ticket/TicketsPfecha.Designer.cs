using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class TicketsPfecha : Form
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketsPfecha));
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            TreeListView1 = new WinControls.ListView.TreeListView();
            ContainerColumnHeader1 = new WinControls.ListView.ContainerColumnHeader();
            ContainerColumnHeader2 = new WinControls.ListView.ContainerColumnHeader();
            ContainerColumnHeader3 = new WinControls.ListView.ContainerColumnHeader();
            ContainerColumnHeader10 = new WinControls.ListView.ContainerColumnHeader();
            ContainerColumnHeader9 = new WinControls.ListView.ContainerColumnHeader();
            ContainerColumnHeader4 = new WinControls.ListView.ContainerColumnHeader();
            ContainerColumnHeader5 = new WinControls.ListView.ContainerColumnHeader();
            ContainerColumnHeader6 = new WinControls.ListView.ContainerColumnHeader();
            ContainerColumnHeader7 = new WinControls.ListView.ContainerColumnHeader();
            ContainerColumnHeader8 = new WinControls.ListView.ContainerColumnHeader();
            Panel1 = new Panel();
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton21.Click += new EventHandler(BunifuThinButton21_Click);
            BunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton22.Click += new EventHandler(BunifuThinButton22_Click);
            Label8 = new Label();
            ComboFiltro = new ComboBox();
            MonoFlat_Label2 = new MonoFlat.MonoFlat_Label();
            MonoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            dateHasta = new Bunifu.Framework.UI.BunifuDatepicker();
            dateDesde = new Bunifu.Framework.UI.BunifuDatepicker();
            BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundWorker1_DoWork);
            BackgroundCajas = new System.ComponentModel.BackgroundWorker();
            BackgroundCajas.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundCajas_DoWork);
            BackgroundCajas.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundCajas_RunWorkerCompleted);
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.Location = new Point(379, 148);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 1;
            Button1.Text = "Button1";
            Button1.UseVisualStyleBackColor = true;
            Button1.Visible = false;
            // 
            // TreeListView1
            // 
            TreeListView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            TreeListView1.Columns.AddRange(new WinControls.ListView.ContainerColumnHeader[] { ContainerColumnHeader1, ContainerColumnHeader2, ContainerColumnHeader3, ContainerColumnHeader10, ContainerColumnHeader9, ContainerColumnHeader4, ContainerColumnHeader5, ContainerColumnHeader6, ContainerColumnHeader7, ContainerColumnHeader8 });
            TreeListView1.Font = new Font("Microsoft Sans Serif", 8.25f);
            TreeListView1.Location = new Point(2, 177);
            TreeListView1.Name = "TreeListView1";
            TreeListView1.Size = new Size(1375, 489);
            TreeListView1.TabIndex = 2;
            // 
            // ContainerColumnHeader1
            // 
            ContainerColumnHeader1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContainerColumnHeader1.Text = "ID";
            // 
            // ContainerColumnHeader2
            // 
            ContainerColumnHeader2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContainerColumnHeader2.Text = "IdCrédito";
            // 
            // ContainerColumnHeader3
            // 
            ContainerColumnHeader3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContainerColumnHeader3.Text = "Nombre";
            // 
            // ContainerColumnHeader10
            // 
            ContainerColumnHeader10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContainerColumnHeader10.Text = "PagoNormal";
            // 
            // ContainerColumnHeader9
            // 
            ContainerColumnHeader9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContainerColumnHeader9.Text = "Intereses";
            // 
            // ContainerColumnHeader4
            // 
            ContainerColumnHeader4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContainerColumnHeader4.Text = "Monto";
            // 
            // ContainerColumnHeader5
            // 
            ContainerColumnHeader5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContainerColumnHeader5.Text = "Fecha";
            // 
            // ContainerColumnHeader6
            // 
            ContainerColumnHeader6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContainerColumnHeader6.Text = "Hora";
            // 
            // ContainerColumnHeader7
            // 
            ContainerColumnHeader7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContainerColumnHeader7.Text = "Tipo";
            // 
            // ContainerColumnHeader8
            // 
            ContainerColumnHeader8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContainerColumnHeader8.Text = "Caja";
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(Button2);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Location = new Point(2, 3);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1375, 36);
            Panel1.TabIndex = 9;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(63, 3);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(128, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Tickets por fecha";
            // 
            // BunifuThinButton21
            // 
            BunifuThinButton21.ActiveBorderThickness = 1;
            BunifuThinButton21.ActiveCornerRadius = 20;
            BunifuThinButton21.ActiveFillColor = Color.SeaGreen;
            BunifuThinButton21.ActiveForecolor = Color.White;
            BunifuThinButton21.ActiveLineColor = Color.SeaGreen;
            BunifuThinButton21.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BunifuThinButton21.BackColor = Color.FromArgb(0, 5, 11);
            BunifuThinButton21.BackgroundImage = (Image)resources.GetObject("BunifuThinButton21.BackgroundImage");
            BunifuThinButton21.ButtonText = "Exportar";
            BunifuThinButton21.Cursor = Cursors.Hand;
            BunifuThinButton21.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BunifuThinButton21.ForeColor = Color.SeaGreen;
            BunifuThinButton21.IdleBorderThickness = 1;
            BunifuThinButton21.IdleCornerRadius = 20;
            BunifuThinButton21.IdleFillColor = Color.White;
            BunifuThinButton21.IdleForecolor = Color.SeaGreen;
            BunifuThinButton21.IdleLineColor = Color.SeaGreen;
            BunifuThinButton21.Location = new Point(1229, 66);
            BunifuThinButton21.Margin = new Padding(5);
            BunifuThinButton21.Name = "BunifuThinButton21";
            BunifuThinButton21.Size = new Size(92, 31);
            BunifuThinButton21.TabIndex = 34;
            BunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BunifuThinButton22
            // 
            BunifuThinButton22.ActiveBorderThickness = 1;
            BunifuThinButton22.ActiveCornerRadius = 20;
            BunifuThinButton22.ActiveFillColor = Color.SeaGreen;
            BunifuThinButton22.ActiveForecolor = Color.White;
            BunifuThinButton22.ActiveLineColor = Color.SeaGreen;
            BunifuThinButton22.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BunifuThinButton22.BackColor = Color.FromArgb(0, 5, 11);
            BunifuThinButton22.BackgroundImage = (Image)resources.GetObject("BunifuThinButton22.BackgroundImage");
            BunifuThinButton22.ButtonText = "Consultar";
            BunifuThinButton22.Cursor = Cursors.Hand;
            BunifuThinButton22.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BunifuThinButton22.ForeColor = Color.SeaGreen;
            BunifuThinButton22.IdleBorderThickness = 1;
            BunifuThinButton22.IdleCornerRadius = 20;
            BunifuThinButton22.IdleFillColor = Color.White;
            BunifuThinButton22.IdleForecolor = Color.SeaGreen;
            BunifuThinButton22.IdleLineColor = Color.SeaGreen;
            BunifuThinButton22.Location = new Point(1127, 66);
            BunifuThinButton22.Margin = new Padding(5);
            BunifuThinButton22.Name = "BunifuThinButton22";
            BunifuThinButton22.Size = new Size(92, 31);
            BunifuThinButton22.TabIndex = 35;
            BunifuThinButton22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.ForeColor = Color.White;
            Label8.Location = new Point(9, 46);
            Label8.Name = "Label8";
            Label8.Size = new Size(33, 13);
            Label8.TabIndex = 41;
            Label8.Text = "Cajas";
            // 
            // ComboFiltro
            // 
            ComboFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboFiltro.FormattingEnabled = true;
            ComboFiltro.ItemHeight = 13;
            ComboFiltro.Location = new Point(12, 76);
            ComboFiltro.Name = "ComboFiltro";
            ComboFiltro.Size = new Size(239, 21);
            ComboFiltro.TabIndex = 40;
            // 
            // MonoFlat_Label2
            // 
            MonoFlat_Label2.AutoSize = true;
            MonoFlat_Label2.BackColor = Color.Transparent;
            MonoFlat_Label2.Font = new Font("Segoe UI", 9.0f);
            MonoFlat_Label2.ForeColor = Color.FromArgb(116, 125, 132);
            MonoFlat_Label2.Location = new Point(514, 46);
            MonoFlat_Label2.Name = "MonoFlat_Label2";
            MonoFlat_Label2.Size = new Size(37, 15);
            MonoFlat_Label2.TabIndex = 39;
            MonoFlat_Label2.Text = "Hasta";
            // 
            // MonoFlat_Label1
            // 
            MonoFlat_Label1.AutoSize = true;
            MonoFlat_Label1.BackColor = Color.Transparent;
            MonoFlat_Label1.Font = new Font("Segoe UI", 9.0f);
            MonoFlat_Label1.ForeColor = Color.FromArgb(116, 125, 132);
            MonoFlat_Label1.Location = new Point(271, 46);
            MonoFlat_Label1.Name = "MonoFlat_Label1";
            MonoFlat_Label1.Size = new Size(39, 15);
            MonoFlat_Label1.TabIndex = 38;
            MonoFlat_Label1.Text = "Desde";
            // 
            // dateHasta
            // 
            dateHasta.BackColor = Color.FromArgb(0, 5, 11);
            dateHasta.BorderRadius = 0;
            dateHasta.ForeColor = Color.White;
            dateHasta.Format = DateTimePickerFormat.Short;
            dateHasta.FormatCustom = null;
            dateHasta.Location = new Point(517, 64);
            dateHasta.Name = "dateHasta";
            dateHasta.Size = new Size(177, 33);
            dateHasta.TabIndex = 37;
            dateHasta.Value = new DateTime(2020, 2, 20, 0, 0, 0, 0);
            // 
            // dateDesde
            // 
            dateDesde.BackColor = Color.FromArgb(0, 5, 11);
            dateDesde.BorderRadius = 0;
            dateDesde.ForeColor = Color.White;
            dateDesde.Format = DateTimePickerFormat.Short;
            dateDesde.FormatCustom = null;
            dateDesde.Location = new Point(274, 64);
            dateDesde.Name = "dateDesde";
            dateDesde.Size = new Size(177, 33);
            dateDesde.TabIndex = 36;
            dateDesde.Value = new DateTime(2020, 2, 20, 0, 0, 0, 0);
            // 
            // BackgroundWorker1
            // 
            // 
            // BackgroundCajas
            // 
            // 
            // Button2
            // 
            Button2.FlatAppearance.BorderColor = Color.White;
            Button2.FlatStyle = FlatStyle.Flat;
            Button2.ForeColor = SystemColors.Control;
            Button2.Location = new Point(3, 3);
            Button2.Name = "Button2";
            Button2.Size = new Size(54, 23);
            Button2.TabIndex = 3;
            Button2.Text = "Atrás";
            Button2.UseVisualStyleBackColor = true;
            // 
            // TicketsPfecha
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(1380, 671);
            Controls.Add(BunifuThinButton21);
            Controls.Add(BunifuThinButton22);
            Controls.Add(Label8);
            Controls.Add(ComboFiltro);
            Controls.Add(MonoFlat_Label2);
            Controls.Add(MonoFlat_Label1);
            Controls.Add(dateHasta);
            Controls.Add(dateDesde);
            Controls.Add(Panel1);
            Controls.Add(TreeListView1);
            Controls.Add(Button1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TicketsPfecha";
            Text = "TicketsPfecha";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(TicketsPfecha_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Button Button1;
        internal WinControls.ListView.TreeListView TreeListView1;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader1;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader2;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader3;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader4;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader5;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader6;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader7;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader8;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader10;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader9;
        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton21;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton22;
        internal Label Label8;
        internal ComboBox ComboFiltro;
        internal MonoFlat.MonoFlat_Label MonoFlat_Label2;
        internal MonoFlat.MonoFlat_Label MonoFlat_Label1;
        internal Bunifu.Framework.UI.BunifuDatepicker dateHasta;
        internal Bunifu.Framework.UI.BunifuDatepicker dateDesde;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
        internal System.ComponentModel.BackgroundWorker BackgroundCajas;
        internal Button Button2;
    }
}