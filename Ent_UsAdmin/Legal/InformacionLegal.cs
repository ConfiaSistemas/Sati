using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Spire.Doc;
using WinControls.ListView;
using Xceed.Words.NET;

namespace ConfiaAdmin
{

    public partial class InformacionLegal
    {
        public int idCredito;
        private System.Data.DataTable dataClientes;
        private SqlDataAdapter adapterClientes;
        private System.Data.DataTable dataCalendario;
        private SqlDataAdapter adapterCalendario;
        private System.Data.DataTable dataDocumentos;
        private SqlDataAdapter adapterDocumentos;
        private bool bloqueado = false;
        private double DeudaTotal;
        private double Pagado;
        private double restante;
        private System.Data.DataTable dataGestiones;
        private SqlDataAdapter adapterGestiones;
        private System.Data.DataTable dataActualizaciones;
        private SqlDataAdapter adapterActualizaciones;
        private System.Data.DataTable dataGastos;
        private SqlDataAdapter adapterGastos;
        private string estado;
        private DateTime FechaConvenio;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private int plazo;
        private System.Data.DataTable dataCalConvenio;
        private SqlDataAdapter adapterCalConvenio;
        private string domicilio;
        private string nombreResponsable;
        private string Celular, telefono;
        private double montoConvenio;
        private double gastos;
        private double multas;

        public InformacionLegal()
        {
            InitializeComponent();
        }
        private void InformacionSolicitud_Load(object sender, EventArgs e)
        {
            MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            foreach (DataRow row in Module1.dataPermisos.Rows)
            {
                if (Conversions.ToBoolean(row["SatiModLegalModificar"]))
                {
                    btnGenerarCalendario.Enabled = true;
                    BunifuThinButton23.Enabled = true;
                    BunifuThinButton21.Enabled = true;
                    BunifuThinButton24.Enabled = true;
                }
                else
                {
                    btnGenerarCalendario.Enabled = false;
                    BunifuThinButton23.Enabled = false;
                    BunifuThinButton21.Enabled = false;
                    BunifuThinButton24.Enabled = false;
                }
            }

            Panel2.Size = new Size(51, 79);
            Panel2.Location = new System.Drawing.Point(Width - Panel2.Width, TabControl1.Location.Y - Panel2.Height);
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Información";
            My.MyProject.Forms.Cargando.TopMost = true;
            BackgroundClientes.RunWorkerAsync();

        }

        private void BackgroundClientes_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consultaCredito;
            SqlCommand comandoCredito;
            SqlDataReader readerCredito;

            consultaCredito = @" select credlegal.*, isnull((select sum(monto) from gastoslegales where idcredito = credlegal.id),0) as gastos,
isnull((select sum(Interes) from CalendarioLegales where idcredito = credlegal.id),0)multas
from (select id,Fecha,Nombre,Credito,Moratorios,DeudaAP,TotalDeuda,Estado,FechaInicio,FechaFin,FechaConvenio,plazo,montoconvenio from legales where id = '" + idCredito + "') credlegal";
            comandoCredito = new SqlCommand();
            comandoCredito.Connection = Module1.conexionempresa;
            comandoCredito.CommandText = consultaCredito;
            readerCredito = comandoCredito.ExecuteReader();
            while (readerCredito.Read())
            {
                lblnombre.Text = Conversions.ToString(readerCredito["Nombre"]);
                lblfecha.Text = Conversions.ToString(readerCredito["fecha"]);
                lblParteCredito.Text = Strings.FormatCurrency(readerCredito["credito"]);
                lblParteMoratorios.Text = Strings.FormatCurrency(readerCredito["moratorios"]);
                lblSubTotal.Text = Strings.FormatCurrency(readerCredito["deudaAp"], 2);
                lblTotal.Text = Strings.FormatCurrency(readerCredito["TotalDeuda"], 2);
                DeudaTotal = Conversions.ToDouble(readerCredito["TotalDeuda"]);
                estado = Conversions.ToString(readerCredito["Estado"]);
                FechaConvenio = Conversions.ToDate(readerCredito["FechaConvenio"]);
                fechaInicio = Conversions.ToDate(readerCredito["FechaInicio"]);
                fechaFin = Conversions.ToDate(readerCredito["FechaFin"]);
                plazo = Conversions.ToInteger(readerCredito["Plazo"]);
                gastos = Conversions.ToDouble(readerCredito["gastos"]);
                multas = Conversions.ToDouble(readerCredito["multas"]);
                if (readerCredito["montoconvenio"] is DBNull)
                {
                    montoConvenio = 0d;
                }
                else
                {
                    montoConvenio = Conversions.ToDouble(readerCredito["montoconvenio"]);
                }
                lblConvenio.Text = Strings.FormatCurrency(montoConvenio, 2);
                DeudaTotal = DeudaTotal + gastos;
            }
            lblTotal.Text = Strings.FormatCurrency(DeudaTotal, 2);
            readerCredito.Close();
            int tipoDoc;
            tipoDoc = Module1.ObtenerTipoDoc("Legal");
            SqlCommand comandoPagos;
            string consultaPagos;
            consultaPagos = "select sum(subtotal) AS pagado from ticket where idCredito = '" + idCredito + "' and tipoDoc = '" + tipoDoc + "' and estado = 'A'";
            comandoPagos = new SqlCommand();
            comandoPagos.Connection = Module1.conexionempresa;
            comandoPagos.CommandText = consultaPagos;
            if (comandoPagos.ExecuteScalar() is DBNull)
            {
                Pagado = 0d;
            }
            else
            {
                Pagado = Conversions.ToDouble(comandoPagos.ExecuteScalar());
            }

