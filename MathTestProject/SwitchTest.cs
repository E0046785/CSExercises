using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTestProject
{
    class SwitchTest
    {
        public static void Main(string[] args)
        {
            //int Day =Convert.ToInt32(Console.ReadLine());
            //switch(Day)
            //{
            //    case 1:
            //        Console.WriteLine("Sun");
            //        break;
            //    case 2:
            //        Console.WriteLine("Mon");
            //        break;
            //    case 3:
            //        Console.WriteLine("Tues");
            //        break;
            //    default:
            //        Console.WriteLine("Out of Range");
            //        break;

            //}

            string Day = Console.ReadLine();
           // switch (Day.ToLower())
            switch (Day)
            {
                case "sun":
                    Console.WriteLine("Sun");
                    break;
                case "mon":
                    Console.WriteLine("Mon");
                    break;
                case "Tues":
                    Console.WriteLine("Tues");
                    break;
                default:
                    Console.WriteLine("Out of Range");
                    break;

            }

        }
    }
}
