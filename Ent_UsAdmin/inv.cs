using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{
    public partial class inv
    {

        public servicios catservicios = new servicios();
        public impuestos catimpuestos = new impuestos();
        public string ventanapanel;
        public TiposDocumentosSolicitud catTiposDocumentos = new TiposDocumentosSolicitud();
        public CatTiposdeCredito CatTiposdecreditos = new CatTiposdeCredito();
        public CreditosActivos CatCreditosActivos = new CreditosActivos();
        public Cajas catCajas = new Cajas();
        public CreditosEnLegal catLegal = new CreditosEnLegal();
        public EmpeñosActivos catEmpeños = new EmpeñosActivos();
        public LegalTerminal catTerminal = new LegalTerminal();

        public inv()
        {
            InitializeComponent();
        }
        private void MonoFlat_Button2_Click(object sender, EventArgs e)
        {
            catimpuestos.Visible = false;
            catLegal.Visible = false;
            catTiposDocumentos.Visible = false;
            CatTiposdecreditos.Visible = false;
            CatCreditosActivos.Visible = false;
            catservicios.Visible = true;
            catservicios.TopLevel = false;
            catTerminal.Visible = false;
            catservicios.Size = Panel1.Size;
            catservicios.Location = new Point(0, 0);
            catservicios.WindowState = FormWindowState.Normal;
            catservicios.Visible = true;
            ventanapanel = "servicios";
            Panel1.Controls.Add(catservicios);
        }

        private void inv_SizeChanged(object sender, EventArgs e)
        {
            switch (ventanapanel ?? "")
            {
                case "servicios":
                    {
                        catservicios.Size = Panel1.Size;
                        break;
                    }
                case "impuestos":
                    {
                        catimpuestos.Size = Panel1.Size;
                        break;
                    }
                case "TiposDocumentos":
                    {
                        catTiposDocumentos.Size = Panel1.Size;
                        break;
                    }
                case "TiposDeCredito":
                    {
                        CatTiposdecreditos.Size = Panel1.Size;
                        break;
                    }
                case "CreditosActivos":
                    {
                        CatCreditosActivos.Size = Panel1.Size;
                        break;
                    }
                case "Cajas":
                    {
                        catCajas.Size = Panel1.Size;
                        break;
                    }
                case "Legal":
                    {
                        catLegal.Size = Panel1.Size;
                        break;
                    }
                case "Empeños":
                    {
                        catEmpeños.Size = Panel1.Size;
                        break;
                    }
                case "Terminal":
                    {
                        catTerminal.Size = Panel1.Size;
                        break;
                    }
            }


        }

        private void MonoFlat_Button3_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in Module1.dataPermisos.Rows)
            {
                if (Conversions.ToBoolean(row["SatiModClientes"]))
                {
                    catservicios.Visible = false;
                    catCajas.Visible = false;
                    catLegal.Visible = false;
                    catTiposDocumentos.Visible = false;
                    CatTiposdecreditos.Visible = false;
                    CatCreditosActivos.Visible = false;
                    catEmpeños.Visible = false;
                    catTerminal.Visible = false;
                    catimpuestos.Visible = true;

                    catimpuestos.TopLevel = false;

                    catimpuestos.Size = Panel1.Size;
                    catimpuestos.Location = new Point(0, 0);
                    catimpuestos.WindowState = FormWindowState.Normal;
                    catimpuestos.Visible = true;
                    ventanapanel = "impuestos";
                    Panel1.Controls.Add(catimpuestos);
                }
                else
                {

                }
            }

        }

        private void MonoFlat_Button4_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in Module1.dataPermisos.Rows)
            {
                if (Conversions.ToBoolean(row["SatiModTipoDocumentos"]))
                {
                    catimpuestos.Visible = false;
                    catCajas.Visible = false;
                    CatTiposdecreditos.Visible = false;
                    catservicios.Visible = false;
                    catLegal.Visible = false;
                    CatCreditosActivos.Visible = false;
                    catEmpeños.Visible = false;
                    catTerminal.Visible = false;
                    catTiposDocumentos.Visible = true;
                    catTiposDocumentos.TopLevel = false;

                    catTiposDocumentos.Size = Panel1.Size;
                    catTiposDocumentos.Location = new Point(0, 0);
                    catTiposDocumentos.WindowState = FormWindowState.Normal;
                    catTiposDocumentos.Visible = true;
                    ventanapanel = "TiposDocumentos";
                    Panel1.Controls.Add(catTiposDocumentos);
                }
                else
                {

                }
            }


        }

        private void MonoFlat_Button1_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in Module1.dataPermisos.Rows)
            {
                if (Conversions.ToBoolean(row["SatiModTiposCreditos"]))
                {
                    catimpuestos.Visible = false;
                    catCajas.Visible = false;
                    catLegal.Visible = false;
                    catservicios.Visible = false;
                    catTiposDocumentos.Visible = false;
                    CatCreditosActivos.Visible = false;
                    catEmpeños.Visible = false;
                    catTerminal.Visible = false;
                    CatTiposdecreditos.Visible = true;
                    CatTiposdecreditos.TopLevel = false;

                    CatTiposdecreditos.Size = Panel1.Size;
                    CatTiposdecreditos.Location = new Point(0, 0);
                    CatTiposdecreditos.WindowState = FormWindowState.Normal;
                    CatTiposdecreditos.Visible = true;
                    ventanapanel = "TiposDeCredito";
                    Panel1.Controls.Add(CatTiposdecreditos);
                }
                else
                {

                }
            }


        }

        private void MonoFlat_Button5_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in Module1.dataPermisos.Rows)
            {
                if (Conversions.ToBoolean(row["SatiModCreditos"]))
                {
                    catimpuestos.Visible = false;
                    CatTiposdecreditos.Visible = false;
                    catservicios.Visible = false;
                    catLegal.Visible = false;
                    catTiposDocumentos.Visible = false;
                    catEmpeños.Visible = false;
                    catCajas.Visible = false;
                    catTerminal.Visible = false;
                    CatCreditosActivos.Visible = true;
                    CatCreditosActivos.TopLevel = false;

                    CatCreditosActivos.Size = Panel1.Size;
                    CatCreditosActivos.Location = new Point(0, 0);
                    CatCreditosActivos.WindowState = FormWindowState.Normal;
                    CatCreditosActivos.Visible = true;
                    ventanapanel = "CreditosActivos";
                    Panel1.Controls.Add(CatCreditosActivos);
                }
                else
                {

                }
            }

        }

        private void MonoFlat_Button6_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in Module1.dataPermisos.Rows)
            {
                if (Conversions.ToBoolean(row["SatiModTiposCreditos"]))
                {
                    catimpuestos.Visible = false;
                    CatTiposdecreditos.Visible = false;
                    catservicios.Visible = false;
                    catEmpeños.Visible = false;
                    catTiposDocumentos.Visible = false;
                    CatCreditosActivos.Visible = false;
                    catLegal.Visible = false;
                    catTerminal.Visible = false;
                    catCajas.Visible = true;
                    catCajas.TopLevel = false;

                    catCajas.Size = Panel1.Size;
                    catCajas.Location = new Point(0, 0);
                    catCajas.WindowState = FormWindowState.Normal;
                    catCajas.Visible = true;
                    ventanapanel = "Cajas";
                    Panel1.Controls.Add(catCajas);
                }
                else
                {

                }
            }



        }

        private void MonoFlat_Button7_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in Module1.dataPermisos.Rows)
            {
                if (Conversions.ToBoolean(row["SatiModLegal"]))
                {
                    catimpuestos.Visible = false;
                    CatTiposdecreditos.Visible = false;
                    catservicios.Visible = false;
                    catTiposDocumentos.Visible = false;
                    CatCreditosActivos.Visible = false;
                    catEmpeños.Visible = false;
                    catCajas.Visible = false;
                    catTerminal.Visible = false;
                    catLegal.Visible = true;
                    catLegal.TopLevel = false;

                    catLegal.Size = Panel1.Size;
                    catLegal.Location = new Point(0, 0);
                    catLegal.WindowState = FormWindowState.Normal;
                    catLegal.Visible = true;
                    ventanapanel = "Legal";
                    Panel1.Controls.Add(catLegal);
                }
                else
                {

                }
            }


        }

        private void inv_Load(object sender, EventArgs e)
        {
            foreach (DataRow row in Module1.dataPermisos.Rows)
            {
                if (Conversions.ToBoolean(row["SatiModEmpeñosAgregarSolicitud"]))
                {
                    btnEmpeños.Visible = true;
                }
                else
                {
                    btnEmpeños.Visible = false;
                }
            }

        }

        private void btnEmpeños_Click(object sender, EventArgs e)
        {
            catimpuestos.Visible = false;
            CatTiposdecreditos.Visible = false;
            catservicios.Visible = false;
            catTiposDocumentos.Visible = false;
            CatCreditosActivos.Visible = false;
            catCajas.Visible = false;
            catLegal.Visible = false;
            catTerminal.Visible = false;
            catEmpeños.Visible = true;
            catEmpeños.TopLevel = false;

            catEmpeños.Size = Panel1.Size;
            catEmpeños.Location = new Point(0, 0);
            catEmpeños.WindowState = FormWindowState.Normal;
            catEmpeños.Visible = true;
            ventanapanel = "Empeños";
            Panel1.Controls.Add(catEmpeños);
        }

        private void btnLegalTerminal_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in Module1.dataPermisos.Rows)
            {
                if (Conversions.ToBoolean(row["SatiModLegal"]))
                {
                    catimpuestos.Visible = false;
                    CatTiposdecreditos.Visible = false;
                    catservicios.Visible = false;
                    catTiposDocumentos.Visible = false;
                    CatCreditosActivos.Visible = false;
                    catEmpeños.Visible = false;
                    catCajas.Visible = false;
                    catLegal.Visible = false;
                    catTerminal.Visible = true;
                    catTerminal.TopLevel = false;

                    catTerminal.Size = Panel1.Size;
                    catTerminal.Location = new Point(0, 0);
                    catTerminal.WindowState = FormWindowState.Normal;
                    catTerminal.Visible = true;
                    ventanapanel = "Terminal";
                    Panel1.Controls.Add(catTerminal);
                }
                else
                {

                }
            }
        }
    }
}