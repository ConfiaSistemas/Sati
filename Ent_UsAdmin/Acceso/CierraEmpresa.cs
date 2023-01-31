using System;

namespace ConfiaAdmin
{
    public partial class CierraEmpresa
    {
        public CierraEmpresa()
        {
            InitializeComponent();
        }
        private void CierraEmpresa_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1000); // 1 segundo
            SeCierra();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.frm_adm.cerrarEmpresa = true;
            My.MyProject.Forms.frm_adm.cerrarSesion = true;
            My.MyProject.Forms.frm_adm.Close();

        }
        private void SeCierra()
        {
            My.MyProject.Forms.frm_adm.cerrarEmpresa = true;
            My.MyProject.Forms.frm_adm.cerrarSesion = true;
            My.MyProject.Forms.frm_adm.Close();
        }
    }
}