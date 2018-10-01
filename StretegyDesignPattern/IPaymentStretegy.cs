using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StretegyDesignPattern
{
    public interface IPaymentStretegy
    {
        void Pay(int amount);
    }
}
