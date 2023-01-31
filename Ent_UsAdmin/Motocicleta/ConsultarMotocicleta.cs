using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class ConsultarMotocicleta
    {

        public string idCredito;
        private DataTable dataDocumentos;
        private SqlDataAdapter adapterDocumentos;
        private Cargando nCargando;

        public ConsultarMotocicleta()
        {
            InitializeComponent();
        }

        private void CaputarMotocicleta_Load(object sender, EventArgs e)
        {
            nCargando = new Cargando();
            nCargando.Show();
            nCargando.MonoFlat_Label1.Text = "Cargando Datos";


            BackgroundMotocicleta.RunWorkerAsync();

        }

        private void BackgroundMotocicleta_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();

            SqlCommand comandoMotocicleta;
            string consultaMotocicleta;
            SqlDataReader readerMotocicleta;

            consultaMotocicleta = "select * from motocicletas where idcredito='" + idCredito + "'";
            comandoMotocicleta = new SqlCommand();
            comandoMotocicleta.Connection = Module1.conexionempresa;
            comandoMotocicleta.CommandText = consultaMotocicleta;

            readerMotocicleta = comandoMotocicleta.ExecuteReader();
            if (readerMotocicleta.HasRows)
            {
                while (readerMotocicleta.Read())
                {
                    txtMarca.Text = Conversions.ToString(readerMotocicleta["Marca"]);
                    txtModelo.Text = Conversions.ToString(readerMotocicleta["Modelo"]);
                    txtCilindraje.Text = Conversions.ToString(readerMotocicleta["Cilindraje"]);
                    txtColor.Text = Conversions.ToString(readerMotocicleta["Color"]);
                    txtAño.Text = Conversions.ToString(readerMotocicleta["Año"]);
                    txtSerie.Text = Conversions.ToString(readerMotocicleta["Serie"]);
                    txtNCI.Text = Conversions.ToString(readerMotocicleta["NCI"]);
                    txtNoMotor.Text = Conversions.ToString(readerMotocicleta["NoMotor"]);
                    txtNoPedimento.Text = Conversions.ToString(readerMotocicleta["NoPedimento"]);
                    txtNoFactura.Text = Conversions.ToString(readerMotocicleta["NoFactura"]);
                    txtValor.Text = Conversions.ToString(readerMotocicleta["Valor"]);



                }
            }


        }

        private void BackgroundDocumentosMotocicleta_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consultaDocumentos;
            consultaDocumentos = "Select DocumentosCredito.Tipo,TiposdeDocumentosSolicitud.Nombre,DocumentosCredito.Imagen from documentosCredito inner join TiposdeDocumentosSolicitud on DocumentosCredito.Tipo = TiposdeDocumentosSolicitud.id where idCredito = '" + idCredito + "' and (DocumentosCredito.tipo = (select id from TiposdeDocumentosSolicitud where nombre='Motocicleta') or DocumentosCredito.tipo = (select id from TiposdeDocumentosSolicitud where nombre='Factura Motocicleta'))";
            adapterDocumentos = new SqlDataAdapter(consultaDocumentos, Module1.conexionempresa);
            dataDocumentos = new DataTable();
            adapterDocumentos.Fill(dataDocumentos);
        }

        private void BackgroundDocumentosMotocicleta_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtdatosDocumentos.DataSource = dataDocumentos;
            nCargando.Close();

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.AgregarDocumentoMotocicleta.Show();

        }

        private void BackgroundMotocicleta_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            nCargando.MonoFlat_Label1.Text = "Cargando Documentos";
            BackgroundDocumentosMotocicleta.RunWorkerAsync();

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

        private void BackgroundActualizarDatos_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            SqlCommand comandoActualizar;
            string consultaActualizar;
            consultaActualizar = @"UPDATE [dbo].[Motocicletas]
   SET [Marca] = '" + txtMarca.Text + @"'
      ,[Modelo] = '" + txtModelo.Text + @"'
      ,[Cilindraje] = '" + txtCilindraje.Text + @"'
      ,[Color] = '" + txtColor.Text + @"'
      ,[Año] = '" + txtAño.Text + @"'
      ,[Serie] = '" + txtSerie.Text + @"'
      ,[NCI] = '" + txtNCI.Text + @"'
      ,[NoMotor] = '" + txtNoMotor.Text + @"'
      ,[NoPedimento] = '" + txtNoPedimento.Text + @"'
      ,[NoFactura] = '" + txtNoFactura.Text + @"'
      ,[Valor] = '" + txtValor.Text + @"'
     
 WHERE idcredito='" + idCredito + "'";

            comandoActualizar = new SqlCommand();
            comandoActualizar.Connection = Module1.conexionempresa;
            comandoActualizar.CommandText = consultaActualizar;
            comandoActualizar.ExecuteNonQuery();

        }

        private void btn_Procesar_Click(object sender, EventArgs e)
        {
            nCargando = new Cargando();
            nCargando.Show();

            nCargando.MonoFlat_Label1.Text = "Actualizando Información";
            BackgroundActualizarDatos.RunWorkerAsync();

        }

        private void BackgroundActualizarDatos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            nCargando.MonoFlat_Label1.Text = "Insertando Documentos";
            BackgroundDocumentos.RunWorkerAsync();

        }

        private void BackgroundDocumentos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            nCargando.MonoFlat_Label1.Text = "Cargando Documentos";


            BackgroundDocumentosMotocicleta.RunWorkerAsync();
            My.MyProject.Forms.EntregarDocumentacion.MotoActualizada = true;


        }

        private void TabControlAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {

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