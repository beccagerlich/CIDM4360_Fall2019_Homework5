// CIDM4360: Becca Gerlich, Gregory Sprock, & Cedric Whitaker

using System;
using System.Collections.Generic;

namespace Homework5
{
    class Check : Payment
    {
        string Bank; // bank name
        string custName; // customer/client name
        string accNum; // account number
        public Check(string b, string c, string num)
        {
            Bank = b;
            custName = c;
            accNum = num;
        }
        public override string getPaymentType()
        {
            return;
        }
    }
}
