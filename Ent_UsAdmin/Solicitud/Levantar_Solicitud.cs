using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class Levantar_Solicitud
    {
        private string idtipo, tipo, nombreTipo, Modalidad, tipocredito;
        private double plazoTipo, interesTipo;
        private bool consultadoTipo;
        private string nombreCliente, idCliente;
        private bool consultadoCliente;
        private int totalintegrantes = 0;
        private DataSet dataGestores;
        private DataSet dataPromotores;
        private SqlDataAdapter adapterGestores;
        private SqlDataAdapter adapterPromotores;
        private DataSet dataLegal;
        private SqlDataAdapter adapterLegal;
        private double totalMoratorios;
        private bool empezar;
        private double MontoTotal = 0d;
        private int idSolicitud;
        private string esta;
        private bool usarNombre;
        public bool autorizado;
        private string correoEmpleado;
        private string curp;
        public bool continuar;

        public Levantar_Solicitud()
        {
            InitializeComponent();
        }
        private void txtTipo_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Levantar_Solicitud_Load(object sender, EventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Gestores";
            BackgroundGestores.RunWorkerAsync();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.BuscarClienteSolicitud.Show();
        }

        private void txtIdCliente_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btn_agregar_ClickAsync(object sender, EventArgs e)
        {
            switch (tipocredito ?? "")
            {
                case "G":
                    {
                        dtdatos.Rows.Add(idCliente, nombreCliente, txtMontopPersona.Text);
                        totalintegrantes += 1;
                        MontoTotal = MontoTotal + Conversion.Val(txtMontopPersona.Text);
                        btn_agregar.Visible = false;
                        break;
                    }
                case "I":
                    {
                        if (totalintegrantes >= 1)
                        {
                            MessageBox.Show("El tipo de crédito es individual, sólo puede tener un integrante");
                            btn_agregar.Visible = false;
                        }
                        else
                        {
                            await Task.Factory.StartNew(() =>
                                    {
                                        Module1.iniciarconexionempresa();
                                        SqlCommand comandoTiene;
                                        string consultaTiene;
                                        consultaTiene = "if exists(select Solicitud.id from Solicitud inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud where DatosSolicitud.IdCliente = '" + txtIdCliente.Text + @"' and (Solicitud.Estado = 'I' or Solicitud.Estado = 'E' or Solicitud.Estado = 'V'))
begin 
select concat('Solicitud con Número ',Solicitud.id) as solicitud from Solicitud inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud where DatosSolicitud.IdCliente = '" + txtIdCliente.Text + @"' and (Solicitud.Estado = 'I' or Solicitud.Estado = 'E' or Solicitud.Estado = 'V')
end
else if exists(select Credito.id from Credito inner join Solicitud on Credito.IdSolicitud = Solicitud.id inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud where DatosSolicitud.IdCliente ='" + txtIdCliente.Text + @"' and (credito.estado = 'A' or credito.estado = 'C' or credito.estado = 'L' or credito.estado = 'E' or credito.estado = 'P'))
begin
select concat('Credito con Número ',Credito.id) as credito from Credito inner join Solicitud on Credito.IdSolicitud = Solicitud.id inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud where DatosSolicitud.IdCliente = '" + txtIdCliente.Text + @"' and (credito.estado = 'A' or credito.estado = 'C' or credito.estado = 'L' or credito.estado = 'E' or credito.estado = 'P')
end
else if exists(select Solicitud.id,Fecha,Solicitud.Estado from Solicitud inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud where DatosSolicitud.IdCliente = '" + txtIdCliente.Text + @"' and Solicitud.Estado = 'R')
begin
select 'R'
end
else if exists(select Solicitud.id,Fecha,Solicitud.Estado from Solicitud inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud where DatosSolicitud.IdCliente = '" + txtIdCliente.Text + @"' and DatosSolicitud.Estado = 'R' )
begin 
select 'DSR'
end
else
begin
select 'No tiene'
end";
                                        comandoTiene = new SqlCommand();
                                        comandoTiene.Connection = Module1.conexionempresa;
                                        comandoTiene.CommandText = consultaTiene;
                                        esta = Conversions.ToString(comandoTiene.ExecuteScalar());
                                    });
                            switch (esta ?? "")
                            {
                                case "No tiene":
                                    {
                                        dtdatos.Rows.Add(idCliente, nombreCliente, txtMontopPersona.Text);
                                        totalintegrantes += 1;
                                        MontoTotal = MontoTotal + Conversion.Val(txtMontopPersona.Text);
                                        txtNombreSolicitud.Text = nombreCliente;
                                        txtNombreSolicitud.Enabled = false;
                                        btn_agregar.Visible = false;
                                        break;
                                    }
                                case "R":
                                    {
                                        MessageBox.Show("El cliente tiene solicitudes rechazadas");
                                        My.MyProject.Forms.SolicitudesRechazadasCliente.tipoRechazo = "R";
                                        My.MyProject.Forms.SolicitudesRechazadasCliente.Idcliente = Conversions.ToInteger(txtIdCliente.Text);
                                        My.MyProject.Forms.SolicitudesRechazadasCliente.ShowDialog();
                                        var result = MessageBox.Show("¿Desea agregarlo a la solicitud de todos modos?", "Cliente Rechazado", MessageBoxButtons.YesNo);

                                        if (result == DialogResult.Yes)
                                        {
                                            My.MyProject.Forms.Autorizacion.tipoAutorizacion = "SatiModSolicitudesAgregarRechazados";
                                            My.MyProject.Forms.Autorizacion.ShowDialog();
                                            if (autorizado)
                                            {
                                                dtdatos.Rows.Add(idCliente, nombreCliente, txtMontopPersona.Text);
                                                totalintegrantes += 1;
                                                MontoTotal = MontoTotal + Conversion.Val(txtMontopPersona.Text);
                                                txtNombreSolicitud.Text = nombreCliente;
                                                txtNombreSolicitud.Enabled = false;
                                                btn_agregar.Visible = false;
                                            }
                                            else
                                            {
                                                MessageBox.Show("No fue autorizado");
                                            }
                                        }

                                        else
                                        {

                                        }

                                        break;
                                    }
                                case "DSR":
                                    {
                                        MessageBox.Show("El cliente fue rechazado de algunas solicitudes");
                                        My.MyProject.Forms.SolicitudesRechazadasCliente.tipoRechazo = "DSR";
                                        My.MyProject.Forms.SolicitudesRechazadasCliente.Idcliente = Conversions.ToInteger(txtIdCliente.Text);
                                        My.MyProject.Forms.SolicitudesRechazadasCliente.ShowDialog();
                                        var result = MessageBox.Show("¿Desea agregarlo a la solicitud de todos modos?", "Cliente Rechazado", MessageBoxButtons.YesNo);

                                        if (result == DialogResult.Yes)
                                        {
                                            My.MyProject.Forms.Autorizacion.tipoAutorizacion = "SatiModSolicitudesAgregarRechazados";
                                            My.MyProject.Forms.Autorizacion.ShowDialog();
                                            if (autorizado)
                                            {
                                                dtdatos.Rows.Add(idCliente, nombreCliente, txtMontopPersona.Text);
                                                totalintegrantes += 1;
                                                MontoTotal = MontoTotal + Conversion.Val(txtMontopPersona.Text);
                                                txtNombreSolicitud.Text = nombreCliente;
                                                txtNombreSolicitud.Enabled = false;
                                                btn_agregar.Visible = false;
                                            }
                                            else
                                            {
                                                MessageBox.Show("No fue autorizado");
                                            }
                                        }

                                        else
                                        {

                                        }

                                        break;
                                    }

                                default:
                                    {
                                        MessageBox.Show("El cliente ya cuenta con " + esta);
                                        var result = MessageBox.Show("¿Desea agregarlo a la solicitud de todos modos?", "Cliente Rechazado", MessageBoxButtons.YesNo);
                                        if (result == DialogResult.Yes)
                                        {
                                            dtdatos.Rows.Add(idCliente, nombreCliente, txtMontopPersona.Text);
                                            totalintegrantes += 1;
                                            MontoTotal = MontoTotal + Conversion.Val(txtMontopPersona.Text);
                                            txtNombreSolicitud.Text = nombreCliente;
                                            txtNombreSolicitud.Enabled = false;
                                            btn_agregar.Visible = false;
                                        }

                                        break;
                                    }
                            }

                        }

                        break;
                    }
                case "L":
                    {
                        dtdatos.Rows.Add(idCliente, nombreCliente, Conversion.Val(txtMontopPersona.Text) + Conversion.Val(txtMoratorios.Text));
                        totalintegrantes += 1;
                        MontoTotal = MontoTotal + Conversion.Val(txtMontopPersona.Text);
                        btn_agregar.Visible = false;
                        txtMoratorios.Visible = false;
                        lblMoratorios.Visible = false;
                        if (usarNombre)
                        {
                            txtNombreSolicitud.Text = nombreCliente;
                            txtNombreSolicitud.Enabled = false;
                        }
                        else
                        {
                            txtNombreSolicitud.Text = "";
                            txtNombreSolicitud.Enabled = true;
                        }
                        totalMoratorios = totalMoratorios + Conversion.Val(txtMoratorios.Text);
                        break;
                    }
                    // txtTotal.Visible = False
                    // lblTotal.Visible = False
            }
            txtIntegrantes.Text = totalintegrantes.ToString();
            txtMontoTotal.Text = MontoTotal.ToString();
            if (tipocredito == "L")
            {
                txtTotal.Text = ((MontoTotal + totalMoratorios) * 1.3d).ToString();
                txtTotalMoratorios.Text = totalMoratorios.ToString();
            }
        }

        private void dtdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Module_resize.MoveForm(this);
            }
        }

        private void BackgroundGestores_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {
                Module1.iniciarconexionempresa();
                string consulta;
                consulta = @" select '' as id, '' as nombre,'' as correo union all
Select id,nombre,correo from empleados where tipo = 'G'";
                adapterGestores = new SqlDataAdapter(consulta, Module1.conexionempresa);
                dataGestores = new DataSet();
                adapterGestores.Fill(dataGestores);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error " + ex.Message);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.TiposDeCreditos.Show();
        }

        private void BackgroundPromotores_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Module1.iniciarconexionempresa();
                string consulta;
                consulta = @"select '' as id, '' as nombre union all 
