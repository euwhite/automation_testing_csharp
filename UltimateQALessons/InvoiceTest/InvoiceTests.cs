using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HardwareStoreExample;

namespace InvoiceTest
{
    [TestClass]
    public class InvoiceTests
    {
        [TestMethod]
        public void TestGetInvoiceAmount()
        {
            Invoice myInvoice1 = new Invoice("09887", "Apple", 3, 3.50M);
            Assert.AreEqual(10.5M, myInvoice1.GetInvoiceAmt());
        }

        [TestMethod]
        public void TestPartProperty()
        {
            Invoice myInvoice2= new Invoice("09887", "Apple", 3, 3.50M);
            Assert.AreEqual("09887", myInvoice2.Part);
        }

        [TestMethod]
        public void TestPriceProperty()
        {
            Invoice myInvoice3 = new Invoice("09887", "Apple", 3, -3.50M);
            Assert.AreEqual(-3.50M, myInvoice3.Price); // why test is Passed?
        }

        [TestMethod]
        public void TestQuantityProperty()
        {
            Invoice myInvoice4 = new Invoice("09887", "Apple", -3, 3.50M);
            Assert.AreEqual(-3, myInvoice4.Quantity); // why test is Passed?
        }
    }
}
