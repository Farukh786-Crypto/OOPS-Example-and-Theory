using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// LISKOV Example 3

namespace OOPSExample_Theory.SOLID_Principal
{
    public interface IEnquiry // not real customer
    {
        double CalCulatDiscount(); // give little Discount but not save in database
    }

    public interface ICustomer : IEnquiry // real Customer
    {
        void Add(); // give discount and also save in database bcoz they are real customer
    }

   
    public class simpleCustomer2 : ICustomer // simple class
    {
        public virtual double CalCulatDiscount()
        {
            return 0;
        }
        public void Add()
        {
            try
            {
                // Adds to Customer database
            }
            catch (Exception ex)
            {

                ErrorHandler obj = new ErrorHandler();
                obj.HandleError(ex.ToString());
            }
        }
    }
    public class EnquiryCustomer2 : IEnquiry
    {
        public double CalCulatDiscount()
        {
            return 2;
        }
    }
    public class GoldCustomer2 : simpleCustomer2 // open for extenstion
    {
        public override double CalCulatDiscount()
        {
            return base.CalCulatDiscount() + 10;
        }
    }
    public class SilverCustomer2 : simpleCustomer2 // open for extenstion
    {
        public override double CalCulatDiscount()
        {
            return base.CalCulatDiscount() + 5;
        }
    }
    public class ErrorHandler2
    {
        public void HandleError(string err)
        {
            System.IO.File.WriteAllText(@"c:\Error.txt", err);
        }
    }
   /* public class Program
    {
        static void Main(string[] args)
        {
            List<simpleCustomer2> obj = new List<simpleCustomer2>();
            obj.Add(new GoldCustomer2());
            obj.Add(new SilverCustomer2());
            //obj.Add(new EnquiryCustomer2()); it is not real customer so we not add to memory

            foreach (simpleCustomer2 o in obj)
            {
                o.Add();
            }
        }
    }*/
}
