using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class Cajas
    {
        public Cajas()
        {
            InitializeComponent();
        }
        private void Cajas_Load(object sender, EventArgs e)
        {
            cargarCajas();
        }

        public void cargarCajas()
        {
            dtimpuestos.Rows.Clear();
            try
            {
                string strimpuestos;
                Module1.iniciarconexionempresa();

                strimpuestos = "select * from CajasSucursal";

                var ejec = new SqlCommand(strimpuestos);
                ejec.Connection = Module1.conexionempresa;
                string id, numero, valor, factor, tipo;

                var myreaderimpuestos = ejec.ExecuteReader();
                while (myreaderimpuestos.Read())
                {
                    id = Conversions.ToString(myreaderimpuestos["id"]);
                    numero = Conversions.ToString(myreaderimpuestos["nocaja"]);

                    dtimpuestos.Rows.Add(id, numero, Strings.FormatCurrency(myreaderimpuestos["Fondo"], 2), Strings.FormatCurrency(myreaderimpuestos["limite"], 2));
                }
                myreaderimpuestos.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.AgregarCaja.Show();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            cargarCajas();
        }
    }
}