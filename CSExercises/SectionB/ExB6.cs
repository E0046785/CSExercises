﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that reads the (x,y) coordinates 
    //of two points.  Compute the distance between the 
    //two points using the formula:

    //  Distance = Square Root of[(x2 – x1 ) 2 + (y2 – y1 ) 2]

    public class ExB6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Please enter value of x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter value of y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter value of x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter value of y2");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(CalculateDistance(x1,y1,x2,y2).ToString());

        }

        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            //YOUR CODE HERE
          //   Distance = Square Root of[(x2 – x1 ) 2 + (y2 – y1 ) 2]
           // double result = 
            double distance = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));
            return distance;
        }
    }
}
