using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class CreditosActivos
    {
        private string strimpuestos;

        public CreditosActivos()
        {
            InitializeComponent();
        }
        private void CreditosPorEntregar_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            cargarSolicitudes();
            txtnombre.Select();
            foreach (DataRow row in Module1.dataPermisos.Rows)
            {
                if (Conversions.ToBoolean(row["SatiModCreditosCrearPromesa"]))
                {
                    PromesaDePagoToolStripMenuItem.Visible = true;
                }
                else
                {
                    PromesaDePagoToolStripMenuItem.Visible = false;
                }
            }
        }
        public async void cargarSolicitudes()
        {
            dtimpuestos.Rows.Clear();
            dtimpuestos.ScrollBars = ScrollBars.None;
            try
            {
                await Task.Factory.StartNew(() =>
                    {
                        Module1.iniciarconexionempresa();

                        strimpuestos = "select id,Fecha,Nombre,Monto,Plazo,format(fechaEntrega,'dd/MM/yyyy') as FechaEntrega,estado from credito where (estado = 'A' or estado = 'C' or estado = 'I' or estado = 'R' or estado ='V' or estado='Z') and nombre like '%" + txtnombre.Text + "%' order by nombre asc";

                        var ejec = new SqlCommand(strimpuestos);
                        ejec.Connection = Module1.conexionempresa;
                        string id, nombre;

                        var myreaderimpuestos = ejec.ExecuteReader();
                        while (myreaderimpuestos.Read())
                        {
                            id = Conversions.ToString(myreaderimpuestos["id"]);
                            nombre = Conversions.ToString(myreaderimpuestos["nombre"]);

                            dtimpuestos.Rows.Add(id, myreaderimpuestos["fecha"], nombre, Strings.FormatCurrency(myreaderimpuestos["Monto"], 2), myreaderimpuestos["Plazo"], myreaderimpuestos["FechaEntrega"], myreaderimpuestos["Estado"]);
                        }
                        myreaderimpuestos.Close();
                    });

                dtimpuestos.ScrollBars = ScrollBars.Both;
            }
            catch (Exception ex)
            {
                dtimpuestos.ScrollBars = ScrollBars.Both;
                MessageBox.Show(ex.Message);
            }

        }

        private void dtimpuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtimpuestos_SelectionChanged(object sender, EventArgs e)
        {
            if (DateTime.Now.Date <= Conversions.ToDate("2021-11-16"))
            {
                DescuentoBuenFinToolStripMenuItem.Visible = true;
            }
            else
            {
                DescuentoBuenFinToolStripMenuItem.Visible = false;

            }

            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[6].Value, "A", false)))
            {
                craToolStripMenuItem.Visible = false;
                CrearReestructuraToolStripMenuItem.Visible = false;
                CrearConvenioToolStripMenuItem.Visible = true;
                dtimpuestos.ContextMenuStrip = ContextMenuEntregar;
            }

            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[6].Value, "C", false)))
            {
                CrearReestructuraToolStripMenuItem.Visible = false;
                CrearConvenioToolStripMenuItem.Visible = false;
                craToolStripMenuItem.Visible = false;
                dtimpuestos.ContextMenuStrip = ContextMenuEntregar;
            }

            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[6].Value, "I", false)))
            {
                craToolStripMenuItem.Visible = false;
                CrearReestructuraToolStripMenuItem.Visible = true;
                CrearConvenioToolStripMenuItem.Visible = false;
                dtimpuestos.ContextMenuStrip = ContextMenuEntregar;
            }
            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[6].Value, "V", false)))
            {
               craToolStripMenuItem.Visible = true;
                CrearConvenioToolStripMenuItem.Visible = false;
                CrearReestructuraToolStripMenuItem.Visible = false;
                dtimpuestos.ContextMenuStrip = ContextMenuEntregar;
            }
            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[6].Value, "R", false)))
            {
                CrearReestructuraToolStripMenuItem.Visible = false;
                CrearConvenioToolStripMenuItem.Visible = false;
                craToolStripMenuItem.Visible = false;
                dtimpuestos.ContextMenuStrip = ContextMenuEntregar;
            }
            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[6].Value, "Z", false)))
            {
                CrearReestructuraToolStripMenuItem.Visible = false;
                CrearConvenioToolStripMenuItem.Visible = false;
                craToolStripMenuItem.Visible = false;
                dtimpuestos.ContextMenuStrip = ContextMenuEntregar;
            }

            else
            {

                dtimpuestos.ContextMenuStrip = null;

            }
        }

        private void EntregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.EntregarDocumentacion.idCreditoAentregar = Conversions.ToInteger(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value);
            My.MyProject.Forms.EntregarDocumentacion.Show();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            cargarSolicitudes();
        }

        private void InformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmInformacion = new InformacionSolicitud();
            frmInformacion.idCredito = Conversions.ToInteger(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value);
            // InformacionSolicitud.idCredito = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
            // DatosConsultaSolicitud.TipoSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(5).Value
            frmInformacion.Show();
        }

        private void CrearConvenioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.CrearConvenio.idCredito = Conversions.ToString(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value);
            My.MyProject.Forms.CrearConvenio.Show();
        }

        private void txtnombre_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cargarSolicitudes();
            }
        }

        private void MonoFlat_HeaderLabel1_Click(object sender, EventArgs e)
        {

        }

        private void EstadoDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.EstadoDeCuenta.idCredito = Conversions.ToInteger(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value);
            My.MyProject.Forms.EstadoDeCuenta.Show();
        }

        private void CrearReestructuraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.CrearReestructura.idCredito = Conversions.ToString(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value);
            My.MyProject.Forms.CrearReestructura.Show();
        }

        private void PromesaDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.PromPago.idCredito = Conversions.ToInteger(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value);
            My.MyProject.Forms.PromPago.estadoCredito = Conversions.ToString(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[6].Value);
            My.MyProject.Forms.PromPago.Show();

        }

        private void DescuentoBuenFinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.PromPagoBuenFin.idCredito = Conversions.ToInteger(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value);
            My.MyProject.Forms.PromPagoBuenFin.estadoCredito = Conversions.ToString(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[6].Value);
            My.MyProject.Forms.PromPagoBuenFin.Show();
        }

        private void craToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.CrearConvenioTerminal.idCredito = Conversions.ToString(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value);
            My.MyProject.Forms.CrearConvenioTerminal.Show();
        }
    }
}