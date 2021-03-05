using OOPS.modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Factory
{
    class ObjFactory
    {
        IReceipt returnValue;
        public IReceipt getObject(string Type)
        {
            if (Type == "Buyer")
            {
                returnValue = new BuyerReceipt();
            }
            else if (Type == "Seller")
            {
                returnValue = new SellerReceipt();
            }
            return returnValue;
        }
    }
}
