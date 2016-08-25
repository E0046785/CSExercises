using System;


namespace CSExercises
{
    public class ExH2
    {
        //Write a static method: FindWord(string s1, string s2) that would return an integer.  
        //The method should find if the string s2 occurs in s1 and return an integer that would 
        //indicate the starting position of the word s2 in s1.  If the word does not occur 
        //the return value should be –1.

        public static int FindWord(string s1, string s2)
        {
            
            for(int j=0;j<s1.Length;j++)
            {
               string[] s1WordList = s1.Split(' ');
            }
            //YOUR CODE HERE
            string result= null;
            int resultIndex = -1;
            for (int i = 0; i <; i++)
            {
                if(s1[i].Equals(s2[0]))
                {
                     result = s1.Substring(s1[i], s2.Length);
                     if (result.CompareTo(s2) == 0)
                     {
                         resultIndex = i;

                     }
                    
                }
               
                
            }

            return resultIndex;
        }
        public static void Main(string[] args)
        {
            string s1 = "Hello World";
            string s2 = "World";
            Console.WriteLine(FindWord(s1,s2));
        }
    }
}
