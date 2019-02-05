using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIMSContainerDBEFDLL.EntityProxies
{
    public class ContainerTransactionProxy : ContainerTransaction
    {
        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType().Equals(typeof(ContainerTransactionProxy)) && ((ContainerTransactionProxy)obj).TransID.Equals(this.TransID))
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return "Transaction ID: " + this.TransID + "\nTransaction time: " + this.TransactionTime;
        }
    }
}
