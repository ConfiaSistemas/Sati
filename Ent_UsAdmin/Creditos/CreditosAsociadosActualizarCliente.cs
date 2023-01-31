using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class CreditosAsociadosActualizarCliente
    {
        public DataTable dataCreditos;
        public string nombre;
        public string aPaterno;
        public string aMaterno;
        public string Curp;
        public string telefono;
        public string Celular;
        public string valorAnterior;
        public string idCliente;
        public string EstadoValidacionCurp;
        public bool ValidadoCurp;
        public DateTime FechaNacimiento;
        public bool Autorizado;
        private string idActualizacion;
        private bool err;
        private Cargando ncargando;
        public bool creada;
        private string existeActualizacion;

        public CreditosAsociadosActualizarCliente()
        {
            InitializeComponent();
        }
        private void CreditosAsociadosActualizarCliente_Load(object sender, EventArgs e)
        {

            dtdatos.DataSource = dataCreditos;
            btn_agregar.Enabled = false;

            ncargando = new Cargando();
            ncargando.MonoFlat_Label1.Text = "Consultando información";
            ncargando.Show();

            BackgroundConsultarActualizacion.RunWorkerAsync();


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

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            btn_agregar.Enabled = false;

            foreach (DataRow row in Module1.dataPermisos.Rows)
            {
                if (Conversions.ToBoolean(row["SatiModCreditosModificar"]))
                {
                    My.MyProject.Forms.Autorizacion.tipoAutorizacion = "SatiModCreditosModificar";
                    My.MyProject.Forms.Autorizacion.ShowDialog();
                    if (Autorizado)
                    {
                        ncargando = new Cargando();

                        ncargando.MonoFlat_Label1.Text = "Actualizando cliente";
                        ncargando.Show();
                        BackgroundActualizar.RunWorkerAsync();
                    }
                    else
                    {
                        MessageBox.Show("No fue autorizado");
                    }
                    break;
                }
                else if (MessageBox.Show("¿No cuenta con los permisos, desea notificar a un usuario?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ncargando = new Cargando();
                    ncargando.MonoFlat_Label1.Text = "Creando actualización";
                    ncargando.Show();
                    BackgroundActualizarCnotificacion.RunWorkerAsync();


                }
            }
        }

        private void BackgroundActualizar_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Module1.iniciarconexionempresa();

                SqlCommand comandoActualizar;
                string consultaActualizar;

                consultaActualizar = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(@"INSERT INTO [dbo].[ActualizacionesClientes]
          
     VALUES
           (" + idCliente + @"
           ,'" + nombre + @"'
           ,'" + aPaterno + @"'
           ,'" + aMaterno + @"'
           ,'" + Curp + @"'
           ,'" + EstadoValidacionCurp + @"'
           ,'" + ValidadoCurp + @"'
           ,'" + telefono + @"'
           ,'" + Celular + @"'
           ,'" + FechaNacimiento.ToString("yyyy-MM-dd") + @"'
           ,'", dtdatos.Rows[dtdatos.CurrentRow.Index].Cells[0].Value), @"'
           ,'"), valorAnterior), @"'
           ,GETDATE()
           ,GETDATE()
           ,'"), Module1.nmusr), @"'
           ,''
           ,''
           ,''
           ,'E','0') Select SCOPE_IDENTITY()"));
                comandoActualizar = new SqlCommand();
                comandoActualizar.Connection = Module1.conexionempresa;
                comandoActualizar.CommandText = consultaActualizar;
                idActualizacion = Conversions.ToString(comandoActualizar.ExecuteScalar());

                SqlCommand comandoProdActualizar;
                string consultaProdActualizar;
                consultaProdActualizar = "ActualizarCliente";
                comandoProdActualizar = new SqlCommand();
                comandoProdActualizar.Connection = Module1.conexionempresa;
                comandoProdActualizar.CommandText = consultaProdActualizar;

                comandoProdActualizar.CommandType = CommandType.StoredProcedure;
                comandoProdActualizar.Parameters.AddWithValue("idActualizacion", idActualizacion);
                comandoProdActualizar.Parameters.AddWithValue("usr", Module1.nmusr);
                comandoProdActualizar.ExecuteNonQuery();
                err = false;
            }


            catch (Exception ex)
            {
                err = true;
                MessageBox.Show(ex.Message);
            }



        }

        private void BackgroundActualizar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ncargando.Close();

            if (err)
            {
                MessageBox.Show("Hubo un error inténtalo de nuevo");
            }
            else
            {
                MessageBox.Show("Actualizado con éxito");
                Close();

            }
            btn_agregar.Enabled = true;

        }

        private void BackgroundActualizarCnotificacion_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();

            SqlCommand comandoActualizar;
            string consultaActualizar;

            consultaActualizar = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(@"INSERT INTO [dbo].[ActualizacionesClientes]
          
     VALUES  (" + idCliente + ",'" + nombre + "','" + aPaterno + "','" + aMaterno + "','" + Curp + "','" + EstadoValidacionCurp + "','" + ValidadoCurp + "','" + telefono + "','" + Celular + "','" + FechaNacimiento.ToString("yyyy-MM-dd") + "','", dtdatos.Rows[dtdatos.CurrentRow.Index].Cells[0].Value), "','"), valorAnterior), "',GETDATE(),GETDATE(),'"), Module1.nmusr), "','','','','E','0'); Select SCOPE_IDENTITY()"));
            comandoActualizar = new SqlCommand();
            comandoActualizar.Connection = Module1.conexionempresa;
            comandoActualizar.CommandText = consultaActualizar;
            idActualizacion = Conversions.ToString(comandoActualizar.ExecuteScalar());
        }

        private void BackgroundActualizarCnotificacion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ncargando.Close();
            My.MyProject.Forms.CrearNotificacionActualizarCliente.idActualizacion = idActualizacion;
            // CrearNotificacionDescuentoPromesa.tipoCredito = TipoCredito
            My.MyProject.Forms.CrearNotificacionActualizarCliente.ShowDialog();

            if (creada)
            {
                Task.Factory.StartNew(() =>
                    {
                        SqlCommand comandoActualizaPromesa;
                        string consultaActualizaPromesa;
                        consultaActualizaPromesa = "update ActualizacionesClientes set notificado = 1 where id = '" + idActualizacion + "'";
                        comandoActualizaPromesa = new SqlCommand();
                        comandoActualizaPromesa.Connection = Module1.conexionempresa;
                        comandoActualizaPromesa.CommandText = consultaActualizaPromesa;
                        comandoActualizaPromesa.ExecuteNonQuery();


                    });
                Close();
            }
            else if (MessageBox.Show("¿La notificación no fue creada, desea volver a intentarlo?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                My.MyProject.Forms.CrearNotificacionActualizarCliente.idActualizacion = idActualizacion;
                // CrearNotificacionDescuentoPromesa.tipoCredito = TipoCredito
                My.MyProject.Forms.CrearNotificacionActualizarCliente.ShowDialog();
                if (creada)
                {
                    Task.Factory.StartNew(() =>
                    {
                        SqlCommand comandoActualizaPromesa;
                        string consultaActualizaPromesa;
                        consultaActualizaPromesa = "update ActualizacionesClientes set notificado = 1 where id = '" + idActualizacion + "'";
                        comandoActualizaPromesa = new SqlCommand();
                        comandoActualizaPromesa.Connection = Module1.conexionempresa;
                        comandoActualizaPromesa.CommandText = consultaActualizaPromesa;
                        comandoActualizaPromesa.ExecuteNonQuery();


                    });
                    Close();
                }
                else
                {
                    MessageBox.Show("La notificación no fue creada, puedes intentarlo más tarde");
                    Close();

                }
            }
            else
            {
                Close();

            }
            btn_agregar.Enabled = true;


        }

        private void BackgroundConsultarActualizacion_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consultaActualizacion;
            consultaActualizacion = " if exists(Select * from actualizacionesClientes where idcliente = '" + idCliente + @"' and estado = 'E' and notificado = 0)
							begin
							 select 'Pendiente'
							end
							else if exists(select * from actualizacionesClientes where idcliente = '" + idCliente + @"' and estado = 'E' and Notificado = 1)
                            begin
                             Select 'Notificado'
                            end
                            else
							select 'Noexiste'
