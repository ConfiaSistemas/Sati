using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class TiposDeEmpeños
    {
        private List<int> idTipo = new List<int>();
        private List<string> nombreTipo = new List<string>();

        public TiposDeEmpeños()
        {
            InitializeComponent();
        }
        private async void TiposDeCreditos_LoadAsync(object sender, EventArgs e)
        {
            Location = new Point(My.MyProject.Forms.Levantar_Solicitud.Location.X, My.MyProject.Forms.Levantar_Solicitud.Location.Y + My.MyProject.Forms.Levantar_Solicitud.txtTipo.Location.Y + My.MyProject.Forms.Levantar_Solicitud.txtTipo.Height);
            CheckForIllegalCrossThreadCalls = false;

            await Task.Factory.StartNew(() =>
                {

                    Module1.iniciarconexionempresa();
                    string strgrupos;
                    strgrupos = "select id,nombre from TiposDeEmpeño";
                    var ejec = new SqlCommand(strgrupos);
                    ejec.Connection = Module1.conexionempresa;
                    Label labelgrupo;

                    int numero = 0;

                    var myreadergrupos = ejec.ExecuteReader();
                    while (myreadergrupos.Read())
                    {
                        labelgrupo = new Label();

                        idTipo.Add(Conversions.ToInteger(myreadergrupos["id"]));
                        nombreTipo.Add(Conversions.ToString(myreadergrupos["nombre"]));

                        Invoke(new Action(() =>
{
                            labelgrupo.Name = idTipo[numero].ToString();
                            labelgrupo.AutoSize = true;
                            labelgrupo.Text = idTipo[numero] + "-" + nombreTipo[numero];
                            labelgrupo.ForeColor = Color.White;
                            labelgrupo.Click += clickevent;
                            FlowLayoutPanel1.Controls.Add(labelgrupo);
                        }));

                        numero += 1;
                    // cantidadgrupos = numero
                }
                    myreadergrupos.Close();

                });
        }

        public void clickevent(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            // Dim label = DirectCast(sender, Label)

            My.MyProject.Forms.Solicitud_Boleta.txtTipo.Text = Conversions.ToString(l.Name);
            My.MyProject.Forms.Solicitud_Boleta.ConsultarTipocredito();

            Close();





        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}