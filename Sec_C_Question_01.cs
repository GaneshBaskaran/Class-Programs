using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_Part1
{
    class Sec_C_Question_01
    {
        static void Main(String[] args)
        {
            Console.Write("Enter the String to find the number of Vowels:");
            String input = Console.ReadLine();
            int len = input.Length;
            int output = 0;
           
            for (int index = 0; index <= len - 1; index++)
            {
                 if (input.Substring(len - 1 - index, 1) == "a" ||
                     input.Substring(len - 1 - index, 1) == "e" ||
                     input.Substring(len - 1 - index, 1) == "i" ||
                     input.Substring(len - 1 - index, 1) == "o" ||
                     input.Substring(len - 1 - index, 1) == "u")
                {
                    output++;
                }

            }

            Console.WriteLine(output);

        }
    }
}
