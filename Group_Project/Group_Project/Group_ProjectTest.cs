using System;
using NUnit.Framework;

namespace Group_Project
{
    [TestFixture]
    class Group_ProjectTest
    {
        CustomerReport testCustomerReport = new CustomerReport();
        
        public void Init()
        {
            int testCustomerTotal;
            CustomerReport testCustomerReport = new CustomerReport();
            testCustomerReport.AddToCustomerTotal(3);
            testCustomerReport.ToString();
            testCustomerTotal = testCustomerReport.CustomerTotal;
        }
    }
}
