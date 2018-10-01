using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StretegyDesignPattern
{
    class PayPalStretegy : IPaymentStretegy
    {
        string emialId;
        string password;

        public PayPalStretegy(string id, string pwd)
        {
            emialId = id;
            password = pwd;
        }

        public void Pay(int amount)
        {
            Console.WriteLine($"Amount {amount} has bene deducted from you paypal Account");
        }
    }
}
