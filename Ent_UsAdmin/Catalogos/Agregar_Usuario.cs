using System;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class Agregar_Usuario
    {
        private bool actualizar = false;
        public bool autorizado;
        public string nombre, usuario, contraseña, idusuario, pass, passdecrypt;
        public string grupo;
        public bool activo;
        public DateTime fecha_alta;
        private int cantidadgrupos;
        private string[] nombregrupo = new string[1001];
        private string[] codigogrupo = new string[1001];
        private string[] idgrupo = new string[1001];
        private bool mostrarcontraseña = false;

        public Agregar_Usuario()
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
            ConsultarEmpleado();

            dateusr.Value = DateTime.Today;

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
            My.MyProject.Forms.Autorizacion.tipoAutorizacion = "SatiModUsuariosAgregar";
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


                    // sql = "update usr set nm = '" & txtusuario.Text & "',nm_complete='" & txtnombre.Text & "',pass='" & contraseña & "',grp='" & txtgrupo.Text & "',fecha_alta='" & dateusr.Value & "',activo='" & activosql & "' where idusr = '" & idusuario & "'"

                    sql = "insert into usr(nm,pass,grp,nm_complete,addr,imgstr,tlf,fecha_alta,activo) values('" + txtusuario.Text + "','" + contraseña + "','" + txtgrupo.Text + "','" + txtnombre.Text + "','','','','" + Conversions.ToString(dateusr.Value) + "','" + activosql + "')";
                    OleDbCommand comandoagregar;

                    Module1.iniciarconexionR();
                    comandoagregar = new OleDbCommand();
                    comandoagregar.Connection = Module1.conexionempresaR;
                    comandoagregar.CommandText = sql;
                    comandoagregar.ExecuteNonQuery();

                    if (txtempleado.Text != "0")
                    {
                        Module1.iniciarconexionempresa();
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
                My.MyProject.Forms.BuscarEmpleadoUsuario.Show();
            }
        }
    }
}