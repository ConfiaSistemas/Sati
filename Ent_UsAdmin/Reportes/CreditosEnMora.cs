using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class CreditosEnMora
    {
        private Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
        private DataSet dataGestores;
        private DataSet dataPromotores;
        private SqlDataAdapter adapterGestores;
        private double widthEmpresa = 0;
        private double heightEmpresa = 0;
        private SqlDataAdapter adapterPromotores;
        private DataTable dataConsulta;
        private SqlDataAdapter adapterConsulta;
        public ArrayList arrayEmpresas = new ArrayList();
        private bool chicoGrande = false;

        public CreditosEnMora()
        {
            InitializeComponent();
        }

        private void Desembolsos_Load(object sender, EventArgs e)
        {

            CheckForIllegalCrossThreadCalls = false;
            FlowEmpresas.Size = new Size(0, 0);
            ComboFiltro.SelectedIndex = 0;
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
                        lblFiltro.Visible = false;

                        // txtnombre.Enabled = False
                        ComboElección.Items.Clear();
                        ComboElección.Enabled = false;
                        break;
                    }
                case "Promotor":
                    {
                        lblFiltro.Visible = true;
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
                        lblFiltro.Visible = true;
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
            BackgroundEmpresas.RunWorkerAsync();

        }

        private int ConsultarId(string nombre)
        {
            int idEmpleado=0;
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
            string consulta = @"select creditos_en_mora.* from
(select carteraVencida.id, carteravencida.nombre as Nombre,format(pagare,'C','es-mx') as Pagaré,format(PagoSemanal,'C','es-mx') as 'Pago Semanal',format(AbonadoSinMultas,'C','es-mx') as 'Abonado sin multas',format(Multas,'C','es-mx') as Multas,format(AbonadoMultas,'C','es-mx') as 'Multas abonadas',format(multasPendientes,'C','es-mx') as 'Multas pendientes',format(VencidoNormal,'C','es-mx') as 'Vencido normal',format(TotalPendiente,'C','es-mx') as 'Total Pendiente',Pagos_atrasados as 'Pagos atrasados',FechaDeAtraso as 'Fecha del último abono',
case when FechaDeAtraso = 'Nunca' then
	(case when carteraVencida.Estado = 'C' then
	datediff(day,(select top 1 fechapago from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where Abonado < (monto+interes) and ConveniosSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	when carteraVencida.Estado = 'R' then
	datediff(day,(select top 1 fechapago from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where Abonado < (monto+interes) and ReestructurasSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	else 
	datediff(day,(select top 1 fechapago from CalendarioNormal where Abonado < (monto+interes) and id_credito = carteraVencida.id order by FechaPago asc),GETDATE())
	end)
else (case when carteraVencida.Estado = 'C' then
	datediff(day,(select top 1 fechapago from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where Abonado < (monto+interes) and ConveniosSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	when carteraVencida.Estado = 'R' then
	datediff(day,(select top 1 fechapago from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where Abonado < (monto+interes) and ReestructurasSac.idCredito = carteraVencida.id order by FechaPago asc),GETDATE())
	else 
	datediff(day,(select top 1 fechapago from CalendarioNormal where Abonado < (monto+interes) and id_credito = carteraVencida.id order by FechaPago asc),GETDATE())
	end)
end as Diasdeatraso,
format(((pagare - AbonadoSinMultas) + multasPendientes),'C','es-mx') as 'Liquida con',DatosSolicitud.Telefono,DatosSolicitud.Celular,(DatosSolicitud.Calle + ', ' + DatosSolicitud.Noext + ', ' + DatosSolicitud.Colonia ) as Domicilio,Promotor,Gestor,carteravencida.Estado from 
(select nombre,id,pagare,PagoSemanal,AbonadoSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,
 case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.Estado = 'R' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Promotor,Estado,Pagos_atrasados,IdSolicitud,FechaDeAtraso from
(select Cartera.nombre,Cartera.id,
case when Cartera.Estado = 'C' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where Abonado <> 0 and Abonado >= interes and conveniossac.idcredito = Cartera.id group by idcredito),0)
when Cartera.Estado = 'R' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where Abonado <> 0 and Abonado >= interes and ReestructurasSac.idcredito = Cartera.id group by idcredito),0)
else
isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id group by id_credito),0) end as AbonadoSinMultas,
case when Cartera.Estado = 'C' then
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idconvenio = ConveniosSac.id where CalendarioConveniosSac.estado = 'V' and Abonado <= CalendarioConveniosSac.Interes and ConveniosSac.idCredito =cartera.id group by CalendarioConveniosSac.idConvenio),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioConveniosSac.Interes) ))) )) as AbonadoInteres from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where CalendarioConveniosSac.estado = 'V' and Abonado >=CalendarioConveniosSac.Interes and ConveniosSac.idCredito =cartera.id group by CalendarioConveniosSac.idConvenio),0)),0)
--isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioConveniossac.estado = 'V' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0) 
when Cartera.Estado = 'R' then
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idconvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado <= CalendarioReestructurasSac.Interes and ReestructurasSac.idCredito =cartera.id group by CalendarioReestructurasSac.idConvenio),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioReestructurasSac.Interes) ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado >=CalendarioReestructurasSac.Interes and ReestructurasSac.idCredito =cartera.id group by CalendarioReestructurasSac.idConvenio),0)),0)
else
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)),0)end as AbonadoMultasV,
case when Cartera.Estado = 'C' then
isnull((select SUM(Abonado - CalendarioConveniossac.monto) as AbonadoMultas from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where  CalendarioConveniossac.estado = 'L' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(Abonado - CalendarioReestructurasSac.monto) as AbonadoMultas from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where  CalendarioReestructurasSac.estado = 'L' and ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L' and CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as AbonadoMultasL,
case when Cartera.Estado = 'C' THEN 
isnull((select SUM(CalendarioConveniossac.interes) as Multas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where  Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.interes) as Multas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where  ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(CalendarioNormal.interes) as Multas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as Multas,
case when cartera.Estado = 'C' THEN 
(select SUM(calendarioconveniossac.monto) from CalendarioConveniossac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(CalendarioReestructurasSac.monto) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where ReestructurasSac.idcredito = Cartera.id)
else
(select Pagare from credito where id = Cartera.id) end as pagare,
case when Cartera.Estado = 'C' then
(select COUNT(pendiente) AS Pagos_atrasados from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado = 'V' and Conveniossac.idcredito = cartera.id)
when Cartera.Estado = 'R' then
(select COUNT(pendiente) AS Pagos_atrasados from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = cartera.id)
 else
(select count(pendiente) as Pagos_atrasados from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id) end as Pagos_atrasados
,
case when Cartera.Estado = 'C' then
(select top 1 (monto + interes) as pagoNormal from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where Conveniossac.idcredito = Cartera.id and CalendarioConveniossac.Estado = 'V' )
else
(select PagoIndividual  as PagoNormal From Credito where id = Cartera.id)
end as PagoSemanal
,
case when Cartera.Estado = 'C' then
isnull((select SUM(calendarioconveniossac.pendiente) from CalendarioConveniossac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where calendarioconveniossac.Estado = 'V' and conveniossac.idcredito = Cartera.id),0)
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.pendiente) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
isnull(convert(varchar,(select top 1 CalendarioConveniosSac.Fecha from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniosSac.Fecha>'1900-01-01' and ConveniosSac.idCredito = Cartera.id order by CalendarioConveniosSac.Fecha desc),23),'Nunca')
when Cartera.Estado = 'R' then
isnull(convert(varchar,(select top 1 CalendarioReestructurasSac.Fecha from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Fecha>'1900-01-01' and ReestructurasSac.idCredito = Cartera.id order by CalendarioReestructurasSac.Fecha desc),23),'Nunca')
else
isnull(convert(varchar,(select top 1 FechaUltimoPago from CalendarioNormal where FechaUltimoPago>'1900-01-01' and CalendarioNormal.id_credito = Cartera.id order by FechaUltimoPago desc),23),'Nunca')
end as FechaDeAtraso,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado ='V' and Conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(interes) as MultasVencidas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado ='V' and ReestructurasSac.idcredito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado,Cartera.IdSolicitud,isnull((select id from promesadepago where idcredito = Cartera.id and estado = 'A' and tipocredito = cartera.estado),0) as prompago from
(select Credito.nombre,Credito.id,Credito.IdGestor,Credito.IdPromotor,Credito.Estado,Credito.IdSolicitud from CREDITO inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito  

where CalendarioNormal.Estado = 'V'  and Credito.Estado <> 'L' and Credito.Estado <> 'T' and Credito.Nombre like '%" + txtnombre.Text +@"% " ;

            int idEmpleado;
            idEmpleado = ConsultarId(ComboElección.Text);
            switch (ComboFiltro.Text ?? "")
            {
                case "Gestor":
                    {
                        if (ComboElección.Text != "Todos")
                        {
                            consulta = consulta + "and idgestor = '" + idEmpleado + @"'";
                        }

                        break;
                    }
                case "Promotor":
                    {
                        if (ComboElección.Text != "Todos")
                        {
                            consulta = consulta + " and idpromotor = '" + idEmpleado + @"'";
                        }
                        break;
                    }
            }


            consulta =consulta+ @"' 
group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado,Credito.monto,Credito.Interes,Credito.IdSolicitud) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal where prompago =0) carteraVencida inner join Solicitud on carteraVencida.IdSolicitud = Solicitud.id inner join DatosSolicitud on solicitud.id = DatosSolicitud.IdSolicitud where VencidoNormal <> 0)creditos_en_mora order by creditos_en_mora.nombre asc";

            adapterConsulta = new SqlDataAdapter(consulta, Module1.conexionempresa);
            dataConsulta = new DataTable();
            adapterConsulta.Fill(dataConsulta);
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            // BunifuThinButton22.Enabled = False
            // Cargando.Show()
            // Cargando.MonoFlat_Label1.Text = "Consultando"
            // Cargando.TopMost = True
            Panel2.Visible = true;
            Panel2.BringToFront();
            // TransparentPanel1.Location = dtimpuestos.Location
            TabControl1.Visible = false;

            // TransparentPanel1.Size = dtimpuestos.Size

            Panel2.Location = new Point((int)Math.Round(Size.Width / 2d + Panel2.Width / 2d - 200d), (int)Math.Round(Height / 2d + Panel2.Height / 2d - 200d));
            BackgroundConectarEmpresas.RunWorkerAsync();
        }

        private void BackgroundConsulta_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // dtimpuestos.DataSource = dataConsulta
            My.MyProject.Forms.Cargando.Close();
            BunifuThinButton22.Enabled = true;
            // txtnombre.Enabled = True
            // txtnombre.Select()
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
            nuevolibroMora();
            // For Each tabP As TabPage In TabControl1.TabPages
            foreach (Control ctrl in TabControl1.Controls)
            {
                var ctrldentro = ctrl;
                foreach (Control ctrldt in ctrldentro.Controls)
                {
                    if (ctrldt is Bunifu.Framework.UI.BunifuCustomDataGrid)
                    {

                        Bunifu.Framework.UI.BunifuCustomDataGrid dt = (Bunifu.Framework.UI.BunifuCustomDataGrid)ctrldt;
                        // MessageBox.Show(dt.Name)
                        // MessageBox.Show(dt.Rows.Count & " Filas antes")
                        GridAExcelMora(dt);


                    }
                }

            }
            // Next

        }

        private void BackgroundExcel_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();
            cerrarlibroMora();

        }

        private void CreditosEnMora_Resize(object sender, EventArgs e)
        {
            BunifuThinButton22.Location = new Point(ComboElección.Location.X + ComboElección.Width + 20, ComboElección.Location.Y);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Reportes.Panel1.Visible = false;
            My.MyProject.Forms.Reportes.RadPanorama1.Visible = true;
        }

        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // txtnombre.Enabled = False
                My.MyProject.Forms.Cargando.Show();
                My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Consultando";
                My.MyProject.Forms.Cargando.TopMost = true;
                BackgroundConsulta.RunWorkerAsync();
            }
        }

        private void dtimpuestos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // InformacionSolicitud.idCredito = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
            // InformacionSolicitud.Show()
        }

        private void BackgroundEmpresas_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexion();

            OleDbCommand comandoEmpresasPermitidas;

            string consultaEmpresasPermitidas;
            OleDbDataReader readerEmpresasPermitidas;
            consultaEmpresasPermitidas = "select id,nombre from empresas where id in (select idempresa from empresaspermitidas where idusuario = '" + Module1.idusr + "')";
            comandoEmpresasPermitidas = new OleDbCommand();
            comandoEmpresasPermitidas.Connection = Module1.conexion;
            comandoEmpresasPermitidas.CommandText = consultaEmpresasPermitidas;
            readerEmpresasPermitidas = comandoEmpresasPermitidas.ExecuteReader();
            if (readerEmpresasPermitidas.HasRows)
            {

                while (readerEmpresasPermitidas.Read())
                {
                    var botonempresa = new Bunifu.Framework.UI.BunifuFlatButton();

                    botonempresa.Normalcolor = Color.FromArgb(48, 55, 76);
                    botonempresa.Iconimage = null;

                    botonempresa.Size = new Size(178, 48);
                    botonempresa.Name = readerEmpresasPermitidas["id"].ToString();
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(readerEmpresasPermitidas["nombre"], Module1.nombreAmostrar, false)))
                    {
                        botonempresa.Text = readerEmpresasPermitidas["nombre"].ToString() + " (Activa)";
                        botonempresa.Normalcolor = Color.FromArgb(46, 139, 87);
                    }
                    else
                    {
                        botonempresa.Text = readerEmpresasPermitidas["nombre"].ToString();
                    }

                    // botonempresa.Tag = milector("ip")
                    botonempresa.Click += clickevenntAsync;
                    // AddHandler botonempresa.MouseDown, AddressOf OnButtonMouseDown
                    Invoke(new Action(() => FlowEmpresas.Controls.Add(botonempresa)));

                }

            }
        }

        private void BackgroundEmpresas_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();

        }
        private async void clickevenntAsync(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuFlatButton b = (Bunifu.Framework.UI.BunifuFlatButton)sender;
            if (Operators.ConditionalCompareObjectEqual(b.Normalcolor, Color.FromArgb(48, 55, 76), false))
            {
                b.Normalcolor = Color.FromArgb(46, 139, 87);
            }

            else if (Operators.ConditionalCompareObjectEqual(b.Normalcolor, Color.FromArgb(46, 139, 87), false))
            {
                b.Normalcolor = Color.FromArgb(48, 55, 76);
            }
            else if (Operators.ConditionalCompareObjectEqual(b.Normalcolor, Color.FromArgb(189, 2, 2), false))
            {
                b.Normalcolor = Color.FromArgb(48, 55, 76);

            }



        }

        private void BackgroundConectarEmpresas_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0, loopTo = TabControl1.TabCount - 1; i <= loopTo; i++)


                TabControl1.TabPages.RemoveAt(0);

            // For Each tabctrl As TabPage In TabControl1.TabPages
            // Dim indexOfTab As Integer = TabControl1.TabPages.IndexOfKey(tabctrl.Name)
            // MessageBox.Show(indexOfTab)
            // Next

            foreach (Control ctrl in FlowEmpresas.Controls)
            {
                if (ctrl is Bunifu.Framework.UI.BunifuFlatButton)
                {
                    Bunifu.Framework.UI.BunifuFlatButton ctrlE = (Bunifu.Framework.UI.BunifuFlatButton)ctrl;
                    bool EmpresaActiva;
                    if (ctrlE.Text.Contains("Activa"))
                    {
                        EmpresaActiva = true;
                    }
                    else
                    {
                        EmpresaActiva = false;
                    }

                    if (ctrlE.Normalcolor == Color.FromArgb(46, 139, 87))
                    {
                        foreach (DataRow row in Module1.dataEmpresas.Rows)
                        {
                            if ((row["id"].ToString() ?? "") == (ctrlE.Name ?? ""))
                            {
                                // MessageBox.Show(ctrlE.Name)

                                if (Module1.ProbarConexionEmpresa(row["ip"].ToString(), row["bd"].ToString()))
                                {

                                    var empresaConect = new EmpresaConectada();
                                    empresaConect.Conectada = true;
                                    empresaConect.ConexionEmpresaConectada = Module1.CrearConexionEmpresa(row["ip"].ToString(), row["bd"].ToString());
                                    arrayEmpresas.Add(empresaConect);
                                    Invoke(new Action(() =>
                                    {
                                        var tabPg = new TabPage();
                                        tabPg.Name = ctrlE.Text;
                                        tabPg.Text = ctrlE.Text;
                                        var dtConsultas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
                                        dtConsultas.BackgroundColor = Color.Gainsboro;
                                        dtConsultas.Anchor = AnchorStyles.Bottom & AnchorStyles.Left & AnchorStyles.Right & AnchorStyles.Top;
                                        dtConsultas.Size = new Size(TabControl1.Width - 10, TabControl1.Height - 30);
                                        dtConsultas.DataSource = CredMora(Module1.CrearConexionEmpresa(row["ip"].ToString(), row["bd"].ToString()), EmpresaActiva);
                                        dtConsultas.AllowUserToAddRows = false;
                                        dtConsultas.AllowUserToDeleteRows = false;
                                        dtConsultas.HeaderBgColor = Color.DarkSlateGray;
                                        dtConsultas.ScrollBars = ScrollBars.Both;
                                        dtConsultas.HeaderForeColor = Color.FromArgb(223, 223, 223);
                                        dtConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                                        dtConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                                        dtConsultas.Name = ctrlE.Text;
                                        tabPg.Controls.Add(dtConsultas);
                                        dtConsultas.Location = new Point(0, 0);
                                        Invoke(new Action(() => TabControl1.TabPages.Insert(TabControl1.TabPages.Count, tabPg)));



                                    }));
                                }


                                else
                                {
                                    ctrlE.Normalcolor = Color.FromArgb(189, 2, 2);
                                }
                                break;
                            }
                        }
                    }
                }

            }

            foreach (TabPage ctrl in TabControl1.TabPages)
            {
                foreach (Control ctrlDT in ctrl.Controls)
                {
                    if (ctrlDT is Bunifu.Framework.UI.BunifuCustomDataGrid)
                    {
                        Bunifu.Framework.UI.BunifuCustomDataGrid dt = (Bunifu.Framework.UI.BunifuCustomDataGrid)ctrlDT;

                        Invoke(new Action(() => dt.Location = new Point(0, 0)));

                    }
                }
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Panel2.Visible = True
            // Panel2.BringToFront()
            // TransparentPanel1.Location = dtimpuestos.Location
            // TabControl1.Visible = False

            // TransparentPanel1.Size = dtimpuestos.Size

            // Panel2.Location = New Point((Me.Size.Width / 2) + (Panel2.Width / 2) - 200, (Me.Height / 2) + (Panel2.Height / 2) - 200)
            // BackgroundConectarEmpresas.RunWorkerAsync()

            if (chicoGrande == false)
            {
                TimerGrande.Enabled = true;
                TimerGrande.Interval = 1;
                TimerGrande.Start();
            }

            if (chicoGrande)
            {
                TimerChico.Enabled = true;
                TimerChico.Interval = 1;
                TimerChico.Start();

            }



        }
        private DataTable CredMora(OleDbConnection conexiondt, bool EmpresaActiva)
        {
            OleDbDataAdapter adapterDT;
            string consulta="";
            DataTable dataDT;
            int idEmpleado;
            idEmpleado = ConsultarId(ComboElección.Text);
            if (EmpresaActiva)
            {
                switch (ComboFiltro.Text ?? "")
                {
                    case "Gestor":
                        {

                            if (ComboElección.Text == "Todos")
                            {
                                consulta = "select * from dbo.CreditosEnMoraAcomodado('" + ComboElección.Text + "','','" + txtnombre.Text + "')";
                            }

                            else
                            {

                                consulta = "select * from dbo.CreditosEnMoraAcomodado('" + ComboFiltro.Text + "','" + idEmpleado + "','" + txtnombre.Text + "')";
                            }

                            break;
                        }
                    case "Promotor":
                        {

                            if (ComboElección.Text == "Todos")
                            {
                                consulta = "select * from dbo.CreditosEnMoraAcomodado('" + ComboElección.Text + "','','" + txtnombre.Text + "')";
                            }
                            else
                            {
                                consulta = "select * from dbo.CreditosEnMoraAcomodado('" + ComboFiltro.Text + "','" + idEmpleado + "','" + txtnombre.Text + "')";
                            }

                            break;
                        }
                    case "Todos":
                        {
                            consulta = "select * from dbo.CreditosEnMoraAcomodado('" + ComboFiltro.Text + "','','" + txtnombre.Text + "')";
                            break;
                        }
                }
            }
            else
            {
                consulta = "select * from dbo.CreditosEnMoraAcomodado('Todos','','')";
            }



            adapterDT = new OleDbDataAdapter(consulta, conexiondt);
            dataDT = new DataTable();
            adapterDT.Fill(dataDT);
            return dataDT;

        }

        private void BackgroundConectarEmpresas_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Panel2.Visible = false;
            TabControl1.Visible = true;
        }
        public void nuevolibroMora()
        {
            Module1.exLibro = exApp.Workbooks.Add();
        }

        public bool GridAExcelMora(DataGridView ElGrid)
        {

            // Creamos las variables

            Microsoft.Office.Interop.Excel.Worksheet exHoja;

            try
            {
                // Añadimos el Libro al programa, y la hoja al libro

                exHoja = (Microsoft.Office.Interop.Excel.Worksheet)Module1.exLibro.Worksheets.Add();
                exHoja.Name = ElGrid.Name;

                // ¿Cuantas columnas y cuantas filas?
                int NCol = ElGrid.ColumnCount;
                int NRow = ElGrid.RowCount;

                // Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.


                for (int i = 1, loopTo = NCol; i <= loopTo; i++)
                    // exHoja.Cells.Item(1, i).HorizontalAlignment = 3
                    exHoja.Cells.set_Item(1, i, ElGrid.Columns[i - 1].HeaderText.ToString());

                for (int Fila = 0, loopTo1 = NRow - 1; Fila <= loopTo1; Fila++)
                {
                    for (int Col = 0, loopTo2 = NCol - 1; Col <= loopTo2; Col++)
                        exHoja.Cells.set_Item(Fila + 2, Col + 1, ElGrid.Rows[Fila].Cells[Col].Value.ToString());
                }
                // Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
                exHoja.Rows.get_Item((object)1).Font.Bold = (object)1;
                exHoja.Rows.get_Item((object)1).HorizontalAlignment = (object)3;
                exHoja.Columns.AutoFit();
                // exHoja.Columns.Range("A:A").NumberFormat = "#0"

                // Aplicación visible

                exHoja = null;
            }


            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel");

                return false;
            }

            return true;

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectLessEqual(widthEmpresa, 507, false)))
            {
                FlowEmpresas.Width = Conversions.ToInteger(widthEmpresa);
                widthEmpresa += 10;
            }
            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectLessEqual(heightEmpresa, 68, false)))
            {
                FlowEmpresas.Height = Conversions.ToInteger(heightEmpresa);
                heightEmpresa += 10;
            }
            else
            {
                TimerGrande.Stop();
                TimerGrande.Enabled = false;
                chicoGrande = true;

            }
        }

        private void TimerChico_Tick(object sender, EventArgs e)
        {
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectGreaterEqual(widthEmpresa, 0, false)))
            {
                FlowEmpresas.Width = Conversions.ToInteger(widthEmpresa);
                widthEmpresa -= 10;
            }
            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectGreaterEqual(heightEmpresa, 0, false)))
            {
                FlowEmpresas.Height = Conversions.ToInteger(heightEmpresa);
                heightEmpresa -= 10;
            }
            else
            {
                TimerChico.Stop();
                TimerChico.Enabled = false;
                chicoGrande = false;

            }
        }

        public void cerrarlibroMora()
        {
            try
            {

                SaveFileDialog guardar;
                guardar = new SaveFileDialog();
                guardar.Filter = "Archivo de Excel|*.xlsx";
                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    exApp.Application.Visible = true;
                    // exLibro.SaveAs(Environ("UserProfile") & "\desktop\" & nombre & ".xls")
                    Module1.exLibro.SaveAs(guardar.FileName);
                }
            }

            // exLibro.SaveAs(Environ("UserProfile") & "\desktop\NombreDeTuArchivo.xls")
            // exLibro = Nothing
            // exApp = Nothing
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}