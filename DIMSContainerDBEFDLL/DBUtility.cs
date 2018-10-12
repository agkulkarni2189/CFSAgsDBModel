using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIMSContainerDBEFDLL
{
    public class DBUtility
    {
        private DIMContainerDB_RevisedEntities dcre = null;

        public DBUtility()
        {
            dcre = new DIMContainerDB_RevisedEntities();
            ObjectContext context = ((IObjectContextAdapter)dcre).ObjectContext;

            if (!context.DatabaseExists())
                context.CreateDatabase();
        }
    }
}
