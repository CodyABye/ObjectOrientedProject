using Group_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project
{
    class Table
    {
        int tableID;
        string status;
        int capacity;
        Customer party;
        //Server serv;
        public Table()
        {

        }
        public Table(int theID, int theCapacity)
        {
            this.tableID = theID;
            this.capacity = theCapacity;
        }
        public int TableID { get; set; }
        public string Status { get; set; }
        public int Capacity { get; set; }
        public Customer Party { get; set; }
        //public Server Serv { get; set; }

        public void AssignCustomer(Customer cust1)
        {
            party = cust1;
        }
        /*public void AssignServer(Server serv1)
        {
            serv = serv1;
        }*/
    }
}
