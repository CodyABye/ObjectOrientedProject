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
        int xPos;
        int yPos;
        string tType;

        public TablePosition()
        {

        }
        public TablePosition(int xPosition, int yPosition)
        {
            this.xPos = xPosition;
            this.yPos = yPosition;
        }
        public int XPos { get; set; }
        public int YPos { get; set; }
        public string TType { get; set; }
    }
}
