using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIMSContainerDBEFDLL.EntityProxies
{
    public class DamageTransactionProxy : DamageTransaction
    {
        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType().Equals(typeof(DamageTransaction)) && ((DamageTransactionProxy)obj).DmgDtlsID.Equals(this.DmgDtlsID))
                return true;
            else
                return false;
        }
    }
}
