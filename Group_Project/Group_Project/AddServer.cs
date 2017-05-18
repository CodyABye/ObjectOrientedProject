using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project
{
    public partial class AddServer : Form
    {
        public AddServer()
        {
            InitializeComponent();
        }

        private void btnServerAssign_Click(object sender, EventArgs e)
        {
            RestServer newServer = new RestServer(Convert.ToInt32(txtServerID.Text), txtServerName.Text);
            Form1 frm = new Form1();
            string serverName = txtServerName.Text;
            //frm.lstServers.Items.Add(serverName.ToString());
        }
    }
}
