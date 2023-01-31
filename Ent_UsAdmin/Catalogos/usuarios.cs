using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class usuarios
    {
        private int vertscroll = SystemInformation.VerticalScrollBarWidth;
        private PictureBox picturecargando;
        private int nombrepicture = 0;
        private string[] nombre = new string[1001];
        private string[] idgrp = new string[1001];
        private string busqueda;
        private int ypicturebox = 0;
        private bool agregarpicturetimer = false;
        private Bunifu.Framework.UI.BunifuImageButton pictureboxusuario;
        private Label labelusuario;
        private int cantidadusuarios;
        private int numero = 0;
        private string[] imgpanel = new string[1001];
        private string[] idusrpanel = new string[1001];
        private string[] nombrecompleto = new string[1001];
        private Label labelcargando;

        public usuarios()
        {
            InitializeComponent();
        }
        [DllImport("user32")]
        private static extern int LockWindowUpdate(IntPtr hwndLock);
        [DllImport("user32")]
        private static extern int ShowScrollBar(IntPtr hwnd, int wBar, int bShow);

        private const int SB_VERT = 1;

        private void usuarios_Load(object sender, EventArgs e)
        {
            var mensajesayuda = new ToolTip();
            mensajesayuda.AutoPopDelay = 5000;
            mensajesayuda.InitialDelay = 500;
            mensajesayuda.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            mensajesayuda.ShowAlways = true;
            mensajesayuda.SetToolTip(BunifuMaterialTextbox1, "Presiona F5 para iniciar la búsqueda");
           // Module1.InitializeBackgroundWorker();

            CheckForIllegalCrossThreadCalls = false;

            BunifuMaterialTextbox1.Location = new Point(BunifuMaterialTextbox1.Location.X, Combofiltro.Location.Y);
            Combofiltro.Items.Add("Todos");
            Combofiltro.Items.Add("Grupo");
            Combofiltro.Items.Add("Con Nombre");
            Combofiltro.Items.Add("Con Usuario");
            Combogrupo.Visible = false;
            Combogrupo.Location = new Point(BunifuMaterialTextbox1.Location.X, Combofiltro.Location.Y);
            Combogrupo.Size = BunifuMaterialTextbox1.Size;
            Module1.iniciarconexionR();
            Combofiltro.SelectedIndex = 0;

            // cargarusuarios()
            FlowLayoutPanel1.Padding = new Padding(0, 0, vertscroll, 0);
            ShowScrollBar(FlowLayoutPanel1.Handle, SB_VERT, Conversions.ToInteger(false));

        }






        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left & WindowState != FormWindowState.Maximized)
            {
                Module_resize.MoveForm(this);
            }
        }

        private void BunifuMaterialTextbox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F5)
            {
                if (busqueda == "nombre")
                {
                    Module1.strusuarios = "select idusr,nm_complete,imgstr from usr where nm_complete like '%" + BunifuMaterialTextbox1.Text + "%'";
                }
                else
                {
                    Module1.strusuarios = "select idusr,nm_complete,imgstr from usr where nm like '%" + BunifuMaterialTextbox1.Text + "%'";
                }
                Combogrupo.Visible = false;

                panelcargando.Size = FlowLayoutPanel1.Size;
                panelcargando.Location = FlowLayoutPanel1.Location;
                FlowLayoutPanel1.Visible = false;
                panelcargando.Visible = true;
                timercargando.Enabled = true;
                BackgroundWorker1.RunWorkerAsync();
            }
        }












        private void Combofiltro_SelectedIndexChanged(object sender, EventArgs e)
        {


            switch (Combofiltro.Text ?? "")
            {
                case "Todos":
                    {

                        Combogrupo.Visible = false;
                        BunifuMaterialTextbox1.Visible = false;
                        panelcargando.Size = FlowLayoutPanel1.Size;
                        panelcargando.Location = FlowLayoutPanel1.Location;
                        FlowLayoutPanel1.Visible = false;
                        panelcargando.Visible = true;
                        timercargando.Enabled = true;

                        Module1.strusuarios = "select idusr,nm_complete,imgstr from usr";

                        BackgroundWorker1.RunWorkerAsync();
                        break;
                    }


                case "Grupo":
                    {

                        Combogrupo.Visible = true;
                        BunifuMaterialTextbox1.Visible = false;
                        Combogrupo.Items.Clear();
                        cargargrupos();
                        break;
                    }
                case "Con Nombre":
                    {
                        Combogrupo.Visible = false;
                        busqueda = "nombre";
                        BunifuMaterialTextbox1.Visible = true;
                        break;
                    }



                case "Con Usuario":
                    {
                        Combogrupo.Visible = false;
                        busqueda = "usuario";
                        BunifuMaterialTextbox1.Visible = true;
                        break;
                    }


            }
        }

        public void cargargrupos()
        {
            try
            {
                string strgrupos;
                strgrupos = "select id,nm,cdg from grp";
                var ejec = new OleDbCommand(strgrupos);
                ejec.Connection = Module1.conexionempresaR;
                string codigo;

                int numero = 0;

                var myreadergrupos = ejec.ExecuteReader();
                while (myreadergrupos.Read())
                {


                    codigo = Conversions.ToString(myreadergrupos["cdg"]);
                    Combogrupo.Items.Add(codigo);
                    nombre[numero] = Conversions.ToString(myreadergrupos["nm"]);
                    idgrp[numero] = Conversions.ToString(myreadergrupos["id"]);
                    numero += 1;
                }
                myreadergrupos.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Combogrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Module1.strusuarios = "select idusr,nm_complete,imgstr from usr where grp = '" + idgrp[Combogrupo.SelectedIndex] + "'";
            My.MyProject.Forms.nombregrupo.MonoFlat_HeaderLabel1.Text = nombre[Combogrupo.SelectedIndex];
            My.MyProject.Forms.nombregrupo.Show();

            BunifuMaterialTextbox1.Visible = false;
            panelcargando.Size = FlowLayoutPanel1.Size;
            panelcargando.Location = FlowLayoutPanel1.Location;
            FlowLayoutPanel1.Visible = false;
            panelcargando.Visible = true;
            timercargando.Enabled = true;
            BackgroundWorker1.RunWorkerAsync();

        }





        private void timercargando_Tick(object sender, EventArgs e)
        {
            timercargando.Interval = 100;
            if (agregarpicturetimer == false)
            {
                if (nombrepicture < 6)
                {
                    picturecargando = new PictureBox();
                    picturecargando.Image = My.Resources.Resources.lconfia;
                    picturecargando.Size = new Size(100, 200);
                    picturecargando.Name = nombrepicture.ToString();
                    picturecargando.BackColor = Color.FromArgb(223, 223, 223);
                    picturecargando.SizeMode = PictureBoxSizeMode.StretchImage;
                    picturecargando.BorderStyle = BorderStyle.FixedSingle;
                    picturecargando.Location = new Point(ypicturebox, 0);
                    panelcargando.Controls.Add(picturecargando);
                    labelcargando = new Label();
                    labelcargando.Text = "Cargando...";

                    labelcargando.AutoSize = false;
                    labelcargando.Size = new Size(100, 50);
                    labelcargando.BackColor = Color.FromArgb(18, 18, 18);
                    labelcargando.ForeColor = Color.FromArgb(223, 223, 223);
                    labelcargando.Location = new Point(0, picturecargando.Height - labelcargando.Height);
                    picturecargando.Controls.Add(labelcargando);
                    ypicturebox = ypicturebox + 100;
                    nombrepicture += 1;
                }
                else
                {
                    agregarpicturetimer = true;
                }
            }

            else if (nombrepicture > 0)
            {
                var ctrl = panelcargando.Controls[nombrepicture - 1];
                panelcargando.Controls.Remove(ctrl);
                ctrl.Dispose();
                nombrepicture -= 1;
            }
            else
            {
                agregarpicturetimer = false;

                ypicturebox = 0;


            }

        }

        private void BackgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {


            // strusuarios = "select idusr,nm_complete,imgstr from usr"




            // Me.Invoke(New Action(AddressOf cargarusuarios))
            // Await Task.Factory.StartNew(Sub()
            // Me.Invoke(New Action(AddressOf cargarusuarios))
            // End Sub)


            var ejec2 = new OleDbCommand(Module1.strusuarios);
            ejec2.Connection = Module1.conexionempresaR;
            var myreaderusuarios = ejec2.ExecuteReader();
            while (myreaderusuarios.Read())
            {
                imgpanel[numero] = Convert.ToString(myreaderusuarios["imgstr"]);
                idusrpanel[numero] = Convert.ToString(myreaderusuarios["idusr"]);
                nombrecompleto[numero] = Convert.ToString(myreaderusuarios["nm_complete"]);
                numero += 1;

            }
            cantidadusuarios = numero;

        }


        private void BackgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {

            int num_controles = FlowLayoutPanel1.Controls.Count - 1;
            for (int n = num_controles; n >= 0; n -= 1)
            {
                var ctrl = FlowLayoutPanel1.Controls[n];
                FlowLayoutPanel1.Controls.Remove(ctrl);
                ctrl.Dispose();
            }
            Backgroundusuarios.RunWorkerAsync();

        }


        private void Button1_Click(object sender, EventArgs e)
        {
            // FlowLayoutPanel1.Visible = False
            // panelcargando.Visible = True
            // timercargando.Enabled = True

        }

        private void Backgroundusuarios_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

            byte[] bytespanel;
            MemoryStream streamimgpanel;
            Bitmap bitmapimgpanel;
            Bunifu.Framework.UI.BunifuImageButton botonusuario;
            Label labelnombre;
            try
            {
                for (int numero1 = 0, loopTo = cantidadusuarios - 1; numero1 <= loopTo; numero1++)
                {
                    if (!string.IsNullOrEmpty(imgpanel[numero1]))
                    {
                        bytespanel = Convert.FromBase64String(imgpanel[numero1]);
                        streamimgpanel = new MemoryStream(bytespanel, 0, bytespanel.Length);
                        streamimgpanel.Write(bytespanel, 0, bytespanel.Length);
                        bitmapimgpanel = new Bitmap(streamimgpanel);

                        botonusuario = new Bunifu.Framework.UI.BunifuImageButton();
                        botonusuario.Image = bitmapimgpanel;
                        botonusuario.Size = new Size(100, 200);
                        botonusuario.Name = idusrpanel[numero1];
                        botonusuario.BackColor = Color.FromArgb(223, 223, 223);
                        botonusuario.SizeMode = PictureBoxSizeMode.StretchImage;
                        botonusuario.MouseDown += mousedownevent;
                        botonusuario.MouseMove += MouseMoveevent;
                        botonusuario.MouseUp += mouseupevent;
                        botonusuario.Click += clickevent;
                        FlowLayoutPanel1.PerformLayout();
                        Invoke(new Action(() => FlowLayoutPanel1.Controls.Add(botonusuario)));
                        labelnombre = new Label();
                        labelnombre.Text = nombrecompleto[numero1];

                        labelnombre.AutoSize = false;
                        labelnombre.Size = new Size(100, 50);
                        labelnombre.BackColor = Color.FromArgb(18, 18, 18);
                        labelnombre.ForeColor = Color.FromArgb(223, 223, 223);
                        labelnombre.Location = new Point(0, botonusuario.Height - labelnombre.Height);
                        Invoke(new Action(() => botonusuario.Controls.Add(labelnombre)));
                    }

                    else
                    {


                        botonusuario = new Bunifu.Framework.UI.BunifuImageButton();
                        botonusuario.Image = My.Resources.Resources.usuario;
                        botonusuario.Size = new Size(100, 200);
                        botonusuario.Name = idusrpanel[numero1];
                        botonusuario.BackColor = Color.FromArgb(223, 223, 223);
                        botonusuario.SizeMode = PictureBoxSizeMode.StretchImage;
                        botonusuario.MouseDown += mousedownevent;
                        botonusuario.MouseMove += MouseMoveevent;
                        botonusuario.MouseUp += mouseupevent;
                        botonusuario.Click += clickevent;
                        FlowLayoutPanel1.PerformLayout();
                        Invoke(new Action(() => FlowLayoutPanel1.Controls.Add(botonusuario)));
                        labelnombre = new Label();
                        labelnombre.Text = nombrecompleto[numero1];

                        labelnombre.AutoSize = false;
                        labelnombre.Size = new Size(100, 50);
                        labelnombre.BackColor = Color.FromArgb(18, 18, 18);
                        labelnombre.ForeColor = Color.FromArgb(223, 223, 223);
                        labelnombre.Location = new Point(0, botonusuario.Height - labelnombre.Height);
                        Invoke(new Action(() => botonusuario.Controls.Add(labelnombre)));
                    }
                }
                botonusuario = new Bunifu.Framework.UI.BunifuImageButton();
                botonusuario.Image = My.Resources.Resources.usuario_agregar;
                botonusuario.Size = new Size(100, 200);
                botonusuario.Name = "Agregar Usuario";
                botonusuario.BackColor = Color.FromArgb(223, 223, 223);
                botonusuario.SizeMode = PictureBoxSizeMode.StretchImage;
                botonusuario.MouseDown += mousedownevent;
                botonusuario.MouseMove += MouseMoveevent;
                botonusuario.MouseUp += mouseupevent;
                botonusuario.Click += clickeventagregar;
                Invoke(new Action(() => FlowLayoutPanel1.Controls.Add(botonusuario)));
                numero = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void mousedownevent(object sender, MouseEventArgs e)
        {

            // Capture the initial point 
            Module1.m_PanStartPoint = new Point(e.X, e.Y);

        }
        public void mouseupevent(object sender, MouseEventArgs e)
        {

            // Capture the initial point 
            Module1.bloquear = false;


        }
        public void MouseMoveevent(object sender, MouseEventArgs e)
        {

            // Verify Left Button is pressed while the mouse is moving
            if (e.Button == MouseButtons.Left)
            {
                Module1.bloquear = true;
                // Here we get the change in coordinates.
                int DeltaX = Module1.m_PanStartPoint.X - e.X;
                int DeltaY = Module1.m_PanStartPoint.Y - e.Y;

                // Then we set the new autoscroll position.
                // ALWAYS pass positive integers to the panels autoScrollPosition method
                FlowLayoutPanel1.AutoScrollPosition = new Point(DeltaX - FlowLayoutPanel1.AutoScrollPosition.X, DeltaY - FlowLayoutPanel1.AutoScrollPosition.Y);


            }

        }
        public void clickevent(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuImageButton b = (Bunifu.Framework.UI.BunifuImageButton)sender;
            // Dim label = DirectCast(sender, Label)
            if (Module1.bloquear == false)
            {
                foreach (DataRow row in Module1.dataPermisos.Rows)
                {
                    if (Conversions.ToBoolean(row["SatiModUsuariosVer"]))
                    {
                        My.MyProject.Forms.Editar_Usuario.idusuario = Conversions.ToString(b.Name);

                        My.MyProject.Forms.Editar_Usuario.Show();
                    }
                    else
                    {

                    }
                }

            }



        }
        public void clickeventagregar(object sender, EventArgs e)
        {

            // Dim label = DirectCast(sender, Label)
            if (Module1.bloquear == false)
            {


                My.MyProject.Forms.Agregar_Usuario.Show();
            }



        }

        private void Backgroundusuarios_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            panelcargando.Visible = false;

            FlowLayoutPanel1.Visible = true;
            timercargando.Enabled = false;
            nombrepicture = 0;
            ypicturebox = 0;
            int num_controles = panelcargando.Controls.Count - 1;
            for (int n = num_controles; n >= 0; n -= 1)
            {
                var ctrl = panelcargando.Controls[n];
                panelcargando.Controls.Remove(ctrl);
                ctrl.Dispose();
            }
        }


    }
}