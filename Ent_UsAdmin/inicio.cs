using System;

namespace ConfiaAdmin
{
    public partial class inicio
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            // If frm_adm.BunifuImageButton1.Width + frm_adm.panelusuarios.Width + frm_adm.Panelconfiguracion.Width + frm_adm.Panel3.Width + frm_adm.Panel4.Width + frm_adm.notificaciones.Width + frm_adm.imgperfil.Width + 30 > frm_adm.Panel1.Width Then


            SuspendLayout();

            // Me.Panelsecundario.Visible = True




            // Else



            // Me.Panelsecundario.Visible = False





            // End If
            if (My.MyProject.Forms.frm_adm.mostrarpanelsecundario == false)
            {
                Panelsecundario.Visible = false;
            }
            else
            {
                Panelsecundario.Visible = true;

            }
            Panelsecundario.Left = My.MyProject.Forms.frm_adm.panelusuarios.Width + My.MyProject.Forms.frm_adm.Panelconfiguracion.Width + My.MyProject.Forms.frm_adm.BunifuImageButton1.Width - My.MyProject.Forms.frm_adm.panelmenus.Width + 10;
            Panelsecundario.Top = 0;

        }

        private void BunifuFlatButton7_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.grupos.Show();

        }
    }
}