Select id,nombre from empleados where tipo = 'P'";
                adapterPromotores = new SqlDataAdapter(consulta, Module1.conexionempresa);
                dataPromotores = new DataSet();
                adapterPromotores.Fill(dataPromotores);
                empezar = true;
            }
            catch (Exception ex)
            {
                empezar = false;
                MessageBox.Show("Ha ocurrido un error " + ex.Message);
            }

        }

        public void ConsultarTipocredito()
        {
            try
            {
                Module1.iniciarconexionempresa();
                SqlCommand comando;
                string consulta;
                SqlDataReader reader;
                consulta = "select nombre,modalidad,tipo,plazo,interes from TiposDeCredito where id = '" + txtTipo.Text + "'";
                comando = new SqlCommand();
                comando.Connection = Module1.conexionempresa;
                comando.CommandText = consulta;
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        nombreTipo = Conversions.ToString(reader["nombre"]);
                        Modalidad = Conversions.ToString(reader["modalidad"]);
                        tipocredito = Conversions.ToString(reader["tipo"]);
                        idtipo = txtTipo.Text;
                        plazoTipo = Conversions.ToDouble(reader["plazo"]);
                        interesTipo = Conversions.ToDouble(reader["interes"]);
                    }
                    lblTipo.Text = nombreTipo;
                    txtplazo.Text = plazoTipo.ToString();
                    txtInteres.Text = interesTipo.ToString();
                }

                else
                {
                    lblTipo.Text = "No se encontró";
                }


                consultadoTipo = true;
            }
            catch (Exception ex)
            {
                lblTipo.Text = "...";
                consultadoTipo = false;
                MessageBox.Show("Ha ocurrido un error " + ex.Message);
            }

        }

        private void txtTipo_KeyDown(object sender, KeyEventArgs e)
        {
            if (empezar)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ConsultarTipocredito();

                }

                if (e.KeyCode == Keys.F2)
                {
                    My.MyProject.Forms.TiposDeCreditos.Show();
                }
            }
            else
            {
                MessageBox.Show("No se han cargado los valores, espere");
            }

        }

        public void ConsultarCliente()
        {
            Module1.iniciarconexionempresa();
            SqlCommand comando;
            string consulta;
            SqlDataReader reader;
            consulta = "select id,id,(nombre+' '+apellidoPaterno+' '+apellidoMaterno) as nombre,curp from clientes where id = '" + txtIdCliente.Text + "'";
            comando = new SqlCommand();
            comando.Connection = Module1.conexionempresa;
            comando.CommandText = consulta;
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    idCliente = Conversions.ToString(reader["id"]);
                    nombreCliente = Conversions.ToString(reader["nombre"]);
                    if (reader["curp"] is DBNull)
                    {
                        curp = "";
                    }
                    else
                    {
                        curp = Conversions.ToString(reader["curp"]);
                    }
                }

                lblCliente.Text = nombreCliente;
                consultadoCliente = true;
            }
            else
            {
                consultadoCliente = false;
                lblCliente.Text = "No se encontró";
            }
            if (consultadoCliente)
            {
                if (tipocredito == "L")
                {

                    btn_agregar.Visible = true;
                    txtMoratorios.Visible = true;
                    lblMoratorios.Visible = true;
                    txtTotal.Visible = true;
                    lblTotal.Visible = true;
                    CheckNombre.Visible = true;
                    ComboLegal.Visible = true;
                    lblGestorLegal.Visible = true;
                    txtTotalMoratorios.Visible = true;
                    lblTotalMoratorios.Visible = true;
                }
                else
                {
                    btn_agregar.Visible = true;
                    txtMoratorios.Visible = false;
                    lblMoratorios.Visible = false;
                    txtTotal.Visible = false;
                    lblTotal.Visible = false;
                    CheckNombre.Visible = false;
                    ComboLegal.Visible = false;
                    lblGestorLegal.Visible = false;
                    txtTotalMoratorios.Visible = false;
                    lblTotalMoratorios.Visible = false;
                }


            }
        }

        private void txtIdCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (empezar)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ConsultarCliente();
                    if (consultadoCliente)
                    {
                        if (tipocredito == "L")
                        {

                            btn_agregar.Visible = true;
                            txtMoratorios.Visible = true;
                            lblMoratorios.Visible = true;
                            txtTotal.Visible = true;
                            lblTotal.Visible = true;
                            CheckNombre.Visible = true;
                            ComboLegal.Visible = true;
                            lblGestorLegal.Visible = true;
                            txtTotalMoratorios.Visible = true;
                            lblTotalMoratorios.Visible = true;
                        }
                        else if (string.IsNullOrEmpty(curp))
                        {

                            MessageBox.Show("Este cliente no cuenta con sus datos actualizados, favor de actualizar para continuar");
                        }
                        else
                        {
                            btn_agregar.Visible = true;
                            txtMoratorios.Visible = false;
                            lblMoratorios.Visible = false;
                            txtTotal.Visible = false;
                            lblTotal.Visible = false;
                            CheckNombre.Visible = false;
                            ComboLegal.Visible = false;
                            lblGestorLegal.Visible = false;
                            txtTotalMoratorios.Visible = false;
                            lblTotalMoratorios.Visible = false;

                        }


                    }
                }
            }
            else
            {
                MessageBox.Show("No se han cargado los valores, espere");
            }

        }

        private void BackgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();

            correoEmpleado = ConsultarCorreoGestor(ComboGestor.Text);
            SqlCommand comandoSolicitud;
            string consultaSolicitud;

            int idpromotor;
            int idgestor;
            idpromotor = ConsultarIdPromotor(ComboPromotor.Text);
            idgestor = ConsultarIdGestor(ComboGestor.Text);
            consultaSolicitud = @"Insert into Solicitud(Fecha,Nombre,Monto,Tipo,Plazo,Interes,PagoIndividual,Integrantes,IDcliente,IdPromotor,IdGestor,Estado,correo)
                             values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + txtNombreSolicitud.Text + "','" + txtMontoTotal.Text + "', '" + txtTipo.Text + "','" + txtplazo.Text + "','" + txtInteres.Text + "','" + Conversion.Val(txtMontoTotal.Text) / 1000d * Conversion.Val(txtInteres.Text) + "','" + txtIntegrantes.Text + "','" + txtResponsable.Text + "','" + idpromotor + "','" + idgestor + @"','I','0') 
                             SELECT SCOPE_IDENTITY()";
            comandoSolicitud = new SqlCommand();
            comandoSolicitud.Connection = Module1.conexionempresa;
            comandoSolicitud.CommandText = consultaSolicitud;
            idSolicitud = Conversions.ToInteger(comandoSolicitud.ExecuteScalar());

            SqlCommand comandoCronograma;
            string consultaCronograma;
            string tiempo = DateAndTime.TimeOfDay.ToString("HH:mm:ss");
            consultaCronograma = "insert into CronogramaSolicitud values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tiempo + "','" + idSolicitud + "','Se registró la solicitud por " + Module1.nmusr + "')";
            comandoCronograma = new SqlCommand();
            comandoCronograma.Connection = Module1.conexionempresa;
            comandoCronograma.CommandText = consultaCronograma;
            comandoCronograma.ExecuteNonQuery();


            foreach (DataGridViewRow row in dtdatos.Rows)
            {
                SqlCommand comandoDatosSolicitud;
                string consultaDatosSolicitud;
                consultaDatosSolicitud = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(@"INSERT INTO [dbo].[DatosSolicitud]
           ([IdSolicitud]
           ,[Monto]
           ,[IdCliente]
           ,[Edad]
           ,[Telefono]
           ,[Celular]
           ,[TiempoEnDomicilio]
           ,[Calle]
           ,[Noext]
           ,[Noint]
           ,[CodigoPostal]
           ,[Colonia]
           ,[Ciudad]
           ,[EstadoCliente]
           ,[EntreCalles]
           ,[Conyuge]
           ,[RelacionConyuge]
           ,[DondeTrabaja]
           ,[SeDedica]
           ,[QueVende]
           ,[Antiguedad]
           ,[Horarios]
           ,[TipoEstablecimiento]
           ,[IngresoPmensual]
           ,[FrecuenciaCobro]
           ,[CalleTrabajo]
           ,[NoextTrabajo]
           ,[NointTrabajo]
           ,[CodigoPostalTrabajo]
           ,[ColoniaTrabajo]
           ,[TelefonoTrabajo]
           ,[JefeDirecto]
           ,[Objetivo]
           ,[NombreR1]
           ,[TelefonoR1]
           ,[RelacionR1]
           ,[NombreR2]
           ,[TelefonoR2]
           ,[RelacionR2]
           ,[Enfermedad]
           ,[FamiliasEnCasa]
           ,[DeudasCon]
           ,[Servicios]
           ,[PersonasDependientes]
           ,[Empleados]
           ,[FrecuenciaInversion]
           ,[ObservacionesDomicilio]
           ,[HorarioVerificacion]
           ,[MontoAutorizado]
           ,[Comentarios]
           ,[Estado]
           ,[CodigoPostalR1]
           ,[ColoniaR1]
           ,[CalleR1]
           ,[NoExtR1]
           ,[NoIntR1]
           ,[CodigoPostalR2]
           ,[ColoniaR2]
           ,[CalleR2]
           ,[NoExtR2]
           ,[NoIntR2]
           ,[Hijos]
           ,[ColoniaReal]
           ,[DomicilioAlterno]
           ,[TelefonoConyuge]
           ,[OcupacionConyuge]
           ,[MontoMaximoAutorizado]
          
)
     VALUES
           ('" + idSolicitud + "','", row.Cells[2].Value), "','"), row.Cells[0].Value), "','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','P','','','','','','','','','','','','','','','','')"));
                comandoDatosSolicitud = new SqlCommand();
                comandoDatosSolicitud.Connection = Module1.conexionempresa;
                comandoDatosSolicitud.CommandText = consultaDatosSolicitud;
                comandoDatosSolicitud.ExecuteNonQuery();

            }



        }

        private void btn_Procesar_Click(object sender, EventArgs e)
        {

            if (dtdatos.Rows.Count > 0)
            {
                if (tipocredito == "L")
                {
                    My.MyProject.Forms.Autorizacion.tipoAutorizacion = "SatiModSolicitudesAgregarLegales";
                    My.MyProject.Forms.Autorizacion.ShowDialog();
                    if (autorizado)
                    {
                        My.MyProject.Forms.Cargando.Show();
                        My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Procesando";
                        BackgroundSolicitudLegal.RunWorkerAsync();
                    }
                    else
                    {
                        MessageBox.Show("No fue autorizado");
                    }
                }
                else if (string.IsNullOrEmpty(ComboGestor.Text))
                {
                    MessageBox.Show("Selecciona el gestor");
                }
                else if (string.IsNullOrEmpty(ComboPromotor.Text))
                {
                    MessageBox.Show("Selecciona el promotor");
                }
                else
                {

                    My.MyProject.Forms.Autorizacion.tipoAutorizacion = "SatiModSolicitudesAgregar";
                    My.MyProject.Forms.Autorizacion.ShowDialog();
                    if (autorizado)
                    {
                        DataTable DtGrid;
                        DtGrid = DatagridviewToDt(dtdatos);
                        My.MyProject.Forms.vistPreviaSolicitud.nombre = txtNombreSolicitud.Text;
                        My.MyProject.Forms.vistPreviaSolicitud.Monto = Conversions.ToDouble(txtMontoTotal.Text);
                        My.MyProject.Forms.vistPreviaSolicitud.plazo = Conversions.ToInteger(txtplazo.Text);
                        My.MyProject.Forms.vistPreviaSolicitud.tipo = lblTipo.Text;
                        My.MyProject.Forms.vistPreviaSolicitud.intere = Conversions.ToDouble(txtInteres.Text);
                        My.MyProject.Forms.vistPreviaSolicitud.promotor = ComboPromotor.Text;
                        My.MyProject.Forms.vistPreviaSolicitud.gestor = ComboGestor.Text;
                        My.MyProject.Forms.vistPreviaSolicitud.dataIntegrantes = DtGrid;
                        My.MyProject.Forms.vistPreviaSolicitud.ShowDialog();
                        if (continuar == true)
                        {
                            My.MyProject.Forms.Cargando.Show();
                            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Procesando";
                            BackgroundWorker1.RunWorkerAsync();
                        }
                        else
                        {

                        }
                    }

                    else
                    {
                        MessageBox.Show("No fue autorizado");
                    }


                }
            }

            else
            {
                MessageBox.Show("La solicitud no cuenta con ningún integrante");
            }

        }

        private void dtdatos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dtdatos.Rows.Count != 0)
                {
                    dtdatos.Rows.RemoveAt(dtdatos.CurrentCell.RowIndex);
                    totalintegrantes -= 1;
                    txtIntegrantes.Text = totalintegrantes.ToString();
                }

            }
        }

        private void CheckNombre_CheckedChanged(object sender)
        {
            if (CheckNombre.Checked)
            {
                usarNombre = true;
            }
            else
            {

                usarNombre = false;

            }
        }

        private DataTable DatagridviewToDt(DataGridView dtv)
        {
            var dt = new DataTable();

            // Adding the Columns.
            foreach (DataGridViewColumn column in dtv.Columns)
                dt.Columns.Add(column.HeaderText, typeof(string));

            // Adding the Rows.
            foreach (DataGridViewRow row in dtv.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
            }
            return dt;
        }

        private void BackgroundLegal_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Module1.iniciarconexionempresa();
                string consulta;
                consulta = "Select id,nombre from empleados where tipo = 'L'";
                adapterLegal = new SqlDataAdapter(consulta, Module1.conexionempresa);
                dataLegal = new DataSet();
                adapterLegal.Fill(dataLegal);
                empezar = true;
            }
            catch (Exception ex)
            {
                empezar = false;
                MessageBox.Show("Ha ocurrido un error " + ex.Message);
            }
        }

        private void ComboLegal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BackgroundGestores_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Promotores";
            BackgroundPromotores.RunWorkerAsync();

        }

        private void BackgroundSolicitudLegal_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            SqlCommand comandoSolicitud;
            string consultaSolicitud;

            int idpromotor;
            int idgestor;
            idpromotor = ConsultarIdPromotor(ComboPromotor.Text);
            idgestor = ConsultarIdGestor(ComboGestor.Text);
            consultaSolicitud = @"Insert into Solicitud(Fecha,Nombre,Monto,Tipo,Plazo,Interes,PagoIndividual,Integrantes,IDcliente,IdPromotor,IdGestor,Estado)
                             values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + txtNombreSolicitud.Text + "','" + txtMontoTotal.Text + "', '" + txtTipo.Text + "','" + txtplazo.Text + "','" + txtInteres.Text + "','" + Conversion.Val(txtMontoTotal.Text) / 1000d * Conversion.Val(txtInteres.Text) + "','" + txtIntegrantes.Text + "','" + txtResponsable.Text + "','" + idpromotor + "','" + idgestor + @"','N') 
                             SELECT SCOPE_IDENTITY()";
            comandoSolicitud = new SqlCommand();
            comandoSolicitud.Connection = Module1.conexionempresa;
            comandoSolicitud.CommandText = consultaSolicitud;
            idSolicitud = Conversions.ToInteger(comandoSolicitud.ExecuteScalar());

            SqlCommand comandoCronograma;
            string consultaCronograma;
            string tiempo = DateAndTime.TimeOfDay.ToString("HH:mm:ss");
            consultaCronograma = "insert into CronogramaSolicitud values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tiempo + "','" + idSolicitud + "','Se registró la solicitud por " + Module1.nmusr + "')";
            comandoCronograma = new SqlCommand();
            comandoCronograma.Connection = Module1.conexionempresa;
            comandoCronograma.CommandText = consultaCronograma;
            comandoCronograma.ExecuteNonQuery();


            foreach (DataGridViewRow row in dtdatos.Rows)
            {
                SqlCommand comandoDatosSolicitud;
                string consultaDatosSolicitud;
                consultaDatosSolicitud = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(@"INSERT INTO [dbo].[DatosSolicitud]
           ([IdSolicitud]
           ,[Monto]
           ,[IdCliente]
           ,[Edad]
           ,[Telefono]
           ,[Celular]
           ,[TiempoEnDomicilio]
           ,[Calle]
           ,[Noext]
           ,[Noint]
           ,[CodigoPostal]
           ,[Colonia]
           ,[Ciudad]
           ,[EstadoCliente]
           ,[EntreCalles]
           ,[Conyuge]
           ,[RelacionConyuge]
           ,[DondeTrabaja]
           ,[SeDedica]
           ,[QueVende]
           ,[Antiguedad]
           ,[Horarios]
           ,[TipoEstablecimiento]
           ,[IngresoPmensual]
           ,[FrecuenciaCobro]
           ,[CalleTrabajo]
           ,[NoextTrabajo]
           ,[NointTrabajo]
           ,[CodigoPostalTrabajo]
           ,[ColoniaTrabajo]
           ,[TelefonoTrabajo]
           ,[JefeDirecto]
           ,[Objetivo]
           ,[NombreR1]
           ,[TelefonoR1]
           ,[RelacionR1]
           ,[NombreR2]
           ,[TelefonoR2]
           ,[RelacionR2]
           ,[Enfermedad]
           ,[FamiliasEnCasa]
           ,[DeudasCon]
           ,[Servicios]
           ,[PersonasDependientes]
           ,[Empleados]
           ,[FrecuenciaInversion]
           ,[ObservacionesDomicilio]
           ,[HorarioVerificacion]
           ,[MontoAutorizado]
           ,[Comentarios]
           ,[Estado])
            VALUES
           ('" + idSolicitud + "','", row.Cells[2].Value), "','"), row.Cells[0].Value), "','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','P')"));
                comandoDatosSolicitud = new SqlCommand();
                comandoDatosSolicitud.Connection = Module1.conexionempresa;
                comandoDatosSolicitud.CommandText = consultaDatosSolicitud;
                comandoDatosSolicitud.ExecuteNonQuery();

            }


            SqlCommand comandoLegal;
            string consultaLegal;
            int idGestorLegal;
            idGestorLegal = ConsultarIdGestorLegal(ComboLegal.Text);
            consultaLegal = "insert into Legales values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tiempo + "','" + txtNombreSolicitud.Text + "','" + txtMontoTotal.Text + "','" + txtTotalMoratorios.Text + "','" + (Conversion.Val(txtMontoTotal.Text) + Conversion.Val(txtTotalMoratorios.Text)) + "','" + txtTotal.Text + "','" + txtTipo.Text + "','" + txtIntegrantes.Text + "','" + txtResponsable.Text + "','" + idGestorLegal + "','" + idSolicitud + "','E','" + txtplazo.Text + "','','','','','','','')";
            comandoLegal = new SqlCommand();
            comandoLegal.Connection = Module1.conexionempresa;
            comandoLegal.CommandText = consultaLegal;
            comandoLegal.ExecuteNonQuery();

        }

        private void BackgroundPromotores_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Legales";
            BackgroundLegal.RunWorkerAsync();
        }


        private int ConsultarIdPromotor(string nombre)
        {
            int idEmpleado =0;

            foreach (DataRow row in dataPromotores.Tables[0].Rows)
            {
                if ((row["nombre"].ToString() ?? "") == (nombre ?? ""))
                {
                    idEmpleado = (int)Math.Round(Conversion.Val(row["id"].ToString()));
                    break;
                }
            }



            return idEmpleado;
        }
        private int ConsultarIdGestor(string nombre)
        {
            int idEmpleado =0;

            foreach (DataRow row in dataGestores.Tables[0].Rows)
            {
                if ((row["nombre"].ToString() ?? "") == (nombre ?? ""))
                {
                    idEmpleado = (int)Math.Round(Conversion.Val(row["id"].ToString()));
                    break;
                }
            }



            return idEmpleado;
        }
        private string ConsultarCorreoGestor(string nombre)
        {
            string CorreoEmpleado="";

            foreach (DataRow row in dataGestores.Tables[0].Rows)
            {
                if ((row["nombre"].ToString() ?? "") == (nombre ?? ""))
                {
                    CorreoEmpleado = Conversion.Val(row["Correo"].ToString()).ToString();
                    break;
                }
            }



            return CorreoEmpleado;
        }

        private int ConsultarIdGestorLegal(string nombre)
        {
            int idEmpleado =0;

            foreach (DataRow row in dataLegal.Tables[0].Rows)
            {
                if ((row["nombre"].ToString() ?? "") == (nombre ?? ""))
                {
                    idEmpleado = (int)Math.Round(Conversion.Val(row["id"].ToString()));
                    break;
                }
            }



            return idEmpleado;
        }


        private void dtdatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtdatos.Rows.Count != 0)
            {
                txtResponsable.Text = Conversions.ToString(dtdatos.CurrentRow.Cells[0].Value);
            }
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();
            My.MyProject.Forms.DatosSolicitud.idSolicitud = idSolicitud;
            My.MyProject.Forms.DatosSolicitud.tipoSolicitud = Conversions.ToInteger(txtTipo.Text);
            My.MyProject.Forms.DatosSolicitud.correoGestor = correoEmpleado;
            My.MyProject.Forms.DatosSolicitud.Show();
            Close();
        }

        private void BackgroundLegal_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ComboPromotor.Items.Clear();

            foreach (DataRow row in dataPromotores.Tables[0].Rows)

                ComboPromotor.Items.Add(row["nombre"]);
            ComboPromotor.SelectedIndex = 0;

            ComboGestor.Items.Clear();

            foreach (DataRow row in dataGestores.Tables[0].Rows)

                ComboGestor.Items.Add(row["nombre"]);
            ComboGestor.SelectedIndex = 0;


            ComboLegal.Items.Clear();

            foreach (DataRow row in dataLegal.Tables[0].Rows)

                ComboLegal.Items.Add(row["nombre"]);
            ComboLegal.SelectedIndex = 0;

            My.MyProject.Forms.Cargando.Close();
        }

        private void BackgroundSolicitudLegal_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();
            My.MyProject.Forms.DatosSolicitud.idSolicitud = idSolicitud;
            My.MyProject.Forms.DatosSolicitud.tipoSolicitud = Conversions.ToInteger(txtTipo.Text);
            My.MyProject.Forms.DatosSolicitud.Show();
            Close();
        }
    }
}