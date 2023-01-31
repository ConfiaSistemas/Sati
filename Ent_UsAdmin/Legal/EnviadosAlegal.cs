using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class EnviadosAlegal
    {
        private DataSet dataGestores;
        private DataSet dataPromotores;
        private SqlDataAdapter adapterGestores;

        private SqlDataAdapter adapterPromotores;
        private DataTable dataConsulta;
        private SqlDataAdapter adapterConsulta;

        public EnviadosAlegal()
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
                            consulta = @"select repEnviadasLegal.id,repEnviadasLegal.Nombre,repEnviadasLegal.Credito,repEnviadasLegal.Moratorios,repEnviadasLegal.DeudaAP,repEnviadasLegal.Fecha,ISNULL((select nombre from empleados where id=repEnviadasLegal.idPromotor),'') as Promotor,ISNULL((select nombre from empleados where id=repEnviadasLegal.idGestor),'') as Gestor from
(select *,isnull((select idgestor from credito where id=lega.idcredito),0) as idgestor,isnull((select IdPromotor from credito where id=lega.idcredito),0) as idPromotor from
(select *,isnull((select id from credito where IdSolicitud = leg.idSolicitud),0) as idcredito from
(select legales.id,legales.Nombre,Legales.Credito,legales.Moratorios,legales.DeudaAP,legales.Fecha,legales.idSolicitud from legales  where legales.fecha between '" + Strings.Format(dateDesde.Value, "yyyy-MM-dd") + "' and '" + Strings.Format(dateHasta.Value, "yyyy-MM-dd") + "' )leg)lega)repEnviadasLegal";
                        }

                        else
                        {

                            // consulta = "select FechaEntrega,cred.id,cred.Nombre,format(cred.Monto,'C','es-mx') as Monto,format(cred.Pagare,'C','es-mx') as Pagaré,cred.Tipo,Gestores.Nombre as Gestor from
                            // (select FechaEntrega,Credito.id,credito.Nombre,Monto,Pagare,TiposDeCredito.Nombre as tipo,IdGestor from Credito inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id where credito.idgestor = '" & idEmpleado & "' and FechaEntrega != null and (FechaEntrega >= '" & Format(dateDesde.Value, "yyyy-MM-dd") & "' and FechaEntrega <= '" & Format(dateHasta.Value, "yyyy-MM-dd") & "')) cred inner join
                            // (select * from Empleados where Tipo = 'G') Gestores on cred.IdGestor = Gestores.id
                            // "
                            consulta = @"select repEnviadasLegal.id,repEnviadasLegal.Nombre,repEnviadasLegal.Credito,repEnviadasLegal.Moratorios,repEnviadasLegal.DeudaAP,repEnviadasLegal.Fecha,ISNULL((select nombre from empleados where id=repEnviadasLegal.idPromotor),'') as Promotor,ISNULL((select nombre from empleados where id=repEnviadasLegal.idGestor),'') as Gestor from
(select *,isnull((select idgestor from credito where id=lega.idcredito),0) as idgestor,isnull((select IdPromotor from credito where id=lega.idcredito),0) as idPromotor from
(select *,isnull((select id from credito where IdSolicitud = leg.idSolicitud),0) as idcredito from
(select legales.id,legales.Nombre,Legales.Credito,legales.Moratorios,legales.DeudaAP,legales.Fecha,legales.idSolicitud from legales  where legales.fecha between '" + Strings.Format(dateDesde.Value, "yyyy-MM-dd") + "' and '" + Strings.Format(dateHasta.Value, "yyyy-MM-dd") + "' )leg)lega)repEnviadasLegal where idgestor='"+ idEmpleado +"'";
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
                            consulta = @"select repEnviadasLegal.id,repEnviadasLegal.Nombre,repEnviadasLegal.Credito,repEnviadasLegal.Moratorios,repEnviadasLegal.DeudaAP,repEnviadasLegal.Fecha,ISNULL((select nombre from empleados where id=repEnviadasLegal.idPromotor),'') as Promotor,ISNULL((select nombre from empleados where id=repEnviadasLegal.idGestor),'') as Gestor from
(select *,isnull((select idgestor from credito where id=lega.idcredito),0) as idgestor,isnull((select IdPromotor from credito where id=lega.idcredito),0) as idPromotor from
(select *,isnull((select id from credito where IdSolicitud = leg.idSolicitud),0) as idcredito from
(select legales.id,legales.Nombre,Legales.Credito,legales.Moratorios,legales.DeudaAP,legales.Fecha,legales.idSolicitud from legales  where legales.fecha between '" + Strings.Format(dateDesde.Value, "yyyy-MM-dd") + "' and '" + Strings.Format(dateHasta.Value, "yyyy-MM-dd") + "' )leg)lega)repEnviadasLegal";
                        }
                        else
                        {
                            // consulta = "select FechaEntrega,cred.id,cred.Nombre,format(cred.Monto,'C','es-mx') as Monto,format(cred.Pagare,'C','es-mx') as Pagaré,cred.Tipo,Promotores.Nombre as Promotor from
                            // (select FechaEntrega,Credito.id,credito.Nombre,Monto,Pagare,TiposDeCredito.Nombre as tipo,IdPromotor from Credito inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id where credito.idpromotor = '" & idEmpleado & "' and FechaEntrega != null and (FechaEntrega >= '" & Format(dateDesde.Value, "yyyy-MM-dd") & "' and FechaEntrega <= '" & Format(dateHasta.Value, "yyyy-MM-dd") & "')) cred inner join
                            // (select * from Empleados where Tipo = 'P') Promotores on cred.IdPromotor = Promotores.id "
                            consulta = @"select repEnviadasLegal.id,repEnviadasLegal.Nombre,repEnviadasLegal.Credito,repEnviadasLegal.Moratorios,repEnviadasLegal.DeudaAP,repEnviadasLegal.Fecha,ISNULL((select nombre from empleados where id=repEnviadasLegal.idPromotor),'') as Promotor,ISNULL((select nombre from empleados where id=repEnviadasLegal.idGestor),'') as Gestor from
(select *,isnull((select idgestor from credito where id=lega.idcredito),0) as idgestor,isnull((select IdPromotor from credito where id=lega.idcredito),0) as idPromotor from
(select *,isnull((select id from credito where IdSolicitud = leg.idSolicitud),0) as idcredito from
(select legales.id,legales.Nombre,Legales.Credito,legales.Moratorios,legales.DeudaAP,legales.Fecha,legales.idSolicitud from legales  where legales.fecha between '" + Strings.Format(dateDesde.Value, "yyyy-MM-dd") + "' and '" + Strings.Format(dateHasta.Value, "yyyy-MM-dd") + "' )leg)lega)repEnviadasLegal where idpromotor='"+ idEmpleado +"'";
                        }

                        break;
                    }
                case "Todos":
                    {
                        // consulta = "select FechaEntrega,cred.id,cred.Nombre,format(cred.Monto,'C','es-mx') as Monto,format(cred.Pagare,'C','es-mx') as Pagaré,cred.Tipo,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor from
                        // (select FechaEntrega,Credito.id,credito.Nombre,Monto,Pagare,TiposDeCredito.Nombre as tipo,IdPromotor,IdGestor from Credito inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id  where FechaEntrega != null and (FechaEntrega >= '" & Format(dateDesde.Value, "yyyy-MM-dd") & "' and FechaEntrega <= '" & Format(dateHasta.Value, "yyyy-MM-dd") & "')) cred inner join
                        // (select * from Empleados where Tipo = 'G') Gestores on cred.IdGestor = Gestores.id inner join
                        // (select * from Empleados where Tipo = 'P') Promotores on cred.IdPromotor = Promotores.id"
                        consulta = @"select repEnviadasLegal.id,repEnviadasLegal.Nombre,repEnviadasLegal.Credito,repEnviadasLegal.Moratorios,repEnviadasLegal.DeudaAP,repEnviadasLegal.Fecha,ISNULL((select nombre from empleados where id=repEnviadasLegal.idPromotor),'') as Promotor,ISNULL((select nombre from empleados where id=repEnviadasLegal.idGestor),'') as Gestor from
(select *,isnull((select idgestor from credito where id=lega.idcredito),0) as idgestor,isnull((select IdPromotor from credito where id=lega.idcredito),0) as idPromotor from
(select *,isnull((select id from credito where IdSolicitud = leg.idSolicitud),0) as idcredito from
(select legales.id,legales.Nombre,Legales.Credito,legales.Moratorios,legales.DeudaAP,legales.Fecha,legales.idSolicitud from legales  where legales.fecha between '" + Strings.Format(dateDesde.Value, "yyyy-MM-dd") + "' and '" + Strings.Format(dateHasta.Value, "yyyy-MM-dd") + "' )leg)lega)repEnviadasLegal";
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
                totalEntregado +=Convert.ToDouble(row.Cells[2].Value);
                totalPagare += Convert.ToDouble(row.Cells[3].Value);
                totalEnviado += Convert.ToDouble(row.Cells[4].Value);

            }
            lblEntregado.Text = Strings.FormatCurrency(totalEntregado, 2);
            lblPagare.Text = Strings.FormatCurrency(totalPagare, 2);
            lblTotal.Text = Strings.FormatCurrency(totalEnviado, 2);
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