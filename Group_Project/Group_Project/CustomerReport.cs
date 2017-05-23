using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project
{
    class CustomerReport
    {
        public int CustomerTotal { get; set; }
        public CustomerReport()
        {
            CustomerTotal = 0;
        }
        public void AddToCustomerTotal(int partySize)
        {
            CustomerTotal += partySize;
        }
        public override string ToString()
        {
            return "Report: Total Customers: " + CustomerTotal.ToString();
        }
    }
}
