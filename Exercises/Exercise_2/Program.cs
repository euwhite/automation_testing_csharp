using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести три числа с консоли, а затем вывести наибольшее и наименьшее 
            while (true)
            {
                Console.WriteLine("Please, enter three numbers: ");
                Console.WriteLine("The first one is: ");
                int i1 = int.Parse(Console.ReadLine());

                Console.WriteLine("\nThe second one is: ");
                int i2 = int.Parse(Console.ReadLine());

                Console.WriteLine("\nThe third one is: ");
                int i3 = int.Parse(Console.ReadLine());

                //which number one is biggest?
                if (i1 > i2 && i1 > i3)
                {
                    Console.WriteLine("Looks like {0} is the biggest number", i1);
                }
                else if (i2 > i1 && i2 > i3)
                {
                    Console.WriteLine("Looks like {0} is the biggest number", i2);
                }
                else
                    Console.WriteLine("Looks like {0} is the biggest number", i3);

                //which number one is smaller?
                if (i1 < i2 && i1 < i3)
                {
                    Console.WriteLine("Looks like {0} is the smaller number", i1);
                }
                else if (i2 < i1 && i2 < i3)
                {
                    Console.WriteLine("Looks like {0} is the smaller number", i2);
                }
                else
                    Console.WriteLine("Looks like {0} is the smaller number", i3);

                Console.ReadKey();
            }
        }
    }
}
