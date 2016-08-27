using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Examples
{
    class Program6
    {
        public static void Main()
        {
            double x = 100.0;
            double y = 200;

            Console.WriteLine(Math.Sqrt(y));
            Console.WriteLine(Math.Pow(x, 3));

            Console.WriteLine(Math.Round(1.334));
            Console.WriteLine(Math.Round(1.734));

            Console.WriteLine(Math.Floor(1.334));
            Console.WriteLine(Math.Floor(1.734));

            Console.WriteLine(Math.Ceiling(1.334));
            Console.WriteLine(Math.Ceiling(1.734));

            Console.WriteLine(Math.Round(1.334,1));
            Console.WriteLine(Math.Round(1.734,2));

            int i = 100;
            Console.WriteLine(i);
            i++; //i = i + 1;
            Console.WriteLine(i);

            int k = 100;
            Console.WriteLine(++k); //k = k + 1; Console.WriteLine(k); 
            Console.WriteLine(k++); //Console.WriteLine(k); k = k + 1;



        }
    }
}
