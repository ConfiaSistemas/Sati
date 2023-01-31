using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Globalization;

namespace ConfiaAdmin
{

    public partial class CreditosPorEntregar
    {
        public CreditosPorEntregar()
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

                // strimpuestos = "select * from
                // (select SinEntregar.*,case when sinentregar.ciudad <> '" & CiudadEmpresa & "' and Ciudad <> '' and Ciudad <> '0' and Ciudad <> '-' then 1 else  isnull((select count(id) from ticket where idCredito = SinEntregar.id and TipoDoc = '2' and estado = 'A'),0) END as Cobrado from
                // (select credito.id,credito.Fecha,credito.Nombre,credito.Monto,credito.Plazo,credito.fechaEntrega,credito.estado,ISNULL((select Ciudad from DatosSolicitud where DatosSolicitud.IdSolicitud = Credito.IdSolicitud and DatosSolicitud.IdCliente = Credito.IdCliente),0) as Ciudad from credito  where (credito.Estado = 'E' or credito.estado = 'P') ) SinEntregar) ComisionCobrada where Cobrado = 1 "
                strimpuestos = @"select * from
(select SinEntregar.*,isnull((select count(id) from ticket where idCredito = SinEntregar.id and TipoDoc = '2' and Estado='A'),0) as Cobrado,isnull((select count(id) from ticket where idCredito = SinEntregar.id and TipoDoc = (select id from tipodoc where nombre='Enganche Motocicleta')),0) as EngancheCobrado from
(select credito.id,credito.Fecha,credito.Nombre,credito.Monto,credito.Plazo,TiposDeCredito.Moto,credito.Estado,tiposdecredito.Nombre as NombreTipo,ISNULL((select Ciudad from DatosSolicitud where DatosSolicitud.IdSolicitud = Credito.IdSolicitud and DatosSolicitud.IdCliente = Credito.IdCliente),0) as Ciudad from credito inner join tiposdecredito on credito.tipo = tiposdecredito.id where (credito.Estado = 'E' or credito.estado = 'P')) SinEntregar) ComisionCobrada where (case when Moto=0 then case when Cobrado=1 and EngancheCobrado=0 then 1 else 0 end else case when Cobrado=1 and EngancheCobrado=1 then 1 else 0 end end)=1
";
                var ejec = new SqlCommand(strimpuestos);
                ejec.Connection = Module1.conexionempresa;
                string id, nombre, valor, factor, tipo;

                var myreaderimpuestos = ejec.ExecuteReader();
                while (myreaderimpuestos.Read())
                {
                    id = Conversions.ToString(myreaderimpuestos["id"]);
                    nombre = Conversions.ToString(myreaderimpuestos["nombre"]);

                    dtimpuestos.Rows.Add(id, String.Format("yyyy-MM-dd", myreaderimpuestos["fecha"].ToString()), nombre, Strings.FormatCurrency(myreaderimpuestos["Monto"], 2), myreaderimpuestos["NombreTipo"], myreaderimpuestos["Plazo"], myreaderimpuestos["Cobrado"], myreaderimpuestos["Estado"], myreaderimpuestos["ciudad"]);
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
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[6].Value, "1", false)))
            {
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
    }
}