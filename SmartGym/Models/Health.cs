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
    using System.Web;
    public partial class Health
    {
        public string memId { get; set; }
        public double height { get; set; }
        public double weight { get; set; }
        public double BMI { get; set; }
        public string imageUrl { get; set; }
        public Nullable<System.DateTime> updated { get; set; }
        public int id { get; set; }
        public Nullable<int> healthStatus { get; set; }
        public HttpPostedFileBase ImageFile { get; set; }
    
        public virtual HealthRange HealthRange { get; set; }
        public virtual Member Member { get; set; }
    }
}