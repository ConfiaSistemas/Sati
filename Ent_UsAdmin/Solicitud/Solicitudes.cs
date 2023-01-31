using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class Solicitudes
    {
        private object consultaSolicitudes;
        private DataTable dataSolicitudes;
        private SqlDataAdapter adapterSolicitudes;
        private string estadoFiltro;
        private string consultaEstado;
        private string consultaEmpleadoAsignado;

        public Solicitudes()
        {
            InitializeComponent();
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Levantar_Solicitud.Show();
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
                    ToolStripMenuItem1.Visible = true;
                    VerHistoriaToolStripMenuItem.Visible = true;
                    ToolStripMenuItem2.Visible = true;
                    VerSolicitudToolStripMenuItem.Visible = true;
                }
                else
                {
                    VerSolicitudToolStripMenuItem.Visible = false;
                    VerificarToolStripMenuItem.Visible = false;
                    SeguimientoToolStripMenuItem.Visible = false;
                    ToolStripMenuItem1.Visible = false;
                    VerHistoriaToolStripMenuItem.Visible = false;
                    ToolStripMenuItem2.Visible = false;
                    VerSolicitudToolStripMenuItem.Visible = false;
                }


            }
            cargarSolicitudes();
        }
        public async void cargarSolicitudes()
        {
            // dtimpuestos.Rows.Clear()
            dtimpuestos.DataSource = null;

            dtimpuestos.ScrollBars = ScrollBars.None;
            BunifuMaterialTextbox1.Enabled = false;
            BunifuThinButton22.Enabled = false;
            BunifuThinButton21.Enabled = false;
            Combofiltro.Enabled = false;
            Panel2.Visible = true;
            Panel2.BringToFront();
            // TransparentPanel1.Location = dtimpuestos.Location
            dtimpuestos.Visible = false;

            // TransparentPanel1.Size = dtimpuestos.Size

            Panel2.Location = new Point((int)Math.Round(Size.Width / 2d + Panel2.Width / 2d - 200d), (int)Math.Round(Height / 2d + Panel2.Height / 2d - 200d));

            await Task.Factory.StartNew(() => Invoke(new Action(() =>
{
string strimpuestos;
Module1.iniciarconexionempresa();
                // If EmpleadoAsignado <> 0 Then

                // strimpuestos = "select id,nombre,fecha,monto,estado,tipo, from Solicitud inner join tipo where idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "' order by nombre"
                // Else
                // strimpuestos = "select id,nombre,fecha,monto,estado,tipo from Solicitud order by nombre asc"
                // End If

                if (Combofiltro.Text == "Por Nombre")
{

if (Module1.EmpleadoAsignado != 0)
{
consultaSolicitudes = @"select top (200) asce.id,asce.nombre,asce.Fecha,Format(asce.Monto,'C','es-mx') as Monto,Format(asce.MontoAutorizado,'C','es-mx') as 'Monto Autorizado',asce.nombretipo as Tipo,asce.interes as 'Interés',asce.nombretipo,gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado,asce.tipo from
(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,solicitud.estado,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor,solicitud.interes from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.nombre like '%" + BunifuMaterialTextbox1.Text + "%' and ( solicitud.idpromotor = '" + Module1.EmpleadoAsignado + "' or solicitud.idgestor = '" + Module1.EmpleadoAsignado + @"' ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id order by 1 desc";
}
                    // consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where nombre like '%" & BunifuMaterialTextbox1.Text & "%' and ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
                    else
{
consultaSolicitudes = @"select top(200) asce.id,asce.nombre,asce.Fecha,Format(asce.Monto,'C','es-mx') as Monto,Format(asce.MontoAutorizado,'C','es-mx') as 'Monto Autorizado',asce.nombretipo as Tipo,Format(asce.interes,'C','es-mx') as 'Interés',gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.Estado,asce.tipo from
(select Solicitud.id,Solicitud.Nombre,solicitud.estado,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor,solicitud.interes from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.nombre like '%" + BunifuMaterialTextbox1.Text + @"%'  ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id order by asce.id desc";
                        // consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where nombre like '%" & BunifuMaterialTextbox1.Text & "%' "
                    }
}

                // Dim ejec = New SqlCommand(consultaSolicitudes)
                // ejec.Connection = conexionempresa
                // Dim id, nombre, valor, factor, tipo As String

                // Dim myreaderimpuestos As SqlDataReader = ejec.ExecuteReader()
                // While myreaderimpuestos.Read
                // id = myreaderimpuestos("id")
                // nombre = myreaderimpuestos("nombre")
                // If IsDBNull(myreaderimpuestos("MontoAutorizado")) Then
                // valor = 0
                // Else
                // valor = myreaderimpuestos("MontoAutorizado")
                // End If
                // dtimpuestos.Rows.Add(id, nombre, myreaderimpuestos("fecha"), FormatCurrency(myreaderimpuestos("Monto"), 2), FormatCurrency(valor, 2), myreaderimpuestos("nombretipo"), myreaderimpuestos("gestor"), myreaderimpuestos("promotor"), myreaderimpuestos("estado"), myreaderimpuestos("tipo"))
                // End While
                // myreaderimpuestos.Close()
                adapterSolicitudes = new SqlDataAdapter(Conversions.ToString(consultaSolicitudes), Module1.conexionempresa);
dataSolicitudes = new DataTable();
adapterSolicitudes.Fill(dataSolicitudes);




})));
            dtimpuestos.DataSource = dataSolicitudes;
            dtimpuestos.Columns[10].Visible = false;

            // Try
            BunifuMaterialTextbox1.Enabled = true;
            BunifuThinButton22.Enabled = true;
            BunifuThinButton21.Enabled = true;
            Combofiltro.Enabled = true;
            dtimpuestos.Visible = true;
            Panel2.Visible = false;

            dtimpuestos.ScrollBars = ScrollBars.Both;
            // Catch ex As Exception
            // MessageBox.Show(ex.Message)
            // End Try

        }

        private void VerificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.DatosVerificacion.idSolicitud = Conversions.ToInteger(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value);
            My.MyProject.Forms.DatosVerificacion.tipoSolicitud = Conversions.ToInteger(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[10].Value);
            My.MyProject.Forms.DatosVerificacion.Show();
        }


        private void dtimpuestos_SelectionChanged(object sender, EventArgs e)
        {
            if (dtimpuestos.CurrentRow is null) { }
                else
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[9].Value, "E", false)))
            {
                dtimpuestos.ContextMenuStrip = ContextMenuVerificar;
            }
            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[9].Value, "I", false)))
            {
                dtimpuestos.ContextMenuStrip = ContextMenuIncompleto;
            }
            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[9].Value, "V", false)))
            {
                dtimpuestos.ContextMenuStrip = ContextMenuAprobacion;
            }
            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[9].Value, "A", false)))
            {
                dtimpuestos.ContextMenuStrip = ContextMenuAprobado;
            }
            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[9].Value, "R", false)))
            {
                dtimpuestos.ContextMenuStrip = ContextMenuAprobado;
            }
            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[9].Value, "N", false)))
            {
                dtimpuestos.ContextMenuStrip = ContextMenuIncompleto;
            }
            else
            {

                dtimpuestos.ContextMenuStrip = null;

            }
        }

        private void SeguimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.DatosSolicitud.idSolicitud = Conversions.ToInteger(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value);
            My.MyProject.Forms.DatosSolicitud.tipoSolicitud = Conversions.ToInteger(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[10].Value);
            My.MyProject.Forms.DatosSolicitud.nombreSolicitud = Conversions.ToString(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[1].Value);
            My.MyProject.Forms.DatosSolicitud.Show();
        }



        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.DatosAprobacion.idSolicitud = Conversions.ToInteger(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value);
            My.MyProject.Forms.DatosAprobacion.Show();
        }

        private void VerHistoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Historia_de_Solicitud.idSolicitud = dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value;
            My.MyProject.Forms.Historia_de_Solicitud.esEmpeño = false;
            My.MyProject.Forms.Historia_de_Solicitud.Show();
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Historia_de_Solicitud.idSolicitud = dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value;
            My.MyProject.Forms.Historia_de_Solicitud.esEmpeño = false;
            My.MyProject.Forms.Historia_de_Solicitud.Show();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            cargarSolicitudes();

        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void ContextMenuVerificar_Opening(object sender, CancelEventArgs e)
        {

        }

        private void VerSolicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.DatosConsultaSolicitud.idSolicitud = Conversions.ToInteger(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value);
            // DatosConsultaSolicitud.TipoSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(5).Value
            My.MyProject.Forms.DatosConsultaSolicitud.Show();
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
                        // If EmpleadoAsignado <> 0 Then
                        // '                    consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo AS tIPO,asce.interes as 'Interés',gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
                        // '(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,solicitud.estado,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor,solicitud.interes from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'R' and ( solicitud.idpromotor = '" & EmpleadoAsignado & "' or solicitud.idgestor = '" & EmpleadoAsignado & "' ) asce inner join
                        // '(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
                        // '(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id"
                        // '                    'consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'R' and ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
                        // '                Else
                        // '                    consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo as Tipo,asce.interes as 'Interés',gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
                        // '(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'R' ) asce inner join
                        // '(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
                        // '(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id order by asce.nombre asc"
                        // 'consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'R' "
                        // End If
                        consultaEstado = "where Estado ='R'";
                        break;
                    }


                case "Autorizadas":
                    {
                        // If EmpleadoAsignado <> 0 Then
                        // consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo as Tipo,asce.interes as 'Interés',gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
                        // (select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,solicitud.estado,Solicitud.Tipo,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor,solicitud.interes from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'A' and ( solicitud.idpromotor = '" & EmpleadoAsignado & "' or solicitud.idgestor = '" & EmpleadoAsignado & "' ) asce inner join
                        // (select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
                        // (select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id"
                        // 'consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'A' and ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
                        // Else
                        // consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo as Tipo,asce.interes as 'Interés',gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
                        // (select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor,solicitud.interes from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'A' ) asce inner join
                        // (select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
                        // (select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id order by asce.nombre asc"
                        // 'consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'A' "
                        // End If
                        consultaEstado = "where Estado ='A'";
                        break;
                    }

                case "En Espera":
                    {
                        // If EmpleadoAsignado <> 0 Then
                        // consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo as Tipo,asce.interes as 'Interés',gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
                        // (select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor,solicitud.interes from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'E' and ( solicitud.idpromotor = '" & EmpleadoAsignado & "' or solicitud.idgestor = '" & EmpleadoAsignado & "' ) asce inner join
                        // (select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
                        // (select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id"
                        // ' consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'E' and ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
                        // Else
                        // consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo as Tipo,asce.interes as 'Interés',gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
                        // (select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor,solicitud.interes from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'E'  ) asce inner join
                        // (select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
                        // (select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id order by asce.nombre asc"
                        // 'consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'E' "
                        // End If
                        consultaEstado = "where Estado ='E'";
                        break;
                    }

                case "Verificadas":
                    {
                        // If EmpleadoAsignado <> 0 Then
                        // consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo as Tipo,asce.interes as 'Interés',gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
                        // (select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor,solicitud.interes from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'V' and ( solicitud.idpromotor = '" & EmpleadoAsignado & "' or solicitud.idgestor = '" & EmpleadoAsignado & "' ) asce inner join
                        // (select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
                        // (select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id"
                        // 'consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'V' and ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
                        // Else
                        // consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo as Tipo,asce.interes as 'Interés',gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
                        // (select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor,solicitud.interes from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'V'  ) asce inner join
                        // (select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
                        // (select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id order by asce.nombre asc"
                        // ' consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'V' "

                        // End If
                        consultaEstado = "where Estado ='V'";
                        break;
                    }

                case "Todas":
                    {
                        // If EmpleadoAsignado <> 0 Then
                        // consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo as Tipo,asce.interes as 'Interés',gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
                        // (select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor,solicitud.interes from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where  ( solicitud.idpromotor = '" & EmpleadoAsignado & "' or solicitud.idgestor = '" & EmpleadoAsignado & "' ) asce inner join
                        // (select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
                        // (select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id"
                        // ' consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where  ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
                        // Else
                        // consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo as Tipo,gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
                        // (select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor,solicitud.interes from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id  ) asce inner join
                        // (select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
                        // (select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id order by asce.Nombre asc"
                        // 'consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud "
                        // End If
                        consultaEstado = "";
                        break;
                    }


                case "Incompletas":
                    {
                        // If EmpleadoAsignado <> 0 Then
                        // consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo as Tipo,asce.interes as 'Interés',gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
                        // (select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor,solicitud.interes from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'I' and ( solicitud.idpromotor = '" & EmpleadoAsignado & "' or solicitud.idgestor = '" & EmpleadoAsignado & "' ) asce inner join
                        // (select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
                        // (select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id"
                        // 'consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'V' and ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
                        // Else
                        // consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo as Tipo,asce.interes as 'Interés',gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
                        // (select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor,solicitud.interes from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'I'  ) asce inner join
                        // (select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
                        // (select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id order by asce.nombre asc"
                        // ' consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'V' "

                        // End If

                        consultaEstado = "where Estado ='I'";
                        break;
                    }


            }
            if (Module1.EmpleadoAsignado != 0)
            {
                consultaEmpleadoAsignado = "  where  ( solicitud.idpromotor = '" + Module1.EmpleadoAsignado + "' or solicitud.idgestor = '" + Module1.EmpleadoAsignado + "' ) ";
            }
            else
            {
                consultaEmpleadoAsignado = "";
            }
            consultaSolicitudes = @"select asce.id,asce.nombre,asce.Fecha,Format(asce.Monto,'C','es-mx') as Monto,Format(asce.MontoAutorizado,'C','es-mx') as 'Monto Autorizado',asce.nombretipo as Tipo,Format(asce.interes,'C','es-mx') as 'Interés',gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.Estado,asce.tipo from
(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor,solicitud.interes from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id " + consultaEmpleadoAsignado + @"  ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id " + consultaEstado + " order  by asce.nombre asc";
            cargarSolicitudes();
            // If estadoFiltro <> "" Then
        }

        private void BunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void BunifuMaterialTextbox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cargarSolicitudes();
            }
        }

        private void BackgroundExcel_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.nuevolibro();
            Module1.GridAExcel(dtimpuestos);
        }

        private void BackgroundExcel_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();
            Module1.cerrarlibro();
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Exportando a Excel";
            BackgroundExcel.RunWorkerAsync();

        }

        private void dtimpuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReenviarCorreoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.DatosSolicitudReenviarCorreo.idSolicitud = Conversions.ToInteger(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value);
            // DatosConsultaSolicitud.TipoSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(5).Value
            My.MyProject.Forms.DatosSolicitudReenviarCorreo.Show();
        }
    }
}