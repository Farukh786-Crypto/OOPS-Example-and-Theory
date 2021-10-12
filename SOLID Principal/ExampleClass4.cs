using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ISP Example4
namespace OOPSExample_Theory.SOLID_Principal
{
    public interface IEnquiry4 // not real customer
    {
        double CalCulatDiscount(); // give little Discount but not save in database
    }

    public interface ICustomer4 : IEnquiry4 // real Customer
    {
        void Add(); // give discount and also save in database bcoz they are real customer
    }
    // add new interface
    public interface Iread4 : ICustomer4
    {
        void Read();
    }
    public class NewClient4 : Iread4
    {
        public void Add()
        {
            try
            {
                // Adds to Customer database
            }
            catch (Exception ex)
            {

                ErrorHandler4 obj = new ErrorHandler4();
                obj.HandleError(ex.ToString());
            }
        }

        public double CalCulatDiscount()
        {
            return 7;
        }

        public void Read()
        {
            Console.WriteLine("Read Data !!");
        }
    }
    public class simpleCustomer4 : ICustomer4  // simple class
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

                ErrorHandler4 obj = new ErrorHandler4();
                obj.HandleError(ex.ToString());
            }
        }
    }
    public class EnquiryCustomer4 : IEnquiry4
    {
        public double CalCulatDiscount()
        {
            return 2;
        }
    }
    public class GoldCustomer4 : simpleCustomer4 // open for extenstion
    {
        public override double CalCulatDiscount()
        {
            return base.CalCulatDiscount() + 10;
        }
    }
    public class SilverCustomer4 : simpleCustomer4 // open for extenstion
    {
        public override double CalCulatDiscount()
        {
            return base.CalCulatDiscount() + 5;
        }
    }
    public class ErrorHandler4
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
            // old 30 Customer
            ICustomer4 oldcust = new simpleCustomer4();
            oldcust.Add();


            // new client 5 Client
            Iread4 newcust = new NewClient4();
            newcust.Add();
            newcust.Read(); // add new features Read()


            Console.ReadKey();

        }
    }*/
}
