﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            new ChainPatternExample().RunTheOrganization();
            Console.ReadLine();
        }
    }
}