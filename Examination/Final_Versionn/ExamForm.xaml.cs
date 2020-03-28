
using MaterialDesignThemes.Wpf;
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
using System.Windows.Threading;

namespace Final_Versionn
{
    /// <summary>
    /// Interaction logic for ExamForm.xaml
    /// </summary>
    public partial class ExamForm : Window
    {
        Context service = new Context();
        int counter = 1;
        List<int> ID_Questions = new List<int>();
        public Dictionary<int, List<string>> myansExamDiC = new Dictionary<int, List<string>>();
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public int st_id { get; set; }
        public int ex_id { get; set; }
        Label clock = new Label();
        public ExamForm(int sid, int ex_id)
        {
            InitializeComponent();

            this.st_id = sid;
            this.ex_id = ex_id;
            clock.FontSize = 40;
            dispatcherTimer.Interval = TimeSpan.FromSeconds(1);

            dispatcherTimer.Tick += tick;

            dispatcherTimer.Start();
            var query = service.exam_question.Where(c => c.ex_id == this.ex_id).Select(c => c.ID_question).ToList();
            foreach (var item in query)
            {
                ID_Questions.Add(item);
            }
            myansExamDiC.Add(ID_Questions[counter - 1], getvalue(ID_Questions[counter - 1]));
            print_question(ID_Questions[counter - 1]);
            bttons();
            clok.Children.Add(clock);
        }



        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridBarraTitulo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }



        int h;
        int m = 59;
        int s = 59;
       
        private void tick(object sender, EventArgs args)
        {
            h = service.Exams.Where(ex => ex.ex_id == ex_id).Select(ex => ex.period).FirstOrDefault() - 1;
            s--;

            if (h > 0 && m < 0)
            {
                m = 59;
                h--;
            }
            if (m > 0 && s < 0)
            {
                s = 59;
                m--;
            }
            clock.Content = h + ":" + m + ":" + s;
            clock.FontSize = 25;
            clock.Foreground = Brushes.BurlyWood;
            clock.HorizontalContentAlignment = HorizontalAlignment.Center;
            clock.VerticalContentAlignment = VerticalAlignment.Center;
           

        }
        private void bttons()
        {

            

            if (counter != 1)
            {
                Button Previous = new Button();

                Previous.Content = "Previous";
                Previous.Width = 80;
                Previous.Height = 50;
             
                Previous.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#59d4ff"));
                Previous.Content = new PackIcon { Kind = PackIconKind.SkipBackward, Height = 10, Width = 30 };
                Previous.Foreground= (SolidColorBrush)(new BrushConverter().ConvertFrom("#086564"));
                btn.Children.Add(Previous);

                Previous.Click += Prevoius_question;
            }
            if (counter != ID_Questions.Count() )
            {
                Button Next = new Button();
                Next.Content = "Next";
                Next.Width = 80;
                Next.Height = 50;
                Next.Margin = new Thickness(350,0,0,0);
                Next.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#59d4ff"));
                Next.Content = new PackIcon { Kind = PackIconKind.SkipForward, Height = 30, Width = 40 };

                btn.Children.Add(Next);

                Next.Click += Next_question;
            }
            else
            {
                Button Next = new Button();
                Next.Content = "Finish";
                Next.Margin = new Thickness(350,0,0,0);
                Next.Width = 80;
                Next.Height = 50; 

                Next.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#086564"));
                Next.Content = new PackIcon { Kind = PackIconKind.SmileyHappy, Height = 35, Width = 40 };
                Next.Width = 80;
                Next.Height = 50;
                btn.Children.Add(Next);
                Next.Click += sure;
            }
        }
        private void sure(object sender, EventArgs args)
        {
            myansExamDiC.Add(ID_Questions[counter-1], getvalue(ID_Questions[counter-1]));
            MessageBox.Show("Are You Sure?", "Finished", MessageBoxButton.OK);
            MessageBox.Show("Your MArk is:" + calc().ToString());

            this.Close();
        }
        private void Next_question(object sender, EventArgs e)
        {

            if (counter >= 1 && counter <= ID_Questions.Count())
            {
                
                myansExamDiC.Add(ID_Questions[counter-1], getvalue(ID_Questions[counter - 1]));
                counter++;
                clear_controls();
            }

            print_question(ID_Questions[counter - 1]);
            bttons();


        }

