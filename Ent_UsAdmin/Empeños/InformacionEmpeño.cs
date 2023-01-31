using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using WinControls.ListView;

namespace ConfiaAdmin
{

    public partial class InformacionEmpeño
    {
        public int idEmpeño;
        private DataTable dataArticulos;
        private SqlDataAdapter adapterArticulos;
        private DataTable dataCalendario;
        private SqlDataAdapter adapterCalendario;
        private DataTable dataDocumentos;
        private SqlDataAdapter adapterDocumentos;
        private bool bloqueado;
        private DataTable dataGestiones;
        private SqlDataAdapter adapterGestiones;
        private DataTable dataActualizaciones;
        private SqlDataAdapter adapterActualizaciones;
        private string estado;

        public InformacionEmpeño()
        {
            InitializeComponent();
        }
        private void InformacionSolicitud_Load(object sender, EventArgs e)
        {
            Panel2.Size = new Size(51, 85);
            Panel2.Location = new Point(Width - Panel2.Width, TabControl1.Location.Y - Panel2.Height);
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Información...";
            My.MyProject.Forms.Cargando.TopMost = true;
            BackgroundArticulos.RunWorkerAsync();

        }

        private void BackgroundArticulos_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consultaEmpeño;
            SqlCommand comandoEmpeño;
            SqlDataReader readerEmpeño;

            consultaEmpeño = "select format(FechaEntrega,'dd-MM-yy') as 'Fecha de Entrega',Empeños.Nombre,MontoPrestado as 'Monto Prestado',empeños.montoRefrendo as 'Monto Refrendo',TiposDeEmpeño.Nombre as Tipo,empeños.Estado from Empeños inner join SolicitudBoleta on SolicitudBoleta.id = Empeños.idSolicitudBoleta  inner join TiposDeEmpeño on SolicitudBoleta.idTipoEmpeño = TiposDeEmpeño.id where Empeños.id = '" + idEmpeño + "'";
            comandoEmpeño = new SqlCommand();
            comandoEmpeño.Connection = Module1.conexionempresa;
            comandoEmpeño.CommandText = consultaEmpeño;
            readerEmpeño = comandoEmpeño.ExecuteReader();
            while (readerEmpeño.Read())
            {
                lblnombre.Text = Conversions.ToString(readerEmpeño["Nombre"]);
                if (readerEmpeño["Fecha de Entrega"] is DBNull)
                {
                    lblfecha.Text = "";
                }
                else
                {
                    lblfecha.Text = Conversions.ToString(readerEmpeño["Fecha de Entrega"]);
                }
                lblmonto.Text = Strings.FormatCurrency(readerEmpeño["Monto Prestado"]);
                lblmontorefrendo.Text = Strings.FormatCurrency(readerEmpeño["Monto Refrendo"]);
                lbltipo.Text = Conversions.ToString(readerEmpeño["Tipo"]);
                estado = Conversions.ToString(readerEmpeño["Estado"]);
            }
            readerEmpeño.Close();

            string consultaArticulos;
            consultaArticulos = "select ArticulosEmpeños.id, Tipo, Descripcion, Marca, Modelo, NoSerie as 'No de Serie', format(ArticulosEmpeños.MontoValuado, 'C','es-mx') as 'Monto Valuado', format(ArticulosEmpeños.MontoPrestado, 'c', 'es-mx') as 'Monto Prestado', Imagen from Empeños inner join ArticulosEmpeños on ArticulosEmpeños.idSolicitud=Empeños.idSolicitudBoleta  where Empeños.id = '" + idEmpeño + "'";
            adapterArticulos = new SqlDataAdapter(consultaArticulos, Module1.conexionempresa);
            dataArticulos = new DataTable();
            adapterArticulos.Fill(dataArticulos);

        }

        private void BackgroundArticulos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Text = "Información de Empeño " + lblnombre.Text;
            dtArticulos.DataSource = dataArticulos;

