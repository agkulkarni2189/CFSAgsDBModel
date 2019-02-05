using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIMSContainerDBEFDLL.EntityProxies
{
    public class DesignationMasterProxy : DesignationMaster
    {
        public override bool Equals(object obj)
        {
            if ((obj != null && obj.GetType().Equals(typeof(DesignationMasterProxy))) && (((DesignationMasterProxy)obj).ID.Equals(this.ID)) && (((DesignationMasterProxy)obj).DesignationName.Equals(this.DesignationName)))
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return "Designation: " + this.DesignationName;
        }
    }
}
