﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var dollar = double.Parse(Console.ReadLine());
            double leva = dollar * 1.79549;
            Console.WriteLine(Math.Round(leva,2));
        }
    }
}
