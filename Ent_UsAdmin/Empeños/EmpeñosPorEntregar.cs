using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class EmpeñosPorEntregar
    {
        public EmpeñosPorEntregar()
        {
            InitializeComponent();
        }
        private void CreditosPorEntregar_Load(object sender, EventArgs e)
        {
            cargarSolicitudes();
        }
        public void cargarSolicitudes()
        {
            dtimpuestos.Rows.Clear();
            try
            {
                string strimpuestos;
                Module1.iniciarconexionempresa();

                strimpuestos = "select id,format(Fecha,'yyyy-MM-dd')as Fecha,Nombre,MontoPrestado,MontoRefrendo,estado from Empeños where (Estado = 'E' or estado = 'P')";

                var ejec = new SqlCommand(strimpuestos);
                ejec.Connection = Module1.conexionempresa;
                string id, nombre, valor, factor, tipo;

                var myreaderimpuestos = ejec.ExecuteReader();
                while (myreaderimpuestos.Read())
                {
                    id = Conversions.ToString(myreaderimpuestos["id"]);
                    nombre = Conversions.ToString(myreaderimpuestos["nombre"]);

                    dtimpuestos.Rows.Add(id, myreaderimpuestos["fecha"], nombre, Strings.FormatCurrency(myreaderimpuestos["MontoPrestado"], 2), Strings.FormatCurrency(myreaderimpuestos["MontoRefrendo"], 2), myreaderimpuestos["Estado"], myreaderimpuestos["Estado"]);
                }
                myreaderimpuestos.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dtimpuestos_SelectionChanged(object sender, EventArgs e)
        {
            // If dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(5).Value = "1" Then
            dtimpuestos.ContextMenuStrip = ContextMenuEntregar;

            // Else

            // dtimpuestos.ContextMenuStrip = Nothing

            // End If
        }

        private void EntregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.EntregarDocumentacionEmpeño.idEmpeñoAentregar = Conversions.ToInteger(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value);
            My.MyProject.Forms.EntregarDocumentacionEmpeño.Show();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            cargarSolicitudes();
        }

    }
}