            if (montoConvenio == 0d)
            {
                restante = DeudaTotal - Pagado;
            }
            else
            {
                restante = montoConvenio + multas - Pagado;
            }
            // restante = DeudaTotal - Pagado
            lblMultas.Text = Strings.FormatCurrency(multas);
            lblRestante.Text = Strings.FormatCurrency(restante);
            lblAbonado.Text = Strings.FormatCurrency(Pagado);
            lblgastos.Text = Strings.FormatCurrency(gastos, 2);
            SqlCommand comandoDomicilio;
            string consultaDomicilio;
            SqlDataReader readerNombre;
            consultaDomicilio = "if exists(select * from Legales where id = '" + idCredito + @"' and idSolicitud=0)
begin
select nombre,Direccion as domicilio,CP,Municipio,Estado,Telefono,'0' as celular from DireccionesLegales where idLegal = '" + idCredito + @"'
end
else
begin

select CONCAT(domicilioCompleto.Calle,' ',domicilioCompleto.Noext,' ',domicilioCompleto.Noint,' ',domicilioCompleto.Colonia) as Domicilio,CONCAT(Nombre,' ',ApellidoPaterno,' ',ApellidoMaterno) as nombre,Celular,Telefono from
(select domicilio.Calle,domicilio.Noext, (case when 
domicilio.Noint = 0 then
'' else
CONCAT('Interior ',domicilio.Noint) end) as Noint,Colonia,Nombre,ApellidoPaterno,ApellidoMaterno,Celular,Telefono
 from
(select DatosSolicitud.Calle,DatosSolicitud.Noext,DatosSolicitud.Noint,DatosSolicitud.Colonia,Clientes.Nombre,Clientes.ApellidoPaterno,Clientes.ApellidoMaterno,DatosSolicitud.Celular,DatosSolicitud.Telefono from legales inner join Solicitud on legales.IdSolicitud =  Solicitud.id inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud inner join Clientes on DatosSolicitud.IdCliente = Clientes.id where legales.id = '" + idCredito + @"') domicilio) domicilioCompleto
end";
            comandoDomicilio = new SqlCommand();
            comandoDomicilio.Connection = Module1.conexionempresa;
            comandoDomicilio.CommandText = consultaDomicilio;
            readerNombre = comandoDomicilio.ExecuteReader();
            if (readerNombre.HasRows)
            {
                while (readerNombre.Read())
                {
                    domicilio = Conversions.ToString(readerNombre["Domicilio"]);
                    nombreResponsable = Conversions.ToString(readerNombre["nombre"]);
                    telefono = Conversions.ToString(readerNombre["Telefono"]);
                    Celular = Conversions.ToString(readerNombre["celular"]);
                }
            }

