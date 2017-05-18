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
        private string partyTable;
        private string serverTable;
        Button[,] tableArray = new Button[4, 4];

        private string customers = "";
        private string servers = "";
        private int partySize = 0;
        private int tableNum = 0;
        CustomerReport c;
        RestServer newServ;

        int dailyCustomers = 0;
        string errorMessage = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            c = new CustomerReport();
            tl = new TableLayout(pnlTables);
            Start();

            lstServers.Items.Add(new RestServer(15, "Andy"));
            lstWaitList.Items.Add(new Customer("Jack", 6))
            lstServers.SelectedIndex = lstServers.TopIndex;
            //listBox2.Items.Add("Name 2");
            //listBox2.Items.Add("Name 3");

        }

        private void BtnServerAdd_Click(object sender, EventArgs e)
        {
            string serverName = "";
            int serverID = 0;
            using(AddServer addServer = new AddServer())
            {
                if(addServer.ShowDialog() == DialogResult.OK)
                {
                    serverName = addServer.ServerName;
                    serverID = addServer.ServerID;                    
                }
            }
            newServ = new RestServer(serverID, serverName);
            lstServers.Items.Add(newServ);
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
                    
                    Customer partyWait = new Customer(txtpName.Text, Convert.ToInt32(txtpSize.Text));

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

        //private void lstServers_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string server = (string)lstServers.SelectedItem;
        //    string customer = (string)lstWaitList.SelectedItem;
        //    int size = partySize;

        //    assignParty.Customer_Table(customer, server, size);

        //}

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBox2.Items.Add(listBox1.SelectedItem);

            //string server = (string)lstServers.SelectedItem;
            //string customer = (string)lstWaitList.SelectedItem;
            //int size = partySize;

            //assignParty.Customer_Table(customer, server, size);
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

            if (isInt(txtTable.Text))
            {
                int table = Convert.ToInt16(txtTable.Text);
                AssignTable(waitList, waitStaff, table);
                lstWaitList.Items.Remove(lstWaitList.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please enter a valid integer for table number");
                txtTable.Focus();
            }
        }

        //-------------------------------------------------------------------------------------------------------------
        //taken from table layout to access tables 
        public void Start()
        {
            BuildBoard();
        }
        private void BuildBoard()
        {
            int startLeft = 30;
            int startTop = 10;
            int tableName = 1;

            for (int row = 0; row <= tableArray.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= tableArray.GetUpperBound(1); col++)
                {
                    tableArray[row, col] = new Button();
                    tableArray[row, col].Location = new System.Drawing.Point(startLeft + (col * 175), startTop + (row * 120));
                    tableArray[row, col].Tag = new Table();
                    tableArray[row, col].Height = 90;
                    tableArray[row, col].Width = 120;
                    tableArray[row, col].Text = "Table " + tableName;


                    //incremented tableName after assignment of .Tag and .Text so tableName would be the same in both.

                    ++tableName;

                    pnlTables.Controls.Add(tableArray[row, col]);

                    tableArray[row, col].Click += Form1_Click;

                }
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //THE PROBLEM IS HERE!!!
            Button s = (Button)sender;
            Table t = new Table();
            t.Serv = (RestServer)lstServers.SelectedItem;
            t.AssignCustomer((Customer)lstWaitList.SelectedItem);
            s.Text = t.ToString();
        }

        public void AssignTable(string party, string server, int tableNumber)
        {
            partyTable = party;
            serverTable = server;
            tableNum = tableNumber;
            //Table[,] tArray = new Table[4, 4];

            for (int row = 0; row <= tableArray.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= tableArray.GetUpperBound(1); col++)
                {
                    if (tableNum == (int)tableArray[row, col].Tag)
                    {
                        tableArray[row, col].Text = "Table " + tableNum + "\n" + partyTable + "\n" + serverTable;


                    }
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //we'll call this method elsewhere, but it works
            //c.AddToCustomerTotal(3);
            CReport cr = new CReport();
            cr.lblReport.Text = c.ToString();
            cr.Show();
        }
    }
}