using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem___06_console_app_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            double p, q, f;

            Console.WriteLine("Enter distance of object from lens:");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter distance of image from lens:");
            q = Convert.ToDouble(Console.ReadLine());

            //fomrula

            f = p * q / p + q;

            Console.WriteLine($"The focal length of the lens is {f}.");
            Console.ReadLine();
        }
    }
}
