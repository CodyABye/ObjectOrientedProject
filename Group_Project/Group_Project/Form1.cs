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
        int dailyCustomers = 0;

        TableLayout assignParty = new TableLayout();
        public Form1()
        {
            InitializeComponent();
        }

        TableLayout tl = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            tl = new TableLayout(pnlTables);
            tl.Start();

            listBox1.Items.Add("Jack");
            listBox1.Items.Add("Sue");

            //listBox2.Items.Add("Name 2");
            //listBox2.Items.Add("Name 3");

        }

        private void BtnServerAdd_Click(object sender, EventArgs e)
        {
            AddServer addServer = new AddServer();
            addServer.Show();
        }

        private void BtnPartiesAdd_Click(object sender, EventArgs e)
        {
            //create new customer
            Customer currentParty = new Customer(txtpName.Text, Convert.ToInt32(txtpSize.Text));
            int size = 0;


            string partyName = txtpName.Text;
            //AddParty addParty = new AddParty();
            //addParty.Show();

            if (partyName == "")
            {
                MessageBox.Show("Please enter valid input for the name of party");
                txtpName.Focus();
            }

            try
            {
                size = int.Parse(txtpSize.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid integer for party size");
                txtpSize.Focus();
            }

            dailyCustomers += size;

            //create new Customer object here. Can add objects to listbox
            string partyWait = partyName + " " + size.ToString();
            
            //add Customer object to listbox
            listBox2.Items.Add(currentParty);

            txtpName.Clear();
            txtpSize.Clear();

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
            string party = (string) listBox2.SelectedItem;

            assignParty.Customer_Table(party);

            listBox2.Items.Remove(listBox2.SelectedItem);
            
        }

        
    }
}