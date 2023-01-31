using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class EmpeñosActivos
    {
        private string strimpuestos;

        public EmpeñosActivos()
        {
            InitializeComponent();
        }
        private void EmpeñosActivos_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            cargarSolicitudes();
            txtnombre.Select();

        }
        public void cargarSolicitudes()
        {
            dtDatos.Rows.Clear();
            try
            {

                Module1.iniciarconexionempresa();

                strimpuestos = "select id,format(Fecha,'yyyy-MM-dd')as Fecha,Nombre,MontoPrestado,MontoRefrendo, format(FechaPrimerPago,'yyyy-MM-dd')as FechaPrimerPago, Estado from Empeños where (estado = 'A') and nombre like '%" + txtnombre.Text + "%' order by nombre asc";

                var ejec = new SqlCommand(strimpuestos);
                ejec.Connection = Module1.conexionempresa;
                string id, nombre;

                var myreaderimpuestos = ejec.ExecuteReader();
                while (myreaderimpuestos.Read())
                {
                    id = Conversions.ToString(myreaderimpuestos["id"]);
                    nombre = Conversions.ToString(myreaderimpuestos["nombre"]);

                    dtDatos.Rows.Add(id, myreaderimpuestos["fecha"], nombre, Strings.FormatCurrency(myreaderimpuestos["MontoPrestado"], 2), Strings.FormatCurrency(myreaderimpuestos["MontoRefrendo"], 2), myreaderimpuestos["FechaPrimerPago"], myreaderimpuestos["Estado"]);
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
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dtDatos.Rows[dtDatos.CurrentRow.Index].Cells[6].Value, "A", false)))
            {

                dtDatos.ContextMenuStrip = ContextMenuEntregar;
            }
            else
            {

                dtDatos.ContextMenuStrip = null;

            }
        }

        private void EntregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.EntregarDocumentacionEmpeño.idEmpeñoAentregar = Conversions.ToInteger(dtDatos.Rows[dtDatos.CurrentRow.Index].Cells[0].Value);
            My.MyProject.Forms.EntregarDocumentacionEmpeño.Show();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            cargarSolicitudes();
        }

        private void InformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmInformacion = new InformacionEmpeño();
            frmInformacion.idEmpeño = Conversions.ToInteger(dtDatos.Rows[dtDatos.CurrentRow.Index].Cells[0].Value);
            // InformacionSolicitud.idCredito = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
            // DatosConsultaSolicitud.TipoSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(5).Value
            frmInformacion.Show();
        }

        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cargarSolicitudes();
            }
        }
    }
}