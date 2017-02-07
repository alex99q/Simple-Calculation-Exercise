using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime FinalTime;
            string DateFormat = "dd-MM-yyyy";
            var DateString = Console.ReadLine();
            var ConvertedTime = DateTime.ParseExact(DateString,DateFormat, new CultureInfo("bg-BG"),DateTimeStyles.None);
            FinalTime = ConvertedTime.AddDays(999);
            Console.WriteLine(FinalTime.ToString("dd-MM-yyyy"));
        }
    }
}
