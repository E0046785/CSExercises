using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Examples
{
    class Program1
    {
        static void Main(string[] args)
        {
            string name = "John";
            double weight = 70.2;
            int height = 180;

            Console.Write("Hello ");
            Console.Write(name);
            Console.WriteLine("!");

            Console.WriteLine("Hello ", name, "!");

            Console.WriteLine("Hello " + name + "!");

            Console.WriteLine(weight);
            Console.WriteLine(weight + height);
            Console.WriteLine(weight + name);

            Console.WriteLine(name + " has a height of " + 
                height + "cm and " + "weight of " + weight + "kg.");

            Console.WriteLine("{0} has a height of {1} and weight of {2}", 
                name, height, weight); //recommended
            Console.WriteLine("{1} has a height of {2} and weight of {2}",
                name, height, weight);

            Console.WriteLine("Name:\t{0}\nHeight:\t{1}\nWeight:\t{2}",
                name, height, weight);
            Console.WriteLine("Someone said :\"It's going to rain\"");
            Console.WriteLine("My file is on C:\\Data\\song.txt");
        }
    }
}
