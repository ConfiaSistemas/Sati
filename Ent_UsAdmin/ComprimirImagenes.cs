using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class ComprimirImagenes
    {
        public ComprimirImagenes()
        {
            InitializeComponent();
        }
        private void ComprimirImagenes_Load(object sender, EventArgs e)
        {


        }
        public void Resizer(int photo)
        {
            Module1.iniciarconexionempresa();
            var cmd = new System.Data.SqlClient.SqlCommand();
            System.Data.SqlClient.SqlDataReader reader;
            cmd = Module1.conexionempresa.CreateCommand();
            // query to retrieve the rows from the table that contain images 
            // (only the actual column that contains the id is retrieved for all rows 
            // that contain a non-empty blob)
            if (RadioSolicitud.Checked)
            {
                cmd.CommandText = "SELECT imagen FROM documentosSolicitud where id = '" + photo + "' ";
            }
            if (RadioCredito.Checked)
            {
                cmd.CommandText = "SELECT imagen FROM documentoscredito where id = '" + photo + "' ";
            }

            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                byte[] imgByteArray;
                // try to resize the image, else fail with error and resume to next
                try
                {
                    // read the image as a stream and make a bitmap out of it
                    imgByteArray = (byte[])reader[0];
                    var stream = new MemoryStream(imgByteArray);
                    var bmp = new Bitmap(stream);
                    stream.Close();
                    // start resizing the retrieved image. First the current dimensions are checked.
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
                    // if the resizing factor is lower than the set limit, start processing the image, 
                    // else proceed to the next image
                    if (Factor < Factorlimit)
                    {
                        // draw a new image with the dimensions that result from the resizing
                        var bmpnew = new Bitmap((int)Math.Round(bmp.Width * Factor), (int)Math.Round(bmp.Height * Factor), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                        var g = Graphics.FromImage(bmpnew);
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        // and paste the resized image into it
                        g.DrawImage(bmp, 0, 0, bmpnew.Width, bmpnew.Height);
                        reader.Close();
                        System.Data.SqlClient.SqlCommand cmdstore;
                        cmdstore = Module1.conexionempresa.CreateCommand();
                        // run an update query to set the image back to its original tablerow. 
                        // Effectively reversing the retrieval mechanism, using the image stream 
                        // as a variable in the query.
                        if (RadioSolicitud.Checked)
                        {
                            cmdstore.CommandText = "Update documentossolicitud SET imagen=@image WHERE id=" + photo;
                        }
                        if (RadioCredito.Checked)
                        {
                            cmdstore.CommandText = "Update documentoscredito SET imagen=@image WHERE id=" + photo;
                        }

                        var streamstore = new MemoryStream();
                        bmpnew.Save(streamstore, System.Drawing.Imaging.ImageFormat.Jpeg);
                        imgByteArray = streamstore.ToArray();
                        streamstore.Close();
                        cmdstore.Parameters.AddWithValue("@Image", imgByteArray);
                        // Execute the query and report a success if succeeded, else give the error.
                        if (cmdstore.ExecuteNonQuery() > 0)
                        {
                            Console.WriteLine("{0} ", photo + " stored");
                        }
                    }
                }
                // if the processing fails, give the id of the image and the error
                catch (Exception ex)
                {
                    Console.WriteLine("{0} ", photo + ": " + ex.Message);
                }
            }
            // Close and dispose the objects used. Ready to proceed to the next image.
            reader.Close();

            cmd.Dispose();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            BackgroundWorker1.RunWorkerAsync();

        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            int photo;
            int numero = 1;
            var cmdtotal = new System.Data.SqlClient.SqlCommand();
            System.Data.SqlClient.SqlDataReader readertotal;
            cmdtotal = Module1.conexionempresa.CreateCommand();
            // query to retrieve the rows from the table that contain images 
            // (only the actual column that contains the id is retrieved for all rows 
            // that contain a non-empty blob)
            System.Data.SqlClient.SqlCommand comandoTotal;

            int totalRegistros;
            string consultaTotal ="";
            comandoTotal = new System.Data.SqlClient.SqlCommand();
            if (RadioSolicitud.Checked)
            {
                consultaTotal = "select count(id) from documentossolicitud";

            }
            if (RadioCredito.Checked)
            {
                consultaTotal = "select count(id) from documentoscredito";
            }

            comandoTotal.Connection = Module1.conexionempresa;
            comandoTotal.CommandText = consultaTotal;
            totalRegistros = Conversions.ToInteger(comandoTotal.ExecuteScalar());


            if (RadioSolicitud.Checked)
            {
                cmdtotal.CommandText = "SELECT id FROM documentossolicitud";
            }
            if (RadioCredito.Checked)
            {
                cmdtotal.CommandText = "SELECT id FROM documentoscredito";
            }

            readertotal = cmdtotal.ExecuteReader();
            // for each result in the dataset, run the resizer and pass it the id of the specific image
            while (readertotal.Read() != false)
            {
                Label1.Text = numero + " de " + totalRegistros;
                photo = readertotal.GetInt32(0);
                Resizer(photo);
                numero += 1;


            }
            // dispose of all used objects
            readertotal.Close();

            cmdtotal.Dispose();
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Terminado");
        }
    }
}