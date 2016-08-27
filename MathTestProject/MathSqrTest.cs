using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTestProject
{
    class MathSqrANDPowerTest
    {
       // Returns the square root of a specified number.
        //argument :double type
        public static void Main(string[] args)
        {
            //4.47213595499958
            //Console.WriteLine(Math.Sqrt(20));
            //3
            //Console.WriteLine(Math.Sqrt(9));
            //2
         //   Console.WriteLine(Math.Sqrt(4));
            //2.828...
            //Console.WriteLine(Math.Sqrt(8));

         //  Console.WriteLine(Math.Pow(4, 2));
         //   Console.WriteLine(Math.Pow(4.5, 2));
            //2.6
            //Console.WriteLine(Math.Max(2.5, 2.6));
            //2.5
           // Console.WriteLine(Math.Max(2.5, -2.6));

           // int[] list = new[] { 4,6,7};
           //Console.WriteLine(Math.Max(Math.Max(4,6),7));

           int[] list = new[] { 4, 6, 7,8,9,88 };
           int max=Math.Max(Math.Max(4, 6), 7);
           int max2 = Math.Max(Math.Max(8, 9), max);
           int max3 = Math.Max(88,max2);
          // Console.WriteLine(max2);
           //Console.WriteLine(max3);
            //for(int i=0;i<list.Length;i++)
            //{
            //    for(int j=1;j<list.Length-1;j++)
            //    {
            //        int temp = list[i];
            //        if()
            //    }

            //}
           int min = Math.Min(Math.Min(4, 6), 7);
           int min2 = Math.Min(Math.Min(8, 9), min);
           int min3 = Math.Min(88, min2);
           Console.WriteLine(min2);
           Console.WriteLine(min3);
             
        }
    }
}
