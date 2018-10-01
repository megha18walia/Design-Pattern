using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StretegyDesignPattern
{
   public class CreditCardStretegy : IPaymentStretegy
    {
        string cardName;
        string cardNumber;
        string ccv;
        string dateOfExpiry;

        public CreditCardStretegy(string name, string number, string ccv, string dob)
        {
            cardName = name;
            cardNumber = number;
            this.ccv = ccv;
            dateOfExpiry = dob;

        }
        public void Pay(int amount)
        {
            Console.WriteLine($"Amount {amount} has been deducted from your card number {cardNumber}.");
        }
    }
}
