using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //​Вводим два числа, вывести их суму, если она в диапазоне от 11 до 19.
            while (true)
            {
                Console.WriteLine("\nPlease, enter the first number: ");
                int i1 = int.Parse(Console.ReadLine());

                Console.WriteLine("\nPlease, enter the second number: ");
                int i2 = int.Parse(Console.ReadLine());

                if ((i1 + i2) >= 11 && (i1 + i2) <= 19)
                {
                    Console.WriteLine("The Addition of the numbers is: " + (i1 + i2));
                }
                else
                {
                    Console.WriteLine("Looks like this is not the numbers we need..., enter some new ones");
                }
            }
        }
    }
}
