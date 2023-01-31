using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class ValorCartera
    {

        private DataSet dataGestores;
        private DataSet dataPromotores;
        private SqlDataAdapter adapterGestores;
        private Resizer rs = new Resizer();
        private SqlDataAdapter adapterPromotores;
        private DataTable dataConsulta;
        private SqlDataAdapter adapterConsulta;
        private double totalSmultas, totalCmultas, totalNormal, totalVCmultas;
        private double porcentajeSmultas;
        private double porcentajeCmultas;
        private int formancho = 1197;
        private int formalto = 581;

        public ValorCartera()
        {
            InitializeComponent();
        }
        private void Desembolsos_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            ComboFiltro.SelectedIndex = 0;
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Información";
            My.MyProject.Forms.Cargando.TopMost = true;
            BackgroundGestores.RunWorkerAsync();

        }
        public void escalar1()
        {
            var f = new SizeF();
            f.Height = (float)(100d / formalto * Height / 100d);
            f.Width = (float)(100d / formancho * Width / 100d);
            foreach (Control ctrl in Controls)
            {
                ctrl.Scale(f);
                try
                {
                    // controlo el error por si no tiene propiedad font
                    ctrl.Font = new Font(ctrl.Font.OriginalFontName, ctrl.Font.Size * f.Height, ctrl.Font.Style, GraphicsUnit.Point);
                }
                catch (Exception ex)
                {
                }
                if (ctrl is FlowLayoutPanel) // si el control es un groupbox escalo sus controles internos
                {
                    foreach (Control ctrlAUX in ctrl.Controls)
                    {
                        ctrlAUX.Scale(f);
                        try
                        {
                            ctrlAUX.Font = new Font(ctrlAUX.Font.OriginalFontName, ctrlAUX.Font.Size * f.Height, ctrlAUX.Font.Style, GraphicsUnit.Point);
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }
            }
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
            string consulta ="";

            int idEmpleado;
            idEmpleado = ConsultarId(ComboElección.Text);
            switch (ComboFiltro.Text ?? "")
            {
                case "Gestor":
                    {
                        if (ComboElección.Text == "Todos")
                        {
                            consulta = @"select nombre,id,pagare,AbonadoSinMultas,(pagare-AbonadoSinMultas) as valorCarteraSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,((Multas-(AbonadoMultasL+AbonadoMultasV))+(pagare-AbonadoSinMultas)) as ValorCarteraConMultas,
 case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.Estado = 'R' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.Estado = 'Z' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Promotor,Estado from
(select Cartera.nombre,Cartera.id,
case when Cartera.Estado = 'C' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where Abonado <> 0 and Abonado >= interes and conveniossac.idcredito = Cartera.id group by idcredito),0)
when Cartera.Estado = 'R' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where Abonado <> 0 and Abonado >= interes and ReestructurasSac.idcredito = Cartera.id group by idcredito),0)
 when Cartera.Estado = 'Z' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.IdConvenio = ConveniosTerminalesSac.id where Abonado <> 0 and Abonado >= interes and ConveniosTerminalesSac.idcredito = Cartera.id group by idcredito),0)
else
isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id group by id_credito),0) end as AbonadoSinMultas,
case when Cartera.Estado = 'C' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConveniossac inner join Conveniossac on ConveniosSac.id = CalendarioConveniossac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioConveniossac.estado = 'V' and Conveniossac.idcredito = cartera.id group by Conveniossac.idcredito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarioconveniossac.Interes) ))) )) as AbonadoInteres from calendarioconveniossac inner join conveniossac on calendarioconveniossac.idconvenio = conveniossac.id where calendarioconveniossac.estado = 'V' and Abonado >=calendarioconveniossac.Interes and conveniossac.idcredito =cartera.id group by conveniossac.idcredito),0) 
when Cartera.Estado = 'R' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioReestructurasSac.estado = 'V' and ReestructurasSac.idcredito = cartera.id group by ReestructurasSac.idcredito),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioReestructurasSac.Interes) ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idconvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado >=CalendarioReestructurasSac.Interes and ReestructurasSac.idcredito =cartera.id group by ReestructurasSac.idcredito),0) 
when Cartera.Estado = 'Z' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on ConveniosTerminalesSac.id = CalendarioConveniosTerminalesSac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioConveniosTerminalesSac.estado = 'V' and ConveniosTerminalesSac.idcredito = cartera.id group by ConveniosTerminalesSac.idcredito),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioConveniosTerminalesSac.Interes) ))) )) as AbonadoInteres from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.idconvenio = ConveniosTerminalesSac.id where CalendarioConveniosTerminalesSac.estado = 'V' and Abonado >=CalendarioConveniosTerminalesSac.Interes and ConveniosTerminalesSac.idcredito =cartera.id group by ConveniosTerminalesSac.idcredito),0) 
else
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)),0)end as AbonadoMultasV,
case when Cartera.Estado = 'C' then
isnull((select SUM(Abonado - CalendarioConveniossac.monto) as AbonadoMultas from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where  CalendarioConveniossac.estado = 'L' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(Abonado - CalendarioReestructurasSac.monto) as AbonadoMultas from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where  CalendarioReestructurasSac.estado = 'L' and ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
when Cartera.Estado = 'Z' then
isnull((select SUM(Abonado - CalendarioConveniosTerminalesSac.monto) as AbonadoMultas from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on ConveniosTerminalesSac.id = CalendarioConveniosTerminalesSac.IdConvenio where  CalendarioConveniosTerminalesSac.estado = 'L' and ConveniosTerminalesSac.idcredito = Cartera.id group by ConveniosTerminalesSac.idcredito),0)
else
isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L' and CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as AbonadoMultasL,
case when Cartera.Estado = 'C' THEN 
isnull((select SUM(CalendarioConveniossac.interes) as Multas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where  Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.interes) as Multas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where  ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
when Cartera.Estado = 'Z' then
isnull((select SUM(CalendarioConveniosTerminalesSac.interes) as Multas from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.IdConvenio = ConveniosTerminalesSac.id where  ConveniosTerminalesSac.idcredito = Cartera.id group by ConveniosTerminalesSac.idcredito),0)
else
isnull((select SUM(CalendarioNormal.interes) as Multas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as Multas,
case when cartera.Estado = 'C' THEN 
(select SUM(calendarioconveniossac.monto) from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(CalendarioReestructurasSac.monto) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where ReestructurasSac.idcredito = Cartera.id)
when Cartera.Estado = 'Z' then
(select SUM(CalendarioConveniosTerminalesSac.monto) from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.IdConvenio = ConveniosTerminalesSac.id where ConveniosTerminalesSac.idcredito = Cartera.id)
else
(select Pagare from credito where id = Cartera.id) end as pagare,
case when Cartera.Estado = 'C' then
isnull((select SUM(calendarioconveniossac.pendiente) from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where calendarioconveniossac.Estado = 'V' and conveniossac.idcredito = Cartera.id),0)
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.pendiente) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = Cartera.id),0)
when Cartera.Estado = 'Z' then
isnull((select SUM(CalendarioConveniosTerminalesSac.pendiente) from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.IdConvenio = ConveniosTerminalesSac.id where CalendarioConveniosTerminalesSac.Estado = 'V' and ConveniosTerminalesSac.idcredito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado ='V' and Conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(interes) as MultasVencidas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado ='V' and ReestructurasSac.idcredito = Cartera.id)
when Cartera.Estado = 'Z' then
(select SUM(interes) as MultasVencidas from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.IdConvenio = ConveniosTerminalesSac.id where CalendarioConveniosTerminalesSac.Estado ='V' and ConveniosTerminalesSac.idcredito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado from
(select credito.nombre,Credito.id,Credito.idgestor,Credito.IdPromotor,credito.Estado from Credito inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito where Credito.Estado <> 'L' and credito.estado <> 'T' group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal order by nombre asc";
                        }

                        else
                        {

                            consulta = @"select nombre,id,pagare,AbonadoSinMultas,(pagare-AbonadoSinMultas) as valorCarteraSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,((Multas-(AbonadoMultasL+AbonadoMultasV))+(pagare-AbonadoSinMultas)) as ValorCarteraConMultas,
 case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.Estado = 'R' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.Estado = 'Z' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Promotor,Estado from
(select Cartera.nombre,Cartera.id,
case when Cartera.Estado = 'C' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where Abonado <> 0 and Abonado >= interes and conveniossac.idcredito = Cartera.id group by idcredito),0)
when Cartera.Estado = 'R' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where Abonado <> 0 and Abonado >= interes and ReestructurasSac.idcredito = Cartera.id group by idcredito),0)
 when Cartera.Estado = 'Z' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.IdConvenio = ConveniosTerminalesSac.id where Abonado <> 0 and Abonado >= interes and ConveniosTerminalesSac.idcredito = Cartera.id group by idcredito),0)
