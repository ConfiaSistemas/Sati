using System;
using System.Drawing.Printing;
using System.Windows.Forms;
using MadMilkman.Ini;

namespace ConfiaAdmin
{

    public partial class ConfigurarEmpresa
    {
        public ConfigurarEmpresa()
        {
            InitializeComponent();
        }

        private void Configuraciones_Load(object sender, EventArgs e)
        {

            txtIp.Text = Module1.ipser;
            txtBD.Text = Module1.bdser;
            foreach (var Impresoras in PrinterSettings.InstalledPrinters)
                ComboImpresora.Items.Add(Impresoras.ToString());
            ComboImpresora.Text = Module1.ImpresoraPredeterminada;
        }

        private void btn_Procesar_Click(object sender, EventArgs e)
        {
            var options = new IniOptions() { EncryptionPassword = "EntUs01pos" };
            var file = new IniFile(options);

            var section = file.Sections.Add("Conexión");
            section.Keys.Add("Ip", txtIp.Text);
            section.Keys.Add("Base", txtBD.Text);
            // section.Keys.Add("Caja", txtcaja.Text)
            section.Keys.Add("Impresora", ComboImpresora.Text);
            section.Keys.Add("Tipo", Module1.TipoEquipo);
            // Save and encrypt the file.
            file.Save(@"C:\ConfiaAdmin\SATI\SetConfig.ini");

            file.Sections.Clear();
            Module1.ipser = txtIp.Text;
            Module1.bdser = txtBD.Text;
            Module1.ImpresoraPredeterminada = ComboImpresora.Text;
            MessageBox.Show("Listo");
            Close();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_MouseEnter(object sender, EventArgs e)
        {

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