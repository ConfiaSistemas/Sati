using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class TiposDocumentosSolicitud
    {
        public TiposDocumentosSolicitud()
        {
            InitializeComponent();
        }
        private void TiposDocumentosSolicitud_Load(object sender, EventArgs e)
        {
            cargarDocumentos();
        }


        public void cargarDocumentos()
        {
            dtimpuestos.Rows.Clear();
            try
            {
                string strimpuestos;
                Module1.iniciarconexionempresa();

                strimpuestos = "select * from TiposdeDocumentosSolicitud";

                var ejec = new SqlCommand(strimpuestos);
                ejec.Connection = Module1.conexionempresa;
                string id, nombre, valor, factor, tipo;

                var myreaderimpuestos = ejec.ExecuteReader();
                while (myreaderimpuestos.Read())
                {
                    id = Conversions.ToString(myreaderimpuestos["id"]);
                    nombre = Conversions.ToString(myreaderimpuestos["nombre"]);

                    dtimpuestos.Rows.Add(id, nombre, myreaderimpuestos["tipo"]);
                }
                myreaderimpuestos.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            cargarDocumentos();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.AgregarTipoDocumentoSolicitud.Show();
        }
    }
}