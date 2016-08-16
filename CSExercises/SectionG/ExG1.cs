using System;
using System.Linq;

namespace CSExercises
{
    //Program to count the number of vowels in a given phrase and print out 
    //the number of each vowel. (a, e, i, o & u are vowels)
    //a.Write a program to read a phrase from the console and count the number 
    //of vowels there are in the phrase.You should substring one character at a time and 
    //match it to the vowels and increment the counter.
    //b.Make your program explicitly count the number of occurrences of each vowel 
    //ie: number of a’s, number of e’s etc.)

    public class ExG1
    {
        static char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        public static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            Console.WriteLine("Total number of vowels: " + CountVowels(phrase.ToLower()));

            int[] vowelCount = CountIndividualVowels(phrase.ToLower());
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Number of {0}: {1}", vowels[i], vowelCount[i]);
            }
        }

        public static int CountVowels(string phrase)
        {  
            int vowelCount =0;
              
            //YOUR CODE HERE
            for (int i = 0; i<phrase.Length; i++)
            {
                for(int j=0;j<vowels.Length;j++)
                {
                    if (phrase[i] == vowels[j])
                    {
                        vowelCount++;
                    }
                }
            }
            return vowelCount;


        }

        public static int[] CountIndividualVowels(string phrase)
        {
            
            int[] vowelCount = new int[5];
                        //YOUR CODE HERE
            for (int i = 0; i<phrase.Length;i++)
            {
                for (int j = 0; j <vowels.Length; j++)
                {
                    if (phrase[i] == vowels[j])
                    {

                        vowelCount[j] = vowelCount[j] + 1;
                    }
                }
            }


                return vowelCount;
        }
    }
}
