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
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class exam_Student
    {
        public int ID { get; set; }
        public int St_ID { get; set; }
        public int ex_id { get; set; }
        public int Mark { get; set; }

        [ForeignKey("ex_id")]
        public virtual Exam Exam { get; set; }
        [ForeignKey("St_ID")]
        public virtual Student Student { get; set; }
    }
}