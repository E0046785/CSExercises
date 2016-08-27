using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTestProject
{
    class MathFloor
    {
        public static void Main(string[] args)
        {
            //Returns the largest integer less than or equal to the 
            //specified double-precision floating-point number.
            //argument:double,decimal
            //double[] values = { 7.03, 7.64, 0.12, -0.12, -7.1, -7.6 };
            //ouput:7,7,0,-1,-8,-8
            //for(int i=0;i<values.Length;i++)
            //{
            //    Console.WriteLine(Math.Floor(values[i]));
            //}

            //output:2
           // double num = Math.Floor(2.345);
            //output:0
            double num = Math.Floor(0.90);
            Console.WriteLine(num);
        }
    }
}
