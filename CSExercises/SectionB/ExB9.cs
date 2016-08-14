using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company problem above, 
    //calculate the fare so that the fare is always 
    //rounded upwards to the nearest 10 cents. 
    //This is harder than the previous problem 
    //and requires your ingenuity

    public class ExB9
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Please enter kilometer");
            double testNum =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(CalculateFare(testNum));          
        }

        public static double CalculateFare(double distance)
        {
            //YOUR CODE HERE
            double totalFares = 2.40 + distance * 0.4;
            double mul = totalFares * 10;
            double cel = Math.Ceiling(mul);
            return cel * 0.1 ;

        }
    }
}
