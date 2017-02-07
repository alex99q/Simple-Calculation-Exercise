using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiceNaPravougulnik
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            double strana1;
            double strana2;

            if (y1 > y2)
            strana1 = y1 - y2;
            else strana1 = y2 - y1;

            if (x1 > x2)
            strana2 = x1 - x2;
            else strana2 = x2 - x1;

            Console.WriteLine(strana1 * strana2);
            Console.WriteLine(2 * (strana1 + strana2));
        }
    }
}
