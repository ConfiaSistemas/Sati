using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class AutorizacionNotificacion
    {

        private OleDbDataAdapter adapterUsuariosCautorizacion;
        private DataTable dataUsuariosCautorizacion;
        private bool autorizado;
        public string tipoAutorizacion;
        private bool passwordCorrect;

        public AutorizacionNotificacion()
        {
            InitializeComponent();
        }
        private void Autorizacion_Load(object sender, EventArgs e)
        {

        }

        private void MonoFlat_Button1_ClickAsync(object sender, EventArgs e)
        {
            FlowEspere.Visible = true;

            txtcontra.Enabled = false;
            MonoFlat_Button1.Enabled = false;
            MonoFlat_Button2.Enabled = false;
            BackgroundWorker1.RunWorkerAsync();


        }



        private void MonoFlat_Button2_Click(object sender, EventArgs e)
        {
            switch (tipoAutorizacion ?? "")
            {
                case "SatiAcceso":
                    {
                        break;
                    }
                case "SatiModUsuarios":
                    {
                        break;
                    }
                case "SatiModUsuariosVer":
                    {
                        break;
                    }
                case "SatiModUsuariosModificar":
                    {
                        My.MyProject.Forms.Editar_Usuario.autorizado = false;
                        Close();
                        break;
                    }
                case "SatiModUsuariosAgregar":
                    {
                        My.MyProject.Forms.Agregar_Usuario.autorizado = false;
                        Close();
                        break;
                    }

                case "SatiModGrupos":
                    {
                        break;
                    }
                case "SatiModGruposVer":
                    {
                        break;
                    }
                case "SatiModGruposModificar":
                    {
                        My.MyProject.Forms.PermisosGrupo.Autorizado = false;
                        Close();
                        break;
                    }
                case "SatiModGruposAgregar":
                    {
                        My.MyProject.Forms.agregargrupos.autorizado = false;
                        Close();
                        break;
                    }
                case "SatiModCatalogos":
                    {
                        break;
                    }
                case "SatiModClientes":
                    {
                        break;
                    }
                case "SatiModClientesVer":
                    {
                        break;
                    }
                case "SatiModClientesModificar":
                    {
                        break;
                    }
                case "SatiModClientesAgregar":
                    {
                        My.MyProject.Forms.Agregar_Impuestos.autorizado = false;
                        Close();
                        break;
                    }
                case "SatiModDocumentos":
                    {
                        break;
                    }
                case "SatiModDocumentosVer":
                    {
                        break;
                    }
                case "SatiModDocumentosModificar":
                    {
                        break;
                    }
                case "SatiModDocumentosAgregar":
                    {
                        break;
                    }
                case "SatiModTipoDocumentos":
                    {
                        break;
                    }
                case "SatiModTipoDocumentosVer":
                    {
                        break;
                    }
                case "SatiModTipoDocumentosModificar":
                    {
                        break;
                    }
                case "SatiModTipoDocumentosAgregar":
                    {
                        My.MyProject.Forms.AgregarTipoDocumentoSolicitud.autorizado = false;
                        Close();
                        break;
                    }
                case "SatiModSolicitudes":
                    {
                        break;
                    }
                case "SatiModSolicitudesVer":
                    {
                        break;
                    }
                case "SatiModSolicitudesModificar":
                    {
                        break;
                    }
                case "SatiModSolicitudesAgregar":
                    {
                        My.MyProject.Forms.Levantar_Solicitud.autorizado = false;
                        Close();
                        break;
                    }
                case "SatiModSolicitudesVerificar":
                    {
                        My.MyProject.Forms.DatosVerificacion.autorizado = false;
                        Close();
                        break;
                    }
                case "SatiModSolicitudesAprobar":
                    {
                        My.MyProject.Forms.DatosAprobacion.autorizado = false;
                        Close();
                        break;
                    }

                case "SatiModSolicitudesCancelar":
                    {
                        break;
                    }
                case "SatiModSolicitudesAgregarRechazados":
                    {

                        My.MyProject.Forms.DatosAprobacion.autorizado = false;
                        Close();
                        break;
                    }
                case "SatiModSolicitudesAgregarLegales":
                    {
                        My.MyProject.Forms.Levantar_Solicitud.autorizado = false;
                        Close();
                        break;
                    }
                case "SatiModCreditos":
                    {
                        break;
                    }
                case "SatiModCreditosVer":
                    {
                        break;
                    }
                case "SatiModCreditosCrearConvenio":
                    {
                        My.MyProject.Forms.CalendarioConvenio.Autorizado = false;
                        Close();
                        break;
                    }
                case "SatiModCreditosCrearReestructura":
                    {
                        My.MyProject.Forms.CalendarioReestructura.Autorizado = false;
                        Close();
                        break;
                    }
                case "SatiModCreditosCrearPromesa":
                    {
                        My.MyProject.Forms.PromesaPago.Autorizado = false;
                        Close();
                        break;
                    }
                case "SatiModReportes":
                    {
                        break;
                    }
                case "SatiModTiposCreditos":
                    {
                        break;
                    }
                case "SatiModTiposCreditosVer":
                    {
                        break;
                    }
                case "SatiModTiposCreditosModificar":
                    {
                        break;
                    }
                case "SatiModTiposCreditosAgregar":
                    {
                        My.MyProject.Forms.AgregarTipoCredito.autorizado = false;
                        Close();
                        break;
                    }
                case "SatiModEmpleados":
                    {
                        break;
                    }
                case "SatiModEmpleadosVer":
                    {
                        break;
                    }
                case "SatiModEmpleadosModificar":
                    {
                        break;
                    }
                case "SatiModEmpleadosAgregar":
                    {
                        break;
                    }
                case "SatiModCajas":
                    {
                        break;
                    }
                case "SatiModCajasVer":
                    {
                        break;
                    }
                case "SatiModCajasModificar":
                    {
                        break;
                    }
                case "SatiModCajasAgregar":
                    {
                        My.MyProject.Forms.AgregarCaja.autorizado = false;
                        Close();
                        break;
                    }
                case "SacCancelarTicket":
                    {
                        My.MyProject.Forms.CancelarTicket.Autorizado = false;
                        Close();
                        break;
                    }
                case "SatiModEmpeñosAgregarSolicitud":
                    {
                        My.MyProject.Forms.Solicitud_Boleta.autorizado = false;
                        Close();
                        break;
                    }
                case "SatiModCreditosDescuentoPromesa":
                    {
                        My.MyProject.Forms.AplicarDescuentoPromesa.Autorizado = false;
                        Close();
                        break;
                    }
                case "SatiModLegalAplicaDeposito":
                    {
                        My.MyProject.Forms.AplicarDepositoLegal.Autorizado = false;
                        Close();
                        break;
                    }
                case "SatiModCreditosModificar":
                    {
                        My.MyProject.Forms.AplicarActualizacionCliente.Autorizado = false;
                        Close();
                        break;
                    }

            }
        }

        private void Autorizacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (tipoAutorizacion ?? "")
            {
                case "SatiAcceso":
                    {
                        break;
                    }
                case "SatiModUsuarios":
                    {
                        break;
                    }
                case "SatiModUsuariosVer":
                    {
                        break;
                    }
                case "SatiModUsuariosModificar":
                    {
                        if (autorizado)
                        {
                            My.MyProject.Forms.Editar_Usuario.autorizado = true;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }
                        else
                        {
                            My.MyProject.Forms.Editar_Usuario.autorizado = false;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }

                        break;
                    }


                case "SatiModUsuariosAgregar":
                    {
                        if (autorizado)
                        {
                            My.MyProject.Forms.Agregar_Usuario.autorizado = true;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }
                        else
                        {
                            My.MyProject.Forms.Agregar_Usuario.autorizado = false;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }

                        break;
                    }

                case "SatiModGrupos":
                    {
                        break;
                    }
                case "SatiModGruposVer":
                    {
                        break;
                    }
                case "SatiModGruposModificar":
                    {
                        if (autorizado)
                        {
                            My.MyProject.Forms.PermisosGrupo.Autorizado = true;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }
                        else
                        {
                            My.MyProject.Forms.PermisosGrupo.Autorizado = false;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }

                        break;
                    }
                case "SatiModGruposAgregar":
                    {
                        if (autorizado)
                        {
                            My.MyProject.Forms.agregargrupos.autorizado = true;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }
                        else
                        {
                            My.MyProject.Forms.agregargrupos.autorizado = false;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }

                        break;
                    }
                case "SatiModCatalogos":
                    {
                        break;
                    }
                case "SatiModClientes":
                    {
                        break;
                    }
                case "SatiModClientesVer":
                    {
                        break;
                    }
                case "SatiModClientesModificar":
                    {
                        break;
                    }
                case "SatiModClientesAgregar":
                    {
                        if (autorizado)
                        {
                            My.MyProject.Forms.Agregar_Impuestos.autorizado = true;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }
                        else
                        {
                            My.MyProject.Forms.Agregar_Impuestos.autorizado = false;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }

                        break;
                    }
                case "SatiModDocumentos":
                    {
                        break;
                    }
                case "SatiModDocumentosVer":
                    {
                        break;
                    }
                case "SatiModDocumentosModificar":
                    {
                        break;
                    }
                case "SatiModDocumentosAgregar":
                    {
                        break;
                    }
                case "SatiModTipoDocumentos":
                    {
                        break;
                    }
                case "SatiModTipoDocumentosVer":
                    {
                        break;
                    }
                case "SatiModTipoDocumentosModificar":
                    {
                        break;
                    }
                case "SatiModTipoDocumentosAgregar":
                    {
                        if (autorizado)
                        {
                            My.MyProject.Forms.AgregarTipoDocumentoSolicitud.autorizado = true;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }
                        else
                        {
                            My.MyProject.Forms.AgregarTipoDocumentoSolicitud.autorizado = false;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }

                        break;
                    }
                case "SatiModSolicitudes":
                    {
                        break;
                    }
                case "SatiModSolicitudesVer":
                    {
                        break;
                    }
                case "SatiModSolicitudesModificar":
                    {
                        break;
                    }
                case "SatiModSolicitudesAgregar":
                    {
                        if (autorizado)
                        {
                            My.MyProject.Forms.Levantar_Solicitud.autorizado = true;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }
                        else
                        {
                            My.MyProject.Forms.Levantar_Solicitud.autorizado = false;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }

                        break;
                    }
                case "SatiModSolicitudesVerificar":
                    {
                        if (autorizado)
                        {
                            My.MyProject.Forms.DatosVerificacion.autorizado = true;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }
                        else
                        {
                            My.MyProject.Forms.DatosVerificacion.autorizado = false;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }

                        break;
                    }
                case "SatiModSolicitudesAprobar":
                    {
                        if (autorizado)
                        {
                            My.MyProject.Forms.DatosAprobacion.autorizado = true;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }
                        else
                        {
                            My.MyProject.Forms.DatosAprobacion.autorizado = false;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }

                        break;
                    }
                case "SatiModSolicitudesCancelar":
                    {
                        break;
                    }
                case "SatiModSolicitudesAgregarRechazados":
                    {
                        if (autorizado)
                        {
                            My.MyProject.Forms.Levantar_Solicitud.autorizado = true;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }
                        else
                        {
                            My.MyProject.Forms.Levantar_Solicitud.autorizado = false;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }

                        break;
                    }
                case "SatiModSolicitudesAgregarLegales":
                    {
                        if (autorizado)
                        {
                            My.MyProject.Forms.Levantar_Solicitud.autorizado = true;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }
                        else
                        {
                            My.MyProject.Forms.Levantar_Solicitud.autorizado = false;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }

                        break;
                    }
                case "SatiModCreditos":
                    {
                        break;
                    }
                case "SatiModCreditosVer":
                    {
                        break;
                    }
                case "SatiModCreditosCrearConvenio":
                    {
                        if (autorizado)
                        {
                            My.MyProject.Forms.CalendarioConvenio.Autorizado = true;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }
                        else
                        {
                            My.MyProject.Forms.CalendarioConvenio.Autorizado = false;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }

                        break;
                    }
                case "SatiModCreditosCrearReestructura":
                    {
                        if (autorizado)
                        {
                            My.MyProject.Forms.CalendarioReestructura.Autorizado = true;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }
                        else
                        {
                            My.MyProject.Forms.CalendarioReestructura.Autorizado = false;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }

                        break;
                    }
                case "SatiModCreditosCrearPromesa":
                    {
                        if (autorizado)
                        {
                            My.MyProject.Forms.PromesaPago.Autorizado = true;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }
                        else
                        {
                            My.MyProject.Forms.PromesaPago.Autorizado = false;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }

                        break;
                    }
                case "SatiModReportes":
                    {
                        break;
                    }
                case "SatiModTiposCreditos":
                    {
                        break;
                    }
                case "SatiModTiposCreditosVer":
                    {
                        break;
                    }
                case "SatiModTiposCreditosModificar":
                    {
                        break;
                    }
                case "SatiModTiposCreditosAgregar":
                    {
                        if (autorizado)
                        {
                            My.MyProject.Forms.AgregarTipoCredito.autorizado = true;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }
                        else
                        {
                            My.MyProject.Forms.AgregarTipoCredito.autorizado = false;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }

                        break;
                    }
                case "SatiModEmpleados":
                    {
                        break;
                    }
                case "SatiModEmpleadosVer":
                    {
                        break;
                    }
                case "SatiModEmpleadosModificar":
                    {
                        break;
                    }
                case "SatiModEmpleadosAgregar":
                    {
                        break;
                    }
                case "SatiModCajas":
                    {
                        break;
                    }
                case "SatiModCajasVer":
                    {
                        break;
                    }
                case "SatiModCajasModificar":
                    {
                        break;
                    }
                case "SatiModCajasAgregar":
                    {
                        if (autorizado)
                        {
                            My.MyProject.Forms.AgregarCaja.autorizado = true;

                            txtcontra.MonoFlatTB.Text = "";
                        }
                        else
                        {
                            My.MyProject.Forms.AgregarCaja.autorizado = false;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }

                        break;
                    }
                case "SacCancelarTicket":
                    {
                        if (autorizado)
                        {
                            My.MyProject.Forms.CancelarTicket.Autorizado = true;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }
                        else
                        {
                            My.MyProject.Forms.CancelarTicket.Autorizado = false;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }

                        break;
                    }
                case "SatiModEmpeñosAgregarSolicitud":
                    {
                        if (autorizado)
                        {
                            My.MyProject.Forms.Solicitud_Boleta.autorizado = true;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }
                        else
                        {
                            My.MyProject.Forms.Solicitud_Boleta.autorizado = false;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }

                        break;
                    }
                case "SatiModCreditosDescuentoPromesa":
                    {
                        if (autorizado)
                        {
                            My.MyProject.Forms.AplicarDescuentoPromesa.Autorizado = true;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }
                        else
                        {
                            My.MyProject.Forms.AplicarDescuentoPromesa.Autorizado = false;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }

                        break;
                    }
                case "SatiModLegalAplicaDeposito":
                    {
                        if (autorizado)
                        {
                            My.MyProject.Forms.AplicarDepositoLegal.Autorizado = true;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }
                        else
                        {
                            My.MyProject.Forms.AplicarDepositoLegal.Autorizado = false;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }

                        break;
                    }
                case "SatiModCreditosModificar":
                    {
                        if (autorizado)
                        {
                            My.MyProject.Forms.AplicarActualizacionCliente.Autorizado = true;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }
                        else
                        {
                            My.MyProject.Forms.AplicarActualizacionCliente.Autorizado = false;
                            autorizado = false;

                            txtcontra.MonoFlatTB.Text = "";
                        }

                        break;
                    }

            }
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
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
                if (row["nm"].ToString().Equals(Module1.nmusr, StringComparison.InvariantCultureIgnoreCase))
                {

                    try
                    {

                        string pass, passdecrypt="" ;
                        string s = "SELECT idusr FROM usr  where nm = '" + Module1.nmusr + "'";

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

                    // MsgBox("El usuario no tiene autorización", MsgBoxStyle.Exclamation, "SATI")
                    // Exit For

                }
                // Exit For
            }


        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FlowEspere.Visible = false;

            txtcontra.Enabled = true;
            MonoFlat_Button1.Enabled = true;
            MonoFlat_Button2.Enabled = true;
            if (autorizado)
            {
                switch (tipoAutorizacion ?? "")
                {
                    case "SatiAcceso":
                        {
                            break;
                        }
                    case "SatiModUsuarios":
                        {
                            break;
                        }
                    case "SatiModUsuariosVer":
                        {
                            break;
                        }
                    case "SatiModUsuariosModificar":
                        {
                            My.MyProject.Forms.Editar_Usuario.autorizado = true;
                            Close();
                            break;
                        }
                    case "SatiModUsuariosAgregar":
                        {
                            My.MyProject.Forms.Agregar_Usuario.autorizado = true;
                            Close();
                            break;
                        }

                    case "SatiModGrupos":
                        {
                            break;
                        }
                    case "SatiModGruposVer":
                        {
                            break;
                        }
                    case "SatiModGruposModificar":
                        {
                            My.MyProject.Forms.PermisosGrupo.Autorizado = true;
                            Close();
                            break;
                        }
                    case "SatiModGruposAgregar":
                        {
                            My.MyProject.Forms.agregargrupos.autorizado = true;
                            Close();
                            break;
                        }
                    case "SatiModCatalogos":
                        {
                            break;
                        }
                    case "SatiModClientes":
                        {
                            break;
                        }
                    case "SatiModClientesVer":
                        {
                            break;
                        }
                    case "SatiModClientesModificar":
                        {
                            break;
                        }
                    case "SatiModClientesAgregar":
                        {
                            My.MyProject.Forms.Agregar_Impuestos.autorizado = true;
                            Close();
                            break;
                        }
                    case "SatiModDocumentos":
                        {
                            break;
                        }
                    case "SatiModDocumentosVer":
                        {
                            break;
                        }
                    case "SatiModDocumentosModificar":
                        {
                            break;
                        }
                    case "SatiModDocumentosAgregar":
                        {
                            break;
                        }
                    case "SatiModTipoDocumentos":
                        {
                            break;
                        }
                    case "SatiModTipoDocumentosVer":
                        {
                            break;
                        }
                    case "SatiModTipoDocumentosModificar":
                        {
                            break;
                        }
                    case "SatiModTipoDocumentosAgregar":
                        {
                            My.MyProject.Forms.AgregarTipoDocumentoSolicitud.autorizado = true;
                            Close();
                            break;
                        }
                    case "SatiModSolicitudes":
                        {
                            break;
                        }
                    case "SatiModSolicitudesVer":
                        {
                            break;
                        }
                    case "SatiModSolicitudesModificar":
                        {
                            break;
                        }
                    case "SatiModSolicitudesAgregar":
                        {
                            My.MyProject.Forms.Levantar_Solicitud.autorizado = true;
                            Close();
                            break;
                        }
                    case "SatiModSolicitudesVerificar":
                        {
                            My.MyProject.Forms.DatosVerificacion.autorizado = true;
                            Close();
                            break;
                        }
                    case "SatiModSolicitudesAprobar":
                        {
                            My.MyProject.Forms.DatosAprobacion.autorizado = true;
                            Close();
                            break;
                        }
                    case "SatiModSolicitudesCancelar":
                        {
                            break;
                        }
                    case "SatiModSolicitudesAgregarRechazados":
                        {
                            My.MyProject.Forms.Levantar_Solicitud.autorizado = true;
                            Close();
                            break;
                        }
                    case "SatiModSolicitudesAgregarLegales":
                        {
                            My.MyProject.Forms.Levantar_Solicitud.autorizado = true;
                            Close();
                            break;
                        }
                    case "SatiModCreditos":
                        {
                            break;
                        }
                    case "SatiModCreditosVer":
                        {
                            break;
                        }
                    case "SatiModCreditosCrearConvenio":
                        {
                            My.MyProject.Forms.CalendarioConvenio.Autorizado = true;
                            Close();
                            break;
                        }
                    case "SatiModCreditosCrearReestructura":
                        {
                            My.MyProject.Forms.CalendarioReestructura.Autorizado = true;
                            Close();
                            break;
                        }
                    case "SatiModCreditosCrearPromesa":
                        {
                            My.MyProject.Forms.PromesaPago.Autorizado = true;
                            Close();
                            break;
                        }
                    case "SatiModReportes":
                        {
                            break;
                        }

                    case "SatiModTiposCreditos":
                        {
                            break;
                        }
                    case "SatiModTiposCreditosVer":
                        {
                            break;
                        }
                    case "SatiModTiposCreditosModificar":
                        {
                            break;
                        }
                    case "SatiModTiposCreditosAgregar":
                        {
                            My.MyProject.Forms.AgregarTipoCredito.autorizado = true;
                            Close();
                            break;
                        }
                    case "SatiModEmpleados":
                        {
                            break;
                        }
                    case "SatiModEmpleadosVer":
                        {
                            break;
                        }
                    case "SatiModEmpleadosModificar":
                        {
                            break;
                        }
                    case "SatiModEmpleadosAgregar":
                        {
                            break;
                        }
                    case "SatiModCajas":
                        {
                            break;
                        }
                    case "SatiModCajasVer":
                        {
                            break;
                        }
                    case "SatiModCajasModificar":
                        {
                            break;
                        }
                    case "SatiModCajasAgregar":
                        {
                            My.MyProject.Forms.AgregarCaja.autorizado = true;
                            Close();
                            break;
                        }
                    case "SacCancelarTicket":
                        {
                            My.MyProject.Forms.CancelarTicket.Autorizado = true;
                            Close();
                            break;
                        }
                    case "SatiModEmpeñosAgregarSolicitud":
                        {
                            My.MyProject.Forms.Solicitud_Boleta.autorizado = true;
                            Close();
                            break;
                        }
                    case "SatiModCreditosDescuentoPromesa":
                        {
                            My.MyProject.Forms.AplicarDescuentoPromesa.Autorizado = true;
                            Close();
                            break;
                        }
                    case "SatiModLegalAplicaDeposito":
                        {
                            My.MyProject.Forms.AplicarDepositoLegal.Autorizado = true;
                            Close();
                            break;
                        }
                    case "SatiModCreditosModificar":
                        {
                            My.MyProject.Forms.AplicarActualizacionCliente.Autorizado = true;
                            Close();
                            break;
                        }
                }
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

        private void txtcontra_TextChanged(object sender, EventArgs e)
        {

        }


    }
}