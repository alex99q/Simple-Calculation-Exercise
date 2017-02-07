using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zala
{
    class Program
    {
        static void Main(string[] args)
        {
            double w_mesta = 0;
            double h_mesta = 0;
            var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());

            if (h >= 3 && w >= 3 && h <= 100 && w <= 100)
            {
                if ((w * 100) % 70 == 0)
                {
                    w_mesta = (w * 100) / 70;
                }
                else
                h_mesta = ((h * 100) - 100) / 120;
                Console.WriteLine(w_mesta);
                Console.WriteLine(h_mesta);
                Console.WriteLine((w_mesta * h_mesta) - 3);
            }
        }
    }
}
