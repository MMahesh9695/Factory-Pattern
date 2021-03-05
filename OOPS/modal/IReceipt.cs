using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.modal
{
    interface IReceipt
    {
        string getCustomerName();
        string getReceiptType();
        double getreceiptAmount();
    }
}
