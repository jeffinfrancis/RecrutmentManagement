//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecruitmentManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Candidate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PAN { get; set; }
        public System.DateTime InterviewDate { get; set; }
        public Nullable<int> Levels { get; set; }
        public string Status { get; set; }
        public string AddedBy { get; set; }
    }
}