else
isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id group by id_credito),0) end as AbonadoSinMultas,
case when Cartera.Estado = 'C' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConveniossac inner join Conveniossac on ConveniosSac.id = CalendarioConveniossac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioConveniossac.estado = 'V' and Conveniossac.idcredito = cartera.id group by Conveniossac.idcredito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarioconveniossac.Interes) ))) )) as AbonadoInteres from calendarioconveniossac inner join conveniossac on calendarioconveniossac.idconvenio = conveniossac.id where calendarioconveniossac.estado = 'V' and Abonado >=calendarioconveniossac.Interes and conveniossac.idcredito =cartera.id group by conveniossac.idcredito),0) 
when Cartera.Estado = 'R' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioReestructurasSac.estado = 'V' and ReestructurasSac.idcredito = cartera.id group by ReestructurasSac.idcredito),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioReestructurasSac.Interes) ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idconvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado >=CalendarioReestructurasSac.Interes and ReestructurasSac.idcredito =cartera.id group by ReestructurasSac.idcredito),0) 
when Cartera.Estado = 'Z' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on ConveniosTerminalesSac.id = CalendarioConveniosTerminalesSac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioConveniosTerminalesSac.estado = 'V' and ConveniosTerminalesSac.idcredito = cartera.id group by ConveniosTerminalesSac.idcredito),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioConveniosTerminalesSac.Interes) ))) )) as AbonadoInteres from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.idconvenio = ConveniosTerminalesSac.id where CalendarioConveniosTerminalesSac.estado = 'V' and Abonado >=CalendarioConveniosTerminalesSac.Interes and ConveniosTerminalesSac.idcredito =cartera.id group by ConveniosTerminalesSac.idcredito),0) 
else
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)),0)end as AbonadoMultasV,
case when Cartera.Estado = 'C' then
isnull((select SUM(Abonado - CalendarioConveniossac.monto) as AbonadoMultas from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where  CalendarioConveniossac.estado = 'L' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(Abonado - CalendarioReestructurasSac.monto) as AbonadoMultas from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where  CalendarioReestructurasSac.estado = 'L' and ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
when Cartera.Estado = 'Z' then
isnull((select SUM(Abonado - CalendarioConveniosTerminalesSac.monto) as AbonadoMultas from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on ConveniosTerminalesSac.id = CalendarioConveniosTerminalesSac.IdConvenio where  CalendarioConveniosTerminalesSac.estado = 'L' and ConveniosTerminalesSac.idcredito = Cartera.id group by ConveniosTerminalesSac.idcredito),0)
else
isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L' and CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as AbonadoMultasL,
case when Cartera.Estado = 'C' THEN 
isnull((select SUM(CalendarioConveniossac.interes) as Multas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where  Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.interes) as Multas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where  ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
when Cartera.Estado = 'Z' then
isnull((select SUM(CalendarioConveniosTerminalesSac.interes) as Multas from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.IdConvenio = ConveniosTerminalesSac.id where  ConveniosTerminalesSac.idcredito = Cartera.id group by ConveniosTerminalesSac.idcredito),0)
else
isnull((select SUM(CalendarioNormal.interes) as Multas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as Multas,
case when cartera.Estado = 'C' THEN 
(select SUM(calendarioconveniossac.monto) from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(CalendarioReestructurasSac.monto) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where ReestructurasSac.idcredito = Cartera.id)
when Cartera.Estado = 'Z' then
(select SUM(CalendarioConveniosTerminalesSac.monto) from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.IdConvenio = ConveniosTerminalesSac.id where ConveniosTerminalesSac.idcredito = Cartera.id)
else
(select Pagare from credito where id = Cartera.id) end as pagare,
case when Cartera.Estado = 'C' then
isnull((select SUM(calendarioconveniossac.pendiente) from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where calendarioconveniossac.Estado = 'V' and conveniossac.idcredito = Cartera.id),0)
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.pendiente) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = Cartera.id),0)
when Cartera.Estado = 'Z' then
isnull((select SUM(CalendarioConveniosTerminalesSac.pendiente) from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.IdConvenio = ConveniosTerminalesSac.id where CalendarioConveniosTerminalesSac.Estado = 'V' and ConveniosTerminalesSac.idcredito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado ='V' and Conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(interes) as MultasVencidas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado ='V' and ReestructurasSac.idcredito = Cartera.id)
when Cartera.Estado = 'Z' then
(select SUM(interes) as MultasVencidas from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.IdConvenio = ConveniosTerminalesSac.id where CalendarioConveniosTerminalesSac.Estado ='V' and ConveniosTerminalesSac.idcredito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado from
(select credito.nombre,Credito.id,Credito.idgestor,Credito.IdPromotor,credito.Estado from Credito inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito where Credito.Estado <> 'L' and credito.estado <> 'T' and credito.idGestor ='" + idEmpleado + @"' group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal order by nombre asc";
                        }

                        break;
                    }
                case "Promotor":
                    {
                        if (ComboElección.Text == "Todos")
                        {
                            consulta = @"select nombre,id,pagare,AbonadoSinMultas,(pagare-AbonadoSinMultas) as valorCarteraSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,((Multas-(AbonadoMultasL+AbonadoMultasV))+(pagare-AbonadoSinMultas)) as ValorCarteraConMultas,
 case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.Estado = 'R' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.Estado = 'Z' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Promotor,Estado from
(select Cartera.nombre,Cartera.id,
case when Cartera.Estado = 'C' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where Abonado <> 0 and Abonado >= interes and conveniossac.idcredito = Cartera.id group by idcredito),0)
when Cartera.Estado = 'R' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where Abonado <> 0 and Abonado >= interes and ReestructurasSac.idcredito = Cartera.id group by idcredito),0)
 when Cartera.Estado = 'Z' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.IdConvenio = ConveniosTerminalesSac.id where Abonado <> 0 and Abonado >= interes and ConveniosTerminalesSac.idcredito = Cartera.id group by idcredito),0)
