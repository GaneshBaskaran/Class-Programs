using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_Part1
{
    class Sec_C_Question_05
    {
        static void Main(String[] args)
        {
            Console.Write("Enter the String:");
            String input = Console.ReadLine();
            string[] sArr = input.Split();
            string output = "";
            for (int i = 0; i < sArr.Length; i++)
            {
                if (sArr[i] != "")
                {
                    output = output + char.ToUpper(sArr[i][0]) + sArr[i].Substring(1)+" ";
                }
            }
             Console.WriteLine(output);
        }
    }
}
