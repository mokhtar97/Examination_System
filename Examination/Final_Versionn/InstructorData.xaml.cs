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
    /// Interaction logic for InstructorData.xaml
    /// </summary>
    public partial class InstructorData : Window
    {
        Context service = new Context();


        TextBlock name;
        TextBlock branch;
        ComboBox course;
        ComboBox exam_course;
        ListView questionlist;
        TextBox ID;
        TextBox Type;
        TextBox Body;
        TextBlock body;
        TextBlock type;
        Button add;
        Button update;
        Button delete;
        TextBlock TextBlockQuestion1;
        TextBlock TextBlockQuestion2;
        TextBlock TextBlockQuestion3;
        TextBlock TextBlockQuestion4;
        TextBlock TextBlockQuestion5;

        TextBox TextBoxNQuestion1;
        ComboBox ComboBoxQuestion1;
        RadioButton RadioButtonQuestion1;
        RadioButton RadioButton2Question1;
        Button ButtonQuestion1;

        WrapPanel w4;
        StackPanel p = new StackPanel();
        StackPanel detail = new StackPanel();
        TextBlock Deleted;
        RadioButton radioButton;
        RadioButton radioButton1;
        TextBlock C_IDD = new TextBlock();
        ListView ListView;

        ComboBox coursecombo;

        Calendar StartCalender;
        Calendar EndCalender;
        TextBox periodtxtbox;
        TextBox mcqmarktxtbox;
        TextBox T_Fmarktxtbox;
        TextBox ArtMarktxtbox;
        TextBox mcqNumbertxtbox;
        TextBox TFnumbertxtbox;
        TextBox ArtNumbertxtbox;
        TextBox textBoxART;
        TextBox textBoxMCQ;
        RadioButton RadioButtonMCQtrue;
        RadioButton RadioButtonMCQfalse;
        RadioButton RadioButtonTFtrue;
        RadioButton RadioButtonTFfalse;
        WrapPanel w6;
        WrapPanel w7;
        WrapPanel w8;
        WrapPanel w9;
        WrapPanel w10;
        WrapPanel w13;
        List<Course> courses;
        Button buttonadd;
        int flag = -1;

        DataGrid DataGrid1;

        Dictionary<int, CheckBox> art_checks = new Dictionary<int, CheckBox>();
        Dictionary<int, CheckBox> Mcq_checks = new Dictionary<int, CheckBox>();
        Dictionary<int, CheckBox> tf_checks = new Dictionary<int, CheckBox>();

        public int id { get; set; }
        public InstructorData(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void logout(object sender, RoutedEventArgs e)
        {
            LoginForm l = new LoginForm();
            l.Show();
            this.Close();
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
        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridBarraTitulo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }


        private void Instructor_Profile(object sender, RoutedEventArgs e)
        {
            Content.Children.Clear();
            p.Children.Clear();
            name = new TextBlock();
            branch = new TextBlock();
            course = new ComboBox();
            exam_course = new ComboBox();

            

            Instructor query = service.Instructors.Where(d => d.Instruct_ID == id).FirstOrDefault();
            if (query != null)
            {
                name.Text = query.Name;
                name.Foreground = Brushes.White;
                name.FontSize = 25;
                name.FontWeight = FontWeights.Bold;
                branch.Text = service.Branches.FirstOrDefault(b => b.brn_id == query.brn).brn_name;
                branch.Foreground = Brushes.White;
                branch.FontSize = 22;

            }


            courses = service.Courses.Where(c => c.Instruct_ID == id).Select(c => c).ToList();
            course.ItemsSource = courses;
            course.DisplayMemberPath = "Name";
            course.SelectionChanged += new SelectionChangedEventHandler(COURSESCHANGED);
            Content.Children.Add(name);
            Content.Children.Add(branch);
            Content.Children.Add(course);
            Content.Children.Add(p);
            detail.Children.Clear();
            Content.Children.Add(detail);

        }

        private void COURSESCHANGED(object sender, SelectionChangedEventArgs e)
        {

            try
            {
                questionlist = new ListView();
                int id_c = ((Course)course.SelectedItem).C_ID;
                var query = service.Questions.Where(c => c.C_ID == id_c).Select(c => c).ToList();
                if (query != null)
                {
                    questionlist.ItemsSource = query;
                    questionlist.DisplayMemberPath = "Body";
                    questionlist.Height = 200;
                    questionlist.SelectionChanged += new SelectionChangedEventHandler(QuestionSCHANGED);
                }
                p.Children.Clear();
                p.Children.Add(questionlist);

                add = new Button();
                add.Width = 200;
                add.Margin = new Thickness(600, 0, 0, 0);
                add.Content = "Click Here To Add";
                add.Height = 40;
                add.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#086564"));
                add.Margin = new Thickness(0,10,0,0);
                add.FontSize = 15;
                add.Background = Brushes.White;
                add.BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#59d4ff"));
                add.Click += ADD_Question;

                p.Children.Add(add);
            }

            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void QuestionSCHANGED(object sender, SelectionChangedEventArgs e)
        {
            try
            {

                detail.Children.Clear();
                var question = ((Question)questionlist.SelectedItem);
                C_IDD.Text = question.C_ID.ToString();
                TextBlock idd = new TextBlock();
                idd.Text = "ID";
                idd.FontSize = 20;
                idd.Foreground = Brushes.White;
                idd.Margin = new Thickness(10, 5, 0, 0);

                ID = new TextBox();
                ID.Margin = new Thickness(20,10,10,10);
                ID.Width = 200;
                ID.Height = 20;
                ID.Text = question.ID_question.ToString();
                body = new TextBlock();
                body.FontSize = 20;
                body.Foreground = Brushes.White;
                body.Margin = new Thickness(10, 5, 0, 0);

                body.Text = "BODY";
                Body = new TextBox();
                Body.Margin = new Thickness(10, 10, 10, 10);
                Body.Width = 200;
                Body.Height = 20;
                Body.Text = question.Body;
                type = new TextBlock();
                type.Text = "TPYE";
                type.FontSize = 20;
                type.Foreground = Brushes.White;
                type.Margin = new Thickness(10, 5, 0, 0);
                Type = new TextBox();
                Type.Margin = new Thickness(10, 10, 10, 10);
                Type.Width = 200;
                Type.Height = 20;
                Type.Text = question.type;
                Deleted = new TextBlock();
                Deleted.Text = "DELETED";
                Deleted.Margin = new Thickness(10, 5, 0, 0);
                radioButton = new RadioButton();
                radioButton.Content = "True";
                radioButton.Margin = new Thickness(10,10,0,0);
                radioButton1 = new RadioButton();
                radioButton1.Content = "False";
                radioButton1.Margin = new Thickness(10, 10, 0, 0);
                if (question.is_deleted == true)
                {
                    radioButton.IsChecked = true;
                }
                else
                {
                    radioButton1.IsChecked = true;
                }

                update = new Button();
                update.Content = "UPDATE";
                update.Click += Update_Question;
                delete = new Button();
                delete.Content = "DELETE";
                delete.Click += DELETE_Question;
                WrapPanel w1 = new WrapPanel();

                w1.Children.Add(idd);
                w1.Children.Add(ID);
                WrapPanel w2 = new WrapPanel();
                w2.Children.Add(body);
                w2.Children.Add(Body);
                WrapPanel w3 = new WrapPanel();
                w3.Children.Add(type);
                w3.Children.Add(Type);
                w4 = new WrapPanel();
                if (Type.Text == "MCQ" || Type.Text == "MCQ")
                {

                    DataGrid1 = new DataGrid();
                    //DataGrid1.DataContext=service.MCQ_Choice.ToList();
                    DataGrid1.ItemsSource = service.MCQ_Choice.Where(mc => mc.ID_question == ((Question)questionlist.SelectedItem).ID_question).Select(ee => new { ee.MCQ_ID, ee.choice, ee.istrue }).ToList();
                    DataGrid1.SelectedValuePath = "MCQ_ID";

                }
                if (Type.Text == "TF" || Type.Text == "TF")
                {

                    DataGrid1 = new DataGrid();
                    //DataGrid1.DataContext=service.MCQ_Choice.ToList();
                    DataGrid1.ItemsSource = service.T_F.Where(mc => mc.ID_question == ((Question)questionlist.SelectedItem).ID_question).Select(ee => new { ee.TF_ID, ee.istrue }).ToList();
                    DataGrid1.SelectedValuePath = "TF_ID";

                }
                if (Type.Text == "ART" || Type.Text == "ART")
                {

                    DataGrid1 = new DataGrid();

                    //DataGrid1.DataContext=service.MCQ_Choice.ToList();
                    DataGrid1.ItemsSource = service.Articles.Where(mc => mc.ID_question == ((Question)questionlist.SelectedItem).ID_question).Select(ee => new { ee.Ar_ID, ee.answer }).ToList();
                    DataGrid1.SelectedValuePath = "Ar_ID";
                }
                Deleted.Foreground = Brushes.White;
                Deleted.FontSize = 20;
               
                
                w4.Children.Add(Deleted);
                w4.Children.Add(radioButton);
                w4.Children.Add(radioButton1);

                WrapPanel w5 = new WrapPanel();
                w5.Children.Add(update);
                w5.Children.Add(delete);
                detail.Children.Clear();
                detail.Children.Add(w1);
                detail.Children.Add(w2);
                detail.Children.Add(w3);
                detail.Children.Add(w4);
                 detail.Children.Add(DataGrid1);

                detail.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#59d4ff"));
                detail.Width = 700;
                detail.Height = 200;
                detail.Margin = new Thickness(0,20,0,0);

            }

            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void DELETE_Question(object sender, RoutedEventArgs e)
        {
            try
            {

                ((Question)questionlist.SelectedItem).is_deleted = true;
                radioButton.IsChecked = true;
                service.SaveChanges();
                MessageBox.Show("Deleted Successfully");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }


        }

        private void Update_Question(object sender, RoutedEventArgs e)
        {
            try
            {
                var question = service.Questions.Where(c => c.ID_question == ((Question)questionlist.SelectedItem).ID_question).Select(c => c).First();
                question.Body = Body.Text;
                question.type = Type.Text;

                if (radioButton.IsChecked == true)
                    question.is_deleted = true;
                else
                    question.is_deleted = false;
                service.SaveChanges();
                MessageBox.Show("Updateded Successfully");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        private void ADD_Question(object sender, RoutedEventArgs e)
        {
            detail.Children.Clear();
            detail.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#59d4ff"));
            w6 = new WrapPanel();
            w7 = new WrapPanel();
            w8 = new WrapPanel();
            w9 = new WrapPanel();
            w6.Orientation = Orientation.Vertical;
            TextBlockQuestion1 = new TextBlock();
            TextBlockQuestion1.Text = "body";

            TextBlockQuestion1.Margin = new Thickness(300, 25, 0, 0);
            w8.Children.Add(TextBlockQuestion1);
            TextBoxNQuestion1 = new TextBox();
            TextBoxNQuestion1.Width = 150;
            TextBoxNQuestion1.Height = 30;
            //TextBoxNQuestion1.Margin = new Thickness(300, 100, 100, 100);
            w8.Children.Add(TextBoxNQuestion1);

            TextBlockQuestion2 = new TextBlock();
            TextBlockQuestion2.Text = "type";
            TextBlockQuestion2.Margin = new Thickness(300, 10, 0, 0);
            w9.Children.Add(TextBlockQuestion2);
            ComboBoxQuestion1 = new ComboBox();
            ComboBoxQuestion1.Width = 150;
            ComboBoxQuestion1.Items.Add("MCQ");
            ComboBoxQuestion1.Items.Add("TF");
            ComboBoxQuestion1.Items.Add("ART");
            w9.Children.Add(ComboBoxQuestion1);
            ComboBoxQuestion1.SelectionChanged += selectededchangeaddans;
            TextBlockQuestion3 = new TextBlock();
            TextBlockQuestion3.Text = "isdeleted";
            w7.Margin = new Thickness(300, 10, 0, 0);
            w7.Children.Add(TextBlockQuestion3);
            RadioButtonQuestion1 = new RadioButton();
            w7.Children.Add(RadioButtonQuestion1);
            TextBlockQuestion4 = new TextBlock();
            TextBlockQuestion4.Text = "true";
            w7.Children.Add(TextBlockQuestion4);

            RadioButton2Question1 = new RadioButton();
            w7.Children.Add(RadioButton2Question1);
            TextBlockQuestion5 = new TextBlock();
            TextBlockQuestion5.Text = "false";
            w7.Children.Add(TextBlockQuestion5);

            ButtonQuestion1 = new Button();
            ButtonQuestion1.Content = "add";
            ButtonQuestion1.Margin = new Thickness(300, 10, 0, 0);
            ButtonQuestion1.Click += addQuestion;
            w6.Children.Add(w8);
            w6.Children.Add(w9);

            w6.Children.Add(w7);
            w6.Children.Add(ButtonQuestion1);
            detail.Children.Add(w6);

        }

        private void selectededchangeaddans(object sender, RoutedEventArgs e)
        {

            detail.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#9370DB"));
            if ((string)ComboBoxQuestion1.SelectedItem == "MCQ")
            {
                TextBlock textBlockChoice = new TextBlock();
                textBlockChoice.Text = "add chocice for mcq qestion";
                textBlockChoice.Margin = new Thickness(300, 10, 0, 0);
                textBoxMCQ = new TextBox();
                textBoxMCQ.Width = 100;
                w13 = new WrapPanel();
                TextBlock textBlockkk = new TextBlock();
                textBlockkk.Text = "answer the question";
                TextBlock textBlock1 = new TextBlock();
                textBlock1.Text = "true";
                TextBlock textBlock2 = new TextBlock();
                textBlock2.Text = "false";
                RadioButtonMCQtrue = new RadioButton();
                RadioButtonMCQfalse = new RadioButton();
                w13.Children.Add(textBlockkk);
                w13.Children.Add(RadioButtonMCQtrue);
                w13.Children.Add(textBlock1);
                w13.Children.Add(RadioButtonMCQfalse);
                w13.Children.Add(textBlock2);

                textBoxMCQ.Margin = new Thickness(300, 10, 0, 0);
                w13.Margin = new Thickness(300, 10, 0, 0);
                w6.Children.Add(textBlockChoice);
                w6.Children.Add(textBoxMCQ);
                Button buttonadd = new Button();
                buttonadd.Content = "add";
                buttonadd.Margin = new Thickness(300, 10, 0, 0);
                buttonadd.Click += addchoice;
                w6.Children.Add(w13);
                w6.Children.Add(buttonadd);
            }

            else if ((string)ComboBoxQuestion1.SelectedItem == "TF")
            {
                w6.Children.Remove(w13);
                w10 = new WrapPanel();
                TextBlock textBlockkk = new TextBlock();
                textBlockkk.Text = "answer the question";
                TextBlock textBlock1 = new TextBlock();
                textBlock1.Text = "true";
                TextBlock textBlock2 = new TextBlock();
                textBlock2.Text = "false";
                RadioButtonTFtrue = new RadioButton();
                RadioButtonTFfalse = new RadioButton();
                w10.Children.Add(textBlockkk);
                w10.Children.Add(RadioButtonTFtrue);
                w10.Children.Add(textBlock1);
                w10.Children.Add(RadioButtonTFfalse);
                w10.Children.Add(textBlock2);
                w10.Margin = new Thickness(300, 10, 0, 0);
                buttonadd = new Button();
                buttonadd.Content = "add";
                buttonadd.Click += addtf;
                buttonadd.Margin = new Thickness(300, 10, 0, 0);
                w6.Children.Add(w10);
                w6.Children.Add(buttonadd);
            }



            else if ((string)ComboBoxQuestion1.SelectedItem == "ART")
            {
                w6.Children.Remove(w13);
                Button buttonaddart = new Button();
                TextBlock textBlockChoice = new TextBlock();

                textBlockChoice.Text = "add answer for art qestion";
                textBlockChoice.Margin = new Thickness(300, 10, 0, 0);
                textBoxART = new TextBox();
                textBoxART.Width = 100;
                textBoxART.Margin = new Thickness(300, 10, 0, 0);
                w6.Children.Add(textBlockChoice);
                w6.Children.Add(textBoxART);
                buttonaddart.Content = "add";
                buttonaddart.Click += addART;
                buttonaddart.Margin = new Thickness(300, 10, 0, 0);
                w6.Children.Add(buttonaddart);
            }
        }
        private void addtf(object sender, RoutedEventArgs e)
        {
            if (flag > 0 && (string)ComboBoxQuestion1.SelectedItem == "TF")
            {
                try
                {
                    T_F t_F = new T_F();
                    t_F.ID_question = flag;

                    if (RadioButtonTFtrue.IsChecked == true)
                    {
                        t_F.istrue = true;
                    }

                    if (RadioButtonTFfalse.IsChecked == true)
                    {
                        t_F.istrue = false;
                    }
                    service.T_F.Add(t_F);
                    service.SaveChanges();
                    flag = -1;
                    MessageBox.Show("t_F ADDED SUCCESSFULLY");
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
            else
            {
                MessageBox.Show("you should  add question apve");
            }
        }

        private void addART(object sender, RoutedEventArgs e)
        {
            if (flag > 0 && (string)ComboBoxQuestion1.SelectedItem == "ART")
            {
                try
                {
                    Article article = new Article();
                    article.ID_question = flag;
                    article.answer = textBoxART.Text;
                    service.Articles.Add(article);
                    service.SaveChanges();
                    flag = -1;
                    MessageBox.Show("t_F ADDED SUCCESSFULLY");
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
            else
            {
                MessageBox.Show("you should  add question apve");
            }
        }
        private void addchoice(object sender, RoutedEventArgs e)
        {
            if (flag > 0 && (string)ComboBoxQuestion1.SelectedItem == "MCQ")
            {
                try
                {
                    MCQ_Choice q = new MCQ_Choice();
                    q.ID_question = flag;
                    q.choice = textBoxMCQ.Text;
                    if (RadioButtonMCQtrue.IsChecked == true)
                    {
                        q.istrue = true;
                    }

                    if (RadioButtonMCQfalse.IsChecked == true)
                    {
                        q.istrue = false;
                    }
                    service.MCQ_Choice.Add(q);
                    service.SaveChanges();

                    MessageBox.Show("choice ADDED SUCCESSFULLY");
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
            else
            {
                MessageBox.Show("you should  add question apve");
            }
        }
        private void addQuestion(object sender, RoutedEventArgs e)
        {
            try
            {
                Question q = new Question();

                q.Body = TextBoxNQuestion1.Text;
                q.type = (string)ComboBoxQuestion1.SelectedItem;

                if (RadioButtonQuestion1.IsChecked == true)
                {
                    q.is_deleted = true;
                }

                if (RadioButton2Question1.IsChecked == true)
                {
                    q.is_deleted = false;
                }

                q.C_ID = ((Course)course.SelectedItem).C_ID;
                service.Questions.Add(q);
                service.SaveChanges();
                flag = (service.Questions.Select(ee => ee).OrderByDescending(ee => ee.ID_question).FirstOrDefault()).ID_question;
                MessageBox.Show("ADD SUCCESSFULLY");
                course.ItemsSource = courses;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }



        internal class ConsumoViewModel
        {
            public List<Consumo> Consumo { get; private set; }

            public ConsumoViewModel(Consumo consumo)
            {
                Consumo = new List<Consumo>();
                Consumo.Add(consumo);
            }
        }



        internal class Consumo
        {
            public string Titulo { get;

                private set; }
            public int Porcentagem { get; private set; }

            public Consumo()
            {
                Titulo = "Consumo Atual";
                Porcentagem = CalcularPorcentagem();
            }

            private int CalcularPorcentagem()
            {
                return 47; //Calculo da porcentagem de consumo
            }
        }

        private void Create_Exam(object sender, RoutedEventArgs e)
        {
            Content.Children.Clear();
            StackPanel stack1 = new StackPanel();
            WrapPanel wrap1 = new WrapPanel();
            coursecombo = new ComboBox();
            coursecombo.ItemsSource= service.Courses.Where(c => c.Instruct_ID == id).Select(c => c).ToList();
            coursecombo.DisplayMemberPath = "Name";
            periodtxtbox = new TextBox();
            mcqmarktxtbox = new TextBox();
            T_Fmarktxtbox = new TextBox();
            ArtMarktxtbox = new TextBox();
            mcqNumbertxtbox = new TextBox();
            TFnumbertxtbox = new TextBox();
            ArtNumbertxtbox = new TextBox();

          TextBlock  Period = new TextBlock();
            Period.Text = "Period";
            Period.FontSize = 20;
            Period.FontWeight = FontWeights.Bold;
            Period.Margin = new Thickness(5);


        TextBlock    MCQ_Mark = new TextBlock();
            MCQ_Mark.Text = "MCQ-Mark";
            MCQ_Mark.FontSize = 20;
            MCQ_Mark.FontWeight = FontWeights.Bold;
            MCQ_Mark.Margin = new Thickness(5);

          TextBlock   TF_Mark = new TextBlock();
            TF_Mark.Text = "TF_Mark";
            TF_Mark.FontSize = 20;
            TF_Mark.FontWeight = FontWeights.Bold;
            TF_Mark.Margin = new Thickness(5);

         TextBlock   Art_Mark = new TextBlock();
            Art_Mark.Text = "Art_Mark";
            Art_Mark.FontSize = 20;
            Art_Mark.FontWeight = FontWeights.Bold;
            Art_Mark.Margin = new Thickness(5);

        TextBlock    MCQ_Number = new TextBlock();
            MCQ_Number.Text = "Number of MCQ question";
            MCQ_Number.FontSize = 20;
            MCQ_Number.FontWeight = FontWeights.Bold;
            MCQ_Number.Margin = new Thickness(5);

        TextBlock    TF_Number = new TextBlock();
            TF_Number.Text = "Number of true false questions";
            TF_Number.FontSize = 20;
            TF_Number.FontWeight = FontWeights.Bold;
            TF_Number.Margin = new Thickness(5);

       TextBlock     Art_Number = new TextBlock();
            Art_Number.Text = "Number of article questions";
            Art_Number.FontSize = 20;
            Art_Number.FontWeight = FontWeights.Bold;
            Art_Number.Margin = new Thickness(5);

            TextBlock start = new TextBlock();
            start.Text = "Start Time";
            start.FontSize = 20;
            start.FontWeight = FontWeights.Bold;
            start.Margin = new Thickness(5);

            StartCalender = new Calendar();
            TextBlock end = new TextBlock();
            end.Text = "End Time";
            end.FontSize = 20;
            end.FontWeight = FontWeights.Bold;
            end.Margin = new Thickness(5);

            EndCalender = new Calendar();
            Button Creat = new Button();
            Creat.Width = 100;
            Creat.Height = 60;
            Creat.Foreground = Brushes.AliceBlue;
            Creat.Content = "CREATE";
            Creat.Click += Crate_Exa;


            stack1.Children.Add(coursecombo);
            stack1.Children.Add(Period);
            stack1.Children.Add(periodtxtbox);
            wrap1.Children.Add(start);
            wrap1.Children.Add(StartCalender);
            wrap1.Children.Add(end);
            wrap1.Children.Add(EndCalender);
            stack1.Children.Add(wrap1);
            stack1.Children.Add(MCQ_Mark);
            stack1.Children.Add(mcqmarktxtbox);
            stack1.Children.Add(TF_Mark);
            stack1.Children.Add(T_Fmarktxtbox);
            stack1.Children.Add(Art_Mark);
            stack1.Children.Add(ArtMarktxtbox);
            stack1.Children.Add(MCQ_Number);
            stack1.Children.Add(mcqNumbertxtbox);
            stack1.Children.Add(TF_Number);
            stack1.Children.Add(TFnumbertxtbox);
            stack1.Children.Add(Art_Number);
            stack1.Children.Add(ArtNumbertxtbox);
            stack1.Children.Add(Creat);

            Content.Children.Add(stack1);


        }

        private void Crate_Exa(object sender, RoutedEventArgs e)
        {
            try
            {
                var query = service.Exams.ToList();
                Exam ex = new Exam();
                ex.instruct_id = id;
                ex.C_ID = ((Course)coursecombo.SelectedItem).C_ID;
                ex.ex_id = query.Count() + 1;
                ex.period = int.Parse(periodtxtbox.Text);
                ex.start_time = StartCalender.SelectedDate.Value;
                ex.end_time = EndCalender.SelectedDate.Value;
                ex.MCQ_Mark = int.Parse(mcqmarktxtbox.Text);
                ex.TF_Mark = int.Parse(T_Fmarktxtbox.Text);
                ex.Article_Mark = int.Parse(ArtMarktxtbox.Text);
                ex.MCQ_NUM = int.Parse(mcqNumbertxtbox.Text);
                ex.TF_NUM = int.Parse(TFnumbertxtbox.Text);
                ex.Article_NUM = int.Parse(ArtNumbertxtbox.Text);
                ex.exam_type = "Exam";
                int arts = service.Questions.Where(c => c.C_ID == ex.C_ID && c.type == "ART").Select(c => c).ToList().Count();
                int MCQ = service.Questions.Where(c => c.C_ID == ex.C_ID && c.type == "MCQ").Select(c => c).ToList().Count();
                int TF = service.Questions.Where(c => c.C_ID == ex.C_ID && c.type == "TF").Select(c => c).ToList().Count();

                if (ex.Article_NUM > arts || ex.MCQ_NUM > MCQ || ex.TF_NUM > TF)
                {
                    MessageBox.Show("NOT enough Questions");
                }
                else
                {
                    service.Database.ExecuteSqlCommand("Create_exam @p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12",
                   parameters: new object[] { id, ex.ex_id, ex.C_ID, ex.period, ex.start_time, ex.end_time, ex.exam_type, ex.MCQ_NUM, ex.MCQ_Mark, ex.TF_NUM, ex.TF_Mark, ex.Article_NUM, ex.Article_Mark });
                    service.SaveChanges();
                    MessageBox.Show("Exam Created Successfully");
                }



            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void Manual_Exam(object sender, RoutedEventArgs e)
        {
            Content.Children.Clear();
            p.Children.Clear();
            StackPanel stack1 = new StackPanel();
            WrapPanel wrap1 = new WrapPanel();
            name = new TextBlock();
            branch = new TextBlock();
            course = new ComboBox();
            periodtxtbox = new TextBox();
            mcqmarktxtbox = new TextBox();
            T_Fmarktxtbox = new TextBox();
            ArtMarktxtbox = new TextBox();
            Instructor query = service.Instructors.Where(d => d.Instruct_ID == id).FirstOrDefault();
            //comboboxInstructor.ItemsSource = query;
            if (query != null)
            {
                name.Text = query.Name;
                branch.Text = service.Branches.FirstOrDefault(b => b.brn_id == query.brn).brn_name;
            }


            List<Course> courses = service.Courses.Where(c => c.Instruct_ID == id).Select(c => c).ToList();
            course.ItemsSource = courses;
            course.DisplayMemberPath = "Name";
            course.SelectionChanged += new SelectionChangedEventHandler(Choose_Questiosn);


            TextBlock Period = new TextBlock();
            Period.Text = "Period";
            Period.FontSize = 20;
            Period.FontWeight = FontWeights.Bold;
            Period.Margin = new Thickness(5);

            TextBlock start = new TextBlock();
            start.Text = "Start Time";
            start.FontSize = 20;
            start.FontWeight = FontWeights.Bold;
            start.Margin = new Thickness(5);


            StartCalender = new Calendar();
            TextBlock end = new TextBlock();
            end.Text = "End Time";
            end.FontSize = 20;
            end.FontWeight = FontWeights.Bold;
            end.Margin = new Thickness(5);

            EndCalender = new Calendar();
            Button Creat = new Button();
            Creat.Width = 100;
            Creat.Height = 60;
            Creat.Foreground = Brushes.AliceBlue;


            TextBlock MCQ_Mark = new TextBlock();
            MCQ_Mark.Text = "MCQ-Mark";
            MCQ_Mark.FontSize = 20;
            MCQ_Mark.FontWeight = FontWeights.Bold;
            MCQ_Mark.Margin = new Thickness(5);

            TextBlock TF_Mark = new TextBlock();
            TF_Mark.Text = "TF_Mark";
            TF_Mark.FontSize = 20;
            TF_Mark.FontWeight = FontWeights.Bold;
            TF_Mark.Margin = new Thickness(5);

            TextBlock Art_Mark = new TextBlock();
            Art_Mark.Text = "Art_Mark";
            Art_Mark.FontSize = 20;
            Art_Mark.FontWeight = FontWeights.Bold;
            Art_Mark.Margin = new Thickness(5);


            Content.Children.Add(name);
            Content.Children.Add(branch);
            Content.Children.Add(course);
            detail.Children.Clear();
            Content.Children.Add(detail);
            stack1.Children.Add(Period);
            stack1.Children.Add(periodtxtbox);
            wrap1.Children.Add(start);
            wrap1.Children.Add(StartCalender);
            wrap1.Children.Add(end);
            wrap1.Children.Add(EndCalender);
            Content.Children.Add(stack1);
            Content.Children.Add(wrap1);
            stack1.Children.Add(MCQ_Mark);
            stack1.Children.Add(mcqmarktxtbox);
            stack1.Children.Add(TF_Mark);
            stack1.Children.Add(T_Fmarktxtbox);
            stack1.Children.Add(Art_Mark);
            stack1.Children.Add(ArtMarktxtbox);
            Content.Children.Add(p);
          


        }

        private void Choose_Questiosn(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Mcq_checks.Clear();
                tf_checks.Clear();
                art_checks.Clear();

                periodtxtbox.Clear();
                mcqmarktxtbox.Clear();
                T_Fmarktxtbox.Clear();
                ArtMarktxtbox.Clear(); ;

                p.Children.Clear();
                questionlist = new ListView();
                int id_c = ((Course)course.SelectedItem).C_ID;

                var query = service.Questions.Where(c => c.C_ID == id_c).Select(c => c).ToList();

                if (query != null)
                {

                    foreach (var item in query)
                    {
                        if(item.type.Contains("ART"))
                        {
                            CheckBox question = new CheckBox();
                            question.Content = item.Body;
                            art_checks.Add(item.ID_question,question);
                        }

                        else if (item.type.Contains("TF"))
                        {

                            CheckBox question = new CheckBox();
                            question.Content = item.Body;
                            tf_checks.Add(item.ID_question,question);
                        }

                        else if (item.type.Contains("MCQ"))
                        {
                            CheckBox question = new CheckBox();
                            question.Content = item.Body;
                            Mcq_checks.Add(item.ID_question,question);
                        }
                        
                    }

                }
              
                TextBlock t1 = new TextBlock();
                t1.Text = "MCQ QUESTIONS";
                p.Children.Add(t1);
                foreach (var item in Mcq_checks.Values)
                {
                    p.Children.Add(item);
                }

                TextBlock t2 = new TextBlock();
                t2.Text = "TRUE_FALSE QUESTIONS";
                p.Children.Add(t2);
                foreach (var item in tf_checks.Values)
                {
                    p.Children.Add(item);
                }
                TextBlock t3 = new TextBlock();
                t3.Text = "ARTICLE QUESTIONS";
                p.Children.Add(t3);
                foreach (var item in art_checks.Values)
                {
                    p.Children.Add(item);
                }
                Button create = new Button();
                create.Content = "Create Exam";
                p.Children.Add(create);
                create.Click += Creat_Manual;

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void Creat_Manual(object sender, RoutedEventArgs e)
        {
            try
            {
                var query = service.Exams.ToList();
                Exam ex = new Exam();
                ex.instruct_id = id;
                ex.C_ID = ((Course)course.SelectedItem).C_ID;
                ex.ex_id = query.Count() + 1;
                ex.period = int.Parse(periodtxtbox.Text);
                ex.start_time = StartCalender.SelectedDate.Value;
                ex.end_time = EndCalender.SelectedDate.Value;
                ex.MCQ_Mark = int.Parse(mcqmarktxtbox.Text);
                ex.TF_Mark = int.Parse(T_Fmarktxtbox.Text);
                ex.Article_Mark = int.Parse(ArtMarktxtbox.Text);
                ex.exam_type = "Exam";

                int mcq_num = 0;
                int tf_num = 0;
                int art_num = 0;
                foreach (KeyValuePair<int,CheckBox> item in Mcq_checks)
                {
                    if(item.Value.IsChecked==true)
                    {
                        mcq_num++;
                    }

                }

                foreach (KeyValuePair<int, CheckBox> item in tf_checks)
                {
                    if (item.Value.IsChecked == true)
                    {
                        tf_num++;
                    }

                }

                foreach (KeyValuePair<int, CheckBox> item in art_checks)
                {
                    if (item.Value.IsChecked == true)
                    {
                        
                        art_num++;
                    }

                }

                MessageBox.Show(mcq_num.ToString());
                MessageBox.Show(art_num.ToString());
                MessageBox.Show(tf_num.ToString());
                ex.MCQ_NUM = mcq_num;
                ex.TF_NUM = tf_num;
                ex.Article_NUM = art_num;
                service.Database.ExecuteSqlCommand("Create_exam_manual @p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12",
                 parameters: new object[] { id, ex.ex_id, ex.C_ID, ex.period, ex.start_time, ex.end_time, ex.exam_type, ex.MCQ_NUM, ex.MCQ_Mark, ex.TF_NUM, ex.TF_Mark, ex.Article_NUM, ex.Article_Mark });
                service.SaveChanges();

                foreach (KeyValuePair<int, CheckBox> item in Mcq_checks)
                {
                    if (item.Value.IsChecked == true)
                    {
                        service.exam_question.Add(new exam_question { ex_id = ex.ex_id, ID_question = item.Key });
                        
                    }

                }

                foreach (KeyValuePair<int, CheckBox> item in tf_checks)
                {
                    if (item.Value.IsChecked == true)
                    {
                        service.exam_question.Add(new exam_question { ex_id = ex.ex_id, ID_question = item.Key });
                       
                    }

                }

                foreach (KeyValuePair<int, CheckBox> item in art_checks)
                {
                    if (item.Value.IsChecked == true)
                    {
                        service.exam_question.Add(new exam_question { ex_id = ex.ex_id, ID_question = item.Key });
                        
                    }

                }
                service.SaveChanges();
                MessageBox.Show("Exam Created Successfully");

                
                
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }
    }
}
