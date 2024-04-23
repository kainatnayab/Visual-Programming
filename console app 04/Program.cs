using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem___04_console_app_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            double frht, cls;

            Console.WriteLine("Enter temperature in  Fahrenheit:");
            frht = Convert.ToDouble(Console.ReadLine());

            //formula of calsius
            cls = 5 / 9 * (frht - 32);
            //for output
            Console.WriteLine($"The tmperature in Fahrenheit to calsius is {cls}.");
            Console.ReadLine();
        }
    }
}
