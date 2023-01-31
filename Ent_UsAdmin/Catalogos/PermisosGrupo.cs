using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class PermisosGrupo
    {
        public int idgrupousuarios;
        public bool Autorizado;

        public PermisosGrupo()
        {
            InitializeComponent();
        }
        private void PermisosGrupo_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            BackgroundPermisos.RunWorkerAsync();
        }

        private void cargarPermisos()
        {

        }

        private void BackgroundPermisos_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Module1.iniciarconexionR();
                // Acceso Sati

                string sqlAccesoSati;
                System.Data.OleDb.OleDbCommand comandoAccesoSati;



                System.Data.OleDb.OleDbDataReader milectorAccesoSati;

                comandoAccesoSati = new System.Data.OleDb.OleDbCommand();


                comandoAccesoSati.Connection = Module1.conexionempresaR;
                sqlAccesoSati = @"select permiso,valor from
(select SatiAcceso as Acceso from permisosGrupo where idGrupo = '" + idgrupousuarios + "') p unpivot(valor for permiso in ( [Acceso])) unpvt";
                comandoAccesoSati.CommandText = sqlAccesoSati;
                milectorAccesoSati = comandoAccesoSati.ExecuteReader();
                while (milectorAccesoSati.Read())
                {
                    var checkTipo = new CheckBox();


                    checkTipo.Name = Conversions.ToString(milectorAccesoSati["permiso"]);
                    checkTipo.Text = Conversions.ToString(milectorAccesoSati["permiso"]);
                    if (Conversions.ToBoolean(milectorAccesoSati["valor"]))
                    {
                        checkTipo.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkTipo.CheckState = CheckState.Unchecked;
                    }
                    checkTipo.ForeColor = Color.White;
                    checkTipo.AutoSize = true;
                    // checkTipo.Tag = milector("ip")

                    Invoke(new Action(() => FlowAccesoSati.Controls.Add(checkTipo)));

                }
                milectorAccesoSati.Close();


                // Usuarios

                string sql;
                System.Data.OleDb.OleDbCommand comando;



                System.Data.OleDb.OleDbDataReader milector;

                comando = new System.Data.OleDb.OleDbCommand();


                comando.Connection = Module1.conexionempresaR;
                sql = @"select permiso,valor from
(select SatiModUsuarios as Acceder,
SatiModUsuariosVer as Ver,
SatiModUsuariosModificar as Modificar,
SatiModUsuariosAgregar as Agregar from permisosGrupo where idGrupo = '" + idgrupousuarios + "') p unpivot(valor for permiso in ( [Acceder],[Ver],[Modificar],[Agregar])) unpvt";
                comando.CommandText = sql;
                milector = comando.ExecuteReader();
                while (milector.Read())
                {
                    var checkTipo = new CheckBox();


                    checkTipo.Name = Conversions.ToString(milector["permiso"]);
                    checkTipo.Text = Conversions.ToString(milector["permiso"]);
                    if (Conversions.ToBoolean(milector["valor"]))
                    {
                        checkTipo.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkTipo.CheckState = CheckState.Unchecked;
                    }
                    checkTipo.ForeColor = Color.Black;
                    checkTipo.AutoSize = true;
                    // checkTipo.Tag = milector("ip")

                    Invoke(new Action(() => FlowUsuarios.Controls.Add(checkTipo)));

                }
                milector.Close();

                // grupos

                string sqlgrupos;
                System.Data.OleDb.OleDbCommand comandogrupos;



                System.Data.OleDb.OleDbDataReader milectorgrupos;

                comandogrupos = new System.Data.OleDb.OleDbCommand();


                comandogrupos.Connection = Module1.conexionempresaR;
                sqlgrupos = @"select permiso,valor from
(select SatiModGrupos as Acceder,
SatiModGruposVer as Ver,
SatiModGruposModificar as Modificar,
SatiModGruposAgregar as Agregar from permisosGrupo where idGrupo = '" + idgrupousuarios + "') p unpivot(valor for permiso in ( [Acceder],[Ver],[Modificar],[Agregar])) unpvt";
                comandogrupos.CommandText = sqlgrupos;
                milectorgrupos = comandogrupos.ExecuteReader();
                while (milectorgrupos.Read())
                {
                    var checkTipo = new CheckBox();


                    checkTipo.Name = Conversions.ToString(milectorgrupos["permiso"]);
                    checkTipo.Text = Conversions.ToString(milectorgrupos["permiso"]);
                    if (Conversions.ToBoolean(milectorgrupos["valor"]))
                    {
                        checkTipo.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkTipo.CheckState = CheckState.Unchecked;
                    }
                    checkTipo.ForeColor = Color.Black;
                    checkTipo.AutoSize = true;
                    // checkTipo.Tag = milector("ip")

                    Invoke(new Action(() => FlowGrupos.Controls.Add(checkTipo)));

                }
                milectorgrupos.Close();

                // Catalogos
                string sqlcatalogos;
                System.Data.OleDb.OleDbCommand comandocatalogos;



                System.Data.OleDb.OleDbDataReader milectorcatalogos;

                comandocatalogos = new System.Data.OleDb.OleDbCommand();


                comandocatalogos.Connection = Module1.conexionempresaR;
                sqlcatalogos = @"select permiso,valor from
