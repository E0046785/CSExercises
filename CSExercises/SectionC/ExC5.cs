using System;

namespace CSExercises
{
    //Given a three-digit integer as input write a C# program 
    //to determine whether the number is an Armstrong number.
    //
    //An Armstrong number is one for which the sum of each digit 
    //raised to the power of number of digits results in the number itself.
    //
    //For a three digit number 153 =  13 + 53 + 33  
    //
    //Confine the input to 3 digit examples only ie., number values 100…999.


    public class ExC5
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Pleae enter 3 digit number::");
            int digitNum = Convert.ToInt32(Console.ReadLine());
            bool isArmNum = IsArmstrongNumber(digitNum);
            Console.WriteLine(isArmNum);
        }


        public static bool IsArmstrongNumber(int n)
        {
            //YOUR CODE HERE
            int firstDigit = n / 100;
            int secondDigit = (n % 100) / 10;
            int thirdDigit =(n % 100) % 10;
            int result = (firstDigit * firstDigit * firstDigit) + (secondDigit * secondDigit * secondDigit) + (thirdDigit * thirdDigit * thirdDigit);
            if (result == n)
                return true;
            else
                return false;

        }
    }
}