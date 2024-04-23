using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem__08_console_app_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int var1 = 10, var2 = 20, var3 = 30, fourth;

            Console.WriteLine("Enter first number for 1st variable:");
            var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number for 2nd variable:");
            var2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number for 3rd variable:");
            var3 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Before swapping var1 =  {var1} , var2 =  {var2} , var3 =  {var3}");
            //process
            fourth = var1;
            var1 = var2;
            var2 = var3;
            var3 = fourth;
            Console.Write($"After swapping var1 = {var1} , var2 = {var2}  , var3 =  {var3}");
            Console.ReadLine();
        }
    }
}