else
isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id group by id_credito),0) end as AbonadoSinMultas,
case when Cartera.Estado = 'C' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConveniossac inner join Conveniossac on ConveniosSac.id = CalendarioConveniossac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioConveniossac.estado = 'V' and Conveniossac.idcredito = cartera.id group by Conveniossac.idcredito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarioconveniossac.Interes) ))) )) as AbonadoInteres from calendarioconveniossac inner join conveniossac on calendarioconveniossac.idconvenio = conveniossac.id where calendarioconveniossac.estado = 'V' and Abonado >=calendarioconveniossac.Interes and conveniossac.idcredito =cartera.id group by conveniossac.idcredito),0) 
when Cartera.Estado = 'R' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioReestructurasSac.estado = 'V' and ReestructurasSac.idcredito = cartera.id group by ReestructurasSac.idcredito),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioReestructurasSac.Interes) ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idconvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado >=CalendarioReestructurasSac.Interes and ReestructurasSac.idcredito =cartera.id group by ReestructurasSac.idcredito),0) 
when Cartera.Estado = 'Z' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on ConveniosTerminalesSac.id = CalendarioConveniosTerminalesSac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioConveniosTerminalesSac.estado = 'V' and ConveniosTerminalesSac.idcredito = cartera.id group by ConveniosTerminalesSac.idcredito),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioConveniosTerminalesSac.Interes) ))) )) as AbonadoInteres from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.idconvenio = ConveniosTerminalesSac.id where CalendarioConveniosTerminalesSac.estado = 'V' and Abonado >=CalendarioConveniosTerminalesSac.Interes and ConveniosTerminalesSac.idcredito =cartera.id group by ConveniosTerminalesSac.idcredito),0) 
else
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)),0)end as AbonadoMultasV,
case when Cartera.Estado = 'C' then
isnull((select SUM(Abonado - CalendarioConveniossac.monto) as AbonadoMultas from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where  CalendarioConveniossac.estado = 'L' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(Abonado - CalendarioReestructurasSac.monto) as AbonadoMultas from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where  CalendarioReestructurasSac.estado = 'L' and ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
when Cartera.Estado = 'Z' then
isnull((select SUM(Abonado - CalendarioConveniosTerminalesSac.monto) as AbonadoMultas from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on ConveniosTerminalesSac.id = CalendarioConveniosTerminalesSac.IdConvenio where  CalendarioConveniosTerminalesSac.estado = 'L' and ConveniosTerminalesSac.idcredito = Cartera.id group by ConveniosTerminalesSac.idcredito),0)
else
isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L' and CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as AbonadoMultasL,
case when Cartera.Estado = 'C' THEN 
isnull((select SUM(CalendarioConveniossac.interes) as Multas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where  Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.interes) as Multas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where  ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
when Cartera.Estado = 'Z' then
isnull((select SUM(CalendarioConveniosTerminalesSac.interes) as Multas from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.IdConvenio = ConveniosTerminalesSac.id where  ConveniosTerminalesSac.idcredito = Cartera.id group by ConveniosTerminalesSac.idcredito),0)
else
isnull((select SUM(CalendarioNormal.interes) as Multas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as Multas,
case when cartera.Estado = 'C' THEN 
(select SUM(calendarioconveniossac.monto) from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(CalendarioReestructurasSac.monto) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where ReestructurasSac.idcredito = Cartera.id)
when Cartera.Estado = 'Z' then
(select SUM(CalendarioConveniosTerminalesSac.monto) from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.IdConvenio = ConveniosTerminalesSac.id where ConveniosTerminalesSac.idcredito = Cartera.id)
else
(select Pagare from credito where id = Cartera.id) end as pagare,
case when Cartera.Estado = 'C' then
isnull((select SUM(calendarioconveniossac.pendiente) from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where calendarioconveniossac.Estado = 'V' and conveniossac.idcredito = Cartera.id),0)
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.pendiente) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = Cartera.id),0)
when Cartera.Estado = 'Z' then
isnull((select SUM(CalendarioConveniosTerminalesSac.pendiente) from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.IdConvenio = ConveniosTerminalesSac.id where CalendarioConveniosTerminalesSac.Estado = 'V' and ConveniosTerminalesSac.idcredito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado ='V' and Conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(interes) as MultasVencidas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado ='V' and ReestructurasSac.idcredito = Cartera.id)
when Cartera.Estado = 'Z' then
(select SUM(interes) as MultasVencidas from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.IdConvenio = ConveniosTerminalesSac.id where CalendarioConveniosTerminalesSac.Estado ='V' and ConveniosTerminalesSac.idcredito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado from
(select credito.nombre,Credito.id,Credito.idgestor,Credito.IdPromotor,credito.Estado from Credito inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito where Credito.Estado <> 'L' and credito.estado <> 'T' group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal order by nombre asc";
                        }
                        else
                        {
                            consulta = @"select nombre,id,pagare,AbonadoSinMultas,(pagare-AbonadoSinMultas) as valorCarteraSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,((Multas-(AbonadoMultasL+AbonadoMultasV))+(pagare-AbonadoSinMultas)) as ValorCarteraConMultas,
 case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.Estado = 'R' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.Estado = 'Z' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Promotor,Estado from
(select Cartera.nombre,Cartera.id,
case when Cartera.Estado = 'C' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where Abonado <> 0 and Abonado >= interes and conveniossac.idcredito = Cartera.id group by idcredito),0)
when Cartera.Estado = 'R' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where Abonado <> 0 and Abonado >= interes and ReestructurasSac.idcredito = Cartera.id group by idcredito),0)
 when Cartera.Estado = 'Z' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.IdConvenio = ConveniosTerminalesSac.id where Abonado <> 0 and Abonado >= interes and ConveniosTerminalesSac.idcredito = Cartera.id group by idcredito),0)
