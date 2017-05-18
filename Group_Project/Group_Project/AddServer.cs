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
        public string ServerName { get; set; }
        public int ServerID { get; set; }
        private void btnServerAssign_Click(object sender, EventArgs e)
        {              
            ServerName = txtServerName.Text;
            ServerID = Convert.ToInt32(txtServerID.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
            //frm.lstServers.Items.Add(serverName.ToString());
        }

        private void AddServer_Load(object sender, EventArgs e)
        {
            
        }
    }
}
