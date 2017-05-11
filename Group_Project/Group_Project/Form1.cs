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

        private void Form1_Load(object sender, EventArgs e)
        {
            TableLayout table = new TableLayout();
            listBox1.Items.Add("Jack");
            listBox1.Items.Add("Sue");
            listBox2.Items.Add("Name 2");
            listBox2.Items.Add("Name 3");
        }

        private void BtnServerAdd_Click(object sender, EventArgs e)
        {
            AddServer addServer = new AddServer();
            addServer.Show();
        }

        private void BtnPartiesAdd_Click(object sender, EventArgs e)
        {
            //AddParty addParty = new AddParty();
            //addParty.Show();
            string partyName = txtpName.Text;

            if (txtpName.Text == "")
            {
                MessageBox.Show("Please enter valid input for the name of party");
                txtpName.Focus();
            }

            try
            {
                int size = int.Parse(txtpSize.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid integer for party size");
                txtpSize.Focus();
            }

           
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
            //listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            //listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}