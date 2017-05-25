using System;
using NUnit.Framework;

namespace Group_Project
{
    [TestFixture]
    class Group_ProjectTest
    {
        CustomerReport testCustomerReport = new CustomerReport();
        Table tbl = new Table();
        
        public void Init()
        {
            
        }
        

        

        //Tests for CustomerReportClass
        //PartySize Setter Validation Test
        [Test]
        public void MakeCustomerReport_WithValidatedPartySize()
        {
            int testCustomerTotal;
            bool isCorrectPartySize = false;

            CustomerReport testCustomerReport = new CustomerReport();

            testCustomerReport.AddToCustomerTotal(3);
            testCustomerTotal = testCustomerReport.CustomerTotal;

            if (testCustomerTotal == 3)
            {
                isCorrectPartySize = true;
            }
            else
            {
                isCorrectPartySize = false;
            }
            

            Assert.IsTrue(isCorrectPartySize);
        }

        //ToString Validation Test
        [Test]
        public void MakeCustomerReport_WithValidatedToString()
        {
            string testCustomerString;
            string testCustomerString2;
            bool isCorrectString = false;

            CustomerReport testCustomerReport = new CustomerReport();

            testCustomerReport.AddToCustomerTotal(3);
            testCustomerString = testCustomerReport.ToString();
            testCustomerString2 = "Report: Total Customers: " + testCustomerReport.CustomerTotal.ToString();

            if (testCustomerString == testCustomerString2)
            {
                isCorrectString = true;
            }
            else
            {
                isCorrectString = false;
            }


            Assert.IsTrue(isCorrectString);
        }
        //tests for Table Class
        [Test]
        public void Table_AddServer()
        {
            
        }
    }
}
