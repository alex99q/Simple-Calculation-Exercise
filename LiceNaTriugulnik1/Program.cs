using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiceNaTriugulnik1
{
    class Program
    {
        static void Main(string[] args)
        {
            var strana = float.Parse(Console.ReadLine());
            var visochina = float.Parse(Console.ReadLine());
            float area = strana * visochina / 2;
            Console.WriteLine(Math.Round(area, 2));
        }
    }
}
