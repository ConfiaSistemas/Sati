using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class Desembolsos
    {
        private DataSet dataGestores;
        private DataSet dataPromotores;
        private SqlDataAdapter adapterGestores;

        private SqlDataAdapter adapterPromotores;
        private DataTable dataConsulta;
        private SqlDataAdapter adapterConsulta;

        public Desembolsos()
        {
            InitializeComponent();
        }
        private void Desembolsos_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            ComboFiltro.SelectedIndex = 0;
            dateDesde.Value = DateTime.Now;
            dateHasta.Value = DateTime.Now;
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Información";
            My.MyProject.Forms.Cargando.TopMost = true;
            BackgroundGestores.RunWorkerAsync();

        }

        private void BackgroundGestores_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consulta;
            consulta = "Select id,nombre from empleados where tipo = 'G'";
            adapterGestores = new SqlDataAdapter(consulta, Module1.conexionempresa);
            dataGestores = new DataSet();
            adapterGestores.Fill(dataGestores);
        }

        private void BackgroundGestores_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BackgroundPromotores.RunWorkerAsync();

        }

        private void BackgroundPromotores_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consulta;
            consulta = "Select id,nombre from empleados where tipo = 'P'";
            adapterPromotores = new SqlDataAdapter(consulta, Module1.conexionempresa);
            dataPromotores = new DataSet();
            adapterPromotores.Fill(dataPromotores);
        }

        private void ComboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboFiltro.Text ?? "")
            {
                case "Todos":
                    {
                        // txtnombre.Enabled = False
                        ComboElección.Items.Clear();
                        ComboElección.Enabled = false;
                        break;
                    }
                case "Promotor":
                    {
                        // txtnombre.Enabled = True
                        ComboElección.Enabled = true;
                        ComboElección.Items.Clear();

                        ComboElección.Items.Add("Todos");
                        foreach (DataRow row in dataPromotores.Tables[0].Rows)

                            ComboElección.Items.Add(row["nombre"]);
                        ComboElección.SelectedIndex = 0;
                        break;
                    }
                case "Gestor":
                    {
                        // txtnombre.Enabled = True
                        ComboElección.Enabled = true;
                        ComboElección.Items.Clear();

                        ComboElección.Items.Add("Todos");
                        foreach (DataRow row in dataGestores.Tables[0].Rows)

                            ComboElección.Items.Add(row["nombre"]);
                        ComboElección.SelectedIndex = 0;
                        break;
                    }
            }
        }

        private void BackgroundPromotores_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();
        }

        private int ConsultarId(string nombre)
        {
            int idEmpleado =0;
            switch (ComboFiltro.Text ?? "")
            {
                case "Gestor":
                    {
                        foreach (DataRow row in dataGestores.Tables[0].Rows)
                        {
                            if ((row["nombre"].ToString() ?? "") == (ComboElección.Text ?? ""))
                            {
                                idEmpleado = (int)Math.Round(Conversion.Val(row["id"].ToString()));
                                break;
                            }
                        }

                        break;
                    }
                case "Promotor":
                    {
                        foreach (DataRow row in dataPromotores.Tables[0].Rows)
                        {
                            if ((row["nombre"].ToString() ?? "") == (ComboElección.Text ?? ""))
                            {
                                idEmpleado = (int)Math.Round(Conversion.Val(row["id"].ToString()));
                                break;
                            }
                        }

                        break;
                    }


            }
            return idEmpleado;
        }

        private void BackgroundConsulta_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consulta="" ;

            int idEmpleado;
            idEmpleado = ConsultarId(ComboElección.Text);
            switch (ComboFiltro.Text ?? "")
            {
                case "Gestor":
                    {
                        if (ComboElección.Text == "Todos")
                        {
                            // consulta = "select FechaEntrega,cred.id,cred.Nombre,format(cred.Monto,'C','es-mx') as Monto,format(cred.Pagare,'C','es-mx') as Pagaré,cred.Tipo,Gestores.Nombre as Gestor from
                            // (select FechaEntrega,Credito.id,credito.Nombre,Monto,Pagare,TiposDeCredito.Nombre as tipo,IdGestor from Credito inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id  where FechaEntrega != null and (FechaEntrega >= '" & Format(dateDesde.Value, "yyyy-MM-dd") & "' and FechaEntrega <= '" & Format(dateHasta.Value, "yyyy-MM-dd") & "')) cred inner join
                            // (select * from Empleados where Tipo = 'G') Gestores on cred.IdGestor = Gestores.id
                            // "
                            consulta = @"select FechaEntrega,id,Nombre,Monto,Pagaré,Tipo,Gestor,Promotor,case when CanCreditos > 1 then 'Renovación' else 'Nuevo' end as 'Nuevo o Renovación' from
(select FechaEntrega,cred.id,cred.Nombre,format(cred.Monto,'C','es-mx') as Monto,format(cred.Pagare,'C','es-mx') as Pagaré,cred.Tipo,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,
isnull((select COUNT(id) from Credito where IdCliente = cred.IdCliente and cred.Estado not in ( 'E'),0) as CanCreditos from
(select FechaEntrega,Credito.id,credito.Nombre,Monto,Pagare,TiposDeCredito.Nombre as tipo,IdPromotor,IdGestor,IdCliente,Estado from Credito inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id  
where FechaEntrega is not null and (FechaEntrega >= '" + Strings.Format(dateDesde.Value, "yyyy-MM-dd") + "' and FechaEntrega <= '" + Strings.Format(dateHasta.Value, "yyyy-MM-dd") + @"')) cred inner join
(select * from Empleados where Tipo = 'G') Gestores on cred.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on cred.IdPromotor = Promotores.id) desembolsos";
                        }

                        else
                        {

                            // consulta = "select FechaEntrega,cred.id,cred.Nombre,format(cred.Monto,'C','es-mx') as Monto,format(cred.Pagare,'C','es-mx') as Pagaré,cred.Tipo,Gestores.Nombre as Gestor from
                            // (select FechaEntrega,Credito.id,credito.Nombre,Monto,Pagare,TiposDeCredito.Nombre as tipo,IdGestor from Credito inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id where credito.idgestor = '" & idEmpleado & "' and FechaEntrega != null and (FechaEntrega >= '" & Format(dateDesde.Value, "yyyy-MM-dd") & "' and FechaEntrega <= '" & Format(dateHasta.Value, "yyyy-MM-dd") & "')) cred inner join
                            // (select * from Empleados where Tipo = 'G') Gestores on cred.IdGestor = Gestores.id
                            // "
                            consulta = @"select FechaEntrega,id,Nombre,Monto,Pagaré,Tipo,Gestor,Promotor,case when CanCreditos > 1 then 'Renovación' else 'Nuevo' end as 'Nuevo o Renovación' from
(select FechaEntrega,cred.id,cred.Nombre,format(cred.Monto,'C','es-mx') as Monto,format(cred.Pagare,'C','es-mx') as Pagaré,cred.Tipo,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,isnull((select COUNT(id) from Credito where IdCliente = cred.IdCliente and cred.Estado <> 'E'),0) as CanCreditos from
(select FechaEntrega,Credito.id,credito.Nombre,Monto,Pagare,TiposDeCredito.Nombre as tipo,IdPromotor,IdGestor,IdCliente,Estado from Credito inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id  where credito.idgestor = '" + idEmpleado + "' and FechaEntrega is not null and (FechaEntrega >= '" + Strings.Format(dateDesde.Value, "yyyy-MM-dd") + "' and FechaEntrega <= '" + Strings.Format(dateHasta.Value, "yyyy-MM-dd") + @"')) cred inner join
(select * from Empleados where Tipo = 'G') Gestores on cred.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on cred.IdPromotor = Promotores.id) desembolsos";
                        }

                        break;
                    }
                case "Promotor":
                    {
                        if (ComboElección.Text == "Todos")
                        {
                            // consulta = "select FechaEntrega,cred.id,cred.Nombre,format(cred.Monto,'C','es-mx') as Monto,format(cred.Pagare,'C','es-mx') as Pagaré,cred.Tipo,Promotores.Nombre as Promotor from
                            // (select FechaEntrega,Credito.id,credito.Nombre,Monto,Pagare,TiposDeCredito.Nombre as tipo,IdPromotor from Credito inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id where FechaEntrega != null and (FechaEntrega >= '" & Format(dateDesde.Value, "yyyy-MM-dd") & "' and FechaEntrega <= '" & Format(dateHasta.Value, "yyyy-MM-dd") & "')) cred inner join
                            // (select * from Empleados where Tipo = 'P') Promotores on cred.IdPromotor = Promotores.id "
                            consulta = @"select FechaEntrega,id,Nombre,Monto,Pagaré,Tipo,Gestor,Promotor,case when CanCreditos > 1 then 'Renovación' else 'Nuevo' end as 'Nuevo o Renovación' from
(select FechaEntrega,cred.id,cred.Nombre,format(cred.Monto,'C','es-mx') as Monto,format(cred.Pagare,'C','es-mx') as Pagaré,cred.Tipo,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,isnull((select COUNT(id) from Credito where IdCliente = cred.IdCliente and cred.Estado <> 'E'),0) as CanCreditos from
(select FechaEntrega,Credito.id,credito.Nombre,Monto,Pagare,TiposDeCredito.Nombre as tipo,IdPromotor,IdGestor,IdCliente,Estado from Credito inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id  where FechaEntrega is not null and (FechaEntrega >= '" + Strings.Format(dateDesde.Value, "yyyy-MM-dd") + "' and FechaEntrega <= '" + Strings.Format(dateHasta.Value, "yyyy-MM-dd") + @"')) cred inner join
(select * from Empleados where Tipo = 'G') Gestores on cred.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on cred.IdPromotor = Promotores.id) desembolsos";
                        }
                        else
                        {
                            // consulta = "select FechaEntrega,cred.id,cred.Nombre,format(cred.Monto,'C','es-mx') as Monto,format(cred.Pagare,'C','es-mx') as Pagaré,cred.Tipo,Promotores.Nombre as Promotor from
                            // (select FechaEntrega,Credito.id,credito.Nombre,Monto,Pagare,TiposDeCredito.Nombre as tipo,IdPromotor from Credito inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id where credito.idpromotor = '" & idEmpleado & "' and FechaEntrega != null and (FechaEntrega >= '" & Format(dateDesde.Value, "yyyy-MM-dd") & "' and FechaEntrega <= '" & Format(dateHasta.Value, "yyyy-MM-dd") & "')) cred inner join
                            // (select * from Empleados where Tipo = 'P') Promotores on cred.IdPromotor = Promotores.id "
                            consulta = @"select FechaEntrega,id,Nombre,Monto,Pagaré,Tipo,Gestor,Promotor,case when CanCreditos > 1 then 'Renovación' else 'Nuevo' end as 'Nuevo o Renovación' from
(select FechaEntrega,cred.id,cred.Nombre,format(cred.Monto,'C','es-mx') as Monto,format(cred.Pagare,'C','es-mx') as Pagaré,cred.Tipo,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,isnull((select COUNT(id) from Credito where IdCliente = cred.IdCliente and cred.Estado <> 'E'),0) as CanCreditos from
(select FechaEntrega,Credito.id,credito.Nombre,Monto,Pagare,TiposDeCredito.Nombre as tipo,IdPromotor,IdGestor,IdCliente,Estado from Credito inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id  where credito.idpromotor = '" + idEmpleado + "' and  FechaEntrega is not null and (FechaEntrega >= '" + Strings.Format(dateDesde.Value, "yyyy-MM-dd") + "' and FechaEntrega <= '" + Strings.Format(dateHasta.Value, "yyyy-MM-dd") + @"')) cred inner join
(select * from Empleados where Tipo = 'G') Gestores on cred.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on cred.IdPromotor = Promotores.id) desembolsos";
                        }

                        break;
                    }
                case "Todos":
                    {
                        // consulta = "select FechaEntrega,cred.id,cred.Nombre,format(cred.Monto,'C','es-mx') as Monto,format(cred.Pagare,'C','es-mx') as Pagaré,cred.Tipo,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor from
                        // (select FechaEntrega,Credito.id,credito.Nombre,Monto,Pagare,TiposDeCredito.Nombre as tipo,IdPromotor,IdGestor from Credito inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id  where FechaEntrega != null and (FechaEntrega >= '" & Format(dateDesde.Value, "yyyy-MM-dd") & "' and FechaEntrega <= '" & Format(dateHasta.Value, "yyyy-MM-dd") & "')) cred inner join
                        // (select * from Empleados where Tipo = 'G') Gestores on cred.IdGestor = Gestores.id inner join
                        // (select * from Empleados where Tipo = 'P') Promotores on cred.IdPromotor = Promotores.id"
                        consulta = @"select FechaEntrega,id,Nombre,Monto,Pagaré,Tipo,Gestor,Promotor,case when CanCreditos > 1 then 'Renovación' else 'Nuevo' end as 'Nuevo o Renovación' from
(select FechaEntrega,cred.id,cred.Nombre,format(cred.Monto,'C','es-mx') as Monto,format(cred.Pagare,'C','es-mx') as Pagaré,cred.Tipo,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,isnull((select COUNT(id) from Credito where IdCliente = cred.IdCliente and cred.Estado <> 'E'),0) as CanCreditos from
(select FechaEntrega,Credito.id,credito.Nombre,Monto,Pagare,TiposDeCredito.Nombre as tipo,IdPromotor,IdGestor,IdCliente,Estado from Credito inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id  where FechaEntrega is not null and (FechaEntrega >= '" + Strings.Format(dateDesde.Value, "yyyy-MM-dd") + "' and FechaEntrega <= '" + Strings.Format(dateHasta.Value, "yyyy-MM-dd") + @"')) cred inner join
(select * from Empleados where Tipo = 'G') Gestores on cred.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on cred.IdPromotor = Promotores.id) desembolsos";
                        break;
                    }
            }


            adapterConsulta = new SqlDataAdapter(consulta, Module1.conexionempresa);
            dataConsulta = new DataTable();
            adapterConsulta.Fill(dataConsulta);
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            BunifuThinButton22.Enabled = false;
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Consultando";
            My.MyProject.Forms.Cargando.TopMost = true;
            BackgroundConsulta.RunWorkerAsync();
        }

        private void BackgroundConsulta_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtimpuestos.DataSource = dataConsulta;
            double totalEntregado = 0d;
            double totalPagare = 0d;
            double totalEnviado = 0;


            foreach (DataGridViewRow row in dtimpuestos.Rows)
            {
                totalEntregado = Conversions.ToDouble(Operators.AddObject(totalEntregado, row.Cells[3].Value));
                totalPagare = Conversions.ToDouble(Operators.AddObject(totalPagare, row.Cells[4].Value));

            }
            lblEntregado.Text = Strings.FormatCurrency(totalEntregado, 2);
            lblPagare.Text = Strings.FormatCurrency(totalPagare, 2);
            My.MyProject.Forms.Cargando.Close();
            BunifuThinButton22.Enabled = true;
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Exportando a Excel";
            My.MyProject.Forms.Cargando.TopMost = true;
            BackgroundExcel.RunWorkerAsync();
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

        private void dtimpuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Reportes.Panel1.Visible = false;
            My.MyProject.Forms.Reportes.RadPanorama1.Visible = true;
        }
    }
}