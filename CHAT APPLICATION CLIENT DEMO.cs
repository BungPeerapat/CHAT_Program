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
                client.Connect(ip_end);
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

        async private void SendBottonDemo_Click(object sender, EventArgs e)
        {
            if (client.Connected)
            {
                if (!string.IsNullOrEmpty(SendTextDemo.Text))
                {
                    sendtxtclient = SendTextDemo.Text;
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
            await TimeDelay1Second();
            SendTextDemo.Text = "";
        }
        async Task TimeDelay1Second() //Delay Time
        {
            await Task.Delay(1000);
        }

        async private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) //1 เป็นตัวรับ
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                await TimeDelay1Second();
                receive = "";
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
                    SW.WriteLine(sendtxtclient);
                    this.TxtMessageDemo.Invoke(new MethodInvoker(delegate ()
                    {
                        this.TxtMessageDemo.AppendText("Me : " + sendtxtclient + "\n");
                    }));
                    await Time05Delay();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SendTextDemo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
