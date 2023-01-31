using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class Migrar
    {
        public string Archivo;
        public string columna;
        public string fila;

        public Migrar()
        {
            InitializeComponent();
        }
        private void Migrar_Load(object sender, EventArgs e)
        {

        }

        private void txtArchivo_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtArchivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                OpenFileDialog abrircarpeta;
                abrircarpeta = new OpenFileDialog();
                abrircarpeta.Filter = "Archivo de Excel|*.xls;*.xlsx";
                if (abrircarpeta.ShowDialog() == DialogResult.OK)
                {
                    txtArchivo.Text = abrircarpeta.FileName;
                }
                else
                {
                    MessageBox.Show("No se seleccionó ningún archivo");
                }
                My.MyProject.Forms.ImportarExcel.ShowDialog();

            }
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                My.MyProject.Forms.Cargando.Show();
                My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando datos";
                int intLoopCounter;
                int contador1;
                int contador = 1;
                int cantidadregistros = 1;

                string fname;
                Microsoft.Office.Interop.Excel.Application objXLApp;
                objXLApp = new Microsoft.Office.Interop.Excel.Application();
                fname = txtArchivo.Text;
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
                    My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "" + contador + " registros de " + (cantidadregistros - 1) + "";
                    // BunifuCircleProgressbar1.Value = intLoopCounter
                    // Sql = "insert into hotel(Nombre,telefono,email) values('" & .Range("" & Combonombre.Text & "" & intLoopCounter) & "','" & .Range("" & Combotelefono.Text & "" & intLoopCounter) & "','" & .Range("" & Comboemail.Text & "" & intLoopCounter) & "')"

                    dtimpuestos.Rows.Add(objXLApp.get_Range("" + columna + "" + intLoopCounter).get_Value(), objXLApp.get_Range("" + columna + "" + intLoopCounter).get_Offset(0, 1).get_Value(), objXLApp.get_Range("" + columna + "" + intLoopCounter).get_Offset(0, 2).get_Value(), objXLApp.get_Range("" + columna + "" + intLoopCounter).get_Offset(0, 3).get_Value());

                    contador += 1;
                }
                objXLApp.Workbooks[1].Close(false);
                objXLApp.Quit();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            My.MyProject.Forms.Cargando.Close();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Module1.iniciarconexionempresa();
                int canregistros;
                canregistros = dtimpuestos.Rows.Count;
                int numero = 1;

                foreach (DataGridViewRow row in dtimpuestos.Rows)
                {
                    My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = numero + " registros de '" + canregistros + "'";
                    SqlCommand comandoCalendario;
                    string consultaCalendario;
                    SqlDataReader readerCalendario;
                    consultaCalendario = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select FechaPago,Monto,interes,fecha,estado,abonado,pendiente,npago,convenio from pagosext where id_credito = '", row.Cells[0].Value), "' order by npago asc"));
                    comandoCalendario = new SqlCommand();
                    comandoCalendario.Connection = Module1.conexionempresa;
                    comandoCalendario.CommandText = consultaCalendario;
                    readerCalendario = comandoCalendario.ExecuteReader();
                    if (readerCalendario.HasRows)
                    {
                        while (readerCalendario.Read())
                        {
                            string consultaCalendarioSac;
                            SqlCommand comandoCalendarioSac;
                            string fechapago, monto, interes, pendiente, abonado, npago, id_credito, estado, convenio, fechaupago;
                            fechapago = Conversions.ToString(readerCalendario["fechapago"]);
                            monto = Conversions.ToString(readerCalendario["monto"]);
                            interes = Conversions.ToString(readerCalendario["interes"]);
                            pendiente = Conversions.ToString(readerCalendario["pendiente"]);
                            abonado = Conversions.ToString(readerCalendario["abonado"]);
                            npago = Conversions.ToString(readerCalendario["npago"]);
                            id_credito = Conversions.ToString(row.Cells[2].Value);
                            estado = Conversions.ToString(readerCalendario["estado"]);
                            convenio = Conversions.ToString(readerCalendario["convenio"]);
                            fechaupago = Conversions.ToString(readerCalendario["fecha"]);

                            consultaCalendarioSac = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into calendarionormal values('" + fechapago + "','" + monto + "','" + interes + "','" + pendiente + "','" + abonado + "','", readerCalendario["npago"]), "','"), id_credito), "','"), estado), "','"), convenio), "','"), fechaupago), "')"));
                            comandoCalendarioSac = new SqlCommand();
                            comandoCalendarioSac.Connection = Module1.conexionempresa;
                            comandoCalendarioSac.CommandText = consultaCalendarioSac;
                            comandoCalendarioSac.ExecuteNonQuery();

                        }

                    }
                    SqlCommand comandoActEstado;
                    string consultaActEstado;
                    consultaActEstado = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update credito set estado = '", row.Cells[3].Value), "' where id = '"), row.Cells[2].Value), "'"));
                    comandoActEstado = new SqlCommand();
                    comandoActEstado.Connection = Module1.conexionempresa;
                    comandoActEstado.CommandText = consultaActEstado;
                    comandoActEstado.ExecuteNonQuery();

                    numero += 1;

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Información";
            BackgroundWorker1.RunWorkerAsync();

        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();

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