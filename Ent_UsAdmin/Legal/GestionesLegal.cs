using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ConfiaAdmin
{
    // texto de prueb
    public partial class GestionesLegal
    {
        public int idLegal;

        public GestionesLegal()
        {
            InitializeComponent();
        }
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Module_resize.MoveForm(this);
            }
        }

        private void BackgroundGestiones_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();

            SqlCommand comandoGestiones;
            string consultaGestiones;
            SqlDataReader readerGestiones;
            consultaGestiones = "select Fecha,Concepto,NombreUsuario from GestionesLegales where idCredito = " + idLegal;
            comandoGestiones = new SqlCommand();
            comandoGestiones.Connection = Module1.conexionempresa;
            comandoGestiones.CommandText = consultaGestiones;
            readerGestiones = comandoGestiones.ExecuteReader();
            if (readerGestiones.HasRows)
            {
                while (readerGestiones.Read())
                    dtimpuestos.Rows.Add(Strings.Format(readerGestiones["Fecha"], "yyyy-MM-dd"), readerGestiones["Concepto"], readerGestiones["NombreUsuario"]);
            }
        }

        private void Retiros_Load(object sender, EventArgs e)
        {
            CargarGestiones();
        }

        private void BackgroundGestiones_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtimpuestos.ScrollBars = ScrollBars.Both;
            My.MyProject.Forms.Cargando.Close();
        }

        public void CargarGestiones()
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Información";
            My.MyProject.Forms.Cargando.TopMost = true;
            dtimpuestos.Rows.Clear();
            dtimpuestos.ScrollBars = ScrollBars.None;

            BackgroundGestiones.RunWorkerAsync();
        }
    }
}