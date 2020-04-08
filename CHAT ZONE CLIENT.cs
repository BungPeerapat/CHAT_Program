﻿using System;
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
    public partial class ChatApplicationClientSize : Form
    {
        public TcpClient client;
        public StreamReader SR;
        public StreamWriter SW;
        public string receive;
        public string sendtxt;
        public ChatApplicationClientSize()
        {
            InitializeComponent();
        }

        private void btnstartserver_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint ip_end = new IPEndPoint(IPAddress.Parse(ipclient.Text), int.Parse(portclient.Text));
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
                if (backgroundWorker2.WorkerSupportsCancellation == false)
                {
                    Console.Beep();
                    Console.Beep();
                    MessageBox.Show("Work!!!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void sendbutton_Click_1(object sender, EventArgs e)
        {
            if (txtsend != null)
            {
                sendtxt = txtsend.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            txtsend.Text = "";
        }

        private void backgroundWorker2_DoWork_1(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                try
                {
                    SW.WriteLine(sendtxt);
                    this.TxtShowMessenge.Invoke(new MethodInvoker(delegate ()
                    {
                        this.TxtShowMessenge.AppendText("Me : " + sendtxt + "\n");
                    }));
                }
                catch
                {
                    MessageBox.Show("Error");
                }
                backgroundWorker2.CancelAsync();
            }
        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
