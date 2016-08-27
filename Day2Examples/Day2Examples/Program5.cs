using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Examples
{
    class Program5
    {
        public static void Main()
        {
            Console.WriteLine(1 + 1);
            Console.WriteLine(1 - 1);
            Console.WriteLine(10 * 5);
            Console.WriteLine(10 / 5);
            Console.WriteLine(10 % 3);
            Console.WriteLine(10 / 3);
            Console.WriteLine(10.0 / 3);

            Console.WriteLine("Please enter your name: ");
            string input = Console.ReadLine();

            Console.Write("Please enter your height in cm: ");
            string heightStr = Console.ReadLine();
            int height = Convert.ToInt32(heightStr);

            Console.WriteLine("Hello {0}", input);
            int mToCm = 100;
            Console.WriteLine("Your height is {0} m", 1.0* height / mToCm);
        }
    }
}
