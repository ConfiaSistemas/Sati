using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ConfiaAdmin
{

    public partial class AgregarDocumentoDatosSolicitud
    {
        private string nombre;
        private DataTable dataDocumento;
        private SqlDataAdapter adapterDocumento;
        private bool cargado;
        private Image imagenNada = My.Resources.Resources.new_seo2_38_512;

        public AgregarDocumentoDatosSolicitud()
        {
            InitializeComponent();
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
            }
            // labelimagen.Visible = False

            else
            {
                MessageBox.Show("No se seleccionó ningún archivo");

            }

        }

        private void btn_Procesar_Click(object sender, EventArgs e)
        {
            if (ReferenceEquals(BunifuImageButton1.Image, My.Resources.Resources.new_seo2_38_512))
            {
                MessageBox.Show("Debe seleccionar una imagen");
            }
            else
            {
                int idTipoDocumento;
                idTipoDocumento = ConsultarIdTipo(ComboDocumento.Text);
                My.MyProject.Forms.DatosSolicitud.dtdatosDocumentosNuevos.Rows.Add(idTipoDocumento, ComboDocumento.Text, BunifuImageButton1.Image);
                BunifuImageButton1.Image = My.Resources.Resources.new_seo2_38_512;
            }


        }

        private void AgregarDocumentoDatosSolicitud_Load(object sender, EventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Tipos de Documentos";
            BackgroundTiposDocumentos.RunWorkerAsync();
        }

        private void BackgroundTiposDocumentos_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {
                Module1.iniciarconexionempresa();
                string consulta;
                consulta = "Select id,Nombre from tiposdeDocumentosSolicitud ";
                adapterDocumento = new SqlDataAdapter(consulta, Module1.conexionempresa);
                dataDocumento = new DataTable();
                adapterDocumento.Fill(dataDocumento);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error " + ex.Message);
            }
        }

        private void BackgroundTiposDocumentos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ComboDocumento.Items.Clear();
            foreach (DataRow row in dataDocumento.Rows)

                ComboDocumento.Items.Add(row["Nombre"].ToString());
            My.MyProject.Forms.Cargando.Close();
        }
        private int ConsultarIdTipo(string nombre)
        {
            int idTipo =0;

            foreach (DataRow row in dataDocumento.Rows)
            {
                if ((row["Nombre"].ToString() ?? "") == (nombre ?? ""))
                {
                    idTipo = (int)Math.Round(Conversion.Val(row["id"].ToString()));
                    break;
                }
            }



            return idTipo;
        }
    }
}