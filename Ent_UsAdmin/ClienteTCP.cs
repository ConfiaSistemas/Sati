using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
namespace ConfiaAdmin
{
    public partial class ClienteTCP : Form
    {
        static byte[] data;  // 1
        static Socket socket; // 1
        Socket s;
        TcpClient tcpclnt = new TcpClient();
        Stream stm;
        public ClienteTCP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPAddress ipAd = IPAddress.Parse(textBox1.Text);
            
            textBox2.Text = "Connecting...\n";
            tcpclnt.Connect(textBox1.Text, 8080);
            textBox2.Text = textBox2.Text + " Connected \n";
           stm = tcpclnt.GetStream();
           
            
            byte[] bb = new byte[100];
            int k = stm.Read(bb, 0, 100);
            for (int i = 0; i < k; i++)
                textBox2.Text = textBox2.Text + Convert.ToChar(bb[i]).ToString() + " \n";
            //s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //try // 1
            //{
            //    s.Connect(IPAddress.Parse(textBox1.Text), 8080); // 2
            //    textBox2.Text = s.;
            //}
            //catch // 1
            //{
            //    // not connected
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String str = textBox3.Text;
            ASCIIEncoding asen = new ASCIIEncoding();
            byte[] ba = asen.GetBytes(str);
            textBox2.Text = textBox2.Text + "Transmitiendo... \n";
            stm.Write(ba, 0, ba.Length);
            //string q = textBox3.Text;                 // 3
            //byte[] data = Encoding.Default.GetBytes(q);    // 3
            //s.Send(data);

        }

       
    }
}
