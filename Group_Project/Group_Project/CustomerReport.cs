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
            if(partySize > 0)
            {
                CustomerTotal += partySize;
            }
            
        }
        public override string ToString()
        {
            if (CustomerTotal > 0)
            {
                return "Report: Total Customers: " + CustomerTotal.ToString();
            }
            else
            {
                return "No Customers Currently";
            }
            
        }
    }
}