(select SatiModCatalogos as Acceder from permisosGrupo  where idGrupo = '" + idgrupousuarios + "') p unpivot(valor for permiso in ( [Acceder])) unpvt";
                comandocatalogos.CommandText = sqlcatalogos;
                milectorcatalogos = comandocatalogos.ExecuteReader();
                while (milectorcatalogos.Read())
                {
                    var checkTipo = new CheckBox();


                    checkTipo.Name = Conversions.ToString(milectorcatalogos["permiso"]);
                    checkTipo.Text = Conversions.ToString(milectorcatalogos["permiso"]);
                    if (Conversions.ToBoolean(milectorcatalogos["valor"]))
                    {
                        checkTipo.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkTipo.CheckState = CheckState.Unchecked;
                    }
                    checkTipo.ForeColor = Color.Black;
                    checkTipo.AutoSize = true;
                    // checkTipo.Tag = milector("ip")

                    Invoke(new Action(() => FlowCatalogos.Controls.Add(checkTipo)));

                }
                milectorcatalogos.Close();


                // clientes
                string sqlclientes;
                System.Data.OleDb.OleDbCommand comandoclientes;



                System.Data.OleDb.OleDbDataReader milectorclientes;

                comandoclientes = new System.Data.OleDb.OleDbCommand();


                comandoclientes.Connection = Module1.conexionempresaR;
                sqlclientes = @"select permiso,valor from
(select SatiModClientes as Acceder,
SatiModClientesVer as Ver,
SatiModClientesModificar as Modificar,
SatiModClientesAgregar as Agregar from permisosGrupo  where idGrupo = '" + idgrupousuarios + "') p unpivot(valor for permiso in ( [Acceder],[Ver],[Modificar],[Agregar])) unpvt";
                comandoclientes.CommandText = sqlclientes;
                milectorclientes = comandoclientes.ExecuteReader();
                while (milectorclientes.Read())
                {
                    var checkTipo = new CheckBox();


                    checkTipo.Name = Conversions.ToString(milectorclientes["permiso"]);
                    checkTipo.Text = Conversions.ToString(milectorclientes["permiso"]);
                    if (Conversions.ToBoolean(milectorclientes["valor"]))
                    {
                        checkTipo.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkTipo.CheckState = CheckState.Unchecked;
                    }
                    checkTipo.ForeColor = Color.Black;
                    checkTipo.AutoSize = true;
                    // checkTipo.Tag = milector("ip")

                    Invoke(new Action(() => FlowClientes.Controls.Add(checkTipo)));

                }
                milectorclientes.Close();

                // documentos
                string sqldocumentos;
                System.Data.OleDb.OleDbCommand comandodocumentos;



                System.Data.OleDb.OleDbDataReader milectordocumentos;

                comandodocumentos = new System.Data.OleDb.OleDbCommand();


                comandodocumentos.Connection = Module1.conexionempresaR;
                sqldocumentos = @"select permiso,valor from
(select SatiModDocumentos as Acceder,
SatiModDocumentosVer as Ver,
SatiModDocumentosModificar as Modificar,
SatiModDocumentosAgregar as Agregar from permisosGrupo  where idGrupo = '" + idgrupousuarios + "') p unpivot(valor for permiso in ( [Acceder],[Ver],[Modificar],[Agregar])) unpvt";
                comandodocumentos.CommandText = sqldocumentos;
                milectordocumentos = comandodocumentos.ExecuteReader();
                while (milectordocumentos.Read())
                {
                    var checkTipo = new CheckBox();


                    checkTipo.Name = Conversions.ToString(milectordocumentos["permiso"]);
                    checkTipo.Text = Conversions.ToString(milectordocumentos["permiso"]);
                    if (Conversions.ToBoolean(milectordocumentos["valor"]))
                    {
                        checkTipo.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkTipo.CheckState = CheckState.Unchecked;
                    }
                    checkTipo.ForeColor = Color.Black;
                    checkTipo.AutoSize = true;
                    // checkTipo.Tag = milector("ip")

                    Invoke(new Action(() => FlowDocumentos.Controls.Add(checkTipo)));

                }
                milectordocumentos.Close();


                // tipos de documentos
                string sqltiposdoc;
                System.Data.OleDb.OleDbCommand comandotiposdoc;



                System.Data.OleDb.OleDbDataReader milectortiposdoc;

                comandotiposdoc = new System.Data.OleDb.OleDbCommand();


                comandotiposdoc.Connection = Module1.conexionempresaR;
                sqltiposdoc = @"select permiso,valor from
(select SatiModTipoDocumentos as Acceder,
SatiModTipoDocumentosVer as Ver,
SatiModTipoDocumentosModificar as Modificar,
SatiModTipoDocumentosAgregar as Agregar from permisosGrupo  where idGrupo = '" + idgrupousuarios + "') p unpivot(valor for permiso in ( [Acceder],[Ver],[Modificar],[Agregar])) unpvt";
                comandotiposdoc.CommandText = sqltiposdoc;
                milectortiposdoc = comandotiposdoc.ExecuteReader();
                while (milectortiposdoc.Read())
                {
                    var checkTipo = new CheckBox();


                    checkTipo.Name = Conversions.ToString(milectortiposdoc["permiso"]);
                    checkTipo.Text = Conversions.ToString(milectortiposdoc["permiso"]);
                    if (Conversions.ToBoolean(milectortiposdoc["valor"]))
                    {
                        checkTipo.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkTipo.CheckState = CheckState.Unchecked;
                    }
                    checkTipo.ForeColor = Color.Black;
                    checkTipo.AutoSize = true;
                    // checkTipo.Tag = milector("ip")

                    Invoke(new Action(() => FlowTiposDeDocumentos.Controls.Add(checkTipo)));

                }
                milectortiposdoc.Close();

                // solicitudes
                string sqlsolicitudes;
                System.Data.OleDb.OleDbCommand comandosolicitudes;



                System.Data.OleDb.OleDbDataReader milectorsolicitudes;

                comandosolicitudes = new System.Data.OleDb.OleDbCommand();


                comandosolicitudes.Connection = Module1.conexionempresaR;
                sqlsolicitudes = @"select permiso,valor from
