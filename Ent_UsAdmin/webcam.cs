using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video.DirectShow;

namespace ConfiaAdmin
{
    public partial class webcam
    {
        private FilterInfoCollection dispositivos;
        private VideoCaptureDevice fuentedevideo;
        private int ex, ey;
        private string nombre;
        private bool Arrastre;

        public webcam()
        {
            InitializeComponent();
        }

        private void webcam_Load(object sender, EventArgs e)
        {
            dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo x in dispositivos)
                ComboBox1.Items.Add(x.Name);
            ComboBox1.SelectedIndex = 0;
        }

        private void Btn_iniciar_Click(object sender, EventArgs e)
        {
            fuentedevideo = new VideoCaptureDevice(dispositivos[ComboBox1.SelectedIndex].MonikerString);
            VideoSourcePlayer1.VideoSource = fuentedevideo;
            VideoSourcePlayer1.Start();

        }

        private void btn_detener_Click(object sender, EventArgs e)
        {
            VideoSourcePlayer1.SignalToStop();
        }

        private void btn_capturar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.editarperfil.BunifuImageButton1.Image = VideoSourcePlayer1.GetCurrentVideoFrame();
            My.MyProject.Forms.editarperfil.labelimagen.Visible = false;
        }

        private void webcam_MouseDown(object sender, MouseEventArgs e)
        {
            ex = e.X;

            ey = e.Y;

            Arrastre = true;
        }

        private void webcam_MouseMove(object sender, MouseEventArgs e)
        {
            // Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien

            if (Arrastre)
                Location = PointToScreen(new Point(MousePosition.X - Location.X - ex, MousePosition.Y - Location.Y - ey));

            // pero si quieres dejar los bordes y la barra de titulo entonces es necesario descomentar la siguiente linea y comentar la anterior, osea ponerle el apostrofe

            // If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex - 8, Me.MousePosition.Y - Me.Location.Y - ey - 60))
        }

        private void webcam_MouseUp(object sender, MouseEventArgs e)
        {
            Arrastre = false;
        }
    }
}