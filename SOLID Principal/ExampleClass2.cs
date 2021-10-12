using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 // OCP Example 2
namespace OOPSExample_Theory.SOLID_Principal
{
    public class simpleCustomer // simple class
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
    public class GoldCustomer : simpleCustomer // open for extenstion
    {
        public override double CalCulatDiscount()
        {
            return base.CalCulatDiscount()+10;
        }
    }
    public class SilverCustomer : simpleCustomer // open for extenstion
    {
        public override double CalCulatDiscount()
        {
            return base.CalCulatDiscount() + 5;
        }
    }
    public class ErrorHandler1
    {
        public void HandleError(string err)
        {
            System.IO.File.WriteAllText(@"c:\Error.txt",err);
        }
    }
}
