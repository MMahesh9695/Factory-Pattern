using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.modal
{
    class SellerReceipt : IReceipt
    {
        public string getCustomerName()
        {
            return "Corporate";
        }

        public double getreceiptAmount()
        {
            return 2000.00;
        }

        public string getReceiptType()
        {
            return "Seller";
        }
    }
}
