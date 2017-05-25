using System;
using NUnit.Framework;

namespace Group_Project
{
    [TestFixture]
    class Table_Test
    {
        Table tbl = new Table();

        public void Init()
        {

        }
        [Test]
        public void Table_AddServer()
        {
            bool isThere;
            RestServer srv = new Group_Project.RestServer(1, "Nancy");
            tbl.AssignServer(srv);
            if (tbl.Serv != null)
            {
                isThere = true;
            }
            else
            {
                isThere = false;
            }
            Assert.IsTrue(isThere);
        }
        [Test]
        public void Table_AddParty()
        {
            bool isThere;
            Customer pty = new Group_Project.Customer("Smiths", 5);
            tbl.AssignCustomer(pty);
            if(tbl.Party != null)
            {
                isThere = true;
            }
            else
            {
                isThere = false;
            }
            Assert.IsTrue(isThere);
        }

    }
}
