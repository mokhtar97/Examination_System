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
    
    public partial class Login
    {
        public Login()
        {
            this.Instructors = new HashSet<Instructor>();
            this.Students = new HashSet<Student>();
        }
    
        public int ID { get; set; }
        public string Password { get; set; }
        public string username { get; set; }
        public string type { get; set; }
    
        public virtual ICollection<Instructor> Instructors { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
