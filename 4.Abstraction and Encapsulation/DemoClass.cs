using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample_Theory._4.Abstraction_and_Encapsulation
{
    class ProductClass
    {
        
        public string pName;
        private int intQty;

        public int Qty
        {
            get { return intQty; }
            set {
                
                    if (IsQuantityGreater(value))
                    {
                        throw new Exception("Qty exceeds limit :");
                    } 
                intQty = value; 
            }
        }
        private double intPerProductCost;

        public double perProductCost
        {
            get { return intPerProductCost; }
            set {
                if(isProductCostZero(value))
                {
                    throw new Exception("Product never be zero !!");
                }
                
                intPerProductCost = value;
            }
        }


        public void ReadData() // Show user
        {
            Console.WriteLine("Product Name :");
            pName = Console.ReadLine();
            Console.WriteLine("Product Quantity :");
            Qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Per Product Cost :");
            perProductCost = Convert.ToDouble(Console.ReadLine());
            
        }
        // Make Encapsulation
        private bool IsQuantityGreater(int intQty) // Hide Business Logic
        {
            if(intQty > 1000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Make Encapsulation
        private bool isProductCostZero(double PerProductCost) //Hide Business Logic
        {
            if(PerProductCost==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private double TotalCost(int intQty, double PerProductCost) // Hide Logic
        {
            return (intQty * PerProductCost);
        }
        public void Display() // show user
        { 
            Console.WriteLine("Total Cost is :"+TotalCost(intQty, perProductCost));
        }
    }
    /*class Program
    {
        static void Main(string[] args)
        {
            ProductClass product = new ProductClass();
            product.ReadData();
            product.Display();
            Console.ReadKey();
        }
    }*/
}
