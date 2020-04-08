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
    public partial class ChatApplicationServer : Form
    {
        private TcpClient client;
        public StreamReader SR;
        public StreamWriter SW;
        public string receive;
        public string sendtxtclient;
        public ChatApplicationServer()
        {
            InitializeComponent();
        }

        private void btnstartserver_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(PORT.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            SR = new StreamReader(client.GetStream());
            SW = new StreamWriter(client.GetStream());
            SW.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
            if (client.Connected)
            {
                MessageBox.Show("Work!");
            }
        }

        private void sendbutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtsend.Text))
            {
                sendtxtclient = txtsend.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            txtsend.Text = "";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    receive = SR.ReadLine();
                    this.TxtShowMessenge.Invoke(new MethodInvoker(delegate ()
                    {
                        this.TxtShowMessenge.AppendText("Someone : " + receive + "\n");
                    }));
                    receive = "";
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                try
                {
                    SW.WriteLine(sendtxtclient);
                    this.TxtShowMessenge.Invoke(new MethodInvoker(delegate ()
                    {
                        this.TxtShowMessenge.AppendText("Me : " + sendtxtclient + "\n");
                    }));
                }catch
                {
                    MessageBox.Show("Error");
                }
                backgroundWorker2.CancelAsync();
            }
        }
    }
}
