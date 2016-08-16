using System;

namespace CSExercises
{
    //The C# language gives facilities for changing cases all to upper or lower - 
    //however, not to title case.  Write a program that would convert a given sentence/phrase to title case.
    //Example
    //“institute of systems science”   =>   “Institute Of System Science”

    public class ExG3
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            string newphrase = ToTitleCase(phrase);

            Console.WriteLine(newphrase);
        }

        public static string ToTitleCase(string phrase)
        {
            //YOUR CODE HERE
         //   string titleWord = phrase;
            string lastString = null;
            string[] s= phrase.Split(' ');
            string[] stringList = new String[s.Length];
            
            for(int i =0;i< s.Length;i++)
            {
                string word = s[i];
               char[]  c = new char[word.Length];
                for (int j = 0; j < word.Length; j++)
                {
                   
                    if(j==0)
                    {
                        c[j] = Char.ToUpper(word[j]);
                    }
                    else 
                    {
                        c[j] = word[j];
                    }
                   
                }
                lastString = new String(c);
                stringList[i] = lastString;
            }


            return string.Join(" ",stringList);


        }
    }
}
