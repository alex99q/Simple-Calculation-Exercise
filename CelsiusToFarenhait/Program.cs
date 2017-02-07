using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFarenhait
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = double.Parse(Console.ReadLine());
            double farenhait = celsius * 1.8 + 32;
            Console.WriteLine(Math.Round(farenhait, 2));
        }
    }
}
