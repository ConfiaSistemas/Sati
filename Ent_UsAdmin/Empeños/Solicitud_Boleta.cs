using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class Solicitud_Boleta
    {

        private string idtipo, tipo, nombreTipo, Modalidad, tipocredito, porcentajeSugerido;
        private double plazoTipo, porcentajeRefrendo;
        private bool consultadoTipo;
        private string nombreCliente, idCliente;
        private bool consultadoCliente;
        private int totalintegrantes = 0;
        private DataSet dataGestores;
        private DataSet dataPromotores;
        private SqlDataAdapter adapterGestores;
        private SqlDataAdapter adapterPromotores;
        private DataSet dataLegal;
        private SqlDataAdapter adapterLegal;
        private double totalMoratorios;
        private bool empezar;
        private double MontoTotal = 0d;
        private string esta;
        private bool usarNombre;
        public bool autorizado;
        private DataTable dataTipo;
        private SqlDataAdapter adapterTipo;
        private double totalValuado = 0d;
        private double totalSugerido = 0d;
        private bool errorValuado, errorSugerido;
        private int idSolicitudBoleta;
        private bool estabien;
        private bool tieneFocus;

        public Solicitud_Boleta()
        {
            InitializeComponent();
        }

        private void Levantar_Solicitud_Load(object sender, EventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Gestores";
            BackgroundGestores.RunWorkerAsync();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.BuscarClienteEmpeño.Show();
        }

        private void btn_agregar_click(object sender, EventArgs e)
        {
            try
            {
                var bm = new Bitmap(txtPrenda.Text);
                dtdatos.Rows.Add(bm, "", "", "", "", "");
                foreach (DataGridViewRow row in dtdatos.Rows)
                    row.Height = 100;
                foreach (DataGridViewRow row in dtdatos.Rows)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row.Cells[1].Value, "", false)))
                    {
                        dtdatos.Focus();
                        dtdatos.CurrentCell = dtdatos[row.Cells[1].ColumnIndex, row.Index];
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("La ruta de la imagen no es válida");
                txtPrenda.Select();

                txtPrenda.Text = "";
            }

        }


        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Module_resize.MoveForm(this);
            }
        }

        private void BackgroundGestores_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {
                Module1.iniciarconexionempresa();
                string consulta;
                consulta = "Select id,nombre from empleados where tipo = 'G'";
                adapterGestores = new SqlDataAdapter(consulta, Module1.conexionempresa);
                dataGestores = new DataSet();
                adapterGestores.Fill(dataGestores);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error " + ex.Message);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.TiposDeEmpeños.Show();
        }

        private void BackgroundPromotores_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Module1.iniciarconexionempresa();
                string consulta;
                consulta = "Select id,nombre from empleados where tipo = 'P'";
                adapterPromotores = new SqlDataAdapter(consulta, Module1.conexionempresa);
                dataPromotores = new DataSet();
                adapterPromotores.Fill(dataPromotores);
                empezar = true;
            }
            catch (Exception ex)
            {
                empezar = false;
                MessageBox.Show("Ha ocurrido un error " + ex.Message);
            }

        }

        public void ConsultarTipocredito()
        {
            try
            {
                Module1.iniciarconexionempresa();
                SqlCommand comando;
                string consulta;
                SqlDataReader reader;
                consulta = "select id,nombre,porcentajerefrendo, porcentajeSugerido from TiposDeEmpeño where id = '" + txtTipo.Text + "'";
                comando = new SqlCommand();
                comando.Connection = Module1.conexionempresa;
                comando.CommandText = consulta;
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        nombreTipo = Conversions.ToString(reader["nombre"]);


                        idtipo = txtTipo.Text;

                        porcentajeRefrendo = Conversions.ToDouble(reader["porcentajerefrendo"]);

                        porcentajeSugerido = Conversions.ToString(reader["porcentajeSugerido"]);
                    }
                    lblTipo.Text = nombreTipo;
                    txtMontoTotalSugerido.Text = plazoTipo.ToString();
                    txtPorcentajeRefrendo.Text = porcentajeRefrendo.ToString();
                }

                else
                {
                    lblTipo.Text = "No se encontró";
                }


                consultadoTipo = true;
            }
            catch (Exception ex)
            {
                lblTipo.Text = "...";
                consultadoTipo = false;
                MessageBox.Show("Ha ocurrido un error " + ex.Message);
            }

        }


        public void ConsultarCliente()
        {
            Module1.iniciarconexionempresa();
            SqlCommand comando;
            string consulta;
            SqlDataReader reader;
            consulta = "select id,id,(nombre+' '+apellidoPaterno+' '+apellidoMaterno) as nombre from clientes where id = '" + txtIdCLiente.Text + "'";
            comando = new SqlCommand();
            comando.Connection = Module1.conexionempresa;
            comando.CommandText = consulta;
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    idCliente = Conversions.ToString(reader["id"]);
                    nombreCliente = Conversions.ToString(reader["nombre"]);
                }

                lblCliente.Text = nombreCliente;
                consultadoCliente = true;
            }
            else
            {
                consultadoCliente = false;
                lblCliente.Text = "No se encontró";
            }
        }


        private void BackgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            SqlCommand comandoSolicitud;
            string consultaSolicitud;

            consultaSolicitud = "insert into SolicitudBoleta values(" + txtIdCLiente.Text + ",'" + lblCliente.Text + "','','','','','','','','" + txtMontoTotalValuado.Text + "'," + txtMontoTotalSugerido.Text + "," + txtPorcentajeRefrendo.Text + ",'','" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "','I','" + txtTipo.Text + "','" + ConsultarIdPromotor(ComboPromotor.Text) + "','" + Module1.nmusr + "','','') select SCOPE_IDENTITY()";
            comandoSolicitud = new SqlCommand();
            comandoSolicitud.Connection = Module1.conexionempresa;
            comandoSolicitud.CommandText = consultaSolicitud;
            idSolicitudBoleta = Conversions.ToInteger(comandoSolicitud.ExecuteScalar());

            foreach (DataGridViewRow row in dtdatos.Rows)
            {
                string consultaArticulos = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into articulosempeños values(" + idSolicitudBoleta + ",'" + ConsultarTipo(Conversions.ToString(row.Cells[1].Value)) + "','", row.Cells[5].Value), "','"), row.Cells[2].Value), "','"), row.Cells[3].Value), "','"), row.Cells[4].Value), "',"), row.Cells[6].Value), ","), row.Cells[7].Value), ",'',@imagen,1)"));
                SqlCommand comandoArticulo;
                Bitmap imagen = row.Cells[0].Value as Bitmap;
                var imgDocumento = new SqlParameter("@imagen", SqlDbType.Image);
                var msImgDocumento = new MemoryStream();
                imagen.Save(msImgDocumento, ImageFormat.Jpeg);
                imgDocumento.Value = msImgDocumento.GetBuffer();
                comandoArticulo = new SqlCommand();
                comandoArticulo.Connection = Module1.conexionempresa;
                comandoArticulo.CommandText = consultaArticulos;
                comandoArticulo.Parameters.Add(imgDocumento);
                comandoArticulo.ExecuteNonQuery();

            }

            SqlCommand comandoCronograma;
            string consultaCronograma;
            string tiempo = DateAndTime.TimeOfDay.ToString("HH:mm:ss");
            consultaCronograma = "insert into CronogramaSolicitudEmpeño values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tiempo + "','" + idSolicitudBoleta + "','Se registró la solicitud por " + Module1.nmusr + "')";
            comandoCronograma = new SqlCommand();
            comandoCronograma.Connection = Module1.conexionempresa;
            comandoCronograma.CommandText = consultaCronograma;
            comandoCronograma.ExecuteNonQuery();

        }

        private void btn_Procesar_Click(object sender, EventArgs e)
        {

            if (dtdatos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dtdatos.Rows)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row.Cells[1].Value, "", false)))
                    {
                        MessageBox.Show("La columna Tipo está vacía, todos los campos son obligatorios");
                        dtdatos.Focus();
                        dtdatos.CurrentCell = dtdatos[row.Cells[1].ColumnIndex, row.Index];
                        break;
                    }


                    else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row.Cells[2].Value, "", false)))
                    {
                        MessageBox.Show("La columna Marca está vacía, todos los campos son obligatorios");
                        dtdatos.Focus();
                        dtdatos.CurrentCell = dtdatos[row.Cells[2].ColumnIndex, row.Index];
                        break;
                    }
                    else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row.Cells[3].Value, "", false)))
                    {
                        MessageBox.Show("La columna Modelo está vacía, todos los campos son obligatorios");
                        dtdatos.Focus();
                        dtdatos.CurrentCell = dtdatos[row.Cells[3].ColumnIndex, row.Index];
                        break;
                    }
                    else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row.Cells[4].Value, "", false)))
                    {
                        MessageBox.Show("La columna No. de Serie está vacía, todos los campos son obligatorios");
                        dtdatos.Focus();
                        dtdatos.CurrentCell = dtdatos[row.Cells[4].ColumnIndex, row.Index];
                        break;
                    }
                    else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row.Cells[5].Value, "", false)))
                    {
                        MessageBox.Show("La columna Descripción está vacía, todos los campos son obligatorios");
                        dtdatos.Focus();
                        dtdatos.CurrentCell = dtdatos[row.Cells[5].ColumnIndex, row.Index];
                        break;
                    }
                    else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row.Cells[6].Value, "", false)))
                    {
                        MessageBox.Show("La columna Monto Valuado está vacía, todos los campos son obligatorios");
                        dtdatos.Focus();
                        dtdatos.CurrentCell = dtdatos[row.Cells[6].ColumnIndex, row.Index];
                        break;
                    }

                    else if (Information.IsNumeric(row.Cells[6].Value))
                    {
                        if (string.IsNullOrEmpty(row.Cells[7].Value.ToString()))
                        {
                            MessageBox.Show("La columna Monto Sugerido está vacía, todos los campos son obligatorios");
                            dtdatos.Focus();
                            dtdatos.CurrentCell = dtdatos[row.Cells[7].ColumnIndex, row.Index];
                            estabien = false;
                            break;
                        }
                        else if (Information.IsNumeric(row.Cells[7].Value))
                        {
                            estabien = true;
                        }
                        else
                        {
                            MessageBox.Show("La columna Monto Sugerido solo admite valores numéricos");
                            dtdatos.Focus();
                            dtdatos.CurrentCell = dtdatos[row.Cells[7].ColumnIndex, row.Index];
                            estabien = false;
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("La columna Monto Valuado solo admite valores numéricos");
                        dtdatos.Focus();
                        dtdatos.CurrentCell = dtdatos[row.Cells[6].ColumnIndex, row.Index];
                        break;


                    }
                }
                if (estabien)
                {
                    My.MyProject.Forms.Autorizacion.tipoAutorizacion = "SatiModEmpeñosAgregarSolicitud";
                    My.MyProject.Forms.Autorizacion.ShowDialog();
                    if (autorizado)
                    {
                        My.MyProject.Forms.Cargando.Show();
                        My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Procesando";
                        BackgroundWorker1.RunWorkerAsync();
                    }
                    else
                    {
                        MessageBox.Show("No fue autorizado");
                    }

                }
            }



            else
            {
                MessageBox.Show("La solicitud no cuenta con ningún artículo");
                txtPrenda.Select();
            }

        }

        private void dtdatos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dtdatos.Rows.Count != 0)
                {
                    dtdatos.Rows.RemoveAt(dtdatos.CurrentCell.RowIndex);
                }

            }
        }



        private void ComboLegal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BackgroundGestores_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Promotores";
            BackgroundPromotores.RunWorkerAsync();

        }


        private void BackgroundPromotores_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Tipos";
            ComboPromotor.Items.Clear();

            foreach (DataRow row in dataPromotores.Tables[0].Rows)

                ComboPromotor.Items.Add(row["nombre"]);
            ComboPromotor.SelectedIndex = 0;
            BackgroundTipos.RunWorkerAsync();
        }


        private int ConsultarIdPromotor(string nombre)
        {
            int idEmpleado=0;

            foreach (DataRow row in dataPromotores.Tables[0].Rows)
            {
                if ((row["nombre"].ToString() ?? "") == (nombre ?? ""))
                {
                    idEmpleado = (int)Math.Round(Conversion.Val(row["id"].ToString()));
                    break;
                }
            }



            return idEmpleado;
        }


        private int ConsultarIdGestor(string nombre)
        {
            int idEmpleado=0;

            foreach (DataRow row in dataGestores.Tables[0].Rows)
            {
                if ((row["nombre"].ToString() ?? "") == (nombre ?? ""))
                {
                    idEmpleado = (int)Math.Round(Conversion.Val(row["id"].ToString()));
                    break;
                }
            }



            return idEmpleado;
        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void dtdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPrenda_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void BackgroundTipos_DoWork(object sender, DoWorkEventArgs e)
        {
            string consultaTipos;
            consultaTipos = "Select id,nombre from tipoarticulosempeño";
            adapterTipo = new SqlDataAdapter(consultaTipos, Module1.conexionempresa);
            dataTipo = new DataTable();
            adapterTipo.Fill(dataTipo);
        }

        private void TextBoxEx1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();
            My.MyProject.Forms.DatosSolicitudBoleta.idSolicitud = idSolicitudBoleta;
            My.MyProject.Forms.DatosSolicitudBoleta.tipoSolicitud = Conversions.ToInteger(txtTipo.Text);
            My.MyProject.Forms.DatosSolicitudBoleta.Show();
            Close();
        }


        private void dtdatos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow row in dtdatos.Rows)
            {
                DataGridViewComboBoxCell combocolumn = (DataGridViewComboBoxCell)row.Cells[1];
                if (combocolumn.Items.Count == 0)
                {
                    foreach (DataRow rowtipo in dataTipo.Rows)

                        combocolumn.Items.Add(rowtipo["nombre"].ToString());

                }
            }
        }

        private int ConsultarTipo(string nombre)
        {
            int idtipo =0;

            foreach (DataRow row in dataTipo.Rows)
            {

                if ((row["nombre"].ToString() ?? "") == (nombre ?? ""))
                {
                    idtipo = (int)Math.Round(Conversion.Val(row["id"].ToString()));
                    break;
                }
            }



            return idtipo;
        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackgroundTipos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();
        }

        private void dtdatos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            totalValuado = 0d;

            try
            {
                foreach (DataGridViewRow row in dtdatos.Rows)


                    totalValuado = Conversions.ToDouble(Operators.AddObject(totalValuado, row.Cells[6].Value));

                errorValuado = false;
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("La columna Monto Valuado solo admite valores numéricos");
                dtdatos.Focus();
                dtdatos.CurrentCell = dtdatos[dtdatos.CurrentRow.Cells[6].ColumnIndex, dtdatos.CurrentRow.Index];
                errorValuado = true;
            }

            if (errorValuado == false)
            {
                if (dtdatos.CurrentCell.ColumnIndex == 6)
                {
                    dtdatos.CurrentRow.Cells[7].Value = Operators.MultiplyObject(Operators.MultiplyObject(dtdatos.CurrentRow.Cells[6].Value, porcentajeSugerido), 0.01d);
                }
            }

            totalSugerido = 0d;
            try
            {
                foreach (DataGridViewRow row in dtdatos.Rows)
                    totalSugerido = Conversions.ToDouble(Operators.AddObject(totalSugerido, row.Cells[7].Value));
                errorSugerido = false;
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("La columna Monto Sugerido solo admite valores numéricos");
                dtdatos.Focus();
                dtdatos.CurrentCell = dtdatos[dtdatos.CurrentRow.Cells[7].ColumnIndex, dtdatos.CurrentRow.Index];
                errorSugerido = true;
            }
            txtMontoTotalValuado.Text = totalValuado.ToString();
            txtMontoTotalSugerido.Text = totalSugerido.ToString();

        }

        private void txtPrenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxEx1_MouseHover(object sender, EventArgs e)
        {
            txtIdCLiente.BorderColor = Color.Blue;
        }

        private void TextBoxEx1_MouseLeave(object sender, EventArgs e)
        {
            if (tieneFocus)
            {
            }
            else
            {
                txtIdCLiente.BorderColor = Color.Gray;
            }

        }

        private void TextBoxEx1_GotFocus(object sender, EventArgs e)
        {
            tieneFocus = true;
            txtIdCLiente.BorderColor = Color.Blue;
        }

        private void TextBoxEx1_LostFocus(object sender, EventArgs e)
        {
            tieneFocus = false;
            txtIdCLiente.BorderColor = Color.Gray;
        }

        private void txtIdCLiente_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.IsInputKey = true;
            }
        }

        private void txtIdCLiente_KeyDown(object sender, KeyEventArgs e)
        {
            if (empezar)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ConsultarCliente();
                    if (consultadoCliente)
                    {

                        btn_agregar.Visible = true;
                        txtPrenda.Select();
                    }
                }
                if (e.KeyCode == Keys.Tab)
                {
                    ConsultarCliente();
                    if (consultadoCliente)
                    {

                        btn_agregar.Visible = true;
                        txtPrenda.Select();
                    }
                }
                if ((int)e.KeyData == (int)Keys.Shift + (int)Keys.Tab)
                {
                    txtTipo.Select();
                }
            }
            else
            {
                MessageBox.Show("No se han cargado los valores, espere");
            }

            if (e.KeyCode == Keys.F2)
            {
                My.MyProject.Forms.BuscarClienteEmpeño.Show();
            }
        }

        private void txtPrenda_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.IsInputKey = true;
            }
        }

        private void txtPrenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                var fimagen = new OpenFileDialog();
                fimagen.Filter = "Archivos de imagen (*.png,*.jpg,*.jpeg,*.bmp,*.ico)|*.png;*.jpg;*.jpeg;*.bmp;*.ico";
                var result = fimagen.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtPrenda.Text = fimagen.FileName;
                }
                else
                {
                    MessageBox.Show("No se seleccionó ningún archivo");
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    var bm = new Bitmap(txtPrenda.Text);
                    dtdatos.Rows.Add(bm, "", "", "", "", "");
                    foreach (DataGridViewRow row in dtdatos.Rows)
                        row.Height = 100;
                    foreach (DataGridViewRow row in dtdatos.Rows)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row.Cells[1].Value, "", false)))
                        {
                            dtdatos.Focus();
                            dtdatos.CurrentCell = dtdatos[row.Cells[1].ColumnIndex, row.Index];
                            SendKeys.Send("%{DOWN}");
                        }
                    }
                }


                catch (ArgumentException ex)
                {
                    MessageBox.Show("La ruta de la imagen no es válida");
                    txtPrenda.Select();

                    txtPrenda.Text = "";
                }
            }


            if ((int)e.KeyData == (int)Keys.Shift + (int)Keys.Tab)
            {
                txtIdCLiente.Select();
            }

        }

        private void txtTipo_MouseHover(object sender, EventArgs e)
        {
            txtTipo.BorderColor = Color.Blue;
        }

        private void txtTipo_MouseLeave(object sender, EventArgs e)
        {
            if (!tieneFocus)
            {
                txtTipo.BorderColor = Color.Gray;
            }
        }

        private void txtTipo_GotFocus(object sender, EventArgs e)
        {
            tieneFocus = true;
            txtTipo.BorderColor = Color.Blue;
        }

        private void txtTipo_LostFocus(object sender, EventArgs e)
        {
            tieneFocus = false;
            txtTipo.BorderColor = Color.Gray;
        }

        private void txtTipo_KeyDown(object sender, KeyEventArgs e)
        {
            if (empezar)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ConsultarTipocredito();
                    txtIdCLiente.Select();
                }

                if (e.KeyCode == Keys.Tab)
                {
                    ConsultarTipocredito();
                    txtIdCLiente.Select();
                }

                if (e.KeyCode == Keys.F2)
                {
                    My.MyProject.Forms.TiposDeEmpeños.Show();
                }
            }
            else
            {
                MessageBox.Show("No se han cargado los valores, espere");
            }
        }

        private void txtTipo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.IsInputKey = true;
            }
        }

        private void txtPrenda_MouseHover(object sender, EventArgs e)
        {
            txtPrenda.BorderColor = Color.Blue;
        }

        private void txtPrenda_MouseLeave(object sender, EventArgs e)
        {
            if (tieneFocus == false)
            {
                txtPrenda.BorderColor = Color.Gray;
            }
        }

        private void txtPrenda_GotFocus(object sender, EventArgs e)
        {
            tieneFocus = true;
            txtPrenda.BorderColor = Color.Blue;
        }

        private void txtPrenda_LostFocus(object sender, EventArgs e)
        {
            tieneFocus = false;
            txtPrenda.BorderColor = Color.Gray;
        }
    }
}