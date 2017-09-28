using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes
{
    class Program
    {

        static void Main(string[] args)
        {
            //MyClass a = new MyClass();
            //a.Value = "start Value";

            //MyClass b = a;
            //b.Value = "new Value";

            //Console.WriteLine(a.Value);
            //Console.ReadLine();

            int a = 1;
            int b = a;

            b = 2;

            Console.WriteLine(a);
            Console.ReadLine();
        }
    }

    class MyClass
    {
        public string Value { get; set; }
    }
}
