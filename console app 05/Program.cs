using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem__05_console_app_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables dclaration
            double vi, t, a, S;

            Console.Write($"Enter initial velocity of car:");
            vi = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Enter time of a car:");
            t = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Enter aceleration of a car:");
            a = Convert.ToDouble(Console.ReadLine());

            //fomula of distance

            S = vi * t + 1 / 2 * a * t * t;

            Console.WriteLine($"Distance covered by car is {S}.");
            Console.ReadLine();
        }
    }
}
