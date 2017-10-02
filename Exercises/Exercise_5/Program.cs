using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //​Вводим 2 числа. Если первое число больше второго, то вывести на экран разницу чисел. Если второе больше, то выводим сумму.
            while (true)
            {
                Console.WriteLine("\nPlease, enter the first number: ");
                int i1 = int.Parse(Console.ReadLine());

                Console.WriteLine("\nPlease, enter the second number: ");
                int i2 = int.Parse(Console.ReadLine());

                if (i1 > i2)
                {
                    Console.WriteLine("There is some substraction of these numers: " + (i1 - i2));
                }
                else
                    Console.WriteLine("There is some addition of these numers: " + (i1 + i2));
            }
        }
    }
}
