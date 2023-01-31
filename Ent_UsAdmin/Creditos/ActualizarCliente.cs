using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;
using Microsoft.VisualBasic.CompilerServices;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace ConfiaAdmin
{

    public partial class ActualizarCliente
    {

        private bool actualizar;
        public bool autorizado;
        private Cargando nCargando;
        private bool curpValidada = false;
        private string estadoValidacionCurp;
        private string existe;
        public string idCliente;
        private DataTable dataCreditosCliente;
        private SqlDataAdapter adapterCreditosCliente;
        private string nombre;
        private string aPaterno;
        private string aMaterno;
        private DateTime fechana;
        private string valorAnterior;
        private string op="Op1";

        public class Curp
        {
            public string Nombre { get; set; }
            public string APaterno { get; set; }
            public string AMaterno { get; set; }
            public string FechaNaci { get; set; }

        }
        Curp curp;
        public ActualizarCliente()
        {
            InitializeComponent();
        }


        private void Agregar_Impuestos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (actualizar == true)
            {
                Invoke(new Action(() => My.MyProject.Forms.impuestos.cargarimpuestos()));


            }
        }

        private void Agregar_Impuestos_Load(object sender, EventArgs e)
        {
            nCargando = new Cargando();
            nCargando.Show();
            nCargando.MonoFlat_Label1.Text = "Cargando información";
            BackgroundConsultarCliente.RunWorkerAsync();

        }
        private async Task<Curp> GetItems(string filter)
        {
            try
            {
                var requestNombre = new HttpRequestMessage();
                requestNombre.RequestUri = new Uri("http://74.208.22.235:3000/Curp?curp=" + filter);
                requestNombre.Method = HttpMethod.Get;
                var clientNombre = new HttpClient();
                HttpResponseMessage responseNombre = await clientNombre.SendAsync(requestNombre);
                if (responseNombre.StatusCode == HttpStatusCode.OK)
                {
                    string content = await responseNombre.Content.ReadAsStringAsync();
                    var LCurp = JsonConvert.DeserializeObject<Curp>(content);
                    //Resultado = JsonConvert.DeserializeObject<List<NombreCredito>>(content);

                    // BindableLayout.SetItemsSource(MyStackList, MCalendario);
                    Curp crp = new Curp();
                    crp = LCurp;
                    return crp;
                    // await DisplayAlert("Mensaje", MCalendario[0].Pagar.ToString(), "Ok");

                }
                else
                {
                    return null;
                }
            }
            catch (System.Net.Http.HttpRequestException e)
            {
                MessageBox.Show("No está disponible el servicio");
                return null;
            }


        }


        public async Task<bool> ValidarCurpOp1Async(string filter)
        {
            Boolean retorno = false;
            try
            {
                var requestNombre = new HttpRequestMessage();
                requestNombre.RequestUri = new Uri("http://74.208.22.235:3000/Curp?curp=" + filter);
                requestNombre.Method = HttpMethod.Get;
                var clientNombre = new HttpClient();
                HttpResponseMessage responseNombre = await clientNombre.SendAsync(requestNombre);
                if (responseNombre.StatusCode == HttpStatusCode.OK)
                {
                    string content = await responseNombre.Content.ReadAsStringAsync();
                    var LCurp = JsonConvert.DeserializeObject<Curp>(content);
                    //Resultado = JsonConvert.DeserializeObject<List<NombreCredito>>(content);

                    // BindableLayout.SetItemsSource(MyStackList, MCalendario);
                    Curp crp = new Curp();
                    crp = LCurp;


                    if (Conversions.ToInteger(string.Equals(crp.Nombre, txtnombre.Text, StringComparison.InvariantCultureIgnoreCase)) == 0)
                    {
                        MessageBox.Show("El valor Nombre es diferente al ingresado");
                        retorno = false;
                        estadoValidacionCurp = "El valor Nombre es diferente al ingresado";

                    }
                    else if (Conversions.ToInteger(string.Equals(crp.APaterno, txtApellidoP.Text, StringComparison.InvariantCultureIgnoreCase)) == 0)
                    {
                        MessageBox.Show("El valor Apellido Paterno es diferente al ingresado");
                        retorno = false;
                        estadoValidacionCurp = "El valor Apellido Paterno es diferente al ingresado";
                    }
                    else if (Conversions.ToInteger(string.Equals(crp.AMaterno, txtApellidoM.Text, StringComparison.InvariantCultureIgnoreCase)) == 0)
                    {
                        MessageBox.Show("El valor Apellido Materno es diferente al ingresado");
                        retorno = false;
                        estadoValidacionCurp = "El valor Apellido Materno es diferente al ingresado";
                    }
                    else if (Conversions.ToInteger(string.Equals(crp.APaterno, txtApellidoP.Text, StringComparison.InvariantCultureIgnoreCase)) == 0)
                    {
                        MessageBox.Show("El valor Apellido Paterno es diferente al ingresado");
                        retorno = false;
                        estadoValidacionCurp = "El valor Apellido Paterno es diferente al ingresado";
                    }
                    else if (Conversions.ToInteger(string.Equals(crp.FechaNaci, DateNacimiento.Value.ToString("dd/MM/yyyy"), StringComparison.InvariantCultureIgnoreCase)) == 0)
                    {
                        MessageBox.Show("El valor Fecha de Nacimiento es diferente al ingresado");
                        retorno = false;
                        estadoValidacionCurp = "El valor Fecha de Nacimiento es diferente al ingresado";
                    }
                    else
                    {
                        retorno = true;
                    }
                    if (retorno)
                    {
                        estadoValidacionCurp = "Datos correctos";
                    }

                    return retorno;
                    // await DisplayAlert("Mensaje", MCalendario[0].Pagar.ToString(), "Ok");

                }
                else
                {
                    return false;
                }
            }
            catch (System.Net.Http.HttpRequestException e)
            {
                MessageBox.Show("No está disponible el servicio");
                return false;
            }


        }


        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Module_resize.MoveForm(this);
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {


            My.MyProject.Forms.Autorizacion.tipoAutorizacion = "SatiModClientesModificar";
            My.MyProject.Forms.Autorizacion.ShowDialog();
            if (autorizado)
            {
                btn_agregar.Enabled = false;
                nCargando = new Cargando();
                nCargando.Show();
                nCargando.MonoFlat_Label1.Text = "Validando existencia del cliente";
                BackgroundValidaExistencia.RunWorkerAsync();
            }

            else
            {
                MessageBox.Show("No fue autorizado");
            }





        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {







        }

        public bool ValidarCurp(string curp)
        {
            try
            {
                HttpWebRequest s;
                UTF8Encoding enc;
                string postdata;
                byte[] postdatabytes;
                s = (HttpWebRequest)WebRequest.Create("https://www.buholegal.com/consultacurp/");
                enc = new UTF8Encoding();
                postdata = "curp=" + txtcurp.Text;
                postdatabytes = enc.GetBytes(postdata);
                s.Method = "POST";
                s.ContentType = "application/x-www-form-urlencoded";
                s.ContentLength = postdatabytes.Length;

                using (var stream = s.GetRequestStream())
                {
                    stream.Write(postdatabytes, 0, postdatabytes.Length);
                }
                var result = s.GetResponse();

                bool retorno = true;
                var web = new HtmlWeb();
                // Dim doc As HtmlDocument = web.Load("http://www.renapo.sep.gob.mx/wsrenapo/MainControllerParam?curp=" & txtcurp.Text)
                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.Load(result.GetResponseStream(), true);
                // Get all tables in the document
                var tables = doc.DocumentNode.SelectNodes("//table");

                // Iterate all rows in the first table
                var rows = tables[0].SelectNodes("//tr");

                for (int i = 0, loopTo = rows.Count - 1; i <= loopTo; i++)
                {

                    // Iterate all columns in this row
                    var cols = rows[i].SelectNodes("//td");
                    for (int j = 0, loopTo1 = cols.Count - 1; j <= loopTo1; j++)
                    {

                        // Get the value of the column and print it
                        string value = cols[j].InnerText;
                        if (value == @"
                        
                            Espere mientras se ejecuta su consulta...
                            
                            
                        ")
                        {
                            MessageBox.Show("Hubo un error curp no encontrada");
                            retorno = false;
                            estadoValidacionCurp = "Hubo un error curp no encontrada";
                        }

                        else if (value == "Apellido Paterno:")
                        {
                            if (Conversions.ToInteger(string.Equals(cols[j + 1].InnerText, txtApellidoP.Text, StringComparison.InvariantCultureIgnoreCase)) == 0)
                            {
                                MessageBox.Show("El valor " + value + " es diferente al ingresado");
                                retorno = false;
                                estadoValidacionCurp = "El valor " + value + " es diferente al ingresado";


                            }
                        }

                        else if (value == "Apellido Materno:")
                        {
                            if (Conversions.ToInteger(string.Equals(cols[j + 1].InnerText, txtApellidoM.Text, StringComparison.InvariantCultureIgnoreCase)) == 0)
                            {
                                MessageBox.Show("El valor " + value + " es diferente al ingresado");
                                retorno = false;
                                estadoValidacionCurp = "El valor " + value + " es diferente al ingresado";
                            }
                        }

                        else if (value == "Nombre(s):")
                        {
                            if (Conversions.ToInteger(string.Equals(cols[j + 1].InnerText, txtnombre.Text, StringComparison.InvariantCultureIgnoreCase)) == 0)
                            {
                                MessageBox.Show("El valor " + value + " es diferente al ingresado");
                                retorno = false;
                                estadoValidacionCurp = "El valor " + value + " es diferente al ingresado";

                            }
                        }


                        else if (value == "Fecha de Nacimiento:")
                        {
                            if (Conversions.ToInteger(string.Equals(cols[j + 1].InnerText, DateNacimiento.Value.ToString("dd/MM/yyyy"), StringComparison.CurrentCultureIgnoreCase)) == 0)
                            {
                                MessageBox.Show("El valor " + value + " es diferente al ingresado");
                                retorno = false;
                                estadoValidacionCurp = "El valor " + value + " es diferente al ingresado";

                            }
                        }





                        // MessageBox.Show(value)
                    }
                    break;

                }
                if (retorno)
                {
                    estadoValidacionCurp = "Datos correctos";
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error " + ex.Message);
                return false;

            }

        }

        private async void BunifuThinButton22_ClickAsync(object sender, EventArgs e)
        {
            btnConsultaCurp.Enabled = false;
            btn_agregar.Enabled = false;
            txtnombre.Text = "";
            txtApellidoP.Text = "";
            txtApellidoM.Text = "";
            DateNacimiento.Value = Conversions.ToDate("01/01/99");
            // txtCelular.Text = ""
            // txtTelefono.Text = ""

            nCargando = new Cargando();
            nCargando.Show();
            nCargando.MonoFlat_Label1.Text = "Consultando Información";
            if (op == "Op1")
            {
                //BackgroundConsultarCurp.RunWorkerAsync();
                curp = await GetItems(txtcurp.Text);
                if (curp != null)
                {
                    txtnombre.Text = curp.Nombre;
                    txtApellidoP.Text = curp.APaterno;
                    txtApellidoM.Text = curp.AMaterno;
                    DateNacimiento.Value = Conversions.ToDate(curp.FechaNaci);
                    btnConsultaCurp.Enabled = true;
                    btn_agregar.Enabled = true;
                    nCargando.Close();
                }
                else
                {
                    btnConsultaCurp.Enabled = true;
                    btn_agregar.Enabled = true;
                    nCargando.Close();

                }
            }
            else
            {
                BackgroundConsultaCurpOp2.RunWorkerAsync();

            }

        }

        private void BackgroundConsultarCurp_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                HttpWebRequest s;
                UTF8Encoding enc;
                string postdata;
                byte[] postdatabytes;
                s = (HttpWebRequest)WebRequest.Create("https://www.buholegal.com/consultacurp/");
                enc = new UTF8Encoding();
                postdata = "curp=" + txtcurp.Text;
                postdatabytes = enc.GetBytes(postdata);
                s.Method = "POST";
                s.ContentType = "application/x-www-form-urlencoded";
                s.ContentLength = postdatabytes.Length;

                using (var stream = s.GetRequestStream())
                {
                    stream.Write(postdatabytes, 0, postdatabytes.Length);
                }
                var result = s.GetResponse();

                bool retorno = true;
                var web = new HtmlWeb();
                // Dim doc As HtmlDocument = web.Load("http://www.renapo.sep.gob.mx/wsrenapo/MainControllerParam?curp=" & txtcurp.Text)
                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.Load(result.GetResponseStream(), true);

                // Get all tables in the document
                var tables = doc.DocumentNode.SelectNodes("//table");

                // Iterate all rows in the first table
                var rows = tables[0].SelectNodes("//tr");

                for (int i = 0, loopTo = rows.Count - 1; i <= loopTo; i++)
                {

                    // Iterate all columns in this row
                    var cols = rows[i].SelectNodes("//td");
                    for (int j = 0, loopTo1 = cols.Count - 1; j <= loopTo1; j++)
                    {

                        // Get the value of the column and print it
                        string value = cols[j].InnerText;
                        if (value == @"
                        
                            Espere mientras se ejecuta su consulta...
                            
                            
                        ")
                        {
                            MessageBox.Show("Hubo un error curp no encontrada");
                        }


                        else if (value == "Apellido Paterno:")
                        {



                            txtApellidoP.Text = cols[j + 1].InnerText;
                        }



                        else if (value == "Apellido Materno:")
                        {


                            txtApellidoM.Text = cols[j + 1].InnerText;
                        }





                        else if (value == "Fecha de Nacimiento:")
                        {

                            DateNacimiento.Value = Conversions.ToDate(cols[j + 1].InnerText);
                        }


                        else if (value == "Nombre(s):")
                        {
                            txtnombre.Text = cols[j + 1].InnerText;

                        }





                        // MessageBox.Show(value)
                    }
                    break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error " + ex.Message);

            }
        }

        private void BackgroundConsultarCurp_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnConsultaCurp.Enabled = true;
            btn_agregar.Enabled = true;
            nCargando.Close();
        }

        private void BackgroundAgregar_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {
                Module1.iniciarconexionempresa();

                SqlCommand comandoIdStr;
                string consultaIdStr;
                consultaIdStr = "update clientes set curp='" + txtcurp.Text + "',telefono='" + txtTelefono.Text + "',celular='" + txtCelular.Text + "',estadoValidacion='" + estadoValidacionCurp + "',validado='" + curpValidada + "' where id = '" + idCliente + "'";
                comandoIdStr = new SqlCommand();
                comandoIdStr.Connection = Module1.conexionempresa;
                comandoIdStr.CommandText = consultaIdStr;
                comandoIdStr.ExecuteNonQuery();
                actualizar = true;
                MessageBox.Show("Listo");
            }



            catch (Exception ex)
            {
                actualizar = false;
                MessageBox.Show(ex.Message);
            }

        }

        private async void BackgroundValidar_DoWork(object sender, DoWorkEventArgs e)
        {
            if (op == "Op1")
            {
                // curpValidada = ValidarCurp(txtcurp.Text);
                curpValidada = await ValidarCurpOp1Async(txtcurp.Text);
            }
            else
            {
                curpValidada = ValidaCurpOp2(txtcurp.Text);
            }


        }

        private void BackgroundValidar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((txtnombre.Text ?? "") != (nombre ?? "") | (txtApellidoP.Text ?? "") != (aPaterno ?? "") | (txtApellidoM.Text ?? "") != (aMaterno ?? ""))
            {

                if (curpValidada)
                {
                    nCargando.MonoFlat_Label1.Text = "Consultando créditos asociados recientes";
                    BackgroundCreditosActivos.RunWorkerAsync();
                }

                // BackgroundAgregar.RunWorkerAsync()

                else
                {
                    MessageBox.Show("La curp no pudo ser validada");

                    nCargando.Close();
                    btn_agregar.Enabled = true;




                }
            }

            else if (curpValidada)
            {
                nCargando.MonoFlat_Label1.Text = "Actualizando Cliente";
                BackgroundAgregar.RunWorkerAsync();
            }

            // BackgroundAgregar.RunWorkerAsync()

            else
            {
                MessageBox.Show("La curp no pudo ser validada");

                nCargando.Close();
                btn_agregar.Enabled = true;




            }


        }

        private void BackgroundValidaExistencia_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();

            SqlCommand comandoValidaExistencia;
            string consultaValidaExistencia;
            consultaValidaExistencia = "if exists(select concat('id:',id,' Nombre:',Nombre,' ',apellidopaterno,' ',apellidoMaterno) as nombre from clientes where curp='" + txtcurp.Text + "' and id <> '" + idCliente + @"' )
                                       begin
                                            select concat('id:',id,' Nombre:',Nombre,' ',apellidopaterno,' ',apellidoMaterno) as nombre from clientes where curp='" + txtcurp.Text + @"'
                                            
                                    end
                                    else
                                    begin
                                    select 'No existe'
                                    end    ";
            comandoValidaExistencia = new SqlCommand();
            comandoValidaExistencia.Connection = Module1.conexionempresa;
            comandoValidaExistencia.CommandText = consultaValidaExistencia;
            existe = Conversions.ToString(comandoValidaExistencia.ExecuteScalar());


        }

        private void BackgroundValidaExistencia_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (existe == "No existe")
            {
                nCargando.MonoFlat_Label1.Text = "Validando información en la RENAPO";
                BackgroundValidar.RunWorkerAsync();
            }

            else
            {
                MessageBox.Show("El cliente ya existe con los datos " + existe);
                nCargando.Close();
                btn_agregar.Enabled = true;

            }
        }

        private void BackgroundAgregar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            nCargando.Close();
            btn_agregar.Enabled = true;
        }

        private void BackgroundConsultarCliente_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            SqlCommand comandoDatosCliente;
            string consultaDatosCliente;
            SqlDataReader readerDatosCliente;

            consultaDatosCliente = "select * from clientes where id='" + idCliente + "'";
            comandoDatosCliente = new SqlCommand();
            comandoDatosCliente.Connection = Module1.conexionempresa;
            comandoDatosCliente.CommandText = consultaDatosCliente;
            readerDatosCliente = comandoDatosCliente.ExecuteReader();
            if (readerDatosCliente.HasRows)
            {
                while (readerDatosCliente.Read())
                {
                    if (readerDatosCliente["curp"] is DBNull)
                    {
                        txtcurp.Text = "";
                    }
                    else
                    {
                        txtcurp.Text = Conversions.ToString(readerDatosCliente["curp"]);

                    }
                    nombre = Conversions.ToString(readerDatosCliente["nombre"]);
                    aPaterno = Conversions.ToString(readerDatosCliente["apellidopaterno"]);
                    aMaterno = Conversions.ToString(readerDatosCliente["apellidoMaterno"]);
                    fechana = Conversions.ToDate(readerDatosCliente["fechanacimiento"]);
                    DateNacimiento.Value = Conversions.ToDate(readerDatosCliente["fechanacimiento"]);
                    valorAnterior = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Nombre: " + nombre + " Apellido Paterno: " + aPaterno + " Apellido Materno: " + " Fecha Nacimiento: " + fechana.ToString("aaaa-MM-dd") + " Tel: ", readerDatosCliente["telefono"]), " Cel: "), readerDatosCliente["celular"]));
                    txtnombre.Text = Conversions.ToString(readerDatosCliente["nombre"]);
                    txtApellidoP.Text = Conversions.ToString(readerDatosCliente["apellidopaterno"]);
                    txtApellidoM.Text = Conversions.ToString(readerDatosCliente["apellidoMaterno"]);
                    txtTelefono.Text = Conversions.ToString(readerDatosCliente["telefono"]);
                    txtCelular.Text = Conversions.ToString(readerDatosCliente["celular"]);
                }
            }
        }

        private void BackgroundConsultarCliente_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            nCargando.Close();
        }

        private void BackgroundCreditosActivos_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consultaCreditosCliente;
            consultaCreditosCliente = "select Credito.id,Credito.Nombre,Credito.Monto,Credito.Pagare,TiposDeCredito.Nombre as Tipo,Credito.FechaEntrega,Credito.Estado from credito inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id  where IdCliente=" + idCliente + " and Estado <>'T'  and  tiposdecredito.Tipo ='I' order by FechaEntrega desc";
            adapterCreditosCliente = new SqlDataAdapter(consultaCreditosCliente, Module1.conexionempresa);
            dataCreditosCliente = new DataTable();
            adapterCreditosCliente.Fill(dataCreditosCliente);


        }

        private void BackgroundCreditosActivos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (dataCreditosCliente.Rows.Count > 0)
            {
                MessageBox.Show("El cliente contiene créditos asociados, al actualizar el cliente se tiene que actualizar el nombre del crédito asociado más reciente");
                nCargando.Close();

                My.MyProject.Forms.CreditosAsociadosActualizarCliente.dataCreditos = dataCreditosCliente;
                My.MyProject.Forms.CreditosAsociadosActualizarCliente.nombre = txtnombre.Text;
                My.MyProject.Forms.CreditosAsociadosActualizarCliente.aPaterno = txtApellidoP.Text;
                My.MyProject.Forms.CreditosAsociadosActualizarCliente.aMaterno = txtApellidoM.Text;
                My.MyProject.Forms.CreditosAsociadosActualizarCliente.FechaNacimiento = DateNacimiento.Value;
                My.MyProject.Forms.CreditosAsociadosActualizarCliente.telefono = txtTelefono.Text;
                My.MyProject.Forms.CreditosAsociadosActualizarCliente.Celular = txtCelular.Text;
                My.MyProject.Forms.CreditosAsociadosActualizarCliente.Curp = txtcurp.Text;
                My.MyProject.Forms.CreditosAsociadosActualizarCliente.EstadoValidacionCurp = estadoValidacionCurp;
                My.MyProject.Forms.CreditosAsociadosActualizarCliente.ValidadoCurp = curpValidada;
                My.MyProject.Forms.CreditosAsociadosActualizarCliente.valorAnterior = valorAnterior;
                My.MyProject.Forms.CreditosAsociadosActualizarCliente.idCliente = idCliente;
                My.MyProject.Forms.CreditosAsociadosActualizarCliente.Show();
            }

            else
            {
                nCargando.MonoFlat_Label1.Text = "Actualizando cliente";
                BackgroundActualizarTodo.RunWorkerAsync();

            }
        }

        private void BackgroundActualizarTodo_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Module1.iniciarconexionempresa();

                SqlCommand comandoIdStr;
                string consultaIdStr;
                consultaIdStr = "update clientes set curp='" + txtcurp.Text + "',telefono='" + txtTelefono.Text + "',celular='" + txtCelular.Text + "',estadoValidacion='" + estadoValidacionCurp + "',validado='" + curpValidada + "',nombre='" + txtnombre.Text + "',apellidopaterno='" + txtApellidoP.Text + "',apellidoMaterno='" + txtApellidoM.Text + "',fechanacimiento='" + DateNacimiento.Value.ToString("yyyy-MM-dd") + "' where id = '" + idCliente + "'";
                comandoIdStr = new SqlCommand();
                comandoIdStr.Connection = Module1.conexionempresa;
                comandoIdStr.CommandText = consultaIdStr;
                comandoIdStr.ExecuteNonQuery();
                actualizar = true;
                MessageBox.Show("Listo");
            }



            catch (Exception ex)
            {
                actualizar = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void BackgroundActualizarTodo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            nCargando.Close();

        }

        private bool ValidaCurpOp2(string curp)
        {

            try
            {
                HttpWebRequest s;
                UTF8Encoding enc;
                string postdata;
                byte[] postdatabytes;
                var tempCookies = new CookieContainer();
                string Boundary = Guid.NewGuid().ToString().Replace("-", "");
                s = (HttpWebRequest)WebRequest.Create("http://registrate.fgr.org.mx/Applicant/CheckCurp");
                enc = new UTF8Encoding();
                postdata = "__RequestVerificationToken=U-mGkTgFNrE3HTcnjqYOAuwsSY4dE209vhiNqaS3D79oKYwphVJUvMlpVhiT0LXfcu6clJZL8k9Xv9ALOrvMITgC0pabK9x2KKXes0HfT4U1&Curp=" + curp + "&CaptchaValue_56e84f664f324334a0c40a223da4fa38=vqGBttp4Dr4AZK2OtZH/Mg==&CaptchaUserInput_5563becd985f482dace5a6c102c15453=4njyJ8";
                postdatabytes = enc.GetBytes(postdata);
                s.Method = "POST";

                // .ContentType = "multipart/form-data;boundary=" & Boundary
                s.ContentType = "application/x-www-form-urlencoded";
                s.ContentLength = postdatabytes.Length;
                s.CookieContainer = tempCookies;
                bool retorno = true;


                using (var stream = s.GetRequestStream())
                {
                    stream.Write(postdatabytes, 0, postdatabytes.Length);
                }
                var result = s.GetResponse();
                var web = new HtmlWeb();
                // Dim doc As HtmlDocument = web.Load("http://registrate.fgr.org.mx/Applicant/Register?curp=" & txtcurp.Text & "&guid=374d9585-bec7-4c4e-8d04-62342457dad7")
                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.Load(result.GetResponseStream(), true);
                var nombres = doc.DocumentNode.SelectSingleNode("//*[@id='Names']");
                var apePaterno = doc.DocumentNode.SelectSingleNode("//*[@id='LastName']");
                var apeMaterno = doc.DocumentNode.SelectSingleNode("//*[@id='SecondLastName']");
                var Fechanacimien = doc.DocumentNode.SelectSingleNode("//*[@id='BirthDay']");


                if (nombres != null)
                {
                    if (Conversions.ToInteger(string.Equals(nombres.GetAttributeValue("value", ""), txtnombre.Text, StringComparison.InvariantCultureIgnoreCase)) == 0)
                    {
                        MessageBox.Show("El valor Nombres es diferente al ingresado");
                        retorno = false;
                        estadoValidacionCurp = "El valor Nombres es diferente al ingresado";
                    }
                    else if (Conversions.ToInteger(string.Equals(apePaterno.GetAttributeValue("value", ""), txtApellidoP.Text, StringComparison.InvariantCultureIgnoreCase)) == 0)
                    {
                        MessageBox.Show("El valor Apellido Paterno es diferente al ingresado");
                        retorno = false;
                        estadoValidacionCurp = "El valor Apellido Paterno es diferente al ingresado";
                    }
                    else if (Conversions.ToInteger(string.Equals(apeMaterno.GetAttributeValue("value", ""), txtApellidoM.Text, StringComparison.InvariantCultureIgnoreCase)) == 0)
                    {
                        MessageBox.Show("El valor Apellido Materno es diferente al ingresado");
                        retorno = false;
                        estadoValidacionCurp = "El valor Apellido Materno es diferente al ingresado";
                    }
                    else if (Conversions.ToInteger(string.Equals(apeMaterno.GetAttributeValue("value", ""), txtApellidoM.Text, StringComparison.InvariantCultureIgnoreCase)) == 0)
                    {
                        MessageBox.Show("El valor Apellido Materno es diferente al ingresado");
                        retorno = false;
                        estadoValidacionCurp = "El valor Apellido Materno es diferente al ingresado";
                    }
                    else if (Conversions.ToInteger(string.Equals(Fechanacimien.GetAttributeValue("value", ""), DateNacimiento.Value.ToString("dd/MM/yyyy"), StringComparison.CurrentCultureIgnoreCase)) == 0)
                    {
                        MessageBox.Show("El valor Fecha de Nacimiento es diferente al ingresado");
                        retorno = false;
                        estadoValidacionCurp = "El valor Fecha de Nacimiento es diferente al ingresado";

                    }
                }



                else
                {
                    MessageBox.Show("Curp no encontrada");
                    retorno = false;

                }
                if (retorno)
                {
                    estadoValidacionCurp = "Datos correctos";
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error " + ex.Message);
                return false;
            }



        }

        private void BackgroundCurpOp2_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                HttpWebRequest s;
                UTF8Encoding enc;
                string postdata;
                byte[] postdatabytes;
                var tempCookies = new CookieContainer();
                string Boundary = Guid.NewGuid().ToString().Replace("-", "");
                s = (HttpWebRequest)WebRequest.Create("http://registrate.fgr.org.mx/Applicant/CheckCurp");
                enc = new UTF8Encoding();
                postdata = "__RequestVerificationToken=U-mGkTgFNrE3HTcnjqYOAuwsSY4dE209vhiNqaS3D79oKYwphVJUvMlpVhiT0LXfcu6clJZL8k9Xv9ALOrvMITgC0pabK9x2KKXes0HfT4U1&Curp=" + txtcurp.Text + "&CaptchaValue_56e84f664f324334a0c40a223da4fa38=vqGBttp4Dr4AZK2OtZH/Mg==&CaptchaUserInput_5563becd985f482dace5a6c102c15453=4njyJ8";
                postdatabytes = enc.GetBytes(postdata);
                s.Method = "POST";

                // .ContentType = "multipart/form-data;boundary=" & Boundary
                s.ContentType = "application/x-www-form-urlencoded";
                s.ContentLength = postdatabytes.Length;
                s.CookieContainer = tempCookies;



                using (var stream = s.GetRequestStream())
                {
                    stream.Write(postdatabytes, 0, postdatabytes.Length);
                }
                var result = s.GetResponse();
                var web = new HtmlWeb();
                // Dim doc As HtmlDocument = web.Load("http://registrate.fgr.org.mx/Applicant/Register?curp=" & txtcurp.Text & "&guid=374d9585-bec7-4c4e-8d04-62342457dad7")
                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.Load(result.GetResponseStream(), true);
                var nombres = doc.DocumentNode.SelectSingleNode("//*[@id='Names']");
                var apePaterno = doc.DocumentNode.SelectSingleNode("//*[@id='LastName']");
                var apeMaterno = doc.DocumentNode.SelectSingleNode("//*[@id='SecondLastName']");
                var Fechanacimien = doc.DocumentNode.SelectSingleNode("//*[@id='BirthDay']");

                if (nombres != null)
                {

                    txtnombre.Text = nombres.GetAttributeValue("value", "");
                    txtApellidoP.Text = apePaterno.GetAttributeValue("value", "");
                    txtApellidoM.Text = apeMaterno.GetAttributeValue("value", "");
                    DateNacimiento.Value = Conversions.ToDate(Fechanacimien.GetAttributeValue("value", ""));
                }


                else
                {
                    MessageBox.Show("Curp no encontrada");
                }
            }



            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error " + ex.Message);

            }
        }

        private void BackgroundConsultaCurpOp2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnConsultaCurp.Enabled = true;
            btn_agregar.Enabled = true;
            nCargando.Close();
        }


        private void RadioOp1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioOp1.Checked)
            {
                op = "Op1";
            }
        }

        private void RadioOp2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioOp2.Checked)
            {
                op = "Op2";
            }
        }
    }
}