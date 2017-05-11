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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TableLayout tl = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            tl = new TableLayout(pnlTables);
            tl.Start();

            listBox1.Items.Add("Name 1");
            listBox1.Items.Add("Name 2");
            listBox2.Items.Add("Name 3");
            listBox2.Items.Add("Name 4");
        }

        private void BtnServerAdd_Click(object sender, EventArgs e)
        {
            AddServer addServer = new AddServer();
            addServer.Show();
        }

        private void BtnPartiesAdd_Click(object sender, EventArgs e)
        {
            AddParty addParty = new AddParty();
            addParty.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBox2.Items.Add(listBox1.SelectedItem);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBox1.Items.Add(listBox2.SelectedItem);
        }

        private void ListDragTarget_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            //listBox1.Items.Add(listBox2.SelectedItem);
        }

        private void btnServerAssign_Click(object sender, EventArgs e)
        {

        }

        private void btnPartiesAssign_Click(object sender, EventArgs e)
        {

        }
    }
}