            // Damos formato de imagen a la columna con la foto del artículo, y definimos el ancho y alto de esta.
            dtArticulos.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dtArticulos.Columns[8].Width = 200;
            DataGridViewImageColumn imagecolumn;
            imagecolumn = (DataGridViewImageColumn)dtArticulos.Columns[8];
            imagecolumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dtArticulos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dtArticulos.Columns[2].Width = 300;
            dtArticulos.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dtArticulos.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtArticulos.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewRow row in dtArticulos.Rows)
                row.Height = 120;

            BackgroundSolicitud.RunWorkerAsync();
            dtSolicitud.Rows.Clear();
            dtSolicitud.ScrollBars = ScrollBars.None;
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Solicitud...";
        }

        private void BackgroundSolicitud_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {
                string strSolicitud;
                Module1.iniciarconexionempresa();

                strSolicitud = "select SolicitudBoleta.id,format(SolicitudBoleta.Fecha,'dd-MM-yy') as Fecha,SolicitudBoleta.MontoValuado,SolicitudBoleta.MontoAutorizado, SolicitudBoleta.idTipoEmpeño as tipo from Empeños inner join SolicitudBoleta on Empeños.IdSolicitudBoleta = SolicitudBoleta.id where Empeños.id = '" + idEmpeño + "'";




                var ejec = new SqlCommand(strSolicitud);
                ejec.Connection = Module1.conexionempresa;
                string id;

                var myreaderSolicitud = ejec.ExecuteReader();
                while (myreaderSolicitud.Read())
                {
                    id = Conversions.ToString(myreaderSolicitud["id"]);


                    dtSolicitud.Rows.Add(id, myreaderSolicitud["fecha"], Strings.FormatCurrency(myreaderSolicitud["MontoValuado"], 2), Strings.FormatCurrency(myreaderSolicitud["MontoAutorizado"], 2), myreaderSolicitud["tipo"]);
                }
                myreaderSolicitud.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BackgroundSolicitud_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtSolicitud.ScrollBars = ScrollBars.Both;
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Documentos...";
            BackgroundDocumentos.RunWorkerAsync();

        }

        private void BackgroundDocumentos_DoWork(object sender, DoWorkEventArgs e)
        {
            string consultaDocumentos;
            consultaDocumentos = "select TiposdeDocumentosSolicitud.Nombre,DocumentosEmpeño.Imagen from Empeños inner join DocumentosEmpeño on Empeños.id = DocumentosEmpeño.idEmpeño inner join TiposdeDocumentosSolicitud on DocumentosEmpeño.Tipo = TiposdeDocumentosSolicitud.id where Empeños.id = '" + idEmpeño + "'";
            adapterDocumentos = new SqlDataAdapter(consultaDocumentos, Module1.conexionempresa);
            dataDocumentos = new DataTable();
            adapterDocumentos.Fill(dataDocumentos);
        }

        private void BackgroundDocumentos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtdatosDocumentos.DataSource = dataDocumentos;

            // Damos formato de imagen a la columna con la foto del artículo, y definimos el ancho y alto de esta.
            dtdatosDocumentos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dtdatosDocumentos.Columns[1].Width = 250;
            DataGridViewImageColumn imagecolumn;
            imagecolumn = (DataGridViewImageColumn)dtdatosDocumentos.Columns[1];
            imagecolumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dtdatosDocumentos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Pagos...";
            BackgroundPagos.RunWorkerAsync();
        }

        private void dtSolicitud_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            My.MyProject.Forms.DatosSolicitudBoletaVerificar.idSolicitud = Conversions.ToInteger(dtSolicitud.Rows[dtSolicitud.CurrentRow.Index].Cells[0].Value);
            My.MyProject.Forms.DatosSolicitudBoletaVerificar.verSolicitud = true;
            My.MyProject.Forms.DatosSolicitudBoletaVerificar.Show();
        }



        private void dtdatosDocumentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                My.MyProject.Forms.VistaDocumento.PictureBox1.Image = (Image)dtdatosDocumentos.Rows[dtdatosDocumentos.CurrentRow.Index].Cells[1].FormattedValue;
                My.MyProject.Forms.VistaDocumento.ShowDialog();
            }
            catch (Exception a)
            {
                MessageBox.Show("No hay documentos para mostrar en este empeño.");
            }
        }

        private void BackgroundPagos_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            TreeListView1.Nodes.Clear();

            SqlCommand comandoTicket;
            string consulta;
            SqlDataReader readerTicket;

            consulta = $@"select id,Recibido,(case when tipo = 'Refrendo' or tipo = 'Comisión por avalúo' or tipo = 'Desempeño' then
