using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIMSContainerDBEFDLL.EntityProxies
{
    public class LocationTypeMasterProxy : LocationTypeMaster
    {
        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType().Equals(typeof(LocationTypeMasterProxy)) && ((LocationTypeMasterProxy)obj).ID.Equals(this.ID))
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return "Location type name: " + this.LocationTypeName;
        }
    }
}
