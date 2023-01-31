using System;
using System.Data.OleDb;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class agregargrupos
    {
        private bool actualizar = false;
        public bool autorizado;

        public agregargrupos()
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



        private void btn_agregar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Autorizacion.tipoAutorizacion = "SatiModGruposAgregar";
            My.MyProject.Forms.Autorizacion.ShowDialog();
            if (autorizado)
            {
                string sql;
                string idGrupoasignado;
                sql = "insert into grp(cdg,nm) values('" + txtcodigo.Text + "','" + txtnombre.Text + "') SELECT SCOPE_IDENTITY()";
                OleDbCommand comandoagregar;
                try
                {
                    Module1.iniciarconexionR();
                    comandoagregar = new OleDbCommand();
                    comandoagregar.Connection = Module1.conexionempresaR;
                    comandoagregar.CommandText = sql;
                    idGrupoasignado = Conversions.ToString(comandoagregar.ExecuteScalar());
                    OleDbCommand comandoAgregarPermisos;
                    string consultaAgregarPermisos;
                    consultaAgregarPermisos = "insert into PermisosGrupo values('" + idGrupoasignado + "',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0)";
                    comandoAgregarPermisos = new OleDbCommand();
                    comandoAgregarPermisos.Connection = Module1.conexionempresaR;
                    comandoAgregarPermisos.CommandText = consultaAgregarPermisos;
                    comandoAgregarPermisos.ExecuteNonQuery();

                    actualizar = true;
                    MessageBox.Show("Listo");
                    MessageBox.Show("El grupo creado por defecto no tiene ningún permiso asignado, puedes asignarselos en el apartado grupos");
                }
                catch (Exception ex)
                {
                    actualizar = false;
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No fue autorizado");
            }

        }

        private void agregargrupos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (actualizar == true)
            {
                Invoke(new Action(() => My.MyProject.Forms.grupos.cargargrupos()));


            }
        }

        private void EvolveControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }



    }
}