using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIMSContainerDBEFDLL.EntityProxies
{
    public class CameraDtlsTblProxy : CameraDtlsTbl
    {
        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType().Equals(typeof(CameraDtlsTblProxy)) && ((CameraDtlsTblProxy)obj).CameraID.Equals(this.CameraID))
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return "Camera IP: " + this.CameraIP + "\nDevice IP: " + this.CameraPositionMaster.PositionName;
        }
    }
}
