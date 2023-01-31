using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using HtmlAgilityPack;
using System.Globalization;

namespace ConfiaAdmin
{

    public partial class frm_adm
    {
        private Form ventana = new Form();
        public bool abierto = false;
        private int widthmenu = 0;
        private bool widthmenubool = false;
        private bool widthmenuperfilbool = false;
        private Size sizeventanas;
        private double op = 0d;
        public bool cerrarEmpresa;
        public bool mostrarpanelsecundario = false;
        public bool cerrarSesion;
        public bool cerrandoSesion;
        public bool cerrandoEmpresa;
        private bool hayActualizacion;
        private bool actualizar;
        public ArrayList array = new ArrayList();
        internal MySqlConnection conexionsql;
        public int CantNotificaciones = 0;
        private string music = @"C:\ConfiaAdmin\NOTIFICACION.wav"; // *.wav file location
        private System.Media.SoundPlayer media;
        string dolar = "";
        string euro = "";
        public frm_adm()
        {
            media = new System.Media.SoundPlayer(music);
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Timer1.Interval = 150;


            Timer1.Start();
            Opacity = op;
            if (op < 1d)
            {
                op = op + 0.1d;
                Opacity = op;
            }

            // MessageBox.Show(Str(op))
            else
            {
                op = 0d;
                Timer1.Stop();
                Timer1.Enabled = false;


            }
        }

