// CIDM4360: Becca Gerlich, Gregory Sprock, & Cedric Whitaker

using System;
using System.Collections.Generic;

namespace Homework5
{
    abstract class Payment
    {
        double amount; //amount of this payment
        string paymentDate; //date of this payment
        public Payment(double a, string p)
        {
            amount = a;
            paymentDate = p;
        }

        public double getAmount()
        {
            return amount;
        }
        public string getPaymentDate()
        {
            return paymentDate;
        }
        public virtual bool verify()
        {

        }
        public abstract string getPaymentType();
    }
}