using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context con = new Context();
            con.State = new RestingState();

            char command = ' ';
            Console.WriteLine("Welcome to the state game ");
            Console.WriteLine("You are standing here looking relaxed");
            Console.WriteLine("What would you like to do now ???");
            Console.WriteLine("Move - m , Attack - a , Stop - s , Run - r , Panic - p , Calm Down - c Exit the game ");

            do
            {
                string s = Console.ReadLine();
                if (!(s == null || s == string.Empty))
                {
                    command = s[0];
                    con.Request(command);
                }
            } while (command != 'e');





        }
    }
}
