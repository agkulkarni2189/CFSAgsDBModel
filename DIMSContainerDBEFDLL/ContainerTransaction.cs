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
    
    public partial class ContainerTransaction
    {
        public int TransID { get; set; }
        public Nullable<int> ShippingLineID { get; set; }
        public Nullable<System.DateTime> TransactionTime { get; set; }
        public Nullable<int> LaneID { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> DmgDtlsID { get; set; }
        public Nullable<bool> ContainerDmgd { get; set; }
        public Nullable<int> ContainerTypeID { get; set; }
        public string ContainerCode { get; set; }
        public string IsoCode { get; set; }
        public string VehicleNo { get; set; }
        public string DriverName { get; set; }
        public string BATNo { get; set; }
        public bool Displayed { get; set; }
        public string DIRLocation { get; set; }
        public int TrailerTransID { get; set; }
        public Nullable<int> SequnceOfContan { get; set; }
        public byte[] EmailImg { get; set; }
        public string ContainerType { get; set; }
        public Nullable<bool> IsRotateImages { get; set; }
        public Nullable<bool> CancelStatus { get; set; }
        public Nullable<bool> IsManualTransaction { get; set; }
        public Nullable<bool> IsReportCreated { get; set; }
    
        public virtual ContainerTypeMaster ContainerTypeMaster { get; set; }
        public virtual DamageTransaction DamageTransaction { get; set; }
        public virtual LaneMaster LaneMaster { get; set; }
        public virtual ShippingLineMaster ShippingLineMaster { get; set; }
        public virtual UserMaster UserMaster { get; set; }
    }
}
