using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIMSContainerDBEFDLL.EntityProxies
{
    public class ContainerTypeMasterProxy : ContainerTypeMaster
    {
        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType().Equals(typeof(ContainerTypeMasterProxy)) && ((ContainerTypeMasterProxy)obj).ContainerTypeID.Equals(this.ContainerTypeID))
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return "Location name: " + this.ContainerTypeName;
        }
    }
}
