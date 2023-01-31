using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class InformacionCliente
    {

        public int idCLiente;

        private DataTable dataClientes;
        private SqlDataAdapter adapterClientes;
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

        public InformacionCliente()
        {
            InitializeComponent();
        }
        private void InformacionSolicitud_Load(object sender, EventArgs e)
        {
            // Panel2.Size = New Size(51, 85)
            // Panel2.Location = New Drawing.Point(Me.Width - Panel2.Width, TabControl1.Location.Y - Panel2.Height)
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Información";
            My.MyProject.Forms.Cargando.TopMost = true;
            dtSolicitud.ScrollBars = ScrollBars.None;
            dtCredito.ScrollBars = ScrollBars.None;
            BackgroundDatos.RunWorkerAsync();
        }



        private void BackgroundSolicitud_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {
                string strimpuestos;
                Module1.iniciarconexionempresa();

                strimpuestos = "select Solicitud.id,format(Solicitud.Fecha,'dd-MM-yy') as Fecha,Solicitud.Nombre,Solicitud.Monto,Solicitud.MontoAutorizado,TiposDeCredito.Nombre as Tipo from solicitud inner join DatosSolicitud on Solicitud.id = DatosSolicitud.IdSolicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where DatosSolicitud.IdCliente ='" + idCLiente + "'";




                var ejec = new SqlCommand(strimpuestos);
                ejec.Connection = Module1.conexionempresa;
                string id, nombre, valor, factor, tipo;

                var myreaderimpuestos = ejec.ExecuteReader();
                while (myreaderimpuestos.Read())
                {
                    id = Conversions.ToString(myreaderimpuestos["id"]);
                    if (myreaderimpuestos["montoautorizado"] is DBNull)
                    {
                        valor = 0.ToString();
                    }
                    else
                    {
                        valor = Conversions.ToString(myreaderimpuestos["montoautorizado"]);
                    }


                    dtSolicitud.Rows.Add(id, myreaderimpuestos["fecha"], myreaderimpuestos["nombre"], Strings.FormatCurrency(myreaderimpuestos["Monto"], 2), Strings.FormatCurrency(valor, 2), myreaderimpuestos["tipo"]);
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
            // BackgroundCalendario.RunWorkerAsync()
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Créditos";
            BackgroundCreditos.RunWorkerAsync();
        }

        private void dtSolicitud_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            My.MyProject.Forms.DatosConsultaSolicitud.idSolicitud = Conversions.ToInteger(dtSolicitud.Rows[dtSolicitud.CurrentRow.Index].Cells[0].Value);
            // DatosConsultaSolicitud.TipoSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(5).Value
            My.MyProject.Forms.DatosConsultaSolicitud.Show();
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Module_resize.MoveForm(this);
            }
        }

        private void btnGenerarCalendario_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.DocumentosCredito.idCredito = 1.ToString();
            My.MyProject.Forms.DocumentosCredito.Show();
        }


        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.ActInformacionCredito.idCredito = idCLiente.ToString();
            My.MyProject.Forms.ActInformacionCredito.Show();
        }

        private void BackgroundCreditos_DoWork(object sender, DoWorkEventArgs e)
        {
            // Try
            string strimpuestos;
            Module1.iniciarconexionempresa();

            strimpuestos = "select Credito.id,format(Credito.FechaEntrega,'dd-MM-yy') as 'Fecha de Entrega',Credito.Nombre,Credito.Monto,TiposDeCredito.Nombre as Tipo, Credito.Estado  from Credito inner join Solicitud on Solicitud.id = Credito.IdSolicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id inner join DatosSolicitud on DatosSolicitud.IdSolicitud = Solicitud.id where DatosSolicitud.IdCliente ='" + idCLiente + "'";




            var ejec = new SqlCommand(strimpuestos);
            ejec.Connection = Module1.conexionempresa;
            string id, nombre, valor, factor, tipo;

            var myreaderimpuestos = ejec.ExecuteReader();
            while (myreaderimpuestos.Read())
            {
                id = Conversions.ToString(myreaderimpuestos["id"]);


                dtCredito.Rows.Add(id, myreaderimpuestos["Fecha de Entrega"], myreaderimpuestos["nombre"], Strings.FormatCurrency(myreaderimpuestos["Monto"], 2), myreaderimpuestos["tipo"], myreaderimpuestos["estado"]);
            }
            myreaderimpuestos.Close();
            // Catch ex As Exception
            // MessageBox.Show(ex.Message)
            // End Try
        }

        private void BackgroundDatos_DoWork(object sender, DoWorkEventArgs e)
        {

            // consultadatos = "select CONCAT(Nombre,' ',ApellidoPaterno,' ',ApellidoMaterno) as nombre,FechaAlta,FechaNacimiento,Telefono,Celular	 from clientes where id = '" & idCLiente & "'"
            Module1.iniciarconexionempresa();
            string consultaCredito;
            SqlCommand comandoCredito;
            SqlDataReader readerCredito;

            consultaCredito = "select CONCAT(Nombre,' ',ApellidoPaterno,' ',ApellidoMaterno) as nombre,FechaAlta,FechaNacimiento,Telefono,Celular	 from clientes where id = '" + idCLiente + "'";
            comandoCredito = new SqlCommand();
            comandoCredito.Connection = Module1.conexionempresa;
            comandoCredito.CommandText = consultaCredito;
            readerCredito = comandoCredito.ExecuteReader();
            while (readerCredito.Read())
            {
                lblnombre.Text = Conversions.ToString(readerCredito["Nombre"]);
                lblfecha.Text = Conversions.ToString(readerCredito["fechaalta"]);
                lblfechanacimiento.Text = Conversions.ToString(readerCredito["fechanacimiento"]);
                lbltelefono.Text = Conversions.ToString(readerCredito["telefono"]);
                lblcelular.Text = Conversions.ToString(readerCredito["celular"]);

            }
        }

        private void BackgroundDatos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Solicitudes";
            BackgroundSolicitud.RunWorkerAsync();

        }

        private void BackgroundCreditos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtSolicitud.ScrollBars = ScrollBars.Both;
            dtCredito.ScrollBars = ScrollBars.Both;
            My.MyProject.Forms.Cargando.Close();
        }

        private void dtCredito_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            My.MyProject.Forms.InformacionSolicitud.idCredito = Conversions.ToInteger(dtCredito.Rows[dtCredito.CurrentRow.Index].Cells[0].Value);
            // DatosConsultaSolicitud.TipoSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(5).Value
            My.MyProject.Forms.InformacionSolicitud.Show();
        }

        private void dtSolicitud_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}