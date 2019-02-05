using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIMSContainerDBEFDLL.EntityProxies
{
    public class DamageTransactionDetailProxy: DamageTransactionDetail
    {
        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType().Equals(typeof(DamageTransactionDetail)) && ((DamageTransactionDetail)obj).ID.Equals(this.ID))
                return true;
            else
                return false;
        }
    }
}
