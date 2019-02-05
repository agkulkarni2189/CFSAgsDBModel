using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIMSContainerDBEFDLL.EntityProxies
{
    public class DeviceMasterProxy : DeviceMaster
    {
        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType().Equals(typeof(DeviceMasterProxy)) && ((DeviceMasterProxy)obj).ID.Equals(this.ID))
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return "Location name: " + this.DeviceName + "\nDevice IP: " + this.DeviceIP;
        }
    }
}
