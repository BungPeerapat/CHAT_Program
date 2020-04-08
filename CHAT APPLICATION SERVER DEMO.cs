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
    public partial class CHAT_APPLICATION_SERVER_DEMO : Form
    {
        private TcpClient client;
        public StreamReader SR;
        public StreamWriter SW;
        public string receive; //ตัวรับ
        public string sendtxtclient; //ตัวส่ง
        public CHAT_APPLICATION_SERVER_DEMO()
        {
        InitializeComponent();
        }

        private void CreateServerBotton_Click(object sender, EventArgs e)
        {
            TcpListener clientConnected = new TcpListener(IPAddress.Any, int.Parse(PORTSERVER.Text));
            clientConnected.Start();
            client = clientConnected.AcceptTcpClient();
            SR = new StreamReader(client.GetStream());
            SW = new StreamWriter(client.GetStream());
            SW.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
            Console.Beep();
            Console.Beep();
            MessageBox.Show("Create Complete.");
            Console.Beep();
        }

        async Task TimeDelay1Second()
        {
            await Task.Delay(1000);
        }
        private void SendTextBotton_Click(object sender, EventArgs e)
        {
            if (client.Connected)
            {
                if (!string.IsNullOrEmpty(SendTextDemo.Text))
                {
                    sendtxtclient = SendTextDemo.Text;
                    backgroundWorker2.RunWorkerAsync();
                }
            }
            else
            {
                MessageBox.Show("You don't have any Connecttion.");            
            }
        }

        async private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) //ตัวรับ
        {
            while (client.Connected)
            {
                try
                {
                    receive = SR.ReadLine();
                    this.TxtMessageDemo.Invoke(new MethodInvoker(delegate ()
                    {
                        this.TxtMessageDemo.AppendText("Someone : " + receive + "\n");
                    }));
                    await TimeDelay1Second();
                    receive = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        async Task Time05Delay()
        {
            await Task.Delay(500);
        }

        async private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e) //ตัวส่ง
        {
            try
            {
                if (client.Connected)
                {
                    SW.WriteLine(SendTextDemo.Text);
                    this.TxtMessageDemo.Invoke(new MethodInvoker(delegate ()
                    {
                        this.TxtMessageDemo.AppendText("Me : " + SendTextDemo + "\n");
                    }));
                    await Time05Delay();
                }
                else
                {
                    MessageBox.Show("SYSTEM : Client Don't Connected");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
