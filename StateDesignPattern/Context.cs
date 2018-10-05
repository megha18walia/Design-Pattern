using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
   public class Context
    {
        public IState State { get; set; }

        public void Request(char c)
        {
            string result;

            switch(Char.ToLower(c))
            {
                case 'm':
                    result = State.Move(this);
                    break;
                case 'a':
                    result = State.Attack(this);
                    break;
                case 's':
                    result = State.Stop(this);
                    break;
                case 'p':
                    result = State.Panic(this);
                    break;
                case 'c':
                    result = State.CalmDown(this);
                    break;
                case 'r':
                    result = State.Run(this);
                    break;
                default:
                    result = "Error Try again";
                    break;
            }

            Console.WriteLine(result);
        }
    }
}
