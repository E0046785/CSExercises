using FirstApplication.Libraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    class Program
    {
        static void Main(string[] args)
        {
            SecondClass.WriteHeader();
            FirstApplication.Libraries.SecondClass.WriteHeader();
            SecondClass.WriteHeader();

            string myString = "ISS";
            Console.WriteLine(myString);
            myString = myString + "****";
            Console.WriteLine(myString);
        }
    }
}
