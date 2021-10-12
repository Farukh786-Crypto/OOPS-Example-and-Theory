using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample_Theory._6.Interface_class
{
    interface IDatabase
    {
        void Update();
    }
    class clsProductClass : IDatabase
    {
        public void Update()
        {
            // write your Logic
        }
    }
    class clsSupplier : IDatabase
    {
        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
