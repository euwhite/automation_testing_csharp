using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterControlledRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            //Counter controlled repetition
            //int total1 = 0;
            //int value1 = 0;
            //int counter = 1;

            //while (counter <= 3)
            //{
            //    Console.WriteLine("Please enter a number:");
            //    value1 = Convert.ToInt32(Console.ReadLine());

            //    total1 = total1 + value1;
            //    counter++;
            //}

            //Console.WriteLine("\nThe Sum of numbers you've entered is: {0}", total1);
            //Console.ReadKey();



            ////Sentiel controlled repetition
            //int total2 = 0;
            //int value2 = 0;

            //while (value2 != -1)
            //{
            //    Console.WriteLine("Please enter a number or -1 to Exit the program: ");
            //    value2 = Convert.ToInt32(Console.ReadLine());

            //    total2 = total2 + value2;
            //}

            //Console.WriteLine("\nThe Sum of numbers you've entered is: {0}", total2);
            //Console.ReadKey();

            //Nested controlled repetition
            int total3 = 0;
            int value3 = 0;
            int counter3 = 0;

            Console.WriteLine("Please enter a Number which:\n1. More than 0;\n2. Less than 10;\n3. Or enter -1 to Exit the program");

            while (value3 != -1 && counter3 <= 3 && total3 <= 20)
            {
                Console.WriteLine("\nPlease enter your Number: ");
                value3 = Convert.ToInt32(Console.ReadLine());

                counter3++;

                if (value3 > 10) // data validation
                {
                    total3 = total3 + 10;
                    Console.WriteLine("You've entered the value more than 10, so 10 added to the total amount");
                }
                else total3 = total3 + value3;
            }

            Console.WriteLine("Thank you! \nYour Total Number is: {0}", total3);
            Console.ReadKey();
        }
    }
}
