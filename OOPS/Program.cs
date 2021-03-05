using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPS.Factory;
using OOPS.modal;

namespace OOPS
{
    class Program
    {        
        //Factory Pattern : Different Implementation objects of same type
        static void Main(string[] args)
        {
            string Type = Console.ReadLine();
            ObjFactory fac = new ObjFactory();
            IReceipt receipt = fac.getObject(Type);
            string name = receipt.getCustomerName();
            double amount = receipt.getreceiptAmount();
            Console.WriteLine("{0} {1}", name, amount);
            Console.ReadLine();
        }
    }
}
