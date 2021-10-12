using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample_Theory._2.Inheritence
{
    class clsProductClass2
    {
        public int getTotalCost(int intPerProductCost, int intQty)
        {
            return (intPerProductCost * intQty);
        }
    }
    class clsProductWithDiscount : clsProductClass2 // colon represent inheritence
    {
        public int getTotalCost(int intPerProductCost, int intQty, int intDiscount)
        {
            return (intPerProductCost * intQty) - intDiscount;
        }
        /*static void Main()
        {
            clsProductWithDiscount productObj = new clsProductWithDiscount();
            productObj.getTotalCost(100,10,3);
            Console.ReadKey();
        }*/
    }
}