        private void Prevoius_question(object sender, EventArgs e)
        {
            if (counter > 1 && counter <= ID_Questions.Count())
            {

                myansExamDiC.Add(ID_Questions[counter-1], getvalue(ID_Questions[counter-1]));
                counter--;

                clear_controls();
            }
            //MessageBox.Show(counter.ToString());

            print_question(ID_Questions[counter-1]);
            bttons();

        }

        public void print_question(int x)
        {
            clear_controls();
            Label label = new Label();
            label.FontSize = 25;
            
            label.Foreground = Brushes.White;
            label.FontFamily = new FontFamily("Arial");

            var question = service.Questions.Where(q => q.ID_question == x).Select(c => new { c.Body, c.type }).ToList();
            label.Content = counter.ToString() + question[0].Body;

         

            if (question[0].type.Contains("MCQ"))
            {
                clear_controls();
                Question.Children.Add(label);
                var choices = service.MCQ_Choice.Where(q => q.ID_question == x).Select(c => c.choice).ToList();
              

                foreach (var item in choices)
                {

                    CheckBox ch = new CheckBox();
                    //ch.AutoSize = true;
                    ch.Content = item;
                    ch.Foreground = Brushes.White;
                    //ch.Location = new Point(70, count);
                    ch.FontSize = 20;
                    ch.Margin = new Thickness(0,10,0,0);
                            
                    Question.Children.Add(ch);

                    foreach (KeyValuePair<int, List<string>> itemm in myansExamDiC)
                    {
                        if (itemm.Key == x)
                        {
                            foreach (string str in itemm.Value)
                            {
                                if (item == str)
                                {
                                    ch.IsChecked = true;
                                }

                            }
                        }
                    }

                   

                }
                myansExamDiC.Remove(x);
            }

            else if (question[0].type.Contains("TF"))
            {
                clear_controls();
                Question.Children.Add(label);
                RadioButton rad_true = new RadioButton();
                RadioButton rad_false = new RadioButton();

                rad_true.Content = "True";
                rad_false.Content = "False";
                rad_true.Foreground = Brushes.White;
                rad_false.Foreground = Brushes.White;
                // rad_true.Location = new Point(70, 50);
                //rad_false.Location = new Point(70, 70);
                foreach (KeyValuePair<int, List<string>> item in myansExamDiC)
                {
                    if (item.Key == x)
                    {
                        foreach (var itemm in item.Value)
                        {

                            if (itemm == "False")
                            {
                                rad_false.IsChecked = true;
                            }
                            if (itemm == "True")
                                rad_true.IsChecked = true;

                        }

                    }

                }
                myansExamDiC.Remove(x);
                Question.Children.Add(rad_true);
                Question.Children.Add(rad_false);

            }
            else if (question[0].type.Contains("ART"))
            {
                clear_controls();
                Question.Children.Add(label);
                TextBox textbox = new TextBox();
                // textbox.Location = new Point(50, 70);
                foreach (KeyValuePair<int, List<string>> item in myansExamDiC)
                {
                    if (item.Key == x)
                    {
                        foreach (string str in item.Value)
                        {
                            textbox.Text = str;
                        }
                    }
                }
                myansExamDiC.Remove(ID_Questions[counter-1]);
                Question.Children.Add(textbox);

            }


        }

        private void clear_controls()
        {
            //Exam_Form.Children.Clear();
           
            Question.Children.Clear();
            btn.Children.Clear();
        }

