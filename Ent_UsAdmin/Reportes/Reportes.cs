using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{
    public partial class Reportes
    {

        public servicios catservicios = new servicios();
        public impuestos catimpuestos = new impuestos();
        public string ventanapanel;
        public TiposDocumentosSolicitud catTiposDocumentos = new TiposDocumentosSolicitud();
        public CatTiposdeCredito CatTiposdecreditos = new CatTiposdeCredito();
        public CreditosActivos CatCreditosActivos = new CreditosActivos();
        public Cajas catCajas = new Cajas();


        public Desembolsos catDesembolsos = new Desembolsos();
        public Tickets CatTickets = new Tickets();
        public TicketsPfecha catTicketsDetalle = new TicketsPfecha();
        public CreditosEnMora catCreditosEnMora = new CreditosEnMora();
        public ValorCartera catValorCartera = new ValorCartera();
        public RetirosPorFecha catRetiros = new RetirosPorFecha();
        public PagosHoy catPagosHoy = new PagosHoy();
        public MoraPorNiveles CatMoraNiveles = new MoraPorNiveles();
        public ListadoMaestro CatListadoMaestro = new ListadoMaestro();
        public ReporteLegal CatReporteLegal = new ReporteLegal();
        public SolicitudPorFecha catSolicitudesFecha = new SolicitudPorFecha();
        public TicketsSinRecibir catTicketsSinCierre = new TicketsSinRecibir();
        public CierresPorFecha catCierresRecibidos = new CierresPorFecha();
        public EnviadosAlegal catEnviadosAlegal = new EnviadosAlegal();

        public Reportes()
        {
            InitializeComponent();
        }


        private void inv_SizeChanged(object sender, EventArgs e)
        {
            switch (ventanapanel ?? "")
            {
                case "Tickets":
                    {
                        CatTickets.Size = Panel1.Size;
                        break;
                    }
                case "Desembolsos":
                    {
                        catDesembolsos.Size = Panel1.Size;
                        break;
                    }
                case "TicketsDetalle":
                    {
                        catTicketsDetalle.Size = Panel1.Size;
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
                case "Mora":
                    {
                        catCreditosEnMora.Size = Panel1.Size;
                        break;
                    }
                case "ValorCartera":
                    {
                        catValorCartera.Size = Panel1.Size;
                        break;
                    }
                case "Retiros":
                    {
                        catRetiros.Size = Panel1.Size;
                        break;
                    }
                case "PagosHoy":
                    {
                        catPagosHoy.Size = Panel1.Size;
                        break;
                    }
                case "MoraNiveles":
                    {
                        CatMoraNiveles.Size = Panel1.Size;
                        break;
                    }
                case "ListadoMaestro":
                    {
                        CatMoraNiveles.Size = Panel1.Size;
                        break;
                    }
                case "ReporteLegal":
                    {
                        CatReporteLegal.Size = Panel1.Size;
                        break;
                    }
                case "SolicitudPorFecha":
                    {
                        catSolicitudesFecha.Size = Panel1.Size;
                        break;
                    }
                case "TicketsSinCierre":
                    {
                        catTicketsSinCierre.Size = Panel1.Size;
                        break;
                    }
                case "CierresRecibidos":
                    {
                        catCierresRecibidos.Size = Panel1.Size;
                        break;
                    }
                case "EnviadosAlegal":
                    {
                        catEnviadosAlegal.Size = Panel1.Size;
                        break;
                    }
            }
            Panel1.Size = Size;
            RadPanorama1.Size = Size;
            Panel1.Location = new Point(0, 0);
            RadPanorama1.Location = new Point(0, 0);

        }

        private void MonoFlat_Button3_Click(object sender, EventArgs e)
        {

            // catservicios.Visible = False
            // catCajas.Visible = False
            // catTiposDocumentos.Visible = False
            // CatTiposdecreditos.Visible = False
            CatTickets.Visible = false;
            catTicketsDetalle.Visible = false;
            catCreditosEnMora.Visible = false;
            CatMoraNiveles.Visible = false;
            catValorCartera.Visible = false;
            catPagosHoy.Visible = false;
            catRetiros.Visible = false;
            catEnviadosAlegal.Visible = false;
            catDesembolsos.Visible = true;
            CatListadoMaestro.Visible = false;
            catSolicitudesFecha.Visible = false;
            catDesembolsos.TopLevel = false;
            
            catDesembolsos.Size = Panel1.Size;
            catDesembolsos.Location = new Point(0, 0);
            catDesembolsos.WindowState = FormWindowState.Normal;
            catDesembolsos.Visible = true;
            ventanapanel = "Desembolsos";
            Panel1.Controls.Add(catDesembolsos);


        }




        private void MonoFlat_Button5_Click(object sender, EventArgs e)
        {

            // catimpuestos.Visible = False
            // CatTiposdecreditos.Visible = False
            // catservicios.Visible = False
            // catTiposDocumentos.Visible = False
            // catCajas.Visible = False
            catDesembolsos.Visible = false;
            catTicketsDetalle.Visible = false;
            catCreditosEnMora.Visible = false;
            catValorCartera.Visible = false;
            CatMoraNiveles.Visible = false;
            catPagosHoy.Visible = false;
            catRetiros.Visible = false;
            catEnviadosAlegal.Visible = false;
            CatTickets.Visible = true;
            CatTickets.TopLevel = false;
            CatListadoMaestro.Visible = false;
            catSolicitudesFecha.Visible = false;
            CatTickets.Size = Panel1.Size;
            CatTickets.Location = new Point(0, 0);
            CatTickets.WindowState = FormWindowState.Normal;
            CatTickets.Visible = true;
            ventanapanel = "Tickets";
            Panel1.Controls.Add(CatTickets);


        }



        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MonoFlat_Button1_Click(object sender, EventArgs e)
        {
            catDesembolsos.Visible = false;
            CatTickets.Visible = false;
            catCreditosEnMora.Visible = false;
            catValorCartera.Visible = false;
            catRetiros.Visible = false;
            CatMoraNiveles.Visible = false;
            catPagosHoy.Visible = false;
            catEnviadosAlegal.Visible = false;
            catTicketsDetalle.Visible = true;
            catTicketsDetalle.Visible = true;
            catTicketsDetalle.TopLevel = false;
            CatListadoMaestro.Visible = false;
            catSolicitudesFecha.Visible = false;
            catTicketsDetalle.Size = Panel1.Size;
            catTicketsDetalle.Location = new Point(0, 0);
            catTicketsDetalle.WindowState = FormWindowState.Normal;
            catTicketsDetalle.Visible = true;
            ventanapanel = "TicketsDetalle";
            Panel1.Controls.Add(catTicketsDetalle);
        }

        private void MonoFlat_Button2_Click(object sender, EventArgs e)
        {
            catDesembolsos.Visible = false;
            CatTickets.Visible = false;
            catTicketsDetalle.Visible = false;
            catValorCartera.Visible = false;
            catRetiros.Visible = false;
            CatMoraNiveles.Visible = false;
            catPagosHoy.Visible = false;
            catCreditosEnMora.Visible = true;
            catEnviadosAlegal.Visible = false;
            CatListadoMaestro.Visible = false;
            catSolicitudesFecha.Visible = false;
            catCreditosEnMora.Visible = true;
            catCreditosEnMora.Visible = true;
            catCreditosEnMora.TopLevel = false;

            catCreditosEnMora.Size = Panel1.Size;
            catCreditosEnMora.Location = new Point(0, 0);
            catCreditosEnMora.WindowState = FormWindowState.Normal;
            catCreditosEnMora.Visible = true;
            ventanapanel = "Mora";
            Panel1.Controls.Add(catCreditosEnMora);
        }

        private void MonoFlat_Button4_Click(object sender, EventArgs e)
        {
            catDesembolsos.Visible = false;
            CatTickets.Visible = false;
            catTicketsDetalle.Visible = false;
            catRetiros.Visible = false;
            catPagosHoy.Visible = false;
            catEnviadosAlegal.Visible = false;
            CatMoraNiveles.Visible = false;
            catValorCartera.Visible = true;
            catCreditosEnMora.Visible = false;
            CatListadoMaestro.Visible = false;
            catSolicitudesFecha.Visible = false;

            catValorCartera.Visible = true;
            catValorCartera.Visible = true;
            catValorCartera.TopLevel = false;

            catValorCartera.Size = Panel1.Size;
            catValorCartera.Location = new Point(0, 0);
            catValorCartera.WindowState = FormWindowState.Normal;
            catValorCartera.Visible = true;
            ventanapanel = "ValorCartera";
            Panel1.Controls.Add(catValorCartera);
        }

        private void MonoFlat_Button6_Click(object sender, EventArgs e)
        {
            catDesembolsos.Visible = false;
            CatTickets.Visible = false;
            catTicketsDetalle.Visible = false;
            catValorCartera.Visible = false;
            catEnviadosAlegal.Visible = false;
            catCreditosEnMora.Visible = false;
            catPagosHoy.Visible = false;
            CatMoraNiveles.Visible = false;
            catRetiros.Visible = true;
            catRetiros.Visible = true;
            catRetiros.Visible = true;
            catRetiros.TopLevel = false;
            CatListadoMaestro.Visible = false;
            catSolicitudesFecha.Visible = false;
            catRetiros.Size = Panel1.Size;
            catRetiros.Location = new Point(0, 0);
            catRetiros.WindowState = FormWindowState.Normal;
            catRetiros.Visible = true;
            ventanapanel = "Retiros";
            Panel1.Controls.Add(catRetiros);
        }

        private void MonoFlat_Button7_Click(object sender, EventArgs e)
        {
            catDesembolsos.Visible = false;
            CatTickets.Visible = false;
            catTicketsDetalle.Visible = false;
            catValorCartera.Visible = false;
            catCreditosEnMora.Visible = false;
            catRetiros.Visible = false;
            catEnviadosAlegal.Visible = false;
            CatMoraNiveles.Visible = false;
            catPagosHoy.Visible = true;
            catPagosHoy.Visible = true;
            catPagosHoy.Visible = true;
            catPagosHoy.TopLevel = false;
            CatListadoMaestro.Visible = false;
            catSolicitudesFecha.Visible = false;
            catPagosHoy.Size = Panel1.Size;
            catPagosHoy.Location = new Point(0, 0);
            catPagosHoy.WindowState = FormWindowState.Normal;
            catPagosHoy.Visible = true;
            ventanapanel = "PagosHoy";
            Panel1.Controls.Add(catPagosHoy);
        }

        private void MonoFlat_Button8_Click(object sender, EventArgs e)
        {
            catDesembolsos.Visible = false;
            CatTickets.Visible = false;
            catTicketsDetalle.Visible = false;
            catValorCartera.Visible = false;
            catCreditosEnMora.Visible = false;
            catRetiros.Visible = false;
            catEnviadosAlegal.Visible = false;
            catPagosHoy.Visible = false;
            CatListadoMaestro.Visible = false;
            catSolicitudesFecha.Visible = false;
            CatMoraNiveles.Visible = true;
            CatMoraNiveles.Visible = true;
            CatMoraNiveles.Visible = true;
            CatMoraNiveles.TopLevel = false;

            CatMoraNiveles.Size = Panel1.Size;
            CatMoraNiveles.Location = new Point(0, 0);
            CatMoraNiveles.WindowState = FormWindowState.Normal;
            CatMoraNiveles.Visible = true;
            ventanapanel = "MoraNiveles";
            Panel1.Controls.Add(CatMoraNiveles);
        }

        private void MonoFlat_Button9_Click(object sender, EventArgs e)
        {
            catDesembolsos.Visible = false;
            CatTickets.Visible = false;
            catTicketsDetalle.Visible = false;
            catValorCartera.Visible = false;
            catEnviadosAlegal.Visible = false;
            catCreditosEnMora.Visible = false;
            catRetiros.Visible = false;
            catPagosHoy.Visible = false;
            CatMoraNiveles.Visible = false;
            catSolicitudesFecha.Visible = false;
            CatListadoMaestro.Visible = true;
            CatListadoMaestro.TopLevel = false;

            CatListadoMaestro.Size = Panel1.Size;
            CatListadoMaestro.Location = new Point(0, 0);
            CatListadoMaestro.WindowState = FormWindowState.Normal;
            ventanapanel = "ListadoMaestro";
            Panel1.Controls.Add(CatListadoMaestro);
        }

        private void RadTileElement1_Click(object sender, EventArgs e)
        {


        }




        private void RadTileElement2_Click(object sender, EventArgs e)
        {
            catDesembolsos.Visible = false;
            CatTickets.Visible = false;
            catCreditosEnMora.Visible = false;
            catValorCartera.Visible = false;
            catRetiros.Visible = false;
            catEnviadosAlegal.Visible = false;
            catCierresRecibidos.Visible = false;
            CatMoraNiveles.Visible = false;
            catPagosHoy.Visible = false;
            catTicketsDetalle.Visible = true;
            catTicketsDetalle.Visible = true;
            catTicketsDetalle.TopLevel = false;
            CatListadoMaestro.Visible = false;
            CatReporteLegal.Visible = false;
            catSolicitudesFecha.Visible = false;
            catTicketsSinCierre.Visible = false;
            catTicketsDetalle.Size = Panel1.Size;
            catTicketsDetalle.Location = new Point(0, 0);
            catTicketsDetalle.WindowState = FormWindowState.Normal;
            catTicketsDetalle.Visible = true;
            ventanapanel = "TicketsDetalle";
            Panel1.Controls.Add(catTicketsDetalle);
            Panel1.Visible = true;

            RadPanorama1.Visible = false;
        }

        private void RadTileElement3_Click(object sender, EventArgs e)
        {

            // catservicios.Visible = False
            // catCajas.Visible = False
            // catTiposDocumentos.Visible = False
            // CatTiposdecreditos.Visible = False
            CatTickets.Visible = false;
            catTicketsDetalle.Visible = false;
            catCreditosEnMora.Visible = false;
            CatMoraNiveles.Visible = false;
            catValorCartera.Visible = false;
            catEnviadosAlegal.Visible = false;
            catCierresRecibidos.Visible = false;
            catPagosHoy.Visible = false;
            catRetiros.Visible = false;
            catDesembolsos.Visible = true;
            CatListadoMaestro.Visible = false;
            catTicketsSinCierre.Visible = false;
            CatReporteLegal.Visible = false;
            catSolicitudesFecha.Visible = false;
            catDesembolsos.TopLevel = false;

            catDesembolsos.Size = Panel1.Size;
            catDesembolsos.Location = new Point(0, 0);
            catDesembolsos.WindowState = FormWindowState.Normal;
            catDesembolsos.Visible = true;
            ventanapanel = "Desembolsos";
            Panel1.Controls.Add(catDesembolsos);
            Panel1.Visible = true;

            RadPanorama1.Visible = false;
        }




        private void RadTileElement6_Click(object sender, EventArgs e)
        {
            catDesembolsos.Visible = false;
            CatTickets.Visible = false;
            catTicketsDetalle.Visible = false;
            catValorCartera.Visible = false;
            catCreditosEnMora.Visible = false;
            catEnviadosAlegal.Visible = false;
            catRetiros.Visible = false;
            catCierresRecibidos.Visible = false;
            catPagosHoy.Visible = false;
            CatMoraNiveles.Visible = false;
            CatReporteLegal.Visible = false;
            catSolicitudesFecha.Visible = false;
            CatListadoMaestro.Visible = true;
            catTicketsSinCierre.Visible = false;
            CatListadoMaestro.TopLevel = false;

            CatListadoMaestro.Size = Panel1.Size;
            CatListadoMaestro.Location = new Point(0, 0);
            CatListadoMaestro.WindowState = FormWindowState.Normal;
            ventanapanel = "ListadoMaestro";
            Panel1.Controls.Add(CatListadoMaestro);
            Panel1.Visible = true;

            RadPanorama1.Visible = false;
        }



        private void RadTileElement8_Click(object sender, EventArgs e)
        {
            catDesembolsos.Visible = false;
            CatTickets.Visible = false;
            catTicketsDetalle.Visible = false;
            catValorCartera.Visible = false;
            catEnviadosAlegal.Visible = false;
            catCreditosEnMora.Visible = false;
            catPagosHoy.Visible = false;
            catCierresRecibidos.Visible = false;
            CatMoraNiveles.Visible = false;
            catRetiros.Visible = true;
            catRetiros.Visible = true;
            catRetiros.Visible = true;
            catRetiros.TopLevel = false;
            CatListadoMaestro.Visible = false;
            CatReporteLegal.Visible = false;
            catTicketsSinCierre.Visible = false;
            catSolicitudesFecha.Visible = false;
            catRetiros.Size = Panel1.Size;
            catRetiros.Location = new Point(0, 0);
            catRetiros.WindowState = FormWindowState.Normal;
            catRetiros.Visible = true;
            ventanapanel = "Retiros";
            Panel1.Controls.Add(catRetiros);
            Panel1.Visible = true;

            RadPanorama1.Visible = false;
        }

        private void RadLiveTileElement1_Click(object sender, EventArgs e)
        {

            // catimpuestos.Visible = False
            // CatTiposdecreditos.Visible = False
            // catservicios.Visible = False
            // catTiposDocumentos.Visible = False
            // catCajas.Visible = False
            catDesembolsos.Visible = false;
            catTicketsDetalle.Visible = false;
            catEnviadosAlegal.Visible = false;
            catCreditosEnMora.Visible = false;
            catValorCartera.Visible = false;
            CatMoraNiveles.Visible = false;
            catPagosHoy.Visible = false;
            catCierresRecibidos.Visible = false;
            catRetiros.Visible = false;
            CatTickets.Visible = true;
            catTicketsSinCierre.Visible = false;
            CatTickets.TopLevel = false;
            CatListadoMaestro.Visible = false;
            CatReporteLegal.Visible = false;
            catSolicitudesFecha.Visible = false;
            CatTickets.Size = Panel1.Size;
            CatTickets.Location = new Point(0, 0);
            CatTickets.WindowState = FormWindowState.Normal;
            CatTickets.Visible = true;
            ventanapanel = "Tickets";
            Panel1.Controls.Add(CatTickets);
            Panel1.Visible = true;

            RadPanorama1.Visible = false;

        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            RadLiveTileElement1.TransitionType = Telerik.WinControls.UI.ContentTransitionType.SlideLeft;
            foreach (DataRow row in Module1.dataPermisos.Rows)
            {
                if (Conversions.ToBoolean(row["SatiModLegalModificar"]))
                {
                    tile_group_legal.Enabled = true;
                    tile_group_legal.Visibility = Telerik.WinControls.ElementVisibility.Visible;
                }
                if (Conversions.ToBoolean(row["SacAcceso"]))
                {
                    tile_group_retiros.Visibility = Telerik.WinControls.ElementVisibility.Visible;
                }
            }
            RadPanorama1.Visible = true;
            RadPanorama1.BringToFront();
        }

        private void RadLiveTileElement2_Click(object sender, EventArgs e)
        {
            catDesembolsos.Visible = false;
            CatTickets.Visible = false;
            catTicketsDetalle.Visible = false;
            catValorCartera.Visible = false;
            catCreditosEnMora.Visible = false;
            catRetiros.Visible = false;
            catEnviadosAlegal.Visible = false;
            CatMoraNiveles.Visible = false;
            catPagosHoy.Visible = true;
            catPagosHoy.Visible = true;
            catPagosHoy.Visible = true;
            catPagosHoy.TopLevel = false;
            catCierresRecibidos.Visible = false;
            CatListadoMaestro.Visible = false;
            catTicketsSinCierre.Visible = false;
            CatReporteLegal.Visible = false;
            catSolicitudesFecha.Visible = false;
            catPagosHoy.Size = Panel1.Size;
            catPagosHoy.Location = new Point(0, 0);
            catPagosHoy.WindowState = FormWindowState.Normal;
            catPagosHoy.Visible = true;
            ventanapanel = "PagosHoy";
            Panel1.Controls.Add(catPagosHoy);
            Panel1.Visible = true;

            RadPanorama1.Visible = false;
        }

        private void RadLiveTileElement3_Click(object sender, EventArgs e)
        {
            catDesembolsos.Visible = false;
            CatTickets.Visible = false;
            catTicketsDetalle.Visible = false;
            catValorCartera.Visible = false;
            catEnviadosAlegal.Visible = false;
            catRetiros.Visible = false;
            CatMoraNiveles.Visible = false;
            catPagosHoy.Visible = false;
            catCreditosEnMora.Visible = true;
            CatListadoMaestro.Visible = false;
            CatReporteLegal.Visible = false;
            catSolicitudesFecha.Visible = false;
            catCreditosEnMora.Visible = true;
            catCierresRecibidos.Visible = false;
            catCreditosEnMora.Visible = true;
            catCreditosEnMora.TopLevel = false;
            catTicketsSinCierre.Visible = false;
            catCreditosEnMora.Size = Panel1.Size;
            catCreditosEnMora.Location = new Point(0, 0);
            catCreditosEnMora.WindowState = FormWindowState.Normal;
            catCreditosEnMora.Visible = true;
            ventanapanel = "Mora";
            Panel1.Controls.Add(catCreditosEnMora);
            Panel1.Visible = true;

            RadPanorama1.Visible = false;
        }

        private void RadLiveTileElement4_Click(object sender, EventArgs e)
        {
            catDesembolsos.Visible = false;
            CatTickets.Visible = false;
            catTicketsDetalle.Visible = false;
            catEnviadosAlegal.Visible = false;
            catRetiros.Visible = false;
            catPagosHoy.Visible = false;
            CatMoraNiveles.Visible = false;
            catValorCartera.Visible = true;
            catCreditosEnMora.Visible = false;
            CatListadoMaestro.Visible = false;
            CatReporteLegal.Visible = false;
            catSolicitudesFecha.Visible = false;
            catValorCartera.Visible = true;
            catValorCartera.Visible = true;
            catValorCartera.TopLevel = false;
            catCierresRecibidos.Visible = false;
            catTicketsSinCierre.Visible = false;
            catValorCartera.Size = Panel1.Size;
            catValorCartera.Location = new Point(0, 0);
            catValorCartera.WindowState = FormWindowState.Normal;
            catValorCartera.Visible = true;
            ventanapanel = "ValorCartera";
            Panel1.Controls.Add(catValorCartera);
            Panel1.Visible = true;

            RadPanorama1.Visible = false;
        }

        private void tile_btn_cartera_Click(object sender, EventArgs e)
        {
            catDesembolsos.Visible = false;
            CatTickets.Visible = false;
            catTicketsDetalle.Visible = false;
            catEnviadosAlegal.Visible = false;
            catValorCartera.Visible = false;
            catCreditosEnMora.Visible = false;
            catPagosHoy.Visible = false;
            CatMoraNiveles.Visible = false;
            catRetiros.Visible = false;
            catSolicitudesFecha.Visible = false;
            catCierresRecibidos.Visible = false;
            CatListadoMaestro.Visible = false;
            catTicketsSinCierre.Visible = false;
            CatReporteLegal.Visible = true;
            CatReporteLegal.Size = Panel1.Size;
            CatReporteLegal.Location = new Point(0, 0);
            CatReporteLegal.WindowState = FormWindowState.Normal;

            CatReporteLegal.TopLevel = false;
            ventanapanel = "ReporteLegal";
            Panel1.Controls.Add(CatReporteLegal);
            Panel1.Visible = true;

            RadPanorama1.Visible = false;
        }

        private void RadLiveTileElement5_Click(object sender, EventArgs e)
        {
            catDesembolsos.Visible = false;
            CatTickets.Visible = false;
            catTicketsDetalle.Visible = false;
            catValorCartera.Visible = false;
            catEnviadosAlegal.Visible = false;
            catCreditosEnMora.Visible = false;
            catPagosHoy.Visible = false;
            CatMoraNiveles.Visible = false;
            catRetiros.Visible = false;
            CatListadoMaestro.Visible = false;
            catCierresRecibidos.Visible = false;
            CatReporteLegal.Visible = false;
            catTicketsSinCierre.Visible = false;
            catSolicitudesFecha.Visible = true;
            catSolicitudesFecha.Size = Panel1.Size;
            catSolicitudesFecha.Location = new Point(0, 0);
            catSolicitudesFecha.WindowState = FormWindowState.Normal;

            catSolicitudesFecha.TopLevel = false;
            ventanapanel = "SolicitudPorFecha";
            Panel1.Controls.Add(catSolicitudesFecha);
            Panel1.Visible = true;

            RadPanorama1.Visible = false;
        }

        private void RadLiveTileElement7_Click(object sender, EventArgs e)
        {
            catDesembolsos.Visible = false;
            CatTickets.Visible = false;
            catTicketsDetalle.Visible = false;
            catValorCartera.Visible = false;
            catCreditosEnMora.Visible = false;
            catEnviadosAlegal.Visible = false;
            catPagosHoy.Visible = false;
            CatMoraNiveles.Visible = false;
            catRetiros.Visible = false;
            CatListadoMaestro.Visible = false;
            catCierresRecibidos.Visible = false;
            CatReporteLegal.Visible = false;
            catSolicitudesFecha.Visible = false;
            catTicketsSinCierre.Visible = true;
            catTicketsSinCierre.Size = Panel1.Size;
            catTicketsSinCierre.Location = new Point(0, 0);
            catTicketsSinCierre.WindowState = FormWindowState.Normal;

            catTicketsSinCierre.TopLevel = false;
            ventanapanel = "TicketsSinCierre";
            Panel1.Controls.Add(catTicketsSinCierre);
            Panel1.Visible = true;

            RadPanorama1.Visible = false;
        }

        private void RadTileElement4_Click(object sender, EventArgs e)
        {
            catDesembolsos.Visible = false;
            CatTickets.Visible = false;
            catTicketsDetalle.Visible = false;
            catEnviadosAlegal.Visible = false;
            catValorCartera.Visible = false;
            catCreditosEnMora.Visible = false;
            catPagosHoy.Visible = false;
            CatMoraNiveles.Visible = false;
            catRetiros.Visible = false;
            CatListadoMaestro.Visible = false;

            CatReporteLegal.Visible = false;
            catSolicitudesFecha.Visible = false;
            catTicketsSinCierre.Visible = false;
            catCierresRecibidos.Visible = true;
            catCierresRecibidos.Size = Panel1.Size;
            catCierresRecibidos.Location = new Point(0, 0);
            catCierresRecibidos.WindowState = FormWindowState.Normal;

            catCierresRecibidos.TopLevel = false;
            ventanapanel = "CierresRecibidos";
            Panel1.Controls.Add(catCierresRecibidos);
            Panel1.Visible = true;

            RadPanorama1.Visible = false;
        }

        private void radLiveTileElement8_Click(object sender, EventArgs e)
        {
            catDesembolsos.Visible = false;
            CatTickets.Visible = false;
            catTicketsDetalle.Visible = false;
          
            catValorCartera.Visible = false;
            catCreditosEnMora.Visible = false;
            catPagosHoy.Visible = false;
            CatMoraNiveles.Visible = false;
            catRetiros.Visible = false;
            CatListadoMaestro.Visible = false;

            CatReporteLegal.Visible = false;
            catSolicitudesFecha.Visible = false;
            catTicketsSinCierre.Visible = false;
            catCierresRecibidos.Visible = false;
            catEnviadosAlegal.Visible = true;
            catEnviadosAlegal.Size = Panel1.Size;
            catEnviadosAlegal.Location = new Point(0, 0);
            catEnviadosAlegal.WindowState = FormWindowState.Normal;

            catEnviadosAlegal.TopLevel = false;
            ventanapanel = "EnviadosAlegal";
            Panel1.Controls.Add(catEnviadosAlegal);
            Panel1.Visible = true;

            RadPanorama1.Visible = false;

        }
    }
}