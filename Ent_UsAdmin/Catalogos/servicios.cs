using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    public partial class servicios
    {

        public bool bloquearlabel = false;
        public bool bloquearlabelagregar = false;
        public bool agregarservicioabierto = false;
        public int yiniciallabel = 34;
        public int yfinallabel = 30;

        public servicios()
        {
            InitializeComponent();
        }





        private void MonoFlat_Label1_MouseClick(object sender, MouseEventArgs e)
        {


        }

        private void MonoFlat_Label1_MouseDown(object sender, MouseEventArgs e)
        {
            MonoFlat_Label1.BorderStyle = BorderStyle.Fixed3D;
            MonoFlat_Label1.ForeColor = Color.Coral;
            bloquearlabelagregar = true;
            agregarservicioabierto = true;
            My.MyProject.Forms.agregarservicio.Show();
        }

        private void MonoFlat_Label1_MouseUp(object sender, MouseEventArgs e)
        {
            // MonoFlat_Label1.ForeColor = Color.FromArgb(64, 64, 64)
            // MonoFlat_Label1.BorderStyle = BorderStyle.None
            // agregarservicio.Show()
        }



        private void MonoFlat_Label1_MouseHover(object sender, EventArgs e)
        {
            // MonoFlat_Label1.ForeColor = Color.FromArgb(204, 0, 0)
            if (bloquearlabelagregar == false)
            {
                MonoFlat_Label1.Location = new Point(MonoFlat_Label1.Location.X, yfinallabel);
                bloquearlabelagregar = true;
            }


            // MonoFlat_Label1.BorderStyle = BorderStyle.FixedSingle
        }

        private void MonoFlat_Label1_MouseLeave(object sender, EventArgs e)
        {
            if (agregarservicioabierto == false)
            {
                if (bloquearlabelagregar == true)
                {
                    MonoFlat_Label1.ForeColor = Color.FromArgb(64, 64, 64);
                    MonoFlat_Label1.BorderStyle = BorderStyle.None;
                    MonoFlat_Label1.Location = new Point(MonoFlat_Label1.Location.X, yiniciallabel);
                    bloquearlabelagregar = false;
                }
            }


        }



        private void lblmodificar_MouseDown(object sender, MouseEventArgs e)
        {
            lblmodificar.BorderStyle = BorderStyle.Fixed3D;
            lblmodificar.ForeColor = Color.Coral;

        }

        private void lblmodificar_MouseHover(object sender, EventArgs e)
        {
            if (bloquearlabel == false)
            {
                lblmodificar.Location = new Point(lblmodificar.Location.X, lblmodificar.Location.Y - 4);
                bloquearlabel = true;
            }

        }

        private void lblmodificar_MouseLeave(object sender, EventArgs e)
        {
            if (bloquearlabel == true)
            {
                lblmodificar.ForeColor = Color.FromArgb(64, 64, 64);
                lblmodificar.BorderStyle = BorderStyle.None;
                lblmodificar.Location = new Point(lblmodificar.Location.X, lblmodificar.Location.Y + 4);
                bloquearlabel = false;
            }
        }

        private void lblmodificar_MouseUp(object sender, MouseEventArgs e)
        {
            lblmodificar.ForeColor = Color.FromArgb(64, 64, 64);
            lblmodificar.BorderStyle = BorderStyle.None;
        }

        private void lbleliminar_Click(object sender, EventArgs e)
        {

        }

        private void lbleliminar_MouseDown(object sender, MouseEventArgs e)
        {
            lbleliminar.BorderStyle = BorderStyle.Fixed3D;
            lbleliminar.ForeColor = Color.Coral;
        }

        private void lbleliminar_MouseHover(object sender, EventArgs e)
        {
            if (bloquearlabel == false)
            {
                lbleliminar.Location = new Point(lbleliminar.Location.X, lbleliminar.Location.Y - 4);
                bloquearlabel = true;
            }
        }

        private void lbleliminar_MouseLeave(object sender, EventArgs e)
        {
            if (bloquearlabel == true)
            {
                lbleliminar.ForeColor = Color.FromArgb(64, 64, 64);
                lbleliminar.BorderStyle = BorderStyle.None;
                lbleliminar.Location = new Point(lbleliminar.Location.X, lbleliminar.Location.Y + 4);
                bloquearlabel = false;
            }
        }

        private void lbleliminar_MouseUp(object sender, MouseEventArgs e)
        {
            lbleliminar.ForeColor = Color.FromArgb(64, 64, 64);
            lbleliminar.BorderStyle = BorderStyle.None;
        }

        private void MonoFlat_Label1_Click(object sender, EventArgs e)
        {



        }


    }
}