using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //​​Вводим два числа, если одно из них делиться на другое без остатка
            // - то выводим true и показываем результат деления(целую часть от деления и остаток)
            // - в другом случае выводим false и показываем результат деления(целую часть от деления и остачу)

            while (true)
            {
                Console.WriteLine("\nPlease, enter the first number: ");
                int i1 = int.Parse(Console.ReadLine());

                Console.WriteLine("\nPlease, enter the second number: ");
                int i2 = int.Parse(Console.ReadLine());

                int result = i1 % i2;

                if (result == 0)
                {
                    Console.WriteLine("\nTrue!");
                    Console.WriteLine("Division details are: ");
                    Console.WriteLine("Entire occurencies: " + (i1 / i2));
                }
                else
                {
                    Console.WriteLine("\nFalse :(");
                    Console.WriteLine("Division details are: ");
                    Console.WriteLine("Entire occurencies: " + (i1 / i2));
                    Console.WriteLine("Remainder: " + (i1 % i2));
                }
            }
        }
    }
}
