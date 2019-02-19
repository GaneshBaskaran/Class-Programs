
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_Part1
{
    class Sec_B_Question_01
    {
        static void Main(String[] args)
        {
            Console.Write("Enter a number :");
            int  input = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i=1;i<= input;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine($"Factorial of {input} :"+fact);
        }
    }
}
