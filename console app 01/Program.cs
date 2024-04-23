using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem___01_console_app_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarevariables
            int sub1, sub2, sub3, sub4, sub5;
            int sum;
            double avg;

            Console.WriteLine("Enter first subject of marks:");
            sub1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second subject of marks:");
            sub2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third subject of marks :");
            sub3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter fourth subjectof marks :");
            sub4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter fifth subject of marks :");
            sub5 = Convert.ToInt32(Console.ReadLine());
            //process
            sum = sub1 + sub2 + sub3 + sub4 + sub5;
            avg = sum / 5;
            //for output
            Console.WriteLine($"The Sum is{sum}.");
            Console.WriteLine($"The Average is{sum}.");
            Console.ReadLine();
        }
    }
}
