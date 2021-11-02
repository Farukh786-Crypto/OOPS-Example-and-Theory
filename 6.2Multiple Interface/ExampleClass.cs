using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample_Theory._6._2Multiple_Interface
{
    interface I1
    {
       void method1();
    }
    interface I2
    {
        void method1();
    }
    class A : I1, I2
    {
        // Explicit interface
        void I1.method1()
        {
            Console.WriteLine("I1 interface has called me...");
        }
        void I2.method1()
        {
            Console.WriteLine("I2 interface has called me...");
        }
    }

   /* class ExampleClass
    {
        static void Main(string[] args)
        {
            I1 i1 = new A();
            i1.method1();

            I2 i2 = new A();
            i2.method1();

            Console.ReadKey();
        }
    }*/
}
