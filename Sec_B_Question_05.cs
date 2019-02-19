using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_Part1
{
    class Sec_B_Question_05
    {
        static void Main(String[] args)
        {
            Console.Write("The List of Prime Numbers between 5 and 1000:");
            
            int j = 0;

            for (int i = 5; i <= 1000; i++)
            {
                int n = 0;
                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        n++;
                    }
                }
                if (n == 2)
                {
                   Console.Write(i+"\t");
                   
                }
            }
        
            
        }
    }
}
