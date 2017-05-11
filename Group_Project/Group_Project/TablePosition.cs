using Group_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project
{
    class TablePosition
    {
        public int XPos { get; set; }
        public int YPos { get; set; }
        public string TType { get; set; }

        public TablePosition()
        {

        }
        public TablePosition(int xPosition, int yPosition)
        {
            this.XPos = xPosition;
            this.YPos = yPosition;
        }
        
    }
}
