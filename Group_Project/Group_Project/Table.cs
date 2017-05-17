using Group_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project
{
    class Table : Button
    {
        public int TableID { get; set; }
        public string Status { get; set; }
        public int Capacity { get; set; }
        public Customer Party { get; set; }
        public RestServer Serv { get; set; }

        public Table()
        {

        }

        public Table(int theID, int theCapacity)
        {
            this.TableID = theID;
            this.Capacity = theCapacity;
        }     

        public void AssignCustomer(Customer cust1)
        {
            Party = cust1;
        }

        
        public void AssignServer(RestServer serv1)
        {
            Serv = serv1;
        }
        public void TUpdate()
        {
            this.Text = Party.ToString() + "\n" + Serv.ToString();
        }        
    }
}
