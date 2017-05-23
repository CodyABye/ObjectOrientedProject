using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project
{
    class RestServer
    {
        public int ServID { get; set; }
        public string ServName { get; set; }

        public RestServer()
        {

        }
        public RestServer(int theID, string theName)
        {
            this.ServID = theID;
            this.ServName = theName;
        }
        public override string ToString()
        {
            return "Server: " + ServName;
        }
    }
}
