﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfAppVezhba
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class AdventureWorksDW2017Entities : DbContext
    {
        public AdventureWorksDW2017Entities()
            : base("name=AdventureWorksDW2017Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<DatabaseLog> DatabaseLog { get; set; }
        public DbSet<DimAccount> DimAccount { get; set; }
        public DbSet<DimCurrency> DimCurrency { get; set; }
        public DbSet<DimCustomer> DimCustomer { get; set; }
        public DbSet<DimDate> DimDate { get; set; }
        public DbSet<DimDepartmentGroup> DimDepartmentGroup { get; set; }
        public DbSet<DimEmployee> DimEmployee { get; set; }
        public DbSet<DimGeography> DimGeography { get; set; }
        public DbSet<DimOrganization> DimOrganization { get; set; }
        public DbSet<DimProduct> DimProduct { get; set; }
        public DbSet<DimProductCategory> DimProductCategory { get; set; }
        public DbSet<DimProductSubcategory> DimProductSubcategory { get; set; }
        public DbSet<DimPromotion> DimPromotion { get; set; }
        public DbSet<DimReseller> DimReseller { get; set; }
        public DbSet<DimSalesReason> DimSalesReason { get; set; }
        public DbSet<DimSalesTerritory> DimSalesTerritory { get; set; }
        public DbSet<DimScenario> DimScenario { get; set; }
        public DbSet<FactAdditionalInternationalProductDescription> FactAdditionalInternationalProductDescription { get; set; }
        public DbSet<FactCallCenter> FactCallCenter { get; set; }
        public DbSet<FactCurrencyRate> FactCurrencyRate { get; set; }
        public DbSet<FactInternetSales> FactInternetSales { get; set; }
        public DbSet<FactProductInventory> FactProductInventory { get; set; }
        public DbSet<FactResellerSales> FactResellerSales { get; set; }
        public DbSet<FactSalesQuota> FactSalesQuota { get; set; }
        public DbSet<FactSurveyResponse> FactSurveyResponse { get; set; }
        public DbSet<ProspectiveBuyer> ProspectiveBuyer { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<FactFinance> FactFinance { get; set; }
        public DbSet<DimAccount_FactFinance_View1> DimAccount_FactFinance_View1 { get; set; }
        public DbSet<DimReseller_DimGeogrpahy_FactResellerSales_View1> DimReseller_DimGeogrpahy_FactResellerSales_View1 { get; set; }
        public DbSet<vAssocSeqLineItems> vAssocSeqLineItems { get; set; }
        public DbSet<vAssocSeqOrders> vAssocSeqOrders { get; set; }
        public DbSet<vDMPrep> vDMPrep { get; set; }
        public DbSet<vTargetMail> vTargetMail { get; set; }
        public DbSet<vTimeSeries> vTimeSeries { get; set; }
    
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
    
        public virtual ObjectResult<SQLCMD_Test_Procedure_Result> SQLCMD_Test_Procedure()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SQLCMD_Test_Procedure_Result>("SQLCMD_Test_Procedure");
        }
    }
}