";


            SqlCommand comandoActualizacion;
            comandoActualizacion = new SqlCommand();
            comandoActualizacion.Connection = Module1.conexionempresa;
            comandoActualizacion.CommandText = consultaActualizacion;
            existeActualizacion = Conversions.ToString(comandoActualizacion.ExecuteScalar());
        }

        private void BackgroundConsultarActualizacion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ncargando.Close();

            if (existeActualizacion == "Existe")
            {

                MessageBox.Show("El crédito ya cuenta con una actualización activa");
                Close();
            }
            else if (existeActualizacion == "Pendiente")
            {
                MessageBox.Show("El cliente cuenta con una actualización pendiente de notificar, se intentará notificar de nuevo");

                ncargando = new Cargando();
                ncargando.Show();
                ncargando.MonoFlat_Label1.Text = "Consultando Actualización";
                ncargando.TopMost = true;
                BackgroundConsultarActualizacionPendiente.RunWorkerAsync();
            }

            else if (existeActualizacion == "Notificado")
            {
                MessageBox.Show("El cliente cuenta con una notificación pendiente de autorizar");
                Close();
            }
            else
            {
                btn_agregar.Enabled = true;


            }
        }

        private void BackgroundConsultarActualizacionPendiente_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consultaActualizacion;
            consultaActualizacion = "select id from actualizacionesClientes where idcliente = '" + idCliente + "' and estado = 'E' and notificado = 0";
            SqlCommand comandoActualizacion;
            comandoActualizacion = new SqlCommand();
            comandoActualizacion.Connection = Module1.conexionempresa;
            comandoActualizacion.CommandText = consultaActualizacion;
            idActualizacion = Conversions.ToString(comandoActualizacion.ExecuteScalar());
        }

        private void BackgroundConsultarActualizacionPendiente_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ncargando.Close();
            My.MyProject.Forms.CrearNotificacionActualizarCliente.idActualizacion = idActualizacion;
            // CrearNotificacionDescuentoPromesa.tipoCredito = TipoCredito
            My.MyProject.Forms.CrearNotificacionActualizarCliente.ShowDialog();

            if (creada)
            {
                Task.Factory.StartNew(() =>
                    {
                        SqlCommand comandoActualizaPromesa;
                        string consultaActualizaPromesa;
                        consultaActualizaPromesa = "update ActualizacionesClientes set notificado = 1 where id = '" + idActualizacion + "'";
                        comandoActualizaPromesa = new SqlCommand();
                        comandoActualizaPromesa.Connection = Module1.conexionempresa;
                        comandoActualizaPromesa.CommandText = consultaActualizaPromesa;
                        comandoActualizaPromesa.ExecuteNonQuery();


                    });
                Close();
            }
            else if (MessageBox.Show("¿La notificación no fue creada, desea volver a intentarlo?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                My.MyProject.Forms.CrearNotificacionActualizarCliente.idActualizacion = idActualizacion;
                // CrearNotificacionDescuentoPromesa.tipoCredito = TipoCredito
                My.MyProject.Forms.CrearNotificacionActualizarCliente.ShowDialog();
                if (creada)
                {
                    Task.Factory.StartNew(() =>
                    {
                        SqlCommand comandoActualizaPromesa;
                        string consultaActualizaPromesa;
                        consultaActualizaPromesa = "update ActualizacionesClientes set notificado = 1 where id = '" + idActualizacion + "'";
                        comandoActualizaPromesa = new SqlCommand();
                        comandoActualizaPromesa.Connection = Module1.conexionempresa;
                        comandoActualizaPromesa.CommandText = consultaActualizaPromesa;
                        comandoActualizaPromesa.ExecuteNonQuery();


                    });
                    Close();
                }
                else
                {
                    MessageBox.Show("La notificación no fue creada, puedes intentarlo más tarde");
                    Close();

                }
            }
            else
            {
                Close();

            }
        }
    }
}