(select SatiModSolicitudes as Acceder,
SatiModSolicitudesVer as Ver,
SatiModSolicitudesModificar as Modificar,
SatiModSolicitudesAgregar as Agregar,
SatiModSolicitudesVerificar as Verificar,
SatiModSolicitudesAprobar as Aprobar,
SatiModSolicitudesCancelar as Cancelar,
SatiModSolicitudesAgregarRechazados as 'Agregar Rechazados',
SatimodSolicitudesAgregarLegales as 'Agregar Legales' from permisosGrupo  where idGrupo = '" + idgrupousuarios + "') p unpivot(valor for permiso in ( [Acceder],[Ver],[Modificar],[Agregar],[Verificar],[Aprobar],[Cancelar],[Agregar Rechazados],[Agregar Legales])) unpvt";
                comandosolicitudes.CommandText = sqlsolicitudes;
                milectorsolicitudes = comandosolicitudes.ExecuteReader();
                while (milectorsolicitudes.Read())
                {
                    var checkTipo = new CheckBox();


                    checkTipo.Name = Conversions.ToString(milectorsolicitudes["permiso"]);
                    checkTipo.Text = Conversions.ToString(milectorsolicitudes["permiso"]);
                    if (Conversions.ToBoolean(milectorsolicitudes["valor"]))
                    {
                        checkTipo.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkTipo.CheckState = CheckState.Unchecked;
                    }
                    checkTipo.ForeColor = Color.Black;
                    if (checkTipo.Name == "Agregar Rechazados")
                    {
                        checkTipo.AutoSize = false;
                        checkTipo.Size = new Size(104, 33);
                    }
                    else
                    {
                        checkTipo.AutoSize = true;

                    }

                    // checkTipo.Tag = milector("ip")

                    Invoke(new Action(() => FlowSolicitudes.Controls.Add(checkTipo)));

                }
                milectorsolicitudes.Close();

                // creditos
                string sqlcreditos;
                System.Data.OleDb.OleDbCommand comandocreditos;



                System.Data.OleDb.OleDbDataReader milectorcreditos;

                comandocreditos = new System.Data.OleDb.OleDbCommand();


                comandocreditos.Connection = Module1.conexionempresaR;
                sqlcreditos = @"select permiso,valor from
(select SatiModCreditos as Acceder,
SatiModCreditosVer as Ver,
SatiModCreditosCrearConvenio as 'Crear Convenio',
SatiModCreditosCrearReestructura as 'Crear Reestructura',
SatiModCreditosCrearPromesa as 'Crear Promesa' from permisosGrupo  where idGrupo = '" + idgrupousuarios + "') p unpivot(valor for permiso in ( [Acceder],[Ver],[Crear Convenio],[Crear Reestructura],[Crear Promesa])) unpvt";
                comandocreditos.CommandText = sqlcreditos;
                milectorcreditos = comandocreditos.ExecuteReader();
                while (milectorcreditos.Read())
                {
                    var checkTipo = new CheckBox();


                    checkTipo.Name = Conversions.ToString(milectorcreditos["permiso"]);
                    checkTipo.Text = Conversions.ToString(milectorcreditos["permiso"]);
                    if (Conversions.ToBoolean(milectorcreditos["valor"]))
                    {
                        checkTipo.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkTipo.CheckState = CheckState.Unchecked;
                    }
                    if (checkTipo.Name == "Crear Convenio")
                    {
                        checkTipo.AutoSize = false;
                        checkTipo.Size = new Size(104, 33);
                    }
                    else if (checkTipo.Name == "Acceder")
                    {
                        checkTipo.AutoSize = false;
                        checkTipo.Size = new Size(120, 20);
                    }
                    else
                    {

                        checkTipo.AutoSize = true;

                    }

                    checkTipo.ForeColor = Color.Black;
                    // checkTipo.AutoSize = True
                    // checkTipo.Tag = milector("ip")

                    Invoke(new Action(() => FlowCreditos.Controls.Add(checkTipo)));

                }
                milectorcreditos.Close();

                // reportes
                string sqlreportes;
                System.Data.OleDb.OleDbCommand comandoreportes;



                System.Data.OleDb.OleDbDataReader milectorreportes;

                comandoreportes = new System.Data.OleDb.OleDbCommand();


                comandoreportes.Connection = Module1.conexionempresaR;
                sqlreportes = @"select permiso,valor from