        private void frm_adm_Activated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Module1.imgstrusr))
            {
                imgperfil.Image = My.Resources.Resources.usuario;
            }
            else
            {
                imgperfil.Image = Module1.bitmapimgusr;
            }
        }

        private void frm_adm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // perfilalt.Close()

        }

        private void frm_adm_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
                Timer2.Stop();
                My.MyProject.Forms.CierraEmpresa.Close();
                My.MyProject.Forms.perfilalt.Close();
                abierto = false;
                if (actualizar)
                {
                }

                else if (cerrarSesion)
                {
                    if (cerrarEmpresa)
                    {
                        if (MessageBox.Show("¿Está seguro que desea cerrar la empresa?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            My.MyProject.Forms.perfilalt.TopMost = false;

                            // Application.ExitThread()
                            My.MyProject.Forms.Empresas.Show();
                            cerrarSesion = false;
                            cerrandoSesion = true;
                            // Dim i As Integer = 0
                            // i = Application.OpenForms.Count
                            // For a As Integer = 0 To i
                            // Dim frm As Form
                            // frm = New Form
                            // frm = Application.OpenForms.Item(a)
                            // If frm.Name <> "login" And frm.Name <> Me.Name Then
                            // frm.Close()
                            // End If
                            // Next

                            int num_controles = Application.OpenForms.Count - 1;
                            for (int n = num_controles; n >= 0; n -= 1)
                            {
                                var ctrl = Application.OpenForms[n];
                                if (ctrl.Name != "Empresas" & (ctrl.Name ?? "") != (Name ?? ""))
                                {
                                    ctrl.Close();
                                }

                                // ctrl.Dispose()
                            }

                            Close();
                        }

                        else
                        {
                            cerrarSesion = false;

                            e.Cancel = true;

                        }
                    }
                    else if (MessageBox.Show("¿Está seguro que desea cerrar sesión?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        My.MyProject.Forms.perfilalt.TopMost = false;
                        MySqlConnection conexionSesion;
                        conexionSesion = new MySqlConnection();
                        conexionSesion.ConnectionString = "server=www.prestamosconfia.com;user id=ajas;pwd=123456;port=3306;database=USRS";
                        conexionSesion.Open();
                        MySqlCommand comandoActSesion;
                        string consultaActSesion;
                        consultaActSesion = "update Sesiones set Activo = 0 where id = '" + Module1.idSesion + "'";
                        comandoActSesion = new MySqlCommand();
                        comandoActSesion.Connection = conexionSesion;
                        comandoActSesion.CommandText = consultaActSesion;
                        comandoActSesion.ExecuteNonQuery();
                        conexionSesion.Close();
                        // Application.ExitThread()
                        My.MyProject.Forms.login.Show();
                        cerrarSesion = false;
                        cerrandoSesion = true;
                        // Dim i As Integer = 0
                        // i = Application.OpenForms.Count
                        // For a As Integer = 0 To i
                        // Dim frm As Form
                        // frm = New Form
                        // frm = Application.OpenForms.Item(a)
                        // If frm.Name <> "login" And frm.Name <> Me.Name Then
                        // frm.Close()
                        // End If
                        // Next

                        int num_controles = Application.OpenForms.Count - 1;
                        for (int n = num_controles; n >= 0; n -= 1)
                        {
                            var ctrl = Application.OpenForms[n];
                            if (ctrl.Name != "login" & (ctrl.Name ?? "") != (Name ?? ""))
                            {
                                ctrl.Close();
                            }

                            // ctrl.Dispose()
                        }

                        Close();
                    }

                    else
                    {
                        cerrarSesion = false;

                        e.Cancel = true;

                    }
                }

                else if (cerrandoSesion)
                {
                }
                // MessageBox.Show("hola")
                // MessageBox.Show("hola")
                else if (MessageBox.Show("¿Está seguro que desea salir?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    My.MyProject.Forms.perfilalt.TopMost = false;
                    MySqlConnection conexionSesion;
                    conexionSesion = new MySqlConnection();
                    conexionSesion.ConnectionString = "server=www.prestamosconfia.com;user id=ajas;pwd=123456;port=3306;database=USRS";
                    conexionSesion.Open();
                    MySqlCommand comandoActSesion;
                    string consultaActSesion;
                    consultaActSesion = "update Sesiones set Activo = 0 where id = '" + Module1.idSesion + "'";
                    comandoActSesion = new MySqlCommand();
                    comandoActSesion.Connection = conexionSesion;
                    comandoActSesion.CommandText = consultaActSesion;
                    comandoActSesion.ExecuteNonQuery();
                    conexionSesion.Close();
                    Application.ExitThread();
                }



                else
                {
                    e.Cancel = true;


                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void frm_adm_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyData == (int)Keys.Control + (int)Keys.L)
            {
                My.MyProject.Forms.login.bloqueado = true;
                My.MyProject.Forms.login.ShowDialog();
            }

            if ((int)e.KeyData == (int)Keys.Control + (int)Keys.R)
            {

                My.MyProject.Forms.Run.ShowDialog();
            }

        }
        private SqlDependency sqlDependency;
        private void frm_login_Load(object sender, EventArgs e)
        {


            TimerActualizacion.Interval = 60000;
            TimerActualizacion.Enabled = true;
            TimerActualizacion.Start();
            TimerNotificaciones.Interval = 10000;
            TimerNotificaciones.Enabled = true;
            TimerNotificaciones.Start();
            TimerActSesion.Interval = 60000;
            TimerActSesion.Enabled = true;
            TimerActSesion.Start();
            timerDolar.Interval = 10000;
            timerDolar.Enabled = true;
            timerDolar.Start();
           timerEuro.Interval = 10000;
           timerEuro.Enabled = true;
           timerEuro.Start();
            DoubleBuffered = true;

            TimerLiberar.Enabled = true;
            TimerLiberar.Start();

            foreach (DataRow row in Module1.dataPermisos.Rows)
            {





                if (Conversions.ToBoolean(row["SatiModSolicitudes"]))
                {
                    BunifuFlatButton3.Enabled = true;
                }
                else
                {
                    BunifuFlatButton3.Enabled = false;
                }

                if (Conversions.ToBoolean(row["SatiModCreditos"]))
                {
                    BunifuFlatButton4.Enabled = true;
                }
                else
                {
                    BunifuFlatButton4.Enabled = false;
                }

                if (Conversions.ToBoolean(row["SatiModReportes"]))
                {
                    BunifuFlatButton8.Enabled = true;
                }
                else
                {
                    BunifuFlatButton8.Enabled = false;
                }
                if (Conversions.ToBoolean(row["SatiModEmpeñosAgregarSolicitud"]))
                {
                    MonoFlat_Button1.Visible = true;
                    MonoFlat_Button2.Visible = true;
                }
                else
                {
                    MonoFlat_Button1.Visible = false;
                    MonoFlat_Button2.Visible = false;

                }
            }

            Module1.FlushMemory();
            Text = "SATI" + " - " + Module1.nombreAmostrar;
            sizeventanas = new Size(Width - panelmenus.Width - 20, Height - Panel1.Height - 43);
            if (string.IsNullOrEmpty(Module1.imgstrusr))
            {
                imgperfil.Image = My.Resources.Resources.usuario;
            }
            else
            {
                imgperfil.Image = Module1.bitmapimgusr;
            }

            notificaciones.Text = "Tienes " + array.Count + " notificaciones";
            notificaciones.Refresh();

            Timer1.Enabled = true;
            Timer2.Enabled = true;


            Opacity = 0d;
            My.MyProject.Forms.inicio.MdiParent = this;

            My.MyProject.Forms.inicio.Height = Height - Panel1.Height - 10;
            My.MyProject.Forms.inicio.Width = Width - panelmenus.Width + 1000;
            My.MyProject.Forms.inicio.FormBorderStyle = FormBorderStyle.None;
            My.MyProject.Forms.inicio.AutoScroll = false;

            My.MyProject.Forms.inicio.Location = new Point(panelmenus.Width + 10, Panel1.Height + 10);
            My.MyProject.Forms.inv.Height = Height - Panel1.Height;
            My.MyProject.Forms.inv.Width = Width - panelmenus.Width;
            panelmenus.Width = 0;


            My.MyProject.Forms.inv.AutoScroll = false;
            My.MyProject.Forms.inicio.Show();
            ventana.Name = My.MyProject.Forms.inicio.Name;
            acomodar();
            // inicio.Panelsecundario.BackColor = Color.FromArgb(0, 100, 100, 100)
            My.MyProject.Forms.inicio.Panelsecundario.Left = panelusuarios.Width + Panelconfiguracion.Width + BunifuImageButton1.Width + 10;
            My.MyProject.Forms.inicio.Panelsecundario.Top = 0;
            if (BunifuImageButton1.Width + panelusuarios.Width + Panelconfiguracion.Width + Panel3.Width + Panel4.Width + notificaciones.Width + imgperfil.Width + 30 > Panel1.Width)
            {




                imgmostrarpanel.Visible = true;
            }




            else
            {



                imgmostrarpanel.Visible = false;





            }
            imgmostrarpanel.Left = panelusuarios.Width + Panelconfiguracion.Width + BunifuImageButton1.Width + 12 + Panel4.Width;
            imgmostrarpanel.Top = panelusuarios.Top;
        }

        private void frm_adm_LocationChanged(object sender, EventArgs e)
        {
            My.MyProject.Forms.perfilalt.SetDesktopLocation(Location.X + Width - My.MyProject.Forms.perfilalt.Width, Location.Y + Panel1.Height + 20);
        }

        private void frm_adm_LostFocus(object sender, EventArgs e)
        {
            My.MyProject.Forms.perfilalt.TopMost = false;
        }

        private void OnChange(object sender, EventArgs e)
        {
            notificaciones.Text = "Tienes una notificación";
        }



        private void frm_adm_SizeChanged(object sender, EventArgs e)
        {
            // inicio.Height = Me.Height - Panel1.Height
            // inicio.Width = Me.Width - panelmenus.Width
            // inv.Height = Me.Height - Panel1.Height - 43
            // inv.Width = Me.Width - panelmenus.Width - 20
            // ventana.Height = Me.Height - Panel1.Height - 43
            // ventana.Width = Me.Width - panelmenus.Width - 20
            acomodar();
            imgperfil.Left = Panel1.Width - imgperfil.Width - 10;
            notificaciones.Left = Panel1.Width - imgperfil.Width - 10 - notificaciones.Width;
            My.MyProject.Forms.perfilalt.SetDesktopLocation(Location.X + Width - My.MyProject.Forms.perfilalt.Width, Location.Y + Panel1.Height + 20);
            if (BunifuImageButton1.Width + panelusuarios.Width + Panelconfiguracion.Width + Panel3.Width + Panel4.Width + notificaciones.Width + imgperfil.Width + 30 > Panel1.Width)
            {



                Panel4.Visible = false;
                // inicio.Panelsecundario.Visible = True
                imgmostrarpanel.Visible = true;
            }




            else
            {


                Panel4.Visible = true;
                My.MyProject.Forms.inicio.Panelsecundario.Visible = false;
                mostrarpanelsecundario = false;
                imgmostrarpanel.Visible = false;
                imgmostrarpanel.Image = My.Resources.Resources.mostrar1;
                imgmostrarpanel.BackColor = Color.FromArgb(51, 0, 204);


            }
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            BunifuFlatButton2.Textcolor = Color.White;

            foreach (DataRow row in Module1.dataPermisos.Rows)
            {
                if (Conversions.ToBoolean(row["SatiModCatalogos"]))
                {
                    foreach (Form frmForm in My.MyProject.Application.OpenForms)
                    {


                        if ((frmForm.Name ?? "") == (ventana.Name ?? ""))
                        {
                            frmForm.Close();
                            break;
                        }
                    }
                    ventana.Name = My.MyProject.Forms.inv.Name;

                    My.MyProject.Forms.inv.MdiParent = this;
                    My.MyProject.Forms.inv.Height = Height - Panel1.Height;
                    My.MyProject.Forms.inv.Width = Width - panelmenus.Width;


                    My.MyProject.Forms.inv.Top = 0;
                    My.MyProject.Forms.inv.Left = 0;
                    My.MyProject.Forms.inv.Show();
                    My.MyProject.Forms.inv.Top = 0;
                    My.MyProject.Forms.inv.Left = 0;
                    My.MyProject.Forms.inv.Height = Height - Panel1.Height - 43;
                    My.MyProject.Forms.inv.Width = Width - panelmenus.Width - 20;
                    // inv.Size = sizeventanas
                    My.MyProject.Forms.inv.Show();

                    if (My.MyProject.Forms.inv.Top > 0)
                    {
                        My.MyProject.Forms.inv.Top = 0;

                    }
                    My.MyProject.Forms.inv.Update();
                }
                else
                {

                }
            }

            BunifuFlatButton1.Textcolor = Color.Black;
            BunifuFlatButton3.Textcolor = Color.Black;
            BunifuFlatButton4.Textcolor = Color.Black;
            BunifuFlatButton8.Textcolor = Color.Black;
            BunifuFlatButton5.Textcolor = Color.Black;


        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            BunifuFlatButton1.Textcolor = Color.White;

            foreach (Form frmForm in My.MyProject.Application.OpenForms)
            {


                if ((frmForm.Name ?? "") == (ventana.Name ?? ""))
                {
                    frmForm.Close();
                    break;
                }
            }
            ventana.Name = My.MyProject.Forms.inicio.Name;
            My.MyProject.Forms.inicio.MdiParent = this;
            My.MyProject.Forms.inicio.Height = Height - Panel1.Height - 43;
            My.MyProject.Forms.inicio.Width = Width - panelmenus.Width - 20;


            My.MyProject.Forms.inicio.Top = 0;
            My.MyProject.Forms.inicio.Left = 0;
            My.MyProject.Forms.inicio.Show();
            My.MyProject.Forms.inicio.Top = 0;
            My.MyProject.Forms.inicio.Left = 0;
            // inicio.Height = Me.Height - Panel1.Height + 1
            // inicio.Width = Me.Width - panelmenus.Width + 1

            My.MyProject.Forms.inicio.Show();

            if (My.MyProject.Forms.inicio.Top > 0)
            {
                My.MyProject.Forms.inicio.Top = 0;

            }

            BunifuFlatButton2.Textcolor = Color.Black;
            BunifuFlatButton3.Textcolor = Color.Black;
            BunifuFlatButton4.Textcolor = Color.Black;
            BunifuFlatButton8.Textcolor = Color.Black;
            BunifuFlatButton5.Textcolor = Color.Black;
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            // If panelmenus.Width = 258 Then
            // antes era width 51

            // panelmenus.Width = 0
            // acomodar()
            // Else
            // panelmenus.Width = 258
            // acomodar()

            // End If
            if (widthmenubool == false)
            {
                BunifuImageButton1.BackColor = Color.FromArgb(0, 0, 153);
                Timerwidthmas.Enabled = true;
                Timerwidthmenos.Enabled = false;
            }
            else
            {
                BunifuImageButton1.BackColor = Color.FromArgb(51, 0, 204);
                Timerwidthmenos.Enabled = true;
                Timerwidthmas.Enabled = false;


            }
        }
        public void acomodar()
        {
            foreach (Form vent in My.MyProject.Application.OpenForms)
            {

                if ((vent.Name ?? "") == (ventana.Name ?? ""))
                {
                    // vent.Height = Me.Height - Panel1.Height
                    // vent.Width = Me.Width - panelmenus.Width
                    vent.Height = Height - Panel1.Height - 43;
                    vent.Width = Width - panelmenus.Width - 20;
                }

            }


        }



        private void imgperfil_Click(object sender, EventArgs e)
        {

            My.MyProject.Forms.perfilalt.SetDesktopLocation(Location.X + Width - My.MyProject.Forms.perfilalt.Width, Location.Y + Panel1.Height + 20);
            if (abierto == false)
            {
                My.MyProject.Forms.perfilalt.Show();
                Timer2.Start();

                My.MyProject.Forms.perfilalt.SetDesktopLocation(Location.X + Width - My.MyProject.Forms.perfilalt.Width, Location.Y + Panel1.Height + 20);
                abierto = true;
            }

            else
            {
                My.MyProject.Forms.perfilalt.TopMost = false;
                Timer2.Stop();

                My.MyProject.Forms.perfilalt.Close();
                abierto = false;


            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            Timer2.Interval = 1;
            Timer2.Start();
            if (!ReferenceEquals(this, ActiveForm))
            {
                My.MyProject.Forms.perfilalt.TopMost = false;
            }


            else
            {
                My.MyProject.Forms.perfilalt.TopMost = true;

            }
        }


        private void Timer3_Tick(object sender, EventArgs e)
        {
            // If panelmenus.Width = 258 Then
            // antes era width 51

            // panelmenus.Width = 0
            // acomodar()
            // End If

            // If panelmenus.Width < 258 Then
            // panelmenus.Width = 258
            // acomodar()

            // End If

            Timerwidthmenos.Interval = 1;
            sizeventanas = new Size(Width - panelmenus.Width - 20, Height - Panel1.Height - 43);
            panelmenus.Enabled = false;
            panelmenus.Width = widthmenu;
            if (panelmenus.Width > 0)
            {
                widthmenu = widthmenu - 10;
                My.MyProject.Forms.inicio.Panelsecundario.Left = panelusuarios.Width + Panelconfiguracion.Width - BunifuImageButton1.Width + 10;
            }

            else
            {
                widthmenubool = false;
                Timerwidthmenos.Stop();
                Timerwidthmenos.Enabled = false;
                panelmenus.Enabled = true;
                My.MyProject.Forms.inicio.Panelsecundario.Left = panelusuarios.Width + Panelconfiguracion.Width + BunifuImageButton1.Width + panelmenus.Width + 10;
                acomodar();
            }

        }

        private void Timerwidthmas_Tick(object sender, EventArgs e)
        {
            Timerwidthmas.Interval = 1;
            sizeventanas = new Size(Width - panelmenus.Width - 20, Height - Panel1.Height - 43);
            panelmenus.Enabled = false;

            panelmenus.Width = widthmenu;
            if (panelmenus.Width < 258)
            {
                widthmenu = widthmenu + 30;
                My.MyProject.Forms.inicio.Panelsecundario.Left = panelusuarios.Width + Panelconfiguracion.Width + BunifuImageButton1.Width - panelmenus.Width + 10;

                acomodar();
            }
            else
            {
                widthmenubool = true;
                Timerwidthmas.Stop();
                Timerwidthmas.Enabled = false;
                My.MyProject.Forms.inicio.Panelsecundario.Left = panelusuarios.Width + Panelconfiguracion.Width + BunifuImageButton1.Width - panelmenus.Width + 10;
                acomodar();
                panelmenus.Enabled = true;
            }
        }


        private void imgmostrarpanel_Click(object sender, EventArgs e)
        {
            if (mostrarpanelsecundario == false)
            {

                My.MyProject.Forms.inicio.Panelsecundario.Visible = true;
                imgmostrarpanel.Image = My.Resources.Resources.ocultar1;
                imgmostrarpanel.BackColor = Color.FromArgb(46, 139, 87);

                mostrarpanelsecundario = true;
            }
            else
            {
                My.MyProject.Forms.inicio.Panelsecundario.Visible = false;
                imgmostrarpanel.Image = My.Resources.Resources.mostrar1;
                imgmostrarpanel.BackColor = Color.FromArgb(51, 0, 204);
                mostrarpanelsecundario = false;

            }
        }



        private void btnusuarios_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in Module1.dataPermisos.Rows)
            {
                if (Conversions.ToBoolean(row["SatiModUsuarios"]))
                {
                    My.MyProject.Forms.usuarios.Show();
                }

                else
                {

                }
            }



        }

        private void BunifuFlatButton7_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in Module1.dataPermisos.Rows)
            {
                if (Conversions.ToBoolean(row["SatiModGrupos"]))
                {
                    My.MyProject.Forms.grupos.Show();
                }
                else
                {

                }
            }

        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            BunifuFlatButton3.Textcolor = Color.White;

            foreach (DataRow row in Module1.dataPermisos.Rows)
            {
                if (Conversions.ToBoolean(row["SatiModSolicitudes"]))
                {
                    My.MyProject.Forms.inicio.Close();
                    My.MyProject.Forms.inv.Close();

                    ventana.Name = My.MyProject.Forms.Solicitudes.Name;

                    My.MyProject.Forms.Solicitudes.MdiParent = this;
                    My.MyProject.Forms.Solicitudes.Height = Height - Panel1.Height;
                    My.MyProject.Forms.Solicitudes.Width = Width - panelmenus.Width;


                    My.MyProject.Forms.Solicitudes.Top = 0;
                    My.MyProject.Forms.Solicitudes.Left = 0;
                    My.MyProject.Forms.Solicitudes.Show();
                    My.MyProject.Forms.Solicitudes.Top = 0;
                    My.MyProject.Forms.Solicitudes.Left = 0;
                    My.MyProject.Forms.Solicitudes.Height = Height - Panel1.Height - 43;
                    My.MyProject.Forms.Solicitudes.Width = Width - panelmenus.Width - 20;
                    // inv.Size = sizeventanas
                    My.MyProject.Forms.Solicitudes.Show();

                    if (My.MyProject.Forms.Solicitudes.Top > 0)
                    {
                        My.MyProject.Forms.Solicitudes.Top = 0;

                    }
                    My.MyProject.Forms.Solicitudes.Update();
                }
                else
                {

                }
            }

            BunifuFlatButton1.Textcolor = Color.Black;
            BunifuFlatButton2.Textcolor = Color.Black;
            BunifuFlatButton4.Textcolor = Color.Black;
            BunifuFlatButton8.Textcolor = Color.Black;
            BunifuFlatButton5.Textcolor = Color.Black;
        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {
            BunifuFlatButton4.Textcolor = Color.White;

            foreach (Form frmForm in My.MyProject.Application.OpenForms)
            {


                if ((frmForm.Name ?? "") == (ventana.Name ?? ""))
                {
                    frmForm.Close();
                    break;
                }
            }

            ventana.Name = My.MyProject.Forms.CreditosPorEntregar.Name;

            My.MyProject.Forms.CreditosPorEntregar.MdiParent = this;
            My.MyProject.Forms.CreditosPorEntregar.Height = Height - Panel1.Height;
            My.MyProject.Forms.CreditosPorEntregar.Width = Width - panelmenus.Width;


            My.MyProject.Forms.CreditosPorEntregar.Top = 0;
            My.MyProject.Forms.CreditosPorEntregar.Left = 0;
            My.MyProject.Forms.CreditosPorEntregar.Show();
            My.MyProject.Forms.CreditosPorEntregar.Top = 0;
            My.MyProject.Forms.CreditosPorEntregar.Left = 0;
            My.MyProject.Forms.CreditosPorEntregar.Height = Height - Panel1.Height - 43;
            My.MyProject.Forms.CreditosPorEntregar.Width = Width - panelmenus.Width - 20;
            // inv.Size = sizeventanas
            My.MyProject.Forms.CreditosPorEntregar.Show();

            if (My.MyProject.Forms.CreditosPorEntregar.Top > 0)
            {
                My.MyProject.Forms.CreditosPorEntregar.Top = 0;

            }
            My.MyProject.Forms.CreditosPorEntregar.Update();
            BunifuFlatButton1.Textcolor = Color.Black;
            BunifuFlatButton2.Textcolor = Color.Black;
            BunifuFlatButton3.Textcolor = Color.Black;
            BunifuFlatButton8.Textcolor = Color.Black;
            BunifuFlatButton5.Textcolor = Color.Black;
        }

        private void BunifuFlatButton5_Click(object sender, EventArgs e)
        {
            BunifuFlatButton5.Textcolor = Color.White;
            try
            {
                My.MyProject.Forms.CierraEmpresa.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            BunifuFlatButton5.Textcolor = Color.Black;
            BunifuFlatButton1.Textcolor = Color.Black;
            BunifuFlatButton2.Textcolor = Color.Black;
            BunifuFlatButton3.Textcolor = Color.Black;
            BunifuFlatButton4.Textcolor = Color.Black;
            BunifuFlatButton8.Textcolor = Color.Black;
        }

        private void frm_adm_ImeModeChanged(object sender, EventArgs e)
        {

        }

        private void btnconfiguracion_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Configuraciones.Show();
        }

        private void btnconfiguracion_Click_1(object sender, EventArgs e)
        {
            My.MyProject.Forms.Configuraciones.Show();
        }

        private void BunifuFlatButton8_Click(object sender, EventArgs e)
        {
            BunifuFlatButton8.Textcolor = Color.White;
            foreach (DataRow row in Module1.dataPermisos.Rows)
            {
                if (Conversions.ToBoolean(row["SatiModReportes"]))
                {
                    foreach (Form frmForm in My.MyProject.Application.OpenForms)
                    {


                        if ((frmForm.Name ?? "") == (ventana.Name ?? ""))
                        {
                            frmForm.Close();
                            break;
                        }
                    }
                    ventana.Name = My.MyProject.Forms.Reportes.Name;
                    My.MyProject.Forms.Reportes.MdiParent = this;
                    My.MyProject.Forms.Reportes.Height = Height - Panel1.Height;
                    My.MyProject.Forms.Reportes.Width = Width - panelmenus.Width;


                    My.MyProject.Forms.Reportes.Top = 0;
                    My.MyProject.Forms.Reportes.Left = 0;
                    My.MyProject.Forms.Reportes.Show();
                    My.MyProject.Forms.Reportes.Top = 0;
                    My.MyProject.Forms.Reportes.Left = 0;
                    My.MyProject.Forms.Reportes.Height = Height - Panel1.Height - 43;
                    My.MyProject.Forms.Reportes.Width = Width - panelmenus.Width - 20;
                    // inv.Size = sizeventanas
                    My.MyProject.Forms.Reportes.Show();

                    if (My.MyProject.Forms.Reportes.Top > 0)
                    {
                        My.MyProject.Forms.Reportes.Top = 0;

                    }
                    My.MyProject.Forms.Reportes.Update();
                }
                else
                {

                }
            }

            BunifuFlatButton1.Textcolor = Color.Black;
            BunifuFlatButton2.Textcolor = Color.Black;
            BunifuFlatButton3.Textcolor = Color.Black;
            BunifuFlatButton4.Textcolor = Color.Black;
            BunifuFlatButton5.Textcolor = Color.Black;

        }

        private void TimerLiberar_Tick(object sender, EventArgs e)
        {
            Module1.FlushMemory();
        }

        private void BunifuFlatButton6_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Retiros.Show();
        }

        private void MonoFlat_Button1_Click(object sender, EventArgs e)
        {
            foreach (Form frmForm in My.MyProject.Application.OpenForms)
            {


                if ((frmForm.Name ?? "") == (ventana.Name ?? ""))
                {
                    frmForm.Close();
                    break;
                }
            }
            ventana.Name = My.MyProject.Forms.EmpeñosPorEntregar.Name;

            My.MyProject.Forms.EmpeñosPorEntregar.MdiParent = this;
            My.MyProject.Forms.EmpeñosPorEntregar.Height = Height - Panel1.Height;
            My.MyProject.Forms.EmpeñosPorEntregar.Width = Width - panelmenus.Width;


            My.MyProject.Forms.EmpeñosPorEntregar.Top = 0;
            My.MyProject.Forms.EmpeñosPorEntregar.Left = 0;
            My.MyProject.Forms.EmpeñosPorEntregar.Show();
            My.MyProject.Forms.EmpeñosPorEntregar.Top = 0;
            My.MyProject.Forms.EmpeñosPorEntregar.Left = 0;
            My.MyProject.Forms.EmpeñosPorEntregar.Height = Height - Panel1.Height - 43;
            My.MyProject.Forms.EmpeñosPorEntregar.Width = Width - panelmenus.Width - 20;
            // inv.Size = sizeventanas
            My.MyProject.Forms.EmpeñosPorEntregar.Show();

            if (My.MyProject.Forms.EmpeñosPorEntregar.Top > 0)
            {
                My.MyProject.Forms.EmpeñosPorEntregar.Top = 0;

            }
            My.MyProject.Forms.EmpeñosPorEntregar.Update();
            BunifuFlatButton1.Textcolor = Color.Black;
            BunifuFlatButton1.selected = false;
            BunifuFlatButton2.Textcolor = Color.Black;
            BunifuFlatButton2.selected = false;
            BunifuFlatButton3.Textcolor = Color.Black;
            BunifuFlatButton3.selected = false;
            BunifuFlatButton4.Textcolor = Color.Black;
            BunifuFlatButton4.selected = false;
            BunifuFlatButton8.Textcolor = Color.Black;
            BunifuFlatButton8.selected = false;
            BunifuFlatButton5.Textcolor = Color.Black;
        }

        private void MonoFlat_Button2_Click(object sender, EventArgs e)
        {
            foreach (Form frmForm in My.MyProject.Application.OpenForms)
            {


                if ((frmForm.Name ?? "") == (ventana.Name ?? ""))
                {
                    frmForm.Close();
                    break;
                }
            }

            ventana.Name = My.MyProject.Forms.SolicitudesEmpeños.Name;

            My.MyProject.Forms.SolicitudesEmpeños.MdiParent = this;
            My.MyProject.Forms.SolicitudesEmpeños.Height = Height - Panel1.Height;
            My.MyProject.Forms.SolicitudesEmpeños.Width = Width - panelmenus.Width;


            My.MyProject.Forms.SolicitudesEmpeños.Top = 0;
            My.MyProject.Forms.SolicitudesEmpeños.Left = 0;
            My.MyProject.Forms.SolicitudesEmpeños.Show();
            My.MyProject.Forms.SolicitudesEmpeños.Top = 0;
            My.MyProject.Forms.SolicitudesEmpeños.Left = 0;
            My.MyProject.Forms.SolicitudesEmpeños.Height = Height - Panel1.Height - 43;
            My.MyProject.Forms.SolicitudesEmpeños.Width = Width - panelmenus.Width - 20;
            // inv.Size = sizeventanas
            My.MyProject.Forms.SolicitudesEmpeños.Show();

            if (My.MyProject.Forms.SolicitudesEmpeños.Top > 0)
            {
                My.MyProject.Forms.SolicitudesEmpeños.Top = 0;

            }
            My.MyProject.Forms.SolicitudesEmpeños.Update();
            BunifuFlatButton1.Textcolor = Color.Black;
            BunifuFlatButton1.selected = false;
            BunifuFlatButton2.Textcolor = Color.Black;
            BunifuFlatButton2.selected = false;
            BunifuFlatButton3.Textcolor = Color.Black;
            BunifuFlatButton3.selected = false;
            BunifuFlatButton4.Textcolor = Color.Black;
            BunifuFlatButton4.selected = false;
            BunifuFlatButton8.Textcolor = Color.Black;
            BunifuFlatButton8.selected = false;
            BunifuFlatButton5.Textcolor = Color.Black;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Application.ProductVersion);
        }

        private void BackgroundActualizacion_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                conexionsql = new MySqlConnection();
                conexionsql.ConnectionString = "server=www.prestamosconfia.com;user id=SATIVersiones;pwd=123456;port=3306;database=Versiones";
                conexionsql.Open();

                MySqlCommand mysqlcomando;
                string consulta;

                consulta = "select Nversion from Versiones where Sistema = 'SATI'";
                mysqlcomando = new MySqlCommand();
                mysqlcomando.Connection = conexionsql;
                mysqlcomando.CommandText = consulta;
                string versionAct;
                versionAct = Conversions.ToString(mysqlcomando.ExecuteScalar());


                conexionsql.Close();

                if ((Application.ProductVersion ?? "") != (versionAct ?? ""))
                {
                    hayActualizacion = true;


                }
            }
            catch (Exception ex)
            {
                hayActualizacion = false;

            }


        }

        private void BackgroundActualizacion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (hayActualizacion)
            {
                btn_Actualizar.Visible = true;

            }

        }

        private void TimerActualizacion_Tick(object sender, EventArgs e)
        {
            if (BackgroundActualizacion.IsBusy == true)
            {
            }
            else
            {
                BackgroundActualizacion.RunWorkerAsync();
            }


        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea aplicar la actualización?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                actualizar = true;

                var Proceso = new Process();
                string ruta = @"C:\ConfiaAdmin\Updater\Updater.exe";
                Proceso.StartInfo.FileName = ruta;
                Proceso.StartInfo.Arguments = "/S SATI /T " + Module1.TipoEquipo;
                Proceso.Start();
                Application.Exit();
            }
            else
            {
                actualizar = false;

            }

        }



        private void BackgroundNotificaciones_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {



                MySqlConnection conexionNotificaciones;
                conexionNotificaciones = new MySqlConnection();
                conexionNotificaciones.ConnectionString = "server=www.prestamosconfia.com;user id=SatiNotificacion;pwd=123456;port=3306;database=USRS";
                conexionNotificaciones.Open();

                // Revisar notificaciones no aplicadas

                for (int a = array.Count - 1; a >= 0; a -= 1)
                {
                    Notificaciones r = (Notificaciones)array[a];
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(r.Estado, "", false)))
                    {
                        MySqlCommand mysqlcomandoexiste;
                        string consultaExiste;
                        bool aplicado;

                        consultaExiste = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select Aplicado from Notificaciones where id = '", r.id), "'"));
                        mysqlcomandoexiste = new MySqlCommand();
                        mysqlcomandoexiste.Connection = conexionNotificaciones;
                        mysqlcomandoexiste.CommandText = consultaExiste;
                        aplicado = Conversions.ToBoolean(mysqlcomandoexiste.ExecuteScalar());
                        if (aplicado)
                        {
                            array.RemoveAt(a);

                        }

                    }
                }


                // Revisar notificaciones aplicadas

                for (int a = array.Count - 1; a >= 0; a -= 1)
                {
                    Notificaciones r = (Notificaciones)array[a];
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(r.Estado, "", false)))
                    {
                        MySqlCommand mysqlcomandoexiste;
                        string consultaExiste;
                        bool Visto;

                        consultaExiste = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select Visto from Notificaciones where id = '", r.id), "'"));
                        mysqlcomandoexiste = new MySqlCommand();
                        mysqlcomandoexiste.Connection = conexionNotificaciones;
                        mysqlcomandoexiste.CommandText = consultaExiste;
                        Visto = Conversions.ToBoolean(mysqlcomandoexiste.ExecuteScalar());
                        if (Visto)
                        {
                            array.RemoveAt(a);

                        }

                    }
                }





                MySqlCommand mysqlcomando;
                string consulta;
                MySqlDataReader readerNotificacion;

                consulta = "select * from Notificaciones where UsuarioDestino = '" + Module1.nmusr + "' and Aplicado = 0 and idSesion='" + Module1.idSesion + "'";
                mysqlcomando = new MySqlCommand();
                mysqlcomando.Connection = conexionNotificaciones;
                mysqlcomando.CommandText = consulta;
                readerNotificacion = mysqlcomando.ExecuteReader();
                bool existe =false;
                while (readerNotificacion.Read())
                {
                    var Nnotificacion = new Notificaciones();
                    Nnotificacion.id = Conversions.ToInteger(readerNotificacion["id"]);
                    Nnotificacion.Tipo = Conversions.ToString(readerNotificacion["tipo"]);
                    Nnotificacion.Usuario = Conversions.ToString(readerNotificacion["Usuario"]);
                    Nnotificacion.UsuarioDestino = Conversions.ToString(readerNotificacion["usuariodestino"]);
                    Nnotificacion.Notificacion = Conversions.ToBoolean(readerNotificacion["notificacion"]);
                    Nnotificacion.Mensaje = Conversions.ToString(readerNotificacion["Mensaje"]);
                    Nnotificacion.Fecha = Conversions.ToString(readerNotificacion["Fecha"]);
                    Nnotificacion.Hora = readerNotificacion["Hora"].ToString();
                    Nnotificacion.Empresa = Conversions.ToString(readerNotificacion["Empresa"]);
                    for (int a = array.Count - 1; a >= 0; a -= 1)
                    {
                        Notificaciones r = (Notificaciones)array[a];
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(r.id, Nnotificacion.id, false)))
                        {
                            existe = true;
                            // MessageBox.Show("existe")
                            break;
                        }
                        else
                        {
                            // MessageBox.Show("No existe")
                            existe = false;

                        }

                    }
                    if (existe == false)
                    {
                        // media.Play() ' Async, creates a new thread
                        array.Add(Nnotificacion);
                    }

                }
                readerNotificacion.Close();








                MySqlCommand mysqlcomandoConNotificacion;
                string consultaConNotificacion;
                MySqlDataReader readerConNotificacion;

                consultaConNotificacion = "select * from Notificaciones where UsuarioDestino = '" + Module1.nmusr + "' and Notificacion = 1 and Aplicado = 0 ";
                mysqlcomandoConNotificacion = new MySqlCommand();
                mysqlcomandoConNotificacion.Connection = conexionNotificaciones;
                mysqlcomandoConNotificacion.CommandText = consultaConNotificacion;
                readerConNotificacion = mysqlcomandoConNotificacion.ExecuteReader();
                bool existeConNotificacion =false;
                while (readerConNotificacion.Read())
                {
                    var Nnotificacion = new Notificaciones();
                    Nnotificacion.id = Conversions.ToInteger(readerConNotificacion["id"]);
                    Nnotificacion.Tipo = Conversions.ToString(readerConNotificacion["tipo"]);
                    Nnotificacion.Usuario = Conversions.ToString(readerConNotificacion["Usuario"]);
                    Nnotificacion.UsuarioDestino = Conversions.ToString(readerConNotificacion["usuariodestino"]);
                    Nnotificacion.Notificacion = Conversions.ToBoolean(readerConNotificacion["notificacion"]);
                    Nnotificacion.Mensaje = Conversions.ToString(readerConNotificacion["Mensaje"]);
                    Nnotificacion.Fecha = Conversions.ToString(readerConNotificacion["Fecha"]);
                    Nnotificacion.Hora = readerConNotificacion["Hora"].ToString();
                    Nnotificacion.Valor = Conversions.ToString(readerConNotificacion["valor"]);
                    Nnotificacion.Estado = Conversions.ToString(readerConNotificacion["Estado"]);
                    Nnotificacion.Empresa = Conversions.ToString(readerConNotificacion["Empresa"]);
                    for (int a = array.Count - 1; a >= 0; a -= 1)
                    {
                        Notificaciones r = (Notificaciones)array[a];

                        if (Conversions.ToBoolean(Operators.AndObject(Operators.ConditionalCompareObjectEqual(r.id, Nnotificacion.id, false), Operators.ConditionalCompareObjectEqual(r.Estado, Nnotificacion.Estado, false))))
                        {
                            existeConNotificacion = true;

                            break;
                        }
                        else
                        {

                            existeConNotificacion = false;

                        }

                    }
                    if (existeConNotificacion == false)
                    {
                        CantNotificaciones += 1;
                        // media.Play() ' Async, creates a new thread
                        array.Add(Nnotificacion);
                    }

                }
                readerConNotificacion.Close();


                MySqlCommand mysqlcomandoConNotificacionAplicado;
                string consultaConNotificacionAplicado;
                MySqlDataReader readerConNotificacionAplicado;

                consultaConNotificacionAplicado = "select * from Notificaciones where Usuario = '" + Module1.nmusr + "' and Notificacion = 1 and Aplicado = 1 and Visto = 0";
                mysqlcomandoConNotificacionAplicado = new MySqlCommand();
                mysqlcomandoConNotificacionAplicado.Connection = conexionNotificaciones;
                mysqlcomandoConNotificacionAplicado.CommandText = consultaConNotificacionAplicado;
                readerConNotificacionAplicado = mysqlcomandoConNotificacionAplicado.ExecuteReader();
                bool existeConNotificacionAplicado =false;
                while (readerConNotificacionAplicado.Read())
                {
                    var Nnotificacion = new Notificaciones();
                    Nnotificacion.id = Conversions.ToInteger(readerConNotificacionAplicado["id"]);
                    Nnotificacion.Tipo = Conversions.ToString(readerConNotificacionAplicado["tipo"]);
                    Nnotificacion.Usuario = Conversions.ToString(readerConNotificacionAplicado["Usuario"]);
                    Nnotificacion.UsuarioDestino = Conversions.ToString(readerConNotificacionAplicado["usuariodestino"]);
                    Nnotificacion.Notificacion = Conversions.ToBoolean(readerConNotificacionAplicado["notificacion"]);
                    Nnotificacion.Mensaje = Conversions.ToString(readerConNotificacionAplicado["Mensaje"]);
                    Nnotificacion.FechaAplicacion = Conversions.ToString(readerConNotificacionAplicado["FechaAplicacion"]);
                    Nnotificacion.HoraAplicacion = readerConNotificacionAplicado["HoraAplicacion"].ToString();
                    Nnotificacion.Valor = Conversions.ToString(readerConNotificacionAplicado["valor"]);
                    Nnotificacion.Estado = Conversions.ToString(readerConNotificacionAplicado["Estado"]);
                    Nnotificacion.ComentarioUsuarioDestino = Conversions.ToString(readerConNotificacionAplicado["ComentarioUsuarioDestino"]);
                    Nnotificacion.Empresa = Conversions.ToString(readerConNotificacionAplicado["Empresa"]);
                    for (int a = array.Count - 1; a >= 0; a -= 1)
                    {
                        Notificaciones r = (Notificaciones)array[a];
                        if (Conversions.ToBoolean(Operators.AndObject(Operators.ConditionalCompareObjectEqual(r.id, Nnotificacion.id, false), Operators.ConditionalCompareObjectEqual(r.Estado, Nnotificacion.Estado, false))))
                        {

                            existeConNotificacionAplicado = true;

                            break;
                        }
                        else
                        {

                            existeConNotificacionAplicado = false;

                        }

                    }
                    if (existeConNotificacionAplicado == false)
                    {
                        CantNotificaciones += 1;
                        // media.Play() ' Async, creates a new thread
                        array.Add(Nnotificacion);
                    }

                }
                readerConNotificacionAplicado.Close();




                Invoke(new Action(() =>
                    {
                        notificaciones.Text = "Tienes " + array.Count + " notificaciones";
                        notificaciones.Refresh();

                    }));

                // conexionNotificaciones.Close()

                for (int a = array.Count - 1; a >= 0; a -= 1)
                {
                    Notificaciones r = (Notificaciones)array[a];

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(r.Notificacion, "0", false)))
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(r.Tipo, "Logout", false)))
                        {
                            MySqlCommand comandoActNotificacion;
                            string consultaActNotificacion;
                            comandoActNotificacion = new MySqlCommand();
                            consultaActNotificacion = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("update Notificaciones set Aplicado = 1 where id = '", r.id), "'"));
                            comandoActNotificacion.Connection = conexionNotificaciones;
                            comandoActNotificacion.CommandText = consultaActNotificacion;
                            comandoActNotificacion.ExecuteNonQuery();
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(r.Mensaje, "", false)))
                            {

                                Invoke(new Action(() =>
                                    {
                                        var nAlertas = new Alertas();
                                        nAlertas.cadena = Conversions.ToString(r.Mensaje);
                                        nAlertas.ShowDialog();
                                        nAlertas.TopMost = true;
                                    }));
                            }
                            actualizar = true;
                            int num_controles = Application.OpenForms.Count - 1;
                            for (int n = num_controles; n >= 0; n -= 1)
                            {
                                var ctrl = Application.OpenForms[n];
                                if (ctrl.Name != "login" & (ctrl.Name ?? "") != (Name ?? ""))
                                {
                                    ctrl.Close();
                                }

                                // ctrl.Dispose()
                            }
                            Invoke(new Action(() => My.MyProject.Forms.login.Show()));


                            Close();
                        }
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(r.Tipo, "Message", false)))
                        {
                            MySqlCommand comandoActNotificacion;
                            string consultaActNotificacion;
                            comandoActNotificacion = new MySqlCommand();
                            consultaActNotificacion = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("update Notificaciones set Aplicado = 1 where id = '", r.id), "'"));
                            comandoActNotificacion.Connection = conexionNotificaciones;
                            comandoActNotificacion.CommandText = consultaActNotificacion;
                            comandoActNotificacion.ExecuteNonQuery();

                            Invoke(new Action(() =>
                                {
                                    var nAlertas = new Alertas();


                                    nAlertas.cadena = Conversions.ToString(r.Mensaje);
                                    array.RemoveAt(a);
                                    nAlertas.ShowDialog();
                                    nAlertas.TopMost = true;

                                }));
                            if (array.Count == 0)
                            {
                                break;
                            }
                        }
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(r.Tipo, "CargarPermisos", false)))
                        {
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(r.Mensaje, "", false)))
                            {

                                Invoke(new Action(() =>
                                    {
                                        var nAlertas = new Alertas();
                                        nAlertas.cadena = Conversions.ToString(r.Mensaje);
                                        nAlertas.ShowDialog();
                                        nAlertas.TopMost = true;
                                    }));
                            }
                            Module1.cargarperfil();
                            MySqlCommand comandoActNotificacion;
                            string consultaActNotificacion;
                            comandoActNotificacion = new MySqlCommand();
                            consultaActNotificacion = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("update Notificaciones set Aplicado = 1 where id = '", r.id), "'"));
                            comandoActNotificacion.Connection = conexionNotificaciones;
                            comandoActNotificacion.CommandText = consultaActNotificacion;
                            comandoActNotificacion.ExecuteNonQuery();
                            array.RemoveAt(a);
                            if (array.Count == 0)
                            {
                                break;
                            }
                        }
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(r.Tipo, "Update", false)))
                        {
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(r.Mensaje, "", false)))
                            {

                                Invoke(new Action(() =>
                                    {
                                        var nAlertas = new Alertas();
                                        nAlertas.cadena = Conversions.ToString(r.Mensaje);
                                        nAlertas.ShowDialog();
                                        nAlertas.TopMost = true;
                                    }));
                            }

                            MySqlCommand comandoActNotificacion;
                            string consultaActNotificacion;
                            comandoActNotificacion = new MySqlCommand();
                            consultaActNotificacion = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("update Notificaciones set Aplicado = 1 where id = '",r.id), "'"));
                            comandoActNotificacion.Connection = conexionNotificaciones;
                            comandoActNotificacion.CommandText = consultaActNotificacion;
                            comandoActNotificacion.ExecuteNonQuery();
                            actualizar = true;

                            string ruta = @"C:\ConfiaAdmin\Updater\Updater.exe";
                            var Proceso = new Process();
                            Proceso.StartInfo.FileName = ruta;
                            Proceso.StartInfo.Arguments = "/S SATI /T " + Module1.TipoEquipo;
                            Proceso.Start();

                            Application.Exit();
                        }
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(r.Tipo, "UpdateUpdater", false)))
                        {
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(r.Mensaje, "", false)))
                            {

                                var nAlertas = new Alertas();
                                nAlertas.cadena = Conversions.ToString(r.Mensaje);
                                nAlertas.ShowDialog();
                                nAlertas.TopMost = true;
                            }

                            MySqlCommand comandoActNotificacion;
                            string consultaActNotificacion;
                            comandoActNotificacion = new MySqlCommand();
                            consultaActNotificacion = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("update Notificaciones set Aplicado = 1 where id = '", r.id), "'"));
                            comandoActNotificacion.Connection = conexionNotificaciones;
                            comandoActNotificacion.CommandText = consultaActNotificacion;
                            comandoActNotificacion.ExecuteNonQuery();
                            Invoke(new Action(() => My.MyProject.Forms.ActualizadorUpdater.Show()));

                            array.RemoveAt(a);
                            if (array.Count == 0)
                            {
                                break;
                            }
                        }
                    }



                }
                conexionNotificaciones.Close();
            }


            catch (Exception ex)
            {

            }
        }


        public void VerificaNotificaciones()
        {
            for (int a = array.Count - 1; a >= 0; a -= 1)
            {

            }
        }


        private void TimerNotificaciones_Tick(object sender, EventArgs e)
        {
            if (BackgroundNotificaciones.IsBusy == true)
            {
            }
            else
            {
                BackgroundNotificaciones.RunWorkerAsync();
            }


        }

        private void BackgroundActSesion_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                MySqlConnection conexionSesion;
                conexionSesion = new MySqlConnection();
                conexionSesion.ConnectionString = "server=www.prestamosconfia.com;user id=confia1;pwd=123456;port=3306;database=USRS";
                conexionSesion.Open();

                MySqlCommand mysqlcomando;
                string consulta;
                bool sesionActiva;

                consulta = "select Activo from Sesiones where Usuario = '" + Module1.nmusr + "' and id='" + Module1.idSesion + "'";
                mysqlcomando = new MySqlCommand();
                mysqlcomando.Connection = conexionSesion;
                mysqlcomando.CommandText = consulta;
                sesionActiva = Conversions.ToBoolean(mysqlcomando.ExecuteScalar());

                if (sesionActiva)
                {
                    MySqlCommand comandoActSesion;
                    string consultaActSesion;
                    consultaActSesion = "update Sesiones set UltimoAcceso = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where id = '" + Module1.idSesion + "'";
                    comandoActSesion = new MySqlCommand();
                    comandoActSesion.Connection = conexionSesion;
                    comandoActSesion.CommandText = consultaActSesion;
                    comandoActSesion.ExecuteNonQuery();
                    conexionSesion.Close();
                }
                else
                {
                    // quitar comentarios
                    Invoke(new Action(() =>
                        {

                            var nAlertas = new Alertas();
                            nAlertas.cadena = "Han pasado más de 5 minutos sin conexión, la sesión se cerrará";

                            nAlertas.ShowDialog();
                            nAlertas.TopMost = true;
                        }));

                    actualizar = true;

                    My.MyProject.Forms.login.Show();
                    int num_controles = Application.OpenForms.Count - 1;
                    for (int n = num_controles; n >= 0; n -= 1)
                    {
                        var ctrl = Application.OpenForms[n];
                        if (ctrl.Name != "login" & (ctrl.Name ?? "") != (Name ?? ""))
                        {
                            ctrl.Close();
                        }

                        ctrl.Dispose();
                    }
                    Invoke(new Action(() => My.MyProject.Forms.login.Show()));
                    Close();


                }
            }

            catch (Exception ex)
            {

            }


        }

        private void TimerActSesion_Tick(object sender, EventArgs e)
        {
            if (BackgroundActSesion.IsBusy)
            {
            }
            else
            {
                BackgroundActSesion.RunWorkerAsync();

            }
        }

        private void frm_adm_Disposed(object sender, EventArgs e)
        {

        }

        private void notificaciones_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.CentroDeNotificaciones.Show();

        }

        private void BunifuFlatButton9_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.CierresSinRecibir.Show();
        }

        private void backgroundDolar_DoWork(object sender, DoWorkEventArgs e)
        {try
            {
                var web = new HtmlWeb();
                var doc = new HtmlAgilityPack.HtmlDocument();
                doc = web.Load("https://www.eldolar.info/es-MX/mexico/dia/hoy");
                var dolar1 = doc.DocumentNode.SelectSingleNode("/html/body/div/main/div[1]/div[1]/p[1]/span").InnerText;
                dolar = dolar1;
                
            }
            catch (Exception ex)
            {
             
            }

           

        }
      

        private void backgroundDolar_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            StripStatusLabelDolar.Text = string.Format("{0:C}", dolar);
        }

        private void timerDolar_Tick(object sender, EventArgs e)
        {
            if (backgroundDolar.IsBusy == true)
            {
            }
            else
            {
                backgroundDolar.RunWorkerAsync();
            }

        }

        private void backgroundEuro_DoWork(object sender, DoWorkEventArgs e)
        {
           try
            {
                var web = new HtmlWeb();
                var doc = new HtmlAgilityPack.HtmlDocument();
                doc = web.Load("https://www.infodolar.com.mx/tipo-de-cambio-euro-estado-distrito-federal.aspx");
                var euro1 = doc.DocumentNode.SelectSingleNode("//*[@id='Promedio']/tr/td[2]");
                euro = euro1.GetAttributeValue("data-order", "");
            }
            catch (Exception ex)
            {

            }
               
         
            //var euro1 = doc.DocumentNode.SelectSingleNode("//*[@id="Promedio"]/tbody/tr/td[2]");

            //euro = euro1.GetAttributeValue("data-order", "");
            //MessageBox.Show(euro1.GetAttributeValue("data-order", ""));
            //   euro = euro1.Attributes.AttributesWithName("data-order").ToString();


        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            if (backgroundEuro.IsBusy == true)
            {
            }
            else
            {
                backgroundEuro.RunWorkerAsync();
            }


        }

        private void backgroundEuro_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            StripStatusLabelEuro.Text = string.Format("{0:C}", euro);
        }
    }
}