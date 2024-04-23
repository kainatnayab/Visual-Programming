using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem___09_console_app_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int n1, n2, n3, n4, n5,sum;

            Console.WriteLine("Enter 1st number:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number:");
            n2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd number:");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 4th number:");
            n4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 5th number:");
            n5 = Convert.ToInt32(Console.ReadLine());

            //sum of five numbers
            sum = n1 + n2 + n3 + n4 + n5;
            //for output
            Console.WriteLine($"The sum of any five numbers {n1} + {n2} + {n3} + {n4} + {n5} is {sum}.");
            Console.ReadLine();
        }
    }
}
