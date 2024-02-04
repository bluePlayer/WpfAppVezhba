//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class FactFinance
    {
        public int FinanceKey { get; set; }
        public int DateKey { get; set; }
        public int OrganizationKey { get; set; }
        public int DepartmentGroupKey { get; set; }
        public int ScenarioKey { get; set; }
        public int AccountKey { get; set; }
        public double Amount { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual DimAccount DimAccount { get; set; }
        public virtual DimDate DimDate { get; set; }
        public virtual DimDepartmentGroup DimDepartmentGroup { get; set; }
        public virtual DimOrganization DimOrganization { get; set; }
        public virtual DimScenario DimScenario { get; set; }
    }
}