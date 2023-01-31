using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class LegalTerminal
    {
        private string strimpuestos;

        public LegalTerminal()
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

                strimpuestos = "select legales.Id,legales.Fecha,legales.Nombre,legales.TotalDeuda,TiposDeCredito.Nombre as Tipo,Empleados.Nombre as Gestor,legales.Estado from legales inner join TiposDeCredito on legales.tipo = TiposDeCredito.id inner join Empleados on legales.idGestorLegal = Empleados.id where legales.Nombre like '%" + txtnombre.Text + "%' and (legales.estado = 'Z' or legales.estado = 'Y' or legales.estado = 'X') order by legales.Nombre asc ";

                var ejec = new SqlCommand(strimpuestos);
                ejec.Connection = Module1.conexionempresa;
                string id, nombre, estado ="";

                var myreaderimpuestos = ejec.ExecuteReader();
                while (myreaderimpuestos.Read())
                {
                    id = Conversions.ToString(myreaderimpuestos["id"]);
                    nombre = Conversions.ToString(myreaderimpuestos["nombre"]);
                    switch (myreaderimpuestos["Estado"].ToString() ?? "")
                    {
                        case "X":
                            {
                                estado = "Activo";
                                break;
                            }
                        case "Y":
                            {
                                estado = "Convenio";
                                break;
                            }
                        case "Z":
                            {
                                estado = "Liquidado";
                                break;
                            }
                    }

                    dtimpuestos.Rows.Add(id, myreaderimpuestos["fecha"], nombre, Strings.FormatCurrency(myreaderimpuestos["TotalDeuda"], 2), myreaderimpuestos["Tipo"], myreaderimpuestos["Gestor"], estado);
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
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[6].Value, "Activo", false)))
            {
                dtimpuestos.ContextMenuStrip = ContextMenuEntregar;
            }

            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[6].Value, "Convenio", false)))
            {
                dtimpuestos.ContextMenuStrip = ContextMenuInformacion;
            }
            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[6].Value, "Liquidado", false)))
            {
                dtimpuestos.ContextMenuStrip = ContextMenuInformacion;
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

    }
}