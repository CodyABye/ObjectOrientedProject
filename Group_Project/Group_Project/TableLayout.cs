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
        public ListBox[,] tableListbox = new ListBox[4, 4];
        private Panel tableBoard;

        //Form1 cust_Table = new Form1();
        //GroupBox[,] tableID = new GroupBox[4, 4];

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

        public void Customer_Table(string party)
        {
            string client = party;
            tableListbox[1, 1].Items.Add(client);
        }

        private void BuildBoard()
        {
            int startLeft = 30;
            int startTop = 10;
            int tableName = 0;

            for (int row = 0; row <= tableListbox.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= tableListbox.GetUpperBound(1); col++)
                {
                    tableListbox[row, col] = new ListBox();
                    tableListbox[row, col].Location = new System.Drawing.Point(startLeft + (col * 175), startTop + (row * 120));
                    tableListbox[row, col].Tag = row + ", " + col;
                    tableListbox[row, col].Height = 120;
                    tableListbox[row, col].Width = 120;
                    tableListbox[row, col].Name = "Table " + tableName++;
                    tableBoard.Controls.Add(tableListbox[row, col]);
                }
            }
        }



    }
}

