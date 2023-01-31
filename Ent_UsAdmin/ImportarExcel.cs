using System;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    public partial class ImportarExcel
    {
        public ImportarExcel()
        {
            InitializeComponent();
        }
        private void ImportarExcel_Load(object sender, EventArgs e)
        {
            Combocodigo.Items.Add("A");
            Combocodigo.Items.Add("B");
            Combocodigo.Items.Add("C");
            Combocodigo.Items.Add("D");
            Combocodigo.Items.Add("E");
            Combocodigo.Items.Add("F");
            Combocodigo.Items.Add("G");
            Combocodigo.Items.Add("H");
            Combocodigo.Items.Add("I");
            Combocodigo.Items.Add("J");
            Combocodigo.Items.Add("K");
            Combocodigo.Items.Add("L");
            Combocodigo.Items.Add("M");
            Combocodigo.Items.Add("N");
            Combocodigo.Items.Add("O");
            Combocodigo.Items.Add("P");
            Combocodigo.Items.Add("Q");
            Combocodigo.Items.Add("R");
            Combocodigo.Items.Add("S");
            Combocodigo.Items.Add("T");
            Combocodigo.Items.Add("U");
            Combocodigo.Items.Add("V");
            Combocodigo.Items.Add("W");
            Combocodigo.Items.Add("X");
            Combocodigo.Items.Add("Y");
            Combocodigo.Items.Add("Z");
            Combocodigo.SelectedIndex = 0;
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Migrar.fila = txtfila.Text;
            My.MyProject.Forms.Migrar.columna = Combocodigo.Text;
            Close();
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
    }
}