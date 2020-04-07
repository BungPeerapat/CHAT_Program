using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSTEMDEMO
{
    public partial class Form1 : Form
    {
        public TcpClient client;
        private StreamReader SR;
        private StreamWriter SW;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnstartserver_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint ip_end = new IPEndPoint(IPAddress.Parse(IPCLIENT.Text),int.Parse(PORTCLIENT.Text));
            try
            {
                client.Connect(ip_end);
                if (client.Connected)
                {
                    TxtShowMessenge.AppendText("Connected!\n");
                    SW = new StreamWriter(client.GetStream());
                    SR = new StreamReader(client.GetStream());
                    SW.AutoFlush = true;
                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sendbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
