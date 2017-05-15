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
        public ListBox[,] tableListbox = new ListBox[4, 4];

        //Form1 cust_Table = new Form1();

        //GroupBox[,] tableID = new GroupBox[4, 4];

        public TableLayout() { }

        public TableLayout(Panel theTableBoard)
        {
            this.TableBoard = theTableBoard;
            int id = 0;
            for(int x=0; x<4; x++)
            {
                for(int y=0; y<4; y++)
                {
                    AllTables.Add(new Table(id, 10));
                    id++;
                }
            }
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

            for (int row = 0; row <= tableListbox.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= tableListbox.GetUpperBound(1); col++)
                {

                    tableListbox[row, col] = new Table();
                    tableListbox[row, col].Location = new System.Drawing.Point(startTop + (col * 175), startLeft + (row * 120));
                    tableListbox[row, col].Tag = row + ", " + col;
                    tableListbox[row, col].Height = 120;
                    tableListbox[row, col].Width = 120;
                    tableListbox[row, col].Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    tableListbox[row, col].Name = "Table" + 1;
          
                    tableBoard.Controls.Add(tableListbox[row, col]);
                }
            }
        }
        public void Customer_Table(Customer party)
        {
            Customer client = party;

            tableListbox[1, 1].Items.Add(client);
        }

    }
}

