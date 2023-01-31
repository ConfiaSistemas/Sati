using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class impuestos
    {
        private string strimpuestos;

        public impuestos()
        {
            InitializeComponent();
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Agregar_Impuestos.Show();

        }




        public void cargarimpuestos()
        {
            dtimpuestos.Rows.Clear();
            try
            {

                Module1.iniciarconexionempresa();

                strimpuestos = @"select * from
(select id,concat(nombre, ' ',apellidopaterno,' ',apellidomaterno) as nombre from clientes)cli where cli.nombre like '%" + txtnombre.Text + "%' order by cli.nombre asc ";

                var ejec = new SqlCommand(strimpuestos);
                ejec.Connection = Module1.conexionempresa;
                string id, nombre, valor, factor, tipo;

                var myreaderimpuestos = ejec.ExecuteReader();
                while (myreaderimpuestos.Read())
                {
                    id = Conversions.ToString(myreaderimpuestos["id"]);
                    nombre = Conversions.ToString(myreaderimpuestos["nombre"]);

                    dtimpuestos.Rows.Add(id, nombre);
                }
                myreaderimpuestos.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void impuestos_Load(object sender, EventArgs e)
        {
            cargarimpuestos();
            txtnombre.Select();

        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            cargarimpuestos();
        }

        private void VerInformaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.InformacionCliente.idCLiente = Conversions.ToInteger(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value);

            My.MyProject.Forms.InformacionCliente.Show();
        }

        private void ContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void dtimpuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtimpuestos_SelectionChanged(object sender, EventArgs e)
        {
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[1].Value, "", false)))
            {
                dtimpuestos.ContextMenuStrip = ContextMenuStrip1;

            }
        }

        private void MonoFlat_Label1_Click(object sender, EventArgs e)
        {

        }

        private void txtnombre_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cargarimpuestos();
            }
        }

        private void ImprimirTarjetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.ImprimirTarjeta.idCredito = Conversions.ToString(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value);

            My.MyProject.Forms.ImprimirTarjeta.Show();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.ActualizarCliente.idCliente = Conversions.ToString(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value);

            My.MyProject.Forms.ActualizarCliente.Show();
        }
    }
}