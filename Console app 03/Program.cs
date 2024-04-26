using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem___03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ROLL NO: 03
            //Name  kainat najamudin

            //declare variables
            double BS, HRA, MA, TA, ITD, GD;
            double GS, NS;
            Console.WriteLine("Enter basic salary:");
            BS = Convert.ToDouble(Console.ReadLine());

            //apply ifelse statement
            if (BS >= 50000)
            {
                HRA = (15 * BS) / 100;
                MA = (25 * BS) / 100;
                TA = 2500;
                ITD = 6 * (BS + HRA + MA + TA);
                GD = 4.8* (BS + HRA + MA + TA);
            }
            else if (BS > 25000 && BS < 50000)
            {
                HRA = 10 * BS;

                MA = 20 * BS;
                TA = 2500;
               ITD = 5 * (BS + HRA + MA + TA);
               GD = 4.5 * (BS + HRA + MA + TA);
            }
            else if (BS > 10000 && BS < 25000)
            {
                HRA = (5 * BS) / 100;
                MA = (20 * BS) / 100;
                TA = 2000;
                ITD = 1000;
                GD = 500;
            }
            else
            {
               HRA = 0;
               MA = (5 * BS) / 100;
                TA = 1500;
                ITD = 500;
                GD = 200;
            }

            GS= BS + HRA + MA + TA;
            NS = GS - ITD - GD;
            //for output
            Console.WriteLine($"House Rent Allowance: {HRA}.");
            Console.WriteLine($"Medical Allowance: {MA}.");
            Console.WriteLine($"Travelling Allowance: {TA}.");
            Console.WriteLine($"Gross Salary: {GS}.");
            Console.WriteLine($"Income Tax Deduction: {ITD}.");
            Console.WriteLine($"Gratuity Deduction: {GD}.");
            Console.WriteLine($"Net Salary: {NS}.");
            Console.ReadLine();
        }
    }
}