            readerNombre.Close();
            string consultaClientes;
            consultaClientes = "if exists(select * from Legales where id = '" + idCredito + @"' and idSolicitud=0 ) 
begin
select Nombre,Direccion as Domicilio,CP,Colonia,Municipio,Estado,Telefono,'0' as Celular from DireccionesLegales where idLegal ='" + idCredito + @"'
end
else
begin

select CONCAT(Nombre,' ',ApellidoPaterno,' ',ApellidoMaterno) as Nombre, CONCAT(domicilioCompleto.Calle,' ',domicilioCompleto.Noext,' ',domicilioCompleto.Noint,' ',domicilioCompleto.Colonia) as Domicilio,CodigoPostal as CP,Colonia,Ciudad as Municipio,EstadoCliente as Estado,Telefono,Celular
from
(select domicilio.Calle,domicilio.Noext,domicilio.CodigoPostal,domicilio.ciudad,domicilio.EstadoCliente,domicilio.Colonia, (case when 
domicilio.Noint = 0 then
'' else
CONCAT('Interior ',domicilio.Noint) end) as Noint,Nombre,ApellidoPaterno,ApellidoMaterno,Celular,Telefono
 from
(select DatosSolicitud.Calle,DatosSolicitud.Noext,DatosSolicitud.Noint,DatosSolicitud.Colonia,Clientes.Nombre,Clientes.ApellidoPaterno,Clientes.ApellidoMaterno,DatosSolicitud.Celular,DatosSolicitud.Telefono, DatosSolicitud.CodigoPostal,DatosSolicitud.Ciudad,DatosSolicitud.EstadoCliente
from legales inner join Solicitud on legales.IdSolicitud =  Solicitud.id inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud inner join Clientes on DatosSolicitud.IdCliente = Clientes.id inner join Credito on Credito.IdSolicitud = Solicitud.id
where legales.id = '" + idCredito + @"') domicilio) domicilioCompleto
end";
            adapterClientes = new SqlDataAdapter(consultaClientes, Module1.conexionempresa);
            dataClientes = new System.Data.DataTable();
            adapterClientes.Fill(dataClientes);

        }

