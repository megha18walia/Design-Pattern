using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class ChainPatternExample
    {
        public class ChainException : Exception
        {

            public ChainException() { }
        }

            void AdjustChain() { }

            enum Levels { Manager, Supervisor, Clerk}

            static Random choice = new Random(11);
            static Levels First
            {
                get
                {
                    return ((Levels[])Enum.GetValues(typeof(Levels)))[0];
                }
            }

            class Structure
            {
                public int Limit { get; set; }
                public int Positions { get; set; }
            }

            static Dictionary<Levels, Structure> structure = new Dictionary<Levels, Structure>
            {
                {Levels.Manager, new Structure{ Limit = 9000, Positions = 1 } },
                {Levels.Supervisor, new Structure{ Limit = 4000, Positions = 3 } },
                {Levels.Clerk , new Structure{ Limit = 2000, Positions = 10 } }
            };

            static Dictionary<Levels, List<Handler>> handlersAtLevel = new Dictionary<Levels, List<Handler>>
            {
                { Levels.Manager , new List<Handler>() },
                {Levels.Supervisor , new List<Handler>() },
                {Levels.Clerk, new List<Handler>() }
            };
            class Handler
            {
                Levels level;
                int id;

                public Handler(int id , Levels level)
                {
                    this.id = id;
                    this.level = level;
                }

                public string HandleRequest(int data)
                {
                    if(data < structure[level].Limit)
                    {
                        return "Request of this " + data + " can be handled by " + level + " " + id;
                    }
                    else if(level > First)
                    {
                        Levels nextLevel = --level;
                        int which = choice.Next(structure[nextLevel].Positions);
                        return handlersAtLevel[nextLevel][which].HandleRequest(data);
                    }
                    else
                    {
                        Exception chainException = new ChainException();
                        chainException.Data.Add("Limit", data);
                        throw chainException;
                    }
                }

            }

            public void RunTheOrganization()
            {
                Console.WriteLine("Trusty Bank opens with ");
                foreach(Levels level in Enum.GetValues(typeof(Levels)))
                {
                    for(int i = 0; i< structure[level].Positions; i++)
                    {
                        handlersAtLevel[level].Add(new Handler(i, level));
                    }

                    Console.WriteLine(structure[level].Positions + " " + level + " who deal upto a limit of " + structure[level].Limit);
                }
                Console.WriteLine();

                int[] amounts = { 50, 2000, 1500, 10000, 175, 4500, 2000 };
                foreach(int amount in amounts)
                {
                    try
                    {
                        int which = choice.Next(structure[Levels.Clerk].Positions);
                        Console.WriteLine("Approached Clerk " + which);
                        Console.WriteLine(handlersAtLevel[Levels.Clerk][which].HandleRequest(amount));
                        AdjustChain();
                    }
                    catch(ChainException e)
                    {
                        Console.WriteLine("\n No Facility to handle the request of " + e.Data["Limit"]);
                        Console.WriteLine("Try to break down to smaller request");
                    }
                }

                
                
            }




        
    }
}
