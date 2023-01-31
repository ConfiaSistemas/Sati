using System;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    public partial class perfil
    {
        public perfil()
        {
            InitializeComponent();
        }


        private void linklabeleditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            My.MyProject.Forms.editarperfil.Show();
            Close();

        }

        private void perfil_Load(object sender, EventArgs e)
        {

        }
    }
}