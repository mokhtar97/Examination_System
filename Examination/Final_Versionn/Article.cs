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

    public partial class Article
    {
        [Key]
        public int Ar_ID { get; set; }
        public string answer { get; set; }
        public int ID_question { get; set; }
       [ForeignKey("ID_question")]
        public virtual Question Question { get; set; }
    }
}