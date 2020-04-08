using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.ServiceModel.Activities;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSTEMDEMO
{
    public partial class CHAT_APPLICATION_CLIENT_DEMO : Form
    {
        private TcpClient client;
        public StreamReader SR;
        public StreamWriter SW;
        public string receive; //ตัวรับ
        public string sendtxtclient; //ตัวส่ง
        public CHAT_APPLICATION_CLIENT_DEMO()
        {
            InitializeComponent();
        }

        private void ConnectBotton_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint ip_end = new IPEndPoint(IPAddress.Parse(IPDEMO.Text), int.Parse(PORTDEMO.Text));
            try
            {
                if (client.Connected)
                {
                    MessageBox.Show("Connected!");
                    Console.Beep();
                    SW.AutoFlush = true;
                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SendBottonDemo_Click(object sender, EventArgs e)
        {
            if (client.Connected)
            {
                if (!string.IsNullOrEmpty(SendTextDemo.Text))
                {
                    sendtxtclient = SendTextDemo.Text;
                    SW.WriteLine(sendtxtclient);
                    backgroundWorker2.RunWorkerAsync();
                    Console.Beep();
                }
            }
            else
            {
                MessageBox.Show("Connect to Server Fail.");
                Console.Beep();
                Console.Beep();
                Console.Beep();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) //1 เป็นตัวรับ
        {
            while (client.Connected)
            {
                try
                {
                    SR.ReadLine(receive);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
