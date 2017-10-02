using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    Console.WriteLine("\nPlease enter the time between 0 - 24:");
            //    int hour = int.Parse(Console.ReadLine());

            //    if (hour >= 9 && hour <= 10)
            //    {
            //        Console.WriteLine("\nGood Morning!");
            //    }
            //    else if (hour >= 11 && hour <= 19)
            //    {
            //        Console.WriteLine("\nI'll call you back later ater work :(");
            //    }
            //    else if (hour >= 20 && hour <= 24)
            //    {
            //        Console.WriteLine("\nGood night!");
            //    }
            //    else if (hour >= 0 && hour <= 8)
            //    {
            //        Console.WriteLine("\n...Zzz...");
            //    }
            //    else
            //    {
            //        Console.WriteLine("\nSorry, the Time format is incorrect, enter a hour between 0 - 24:");
            //    }
            //}

            int hour = int.Parse(Console.ReadLine());

            switch (hour)
            {
                case 0 - 8:
                    Console.WriteLine("\n...Zzz...");
                    break;
                case 9 - 10:
                    Console.WriteLine("\nGood Morning!");
                    break;
                case 11 - 13:
                    Console.WriteLine("\nI'll call you back later ater work :(");
                    break;
                case 14 - 15:
                    Console.WriteLine("\nLunch");
                    break;
                case 16 - 19:
                    Console.WriteLine("\nI'll call you back later ater work :(");
                    break;
                case 19 - 24:
                    Console.WriteLine("\nGood night!");
                    break;
                default:
                    Console.WriteLine("\nSorry, the Time format is incorrect, enter a hour between 0 - 24:");
                    break;
            }

            Console.ReadKey();
        }
    }
}
