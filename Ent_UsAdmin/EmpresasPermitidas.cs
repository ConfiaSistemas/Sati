using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;


namespace ConfiaAdmin
{

    public partial class EmpresasPermitidas
    {
        private Cargando ncargando;
        public string idUsuario;
        private int ButtonIndex = 0;
        private Cursor DragDropCursor;

        public EmpresasPermitidas()
        {
            InitializeComponent();
        }
        private void EmpresasPermitidas_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            ButtonIndex += 1;

            ncargando = new Cargando();
            ncargando.MonoFlat_Label1.Text = "Cargando Información";
            ncargando.Show();

            FlowEmpresasRestringidas.AllowDrop = true;
            FlowEmpresasPermitidas.AllowDrop = true;
            BackgroundWorker1.RunWorkerAsync();


        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionR();
            OleDbCommand comandoEmpresasPermitidas;

            string consultaEmpresasPermitidas;
            OleDbDataReader readerEmpresasPermitidas;
            consultaEmpresasPermitidas = "select id,nombre from empresas where id in (select idempresa from empresaspermitidas where idusuario = '" + idUsuario + "')";
            comandoEmpresasPermitidas = new OleDbCommand();
            comandoEmpresasPermitidas.Connection = Module1.conexionempresaR;
            comandoEmpresasPermitidas.CommandText = consultaEmpresasPermitidas;
            readerEmpresasPermitidas = comandoEmpresasPermitidas.ExecuteReader();
            if (readerEmpresasPermitidas.HasRows)
            {

                while (readerEmpresasPermitidas.Read())
                {
                   Button botonempresa = new Button();

                   // botonempresa.Normalcolor = Color.FromArgb(48, 55, 76);
                  //  botonempresa.Iconimage = null;

                    botonempresa.Size = new Size(197, 48);
                    botonempresa.Name = readerEmpresasPermitidas["id"].ToString();
                    botonempresa.Text = readerEmpresasPermitidas["nombre"].ToString();
                    // botonempresa.Tag = milector("ip")
                    // AddHandler botonempresa.Click, AddressOf clickevenntAsync
                    botonempresa.MouseDown += new MouseEventHandler(OnButtonMouseDown);
                    Invoke(new Action(() => FlowEmpresasPermitidas.Controls.Add(botonempresa)));

                }

            }

            OleDbCommand comandoEmpresasRestringidas;
            string consultaEmpresaRestringidas;
            OleDbDataReader readerEmpresasRestringidas;
            consultaEmpresaRestringidas = "select id,nombre from empresas where id not in (select idempresa from empresaspermitidas where idusuario = '" + idUsuario + "')";
            comandoEmpresasRestringidas = new OleDbCommand();
            comandoEmpresasRestringidas.Connection = Module1.conexionempresaR;
            comandoEmpresasRestringidas.CommandText = consultaEmpresaRestringidas;
            readerEmpresasRestringidas = comandoEmpresasRestringidas.ExecuteReader();
            if (readerEmpresasRestringidas.HasRows)
            {

                while (readerEmpresasRestringidas.Read())
                {
                    Button botonempresa = new Button();

                   // botonempresa.Normalcolor = Color.FromArgb(48, 55, 76);
                    //botonempresa.Iconimage = null;

                    botonempresa.Size = new Size(197, 48);
                    botonempresa.Name = readerEmpresasRestringidas["id"].ToString();
                    botonempresa.Text = readerEmpresasRestringidas["nombre"].ToString();
                    // botonempresa.Tag = milector("ip")
                    // AddHandler botonempresa.Click, AddressOf clickevenntAsync
                    botonempresa.MouseDown += new MouseEventHandler(OnButtonMouseDown);
                    Invoke(new Action(() => FlowEmpresasRestringidas.Controls.Add(botonempresa)));

                }

            }




        }

        private void OnButtonMouseDown(object sender, MouseEventArgs e)
        {

            Button button = (Button)sender;

            using (var bmp = new Bitmap(button.Width, button.Height))
            {
                button.DrawToBitmap(bmp, new Rectangle(Point.Empty, button.Size));
                DragDropCursor = new Cursor(bmp.GetHicon());
            }

            button.Parent.DoDragDrop(button, DragDropEffects.Move);

        }

