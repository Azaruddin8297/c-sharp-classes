using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class power_of_2
    {
        public static void p2()
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide a value for N as a command-line argument.");
                return;
            }

            int N = int.Parse(args[0]);
            if (N < 0 || N >= 31)
            {
                Console.WriteLine("N must be between 0 and 30 inclusive, because 2^31 overflows an int.");
                return;
            }

            for (int i = 0; i <= N; i++)
            {
                int powerOf2 = (int)Math.Pow(2, i);
                Console.WriteLine("2^{0} = {1}", i, powerOf2);
            }
        }
    }
}
