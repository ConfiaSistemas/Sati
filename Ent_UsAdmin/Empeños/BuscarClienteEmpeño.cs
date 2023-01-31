using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class BuscarClienteEmpeño
    {
        private DataTable dataConsulta;
        private SqlDataAdapter adapterConsulta;
        private string consulta;
        private bool consultar;

        public BuscarClienteEmpeño()
        {
            InitializeComponent();
        }
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            adapterConsulta = new SqlDataAdapter(consulta, Module1.conexionempresa);
            dataConsulta = new DataTable();
            adapterConsulta.Fill(dataConsulta);
        }

        private void BuscarClienteSolicitud_Load(object sender, EventArgs e)
        {
            consulta = "select id,(nombre+' '+apellidoPaterno+' '+apellidoMaterno) as nombre  from clientes order by nombre asc";
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Consultando";
            BackgroundWorker1.RunWorkerAsync();
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtdatos.DataSource = dataConsulta;
            consultar = false;
            My.MyProject.Forms.Cargando.Close();
        }



        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (consultar)
                {
                    MessageBox.Show("Consultando espere...");
                }
                else
                {
                    consulta = "select id,(nombre+' '+apellidoPaterno+' '+apellidoMaterno) as nombre from clientes where nombre like '%" + txtnombre.Text + "%' or apellidoPaterno like '%" + txtnombre.Text + "%' or apellidoMaterno like '%" + txtnombre.Text + "%' order by nombre asc";
                    consultar = true;
                    My.MyProject.Forms.Cargando.Show();
                    My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Consultando";
                    BackgroundWorker1.RunWorkerAsync();
                }

            }
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

        private void txtnombre_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void dtdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtdatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            My.MyProject.Forms.Solicitud_Boleta.txtIdCLiente.Text = Conversions.ToString(dtdatos.CurrentRow.Cells[0].Value);
            My.MyProject.Forms.Solicitud_Boleta.ConsultarCliente();
            Close();
        }

        private void dtdatos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                My.MyProject.Forms.Solicitud_Boleta.txtIdCLiente.Text = Conversions.ToString(dtdatos.CurrentRow.Cells[0].Value);
                My.MyProject.Forms.Solicitud_Boleta.ConsultarCliente();
                Close();
            }
        }
    }
}