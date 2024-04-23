using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem___10_console_app_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarevariables
            int n1, n2, n3, n4, n5;

            Console.WriteLine("Enter 1st number:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number:");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd number:");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 4th number:");
            n4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 5th number:");
            n5 = Convert.ToInt32(Console.ReadLine());

             //reverse process of five numbers in the form of output
            Console.WriteLine($"The reverse of five numbers is {n5}{n4}{n3}{n2}{n1}.");
            Console.ReadLine();
        }
    }
}