else
isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id group by id_credito),0) end as AbonadoSinMultas,
case when Cartera.Estado = 'C' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConveniossac inner join Conveniossac on ConveniosSac.id = CalendarioConveniossac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioConveniossac.estado = 'V' and Conveniossac.idcredito = cartera.id group by Conveniossac.idcredito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarioconveniossac.Interes) ))) )) as AbonadoInteres from calendarioconveniossac inner join conveniossac on calendarioconveniossac.idconvenio = conveniossac.id where calendarioconveniossac.estado = 'V' and Abonado >=calendarioconveniossac.Interes and conveniossac.idcredito =cartera.id group by conveniossac.idcredito),0) 
when Cartera.Estado = 'R' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioReestructurasSac.estado = 'V' and ReestructurasSac.idcredito = cartera.id group by ReestructurasSac.idcredito),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioReestructurasSac.Interes) ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idconvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado >=CalendarioReestructurasSac.Interes and ReestructurasSac.idcredito =cartera.id group by ReestructurasSac.idcredito),0) 
when Cartera.Estado = 'Z' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on ConveniosTerminalesSac.id = CalendarioConveniosTerminalesSac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioConveniosTerminalesSac.estado = 'V' and ConveniosTerminalesSac.idcredito = cartera.id group by ConveniosTerminalesSac.idcredito),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioConveniosTerminalesSac.Interes) ))) )) as AbonadoInteres from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.idconvenio = ConveniosTerminalesSac.id where CalendarioConveniosTerminalesSac.estado = 'V' and Abonado >=CalendarioConveniosTerminalesSac.Interes and ConveniosTerminalesSac.idcredito =cartera.id group by ConveniosTerminalesSac.idcredito),0) 
else
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)),0)end as AbonadoMultasV,
case when Cartera.Estado = 'C' then
isnull((select SUM(Abonado - CalendarioConveniossac.monto) as AbonadoMultas from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where  CalendarioConveniossac.estado = 'L' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(Abonado - CalendarioReestructurasSac.monto) as AbonadoMultas from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where  CalendarioReestructurasSac.estado = 'L' and ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
when Cartera.Estado = 'Z' then
isnull((select SUM(Abonado - CalendarioConveniosTerminalesSac.monto) as AbonadoMultas from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on ConveniosTerminalesSac.id = CalendarioConveniosTerminalesSac.IdConvenio where  CalendarioConveniosTerminalesSac.estado = 'L' and ConveniosTerminalesSac.idcredito = Cartera.id group by ConveniosTerminalesSac.idcredito),0)
else
isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L' and CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as AbonadoMultasL,
case when Cartera.Estado = 'C' THEN 
isnull((select SUM(CalendarioConveniossac.interes) as Multas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where  Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.interes) as Multas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where  ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
when Cartera.Estado = 'Z' then
isnull((select SUM(CalendarioConveniosTerminalesSac.interes) as Multas from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.IdConvenio = ConveniosTerminalesSac.id where  ConveniosTerminalesSac.idcredito = Cartera.id group by ConveniosTerminalesSac.idcredito),0)
else
isnull((select SUM(CalendarioNormal.interes) as Multas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as Multas,
case when cartera.Estado = 'C' THEN 
(select SUM(calendarioconveniossac.monto) from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(CalendarioReestructurasSac.monto) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where ReestructurasSac.idcredito = Cartera.id)
when Cartera.Estado = 'Z' then
(select SUM(CalendarioConveniosTerminalesSac.monto) from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.IdConvenio = ConveniosTerminalesSac.id where ConveniosTerminalesSac.idcredito = Cartera.id)
else
(select Pagare from credito where id = Cartera.id) end as pagare,
case when Cartera.Estado = 'C' then
isnull((select SUM(calendarioconveniossac.pendiente) from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where calendarioconveniossac.Estado = 'V' and conveniossac.idcredito = Cartera.id),0)
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.pendiente) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = Cartera.id),0)
when Cartera.Estado = 'Z' then
isnull((select SUM(CalendarioConveniosTerminalesSac.pendiente) from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.IdConvenio = ConveniosTerminalesSac.id where CalendarioConveniosTerminalesSac.Estado = 'V' and ConveniosTerminalesSac.idcredito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado ='V' and Conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(interes) as MultasVencidas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado ='V' and ReestructurasSac.idcredito = Cartera.id)
when Cartera.Estado = 'Z' then
(select SUM(interes) as MultasVencidas from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.IdConvenio = ConveniosTerminalesSac.id where CalendarioConveniosTerminalesSac.Estado ='V' and ConveniosTerminalesSac.idcredito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado from
(select credito.nombre,Credito.id,Credito.idgestor,Credito.IdPromotor,credito.Estado from Credito inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito where Credito.Estado <> 'L' and credito.estado <> 'T' and credito.idpromotor='" + idEmpleado + @"' group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal order by nombre asc";
                        }

                        break;
                    }
                case "Todos":
                    {
                        consulta = @"select nombre,id,pagare,AbonadoSinMultas,(pagare-AbonadoSinMultas) as valorCarteraSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,((Multas-(AbonadoMultasL+AbonadoMultasV))+(pagare-AbonadoSinMultas)) as ValorCarteraConMultas,
 case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.Estado = 'R' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.Estado = 'Z' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Promotor,Estado from
(select Cartera.nombre,Cartera.id,
case when Cartera.Estado = 'C' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where Abonado <> 0 and Abonado >= interes and conveniossac.idcredito = Cartera.id group by idcredito),0)
when Cartera.Estado = 'R' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where Abonado <> 0 and Abonado >= interes and ReestructurasSac.idcredito = Cartera.id group by idcredito),0)
 when Cartera.Estado = 'Z' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.IdConvenio = ConveniosTerminalesSac.id where Abonado <> 0 and Abonado >= interes and ConveniosTerminalesSac.idcredito = Cartera.id group by idcredito),0)
