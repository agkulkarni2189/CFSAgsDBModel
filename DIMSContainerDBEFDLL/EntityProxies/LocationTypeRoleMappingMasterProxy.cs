using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIMSContainerDBEFDLL.EntityProxies
{
    public class LocationTypeRoleMappingMasterProxy : LocationTypeRoleMappingMaster
    {
        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType().Equals(typeof(LocationTypeRoleMappingMasterProxy)) && ((LocationTypeRoleMappingMasterProxy)obj).ID.Equals(this.ID))
                return true;
            else
                return false;
        }
    }
}
