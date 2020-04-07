using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSTEMDEMO
{
    public partial class MainServer : Form
    {
        public MainServer()
        {
            InitializeComponent();
        }

        private void SB_Click(object sender, EventArgs e)
        {
            ChatApplicationServer OpenChatServerSize = new ChatApplicationServer();
            OpenChatServerSize.Show();
        }

        private void CB_Click(object sender, EventArgs e)
        {
            ChatApplicationClientSize OpenChatClientSize = new ChatApplicationClientSize();
            OpenChatClientSize.Show();
        }
    }
}
