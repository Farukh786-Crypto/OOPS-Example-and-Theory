using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample_Theory._3.Polymorphism._3._1Function_overloading
{
    class clsProductClass3
    {
        public int intQty;
        public int PerProduct;
        public int intDiscount;
        public int getTotalCost(int intQty1,int intPerProduct1)
        {
            return intQty1 * intPerProduct1;
        }
        // method having same name but different input signatures
        public int getTotalCost(int intQty1, int intPerProduct1,int intDiscount1)
        {
            return (intQty1 * intPerProduct1)-intDiscount1;
        }
        public void ReadData()
        {
            Console.WriteLine("Enter qty");
            intQty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter PerProduct");
            PerProduct = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter intDiscount");
            intDiscount = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Qty is :"+intQty);
            Console.WriteLine("PerProduct is :" + PerProduct);
            Console.WriteLine("intDiscount is :" + intDiscount);
        }
       /* static void Main()
        {
            clsProductClass3 obj1 = new clsProductClass3();
            obj1.ReadData();

            if (obj1.intDiscount == 0) // compile time polymorphism
            {
                int total1 = obj1.getTotalCost(obj1.intQty, obj1.PerProduct);// will invoke calculation of total cost without discount
                Console.WriteLine("Toal of :" + total1);
            }
            else
            {
                // will invoke calculation of total cost with discount
                int total2 = obj1.getTotalCost(obj1.intQty, obj1.PerProduct, obj1.intDiscount);
                Console.WriteLine("total :" + total2);
            }
            obj1.Display();
            Console.ReadKey();
        }*/
    }
  
}
