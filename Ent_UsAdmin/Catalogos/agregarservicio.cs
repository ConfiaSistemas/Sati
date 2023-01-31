using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    public partial class agregarservicio
    {
        public agregarservicio()
        {
            InitializeComponent();
        }








        private void agregarservicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            My.MyProject.Forms.inv.catservicios.MonoFlat_Label1.ForeColor = Color.FromArgb(64, 64, 64);
            My.MyProject.Forms.inv.catservicios.MonoFlat_Label1.BorderStyle = BorderStyle.None;
            My.MyProject.Forms.inv.catservicios.MonoFlat_Label1.Location = new Point(My.MyProject.Forms.inv.catservicios.MonoFlat_Label1.Location.X, My.MyProject.Forms.inv.catservicios.yiniciallabel);
            My.MyProject.Forms.inv.catservicios.bloquearlabelagregar = false;
            My.MyProject.Forms.inv.catservicios.agregarservicioabierto = false;
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Module_resize.MoveForm(this);
            }
        }





        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void agregarservicio_Load(object sender, EventArgs e)
        {

        }
    }
}