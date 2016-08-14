using System;



namespace CSExercises
{
    public class ExB10
    {
        //Consider the simple Geometric example of determining 
        //the area of a triangle, given the lengths of 
        //    its three sides a, b and c.
        //
        //Use the formula:  AREA = SQUAREROOT[s(s - a)(s - b)(s - c)]
        //                     where s = (a+b+c) / 2
        //
        //Does your program always work? If not 
        //alter it to consider situations fro which 
        //it fails.You can return a special value like -1 to 
        //indicate that you cannot calculate the area.


        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Enter first side");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second side");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter third side");
            double c = Convert.ToDouble(Console.ReadLine());
            double total = CalculateArea(a, b, c);
           Console.WriteLine(total);
           
            
            

        }

        public static double CalculateArea(double a, double b, double c)
        {
            //YOUR CODE HERE
            double s = (a + b + c) / 2;
            double total = s*((s - a) * (s - b) * (s - c));


            return Math.Sqrt(s);
        }
    }
}