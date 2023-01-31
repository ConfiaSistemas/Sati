using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class AutorizacionRetiro
    {

        private OleDbDataAdapter adapterUsuariosCautorizacion;
        private DataTable dataUsuariosCautorizacion;
        private bool autorizado;
        public string tipoAutorizacion;
        private bool passwordCorrect;

        public AutorizacionRetiro()
        {
            InitializeComponent();
        }
        private void Autorizacion_Load(object sender, EventArgs e)
        {

        }

        private void MonoFlat_Button1_ClickAsync(object sender, EventArgs e)
        {
            FlowEspere.Visible = true;
            txtusr.Enabled = false;
            txtcontra.Enabled = false;
            MonoFlat_Button1.Enabled = false;
            MonoFlat_Button2.Enabled = false;
            BackgroundWorker1.RunWorkerAsync();


        }

        private async Task<bool> AutorizarAsync()
        {
            Module1.iniciarconexion();
            string consultaUsuariosCautorizacion;
            var connexion = new OleDbConnection(Module1.cn);
            consultaUsuariosCautorizacion = "select Usr.Idusr,Usr.nm from Usr inner join grp on Usr.grp = grp.id inner join PermisosGrupo on PermisosGrupo.idGrupo = grp.id where PermisosGrupo." + tipoAutorizacion + " = 1";
            adapterUsuariosCautorizacion = new OleDbDataAdapter(consultaUsuariosCautorizacion, connexion);
            dataUsuariosCautorizacion = new DataTable();
            adapterUsuariosCautorizacion.Fill(dataUsuariosCautorizacion);
            foreach (DataRow row in dataUsuariosCautorizacion.Rows)
            {
                if ((row["nm"].ToString() ?? "") == (txtusr.MonoFlatTB.Text ?? ""))
                {
                    try
                    {

                        string pass="", passdecrypt ="" ;
                        string s = "SELECT idusr FROM usr  where nm = '" + txtusr.MonoFlatTB.Text + "'";

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
                        await Task.Factory.StartNew(() =>
                            {
                                var myreader2 = ejec.ExecuteReader();
                                while (myreader2.Read())
                                {
                                    pass = Conversions.ToString(myreader2["pass"]);
                                    var byteconverter = new UnicodeEncoding();
                                    var CadByte = Convert.FromBase64String(pass);

                                    var DecryptedMessage = Encryption.RSA.Decrypt(CadByte, "<RSAKeyValue><Modulus>1D3WnN4qZq3DGHf7i3WjEixX0Nzka28RIR9lOrT7Eg2QmJTACm/E6388wMdGgH3yTwKPp/T5zm61yvZn44oHMka8EKlACGKkADsxN/ci0RLKJ0ZGYDVPtB+KSzI+GbmX2eO00R+FlYvXTpMzGXy3e4QpeCJbIbrDGFpt3rmXy28=</Modulus><Exponent>AQAB</Exponent><P>98YU9Nkhu3qQ4Y168ZbMX+kCFUEPK9mRDEc2yZiyfABU9UlrKU4Ja1qy47WJrQNSALA9nnARZgbiY/3JkslISQ==</P><Q>20nBaoUN5QK9cuH6yX0QqAzhhB88rsI/HFzb8xrbEkceNfsTbYOVt+7biqzQQAvsyEILU+0l529eSe6S52yl9w==</Q><DP>wk3CLWkBfQZXC6ppmX9KcoRFr+k/PoH1r41BN8LZZUjVVy3mLZQW6utLkirQ9q695fBPwincWwhXDVb+dnAGkQ==</DP><DQ>Ks/0hhJiCxME37gE2W+kX9rb8IqUs13TKntqqcTVfnUKDent+hSVl2p3zFQ++DIb0WEriwAixVN16iM85RfOMw==</DQ><InverseQ>coc9FIy42//YO02qCCKfORevLIU8GIeTSYFqD9kMwhHSy1a6QMDpKaYWrYvv8FcMHglqWzdTqbSgBSrsfcnibw==</InverseQ><D>JvPie4/awFWLxOXgaMwCTceNpmukEIOl5SpZ7dhhbALJUveZ91BkF8SWZdss+VAkNJQHwY+YeWagPsvSbVRb1WylY11D8gBQEb6EOR3EsM17/5+v6nRrJ5+cySfpcahRbUjUdJFaVhMCUQ1wsnevLNY/Xo20UF4XCE5Exp7TW0E=</D></RSAKeyValue>");
                                    passdecrypt = DecryptedMessage.AsString;
                                }
                            });



                        if (Strings.StrComp(passdecrypt, txtcontra.MonoFlatTB.Text, 0) == 0)
                        {


                            My.MyProject.Forms.Cargando.Close();
                            return true;
                        }
                        // Me.Close()


                        else
                        {
                            MessageBox.Show("Contraseña incorrecta");
                            txtcontra.Focus();
                            txtcontra.Select();
                            My.MyProject.Forms.Cargando.Close();
                            passwordCorrect = true;
                            return false;

                        }
                    }



                    catch (Exception exc)
                    {
                        return false;
                        Interaction.MsgBox(exc.Message, MsgBoxStyle.Exclamation);
                    }
                    break;
                }

                else
                {
                    return false;
                    Interaction.MsgBox("El usuario no tiene autorización", MsgBoxStyle.Exclamation);
                }
                // Exit For
            }

            return default(bool);

        }

        private void MonoFlat_Button2_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.RecibirRetiro.autorizado = false;
            Close();


        }

        private void Autorizacion_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (autorizado)
            {
                My.MyProject.Forms.RecibirRetiro.autorizado = true;
                autorizado = false;
                txtusr.MonoFlatTB.Text = "";
                txtcontra.MonoFlatTB.Text = "";
            }
            else
            {
                My.MyProject.Forms.RecibirRetiro.autorizado = false;
                autorizado = false;
                txtusr.MonoFlatTB.Text = "";
                txtcontra.MonoFlatTB.Text = "";
            }


        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexion();
            string consultaUsuariosCautorizacion;
            var connexion = new OleDbConnection(Module1.cn);
            consultaUsuariosCautorizacion = "select Usr.Idusr,Usr.nm from Usr inner join grp on Usr.grp = grp.id inner join PermisosGrupo on PermisosGrupo.idGrupo = grp.id where PermisosGrupo.SatiModRetirosRecibir  = 1";
            adapterUsuariosCautorizacion = new OleDbDataAdapter(consultaUsuariosCautorizacion, connexion);
            dataUsuariosCautorizacion = new DataTable();
            adapterUsuariosCautorizacion.Fill(dataUsuariosCautorizacion);
            foreach (DataRow row in dataUsuariosCautorizacion.Rows)
            {
                if (row["nm"].ToString().Equals(txtusr.MonoFlatTB.Text, StringComparison.InvariantCultureIgnoreCase))
                {

                    try
                    {

                        string pass="", passdecrypt="";
                        string s = "SELECT idusr FROM usr  where nm = '" + txtusr.MonoFlatTB.Text + "'";

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


                        var myreader2 = ejec.ExecuteReader();
                        while (myreader2.Read())
                        {
                            pass = Conversions.ToString(myreader2["pass"]);
                            var byteconverter = new UnicodeEncoding();
                            var CadByte = Convert.FromBase64String(pass);

                            var DecryptedMessage = Encryption.RSA.Decrypt(CadByte, "<RSAKeyValue><Modulus>1D3WnN4qZq3DGHf7i3WjEixX0Nzka28RIR9lOrT7Eg2QmJTACm/E6388wMdGgH3yTwKPp/T5zm61yvZn44oHMka8EKlACGKkADsxN/ci0RLKJ0ZGYDVPtB+KSzI+GbmX2eO00R+FlYvXTpMzGXy3e4QpeCJbIbrDGFpt3rmXy28=</Modulus><Exponent>AQAB</Exponent><P>98YU9Nkhu3qQ4Y168ZbMX+kCFUEPK9mRDEc2yZiyfABU9UlrKU4Ja1qy47WJrQNSALA9nnARZgbiY/3JkslISQ==</P><Q>20nBaoUN5QK9cuH6yX0QqAzhhB88rsI/HFzb8xrbEkceNfsTbYOVt+7biqzQQAvsyEILU+0l529eSe6S52yl9w==</Q><DP>wk3CLWkBfQZXC6ppmX9KcoRFr+k/PoH1r41BN8LZZUjVVy3mLZQW6utLkirQ9q695fBPwincWwhXDVb+dnAGkQ==</DP><DQ>Ks/0hhJiCxME37gE2W+kX9rb8IqUs13TKntqqcTVfnUKDent+hSVl2p3zFQ++DIb0WEriwAixVN16iM85RfOMw==</DQ><InverseQ>coc9FIy42//YO02qCCKfORevLIU8GIeTSYFqD9kMwhHSy1a6QMDpKaYWrYvv8FcMHglqWzdTqbSgBSrsfcnibw==</InverseQ><D>JvPie4/awFWLxOXgaMwCTceNpmukEIOl5SpZ7dhhbALJUveZ91BkF8SWZdss+VAkNJQHwY+YeWagPsvSbVRb1WylY11D8gBQEb6EOR3EsM17/5+v6nRrJ5+cySfpcahRbUjUdJFaVhMCUQ1wsnevLNY/Xo20UF4XCE5Exp7TW0E=</D></RSAKeyValue>");
                            passdecrypt = DecryptedMessage.AsString;
                        }




                        if (Strings.StrComp(passdecrypt, txtcontra.MonoFlatTB.Text, 0) == 0)
                        {



                            autorizado = true;
                        }
                        // Me.Close()


                        else
                        {
                            MessageBox.Show("Contraseña incorrecta");
                            txtcontra.Focus();
                            txtcontra.Select();
                            FlowEspere.Visible = false;
                            passwordCorrect = true;
                            autorizado = false;

                        }
                    }



                    catch (Exception exc)
                    {
                        autorizado = false;
                        Interaction.MsgBox(exc.Message, MsgBoxStyle.Exclamation, "SATI");

                    }
                    break;
                }

                else
                {

                    autorizado = false;

                    Interaction.MsgBox("El usuario no tiene autorización", MsgBoxStyle.Exclamation, "SATI");
                    // Exit For

                }
                // Exit For
            }


        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FlowEspere.Visible = false;
            txtusr.Enabled = true;
            txtcontra.Enabled = true;
            MonoFlat_Button1.Enabled = true;
            MonoFlat_Button2.Enabled = true;
            if (autorizado)
            {
                My.MyProject.Forms.RecibirRetiro.autorizado = true;
                Close();
            }
            else if (passwordCorrect)
            {
                passwordCorrect = false;
            }

            else
            {
                passwordCorrect = false;
                Interaction.MsgBox("El usuario no tiene autorización", MsgBoxStyle.Exclamation, "SATI");

            }
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