using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ConfiaAdmin
{

    public partial class slider
    {
        private System.Collections.ObjectModel.ReadOnlyCollection<string> ARCHIVOS;
        private int CONTADOR = 0;
        private string extension;

        public slider()
        {
            InitializeComponent();
        }
        private void slider_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Timer1.Interval = 1000;
            Timer1.Start();

            try
            {
                if (CONTADOR < ARCHIVOS.Count - 1)
                {
                    extension = Path.GetExtension(ARCHIVOS[CONTADOR]);
                    if (extension == ".jpg" | extension == ".png" | extension == ".bmp" | extension == ".ico")
                    {
                        PictureBox1.Image = Image.FromFile(ARCHIVOS[CONTADOR]);

                        CONTADOR += 1;
                    }
                    else
                    {

                        CONTADOR += 1;
                    }
                }


                else if (extension == ".jpg" | extension == ".png" | extension == ".bmp" | extension == ".ico")
                {
                    PictureBox1.Image = Image.FromFile(ARCHIVOS[CONTADOR]);



                    CONTADOR = 0;
                }
                else
                {
                    CONTADOR = 0;

                }
            }
            catch (Exception ex)
            {
                Timer1.Stop();

                Interaction.MsgBox(ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string CARPETA;
                CARPETA = FolderBrowserDialog1.SelectedPath;
                ARCHIVOS = My.MyProject.Computer.FileSystem.GetFiles(CARPETA);
            }
            Timer1.Enabled = true;

        }
    }
}