using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_Part1
{
    class Sec_B_Question_06
    {
        static void Main(String[] args)
        {
            Console.Write("Enter a number:");
            
            for (int i = 1; i < 1000; i++)
            {
                int n = 0;
                for (int j=1;j<i;j++)
                {
                    if (i % j == 0)
                    {
                        n = n + j;
                    }
                }
                if (n==i)
                {
                    Console.Write(i + "\t");

                }

            }

        }
    }
}
