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
        TableLayout assignParty = new TableLayout();

        int dailyCustomers = 0;
        string errorMessage = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            tl = new TableLayout(pnlTables);
            tl.Start();

            lstServers.Items.Add("Jack");
            lstServers.Items.Add("Sue");

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

            if ((txtpName.Text == null || txtpName.Text.Trim() == string.Empty))
            {
                MessageBox.Show("Please enter the party name.");
                txtpName.Focus();
            }
            else
            {
                if (isInt(txtpSize.Text))
                {
                    int size = 0;
                    Customer currentParty = new Customer(txtpName.Text, Convert.ToInt32(txtpSize.Text));
                    string partyName = txtpName.Text;

                    size = int.Parse(txtpSize.Text);

                    dailyCustomers += size;

                   
                    //create new Customer object here. Can add objects to listbox
                    string partyWait = partyName + " " + size.ToString();

                    //add Customer object to listbox
                    lstWaitList.Items.Add(partyWait);

                   
                    txtpName.Clear();
                    txtpSize.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a valid integer for party size");
                    txtpSize.Focus();
                }
            }

            //AddParty addParty = new AddParty();
            //addParty.Show();

        }

        private bool isInt(string testString) //tests if test score input is numerical.
        {
            bool valid = false;

            try
            {
                int testValue = Convert.ToInt16(testString);
                valid = true;
            }
            catch
            {
                errorMessage += "Please enter a numerical value.\n";
                valid = false;
            }
            return valid;
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

        public void LoadCustInfo(string waitList, string waitStaff)
        {
            waitList = (string)lstWaitList.SelectedItem;

            waitStaff = (string)lstServers.SelectedItem;
        }

        private void btnPartiesAssign_Click(object sender, EventArgs e)
        {
            string waitList = (string)lstWaitList.SelectedItem;

            string waitStaff = (string)lstServers.SelectedItem;

            
            int  table = Convert.ToInt16(txtTable.Text);
                
            assignParty.AssignTable(waitList, waitStaff, table);

            lstWaitList.Items.Remove(lstWaitList.SelectedItem);



        }

        
    }
}