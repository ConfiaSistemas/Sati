using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class TraspasarDocumentosSolicitud
    {
        public string ipOrigen;
        public string bdOrigen;
        public string cnOrigen;
        private SqlConnection conexionOrigen;
        public string ipDestino;
        public string bdDestino;
        private string cnDestino;
        private SqlConnection conexionDestino;
        private DataTable dataDocumentosSolicitud;
        private SqlDataAdapter adapterDocumentosSolicitud;
        private Cargando ncargando;
        public string fila;
        public string columna;
        private string tipo;

        public TraspasarDocumentosSolicitud()
        {
            InitializeComponent();
        }


        private void TraspasarDocumentosSolicitud_Load(object sender, EventArgs e)
        {

        }
        private void iniciarconexionOrigen()
        {
            cnOrigen = "Data Source=  " + ipOrigen + @"\confia;" + "Initial Catalog=" + bdOrigen + ";" + "User Id=sa;Password=BSi5t3Ma$CFAD;MultipleActiveResultSets=true";
            conexionOrigen = new SqlConnection(cnOrigen);
            conexionOrigen.Open();
        }
        private void iniciarconexionDestino()
        {
            cnDestino = "Data Source=  " + ipDestino + @"\confia;" + "Initial Catalog=" + bdDestino + ";" + "User Id=sa;Password=BSi5t3Ma$CFAD;MultipleActiveResultSets=true";
            conexionDestino = new SqlConnection(cnDestino);
            conexionDestino.Open();
        }

        private void btnOrigen_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.EmpresasOrigenDocSolicitud.ShowDialog();

        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.EmpresasDestinoDocSolicitud.ShowDialog();

        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            iniciarconexionOrigen();

            adapterDocumentosSolicitud = new SqlDataAdapter(txtSQL.Text, conexionOrigen);
            dataDocumentosSolicitud = new DataTable();
            adapterDocumentosSolicitud.Fill(dataDocumentosSolicitud);

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ncargando = new Cargando();
            ncargando.Show();
            ncargando.MonoFlat_Label1.Text = "Consultando";
            BackgroundWorker1.RunWorkerAsync();

        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ncargando.Close();

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                OpenFileDialog abrircarpeta;
                abrircarpeta = new OpenFileDialog();
                abrircarpeta.Filter = "Archivo de Excel|*.xls;*.xlsx";
                if (abrircarpeta.ShowDialog() == DialogResult.OK)
                {
                    TextBox1.Text = abrircarpeta.FileName;
                }
                else
                {
                    MessageBox.Show("No se seleccionó ningún archivo");
                }
                My.MyProject.Forms.ImportarExcelTraspaso.ShowDialog();

            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                ncargando = new Cargando();

                ncargando.Show();
                ncargando.MonoFlat_Label1.Text = "Cargando datos";
                int intLoopCounter;
                int contador1;
                int contador = 1;
                int cantidadregistros = 1;

                string fname;
                Microsoft.Office.Interop.Excel.Application objXLApp;
                objXLApp = new Microsoft.Office.Interop.Excel.Application();
                fname = TextBox1.Text;
                objXLApp.Workbooks.Open(fname);
                objXLApp.Workbooks[1].Worksheets[(object)1].Select();

                var loopTo = Conversions.ToInteger(objXLApp.ActiveSheet.Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell).Row);
                for (intLoopCounter = Conversions.ToInteger(fila); intLoopCounter <= loopTo; intLoopCounter++)
                {
                    if (string.IsNullOrEmpty(Convert.ToString(objXLApp.get_Range("" + columna + "" + intLoopCounter).get_Value())))
                    {
                        break;


                    }

                    cantidadregistros += 1;

                }

                var loopTo1 = (int)Math.Round(cantidadregistros + Conversions.ToDouble(fila) - 2d);
                for (intLoopCounter = Conversions.ToInteger(fila); intLoopCounter <= loopTo1; intLoopCounter++)
                {
                    // panelespera.Visible = True

                    // BunifuCircleProgressbar1.MaxValue = cantidadregistros + fila - 2
                    ncargando.MonoFlat_Label1.Text = "" + contador + " registros de " + (cantidadregistros - 1) + "";
                    // BunifuCircleProgressbar1.Value = intLoopCounter
                    // Sql = "insert into hotel(Nombre,telefono,email) values('" & .Range("" & Combonombre.Text & "" & intLoopCounter) & "','" & .Range("" & Combotelefono.Text & "" & intLoopCounter) & "','" & .Range("" & Comboemail.Text & "" & intLoopCounter) & "')"

                    dtDatos.Rows.Add(objXLApp.get_Range("" + columna + "" + intLoopCounter).get_Value(), objXLApp.get_Range("" + columna + "" + intLoopCounter).get_Offset(0, 1).get_Value(), objXLApp.get_Range("" + columna + "" + intLoopCounter).get_Offset(0, 2).get_Value(), objXLApp.get_Range("" + columna + "" + intLoopCounter).get_Offset(0, 3).get_Value());

                    contador += 1;
                }
                objXLApp.Workbooks[1].Close(false);
                objXLApp.Quit();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ncargando.Close();
        }

        private void BackgroundTraspaso_DoWork(object sender, DoWorkEventArgs e)
        {
            iniciarconexionDestino();
            if (tipo == "Solicitud")
            {
                foreach (DataRow row in dataDocumentosSolicitud.Rows)
                {
                    foreach (DataGridViewRow rowid in dtDatos.Rows)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["IdDatosSolicitud"].ToString(), rowid.Cells[0].Value, false)))
                        {
                            SqlCommand comandoDocumento;
                            string consultaDocumento;
                            consultaDocumento = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into documentossolicitud values('", rowid.Cells[1].Value), "','"), row["Tipo"]), "',@imagen)"));
                            var imgDocumento = new SqlParameter("@imagen", SqlDbType.Image);
                            imgDocumento.Value = row["Imagen"];
                            comandoDocumento = new SqlCommand();
                            comandoDocumento.Connection = conexionDestino;
                            comandoDocumento.CommandText = consultaDocumento;
                            comandoDocumento.Parameters.Add(imgDocumento);
                            comandoDocumento.ExecuteNonQuery();


                        }
                    }
                }
            }
            else
            {
                foreach (DataRow row in dataDocumentosSolicitud.Rows)
                {
                    foreach (DataGridViewRow rowid in dtDatos.Rows)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["IdCredito"].ToString(), rowid.Cells[0].Value, false)))
                        {
                            SqlCommand comandoDocumento;
                            string consultaDocumento;
                            consultaDocumento = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into documentosCredito values('", rowid.Cells[1].Value), "','"), row["Tipo"]), "',@imagen)"));
                            var imgDocumento = new SqlParameter("@imagen", SqlDbType.Image);
                            imgDocumento.Value = row["Imagen"];
                            comandoDocumento = new SqlCommand();
                            comandoDocumento.Connection = conexionDestino;
                            comandoDocumento.CommandText = consultaDocumento;
                            comandoDocumento.Parameters.Add(imgDocumento);
                            comandoDocumento.ExecuteNonQuery();


                        }
                    }
                }
            }


        }

        private void BackgroundTraspaso_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ncargando.Close();

        }

        private void btnTraspasar_Click(object sender, EventArgs e)
        {
            ncargando = new Cargando();
            ncargando.Show();
            ncargando.MonoFlat_Label1.Text = "Realizando traspaso de documentos";
            BackgroundTraspaso.RunWorkerAsync();

        }

        private void RadioSolicitud_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioSolicitud.Checked)
            {
                tipo = "Solicitud";
            }
            else
            {
                tipo = "Crédito";
            }
        }

        private void RadioCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioCredito.Checked)
            {
                tipo = "Crédito";
            }
            else
            {
                tipo = "Solicitud";

            }
        }
    }
}