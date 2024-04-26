using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace problem___04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ROLL NO: 03
            //Name  kainat najamudin
            double convt,r;
            double num1, num2, num3, num4;
            Console.WriteLine("Input type of conversions:");

            //initializing the variables
            num1 = 12.45;
            num2 = 38.48;
            num3 = 48.79;
            num4 = 87.49;
            convt = 0;
            //Use Switchstatement
            switch (convt)
            {
                case 1:
                    Console.Write("The value in inches:");
                    r =2.54 * num1;
                    break;
                case 2:
                    Console.Write("The value in gallon:");
                    r = 3.785 * num2;
                    break;
                case 3:
                    Console.Write("The value in mile:");
                    r = 1.609 * num3;
                    break;
                case 4:
                    Console.Write("The value in pound:");
                    r = 0.4536 * num4;
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
                 r = 0;
                Console.WriteLine($"The value after conversion is:{r}.");
                Console.ReadLine();
        }
    }
}
