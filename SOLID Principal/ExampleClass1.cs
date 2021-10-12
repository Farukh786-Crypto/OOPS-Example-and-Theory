using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// SRP Example
namespace OOPSExample_Theory.SOLID_Principal
{
    public class Customer 
    {
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
    public class ErrorHandler
    {
        public void HandleError(string err)
        {
            System.IO.File.WriteAllText(@"c:\Error.txt", err);
        }
    }
}