        private void BackgroundClientes_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Text = "Información Legal " + lblnombre.Text;
            dtClientes.DataSource = dataClientes;
            BackgroundSolicitud.RunWorkerAsync();
            dtSolicitud.Rows.Clear();
            dtSolicitud.ScrollBars = ScrollBars.None;
        }

        private void BackgroundSolicitud_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {
                string strimpuestos;
                Module1.iniciarconexionempresa();

                strimpuestos = "select Solicitud.id,format(Solicitud.Fecha,'dd-MM-yy') as Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo from legales inner join Solicitud on legales.IdSolicitud = Solicitud.id where legales.id = '" + idCredito + "'";




                var ejec = new SqlCommand(strimpuestos);
                ejec.Connection = Module1.conexionempresa;
                string id, nombre, valor, factor, tipo;

                var myreaderimpuestos = ejec.ExecuteReader();
                while (myreaderimpuestos.Read())
                {
                    id = Conversions.ToString(myreaderimpuestos["id"]);
                    if (myreaderimpuestos["montoAutorizado"] is DBNull)
                    {
                        valor = 0.ToString();
                    }
                    else
                    {
                        valor = Conversions.ToString(myreaderimpuestos["montoAutorizado"]);
                    }

                    dtSolicitud.Rows.Add(id, myreaderimpuestos["fecha"], Strings.FormatCurrency(myreaderimpuestos["Monto"], 2), Strings.FormatCurrency(valor, 2), myreaderimpuestos["tipo"]);
                }
                myreaderimpuestos.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BackgroundSolicitud_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtSolicitud.ScrollBars = ScrollBars.Both;
            BackgroundCalendario.RunWorkerAsync();

        }

        private void BackgroundCalendario_DoWork(object sender, DoWorkEventArgs e)
        {
            string consultaCalendario;
            consultaCalendario = "select format(calendariolegales.FechaPago,'dd-MM-yy') as FechaPago,calendariolegales.Npago,calendariolegales.Monto,calendariolegales.Interes,Calendariolegales.Pendiente from legales inner join calendarioLegales on legales.id = calendariolegales.idcredito where legales.id = '" + idCredito + "'";
            adapterCalendario = new SqlDataAdapter(consultaCalendario, Module1.conexionempresa);
            dataCalendario = new System.Data.DataTable();
            adapterCalendario.Fill(dataCalendario);
        }

        private void BackgroundCalendario_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtCalendarios.DataSource = dataCalendario;
            BackgroundDocumentos.RunWorkerAsync();

        }

        private void BackgroundDocumentos_DoWork(object sender, DoWorkEventArgs e)
        {
            string consultaDocumentos;
            consultaDocumentos = "select TiposdeDocumentosSolicitud.Nombre,DocumentosLegales.imagen from legales inner join DocumentosLegales on legales.id = DocumentosLegales.IdCredito inner join TiposdeDocumentosSolicitud on DocumentosLegales.Tipo = TiposdeDocumentosSolicitud.id where legales.id = '" + idCredito + "'";
            adapterDocumentos = new SqlDataAdapter(consultaDocumentos, Module1.conexionempresa);
            dataDocumentos = new System.Data.DataTable();
            adapterDocumentos.Fill(dataDocumentos);
        }

        private void BackgroundDocumentos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtdatosDocumentos.DataSource = dataDocumentos;
            BackgroundPagos.RunWorkerAsync();

            // Cargando.Close()
        }


        private void dtSolicitud_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            My.MyProject.Forms.DatosConsultaSolicitud.idSolicitud = Conversions.ToInteger(dtSolicitud.Rows[dtSolicitud.CurrentRow.Index].Cells[0].Value);
            // DatosConsultaSolicitud.TipoSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(5).Value
            My.MyProject.Forms.DatosConsultaSolicitud.Show();
        }



        private void dtdatosDocumentos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            My.MyProject.Forms.VistaDocumento.PictureBox1.Image = (System.Drawing.Image)dtdatosDocumentos.Rows[dtdatosDocumentos.CurrentRow.Index].Cells[1].FormattedValue;
            My.MyProject.Forms.VistaDocumento.ShowDialog();
        }

        private void BackgroundPagos_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            TreeListView1.Nodes.Clear();


            int tipoDocLegal;
            tipoDocLegal = Module1.ObtenerTipoDoc("Legal");
            SqlCommand comandoTicket;
            string consulta;
            SqlDataReader readerTicket;



            consulta = @"select id,Recibido,(case when tipo = 'Legal' or tipo = 'Depósito Legal' then  ISNULL((select nombre from Legales where id = pagos.idCredito),0) 		
							   when tipo = 'Extra' then Concepto
							  
							   else ISNULL((select nombre from Credito where id = pagos.idCredito),0) 		end) as nombre,idCredito,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja from
