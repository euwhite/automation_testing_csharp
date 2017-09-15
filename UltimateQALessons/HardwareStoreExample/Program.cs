using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice myInvoice = new Invoice("09887", "Apple", 3, 3.50M);

            //Console.WriteLine("Please, enter Invoice Part number:");
            //myInvoice.Part = Console.ReadLine();
            //Console.WriteLine("Please, enter Invoice Description:");
            //myInvoice.Description = Console.ReadLine();
            //Console.WriteLine("Please, enter Invoice Quantity:");
            //myInvoice.Quantity = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please, enter Invoice Price:");
            //myInvoice.Price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Original Invoice information:");
            Console.WriteLine("Part Number: {0}", myInvoice.Part);
            Console.WriteLine("Description: {0}", myInvoice.Description);
            Console.WriteLine("Quantity: {0}", myInvoice.Quantity);
            Console.WriteLine("Price: {0:C}", myInvoice.Price);
            Console.WriteLine("The Invoice Total : {0:C}", myInvoice.GetInvoiceAmt());
        }
    }
}
