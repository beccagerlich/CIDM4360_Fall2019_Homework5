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
        public CreditCard(string CardNum, string exDate, string CHName, string type)
        {
            CCNum = CardNum;
            expDate = exDate;
            CHolderName = CHName;
            CType = type;
        }
        public override string getPaymentType()
        {
            return;
        }
    }
}