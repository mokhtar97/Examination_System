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

    public partial class Question
    {
        public Question()
        {
            this.Articles = new HashSet<Article>();
            this.exam_question = new HashSet<exam_question>();
            this.MCQ_Choice = new HashSet<MCQ_Choice>();
            this.T_F = new HashSet<T_F>();
        }
    
        [Key]
        public int ID_question { get; set; }
        public string Body { get; set; }
        public int C_ID { get; set; }
        public string type { get; set; }
        public Nullable<bool> is_deleted { get; set; }
    
        public virtual ICollection<Article> Articles { get; set; }
        public virtual Course Course { get; set; }
        public virtual ICollection<exam_question> exam_question { get; set; }
        public virtual ICollection<MCQ_Choice> MCQ_Choice { get; set; }
        public virtual ICollection<T_F> T_F { get; set; }
    }
}
