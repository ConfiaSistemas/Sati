using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Xceed.Words.NET;

namespace ConfiaAdmin
{
    public partial class EntregarDocumentacion
    {
        public string NombreCreditoAentregar;
        public double MontoAentregar;
        public double PagareAentregar;
        public int integrantesAentregar;
        public double pagoIndividualAentregar;
        public int plazoAentregar;
        public double interesAentregar;
        public int idSolicitudAentregar;
        public int idCreditoAentregar;
        public int idClienteAentregar;
        public string NombreClienteAentregar;
        public string modalidadAentregar;
        private System.Data.DataTable dataIntegrantes;
        private SqlDataAdapter adapterIntegrantes;
        private string diaDepago;
        public string estadoCredito;
        private DateTime fechaCredito;
        private DateTime fechaPimerPago;
        private bool moto = false;
        private bool motoCapturada = false;
        public bool MotoActualizada = false;

        public EntregarDocumentacion()
        {
            InitializeComponent();
        }
        private void EntregarDocumentacion_Load(object sender, EventArgs e)
        {

            BunifuImageButton1.Image = null;
            CheckForIllegalCrossThreadCalls = false;
            BunifuImageButton1.AllowDrop = true;
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando datos";
            BackgroundWorker1.RunWorkerAsync();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            SqlCommand comando;
            string consulta;
            SqlDataReader reader;
            consulta = "select credito.Nombre,Monto,Pagare,Integrantes,PagoIndividual,credito.Plazo,credito.Interes,IdSolicitud,idCLiente,Clientes.Nombre + ' ' + Clientes.ApellidoPaterno + ' ' + Clientes.ApellidoMaterno as nombreCliente,tiposdecredito.modalidad,tiposdecredito.moto,Credito.estado from Credito inner join Clientes on Credito.IdCliente = Clientes.id inner join tiposdecredito on credito.tipo = tiposdecredito.id where credito.id = '" + idCreditoAentregar + "'";
            comando = new SqlCommand();
            comando.Connection = Module1.conexionempresa;
            comando.CommandText = consulta;
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                NombreCreditoAentregar = Conversions.ToString(reader["Nombre"]);
                MontoAentregar = Conversions.ToDouble(reader["Monto"]);
                PagareAentregar = Conversions.ToDouble(reader["Pagare"]);
                integrantesAentregar = Conversions.ToInteger(reader["Integrantes"]);
                pagoIndividualAentregar = Conversions.ToDouble(reader["PagoIndividual"]);
                plazoAentregar = Conversions.ToInteger(reader["Plazo"]);
                interesAentregar = Conversions.ToDouble(reader["Interes"]);
                idSolicitudAentregar = Conversions.ToInteger(reader["IdSolicitud"]);
                idClienteAentregar = Conversions.ToInteger(reader["idCliente"]);
                NombreClienteAentregar = Conversions.ToString(reader["nombreCliente"]);
                modalidadAentregar = Conversions.ToString(reader["modalidad"]);
                estadoCredito = Conversions.ToString(reader["Estado"]);
                moto = Conversions.ToBoolean(reader["moto"]);
            }
            reader.Close();

            SqlCommand comandoMotoCapturada;
            string consultaMotoCapturada;
            consultaMotoCapturada = "if exists(select Motocicletas.id from Motocicletas inner join credito on Motocicletas.idCredito= Credito.id inner join DocumentosCredito on Credito.id= DocumentosCredito.IdCredito where motocicletas.idCredito='" + idCreditoAentregar + @"' and documentoscredito.tipo = (select id from tiposdedocumentosSolicitud where nombre='Motocicleta'))
begin
select 1
end
else
select 0";
            comandoMotoCapturada = new SqlCommand();
            comandoMotoCapturada.Connection = Module1.conexionempresa;
            comandoMotoCapturada.CommandText = consultaMotoCapturada;
            motoCapturada = Conversions.ToBoolean(comandoMotoCapturada.ExecuteScalar());


            string consultaIntegrantes;
            consultaIntegrantes = "select IdCliente,Clientes.Nombre+' '+Clientes.ApellidoPaterno +' '+ Clientes.ApellidoMaterno as nombreCliente,montoAutorizado from DatosSolicitud inner join Clientes on DatosSolicitud.IdCliente = Clientes.id where datossolicitud.idsolicitud = '" + idSolicitudAentregar + "' and datossolicitud.estado = 'A'";
            adapterIntegrantes = new SqlDataAdapter(consultaIntegrantes, Module1.conexionempresa);
            dataIntegrantes = new System.Data.DataTable();
            adapterIntegrantes.Fill(dataIntegrantes);
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            lblNombre.Text = NombreCreditoAentregar;
            lblMonto.Text = Strings.FormatCurrency(MontoAentregar);
            My.MyProject.Forms.Cargando.Close();
            switch (estadoCredito ?? "")
            {
                case "E":
                    {
                        if (moto)
                        {
                            if (motoCapturada)
                            {
                                btnMoto.Visible = false;
                            }
                            else
                            {
                                btnMoto.Visible = true;
                            }
                        }
                        else
                        {
                            btnMoto.Visible = false;
                        }
                        BunifuThinButton22.Visible = true;
                        BunifuThinButton21.Visible = false;
                        btn_Procesar.Visible = false;
                        BunifuThinButton23.Visible = false;
                        BunifuImageButton1.Visible = false;
                        BunifuThinButton24.Visible = false;
                        labelimagen.Visible = false;
                        btn_activar.Visible = false;
                        break;
                    }

                case "P":
                    {
                        if (moto)
                        {
                            if (motoCapturada)
                            {
                                btnMoto.Visible = false;
                            }
                            else
                            {
                                btnMoto.Visible = true;
                            }
                        }
                        else
                        {
                            btnMoto.Visible = false;
                        }
                        BunifuThinButton22.Visible = false;
                        BunifuThinButton21.Visible = true;
                        btn_Procesar.Visible = true;
                        BunifuThinButton23.Visible = true;
                        BunifuImageButton1.Visible = true;
                        BunifuThinButton24.Visible = true;
                        labelimagen.Visible = true;
                        btn_activar.Visible = true;
                        break;
                    }
                case "A":
                    {
                        BunifuThinButton22.Visible = false;
                        BunifuThinButton21.Visible = true;
                        btn_Procesar.Visible = true;
                        BunifuThinButton24.Visible = true;
                        BunifuThinButton23.Visible = false;
                        BunifuImageButton1.Visible = false;
                        labelimagen.Visible = false;
                        btn_activar.Visible = false;
                        break;
                    }

                default:
                    {
                        BunifuThinButton22.Visible = false;
                        BunifuThinButton21.Visible = true;
                        btn_Procesar.Visible = true;
                        BunifuThinButton24.Visible = true;
                        BunifuThinButton23.Visible = false;
                        BunifuImageButton1.Visible = false;
                        labelimagen.Visible = false;
                        btn_activar.Visible = false;
                        break;
                    }

            }
        }


