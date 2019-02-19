using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_Part1
{
    class Sec_C_Question_02
    {
        static void Main(String[] args)
        {
            Console.Write("Enter the String to find the number of Vowels:");
            String input = Console.ReadLine();
            int len = input.Length;
            int a = 0, e=0, i=0, o=0, u=0;


            for (int index = 0; index <= len - 1; index++)
            {
                if (input.Substring(len - 1 - index, 1) == "a")
                {
                    a++;
                }
                else if (   input.Substring(len - 1 - index, 1) == "e" )
                {
                    e++;
                }
                else if(input.Substring(len - 1 - index, 1) == "i")
                    {
                    i++;
                }
                else if(input.Substring(len - 1 - index, 1) == "o")
                {
                    o++;
                }
                else if(input.Substring(len - 1 - index, 1) == "u")
                {
                    u++;
                }

            }

            Console.WriteLine($"Number of A's : {a} \n " +
                $"Number of E's : {e}\n" +
                $"Number of I's : {i}\n" +
                $"Number of O's : {o}\n" +
                $"Number of U's : {u}\n");

        }
    }
}
