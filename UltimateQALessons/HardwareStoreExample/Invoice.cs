using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreExample
{
    public class Invoice
    {
        // fields
        private int quantity;
        private decimal price;

        // constructor
        public Invoice(string part, string description, int quantity, decimal price)
        {
            Part = part;
            Description = description;
            Quantity = quantity;
            Price = price;
        }

        // get-set accessors
        public string Part
        {
            get;
            set;
        }

        public string Description
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
                if (value >= 0)
                {
                    quantity = value;
                }
                else
                {
                    quantity = 1;
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
                if (value >= 0)
                {
                    price = value;
                }
                else
                {
                    price = 0;
                }
            }
        }

        // methods
        public decimal GetInvoiceAmt()
        {
            return Quantity * Price;
        }
    }
}