        private void BackgroundPagare_DoWork(object sender, DoWorkEventArgs e)
        {
            var NumeroLetra = new NumLetra();
            // Dim MSWord As New Word.Application
            double multas =0;
            double totalPagareCmultas;
            // Dim Documento As Word.Document
            // Dim fechaActual As Date
            // fechaActual = Now
            SqlCommand comandoFechaEntrega;
            string consultaFechaEntrega;
            SqlDataReader readerpagareEntrega;
            consultaFechaEntrega = @"select *,
case pagareconmultas.Modalidad when 'S' then
((DATEDIFF(day,FechaPrimerPago,dateadd(day,7,fechaultimopago))) * 50)
when 'Q' then
			--el primero del mes
			case when DATEDIFF(DAY,fechaultimopago,EOMONTH(fechaultimopago))>16
			then
				((DATEDIFF(day,FechaPrimerPago,dateadd(day,15,fechaultimopago))) * 50)
			else --El día de pago es el 16 del mes
				((DATEDIFF(day,FechaPrimerPago,dateadd(day,DATEDIFF(day,fechaultimopago,dateadd(day,1,eomonth(fechaultimopago))),fechaultimopago))) * 50)
				 
			end
 END as multas from
(select *,isnull((select top 1 fechapago from CalendarioNormal where id_credito = fechas.id order by FechaPago desc),'1900-01-01') as fechaultimopago from
(select credito.id,fechaEntrega,fechaprimerpago,TiposDeCredito.Modalidad from credito inner join TiposDeCredito on credito.Tipo = TiposDeCredito.id where credito.id = '" + idCreditoAentregar + "') fechas) pagareconmultas";
            DateTime fechaEntrega = DateTime.Now;
            comandoFechaEntrega = new SqlCommand();
            comandoFechaEntrega.Connection = Module1.conexionempresa;
            comandoFechaEntrega.CommandText = consultaFechaEntrega;
            readerpagareEntrega = comandoFechaEntrega.ExecuteReader();
            if (readerpagareEntrega.HasRows)
            {
                while (readerpagareEntrega.Read())
                {
                    fechaEntrega = Conversions.ToDate(readerpagareEntrega["fechaentrega"]);
                    multas = Conversions.ToDouble(readerpagareEntrega["multas"]);
                }
            }
            totalPagareCmultas = PagareAentregar + multas;

            FileSystem.FileCopy(@"C:\ConfiaAdmin\SATI\Pagare.docx", @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempPagare.docx");
            var documento = DocX.Load(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempPagare.docx");
            documento.ReplaceText("%%MontoTotal%%", Strings.FormatCurrency(totalPagareCmultas));
            documento.ReplaceText("%%MontoTotalLetra%%", NumeroLetra.Convertir(totalPagareCmultas.ToString(), true));
            documento.ReplaceText("%%Ciudad%%", Module1.CiudadEmpresa);
            documento.ReplaceText("%%Estado%%", Module1.EstadoEmpresa);
            documento.ReplaceText("%%Dia%%", Conversions.ToDate(fechaEntrega).ToString("dd"));
            documento.ReplaceText("%%Mes%%", Conversions.ToDate(fechaEntrega).ToString("MMMM"));
            documento.ReplaceText("%%Año%%", Conversions.ToDate(fechaEntrega).ToString("yyyy"));
            documento.ReplaceText("%%Diad%%", Conversions.ToDate(fechaEntrega.AddMonths(1)).ToString("dd"));
            documento.ReplaceText("%%Mesd%%", Conversions.ToDate(fechaEntrega.AddMonths(1)).ToString("MMMM"));
            documento.ReplaceText("%%Añod%%", Conversions.ToDate(fechaEntrega.AddMonths(1)).ToString("yyyy"));
            string integrantes = "";
            documento.ReplaceText("%%Responsable%%", NombreClienteAentregar);
            if (integrantesAentregar > 1)
            {

                foreach (DataRow row in dataIntegrantes.Rows)
                {
                    if ((row["nombreCliente"].ToString() ?? "") != (NombreClienteAentregar ?? ""))
                    {
                        integrantes = integrantes + row["nombreCliente"].ToString() + ",";
                    }

                }
            }
            else
            {

            }
            string linea = "__________________________________";
            string firmaintegrantes = "";
            documento.ReplaceText("%%Avales%%", integrantes);
            if (integrantesAentregar > 1)
            {
                foreach (DataRow row in dataIntegrantes.Rows)
                {
                    if ((row["nombreCliente"].ToString() ?? "") != (NombreClienteAentregar ?? ""))
                    {
                        // firmaintegrantes = firmaintegrantes & linea & Environment.NewLine & row("nombreCliente").ToString & Environment.NewLine
                        documento.InsertParagraph(linea).Alignment = Alignment.center;
                        documento.InsertParagraph(row["nombreCliente"].ToString()).Alignment = Alignment.center;
                    }

                }
            }

            documento.InsertParagraph(firmaintegrantes).Alignment = Alignment.center;

            documento.Save();
            documento.Dispose();


        }

        private void btn_Procesar_Click(object sender, EventArgs e)
        {

            BackgroundPagare.RunWorkerAsync();
        }

        private void BackgroundPagare_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.VistaPreviaDocumento.ruta = @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempPagare.docx";
            My.MyProject.Forms.VistaPreviaDocumento.Show();
            // BackgroundCalendario.RunWorkerAsync()
        }

        private void BackgroundEntrega_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            var ci = CultureInfo.InvariantCulture;
            SqlCommand comandoDia;
            string consultaDia;
            string diaCreditoAnterior;
            var diaDeHoy = DateTime.Now;
            var Numerodiahoy = ci.Calendar.GetDayOfWeek(diaDeHoy);
            int numeroDiaMes = diaDeHoy.Day;
            DateTime primerPago = DateTime.Now ;
            consultaDia = "select isnull((select top 1 DATENAME(dw,fechaPrimerPago) from Credito inner join tiposdecredito on credito.tipo = tiposdecredito.id where FechaEntrega is not null and tiposdecredito.modalidad = 'S' order by credito.id desc),0)";
            comandoDia = new SqlCommand();
            comandoDia.Connection = Module1.conexionempresa;
            comandoDia.CommandText = consultaDia;
            diaCreditoAnterior = Conversions.ToString(comandoDia.ExecuteScalar());

            switch (modalidadAentregar ?? "")
            {
                case "S":
                    {
                        switch (diaCreditoAnterior ?? "")
                        {
                            case "0":
                                {
                                    diaDepago = "Lunes";
                                    switch (Numerodiahoy)
                                    {
                                        case 0:
                                            {
                                                primerPago = diaDeHoy.AddDays(1d);
                                                break;
                                            }

                                        case (DayOfWeek)1:
                                            {
                                                primerPago = diaDeHoy.AddDays(7d);
                                                break;
                                            }

                                        case (DayOfWeek)2:
                                            {
                                                primerPago = diaDeHoy.AddDays(6d);
                                                break;
                                            }

                                        case (DayOfWeek)3:
                                            {
                                                primerPago = diaDeHoy.AddDays(5d);
                                                break;
                                            }

                                        case (DayOfWeek)4:
                                            {
                                                primerPago = diaDeHoy.AddDays(4d);
                                                break;
                                            }

                                        case (DayOfWeek)5:
                                            {
                                                primerPago = diaDeHoy.AddDays(3d);
                                                break;
                                            }

                                        case (DayOfWeek)6:
                                            {
                                                primerPago = diaDeHoy.AddDays(2d);
                                                break;
                                            }
                                    }

                                    break;
                                }
                            case "Lunes":
                                {
                                    diaDepago = "Martes";
                                    switch (Numerodiahoy)
                                    {
                                        case 0:
                                            {
                                                primerPago = diaDeHoy.AddDays(2d);
                                                break;
                                            }

                                        case (DayOfWeek)1:
                                            {
                                                primerPago = diaDeHoy.AddDays(8d);
                                                break;
                                            }

                                        case (DayOfWeek)2:
                                            {
                                                primerPago = diaDeHoy.AddDays(7d);
                                                break;
                                            }

                                        case (DayOfWeek)3:
                                            {
                                                primerPago = diaDeHoy.AddDays(6d);
                                                break;
                                            }

                                        case (DayOfWeek)4:
                                            {
                                                primerPago = diaDeHoy.AddDays(5d);
                                                break;
                                            }

                                        case (DayOfWeek)5:
                                            {
                                                primerPago = diaDeHoy.AddDays(4d);
                                                break;
                                            }

                                        case (DayOfWeek)6:
                                            {
                                                primerPago = diaDeHoy.AddDays(3d);
                                                break;
                                            }
                                    }

                                    break;
                                }
                            case "Martes":
                                {
                                    diaDepago = "Lunes";
                                    switch (Numerodiahoy)
                                    {
                                        case 0:
                                            {
                                                primerPago = diaDeHoy.AddDays(1d);
                                                break;
                                            }

                                        case (DayOfWeek)1:
                                            {
                                                primerPago = diaDeHoy.AddDays(7d);
                                                break;
                                            }

                                        case (DayOfWeek)2:
                                            {
                                                primerPago = diaDeHoy.AddDays(6d);
                                                break;
                                            }

                                        case (DayOfWeek)3:
                                            {
                                                primerPago = diaDeHoy.AddDays(5d);
                                                break;
                                            }

                                        case (DayOfWeek)4:
                                            {
                                                primerPago = diaDeHoy.AddDays(4d);
                                                break;
                                            }

                                        case (DayOfWeek)5:
                                            {
                                                primerPago = diaDeHoy.AddDays(3d);
                                                break;
                                            }

                                        case (DayOfWeek)6:
                                            {
                                                primerPago = diaDeHoy.AddDays(2d);
                                                break;
                                            }
                                    }

                                    break;
                                }
                        }
                        SqlCommand comandoActCredito;
                        string consultaActCredito;
                        DateTime fechaPago;
                        consultaActCredito = "update credito set fechaentrega = '" + diaDeHoy.ToString("yyyy-MM-dd") + "',fechaprimerpago = '" + primerPago.ToString("yyyy-MM-dd") + "', estado = 'P',DiaDePago = '" + diaDepago + "' where id = '" + idCreditoAentregar + "'";
                        comandoActCredito = new SqlCommand();
                        comandoActCredito.Connection = Module1.conexionempresa;
                        comandoActCredito.CommandText = consultaActCredito;
                        comandoActCredito.ExecuteNonQuery();

                        for (int i = 0, loopTo = plazoAentregar - 1; i <= loopTo; i++)
                        {
                            SqlCommand comandoCalendario;
                            string consultaCalendario;
                            fechaPago = primerPago.AddDays(i * 7);
                            consultaCalendario = "insert into CalendarioNormal values('" + fechaPago.ToString("yyyy-MM-dd") + "','" + pagoIndividualAentregar + "',0,'" + pagoIndividualAentregar + "',0,'" + (i + 1) + "','" + idCreditoAentregar + "','P',0,'')";
                            comandoCalendario = new SqlCommand();
                            comandoCalendario.Connection = Module1.conexionempresa;
                            comandoCalendario.CommandText = consultaCalendario;
                            comandoCalendario.ExecuteNonQuery();

                        }

                        break;
                    }

                case "Q":
                    {
                        // MessageBox.Show("Hola")
                        if (numeroDiaMes >= 9 & numeroDiaMes <= 23)
                        {
                            if (diaDeHoy.Month == 12)
                            {
                                primerPago = Convert.ToDateTime(diaDeHoy.AddYears(1).Year.ToString() + "-" + diaDeHoy.AddMonths(1).Month.ToString() + "-" + "01");
                            }
                            else
                            {
                                primerPago = Convert.ToDateTime(diaDeHoy.Year.ToString() + "-" + diaDeHoy.AddMonths(1).Month.ToString() + "-" + "01");
                            }
                        }
                        else if (numeroDiaMes >= 1 & numeroDiaMes <= 8)
                        {
                            primerPago = Convert.ToDateTime(diaDeHoy.Year.ToString() + "-" + diaDeHoy.Month.ToString() + "-" + "16");
                        }
                        else if (numeroDiaMes >= 24 & numeroDiaMes <= DateTime.DaysInMonth(diaDeHoy.Year, diaDeHoy.Month))
                        {
                            if (diaDeHoy.Month == 12)
                            {
                                primerPago = Convert.ToDateTime(diaDeHoy.AddYears(1).Year.ToString() + "-" + diaDeHoy.AddMonths(1).Month.ToString() + "-" + "16");
                            }
                            else
                            {
                                primerPago = Convert.ToDateTime(diaDeHoy.Year.ToString() + "-" + diaDeHoy.AddMonths(1).Month.ToString() + "-" + "16");
                            }

                        }
                        SqlCommand comandoActCredito;
                        string consultaActCredito;
                        // Dim fechaPago As Date
                        consultaActCredito = "update credito set fechaentrega = '" + diaDeHoy.ToString("yyyy-MM-dd") + "',fechaprimerpago = '" + primerPago.ToString("yyyy-MM-dd") + "', estado = 'P',DiaDePago = '" + diaDepago + "' where id = '" + idCreditoAentregar + "'";
                        comandoActCredito = new SqlCommand();
                        comandoActCredito.Connection = Module1.conexionempresa;
                        comandoActCredito.CommandText = consultaActCredito;
                        comandoActCredito.ExecuteNonQuery();
                        DateTime fechapago;
                        for (int i = 0, loopTo1 = plazoAentregar - 1; i <= loopTo1; i++)
                        {
                            SqlCommand comandoCalendario;
                            string consultaCalendario;
                            if (primerPago.Day == 16)
                            {
                                fechapago = primerPago;
                                consultaCalendario = "insert into CalendarioNormal values('" + fechapago.ToString("yyyy-MM-dd") + "','" + pagoIndividualAentregar + "',0,'" + pagoIndividualAentregar + "',0,'" + (i + 1) + "','" + idCreditoAentregar + "','P',0,'')";
                                comandoCalendario = new SqlCommand();
                                comandoCalendario.Connection = Module1.conexionempresa;
                                comandoCalendario.CommandText = consultaCalendario;
                                comandoCalendario.ExecuteNonQuery();
                                // dtdatos.Rows.Add(fechapago.ToString("yyyy-MM-dd"), MontoPago)
                                if (primerPago.Month == 12)
                                {
                                    primerPago = Convert.ToDateTime(primerPago.AddYears(1).Year.ToString() + "-" + primerPago.AddMonths(1).Month.ToString() + "-" + "01");
                                }
                                else
                                {
                                    primerPago = Convert.ToDateTime(primerPago.Year.ToString() + "-" + primerPago.AddMonths(1).Month.ToString() + "-" + "01");
                                }
                            }

                            // deuda = deuda - MontoPago
                            else
                            {
                                fechapago = primerPago;
                                consultaCalendario = "insert into CalendarioNormal values('" + fechapago.ToString("yyyy-MM-dd") + "','" + pagoIndividualAentregar + "',0,'" + pagoIndividualAentregar + "',0,'" + (i + 1) + "','" + idCreditoAentregar + "','P',0,'')";
                                comandoCalendario = new SqlCommand();
                                comandoCalendario.Connection = Module1.conexionempresa;
                                comandoCalendario.CommandText = consultaCalendario;
                                comandoCalendario.ExecuteNonQuery();
                                // dtdatos.Rows.Add(fechapago.ToString("yyyy-MM-dd"), MontoPago)
                                primerPago = Convert.ToDateTime(primerPago.Year.ToString() + "-" + primerPago.Month.ToString() + "-" + "16");
                                // deuda = deuda - MontoPago
                            }
                        }

                        break;
                    }


            }


        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            BackgroundEntrega.RunWorkerAsync();
        }

