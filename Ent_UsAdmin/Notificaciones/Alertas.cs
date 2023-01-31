using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.WindowsAPICodePack.Taskbar;

namespace ConfiaAdmin
{
    public partial class Alertas
    {
        public string cadena;
        private int contador = 0;
        // Creamos una variable que define la cantidad de caracteres por linea
        private int longitud_maxima = 30;
        // La nueva cadena a imprimir en el textbox multiline
        private string nueva_cadena = string.Empty;
        private TaskbarManager windowTaskbar = TaskbarManager.Instance;

        public Alertas()
        {
            InitializeComponent();
        }

        private void Alertas_Load(object sender, EventArgs e)
        {
            TextBox1.BackColor = BackColor;
            foreach (char x in cadena.ToCharArray())
            {
                // Incrementamos el contador
                contador += 1;
                // si el contador es igual a la longitus maxima asignada
                if (contador == longitud_maxima)
                {
                    // Adjunto el caracter y le doy un salto de linea
                    nueva_cadena = nueva_cadena + x + Constants.vbCrLf;
                    // Inicializo el contador a 0
                    contador = 0;
                }
                // Sino...
                else
                {
                    // Sigo adjuntando los caracteres a la nueva cadena
                    nueva_cadena = nueva_cadena + x;
                }
            }
            // Una vez finalizado el recorrido adjunto la nueva
            // cadena al textbox multiline
            if (cadena.Length > TextBox1.Height)
            {
                TextBox1.ScrollBars = ScrollBars.Vertical;
            }
            else
            {
                TextBox1.ScrollBars = ScrollBars.None;

            }
            windowTaskbar.SetProgressState(TaskbarProgressBarState.Error);
            windowTaskbar.SetProgressValue(10, 10);
            TextBox1.Text = cadena;

            lblMensaje.Text = nueva_cadena;

        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            windowTaskbar.SetProgressState(TaskbarProgressBarState.NoProgress);
            Close();

        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }
    }
}