(select SatiModReportes as Acceder from permisosGrupo where idGrupo = '" + idgrupousuarios + "') p unpivot(valor for permiso in ( [Acceder])) unpvt";
                comandoreportes.CommandText = sqlreportes;
                milectorreportes = comandoreportes.ExecuteReader();
                while (milectorreportes.Read())
                {
                    var checkTipo = new CheckBox();


                    checkTipo.Name = Conversions.ToString(milectorreportes["permiso"]);
                    checkTipo.Text = Conversions.ToString(milectorreportes["permiso"]);
                    if (Conversions.ToBoolean(milectorreportes["valor"]))
                    {
                        checkTipo.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkTipo.CheckState = CheckState.Unchecked;
                    }
                    checkTipo.ForeColor = Color.Black;
                    checkTipo.AutoSize = true;
                    // checkTipo.Tag = milector("ip")

                    Invoke(new Action(() => FlowReportes.Controls.Add(checkTipo)));

                }
                milectorreportes.Close();

                // Tipos de Crédito
                string sqltiposCredito;
                System.Data.OleDb.OleDbCommand comandotiposCredito;



                System.Data.OleDb.OleDbDataReader milectortiposCredito;

                comandotiposCredito = new System.Data.OleDb.OleDbCommand();


                comandotiposCredito.Connection = Module1.conexionempresaR;
                sqltiposCredito = @"select permiso,valor from
(select SatiModTiposCreditos as Acceder,
SatiModTiposCreditosVer as Ver,
SatiModTiposCreditosModificar as Modificar,
SatiModTiposCreditosAgregar as Agregar from permisosGrupo  where idGrupo = '" + idgrupousuarios + "') p unpivot(valor for permiso in ( [Acceder],[Ver],[Modificar],[Agregar])) unpvt";
                comandotiposCredito.CommandText = sqltiposCredito;
                milectortiposCredito = comandotiposdoc.ExecuteReader();
                while (milectortiposCredito.Read())
                {
                    var checkTipo = new CheckBox();


                    checkTipo.Name = Conversions.ToString(milectortiposCredito["permiso"]);
                    checkTipo.Text = Conversions.ToString(milectortiposCredito["permiso"]);
                    if (Conversions.ToBoolean(milectortiposCredito["valor"]))
                    {
                        checkTipo.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkTipo.CheckState = CheckState.Unchecked;
                    }
                    checkTipo.ForeColor = Color.Black;
                    checkTipo.AutoSize = true;
                    // checkTipo.Tag = milector("ip")

                    Invoke(new Action(() => FlowTiposCredito.Controls.Add(checkTipo)));

                }
                milectortiposCredito.Close();

                // Empleados

                string sqlEmpleados;
                System.Data.OleDb.OleDbCommand comandoEmpleados;



                System.Data.OleDb.OleDbDataReader milectorEmpleados;

                comandoEmpleados = new System.Data.OleDb.OleDbCommand();


                comandoEmpleados.Connection = Module1.conexionempresaR;
                sqlEmpleados = @"select permiso,valor from
(select SatiModEmpleados as Acceder,
SatiModEmpleadosVer as Ver,
SatiModEmpleadosModificar as Modificar,
SatiModEmpleadosAgregar as Agregar from permisosGrupo  where idGrupo = '" + idgrupousuarios + "') p unpivot(valor for permiso in ( [Acceder],[Ver],[Modificar],[Agregar])) unpvt";
                comandoEmpleados.CommandText = sqlEmpleados;
                milectorEmpleados = comandoEmpleados.ExecuteReader();
                while (milectorEmpleados.Read())
                {
                    var checkTipo = new CheckBox();


                    checkTipo.Name = Conversions.ToString(milectorEmpleados["permiso"]);
                    checkTipo.Text = Conversions.ToString(milectorEmpleados["permiso"]);
                    if (Conversions.ToBoolean(milectorEmpleados["valor"]))
                    {
                        checkTipo.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkTipo.CheckState = CheckState.Unchecked;
                    }
                    checkTipo.ForeColor = Color.Black;
                    checkTipo.AutoSize = true;
                    // checkTipo.Tag = milector("ip")

                    Invoke(new Action(() => FlowEmpleados.Controls.Add(checkTipo)));

                }
                milectorEmpleados.Close();

                // Cajas
                string sqlCajas;
                System.Data.OleDb.OleDbCommand comandoCajas;



                System.Data.OleDb.OleDbDataReader milectorCajas;

                comandoCajas = new System.Data.OleDb.OleDbCommand();


                comandoCajas.Connection = Module1.conexionempresaR;
                sqlCajas = @"select permiso,valor from
(select SatiModEmpleados as Acceder,
SatiModEmpleadosVer as Ver,
SatiModEmpleadosModificar as Modificar,
SatiModEmpleadosAgregar as Agregar from permisosGrupo  where idGrupo = '" + idgrupousuarios + "') p unpivot(valor for permiso in ( [Acceder],[Ver],[Modificar],[Agregar])) unpvt";
                comandoCajas.CommandText = sqlCajas;
                milectorCajas = comandoCajas.ExecuteReader();
                while (milectorCajas.Read())
                {
                    var checkTipo = new CheckBox();


                    checkTipo.Name = Conversions.ToString(milectorCajas["permiso"]);
                    checkTipo.Text = Conversions.ToString(milectorCajas["permiso"]);
                    if (Conversions.ToBoolean(milectorCajas["valor"]))
                    {
                        checkTipo.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkTipo.CheckState = CheckState.Unchecked;
                    }
                    checkTipo.ForeColor = Color.Black;
                    checkTipo.AutoSize = true;
                    // checkTipo.Tag = milector("ip")

                    Invoke(new Action(() => FlowCajas.Controls.Add(checkTipo)));

                }
                milectorCajas.Close();

                // Legal
                string sqlLegal;
                System.Data.OleDb.OleDbCommand comandoLegal;



                System.Data.OleDb.OleDbDataReader milectorLegal;

                comandoLegal = new System.Data.OleDb.OleDbCommand();


                comandoLegal.Connection = Module1.conexionempresaR;
                sqlLegal = @"select permiso,valor from
