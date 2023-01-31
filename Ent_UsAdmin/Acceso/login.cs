using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Encryption.RSA;
using MadMilkman.Ini;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace ConfiaAdmin
{

    public partial class login
    {
        public bool bloqueado;

        public login()
        {
            InitializeComponent();
        }
        [DllImport("user32")]
        private static extern long GetAsyncKeyState(int vkey);

        public async void MonoFlat_Button1_ClickAsync(object sender, EventArgs e)
        {
            if (bloqueado)
            {
                passwordBloqueadoAsync();
            }
            else
            {
                passwordInicioAsync();
            }
        }


        private void login_Load(object sender, EventArgs e)
        {

            Timer1.Enabled = true;
            txtusr.KeyPress += keypressed;

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Timer1.Interval = 1;
            Timer1.Start();

        }

        private void keypressed(object o, KeyPressEventArgs e)
        {
            // The keypressed method uses the KeyChar property to check 
            // whether the ENTER key is pressed. 

            // If the ENTER key is pressed, the Handled property is set to true, 
            // to indicate the event is handled.

            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                MessageBox.Show("hola");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.frm_adm.Show();

        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Module_resize.MoveForm(this);
            }
        }
        public async void passwordInicioAsync()
        {
            var options = new IniOptions() { EncryptionPassword = "EntUs01pos" };
            var iniFile = new IniFile(options);
            iniFile.Load(@"C:\ConfiaAdmin\SATI\SetConfig.ini");
            
            Module1.ipser = iniFile.Sections[0].Keys[0].Value;
            Module1.ipser = "25.17.97.21";
            Module1.bdser = iniFile.Sections[0].Keys[1].Value;
            try
            {
                Module1.TipoEquipo = iniFile.Sections[0].Keys["Tipo"].Value;
            }

            catch (ArgumentOutOfRangeException ex)
            {
                Module1.TipoEquipo = "";
            }
            // MessageBox.Show("No se encontró el valor leyenda configurado, se recomienda revisar la configuración")
            catch (NullReferenceException ex)
            {
                Module1.TipoEquipo = "";
                // MessageBox.Show("No se encontró el valor leyenda configurado, se recomienda revisar la configuración")
            }
            try
            {
                Module1.ImpresoraTarjetas = iniFile.Sections[0].Keys["Tarjetas"].Value;
            }

            catch (ArgumentOutOfRangeException ex)
            {
                Module1.ImpresoraTarjetas = "";
            }
            // MessageBox.Show("No se encontró el valor leyenda configurado, se recomienda revisar la configuración")
            catch (NullReferenceException ex)
            {
                Module1.ImpresoraTarjetas = "";
                // MessageBox.Show("No se encontró el valor leyenda configurado, se recomienda revisar la configuración")
            }

            Module1.ImpresoraPredeterminada = iniFile.Sections[0].Keys["Impresora"].Value;
            // noCaja = iniFile.Sections(0).Keys("Caja").Value
            // Impresora = iniFile.Sections(0).Keys("Impresora").Value
            Module1.iniciarconexion();
            try
            {
                string pass="", passdecrypt="" ;
                string s = "SELECT idusr FROM usr  where nm = '" + txtusr.MonoFlatTB.Text + "'";

                var connexio = new OleDbConnection(Module1.cn);
                var myCommand = new OleDbCommand(s);

                myCommand.Connection = connexio;

                connexio.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                    Module1.idusr = Conversions.ToString(myReader["idusr"].ToString());
                if (string.IsNullOrEmpty(Module1.idusr))
                {
                    MessageBox.Show("No existe el usuario");
                    txtusr.Focus();
                    txtusr.Select();
                }
                else
                {

                    string strcontra = "select pass from usr where idusr = '" + Module1.idusr + "'";
                    var ejec = new OleDbCommand(strcontra);
                    ejec.Connection = connexio;
                    My.MyProject.Forms.Cargando.Show();
                    My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando";
                    await Task.Factory.StartNew(() =>
                        {
                            var myreader2 = ejec.ExecuteReader();
                            while (myreader2.Read())
                            {
                                pass = Conversions.ToString(myreader2["pass"]);
                                var byteconverter = new UnicodeEncoding();
                                var CadByte = Convert.FromBase64String(pass);

                                var DecryptedMessage = Decrypt(CadByte, "<RSAKeyValue><Modulus>1D3WnN4qZq3DGHf7i3WjEixX0Nzka28RIR9lOrT7Eg2QmJTACm/E6388wMdGgH3yTwKPp/T5zm61yvZn44oHMka8EKlACGKkADsxN/ci0RLKJ0ZGYDVPtB+KSzI+GbmX2eO00R+FlYvXTpMzGXy3e4QpeCJbIbrDGFpt3rmXy28=</Modulus><Exponent>AQAB</Exponent><P>98YU9Nkhu3qQ4Y168ZbMX+kCFUEPK9mRDEc2yZiyfABU9UlrKU4Ja1qy47WJrQNSALA9nnARZgbiY/3JkslISQ==</P><Q>20nBaoUN5QK9cuH6yX0QqAzhhB88rsI/HFzb8xrbEkceNfsTbYOVt+7biqzQQAvsyEILU+0l529eSe6S52yl9w==</Q><DP>wk3CLWkBfQZXC6ppmX9KcoRFr+k/PoH1r41BN8LZZUjVVy3mLZQW6utLkirQ9q695fBPwincWwhXDVb+dnAGkQ==</DP><DQ>Ks/0hhJiCxME37gE2W+kX9rb8IqUs13TKntqqcTVfnUKDent+hSVl2p3zFQ++DIb0WEriwAixVN16iM85RfOMw==</DQ><InverseQ>coc9FIy42//YO02qCCKfORevLIU8GIeTSYFqD9kMwhHSy1a6QMDpKaYWrYvv8FcMHglqWzdTqbSgBSrsfcnibw==</InverseQ><D>JvPie4/awFWLxOXgaMwCTceNpmukEIOl5SpZ7dhhbALJUveZ91BkF8SWZdss+VAkNJQHwY+YeWagPsvSbVRb1WylY11D8gBQEb6EOR3EsM17/5+v6nRrJ5+cySfpcahRbUjUdJFaVhMCUQ1wsnevLNY/Xo20UF4XCE5Exp7TW0E=</D></RSAKeyValue>");
                                passdecrypt = DecryptedMessage.AsString;
                            }
                        });



                    if (Strings.StrComp(passdecrypt, txtcontra.MonoFlatTB.Text, 0) == 0)
                    {
                        if (bloqueado)
                        {
                            bloqueado = false;
                            My.MyProject.Forms.Cargando.Close();
                            Close();
                        }
                        else
                        {
                            My.MyProject.Forms.Cargando.Show();
                            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando";
                            await Task.Factory.StartNew(() =>
                                {
                                    Module1.cargarperfil();

                                // frm_adm.Show()

                                try
                                    {
                                        MySqlConnection conexionLogin;
                                        conexionLogin = new MySqlConnection();
                                        conexionLogin.ConnectionString = "server=www.prestamosconfia.com;user id=SATISesiones;pwd=123456;port=3306;database=USRS";
                                        conexionLogin.Open();
                                        MySqlCommand comandoLogin;
                                        string consultaLogin;
                                        consultaLogin = "insert into Sesiones values(null,'" + Module1.nmusr + "','','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("HH:mm:ss") + "','1','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','SATI','',''); SELECT LAST_INSERT_ID();";
                                        comandoLogin = new MySqlCommand();
                                        comandoLogin.Connection = conexionLogin;
                                        comandoLogin.CommandText = consultaLogin;
                                        Module1.idSesion = Conversions.ToString(comandoLogin.ExecuteScalar());
                                        conexionLogin.Close();
                                    }

                                    catch (Exception ex)
                                    {
                                        File.AppendAllText(@"C:\ConfiaAdmin\SATI\Log.txt", string.Format("{0}{1}", Environment.NewLine, ex.ToString()));
                                    }
                                });
                            My.MyProject.Forms.Empresas.Show();
                            connexio.Close();
                            My.MyProject.Forms.Cargando.Close();



                            Close();
                        }
                    }


                    else
                    {
                        MessageBox.Show("Contraseña incorrecta");
                        txtcontra.Focus();
                        txtcontra.Select();




                    }
                }
            }


            catch (Exception exc)
            {
                Interaction.MsgBox(exc.Message, MsgBoxStyle.Exclamation);
            }

        }

        public async void passwordBloqueadoAsync()
        {
            Module1.iniciarconexion();

            try
            {
                string pass="", passdecrypt="" ;
                string s = "SELECT idusr FROM usr  where nm = '" + txtusr.Text + "'";

                var connexio = new OleDbConnection(Module1.cn);
                var myCommand = new OleDbCommand(s);

                myCommand.Connection = connexio;

                connexio.Open();
                var myReader = myCommand.ExecuteReader();

                while (myReader.Read())

                    Module1.idusr = Conversions.ToString(myReader["idusr"]);
                if (!Module1.nmusr.Equals(txtusr.Text, StringComparison.InvariantCultureIgnoreCase))
                {

                    MessageBox.Show("El sistema fue bloqueado por otro usuario");
                    txtusr.Focus();
                    txtusr.Select();
                }
                else
                {

                    string strcontra = "select pass from usr where idusr = '" + Module1.idusr + "'";
                    var ejec = new OleDbCommand(strcontra);
                    ejec.Connection = connexio;
                    My.MyProject.Forms.Cargando.Show();
                    My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando";
                    await Task.Factory.StartNew(() =>
                        {
                            var myreader2 = ejec.ExecuteReader();
                            while (myreader2.Read())
                            {
                                pass = Conversions.ToString(myreader2["pass"]);
                                var byteconverter = new UnicodeEncoding();
                                var CadByte = Convert.FromBase64String(pass);

                                var DecryptedMessage = Decrypt(CadByte, "<RSAKeyValue><Modulus>1D3WnN4qZq3DGHf7i3WjEixX0Nzka28RIR9lOrT7Eg2QmJTACm/E6388wMdGgH3yTwKPp/T5zm61yvZn44oHMka8EKlACGKkADsxN/ci0RLKJ0ZGYDVPtB+KSzI+GbmX2eO00R+FlYvXTpMzGXy3e4QpeCJbIbrDGFpt3rmXy28=</Modulus><Exponent>AQAB</Exponent><P>98YU9Nkhu3qQ4Y168ZbMX+kCFUEPK9mRDEc2yZiyfABU9UlrKU4Ja1qy47WJrQNSALA9nnARZgbiY/3JkslISQ==</P><Q>20nBaoUN5QK9cuH6yX0QqAzhhB88rsI/HFzb8xrbEkceNfsTbYOVt+7biqzQQAvsyEILU+0l529eSe6S52yl9w==</Q><DP>wk3CLWkBfQZXC6ppmX9KcoRFr+k/PoH1r41BN8LZZUjVVy3mLZQW6utLkirQ9q695fBPwincWwhXDVb+dnAGkQ==</DP><DQ>Ks/0hhJiCxME37gE2W+kX9rb8IqUs13TKntqqcTVfnUKDent+hSVl2p3zFQ++DIb0WEriwAixVN16iM85RfOMw==</DQ><InverseQ>coc9FIy42//YO02qCCKfORevLIU8GIeTSYFqD9kMwhHSy1a6QMDpKaYWrYvv8FcMHglqWzdTqbSgBSrsfcnibw==</InverseQ><D>JvPie4/awFWLxOXgaMwCTceNpmukEIOl5SpZ7dhhbALJUveZ91BkF8SWZdss+VAkNJQHwY+YeWagPsvSbVRb1WylY11D8gBQEb6EOR3EsM17/5+v6nRrJ5+cySfpcahRbUjUdJFaVhMCUQ1wsnevLNY/Xo20UF4XCE5Exp7TW0E=</D></RSAKeyValue>");
                                passdecrypt = DecryptedMessage.AsString;
                            }
                        });



                    if (Strings.StrComp(passdecrypt, txtcontra.Text, 0) == 0)
                    {

                        bloqueado = false;
                        My.MyProject.Forms.Cargando.Close();
                        Close();
                    }


                    else
                    {
                        MessageBox.Show("Contraseña incorrecta");
                        txtcontra.Focus();
                        txtcontra.Select();




                    }
                }
            }


            catch (Exception exc)
            {
                Interaction.MsgBox(exc.Message, MsgBoxStyle.Exclamation);
            }

        }


        private void login_Closing(object sender, CancelEventArgs e)
        {
            if (bloqueado)
            {
                e.Cancel = true;
            }
        }

        private void MonoFlat_Button2_Click(object sender, EventArgs e)
        {
            // Va a iniciar sesión como admin para hacer pruebas
            var options = new IniOptions() { EncryptionPassword = "EntUs01pos" };
            var iniFile = new IniFile(options);
            iniFile.Load(@"C:\ConfiaAdmin\SATI\SetConfig.ini");
            Module1.ipser = iniFile.Sections[0].Keys[0].Value;
            Module1.bdser = iniFile.Sections[0].Keys[1].Value;
            Module1.ImpresoraPredeterminada = iniFile.Sections[0].Keys["Impresora"].Value;
            try
            {
                Module1.ImpresoraTarjetas = iniFile.Sections[0].Keys["Tarjetas"].Value;
            }

            catch (ArgumentOutOfRangeException ex)
            {
                Module1.ImpresoraTarjetas = "";
            }
            // MessageBox.Show("No se encontró el valor leyenda configurado, se recomienda revisar la configuración")
            catch (NullReferenceException ex)
            {
                Module1.ImpresoraTarjetas = "";
                // MessageBox.Show("No se encontró el valor leyenda configurado, se recomienda revisar la configuración")
            }

            // noCaja = iniFile.Sections(0).Keys("Caja").Value
            // Impresora = iniFile.Sections(0).Keys("Impresora").Value
            Module1.iniciarconexion();
            try
            {
                string pass, passdecrypt;
                string s = "SELECT idusr FROM usr  where nm = 'Admin'";

                var connexio = new OleDbConnection(Module1.cn);
                var myCommand = new OleDbCommand(s);

                myCommand.Connection = connexio;

                connexio.Open();
                var myReader = myCommand.ExecuteReader();

                while (myReader.Read())

                    Module1.idusr = Conversions.ToString(myReader["idusr"]);


                string strcontra = "select pass from usr where idusr = '" + Module1.idusr + "'";
                var ejec = new OleDbCommand(strcontra);
                ejec.Connection = connexio;
                My.MyProject.Forms.Cargando.Show();
                My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando";
                // Await Task.Factory.StartNew(Sub()
                // Dim myreader2 As OleDbDataReader = ejec.ExecuteReader()
                // While myreader2.Read()
                // pass = myreader2("pass")
                // Dim byteconverter As New UnicodeEncoding()
                // Dim CadByte As Byte() = System.Convert.FromBase64String(pass)

                // Dim DecryptedMessage As Encryption.RSAResult = Encryption.RSA.Decrypt(CadByte, "<RSAKeyValue><Modulus>1D3WnN4qZq3DGHf7i3WjEixX0Nzka28RIR9lOrT7Eg2QmJTACm/E6388wMdGgH3yTwKPp/T5zm61yvZn44oHMka8EKlACGKkADsxN/ci0RLKJ0ZGYDVPtB+KSzI+GbmX2eO00R+FlYvXTpMzGXy3e4QpeCJbIbrDGFpt3rmXy28=</Modulus><Exponent>AQAB</Exponent><P>98YU9Nkhu3qQ4Y168ZbMX+kCFUEPK9mRDEc2yZiyfABU9UlrKU4Ja1qy47WJrQNSALA9nnARZgbiY/3JkslISQ==</P><Q>20nBaoUN5QK9cuH6yX0QqAzhhB88rsI/HFzb8xrbEkceNfsTbYOVt+7biqzQQAvsyEILU+0l529eSe6S52yl9w==</Q><DP>wk3CLWkBfQZXC6ppmX9KcoRFr+k/PoH1r41BN8LZZUjVVy3mLZQW6utLkirQ9q695fBPwincWwhXDVb+dnAGkQ==</DP><DQ>Ks/0hhJiCxME37gE2W+kX9rb8IqUs13TKntqqcTVfnUKDent+hSVl2p3zFQ++DIb0WEriwAixVN16iM85RfOMw==</DQ><InverseQ>coc9FIy42//YO02qCCKfORevLIU8GIeTSYFqD9kMwhHSy1a6QMDpKaYWrYvv8FcMHglqWzdTqbSgBSrsfcnibw==</InverseQ><D>JvPie4/awFWLxOXgaMwCTceNpmukEIOl5SpZ7dhhbALJUveZ91BkF8SWZdss+VAkNJQHwY+YeWagPsvSbVRb1WylY11D8gBQEb6EOR3EsM17/5+v6nRrJ5+cySfpcahRbUjUdJFaVhMCUQ1wsnevLNY/Xo20UF4XCE5Exp7TW0E=</D></RSAKeyValue>")
                // passdecrypt = DecryptedMessage.AsString
                // End While
                // End Sub)



                // If StrComp(passdecrypt, "123456", 0) = 0 Then

                // Cargando.Show()
                My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Contraseña Correcta...";

                Module1.cargarperfil();

                // frm_adm.Show()


                My.MyProject.Forms.Cargando.Close();
                My.MyProject.Forms.Empresas.Show();
                connexio.Close();

                Close();
            }




            // End If



            catch (Exception exc)
            {
                Interaction.MsgBox(exc.Message, MsgBoxStyle.Exclamation);
            }
        }

        private void txtcontra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}