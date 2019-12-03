// CIDM4360: Becca Gerlich, Gregory Sprock, & Cedric Whitaker

using System;
using System.Collections.Generic;

namespace Homework5
{
    class CreditCard : Payment
    {
        string CCNum; // credit card number
        string expDate; // expiration date
        string CHolderName; // card holder name
        string CType; //Visa,Mastercard,..
        public CreditCard(double amount, string paymentDate, string CCNum, string expDate, string CHolderName, string CType):base(amount, paymentDate)
        {
            this.CCNum = CCNum;
            this.expDate = expDate;
            this.CHolderName = CHolderName;
            this.CType = CType;
        }
        public override bool verify()
        {
            Console.WriteLine("Credit Card Verified");
            return true;
        }
        public override string getPaymentType()
        {
            return "Credit Card";
        }
    }
}