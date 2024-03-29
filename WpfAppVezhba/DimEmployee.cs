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
    
    public partial class DimEmployee
    {
        public DimEmployee()
        {
            this.DimEmployee1 = new HashSet<DimEmployee>();
            this.FactResellerSales = new HashSet<FactResellerSales>();
            this.FactSalesQuota = new HashSet<FactSalesQuota>();
        }
    
        public int EmployeeKey { get; set; }
        public Nullable<int> ParentEmployeeKey { get; set; }
        public string EmployeeNationalIDAlternateKey { get; set; }
        public string ParentEmployeeNationalIDAlternateKey { get; set; }
        public Nullable<int> SalesTerritoryKey { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public bool NameStyle { get; set; }
        public string Title { get; set; }
        public Nullable<System.DateTime> HireDate { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string LoginID { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public string MaritalStatus { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactPhone { get; set; }
        public Nullable<bool> SalariedFlag { get; set; }
        public string Gender { get; set; }
        public Nullable<byte> PayFrequency { get; set; }
        public Nullable<decimal> BaseRate { get; set; }
        public Nullable<short> VacationHours { get; set; }
        public Nullable<short> SickLeaveHours { get; set; }
        public bool CurrentFlag { get; set; }
        public bool SalesPersonFlag { get; set; }
        public string DepartmentName { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Status { get; set; }
        public byte[] EmployeePhoto { get; set; }
    
        public virtual ICollection<DimEmployee> DimEmployee1 { get; set; }
        public virtual DimEmployee DimEmployee2 { get; set; }
        public virtual DimSalesTerritory DimSalesTerritory { get; set; }
        public virtual ICollection<FactResellerSales> FactResellerSales { get; set; }
        public virtual ICollection<FactSalesQuota> FactSalesQuota { get; set; }
    }
}
