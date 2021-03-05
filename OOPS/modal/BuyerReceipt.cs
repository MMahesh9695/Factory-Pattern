using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.modal
{
    class BuyerReceipt : IReceipt
    {
        public string getCustomerName()
        {
            return "Mahesh";
        }

        public double getreceiptAmount()
        {
            return 200.00;
        }

        public string getReceiptType()
        {
            return "Buyer";
        }
    }
}
