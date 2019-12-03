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
        
        public Bill(string billDate, string description, double amount)
        {
            this.billDate = billDate;
            this.description = description;
            this.amount = amount;
        }

        public string getBillInfo()
        {
            return "";
        }
        public double getBalance()
        {
            return ;
        }
        public bool addPayment(Payment p)
        {
            if(p.verify() == true)
            {
                
            }
            return true;
        }
    }
}