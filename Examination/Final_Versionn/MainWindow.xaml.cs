using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Final_Versionn
{
    // <summary>
    // Interaction logic for MainWindow.xaml
    // </summary>
    public partial class MainWindow : Window
    {
        Context service = new Context();
        public MainWindow()
        {
            InitializeComponent();


            //service.Tracks.Add(new Track { trk_id = 1, trk_name = "SD", is_deleted = false });
            //service.Tracks.Add(new Track { trk_id = 2, trk_name = "Android", is_deleted = false });
            //service.Tracks.Add(new Track { trk_id = 3, trk_name = "Network", is_deleted = false });
            //service.Tracks.Add(new Track { trk_id = 4, trk_name = "Web", is_deleted = false });
            //service.Tracks.Add(new Track { trk_id = 5, trk_name = "BI", is_deleted = false });
            //service.Tracks.Add(new Track { trk_id = 6, trk_name = "OpenSource", is_deleted = false });
            //service.Tracks.Add(new Track { trk_id = 7, trk_name = "Database", is_deleted = false });
            //service.Tracks.Add(new Track { trk_id = 8, trk_name = "Administration", is_deleted = false });
            //service.Tracks.Add(new Track { trk_id = 9, trk_name = "Security", is_deleted = false });
            //service.Tracks.Add(new Track { trk_id = 10, trk_name = "SQL", is_deleted = false });
            //service.Tracks.Add(new Track { trk_id = 11, trk_name = "BigData", is_deleted = false });
            //service.Tracks.Add(new Track { trk_id = 12, trk_name = "Data Analysis", is_deleted = false });
            //service.Tracks.Add(new Track { trk_id = 13, trk_name = "Project Management", is_deleted = false });
            //service.Tracks.Add(new Track { trk_id = 14, trk_name = "Enterprise", is_deleted = false });

            ///////*INTAKE*/

            //service.Intakes.Add(new Intake { itk_id = 1, itk_name = "Intake 26", is_deleted = false });
            //service.Intakes.Add(new Intake { itk_id = 2, itk_name = "Intake 27", is_deleted = false });
            //service.Intakes.Add(new Intake { itk_id = 3, itk_name = "Intake 28", is_deleted = false });
            //service.Intakes.Add(new Intake { itk_id = 4, itk_name = "Intake 29", is_deleted = false });
            //service.Intakes.Add(new Intake { itk_id = 5, itk_name = "Intake 30", is_deleted = false });
            //service.Intakes.Add(new Intake { itk_id = 6, itk_name = "Intake 31", is_deleted = false });
            //service.Intakes.Add(new Intake { itk_id = 7, itk_name = "Intake 32", is_deleted = false });

            ///////*Branch*/
            //service.Branches.Add(new Branch { brn_id = 1, brn_name = "Assiut", is_deleted = false });
            //service.Branches.Add(new Branch { brn_id = 2, brn_name = "Qena", is_deleted = false });
            //service.Branches.Add(new Branch { brn_id = 3, brn_name = "Mineai", is_deleted = false });
            //service.Branches.Add(new Branch { brn_id = 4, brn_name = "Cairo", is_deleted = false });
            //service.Branches.Add(new Branch { brn_id = 5, brn_name = "Smart", is_deleted = false });
            //service.Branches.Add(new Branch { brn_id = 6, brn_name = "Alex", is_deleted = false });
            //service.Branches.Add(new Branch { brn_id = 7, brn_name = "Mansoura", is_deleted = false });
            //service.Branches.Add(new Branch { brn_id = 8, brn_name = "Loxor", is_deleted = false });

            ///////*intake-branch-track*/
            //service.intake_branch_track.Add(new intake_branch_track { id_intake_branch_track = 1, brn_id = 1, trk_id = 1, itk_id = 1, is_deleted = false });
            //service.intake_branch_track.Add(new intake_branch_track { id_intake_branch_track = 2, brn_id = 1, trk_id = 1, itk_id = 2, is_deleted = false });
            //service.intake_branch_track.Add(new intake_branch_track { id_intake_branch_track = 3, brn_id = 1, trk_id = 1, itk_id = 3, is_deleted = false });
            //service.intake_branch_track.Add(new intake_branch_track { id_intake_branch_track = 4, brn_id = 1, trk_id = 1, itk_id = 4, is_deleted = false });
            //service.intake_branch_track.Add(new intake_branch_track { id_intake_branch_track = 5, brn_id = 1, trk_id = 1, itk_id = 5, is_deleted = false });
            //service.intake_branch_track.Add(new intake_branch_track { id_intake_branch_track = 6, brn_id = 1, trk_id = 1, itk_id = 6, is_deleted = false });

            ///////*Instructor*/
            //service.Instructors.Add(new Instructor { Instruct_ID = 1, Name = "Mahmoud", MG_id = 1, brn = 1, is_deleted = false, log_ID = 1 });
            //service.Instructors.Add(new Instructor { Instruct_ID = 2, Name = "Hany", MG_id = 2, brn = 1, is_deleted = false, log_ID = 2 });
            //service.Instructors.Add(new Instructor { Instruct_ID = 3, Name = "Ahmed", MG_id = 2, brn = 2, is_deleted = false, log_ID = 3 });
            //service.Instructors.Add(new Instructor { Instruct_ID = 4, Name = "Christin", MG_id = 1, brn = 1, is_deleted = false, log_ID = 4 });
            //service.Instructors.Add(new Instructor { Instruct_ID = 5, Name = "Roaa", MG_id = 1, brn = 2, is_deleted = false, log_ID = 5 });
            ///////*Course*/
            //service.Courses.Add(new Course { Track_ID = 1, C_ID = 1, description = "Skills", Name = "presentation skills", Hour = 44, max_degree = 100, min_degree = 60, Instruct_ID = 1, is_deleted = false, });
            //service.Courses.Add(new Course { Track_ID = 2, C_ID = 2, description = "Skills", Name = "Communication skills", Hour = 60, max_degree = 160, min_degree = 60, Instruct_ID = 2, is_deleted = false, });
            //service.Courses.Add(new Course { Track_ID = 3, C_ID = 3, description = "Skills", Name = "Interview skills", Hour = 50, max_degree = 160, min_degree = 60, Instruct_ID = 3, is_deleted = false, });
            //service.Courses.Add(new Course { Track_ID = 4, C_ID = 4, description = "Skills", Name = "Drawing", Hour = 23, max_degree = 90, min_degree = 60, Instruct_ID = 4, is_deleted = false, });
            //service.Courses.Add(new Course { Track_ID = 1, C_ID = 5, description = "Mathematics", Name = "Maths1", Hour = 32, max_degree = 140, min_degree = 60, Instruct_ID = 5, is_deleted = false, });
            //service.Courses.Add(new Course { Track_ID = 6, C_ID = 6, description = "Mathematics", Name = "Maths2", Hour = 36, max_degree = 100, min_degree = 60, Instruct_ID = 1, is_deleted = false, });
            //service.Courses.Add(new Course { Track_ID = 7, C_ID = 7, description = "Mathematics", Name = "Maths3", Hour = 72, max_degree = 130, min_degree = 90, Instruct_ID = 4, is_deleted = false, });
            //service.Courses.Add(new Course { Track_ID = 8, C_ID = 8, description = "Mathematics", Name = "Descrete structure", Hour = 18, max_degree = 120, min_degree = 70, Instruct_ID = 5, is_deleted = false, });
            //service.Courses.Add(new Course { Track_ID = 9, C_ID = 9, description = "Language", Name = "English", Hour = 99, max_degree = 400, min_degree = 150, Instruct_ID = 5, is_deleted = false, });
            //service.Courses.Add(new Course { Track_ID = 10, C_ID = 10, description = "Front end", Name = "CSS", Hour = 72, max_degree = 130, min_degree = 80, Instruct_ID = 3, is_deleted = false, });

            ///////*Qusection*/
            //service.Questions.Add(new Question { ID_question = 1, Body = "What Is SQL Profiler?", C_ID = 1, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 2, Body = "What is recursive stored procedure?", C_ID = 1, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 3, Body = "What are the differences between local and global temporary tables?", C_ID = 1, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 4, Body = "What is CHECK constraint?", C_ID = 1, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 5, Body = "Can SQL servers linked to other servers?", C_ID = 1, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 6, Body = "What is sub query and its properties?", C_ID = 1, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 7, Body = "What are the types of sub query?", C_ID = 1, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 8, Body = "What is SQL server agent?", C_ID = 1, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 9, Body = " What are scheduled tasks in SQL Server?", C_ID = 1, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 10, Body = "What is COALESCE in SQL Server?", C_ID = 1, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 11, Body = " A view doesn?t have data of its own.", C_ID = 1, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 12, Body = "A DDL statement or a DCL statement is automatically committed.", C_ID = 1, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 13, Body = " You can use a subquery in an INSERT statement.", C_ID = 1, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 14, Body = "Attempting to delete a record with a value attached to an integrity constraint, returns an error.", C_ID = 1, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 15, Body = "While inserting new rows in a table you must list values in the default order of the columns.", C_ID = 1, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 16, Body = " Multiple column subqueries return more than one column from the inner SELECT statement.", C_ID = 1, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 17, Body = " A multiple row subquery returns more than one row from the inner SELECT statement.", C_ID = 1, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 18, Body = " All group functions ignore null values.", C_ID = 1, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 19, Body = " The DISTINCT keyword allows a function consider only non-duplicate values.", C_ID = 1, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 20, Body = " Reasons for consideration of the stored procedure can be?", C_ID = 1, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 21, Body = " __________ takes no parameters and returns all kinds of interesting information.", C_ID = 1, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 22, Body = "  Which of the following has support for transaction?", C_ID = 1, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 23, Body = " Point out the wrong statement.", C_ID = 1, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 24, Body = " __________create the removable database.", C_ID = 1, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 25, Body = "  Which of the following stored procedure is used for error messages?", C_ID = 1, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 26, Body = "  _____________ sets procedure options in SQL Server.", C_ID = 1, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 27, Body = " __________ is used to build the code dynamically and execute it.", C_ID = 1, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 28, Body = "Stored procedure used to remember the exact number of bytes is _____________", C_ID = 1, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 29, Body = "Point out the correct statement.", C_ID = 1, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 30, Body = "  __________ is used to build the code dynamically and execute it.", C_ID = 1, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 31, Body = " Stored procedure used to remember the exact number of bytes is _____________", C_ID = 1, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 32, Body = " Point out the correct statement.", C_ID = 1, type = "MCQ", is_deleted = false });

            //service.Articles.Add(new Article { Ar_ID = 1, ID_question = 1, answer = "SQL Profiler is a tool which allows system administrator to monitor events in the SQL server" });
            //service.Articles.Add(new Article { Ar_ID = 2, ID_question = 2, answer = "SQL Server supports recursive stored procedure which calls by itself" });
            //service.Articles.Add(new Article { Ar_ID = 3, ID_question = 3, answer = "Local temporary tables are visible when there is a connection, and are deleted when the connection is closed." });
            //service.Articles.Add(new Article { Ar_ID = 4, ID_question = 4, answer = "A CHECK constraint can be applied to a column in a table to limit the values that can be placed in a column." });
            //service.Articles.Add(new Article { Ar_ID = 5, ID_question = 5, answer = "SQL server can be connected to any database which has OLE-DB provider to give a link" });
            //service.Articles.Add(new Article { Ar_ID = 6, ID_question = 6, answer = "A sub-query is a query which can be nested inside a main query like Select, Update, Insert or Delete statements" });
            //service.Articles.Add(new Article { Ar_ID = 7, ID_question = 7, answer = "Multiple column sub query which returns multiple columns to the main query. With that sub query result, Main query will be executed" });
            //service.Articles.Add(new Article { Ar_ID = 8, ID_question = 8, answer = "The SQL Server agent plays a vital role in day to day tasks of SQL server administrator(DBA)." });
            //service.Articles.Add(new Article { Ar_ID = 9, ID_question = 9, answer = "Scheduled tasks or jobs are used to automate processes that can be run on a scheduled time at a regular interval." });
            //service.Articles.Add(new Article { Ar_ID = 10, ID_question = 10, answer = " jobs are used to automate processes that can be run on a scheduled time at a regular interval." });



            //service.T_F.Add(new T_F { TF_ID = 1, ID_question = 11, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 2, ID_question = 12, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 3, ID_question = 13, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 4, ID_question = 14, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 5, ID_question = 15, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 6, ID_question = 16, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 7, ID_question = 17, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 8, ID_question = 18, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 9, ID_question = 19, istrue = true });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 1, istrue = false, choice = "A)SQL Server supports", ID_question = 20 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 2, istrue = false, choice = "B)stored procedure which calls by itself", ID_question = 20 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 3, istrue = true, choice = "C)Local temporary tables", ID_question = 20 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 4, istrue = false, choice = "A)SQL Server supports", ID_question = 21 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 5, istrue = true, choice = "B)stored procedure which calls by itself", ID_question = 21 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 6, istrue = false, choice = "C)Local temporary tables", ID_question = 21 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 7, istrue = false, choice = "D)CHECK constraint", ID_question = 21 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 8, istrue = false, choice = "A)database which has OLE-DB provider", ID_question = 22 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 9, istrue = false, choice = "B)sub-query", ID_question = 22 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 10, istrue = true, choice = "C)Multiple column", ID_question = 22 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 11, istrue = true, choice = "A)calls by itself", ID_question = 24 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 12, istrue = false, choice = "B)Local temporary", ID_question = 24 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 13, istrue = true, choice = "c)CHECK constraint", ID_question = 24 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 14, istrue = false, choice = "D)Scheduled", ID_question = 24 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 15, istrue = false, choice = "f)COALESCE", ID_question = 24 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 16, istrue = false, choice = "A)calls by itself", ID_question = 25 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 17, istrue = true, choice = "B)Local temporary", ID_question = 25 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 18, istrue = false, choice = "c)CHECK constraint", ID_question = 25 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 19, istrue = true, choice = "D)Scheduled", ID_question = 25 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 20, istrue = true, choice = "f)COALESCE", ID_question = 25 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 21, istrue = true, choice = "A)calls by itself", ID_question = 26 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 22, istrue = true, choice = "B)Local temporary", ID_question = 26 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 23, istrue = true, choice = "c)CHECK constraint", ID_question = 26 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 24, istrue = false, choice = "A)calls by itself", ID_question = 27 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 25, istrue = true, choice = "B)Local temporary", ID_question = 27 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 26, istrue = false, choice = "c)CHECK constraint", ID_question = 27 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 27, istrue = false, choice = "A)calls by itself", ID_question = 28 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 28, istrue = true, choice = "B)Local temporary", ID_question = 28 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 29, istrue = false, choice = "c)CHECK constraint", ID_question = 28 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 30, istrue = false, choice = "d)calls by itself", ID_question = 28 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 31, istrue = true, choice = "e)Local temporary", ID_question = 28 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 32, istrue = false, choice = "f)CHECK constraint", ID_question = 28 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 33, istrue = false, choice = "A)calls by itself", ID_question = 29 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 34, istrue = true, choice = "B)Local temporary", ID_question = 29 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 35, istrue = true, choice = "c)CHECK constraint", ID_question = 29 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 36, istrue = false, choice = "d)calls by itself", ID_question = 29 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 37, istrue = true, choice = "f)Local temporary", ID_question = 29 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 38, istrue = false, choice = "g)CHECK constraint", ID_question = 29 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 39, istrue = false, choice = "A)calls by itself", ID_question = 30 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 40, istrue = true, choice = "B)Local temporary", ID_question = 30 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 41, istrue = false, choice = "c)CHECK constraint", ID_question = 30 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 42, istrue = false, choice = "d)calls by itself", ID_question = 30 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 43, istrue = false, choice = "A)calls by itself", ID_question = 31 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 44, istrue = true, choice = "B)Local temporary", ID_question = 31 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 45, istrue = false, choice = "c)CHECK constraint", ID_question = 31 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 46, istrue = false, choice = "d)calls by itself", ID_question = 31 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 43, istrue = false, choice = "A)calls by itself", ID_question = 32 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 44, istrue = true, choice = "B)Local temporary", ID_question = 32 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 45, istrue = false, choice = "c)CHECK constraint", ID_question = 32 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 46, istrue = false, choice = "d)calls by itself", ID_question = 32 });
            //service.Questions.Add(new Question { ID_question = 33, Body = "What Is SQL Profiler?", C_ID = 2, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 34, Body = "What is recursive stored procedure?", C_ID = 2, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 35, Body = "What are the differences between local and global temporary tables?", C_ID = 2, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 36, Body = "What is CHECK constraint?", C_ID = 2, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 37, Body = "Can SQL servers linked to other servers?", C_ID = 2, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 38, Body = "What is sub query and its properties?", C_ID = 2, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 39, Body = "What are the types of sub query?", C_ID = 2, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 40, Body = "What is SQL server agent?", C_ID = 2, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 41, Body = " What are scheduled tasks in SQL Server?", C_ID = 2, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 42, Body = "What is COALESCE in SQL Server?", C_ID = 2, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 43, Body = " A view doesn?t have data of its own.", C_ID = 2, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 44, Body = "A DDL statement or a DCL statement is automatically committed.", C_ID = 2, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 45, Body = " You can use a subquery in an INSERT statement.", C_ID = 2, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 46, Body = "Attempting to delete a record with a value attached to an integrity constraint, returns an error.", C_ID = 2, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 47, Body = "While inserting new rows in a table you must list values in the default order of the columns.", C_ID = 2, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 48, Body = " Multiple column subqueries return more than one column from the inner SELECT statement.", C_ID = 2, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 49, Body = " A multiple row subquery returns more than one row from the inner SELECT statement.", C_ID = 2, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 50, Body = " All group functions ignore null values.", C_ID = 2, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 51, Body = " The DISTINCT keyword allows a function consider only non-duplicate values.", C_ID = 2, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 52, Body = " Reasons for consideration of the stored procedure can be?", C_ID = 2, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 53, Body = " __________ takes no parameters and returns all kinds of interesting information.", C_ID = 1, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 54, Body = "  Which of the following has support for transaction?", C_ID = 2, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 55, Body = " Point out the wrong statement.", C_ID = 2, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 56, Body = " __________create the removable database.", C_ID = 2, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 57, Body = "  Which of the following stored procedure is used for error messages?", C_ID = 2, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 58, Body = "  _____________ sets procedure options in SQL Server.", C_ID = 2, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 59, Body = " __________ is used to build the code dynamically and execute it.", C_ID = 2, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 60, Body = "Stored procedure used to remember the exact number of bytes is _____________", C_ID = 2, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 61, Body = "Point out the correct statement.", C_ID = 2, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 62, Body = "  __________ is used to build the code dynamically and execute it.", C_ID = 2, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 63, Body = " Stored procedure used to remember the exact number of bytes is _____________", C_ID = 2, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 64, Body = " Point out the correct statement.", C_ID = 2, type = "MCQ", is_deleted = false });

            //service.Articles.Add(new Article { Ar_ID = 11, ID_question = 33, answer = "SQL Profiler is a tool which allows system administrator to monitor events in the SQL server" });
            //service.Articles.Add(new Article { Ar_ID = 12, ID_question = 34, answer = "SQL Server supports recursive stored procedure which calls by itself" });
            //service.Articles.Add(new Article { Ar_ID = 13, ID_question = 35, answer = "Local temporary tables are visible when there is a connection, and are deleted when the connection is closed." });
            //service.Articles.Add(new Article { Ar_ID = 14, ID_question = 36, answer = "A CHECK constraint can be applied to a column in a table to limit the values that can be placed in a column." });
            //service.Articles.Add(new Article { Ar_ID = 15, ID_question = 37, answer = "SQL server can be connected to any database which has OLE-DB provider to give a link" });
            //service.Articles.Add(new Article { Ar_ID = 16, ID_question = 38, answer = "A sub-query is a query which can be nested inside a main query like Select, Update, Insert or Delete statements" });
            //service.Articles.Add(new Article { Ar_ID = 17, ID_question = 39, answer = "Multiple column sub query which returns multiple columns to the main query. With that sub query result, Main query will be executed" });
            //service.Articles.Add(new Article { Ar_ID = 18, ID_question = 40, answer = "The SQL Server agent plays a vital role in day to day tasks of SQL server administrator(DBA)." });
            //service.Articles.Add(new Article { Ar_ID = 19, ID_question = 41, answer = "Scheduled tasks or jobs are used to automate processes that can be run on a scheduled time at a regular interval." });
            //service.Articles.Add(new Article { Ar_ID = 20, ID_question = 42, answer = " jobs are used to automate processes that can be run on a scheduled time at a regular interval." });



            //service.T_F.Add(new T_F { TF_ID = 10, ID_question = 43, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 11, ID_question = 44, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 12, ID_question = 45, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 13, ID_question = 46, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 14, ID_question = 47, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 15, ID_question = 48, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 16, ID_question = 49, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 17, ID_question = 50, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 18, ID_question = 51, istrue = true });



            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 51, istrue = false, choice = "A)SQL Server supports", ID_question = 52 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 52, istrue = false, choice = "B)stored procedure which calls by itself", ID_question = 52 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 53, istrue = true, choice = "C)Local temporary tables", ID_question = 52 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 54, istrue = false, choice = "A)SQL Server supports", ID_question = 53 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 55, istrue = true, choice = "B)stored procedure which calls by itself", ID_question = 53 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 56, istrue = false, choice = "C)Local temporary tables", ID_question = 23 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 57, istrue = false, choice = "D)CHECK constraint", ID_question = 53 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 58, istrue = false, choice = "A)database which has OLE-DB provider", ID_question = 54 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 59, istrue = false, choice = "B)sub-query", ID_question = 54 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 60, istrue = true, choice = "C)Multiple column", ID_question = 54 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 61, istrue = true, choice = "A)calls by itself", ID_question = 55 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 62, istrue = false, choice = "B)Local temporary", ID_question = 55 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 63, istrue = true, choice = "c)CHECK constraint", ID_question = 55 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 64, istrue = false, choice = "D)Scheduled", ID_question = 55 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 65, istrue = false, choice = "f)COALESCE", ID_question = 55 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 66, istrue = false, choice = "A)calls by itself", ID_question = 56 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 67, istrue = true, choice = "B)Local temporary", ID_question = 56 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 68, istrue = false, choice = "c)CHECK constraint", ID_question = 56 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 69, istrue = true, choice = "D)Scheduled", ID_question = 56 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 70, istrue = true, choice = "f)COALESCE", ID_question = 56 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 71, istrue = true, choice = "A)calls by itself", ID_question = 57 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 72, istrue = true, choice = "B)Local temporary", ID_question = 57 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 73, istrue = true, choice = "c)CHECK constraint", ID_question = 57 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 74, istrue = false, choice = "A)calls by itself", ID_question = 57 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 75, istrue = true, choice = "B)Local temporary", ID_question = 57 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 76, istrue = false, choice = "c)CHECK constraint", ID_question = 57 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 77, istrue = false, choice = "A)calls by itself", ID_question = 58 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 78, istrue = true, choice = "B)Local temporary", ID_question = 58 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 79, istrue = false, choice = "c)CHECK constraint", ID_question = 58 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 80, istrue = false, choice = "d)calls by itself", ID_question = 58 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 81, istrue = true, choice = "e)Local temporary", ID_question = 58 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 82, istrue = false, choice = "f)CHECK constraint", ID_question = 58 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 83, istrue = false, choice = "A)calls by itself", ID_question = 59 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 84, istrue = true, choice = "B)Local temporary", ID_question = 59 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 85, istrue = true, choice = "c)CHECK constraint", ID_question = 59 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 86, istrue = false, choice = "d)calls by itself", ID_question = 59 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 87, istrue = true, choice = "f)Local temporary", ID_question = 59 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 88, istrue = false, choice = "g)CHECK constraint", ID_question = 59 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 89, istrue = false, choice = "A)calls by itself", ID_question = 60 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 90, istrue = true, choice = "B)Local temporary", ID_question = 60 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 91, istrue = false, choice = "c)CHECK constraint", ID_question = 60 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 92, istrue = false, choice = "d)calls by itself", ID_question = 60 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 93, istrue = false, choice = "A)calls by itself", ID_question = 61 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 94, istrue = true, choice = "B)Local temporary", ID_question = 61 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 95, istrue = false, choice = "c)CHECK constraint", ID_question = 61 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 96, istrue = false, choice = "d)calls by itself", ID_question = 61 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 97, istrue = false, choice = "A)calls by itself", ID_question = 62 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 98, istrue = true, choice = "B)Local temporary", ID_question = 62 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 99, istrue = false, choice = "c)CHECK constraint", ID_question = 62 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 100, istrue = false, choice = "d)calls by itself", ID_question = 62 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 101, istrue = false, choice = "A)calls by itself", ID_question = 63 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 102, istrue = true, choice = "B)Local temporary", ID_question = 63 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 103, istrue = false, choice = "c)CHECK constraint", ID_question = 63 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 104, istrue = false, choice = "d)calls by itself", ID_question = 63 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 105, istrue = false, choice = "A)calls by itself", ID_question = 64 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 106, istrue = true, choice = "B)Local temporary", ID_question = 64 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 107, istrue = false, choice = "c)CHECK constraint", ID_question = 64 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 108, istrue = false, choice = "d)calls by itself", ID_question = 64 });

            //service.Questions.Add(new Question { ID_question = 65, Body = "What Is SQL Profiler?", C_ID = 3, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 66, Body = "What is recursive stored procedure?", C_ID = 3, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 67, Body = "What are the differences between local and global temporary tables?", C_ID = 3, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 68, Body = "What is CHECK constraint?", C_ID = 3, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 69, Body = "Can SQL servers linked to other servers?", C_ID = 3, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 70, Body = "What is sub query and its properties?", C_ID = 3, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 71, Body = "What are the types of sub query?", C_ID = 3, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 72, Body = "What is SQL server agent?", C_ID = 3, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 73, Body = " What are scheduled tasks in SQL Server?", C_ID = 3, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 74, Body = "What is COALESCE in SQL Server?", C_ID = 3, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 75, Body = " A view doesn?t have data of its own.", C_ID = 3, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 76, Body = "A DDL statement or a DCL statement is automatically committed.", C_ID = 3, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 77, Body = " You can use a subquery in an INSERT statement.", C_ID = 3, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 78, Body = "Attempting to delete a record with a value attached to an integrity constraint, returns an error.", C_ID = 3, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 79, Body = "While inserting new rows in a table you must list values in the default order of the columns.", C_ID = 3, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 80, Body = " Multiple column subqueries return more than one column from the inner SELECT statement.", C_ID = 3, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 81, Body = " A multiple row subquery returns more than one row from the inner SELECT statement.", C_ID = 3, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 82, Body = " All group functions ignore null values.", C_ID = 3, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 83, Body = " The DISTINCT keyword allows a function consider only non-duplicate values.", C_ID = 3, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 84, Body = " Reasons for consideration of the stored procedure can be?", C_ID = 3, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 85, Body = " __________ takes no parameters and returns all kinds of interesting information.", C_ID = 1, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 86, Body = "  Which of the following has support for transaction?", C_ID = 3, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 87, Body = " Point out the wrong statement.", C_ID = 3, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 88, Body = " __________create the removable database.", C_ID = 3, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 89, Body = "  Which of the following stored procedure is used for error messages?", C_ID = 3, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 90, Body = "  _____________ sets procedure options in SQL Server.", C_ID = 3, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 91, Body = " __________ is used to build the code dynamically and execute it.", C_ID = 3, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 92, Body = "Stored procedure used to remember the exact number of bytes is _____________", C_ID = 3, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 93, Body = "Point out the correct statement.", C_ID = 3, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 94, Body = "  __________ is used to build the code dynamically and execute it.", C_ID = 3, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 95, Body = " Stored procedure used to remember the exact number of bytes is _____________", C_ID = 3, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 96, Body = " Point out the correct statement.", C_ID = 3, type = "MCQ", is_deleted = false });

            //service.Articles.Add(new Article { Ar_ID = 21, ID_question = 65, answer = "SQL Profiler is a tool which allows system administrator to monitor events in the SQL server" });
            //service.Articles.Add(new Article { Ar_ID = 22, ID_question = 66, answer = "SQL Server supports recursive stored procedure which calls by itself" });
            //service.Articles.Add(new Article { Ar_ID = 23, ID_question = 67, answer = "Local temporary tables are visible when there is a connection, and are deleted when the connection is closed." });
            //service.Articles.Add(new Article { Ar_ID = 24, ID_question = 68, answer = "A CHECK constraint can be applied to a column in a table to limit the values that can be placed in a column." });
            //service.Articles.Add(new Article { Ar_ID = 25, ID_question = 69, answer = "SQL server can be connected to any database which has OLE-DB provider to give a link" });
            //service.Articles.Add(new Article { Ar_ID = 26, ID_question = 70, answer = "A sub-query is a query which can be nested inside a main query like Select, Update, Insert or Delete statements" });
            //service.Articles.Add(new Article { Ar_ID = 27, ID_question = 71, answer = "Multiple column sub query which returns multiple columns to the main query. With that sub query result, Main query will be executed" });
            //service.Articles.Add(new Article { Ar_ID = 28, ID_question = 72, answer = "The SQL Server agent plays a vital role in day to day tasks of SQL server administrator(DBA)." });
            //service.Articles.Add(new Article { Ar_ID = 29, ID_question = 73, answer = "Scheduled tasks or jobs are used to automate processes that can be run on a scheduled time at a regular interval." });
            //service.Articles.Add(new Article { Ar_ID = 30, ID_question = 74, answer = " jobs are used to automate processes that can be run on a scheduled time at a regular interval." });



            //service.T_F.Add(new T_F { TF_ID = 19, ID_question = 75, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 20, ID_question = 76, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 21, ID_question = 77, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 22, ID_question = 78, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 23, ID_question = 79, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 24, ID_question = 80, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 25, ID_question = 81, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 26, ID_question = 82, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 27, ID_question = 83, istrue = true });



            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 109, istrue = false, choice = "A)SQL Server supports", ID_question = 84 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 110, istrue = false, choice = "B)stored procedure which calls by itself", ID_question = 84 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 111, istrue = true, choice = "C)Local temporary tables", ID_question = 84 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 112, istrue = false, choice = "A)SQL Server supports", ID_question = 85 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 113, istrue = true, choice = "B)stored procedure which calls by itself", ID_question = 85 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 114, istrue = false, choice = "C)Local temporary tables", ID_question = 85 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 115, istrue = false, choice = "D)CHECK constraint", ID_question = 85 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 116, istrue = false, choice = "A)database which has OLE-DB provider", ID_question = 86 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 117, istrue = false, choice = "B)sub-query", ID_question = 86 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 118, istrue = true, choice = "C)Multiple column", ID_question = 86 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 119, istrue = true, choice = "A)calls by itself", ID_question = 87 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 120, istrue = false, choice = "B)Local temporary", ID_question = 87 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 121, istrue = true, choice = "c)CHECK constraint", ID_question = 87 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 122, istrue = false, choice = "D)Scheduled", ID_question = 87 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 123, istrue = false, choice = "f)COALESCE", ID_question = 87 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 124, istrue = false, choice = "A)calls by itself", ID_question = 88 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 125, istrue = true, choice = "B)Local temporary", ID_question = 88 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 126, istrue = false, choice = "c)CHECK constraint", ID_question = 88 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 127, istrue = true, choice = "D)Scheduled", ID_question = 88 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 128, istrue = true, choice = "f)COALESCE", ID_question = 88 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 129, istrue = true, choice = "A)calls by itself", ID_question = 89 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 130, istrue = true, choice = "B)Local temporary", ID_question = 89 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 131, istrue = true, choice = "c)CHECK constraint", ID_question = 89 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 132, istrue = false, choice = "A)calls by itself", ID_question = 90 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 133, istrue = true, choice = "B)Local temporary", ID_question = 90 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 134, istrue = false, choice = "c)CHECK constraint", ID_question = 90 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 135, istrue = false, choice = "A)calls by itself", ID_question = 91 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 136, istrue = true, choice = "B)Local temporary", ID_question = 91 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 137, istrue = false, choice = "c)CHECK constraint", ID_question = 91 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 138, istrue = false, choice = "d)calls by itself", ID_question = 91 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 139, istrue = true, choice = "e)Local temporary", ID_question = 91 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 140, istrue = false, choice = "f)CHECK constraint", ID_question = 91 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 141, istrue = false, choice = "A)calls by itself", ID_question = 92 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 142, istrue = true, choice = "B)Local temporary", ID_question = 92 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 143, istrue = true, choice = "c)CHECK constraint", ID_question = 92 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 144, istrue = false, choice = "d)calls by itself", ID_question = 92 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 145, istrue = true, choice = "f)Local temporary", ID_question = 92 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 146, istrue = false, choice = "g)CHECK constraint", ID_question = 92 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 147, istrue = false, choice = "A)calls by itself", ID_question = 93 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 148, istrue = true, choice = "B)Local temporary", ID_question = 93 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 149, istrue = false, choice = "c)CHECK constraint", ID_question = 93 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 150, istrue = false, choice = "d)calls by itself", ID_question = 93 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 151, istrue = false, choice = "A)calls by itself", ID_question = 94 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 152, istrue = true, choice = "B)Local temporary", ID_question = 94 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 153, istrue = false, choice = "c)CHECK constraint", ID_question = 94 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 154, istrue = false, choice = "d)calls by itself", ID_question = 94 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 155, istrue = false, choice = "A)calls by itself", ID_question = 95 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 156, istrue = true, choice = "B)Local temporary", ID_question = 95 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 157, istrue = false, choice = "c)CHECK constraint", ID_question = 95 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 158, istrue = false, choice = "d)calls by itself", ID_question = 95 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 159, istrue = false, choice = "A)calls by itself", ID_question = 96 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 160, istrue = true, choice = "B)Local temporary", ID_question = 96 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 161, istrue = false, choice = "c)CHECK constraint", ID_question = 96 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 162, istrue = false, choice = "d)calls by itself", ID_question = 96 }); ;

            //service.Questions.Add(new Question { ID_question = 97, Body = "What Is SQL Profiler?", C_ID = 4, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 98, Body = "What is recursive stored procedure?", C_ID = 4, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 99, Body = "What are the differences between local and global temporary tables?", C_ID = 4, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 100, Body = "What is CHECK constraint?", C_ID = 4, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 101, Body = "Can SQL servers linked to other servers?", C_ID = 4, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 102, Body = "What is sub query and its properties?", C_ID = 4, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 103, Body = "What are the types of sub query?", C_ID = 4, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 104, Body = "What is SQL server agent?", C_ID = 4, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 105, Body = " What are scheduled tasks in SQL Server?", C_ID = 4, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 106, Body = "What is COALESCE in SQL Server?", C_ID = 4, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 107, Body = " A view doesn?t have data of its own.", C_ID = 4, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 108, Body = "A DDL statement or a DCL statement is automatically committed.", C_ID = 4, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 109, Body = " You can use a subquery in an INSERT statement.", C_ID = 4, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 110, Body = "Attempting to delete a record with a value attached to an integrity constraint, returns an error.", C_ID = 4, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 111, Body = "While inserting new rows in a table you must list values in the default order of the columns.", C_ID = 4, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 112, Body = " Multiple column subqueries return more than one column from the inner SELECT statement.", C_ID = 4, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 113, Body = " A multiple row subquery returns more than one row from the inner SELECT statement.", C_ID = 4, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 114, Body = " All group functions ignore null values.", C_ID = 4, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 115, Body = " The DISTINCT keyword allows a function consider only non-duplicate values.", C_ID = 4, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 116, Body = " Reasons for consideration of the stored procedure can be?", C_ID = 4, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 117, Body = " __________ takes no parameters and returns all kinds of interesting information.", C_ID = 4, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 118, Body = "  Which of the following has support for transaction?", C_ID = 4, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 119, Body = " Point out the wrong statement.", C_ID = 4, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 120, Body = " __________create the removable database.", C_ID = 4, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 121, Body = "  Which of the following stored procedure is used for error messages?", C_ID = 4, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 122, Body = "  _____________ sets procedure options in SQL Server.", C_ID = 4, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 123, Body = " __________ is used to build the code dynamically and execute it.", C_ID = 4, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 124, Body = "Stored procedure used to remember the exact number of bytes is _____________", C_ID = 4, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 125, Body = "Point out the correct statement.", C_ID = 4, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 126, Body = "  __________ is used to build the code dynamically and execute it.", C_ID = 4, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 127, Body = " Stored procedure used to remember the exact number of bytes is _____________", C_ID = 4, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 128, Body = " Point out the correct statement.", C_ID = 4, type = "MCQ", is_deleted = false });


            //service.Articles.Add(new Article { Ar_ID = 31, ID_question = 97, answer = "SQL Profiler is a tool which allows system administrator to monitor events in the SQL server" });
            //service.Articles.Add(new Article { Ar_ID = 32, ID_question = 98, answer = "SQL Server supports recursive stored procedure which calls by itself" });
            //service.Articles.Add(new Article { Ar_ID = 33, ID_question = 99, answer = "Local temporary tables are visible when there is a connection, and are deleted when the connection is closed." });
            //service.Articles.Add(new Article { Ar_ID = 34, ID_question = 100, answer = "A CHECK constraint can be applied to a column in a table to limit the values that can be placed in a column." });
            //service.Articles.Add(new Article { Ar_ID = 35, ID_question = 101, answer = "SQL server can be connected to any database which has OLE-DB provider to give a link" });
            //service.Articles.Add(new Article { Ar_ID = 36, ID_question = 102, answer = "A sub-query is a query which can be nested inside a main query like Select, Update, Insert or Delete statements" });
            //service.Articles.Add(new Article { Ar_ID = 37, ID_question = 103, answer = "Multiple column sub query which returns multiple columns to the main query. With that sub query result, Main query will be executed" });
            //service.Articles.Add(new Article { Ar_ID = 38, ID_question = 104, answer = "The SQL Server agent plays a vital role in day to day tasks of SQL server administrator(DBA)." });
            //service.Articles.Add(new Article { Ar_ID = 39, ID_question = 105, answer = "Scheduled tasks or jobs are used to automate processes that can be run on a scheduled time at a regular interval." });
            //service.Articles.Add(new Article { Ar_ID = 40, ID_question = 106, answer = " jobs are used to automate processes that can be run on a scheduled time at a regular interval." });



            //service.T_F.Add(new T_F { TF_ID = 28, ID_question = 107, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 29, ID_question = 108, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 30, ID_question = 109, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 31, ID_question = 110, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 32, ID_question = 111, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 33, ID_question = 112, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 34, ID_question = 113, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 35, ID_question = 114, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 36, ID_question = 115, istrue = true });



            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 163, istrue = false, choice = "A)SQL Server supports", ID_question = 116 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 164, istrue = false, choice = "B)stored procedure which calls by itself", ID_question = 116 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 165, istrue = true, choice = "C)Local temporary tables", ID_question = 116 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 166, istrue = false, choice = "A)SQL Server supports", ID_question = 117 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 167, istrue = true, choice = "B)stored procedure which calls by itself", ID_question = 117 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 168, istrue = false, choice = "C)Local temporary tables", ID_question = 117 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 169, istrue = false, choice = "D)CHECK constraint", ID_question = 117 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 170, istrue = false, choice = "A)database which has OLE-DB provider", ID_question = 118 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 171, istrue = false, choice = "B)sub-query", ID_question = 118 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 172, istrue = true, choice = "C)Multiple column", ID_question = 118 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 173, istrue = true, choice = "A)calls by itself", ID_question = 119 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 174, istrue = false, choice = "B)Local temporary", ID_question = 119 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 175, istrue = true, choice = "c)CHECK constraint", ID_question = 119 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 176, istrue = false, choice = "D)Scheduled", ID_question = 119 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 177, istrue = false, choice = "f)COALESCE", ID_question = 119 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 178, istrue = false, choice = "A)calls by itself", ID_question = 120 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 179, istrue = true, choice = "B)Local temporary", ID_question = 120 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 180, istrue = false, choice = "c)CHECK constraint", ID_question = 120 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 181, istrue = true, choice = "D)Scheduled", ID_question = 120 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 182, istrue = true, choice = "f)COALESCE", ID_question = 120 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 183, istrue = true, choice = "A)calls by itself", ID_question = 121 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 184, istrue = true, choice = "B)Local temporary", ID_question = 121 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 185, istrue = true, choice = "c)CHECK constraint", ID_question = 121 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 186, istrue = false, choice = "A)calls by itself", ID_question = 122 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 187, istrue = true, choice = "B)Local temporary", ID_question = 122 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 188, istrue = false, choice = "c)CHECK constraint", ID_question = 122 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 189, istrue = false, choice = "A)calls by itself", ID_question = 123 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 190, istrue = true, choice = "B)Local temporary", ID_question = 123 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 191, istrue = false, choice = "c)CHECK constraint", ID_question = 123 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 192, istrue = false, choice = "d)calls by itself", ID_question = 123 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 193, istrue = true, choice = "e)Local temporary", ID_question = 123 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 194, istrue = false, choice = "f)CHECK constraint", ID_question = 123 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 195, istrue = false, choice = "A)calls by itself", ID_question = 124 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 196, istrue = true, choice = "B)Local temporary", ID_question = 124 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 197, istrue = true, choice = "c)CHECK constraint", ID_question = 124 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 198, istrue = false, choice = "d)calls by itself", ID_question = 124 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 199, istrue = true, choice = "f)Local temporary", ID_question = 124 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 200, istrue = false, choice = "g)CHECK constraint", ID_question = 124 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 201, istrue = false, choice = "A)calls by itself", ID_question = 125 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 202, istrue = true, choice = "B)Local temporary", ID_question = 125 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 203, istrue = false, choice = "c)CHECK constraint", ID_question = 125 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 204, istrue = false, choice = "d)calls by itself", ID_question = 125 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 205, istrue = false, choice = "A)calls by itself", ID_question = 126 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 206, istrue = true, choice = "B)Local temporary", ID_question = 126 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 207, istrue = false, choice = "c)CHECK constraint", ID_question = 126 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 208, istrue = false, choice = "d)calls by itself", ID_question = 126 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 209, istrue = false, choice = "A)calls by itself", ID_question = 127 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 210, istrue = true, choice = "B)Local temporary", ID_question = 127 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 211, istrue = false, choice = "c)CHECK constraint", ID_question = 127 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 212, istrue = false, choice = "d)calls by itself", ID_question = 127 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 213, istrue = false, choice = "A)calls by itself", ID_question = 128 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 214, istrue = true, choice = "B)Local temporary", ID_question = 128 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 215, istrue = false, choice = "c)CHECK constraint", ID_question = 128 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 216, istrue = false, choice = "d)calls by itself", ID_question = 128 }); ;



            //service.Questions.Add(new Question { ID_question = 129, Body = "What Is SQL Profiler?", C_ID = 5, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 130, Body = "What is recursive stored procedure?", C_ID = 5, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 131, Body = "What are the differences between local and global temporary tables?", C_ID = 5, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 132, Body = "What is CHECK constraint?", C_ID = 5, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 133, Body = "Can SQL servers linked to other servers?", C_ID = 5, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 134, Body = "What is sub query and its properties?", C_ID = 5, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 135, Body = "What are the types of sub query?", C_ID = 5, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 136, Body = "What is SQL server agent?", C_ID = 4, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 137, Body = " What are scheduled tasks in SQL Server?", C_ID = 5, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 138, Body = "What is COALESCE in SQL Server?", C_ID = 5, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 139, Body = " A view doesn?t have data of its own.", C_ID = 5, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 140, Body = "A DDL statement or a DCL statement is automatically committed.", C_ID = 5, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 141, Body = " You can use a subquery in an INSERT statement.", C_ID = 5, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 142, Body = "Attempting to delete a record with a value attached to an integrity constraint, returns an error.", C_ID = 5, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 143, Body = "While inserting new rows in a table you must list values in the default order of the columns.", C_ID = 5, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 144, Body = " Multiple column subqueries return more than one column from the inner SELECT statement.", C_ID = 5, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 145, Body = " A multiple row subquery returns more than one row from the inner SELECT statement.", C_ID = 5, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 146, Body = " All group functions ignore null values.", C_ID = 5, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 147, Body = " The DISTINCT keyword allows a function consider only non-duplicate values.", C_ID = 5, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 148, Body = " Reasons for consideration of the stored procedure can be?", C_ID = 5, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 149, Body = " __________ takes no parameters and returns all kinds of interesting information.", C_ID = 5, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 150, Body = "  Which of the following has support for transaction?", C_ID = 5, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 151, Body = " Point out the wrong statement.", C_ID = 5, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 152, Body = " __________create the removable database.", C_ID = 5, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 153, Body = "  Which of the following stored procedure is used for error messages?", C_ID = 5, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 154, Body = "  _____________ sets procedure options in SQL Server.", C_ID = 5, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 155, Body = " __________ is used to build the code dynamically and execute it.", C_ID = 5, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 156, Body = "Stored procedure used to remember the exact number of bytes is _____________", C_ID = 5, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 157, Body = "Point out the correct statement.", C_ID = 5, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 158, Body = "  __________ is used to build the code dynamically and execute it.", C_ID = 5, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 159, Body = " Stored procedure used to remember the exact number of bytes is _____________", C_ID = 5, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 160, Body = " Point out the correct statement.", C_ID = 5, type = "MCQ", is_deleted = false });

            //service.Articles.Add(new Article { Ar_ID = 41, ID_question = 129, answer = "SQL Profiler is a tool which allows system administrator to monitor events in the SQL server" });
            //service.Articles.Add(new Article { Ar_ID = 42, ID_question = 130, answer = "SQL Server supports recursive stored procedure which calls by itself" });
            //service.Articles.Add(new Article { Ar_ID = 43, ID_question = 131, answer = "Local temporary tables are visible when there is a connection, and are deleted when the connection is closed." });
            //service.Articles.Add(new Article { Ar_ID = 44, ID_question = 132, answer = "A CHECK constraint can be applied to a column in a table to limit the values that can be placed in a column." });
            //service.Articles.Add(new Article { Ar_ID = 45, ID_question = 133, answer = "SQL server can be connected to any database which has OLE-DB provider to give a link" });
            //service.Articles.Add(new Article { Ar_ID = 46, ID_question = 134, answer = "A sub-query is a query which can be nested inside a main query like Select, Update, Insert or Delete statements" });
            //service.Articles.Add(new Article { Ar_ID = 47, ID_question = 135, answer = "Multiple column sub query which returns multiple columns to the main query. With that sub query result, Main query will be executed" });
            //service.Articles.Add(new Article { Ar_ID = 48, ID_question = 136, answer = "The SQL Server agent plays a vital role in day to day tasks of SQL server administrator(DBA)." });
            //service.Articles.Add(new Article { Ar_ID = 49, ID_question = 137, answer = "Scheduled tasks or jobs are used to automate processes that can be run on a scheduled time at a regular interval." });
            //service.Articles.Add(new Article { Ar_ID = 50, ID_question = 138, answer = " jobs are used to automate processes that can be run on a scheduled time at a regular interval." });



            //service.T_F.Add(new T_F { TF_ID = 37, ID_question = 139, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 38, ID_question = 140, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 39, ID_question = 141, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 40, ID_question = 142, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 41, ID_question = 143, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 42, ID_question = 144, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 43, ID_question = 145, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 44, ID_question = 146, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 45, ID_question = 147, istrue = true });



            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 217, istrue = false, choice = "A)SQL Server supports", ID_question = 148 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 218, istrue = false, choice = "B)stored procedure which calls by itself", ID_question = 148 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 219, istrue = true, choice = "C)Local temporary tables", ID_question = 148 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 220, istrue = false, choice = "A)SQL Server supports", ID_question = 149 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 221, istrue = true, choice = "B)stored procedure which calls by itself", ID_question = 149 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 222, istrue = false, choice = "C)Local temporary tables", ID_question = 149 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 223, istrue = false, choice = "D)CHECK constraint", ID_question = 149 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 224, istrue = false, choice = "A)database which has OLE-DB provider", ID_question = 150 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 225, istrue = false, choice = "B)sub-query", ID_question = 150 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 226, istrue = true, choice = "C)Multiple column", ID_question = 150 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 227, istrue = true, choice = "A)calls by itself", ID_question = 151 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 228, istrue = false, choice = "B)Local temporary", ID_question = 151 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 229, istrue = true, choice = "c)CHECK constraint", ID_question = 151 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 230, istrue = false, choice = "D)Scheduled", ID_question = 151 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 231, istrue = false, choice = "f)COALESCE", ID_question = 151 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 232, istrue = false, choice = "A)calls by itself", ID_question = 152 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 233, istrue = true, choice = "B)Local temporary", ID_question = 152 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 234, istrue = false, choice = "c)CHECK constraint", ID_question = 152 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 235, istrue = true, choice = "D)Scheduled", ID_question = 152 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 236, istrue = true, choice = "f)COALESCE", ID_question = 152 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 237, istrue = true, choice = "A)calls by itself", ID_question = 153 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 238, istrue = true, choice = "B)Local temporary", ID_question = 153 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 239, istrue = true, choice = "c)CHECK constraint", ID_question = 153 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 240, istrue = false, choice = "A)calls by itself", ID_question = 154 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 241, istrue = true, choice = "B)Local temporary", ID_question = 154 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 242, istrue = false, choice = "c)CHECK constraint", ID_question = 154 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 243, istrue = false, choice = "A)calls by itself", ID_question = 155 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 244, istrue = true, choice = "B)Local temporary", ID_question = 155 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 245, istrue = false, choice = "c)CHECK constraint", ID_question = 155 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 246, istrue = false, choice = "d)calls by itself", ID_question = 155 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 247, istrue = true, choice = "e)Local temporary", ID_question = 155 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 248, istrue = false, choice = "f)CHECK constraint", ID_question = 155 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 249, istrue = false, choice = "A)calls by itself", ID_question = 156 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 250, istrue = true, choice = "B)Local temporary", ID_question = 156 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 251, istrue = true, choice = "c)CHECK constraint", ID_question = 156 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 252, istrue = false, choice = "d)calls by itself", ID_question = 156 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 253, istrue = true, choice = "f)Local temporary", ID_question = 156 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 254, istrue = false, choice = "g)CHECK constraint", ID_question = 156 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 255, istrue = false, choice = "A)calls by itself", ID_question = 157 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 256, istrue = true, choice = "B)Local temporary", ID_question = 157 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 257, istrue = false, choice = "c)CHECK constraint", ID_question = 157 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 258, istrue = false, choice = "d)calls by itself", ID_question = 157 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 259, istrue = false, choice = "A)calls by itself", ID_question = 158 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 260, istrue = true, choice = "B)Local temporary", ID_question = 158 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 261, istrue = false, choice = "c)CHECK constraint", ID_question = 158 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 262, istrue = false, choice = "d)calls by itself", ID_question = 158 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 263, istrue = false, choice = "A)calls by itself", ID_question = 159 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 264, istrue = true, choice = "B)Local temporary", ID_question = 159 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 265, istrue = false, choice = "c)CHECK constraint", ID_question = 159 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 266, istrue = false, choice = "d)calls by itself", ID_question = 159 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 267, istrue = false, choice = "A)calls by itself", ID_question = 160 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 268, istrue = true, choice = "B)Local temporary", ID_question = 160 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 269, istrue = false, choice = "c)CHECK constraint", ID_question = 160 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 270, istrue = false, choice = "d)calls by itself", ID_question = 160 }); ;




            //service.Questions.Add(new Question { ID_question = 161, Body = "What Is SQL Profiler?", C_ID = 6, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 162, Body = "What is recursive stored procedure?", C_ID = 6, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 163, Body = "What are the differences between local and global temporary tables?", C_ID = 5, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 164, Body = "What is CHECK constraint?", C_ID = 6, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 165, Body = "Can SQL servers linked to other servers?", C_ID = 6, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 166, Body = "What is sub query and its properties?", C_ID = 6, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 167, Body = "What are the types of sub query?", C_ID = 6, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 168, Body = "What is SQL server agent?", C_ID = 6, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 169, Body = " What are scheduled tasks in SQL Server?", C_ID = 6, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 170, Body = "What is COALESCE in SQL Server?", C_ID = 6, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 171, Body = " A view doesn?t have data of its own.", C_ID = 6, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 172, Body = "A DDL statement or a DCL statement is automatically committed.", C_ID = 6, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 173, Body = " You can use a subquery in an INSERT statement.", C_ID = 6, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 174, Body = "Attempting to delete a record with a value attached to an integrity constraint, returns an error.", C_ID = 6, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 175, Body = "While inserting new rows in a table you must list values in the default order of the columns.", C_ID = 6, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 176, Body = " Multiple column subqueries return more than one column from the inner SELECT statement.", C_ID = 6, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 177, Body = " A multiple row subquery returns more than one row from the inner SELECT statement.", C_ID = 6, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 178, Body = " All group functions ignore null values.", C_ID = 6, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 179, Body = " The DISTINCT keyword allows a function consider only non-duplicate values.", C_ID = 6, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 180, Body = " Reasons for consideration of the stored procedure can be?", C_ID = 6, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 181, Body = " __________ takes no parameters and returns all kinds of interesting information.", C_ID = 6, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 182, Body = "  Which of the following has support for transaction?", C_ID = 6, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 183, Body = " Point out the wrong statement.", C_ID = 6, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 184, Body = " __________create the removable database.", C_ID = 6, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 185, Body = "  Which of the following stored procedure is used for error messages?", C_ID = 6, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 186, Body = "  _____________ sets procedure options in SQL Server.", C_ID = 6, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 187, Body = " __________ is used to build the code dynamically and execute it.", C_ID = 6, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 188, Body = "Stored procedure used to remember the exact number of bytes is _____________", C_ID = 6, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 189, Body = "Point out the correct statement.", C_ID = 6, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 190, Body = "  __________ is used to build the code dynamically and execute it.", C_ID = 6, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 191, Body = " Stored procedure used to remember the exact number of bytes is _____________", C_ID = 6, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 192, Body = " Point out the correct statement.", C_ID = 6, type = "MCQ", is_deleted = false });

            //service.Articles.Add(new Article { Ar_ID = 51, ID_question = 161, answer = "SQL Profiler is a tool which allows system administrator to monitor events in the SQL server" });
            //service.Articles.Add(new Article { Ar_ID = 52, ID_question = 162, answer = "SQL Server supports recursive stored procedure which calls by itself" });
            //service.Articles.Add(new Article { Ar_ID = 53, ID_question = 163, answer = "Local temporary tables are visible when there is a connection, and are deleted when the connection is closed." });
            //service.Articles.Add(new Article { Ar_ID = 54, ID_question = 164, answer = "A CHECK constraint can be applied to a column in a table to limit the values that can be placed in a column." });
            //service.Articles.Add(new Article { Ar_ID = 55, ID_question = 165, answer = "SQL server can be connected to any database which has OLE-DB provider to give a link" });
            //service.Articles.Add(new Article { Ar_ID = 56, ID_question = 166, answer = "A sub-query is a query which can be nested inside a main query like Select, Update, Insert or Delete statements" });
            //service.Articles.Add(new Article { Ar_ID = 57, ID_question = 167, answer = "Multiple column sub query which returns multiple columns to the main query. With that sub query result, Main query will be executed" });
            //service.Articles.Add(new Article { Ar_ID = 58, ID_question = 168, answer = "The SQL Server agent plays a vital role in day to day tasks of SQL server administrator(DBA)." });
            //service.Articles.Add(new Article { Ar_ID = 59, ID_question = 169, answer = "Scheduled tasks or jobs are used to automate processes that can be run on a scheduled time at a regular interval." });
            //service.Articles.Add(new Article { Ar_ID = 60, ID_question = 170, answer = " jobs are used to automate processes that can be run on a scheduled time at a regular interval." });



            //service.T_F.Add(new T_F { TF_ID = 46, ID_question = 171, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 47, ID_question = 172, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 48, ID_question = 173, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 49, ID_question = 174, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 50, ID_question = 175, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 51, ID_question = 176, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 52, ID_question = 177, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 53, ID_question = 178, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 54, ID_question = 179, istrue = true });



            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 271, istrue = false, choice = "A)SQL Server supports", ID_question = 180 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 272, istrue = false, choice = "B)stored procedure which calls by itself", ID_question = 180 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 273, istrue = true, choice = "C)Local temporary tables", ID_question = 180 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 274, istrue = false, choice = "A)SQL Server supports", ID_question = 181 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 275, istrue = true, choice = "B)stored procedure which calls by itself", ID_question = 181 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 276, istrue = false, choice = "C)Local temporary tables", ID_question = 181 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 277, istrue = false, choice = "D)CHECK constraint", ID_question = 181 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 278, istrue = false, choice = "A)database which has OLE-DB provider", ID_question = 182 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 279, istrue = false, choice = "B)sub-query", ID_question = 182 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 280, istrue = true, choice = "C)Multiple column", ID_question = 182 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 281, istrue = true, choice = "A)calls by itself", ID_question = 183 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 282, istrue = false, choice = "B)Local temporary", ID_question = 183 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 283, istrue = true, choice = "c)CHECK constraint", ID_question = 183 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 284, istrue = false, choice = "D)Scheduled", ID_question = 183 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 285, istrue = false, choice = "f)COALESCE", ID_question = 183 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 286, istrue = false, choice = "A)calls by itself", ID_question = 184 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 287, istrue = true, choice = "B)Local temporary", ID_question = 184 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 288, istrue = false, choice = "c)CHECK constraint", ID_question = 184 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 289, istrue = true, choice = "D)Scheduled", ID_question = 184 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 290, istrue = true, choice = "f)COALESCE", ID_question = 184 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 291, istrue = true, choice = "A)calls by itself", ID_question = 185 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 292, istrue = true, choice = "B)Local temporary", ID_question = 185 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 293, istrue = true, choice = "c)CHECK constraint", ID_question = 185 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 294, istrue = false, choice = "A)calls by itself", ID_question = 186 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 295, istrue = true, choice = "B)Local temporary", ID_question = 186 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 296, istrue = false, choice = "c)CHECK constraint", ID_question = 186 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 297, istrue = false, choice = "A)calls by itself", ID_question = 187 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 298, istrue = true, choice = "B)Local temporary", ID_question = 187 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 299, istrue = false, choice = "c)CHECK constraint", ID_question = 187 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 300, istrue = false, choice = "d)calls by itself", ID_question = 187 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 301, istrue = true, choice = "e)Local temporary", ID_question = 187 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 302, istrue = false, choice = "f)CHECK constraint", ID_question = 187 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 303, istrue = false, choice = "A)calls by itself", ID_question = 188 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 304, istrue = true, choice = "B)Local temporary", ID_question = 188 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 305, istrue = true, choice = "c)CHECK constraint", ID_question = 188 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 306, istrue = false, choice = "d)calls by itself", ID_question = 188 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 307, istrue = true, choice = "f)Local temporary", ID_question = 188 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 308, istrue = false, choice = "g)CHECK constraint", ID_question = 188 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 309, istrue = false, choice = "A)calls by itself", ID_question = 189 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 310, istrue = true, choice = "B)Local temporary", ID_question = 189 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 311, istrue = false, choice = "c)CHECK constraint", ID_question = 189 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 312, istrue = false, choice = "d)calls by itself", ID_question = 189 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 313, istrue = false, choice = "A)calls by itself", ID_question = 190 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 314, istrue = true, choice = "B)Local temporary", ID_question = 190 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 315, istrue = false, choice = "c)CHECK constraint", ID_question = 190 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 316, istrue = false, choice = "d)calls by itself", ID_question = 190 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 317, istrue = false, choice = "A)calls by itself", ID_question = 191 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 318, istrue = true, choice = "B)Local temporary", ID_question = 191 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 319, istrue = false, choice = "c)CHECK constraint", ID_question = 191 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 320, istrue = false, choice = "d)calls by itself", ID_question = 191 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 321, istrue = false, choice = "A)calls by itself", ID_question = 192 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 322, istrue = true, choice = "B)Local temporary", ID_question = 192 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 323, istrue = false, choice = "c)CHECK constraint", ID_question = 192 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 324, istrue = false, choice = "d)calls by itself", ID_question = 192 }); ;




            //service.Questions.Add(new Question { ID_question = 193, Body = "What Is SQL Profiler?", C_ID = 7, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 194, Body = "What is recursive stored procedure?", C_ID = 7, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 195, Body = "What are the differences between local and global temporary tables?", C_ID = 7, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 196, Body = "What is CHECK constraint?", C_ID = 7, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 197, Body = "Can SQL servers linked to other servers?", C_ID = 7, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 198, Body = "What is sub query and its properties?", C_ID = 7, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 199, Body = "What are the types of sub query?", C_ID = 7, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 200, Body = "What is SQL server agent?", C_ID = 7, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 201, Body = " What are scheduled tasks in SQL Server?", C_ID = 7, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 202, Body = "What is COALESCE in SQL Server?", C_ID = 7, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 203, Body = " A view doesn?t have data of its own.", C_ID = 7, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 204, Body = "A DDL statement or a DCL statement is automatically committed.", C_ID = 7, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 205, Body = " You can use a subquery in an INSERT statement.", C_ID = 7, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 206, Body = "Attempting to delete a record with a value attached to an integrity constraint, returns an error.", C_ID = 7, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 207, Body = "While inserting new rows in a table you must list values in the default order of the columns.", C_ID = 7, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 208, Body = " Multiple column subqueries return more than one column from the inner SELECT statement.", C_ID = 7, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 209, Body = " A multiple row subquery returns more than one row from the inner SELECT statement.", C_ID = 7, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 210, Body = " All group functions ignore null values.", C_ID = 7, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 211, Body = " The DISTINCT keyword allows a function consider only non-duplicate values.", C_ID = 7, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 212, Body = " Reasons for consideration of the stored procedure can be?", C_ID = 7, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 213, Body = " __________ takes no parameters and returns all kinds of interesting information.", C_ID = 7, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 214, Body = "  Which of the following has support for transaction?", C_ID = 7, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 215, Body = " Point out the wrong statement.", C_ID = 7, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 216, Body = " __________create the removable database.", C_ID = 7, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 217, Body = "  Which of the following stored procedure is used for error messages?", C_ID = 7, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 218, Body = "  _____________ sets procedure options in SQL Server.", C_ID = 7, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 219, Body = " __________ is used to build the code dynamically and execute it.", C_ID = 7, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 220, Body = "Stored procedure used to remember the exact number of bytes is _____________", C_ID = 7, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 221, Body = "Point out the correct statement.", C_ID = 7, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 222, Body = "  __________ is used to build the code dynamically and execute it.", C_ID = 7, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 223, Body = " Stored procedure used to remember the exact number of bytes is _____________", C_ID = 7, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 224, Body = " Point out the correct statement.", C_ID = 7, type = "MCQ", is_deleted = false });

            //service.Articles.Add(new Article { Ar_ID = 61, ID_question = 193, answer = "SQL Profiler is a tool which allows system administrator to monitor events in the SQL server" });
            //service.Articles.Add(new Article { Ar_ID = 62, ID_question = 194, answer = "SQL Server supports recursive stored procedure which calls by itself" });
            //service.Articles.Add(new Article { Ar_ID = 63, ID_question = 195, answer = "Local temporary tables are visible when there is a connection, and are deleted when the connection is closed." });
            //service.Articles.Add(new Article { Ar_ID = 64, ID_question = 196, answer = "A CHECK constraint can be applied to a column in a table to limit the values that can be placed in a column." });
            //service.Articles.Add(new Article { Ar_ID = 65, ID_question = 197, answer = "SQL server can be connected to any database which has OLE-DB provider to give a link" });
            //service.Articles.Add(new Article { Ar_ID = 66, ID_question = 198, answer = "A sub-query is a query which can be nested inside a main query like Select, Update, Insert or Delete statements" });
            //service.Articles.Add(new Article { Ar_ID = 67, ID_question = 199, answer = "Multiple column sub query which returns multiple columns to the main query. With that sub query result, Main query will be executed" });
            //service.Articles.Add(new Article { Ar_ID = 68, ID_question = 200, answer = "The SQL Server agent plays a vital role in day to day tasks of SQL server administrator(DBA)." });
            //service.Articles.Add(new Article { Ar_ID = 69, ID_question = 201, answer = "Scheduled tasks or jobs are used to automate processes that can be run on a scheduled time at a regular interval." });
            //service.Articles.Add(new Article { Ar_ID = 70, ID_question = 202, answer = " jobs are used to automate processes that can be run on a scheduled time at a regular interval." });



            //service.T_F.Add(new T_F { TF_ID = 55, ID_question = 203, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 56, ID_question = 204, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 57, ID_question = 205, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 58, ID_question = 206, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 59, ID_question = 207, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 60, ID_question = 208, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 61, ID_question = 209, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 62, ID_question = 210, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 63, ID_question = 211, istrue = true });



            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 325, istrue = false, choice = "A)SQL Server supports", ID_question = 212 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 326, istrue = false, choice = "B)stored procedure which calls by itself", ID_question = 212 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 327, istrue = true, choice = "C)Local temporary tables", ID_question = 212 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 328, istrue = false, choice = "A)SQL Server supports", ID_question = 213 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 329, istrue = true, choice = "B)stored procedure which calls by itself", ID_question = 213 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 330, istrue = false, choice = "C)Local temporary tables", ID_question = 213 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 331, istrue = false, choice = "D)CHECK constraint", ID_question = 213 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 332, istrue = false, choice = "A)database which has OLE-DB provider", ID_question = 214 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 333, istrue = false, choice = "B)sub-query", ID_question = 214 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 334, istrue = true, choice = "C)Multiple column", ID_question = 214 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 335, istrue = true, choice = "A)calls by itself", ID_question = 215 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 336, istrue = false, choice = "B)Local temporary", ID_question = 215 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 337, istrue = true, choice = "c)CHECK constraint", ID_question = 215 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 338, istrue = false, choice = "D)Scheduled", ID_question = 215 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 339, istrue = false, choice = "f)COALESCE", ID_question = 215 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 340, istrue = false, choice = "A)calls by itself", ID_question = 216 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 341, istrue = true, choice = "B)Local temporary", ID_question = 216 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 342, istrue = false, choice = "c)CHECK constraint", ID_question = 216 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 343, istrue = true, choice = "D)Scheduled", ID_question = 216 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 344, istrue = true, choice = "f)COALESCE", ID_question = 216 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 345, istrue = true, choice = "A)calls by itself", ID_question = 217 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 346, istrue = true, choice = "B)Local temporary", ID_question = 217 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 347, istrue = true, choice = "c)CHECK constraint", ID_question = 217 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 348, istrue = false, choice = "A)calls by itself", ID_question = 218 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 349, istrue = true, choice = "B)Local temporary", ID_question = 218 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 350, istrue = false, choice = "c)CHECK constraint", ID_question = 218 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 351, istrue = false, choice = "A)calls by itself", ID_question = 219 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 352, istrue = true, choice = "B)Local temporary", ID_question = 219 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 353, istrue = false, choice = "c)CHECK constraint", ID_question = 219 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 354, istrue = false, choice = "d)calls by itself", ID_question = 219 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 355, istrue = true, choice = "e)Local temporary", ID_question = 219 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 356, istrue = false, choice = "f)CHECK constraint", ID_question = 219 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 357, istrue = false, choice = "A)calls by itself", ID_question = 220 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 358, istrue = true, choice = "B)Local temporary", ID_question = 220 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 359, istrue = true, choice = "c)CHECK constraint", ID_question = 220 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 360, istrue = false, choice = "d)calls by itself", ID_question = 220 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 361, istrue = true, choice = "f)Local temporary", ID_question = 220 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 362, istrue = false, choice = "g)CHECK constraint", ID_question = 220 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 363, istrue = false, choice = "A)calls by itself", ID_question = 221 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 364, istrue = true, choice = "B)Local temporary", ID_question = 221 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 365, istrue = false, choice = "c)CHECK constraint", ID_question = 221 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 366, istrue = false, choice = "d)calls by itself", ID_question = 221 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 367, istrue = false, choice = "A)calls by itself", ID_question = 222 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 368, istrue = true, choice = "B)Local temporary", ID_question = 222 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 369, istrue = false, choice = "c)CHECK constraint", ID_question = 222 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 370, istrue = false, choice = "d)calls by itself", ID_question = 222 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 371, istrue = false, choice = "A)calls by itself", ID_question = 223 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 372, istrue = true, choice = "B)Local temporary", ID_question = 223 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 373, istrue = false, choice = "c)CHECK constraint", ID_question = 223 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 374, istrue = false, choice = "d)calls by itself", ID_question = 223 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 375, istrue = false, choice = "A)calls by itself", ID_question = 224 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 376, istrue = true, choice = "B)Local temporary", ID_question = 224 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 376, istrue = false, choice = "c)CHECK constraint", ID_question = 224 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 376, istrue = false, choice = "d)calls by itself", ID_question = 224 }); ;


            //service.Questions.Add(new Question { ID_question = 225, Body = "What Is SQL Profiler?", C_ID = 8, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 226, Body = "What is recursive stored procedure?", C_ID = 8, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 227, Body = "What are the differences between local and global temporary tables?", C_ID = 8, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 228, Body = "What is CHECK constraint?", C_ID = 8, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 229, Body = "Can SQL servers linked to other servers?", C_ID = 8, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 230, Body = "What is sub query and its properties?", C_ID = 8, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 231, Body = "What are the types of sub query?", C_ID = 8, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 232, Body = "What is SQL server agent?", C_ID = 8, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 233, Body = " What are scheduled tasks in SQL Server?", C_ID = 8, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 234, Body = "What is COALESCE in SQL Server?", C_ID = 8, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 235, Body = " A view doesn?t have data of its own.", C_ID = 8, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 236, Body = "A DDL statement or a DCL statement is automatically committed.", C_ID = 8, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 237, Body = " You can use a subquery in an INSERT statement.", C_ID = 8, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 238, Body = "Attempting to delete a record with a value attached to an integrity constraint, returns an error.", C_ID = 8, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 239, Body = "While inserting new rows in a table you must list values in the default order of the columns.", C_ID = 8, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 240, Body = " Multiple column subqueries return more than one column from the inner SELECT statement.", C_ID = 8, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 241, Body = " A multiple row subquery returns more than one row from the inner SELECT statement.", C_ID = 8, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 242, Body = " All group functions ignore null values.", C_ID = 8, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 243, Body = " The DISTINCT keyword allows a function consider only non-duplicate values.", C_ID = 8, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 244, Body = " Reasons for consideration of the stored procedure can be?", C_ID = 8, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 245, Body = " __________ takes no parameters and returns all kinds of interesting information.", C_ID = 8, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 246, Body = "  Which of the following has support for transaction?", C_ID = 8, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 247, Body = " Point out the wrong statement.", C_ID = 8, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 248, Body = " __________create the removable database.", C_ID = 8, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 249, Body = "  Which of the following stored procedure is used for error messages?", C_ID = 8, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 250, Body = "  _____________ sets procedure options in SQL Server.", C_ID = 8, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 251, Body = " __________ is used to build the code dynamically and execute it.", C_ID = 8, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 252, Body = "Stored procedure used to remember the exact number of bytes is _____________", C_ID = 8, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 253, Body = "Point out the correct statement.", C_ID = 8, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 254, Body = "  __________ is used to build the code dynamically and execute it.", C_ID = 8, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 255, Body = " Stored procedure used to remember the exact number of bytes is _____________", C_ID = 8, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 256, Body = " Point out the correct statement.", C_ID = 8, type = "MCQ", is_deleted = false });

            //service.Articles.Add(new Article { Ar_ID = 71, ID_question = 225, answer = "SQL Profiler is a tool which allows system administrator to monitor events in the SQL server" });
            //service.Articles.Add(new Article { Ar_ID = 72, ID_question = 226, answer = "SQL Server supports recursive stored procedure which calls by itself" });
            //service.Articles.Add(new Article { Ar_ID = 73, ID_question = 227, answer = "Local temporary tables are visible when there is a connection, and are deleted when the connection is closed." });
            //service.Articles.Add(new Article { Ar_ID = 74, ID_question = 228, answer = "A CHECK constraint can be applied to a column in a table to limit the values that can be placed in a column." });
            //service.Articles.Add(new Article { Ar_ID = 75, ID_question = 229, answer = "SQL server can be connected to any database which has OLE-DB provider to give a link" });
            //service.Articles.Add(new Article { Ar_ID = 76, ID_question = 230, answer = "A sub-query is a query which can be nested inside a main query like Select, Update, Insert or Delete statements" });
            //service.Articles.Add(new Article { Ar_ID = 77, ID_question = 231, answer = "Multiple column sub query which returns multiple columns to the main query. With that sub query result, Main query will be executed" });
            //service.Articles.Add(new Article { Ar_ID = 78, ID_question = 232, answer = "The SQL Server agent plays a vital role in day to day tasks of SQL server administrator(DBA)." });
            //service.Articles.Add(new Article { Ar_ID = 79, ID_question = 233, answer = "Scheduled tasks or jobs are used to automate processes that can be run on a scheduled time at a regular interval." });
            //service.Articles.Add(new Article { Ar_ID = 80, ID_question = 234, answer = " jobs are used to automate processes that can be run on a scheduled time at a regular interval." });



            //service.T_F.Add(new T_F { TF_ID = 64, ID_question = 235, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 65, ID_question = 236, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 66, ID_question = 237, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 67, ID_question = 238, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 68, ID_question = 239, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 69, ID_question = 240, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 70, ID_question = 241, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 71, ID_question = 242, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 72, ID_question = 243, istrue = true });



            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 377, istrue = false, choice = "A)SQL Server supports", ID_question = 244 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 378, istrue = false, choice = "B)stored procedure which calls by itself", ID_question = 244 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 379, istrue = true, choice = "C)Local temporary tables", ID_question = 244 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 380, istrue = false, choice = "A)SQL Server supports", ID_question = 245 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 381, istrue = true, choice = "B)stored procedure which calls by itself", ID_question = 245 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 382, istrue = false, choice = "C)Local temporary tables", ID_question = 245 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 383, istrue = false, choice = "D)CHECK constraint", ID_question = 245 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 384, istrue = false, choice = "A)database which has OLE-DB provider", ID_question = 246 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 385, istrue = false, choice = "B)sub-query", ID_question = 246 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 386, istrue = true, choice = "C)Multiple column", ID_question = 246 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 387, istrue = true, choice = "A)calls by itself", ID_question = 247 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 388, istrue = false, choice = "B)Local temporary", ID_question = 247 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 389, istrue = true, choice = "c)CHECK constraint", ID_question = 247 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 390, istrue = false, choice = "D)Scheduled", ID_question = 247 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 391, istrue = false, choice = "f)COALESCE", ID_question = 247 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 392, istrue = false, choice = "A)calls by itself", ID_question = 248 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 393, istrue = true, choice = "B)Local temporary", ID_question = 248 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 394, istrue = false, choice = "c)CHECK constraint", ID_question = 248 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 395, istrue = true, choice = "D)Scheduled", ID_question = 248 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 396, istrue = true, choice = "f)COALESCE", ID_question = 248 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 397, istrue = true, choice = "A)calls by itself", ID_question = 249 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 398, istrue = true, choice = "B)Local temporary", ID_question = 249 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 399, istrue = true, choice = "c)CHECK constraint", ID_question = 249 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 400, istrue = false, choice = "A)calls by itself", ID_question = 250 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 401, istrue = true, choice = "B)Local temporary", ID_question = 250 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 402, istrue = false, choice = "c)CHECK constraint", ID_question = 250 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 403, istrue = false, choice = "A)calls by itself", ID_question = 251 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 404, istrue = true, choice = "B)Local temporary", ID_question = 251 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 405, istrue = false, choice = "c)CHECK constraint", ID_question = 251 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 406, istrue = false, choice = "d)calls by itself", ID_question = 251 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 407, istrue = true, choice = "e)Local temporary", ID_question = 251 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 408, istrue = false, choice = "f)CHECK constraint", ID_question = 251 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 409, istrue = false, choice = "A)calls by itself", ID_question = 252 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 410, istrue = true, choice = "B)Local temporary", ID_question = 252 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 411, istrue = true, choice = "c)CHECK constraint", ID_question = 252 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 412, istrue = false, choice = "d)calls by itself", ID_question = 252 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 413, istrue = true, choice = "f)Local temporary", ID_question = 252 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 414, istrue = false, choice = "g)CHECK constraint", ID_question = 252 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 415, istrue = false, choice = "A)calls by itself", ID_question = 253 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 416, istrue = true, choice = "B)Local temporary", ID_question = 253 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 417, istrue = false, choice = "c)CHECK constraint", ID_question = 253 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 418, istrue = false, choice = "d)calls by itself", ID_question = 253 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 419, istrue = false, choice = "A)calls by itself", ID_question = 254 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 420, istrue = true, choice = "B)Local temporary", ID_question = 254 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 421, istrue = false, choice = "c)CHECK constraint", ID_question = 254 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 422, istrue = false, choice = "d)calls by itself", ID_question = 254 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 423, istrue = false, choice = "A)calls by itself", ID_question = 255 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 424, istrue = true, choice = "B)Local temporary", ID_question = 255 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 425, istrue = false, choice = "c)CHECK constraint", ID_question = 255 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 426, istrue = false, choice = "d)calls by itself", ID_question = 255 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 427, istrue = false, choice = "A)calls by itself", ID_question = 256 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 428, istrue = true, choice = "B)Local temporary", ID_question = 256 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 429, istrue = false, choice = "c)CHECK constraint", ID_question = 256 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 430, istrue = false, choice = "d)calls by itself", ID_question = 256 });


            //service.Questions.Add(new Question { ID_question = 257, Body = "What Is SQL Profiler?", C_ID = 9, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 258, Body = "What is recursive stored procedure?", C_ID = 9, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 259, Body = "What are the differences between local and global temporary tables?", C_ID = 9, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 260, Body = "What is CHECK constraint?", C_ID = 9, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 261, Body = "Can SQL servers linked to other servers?", C_ID = 9, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 262, Body = "What is sub query and its properties?", C_ID = 9, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 263, Body = "What are the types of sub query?", C_ID = 9, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 264, Body = "What is SQL server agent?", C_ID = 9, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 265, Body = " What are scheduled tasks in SQL Server?", C_ID = 9, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 266, Body = "What is COALESCE in SQL Server?", C_ID = 9, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 267, Body = " A view doesn?t have data of its own.", C_ID = 9, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 268, Body = "A DDL statement or a DCL statement is automatically committed.", C_ID = 9, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 269, Body = " You can use a subquery in an INSERT statement.", C_ID = 9, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 270, Body = "Attempting to delete a record with a value attached to an integrity constraint, returns an error.", C_ID = 9, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 271, Body = "While inserting new rows in a table you must list values in the default order of the columns.", C_ID = 9, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 272, Body = " Multiple column subqueries return more than one column from the inner SELECT statement.", C_ID = 9, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 273, Body = " A multiple row subquery returns more than one row from the inner SELECT statement.", C_ID = 9, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 274, Body = " All group functions ignore null values.", C_ID = 9, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 275, Body = " The DISTINCT keyword allows a function consider only non-duplicate values.", C_ID = 9, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 276, Body = " Reasons for consideration of the stored procedure can be?", C_ID = 9, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 277, Body = " __________ takes no parameters and returns all kinds of interesting information.", C_ID = 9, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 278, Body = "  Which of the following has support for transaction?", C_ID = 9, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 279, Body = " Point out the wrong statement.", C_ID = 9, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 280, Body = " __________create the removable database.", C_ID = 9, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 281, Body = "  Which of the following stored procedure is used for error messages?", C_ID = 9, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 282, Body = "  _____________ sets procedure options in SQL Server.", C_ID = 9, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 283, Body = " __________ is used to build the code dynamically and execute it.", C_ID = 9, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 284, Body = "Stored procedure used to remember the exact number of bytes is _____________", C_ID = 9, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 285, Body = "Point out the correct statement.", C_ID = 9, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 286, Body = "  __________ is used to build the code dynamically and execute it.", C_ID = 9, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 287, Body = " Stored procedure used to remember the exact number of bytes is _____________", C_ID = 9, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 288, Body = " Point out the correct statement.", C_ID = 9, type = "MCQ", is_deleted = false });

            //service.Articles.Add(new Article { Ar_ID = 81, ID_question = 257, answer = "SQL Profiler is a tool which allows system administrator to monitor events in the SQL server" });
            //service.Articles.Add(new Article { Ar_ID = 82, ID_question = 258, answer = "SQL Server supports recursive stored procedure which calls by itself" });
            //service.Articles.Add(new Article { Ar_ID = 83, ID_question = 259, answer = "Local temporary tables are visible when there is a connection, and are deleted when the connection is closed." });
            //service.Articles.Add(new Article { Ar_ID = 84, ID_question = 260, answer = "A CHECK constraint can be applied to a column in a table to limit the values that can be placed in a column." });
            //service.Articles.Add(new Article { Ar_ID = 85, ID_question = 261, answer = "SQL server can be connected to any database which has OLE-DB provider to give a link" });
            //service.Articles.Add(new Article { Ar_ID = 86, ID_question = 262, answer = "A sub-query is a query which can be nested inside a main query like Select, Update, Insert or Delete statements" });
            //service.Articles.Add(new Article { Ar_ID = 87, ID_question = 263, answer = "Multiple column sub query which returns multiple columns to the main query. With that sub query result, Main query will be executed" });
            //service.Articles.Add(new Article { Ar_ID = 88, ID_question = 264, answer = "The SQL Server agent plays a vital role in day to day tasks of SQL server administrator(DBA)." });
            //service.Articles.Add(new Article { Ar_ID = 89, ID_question = 265, answer = "Scheduled tasks or jobs are used to automate processes that can be run on a scheduled time at a regular interval." });
            //service.Articles.Add(new Article { Ar_ID = 90, ID_question = 266, answer = " jobs are used to automate processes that can be run on a scheduled time at a regular interval." });



            //service.T_F.Add(new T_F { TF_ID = 73, ID_question = 267, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 74, ID_question = 268, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 75, ID_question = 269, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 76, ID_question = 270, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 77, ID_question = 271, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 78, ID_question = 272, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 79, ID_question = 273, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 80, ID_question = 274, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 81, ID_question = 275, istrue = true });




            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 434, istrue = false, choice = "A)SQL Server supports", ID_question = 276 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 435, istrue = true, choice = "B)stored procedure which calls by itself", ID_question = 276 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 436, istrue = false, choice = "C)Local temporary tables", ID_question = 276 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 437, istrue = false, choice = "D)CHECK constraint", ID_question = 276 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 438, istrue = false, choice = "A)database which has OLE-DB provider", ID_question = 277 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 439, istrue = false, choice = "B)sub-query", ID_question = 277 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 440, istrue = true, choice = "C)Multiple column", ID_question = 277 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 441, istrue = true, choice = "A)calls by itself", ID_question = 278 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 442, istrue = false, choice = "B)Local temporary", ID_question = 278 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 443, istrue = true, choice = "c)CHECK constraint", ID_question = 278 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 444, istrue = false, choice = "D)Scheduled", ID_question = 278 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 445, istrue = false, choice = "f)COALESCE", ID_question = 278 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 446, istrue = false, choice = "A)calls by itself", ID_question = 279 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 447, istrue = true, choice = "B)Local temporary", ID_question = 279 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 448, istrue = false, choice = "c)CHECK constraint", ID_question = 279 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 449, istrue = true, choice = "D)Scheduled", ID_question = 279 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 450, istrue = true, choice = "f)COALESCE", ID_question = 279 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 451, istrue = true, choice = "A)calls by itself", ID_question = 280 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 452, istrue = true, choice = "B)Local temporary", ID_question = 280 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 453, istrue = true, choice = "c)CHECK constraint", ID_question = 280 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 454, istrue = false, choice = "A)calls by itself", ID_question = 281 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 455, istrue = true, choice = "B)Local temporary", ID_question = 281 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 456, istrue = false, choice = "c)CHECK constraint", ID_question = 281 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 457, istrue = false, choice = "A)calls by itself", ID_question = 282 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 458, istrue = true, choice = "B)Local temporary", ID_question = 282 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 459, istrue = false, choice = "c)CHECK constraint", ID_question = 282 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 460, istrue = false, choice = "d)calls by itself", ID_question = 282 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 461, istrue = true, choice = "e)Local temporary", ID_question = 282 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 462, istrue = false, choice = "f)CHECK constraint", ID_question = 282 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 463, istrue = false, choice = "A)calls by itself", ID_question = 283 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 464, istrue = true, choice = "B)Local temporary", ID_question = 283 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 465, istrue = true, choice = "c)CHECK constraint", ID_question = 283 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 466, istrue = false, choice = "d)calls by itself", ID_question = 283 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 467, istrue = true, choice = "f)Local temporary", ID_question = 283 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 468, istrue = false, choice = "g)CHECK constraint", ID_question = 283 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 469, istrue = false, choice = "A)calls by itself", ID_question = 284 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 470, istrue = true, choice = "B)Local temporary", ID_question = 284 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 471, istrue = false, choice = "c)CHECK constraint", ID_question = 284 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 472, istrue = false, choice = "d)calls by itself", ID_question = 284 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 473, istrue = false, choice = "A)calls by itself", ID_question = 285 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 474, istrue = true, choice = "B)Local temporary", ID_question = 285 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 475, istrue = false, choice = "c)CHECK constraint", ID_question = 285 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 476, istrue = false, choice = "d)calls by itself", ID_question = 285 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 477, istrue = false, choice = "A)calls by itself", ID_question = 286 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 478, istrue = true, choice = "B)Local temporary", ID_question = 286 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 479, istrue = false, choice = "c)CHECK constraint", ID_question = 286 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 480, istrue = false, choice = "d)calls by itself", ID_question = 286 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 481, istrue = false, choice = "A)calls by itself", ID_question = 287 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 482, istrue = true, choice = "B)Local temporary", ID_question = 287 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 483, istrue = false, choice = "c)CHECK constraint", ID_question = 287 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 484, istrue = false, choice = "d)calls by itself", ID_question = 287 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 485, istrue = false, choice = "A)calls by itself", ID_question = 288 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 486, istrue = true, choice = "B)Local temporary", ID_question = 288 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 487, istrue = false, choice = "c)CHECK constraint", ID_question = 288 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 488, istrue = false, choice = "d)calls by itself", ID_question = 288 });

            //service.Questions.Add(new Question { ID_question = 289, Body = "What Is SQL Profiler?", C_ID = 10, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 290, Body = "What is recursive stored procedure?", C_ID = 10, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 291, Body = "What are the differences between local and global temporary tables?", C_ID = 10, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 292, Body = "What is CHECK constraint?", C_ID = 10, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 293, Body = "Can SQL servers linked to other servers?", C_ID = 10, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 294, Body = "What is sub query and its properties?", C_ID = 10, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 295, Body = "What are the types of sub query?", C_ID = 10, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 296, Body = "What is SQL server agent?", C_ID = 10, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 297, Body = " What are scheduled tasks in SQL Server?", C_ID = 10, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 298, Body = "What is COALESCE in SQL Server?", C_ID = 10, type = "ART", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 299, Body = " A view doesn?t have data of its own.", C_ID = 10, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 300, Body = "A DDL statement or a DCL statement is automatically committed.", C_ID = 10, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 301, Body = " You can use a subquery in an INSERT statement.", C_ID = 10, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 302, Body = "Attempting to delete a record with a value attached to an integrity constraint, returns an error.", C_ID = 10, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 303, Body = "While inserting new rows in a table you must list values in the default order of the columns.", C_ID = 10, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 304, Body = " Multiple column subqueries return more than one column from the inner SELECT statement.", C_ID = 10, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 305, Body = " A multiple row subquery returns more than one row from the inner SELECT statement.", C_ID = 10, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 306, Body = " All group functions ignore null values.", C_ID = 10, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 307, Body = " The DISTINCT keyword allows a function consider only non-duplicate values.", C_ID = 10, type = "TF", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 308, Body = " Reasons for consideration of the stored procedure can be?", C_ID = 10, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 309, Body = " __________ takes no parameters and returns all kinds of interesting information.", C_ID = 10, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 310, Body = "  Which of the following has support for transaction?", C_ID = 10, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 311, Body = " Point out the wrong statement.", C_ID = 10, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 312, Body = " __________create the removable database.", C_ID = 10, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 313, Body = "  Which of the following stored procedure is used for error messages?", C_ID = 10, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 314, Body = "  _____________ sets procedure options in SQL Server.", C_ID = 10, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 315, Body = " __________ is used to build the code dynamically and execute it.", C_ID = 10, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 316, Body = "Stored procedure used to remember the exact number of bytes is _____________", C_ID = 10, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 317, Body = "Point out the correct statement.", C_ID = 10, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 318, Body = "  __________ is used to build the code dynamically and execute it.", C_ID = 10, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 319, Body = " Stored procedure used to remember the exact number of bytes is _____________", C_ID = 9, type = "MCQ", is_deleted = false });
            //service.Questions.Add(new Question { ID_question = 320, Body = " Point out the correct statement.", C_ID = 10, type = "MCQ", is_deleted = false });

            //service.Articles.Add(new Article { Ar_ID = 91, ID_question = 289, answer = "SQL Profiler is a tool which allows system administrator to monitor events in the SQL server" });
            //service.Articles.Add(new Article { Ar_ID = 92, ID_question = 290, answer = "SQL Server supports recursive stored procedure which calls by itself" });
            //service.Articles.Add(new Article { Ar_ID = 93, ID_question = 291, answer = "Local temporary tables are visible when there is a connection, and are deleted when the connection is closed." });
            //service.Articles.Add(new Article { Ar_ID = 94, ID_question = 292, answer = "A CHECK constraint can be applied to a column in a table to limit the values that can be placed in a column." });
            //service.Articles.Add(new Article { Ar_ID = 95, ID_question = 293, answer = "SQL server can be connected to any database which has OLE-DB provider to give a link" });
            //service.Articles.Add(new Article { Ar_ID = 96, ID_question = 294, answer = "A sub-query is a query which can be nested inside a main query like Select, Update, Insert or Delete statements" });
            //service.Articles.Add(new Article { Ar_ID = 97, ID_question = 295, answer = "Multiple column sub query which returns multiple columns to the main query. With that sub query result, Main query will be executed" });
            //service.Articles.Add(new Article { Ar_ID = 98, ID_question = 296, answer = "The SQL Server agent plays a vital role in day to day tasks of SQL server administrator(DBA)." });
            //service.Articles.Add(new Article { Ar_ID = 99, ID_question = 297, answer = "Scheduled tasks or jobs are used to automate processes that can be run on a scheduled time at a regular interval." });
            //service.Articles.Add(new Article { Ar_ID = 100, ID_question = 298, answer = " jobs are used to automate processes that can be run on a scheduled time at a regular interval." });



            //service.T_F.Add(new T_F { TF_ID = 82, ID_question = 299, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 83, ID_question = 300, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 84, ID_question = 301, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 85, ID_question = 302, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 86, ID_question = 303, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 87, ID_question = 304, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 88, ID_question = 305, istrue = false });
            //service.T_F.Add(new T_F { TF_ID = 89, ID_question = 306, istrue = true });
            //service.T_F.Add(new T_F { TF_ID = 90, ID_question = 307, istrue = true });



            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 489, istrue = false, choice = "A)SQL Server supports", ID_question = 308 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 490, istrue = false, choice = "B)stored procedure which calls by itself", ID_question = 308 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 491, istrue = true, choice = "C)Local temporary tables", ID_question = 308 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 492, istrue = false, choice = "A)SQL Server supports", ID_question = 309 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 493, istrue = true, choice = "B)stored procedure which calls by itself", ID_question = 309 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 494, istrue = false, choice = "C)Local temporary tables", ID_question = 309 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 495, istrue = false, choice = "D)CHECK constraint", ID_question = 309 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 496, istrue = false, choice = "A)database which has OLE-DB provider", ID_question = 310 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 497, istrue = false, choice = "B)sub-query", ID_question = 310 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 498, istrue = true, choice = "C)Multiple column", ID_question = 310 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 499, istrue = true, choice = "A)calls by itself", ID_question = 311 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 500, istrue = false, choice = "B)Local temporary", ID_question = 311 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 501, istrue = true, choice = "c)CHECK constraint", ID_question = 311 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 503, istrue = false, choice = "D)Scheduled", ID_question = 311 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 504, istrue = false, choice = "f)COALESCE", ID_question = 311 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 505, istrue = false, choice = "A)calls by itself", ID_question = 312 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 506, istrue = true, choice = "B)Local temporary", ID_question = 312 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 507, istrue = false, choice = "c)CHECK constraint", ID_question = 312 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 508, istrue = true, choice = "D)Scheduled", ID_question = 312 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 509, istrue = true, choice = "f)COALESCE", ID_question = 312 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 451, istrue = true, choice = "A)calls by itself", ID_question = 313 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 452, istrue = true, choice = "B)Local temporary", ID_question = 313 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 453, istrue = true, choice = "c)CHECK constraint", ID_question = 313 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 454, istrue = false, choice = "A)calls by itself", ID_question = 314 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 455, istrue = true, choice = "B)Local temporary", ID_question = 314 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 456, istrue = false, choice = "c)CHECK constraint", ID_question = 314 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 457, istrue = false, choice = "A)calls by itself", ID_question = 315 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 458, istrue = true, choice = "B)Local temporary", ID_question = 315 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 459, istrue = false, choice = "c)CHECK constraint", ID_question = 315 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 460, istrue = false, choice = "d)calls by itself", ID_question = 315 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 461, istrue = true, choice = "e)Local temporary", ID_question = 315 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 462, istrue = false, choice = "f)CHECK constraint", ID_question = 315 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 463, istrue = false, choice = "A)calls by itself", ID_question = 316 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 464, istrue = true, choice = "B)Local temporary", ID_question = 316 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 465, istrue = true, choice = "c)CHECK constraint", ID_question = 316 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 466, istrue = false, choice = "d)calls by itself", ID_question = 316 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 467, istrue = true, choice = "f)Local temporary", ID_question = 316 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 468, istrue = false, choice = "g)CHECK constraint", ID_question = 316 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 469, istrue = false, choice = "A)calls by itself", ID_question = 317 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 470, istrue = true, choice = "B)Local temporary", ID_question = 317 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 471, istrue = false, choice = "c)CHECK constraint", ID_question = 317 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 472, istrue = false, choice = "d)calls by itself", ID_question = 317 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 473, istrue = false, choice = "A)calls by itself", ID_question = 318 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 474, istrue = true, choice = "B)Local temporary", ID_question = 318 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 475, istrue = false, choice = "c)CHECK constraint", ID_question = 318 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 476, istrue = false, choice = "d)calls by itself", ID_question = 318 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 477, istrue = false, choice = "A)calls by itself", ID_question = 319 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 478, istrue = true, choice = "B)Local temporary", ID_question = 319 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 479, istrue = false, choice = "c)CHECK constraint", ID_question = 319 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 480, istrue = false, choice = "d)calls by itself", ID_question = 319 });

            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 481, istrue = false, choice = "A)calls by itself", ID_question = 320 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 482, istrue = true, choice = "B)Local temporary", ID_question = 320 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 483, istrue = false, choice = "c)CHECK constraint", ID_question = 320 });
            //service.MCQ_Choice.Add(new MCQ_Choice { MCQ_ID = 484, istrue = false, choice = "d)calls by itself", ID_question = 320 });


            ///////*Students*/
            //service.Students.Add(new Student { St_ID = 1, name = "Mokhtar", id_intake_branch_track = 1, is_deleted = false, log_ID = 6 });
            //service.Students.Add(new Student { St_ID = 2, name = "Abanoub", id_intake_branch_track = 2, is_deleted = false, log_ID = 7 });
            //service.Students.Add(new Student { St_ID = 3, name = "Asmaa", id_intake_branch_track = 3, is_deleted = false, log_ID = 8 });
            //service.Students.Add(new Student { St_ID = 4, name = "Myada", id_intake_branch_track = 4, is_deleted = false, log_ID = 9 });
            //service.Students.Add(new Student { St_ID = 5, name = "Roshdy", id_intake_branch_track = 5, is_deleted = false, log_ID = 10 });




            ///*loins*/
            //service.Logins.Add(new Login { ID = 1, username = "Mahmoud", type = "instructor", Password = "123" });
            //service.Logins.Add(new Login { ID = 2, username = "Hany", type = "instructor", Password = "123" });
            //service.Logins.Add(new Login { ID = 3, username = "Ahmed", type = "instructor", Password = "123" });
            //service.Logins.Add(new Login { ID = 4, username = "Christen", type = "instructor", Password = "123" });
            //service.Logins.Add(new Login { ID = 5, username = "Roaa", type = "instructor", Password = "123" });
            //service.Logins.Add(new Login { ID = 6, username = "Mokhtar", type = "student", Password = "123" });
            //service.Logins.Add(new Login { ID = 7, username = "Abanoub", type = "student", Password = "123" });
            //service.Logins.Add(new Login { ID = 8, username = "Asmaa", type = "student", Password = "123" });
            //service.Logins.Add(new Login { ID = 9, username = "Myada", type = "student", Password = "123" });
            //service.Logins.Add(new Login { ID = 10, username = "Roshdy", type = "student", Password = "123" });

            //service.SaveChanges();
            service.SaveChanges();





        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoginForm w1 = new LoginForm();
            w1.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            instructor_form w = new instructor_form();
            w.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            InstructorData w = new InstructorData(6);
            w.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