(select Ticket.Id,Ticket.Recibido,Ticket.IdCredito,Ticket.Fecha,Ticket.hora,Ticket.PagoNormal,Ticket.Intereses,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id  where  ticket.idcredito = '" + idCredito + "' and (Ticket.TipoDoc = '" + tipoDocLegal + "' or ticket.tipodoc = (select id from tipodoc where nombre = 'Depósito Legal') ))pagos order by Fecha,Hora asc";


            comandoTicket = new SqlCommand();
            comandoTicket.Connection = Module1.conexionempresa;
            comandoTicket.CommandText = consulta;
            readerTicket = comandoTicket.ExecuteReader();
            if (readerTicket.HasRows)
            {
                while (readerTicket.Read())
                {
                    var liItem = new TreeListNode(Conversions.ToString(readerTicket["id"].ToString()));
                    {
                        var withBlock = liItem.SubItems;
                        withBlock.Add(readerTicket["idcredito"].ToString());
                        withBlock.Add(readerTicket["nombre"].ToString());
                        withBlock.Add(Strings.FormatCurrency(readerTicket["pagonormal"].ToString()));
                        withBlock.Add(Strings.FormatCurrency(readerTicket["Intereses"].ToString()));
                        withBlock.Add(Strings.FormatCurrency(readerTicket["total"].ToString()));
                        withBlock.Add(readerTicket["Fecha"].ToString());
                        withBlock.Add(readerTicket["Hora"].ToString());
                        withBlock.Add(readerTicket["Tipo"].ToString());
                        withBlock.Add(readerTicket["Caja"].ToString());
                    }

                    SqlCommand COMANDOdetalle;
                    string consultaDetalle;
                    SqlDataReader readerDetalle;
                    consultaDetalle = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select concat(ticketdetalle.concepto,' de ','Pago ', calendariolegales.NPago) as pago,pagonormal,intereses,ticketdetalle.monto from ticketdetalle inner join calendariolegales on ticketdetalle.idpago = CalendarioLegales.idpago where  idTicket = '", readerTicket["id"]), "'"));
                    COMANDOdetalle = new SqlCommand();
                    COMANDOdetalle.Connection = Module1.conexionempresa;
                    COMANDOdetalle.CommandText = consultaDetalle;
                    readerDetalle = COMANDOdetalle.ExecuteReader();
                    if (readerDetalle.HasRows)
                    {
                        while (readerDetalle.Read())
                            _addSubItems((ContainerListViewObject)liItem.Nodes.Add(readerDetalle["pago"].ToString()), Conversions.ToDouble(readerDetalle["pagonormal"].ToString()), Conversions.ToDouble(readerDetalle["intereses"].ToString()), Conversions.ToDouble(readerDetalle["monto"].ToString()));
                    }
                    TreeListView1.Nodes.Add(liItem);
                }
            }
        }
        private void _addSubItems(ContainerListViewObject aObj, double pagonormal, double intereses, double total)
        {
            {
                var withBlock = aObj.SubItems;
                withBlock.Add("");
                withBlock.Add("");
                withBlock.Add(Strings.FormatCurrency(pagonormal));
                withBlock.Add(Strings.FormatCurrency(intereses));
                withBlock.Add(Strings.FormatCurrency(total));
            }
        }

        private void BackgroundPagos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Gestiones";
            BackgroundGestiones.RunWorkerAsync();
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

        private void InformacionLegal_MouseHover(object sender, EventArgs e)
        {
            for (int i = Panel2.Width; i >= 51; i -= 10)
            {
                Panel2.Width = i;
                Panel2.Location = new System.Drawing.Point(Width - Panel2.Width, TabControl1.Location.Y - Panel2.Height);
            }
            bloqueado = false;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_MouseHover(object sender, EventArgs e)
        {
            if (bloqueado)
            {
            }

            else
            {
                for (int i = 51; i <= 615; i += 10)
                {
                    Panel2.Width = i;
                    Panel2.Location = new System.Drawing.Point(Width - Panel2.Width, TabControl1.Location.Y - Panel2.Height);
                }
                bloqueado = true;
            }

        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.ActInformacionLegal.idCreditoLegal = idCredito.ToString();
            My.MyProject.Forms.ActInformacionLegal.Show();

        }

        private void btnGenerarCalendario_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.DocumentosCreditoLegal.idCredito = idCredito.ToString();
            My.MyProject.Forms.DocumentosCreditoLegal.Show();
        }

        private void BunifuThinButton23_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.AgregarGestionLegal.idCredito = idCredito.ToString();
            My.MyProject.Forms.AgregarGestionLegal.frmNombre = Text;
            My.MyProject.Forms.AgregarGestionLegal.Show();

        }

        private void BackgroundGestiones_DoWork(object sender, DoWorkEventArgs e)
        {
            string consultaGestiones;
            Module1.iniciarconexionempresa();
            consultaGestiones = "select id,Fecha,Concepto,NombreUsuario[Nombre Usuario] from gestioneslegales where idcredito = '" + idCredito + "'";
            adapterGestiones = new SqlDataAdapter(consultaGestiones, Module1.conexionempresa);
            dataGestiones = new System.Data.DataTable();
            adapterGestiones.Fill(dataGestiones);
        }

        private void BackgroundGestiones_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtGestiones.DataSource = dataGestiones;
            dtGestiones.Columns["Nombre Usuario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dtGestiones.Columns["Nombre Usuario"].Width = 180;
            dtGestiones.Columns[2].AutoSizeMode = (DataGridViewAutoSizeColumnMode)DataGridViewAutoSizeColumnsMode.Fill;
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Actualizaciones";
            BackgroundActualizaciones.RunWorkerAsync();

        }

        private void BackgroundActualizaciones_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consultaActualizaciones;
            consultaActualizaciones = "select Fecha,Hora,Campo,ValorAnterior,NuevoValor,Motivo from ActualizacionesLegal where idCreditoLegal = '" + idCredito + "'";
            adapterActualizaciones = new SqlDataAdapter(consultaActualizaciones, Module1.conexionempresa);
            dataActualizaciones = new System.Data.DataTable();
            adapterActualizaciones.Fill(dataActualizaciones);

        }

        private void BackgroundActualizaciones_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtActualizaciones.DataSource = dataActualizaciones;
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Gastos";
            BackgroundGastos.RunWorkerAsync();

        }

        private void BunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (estado == "C")
            {
                My.MyProject.Forms.IngresarDepositoLegal.idCredito = idCredito;
                My.MyProject.Forms.IngresarDepositoLegal.Show();
            }

            else if (estado == "Y")
            {
            }
            else
            {

                My.MyProject.Forms.AgregarGastosLegales.idCredito = idCredito.ToString();
                My.MyProject.Forms.AgregarGastosLegales.Show();
            }


        }

        private void BackgroundGastos_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consultaGastos;
            consultaGastos = "select Fecha,Monto,Concepto,Usuario,NombreUsuario from gastoslegales where idcredito = '" + idCredito + "'";
            adapterGastos = new SqlDataAdapter(consultaGastos, Module1.conexionempresa);
            dataGastos = new System.Data.DataTable();
            adapterGastos.Fill(dataGastos);
        }

        private void BackgroundGastos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtGastos.DataSource = dataGastos;
            if (estado == "C")
            {
                BunifuThinButton22.Enabled = true;
                BunifuThinButton24.Enabled = true;
                BunifuThinButton24.ButtonText = "Ingresar Depósito";
            }

            else if (estado == "Y")
            {
                BunifuThinButton22.Enabled = true;
                BunifuThinButton24.Enabled = false;
            }

            else
            {
                BunifuThinButton24.Enabled = true;
                BunifuThinButton22.Enabled = false;
                BunifuThinButton24.ButtonText = "Agregar Gastos";
            }
            My.MyProject.Forms.Cargando.Close();
        }

        private void BackgroundCalConvenio_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();




            string consultaCalendario;

            consultaCalendario = @"select t1.[Número de pago], t1.[Fecha de pago], t1.Monto,
        ISNULL((convert(varchar(3),t2.[Número de pago])),'-')as 'Número de pago ', ISNULL(t2.[Fecha de pago],'-')as 'Fecha de pago ',ISNULL(t2.Monto,'-')as 'Monto '
        from (select format(Fechapago,'dd/MM/yyyy') as 'Fecha de pago',npago as 'Número de pago',
        format(Monto+multas,'C','es-mx') as Monto from calendarioLegales where idcredito ='" + idCredito + @"')t1
        left join (select format(Fechapago,'dd/MM/yyyy') as 'Fecha de pago',npago as 'Número de pago',
        format(Monto+multas,'C','es-mx') as Monto from calendarioLegales where idcredito ='" + idCredito + @"')t2
        on t1.[Número de pago]=(t2.[Número de pago]-1) where t1.[Número de pago] % 2 <>0";
            adapterCalConvenio = new SqlDataAdapter(consultaCalendario, Module1.conexionempresa);
            dataCalConvenio = new System.Data.DataTable();
            adapterCalConvenio.Fill(dataCalConvenio);
            var documento = DocX.Load(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempLegal.docx");



            string firma;
            firma = "";
            documento.InsertParagraph(firma).FontSize(8d).Alignment = Alignment.center;
            documento.Save();
            documento.Dispose();

            dataTableToWord(dataCalConvenio);

        }

        private void dataTableToWord(System.Data.DataTable dt)
        {
            Microsoft.Office.Interop.Word.Application Word;
            Microsoft.Office.Interop.Word.Document Doc;
            Microsoft.Office.Interop.Word.Table Table;
            Range Rng;
            Microsoft.Office.Interop.Word.Paragraph Prf1;
            Microsoft.Office.Interop.Word.Paragraph Prf2;
            Microsoft.Office.Interop.Word.Paragraph Prf3;

            Word = (Microsoft.Office.Interop.Word.Application)Interaction.CreateObject("Word.Application");

            FileSystem.FileCopy(@"C:\ConfiaAdmin\SATI\PagareLegal.docx", @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempLegal.docx");
            object argFileName = @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempLegal.docx";
            Doc = Word.Documents.Open(ref argFileName);
            int NCol = dt.Columns.Count;
            int NRow = dt.Rows.Count;
            // alternativo

            object argIndex = @"\endofdoc";
            Table = Doc.Tables.Add(Doc.Bookmarks[ref argIndex].Range, dt.Rows.Count + 1, dt.Columns.Count);

            // Agregando Los Campos De La Grilla
            for (int i = 1, loopTo = NCol; i <= loopTo; i++)
            {
                Table.Cell(1, i).Range.Text = dt.Columns[i - 1].ColumnName.ToString();
                Table.Cell(1, i).Width = 50f;
            }
            // Agregando Los Registros A La Tabla
            for (int Fila = 0, loopTo1 = NRow - 1; Fila <= loopTo1; Fila++)
            {
                for (int Col = 0, loopTo2 = NCol - 1; Col <= loopTo2; Col++)
                {
                    if (!ReferenceEquals(dt.Rows[NRow - 1][Col].ToString(), DBNull.Value))
                    {
                        Table.Cell(Fila + 2, Col + 1).Range.Text = dt.Rows[Fila][Col].ToString();
                        Table.Cell(Fila + 2, Col + 1).Width = 50f;
                    }
                }
                // Incremento

            }
            // Negrita y Kursiva Para Los Nombres De Los Campos
            Table.Rows[1].Range.Font.Bold = Conversions.ToInteger(true);
            Table.Rows[1].Range.Font.Italic = Conversions.ToInteger(false);
            for (int i = 1, loopTo3 = Table.Rows.Count; i <= loopTo3; i++)
                Table.Rows[i].Range.Font.Size = 8f;


            // Boder De La Tabla
            Table.Borders.InsideLineStyle = WdLineStyle.wdLineStyleEngrave3D;
            Table.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleEngrave3D;
            Table.Borders.InsideColor = WdColor.wdColorBlack;
            object argIndex1 = @"\endofdoc";
            Rng = Doc.Bookmarks[ref argIndex1].Range;
            // Table.Range.Paragraphs.Alignment = WdParagraphAlignment.wdAlignParagraphCenter
            // Rng.InsertParagraphAfter()
            Doc.Tables[1].Rows.Alignment = WdRowAlignment.wdAlignRowCenter;
            Doc.Save();
            Doc.Close();
            // Word = Nothing
            Word.Application.Quit();


        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Generando Convenio";
            My.MyProject.Forms.Cargando.TopMost = true;
            BackgroundCalConvenio.RunWorkerAsync();
        }

        private void BackgroundCalConvenio_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var NumeroLetra = new NumLetra();
            // Dim MSWord As New Word.Application
            // Dim Documento As Word.Document
            // Dim fechaActual As Date
            // fechaActual = Now

            // FileCopy("C:\ConfiaAdmin\SATI\Pagare.docx", "C:\ConfiaAdmin\SATI\TEMPDOCS\TempPagare.docx")
            var documento = DocX.Load(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempLegal.docx");
            documento.ReplaceText("%%FECHACREDITO%%", FechaConvenio.ToString("dd/MM/yyyy"));
            documento.ReplaceText("%%TELEFONORESPONSABLE%%", telefono);
            documento.ReplaceText("%%CELULARRESPONSABLE%%", Celular);
            // documento.ReplaceText("%%DOMICILIORESPONSABLE%%", domicilio)
            documento.ReplaceText("%%DOMICILIORESPONSABLE%%", domicilio);
            documento.ReplaceText("%%NOMBRERESPONSABLE%%", nombreResponsable);
            documento.ReplaceText("%%TOTALDEUDALETRAS%%", NumeroLetra.Convertir(montoConvenio.ToString(), true));
            documento.ReplaceText("%%TOTALDEUDA%%", Strings.FormatCurrency(montoConvenio, 2));

            string para = "Bueno por " + Strings.FormatCurrency(montoConvenio, 2) + " " + NumeroLetra.Convertir(montoConvenio.ToString(), true) + " En la ciudad de URUAPAN MICHOACAN, a " + Conversions.ToDate(FechaConvenio).ToString("dd") + " de " + Conversions.ToDate(FechaConvenio).ToString("MMMM") + " " + Conversions.ToDate(FechaConvenio).ToString("yyyy") + ";  La titular " + nombreResponsable + " debo (emos) pagare (emos) incondicionalmente por este PAGARE a la orden de   Prestamos Confía S.A. de C.V. EN URUAPAN Estado MICHOACAN, EL DIA " + Conversions.ToDate(FechaConvenio.AddDays(5d)).ToString("dd") + " de " + Conversions.ToDate(FechaConvenio.AddDays(5d)).ToString("MMMM") + " " + Conversions.ToDate(FechaConvenio.AddDays(5d)).ToString("yyyy") + ", la cantidad de por " + Strings.FormatCurrency(montoConvenio, 2) + " " + NumeroLetra.Convertir(montoConvenio.ToString(), true) + @" Valor recibido a nuestra satisfacción. 
El suscriptor reconoce y acepta que la falta de pago oportuno de una o más amortizaciones pactadas conforme a este pagare, generara el vencimiento anticipado de los pagos que falten por efectuar, siendo exigible por  Prestamos Confia S.A. de C.V., el pago inmediato de todas las amortizaciones no pagadas, más intereses moratorios del 7% siete por ciento mensual, pagadero en esta ciudad juntamente con el principal.
Se aplicará en lo conducente los numerales  1, 2, 3, 4, 5, 15, 21, 23, 24, 26, 29, 33, 109, 110, 111, 113, 114, 150, 151, 152, 170, 171, 172, 173, 174 y demás relativos aplicables de la Ley General de Títulos y Operaciones de crédito, así como los comprendidos del 1391 al 1414 del Código de Comercio en Vigor. ";

            documento.InsertParagraph(para).FontSize(8d).Alignment = Alignment.both;
            string firma;
            firma = @"
__________________________   
" + nombreResponsable + "";
            documento.InsertParagraph(firma).FontSize(8d).Alignment = Alignment.center;
            documento.Save();
            documento.Dispose();
            // VistaPreviaDocumento.ruta = "C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendario.docx"
            // VistaPreviaDocumento.Show()
            var spDoc = new Spire.Doc.Document();
            spDoc.LoadFromFile(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempLegal.docx");
            // Dim footer As Spire.Doc.HeaderFooter = spDoc.Sections(0).HeadersFooters.Footer
            // Dim footerparagraph As Spire.Doc.Documents.Paragraph = footer.AddParagraph
            // footerparagraph.AppendText("Página ")
            // footerparagraph.AppendField("page number", FieldType.FieldPage)
            // footerparagraph.AppendText(" de ")
            // footerparagraph.AppendField("number of pages", FieldType.FieldNumPages)
            // footerparagraph.Format.HorizontalAlignment = HorizontalAlignment.Right



            var dialog = new PrintPreviewDialog();

            // dialog.AllowCurrentPage = True
            // dialog.AllowSomePages = True
            // dialog.UseEXDialog = True


            try
            {
                // spDoc.PrintDialog = dialog.
                spDoc.PrintDocument.PrinterSettings.PrinterName = Module1.ImpresoraPredeterminada;
                // spDoc.
                dialog.Document = spDoc.PrintDocument;
                My.MyProject.Forms.Cargando.Close();
                dialog.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                My.MyProject.Forms.Cargando.Close();
            }

        }
    }
}