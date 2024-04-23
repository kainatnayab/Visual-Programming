using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem___03_console_app0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaration of variables
            double length, width, a, p;

            Console.WriteLine("Length of a rectangle:");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Width of a rectangle:");
            width = Convert.ToDouble(Console.ReadLine());
            //calculate area and perimeter
            a = length * width;
            p = 2 * (length + width);

            Console.WriteLine($"The Area of a rectangle is {a}.");
            Console.WriteLine($"The Perimeter of a rectangle is {p}.");
            Console.ReadLine();
        }
    }
}
