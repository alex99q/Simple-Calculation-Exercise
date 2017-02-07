using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = double.Parse(Console.ReadLine());
            var valuta = Console.ReadLine();
            var izhodna_valuta = Console.ReadLine();
            double izhodna_suma;

            if (valuta == "BGN" && izhodna_valuta == "USD")
            {
                izhodna_suma = Math.Round((suma * (1/1.79549)), 2);
                Console.WriteLine(izhodna_suma);
            }

            if (valuta == "BGN" && izhodna_valuta == "EUR")
            {
                izhodna_suma = Math.Round((suma * (1/1.95583)), 2);
                Console.WriteLine(izhodna_suma);
            }

            if (valuta == "BGN" && izhodna_valuta == "GBP")
            {
                izhodna_suma = Math.Round((suma * (1/2.53405)), 2);
                Console.WriteLine(izhodna_suma);
            }

            if (valuta == "USD" && izhodna_valuta == "BGN")
            {
                izhodna_suma = Math.Round((suma * 1.79549), 2);
                Console.WriteLine(izhodna_suma);
            }

            if (valuta == "USD" && izhodna_valuta == "EUR")
            {
                izhodna_suma = Math.Round(((suma * 1.79549) * (1 / 1.95583)), 2);
                Console.WriteLine(izhodna_suma);
            }

            if (valuta == "USD" && izhodna_valuta == "GBP")
            {
                izhodna_suma = Math.Round((suma * 1.79549) * (1 / 2.53405), 2);
                Console.WriteLine(izhodna_suma);
            }

            if (valuta == "EUR" && izhodna_valuta == "BGN")
            {
                izhodna_suma = Math.Round(suma * 1.95583, 2);
                Console.WriteLine(izhodna_suma);
            }

            if (valuta == "EUR" && izhodna_valuta == "USD")
            {
                izhodna_suma = Math.Round((suma * 1.95583) * (1 / 1.79549), 2);
                Console.WriteLine(izhodna_suma);
            }

            if (valuta == "EUR" && izhodna_valuta == "GBP")
            {
                izhodna_suma = Math.Round((suma * 1.95583) * (1 / 2.53405), 2);
                Console.WriteLine(izhodna_suma);
            }

            if (valuta == "GBP" && izhodna_valuta == "BGN")
            {
                izhodna_suma = Math.Round(suma * 2.53405, 2);
                Console.WriteLine(izhodna_suma);
            }

            if (valuta == "GBP" && izhodna_valuta == "USD")
            {
                izhodna_suma = Math.Round((suma * 2.53405)*(1 / 1.79549), 2);
                Console.WriteLine(izhodna_suma);
            }

            if (valuta == "GBP" && izhodna_valuta == "EUR")
            {
                izhodna_suma = Math.Round((suma * 2.53405) * (1 / 1.95583), 2);
                Console.WriteLine(izhodna_suma);
            }
        }
    }
}
