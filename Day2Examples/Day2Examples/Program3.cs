using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Examples
{
    class Program3
    {
        public static void Main()
        {
            double x = 100.6;
            int y = 3;

            Console.WriteLine("{0}", x / y);
            Console.WriteLine("{0:0.00}", x / y);

            Console.WriteLine("{0:0.00}", 1.33333333);
            Console.WriteLine("{0:0.00}", 1);
            Console.WriteLine("{0:0.00}", 0.3334);

            Console.WriteLine("{0:0.##}", 1.33333333);
            Console.WriteLine("{0:0.##}", 1);
            Console.WriteLine("{0:0.##}", 0.3334);

            Console.WriteLine("{0:#.##}", 1.33333333);
            Console.WriteLine("{0:#.##}", 1);
            Console.WriteLine("{0:#.##}", 0.3334);
        }
    }
}
