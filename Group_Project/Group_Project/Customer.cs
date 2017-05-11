//Program: Restaurant
//Programmer: John Buhrmann, in conjunction with Ben Jeizan and Cody Bye
//Date: 4 May 2017
//Overview: This program is to be used by restaurants to seat and serve customers in a restaurant.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project
{
    class Customer
    {
        //fields for Customer Class

        string partyName;
        int iD;
        int partySize;

        public Customer()
            {
                //default constructor
            }

        public Customer(string thePName, int theID, int thePSize)
        {
            this.partyName = thePName;
            this.iD = theID;
            this.partySize = thePSize;
        }

        public int ID { get; set; }
        public string PartyName { get; set; }
        public int PartySize { get; set; }

    }
}
