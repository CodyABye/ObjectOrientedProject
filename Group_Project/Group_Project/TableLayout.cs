using Group_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project
{
    class TableLayout
    {
        public List<TablePosition> AllTables { get; set; }
        public Table[,] tableArray = new Table[4, 4];
        private Panel tableBoard;
        private string partyTable;
        private string serverTable;
        private int tableNum;
        private int partySize;

           

        public TableLayout() { }

        public TableLayout(Panel theTableBoard)
        {
            this.TableBoard = theTableBoard;
        }

       
        public Panel TableBoard
        {
            get { return tableBoard; }
            set { tableBoard = value; }
        }

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
                    tableArray[row, col] = new Table();
                    tableArray[row, col].Location = new System.Drawing.Point(startLeft + (col * 175), startTop + (row * 120));
                    tableArray[row, col].Tag = tableName;
                    tableArray[row, col].Height = 90;
                    tableArray[row, col].Width = 120;
                    tableArray[row, col].Text = "Table " + tableName;
                    

                    //incremented tableName after assignment of .Tag and .Text so tableName would be the same in both.

                    ++tableName;

                    tableBoard.Controls.Add(tableArray[row, col]);

                    tableArray[row, col].Click += TableLayout_Click;

                }
            }
        }

        public void Customer_Table(string party, string server, int tableNumber, int size)
        {
            this.partyTable = party;
            this.serverTable = server;
            this.tableNum = tableNumber;
            this.partySize = size;
        }

        public void Customer_Table(string party, string server, int size)
        {
            partyTable = party;
            serverTable = server;
            partySize = size;
        }

        private void TableLayout_Click(object sender, EventArgs e)
        {
            //string customers = " ", servers = " "; 

            //cust_Table.LoadCustInfo(partyTable, serverTable);

            Button newSender = (Button)sender;

            int senderTag = (int)newSender.Tag;

            
            for (int row = 0; row <= tableArray.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= tableArray.GetUpperBound(1); col++)
                {
                    if (senderTag == (int)tableArray[row,col].Tag)
                    {
                        tableArray[row, col].Text = "Table " + senderTag + "\n" + partyTable + "\n" + serverTable;

                        
                    }
                }

            }
            //sender.AssignCustomer();
            //sender.AssignServer(someserver);
            //sender.TUpdate();

        }

        /*
        public void AssignTable(string party ,string server, int tableNumber)
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

        }*/
    }
}

