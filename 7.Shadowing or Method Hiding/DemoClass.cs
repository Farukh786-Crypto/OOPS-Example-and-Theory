using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample_Theory._7.Shadowing_or_Method_Hiding
{
    /// <summary>
    /// code compiled succesfully
    /// </summary>
    class DemoClass1
    {
        // here i is variable
        public int i = 0;
    }
    class DemoClass2 : DemoClass1
    {
        // here i is method
        public void i()
        {
            Console.WriteLine("i is method");
        }
    }
   /* class Program
    {
        static void Main(string[] args)
        {
            DemoClass1 cls1 = new DemoClass1();
            cls1.i = 10;
            DemoClass2 cls2 = new DemoClass2();
            cls2.i();
            Console.ReadKey();
        }
    }*/
}
