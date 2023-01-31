using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class DocumentosCreditoLegal
    {
        public string idCredito;

        public DocumentosCreditoLegal()
        {
            InitializeComponent();
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.AgregarDocumentoLegal.ShowDialog();
        }



        private void dtdatosDocumentosNuevos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dtdatosDocumentosNuevos.Rows.Count != 0)
                {
                    dtdatosDocumentosNuevos.Rows.RemoveAt(dtdatosDocumentosNuevos.CurrentRow.Index);
                }

            }
        }



        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Module_resize.MoveForm(this);
            }
        }

        private void BackgroundDocumentos_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();

            foreach (DataGridViewRow row in dtdatosDocumentosNuevos.Rows)
            {
                SqlCommand comandoDocumento;
                string consultaDocumento;
                Bitmap imagen = row.Cells[2].Value as Bitmap;
                var NuevaImagen = ImagenComprimida(imagen);
                consultaDocumento = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into DocumentosLegales values('" + idCredito + "','", row.Cells[0].Value), "',@Documento)"));
                var imgDocumento = new SqlParameter("@Documento", SqlDbType.Image);
                var msImgDocumento = new MemoryStream();
                NuevaImagen.Save(msImgDocumento, ImageFormat.Jpeg);
                imgDocumento.Value = msImgDocumento.GetBuffer();
                comandoDocumento = new SqlCommand();
                comandoDocumento.Connection = Module1.conexionempresa;
                comandoDocumento.CommandText = consultaDocumento;
                comandoDocumento.Parameters.Add(imgDocumento);
                comandoDocumento.ExecuteNonQuery();

            }
        }
        private Bitmap ImagenComprimida(Bitmap bmp)
        {
            try
            {

                int Width = bmp.Width;
                int Height = bmp.Height;
                // next we declare the maximum size of the resized image. 
                // In this case, all resized images need to be constrained to a 173x173 square.
                int Heightmax = 1572;
                int Widthmax = 1826;
                // declare the minimum value af the resizing factor before proceeding. 
                // All images with a lower factor than this will actually be resized
                decimal Factorlimit = 1m;
                // determine if it is a portrait or landscape image
                decimal Relative = (decimal)(Height / (double)Width);
                decimal Factor;
                // if the image is a portrait image, calculate the resizing factor based on its height. 
                // else the image is a landscape image, 
                // and we calculate the resizing factor based on its width.
                if (Relative > 1m)
                {
                    if (Height < Heightmax + 1)
                    {
                        Factor = 1m;
                    }
                    else
                    {
                        Factor = (decimal)(Heightmax / (double)Height);
                    }
                }
                // 
                else if (Width < Widthmax + 1)
                {
                    Factor = 1m;
                }
                else
                {
                    Factor = (decimal)(Widthmax / (double)Width);
                }
                if (Factor < Factorlimit)
                {
                    // draw a new image with the dimensions that result from the resizing
                    var bmpnew = new Bitmap((int)Math.Round(bmp.Width * Factor), (int)Math.Round(bmp.Height * Factor), PixelFormat.Format24bppRgb);
                    var g = Graphics.FromImage(bmpnew);
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    // and paste the resized image into it
                    g.DrawImage(bmp, 0, 0, bmpnew.Width, bmpnew.Height);
                    return bmpnew;
                }
                else
                {
                    return bmp;
                }
            }

            catch (Exception ex)
            {
                return null;
                MessageBox.Show(ex.Message);
            }

          
        }
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Insertando Documentos";
            My.MyProject.Forms.Cargando.TopMost = true;
            BackgroundDocumentos.RunWorkerAsync();

        }

        private void BackgroundDocumentos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            Invoke(new Action(() => My.MyProject.Forms.InformacionLegal.BackgroundClientes.RunWorkerAsync()));
            My.MyProject.Forms.Cargando.Close();
            Close();
        }
    }
}