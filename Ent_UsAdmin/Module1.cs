using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{


    static class Module1
    {
        public static string strusuarios;
        public static string cn;
        public static string cnempresa;
        public static string cnEmpresasR;
        public static string cnEmpresaMysql;
        public static string ipMysql;
        public static string bdMysql;
        public static string ipMysqlHamachi;
        public static string ipser;
        public static string bdser;
        public static string ipconsultas;
        public static string bdconsultas;
        public static string nmusr;
        public static string grpusr;
        public static string nm_completeusr;
        public static string addrusr;
        public static string tlfusr;
        public static string imgstrusr;
        public static byte[] bitmapBytes;
        public static string idusr;
        public static MemoryStream streamimgusr;
        public static Bitmap bitmapimgusr;
        public static OleDbConnection conexion;
        public static SqlConnection conexionempresa;
        public static OleDbConnection conexionempresaR;
        public static Point m_PanStartPoint = new Point();
        public static bool bloquear = false;
        public static string NombreEmpresa;
        public static string RFCEmpresa;
        public static string CalleEmpresa;
        public static string NumeroEmpresa;
        public static string ColEmpresa;
        public static string CiudadEmpresa;
        public static string EstadoEmpresa;
        public static string CPEmpresa;
        public static string nombreAmostrar;
        public static string idEmpresa;
        public static string telEmpresa;
        public static string ImpresoraPredeterminada;
        public static int EmpleadoAsignado;
        public static bool usuarioActivo;
        public static OleDbDataAdapter adapterPermisos;
        public static DataTable dataPermisos;
        public static int idGrp;
        public static DataSet dataDocs;
        public static SqlDataAdapter adapterDocs;
        public static DataTable dataColonias;
        public static SqlDataAdapter adapterColonias;
        public static DataTable dataCorreos;
        public static OleDbDataAdapter adapterCorreos;
        public static string TipoEquipo;
        public static string idSesion;
        public static string prefijoEmpresa;
        public static string correoEmpresa;
        public static string passwordCorreoEmpresa;
        public static DataTable dataEmpresas;
        public static string ImpresoraTarjetas;

        private static Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
        public static Microsoft.Office.Interop.Excel.Workbook exLibro;
        private static BackgroundWorker _TestWorker;

        //private static BackgroundWorker TestWorker
        //{
        //    [MethodImpl(MethodImplOptions.Synchronized)]
        //    get
        //    {
        //        return _TestWorker;
        //    }

        //    [MethodImpl(MethodImplOptions.Synchronized)]
        //    set
        //    {
        //        if (_TestWorker != null)
        //        {
        //            _TestWorker.DoWork -= TestWorker_DoWork;
        //            _TestWorker.RunWorkerCompleted -= TestWorker_RunWorkerCompleted;
        //        }

        //        _TestWorker = value;
        //        if (_TestWorker != null)
        //        {
        //            _TestWorker.DoWork += TestWorker_DoWork;
        //            _TestWorker.RunWorkerCompleted += TestWorker_RunWorkerCompleted;
        //        }
        //    }
        //}
        [DllImport("kernel32.dll")]
        private static extern int SetProcessWorkingSetSize(IntPtr process, int minimumWorkingSetSize, int maximumWorkingSetSize);
        [DllImport("gdi32")]
        private static extern long CreateEllipticRgn(long X1, long Y1, long X2, long Y2);
        [DllImport("user32")]
        private static extern long SetWindowRgn(long hWnd, long hRgn, bool bRedraw);
        public static void iniciarconexion()
        {
            cn = "Provider=sqloledb;" + "Data Source=  " + ipser + @"\confia;" + "Initial Catalog=" + bdser + ";" + "User Id=sa;Password=BSi5t3Ma$CFAD;";
            conexion = new OleDbConnection(cn);
            conexion.Open();
        }

        public static void iniciarconexionempresa()
        {
            cnempresa = "Data Source=  " + ipconsultas + @"\confia;" + "Initial Catalog=" + bdconsultas + ";" + "User Id=sa;Password=BSi5t3Ma$CFAD;MultipleActiveResultSets=true";
            conexionempresa = new SqlConnection(cnempresa);
            conexionempresa.Open();
        }
        public static void iniciarconexionR()
        {
            cnEmpresasR = "Provider=sqloledb;" + "Data Source=  " + ipconsultas + @"\confia;" + "Initial Catalog=" + bdser + ";" + "User Id=sa;Password=BSi5t3Ma$CFAD;";
            conexionempresaR = new OleDbConnection(cnEmpresasR);
            conexionempresaR.Open();
        }

        public static string iniciarconexionRMysql(string ip, string bd)
        {
            string constring = "Data Source=  " + ip + @"\confia;" + "Initial Catalog=" + bd + ";" + "User Id=sa;Password=BSi5t3Ma$CFAD;MultipleActiveResultSets=true";
            return constring;
        }


        public static bool ProbarConexionEmpresa(string ip, string bd)
        {
            string constring = "Data Source=  " + ip + @"\confia;" + "Initial Catalog=" + bd + ";" + "User Id=sa;Password=BSi5t3Ma$CFAD;MultipleActiveResultSets=true";
            SqlConnection conex;
            try
            {
                conex = new SqlConnection(constring);
                conex.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public static OleDbConnection CrearConexionEmpresa(string ip, string bd)
        {
            string constring = "Provider=sqloledb;" + "Data Source=  " + ip + @"\confia;" + "Initial Catalog=" + bd + ";" + "User Id=sa;Password=BSi5t3Ma$CFAD;MultipleActiveResultSets=true";
            OleDbConnection conex;
            try
            {
                conex = new OleDbConnection(constring);
                conex.Open();
                return conex;
            }
            catch (Exception ex)
            {
                return null;
                MessageBox.Show(ex.Message);
            }

           

        }


        public static void cargarperfil()
        {
            string strconf = "select x1.nm,x2.nm as grp,x1.nm_complete,x1.addr,x1.tlf,x1.imgstr,x1.activo,x1.grp as idgrp from usr x1 inner join grp x2 on x1.grp = x2.id where x1.idusr = '" + idusr + "'";
            var connexio = new OleDbConnection(cn);
            var ejec2 = new OleDbCommand(strconf);
            ejec2.Connection = connexio;
            connexio.Open();
            var myreaderconf = ejec2.ExecuteReader();
            while (myreaderconf.Read())
            {
                nmusr = Convert.ToString(myreaderconf["nm"]);
                grpusr = Convert.ToString(myreaderconf["grp"]);
                nm_completeusr = Convert.ToString(myreaderconf["nm_complete"]);
                addrusr = Convert.ToString(myreaderconf["addr"]);
                tlfusr = Convert.ToString(myreaderconf["tlf"]);
                imgstrusr = Convert.ToString(myreaderconf["imgstr"]);
                usuarioActivo = Conversions.ToBoolean(myreaderconf["activo"]);
                idGrp = Conversions.ToInteger(myreaderconf["idgrp"]);
            }
            if (!string.IsNullOrEmpty(imgstrusr))
            {
                bitmapBytes = Convert.FromBase64String(imgstrusr);
                streamimgusr = new MemoryStream(bitmapBytes, 0, bitmapBytes.Length);
                streamimgusr.Write(bitmapBytes, 0, bitmapBytes.Length);
                bitmapimgusr = new Bitmap(streamimgusr);
            }
            // connexio.Close()
            string consultaPermisos;
            consultaPermisos = "Select * from permisosGrupo where idgrupo = '" + idGrp + "'";
            adapterPermisos = new OleDbDataAdapter(consultaPermisos, connexio);
            dataPermisos = new DataTable();
            adapterPermisos.Fill(dataPermisos);

            connexio.Close();
        }


        //public static void cargarusuarios()
        //{
        //    try
        //    {
        //        int num_controles = My.MyProject.Forms.usuarios.FlowLayoutPanel1.Controls.Count - 1;

        //        for (int n = num_controles; n >= 0; n -= 1)
        //        {
        //            var ctrl = My.MyProject.Forms.usuarios.FlowLayoutPanel1.Controls[n];
        //            My.MyProject.Forms.usuarios.FlowLayoutPanel1.Controls.Remove(ctrl);
        //            ctrl.Dispose();
        //        }
        //        // strusuarios = "select idusr,nm_complete,imgstr from usr"
        //        var ejec2 = new OleDbCommand(strusuarios);
        //        ejec2.Connection = conexion;
        //        string imgpanel;
        //        string idusrpanel;
        //        string nombrecompleto;
        //        byte[] bytespanel;
        //        MemoryStream streamimgpanel;
        //        Bitmap bitmapimgpanel;
        //        Bunifu.Framework.UI.BunifuImageButton pictureboxpanel;
        //        Label labelnombre;

        //        var myreaderusuarios = ejec2.ExecuteReader();
        //        while (myreaderusuarios.Read())
        //        {
        //            imgpanel = Convert.ToString(myreaderusuarios["imgstr"]);
        //            idusrpanel = Convert.ToString(myreaderusuarios["idusr"]);
        //            nombrecompleto = Convert.ToString(myreaderusuarios["nm_complete"]);

        //            if (!string.IsNullOrEmpty(imgpanel))
        //            {
        //                bytespanel = Convert.FromBase64String(imgpanel);
        //                streamimgpanel = new MemoryStream(bytespanel, 0, bytespanel.Length);
        //                streamimgpanel.Write(bytespanel, 0, bytespanel.Length);
        //                bitmapimgpanel = new Bitmap(streamimgpanel);
        //                pictureboxpanel = new Bunifu.Framework.UI.BunifuImageButton();
        //                pictureboxpanel.Image = bitmapimgpanel;
        //                pictureboxpanel.Size = new Size(100, 200);
        //                pictureboxpanel.Name = idusrpanel;
        //                pictureboxpanel.BackColor = Color.FromArgb(223, 223, 223);
        //                pictureboxpanel.SizeMode = PictureBoxSizeMode.StretchImage;
        //                pictureboxpanel.MouseDown += mousedownevent;
        //                pictureboxpanel.MouseMove += MouseMoveevent;
        //                pictureboxpanel.MouseUp += mouseupevent;
        //                pictureboxpanel.Click += clickevent;
        //                My.MyProject.Forms.usuarios.FlowLayoutPanel1.PerformLayout();
        //                My.MyProject.Forms.usuarios.FlowLayoutPanel1.Controls.Add(pictureboxpanel);
        //                labelnombre = new Label();
        //                labelnombre.Text = nombrecompleto;
        //                labelnombre.AutoSize = false;
        //                labelnombre.Size = new Size(100, 50);
        //                labelnombre.BackColor = Color.FromArgb(18, 18, 18);
        //                labelnombre.ForeColor = Color.FromArgb(223, 223, 223);
        //                labelnombre.Location = new Point(0, pictureboxpanel.Height - labelnombre.Height);

        //                pictureboxpanel.Controls.Add(labelnombre);
        //            }
        //            else
        //            {
        //                pictureboxpanel = new Bunifu.Framework.UI.BunifuImageButton();
        //                pictureboxpanel.Image = My.Resources.Resources.usuario;
        //                pictureboxpanel.Size = new Size(100, 200);
        //                pictureboxpanel.Name = idusrpanel;
        //                pictureboxpanel.SizeMode = PictureBoxSizeMode.StretchImage;
        //                pictureboxpanel.BackColor = Color.FromArgb(223, 223, 223);
        //                pictureboxpanel.MouseDown += mousedownevent;
        //                pictureboxpanel.MouseMove += MouseMoveevent;
        //                pictureboxpanel.MouseUp += mouseupevent;
        //                pictureboxpanel.Click += clickevent;
        //                My.MyProject.Forms.usuarios.FlowLayoutPanel1.PerformLayout();
        //                My.MyProject.Forms.usuarios.FlowLayoutPanel1.Controls.Add(pictureboxpanel);
        //                labelnombre = new Label();
        //                labelnombre.Text = nombrecompleto;

        //                labelnombre.AutoSize = false;
        //                labelnombre.Size = new Size(100, 50);
        //                labelnombre.BackColor = Color.FromArgb(18, 18, 18);
        //                labelnombre.ForeColor = Color.FromArgb(223, 223, 223);
        //                labelnombre.Location = new Point(0, pictureboxpanel.Height - labelnombre.Height);
        //                pictureboxpanel.Controls.Add(labelnombre);
        //            }



        //        }
        //        pictureboxpanel = new Bunifu.Framework.UI.BunifuImageButton();
        //        pictureboxpanel.Image = My.Resources.Resources.usuario_agregar;
        //        pictureboxpanel.Size = new Size(100, 200);
        //        pictureboxpanel.Name = "Agregar Usuario";
        //        pictureboxpanel.SizeMode = PictureBoxSizeMode.StretchImage;
        //        pictureboxpanel.BackColor = Color.FromArgb(223, 223, 223);
        //        pictureboxpanel.MouseDown += mousedownevent;
        //        pictureboxpanel.MouseMove += MouseMoveevent;
        //        pictureboxpanel.MouseUp += mouseupevent;
        //        pictureboxpanel.Click += clickevent;
        //        My.MyProject.Forms.usuarios.FlowLayoutPanel1.Controls.Add(pictureboxpanel);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}
        //public static void InitializeBackgroundWorker()
        //{
        //    TestWorker = new BackgroundWorker();

        //    {
        //        var withBlock = TestWorker;
        //        withBlock.WorkerReportsProgress = true;
        //        withBlock.WorkerSupportsCancellation = true;
        //    }
        //}
        //public static void RunWorkerAsync()
        //{
        //    TestWorker.RunWorkerAsync();
        //}
        //public static void TestWorker_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    MessageBox.Show("haciendolo");
        //    cargarusuarios();
        //}

        public static void mousedownevent(object sender, MouseEventArgs e)
        {

            // Capture the initial point 
            m_PanStartPoint = new Point(e.X, e.Y);

        }
        public static void mouseupevent(object sender, MouseEventArgs e)
        {

            // Capture the initial point 
            bloquear = false;


        }
        public static void MouseMoveevent(object sender, MouseEventArgs e)
        {

            // Verify Left Button is pressed while the mouse is moving
            if (e.Button == MouseButtons.Left)
            {
                bloquear = true;
                // Here we get the change in coordinates.
                int DeltaX = m_PanStartPoint.X - e.X;
                int DeltaY = m_PanStartPoint.Y - e.Y;

                // Then we set the new autoscroll position.
                // ALWAYS pass positive integers to the panels autoScrollPosition method
                My.MyProject.Forms.usuarios.FlowLayoutPanel1.AutoScrollPosition = new Point(DeltaX - My.MyProject.Forms.usuarios.FlowLayoutPanel1.AutoScrollPosition.X, DeltaY - My.MyProject.Forms.usuarios.FlowLayoutPanel1.AutoScrollPosition.Y);


            }

        }
        //public static void clickevent(object sender, EventArgs e)
        //{
            
        //    // Dim label = DirectCast(sender, Label)
        //    if (bloquear == false)
        //    {
        //        My.MyProject.Forms.Editar_Usuario.idusuario = Conversions.ToString(sender.name);

        //        My.MyProject.Forms.Editar_Usuario.Show();
        //    }



        //}

        private static void TestWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("listo");
        }

        public static void FlushMemory()
        {
            try
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                {
                    SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1);
                }
            }
            catch (Exception ex)
            {

            }
        }
        public static void Docs()
        {
            string consultaDocs;
            consultaDocs = "select * from tipodoc";
            adapterDocs = new SqlDataAdapter(consultaDocs, conexionempresa);
            dataDocs = new DataSet();
            adapterDocs.Fill(dataDocs);
        }

        public static void Colonias()
        {
            string consultaColonias;
            consultaColonias = "select * from colonias";
            adapterColonias = new SqlDataAdapter(consultaColonias, conexionempresa);
            dataColonias = new DataTable();
            adapterColonias.Fill(dataColonias);
        }

        public static bool AfectaCaja(string nombredoc)
        {
            bool afectacion=false;
            foreach (DataRow row in dataDocs.Tables[0].Rows)
            {
                if ((row["Nombre"].ToString() ?? "") == (nombredoc ?? ""))
                {
                    afectacion = Conversions.ToBoolean(Conversion.Val(row["AfectaCaja"].ToString()));
                    break;
                }

            }
            return afectacion;
        }

        public static int ObtenerTipoDoc(string nombredoc)
        {
            int tipoDoc =0;
            foreach (DataRow row in dataDocs.Tables[0].Rows)
            {
                if ((row["Nombre"].ToString() ?? "") == (nombredoc ?? ""))
                {
                    tipoDoc = (int)Math.Round(Conversion.Val(row["id"].ToString()));
                    break;
                }

            }
            return tipoDoc;
        }

        public static string GetNombreDoc(int id)
        {
            string nombreDoc ="";
            foreach (DataRow row in dataDocs.Tables[0].Rows)
            {
                if (Conversions.ToDouble(row["id"].ToString()) == id)
                {
                    nombreDoc = row["Nombre"].ToString();
                    break;
                }

            }
            return nombreDoc;
        }

        public static void nuevolibro()
        {
            exLibro = exApp.Workbooks.Add();
        }

        public static bool GridAExcel(DataGridView ElGrid)
        {

            // Creamos las variables

            Microsoft.Office.Interop.Excel.Worksheet exHoja;

            try
            {
                // Añadimos el Libro al programa, y la hoja al libro

                exHoja = (Microsoft.Office.Interop.Excel.Worksheet)exLibro.Worksheets.Add();

                // ¿Cuantas columnas y cuantas filas?
                int NCol = ElGrid.ColumnCount;
                int NRow = ElGrid.RowCount;

                // Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.


                for (int i = 1, loopTo = NCol; i <= loopTo; i++)
                    // exHoja.Cells.Item(1, i).HorizontalAlignment = 3
                    exHoja.Cells.set_Item(1, i, ElGrid.Columns[i - 1].HeaderText.ToString());

                for (int Fila = 0, loopTo1 = NRow - 1; Fila <= loopTo1; Fila++)
                {
                    for (int Col = 0, loopTo2 = NCol - 1; Col <= loopTo2; Col++)
                        exHoja.Cells.set_Item(Fila + 2, Col + 1, ElGrid.Rows[Fila].Cells[Col].Value.ToString());
                }
                // Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
                exHoja.Rows.get_Item((object)1).Font.Bold = (object)1;
                exHoja.Rows.get_Item((object)1).HorizontalAlignment = (object)3;
                exHoja.Columns.AutoFit();
                // exHoja.Columns.Range("A:A").NumberFormat = "#0"

                // Aplicación visible

                exHoja = null;

                return true;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel");

                return false;
            }



        }

        public static bool GridAExcelLegal(DataGridView ElGrid, char LetraColumna)
        {

            // Creamos las variables

            Microsoft.Office.Interop.Excel.Worksheet exHoja;
            var ExportArray = new object[ElGrid.Rows.Count, ElGrid.Columns.Count];

            try
            {
                // Añadimos el Libro al programa, y la hoja al libro

                exHoja = (Microsoft.Office.Interop.Excel.Worksheet)exLibro.Worksheets.Add();

                // ¿Cuantas columnas y cuantas filas?
                int NCol = ElGrid.ColumnCount;
                int NRow = ElGrid.RowCount;

                // Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
                for (int i = 1, loopTo = NCol; i <= loopTo; i++)
                    // exHoja.Cells.Item(1, i).HorizontalAlignment = 3
                    exHoja.Cells.set_Item(1, i, ElGrid.Columns[i - 1].HeaderText.ToString());

                for (int Fila = 0, loopTo1 = NRow - 1; Fila <= loopTo1; Fila++)
                {
                    for (int Col = 0, loopTo2 = NCol - 1; Col <= loopTo2; Col++)
                        // exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value.ToString
                        ExportArray[Fila, Col] = ElGrid.Rows[Fila].Cells[Col].Value.ToString();
                }
                // Ponemos toda la información del array, en el excel, a partir de la fila 2
                exHoja.get_Range("A2:" + LetraColumna + (NRow + 1)).set_Value(value: ExportArray);

                // Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
                exHoja.Rows.get_Item((object)1).Font.Bold = (object)1;
                exHoja.Rows.get_Item((object)1).HorizontalAlignment = (object)3;
                exHoja.Columns.AutoFit();

                for (int i = 0, loopTo3 = NRow - 1; i <= loopTo3; i++)
                {
                    if (!ReferenceEquals(ExportArray[i, 23], ""))
                    {
                        exHoja.get_Range("L" + (i + 2) + ":L" + (i + 2)).AddComment(ExportArray[i, 23].ToString());
                        exHoja.get_Range("L" + (i + 2) + ":L" + (i + 2)).Cells.Comment.Shape.Height = 118.5f;
                        exHoja.get_Range("L" + (i + 2) + ":L" + (i + 2)).Cells.Comment.Shape.Width = 162f;
                    }
                }
                exHoja.Columns.AutoFit();
                // Aplicación visible

                exHoja = null;
            }


            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel");

                return false;
            }

            return true;

        }

        public static void cerrarlibro()
        {
            try
            {

                SaveFileDialog guardar;
                guardar = new SaveFileDialog();
                guardar.Filter = "Archivo de Excel|*.xlsx";
                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    exApp.Application.Visible = true;
                    // exLibro.SaveAs(Environ("UserProfile") & "\desktop\" & nombre & ".xls")
                    exLibro.SaveAs(guardar.FileName);
                }
            }

            // exLibro.SaveAs(Environ("UserProfile") & "\desktop\NombreDeTuArchivo.xls")
            // exLibro = Nothing
            // exApp = Nothing
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}