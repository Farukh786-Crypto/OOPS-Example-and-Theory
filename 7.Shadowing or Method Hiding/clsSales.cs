using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample_Theory._7.Shadowing_or_Method_Hiding
{
    class clsSales
    {
        public int InvoiceNumber { get; set; }
    }
    class clsSalesVersion2 : clsSales
    {
        // use new keyword for warning bcoz it complete replace with new InvoiceNumber
        public new object InvoiceNumber { get; set; }
    }
   /* class Program
    {
        static void Main(string[] args)
        {
            // for old Client
            clsSales obj1 = new clsSales();
            obj1.InvoiceNumber = 12;

            // for new Client
            clsSalesVersion2 obj2 = new clsSalesVersion2();
            obj2.InvoiceNumber = "c1001";

        }
    }*/
}
