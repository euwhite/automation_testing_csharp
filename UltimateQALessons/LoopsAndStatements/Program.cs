using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int product = 3;
            int i = 1;

            while (product <= 100)
            {
                product = 3 * product;

                Console.WriteLine("{1} value is {0}", product, i++);
            }

            Console.WriteLine("Final value is {0}", product);
            Console.ReadKey();
        }
    }
}
