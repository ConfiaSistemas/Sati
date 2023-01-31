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

    public partial class IngresarDepositoLegal
    {
        public double MontoDeposito;
        public int idCredito;
        private DataTable dataUsuarios;
        private SqlDataAdapter adapterUsuarios;

        private Cargando nCargando;

        public IngresarDepositoLegal()
        {
            InitializeComponent();
        }
        private void IngresarDepositoLegal_Load(object sender, EventArgs e)
        {
            nCargando = new Cargando();
            nCargando.Show();
            nCargando.MonoFlat_Label1.Text = "Consultando Usuarios";
            BackgroundUsuarios.RunWorkerAsync();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();

            SqlCommand comandoInsertaDeposito;
            string consultaInsertaDeposito;
            string idDepositoLegal;
            consultaInsertaDeposito = "insert into depositoslegal values('" + idCredito + "','" + txtMonto.Text + "','" + dateFechaDeposito.Value.ToString("yyyy-MM-dd") + "',@imagen,'" + txtComentario.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + Module1.nmusr + "','','','','E') select SCOPE_IDENTITY()";
            Bitmap imagen = BunifuImageButton1.Image as Bitmap;
            var NuevaImagen = ImagenComprimida(imagen);
            var imgDocumento = new SqlParameter("@imagen", SqlDbType.Image);
            var msImgDocumento = new MemoryStream();
            NuevaImagen.Save(msImgDocumento, ImageFormat.Jpeg);
            imgDocumento.Value = msImgDocumento.GetBuffer();
            comandoInsertaDeposito = new SqlCommand();
            comandoInsertaDeposito.Connection = Module1.conexionempresa;
            comandoInsertaDeposito.CommandText = consultaInsertaDeposito;
            comandoInsertaDeposito.Parameters.Add(imgDocumento);
            idDepositoLegal = Conversions.ToString(comandoInsertaDeposito.ExecuteScalar());


            SqlCommand comandoNotificacion;
            string consultaNotificación;
            consultaNotificación = @"INSERT INTO OPENQUERY (MYSQ, 'SELECT * FROM USRS.Notificaciones')
VALUES (null,'DepositoLegal',1,'" + Module1.nmusr + "','" + ComboUsuarios.selectedValue + "','" + idDepositoLegal + "','','" + txtComentario.Text + "',0,'0',GETDATE(),CONVERT(varchar(8),GETDATE(),108),'0','','','" + Module1.nombreAmostrar + "','','');";
            comandoNotificacion = new SqlCommand();
            comandoNotificacion.Connection = Module1.conexionempresa;
            comandoNotificacion.CommandText = consultaNotificación;
            comandoNotificacion.ExecuteNonQuery();

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
        private void BackgroundUsuarios_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consultaUsuarios;
            consultaUsuarios = "SELECT * FROM OPENQUERY (MYSQ, 'select Usr.nm,Usr.nm_complete from Usr inner join grp on Usr.grp = grp.id inner join PermisosGrupo on grp.id = PermisosGrupo.idGrupo where PermisosGrupo.SatiModCreditosDescuentoPromesa = 1');  ";
            adapterUsuarios = new SqlDataAdapter(consultaUsuarios, Module1.conexionempresa);
            dataUsuarios = new DataTable();
            adapterUsuarios.Fill(dataUsuarios);
        }

        private void BackgroundUsuarios_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ComboUsuarios.Clear();
            foreach (DataRow row in dataUsuarios.Rows)
                ComboUsuarios.AddItem(row["nm"].ToString());
            ComboUsuarios.selectedIndex = 0;
            nCargando.Close();
        }

        private void ComboUsuarios_onItemSelected(object sender, EventArgs e)
        {
            foreach (DataRow row in dataUsuarios.Rows)
            {
                if ((row["nm"].ToString() ?? "") == (ComboUsuarios.selectedValue ?? ""))
                {
                    lblNombreUsuario.Text = row["nm_complete"].ToString();
                    break;
                }
            }
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            nCargando = new Cargando();
            nCargando.Show();
            nCargando.MonoFlat_Label1.Text = "Insertando Depósito";
            BackgroundWorker1.RunWorkerAsync();

        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            nCargando.Close();
            Close();

        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog();
            string nombre;
            openFileDialog1.Filter = "Imágenes (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg;*.jpeg;*.png";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.ShowDialog();
            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                nombre = openFileDialog1.FileName;
                BunifuImageButton1.Image = Image.FromFile(nombre);
            }


            else
            {
                MessageBox.Show("No se seleccionó ningún archivo");

            }
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