using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIMSContainerDBEFDLL.EntityProxies
{
    public class UserMasterProxy : UserMaster
    {
        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType().Equals(typeof(UserMasterProxy)) && ((UserMasterProxy)obj).UserName.Equals(this.UserName) && ((UserMasterProxy)obj).Password.Equals(this.Password))
            {
                return true;
            }
            else
                return false;
        }


        public override string ToString()
        {
            return "User name: " + this.UserName;
        }
 
    }
}
