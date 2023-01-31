using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class SolicitudesEmpeños
    {

        private object consultaSolicitudes;

        public SolicitudesEmpeños()
        {
            InitializeComponent();
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Solicitud_Boleta.Show();
        }

        private void Solicitudes_Load(object sender, EventArgs e)
        {
            Combofiltro.SelectedIndex = 0;
            foreach (DataRow row in Module1.dataPermisos.Rows)
            {
                if (Conversions.ToBoolean(row["SatiModSolicitudesVer"]))
                {
                    VerSolicitudToolStripMenuItem.Visible = true;
                    VerificarToolStripMenuItem.Visible = true;
                    SeguimientoToolStripMenuItem.Visible = true;
                    ToolStripMenuItem2.Visible = true;
                    VerSolicitudToolStripMenuItem.Visible = true;
                }
                else
                {
                    VerSolicitudToolStripMenuItem.Visible = false;
                    VerificarToolStripMenuItem.Visible = false;
                    SeguimientoToolStripMenuItem.Visible = false;
                    ToolStripMenuItem2.Visible = false;
                    VerSolicitudToolStripMenuItem.Visible = false;
                }


            }
            cargarSolicitudes();
        }
        public void cargarSolicitudes()
        {
            dtimpuestos.Rows.Clear();
            // Try
            string strimpuestos;
            Module1.iniciarconexionempresa();
            if (Module1.EmpleadoAsignado != 0)
            {

                strimpuestos = "select id,nombre,fecha,monto,estado,tipo, from Solicitudboleta inner join tipo where idpromotor = '" + Module1.EmpleadoAsignado + "'  order by nombre";
            }
            else
            {
                strimpuestos = "select id,nombre,fecha,monto,estado,tipo from Solicitudboleta order by nombre asc";
            }

            if (Combofiltro.Text == "Por Nombre")
            {

                if (Module1.EmpleadoAsignado != 0)
                {
                    consultaSolicitudes = @"select asce.id,asce.nombre,asce.Fecha,asce.MontoSugerido,asce.MontoAutorizado,asce.idTipoEmpeño,asce.nombretipo,promotores.Nombre as Promotor,asce.estado from
(select SolicitudBoleta.id,SolicitudBoleta.Nombre,SolicitudBoleta.Fecha,solicitudBoleta.estado,SolicitudBoleta.MontoSugerido,SolicitudBoleta.MontoAutorizado,SolicitudBoleta.idTipoEmpeño,TiposDeEmpeño.Nombre as nombretipo,SolicitudBoleta.IdPromotor, from SolicitudBoleta inner join TiposDeEmpeño on SolicitudBoleta.idTipoEmpeño = TiposDeEmpeño.id where solicitudBoleta.nombre like '%" + BunifuMaterialTextbox1.Text + "%' and ( solicitudBoleta.idpromotor = '" + Module1.EmpleadoAsignado + @"'  ) asce inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id";
                }
                // consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where nombre like '%" & BunifuMaterialTextbox1.Text & "%' and ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
                else
                {
                    consultaSolicitudes = @"select asce.id,asce.nombre,format(asce.Fecha,'yyyy-MM-dd')as fecha,asce.MontoSugerido,asce.MontoAutorizado,asce.idTipoEmpeño,asce.nombretipo,promotores.Nombre as Promotor,asce.estado from
(select SolicitudBoleta.id,SolicitudBoleta.Nombre,SolicitudBoleta.estado,SolicitudBoleta.Fecha,SolicitudBoleta.MontoSugerido,SolicitudBoleta.MontoAutorizado,SolicitudBoleta.idTipoEmpeño,TiposDeEmpeño.Nombre as nombretipo,SolicitudBoleta.IdPromotor from SolicitudBoleta inner join TiposDeEmpeño on SolicitudBoleta.idTipoEmpeño = TiposDeEmpeño.id where SolicitudBoleta.nombre like '%" + BunifuMaterialTextbox1.Text + @"%'  ) asce inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id order by asce.Nombre asc";
                    // consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where nombre like '%" & BunifuMaterialTextbox1.Text & "%' "
                }
            }

            var ejec = new SqlCommand(Conversions.ToString(consultaSolicitudes));
            ejec.Connection = Module1.conexionempresa;
            string id, nombre, valor;

            var myreaderimpuestos = ejec.ExecuteReader();
            while (myreaderimpuestos.Read())
            {
                id = Conversions.ToString(myreaderimpuestos["id"]);
                nombre = Conversions.ToString(myreaderimpuestos["nombre"]);
                if (myreaderimpuestos["MontoAutorizado"] is DBNull)
                {
                    valor = 0.ToString();
                }
                else
                {
                    valor = Conversions.ToString(myreaderimpuestos["MontoAutorizado"]);
                }
                dtimpuestos.Rows.Add(id, nombre, myreaderimpuestos["fecha"], Strings.FormatCurrency(myreaderimpuestos["Montosugerido"], 2), Strings.FormatCurrency(valor, 2), myreaderimpuestos["nombretipo"], myreaderimpuestos["promotor"], myreaderimpuestos["estado"], myreaderimpuestos["idtipoempeño"]);
            }
            myreaderimpuestos.Close();
            // Catch ex As Exception
            // MessageBox.Show(ex.Message)
            // End Try

        }

        private void VerificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.DatosSolicitudBoletaVerificar.idSolicitud = Conversions.ToInteger(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value);
            My.MyProject.Forms.DatosSolicitudBoletaVerificar.tipoSolicitud = Conversions.ToInteger(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[8].Value);
            My.MyProject.Forms.DatosSolicitudBoletaVerificar.Show();
        }


        private void dtimpuestos_SelectionChanged(object sender, EventArgs e)
        {
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[7].Value, "E", false)))
            {
                dtimpuestos.ContextMenuStrip = ContextMenuVerificar;
            }
            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[7].Value, "I", false)))
            {
                dtimpuestos.ContextMenuStrip = ContextMenuIncompleto;
            }
            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[7].Value, "A", false)))
            {
                dtimpuestos.ContextMenuStrip = ContextMenuAprobado;
            }
            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[7].Value, "R", false)))
            {
                dtimpuestos.ContextMenuStrip = ContextMenuAprobado;
            }

            else
            {

                dtimpuestos.ContextMenuStrip = null;

            }
        }

        private void SeguimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.DatosSolicitudBoleta.idSolicitud = Conversions.ToInteger(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value);
            My.MyProject.Forms.DatosSolicitudBoleta.tipoSolicitud = Conversions.ToInteger(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[8].Value);
            My.MyProject.Forms.DatosSolicitudBoleta.Show();
        }


        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Historia_de_Solicitud.idSolicitud = dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value;
            My.MyProject.Forms.Historia_de_Solicitud.esEmpeño = true;
            My.MyProject.Forms.Historia_de_Solicitud.Show();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            cargarSolicitudes();

        }


        private void VerSolicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.DatosSolicitudBoletaVerificar.idSolicitud = Conversions.ToInteger(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value);
            My.MyProject.Forms.DatosSolicitudBoletaVerificar.tipoSolicitud = Conversions.ToInteger(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[8].Value);
            My.MyProject.Forms.DatosSolicitudBoletaVerificar.verSolicitud = true;
            My.MyProject.Forms.DatosSolicitudBoletaVerificar.Show();
        }

        private void Combofiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Combofiltro.Text ?? "")
            {
                case "Por Nombre":
                    {
                        if (Module1.EmpleadoAsignado != 0)
                        {
                        }
                        // consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where nombre like '%" & BunifuMaterialTextbox1.Text & "%' and ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
                        else
                        {
                            // consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where nombre like '%" & BunifuMaterialTextbox1.Text & "%' "
                        }

                        break;
                    }

                case "Rechazadas":
                    {
                        if (Module1.EmpleadoAsignado != 0)
                        {
                            consultaSolicitudes = @"select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo,gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,solicitud.estado,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'R' and ( solicitud.idpromotor = '" + Module1.EmpleadoAsignado + "' or solicitud.idgestor = '" + Module1.EmpleadoAsignado + @"' ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id";
                        }
                        // consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'R' and ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
                        else
                        {
                            consultaSolicitudes = @"select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo,gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'R' ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id order by asce.nombre asc";
                            // consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'R' "
                        }
                        cargarSolicitudes();
                        break;
                    }
                case "Autorizadas":
                    {
                        if (Module1.EmpleadoAsignado != 0)
                        {
                            consultaSolicitudes = @"select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo,gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,solicitud.estado,Solicitud.Tipo,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'A' and ( solicitud.idpromotor = '" + Module1.EmpleadoAsignado + "' or solicitud.idgestor = '" + Module1.EmpleadoAsignado + @"' ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id";
                        }
                        // consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'A' and ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
                        else
                        {
                            consultaSolicitudes = @"select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo,gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'A' ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id order by asce.nombre asc";
                            // consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'A' "
                        }
                        cargarSolicitudes();
                        break;
                    }
                case "En Espera":
                    {
                        if (Module1.EmpleadoAsignado != 0)
                        {
                            consultaSolicitudes = @"select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo,gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'E' and ( solicitud.idpromotor = '" + Module1.EmpleadoAsignado + "' or solicitud.idgestor = '" + Module1.EmpleadoAsignado + @"' ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id";
                        }
                        // consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'E' and ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
                        else
                        {
                            consultaSolicitudes = @"select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo,gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'E'  ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id order by asce.nombre asc";
                            // consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'E' "
                        }
                        cargarSolicitudes();
                        break;
                    }
                case "Verificadas":
                    {
                        if (Module1.EmpleadoAsignado != 0)
                        {
                            consultaSolicitudes = @"select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo,gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'V' and ( solicitud.idpromotor = '" + Module1.EmpleadoAsignado + "' or solicitud.idgestor = '" + Module1.EmpleadoAsignado + @"' ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id";
                        }
                        // consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'V' and ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
                        else
                        {
                            consultaSolicitudes = @"select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo,gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'V'  ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id order by asce.nombre asc";
                            // consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'V' "

                        }
                        cargarSolicitudes();
                        break;
                    }
                case "Todas":
                    {
                        if (Module1.EmpleadoAsignado != 0)
                        {
                            consultaSolicitudes = @"select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo,gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where  ( solicitud.idpromotor = '" + Module1.EmpleadoAsignado + "' or solicitud.idgestor = '" + Module1.EmpleadoAsignado + @"' ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id";
                        }
                        // consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where  ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
                        else
                        {
                            consultaSolicitudes = @"select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo,gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id  ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id order by asce.Nombre asc";
                            // consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud "
                        }

                        cargarSolicitudes();
                        break;
                    }
                case "Incompletas":
                    {
                        if (Module1.EmpleadoAsignado != 0)
                        {
                            consultaSolicitudes = @"select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo,gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'I' and ( solicitud.idpromotor = '" + Module1.EmpleadoAsignado + "' or solicitud.idgestor = '" + Module1.EmpleadoAsignado + @"' ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id";
                        }
                        // consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'V' and ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
                        else
                        {
                            consultaSolicitudes = @"select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo,gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'I'  ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id order by asce.nombre asc";
                            // consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'V' "

                        }
                        cargarSolicitudes();
                        break;
                    }
            }
        }


        private void BunifuMaterialTextbox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cargarSolicitudes();
            }
        }

        private void VerHistoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Historia_de_Solicitud.idSolicitud = dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value;
            My.MyProject.Forms.Historia_de_Solicitud.esEmpeño = true;
            My.MyProject.Forms.Historia_de_Solicitud.Show();
        }
    }
}