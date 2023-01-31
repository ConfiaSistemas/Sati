using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class CierresSinRecibir
    {
        public CierresSinRecibir()
        {
            InitializeComponent();
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

        private void BackgroundRetiros_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();

            SqlCommand comandoRetiros;
            string consultaRetiros;
            SqlDataReader readerRetiros;
            consultaRetiros = "select id,Caja,UsuarioEntrega,Monto,Fecha,Hora from cierrecajagestores where usuariorecibe = ''";
            comandoRetiros = new SqlCommand();
            comandoRetiros.Connection = Module1.conexionempresa;
            comandoRetiros.CommandText = consultaRetiros;
            readerRetiros = comandoRetiros.ExecuteReader();
            if (readerRetiros.HasRows)
            {
                while (readerRetiros.Read())
                    dtimpuestos.Rows.Add(readerRetiros["id"], readerRetiros["Caja"], readerRetiros["UsuarioEntrega"], Strings.FormatCurrency(readerRetiros["Monto"], 2), Strings.Format(readerRetiros["Fecha"], "yyyy-MM-dd"), readerRetiros["hora"]);
            }
        }

        private void Retiros_Load(object sender, EventArgs e)
        {
            CargarRetiros();
        }

        private void BackgroundRetiros_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtimpuestos.ScrollBars = ScrollBars.Both;
            My.MyProject.Forms.Cargando.Close();
        }

        private void dtimpuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtimpuestos_SelectionChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[5].Value.ToString()))
            {
                dtimpuestos.ContextMenuStrip = ContextMenuStrip1;
            }
            else
            {
                dtimpuestos.ContextMenuStrip = null;
            }

        }

        private void RecibirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.RecibirCierre.idRetiro = Conversions.ToInteger(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[0].Value);
            My.MyProject.Forms.RecibirCierre.Cantidad = Conversions.ToDouble(dtimpuestos.Rows[dtimpuestos.CurrentRow.Index].Cells[3].Value);
            My.MyProject.Forms.RecibirCierre.Show();

        }

        public void CargarRetiros()
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Información";
            My.MyProject.Forms.Cargando.TopMost = true;
            dtimpuestos.Rows.Clear();
            dtimpuestos.ScrollBars = ScrollBars.None;

            BackgroundRetiros.RunWorkerAsync();
        }
    }
}