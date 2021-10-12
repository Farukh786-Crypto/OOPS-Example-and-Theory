using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample_Theory._5.Abstract_class
{
    abstract class DB
    {
        public abstract void Connect();
        public string DBIpAddress()
        {
            return "10.10.1.1";
        }
    }
    class SQLServer : DB
    {
        public override void Connect()
        {
            Console.WriteLine("This method will connect to SQL Server !!");
        }
    }
    class Oracle : DB
    {
        public override void Connect()
        {
            Console.WriteLine("This method will connect to Oracle !! ");
        }
    }
   /* class Program
    {
        static void Main(string[] args)
        {
            // we cannor create the object of abstract class
            // DB db1 = new DB();
            DB db1 = new SQLServer();
            db1.Connect();

            DB db2 = new Oracle();
            db1.Connect();
            Console.ReadKey();
        }
    }*/

}
