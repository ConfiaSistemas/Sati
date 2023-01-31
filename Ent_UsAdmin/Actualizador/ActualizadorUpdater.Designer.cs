using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ActualizadorUpdater : Form
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
            Panel3 = new Panel();
            Button4 = new Button();
            Button4.Click += new EventHandler(Button4_Click);
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click);
            Label2 = new Label();
            btnCancelar = new Button();
            lblTiempo = new Label();
            lblTiempoSistema = new Label();
            Label1 = new Label();
            lblSistema = new Label();
            FlowLayoutPanel1 = new FlowLayoutPanel();
            Panel1 = new Panel();
            lblProgreso = new Telerik.WinControls.UI.RadLabel();
            RadLabel2 = new Telerik.WinControls.UI.RadLabel();
            RadLabel1 = new Telerik.WinControls.UI.RadLabel();
            lblTamaño = new Telerik.WinControls.UI.RadLabel();
            lblDescargado = new Telerik.WinControls.UI.RadLabel();
            Panel2 = new Panel();
            lblProgresoDescompresion = new Telerik.WinControls.UI.RadLabel();
            lblArchivo = new Label();
            RadLabel4 = new Telerik.WinControls.UI.RadLabel();
            RadLabel5 = new Telerik.WinControls.UI.RadLabel();
            lblTotalArchivos = new Telerik.WinControls.UI.RadLabel();
            lblDescompreso = new Telerik.WinControls.UI.RadLabel();
            Label4 = new Label();
            lblEstado = new Label();
            BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundWorker1_DoWork);
            BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundWorker1_RunWorkerCompleted);
            Timer1 = new Timer(components);
            Timer1.Tick += new EventHandler(Timer1_Tick);
            BackgroundDescomprimir = new System.ComponentModel.BackgroundWorker();
            BackgroundDescomprimir.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundDescomprimir_DoWork);
            BackgroundDescomprimir.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundDescomprimir_RunWorkerCompleted);
            TimerCuentaRegresiva = new Timer(components);
            Panel3.SuspendLayout();
            FlowLayoutPanel1.SuspendLayout();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lblProgreso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RadLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RadLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblTamaño).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblDescargado).BeginInit();
            Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lblProgresoDescompresion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RadLabel4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RadLabel5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblTotalArchivos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblDescompreso).BeginInit();
            SuspendLayout();
            // 
            // Panel3
            // 
            Panel3.BackColor = Color.FromArgb(14, 21, 38);
            Panel3.Controls.Add(Button4);
            Panel3.Controls.Add(Button3);
            Panel3.Controls.Add(Label2);
            Panel3.Location = new Point(0, 1);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(481, 24);
            Panel3.TabIndex = 16;
            // 
            // Button4
            // 
            Button4.BackgroundImage = My.Resources.Resources.boton_de_quitar_cuadrado;
            Button4.BackgroundImageLayout = ImageLayout.Stretch;
            Button4.Location = new Point(454, 0);
            Button4.Name = "Button4";
            Button4.Size = new Size(27, 24);
            Button4.TabIndex = 17;
            Button4.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            Button3.BackgroundImage = My.Resources.Resources.minimizar_pestana;
            Button3.BackgroundImageLayout = ImageLayout.Stretch;
            Button3.Location = new Point(424, 0);
            Button3.Name = "Button3";
            Button3.Size = new Size(27, 24);
            Button3.TabIndex = 16;
            Button3.Text = "Button3";
            Button3.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(3, 6);
            Label2.Name = "Label2";
            Label2.Size = new Size(152, 13);
            Label2.TabIndex = 16;
            Label2.Text = "Actualizador Préstamos Confía";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(395, 39);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.ForeColor = Color.White;
            lblTiempo.Location = new Point(279, 52);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(16, 13);
            lblTiempo.TabIndex = 23;
            lblTiempo.Text = "...";
            lblTiempo.Visible = false;
            // 
            // lblTiempoSistema
            // 
            lblTiempoSistema.AutoSize = true;
            lblTiempoSistema.ForeColor = Color.White;
            lblTiempoSistema.Location = new Point(153, 52);
            lblTiempoSistema.Name = "lblTiempoSistema";
            lblTiempoSistema.Size = new Size(125, 13);
            lblTiempoSistema.TabIndex = 22;
            lblTiempoSistema.Text = "El equipo se apagará en ";
            lblTiempoSistema.Visible = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(6, 29);
            Label1.Name = "Label1";
            Label1.Size = new Size(47, 13);
            Label1.TabIndex = 21;
            Label1.Text = "Sistema:";
            // 
            // lblSistema
            // 
            lblSistema.AutoSize = true;
            lblSistema.ForeColor = Color.White;
            lblSistema.Location = new Point(55, 29);
            lblSistema.Name = "lblSistema";
            lblSistema.Size = new Size(16, 13);
            lblSistema.TabIndex = 20;
            lblSistema.Text = "...";
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.Controls.Add(Panel1);
            FlowLayoutPanel1.Controls.Add(Panel2);
            FlowLayoutPanel1.Location = new Point(-1, 68);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(481, 287);
            FlowLayoutPanel1.TabIndex = 19;
            // 
            // Panel1
            // 
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Controls.Add(lblProgreso);
            Panel1.Controls.Add(RadLabel2);
            Panel1.Controls.Add(RadLabel1);
            Panel1.Controls.Add(lblTamaño);
            Panel1.Controls.Add(lblDescargado);
            Panel1.Location = new Point(3, 3);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(468, 136);
            Panel1.TabIndex = 7;
            // 
            // lblProgreso
            // 
            lblProgreso.Font = new Font("Segoe UI", 24.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProgreso.ForeColor = Color.Gray;
            lblProgreso.Location = new Point(153, 46);
            lblProgreso.Name = "lblProgreso";
            // 
            // 
            // 
            lblProgreso.RootElement.ApplyShapeToControl = true;
            lblProgreso.RootElement.BorderHighlightColor = Color.Black;
            lblProgreso.RootElement.ClickMode = Telerik.WinControls.ClickMode.Release;
            lblProgreso.RootElement.ClipDrawing = false;
            lblProgreso.RootElement.EnableBorderHighlight = true;
            lblProgreso.RootElement.EnableFocusBorder = true;
            lblProgreso.RootElement.EnableHighlight = true;
            lblProgreso.RootElement.Shape = null;
            lblProgreso.Size = new Size(58, 49);
            lblProgreso.TabIndex = 6;
            lblProgreso.Text = "0%";
            // 
            // RadLabel2
            // 
            RadLabel2.Font = new Font("Segoe UI", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            RadLabel2.ForeColor = Color.Gray;
            RadLabel2.Location = new Point(274, 7);
            RadLabel2.Name = "RadLabel2";
            // 
            // 
            // 
            RadLabel2.RootElement.ApplyShapeToControl = true;
            RadLabel2.RootElement.BorderHighlightColor = Color.Black;
            RadLabel2.RootElement.ClickMode = Telerik.WinControls.ClickMode.Release;
            RadLabel2.RootElement.ClipDrawing = false;
            RadLabel2.RootElement.EnableBorderHighlight = true;
            RadLabel2.RootElement.EnableFocusBorder = true;
            RadLabel2.RootElement.EnableHighlight = true;
            RadLabel2.RootElement.Shape = null;
            RadLabel2.Size = new Size(86, 33);
            RadLabel2.TabIndex = 5;
            RadLabel2.Text = "Tamaño";
            // 
            // RadLabel1
            // 
            RadLabel1.Font = new Font("Segoe UI", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            RadLabel1.ForeColor = Color.Gray;
            RadLabel1.Location = new Point(11, 3);
            RadLabel1.Name = "RadLabel1";
            // 
            // 
            // 
            RadLabel1.RootElement.ApplyShapeToControl = true;
            RadLabel1.RootElement.BorderHighlightColor = Color.Black;
            RadLabel1.RootElement.ClickMode = Telerik.WinControls.ClickMode.Release;
            RadLabel1.RootElement.ClipDrawing = false;
            RadLabel1.RootElement.EnableBorderHighlight = true;
            RadLabel1.RootElement.EnableFocusBorder = true;
            RadLabel1.RootElement.EnableHighlight = true;
            RadLabel1.RootElement.Shape = null;
            RadLabel1.Size = new Size(123, 33);
            RadLabel1.TabIndex = 4;
            RadLabel1.Text = "Descargado";
            // 
            // lblTamaño
            // 
            lblTamaño.Font = new Font("Segoe UI", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTamaño.ForeColor = Color.Gray;
            lblTamaño.Location = new Point(275, 46);
            lblTamaño.Name = "lblTamaño";
            lblTamaño.Size = new Size(24, 33);
            lblTamaño.TabIndex = 4;
            lblTamaño.Text = "...";
            // 
            // lblDescargado
            // 
            lblDescargado.Font = new Font("Segoe UI", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescargado.ForeColor = Color.Gray;
            lblDescargado.Location = new Point(14, 46);
            lblDescargado.Name = "lblDescargado";
            // 
            // 
            // 
            lblDescargado.RootElement.ApplyShapeToControl = true;
            lblDescargado.RootElement.BorderHighlightColor = Color.Black;
            lblDescargado.RootElement.ClickMode = Telerik.WinControls.ClickMode.Release;
            lblDescargado.RootElement.ClipDrawing = false;
            lblDescargado.RootElement.EnableBorderHighlight = true;
            lblDescargado.RootElement.EnableFocusBorder = true;
            lblDescargado.RootElement.EnableHighlight = true;
            lblDescargado.RootElement.Shape = null;
            lblDescargado.Size = new Size(24, 33);
            lblDescargado.TabIndex = 3;
            lblDescargado.Text = "...";
            // 
            // Panel2
            // 
            Panel2.BorderStyle = BorderStyle.FixedSingle;
            Panel2.Controls.Add(lblProgresoDescompresion);
            Panel2.Controls.Add(lblArchivo);
            Panel2.Controls.Add(RadLabel4);
            Panel2.Controls.Add(RadLabel5);
            Panel2.Controls.Add(lblTotalArchivos);
            Panel2.Controls.Add(lblDescompreso);
            Panel2.Location = new Point(3, 145);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(468, 136);
            Panel2.TabIndex = 8;
            // 
            // lblProgresoDescompresion
            // 
            lblProgresoDescompresion.Font = new Font("Segoe UI", 24.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProgresoDescompresion.ForeColor = Color.Gray;
            lblProgresoDescompresion.Location = new Point(153, 46);
            lblProgresoDescompresion.Name = "lblProgresoDescompresion";
            // 
            // 
            // 
            lblProgresoDescompresion.RootElement.ApplyShapeToControl = true;
            lblProgresoDescompresion.RootElement.BorderHighlightColor = Color.Black;
            lblProgresoDescompresion.RootElement.ClickMode = Telerik.WinControls.ClickMode.Release;
            lblProgresoDescompresion.RootElement.ClipDrawing = false;
            lblProgresoDescompresion.RootElement.EnableBorderHighlight = true;
            lblProgresoDescompresion.RootElement.EnableFocusBorder = true;
            lblProgresoDescompresion.RootElement.EnableHighlight = true;
            lblProgresoDescompresion.RootElement.Shape = null;
            lblProgresoDescompresion.Size = new Size(58, 49);
            lblProgresoDescompresion.TabIndex = 11;
            lblProgresoDescompresion.Text = "0%";
            // 
            // lblArchivo
            // 
            lblArchivo.AutoSize = true;
            lblArchivo.BackColor = Color.Transparent;
            lblArchivo.ForeColor = Color.Gray;
            lblArchivo.Location = new Point(11, 110);
            lblArchivo.Name = "lblArchivo";
            lblArchivo.Size = new Size(16, 13);
            lblArchivo.TabIndex = 5;
            lblArchivo.Text = "...";
            // 
            // RadLabel4
            // 
            RadLabel4.Font = new Font("Segoe UI", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            RadLabel4.ForeColor = Color.Gray;
            RadLabel4.Location = new Point(274, 7);
            RadLabel4.Name = "RadLabel4";
            // 
            // 
            // 
            RadLabel4.RootElement.ApplyShapeToControl = true;
            RadLabel4.RootElement.BorderHighlightColor = Color.Black;
            RadLabel4.RootElement.ClickMode = Telerik.WinControls.ClickMode.Release;
            RadLabel4.RootElement.ClipDrawing = false;
            RadLabel4.RootElement.EnableBorderHighlight = true;
            RadLabel4.RootElement.EnableFocusBorder = true;
            RadLabel4.RootElement.EnableHighlight = true;
            RadLabel4.RootElement.Shape = null;
            RadLabel4.Size = new Size(144, 33);
            RadLabel4.TabIndex = 10;
            RadLabel4.Text = "Total Archivos";
            // 
            // RadLabel5
            // 
            RadLabel5.Font = new Font("Segoe UI", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            RadLabel5.ForeColor = Color.Gray;
            RadLabel5.Location = new Point(11, 3);
            RadLabel5.Name = "RadLabel5";
            // 
            // 
            // 
            RadLabel5.RootElement.ApplyShapeToControl = true;
            RadLabel5.RootElement.BorderHighlightColor = Color.Black;
            RadLabel5.RootElement.ClickMode = Telerik.WinControls.ClickMode.Release;
            RadLabel5.RootElement.ClipDrawing = false;
            RadLabel5.RootElement.EnableBorderHighlight = true;
            RadLabel5.RootElement.EnableFocusBorder = true;
            RadLabel5.RootElement.EnableHighlight = true;
            RadLabel5.RootElement.Shape = null;
            RadLabel5.Size = new Size(257, 33);
            RadLabel5.TabIndex = 8;
            RadLabel5.Text = "Archivos Descomprimidos";
            // 
            // lblTotalArchivos
            // 
            lblTotalArchivos.Font = new Font("Segoe UI", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalArchivos.ForeColor = Color.Gray;
            lblTotalArchivos.Location = new Point(275, 46);
            lblTotalArchivos.Name = "lblTotalArchivos";
            lblTotalArchivos.Size = new Size(24, 33);
            lblTotalArchivos.TabIndex = 9;
            lblTotalArchivos.Text = "...";
            // 
            // lblDescompreso
            // 
            lblDescompreso.Font = new Font("Segoe UI", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescompreso.ForeColor = Color.Gray;
            lblDescompreso.Location = new Point(14, 46);
            lblDescompreso.Name = "lblDescompreso";
            // 
            // 
            // 
            lblDescompreso.RootElement.ApplyShapeToControl = true;
            lblDescompreso.RootElement.BorderHighlightColor = Color.Black;
            lblDescompreso.RootElement.ClickMode = Telerik.WinControls.ClickMode.Release;
            lblDescompreso.RootElement.ClipDrawing = false;
            lblDescompreso.RootElement.EnableBorderHighlight = true;
            lblDescompreso.RootElement.EnableFocusBorder = true;
            lblDescompreso.RootElement.EnableHighlight = true;
            lblDescompreso.RootElement.Shape = null;
            lblDescompreso.Size = new Size(24, 33);
            lblDescompreso.TabIndex = 7;
            lblDescompreso.Text = "...";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.ForeColor = Color.White;
            Label4.Location = new Point(6, 52);
            Label4.Name = "Label4";
            Label4.Size = new Size(43, 13);
            Label4.TabIndex = 18;
            Label4.Text = "Estado:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.ForeColor = Color.White;
            lblEstado.Location = new Point(55, 52);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(16, 13);
            lblEstado.TabIndex = 17;
            lblEstado.Text = "...";
            // 
            // BackgroundWorker1
            // 
            // 
            // Timer1
            // 
            // 
            // BackgroundDescomprimir
            // 
            // 
            // ActualizadorUpdater
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 34, 62);
            ClientSize = new Size(479, 384);
            Controls.Add(btnCancelar);
            Controls.Add(lblTiempo);
            Controls.Add(lblTiempoSistema);
            Controls.Add(Label1);
            Controls.Add(lblSistema);
            Controls.Add(FlowLayoutPanel1);
            Controls.Add(Label4);
            Controls.Add(lblEstado);
            Controls.Add(Panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ActualizadorUpdater";
            Text = "ActualizadorUpdater";
            Panel3.ResumeLayout(false);
            Panel3.PerformLayout();
            FlowLayoutPanel1.ResumeLayout(false);
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lblProgreso).EndInit();
            ((System.ComponentModel.ISupportInitialize)RadLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)RadLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblTamaño).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblDescargado).EndInit();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lblProgresoDescompresion).EndInit();
            ((System.ComponentModel.ISupportInitialize)RadLabel4).EndInit();
            ((System.ComponentModel.ISupportInitialize)RadLabel5).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblTotalArchivos).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblDescompreso).EndInit();
            Load += new EventHandler(ActualizadorUpdater_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Panel Panel3;
        internal Button Button4;
        internal Button Button3;
        internal Label Label2;
        internal Button btnCancelar;
        internal Label lblTiempo;
        internal Label lblTiempoSistema;
        internal Label Label1;
        internal Label lblSistema;
        internal FlowLayoutPanel FlowLayoutPanel1;
        internal Panel Panel1;
        internal Telerik.WinControls.UI.RadLabel lblProgreso;
        internal Telerik.WinControls.UI.RadLabel RadLabel2;
        internal Telerik.WinControls.UI.RadLabel RadLabel1;
        internal Telerik.WinControls.UI.RadLabel lblTamaño;
        internal Telerik.WinControls.UI.RadLabel lblDescargado;
        internal Panel Panel2;
        internal Telerik.WinControls.UI.RadLabel lblProgresoDescompresion;
        internal Label lblArchivo;
        internal Telerik.WinControls.UI.RadLabel RadLabel4;
        internal Telerik.WinControls.UI.RadLabel RadLabel5;
        internal Telerik.WinControls.UI.RadLabel lblTotalArchivos;
        internal Telerik.WinControls.UI.RadLabel lblDescompreso;
        internal Label Label4;
        internal Label lblEstado;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
        internal Timer Timer1;
        internal System.ComponentModel.BackgroundWorker BackgroundDescomprimir;
        internal Timer TimerCuentaRegresiva;
    }
}