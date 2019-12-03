// CIDM4360: Becca Gerlich, Gregory Sprock, & Cedric Whitaker

using System;
using System.Collections.Generic;

namespace Homework5
{
    class Bill
    {
        string billDate;
        string description;
        double amount; //bill total amount
        
        public Bill(string b, string d, double a)
        {
            billDate = b;
            description = d;
            amount = a;
        }

        public string getBillinfo()
        {
            return ;
        }
        public double getBalance()
        {
            return ;
        }
        public bool addPayment(Payment p)
        {
            return ;
        }
    }
}