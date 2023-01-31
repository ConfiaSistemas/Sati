using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class CatTiposdeCredito
    {
        public CatTiposdeCredito()
        {
            InitializeComponent();
        }
        private void CatTiposdeCredito_Load(object sender, EventArgs e)
        {
            cargarTipos();
        }
        public void cargarTipos()
        {
            dtimpuestos.Rows.Clear();
            try
            {
                string strimpuestos;
                Module1.iniciarconexionempresa();

                strimpuestos = "select * from TiposDeCredito";

                var ejec = new SqlCommand(strimpuestos);
                ejec.Connection = Module1.conexionempresa;
                string id, nombre, Modalidad, Tipo, Plazo;

                var myreaderimpuestos = ejec.ExecuteReader();
                while (myreaderimpuestos.Read())
                {
                    id = Conversions.ToString(myreaderimpuestos["id"]);
                    nombre = Conversions.ToString(myreaderimpuestos["nombre"]);
                    Modalidad = Conversions.ToString(myreaderimpuestos["Modalidad"]);
                    Tipo = Conversions.ToString(myreaderimpuestos["Tipo"]);
                    Plazo = Conversions.ToString(myreaderimpuestos["Plazo"]);
                    dtimpuestos.Rows.Add(id, nombre, Modalidad, Tipo, Plazo);

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
            My.MyProject.Forms.AgregarTipoCredito.Show();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            cargarTipos();
        }

        private void dtimpuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtimpuestos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            My.MyProject.Forms.DocumentosNecesarios.idTipo = Conversions.ToInteger(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value);
            My.MyProject.Forms.DocumentosNecesarios.Show();

        }
    }
}