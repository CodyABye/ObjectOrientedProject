using Group_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project
{
    class TableLayout
    {
        List<TablePosition> allTables = new List<TablePosition>();

        public TableLayout()
        {
            int xCoor = 6;
            int yCoor = 19;
            for(int y=0; y<5; y++)
            {
                for(int x=0; x<6; x++)
                {
                    addTablePosition(new TablePosition(xCoor, yCoor));
                    xCoor += 126;
                }
                xCoor = 6;
                yCoor += 101;
            }

        }
        public List<TablePosition> AllTables { get; set; }

        public void addTablePosition(TablePosition tableP)
        {
           // AllTables.Add(tableP);
        }


    }
}
