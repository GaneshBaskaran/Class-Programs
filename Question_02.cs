using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_Part1
{
    class Question_02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Value of A:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Value of B:");
            double b = double.Parse(Console.ReadLine());
            double input1 = a;
            double input2 = b;

            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;

            }
           
                Console.WriteLine($"The HCF of the number{input1} and {input2} is:" + a);
                double HCF = (input1 * input2) / a;
                Console.WriteLine($"The LCM of the number{input1} and {input2} is:" + HCF);
            
        }
    }
}
