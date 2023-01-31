using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class Historia_de_Solicitud
    {
        public object idSolicitud;
        public bool esEmpeño;

        public Historia_de_Solicitud()
        {
            InitializeComponent();
        }

        private async void Historia_de_Solicitud_LoadAsync(object sender, EventArgs e)
        {
            switch (esEmpeño)
            {
                case false:
                    {

                        await Task.Factory.StartNew(() =>
                                {
                                    Module1.iniciarconexionempresa();
                                    SqlCommand comando;
                                    string consulta;
                                    SqlDataReader reader;
                                    consulta = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select format(fecha,'dd/MM/yy') as fecha,hora,observaciones from cronogramaSolicitud where idSolicitud = '", idSolicitud), "'"));
                                    comando = new SqlCommand();
                                    comando.Connection = Module1.conexionempresa;
                                    comando.CommandText = consulta;
                                    reader = comando.ExecuteReader();




                                    Invoke(new Action(() => { while (reader.Read()) { var botonempresa = new Bunifu.Framework.UI.BunifuFlatButton(); botonempresa.Normalcolor = Color.FromArgb(48, 55, 76); botonempresa.Iconimage = My.Resources.Resources.lconfia; botonempresa.Size = new Size(530, 93); botonempresa.Text = Conversions.ToString(Operators.ConcatenateObject("  " + reader["fecha"].ToString() + " " + "a las " + reader["hora"].ToString() + " - ", reader["observaciones"])); FlowLayoutPanel1.Controls.Add(botonempresa); } }));
                                });
                        break;
                    }
                case true:
                    {
                        await Task.Factory.StartNew(() =>
                                {
                                    Module1.iniciarconexionempresa();
                                    SqlCommand comando;
                                    string consulta;
                                    SqlDataReader reader;
                                    consulta = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select format(fecha,'dd/MM/yy') as fecha,hora,observaciones from cronogramaSolicitudEmpeño where idSolicitud = '", idSolicitud), "'"));
                                    comando = new SqlCommand();
                                    comando.Connection = Module1.conexionempresa;
                                    comando.CommandText = consulta;
                                    reader = comando.ExecuteReader();




                                    Invoke(new Action(() => { while (reader.Read()) { var botonempresa = new Bunifu.Framework.UI.BunifuFlatButton(); botonempresa.Normalcolor = Color.FromArgb(48, 55, 76); botonempresa.Iconimage = My.Resources.Resources.lconfia; botonempresa.Size = new Size(530, 93); botonempresa.Text = Conversions.ToString(Operators.ConcatenateObject("  " + reader["fecha"].ToString() + " " + "a las " + reader["hora"].ToString() + " - ", reader["observaciones"])); FlowLayoutPanel1.Controls.Add(botonempresa); } }));
                                });
                        break;
                    }
            }
        }
    }
}