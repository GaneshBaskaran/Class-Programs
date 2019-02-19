using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_Part1
{
    class Question_03
    {
        static void Main(String[] args)
        {
            int i = 0;
            Random rnd = new Random();
            int guessValue = rnd.Next(0, 10);
            int input = 11;
            do
            {
                
                Console.Write("Guess a Number between 0 to 9 :");
                input = int.Parse(Console.ReadLine());
                if (guessValue != input)
                {
                    Console.WriteLine("Wrong Guess. Try Again!!");
                }
                ++i;
            }
            while (guessValue != input);

            Console.WriteLine("You guessed it right!");

            if (i == 1)
            {
                Console.WriteLine("You are a Wizard");
            }
            else if (i > 1 && i < 4)
            {
                Console.WriteLine("You are a  good guess");
            }
            else
                Console.WriteLine("You are a Lousy!!");
            
        }
    }
}
