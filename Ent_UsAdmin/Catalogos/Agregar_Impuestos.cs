using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Net;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConfiaAdmin
{

    public partial class Agregar_Impuestos
    {
        private bool actualizar;
        public bool autorizado;
        private Cargando nCargando;
        private bool curpValidada = false;
        private string estadoValidacionCurp;
        private string existe;
        public string idCliente;
        private string op="Op1";


        public class Curp
        {
         public   string Nombre { get; set; }
          public  string APaterno { get; set; }
           public string AMaterno { get; set; }
          public  string FechaNaci { get; set; }

        }

  Curp curp;

        public Agregar_Impuestos()
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

        }

        private  async  Task<Curp>  GetItems(string filter)
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
            catch(System.Net.Http.HttpRequestException e)
            {
                MessageBox.Show("No está disponible el servicio");
                return null;
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
            My.MyProject.Forms.Autorizacion.tipoAutorizacion = "SatiModClientesAgregar";
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


                    if(Conversions.ToInteger(string.Equals(crp.Nombre, txtnombre.Text, StringComparison.InvariantCultureIgnoreCase)) == 0)
                    {
                        MessageBox.Show("El valor Nombre es diferente al ingresado");
                        retorno = false;
                        estadoValidacionCurp = "El valor Nombre es diferente al ingresado";

                    }
                    else if(Conversions.ToInteger(string.Equals(crp.APaterno, txtApellidoP.Text, StringComparison.InvariantCultureIgnoreCase)) == 0)
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

        private async void  BunifuThinButton22_ClickAsync(object sender, EventArgs e)
        {
            btnConsultaCurp.Enabled = false;
            btn_agregar.Enabled = false;
            txtnombre.Text = "";
            txtApellidoP.Text = "";
            txtApellidoM.Text = "";
            DateNacimiento.Value = Conversions.ToDate("01/01/99");
            txtCelular.Text = "";
            txtTelefono.Text = "";

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
                            MessageBox.Show("Hubo un error curp no encontrada ");
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
            string sql;
            string tiempo = DateAndTime.TimeOfDay.ToString("HH:mm:ss");
            string respuesta;
            sql = "If not exists(select * from Clientes where Nombre = '" + txtnombre.Text + "' and ApellidoPaterno = '" + txtApellidoP.Text + "' and ApellidoMaterno = '" + txtApellidoM.Text + @"')
begin
insert into Clientes(Nombre,ApellidoPaterno,ApellidoMaterno,FechaNacimiento,fechaAlta,horaAlta,Telefono,Celular,curp,EstadoValidacion,Validado) values('" + txtnombre.Text + "', '" + txtApellidoP.Text + "', '" + txtApellidoM.Text + "', '" + Strings.Format(DateNacimiento.Value, "yyyy-MM-dd") + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tiempo + "','" + txtTelefono.Text + "','" + txtCelular.Text + "','" + txtcurp.Text + "','" + estadoValidacionCurp + "','" + curpValidada + @"') SELECT SCOPE_IDENTITY()
end
else
SELECT 'existe'";
            SqlCommand comandoagregar;
            if (string.IsNullOrEmpty(txtnombre.Text))
            {
                MessageBox.Show("No puede dejar el campo nombre en blanco");
            }
            else if (string.IsNullOrEmpty(txtApellidoP.Text) | string.IsNullOrEmpty(txtApellidoM.Text))
            {
                MessageBox.Show("Por lo menos debe tener un apellido");
            }
            else
            {
                try
                {
                    Module1.iniciarconexionempresa();
                    comandoagregar = new SqlCommand();
                    comandoagregar.Connection = Module1.conexionempresa;
                    comandoagregar.CommandText = sql;
                    respuesta = Conversions.ToString(comandoagregar.ExecuteScalar());
                    if (respuesta == "existe")
                    {
                        var result = MessageBox.Show("Ya existe un cliente con ese nombre, ¿Desea agregarlo de todos modos?", "Cliente existente", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            SqlCommand comandoAgregarAunAsi;
                            string consultaAgregarAunAsi;
                            consultaAgregarAunAsi = "insert into Clientes(Nombre,ApellidoPaterno,ApellidoMaterno,FechaNacimiento,fechaAlta,horaAlta,Telefono,Celular,curp,EstadoValidacion,Validado) values('" + txtnombre.Text + "', '" + txtApellidoP.Text + "', '" + txtApellidoM.Text + "', '" + Strings.Format(DateNacimiento.Value, "yyyy-MM-dd") + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tiempo + "','" + txtTelefono.Text + "','" + txtCelular.Text + "','" + txtcurp.Text + "','" + estadoValidacionCurp + "','" + curpValidada + "') Select SCOPE_IDENTITY()";
                            comandoAgregarAunAsi = new SqlCommand();
                            comandoAgregarAunAsi.Connection = Module1.conexionempresa;
                            comandoAgregarAunAsi.CommandText = consultaAgregarAunAsi;
                            respuesta = Conversions.ToString(comandoAgregarAunAsi.ExecuteScalar());

                            int idCli;
                            idCli = Conversions.ToInteger(respuesta);
                            SqlCommand comandoIdStr;
                            string consultaIdStr;
                            consultaIdStr = "update clientes set idstr = 'CF-" + Module1.prefijoEmpresa + "-" + idCli.ToString("00000.##") + "' where id = '" + respuesta + "'";
                            comandoIdStr = new SqlCommand();
                            comandoIdStr.Connection = Module1.conexionempresa;
                            comandoIdStr.CommandText = consultaIdStr;
                            comandoIdStr.ExecuteNonQuery();
                            actualizar = true;
                            MessageBox.Show("Listo");
                            txtnombre.Text = "";
                            txtApellidoP.Text = "";
                            txtApellidoM.Text = "";
                            txtCelular.Text = "";
                            txtTelefono.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("No fue agregado el cliente");
                        }
                    }
                    else
                    {
                        int idCli;
                        idCli = Conversions.ToInteger(respuesta);
                        SqlCommand comandoIdStr;
                        string consultaIdStr;
                        consultaIdStr = "update clientes set idstr = 'CF-" + Module1.prefijoEmpresa + "-" + idCli.ToString("00000.##") + "' where id = '" + respuesta + "'";
                        comandoIdStr = new SqlCommand();
                        comandoIdStr.Connection = Module1.conexionempresa;
                        comandoIdStr.CommandText = consultaIdStr;
                        comandoIdStr.ExecuteNonQuery();
                        actualizar = true;
                        MessageBox.Show("Listo");
                        txtnombre.Text = "";
                        txtApellidoP.Text = "";
                        txtApellidoM.Text = "";
                        txtCelular.Text = "";
                        txtTelefono.Text = "";
                    }
                }

                catch (Exception ex)
                {
                    actualizar = false;
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async void BackgroundValidar_DoWorkAsync(object sender, DoWorkEventArgs e)
        {
            if (op == "Op1")
            {
                //curpValidada = ValidarCurp(txtcurp.Text);
                curpValidada = await ValidarCurpOp1Async(txtcurp.Text);
            }
            else
            {
                curpValidada = ValidaCurpOp2(txtcurp.Text);
            }


        }

        private void BackgroundValidar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


            if (curpValidada)
            {
                nCargando.MonoFlat_Label1.Text = "Insertando Cliente";

                BackgroundAgregar.RunWorkerAsync();
            }

            else
            {

                var result = MessageBox.Show("No se pudo validar la curp, ¿Desea agregarlo de todos modos?", "Validación de curp", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    nCargando.MonoFlat_Label1.Text = "Insertando Cliente";
                    BackgroundAgregar.RunWorkerAsync();
                }
                else
                {
                    nCargando.Close();
                    btn_agregar.Enabled = true;

                }


            }

        }

        private void BackgroundValidaExistencia_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();

            SqlCommand comandoValidaExistencia;
            string consultaValidaExistencia;
            consultaValidaExistencia = "if exists(select concat('id:',id,' Nombre:',Nombre,' ',apellidopaterno,' ',apellidoMaterno) as nombre from clientes where curp='" + txtcurp.Text + @"' )
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
                nCargando.MonoFlat_Label1.Text = "Validando información en el RENAPO";
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

        private async void BunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            Boolean pruebavalidar = await ValidarCurpOp1Async(txtcurp.Text);
            MessageBox.Show(pruebavalidar.ToString());
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

        private void BackgroundConsultaCurpOp2_DoWork(object sender, DoWorkEventArgs e)
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

       
    }
}