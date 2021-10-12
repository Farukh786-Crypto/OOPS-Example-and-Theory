using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample_Theory.SOLID_Principal
{
    public interface IEnquiry5 // not real customer
    {
        double CalCulatDiscount(); // give little Discount but not save in database
    }

    public interface ICustomer5 : IEnquiry5 // real Customer
    {
        void Add(); // give discount and also save in database bcoz they are real customer
    }
    // add new interface
    public interface Iread5 : ICustomer5
    {
        void Read();
    }
    public class NewClient5 : Iread5
    {
        public void Add()
        {
            try
            {
                // Adds to Customer database
            }
            catch (Exception ex)
            {

                ErrorHandler5 obj = new ErrorHandler5();
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
    public class simpleCustomer5 : ICustomer5  // simple class
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

                ErrorHandler5 obj = new ErrorHandler5();
                obj.HandleError(ex.ToString());
            }
        }
    }
    public class EnquiryCustomer5 : IEnquiry5
    {
        public double CalCulatDiscount()
        {
            return 2;
        }
    }
    public class GoldCustomer5 : simpleCustomer5 // open for extenstion
    {
        public override double CalCulatDiscount()
        {
            return base.CalCulatDiscount() + 10;
        }
    }
    public class SilverCustomer5 : simpleCustomer5 // open for extenstion
    {
        public override double CalCulatDiscount()
        {
            return base.CalCulatDiscount() + 5;
        }
    }

    public interface IErrorHandler5 // create interface for handle error
    {
        void HandleError(string err);
    }
    public class FileErrorHandler5 : IErrorHandler5
    {
        public void HandleError(string err)
        {
            System.IO.File.WriteAllText(@"c:\Error.txt", err);
        }
    }
    public class EventViwerErrorHandler : IErrorHandler5
    { 
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
