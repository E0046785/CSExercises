using System;

namespace CSExercises
{
    //The marks obtained by five students in Programming course are as below:
    //  Name        Mark
    //  John	    63
    //  Venkat	    29
    //  Mary	    75
    //  Victor	    82
    //  Betty	    55

    //Write a program that would take store the above information in two arrays(one for Name and one for Marks.
    //The program would then print two reports:

    //c.First report sorted in descending order of the Marks (i.e.student rank)
    //d.Second report sorted on student names alphabetically.

    public class ExG4
    {
        static string[] studentName = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };
        static int[] mark = new int[] { 63, 29, 75, 82, 55 };
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            

            //string[,] studentMarkList = new string[5, 2];
            //for(int i=0;i<studentMarkList.GetLength(0);i++)
            //{
            //    studentMarkList[i, 0] = studentName[i];
            //    studentMarkList[i, 1] = mark[i];
            //}

            SortMark(mark);
           // SortName(studentName);

           // for(int j=0;j<studentMarkList.GetLength(0);j++)
           //{
           //    for(int k=0;k<studentMarkList.GetLength(1);k++)
           //    {
           //        Console.Write(studentMarkList[j, k] +"\t");
           //    }
           //}


        }
   //     static string[] studentName = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };
     //   static int[] mark = new int[]                  { 63, 29, 75, 82, 55 };
                                                         // {82,75,63,55,29}
        public static void SortMark(int[] marks)
        {
            string[] stuName=new string[5]; 
            int count=0;
            for(int i=0;i<marks.Length-1;i++)
            {
               for(int j=i+1;j<marks.Length;j++)
               {
                   if (marks[j] > marks[i])
                   {
                       int temp = marks[i];
                       marks[i] = marks[j];
                       marks[j] = temp;

                       string tempString = studentName[i];
                       studentName[i] = studentName[j];
                       studentName[j] = tempString;
                      
                        
                   }
                   
                 
                   
               }
              
            }
           Console.WriteLine("Name\t\tMark");
            for(int i=0;i<marks.Length;i++)
            {
                Console.WriteLine("{0}\t\t{1}", studentName[i], mark[i]);               
            }
        }

        public static void SortName(string[] studentName)
        {
            string[] stuName = new string[5];
            
            for (int i = 0; i < studentName.Length - 1; i++)
            {
                for (int j = i + 1; j < studentName.Length; j++)
                {
                    if (studentName[j].CompareTo(studentName[i]) < 0)
                    {
                        int temp = mark[i];
                        mark[i] = mark[j];
                        mark[j] = temp;

                        string tempString = studentName[i];
                        studentName[i] = studentName[j];
                        studentName[j] = tempString;
                    }
                }          

            }
            Console.WriteLine("Name\t\tMark");
            for (int i = 0; i < studentName.Length; i++)
            {
                Console.WriteLine("{0}\t\t{1}", studentName[i], mark[i]);
            }
        }
        //public static void SortMark(string[,] studentMarkList)
        //{
        //    for (int i = 0; i < studentMarkList.GetLength(0)-1; i++)
        //    {
                

        //        for (int j = i + 1; j < studentMarkList.GetLength(0); j++)
        //        {
        //            if (Convert.ToInt32(studentMarkList[j, 1]) > Convert.ToInt32(studentMarkList[i, 1]))
        //            {
        //                string tempName = studentMarkList[i, 0];
        //                int tempMark = Convert.ToInt32(studentMarkList[i, 1]);

        //                studentMarkList[i, 0] = studentMarkList[j, 0];
        //                studentMarkList[i, 1] = studentMarkList[j, 1];

        //                studentMarkList[j, 0] = tempName;
        //                studentMarkList[j, 1] = Convert.ToString(tempMark);

        //            }
        //        }
        //    }
        //    for (int j = 0; j < studentMarkList.GetLength(0); j++)
        //    {
        //        for (int k = 0; k < studentMarkList.GetLength(1); k++)
        //        {
        //            Console.Write(studentMarkList[j, k] + "\t");
        //        }
        //    }
        //}

        //     public static void SortName(string[,] studentMarkList)
        //{
        //   for(int i=0;i<studentMarkList.GetLength(0)-1;i++)
        //   {
        //       string tempName = studentMarkList[i,0];
        //       string tempMark = studentMarkList[i,1];

        //       for(int j=i+1;j<studentMarkList.GetLength(0);j++)
        //       {
        //           if (studentMarkList[j,0].CompareTo(tempName) < 0)
        //           {
                       
        //               studentMarkList[i,0] = studentMarkList[j, 0];
        //               studentMarkList[i, 1] = studentMarkList[j, 1];

        //               studentMarkList[j, 0] = tempName;
        //               studentMarkList[j, 1] = tempMark;
        //           }
        //       }
        //   }
        //   Console.WriteLine("Name\t  Mark");
        //   for (int j = 0; j < studentMarkList.GetLength(0); j++)
        //   {
        //       Console.WriteLine("{0}\t{1}", studentMarkList[j, 0], studentMarkList[j, 1]);   
                  
        //     //  for (int k = 0; k < studentMarkList.GetLength(1); k++)
        //       //{
        //           Console.WriteLine("{0}\t{1}",studentMarkList[j,0],studentMarkList[j,1]);   
                  
        //       //}
        //   }
        //}

    }
}
