using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class DocumentosNecesarios
    {
        public int idTipo;

        public DocumentosNecesarios()
        {
            InitializeComponent();
        }
        private void DocumentosNecesarios_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            try
            {
                Module1.iniciarconexion();
                string sql;
                SqlCommand comando;

                SqlDataReader milector;
                comando = new SqlCommand();

                comando.Connection = Module1.conexionempresa;
                sql = "select ajas.id,ajas.Nombre,ajas.tipo,case when (select idtipo from documentosnecesariostipo where idtipo = ajas.id and idtipocredito = '" + idTipo + @"')  IS null then '0' else 1 end
as Aplica from
(select * from TiposdeDocumentosSolicitud) ajas";
                comando.CommandText = sql;
                milector = comando.ExecuteReader();
                while (milector.Read())
                {
                    var checkTipo = new CheckBox();


                    checkTipo.Name = Conversions.ToString(milector["id"]);
                    checkTipo.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(milector["nombre"], " ("), milector["tipo"]), ")"));
                    checkTipo.CheckState = (CheckState)milector["Aplica"];
                    checkTipo.AutoSize = true;
                    // checkTipo.Tag = milector("ip")

                    FlowLayoutPanel1.Controls.Add(checkTipo);
                }
                milector.Close();
            }
            catch (Exception ex)
            {

            }
            // 

        }

        private void btn_Procesar_Click(object sender, EventArgs e)
        {
            Module1.iniciarconexionempresa();
            SqlCommand comandoAct;
            string consulta;
            foreach (Control ctrl in FlowLayoutPanel1.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox checkctrl = (CheckBox)ctrl;
                    switch (checkctrl.CheckState)
                    {
                        case CheckState.Checked:
                            {
                                comandoAct = new SqlCommand();
                                consulta = "IF NOT EXISTS((select * from DocumentosNecesariosTipo where idTipo = '" + checkctrl.Name + "' and idTipoCredito = '" + idTipo + @"' ))
BEGIN
insert into DocumentosNecesariosTipo values('" + checkctrl.Name + "','" + idTipo + "') end";
                                comandoAct.Connection = Module1.conexionempresa;
                                comandoAct.CommandText = consulta;
                                comandoAct.ExecuteNonQuery();
                                break;
                            }
                        case CheckState.Unchecked:
                            {
                                comandoAct = new SqlCommand();
                                consulta = "IF  EXISTS((select * from DocumentosNecesariosTipo where idTipo = '" + checkctrl.Name + "' and idTipoCredito = '" + idTipo + @"' ))
BEGIN
delete from DocumentosNecesariosTipo where idtipo = '" + checkctrl.Name + "' and idtipoCredito = '" + idTipo + "' end";
                                comandoAct.Connection = Module1.conexionempresa;
                                comandoAct.CommandText = consulta;
                                comandoAct.ExecuteNonQuery();
                                break;
                            }
                    }
                }
            }

        }
    }
}