else
isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id group by id_credito),0) end as AbonadoSinMultas,
case when Cartera.Estado = 'C' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConveniossac inner join Conveniossac on ConveniosSac.id = CalendarioConveniossac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioConveniossac.estado = 'V' and Conveniossac.idcredito = cartera.id group by Conveniossac.idcredito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarioconveniossac.Interes) ))) )) as AbonadoInteres from calendarioconveniossac inner join conveniossac on calendarioconveniossac.idconvenio = conveniossac.id where calendarioconveniossac.estado = 'V' and Abonado >=calendarioconveniossac.Interes and conveniossac.idcredito =cartera.id group by conveniossac.idcredito),0) 
when Cartera.Estado = 'R' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioReestructurasSac.estado = 'V' and ReestructurasSac.idcredito = cartera.id group by ReestructurasSac.idcredito),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioReestructurasSac.Interes) ))) )) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idconvenio = ReestructurasSac.id where CalendarioReestructurasSac.estado = 'V' and Abonado >=CalendarioReestructurasSac.Interes and ReestructurasSac.idcredito =cartera.id group by ReestructurasSac.idcredito),0) 
when Cartera.Estado = 'Z' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on ConveniosTerminalesSac.id = CalendarioConveniosTerminalesSac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioConveniosTerminalesSac.estado = 'V' and ConveniosTerminalesSac.idcredito = cartera.id group by ConveniosTerminalesSac.idcredito),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioConveniosTerminalesSac.Interes) ))) )) as AbonadoInteres from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.idconvenio = ConveniosTerminalesSac.id where CalendarioConveniosTerminalesSac.estado = 'V' and Abonado >=CalendarioConveniosTerminalesSac.Interes and ConveniosTerminalesSac.idcredito =cartera.id group by ConveniosTerminalesSac.idcredito),0) 
else
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)),0)end as AbonadoMultasV,
case when Cartera.Estado = 'C' then
isnull((select SUM(Abonado - CalendarioConveniossac.monto) as AbonadoMultas from CalendarioConveniossac inner join Conveniossac on Conveniossac.id = CalendarioConveniossac.IdConvenio where  CalendarioConveniossac.estado = 'L' and Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(Abonado - CalendarioReestructurasSac.monto) as AbonadoMultas from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where  CalendarioReestructurasSac.estado = 'L' and ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
when Cartera.Estado = 'Z' then
isnull((select SUM(Abonado - CalendarioConveniosTerminalesSac.monto) as AbonadoMultas from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on ConveniosTerminalesSac.id = CalendarioConveniosTerminalesSac.IdConvenio where  CalendarioConveniosTerminalesSac.estado = 'L' and ConveniosTerminalesSac.idcredito = Cartera.id group by ConveniosTerminalesSac.idcredito),0)
else
isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L' and CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as AbonadoMultasL,
case when Cartera.Estado = 'C' THEN 
isnull((select SUM(CalendarioConveniossac.interes) as Multas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where  Conveniossac.idcredito = Cartera.id group by Conveniossac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.interes) as Multas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where  ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
when Cartera.Estado = 'Z' then
isnull((select SUM(CalendarioConveniosTerminalesSac.interes) as Multas from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.IdConvenio = ConveniosTerminalesSac.id where  ConveniosTerminalesSac.idcredito = Cartera.id group by ConveniosTerminalesSac.idcredito),0)
else
isnull((select SUM(CalendarioNormal.interes) as Multas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as Multas,
case when cartera.Estado = 'C' THEN 
(select SUM(calendarioconveniossac.monto) from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(CalendarioReestructurasSac.monto) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where ReestructurasSac.idcredito = Cartera.id)
when Cartera.Estado = 'Z' then
(select SUM(CalendarioConveniosTerminalesSac.monto) from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.IdConvenio = ConveniosTerminalesSac.id where ConveniosTerminalesSac.idcredito = Cartera.id)
else
(select Pagare from credito where id = Cartera.id) end as pagare,
case when Cartera.Estado = 'C' then
isnull((select SUM(calendarioconveniossac.pendiente) from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where calendarioconveniossac.Estado = 'V' and conveniossac.idcredito = Cartera.id),0)
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.pendiente) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = Cartera.id),0)
when Cartera.Estado = 'Z' then
isnull((select SUM(CalendarioConveniosTerminalesSac.pendiente) from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.IdConvenio = ConveniosTerminalesSac.id where CalendarioConveniosTerminalesSac.Estado = 'V' and ConveniosTerminalesSac.idcredito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConveniossac inner join Conveniossac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniossac.Estado ='V' and Conveniossac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(interes) as MultasVencidas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado ='V' and ReestructurasSac.idcredito = Cartera.id)
when Cartera.Estado = 'Z' then
(select SUM(interes) as MultasVencidas from CalendarioConveniosTerminalesSac inner join ConveniosTerminalesSac on CalendarioConveniosTerminalesSac.IdConvenio = ConveniosTerminalesSac.id where CalendarioConveniosTerminalesSac.Estado ='V' and ConveniosTerminalesSac.idcredito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado from
(select credito.nombre,Credito.id,Credito.idgestor,Credito.IdPromotor,credito.Estado from Credito inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito where Credito.Estado <> 'L' and credito.estado <> 'T' group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal order by nombre asc";
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
            int num_controles = FlowLayoutPanel1.Controls.Count - 1;
            for (int n = num_controles; n >= 0; n -= 1)
            {
                var ctrl = FlowLayoutPanel1.Controls[n];
                FlowLayoutPanel1.Controls.Remove(ctrl);
                ctrl.Dispose();
            }

            totalSmultas = 0d;
            totalCmultas = 0d;
            totalNormal = 0d;
            totalVCmultas = 0d;
            porcentajeCmultas = 0d;
            porcentajeSmultas = 0d;
            double TotalCantCreditos = 0d;
            double totalCreditosSanos = 0d;
            double totalCreditosMorosos = 0d;

            foreach (DataGridViewRow row in dtimpuestos.Rows)
            {
                totalSmultas = Conversions.ToDouble(Operators.AddObject(totalSmultas, row.Cells["ValorCarteraSinMultas"].Value));
                totalCmultas = Conversions.ToDouble(Operators.AddObject(totalCmultas, row.Cells["ValorCarteraConMultas"].Value));
                totalNormal = Conversions.ToDouble(Operators.AddObject(totalNormal, row.Cells["VencidoNormal"].Value));
                totalVCmultas = Conversions.ToDouble(Operators.AddObject(totalVCmultas, row.Cells["TotalPendiente"].Value));
                if (Conversion.Val(row.Cells["valorCarteraSinMultas"].Value) != 0d)
                {
                    TotalCantCreditos += 1d;
                    if (Conversion.Val(row.Cells["VencidoNormal"].Value) > 0d)
                    {
                        totalCreditosMorosos += 1d;
                    }
                    else
                    {
                        totalCreditosSanos += 1d;
                    }
                }

            }

            porcentajeSmultas = totalNormal * 100d / totalSmultas / 100d;
            porcentajeCmultas = totalVCmultas * 100d / totalCmultas / 100d;

            // lbltotal.Text = FormatCurrency(totalSmultas, 2)
            // lblTotalCmultas.Text = FormatCurrency(totalCmultas, 2)
            // lblTotalNormal.Text = FormatCurrency(totalNormal, 2)
            // lblTotalMultas.Text = FormatCurrency(totalVCmultas, 2)
            // lblporcentajeSmultas.Text = FormatPercent(porcentajeSmultas, 2)
            // lblporcentajeCmultas.Text = FormatPercent(porcentajeCmultas, 2)

            var botonValCarteraSmultas = new Bunifu.Framework.UI.BunifuTileButton();

            // botonempresa.Normalcolor = Color.FromArgb(48, 55, 76)
            // botonempresa.Iconimage = My.Resources.lconfia
            botonValCarteraSmultas.Size = new Size(117, 61);
            botonValCarteraSmultas.BackColor = Color.FromArgb(0, 64, 64);
            botonValCarteraSmultas.LabelText = Strings.FormatCurrency(totalSmultas, 2);



            FlowLayoutPanel1.Controls.Add(botonValCarteraSmultas);

            var botonValCarteraCmultas = new Bunifu.Framework.UI.BunifuTileButton();

            // botonempresa.Normalcolor = Color.FromArgb(48, 55, 76)
            // botonempresa.Iconimage = My.Resources.lconfia
            botonValCarteraCmultas.BackColor = Color.FromArgb(0, 64, 64);
            botonValCarteraCmultas.Size = new Size(117, 61);

            botonValCarteraCmultas.LabelText = Strings.FormatCurrency(totalCmultas, 2);



            FlowLayoutPanel1.Controls.Add(botonValCarteraCmultas);



            var botonVencidoNormal = new Bunifu.Framework.UI.BunifuTileButton();

            // botonempresa.Normalcolor = Color.FromArgb(48, 55, 76)
            // botonempresa.Iconimage = My.Resources.lconfia
            botonVencidoNormal.BackColor = Color.FromArgb(0, 64, 64);
            botonVencidoNormal.Size = new Size(117, 61);

            botonVencidoNormal.LabelText = Strings.FormatCurrency(totalNormal, 2);



            FlowLayoutPanel1.Controls.Add(botonVencidoNormal);



            var botonVencidoCmultas = new Bunifu.Framework.UI.BunifuTileButton();

            // botonempresa.Normalcolor = Color.FromArgb(48, 55, 76)
            // botonempresa.Iconimage = My.Resources.lconfia
            botonVencidoCmultas.Size = new Size(117, 61);
            botonVencidoCmultas.BackColor = Color.FromArgb(0, 64, 64);
            botonVencidoCmultas.LabelText = Strings.FormatCurrency(totalVCmultas, 2);



            FlowLayoutPanel1.Controls.Add(botonVencidoCmultas);


            var botonPorcentajeSmultas = new Bunifu.Framework.UI.BunifuTileButton();

            // botonempresa.Normalcolor = Color.FromArgb(48, 55, 76)
            // botonempresa.Iconimage = My.Resources.lconfia
            botonPorcentajeSmultas.Size = new Size(117, 61);
            botonPorcentajeSmultas.BackColor = Color.FromArgb(0, 64, 64);
            botonPorcentajeSmultas.LabelText = Strings.FormatPercent(porcentajeSmultas, 2);



            FlowLayoutPanel1.Controls.Add(botonPorcentajeSmultas);


            var botonPorcentajeCmultas = new Bunifu.Framework.UI.BunifuTileButton();

            // botonempresa.Normalcolor = Color.FromArgb(48, 55, 76)
            // botonempresa.Iconimage = My.Resources.lconfia
            botonPorcentajeCmultas.Size = new Size(117, 61);
            botonPorcentajeCmultas.BackColor = Color.FromArgb(0, 64, 64);
            botonPorcentajeCmultas.LabelText = Strings.FormatPercent(porcentajeCmultas, 2);



            FlowLayoutPanel1.Controls.Add(botonPorcentajeCmultas);



            Chart2.Series[0].Points.Clear();
            Chart2.Series[0].Points.AddXY("Créditos Morosos (" + totalCreditosMorosos + ")", (object)totalCreditosMorosos);
            Chart2.Series[0].Points.AddXY("Créditos Sanos (" + totalCreditosSanos + ")", (object)totalCreditosSanos);
            // WebBrowser1.ScriptErrorsSuppressed = True
            // WebBrowser1.Navigate("192.168.0.190/Otros/index.html")
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

        private void Button2_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Reportes.Panel1.Visible = false;
            My.MyProject.Forms.Reportes.RadPanorama1.Visible = true;
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

        private void CreditosEnMora_Resize(object sender, EventArgs e)
        {
            BunifuThinButton22.Location = new Point(ComboElección.Location.X + ComboElección.Width + 20, ComboElección.Location.Y);
            Chart2.Location = new Point(Width - Chart2.Width - 20, BunifuThinButton22.Location.Y);
        }
    }
}