(select SatiModLegal as Acceder,
SatiModLegalVer as Ver,
SatiModLegalGestionar as Gestionar,
SatiModLegalConvenio as 'Crear Convenio' from permisosGrupo  where idGrupo = '" + idgrupousuarios + "') p unpivot(valor for permiso in ( [Acceder],[Ver],[Gestionar],[Crear Convenio])) unpvt";
                comandoLegal.CommandText = sqlLegal;
                milectorLegal = comandoLegal.ExecuteReader();
                while (milectorLegal.Read())
                {
                    var checkTipo = new CheckBox();


                    checkTipo.Name = Conversions.ToString(milectorLegal["permiso"]);
                    checkTipo.Text = Conversions.ToString(milectorLegal["permiso"]);
                    if (Conversions.ToBoolean(milectorLegal["valor"]))
                    {
                        checkTipo.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkTipo.CheckState = CheckState.Unchecked;
                    }
                    checkTipo.ForeColor = Color.Black;
                    checkTipo.AutoSize = true;
                    // checkTipo.Tag = milector("ip")

                    Invoke(new Action(() => FlowLegal.Controls.Add(checkTipo)));

                }
                milectorLegal.Close();


                // sac

                string sqlsac;
                System.Data.OleDb.OleDbCommand comandosac;



                System.Data.OleDb.OleDbDataReader milectorsac;

                comandosac = new System.Data.OleDb.OleDbCommand();


                comandosac.Connection = Module1.conexionempresaR;
                sqlsac = @"select permiso,valor from
