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
    
    public partial class FactSalesQuota
    {
        public int SalesQuotaKey { get; set; }
        public int EmployeeKey { get; set; }
        public int DateKey { get; set; }
        public short CalendarYear { get; set; }
        public byte CalendarQuarter { get; set; }
        public decimal SalesAmountQuota { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual DimDate DimDate { get; set; }
        public virtual DimEmployee DimEmployee { get; set; }
    }
}
