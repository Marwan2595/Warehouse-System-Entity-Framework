//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class Export_Categories
    {
        public int ExportId { get; set; }
        public string CategoryCode { get; set; }
        public System.DateTime Production_Date { get; set; }
        public int Quantity { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Export Export { get; set; }
    }
}