ISNULL((select nombre from Empeños where id = pagos.idEmpeño),0) 		end) as nombre,idEmpeño,Fecha,Hora,PagoNormal,Intereses,Total,tipo,Caja from
(select Ticket.Id,Ticket.Recibido,Ticket.idCredito as idEmpeño,Ticket.Fecha,Ticket.hora,Ticket.PagoNormal,Ticket.Intereses,Ticket.total,tipodoc.Nombre as tipo,Ticket.concepto,Ticket.caja from Ticket  inner join TipoDoc on Ticket.tipodoc = TipoDoc.id  where  ticket.idCredito = '{idEmpeño}'  and (tipodoc = (select id from tipodoc where nombre = 'Refrendo') or  tipodoc = (select id from tipodoc where nombre = 'Comisión por Avalúo') or  tipodoc = (select id from tipodoc where nombre = 'Desempeño')))pagos order by Fecha,Hora asc";

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
                        withBlock.Add(readerTicket["idEmpeño"].ToString());
                        withBlock.Add(readerTicket["nombre"].ToString());
                        withBlock.Add(readerTicket["PagoNormal"].ToString());
                        withBlock.Add(readerTicket["Intereses"].ToString());
                        withBlock.Add(readerTicket["Total"].ToString());
                        withBlock.Add(readerTicket["Fecha"].ToString());
                        withBlock.Add(readerTicket["Hora"].ToString());
                        withBlock.Add(readerTicket["Tipo"].ToString());
                        withBlock.Add(readerTicket["Caja"].ToString());
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
                withBlock.Add(pagonormal.ToString());
                withBlock.Add(intereses.ToString());
                withBlock.Add(total.ToString());
            }
        }

        private void BackgroundPagos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Consultando Actualizaciones";
            BackgroundActualizaciones.RunWorkerAsync();
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Module_resize.MoveForm(this);
            }
        }

        private void PictureBox1_MouseHover(object sender, EventArgs e)
        {
            if (bloqueado)
            {
            }

            else
            {
                for (int i = 51; i <= 281; i += 10)
                {
                    Panel2.Width = i;
                    Panel2.Location = new Point(Width - Panel2.Width, TabControl1.Location.Y - Panel2.Height);
                }
                bloqueado = true;
            }
        }

        private void InformacionSolicitud_MouseHover(object sender, EventArgs e)
        {
            for (int i = Panel2.Width; i >= 51; i -= 10)
            {
                Panel2.Width = i;
                Panel2.Location = new Point(Width - Panel2.Width, TabControl1.Location.Y - Panel2.Height);
            }
            bloqueado = false;
        }

        private void BackgroundActualizaciones_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consultaActualizaciones;
            consultaActualizaciones = "select Fecha,Hora,Campo,ValorAnterior,NuevoValor,Motivo from ActualizacionesEmpeño where idEmpeño = '" + idEmpeño + "'";
            adapterActualizaciones = new SqlDataAdapter(consultaActualizaciones, Module1.conexionempresa);
            dataActualizaciones = new DataTable();
            adapterActualizaciones.Fill(dataActualizaciones);
        }

        private void BackgroundActualizaciones_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtActualizaciones.DataSource = dataActualizaciones;
            My.MyProject.Forms.Cargando.Close();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.ActInformacionEmpeño.idEmpeño = idEmpeño.ToString();
            My.MyProject.Forms.ActInformacionEmpeño.Show();
        }

        private void btnAgregarDocumentos_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.DocumentosEmpeño.idEmpeño = idEmpeño.ToString();
            My.MyProject.Forms.DocumentosEmpeño.Show();
        }

        private void dtArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                My.MyProject.Forms.VistaDocumento.PictureBox1.Image = (Image)dtArticulos.Rows[dtArticulos.CurrentRow.Index].Cells[8].FormattedValue;
                My.MyProject.Forms.VistaDocumento.ShowDialog();
            }
            catch (Exception a)
            {
                MessageBox.Show("No hay artículos para mostrar en este empeño.");
            }
        }

        private void dtArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}