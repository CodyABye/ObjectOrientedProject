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
            //tableListbox[1, 1].Items.Add(client);
        }

        private void BuildBoard()
        {
            int startLeft = 30;
            int startTop = 10;
            int tableName = 0;

            for (int row = 0; row <= tableArray.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= tableArray.GetUpperBound(1); col++)
                {
                    tableArray[row, col] = new Table();
                    tableArray[row, col].Location = new System.Drawing.Point(startLeft + (col * 175), startTop + (row * 120));
                    tableArray[row, col].Tag = row + ", " + col;
                    tableArray[row, col].Height = 90;
                    tableArray[row, col].Width = 120;
                    tableArray[row, col].Text = "Table " + ++tableName;
                    tableBoard.Controls.Add(tableArray[row, col]);
                    tableArray[row, col].Click += TableLayout_Click;

                }
            }
        }

        private void TableLayout_Click(object sender, EventArgs e)
        {
            
        }
    }
}

