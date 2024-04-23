using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem___02_console_app_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int k, m;
            double cm, f, i;

            //As we know that
            //1kilometre =1000m,1meter =100cm,
            //1centimeter =0.01m,1feet =30.48cm,1inch =2.54cm

            Console.WriteLine("Enter distance in Kilometers:");
            k = Convert.ToInt32(Console.ReadLine());
            //process
            m = k * 1000;
            cm = m * 100;
            f = cm * 30.48f;
            i = cm * 2.54f;
            //for output
            Console.WriteLine($"Distance in Meters is {m} mtr:");
            Console.WriteLine($"Distance in Centimeters is {cm} cmtr:");
            Console.WriteLine($"Distance in Feet is {f} feet:");
            Console.WriteLine($"Distance in Inches is {i} inch:");
            Console.ReadLine();
        }
    }
}
