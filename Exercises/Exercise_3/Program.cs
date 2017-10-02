using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //​Ввести число. Вывести на экран его удвоенное значение, если число делится на 7 нацело
            while (true)
            {
                Console.WriteLine("Please, enter any number: ");
                int i = int.Parse(Console.ReadLine());

                int result = i % 7;

                if (result == 0)
                {
                    Console.WriteLine(i * 2);
                }
                else
                    Console.WriteLine("\nSorry, try to enter some new number");
            }

            Console.ReadKey();
        }
    }
}
