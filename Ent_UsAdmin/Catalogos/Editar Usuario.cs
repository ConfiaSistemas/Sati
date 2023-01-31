using System;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class Editar_Usuario
    {
        private bool actualizar = false;

        public string nombre, usuario, contraseña, idusuario, pass, passdecrypt;
        public string grupo;
        public bool activo;
        public DateTime fecha_alta;
        private int cantidadgrupos;
        private string[] nombregrupo = new string[1001];
        private string[] codigogrupo = new string[1001];
        private string[] idgrupo = new string[1001];
        private bool mostrarcontraseña = false;
        public bool autorizado;

        public Editar_Usuario()
        {
            InitializeComponent();
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Module_resize.MoveForm(this);
            }
        }






        private void Editar_Usuario_Load(object sender, EventArgs e)
        {
            timerformato.Enabled = true;
            cargargrupos();
            cargarusuario();

        }

        public void cargargrupos()
        {
            try
            {
                string strgrupos;
                strgrupos = "select id,nm,cdg from grp";
                var ejec = new OleDbCommand(strgrupos);
                ejec.Connection = Module1.conexionempresaR;
                Label labelgrupo;

                int numero = 0;

                var myreadergrupos = ejec.ExecuteReader();
                while (myreadergrupos.Read())
                {
                    labelgrupo = new Label();

                    idgrupo[numero] = Conversions.ToString(myreadergrupos["id"]);
                    codigogrupo[numero] = Conversions.ToString(myreadergrupos["cdg"]);

                    nombregrupo[numero] = Conversions.ToString(myreadergrupos["nm"]);
                    labelgrupo.Name = idgrupo[numero];
                    labelgrupo.AutoSize = true;
                    labelgrupo.Text = idgrupo[numero] + "-" + codigogrupo[numero] + "-" + nombregrupo[numero];
                    labelgrupo.ForeColor = Color.White;
                    labelgrupo.Click += clickevent;
                    FlowLayoutPanel1.Controls.Add(labelgrupo);
                    numero += 1;
                    cantidadgrupos = numero;
                }
                myreadergrupos.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel1.Location = new Point(lblgrupo.Location.X, lblgrupo.Location.Y - lblgrupo.Height - FlowLayoutPanel1.Height);
            if (FlowLayoutPanel1.Visible == false)
            {
                FlowLayoutPanel1.Visible = true;
                FlowLayoutPanel1.BringToFront();
            }
            else
            {
                FlowLayoutPanel1.Visible = false;
            }


        }

        public void cargarusuario()
        {
            try
            {
                string strusuario;
                strusuario = "select nm,nm_complete,pass,grp,fecha_alta,activo from usr where idusr= '" + idusuario + "'";
                var ejec = new OleDbCommand(strusuario);
                ejec.Connection = Module1.conexionempresaR;
                var myreaderusuario = ejec.ExecuteReader();
                while (myreaderusuario.Read())
                {
                    usuario = Conversions.ToString(myreaderusuario["nm"]);
                    nombre = Conversions.ToString(myreaderusuario["nm_complete"]);
                    pass = Conversions.ToString(myreaderusuario["pass"]);
                    grupo = Conversions.ToString(myreaderusuario["grp"]);
                    if (!(myreaderusuario["fecha_alta"] is DBNull))
                    {
                        fecha_alta = Conversions.ToDate(myreaderusuario["fecha_alta"]);

                    }
                    if (!(myreaderusuario["activo"] is DBNull))
                    {
                        activo = Conversions.ToBoolean(myreaderusuario["activo"]);
                    }


                }

                var byteconverter = new UnicodeEncoding();
                var CadByte = Convert.FromBase64String(pass);

                var DecryptedMessage = Encryption.RSA.Decrypt(CadByte, "<RSAKeyValue><Modulus>1D3WnN4qZq3DGHf7i3WjEixX0Nzka28RIR9lOrT7Eg2QmJTACm/E6388wMdGgH3yTwKPp/T5zm61yvZn44oHMka8EKlACGKkADsxN/ci0RLKJ0ZGYDVPtB+KSzI+GbmX2eO00R+FlYvXTpMzGXy3e4QpeCJbIbrDGFpt3rmXy28=</Modulus><Exponent>AQAB</Exponent><P>98YU9Nkhu3qQ4Y168ZbMX+kCFUEPK9mRDEc2yZiyfABU9UlrKU4Ja1qy47WJrQNSALA9nnARZgbiY/3JkslISQ==</P><Q>20nBaoUN5QK9cuH6yX0QqAzhhB88rsI/HFzb8xrbEkceNfsTbYOVt+7biqzQQAvsyEILU+0l529eSe6S52yl9w==</Q><DP>wk3CLWkBfQZXC6ppmX9KcoRFr+k/PoH1r41BN8LZZUjVVy3mLZQW6utLkirQ9q695fBPwincWwhXDVb+dnAGkQ==</DP><DQ>Ks/0hhJiCxME37gE2W+kX9rb8IqUs13TKntqqcTVfnUKDent+hSVl2p3zFQ++DIb0WEriwAixVN16iM85RfOMw==</DQ><InverseQ>coc9FIy42//YO02qCCKfORevLIU8GIeTSYFqD9kMwhHSy1a6QMDpKaYWrYvv8FcMHglqWzdTqbSgBSrsfcnibw==</InverseQ><D>JvPie4/awFWLxOXgaMwCTceNpmukEIOl5SpZ7dhhbALJUveZ91BkF8SWZdss+VAkNJQHwY+YeWagPsvSbVRb1WylY11D8gBQEb6EOR3EsM17/5+v6nRrJ5+cySfpcahRbUjUdJFaVhMCUQ1wsnevLNY/Xo20UF4XCE5Exp7TW0E=</D></RSAKeyValue>");
                passdecrypt = DecryptedMessage.AsString;
                txtusuario.Text = usuario;
                txtnombre.Text = nombre;

                txtcontra.Text = passdecrypt;
                txtcontra.isPassword = true;
                txtgrupo.Text = grupo;
                if (fecha_alta == Convert.ToDateTime("01/01/1900 12:00:00 AM"))
                {
                    dateusr.Value = DateTime.Today;
                }
                else
                {
                    dateusr.Value = fecha_alta;
                }
                if (activo == false)
                {
                    Switchactivo.Value = false;
                }
                else
                {
                    Switchactivo.Value = true;

                }

                Module1.iniciarconexionempresa();

                SqlCommand comandoEmpleado;
                string consultaEmpleado;
                SqlDataReader readerEmpleado;
                consultaEmpleado = "select idempleado from empleadosAsignados where usr = '" + usuario + "'";
                comandoEmpleado = new SqlCommand();
                comandoEmpleado.Connection = Module1.conexionempresa;
                comandoEmpleado.CommandText = consultaEmpleado;
                readerEmpleado = comandoEmpleado.ExecuteReader();
                if (readerEmpleado.HasRows)
                {
                    while (readerEmpleado.Read())

                        txtempleado.Text = Conversions.ToString(readerEmpleado["idempleado"]);
                    ConsultarEmpleado();
                }

                else
                {
                    txtempleado.Text = "0";
                    ConsultarEmpleado();

                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void timerformato_Tick(object sender, EventArgs e)
        {
            timerformato.Interval = 1;
            if (mostrarcontraseña == false)
            {
                txtcontra.isPassword = true;
            }
            else
            {
                txtcontra.isPassword = false;
            }


        }

        private void txtempleado_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtgrupo_TextChanged(object sender, EventArgs e)
        {
            for (int numero = 0, loopTo = cantidadgrupos; numero <= loopTo; numero++)
            {
                if ((txtgrupo.Text ?? "") == (idgrupo[numero] ?? ""))
                {
                    lblcdggrp.Text = codigogrupo[numero];
                    lblnmgrp.Text = nombregrupo[numero];
                    break;
                }
                else
                {
                    lblcdggrp.Text = "No existe";
                    lblnmgrp.Text = "No existe";

                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.EmpresasPermitidas.idUsuario = idusuario;
            My.MyProject.Forms.EmpresasPermitidas.ShowDialog();


        }

        public void clickevent(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            // Dim label = DirectCast(sender, Label)

            txtgrupo.Text = Conversions.ToString(l.Name);
            FlowLayoutPanel1.Visible = false;





        }

        private void Label5_Click(object sender, EventArgs e)
        {
            if (mostrarcontraseña == false)
            {
                Label5.BorderStyle = BorderStyle.Fixed3D;
                Label5.BackColor = Color.FromArgb(223, 223, 223);
                mostrarcontraseña = true;
            }
            else
            {
                Label5.BorderStyle = BorderStyle.None;
                Label5.BackColor = Color.DimGray;
                mostrarcontraseña = false;
            }
        }


        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Autorizacion.tipoAutorizacion = "SatiModUsuariosModificar";
            My.MyProject.Forms.Autorizacion.ShowDialog();
            if (autorizado)
            {
                try
                {
                    var EncryptedMessage = Encryption.RSA.Encrypt(txtcontra.Text, "<RSAKeyValue><Modulus>1D3WnN4qZq3DGHf7i3WjEixX0Nzka28RIR9lOrT7Eg2QmJTACm/E6388wMdGgH3yTwKPp/T5zm61yvZn44oHMka8EKlACGKkADsxN/ci0RLKJ0ZGYDVPtB+KSzI+GbmX2eO00R+FlYvXTpMzGXy3e4QpeCJbIbrDGFpt3rmXy28=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
                    string contraseña;
                    int activosql;
                    contraseña = EncryptedMessage.AsBase64String;
                    string sql;
                    if (Switchactivo.Value == false)
                    {
                        activosql = 0;
                    }
                    else
                    {
                        activosql = 1;
                    }
                    sql = "update usr set nm = '" + txtusuario.Text + "',nm_complete='" + txtnombre.Text + "',pass='" + contraseña + "',grp='" + txtgrupo.Text + "',fecha_alta='" + Conversions.ToString(dateusr.Value) + "',activo='" + activosql + "' where idusr = '" + idusuario + "'";
                    OleDbCommand comandoagregar;

                    Module1.iniciarconexionR();
                    comandoagregar = new OleDbCommand();
                    comandoagregar.Connection = Module1.conexionempresaR;
                    comandoagregar.CommandText = sql;
                    comandoagregar.ExecuteNonQuery();

                    Module1.iniciarconexionempresa();
                    SqlCommand comandoEliminarEmpleado;
                    string consultaEliminarEmpleado;
                    consultaEliminarEmpleado = "Delete from empleadosAsignados where usr = '" + usuario + "'";
                    comandoEliminarEmpleado = new SqlCommand();
                    comandoEliminarEmpleado.Connection = Module1.conexionempresa;
                    comandoEliminarEmpleado.CommandText = consultaEliminarEmpleado;
                    comandoEliminarEmpleado.ExecuteNonQuery();

                    if (txtempleado.Text != "0")
                    {
                        SqlCommand comandoAempleado;
                        string consultaAempleado;
                        consultaAempleado = "IF NOT EXISTS((select * from empleadosAsignados where usr = '" + txtusuario.Text + "' and idempleado = '" + txtempleado.Text + @"'))
BEGIN
insert into empleadosAsignados values('" + txtusuario.Text + "','" + txtempleado.Text + "') end";
                        comandoAempleado = new SqlCommand();
                        comandoAempleado.Connection = Module1.conexionempresa;
                        comandoAempleado.CommandText = consultaAempleado;
                        comandoAempleado.ExecuteNonQuery();
                    }
                    else
                    {

                    }

                    actualizar = true;
                    MessageBox.Show("Listo");
                }
                catch (Exception ex)
                {
                    actualizar = false;
                    MessageBox.Show(ex.Message);
                }
            }

            else
            {
                MessageBox.Show("No fue autorizado");
            }


        }

        public void ConsultarEmpleado()
        {
            if (txtempleado.Text != "0")
            {
                Module1.iniciarconexionempresa();
                SqlCommand comandoEmpleado;
                string consultaEmpleado;
                consultaEmpleado = "Select nombre from empleados where id = '" + txtempleado.Text + "'";
                comandoEmpleado = new SqlCommand();
                comandoEmpleado.Connection = Module1.conexionempresa;
                comandoEmpleado.CommandText = consultaEmpleado;
                lblempleado.Text = Conversions.ToString(comandoEmpleado.ExecuteScalar());
            }

            else
            {
                lblempleado.Text = "Ninguno";
            }

        }

        private void txtempleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConsultarEmpleado();

            }

            if (e.KeyCode == Keys.F2)
            {
                My.MyProject.Forms.BuscarEmpleadoUsuarioActualizar.Show();
            }
        }
    }
}