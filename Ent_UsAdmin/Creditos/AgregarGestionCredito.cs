using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ConfiaAdmin
{

    public partial class AgregarGestionCredito
    {

        public string idCredito;
        public string frmNombre;

        public AgregarGestionCredito()
        {
            InitializeComponent();
        }

        private void AgregarGestionLegal_Load(object sender, EventArgs e)
        {

        }

        private void BackgroundGestion_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            SqlCommand comandoGestion;
            string consultaGestion;
            string tiempo = DateAndTime.TimeOfDay.ToString("HH:mm:ss");
            consultaGestion = "insert into GestionesCredito values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + idCredito + "','" + txtConcepto.Text + "')";
            comandoGestion = new SqlCommand();
            comandoGestion.Connection = Module1.conexionempresa;
            comandoGestion.CommandText = consultaGestion;
            comandoGestion.ExecuteNonQuery();

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (txtConcepto.Text.Length > 1000)
            {
                MessageBox.Show("La gestión excede el límite de caracteres. Si es necesario, el texto restante se puede introducir en otra gestión.");
            }
            else
            {
                My.MyProject.Forms.Cargando.Show();
                My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Ejecutando";
                BackgroundGestion.RunWorkerAsync();
            }

        }

        private void BackgroundGestion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            foreach (Form frm in Application.OpenForms)
            {
                if ((frm.Text ?? "") == (frmNombre ?? ""))
                {
                    InformacionSolicitud frmn;
                    frmn = (InformacionSolicitud)frm;



                    Invoke(new Action(() => frmn.BackgroundGestiones.RunWorkerAsync()));
                }
            }
            My.MyProject.Forms.Cargando.Close();
            Close();

        }

        private void txtConcepto_TextChanged(object sender, EventArgs e)
        {
            MonoFlat_HeaderLabel2.Text = (1000 - txtConcepto.TextLength).ToString();
            if (txtConcepto.TextLength > 1000)
            {
                MonoFlat_HeaderLabel2.ForeColor = Color.Red;
                MonoFlat_HeaderLabel3.ForeColor = Color.Red;
                MonoFlat_HeaderLabel4.ForeColor = Color.Red;
            }
            else
            {
                MonoFlat_HeaderLabel2.ForeColor = Color.White;
                MonoFlat_HeaderLabel3.ForeColor = Color.White;
                MonoFlat_HeaderLabel4.ForeColor = Color.White;
            }
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Module_resize.MoveForm(this);
            }
        }
    }
}