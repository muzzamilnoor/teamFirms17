//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROJECT
    {
        public long ProjectID { get; set; }
        public string ProjectTitle { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public long Org_ID { get; set; }
        public bool IsComplete { get; set; }
        public int EnteredByUser_ID { get; set; }
        public System.DateTime EntryDate { get; set; }
        public Nullable<int> ModifyByUser_ID { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> IsActiveDate { get; set; }
    }
}