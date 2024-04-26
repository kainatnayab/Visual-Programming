using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem___01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Roll NO: 03
            //Name  kainat najamudin

         
            int a, b, c;  // Declaration of multiple datatype variables 
            double Discrm, x1, x2;  
            
            Console.WriteLine("Calculate root of Quadratic Equation:");  
          

            Console.Write("Input the value of a : ");  
            a = Convert.ToInt32(Console.ReadLine());  
            Console.Write("Input the value of b : "); 
            b = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Input the value of c : "); 
            c = Convert.ToInt32(Console.ReadLine());

            // Calculate the discriminant
            Discrm = b * b - 4 * a * c;

            if (Discrm == 0)
            {
                Console.WriteLine("x1 and x2 roots are real.");
                x1 = -b / (2 * a);
                x2 = x1;
                Console.WriteLine($"1st root in quadratic equation x1 = {x1}");
                Console.WriteLine($"2nd root in quadratic equation x2 = {x2}");
            }
            else if (Discrm < 0)
            { 
                Console.WriteLine("x1 and x2 roots are imaginary.");  
                x1 = (-b + Math.Sqrt(Discrm)) / (2 * a);  
                x2 = (-b - Math.Sqrt(Discrm)) / (2 * a);  

                Console.WriteLine($"First Root x1= {x1}");  
                Console.WriteLine($"Second Root x2= {x2}"); 
            }
            else
            {
                Console.WriteLine("No Solution.");  
            }
            Console.ReadLine();
        }
    }
}