        private void BackgroundEntrega_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando datos";
            BackgroundWorker1.RunWorkerAsync();
            // BackgroundPagare.RunWorkerAsync()

        }

        private void dataTableToWord(System.Data.DataTable dt)
        {
            Microsoft.Office.Interop.Word.Application Word;
            Microsoft.Office.Interop.Word.Document Doc;
            Microsoft.Office.Interop.Word.Table Table;
            Range Rng;
            Microsoft.Office.Interop.Word.Paragraph Prf1;
            Microsoft.Office.Interop.Word.Paragraph Prf2;
            Microsoft.Office.Interop.Word.Paragraph Prf3;

            Word = (Microsoft.Office.Interop.Word.Application)Interaction.CreateObject("Word.Application");

            FileSystem.FileCopy(@"C:\ConfiaAdmin\SATI\Calendario.docx", @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendario.docx");
            object argFileName = @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendario.docx";
            Doc = Word.Documents.Open(ref argFileName);
            int NCol = dt.Columns.Count;
            int NRow = dt.Rows.Count;
            // alternativo

            object argIndex = @"\endofdoc";
            Table = Doc.Tables.Add(Doc.Bookmarks[ref argIndex].Range, dt.Rows.Count + 1, dt.Columns.Count);

            // Agregando Los Campos De La Grilla
            for (int i = 1, loopTo = NCol; i <= loopTo; i++)
                Table.Cell(1, i).Range.Text = dt.Columns[i - 1].ColumnName.ToString();
            // Agregando Los Registros A La Tabla
            for (int Fila = 0, loopTo1 = NRow - 1; Fila <= loopTo1; Fila++)
            {
                for (int Col = 0, loopTo2 = NCol - 1; Col <= loopTo2; Col++)
                {
                    if (!ReferenceEquals(dt.Rows[NRow - 1][Col].ToString(), DBNull.Value))
                    {
                        Table.Cell(Fila + 2, Col + 1).Range.Text = dt.Rows[Fila][Col].ToString();
                    }
                }
                // Incremento

            }
            // Negrita y Kursiva Para Los Nombres De Los Campos
            Table.Rows[1].Range.Font.Bold = Conversions.ToInteger(true);
            Table.Rows[1].Range.Font.Italic = Conversions.ToInteger(false);
            for (int i = 1, loopTo3 = Table.Rows.Count; i <= loopTo3; i++)
                Table.Rows[i].Range.Font.Size = 10f;


            // Boder De La Tabla
            Table.Borders.InsideLineStyle = WdLineStyle.wdLineStyleEngrave3D;
            Table.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleEngrave3D;
            Table.Borders.InsideColor = WdColor.wdColorBlack;
            object argIndex1 = @"\endofdoc";
            Rng = Doc.Bookmarks[ref argIndex1].Range;
            Rng.InsertParagraphAfter();

            Doc.Save();
            Doc.Close();
            // Word = Nothing
            Word.Application.Quit();


        }
        private void dataTableToWordGrupal(System.Data.DataTable dt)
        {
            Microsoft.Office.Interop.Word.Application Word;
            Microsoft.Office.Interop.Word.Document Doc;
            Microsoft.Office.Interop.Word.Table Table;
            Range Rng;
            Microsoft.Office.Interop.Word.Paragraph Prf1;
            Microsoft.Office.Interop.Word.Paragraph Prf2;
            Microsoft.Office.Interop.Word.Paragraph Prf3;

            Word = (Microsoft.Office.Interop.Word.Application)Interaction.CreateObject("Word.Application");

            FileSystem.FileCopy(@"C:\ConfiaAdmin\SATI\CalendarioGrupal.docx", @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendarioGrupal.docx");
            object argFileName = @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendarioGrupal.docx";
            Doc = Word.Documents.Open(ref argFileName);
            int NCol = dt.Columns.Count;
            int NRow = dt.Rows.Count;
            // alternativo

            object argIndex = @"\endofdoc";
            Table = Doc.Tables.Add(Doc.Bookmarks[ref argIndex].Range, dt.Rows.Count + 1, dt.Columns.Count);

            // Agregando Los Campos De La Grilla
            for (int i = 1, loopTo = NCol; i <= loopTo; i++)

                Table.Cell(1, i).Range.Text = dt.Columns[i - 1].ColumnName.ToString();
            // Agregando Los Registros A La Tabla
            for (int Fila = 0, loopTo1 = NRow - 1; Fila <= loopTo1; Fila++)
            {
                for (int Col = 0, loopTo2 = NCol - 1; Col <= loopTo2; Col++)
                {
                    if (!ReferenceEquals(dt.Rows[NRow - 1][Col].ToString(), DBNull.Value))
                    {
                        Table.Cell(Fila + 2, Col + 1).Range.Text = dt.Rows[Fila][Col].ToString();

                    }
                }
                // Incremento

            }
            // Negrita y Kursiva Para Los Nombres De Los Campos
            Table.Rows[1].Range.Font.Bold = Conversions.ToInteger(true);
            Table.Rows[1].Range.Font.Italic = Conversions.ToInteger(false);
            for (int i = 1, loopTo3 = Table.Rows.Count; i <= loopTo3; i++)
                Table.Rows[i].Range.Font.Size = 14f;
            Table.AllowAutoFit = true;
            Table.AutoFitBehavior(WdAutoFitBehavior.wdAutoFitContent);

            // Boder De La Tabla
            Table.Borders.InsideLineStyle = WdLineStyle.wdLineStyleEngrave3D;
            Table.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleEngrave3D;
            Table.Borders.InsideColor = WdColor.wdColorBlack;
            object argIndex1 = @"\endofdoc";
            Rng = Doc.Bookmarks[ref argIndex1].Range;
            Rng.InsertParagraphAfter();

            Doc.Save();
            Doc.Close();
            // Word = Nothing
            Word.Application.Quit();


        }

        private void BackgroundCalendario_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();

            SqlCommand comandoFechaEntrega;
            string consultaFechaEntrega;
            consultaFechaEntrega = "Select fechaEntrega,fechaPrimerPago,DiaDePago from credito where id = '" + idCreditoAentregar + "'";
            SqlDataReader readerFechaEntrega;
            comandoFechaEntrega = new SqlCommand();
            comandoFechaEntrega.Connection = Module1.conexionempresa;
            comandoFechaEntrega.CommandText = consultaFechaEntrega;
            readerFechaEntrega = comandoFechaEntrega.ExecuteReader();
            while (readerFechaEntrega.Read())
            {
                fechaCredito = Conversions.ToDate(readerFechaEntrega["FechaEntrega"]);
                fechaPimerPago = Conversions.ToDate(readerFechaEntrega["fechaPrimerPago"]);
                diaDepago = Conversions.ToString(readerFechaEntrega["DiaDePago"]);
            }
            readerFechaEntrega.Close();
            System.Data.DataTable dataCalendario;
            SqlDataAdapter adapterCalendario;
            string consultaCalendario;

            consultaCalendario = "select format(Fechapago,'dd/MM/yyyy') as 'Fecha de pago',npago as 'Número de pago',format(Monto,'C','es-mx') as Monto from calendarioNormal where id_credito = '" + idCreditoAentregar + "'";
            adapterCalendario = new SqlDataAdapter(consultaCalendario, Module1.conexionempresa);
            dataCalendario = new System.Data.DataTable();
            adapterCalendario.Fill(dataCalendario);
            dataTableToWord(dataCalendario);

        }

        private void BackgroundEntrega_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void BackgroundCalendario_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var NumeroLetra = new NumLetra();
            // Dim MSWord As New Word.Application
            // Dim Documento As Word.Document
            // Dim fechaActual As Date
            // fechaActual = Now

            // FileCopy("C:\ConfiaAdmin\SATI\Pagare.docx", "C:\ConfiaAdmin\SATI\TEMPDOCS\TempPagare.docx")
            var documento = DocX.Load(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendario.docx");
            documento.ReplaceText("%%FECHACREDITO%%", fechaCredito.ToString("dd/MM/yyyy"));
            documento.ReplaceText("%%NOMBRECREDITO%%", NombreCreditoAentregar);
            documento.ReplaceText("%%NOMBRERESPONSABLE%%", NombreClienteAentregar);
            documento.ReplaceText("%%IDCREDITO%%", idCreditoAentregar.ToString());
            documento.ReplaceText("%%DIAPAGO%%", diaDepago);

            string para = @"Por medio del presente he sido debidamente notificado respecto a el pago diario, en caso de incumplimiento que asciende a la cantidad de $ 50.00 (CINCUENTA PESOS 00/100 M.N.). La cual se pagará de forma obligatoria juntamente con los pagos amortizados del calendario anteriormente descritos.


___________________________________________
Acepto
PRÉSTAMOS CONFIA S.A. DE C.V.
TEL.:" + Module1.telEmpresa + @"
HORARIOS: Lunes a Viernes 09:00 a.m. a 02:00 p.m. / 04:00 p.m. a 07:00 p.m.
Sábado 09:00 a.m. a 02:00 p.m.";
            documento.InsertParagraph(para).Alignment = Alignment.center;
            documento.Save();
            documento.Dispose();
            // VistaPreviaDocumento.ruta = "C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendario.docx"
            // VistaPreviaDocumento.Show()
            var spDoc = new Spire.Doc.Document();
            spDoc.LoadFromFile(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendario.docx");
            var dialog = new PrintPreviewDialog();

            // dialog.AllowCurrentPage = True
            // dialog.AllowSomePages = True
            // dialog.UseEXDialog = True
            My.MyProject.Forms.Cargando.Close();

            try
            {
                // spDoc.PrintDialog = dialog.
                spDoc.PrintDocument.PrinterSettings.PrinterName = Module1.ImpresoraPredeterminada;

                dialog.Document = spDoc.PrintDocument;
                dialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void BunifuImageButton1_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {

                   // string strRutaArchivoImagen;

                    int i;

                    // Asignamos la primera posición del array de ruta de archivos a la variable de tipo string

                    // declarada anteriormente ya que en este caso sólo mostraremos una imagen en el control.
                    var strRutaArchivoImagen = e.Data.GetData(DataFormats.Text) as string;
                    // strRutaArchivoImagen = Conversions.ToString(e.Data.GetData(DataFormats.FileDrop)((object)0));

                    // La cargamos al control

                    BunifuImageButton1.Load(strRutaArchivoImagen);
                }
                labelimagen.Visible = false;
            }
            catch (ArgumentException ex)
            {
                Interaction.MsgBox("Archivo no válido", MsgBoxStyle.Exclamation);
            }

        }

        private void BunifuImageButton1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {

                // Los archivos son externos a nuestra aplicación por lo que de indicaremos All ya que dará lo mismo.

                e.Effect = DragDropEffects.All;

            }

        }


        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog();
            string nombre;
            openFileDialog1.Filter = "Imágenes (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg;*.jpeg;*.png";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.ShowDialog();
            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                nombre = openFileDialog1.FileName;
                BunifuImageButton1.Image = System.Drawing.Image.FromFile(nombre);
                labelimagen.Visible = false;
            }

            else
            {
                MessageBox.Show("No se seleccionó ningún archivo");

            }
        }

        private void BunifuThinButton23_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.webcamCredito.Show();
        }

        private void btn_activar_Click(object sender, EventArgs e)
        {
            if (moto)
            {
                if (motoCapturada)
                {
                    if (BunifuImageButton1.Image != null)
                    {
                        My.MyProject.Forms.Cargando.Show();
                        My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Activando Crédito";
                        BackgroundActivar.RunWorkerAsync();
                    }
                    else
                    {
                        MessageBox.Show("Para activar el crédito es necesario cargar una imagen del cliente");
                    }
                }
                else
                {
                    MessageBox.Show("Éste crédito contiene una motocicleta que no ha sido capturada, captúrala para proseguir");
                }
            }

            else if (BunifuImageButton1.Image != null)
            {
                My.MyProject.Forms.Cargando.Show();
                My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Activando Crédito";
                BackgroundActivar.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Para activar el crédito es necesario cargar una imagen del cliente");

            }



        }

        private void BackgroundActivar_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();

            SqlCommand comandoDocumento;
            string consultaDocumento;
            Bitmap imagen = BunifuImageButton1.Image as Bitmap;
            var NuevaImagen = ImagenComprimida(imagen);
            consultaDocumento = "insert into DocumentosCredito values('" + idCreditoAentregar + "','4',@Documento)";
            var imgDocumento = new SqlParameter("@Documento", SqlDbType.Image);
            var msImgDocumento = new MemoryStream();
            NuevaImagen.Save(msImgDocumento, ImageFormat.Jpeg);
            imgDocumento.Value = msImgDocumento.GetBuffer();
            comandoDocumento = new SqlCommand();
            comandoDocumento.Connection = Module1.conexionempresa;
            comandoDocumento.CommandText = consultaDocumento;
            comandoDocumento.Parameters.Add(imgDocumento);
            comandoDocumento.ExecuteNonQuery();

            SqlCommand comandoActCredito;
            string consultaActCredito;
            consultaActCredito = "Update credito set estado = 'A' where id = '" + idCreditoAentregar + "'";
            comandoActCredito = new SqlCommand();
            comandoActCredito.Connection = Module1.conexionempresa;
            comandoActCredito.CommandText = consultaActCredito;
            comandoActCredito.ExecuteNonQuery();



        }
        private Bitmap ImagenComprimida(Bitmap bmp)
        {
            try
            {

                int Width = bmp.Width;
                int Height = bmp.Height;
                // next we declare the maximum size of the resized image. 
                // In this case, all resized images need to be constrained to a 173x173 square.
                int Heightmax = 1572;
                int Widthmax = 1826;
                // declare the minimum value af the resizing factor before proceeding. 
                // All images with a lower factor than this will actually be resized
                decimal Factorlimit = 1m;
                // determine if it is a portrait or landscape image
                decimal Relative = (decimal)(Height / (double)Width);
                decimal Factor;
                // if the image is a portrait image, calculate the resizing factor based on its height. 
                // else the image is a landscape image, 
                // and we calculate the resizing factor based on its width.
                if (Relative > 1m)
                {
                    if (Height < Heightmax + 1)
                    {
                        Factor = 1m;
                    }
                    else
                    {
                        Factor = (decimal)(Heightmax / (double)Height);
                    }
                }
                // 
                else if (Width < Widthmax + 1)
                {
                    Factor = 1m;
                }
                else
                {
                    Factor = (decimal)(Widthmax / (double)Width);
                }
                if (Factor < Factorlimit)
                {
                    // draw a new image with the dimensions that result from the resizing
                    var bmpnew = new Bitmap((int)Math.Round(bmp.Width * Factor), (int)Math.Round(bmp.Height * Factor), PixelFormat.Format24bppRgb);
                    var g = Graphics.FromImage(bmpnew);
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    // and paste the resized image into it
                    g.DrawImage(bmp, 0, 0, bmpnew.Width, bmpnew.Height);
                    return bmpnew;
                }
                else
                {
                    return bmp;
                }
            }

            catch (Exception ex)
            {
                return null;
                MessageBox.Show(ex.Message);
            }

           
        }

        private void BackgroundActivar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando datos";
            BackgroundWorker1.RunWorkerAsync();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Generando Calendario";
            My.MyProject.Forms.Cargando.TopMost = true;

            BackgroundCalendario.RunWorkerAsync();
        }
        private void WordDocViewer(string fileName)
        {
            try
            {
                Process.Start(fileName);
            }
            catch
            {
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

        private void BackgroundCatatula_DoWork(object sender, DoWorkEventArgs e)
        {
            SqlCommand comandoFechaEntrega;
            string consultaFechaEntrega;
            consultaFechaEntrega = "select fechaEntrega from credito where id = '" + idCreditoAentregar + "'";
            DateTime fechaEntrega;
            comandoFechaEntrega = new SqlCommand();
            comandoFechaEntrega.Connection = Module1.conexionempresa;
            comandoFechaEntrega.CommandText = consultaFechaEntrega;
            fechaEntrega = Conversions.ToDate(comandoFechaEntrega.ExecuteScalar());

            FileSystem.FileCopy(@"C:\ConfiaAdmin\SATI\Caratula Informativa.docx", @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempCaratula.docx");
            var documento = DocX.Load(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempCaratula.docx");
            documento.ReplaceText("%%FECHACREDITO%%", fechaEntrega.ToString("dd/MM/yyyy"));

            documento.ReplaceText("%%NOMBRERESPONSABLE%%", NombreClienteAentregar);
            documento.Save();
            documento.Dispose();

        }

        private void BackgroundCatatula_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var spDoc = new Spire.Doc.Document();
            spDoc.LoadFromFile(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempCaratula.docx");


            var Dialog = new PrintPreviewDialog();

            // dialog.AllowCurrentPage = True
            // dialog.AllowSomePages = True
            // dialog.UseEXDialog = True
            My.MyProject.Forms.Cargando.Close();

            try
            {
                // spDoc.PrintDialog = dialog.
                spDoc.PrintDocument.PrinterSettings.PrinterName = Module1.ImpresoraPredeterminada;

                Dialog.Document = spDoc.PrintDocument;
                Dialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BunifuThinButton24_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Generando carátula informativa";
            My.MyProject.Forms.Cargando.TopMost = true;
            BackgroundCatatula.RunWorkerAsync();

        }

        private void BackgroundTarjeta_DoWork(object sender, DoWorkEventArgs e)
        {
            FileSystem.FileCopy(@"C:\ConfiaAdmin\SATI\Tarjeta.docx", @"C:\ConfiaAdmin\SATI\TEMPDOCS\TempTarjeta.docx");
            var documento = DocX.Load(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempTarjeta.docx");
            documento.ReplaceText("%%NOMBRECLIENTE%%", NombreClienteAentregar);
            documento.Save();
            documento.Dispose();

            var document = new Spire.Doc.Document();
            document.LoadFromFile(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempTarjeta.docx");
            var selections = document.FindAllString("%%QR%%", true, true);
            int index = 0;
            TextRange range = null;
            gen_qr_file(@"C:\ConfiaAdmin\SATI\TEMPDOCS\QR", "CF-URP-0001", 50);
            var qr = new Bitmap(@"C:\ConfiaAdmin\SATI\TEMPDOCS\QR.png");

            foreach (TextSelection selection in selections)
            {
                var pic = new DocPicture(document);
                pic.LoadImage(qr);
                range = selection.GetAsOneRange();
                index = range.OwnerParagraph.ChildObjects.IndexOf(range);
                range.OwnerParagraph.ChildObjects.Insert(index, pic);
                range.OwnerParagraph.ChildObjects.Remove(range);
            }

            document.SaveToFile(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempTarjeta.docx", FileFormat.Doc);
            // System.Diagnostics.Process.Start("Sample.doc")

            // Dim GENERADOR As BarcodeWriter = New BarcodeWriter 'INICIALIZA EL GENERADOR
            // GENERADOR.Format = BarcodeFormat.QR_CODE
            // Dim IMAGEN As Bitmap = New Bitmap(GENERADOR.Write("CF-URP-0001"), 50, 50)
            // IMAGEN.Save("C:\ConfiaAdmin\SATI\TEMPDOCS\QR.png")
            // gen_qr_file("C:\ConfiaAdmin\SATI\TEMPDOCS\QR", "CF-URP-0001", 50)
            // Dim Word As Application
            // Dim Doc As Word.Document
            // Word = CreateObject("Word.Application")
            // Doc = Word.Documents.Open("C:\ConfiaAdmin\SATI\TEMPDOCS\TempTarjeta.docx")
            // Dim para As Word.Paragraph = Doc.Paragraphs.Add()
            // para.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
            // With para.Range.InlineShapes.AddPicture("C:\ConfiaAdmin\SATI\TEMPDOCS\QR.png").ConvertToShape
            // .WrapFormat.Type = Word.WdWrapType.wdWrapBehind
            // End With
            // para.Range.InsertParagraphAfter()
            // para.Range.ShapeRange.Item(1).WrapFormat.Type = WdWrapType.wdWrapInline
            // para.Range.InsertParagraph()
            // Word.ActiveDocument.InlineShapes(1).Range.ShapeRange.Item(0).WrapFormat.Type = WdWrapType.wdWrapInline
            // Dim _shape As Shape
            // _shape = Doc.Shapes.AddPicture(FileName:="C:\ConfiaAdmin\SATI\TEMPDOCS\QR.png", LinkToFile:=False, SaveWithDocument:=True)
            // With _shape
            // .WrapFormat.Type = WdWrapType.wdWrapNone
            // .WrapFormat.Type = WdWrapType.wdWrapInline
            // End With

            // Doc.Save()
            // Doc.Close()
            // Word = Nothing
            // Word.Application.Quit()
        }

        private void BackgroundTarjeta_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var spDoc = new Spire.Doc.Document();
            spDoc.LoadFromFile(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempTarjeta.docx");


            var Dialog = new PrintPreviewDialog();

            // dialog.AllowCurrentPage = True
            // dialog.AllowSomePages = True
            // dialog.UseEXDialog = True
            My.MyProject.Forms.Cargando.Close();

            try
            {
                // spDoc.PrintDialog = dialog.
                spDoc.PrintDocument.PrinterSettings.PrinterName = Module1.ImpresoraPredeterminada;

                Dialog.Document = spDoc.PrintDocument;
                Dialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTarjeta_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.CaputarMotocicleta.idCredito = idCreditoAentregar.ToString();
            My.MyProject.Forms.CaputarMotocicleta.ShowDialog();
            if (MotoActualizada)
            {
                BackgroundWorker1.RunWorkerAsync();

            }

        }
        private void gen_qr_file(string file_name, string content, int image_size)
        {
            string new_file_name = file_name;
            var qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            var qrCode = new QrCode();
            qrEncoder.TryEncode(content, out qrCode);
            var renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            var ms = new MemoryStream();
            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var imageTemp = new Bitmap(ms);
            var image = new Bitmap(imageTemp, new Size(new System.Drawing.Point(image_size, image_size)));
            image.Save(new_file_name + ".png", ImageFormat.Png);
        }

        private void BackgroundGrupal_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Data.DataTable dataCalendario;
            SqlDataAdapter adapterCalendario;
            string consultaCalendario;

            consultaCalendario = @"declare @cols nvarchar(max), @sql nvarchar(max)
set @cols = STUFF((select ',' + QUOTENAME(Npago) from CalendarioNormal where id_credito =" + idCreditoAentregar + @" FOR XML PATH('')),1,1,'')
set @sql = 'select row_number() over(order by integrante) as Numero,Integrante,format(Monto,'+ char(39) + 'C' + char(39) +','+ char(39) + 'es-mx' + char(39) +') as Monto,format(pago,'+ char(39) + 'C' + char(39) +','+ char(39) + 'es-mx' + char(39) +') as Pago,' + @cols + ' from 
(select credito.id,credito.nombre,concat(clientes.nombre,'+ char(39) + ' ' + char(39) + ',clientes.apellidopaterno,'+ char(39) + ' ' + char(39) + ',clientes.apellidomaterno) as Integrante,Npago,'+ char(39) + char(39) + ' as re,datossolicitud.montoautorizado as Monto,((datossolicitud.montoautorizado/ 1000) * credito.interes) as Pago from Credito inner join Solicitud on Credito.IdSolicitud = Solicitud.id inner join DatosSolicitud on DatosSolicitud.IdSolicitud = Solicitud.id inner join Clientes on DatosSolicitud.IdCliente = Clientes.id inner join calendarionormal on credito.id = calendarionormal.id_credito where Credito.id = " + idCreditoAentregar + @" and datossolicitud.estado = '+ char(39) + 'A' + char(39) + ' ) s 
 pivot
 (
 max(re) FOR Npago in ('+ @cols +')
 )p'

 execute (@sql)";
            adapterCalendario = new SqlDataAdapter(consultaCalendario, Module1.conexionempresa);
            dataCalendario = new System.Data.DataTable();
            adapterCalendario.Fill(dataCalendario);
            dataTableToWordGrupal(dataCalendario);
        }

        private void BackgroundGrupal_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var documento = DocX.Load(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendarioGrupal.docx");
            documento.ReplaceText("%%GRUPO%%", NombreCreditoAentregar);
            documento.ReplaceText("%%MONTO%%", Strings.FormatCurrency(MontoAentregar, 2));
            documento.Save();
            documento.Dispose();


            var spDoc = new Spire.Doc.Document();
            spDoc.LoadFromFile(@"C:\ConfiaAdmin\SATI\TEMPDOCS\TempCalendarioGrupal.docx");
            var dialog = new PrintPreviewDialog();

            // dialog.AllowCurrentPage = True
            // dialog.AllowSomePages = True
            // dialog.UseEXDialog = True
            My.MyProject.Forms.Cargando.Close();

            try
            {
                // spDoc.PrintDialog = dialog.
                spDoc.PrintDocument.PrinterSettings.PrinterName = Module1.ImpresoraPredeterminada;

                dialog.Document = spDoc.PrintDocument;
                dialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGrupal_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Generando Calendario Grupal";
            BackgroundGrupal.RunWorkerAsync();

        }

        private void TileLayout1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TileLayout1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void ImageStreamer1_Click(object sender, EventArgs e)
        {

        }
    }
}