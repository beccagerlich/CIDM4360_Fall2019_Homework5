// CIDM4360: Becca Gerlich, Gregory Sprock, & Cedric Whitaker

using System;
using System.Collections.Generic;

namespace Homework5
{
    class Cash : Payment
    {
        double tenderCash; //cash provided by customer, e.g. $200
        double change; //change should be returned to customer, e.g. if payment amount is $196, the customer provided $200, then he should get back $4
        public Cash(double t, double c) 
        {
            tenderCash = t;
            change = c;
        }
        public double calcChange()
        {

        }
        public override string getPaymentType()
        {
            return;
        }
    }
}