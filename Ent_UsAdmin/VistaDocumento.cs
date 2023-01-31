using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    public partial class VistaDocumento
    {
        private Image PicCopy;

        public VistaDocumento()
        {
            InitializeComponent();
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            // PictureBox1.Image.Save(SaveFileDialog1.FileName)


        }

        private void PictureBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDialog1;
            SaveFileDialog1 = new SaveFileDialog();

            SaveFileDialog1.Filter = "Archivo imagen (*.jpg*)|*.jpg";
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PictureBox1.Image.Save(SaveFileDialog1.FileName);


            }
        }

        private void VistaDocumento_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void VistaDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Oemplus)
            {
                var btmap = new Bitmap(PictureBox1.Image);

                btmap.RotateFlip(RotateFlipType.Rotate90FlipY);
                PictureBox1.Image = btmap;
            }
        }

        private void VistaDocumento_Load(object sender, EventArgs e)
        {

        }
    }
}