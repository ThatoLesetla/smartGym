//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartGym.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoice
    {
        public int invoiceNo { get; set; }
        public System.DateTime invoiceDate { get; set; }
        public string description { get; set; }
        public string memID { get; set; }
        public double total { get; set; }
        public Nullable<bool> status { get; set; }
    
        public virtual Member Member { get; set; }
    }
}