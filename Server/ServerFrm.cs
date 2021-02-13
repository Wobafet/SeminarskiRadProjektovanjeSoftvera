using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerApp
{
    public partial class ServerApp : Form
    {
        private Server server;
        public ServerApp()
        {
            InitializeComponent();
            server = new Server();
        }

       

        private void btnStart_Click(object sender, EventArgs e)
        {
            server.Start();

            Thread t = new Thread(server.Listen);
            t.IsBackground = true;
            t.Start();

            
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            lblServerStatus.Text = "Server started";
            lblServerStatus.ForeColor = Color.Green;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            server.Stop();
           
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            lblServerStatus.Text = "Server stoped";
            lblServerStatus.ForeColor = Color.Red;

        }

        private void ServerApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            server.Stop();
        }
    }
}
