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
    
    public partial class CompanyMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompanyMaster()
        {
            this.ProjectMasters = new HashSet<ProjectMaster>();
            this.ProjectMasters1 = new HashSet<ProjectMaster>();
        }
    
        public int ID { get; set; }
        public string LegalTitle { get; set; }
        public int CompanyTypeID { get; set; }
        public string HeadOfficeAddress { get; set; }
    
        public virtual CompanyTypeMaster CompanyTypeMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectMaster> ProjectMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectMaster> ProjectMasters1 { get; set; }
    }
}