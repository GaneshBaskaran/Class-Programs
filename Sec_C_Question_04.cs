using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_Part1
{
    class Sec_C_Question_04
    {
        static void Main(String[] args)
        {
            Console.Write("Enter the String:");
            String input = Console.ReadLine();
            String inputLower = input.ToLower();
            int len = inputLower.Length;
            String output1 = "", output2 = "";
            for (int index = 0; index <= len - 1; index++)
            {
                if (char.IsPunctuation(inputLower[index]) == false && char.IsWhiteSpace(inputLower[index]) == false)
                {

                    {
                        output1 = output1 + inputLower[index];
                    }


                }
            }

            int newLen = output1.Length;
            for (int index = 0; index <= newLen - 1; index++)
            {
             output2 = output2 + output1.Substring(newLen - 1 - index, 1);
                
            }

            if (output2 == output1)
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
