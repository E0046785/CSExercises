using System;
namespace CSExercises
{
    public class ExH1

    {
        
        public static bool InString(string s1, string s2)
        {
            //YOUR CODE HERE
            bool isInString = false;

            for (int i = 0; i < s1.Length;i++)
            {
                if(s1[i] == s2[0])
                {
                   string splitString= s1.Substring(i, s2.Length);
                    if(splitString.CompareTo(s2) == 0)
                    {
                        isInString = true;
                    }
                }
            }
            


                return isInString;

        }
        public static void Main(string[] args)
        {       
              string[] s1 = new string[] { "The brown fox", "The brown fox", "The brown fox", "T", "The bras basah complex" };
            string[] s2 = new string[] { "O", "FOX", "bRO", "bRO", "bRO" };
           for(int i=0;i<s1.Length;i++)
           {
            bool isSame = InString(s1[i].ToLower(), s2[i].ToLower());
            Console.WriteLine(isSame);
           }
            

        }
    }
}
