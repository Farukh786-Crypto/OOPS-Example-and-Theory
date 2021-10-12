using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample_Theory._1.Classes_and_Objects
{
    class clsProductClass1
    {
        public int getTotalCost(int intQty, int intPerProduct)
        {
            return intQty * intPerProduct;
        }
       /* static void Main()
        {
            clsProductClass1 obj = new clsProductClass1();
            Console.WriteLine("TotalCost is -:"+ obj.getTotalCost(10, 100));
            Console.ReadKey();
        }*/
    }
}
