using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample_Theory._6.Interface_class
{
    public interface IDB
    {
        void Update();
    }
    public class clsSQLServer : IDB
    {
        public void Update()
        {
            Console.WriteLine("Sql Server Update method !!");
        }
    }
    public class clsOracle : IDB
    {
       
        public void Update()
        {
            Console.WriteLine("Oracle Update method !!");

        }
    }
   /* class clsDatabaseClass1
    {
       
        static void Main(string[] args)
        {
            IDB db = new clsOracle();
            db.Update();
            Console.ReadKey();
        }
        
        
    }*/
}
