using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTestProject
{
    class StringTest
    {
        public static void Main(string[] args)
        {
            //string s = "venkat";
            //Console.WriteLine(s.Length);

            //string s = "abc";
            //string r = "xyz";
            //int a =r.CompareTo(s);
            //Console.WriteLine(a);
           // string s = " abc ";
           //Console.WriteLine("*" +s+ "*");
            //string s = "$%$abc%s%$";
            //char[] c = new char[] { '$', '%' };
            //Console.WriteLine("*"+s+"*");
            //string r = s.TrimEnd(c);
            //Console.WriteLine(r);
            //string s = "Institue of system science;";
            //char[] c = new char[] {' ', ';' };
            //string r = s.Trim(c);
            //Console.WriteLine(r);
            //string s = "Hello World";
            //string r = s.Substring(5, 1);
           // Console.WriteLine(r);
            //string s = "abc";
            //string r = "abc";
            //if(s.Equals("abc"))
            //{
            //    Console.WriteLine("s is abc");
            //}
            //if(s.Equals(r))
            //{
            //    Console.WriteLine("Two string are equals");

            //}
            //else
            //{
            //    Console.WriteLine("Two string are not equals");
            //}
            //string s = "Institute Systems science";
            //string r = s.Insert(10, "of");
            //Console.WriteLine(r);
            //Console.WriteLine(r.Substring(9, 4));

            string s = "ABC";
            string r = s.PadLeft(7, 'c');
            string t = "XYZ";
            string y = s.PadRight(6, 'z');
            Console.WriteLine(r);
            Console.WriteLine(y);


        }
    }
}
