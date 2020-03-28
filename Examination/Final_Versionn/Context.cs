using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Final_Versionn
{
    class Context :DbContext
    {

        public Context() :base($@"Data Source=DESKTOP-OLH3CCS;Initial Catalog=Examination_System;Integrated Security=true")
        { }

     
        public virtual DbSet<answer_Article> answer_Article { get; set; }
        public virtual DbSet<answer_mcq> answer_mcq { get; set; }
        public virtual DbSet<answer_true_false> answer_true_false { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<exam_question> exam_question { get; set; }
        public virtual DbSet<exam_question_Student> exam_question_Student { get; set; }
        public virtual DbSet<exam_Student> exam_Student { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Intake> Intakes { get; set; }
        public virtual DbSet<intake_branch_track> intake_branch_track { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<MCQ_Choice> MCQ_Choice { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<T_F> T_F { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }

    }
}
