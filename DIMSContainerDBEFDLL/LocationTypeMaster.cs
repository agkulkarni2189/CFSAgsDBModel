//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DIMSContainerDBEFDLL
{
    using System;
    using System.Collections.Generic;
    
    public partial class LocationTypeMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LocationTypeMaster()
        {
            this.LocationMasters = new HashSet<LocationMaster>();
            this.LocationTypeDetailsMasters = new HashSet<LocationTypeDetailsMaster>();
            this.LocationTypeDeviceTypeMappingMasters = new HashSet<LocationTypeDeviceTypeMappingMaster>();
            this.LocationTypeRoleMappingMasters = new HashSet<LocationTypeRoleMappingMaster>();
        }
    
        public int ID { get; set; }
        public string LocationTypeName { get; set; }
        public bool IsGate { get; set; }
        public int CreatorUserID { get; set; }
        public bool IsTransactionEnabled { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationMaster> LocationMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationTypeDetailsMaster> LocationTypeDetailsMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationTypeDeviceTypeMappingMaster> LocationTypeDeviceTypeMappingMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationTypeRoleMappingMaster> LocationTypeRoleMappingMasters { get; set; }
    }
}