using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_Part1
{
    class Sec_B_Question_03
    {
        static void Main(String[] args)
        {
            Console.Write("Enter a number:");
            int input = int.Parse(Console.ReadLine());
            int j = 0;

            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                {
                    j++;
                }

            }

            if (j == 2)
            {
                Console.WriteLine($"The number {input} is a Prime Number");
            }
            else
                Console.WriteLine($"The number {input} is not a Prime Number");

        }
    }
    }
