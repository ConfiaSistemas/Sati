using System;
using System.Drawing;

namespace ConfiaAdmin
{
    public partial class nombregrupo
    {


        private int tiempo = 0;
        private double opacidad = 1d;

        public nombregrupo()
        {
            InitializeComponent();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            Timer1.Interval = 100;
            if (tiempo < 10)
            {
                Size = new Size(Width + tiempo, Height + tiempo);
                opacidad = opacidad - 0.05d;
                Opacity = opacidad;
                tiempo += 1;
            }

            else
            {
                Timer1.Enabled = false;
                Close();

            }
        }

        private void nombregrupo_Load(object sender, EventArgs e)
        {
            Location = new Point(My.MyProject.Forms.usuarios.Location.X + My.MyProject.Forms.usuarios.Combogrupo.Location.X, My.MyProject.Forms.usuarios.Location.Y + My.MyProject.Forms.usuarios.Combogrupo.Location.Y + My.MyProject.Forms.usuarios.Panel1.Height);
            Size = new Size(Width - 80, Height - 80);
            Timer1.Enabled = true;
            TopMost = true;
        }

        private void nombregrupo_SizeChanged(object sender, EventArgs e)
        {
            MonoFlat_HeaderLabel1.Location = new Point((int)Math.Round(Width / 2d - MonoFlat_HeaderLabel1.Width / 2d), (int)Math.Round(Height / 2d - MonoFlat_HeaderLabel1.Height / 2d));
        }
    }
}