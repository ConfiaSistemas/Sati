using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class SolicitudesRechazadasCliente
    {
        public int Idcliente;
        public string tipoRechazo;

        public SolicitudesRechazadasCliente()
        {
            InitializeComponent();
        }
        private void SolicitudesRechazadasCliente_Load(object sender, EventArgs e)
        {
            cargarSolicitudes();

        }
        public void cargarSolicitudes()
        {
            dtimpuestos.Rows.Clear();
            try
            {
                string strimpuestos ="";
                Module1.iniciarconexionempresa();
                switch (tipoRechazo ?? "")
                {
                    case "R":
                        {
                            strimpuestos = "select Solicitud.id,solicitud.nombre,Fecha,solicitud.monto,Solicitud.Estado,solicitud.tipo from Solicitud inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud where DatosSolicitud.IdCliente = '" + Idcliente + "' and Solicitud.Estado = 'R' and Solicitud.Fecha >= DATEADD(MONTH,-4,GETDATE()) AND Solicitud.Fecha <= GETDATE()";
                            break;
                        }

                    case "DSR":
                        {
                            strimpuestos = "select Solicitud.id,solicitud.nombre,Fecha,solicitud.monto,Solicitud.Estado,solicitud.tipo from Solicitud inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud where DatosSolicitud.IdCliente = '" + Idcliente + "' and DatosSolicitud.Estado = 'R' and Solicitud.Fecha >= DATEADD(MONTH,-4,GETDATE()) AND Solicitud.Fecha <= GETDATE()";
                            break;
                        }
                }


                var ejec = new SqlCommand(strimpuestos);
                ejec.Connection = Module1.conexionempresa;
                string id, nombre, valor, factor, tipo;

                var myreaderimpuestos = ejec.ExecuteReader();
                while (myreaderimpuestos.Read())
                {
                    id = Conversions.ToString(myreaderimpuestos["id"]);
                    nombre = Conversions.ToString(myreaderimpuestos["nombre"]);

                    dtimpuestos.Rows.Add(id, nombre, myreaderimpuestos["fecha"], Strings.FormatCurrency(myreaderimpuestos["Monto"], 2), myreaderimpuestos["estado"], myreaderimpuestos["tipo"]);
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

        private void dtimpuestos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            My.MyProject.Forms.DatosConsultaSolicitud.idSolicitud = Conversions.ToInteger(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value);
            // DatosConsultaSolicitud.TipoSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(5).Value
            My.MyProject.Forms.DatosConsultaSolicitud.Show();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Module_resize.MoveForm(this);
            }
        }
    }
}