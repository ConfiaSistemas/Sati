using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class CreditosEnLegal
    {
        private string strimpuestos;

        public CreditosEnLegal()
        {
            InitializeComponent();
        }
        private void CreditosPorEntregar_Load(object sender, EventArgs e)
        {
            foreach (DataRow row in Module1.dataPermisos.Rows)
            {
                if (Conversions.ToBoolean(row["SatiModLegalConvenio"]))
                {
                    EntregarToolStripMenuItem.Visible = true;
                    break;
                }
                else
                {
                    EntregarToolStripMenuItem.Visible = false;
                    break;
                }


            }

            foreach (DataRow row in Module1.dataPermisos.Rows)
            {
                if (Conversions.ToBoolean(row["SatiModLegalVer"]))
                {
                    InformacionToolStripMenuItem.Visible = true;
                    ToolStripMenuItem2.Visible = true;
                    break;
                }
                else
                {
                    ToolStripMenuItem2.Visible = false;
                    InformacionToolStripMenuItem.Visible = false;
                    break;
                }


            }

            cargarSolicitudes();
            txtnombre.Select();
        }
        public void cargarSolicitudes()
        {
            dtimpuestos.Rows.Clear();
            try
            {

                Module1.iniciarconexionempresa();

                strimpuestos = "select legales.Id,legales.Fecha,legales.Nombre,legales.TotalDeuda,TiposDeCredito.Nombre as Tipo,Empleados.Nombre as Gestor,legales.Estado from legales inner join TiposDeCredito on legales.tipo = TiposDeCredito.id inner join Empleados on legales.idGestorLegal = Empleados.id where legales.Nombre like '%" + txtnombre.Text + "%' order by legales.Nombre asc ";

                var ejec = new SqlCommand(strimpuestos);
                ejec.Connection = Module1.conexionempresa;
                string id, nombre;

                var myreaderimpuestos = ejec.ExecuteReader();
                while (myreaderimpuestos.Read())
                {
                    id = Conversions.ToString(myreaderimpuestos["id"]);
                    nombre = Conversions.ToString(myreaderimpuestos["nombre"]);

                    dtimpuestos.Rows.Add(id, myreaderimpuestos["fecha"], nombre, Strings.FormatCurrency(myreaderimpuestos["TotalDeuda"], 2), myreaderimpuestos["Tipo"], myreaderimpuestos["Gestor"], myreaderimpuestos["Estado"]);
                }
                myreaderimpuestos.Close();
            }
            catch (Exception ex)
            {
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
                dtimpuestos.ContextMenuStrip = ContextMenuEntregar;
                CrearPromesaDePagoToolStripMenuItem.Visible = false;
                EntregarToolStripMenuItem.Visible = true;
            }
            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[6].Value, "C", false)))
            {
                // dtimpuestos.ContextMenuStrip = ContextMenuInformacion
                dtimpuestos.ContextMenuStrip = ContextMenuEntregar;
                CrearPromesaDePagoToolStripMenuItem.Visible = true;
                EntregarToolStripMenuItem.Visible = false;
            }
            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[6].Value, "T", false)))
            {
                dtimpuestos.ContextMenuStrip = ContextMenuEntregar;
                CrearPromesaDePagoToolStripMenuItem.Visible = false;

                EntregarToolStripMenuItem.Visible = false;
            }
            else
            {



                dtimpuestos.ContextMenuStrip = null;

            }
        }

        private void EntregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.CrearConvenioLegal.idCreditoLegal = Conversions.ToString(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value);
            My.MyProject.Forms.CrearConvenioLegal.Show();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            cargarSolicitudes();
        }

        private void InformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmLegal = new InformacionLegal();
            frmLegal.idCredito = Conversions.ToInteger(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value);
            // InformacionLegal.idCredito = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
            // DatosConsultaSolicitud.TipoSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(5).Value
            frmLegal.Show();
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var frmLegal = new InformacionLegal();
            frmLegal.idCredito = Conversions.ToInteger(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value);
            // InformacionLegal.idCredito = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
            // DatosConsultaSolicitud.TipoSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(5).Value
            frmLegal.Show();
        }

        private void MonoFlat_HeaderLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtnombre_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void BunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            cargarSolicitudes();
        }

        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cargarSolicitudes();
            }
        }

        private void CrearPromesaDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.PromPagoLegal.idCredito = Conversions.ToInteger(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value);
            My.MyProject.Forms.PromPagoLegal.estadoCredito = "L";
            My.MyProject.Forms.PromPagoLegal.Show();
        }

        private void DescuentoBuenFinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.PromPagoLegalBuenFin.idCredito = Conversions.ToInteger(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value);
            My.MyProject.Forms.PromPagoLegalBuenFin.estadoCredito = "L";
            My.MyProject.Forms.PromPagoLegalBuenFin.Show();
        }
    }
}