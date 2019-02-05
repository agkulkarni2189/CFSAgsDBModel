using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIMSContainerDBEFDLL.EntityProxies
{
    public class CameraPositionMasterProxy : CameraPositionMaster
    {
        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType().Equals(typeof(CameraPositionMasterProxy)) && ((CameraPositionMasterProxy)obj).PositionID.Equals(this.PositionID))
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return "Camera position name: " + this.PositionName;
        }
    }
}
