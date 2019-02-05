using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIMSContainerDBEFDLL
{
    public class DBUtility : DbContext
    {
        public DBUtility() : base("DIMContainerDB_Revised_DevEntities")
        {
        }

        
    }

    class DIMSContainerDBInitializer : CreateDatabaseIfNotExists<DIMContainerDB_Revised_DevEntities>
    {
        protected override void Seed(DIMContainerDB_Revised_DevEntities context)
        {
            RoleMaster FirstRole = new RoleMaster() {
                RoleName = "Super User",
                IsSuperUser = true
            };

            DesignationMaster FirstDesignation = new DesignationMaster() {
                DesignationName = "IT Admin"
            };

            LocationTypeMaster FirstLocationType = new LocationTypeMaster() {
                LocationTypeName = "Server Room",
                IsGate = false,
                IsTransactionEnabled = false
            };

            DeviceTypeMaster FirstDeviceType = new DeviceTypeMaster()
            {
                DeviceTypeName = "Windows Server"
            };

            List<CompanyTypeMaster> InitialCompanyTypes = new List<CompanyTypeMaster>() {
                new CompanyTypeMaster()
                {
                    CompanyType = "Owner Firm"
                },
                new CompanyTypeMaster()
                {
                    CompanyType = "Partner Firm"
                },
                new CompanyTypeMaster()
                {
                    CompanyType = "Third Party Firm"
                }
            };

            context.RoleMasters.Add(FirstRole);
            context.DesignationMasters.Add(FirstDesignation);
            context.LocationTypeMasters.Add(FirstLocationType);
            context.DeviceTypeMasters.Add(FirstDeviceType);
            context.CompanyTypeMasters.AddRange(InitialCompanyTypes);
            context.SaveChanges();


            //RoleMaster RecentRole = context.RoleMasters.OrderByDescending(a => a.ID).FirstOrDefault();
            //DesignationMaster FirstDesignation = context.DesignationMasters.OrderByDescending(a => a.ID).FirstOrDefault();
            //LocationTypeMaster RecentLocationType = context.LocationTypeMasters.OrderBy(a => a.ID).FirstOrDefault();
            //DeviceTypeMaster RecentDeviceType = context.DeviceTypeMasters.OrderBy(a => a.ID).FirstOrDefault();

            context.RoleDesignationMappingMasters.Add(new RoleDesignationMappingMaster()
            {
                DesignationID = FirstDesignation.ID,
                RoleID = FirstRole.ID,
                DesignationMaster = FirstDesignation,
                RoleMaster = FirstRole
            });

            context.UserMasters.Add(new UserMaster()
            {
                FirstName = "SuperUser",
                LastName = "Cfs",
                ContactNo = "9999999999",
                DesignationID = FirstDesignation.ID,
                DesignationMaster = FirstDesignation,
                EmailId = "super.user@cfs.in",
                IsActive = true,
                IsLoggedin = false,
                Password = "su@cfs",
                UserName = "sucfs",
            });

            context.LocationTypeRoleMappingMasters.Add(new LocationTypeRoleMappingMaster()
            {
                LocationTypeMaster = FirstLocationType,
                RoleMaster = FirstRole,
                LocationTypeID = FirstLocationType.ID,
                RoleID = FirstRole.ID
            });

            context.LocationMasters.AddRange(new List<LocationMaster>()
            {
                new LocationMaster()
                {
                    LocationName = "Application server room",
                    LocationDesc = "Main application server operates from this location",
                    LocationTypeMaster = FirstLocationType,
                    LocationTypeID = FirstLocationType.ID
                },
                new LocationMaster()
                {
                    LocationName = "Database server room",
                    LocationDesc = "Main database server operates from this location",
                    LocationTypeMaster = FirstLocationType,
                    LocationTypeID = FirstLocationType.ID
                }
            });

            context.DeviceMasters.AddRange(new List<DeviceMaster>
            {
                new DeviceMaster()
                {
                    DeviceIP = "192.168.1.60",
                    DeviceMACAddress =  "F48E387A150A",
                    DeviceName = "Application Server-Win Server2012r",
                    IsActive = true,
                    DeviceTypeID = FirstDeviceType.ID,
                    DeviceTypeMaster = FirstDeviceType
                },
                new DeviceMaster()
                {
                    DeviceIP = "192.168.1.71",
                    DeviceMACAddress = "F48H387A150C",
                    DeviceName = "Database Server-Win Server2012r",
                    DeviceTypeID = FirstDeviceType.ID,
                    DeviceTypeMaster = FirstDeviceType
                }
            });

            context.LocationTypeDeviceTypeMappingMasters.Add(new LocationTypeDeviceTypeMappingMaster()
            {
                LocationTypeID = FirstLocationType.ID,
                DeviceTypeID = FirstDeviceType.ID,
                DeviceTypeMaster = FirstDeviceType,
                LocationTypeMaster = FirstLocationType
            });

            context.ScreenMasters.AddRange(new List<ScreenMaster>()
            {
                new ScreenMaster()
                {
                    ScreenName = "Home",
                    ScreenUrl = "Default.aspx"
                },
                new ScreenMaster()
                {
                    ScreenName = "Screens",
                    ScreenUrl = "ScreenMaster.aspx"
                }
            });

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
