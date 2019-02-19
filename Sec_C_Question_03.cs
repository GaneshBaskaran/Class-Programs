using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_Part1
{
    class Sec_C_Question_03
    {
        static void Main(String[] args)
        {
            Console.Write("Enter the String:");
            String input = Console.ReadLine();
            int len = input.Length;
            String output = "";
            for (int index = 0; index <= len - 1; index++)
            {
               
                output = output + input.Substring(len - 1 - index, 1);
            }
            if (input == output)
            {
                Console.WriteLine($"The word {input} is a Palindrome");
            }
            else
            {
                Console.WriteLine($"The word {input} is not a Palindrome");
            }
        }
    }
}
