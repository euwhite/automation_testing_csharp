using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        //Вводим число с плавающей точкой с консоли, и проверяем лежит ли оно в диапазоне от 0 до 1
        {
            while (true)
            {
                Console.WriteLine("Please enter some number: ");
                float i = float.Parse(Console.ReadLine());

                if (i > 0 && i < 1)
                {
                    Console.WriteLine("Yep, this number is good!");
                }
                else
                    Console.WriteLine("Nope, enter some new number");
            }
        }
    }
}
