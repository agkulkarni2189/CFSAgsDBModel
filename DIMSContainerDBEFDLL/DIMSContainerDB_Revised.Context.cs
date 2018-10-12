﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DIMContainerDB_RevisedEntities : DbContext
    {
        public DIMContainerDB_RevisedEntities()
            : base("name=DIMContainerDB_RevisedEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CameraDtlsTbl> CameraDtlsTbls { get; set; }
        public virtual DbSet<CameraPositionMaster> CameraPositionMasters { get; set; }
        public virtual DbSet<ContainerTransaction> ContainerTransactions { get; set; }
        public virtual DbSet<ContainerTypeMaster> ContainerTypeMasters { get; set; }
        public virtual DbSet<DamageTransaction> DamageTransactions { get; set; }
        public virtual DbSet<DamageTypeMaster> DamageTypeMasters { get; set; }
        public virtual DbSet<LaneMaster> LaneMasters { get; set; }
        public virtual DbSet<ShippingLineMaster> ShippingLineMasters { get; set; }
        public virtual DbSet<UserMaster> UserMasters { get; set; }
        public virtual DbSet<RoleMaster> RoleMasters { get; set; }
        public virtual DbSet<RoleScreenMapping> RoleScreenMappings { get; set; }
        public virtual DbSet<ScreenMaster> ScreenMasters { get; set; }
        public virtual DbSet<ApplicationConfig> ApplicationConfigs { get; set; }
        public virtual DbSet<OwnerCodeMaster1> OwnerCodeMaster1 { get; set; }
        public virtual DbSet<DamageTransactionDetail> DamageTransactionDetails { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    
        public virtual ObjectResult<Nullable<int>> CameraPositionID()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("CameraPositionID");
        }
    
        public virtual ObjectResult<Nullable<int>> fetch_image_details(Nullable<int> transactionID)
        {
            var transactionIDParameter = transactionID.HasValue ?
                new ObjectParameter("TransactionID", transactionID) :
                new ObjectParameter("TransactionID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("fetch_image_details", transactionIDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> savecamerapositionngdata(string positiondescription, string userdescriptionposition, Nullable<int> containervisible)
        {
            var positiondescriptionParameter = positiondescription != null ?
                new ObjectParameter("positiondescription", positiondescription) :
                new ObjectParameter("positiondescription", typeof(string));
    
            var userdescriptionpositionParameter = userdescriptionposition != null ?
                new ObjectParameter("userdescriptionposition", userdescriptionposition) :
                new ObjectParameter("userdescriptionposition", typeof(string));
    
            var containervisibleParameter = containervisible.HasValue ?
                new ObjectParameter("containervisible", containervisible) :
                new ObjectParameter("containervisible", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("savecamerapositionngdata", positiondescriptionParameter, userdescriptionpositionParameter, containervisibleParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> spsavecameradata(string cameraip, string laneid, string positiondesc)
        {
            var cameraipParameter = cameraip != null ?
                new ObjectParameter("cameraip", cameraip) :
                new ObjectParameter("cameraip", typeof(string));
    
            var laneidParameter = laneid != null ?
                new ObjectParameter("laneid", laneid) :
                new ObjectParameter("laneid", typeof(string));
    
            var positiondescParameter = positiondesc != null ?
                new ObjectParameter("positiondesc", positiondesc) :
                new ObjectParameter("positiondesc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("spsavecameradata", cameraipParameter, laneidParameter, positiondescParameter);
        }
    
        public virtual int spsavelanedata(string ingate, string lanename, string busy, string ipaddress)
        {
            var ingateParameter = ingate != null ?
                new ObjectParameter("ingate", ingate) :
                new ObjectParameter("ingate", typeof(string));
    
            var lanenameParameter = lanename != null ?
                new ObjectParameter("lanename", lanename) :
                new ObjectParameter("lanename", typeof(string));
    
            var busyParameter = busy != null ?
                new ObjectParameter("busy", busy) :
                new ObjectParameter("busy", typeof(string));
    
            var ipaddressParameter = ipaddress != null ?
                new ObjectParameter("ipaddress", ipaddress) :
                new ObjectParameter("ipaddress", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spsavelanedata", ingateParameter, lanenameParameter, busyParameter, ipaddressParameter);
        }
    
        public virtual int spsaveshippinglinedata(string shippinglinename, string companyaddr, string phoneno, string faxno, string emailid1, string emailid2, string emailid3)
        {
            var shippinglinenameParameter = shippinglinename != null ?
                new ObjectParameter("shippinglinename", shippinglinename) :
                new ObjectParameter("shippinglinename", typeof(string));
    
            var companyaddrParameter = companyaddr != null ?
                new ObjectParameter("companyaddr", companyaddr) :
                new ObjectParameter("companyaddr", typeof(string));
    
            var phonenoParameter = phoneno != null ?
                new ObjectParameter("phoneno", phoneno) :
                new ObjectParameter("phoneno", typeof(string));
    
            var faxnoParameter = faxno != null ?
                new ObjectParameter("faxno", faxno) :
                new ObjectParameter("faxno", typeof(string));
    
            var emailid1Parameter = emailid1 != null ?
                new ObjectParameter("emailid1", emailid1) :
                new ObjectParameter("emailid1", typeof(string));
    
            var emailid2Parameter = emailid2 != null ?
                new ObjectParameter("emailid2", emailid2) :
                new ObjectParameter("emailid2", typeof(string));
    
            var emailid3Parameter = emailid3 != null ?
                new ObjectParameter("emailid3", emailid3) :
                new ObjectParameter("emailid3", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spsaveshippinglinedata", shippinglinenameParameter, companyaddrParameter, phonenoParameter, faxnoParameter, emailid1Parameter, emailid2Parameter, emailid3Parameter);
        }
    
        public virtual int spupdatecamerapositioningdata(string primarykey, string positiondescription, string userdescriptionposition, Nullable<int> containervisible)
        {
            var primarykeyParameter = primarykey != null ?
                new ObjectParameter("primarykey", primarykey) :
                new ObjectParameter("primarykey", typeof(string));
    
            var positiondescriptionParameter = positiondescription != null ?
                new ObjectParameter("positiondescription", positiondescription) :
                new ObjectParameter("positiondescription", typeof(string));
    
            var userdescriptionpositionParameter = userdescriptionposition != null ?
                new ObjectParameter("userdescriptionposition", userdescriptionposition) :
                new ObjectParameter("userdescriptionposition", typeof(string));
    
            var containervisibleParameter = containervisible.HasValue ?
                new ObjectParameter("containervisible", containervisible) :
                new ObjectParameter("containervisible", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spupdatecamerapositioningdata", primarykeyParameter, positiondescriptionParameter, userdescriptionpositionParameter, containervisibleParameter);
        }
    
        public virtual int updatecamera(string ipofcamera, Nullable<int> cameraid, string laneid, Nullable<int> positiondesc)
        {
            var ipofcameraParameter = ipofcamera != null ?
                new ObjectParameter("ipofcamera", ipofcamera) :
                new ObjectParameter("ipofcamera", typeof(string));
    
            var cameraidParameter = cameraid.HasValue ?
                new ObjectParameter("cameraid", cameraid) :
                new ObjectParameter("cameraid", typeof(int));
    
            var laneidParameter = laneid != null ?
                new ObjectParameter("laneid", laneid) :
                new ObjectParameter("laneid", typeof(string));
    
            var positiondescParameter = positiondesc.HasValue ?
                new ObjectParameter("positiondesc", positiondesc) :
                new ObjectParameter("positiondesc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updatecamera", ipofcameraParameter, cameraidParameter, laneidParameter, positiondescParameter);
        }
    
        public virtual int UpdateEmptytransaction(Nullable<int> transiD)
        {
            var transiDParameter = transiD.HasValue ?
                new ObjectParameter("TransiD", transiD) :
                new ObjectParameter("TransiD", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateEmptytransaction", transiDParameter);
        }
    
        public virtual int updatelanedata(Nullable<int> id, string ingate, string lanenameold, string lanenamenew, Nullable<int> busy, string ipaddress)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var ingateParameter = ingate != null ?
                new ObjectParameter("ingate", ingate) :
                new ObjectParameter("ingate", typeof(string));
    
            var lanenameoldParameter = lanenameold != null ?
                new ObjectParameter("lanenameold", lanenameold) :
                new ObjectParameter("lanenameold", typeof(string));
    
            var lanenamenewParameter = lanenamenew != null ?
                new ObjectParameter("lanenamenew", lanenamenew) :
                new ObjectParameter("lanenamenew", typeof(string));
    
            var busyParameter = busy.HasValue ?
                new ObjectParameter("busy", busy) :
                new ObjectParameter("busy", typeof(int));
    
            var ipaddressParameter = ipaddress != null ?
                new ObjectParameter("ipaddress", ipaddress) :
                new ObjectParameter("ipaddress", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updatelanedata", idParameter, ingateParameter, lanenameoldParameter, lanenamenewParameter, busyParameter, ipaddressParameter);
        }
    
        public virtual int updateshippingline(Nullable<int> id, string shippinglinenamenew, string shippinglinenameold, string companyaddress, string companyphoneno, string faxno, string emailid1, string emailid2, string emailid3)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var shippinglinenamenewParameter = shippinglinenamenew != null ?
                new ObjectParameter("shippinglinenamenew", shippinglinenamenew) :
                new ObjectParameter("shippinglinenamenew", typeof(string));
    
            var shippinglinenameoldParameter = shippinglinenameold != null ?
                new ObjectParameter("shippinglinenameold", shippinglinenameold) :
                new ObjectParameter("shippinglinenameold", typeof(string));
    
            var companyaddressParameter = companyaddress != null ?
                new ObjectParameter("companyaddress", companyaddress) :
                new ObjectParameter("companyaddress", typeof(string));
    
            var companyphonenoParameter = companyphoneno != null ?
                new ObjectParameter("companyphoneno", companyphoneno) :
                new ObjectParameter("companyphoneno", typeof(string));
    
            var faxnoParameter = faxno != null ?
                new ObjectParameter("faxno", faxno) :
                new ObjectParameter("faxno", typeof(string));
    
            var emailid1Parameter = emailid1 != null ?
                new ObjectParameter("emailid1", emailid1) :
                new ObjectParameter("emailid1", typeof(string));
    
            var emailid2Parameter = emailid2 != null ?
                new ObjectParameter("emailid2", emailid2) :
                new ObjectParameter("emailid2", typeof(string));
    
            var emailid3Parameter = emailid3 != null ?
                new ObjectParameter("emailid3", emailid3) :
                new ObjectParameter("emailid3", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateshippingline", idParameter, shippinglinenamenewParameter, shippinglinenameoldParameter, companyaddressParameter, companyphonenoParameter, faxnoParameter, emailid1Parameter, emailid2Parameter, emailid3Parameter);
        }
    
        public virtual ObjectResult<sp_GetScreensFromRoleID_Result> sp_GetScreensFromRoleID(Nullable<int> roleID)
        {
            var roleIDParameter = roleID.HasValue ?
                new ObjectParameter("RoleID", roleID) :
                new ObjectParameter("RoleID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetScreensFromRoleID_Result>("sp_GetScreensFromRoleID", roleIDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> CameraPositionID1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("CameraPositionID1");
        }
    
        public virtual ObjectResult<Nullable<int>> fetch_image_details1(Nullable<int> transactionID)
        {
            var transactionIDParameter = transactionID.HasValue ?
                new ObjectParameter("TransactionID", transactionID) :
                new ObjectParameter("TransactionID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("fetch_image_details1", transactionIDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> savecamerapositionngdata1(string positiondescription, string userdescriptionposition, Nullable<int> containervisible)
        {
            var positiondescriptionParameter = positiondescription != null ?
                new ObjectParameter("positiondescription", positiondescription) :
                new ObjectParameter("positiondescription", typeof(string));
    
            var userdescriptionpositionParameter = userdescriptionposition != null ?
                new ObjectParameter("userdescriptionposition", userdescriptionposition) :
                new ObjectParameter("userdescriptionposition", typeof(string));
    
            var containervisibleParameter = containervisible.HasValue ?
                new ObjectParameter("containervisible", containervisible) :
                new ObjectParameter("containervisible", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("savecamerapositionngdata1", positiondescriptionParameter, userdescriptionpositionParameter, containervisibleParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> spsavecameradata1(string cameraip, string laneid, string positiondesc)
        {
            var cameraipParameter = cameraip != null ?
                new ObjectParameter("cameraip", cameraip) :
                new ObjectParameter("cameraip", typeof(string));
    
            var laneidParameter = laneid != null ?
                new ObjectParameter("laneid", laneid) :
                new ObjectParameter("laneid", typeof(string));
    
            var positiondescParameter = positiondesc != null ?
                new ObjectParameter("positiondesc", positiondesc) :
                new ObjectParameter("positiondesc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("spsavecameradata1", cameraipParameter, laneidParameter, positiondescParameter);
        }
    
        public virtual int spsavelanedata1(string ingate, string lanename, string busy, string ipaddress)
        {
            var ingateParameter = ingate != null ?
                new ObjectParameter("ingate", ingate) :
                new ObjectParameter("ingate", typeof(string));
    
            var lanenameParameter = lanename != null ?
                new ObjectParameter("lanename", lanename) :
                new ObjectParameter("lanename", typeof(string));
    
            var busyParameter = busy != null ?
                new ObjectParameter("busy", busy) :
                new ObjectParameter("busy", typeof(string));
    
            var ipaddressParameter = ipaddress != null ?
                new ObjectParameter("ipaddress", ipaddress) :
                new ObjectParameter("ipaddress", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spsavelanedata1", ingateParameter, lanenameParameter, busyParameter, ipaddressParameter);
        }
    
        public virtual int spsaveshippinglinedata1(string shippinglinename, string companyaddr, string phoneno, string faxno, string emailid1, string emailid2, string emailid3)
        {
            var shippinglinenameParameter = shippinglinename != null ?
                new ObjectParameter("shippinglinename", shippinglinename) :
                new ObjectParameter("shippinglinename", typeof(string));
    
            var companyaddrParameter = companyaddr != null ?
                new ObjectParameter("companyaddr", companyaddr) :
                new ObjectParameter("companyaddr", typeof(string));
    
            var phonenoParameter = phoneno != null ?
                new ObjectParameter("phoneno", phoneno) :
                new ObjectParameter("phoneno", typeof(string));
    
            var faxnoParameter = faxno != null ?
                new ObjectParameter("faxno", faxno) :
                new ObjectParameter("faxno", typeof(string));
    
            var emailid1Parameter = emailid1 != null ?
                new ObjectParameter("emailid1", emailid1) :
                new ObjectParameter("emailid1", typeof(string));
    
            var emailid2Parameter = emailid2 != null ?
                new ObjectParameter("emailid2", emailid2) :
                new ObjectParameter("emailid2", typeof(string));
    
            var emailid3Parameter = emailid3 != null ?
                new ObjectParameter("emailid3", emailid3) :
                new ObjectParameter("emailid3", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spsaveshippinglinedata1", shippinglinenameParameter, companyaddrParameter, phonenoParameter, faxnoParameter, emailid1Parameter, emailid2Parameter, emailid3Parameter);
        }
    
        public virtual int spupdatecamerapositioningdata1(string primarykey, string positiondescription, string userdescriptionposition, Nullable<int> containervisible)
        {
            var primarykeyParameter = primarykey != null ?
                new ObjectParameter("primarykey", primarykey) :
                new ObjectParameter("primarykey", typeof(string));
    
            var positiondescriptionParameter = positiondescription != null ?
                new ObjectParameter("positiondescription", positiondescription) :
                new ObjectParameter("positiondescription", typeof(string));
    
            var userdescriptionpositionParameter = userdescriptionposition != null ?
                new ObjectParameter("userdescriptionposition", userdescriptionposition) :
                new ObjectParameter("userdescriptionposition", typeof(string));
    
            var containervisibleParameter = containervisible.HasValue ?
                new ObjectParameter("containervisible", containervisible) :
                new ObjectParameter("containervisible", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spupdatecamerapositioningdata1", primarykeyParameter, positiondescriptionParameter, userdescriptionpositionParameter, containervisibleParameter);
        }
    
        public virtual int updatecamera1(string ipofcamera, Nullable<int> cameraid, string laneid, Nullable<int> positiondesc)
        {
            var ipofcameraParameter = ipofcamera != null ?
                new ObjectParameter("ipofcamera", ipofcamera) :
                new ObjectParameter("ipofcamera", typeof(string));
    
            var cameraidParameter = cameraid.HasValue ?
                new ObjectParameter("cameraid", cameraid) :
                new ObjectParameter("cameraid", typeof(int));
    
            var laneidParameter = laneid != null ?
                new ObjectParameter("laneid", laneid) :
                new ObjectParameter("laneid", typeof(string));
    
            var positiondescParameter = positiondesc.HasValue ?
                new ObjectParameter("positiondesc", positiondesc) :
                new ObjectParameter("positiondesc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updatecamera1", ipofcameraParameter, cameraidParameter, laneidParameter, positiondescParameter);
        }
    
        public virtual int UpdateEmptytransaction1(Nullable<int> transiD)
        {
            var transiDParameter = transiD.HasValue ?
                new ObjectParameter("TransiD", transiD) :
                new ObjectParameter("TransiD", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateEmptytransaction1", transiDParameter);
        }
    
        public virtual int updatelanedata1(Nullable<int> id, string ingate, string lanenameold, string lanenamenew, Nullable<int> busy, string ipaddress)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var ingateParameter = ingate != null ?
                new ObjectParameter("ingate", ingate) :
                new ObjectParameter("ingate", typeof(string));
    
            var lanenameoldParameter = lanenameold != null ?
                new ObjectParameter("lanenameold", lanenameold) :
                new ObjectParameter("lanenameold", typeof(string));
    
            var lanenamenewParameter = lanenamenew != null ?
                new ObjectParameter("lanenamenew", lanenamenew) :
                new ObjectParameter("lanenamenew", typeof(string));
    
            var busyParameter = busy.HasValue ?
                new ObjectParameter("busy", busy) :
                new ObjectParameter("busy", typeof(int));
    
            var ipaddressParameter = ipaddress != null ?
                new ObjectParameter("ipaddress", ipaddress) :
                new ObjectParameter("ipaddress", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updatelanedata1", idParameter, ingateParameter, lanenameoldParameter, lanenamenewParameter, busyParameter, ipaddressParameter);
        }
    
        public virtual int updateshippingline1(Nullable<int> id, string shippinglinenamenew, string shippinglinenameold, string companyaddress, string companyphoneno, string faxno, string emailid1, string emailid2, string emailid3)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var shippinglinenamenewParameter = shippinglinenamenew != null ?
                new ObjectParameter("shippinglinenamenew", shippinglinenamenew) :
                new ObjectParameter("shippinglinenamenew", typeof(string));
    
            var shippinglinenameoldParameter = shippinglinenameold != null ?
                new ObjectParameter("shippinglinenameold", shippinglinenameold) :
                new ObjectParameter("shippinglinenameold", typeof(string));
    
            var companyaddressParameter = companyaddress != null ?
                new ObjectParameter("companyaddress", companyaddress) :
                new ObjectParameter("companyaddress", typeof(string));
    
            var companyphonenoParameter = companyphoneno != null ?
                new ObjectParameter("companyphoneno", companyphoneno) :
                new ObjectParameter("companyphoneno", typeof(string));
    
            var faxnoParameter = faxno != null ?
                new ObjectParameter("faxno", faxno) :
                new ObjectParameter("faxno", typeof(string));
    
            var emailid1Parameter = emailid1 != null ?
                new ObjectParameter("emailid1", emailid1) :
                new ObjectParameter("emailid1", typeof(string));
    
            var emailid2Parameter = emailid2 != null ?
                new ObjectParameter("emailid2", emailid2) :
                new ObjectParameter("emailid2", typeof(string));
    
            var emailid3Parameter = emailid3 != null ?
                new ObjectParameter("emailid3", emailid3) :
                new ObjectParameter("emailid3", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateshippingline1", idParameter, shippinglinenamenewParameter, shippinglinenameoldParameter, companyaddressParameter, companyphonenoParameter, faxnoParameter, emailid1Parameter, emailid2Parameter, emailid3Parameter);
        }
    
        public virtual int sp_UserLogout(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UserLogout", userIDParameter);
        }
    
        public virtual int sp_MapScreensToRoles(Nullable<int> roleID)
        {
            var roleIDParameter = roleID.HasValue ?
                new ObjectParameter("RoleID", roleID) :
                new ObjectParameter("RoleID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_MapScreensToRoles", roleIDParameter);
        }
    
        public virtual int sp_GetMissingTransactions(Nullable<System.DateTime> startTime, Nullable<System.DateTime> endTime)
        {
            var startTimeParameter = startTime.HasValue ?
                new ObjectParameter("StartTime", startTime) :
                new ObjectParameter("StartTime", typeof(System.DateTime));
    
            var endTimeParameter = endTime.HasValue ?
                new ObjectParameter("EndTime", endTime) :
                new ObjectParameter("EndTime", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_GetMissingTransactions", startTimeParameter, endTimeParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int sp_StoreDamageDetails()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_StoreDamageDetails");
        }
    }
}
