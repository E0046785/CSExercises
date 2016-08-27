using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTestProject
{
    class MathCellingTest
    {
        public static void Main (string[] args)
        {
            //7.03, 7.64, 0.12, -0.12, -7.1, -7.6
            //output:-1
          //double input = -1.68;
            //ouput :7005
          //  double input = 7005;
            //output:70
            //double input = 70.0;
            //output:71
            //double input = 70.1;
            //double input = 70.2;
            //double input = 70.6;
            //double input = 70.9;
            //ouput :81
          //  double input = 80.009;
            //output:-70
            //double input = -70.9;
            //output :0
            //double input = -0;
           //output :0
            //double input = -0.9;
            //output -1
          //  double input = -1.0;


            //output:8,8,1,0,-7,-7
            double[] doubleValues = { 7.03, 7.64, 0.12, -0.12, -7.1, -7.6 };
            //output:8,8,1,0,-7,-7
            decimal[] decimalValues = { 7.03m, 7.64m, 0.12m, -0.12m, -7.1m, -7.6m };
            //argument accept only double and decimal type.
            //Returns the smallest integral value that is greater than or equal to
            //the specified double-precision floating-point number.
            //for (int i = 0; i < decimalValues.Length; i++)
            //{
            //    Console.WriteLine(Math.Ceiling(decimalValues[i]));
            //}

            int result = (int)Math.Ceiling(0.9);
           // double result = Math.Ceiling(input);
           Console.WriteLine(result);
        }
    }
}
