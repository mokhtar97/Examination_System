//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Final_Versionn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Branch
    {
        public Branch()
        {
            this.Instructors = new HashSet<Instructor>();
            this.intake_branch_track = new HashSet<intake_branch_track>();
        }
       [Key]
        public int brn_id { get; set; }
        public string brn_name { get; set; }
        public Nullable<bool> is_deleted { get; set; }
    
        public virtual ICollection<Instructor> Instructors { get; set; }
        public virtual ICollection<intake_branch_track> intake_branch_track { get; set; }
    }
}
