using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that takes a double precision number 
    //as input and prints the square root of the number.

    public class ExB1
    {
        public static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            double numDouble = Convert.ToDouble(num1);
            double result = SQRT(numDouble);
            Console.WriteLine("{0:0.000}",result);
        }

        public static double SQRT(double x)
        {
            double result2 = Math.Sqrt(x);
            return result2;

        }
    }
}
