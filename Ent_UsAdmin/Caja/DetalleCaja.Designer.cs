using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class DetalleCaja : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleCaja));
            Panel1 = new Panel();
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            EvolveControlBox1 = new EvolveControlBox();
            Label4 = new Label();
            lblNoCaja = new MonoFlat.MonoFlat_HeaderLabel();
            Label1 = new Label();
            lblFondoCaja = new MonoFlat.MonoFlat_HeaderLabel();
            lblCantRetiros = new MonoFlat.MonoFlat_HeaderLabel();
            Label2 = new Label();
            lblCantTickets = new MonoFlat.MonoFlat_HeaderLabel();
            Label3 = new Label();
            lblTotalCobrado = new MonoFlat.MonoFlat_HeaderLabel();
            Label5 = new Label();
            lblTotalRetiros = new MonoFlat.MonoFlat_HeaderLabel();
            Label6 = new Label();
            lblTotalCaja = new MonoFlat.MonoFlat_HeaderLabel();
            Label7 = new Label();
            BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundWorker1_DoWork);
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Location = new Point(3, 2);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(535, 36);
            Panel1.TabIndex = 4;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 7);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(112, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Detalle de Caja";
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(466, 3);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 0;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.ForeColor = Color.White;
            Label4.Location = new Point(25, 57);
            Label4.Name = "Label4";
            Label4.Size = new Size(82, 13);
            Label4.TabIndex = 12;
            Label4.Text = "Número de caja";
            // 
            // lblNoCaja
            // 
            lblNoCaja.AutoSize = true;
            lblNoCaja.BackColor = Color.Transparent;
            lblNoCaja.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblNoCaja.ForeColor = Color.FromArgb(255, 255, 255);
            lblNoCaja.Location = new Point(24, 81);
            lblNoCaja.Name = "lblNoCaja";
            lblNoCaja.Size = new Size(21, 20);
            lblNoCaja.TabIndex = 2;
            lblNoCaja.Text = "...";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(25, 122);
            Label1.Name = "Label1";
            Label1.Size = new Size(37, 13);
            Label1.TabIndex = 13;
            Label1.Text = "Fondo";
            // 
            // lblFondoCaja
            // 
            lblFondoCaja.AutoSize = true;
            lblFondoCaja.BackColor = Color.Transparent;
            lblFondoCaja.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblFondoCaja.ForeColor = Color.FromArgb(255, 255, 255);
            lblFondoCaja.Location = new Point(24, 148);
            lblFondoCaja.Name = "lblFondoCaja";
            lblFondoCaja.Size = new Size(21, 20);
            lblFondoCaja.TabIndex = 14;
            lblFondoCaja.Text = "...";
            // 
            // lblCantRetiros
            // 
            lblCantRetiros.AutoSize = true;
            lblCantRetiros.BackColor = Color.Transparent;
            lblCantRetiros.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblCantRetiros.ForeColor = Color.FromArgb(255, 255, 255);
            lblCantRetiros.Location = new Point(170, 148);
            lblCantRetiros.Name = "lblCantRetiros";
            lblCantRetiros.Size = new Size(21, 20);
            lblCantRetiros.TabIndex = 16;
            lblCantRetiros.Text = "...";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(171, 122);
            Label2.Name = "Label2";
            Label2.Size = new Size(100, 13);
            Label2.TabIndex = 15;
            Label2.Text = "Cantidad de Retiros";
            // 
            // lblCantTickets
            // 
            lblCantTickets.AutoSize = true;
            lblCantTickets.BackColor = Color.Transparent;
            lblCantTickets.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblCantTickets.ForeColor = Color.FromArgb(255, 255, 255);
            lblCantTickets.Location = new Point(342, 148);
            lblCantTickets.Name = "lblCantTickets";
            lblCantTickets.Size = new Size(21, 20);
            lblCantTickets.TabIndex = 18;
            lblCantTickets.Text = "...";
            lblCantTickets.TextAlign = ContentAlignment.TopCenter;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.ForeColor = Color.White;
            Label3.Location = new Point(343, 122);
            Label3.Name = "Label3";
            Label3.Size = new Size(102, 13);
            Label3.TabIndex = 17;
            Label3.Text = "Cantidad de Tickets";
            // 
            // lblTotalCobrado
            // 
            lblTotalCobrado.AutoSize = true;
            lblTotalCobrado.BackColor = Color.Transparent;
            lblTotalCobrado.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblTotalCobrado.ForeColor = Color.FromArgb(255, 255, 255);
            lblTotalCobrado.Location = new Point(24, 223);
            lblTotalCobrado.Name = "lblTotalCobrado";
            lblTotalCobrado.Size = new Size(21, 20);
            lblTotalCobrado.TabIndex = 20;
            lblTotalCobrado.Text = "...";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.ForeColor = Color.White;
            Label5.Location = new Point(25, 197);
            Label5.Name = "Label5";
            Label5.Size = new Size(74, 13);
            Label5.TabIndex = 19;
            Label5.Text = "Total Cobrado";
            // 
            // lblTotalRetiros
            // 
            lblTotalRetiros.AutoSize = true;
            lblTotalRetiros.BackColor = Color.Transparent;
            lblTotalRetiros.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblTotalRetiros.ForeColor = Color.FromArgb(255, 255, 255);
            lblTotalRetiros.Location = new Point(170, 223);
            lblTotalRetiros.Name = "lblTotalRetiros";
            lblTotalRetiros.Size = new Size(21, 20);
            lblTotalRetiros.TabIndex = 22;
            lblTotalRetiros.Text = "...";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.ForeColor = Color.White;
            Label6.Location = new Point(171, 197);
            Label6.Name = "Label6";
            Label6.Size = new Size(67, 13);
            Label6.TabIndex = 21;
            Label6.Text = "Total Retiros";
            // 
            // lblTotalCaja
            // 
            lblTotalCaja.AutoSize = true;
            lblTotalCaja.BackColor = Color.Transparent;
            lblTotalCaja.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblTotalCaja.ForeColor = Color.FromArgb(255, 255, 255);
            lblTotalCaja.Location = new Point(342, 223);
            lblTotalCaja.Name = "lblTotalCaja";
            lblTotalCaja.Size = new Size(21, 20);
            lblTotalCaja.TabIndex = 24;
            lblTotalCaja.Text = "...";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.ForeColor = Color.White;
            Label7.Location = new Point(343, 197);
            Label7.Name = "Label7";
            Label7.Size = new Size(70, 13);
            Label7.TabIndex = 23;
            Label7.Text = "Total en Caja";
            // 
            // BackgroundWorker1
            // 
            // 
            // DetalleCaja
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(540, 390);
            Controls.Add(lblTotalCaja);
            Controls.Add(Label7);
            Controls.Add(lblTotalRetiros);
            Controls.Add(Label6);
            Controls.Add(lblTotalCobrado);
            Controls.Add(Label5);
            Controls.Add(lblCantTickets);
            Controls.Add(Label3);
            Controls.Add(lblCantRetiros);
            Controls.Add(Label2);
            Controls.Add(lblFondoCaja);
            Controls.Add(Label1);
            Controls.Add(lblNoCaja);
            Controls.Add(Label4);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DetalleCaja";
            Text = "Detalle de Caja";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal EvolveControlBox EvolveControlBox1;
        internal Label Label4;
        internal MonoFlat.MonoFlat_HeaderLabel lblNoCaja;
        internal Label Label1;
        internal MonoFlat.MonoFlat_HeaderLabel lblFondoCaja;
        internal MonoFlat.MonoFlat_HeaderLabel lblCantRetiros;
        internal Label Label2;
        internal MonoFlat.MonoFlat_HeaderLabel lblCantTickets;
        internal Label Label3;
        internal MonoFlat.MonoFlat_HeaderLabel lblTotalCobrado;
        internal Label Label5;
        internal MonoFlat.MonoFlat_HeaderLabel lblTotalRetiros;
        internal Label Label6;
        internal MonoFlat.MonoFlat_HeaderLabel lblTotalCaja;
        internal Label Label7;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
    }
}