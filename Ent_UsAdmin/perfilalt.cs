using System;

namespace ConfiaAdmin
{
    public partial class perfilalt
    {
        public perfilalt()
        {
            InitializeComponent();
        }


        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.editarperfil.Show();
            My.MyProject.Forms.frm_adm.abierto = false;
            My.MyProject.Forms.frm_adm.Timer2.Stop();

            Close();

        }

        private void perfilalt_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Module1.imgstrusr))
            {
                PictureBox2.Image = My.Resources.Resources.usuarionegro;
            }
            else
            {
                PictureBox2.Image = Module1.bitmapimgusr;
            }
            if (!string.IsNullOrEmpty(Module1.nm_completeusr))
            {
                lblnm_complete.Text = Module1.nm_completeusr;
            }

            if (!string.IsNullOrEmpty(Module1.addrusr))
            {
                lbldireccion.Text = Module1.addrusr;
            }

            if (!string.IsNullOrEmpty(Module1.tlfusr))
            {
                lbltlf.Text = Module1.tlfusr;
            }

            if (!string.IsNullOrEmpty(Module1.grpusr))
            {
                lblgrp.Text = Module1.grpusr;
            }

            if (!string.IsNullOrEmpty(Module1.nmusr))
            {
                lblnm.Text = Module1.nmusr;
            }

            if (!string.IsNullOrEmpty(Module1.idSesion))
            {
                lblSesion.Text = Module1.idSesion;
            }

        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.frm_adm.cerrarSesion = true;
            My.MyProject.Forms.frm_adm.cerrarEmpresa = false;
            My.MyProject.Forms.frm_adm.Close();
        }

        private void BunifuThinButton23_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.frm_adm.cerrarSesion = true;
            My.MyProject.Forms.frm_adm.cerrarEmpresa = true;
            My.MyProject.Forms.frm_adm.Close();
        }
    }
}