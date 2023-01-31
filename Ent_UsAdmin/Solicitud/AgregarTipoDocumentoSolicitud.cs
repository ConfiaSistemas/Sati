using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConfiaAdmin
{

    public partial class AgregarTipoDocumentoSolicitud
    {
        private bool insertar;
        public bool autorizado;

        public AgregarTipoDocumentoSolicitud()
        {
            InitializeComponent();
        }
        private void btn_Procesar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Autorizacion.tipoAutorizacion = "SatiModTipoDocumentosAgregar";
            My.MyProject.Forms.Autorizacion.ShowDialog();
            if (autorizado)
            {
                try
                {
                    Module1.iniciarconexionempresa();
                    SqlCommand comando;

                    string consulta;
                    consulta = "Insert into TiposDeDocumentosSolicitud values('" + txtNombre.Text + "','" + ComboTipo.selectedValue + "')";
                    comando = new SqlCommand();
                    comando.Connection = Module1.conexionempresa;
                    comando.CommandText = consulta;
                    comando.ExecuteNonQuery();
                    insertar = true;
                    MessageBox.Show("Listo");
                    txtNombre.Text = "";
                }
                catch (Exception ex)
                {
                    insertar = false;
                    MessageBox.Show("Ha ocurrido un error " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No fue autorizado");
            }


        }

        private void AgregarTipoDocumentoSolicitud_Closing(object sender, CancelEventArgs e)
        {
            if (insertar)
            {
                My.MyProject.Forms.TiposDocumentosSolicitud.cargarDocumentos();

            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Module_resize.MoveForm(this);
            }
        }

        private void AgregarTipoDocumentoSolicitud_Load(object sender, EventArgs e)
        {

        }
    }
}