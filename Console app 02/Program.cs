using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem___02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ROLL NO: 03
            //Name  kainat najamudin
           
            double phy, mth, comp, bio, chem, percentage, obt;
            int totalmx;
            Console.Write("Calculate the percentage of marks of five subjects:");
            Console.WriteLine();
            Console.Write("Input the marks of physics:");
            phy =Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the marks of mathematics:");
            mth = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the marks of computer:");
            comp = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the marks of Biology:");
            bio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the marks of Chemistry:");
            chem = Convert.ToDouble(Console.ReadLine());
            //calculate obtain marks of five subjects
            obt = phy + mth + comp + bio + chem;
            totalmx = 500;
            //calculate percentage 
            percentage = (obt / totalmx) * 100;
            //apply condition to find the Grade
            if (percentage >= 80)
            {
                Console.Write("Grade: A");
            }
            else if (percentage >= 65)
            {
                Console.Write("Grade: B");
            }
            else if (percentage >= 50)
            {
                Console.Write("Grade: C");
            }
            else if (percentage >= 40)
            {
                Console.Write("Grade: D");
            }
            //(percentage < 40)
            else
            {
                Console.Write("Grade: F");
            }
            Console.WriteLine();
            Console.WriteLine($"The percentage of five subjects is {percentage}.");
            Console.ReadLine();
        }
       
    }
}
