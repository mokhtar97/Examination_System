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
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class answer_Article
    {
        [Key]
        public int id_answer_Article { get; set; }
        public string answer { get; set; }
        public int ID_exam_question_Student { get; set; }
        public bool Mark { get; set; }
        public int st_id { get; set; }
    
        [ForeignKey("ID_exam_question_Student")]
        public virtual exam_question_Student exam_question_Student { get; set; }
        [ForeignKey("st_id")]
        public virtual Student Student { get; set; }
    }
}
