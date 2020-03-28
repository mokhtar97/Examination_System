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
using System.Windows.Shapes;

namespace Final_Versionn
{
    /// <summary>
    /// Interaction logic for Student_form.xaml
    /// </summary>
    public partial class Student_form : Window
    {
        Context service = new Context();
        public List<Exam> finished_exams = new List<Exam>();
        public List<Exam> Missed_exams = new List<Exam>();
        public int id { get; set; }
        public Student_form(int id)
        {
            this.id = id;

            InitializeComponent();
            Student std = service.Students.Where(s => s.St_ID == id).First();
            std_name.Text = std.name;

            var queryy = (from s in service.Students
                          join ibn in service.intake_branch_track on
                          s.id_intake_branch_track equals ibn.id_intake_branch_track
                          join t in service.Tracks on ibn.trk_id
                          equals t.trk_id
                          where s.St_ID == std.St_ID
                          select (t)).First();
            if (queryy != null)
                std_track.Text = queryy.trk_name;
       
            comboboxtrack_maped_course.ItemsSource = (service.Courses.Where(c => c.Track_ID == queryy.trk_id)).ToList();

        }


        private void logout(object sender, RoutedEventArgs e)
        {
            LoginForm l = new LoginForm();
            l.Show();
            this.Close();
        }
        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


        private void GridBarraTitulo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();

        }
        private void maximiz_func(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == System.Windows.WindowState.Normal)
            {
                this.WindowState = System.Windows.WindowState.Maximized;

            }
            else
            {
                this.WindowState = System.Windows.WindowState.Normal;
            }

        }


        private void Comboboxr_mapedtrack_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {


                var query = service.Exams.Where(ex => ex.C_ID == ((Course)comboboxtrack_maped_course.SelectedItem).C_ID).Select(ex => ex).ToList();
                var finished = service.exam_Student.Where(s => s.St_ID == id).ToList();
                List<Exam> exams = new List<Exam>();

                foreach (var item in query)
                {
                    bool check = false;
                    foreach (var tested in finished)
                    {

                        if (item.ex_id == tested.ex_id)
                        {
                            check = true;
                        }
                    }

                    if (check == false && DateTime.Now > item.end_time)
                    {
                        Missed_exams.Add(item);
                    }
                    else if (check == false && DateTime.Now < item.end_time)
                    {
                        exams.Add(item);

                    }
                    else
                    {
                        finished_exams.Add(item);

                    }
                }
                listview.Background = Brushes.Coral;
                finished_exam.BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#59d4ff"));
                listview.ItemsSource = exams;
                finished_exam.Background = Brushes.DarkOrange;
                listview.BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#59d4ff"));

                //Missed_exam.ItemsSource = Missed_exams;
                ///Missed_exam.DisplayMemberPath = "sssssssssssssssss";
                Missed_exam.Background = Brushes.Chocolate;
                Missed_exam.BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#59d4ff"));
                foreach (var item in finished_exams)
                {
                    int mark = service.exam_Student.Where(ex => ex.ex_id == item.ex_id && ex.St_ID == id).Select(ex => ex.Mark).FirstOrDefault();
                    finished_exam.Items.Add(new { Mark = mark, item.exam_type });
                }

                foreach (var item in Missed_exams)
                {
                    //int mark = service.exam_Student.Where(ex => ex.ex_id == item.ex_id && ex.St_ID == id).Select(ex => ex.Mark).FirstOrDefault();
                    Missed_exam.Items.Add(new { item.end_time, item.exam_type });
                }


            }

            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        private void Listview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            try
            {
                
                var exam = ((Exam)listview.SelectedValue);
                ExamForm w = new ExamForm(id, exam.ex_id);
                w.Show();
               

            }

             
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void Instructor_Profile(object sender, RoutedEventArgs e)
        {

        }
    }
}
