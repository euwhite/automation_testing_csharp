using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreExample
{
    class Invoice
    {
        // fields
        private string partNo;
        private string partDescription;
        private int quantity;
        private decimal price;

        // constructor
        public Invoice(string partNo, string partDescription, int quantity, decimal price)
        {
            PartNo = partNo;
            PartDescription = partDescription;
            Quantity = quantity;
            Price = price;
        }

        // get-set accessors
        public string PartNo
        {
            get;
            set;
        }

        public string PartDescription
        {
            get;
            set;
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (quantity >= 0)
                {
                    quantity = value;
                }
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (price >= 0)
                {
                    price = value;
                }

            }
        }

        // methods
        public void GetInvoiceAmount(string partNo, string partDescription, int quantity, decimal price)
        {
            Console.WriteLine("The amount of the Invoice is " + (quantity * price));
        }
    }
}
