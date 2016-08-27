using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTestProject
{
    class ArrayTest
    {
        public static void Main(string[] args)
        {
            int[] a = new int[] { 2, 3, 6, 9, 10 };
               // PrintArray(a);
           Console.WriteLine(Sum(a));
           Console.WriteLine(Avg(a));
        }
        
        public static void PrintArray(int[] arr)
        {
            Console.WriteLine("{");
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("}");
        }
        
        public static int Sum(int[] arr)
        {
            int total = 0;
            for(int i=0;i<arr.Length;i++)
            {
              //  total = total + arr[i];
                total += arr[i];

            }
            return total;
        }
        public static int Avg(int[] arr)
        {
            int avg = 0;
            avg = Sum(arr) / arr.Length;
            return avg;
        }
            
    }
}
