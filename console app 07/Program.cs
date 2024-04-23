using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem___07_console_app_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int var1, var2;

            Console.WriteLine("Enter the number for 1st variable:");
            var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number for 2nd variable:");
            var2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Before swaping of variables:");
            Console.Write($"var1 = {var1} , var2 = {var2}");
            //process
            var1 = var1 * var2;
            var2 = var1 / var2;
            var1 = var1 / var2;
            Console.WriteLine();
            Console.WriteLine($"After swaping of variables:");
            Console.Write($" var1 = {var1} , var2 = {var2}");
            Console.ReadLine();
        }
    }
}
