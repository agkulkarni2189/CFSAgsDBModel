using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIMSContainerDBEFDLL.EntityProxies
{
    public class DamageTypeMasterProxy : DamageTypeMaster
    {
        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType().Equals(typeof(DamageTypeMasterProxy)) && ((DamageTypeMasterProxy)obj).DmgTypeid.Equals(this.DmgTypeid))
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return "Location name: " + this.DmgTypeName;
        }
    }
}
