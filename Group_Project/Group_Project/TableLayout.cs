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
        public List<Table> AllTables { get; set; }
        private Panel tableBoard;
        //public Table[,] tableListbox = new Table[4, 4];
        public Table[,] TableArray { get; set; }

        //Form1 cust_Table = new Form1();

        //GroupBox[,] tableID = new GroupBox[4, 4];

        public TableLayout() { }

        public TableLayout(Panel theTableBoard)
        {
            this.TableBoard = theTableBoard;
            this.TableArray = new Table[4, 4];
            /*int id = 0;
            for(int x=0; x<4; x++)
            {
                for(int y=0; y<4; y++)
                {
                    AllTables.Add(new Table(id, 10));
                    id++;
                }
            }*/
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
        /*public void Customer_Table(string party)
        {
            string client = party;

            tableListbox[1, 1].Items.Add(client);
        }*/

        private void BuildBoard()
        {
            int startTop = 30;
            int startLeft = 10;
            int tableNum = 0;

            for (int row = 0; row <= TableArray.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= TableArray.GetUpperBound(1); col++)
                {
                    tableNum++;
                    TableArray[row, col] = new Table();
                    TableArray[row, col].Location = new System.Drawing.Point(startTop + (col * 175), startLeft + (row * 120));
                    TableArray[row, col].Tag = row + ", " + col;
                    TableArray[row, col].Height = 120;
                    TableArray[row, col].Width = 120;
                    TableArray[row, col].Name = "Table: " + 1;
                    TableArray[row, col].Items.Add("Table: " + tableNum);
          
                    tableBoard.Controls.Add(TableArray[row, col]);
                }
            }
            
        }
        public void Customer_Table(Customer party)
        {
            Table tbl = TableArray[1, 1];
            tbl.AssignCustomer(party);
            tbl.Update();

            //tableListbox[1, 1].Items.Add(client);
        }

    }
}