        private void OnFlowLayoutPanelDragEnter(object sender, DragEventArgs e)
        {

            if (e.AllowedEffect == DragDropEffects.Move && e.Data.GetDataPresent(typeof(Button)))
            {
                e.Effect = DragDropEffects.Move;
            }

        }

        private void OnFlowLayoutPanelDragDrop(object sender, DragEventArgs e)
        {

            Button button = (Button)e.Data.GetData(typeof(Button));
            FlowLayoutPanel destPanel = (FlowLayoutPanel)sender;
            destPanel.Controls.Add(button);
            var targetLoc = destPanel.GetChildAtPoint(destPanel.PointToClient(new Point(e.X, e.Y)));

            if (targetLoc != null)
            {
                int idx = destPanel.Controls.GetChildIndex(targetLoc);
                destPanel.Controls.SetChildIndex(button, idx);
            }

        }

        private void OnFlowLayoutPanelGiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

            e.UseDefaultCursors = false;
            Cursor.Current = DragDropCursor;

        }

        private void EmpresasPermitidas_FormClosing(object sender, FormClosingEventArgs e)
        {
            int num_controles = FlowEmpresasPermitidas.Controls.Count - 1;
            for (int n = num_controles; n >= 0; n -= 1)
            {
                var ctrl = FlowEmpresasPermitidas.Controls[n];
                FlowEmpresasPermitidas.Controls.Remove(ctrl);
                ctrl.Dispose();
            }

            int num_controles2 = FlowEmpresasRestringidas.Controls.Count - 1;
            for (int n = num_controles2; n >= 0; n -= 1)
            {
                var ctrl = FlowEmpresasRestringidas.Controls[n];
                FlowEmpresasRestringidas.Controls.Remove(ctrl);
                ctrl.Dispose();
            }

        }

        private void BackgroundAplicar_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionR();

            foreach (Control ctrl in FlowEmpresasPermitidas.Controls)
            {
                if (ctrl is Button)
                {
                    Button btnctrl = (Button)ctrl;
                    OleDbCommand comandoEmpresaPermitida;
                    string consultaEmpresaPermitida;
                    consultaEmpresaPermitida = "if not exists(select id from empresaspermitidas where idempresa = '" + btnctrl.Name + "' and idusuario = '" + idUsuario + @"')
                                            begin
                                              insert into empresasPermitidas values('" + btnctrl.Name + "','" + idUsuario + @"')
                                               end";
                    comandoEmpresaPermitida = new OleDbCommand();
                    comandoEmpresaPermitida.Connection = Module1.conexionempresaR;
                    comandoEmpresaPermitida.CommandText = consultaEmpresaPermitida;
                    comandoEmpresaPermitida.ExecuteNonQuery();



                }
            }


            foreach (Control ctrl in FlowEmpresasRestringidas.Controls)
            {
                if (ctrl is Button)
                {
                 Button btnctrl = (Button)ctrl;
                    OleDbCommand comandoEmpresaRestringida;
                    string consultaEmpresaRestringida;
                    consultaEmpresaRestringida = "if exists(select id from empresaspermitidas where idempresa = '" + btnctrl.Name + "' and idusuario = '" + idUsuario + @"')
                                             begin
                                            delete from empresasPermitidas where idempresa = '" + btnctrl.Name + "' and idusuario = '" + idUsuario + @"' 
                                            end";
                    comandoEmpresaRestringida = new OleDbCommand();
                    comandoEmpresaRestringida.Connection = Module1.conexionempresaR;
                    comandoEmpresaRestringida.CommandText = consultaEmpresaRestringida;
                    comandoEmpresaRestringida.ExecuteNonQuery();



                }
            }

        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ncargando.Close();

        }

        private void BackgroundAplicar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ncargando.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ncargando = new Cargando();
            ncargando.MonoFlat_Label1.Text = "Aplicando cambios";
            ncargando.Show();

            BackgroundAplicar.RunWorkerAsync();

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Module_resize.MoveForm(this);
            }
        }
    }
}