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
            string partNo = Console.ReadLine();
            string partDescription = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            decimal price = decimal.Parse(Console.ReadLine());

            Invoice myInvoice = new Invoice(partNo, partDescription, quantity, price);

            Console.WriteLine(Invoice.GetInvoiceAmount("1", "Description", 5, 10.0m));

        }
    }
}
