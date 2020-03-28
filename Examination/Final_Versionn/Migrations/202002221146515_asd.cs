namespace Final_Versionn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo.answer_Article",
               c => new
               {
                   id_answer_Article = c.Int(nullable: false, identity: true),
                   answer = c.String(),
                   ID_exam_question_Student = c.Int(nullable: false),
                   Mark = c.Boolean(nullable: false),
                   st_id = c.Int(nullable: false),
               })
               .PrimaryKey(t => t.id_answer_Article)
               .ForeignKey("dbo.exam_question_Student", t => t.ID_exam_question_Student, cascadeDelete: true)
               .ForeignKey("dbo.Students", t => t.st_id, cascadeDelete: false)
               .Index(t => t.ID_exam_question_Student)
               .Index(t => t.st_id);

            CreateTable(
                "dbo.exam_question_Student",
                c => new
                {
                    ID_exam_question_Student = c.Int(nullable: false, identity: true),
                    ID_exam_question = c.Int(nullable: false),
                    St_ID = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ID_exam_question_Student)
                .ForeignKey("dbo.exam_question", t => t.ID_exam_question, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.St_ID, cascadeDelete: false)
                .Index(t => t.ID_exam_question)
                .Index(t => t.St_ID);

            CreateTable(
                "dbo.answer_mcq",
                c => new
                {
                    id_answer_mcq = c.Int(nullable: false, identity: true),
                    Ans_ID = c.Int(nullable: false),
                    ID_exam_question_Student = c.Int(nullable: false),
                    Mark = c.Boolean(nullable: false),
                    st_id = c.Int(nullable: false),
                    MCQ_Choice_MCQ_ID = c.Int(),
                })
                .PrimaryKey(t => t.id_answer_mcq)
                .ForeignKey("dbo.exam_question_Student", t => t.ID_exam_question_Student, cascadeDelete: true)
                .ForeignKey("dbo.MCQ_Choice", t => t.MCQ_Choice_MCQ_ID)
                .ForeignKey("dbo.Students", t => t.st_id, cascadeDelete: false)
                .Index(t => t.ID_exam_question_Student)
                .Index(t => t.st_id)
                .Index(t => t.MCQ_Choice_MCQ_ID);

            CreateTable(
                "dbo.MCQ_Choice",
                c => new
                {
                    MCQ_ID = c.Int(nullable: false, identity: true),
                    choice = c.String(),
                    istrue = c.Boolean(),
                    ID_question = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.MCQ_ID)
                .ForeignKey("dbo.Questions", t => t.ID_question, cascadeDelete: true)
                .Index(t => t.ID_question);

            CreateTable(
                "dbo.Questions",
                c => new
                {
                    ID_question = c.Int(nullable: false, identity: true),
                    Body = c.String(),
                    C_ID = c.Int(nullable: false),
                    type = c.String(),
                    is_deleted = c.Boolean(),
                })
                .PrimaryKey(t => t.ID_question)
                .ForeignKey("dbo.Courses", t => t.C_ID, cascadeDelete: true)
                .Index(t => t.C_ID);

            CreateTable(
                "dbo.Articles",
                c => new
                {
                    Ar_ID = c.Int(nullable: false, identity: true),
                    answer = c.String(),
                    ID_question = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Ar_ID)
                .ForeignKey("dbo.Questions", t => t.ID_question, cascadeDelete: true)
                .Index(t => t.ID_question);

            CreateTable(
                "dbo.Courses",
                c => new
                {
                    C_ID = c.Int(nullable: false, identity: true),
                    description = c.String(),
                    Name = c.String(),
                    Hour = c.Short(nullable: false),
                    max_degree = c.Int(nullable: false),
                    min_degree = c.Int(nullable: false),
                    Instruct_ID = c.Int(nullable: false),
                    Track_ID = c.Int(nullable: false),
                    is_deleted = c.Boolean(),
                })
                .PrimaryKey(t => t.C_ID)
                .ForeignKey("dbo.Instructors", t => t.Instruct_ID, cascadeDelete: false)
                .ForeignKey("dbo.Tracks", t => t.Track_ID, cascadeDelete: false)
                .Index(t => t.Instruct_ID)
                .Index(t => t.Track_ID);

            CreateTable(
                "dbo.Exams",
                c => new
                {
                    ex_id = c.Int(nullable: false, identity: true),
                    period = c.Int(nullable: false),
                    start_time = c.DateTime(nullable: false),
                    end_time = c.DateTime(nullable: false),
                    exam_type = c.String(),
                    instruct_id = c.Int(nullable: false),
                    MCQ_Mark = c.Int(nullable: false),
                    MCQ_NUM = c.Int(nullable: false),
                    TF_Mark = c.Int(nullable: false),
                    TF_NUM = c.Int(nullable: false),
                    Article_Mark = c.Int(nullable: false),
                    Article_NUM = c.Int(nullable: false),
                    C_ID = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ex_id)
                .ForeignKey("dbo.Courses", t => t.C_ID, cascadeDelete: true)
                .ForeignKey("dbo.Instructors", t => t.instruct_id, cascadeDelete: false)
                .Index(t => t.instruct_id)
                .Index(t => t.C_ID);

            CreateTable(
                "dbo.exam_question",
                c => new
                {
                    ID_exam_question = c.Int(nullable: false, identity: true),
                    ex_id = c.Int(nullable: false),
                    ID_question = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ID_exam_question)
                .ForeignKey("dbo.Exams", t => t.ex_id, cascadeDelete: true)
                .ForeignKey("dbo.Questions", t => t.ID_question, cascadeDelete: false)
                .Index(t => t.ex_id)
                .Index(t => t.ID_question);

            CreateTable(
                "dbo.exam_Student",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    St_ID = c.Int(nullable: false),
                    ex_id = c.Int(nullable: false),
                    Mark = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Exams", t => t.ex_id, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.St_ID, cascadeDelete: true)
                .Index(t => t.St_ID)
                .Index(t => t.ex_id);

            CreateTable(
                "dbo.Students",
                c => new
                {
                    St_ID = c.Int(nullable: false, identity: true),
                    name = c.String(),
                    id_intake_branch_track = c.Int(nullable: false),
                    is_deleted = c.Boolean(),
                    log_ID = c.Int(),
                })
                .PrimaryKey(t => t.St_ID)
                .ForeignKey("dbo.Logins", t => t.log_ID)
                .ForeignKey("dbo.intake_branch_track", t => t.id_intake_branch_track, cascadeDelete: true)
                .Index(t => t.id_intake_branch_track)
                .Index(t => t.log_ID);

            CreateTable(
                "dbo.answer_true_false",
                c => new
                {
                    id_answer_true_false = c.Int(nullable: false, identity: true),
                    istrue = c.Boolean(nullable: false),
                    ID_exam_question_Student = c.Int(nullable: false),
                    Mark = c.Boolean(nullable: false),
                    st_id = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.id_answer_true_false)
                .ForeignKey("dbo.exam_question_Student", t => t.ID_exam_question_Student, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.st_id, cascadeDelete: true)
                .Index(t => t.ID_exam_question_Student)
                .Index(t => t.st_id);

            CreateTable(
                "dbo.intake_branch_track",
                c => new
                {
                    id_intake_branch_track = c.Int(nullable: false, identity: true),
                    brn_id = c.Int(nullable: false),
                    trk_id = c.Int(nullable: false),
                    itk_id = c.Int(nullable: false),
                    is_deleted = c.Boolean(),
                })
                .PrimaryKey(t => t.id_intake_branch_track)
                .ForeignKey("dbo.Branches", t => t.brn_id, cascadeDelete: true)
                .ForeignKey("dbo.Intakes", t => t.itk_id, cascadeDelete: true)
                .ForeignKey("dbo.Tracks", t => t.trk_id, cascadeDelete: true)
                .Index(t => t.brn_id)
                .Index(t => t.trk_id)
                .Index(t => t.itk_id);

            CreateTable(
                "dbo.Branches",
                c => new
                {
                    brn_id = c.Int(nullable: false, identity: true),
                    brn_name = c.String(),
                    is_deleted = c.Boolean(),
                })
                .PrimaryKey(t => t.brn_id);

            CreateTable(
                "dbo.Instructors",
                c => new
                {
                    Instruct_ID = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    MG_id = c.Int(),
                    brn = c.Int(nullable: false),
                    is_deleted = c.Boolean(),
                    log_ID = c.Int(),
                })
                .PrimaryKey(t => t.Instruct_ID)
                .ForeignKey("dbo.Branches", t => t.brn, cascadeDelete: true)
                .ForeignKey("dbo.Logins", t => t.log_ID)
                .Index(t => t.brn)
                .Index(t => t.log_ID);

            CreateTable(
                "dbo.Logins",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Password = c.String(),
                    username = c.String(),
                    type = c.String(),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Intakes",
                c => new
                {
                    itk_id = c.Int(nullable: false, identity: true),
                    itk_name = c.String(),
                    is_deleted = c.Boolean(),
                })
                .PrimaryKey(t => t.itk_id);

            CreateTable(
                "dbo.Tracks",
                c => new
                {
                    trk_id = c.Int(nullable: false, identity: true),
                    trk_name = c.String(),
                    is_deleted = c.Boolean(),
                })
                .PrimaryKey(t => t.trk_id);

            CreateTable(
                "dbo.T_F",
                c => new
                {
                    TF_ID = c.Int(nullable: false, identity: true),
                    istrue = c.Boolean(nullable: false),
                    ID_question = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.TF_ID)
                .ForeignKey("dbo.Questions", t => t.ID_question, cascadeDelete: true)
                .Index(t => t.ID_question);

            CreateTable(
                "dbo.StudentCourses",
                c => new
                {
                    Student_St_ID = c.Int(nullable: false),
                    Course_C_ID = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.Student_St_ID, t.Course_C_ID })
                .ForeignKey("dbo.Students", t => t.Student_St_ID, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_C_ID, cascadeDelete: true)
                .Index(t => t.Student_St_ID)
                .Index(t => t.Course_C_ID);

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.T_F", "ID_question", "dbo.Questions");
            DropForeignKey("dbo.MCQ_Choice", "ID_question", "dbo.Questions");
            DropForeignKey("dbo.Questions", "C_ID", "dbo.Courses");
            DropForeignKey("dbo.intake_branch_track", "trk_id", "dbo.Tracks");
            DropForeignKey("dbo.Courses", "Track_ID", "dbo.Tracks");
            DropForeignKey("dbo.Students", "id_intake_branch_track", "dbo.intake_branch_track");
            DropForeignKey("dbo.intake_branch_track", "itk_id", "dbo.Intakes");
            DropForeignKey("dbo.intake_branch_track", "brn_id", "dbo.Branches");
            DropForeignKey("dbo.Students", "log_ID", "dbo.Logins");
            DropForeignKey("dbo.Instructors", "log_ID", "dbo.Logins");
            DropForeignKey("dbo.Exams", "instruct_id", "dbo.Instructors");
            DropForeignKey("dbo.Courses", "Instruct_ID", "dbo.Instructors");
            DropForeignKey("dbo.Instructors", "brn", "dbo.Branches");
            DropForeignKey("dbo.exam_Student", "St_ID", "dbo.Students");
            DropForeignKey("dbo.exam_question_Student", "St_ID", "dbo.Students");
            DropForeignKey("dbo.StudentCourses", "Course_C_ID", "dbo.Courses");
            DropForeignKey("dbo.StudentCourses", "Student_St_ID", "dbo.Students");
            DropForeignKey("dbo.answer_true_false", "st_id", "dbo.Students");
            DropForeignKey("dbo.answer_true_false", "ID_exam_question_Student", "dbo.exam_question_Student");
            DropForeignKey("dbo.answer_mcq", "st_id", "dbo.Students");
            DropForeignKey("dbo.answer_Article", "st_id", "dbo.Students");
            DropForeignKey("dbo.exam_Student", "ex_id", "dbo.Exams");
            DropForeignKey("dbo.exam_question", "ID_question", "dbo.Questions");
            DropForeignKey("dbo.exam_question_Student", "ID_exam_question", "dbo.exam_question");
            DropForeignKey("dbo.exam_question", "ex_id", "dbo.Exams");
            DropForeignKey("dbo.Exams", "C_ID", "dbo.Courses");
            DropForeignKey("dbo.Articles", "ID_question", "dbo.Questions");
            DropForeignKey("dbo.answer_mcq", "MCQ_Choice_MCQ_ID", "dbo.MCQ_Choice");
            DropForeignKey("dbo.answer_mcq", "ID_exam_question_Student", "dbo.exam_question_Student");
            DropForeignKey("dbo.answer_Article", "ID_exam_question_Student", "dbo.exam_question_Student");
            DropIndex("dbo.StudentCourses", new[] { "Course_C_ID" });
            DropIndex("dbo.StudentCourses", new[] { "Student_St_ID" });
            DropIndex("dbo.T_F", new[] { "ID_question" });
            DropIndex("dbo.Instructors", new[] { "log_ID" });
            DropIndex("dbo.Instructors", new[] { "brn" });
            DropIndex("dbo.intake_branch_track", new[] { "itk_id" });
            DropIndex("dbo.intake_branch_track", new[] { "trk_id" });
            DropIndex("dbo.intake_branch_track", new[] { "brn_id" });
            DropIndex("dbo.answer_true_false", new[] { "st_id" });
            DropIndex("dbo.answer_true_false", new[] { "ID_exam_question_Student" });
            DropIndex("dbo.Students", new[] { "log_ID" });
            DropIndex("dbo.Students", new[] { "id_intake_branch_track" });
            DropIndex("dbo.exam_Student", new[] { "ex_id" });
            DropIndex("dbo.exam_Student", new[] { "St_ID" });
            DropIndex("dbo.exam_question", new[] { "ID_question" });
            DropIndex("dbo.exam_question", new[] { "ex_id" });
            DropIndex("dbo.Exams", new[] { "C_ID" });
            DropIndex("dbo.Exams", new[] { "instruct_id" });
            DropIndex("dbo.Courses", new[] { "Track_ID" });
            DropIndex("dbo.Courses", new[] { "Instruct_ID" });
            DropIndex("dbo.Articles", new[] { "ID_question" });
            DropIndex("dbo.Questions", new[] { "C_ID" });
            DropIndex("dbo.MCQ_Choice", new[] { "ID_question" });
            DropIndex("dbo.answer_mcq", new[] { "MCQ_Choice_MCQ_ID" });
            DropIndex("dbo.answer_mcq", new[] { "st_id" });
            DropIndex("dbo.answer_mcq", new[] { "ID_exam_question_Student" });
            DropIndex("dbo.exam_question_Student", new[] { "St_ID" });
            DropIndex("dbo.exam_question_Student", new[] { "ID_exam_question" });
            DropIndex("dbo.answer_Article", new[] { "st_id" });
            DropIndex("dbo.answer_Article", new[] { "ID_exam_question_Student" });
            DropTable("dbo.StudentCourses");
            DropTable("dbo.T_F");
            DropTable("dbo.Tracks");
            DropTable("dbo.Intakes");
            DropTable("dbo.Logins");
            DropTable("dbo.Instructors");
            DropTable("dbo.Branches");
            DropTable("dbo.intake_branch_track");
            DropTable("dbo.answer_true_false");
            DropTable("dbo.Students");
            DropTable("dbo.exam_Student");
            DropTable("dbo.exam_question");
            DropTable("dbo.Exams");
            DropTable("dbo.Courses");
            DropTable("dbo.Articles");
            DropTable("dbo.Questions");
            DropTable("dbo.MCQ_Choice");
            DropTable("dbo.answer_mcq");
            DropTable("dbo.exam_question_Student");
            DropTable("dbo.answer_Article");
        }
    }
}
