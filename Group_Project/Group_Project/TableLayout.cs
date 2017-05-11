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

        public TableLayout()
        {
            AllTables = new List<TablePosition>();
            int xCoor = 6;
            int yCoor = 19;
            for(int y=0; y<4; y++)
            {
                for(int x=0; x<5; x++)
                {
                    TablePosition tabl = new TablePosition(xCoor, yCoor);
                    AllTables.Add(tabl);
                    xCoor += 126;
                }
                xCoor = 6;
                yCoor += 101;
            }
        }
        

       

        public void addTablePosition(TablePosition tableP)
        {
            //try
            //{
                AllTables.Add(tableP);
            //}
            /*catch
            {
                if(tableP.Equals(null))
                {
                    MessageBox.Show("Table's null");
                }
                MessageBox.Show("Something's not right");
            }*/
        }


    }
}