        private List<string> getvalue(int key)
        {

            var controls = Question.Children.OfType<Control>();
            List<TextBox> textboxs = new List<TextBox>();
            List<CheckBox> checks = new List<CheckBox>();
            List<RadioButton> rad_buttons = new List<RadioButton>();
            foreach (var item in controls)
            {
                if (item.GetType() == typeof(TextBox))
                {

                    textboxs.Add((TextBox)item);
                }
                else if (item.GetType() == typeof(CheckBox))
                {

                    checks.Add((CheckBox)item);
                }
                else if (item.GetType() == typeof(RadioButton))
                {

                    rad_buttons.Add((RadioButton)item);
                }
            }
            List<string> str = new List<string>();
            var question = service.Questions.Where(q => q.ID_question == key).Select(c => new { c.Body, c.type }).ToList();

            if (question.Count != 0)
            {
                if (textboxs != null && question[0].type.Contains("ART"))
                {
                foreach (var z in textboxs)
                {

                    str.Add(z.Text);
                }
                }

                if (question[0].type.Contains("MCQ"))
                {
                foreach (var x in checks)
                {
                    if (x.IsChecked == true)
                        str.Add(x.Content.ToString());
                }
                 }
                if (question[0].type.Contains("TF"))
                {
                foreach (var item in rad_buttons)
                {
                    if (item.IsChecked == true)
                        str.Add(item.Content.ToString());
                }
                }
            }

            return str;
        }


        private int calc()
        {
            int choice_mark;
            Exam ex = service.Exams.FirstOrDefault(x => x.ex_id == ex_id);
            float tf_mark;
            if (ex.TF_NUM == 0)
                tf_mark = 0;
            else
                tf_mark = (ex.TF_Mark / ex.TF_NUM);
            float mcq_mark;
            if (ex.MCQ_NUM == 0)
                mcq_mark = 0;
            else
                mcq_mark = (ex.MCQ_Mark / ex.MCQ_NUM);
            float art_mark;
            if (ex.Article_NUM == 0)
                art_mark = 0;
            else
                art_mark = (ex.Article_Mark / ex.Article_NUM);
            float result = 0;
            //var quer = service.exam_question.Where(ex => ex.ex_id == ex_id).Select(ex => ex.ID_question).ToList();

         
            var query = (from q in service.Questions
                         join e in service.exam_question on
                         q.ID_question equals e.ID_question
                         where e.ex_id == ex_id
                         select (new { q.ID_question, q.type })).ToList();


            foreach (var item in query)
            {

                if (myansExamDiC.ContainsKey(item.ID_question) && item.type.Contains("TF"))
                {
                    var TFs = service.T_F.Where(q => q.ID_question == item.ID_question).Select(q => q.istrue).ToList();
                    List<string> str = myansExamDiC[item.ID_question];

                    if (TFs.Count() >= 1 && str.Count() >= 1)
                    {
                        bool istrue = false;
                        if (str[0] == "True")
                        {
                            istrue = true;

                        }

                        if (TFs[0] == istrue)
                        {
                            result += tf_mark;
                        }
                    }

                }


                else if (myansExamDiC.ContainsKey(item.ID_question) && item.type.Contains("MCQ"))
                {
                    var MCQ = service.MCQ_Choice.Where(q => q.ID_question == item.ID_question && q.istrue == true).Select(q => q).ToList();
                    List<string> str = myansExamDiC[item.ID_question];

                    choice_mark = (int)(mcq_mark / MCQ.Count());

                    if (MCQ.Count >= 1 && str.Count() >= 1)
                    {
                        foreach (var dic_item in str)
                        {

                            foreach (var choice in MCQ)
                            {

                                if (dic_item == choice.choice)
                                {
                                    result += choice_mark;
                                }

                            }
                        }

                    }
                }

                else if (myansExamDiC.ContainsKey(item.ID_question) && item.type.Contains("ART"))
                {
                    var ART = service.Articles.Where(q => q.ID_question == item.ID_question).Select(q => q.answer).ToList();
                    List<string> arts = myansExamDiC[item.ID_question];
                    if (arts.Count() >= 1 && ART.Count() >= 1)
                    {
                        if (ART[0] == (arts[0]))
                        {
                            result += art_mark;

                        }
                    }

                }

             }


                try
                {
                    exam_Student student_resul = new exam_Student();
                    student_resul.ex_id = ex_id;
                    student_resul.St_ID = st_id;
                    student_resul.Mark = (int)result;
                    service.exam_Student.Add(student_resul);
                    service.SaveChanges();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }

                return (int)result;
        }
       

        private void maximiz_func(object sender, RoutedEventArgs e)
        {
            if(this.WindowState==System.Windows.WindowState.Normal)
            { 
            this.WindowState = System.Windows.WindowState.Maximized;
            }
            else
            {
                this.WindowState = System.Windows.WindowState.Normal;
            }

        }
    }
}
