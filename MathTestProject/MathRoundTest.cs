using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTestProject
{
    class MathRoundTest
    {
        public static void Main(string[] args)
        {
            //Rounds a value to the nearest integer or to the specified number of fractional digits.

            //output:125
          //  decimal num = Math.Round(125.101M);
            //output:126
          //  decimal num = Math.Round(125.51M);
            //output :125
            //decimal num = Math.Round(125.09M);
            //output:125.1
         //   decimal num = Math.Round(125.09M,1);
         
          

            //output:123
          // double num = Math.Round(123.45,0);   
            //output:123
            //double num = Math.Round(123.45);            
            //output :123.4
           // double num = Math.Round(123.45,1); 

            //123.45
            //double num = Math.Round(123.45, 2);   
         // output:123.6
           //double num = Math.Round(123.55,1);
            // output:123.55
           //double num = Math.Round(123.55, 2);
            //output:123.55
            double num = Math.Round(123.55,3);
           //output:124
           // double num = Math.Round(123.55); 
            //otput:123
          //  double num = Math.Round(123.005,1); 
           
            Console.WriteLine(num);
        }
    }
}
