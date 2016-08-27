using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Examples
{
    public class Program2
    {
        public static void Main()
        {
            string name1 = "John";
            string name2 = "Jane";

            double salary1 = 13000.50;
            double salary2 = 2500.40;

            Console.WriteLine("{0} earns {1:0.00}", name1, salary1);
            Console.WriteLine("{0} earns {1:0,000.00}", name1, salary1);

            Console.WriteLine("Name \tSalary");
            Console.WriteLine("{0} \t${1:0,000.00}", name1, salary1);
            Console.WriteLine("{0} \t${1:0,000.00}", name2, salary2);

            Console.WriteLine("Name \tSalary");
            Console.WriteLine("{0} \t${1:0,000}", name1, salary1);
            Console.WriteLine("{0} \t${1:0,000}", name2, salary2);

            Console.WriteLine("Name \tSalary");
            Console.WriteLine("{0} \t{1:c}", name1, salary1);
            Console.WriteLine("{0} \t{1:c}", name2, salary2);

        }
    }
}
