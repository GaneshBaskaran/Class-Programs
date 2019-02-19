using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_Part1
{
    class Question_04
    {
        static void Main(String[] args)
        {
            Console.Write("Enter a number:");
            int input = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            double guess = rnd.Next(1, input + 1);

            while (Math.Round(Math.Pow(guess,2),5, MidpointRounding.AwayFromZero) != input)
            {
                if (Math.Pow(guess, 2) != input)
                {
                    guess = (guess + (input / guess)) / 2;

                }
            }
            Console.WriteLine($"The Square of {input}:"+Math.Round(guess,3, MidpointRounding.AwayFromZero));
        }
    }
}
