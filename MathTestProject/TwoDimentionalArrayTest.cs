using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTestProject
{
    class TwoDimentionalArrayTest
    {
        public static void Main(string[] args)
        {
            int[,] mark = new int[,] {{35,82},{67,65},{62,77}};
            //for(int i=0;i<3;i++)
            //{
            //    for(int j=0;j<2;j++)
            //    {
            //        Console.WriteLine(mark[i,j]);
            //    }
            //}
            for(int i=0;i<mark.GetLength(0);i++)
            {
                for(int j=0;j<mark.GetLength(1);j++)
                {
                    Console.WriteLine(mark[i, j]);
                }

            }
        }
    }
}