(select SacAcceso as Acceso,
SacConsultaCredito as Consultar,
SacCobrarCredito as Cobrar,
SacCobrarComision as 'Cobrar Comisión',
SacAplicarDescuento as 'Aplicar Descuento',
SacCancelarTicket as Cancelar,
SacDetalleCaja as Detalle,
SacConsultarTicket as 'Consultar Ticket',
SacModReportes as Reportes,
SacCobrarExtra as 'Cobrar Extra' from permisosGrupo where idGrupo = '" + idgrupousuarios + "') p unpivot(valor for permiso in ( [Acceso],[Consultar],[Cobrar],[Cobrar Comisión],[Aplicar Descuento],[Cancelar],[Detalle],[Consultar Ticket],[Reportes],[Cobrar Extra])) unpvt";
                comandosac.CommandText = sqlsac;
                milectorsac = comandosac.ExecuteReader();
                while (milectorsac.Read())
                {
                    var checkTipo = new CheckBox();


                    checkTipo.Name = Conversions.ToString(milectorsac["permiso"]);
                    checkTipo.Text = Conversions.ToString(milectorsac["permiso"]);
                    if (Conversions.ToBoolean(milectorsac["valor"]))
                    {
                        checkTipo.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkTipo.CheckState = CheckState.Unchecked;
                    }
                    checkTipo.ForeColor = Color.Black;
                    checkTipo.AutoSize = true;
                    // checkTipo.Tag = milector("ip")

                    Invoke(new Action(() => FlowSac.Controls.Add(checkTipo)));

                }
                milectorsac.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // 

        }

        private void BackgroundAplicarPermisos_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionR();
            // iniciarconexionempresa()

            bool SatiAcceso=false , SatiModUsuarios=false , SatiModUsuariosVer = false, SatiModUsuariosModificar = false, SatiModUsuariosAgregar = false, SatiModGrupos = false, SatiModGruposVer = false, SatiModGruposModificar = false, SatiModGruposAgregar = false, SatiModCatalogos = false, SatiModClientes = false, SatiModClientesVer = false, SatiModClientesModificar = false, SatiModClientesAgregar = false, SatiModDocumentos = false, SatiModDocumentosVer = false, SatiModDocumentosModificar = false, SatiModDocumentosAgregar = false, SatiModTipoDocumentos = false, SatiModTipoDocumentosVer = false, SatiModTipoDocumentosModificar = false, SatiModTipoDocumentosAgregar = false, SatiModSolicitudes = false, SatiModSolicitudesVer = false, SatiModSolicitudesModificar = false, SatiModSolicitudesAgregar = false, SatiModSolicitudesVerificar = false, SatiModSolicitudesAprobar = false, SatiModSolicitudesCancelar = false, SatiModSolicitudesAgregarRechazados = false, SatiModSolicitudesAgregarLegales = false, SatiModCreditos = false, SatiModCreditosVer = false, SatiModCreditosCrearConvenio = false, SatiModCreditosCrearReestructura = false, SatiModCreditosCrearPromesa = false, SatiModReportes = false, SatiModTiposCreditos = false, SatiModTiposCreditosVer = false, SatiModTiposCreditosModificar = false, SatiModTiposCreditosAgregar = false, SatiModEmpleados = false, SatiModEmpleadosVer = false, SatiModEmpleadosModificar = false, SatiModEmpleadosAgregar = false, SatiModCajas = false, SatiModCajasVer = false, SatiModCajasModificar = false, SatiModCajasAgregar = false, SacAcceso = false, SacConsultaCredito = false, SacCobrarCredito = false, SacCobrarComision = false, SacAplicarDescuento = false, SacCancelarTicket = false, SacDetalleCaja = false, SacConsultarTicket = false, SacModReportes = false, SacCobrarExtra = false, SatiModLegal = false, SatiModLegalVer = false, SatiModLegalGestionar = false, SatiModLegalConvenio = false;


            foreach (Control ctrl in FlowAccesoSati.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox checkctrl = (CheckBox)ctrl;
                    SatiAcceso = Conversions.ToBoolean(checkctrl.CheckState);
                }
            }

            foreach (Control ctrl in FlowUsuarios.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox checkctrl = (CheckBox)ctrl;
                    if (checkctrl.Name == "Acceder")
                    {
                        SatiModUsuarios = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Ver")
                    {
                        SatiModUsuariosVer = Conversions.ToBoolean(checkctrl.CheckState);
                    }

                    if (checkctrl.Name == "Modificar")
                    {
                        SatiModUsuariosModificar = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Agregar")
                    {
                        SatiModUsuariosAgregar = Conversions.ToBoolean(checkctrl.CheckState);
                    }



                }
            }

            foreach (Control ctrl in FlowGrupos.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox checkctrl = (CheckBox)ctrl;
                    if (checkctrl.Name == "Acceder")
                    {
                        SatiModGrupos = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Ver")
                    {
                        SatiModGruposVer = Conversions.ToBoolean(checkctrl.CheckState);
                    }

                    if (checkctrl.Name == "Modificar")
                    {
                        SatiModGruposModificar = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Agregar")
                    {
                        SatiModGruposAgregar = Conversions.ToBoolean(checkctrl.CheckState);
                    }



                }
            }


            foreach (Control ctrl in FlowCatalogos.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox checkctrl = (CheckBox)ctrl;
                    if (checkctrl.Name == "Acceder")
                    {
                        SatiModCatalogos = Conversions.ToBoolean(checkctrl.CheckState);
                    }


                }
            }


            foreach (Control ctrl in FlowClientes.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox checkctrl = (CheckBox)ctrl;
                    if (checkctrl.Name == "Acceder")
                    {
                        SatiModClientes = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Ver")
                    {
                        SatiModClientesVer = Conversions.ToBoolean(checkctrl.CheckState);
                    }

                    if (checkctrl.Name == "Modificar")
                    {
                        SatiModClientesModificar = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Agregar")
                    {
                        SatiModClientesAgregar = Conversions.ToBoolean(checkctrl.CheckState);
                    }



                }
            }

            foreach (Control ctrl in FlowDocumentos.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox checkctrl = (CheckBox)ctrl;
                    if (checkctrl.Name == "Acceder")
                    {
                        SatiModDocumentos = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Ver")
                    {
                        SatiModDocumentosVer = Conversions.ToBoolean(checkctrl.CheckState);
                    }

                    if (checkctrl.Name == "Modificar")
                    {
                        SatiModDocumentosModificar = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Agregar")
                    {
                        SatiModDocumentosAgregar = Conversions.ToBoolean(checkctrl.CheckState);
                    }



                }
            }

            foreach (Control ctrl in FlowTiposDeDocumentos.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox checkctrl = (CheckBox)ctrl;
                    if (checkctrl.Name == "Acceder")
                    {
                        SatiModTipoDocumentos = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Ver")
                    {
                        SatiModTipoDocumentosVer = Conversions.ToBoolean(checkctrl.CheckState);
                    }

                    if (checkctrl.Name == "Modificar")
                    {
                        SatiModTipoDocumentosModificar = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Agregar")
                    {
                        SatiModTipoDocumentosAgregar = Conversions.ToBoolean(checkctrl.CheckState);
                    }



                }
            }


            foreach (Control ctrl in FlowSolicitudes.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox checkctrl = (CheckBox)ctrl;
                    if (checkctrl.Name == "Acceder")
                    {
                        SatiModSolicitudes = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Ver")
                    {
                        SatiModSolicitudesVer = Conversions.ToBoolean(checkctrl.CheckState);
                    }

                    if (checkctrl.Name == "Modificar")
                    {
                        SatiModSolicitudesModificar = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Agregar")
                    {
                        SatiModSolicitudesAgregar = Conversions.ToBoolean(checkctrl.CheckState);
                    }

                    if (checkctrl.Name == "Verificar")
                    {
                        SatiModSolicitudesVerificar = Conversions.ToBoolean(checkctrl.CheckState);
                    }

                    if (checkctrl.Name == "Aprobar")
                    {
                        SatiModSolicitudesAprobar = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Cancelar")
                    {
                        SatiModSolicitudesCancelar = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Agregar Rechazados")
                    {
                        SatiModSolicitudesAgregarRechazados = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Agregar Legales")
                    {
                        SatiModSolicitudesAgregarLegales = Conversions.ToBoolean(checkctrl.CheckState);
                    }

                }
            }

            foreach (Control ctrl in FlowCreditos.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox checkctrl = (CheckBox)ctrl;
                    if (checkctrl.Name == "Acceder")
                    {
                        SatiModCreditos = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Ver")
                    {
                        SatiModCreditosVer = Conversions.ToBoolean(checkctrl.CheckState);
                    }

                    if (checkctrl.Name == "Crear Convenio")
                    {
                        SatiModCreditosCrearConvenio = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Crear Reestructura")
                    {
                        SatiModCreditosCrearReestructura = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Crear Promesa")
                    {
                        SatiModCreditosCrearPromesa = Conversions.ToBoolean(checkctrl.CheckState);
                    }




                }
            }

            foreach (Control ctrl in FlowCreditos.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox checkctrl = (CheckBox)ctrl;
                    if (checkctrl.Name == "Acceder")
                    {
                        SatiModCreditos = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Ver")
                    {
                        SatiModCreditosVer = Conversions.ToBoolean(checkctrl.CheckState);
                    }




                }
            }


            foreach (Control ctrl in FlowReportes.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox checkctrl = (CheckBox)ctrl;
                    if (checkctrl.Name == "Acceder")
                    {
                        SatiModReportes = Conversions.ToBoolean(checkctrl.CheckState);
                    }


                }
            }


            foreach (Control ctrl in FlowTiposCredito.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox checkctrl = (CheckBox)ctrl;
                    if (checkctrl.Name == "Acceder")
                    {
                        SatiModTiposCreditos = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Ver")
                    {
                        SatiModTiposCreditosVer = Conversions.ToBoolean(checkctrl.CheckState);
                    }

                    if (checkctrl.Name == "Modificar")
                    {
                        SatiModTiposCreditosModificar = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Agregar")
                    {
                        SatiModTiposCreditosAgregar = Conversions.ToBoolean(checkctrl.CheckState);
                    }



                }
            }

            foreach (Control ctrl in FlowEmpleados.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox checkctrl = (CheckBox)ctrl;
                    if (checkctrl.Name == "Acceder")
                    {
                        SatiModEmpleados = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Ver")
                    {
                        SatiModEmpleadosVer = Conversions.ToBoolean(checkctrl.CheckState);
                    }

                    if (checkctrl.Name == "Modificar")
                    {
                        SatiModEmpleadosModificar = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Agregar")
                    {
                        SatiModEmpleadosAgregar = Conversions.ToBoolean(checkctrl.CheckState);
                    }



                }
            }


            foreach (Control ctrl in FlowCajas.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox checkctrl = (CheckBox)ctrl;
                    if (checkctrl.Name == "Acceder")
                    {
                        SatiModCajas = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Ver")
                    {
                        SatiModCajasVer = Conversions.ToBoolean(checkctrl.CheckState);
                    }

                    if (checkctrl.Name == "Modificar")
                    {
                        SatiModCajasModificar = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Agregar")
                    {
                        SatiModCajasAgregar = Conversions.ToBoolean(checkctrl.CheckState);
                    }



                }
            }


            foreach (Control ctrl in FlowLegal.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox checkctrl = (CheckBox)ctrl;
                    if (checkctrl.Name == "Acceder")
                    {
                        SatiModLegal = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Ver")
                    {
                        SatiModLegalVer = Conversions.ToBoolean(checkctrl.CheckState);
                    }

                    if (checkctrl.Name == "Gestionar")
                    {
                        SatiModLegalGestionar = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Crear Convenio")
                    {
                        SatiModLegalConvenio = Conversions.ToBoolean(checkctrl.CheckState);
                    }



                }
            }



            foreach (Control ctrl in FlowSac.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox checkctrl = (CheckBox)ctrl;
                    if (checkctrl.Name == "Acceso")
                    {
                        SacAcceso = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Consultar")
                    {
                        SacConsultaCredito = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Cobrar")
                    {
                        SacCobrarCredito = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Cobrar Comisión")
                    {
                        SacCobrarComision = Conversions.ToBoolean(checkctrl.CheckState);
                    }

                    if (checkctrl.Name == "Aplicar Descuento")
                    {
                        SacAplicarDescuento = Conversions.ToBoolean(checkctrl.CheckState);
                    }

                    if (checkctrl.Name == "Cancelar")
                    {
                        SacCancelarTicket = Conversions.ToBoolean(checkctrl.CheckState);
                    }

                    if (checkctrl.Name == "Consultar Ticket")
                    {
                        SacConsultarTicket = Conversions.ToBoolean(checkctrl.CheckState);
                    }


                    if (checkctrl.Name == "Detalle")
                    {
                        SacDetalleCaja = Conversions.ToBoolean(checkctrl.CheckState);
                    }

                    if (checkctrl.Name == "Reportes")
                    {
                        SacModReportes = Conversions.ToBoolean(checkctrl.CheckState);
                    }
                    if (checkctrl.Name == "Cobrar Extra")
                    {
                        SacCobrarExtra = Conversions.ToBoolean(checkctrl.CheckState);
                    }

                }
            }




            System.Data.OleDb.OleDbCommand comandoActPermisos;
            string consultaActPermisos;
            consultaActPermisos = "update PermisosGrupo set SatiAcceso = '" + SatiAcceso + @"' ,
SatiModUsuarios = '" + SatiModUsuarios + @"',
SatiModUsuariosVer = '" + SatiModUsuariosVer + @"',
SatiModUsuariosModificar = '" + SatiModUsuariosModificar + @"',
SatiModUsuariosAgregar ='" + SatiModUsuariosAgregar + @"' ,
SatiModGrupos = '" + SatiModGrupos + @"',
SatiModGruposVer = '" + SatiModGruposVer + @"',
SatiModGruposModificar = '" + SatiModGruposModificar + @"',
SatiModGruposAgregar = '" + SatiModGruposAgregar + @"' ,
SatiModCatalogos = '" + SatiModCatalogos + @"',
SatiModClientes ='" + SatiModClientes + @"' ,
SatiModClientesVer ='" + SatiModClientesVer + @"'  ,
SatiModClientesModificar ='" + SatiModClientesModificar + @"'  ,
SatiModClientesAgregar = '" + SatiModClientesAgregar + @"' ,
SatiModDocumentos = '" + SatiModDocumentos + @"' ,
SatiModDocumentosVer = '" + SatiModDocumentosVer + @"',
SatiModDocumentosModificar = '" + SatiModDocumentosModificar + @"' ,
SatiModDocumentosAgregar = '" + SatiModDocumentosAgregar + @"',
SatiModTipoDocumentos = '" + SatiModTipoDocumentos + @"',
SatiModTipoDocumentosVer = '" + SatiModTipoDocumentosVer + @"',
SatiModTipoDocumentosModificar = '" + SatiModTipoDocumentosModificar + @"',
SatiModTipoDocumentosAgregar = '" + SatiModTipoDocumentosAgregar + @"' ,
SatiModSolicitudes = '" + SatiModSolicitudes + @"',
SatiModSolicitudesVer = '" + SatiModSolicitudesVer + @"' ,
SatiModSolicitudesModificar = '" + SatiModSolicitudesModificar + @"',
SatiModSolicitudesAgregar ='" + SatiModSolicitudesAgregar + @"' ,
SatiModSolicitudesVerificar = '" + SatiModSolicitudesVerificar + @"',
SatiModSolicitudesAprobar = '" + SatiModSolicitudesAprobar + @"',
SatiModSolicitudesCancelar = '" + SatiModSolicitudesCancelar + @"',
SatiModSolicitudesAgregarRechazados = '" + SatiModSolicitudesAgregarRechazados + @"',
SatiModSolicitudesAgregarLegales = '" + SatiModSolicitudesAgregarLegales + @"',
SatiModCreditos = '" + SatiModCreditos + @"',
SatiModCreditosVer = '" + SatiModCreditosVer + @"',
SatiModCreditosCrearConvenio = '" + SatiModCreditosCrearConvenio + @"',
SatiModCreditosCrearReestructura = '" + SatiModCreditosCrearReestructura + @"',
SatiModCreditosCrearPromesa = '" + SatiModCreditosCrearPromesa + @"',
SatiModReportes = '" + SatiModReportes + @"',
SatiModTiposCreditos = '" + SatiModTiposCreditos + @"',
SatiModTiposCreditosVer = '" + SatiModTiposCreditosVer + @"',
SatiModTiposCreditosModificar = '" + SatiModTiposCreditosModificar + @"',
SatiModTiposCreditosAgregar = '" + SatiModTiposCreditosAgregar + @"',
SatiModEmpleados ='" + SatiModEmpleados + @"' ,
SatiModEmpleadosVer = '" + SatiModEmpleadosVer + @"',
SatiModEmpleadosModificar = '" + SatiModEmpleadosModificar + @"',
SatiModEmpleadosAgregar = '" + SatiModEmpleadosAgregar + @"',
SatiModCajas = '" + SatiModCajas + @"',
SatiModCajasVer = '" + SatiModCajasVer + @"',
SatiModCajasModificar = '" + SatiModCajasModificar + @"',
SatiModCajasAgregar = '" + SatiModCajasAgregar + @"',
SacAcceso = '" + SacAcceso + @"',
SacConsultaCredito = '" + SacConsultaCredito + @"',
SacCobrarCredito = '" + SacCobrarCredito + @"',
SacCobrarComision = '" + SacCobrarComision + @"',
SacAplicarDescuento = '" + SacAplicarDescuento + @"' ,
SacCancelarTicket = '" + SacCancelarTicket + @"',
SacDetalleCaja = '" + SacDetalleCaja + @"',
SacConsultarTicket = '" + SacConsultarTicket + @"',
SacModReportes = '" + SacModReportes + @"',
SacCobrarExtra = '" + SacCobrarExtra + @"',
SatiModLegal = '" + SatiModLegal + @"',
SatiModLegalVer = '" + SatiModLegalVer + @"',
SatiModLegalGestionar = '" + SatiModLegalGestionar + @"',
SatiModLegalConvenio = '" + SatiModLegalConvenio + "'    where idgrupo = '" + idgrupousuarios + "'";
            comandoActPermisos = new System.Data.OleDb.OleDbCommand();
            comandoActPermisos.Connection = Module1.conexionempresaR;
            comandoActPermisos.CommandText = consultaActPermisos;
            comandoActPermisos.ExecuteNonQuery();


        }

        private void BackgroundAplicarPermisos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Listo");
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Autorizacion.tipoAutorizacion = "SatiModGruposModificar";
            My.MyProject.Forms.Autorizacion.ShowDialog();
            if (Autorizado)
            {
                BackgroundAplicarPermisos.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("No fue autorizado");
            }

        }


    }
}