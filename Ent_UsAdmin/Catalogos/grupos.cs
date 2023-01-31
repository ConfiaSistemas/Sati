using System;
using System.Data.OleDb;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class grupos
    {
        private string strgrupos;

        public grupos()
        {
            InitializeComponent();
        }
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left & WindowState != FormWindowState.Maximized)
            {
                Module_resize.MoveForm(this);
            }
        }






        private void grupos_Load(object sender, EventArgs e)
        {
            Module1.iniciarconexionR();
            Combofiltro.Items.Add("Todos");
            Combofiltro.Items.Add("Con Nombre");
            Combofiltro.Items.Add("Con Código");
            Combofiltro.SelectedIndex = 0;
        }





        private void Combofiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combofiltro.Text == "Todos")
            {
                strgrupos = "select id,nm,cdg from grp";
                cargargrupos();

            }
        }

        public void cargargrupos()
        {
            dtgrupos.Rows.Clear();

            var ejec = new OleDbCommand(strgrupos);
            ejec.Connection = Module1.conexionempresaR;
            string nombre, codigo, id;

            var myreadergrupos = ejec.ExecuteReader();
            while (myreadergrupos.Read())
            {
                id = Conversions.ToString(myreadergrupos["id"]);
                nombre = Conversions.ToString(myreadergrupos["nm"]);
                codigo = Conversions.ToString(myreadergrupos["cdg"]);
                dtgrupos.Rows.Add(id, codigo, nombre);
            }
            myreadergrupos.Close();

        }



        private void btn_agregar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.agregargrupos.Show();

        }

        private void dtgrupos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgrupos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            My.MyProject.Forms.PermisosGrupo.idgrupousuarios = Conversions.ToInteger(dtgrupos.Rows[dtgrupos.CurrentRow.Index].Cells[0].Value);
            My.MyProject.Forms.PermisosGrupo.Show();
        }
    }
}