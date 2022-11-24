using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample_Theory._3.Polymorphism._3._2Function_Overring
{
    class clsProductClass4
    {        
        public int getTotalCost(int qty,int PerProduct)
        {
            return qty * PerProduct;
        }
        // virtual keyword nesessary to override the method
        public virtual string getTotalCost(int Qty, int PerProduct, string strCurrency)
        {
            return "The Total Cost is :" + ((Qty*PerProduct))+" "+strCurrency;
        }
        
    }
    // class is inherited and "getTotalCost" overriden with new Functionality
    class clsProductWithDiscount : clsProductClass4  // Inherited child Product class
    {
        public int Qty;
        public int PerProduct;
        public int Discount;
        // override keyword is necessasry to define new implementations
        public override string getTotalCost(int Qty, int PerProduct, string strCurrency)
        {
            return "The Total cost with Discount of 10% :" + getTotalCost(Qty, PerProduct, 10).ToString() +
                " " + strCurrency;       
        }
        public int getTotalCost(int qty, int PerProduct,int Discount)
        {
            return (qty * PerProduct)-Discount;
        }
        public void ReadData()
        {
            Console.WriteLine("Enter qty");
            Qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter PerProduct");
            PerProduct = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter intDiscount");
            Discount = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Qty is :" + Qty);
            Console.WriteLine("PerProduct is :" + PerProduct);
            Console.WriteLine("intDiscount is :" + Discount);
        }
      /*  static void Main()
        {
            clsProductWithDiscount obj1 = new clsProductWithDiscount();
            obj1.ReadData();

            if (obj1.Discount == 0) // compile time polymorphism
            {
                Console.WriteLine(obj1.getTotalCost(obj1.Qty, obj1.PerProduct, "INR").ToString());
            }
            else
            {
                Console.WriteLine(obj1.getTotalCost(obj1.Qty, obj1.PerProduct, "INR").ToString());
            }
            obj1.Display();
            Console.ReadKey();
        }*/
    }
}
