using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class PermisosGrupo : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(PermisosGrupo));
            TabControl1 = new TabControl();
            TabPage2 = new TabPage();
            Label14 = new Label();
            FlowLegal = new FlowLayoutPanel();
            Label13 = new Label();
            Label12 = new Label();
            FlowCajas = new FlowLayoutPanel();
            Label11 = new Label();
            FlowEmpleados = new FlowLayoutPanel();
            FlowTiposCredito = new FlowLayoutPanel();
            FlowAccesoSati = new FlowLayoutPanel();
            Label7 = new Label();
            FlowReportes = new FlowLayoutPanel();
            Label8 = new Label();
            Label9 = new Label();
            FlowCreditos = new FlowLayoutPanel();
            FlowSolicitudes = new FlowLayoutPanel();
            Label3 = new Label();
            Label5 = new Label();
            Label6 = new Label();
            FlowTiposDeDocumentos = new FlowLayoutPanel();
            FlowDocumentos = new FlowLayoutPanel();
            FlowClientes = new FlowLayoutPanel();
            Label2 = new Label();
            Label1 = new Label();
            Label4 = new Label();
            FlowCatalogos = new FlowLayoutPanel();
            FlowGrupos = new FlowLayoutPanel();
            FlowUsuarios = new FlowLayoutPanel();
            TabPage3 = new TabPage();
            Label10 = new Label();
            FlowSac = new FlowLayoutPanel();
            Panel1 = new Panel();
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            EvolveControlBox1 = new EvolveControlBox();
            btn_agregar = new Bunifu.Framework.UI.BunifuThinButton2();
            btn_agregar.Click += new EventHandler(btn_agregar_Click);
            BackgroundPermisos = new System.ComponentModel.BackgroundWorker();
            BackgroundPermisos.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundPermisos_DoWork);
            BackgroundAplicarPermisos = new System.ComponentModel.BackgroundWorker();
            BackgroundAplicarPermisos.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundAplicarPermisos_DoWork);
            BackgroundAplicarPermisos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundAplicarPermisos_RunWorkerCompleted);
            TabControl1.SuspendLayout();
            TabPage2.SuspendLayout();
            TabPage3.SuspendLayout();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(TabPage2);
            TabControl1.Controls.Add(TabPage3);
            TabControl1.Location = new Point(12, 44);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(726, 609);
            TabControl1.TabIndex = 5;
            // 
            // TabPage2
            // 
            TabPage2.BackColor = Color.FromArgb(0, 5, 11);
            TabPage2.Controls.Add(Label14);
            TabPage2.Controls.Add(FlowLegal);
            TabPage2.Controls.Add(Label13);
            TabPage2.Controls.Add(Label12);
            TabPage2.Controls.Add(FlowCajas);
            TabPage2.Controls.Add(Label11);
            TabPage2.Controls.Add(FlowEmpleados);
            TabPage2.Controls.Add(FlowTiposCredito);
            TabPage2.Controls.Add(FlowAccesoSati);
            TabPage2.Controls.Add(Label7);
            TabPage2.Controls.Add(FlowReportes);
            TabPage2.Controls.Add(Label8);
            TabPage2.Controls.Add(Label9);
            TabPage2.Controls.Add(FlowCreditos);
            TabPage2.Controls.Add(FlowSolicitudes);
            TabPage2.Controls.Add(Label3);
            TabPage2.Controls.Add(Label5);
            TabPage2.Controls.Add(Label6);
            TabPage2.Controls.Add(FlowTiposDeDocumentos);
            TabPage2.Controls.Add(FlowDocumentos);
            TabPage2.Controls.Add(FlowClientes);
            TabPage2.Controls.Add(Label2);
            TabPage2.Controls.Add(Label1);
            TabPage2.Controls.Add(Label4);
            TabPage2.Controls.Add(FlowCatalogos);
            TabPage2.Controls.Add(FlowGrupos);
            TabPage2.Controls.Add(FlowUsuarios);
            TabPage2.Location = new Point(4, 22);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new Padding(3);
            TabPage2.Size = new Size(718, 583);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "SATI";
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.ForeColor = Color.White;
            Label14.Location = new Point(12, 450);
            Label14.Name = "Label14";
            Label14.Size = new Size(33, 13);
            Label14.TabIndex = 32;
            Label14.Text = "Legal";
            // 
            // FlowLegal
            // 
            FlowLegal.BackColor = Color.White;
            FlowLegal.Location = new Point(12, 466);
            FlowLegal.Name = "FlowLegal";
            FlowLegal.Size = new Size(102, 100);
            FlowLegal.TabIndex = 31;
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.ForeColor = Color.White;
            Label13.Location = new Point(610, 312);
            Label13.Name = "Label13";
            Label13.Size = new Size(33, 13);
            Label13.TabIndex = 30;
            Label13.Text = "Cajas";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.ForeColor = Color.White;
            Label12.Location = new Point(610, 174);
            Label12.Name = "Label12";
            Label12.Size = new Size(59, 13);
            Label12.TabIndex = 30;
            Label12.Text = "Empleados";
            // 
            // FlowCajas
            // 
            FlowCajas.BackColor = Color.White;
            FlowCajas.Location = new Point(610, 328);
            FlowCajas.Name = "FlowCajas";
            FlowCajas.Size = new Size(102, 100);
            FlowCajas.TabIndex = 29;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.ForeColor = Color.White;
            Label11.Location = new Point(607, 42);
            Label11.Name = "Label11";
            Label11.Size = new Size(84, 13);
            Label11.TabIndex = 28;
            Label11.Text = "Tipos de Crédito";
            // 
            // FlowEmpleados
            // 
            FlowEmpleados.BackColor = Color.White;
            FlowEmpleados.Location = new Point(610, 190);
            FlowEmpleados.Name = "FlowEmpleados";
            FlowEmpleados.Size = new Size(102, 100);
            FlowEmpleados.TabIndex = 29;
            // 
            // FlowTiposCredito
            // 
            FlowTiposCredito.BackColor = Color.White;
            FlowTiposCredito.Location = new Point(610, 58);
            FlowTiposCredito.Name = "FlowTiposCredito";
            FlowTiposCredito.Size = new Size(102, 100);
            FlowTiposCredito.TabIndex = 27;
            // 
            // FlowAccesoSati
            // 
            FlowAccesoSati.Location = new Point(12, 6);
            FlowAccesoSati.Name = "FlowAccesoSati";
            FlowAccesoSati.Size = new Size(200, 33);
            FlowAccesoSati.TabIndex = 26;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.ForeColor = Color.White;
            Label7.Location = new Point(423, 312);
            Label7.Name = "Label7";
            Label7.Size = new Size(50, 13);
            Label7.TabIndex = 25;
            Label7.Text = "Reportes";
            // 
            // FlowReportes
            // 
            FlowReportes.BackColor = Color.White;
            FlowReportes.Location = new Point(426, 328);
            FlowReportes.Name = "FlowReportes";
            FlowReportes.Size = new Size(102, 100);
            FlowReportes.TabIndex = 24;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.ForeColor = Color.White;
            Label8.Location = new Point(214, 312);
            Label8.Name = "Label8";
            Label8.Size = new Size(45, 13);
            Label8.TabIndex = 23;
            Label8.Text = "Creditos";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.ForeColor = Color.White;
            Label9.Location = new Point(9, 312);
            Label9.Name = "Label9";
            Label9.Size = new Size(58, 13);
            Label9.TabIndex = 22;
            Label9.Text = "Solicitudes";
            // 
            // FlowCreditos
            // 
            FlowCreditos.AutoScroll = true;
            FlowCreditos.BackColor = Color.White;
            FlowCreditos.Location = new Point(217, 328);
            FlowCreditos.Name = "FlowCreditos";
            FlowCreditos.Size = new Size(97, 100);
            FlowCreditos.TabIndex = 20;
            // 
            // FlowSolicitudes
            // 
            FlowSolicitudes.AutoScroll = true;
            FlowSolicitudes.BackColor = Color.White;
            FlowSolicitudes.Location = new Point(9, 328);
            FlowSolicitudes.Name = "FlowSolicitudes";
            FlowSolicitudes.Size = new Size(99, 100);
            FlowSolicitudes.TabIndex = 19;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.ForeColor = Color.White;
            Label3.Location = new Point(422, 174);
            Label3.Name = "Label3";
            Label3.Size = new Size(109, 13);
            Label3.TabIndex = 18;
            Label3.Text = "Tipos de documentos";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.ForeColor = Color.White;
            Label5.Location = new Point(214, 174);
            Label5.Name = "Label5";
            Label5.Size = new Size(67, 13);
            Label5.TabIndex = 17;
            Label5.Text = "Documentos";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.ForeColor = Color.White;
            Label6.Location = new Point(9, 174);
            Label6.Name = "Label6";
            Label6.Size = new Size(44, 13);
            Label6.TabIndex = 16;
            Label6.Text = "Clientes";
            // 
            // FlowTiposDeDocumentos
            // 
            FlowTiposDeDocumentos.BackColor = Color.White;
            FlowTiposDeDocumentos.Location = new Point(425, 190);
            FlowTiposDeDocumentos.Name = "FlowTiposDeDocumentos";
            FlowTiposDeDocumentos.Size = new Size(102, 100);
            FlowTiposDeDocumentos.TabIndex = 15;
            // 
            // FlowDocumentos
            // 
            FlowDocumentos.BackColor = Color.White;
            FlowDocumentos.Location = new Point(217, 190);
            FlowDocumentos.Name = "FlowDocumentos";
            FlowDocumentos.Size = new Size(102, 100);
            FlowDocumentos.TabIndex = 14;
            // 
            // FlowClientes
            // 
            FlowClientes.BackColor = Color.White;
            FlowClientes.Location = new Point(9, 190);
            FlowClientes.Name = "FlowClientes";
            FlowClientes.Size = new Size(102, 100);
            FlowClientes.TabIndex = 13;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(419, 42);
            Label2.Name = "Label2";
            Label2.Size = new Size(54, 13);
            Label2.TabIndex = 12;
            Label2.Text = "Catalogos";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(211, 42);
            Label1.Name = "Label1";
            Label1.Size = new Size(41, 13);
            Label1.TabIndex = 11;
            Label1.Text = "Grupos";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.ForeColor = Color.White;
            Label4.Location = new Point(6, 42);
            Label4.Name = "Label4";
            Label4.Size = new Size(48, 13);
            Label4.TabIndex = 10;
            Label4.Text = "Usuarios";
            // 
            // FlowCatalogos
            // 
            FlowCatalogos.BackColor = Color.White;
            FlowCatalogos.Location = new Point(422, 58);
            FlowCatalogos.Name = "FlowCatalogos";
            FlowCatalogos.Size = new Size(102, 100);
            FlowCatalogos.TabIndex = 2;
            // 
            // FlowGrupos
            // 
            FlowGrupos.BackColor = Color.White;
            FlowGrupos.Location = new Point(214, 58);
            FlowGrupos.Name = "FlowGrupos";
            FlowGrupos.Size = new Size(102, 100);
            FlowGrupos.TabIndex = 1;
            // 
            // FlowUsuarios
            // 
            FlowUsuarios.BackColor = Color.White;
            FlowUsuarios.Location = new Point(6, 58);
            FlowUsuarios.Name = "FlowUsuarios";
            FlowUsuarios.Size = new Size(102, 100);
            FlowUsuarios.TabIndex = 0;
            // 
            // TabPage3
            // 
            TabPage3.BackColor = Color.FromArgb(0, 5, 11);
            TabPage3.Controls.Add(Label10);
            TabPage3.Controls.Add(FlowSac);
            TabPage3.Location = new Point(4, 22);
            TabPage3.Name = "TabPage3";
            TabPage3.Padding = new Padding(3);
            TabPage3.Size = new Size(718, 583);
            TabPage3.TabIndex = 2;
            TabPage3.Text = "SAC";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.ForeColor = Color.White;
            Label10.Location = new Point(6, 24);
            Label10.Name = "Label10";
            Label10.Size = new Size(49, 13);
            Label10.TabIndex = 12;
            Label10.Text = "Permisos";
            // 
            // FlowSac
            // 
            FlowSac.BackColor = Color.White;
            FlowSac.Location = new Point(6, 40);
            FlowSac.Name = "FlowSac";
            FlowSac.Size = new Size(102, 383);
            FlowSac.TabIndex = 11;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Location = new Point(1, 2);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(747, 36);
            Panel1.TabIndex = 6;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 3);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(140, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Permisos de grupo";
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(681, 3);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 0;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
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
            btn_agregar.ButtonText = "Aplicar";
            btn_agregar.Cursor = Cursors.Hand;
            btn_agregar.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_agregar.ForeColor = Color.SeaGreen;
            btn_agregar.IdleBorderThickness = 1;
            btn_agregar.IdleCornerRadius = 20;
            btn_agregar.IdleFillColor = Color.White;
            btn_agregar.IdleForecolor = Color.SeaGreen;
            btn_agregar.IdleLineColor = Color.SeaGreen;
            btn_agregar.Location = new Point(282, 661);
            btn_agregar.Margin = new Padding(5);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(207, 38);
            btn_agregar.TabIndex = 9;
            btn_agregar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackgroundPermisos
            // 
            // 
            // BackgroundAplicarPermisos
            // 
            // 
            // PermisosGrupo
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(750, 724);
            Controls.Add(btn_agregar);
            Controls.Add(Panel1);
            Controls.Add(TabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PermisosGrupo";
            Text = "PermisosGrupo";
            TabControl1.ResumeLayout(false);
            TabPage2.ResumeLayout(false);
            TabPage2.PerformLayout();
            TabPage3.ResumeLayout(false);
            TabPage3.PerformLayout();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(PermisosGrupo_Load);
            ResumeLayout(false);

        }

        internal TabControl TabControl1;
        internal TabPage TabPage2;
        internal TabPage TabPage3;
        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal EvolveControlBox EvolveControlBox1;
        internal FlowLayoutPanel FlowCatalogos;
        internal FlowLayoutPanel FlowGrupos;
        internal FlowLayoutPanel FlowUsuarios;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_agregar;
        internal Label Label7;
        internal FlowLayoutPanel FlowReportes;
        internal Label Label8;
        internal Label Label9;
        internal FlowLayoutPanel FlowCreditos;
        internal FlowLayoutPanel FlowSolicitudes;
        internal Label Label3;
        internal Label Label5;
        internal Label Label6;
        internal FlowLayoutPanel FlowTiposDeDocumentos;
        internal FlowLayoutPanel FlowDocumentos;
        internal FlowLayoutPanel FlowClientes;
        internal Label Label2;
        internal Label Label1;
        internal Label Label4;
        internal System.ComponentModel.BackgroundWorker BackgroundPermisos;
        internal Label Label10;
        internal FlowLayoutPanel FlowSac;
        internal FlowLayoutPanel FlowAccesoSati;
        internal System.ComponentModel.BackgroundWorker BackgroundAplicarPermisos;
        internal Label Label13;
        internal Label Label12;
        internal FlowLayoutPanel FlowCajas;
        internal Label Label11;
        internal FlowLayoutPanel FlowEmpleados;
        internal FlowLayoutPanel FlowTiposCredito;
        internal Label Label14;
        internal FlowLayoutPanel FlowLegal;
    }
}