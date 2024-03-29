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
    
    public partial class DimProduct
    {
        public DimProduct()
        {
            this.FactInternetSales = new HashSet<FactInternetSales>();
            this.FactProductInventory = new HashSet<FactProductInventory>();
            this.FactResellerSales = new HashSet<FactResellerSales>();
        }
    
        public int ProductKey { get; set; }
        public string ProductAlternateKey { get; set; }
        public Nullable<int> ProductSubcategoryKey { get; set; }
        public string WeightUnitMeasureCode { get; set; }
        public string SizeUnitMeasureCode { get; set; }
        public string EnglishProductName { get; set; }
        public string SpanishProductName { get; set; }
        public string FrenchProductName { get; set; }
        public Nullable<decimal> StandardCost { get; set; }
        public bool FinishedGoodsFlag { get; set; }
        public string Color { get; set; }
        public Nullable<short> SafetyStockLevel { get; set; }
        public Nullable<short> ReorderPoint { get; set; }
        public Nullable<decimal> ListPrice { get; set; }
        public string Size { get; set; }
        public string SizeRange { get; set; }
        public Nullable<double> Weight { get; set; }
        public Nullable<int> DaysToManufacture { get; set; }
        public string ProductLine { get; set; }
        public Nullable<decimal> DealerPrice { get; set; }
        public string Class { get; set; }
        public string Style { get; set; }
        public string ModelName { get; set; }
        public byte[] LargePhoto { get; set; }
        public string EnglishDescription { get; set; }
        public string FrenchDescription { get; set; }
        public string ChineseDescription { get; set; }
        public string ArabicDescription { get; set; }
        public string HebrewDescription { get; set; }
        public string ThaiDescription { get; set; }
        public string GermanDescription { get; set; }
        public string JapaneseDescription { get; set; }
        public string TurkishDescription { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Status { get; set; }
    
        public virtual DimProductSubcategory DimProductSubcategory { get; set; }
        public virtual ICollection<FactInternetSales> FactInternetSales { get; set; }
        public virtual ICollection<FactProductInventory> FactProductInventory { get; set; }
        public virtual ICollection<FactResellerSales> FactResellerSales { get; set; }
    }
}
