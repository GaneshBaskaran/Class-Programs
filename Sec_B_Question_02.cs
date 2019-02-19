using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_Part1
{
    class Sec_B_Question_02
    {
        static void Main(String[] args)
        {
            Console.Write( "No# \t");
            Console.Write( "Inverse \t");
            Console.Write( "Square Root \t");
            Console.Write("Square \n");
            for (double i = 1; i <= 10; i++)
            {
                Console.Write("{0:0.0} \t",i);
                Console.Write("{0:0.0##} \t", 1 / i);
                Console.Write("{0:0.0##} \t", Math.Sqrt(i) );
                Console.Write("{0:0.0} \n", Math.Pow(i,2));
            }
        }
    }
}
