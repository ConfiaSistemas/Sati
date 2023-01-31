using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using ConfiaAdmin.MonoFlat;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace ConfiaAdmin
{

    public partial class CentroDeNotificaciones
    {
        public CentroDeNotificaciones()
        {
            InitializeComponent();
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

        private void CentroDeNotificaciones_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;

            foreach (Notificaciones n in My.MyProject.Forms.frm_adm.array)
            {
                if (!string.IsNullOrEmpty(n.Estado))
                {
                    var botonNotificacion = new Panel();
                    botonNotificacion.BackColor = Color.FromArgb(48, 55, 76);
                    // botonNotificacion.Iconimage = My.Resources.notificacion
                    botonNotificacion.Size = new Size(792, 146);
                    botonNotificacion.Text = "";
                    botonNotificacion.Cursor = Cursors.Hand;
                    botonNotificacion.Name = n.id.ToString();
                    botonNotificacion.Tag = n.Valor;


                    botonNotificacion.MouseEnter += Panel_MouseHover;
                    botonNotificacion.MouseLeave += Panel_MouseLeave;
                    botonNotificacion.Click += Panel_Click;

                    FlowLayoutPanel1.PerformLayout();
                    Invoke(new Action(() => FlowLayoutPanel1.Controls.Add(botonNotificacion)));



                    var lblFecha = new MonoFlat_HeaderLabel();

                    lblFecha.Location = new Point(158, 14);
                    lblFecha.Text = "El " + n.FechaAplicacion + " a las " + n.HoraAplicacion;

                    lblFecha.AutoSize = true;

                    lblFecha.BringToFront();
                    // lblFecha.BackColor = Color.White
                    lblFecha.ForeColor = Color.FromArgb(255, 255, 255);
                    Invoke(new Action(() => botonNotificacion.Controls.Add(lblFecha)));


                    // Dim lblHora As New MonoFlat_HeaderLabel

                    // lblHora.Location = New Point(413, 14)
                    // lblHora.Text = n.HoraAplicacion

                    // lblHora.AutoSize = True
                    // lblHora.BringToFront()
                    // lblFecha.BackColor = Color.White
                    // lblHora.ForeColor = Color.FromArgb(255, 255, 255)
                    // Me.Invoke(Sub()
                    // botonNotificacion.Controls.Add(lblHora)
                    // End Sub)




                    MonoFlat_HeaderLabel lblLabelTipo;
                    lblLabelTipo = new MonoFlat_HeaderLabel();

                    lblLabelTipo.Parent = botonNotificacion;
                    lblLabelTipo.Location = new Point(158, 72);
                    lblLabelTipo.Text = "Respuesta de tu solicitud de " + n.Tipo;
                    lblLabelTipo.AutoSize = true;

                    lblLabelTipo.BringToFront();
                    // lblFecha.BackColor = Color.White
                    lblLabelTipo.ForeColor = Color.FromArgb(255, 255, 255);

                    botonNotificacion.Controls.Add(lblLabelTipo);





                    var lblTipo = new MonoFlat_HeaderLabel();

                    lblTipo.Location = new Point(218, 72);
                    lblTipo.Text = "Respuesta";
                    lblTipo.AutoSize = true;
                    lblTipo.Name = "Tipo";
                    lblTipo.BringToFront();
                    // lblFecha.BackColor = Color.White
                    lblTipo.ForeColor = Color.FromArgb(255, 255, 255);
                    Invoke(new Action(() => botonNotificacion.Controls.Add(lblTipo)));


                    MonoFlat_HeaderLabel lblEmpresa;
                    lblEmpresa = new MonoFlat_HeaderLabel();

                    lblEmpresa.Parent = botonNotificacion;
                    lblEmpresa.Location = new Point(158, 120);
                    lblEmpresa.Text = "En " + n.Empresa;
                    lblEmpresa.AutoSize = true;

                    lblEmpresa.BringToFront();
                    // lblFecha.BackColor = Color.White
                    lblEmpresa.ForeColor = Color.FromArgb(255, 255, 255);

                    botonNotificacion.Controls.Add(lblEmpresa);
                }



                // Dim lblLabelUsuario As New MonoFlat_HeaderLabel

                // lblLabelUsuario.Location = New Point(413, 72)
                // lblLabelUsuario.Text = "Usuario:"
                // lblLabelUsuario.AutoSize = True

                // lblLabelUsuario.BringToFront()
                // lblFecha.BackColor = Color.White
                // lblLabelUsuario.ForeColor = Color.FromArgb(255, 255, 255)
                // Me.Invoke(Sub()
                // botonNotificacion.Controls.Add(lblLabelUsuario)
                // End Sub)




                // Dim lblUsuario As New MonoFlat_HeaderLabel

                // lblUsuario.Location = New Point(497, 72)
                // lblUsuario.Text = n.UsuarioDestino
                // lblUsuario.AutoSize = True

                // lblUsuario.BringToFront()
                // lblFecha.BackColor = Color.White
                // lblUsuario.ForeColor = Color.FromArgb(255, 255, 255)
                // Me.Invoke(Sub()
                // botonNotificacion.Controls.Add(lblUsuario)
                // End Sub)


                else
                {
                    var botonNotificacion = new Panel();
                    botonNotificacion.BackColor = Color.FromArgb(48, 55, 76);
                    // botonNotificacion.Iconimage = My.Resources.notificacion
                    botonNotificacion.Size = new Size(792, 146);
                    botonNotificacion.Text = "";
                    botonNotificacion.Cursor = Cursors.Hand;
                    botonNotificacion.Name = n.id.ToString();
                    botonNotificacion.Tag = n.Valor;

                    botonNotificacion.MouseEnter += Panel_MouseHover;
                    botonNotificacion.MouseLeave += Panel_MouseLeave;
                    botonNotificacion.Click += Panel_Click;

                    FlowLayoutPanel1.PerformLayout();
                    Invoke(new Action(() => FlowLayoutPanel1.Controls.Add(botonNotificacion)));



                    var lblFecha = new MonoFlat_HeaderLabel();

                    lblFecha.Location = new Point(158, 14);
                    lblFecha.Text = "El " + n.Fecha + " a las " + n.Hora;

                    lblFecha.AutoSize = true;

                    lblFecha.BringToFront();
                    // lblFecha.BackColor = Color.White
                    lblFecha.ForeColor = Color.FromArgb(255, 255, 255);
                    Invoke(new Action(() => botonNotificacion.Controls.Add(lblFecha)));


                    // Dim lblHora As New MonoFlat_HeaderLabel

                    // lblHora.Location = New Point(413, 14)
                    // lblHora.Text = n.Hora

                    // lblHora.AutoSize = True
                    // lblHora.BringToFront()
                    // lblFecha.BackColor = Color.White
                    // lblHora.ForeColor = Color.FromArgb(255, 255, 255)
                    // Me.Invoke(Sub()
                    // botonNotificacion.Controls.Add(lblHora)
                    // End Sub)




                    MonoFlat_HeaderLabel lblLabelTipo;
                    lblLabelTipo = new MonoFlat_HeaderLabel();

                    lblLabelTipo.Parent = botonNotificacion;
                    lblLabelTipo.Location = new Point(158, 72);
                    lblLabelTipo.Text = "El usuario " + n.Usuario + " solicita " + n.Tipo;
                    lblLabelTipo.AutoSize = true;

                    lblLabelTipo.BringToFront();
                    // lblFecha.BackColor = Color.White
                    lblLabelTipo.ForeColor = Color.FromArgb(255, 255, 255);

                    botonNotificacion.Controls.Add(lblLabelTipo);





                    var lblTipo = new MonoFlat_HeaderLabel();

                    lblTipo.Location = new Point(218, 72);
                    lblTipo.Text = n.Tipo;
                    lblTipo.AutoSize = true;
                    lblTipo.Name = "Tipo";
                    lblTipo.BringToFront();
                    lblTipo.Visible = false;
                    lblTipo.BackColor = Color.White;
                    // lblTipo.ForeColor = Color.FromArgb(255, 255, 255)
                    Invoke(new Action(() => botonNotificacion.Controls.Add(lblTipo)));




                    MonoFlat_HeaderLabel lblEmpresa;
                    lblEmpresa = new MonoFlat_HeaderLabel();

                    lblEmpresa.Parent = botonNotificacion;
                    lblEmpresa.Location = new Point(158, 120);
                    lblEmpresa.Text = "En " + n.Empresa;
                    lblEmpresa.AutoSize = true;

                    lblEmpresa.BringToFront();
                    // lblFecha.BackColor = Color.White
                    lblEmpresa.ForeColor = Color.FromArgb(255, 255, 255);

                    botonNotificacion.Controls.Add(lblEmpresa);


                    // Dim lblLabelUsuario As New MonoFlat_HeaderLabel

                    // lblLabelUsuario.Location = New Point(413, 72)
                    // lblLabelUsuario.Text = "Usuario:"
                    // lblLabelUsuario.AutoSize = True

                    // lblLabelUsuario.BringToFront()
                    // lblFecha.BackColor = Color.White
                    // lblLabelUsuario.ForeColor = Color.FromArgb(255, 255, 255)
                    // Me.Invoke(Sub()
                    // botonNotificacion.Controls.Add(lblLabelUsuario)
                    // End Sub)




                    // Dim lblUsuario As New MonoFlat_HeaderLabel

                    // lblUsuario.Location = New Point(497, 72)
                    // lblUsuario.Text = n.Usuario
                    // lblUsuario.AutoSize = True

                    // lblUsuario.BringToFront()
                    // lblFecha.BackColor = Color.White
                    // lblUsuario.ForeColor = Color.FromArgb(255, 255, 255)
                    // Me.Invoke(Sub()
                    // botonNotificacion.Controls.Add(lblUsuario)
                    // End Sub)


                }

            }
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void Panel_MouseHover(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            p.BackColor = Color.FromArgb(91, 103, 138);
        }
        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            p.BackColor = Color.FromArgb(48, 55, 76);
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            p.BackColor = Color.FromArgb(123, 127, 139);
            foreach (Control ctrl in (IEnumerable)p.Controls)
            {
                if (ctrl is MonoFlat_HeaderLabel)
                {
                    MonoFlat_HeaderLabel lblTipo = (MonoFlat_HeaderLabel)ctrl;
                    if (lblTipo.Name == "Tipo")
                    {

                        if (lblTipo.Text == "CancelarTicket")
                        {

                            My.MyProject.Forms.CancelarTicket.idNotificacion = Conversions.ToString(p.Name);
                            My.MyProject.Forms.CancelarTicket.idTicket = Conversions.ToString(p.Tag);
                            My.MyProject.Forms.CancelarTicket.Show();
                            break;
                        }
                        if (lblTipo.Text == "DescuentoPromesa")
                        {
                            My.MyProject.Forms.AplicarDescuentoPromesa.idPromesa = Conversions.ToString(p.Tag);
                            My.MyProject.Forms.AplicarDescuentoPromesa.idNotificacion = Conversions.ToString(p.Name);
                            My.MyProject.Forms.AplicarDescuentoPromesa.Show();
                            break;

                        }
                        if (lblTipo.Text == "DescuentoBuenFin")
                        {
                            My.MyProject.Forms.AplicarDescuentoBuenFin.idPromesa = Conversions.ToString(p.Tag);
                            My.MyProject.Forms.AplicarDescuentoBuenFin.idNotificacion = Conversions.ToString(p.Name);
                            My.MyProject.Forms.AplicarDescuentoBuenFin.Show();
                            break;

                        }
                        if (lblTipo.Text == "DepositoLegal")
                        {
                            My.MyProject.Forms.AplicarDepositoLegal.idDeposito = Conversions.ToString(p.Tag);
                            My.MyProject.Forms.AplicarDepositoLegal.idNotificacion = Conversions.ToString(p.Name);
                            My.MyProject.Forms.AplicarDepositoLegal.Show();
                            break;

                        }
                        if (lblTipo.Text == "ActualizarCliente")
                        {
                            My.MyProject.Forms.AplicarActualizacionCliente.idActualizacion = Conversions.ToString(p.Tag);
                            My.MyProject.Forms.AplicarActualizacionCliente.idNotificacion = Conversions.ToString(p.Name);
                            My.MyProject.Forms.AplicarActualizacionCliente.Show();
                            break;

                        }
                    }



                }


                for (int a = My.MyProject.Forms.frm_adm.array.Count - 1; a >= 0; a -= 1)
                {
                    Notificaciones r = (Notificaciones)My.MyProject.Forms.frm_adm.array[a];
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(p.Name, r.id, false)))
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(r.Estado, "", false)))
                        {
                            Invoke(new Action(() =>
                                {
                                    MySqlConnection conexionNotificaciones;
                                    conexionNotificaciones = new MySqlConnection();
                                    conexionNotificaciones.ConnectionString = "server=www.prestamosconfia.com;user id=ajas;pwd=123456;port=3306;database=USRS";
                                    conexionNotificaciones.Open();
                                    MySqlCommand comandoActNotificacion;
                                    string consultaActNotificacion;
                                    comandoActNotificacion = new MySqlCommand();
                                    consultaActNotificacion = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("update Notificaciones set Visto = 1 where id = '",r.id), "'"));
                                    comandoActNotificacion.Connection = conexionNotificaciones;
                                    comandoActNotificacion.CommandText = consultaActNotificacion;
                                    comandoActNotificacion.ExecuteNonQuery();
                                    var nAlertas = new Alertas();
                                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(r.Estado, "R", false)))
                                    {
                                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(r.ComentarioUsuarioDestino, "", false)))
                                        {
                                            nAlertas.cadena = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("El usuario rechazó su solicitud de ",r.Tipo), " con valor "), r.Valor), " y agregó el comentario "),r.ComentarioUsuarioDestino));
                                        }
                                        else
                                        {
                                            nAlertas.cadena = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("El usuario rechazó su solicitud de ", r.Tipo), " con valor "), r.Valor), " sin dejar comentario"));
                                        }
                                    }

                                    else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(r.ComentarioUsuarioDestino, "", false)))
                                    {
                                        nAlertas.cadena = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("El usuario autorizó su solicitud de ", r.Tipo), " con valor "), r.Valor), " y agregó el comentario "), r.ComentarioUsuarioDestino));
                                    }
                                    else
                                    {
                                        nAlertas.cadena = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("El usuario autorizó su solicitud de ",r.Tipo), " con valor "), r.Valor), " sin dejar comentario"));
                                    }

                                    My.MyProject.Forms.frm_adm.array.RemoveAt(a);
                                    nAlertas.ShowDialog();
                                    nAlertas.TopMost = true;
                                    Control ctr = (Control)sender;
                                    FlowLayoutPanel1.Controls.Remove(ctr);
                                    My.MyProject.Forms.frm_adm.CantNotificaciones -= 1;
                                    My.MyProject.Forms.frm_adm.notificaciones.Text = "Tienes " + My.MyProject.Forms.frm_adm.array.Count + " notificaciones";
                                    My.MyProject.Forms.frm_adm.notificaciones.Refresh();
                                }));
                            break;
                        }
                    }
                }

            }




        }


    }
}