using System;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{
    public partial class editarperfil
    {
        private int ex, ey;
        private string nombre;
        private bool Arrastre;

        public editarperfil()
        {
            InitializeComponent();
        }
        private void editarperfil_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Module1.imgstrusr))
            {
                BunifuImageButton1.Image = null;
            }
            else
            {
                BunifuImageButton1.Image = Module1.bitmapimgusr;
                labelimagen.Visible = false;

            }
            if (!string.IsNullOrEmpty(Module1.nm_completeusr))
            {
                txtnombre.Text = Module1.nm_completeusr;
            }

            if (!string.IsNullOrEmpty(Module1.addrusr))
            {
                txtdireccion.Text = Module1.addrusr;
            }

            if (!string.IsNullOrEmpty(Module1.tlfusr))
            {
                txttelefono.Text = Module1.tlfusr;
            }

            BunifuImageButton1.AllowDrop = true;
            var mensajesayuda = new ToolTip();
            mensajesayuda.AutoPopDelay = 5000;
            mensajesayuda.InitialDelay = 500;
            mensajesayuda.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            mensajesayuda.ShowAlways = true;
            mensajesayuda.SetToolTip(BunifuImageButton1, "Arrastra una imagen o da clic para agregar una imagen");
        }
        private void editarperfil_MouseDown(object sender, MouseEventArgs e)
        {

            ex = e.X;

            ey = e.Y;

            Arrastre = true;

        }

        private void editarperfil_MouseUp(object sender, MouseEventArgs e)
        {

            Arrastre = false;

        }

        private void editarperfil_MouseMove(object sender, MouseEventArgs e)
        {

            // Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien

            if (Arrastre)
                Location = PointToScreen(new Point(MousePosition.X - Location.X - ex, MousePosition.Y - Location.Y - ey));

            // pero si quieres dejar los bordes y la barra de titulo entonces es necesario descomentar la siguiente linea y comentar la anterior, osea ponerle el apostrofe

            // If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex - 8, Me.MousePosition.Y - Me.Location.Y - ey - 60))

        }



        private void BunifuImageButton1_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {

                  //  string strRutaArchivoImagen;

                    int i;

                    // Asignamos la primera posición del array de ruta de archivos a la variable de tipo string

                    // declarada anteriormente ya que en este caso sólo mostraremos una imagen en el control.
                    var strRutaArchivoImagen = e.Data.GetData(DataFormats.Text) as string;
                   // strRutaArchivoImagen = Conversions.ToString(e.Data.GetData(DataFormats.FileDrop)((object)0));

                    // La cargamos al control

                    BunifuImageButton1.Load(strRutaArchivoImagen);
                }
                labelimagen.Visible = false;
            }
            catch (ArgumentException ex)
            {
                Interaction.MsgBox("Archivo no válido", MsgBoxStyle.Exclamation);
            }

        }

        private void BunifuImageButton1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {

                // Los archivos son externos a nuestra aplicación por lo que de indicaremos All ya que dará lo mismo.

                e.Effect = DragDropEffects.All;

            }

        }


        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Imágenes (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg;*.jpeg;*.png";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.ShowDialog();
            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                nombre = openFileDialog1.FileName;
                BunifuImageButton1.Image = Image.FromFile(nombre);
                labelimagen.Visible = false;
            }

            else
            {
                MessageBox.Show("No se seleccionó ningún archivo");

            }
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            MemoryStream streamimg;
            byte[] bitmapbytes;
            string bytestring;

            streamimg = new MemoryStream();
            string s;

            var connexio = new OleDbConnection(Module1.cn);
            OleDbCommand myCommand;
            OleDbDataReader myReader;

            if (string.IsNullOrEmpty(txtnombre.Text))
            {
                Interaction.MsgBox("La caja de nombre no puede estar vacía", MsgBoxStyle.Exclamation);
                txtnombre.Focus();
            }

            else if (string.IsNullOrEmpty(txtdireccion.Text))
            {
                Interaction.MsgBox("La caja de dirección no puede estar vacía", MsgBoxStyle.Exclamation);
                txtdireccion.Focus();
            }
            else if (string.IsNullOrEmpty(txttelefono.Text))
            {
                Interaction.MsgBox("La caja de teléfono no puede estar vacía", MsgBoxStyle.Exclamation);
                txttelefono.Focus();
            }
            else
            {


                connexio.Open();
                if (BunifuImageButton1.Image != null)
                {
                    BunifuImageButton1.Image.Save(streamimg, System.Drawing.Imaging.ImageFormat.Bmp);
                    bitmapbytes = streamimg.ToArray();
                    bytestring = Convert.ToBase64String(bitmapbytes);

                    // s = "update usr set nm_complete = '" & txtnombre.Text & "', addr = '" & txtdireccion.Text & "', tlf = '" & Convert.ToInt64(txttelefono.Text) & "', imgstr = '" & bytestring & "' where idusr = '" & idusr & "'"
                    myCommand = new OleDbCommand(string.Format("update usr set nm_complete = '" + txtnombre.Text + "', addr = '" + txtdireccion.Text + "', tlf = '" + txttelefono.Text + "' , imgstr = '" + bytestring + "' where idusr = '" + Module1.idusr + "'"));
                }
                else
                {
                    myCommand = new OleDbCommand(string.Format("update usr set nm_complete = '" + txtnombre.Text + "', addr = '" + txtdireccion.Text + "', tlf = '" + Convert.ToDouble(txttelefono.Text) + "', imgstr = '' where idusr = '" + Module1.idusr + "'"));
                    s = "update usr set nm_complete = '" + txtnombre.Text + "', addr = '" + txtdireccion.Text + "', tlf = '" + txttelefono.Text + "' where idusr = '" + Module1.idusr + "'";
                }
                try
                {
                    myCommand.Connection = connexio;
                    myCommand.ExecuteNonQuery();
                    connexio.Close();
                    Module1.cargarperfil();
                    Interaction.MsgBox("Hecho", MsgBoxStyle.Information);
                    Close();
                }

                catch (Exception ex)
                {
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.Exclamation);
                }

            }
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            var errorprovider1 = new ErrorProvider();


            if (char.IsDigit(e.KeyChar))
            {

                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {

                e.Handled = false;
            }

            else
            {

                e.Handled = true;

            }
        }


        private void LinkLabeldelimage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BunifuImageButton1.Image = null;
            labelimagen.Visible = true;

        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.webcam.Show();

        }
    }
}