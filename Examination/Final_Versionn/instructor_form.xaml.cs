using MaterialDesignThemes.Wpf;
using Microsoft.JScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Interaction logic for instructor_form.xaml
    /// </summary>
    public partial class instructor_form : Window
    {
        Context service = new Context();
        ComboBox c;
        TextBlock txtblock;
        TextBox textBox;
        TextBlock name;
        TextBox name1;
        TextBlock MGID;
        ComboBox MGID1;
        TextBlock branch;
        ComboBox comboBox;
        TextBlock delete;
        RadioButton radioButton;
        TextBlock textBox1;
        RadioButton radioButton1;
        TextBlock textBox2;
        Button button;
        Button update;
        Button delete1;

        TextBlock Track;
        ComboBox Tracks;
        TextBlock Intake;
        ComboBox comboBox2;
        ComboBox comboBox1;

        TextBox text_ins;
        TextBox text_descrtion;
        TextBox Desc;
        public instructor_form()
        {
            InitializeComponent();



            Consumo consumo = new Consumo();
            DataContext = new ConsumoViewModel(consumo);
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridBarraTitulo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Content.Children.Clear();
            WrapPanel wrp = new WrapPanel();
            WrapPanel wrp1 = new WrapPanel();
            WrapPanel wrp2 = new WrapPanel();
            WrapPanel wrp3 = new WrapPanel();
            WrapPanel wrp4 = new WrapPanel();
            WrapPanel wrp5 = new WrapPanel();
            WrapPanel wrp6 = new WrapPanel();
            WrapPanel wrp7 = new WrapPanel();
            c = new ComboBox();
            c.ItemsSource = service.Instructors.ToList();
            c.DisplayMemberPath = "Name";
            c.SelectedValuePath = "Instruct_ID";
            c.SelectionChanged += new SelectionChangedEventHandler(OnMyComboBoxChanged);
            wrp.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#086564"));

            wrp.Width = 700;
            wrp.Height = 500;
            c.Width = 500;
            c.Height = 30;
            c.Margin = new Thickness(85, 30, 0, 0);
            c.Foreground = Brushes.Black;
            txtblock = new TextBlock();
            txtblock.Text = "ID";
            txtblock.Foreground = Brushes.White;
            wrp1.Margin = new Thickness(70, 50, 110, 0);
            txtblock.FontSize = 25;
            txtblock.FontWeight = FontWeights.Bold;
            textBox = new TextBox();
            textBox.Width = 300;
            textBox.Height = 30;
            textBox.Margin = new Thickness(90, 0, 0, 0);
            name = new TextBlock();
            name.Text = "Name";
            name.Foreground = Brushes.White;
            wrp2.Margin = new Thickness(70, 30, 150, 0);
            name.FontSize = 25;
            name.FontWeight = FontWeights.Bold;
            name1 = new TextBox();
            name1.Width = 300;
            name1.Height = 30;
            name1.Margin = new Thickness(50, 0, 0, 0);

            MGID = new TextBlock();
            MGID.Text = "MGID";
            MGID.Foreground = Brushes.White;
            wrp3.Margin = new Thickness(70, 30, 150, 0);
            MGID.FontSize = 25;
            MGID.FontWeight = FontWeights.Bold;
            MGID1 = new ComboBox();
            MGID1.Width = 300;
            MGID1.Height = 30;
            MGID1.Margin = new Thickness(50, 0, 0, 0);
            MGID1.ItemsSource = service.Instructors.ToList();
            MGID1.DisplayMemberPath = "Name";

            branch = new TextBlock();
            branch.Text = "Branch";
            branch.Foreground = Brushes.White;
            wrp4.Margin = new Thickness(70, 30, 150, 0);
            branch.FontSize = 25;
            branch.FontWeight = FontWeights.Bold;
            comboBox = new ComboBox();
            comboBox.Width = 300;
            comboBox.Height = 30;
            comboBox.Margin = new Thickness(40, 0, 0, 0);

            comboBox.ItemsSource = service.Branches.ToList();
            comboBox.DisplayMemberPath = "brn_name";

            delete = new TextBlock();
            delete.Text = "Delete";
            delete.Foreground = Brushes.White;
            wrp5.Margin = new Thickness(70, 30, 150, 0);
            delete.FontSize = 25;
            delete.FontWeight = FontWeights.Bold;
            radioButton = new RadioButton();
            radioButton.Margin = new Thickness(50, 12, 0, 0);
            textBox1 = new TextBlock();
            textBox1.Text = "True";
            textBox1.Foreground = Brushes.White;
            textBox1.Margin = new Thickness(10, 12, 0, 0);
            radioButton1 = new RadioButton();
            radioButton1.Margin = new Thickness(100, 12, 0, 0);
            textBox2 = new TextBlock();
            textBox2.Text = "False";
            textBox2.Foreground = Brushes.White;
            textBox2.Margin = new Thickness(20, 12, 0, 0);

            button = new Button();
            wrp6.Margin = new Thickness(70, 20, 150, 0);
            button.Width = 70;
            button.Height = 40;
            button.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#086564"));

            button.BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#59d4ff"));
            button.Content = new PackIcon { Kind = PackIconKind.GroupAdd, Height = 35, Width = 40 };

            button.Foreground = Brushes.White;
            button.Click += ADD_INSTRUCTOR;
            update = new Button();
            wrp6.Margin = new Thickness(70, 30, 150, 0);
            update.Margin = new Thickness(70, 0, 150, 0);
            update.Width = 70;
            update.Height = 40;
            update.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#086564"));

            update.BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#59d4ff"));
            update.Content = new PackIcon { Kind = PackIconKind.Update, Height = 35, Width = 40 };
            update.Foreground = Brushes.White;
            update.Click += UPDATE_INSTRUCTOR;
            delete1 = new Button();
            wrp7.Margin = new Thickness(70, -40, 0, 0);
            delete1.Margin = new Thickness(280, 0, 0, 0);
            delete1.Width = 70;
            delete1.Height = 40;
            delete1.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#086564"));

            delete1.BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#59d4ff"));
            delete1.Foreground = Brushes.White;
            delete1.Content = new PackIcon { Kind = PackIconKind.Delete, Height = 35, Width = 40 };
            delete1.Click += DELETE_INSTRUCTOR;


            wrp.Children.Add(c);
            wrp.Children.Add(wrp1);
            wrp1.Children.Add(txtblock);
            wrp1.Children.Add(textBox);
            wrp2.Children.Add(name);
            wrp2.Children.Add(name1);
            wrp.Children.Add(wrp2);
            wrp.Children.Add(wrp3);
            wrp3.Children.Add(MGID);
            wrp3.Children.Add(MGID1);
            wrp.Children.Add(wrp4);
            wrp4.Children.Add(branch);
            wrp4.Children.Add(comboBox);
            wrp.Children.Add(wrp5);
            wrp5.Children.Add(delete);
            wrp5.Children.Add(radioButton);
            wrp5.Children.Add(textBox1);
            wrp5.Children.Add(radioButton1);
            wrp5.Children.Add(textBox2);
            wrp.Children.Add(wrp6);
            wrp6.Children.Add(button);
            wrp6.Children.Add(update);
            wrp.Children.Add(wrp7);
            wrp7.Children.Add(delete1);

            Content.Margin = new Thickness(20, 0, 0, 0);
            Content.Children.Add(wrp);


        }

        private void DELETE_INSTRUCTOR(object sender, RoutedEventArgs e)
        {
            try
            {

                ((Instructor)c.SelectedItem).is_deleted = true;
                radioButton.IsChecked = true;
                service.SaveChanges();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        private void UPDATE_INSTRUCTOR(object sender, RoutedEventArgs e)
        {
            try
            {
                var queryidbranch =
                    (from b in service.Branches
                     where b.brn_name == ((Branch)comboBox.SelectedValue).brn_name
                     select (b.brn_id)).First().ToString();
                var queryidmanger =
                    (from i in service.Instructors
                     where i.Name == ((Instructor)MGID1.SelectedValue).Name
                     select (i.MG_id)).First().ToString();
                int num;
                int.TryParse(textBox.Text, out num);

                (service.Instructors.Where(i => i.Instruct_ID == num)).FirstOrDefault().Name = name1.Text;
                (service.Instructors.Where(i => i.Instruct_ID == num)).FirstOrDefault().brn = int.Parse(queryidbranch);
                (service.Instructors.Where(i => i.Instruct_ID == num)).FirstOrDefault().MG_id = int.Parse(queryidmanger);
                if (radioButton.IsChecked == true)
                    (service.Instructors.Where(i => i.Instruct_ID == num)).FirstOrDefault().is_deleted = true;
                if (radioButton1.IsChecked == true)
                    (service.Instructors.Where(i => i.Instruct_ID == num)).FirstOrDefault().is_deleted = false;
                service.SaveChanges();
                MessageBox.Show("instrctor data updated");
                c.ItemsSource = service.Instructors.ToList();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        private void ADD_INSTRUCTOR(object sender, RoutedEventArgs e)
        {
            try
            {
                Instructor instructor = new Instructor();
                instructor.Name = name1.Text;
                var queryidmanger =
                    (from i in service.Instructors
                     where i.Name == ((Instructor)MGID1.SelectedValue).Name
                     select (i.MG_id)).First().ToString();
                instructor.MG_id = int.Parse(queryidmanger);
                int num;
                int.TryParse(textBox.Text, out num);
                instructor.Instruct_ID = num;
                var queryy = (from s in service.Instructors
                              join b in service.Branches on
                              s.brn equals b.brn_id
                              where b.brn_name == ((Branch)comboBox.SelectedValue).brn_name
                              select (b.brn_id)).First().ToString();
                instructor.brn = int.Parse(queryy);
                if (radioButton.IsChecked == true)
                    instructor.is_deleted = true;
                if (radioButton1.IsChecked == true)
                    instructor.is_deleted = false;
                service.Instructors.Add(instructor);
                service.SaveChanges();
                MessageBox.Show("instrctor data inserted ");
                c.ItemsSource = service.Instructors.ToList();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }


        }

        private void OnMyComboBoxChanged(object sender, SelectionChangedEventArgs e)
        {
            string text = c.SelectedValue.ToString();
            int x = (int.Parse(text));
            Instructor instructor = service.Instructors.FirstOrDefault(inst => inst.Instruct_ID == x);
            textBox.Text = instructor.Instruct_ID.ToString();
            name1.Text = instructor.Name;

            int num;
            int.TryParse(textBox.Text.ToString(), out num);
            var queryy = (from s in service.Instructors
                          join b in service.Branches on
                          s.brn equals b.brn_id
                          where s.Instruct_ID == num
                          select (b)).First();
            if (queryy != null)
                comboBox.SelectedItem = queryy;

            var query1 = (from s in service.Instructors
                          where s.Instruct_ID == num
                          select (s)).First();
            var query2 = (from s in service.Instructors
                          where s.MG_id == query1.MG_id
                          select (s)).First();
            if (query2 != null)
                MGID1.SelectedItem = query2;
            service.SaveChanges();
            if (instructor.is_deleted == true)
                radioButton.IsChecked = true;
            if (instructor.is_deleted == false)
                radioButton1.IsChecked = true;
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Content.Children.Clear();
            WrapPanel wrp = new WrapPanel();
            WrapPanel wrp1 = new WrapPanel();
            WrapPanel wrp2 = new WrapPanel();
            WrapPanel wrp3 = new WrapPanel();
            WrapPanel wrp4 = new WrapPanel();
            WrapPanel wrp5 = new WrapPanel();
            WrapPanel wrp6 = new WrapPanel();
            WrapPanel wrp7 = new WrapPanel();
            c = new ComboBox();


            c.ItemsSource = service.Students.ToList();


            c.DisplayMemberPath = "name";
            c.SelectedValuePath = "St_ID";
            c.SelectionChanged += new SelectionChangedEventHandler(STUDENTSCHANGED);


            wrp.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#086564"));

            wrp.Width = 700;
            wrp.Height = 500;
            c.Width = 500;
            c.Height = 30;
            c.Margin = new Thickness(85, 30, 0, 0);
            c.Foreground = Brushes.Black;
            txtblock = new TextBlock();
            txtblock.Text = "ID";
            txtblock.Foreground = Brushes.White;
            wrp1.Margin = new Thickness(70, 40, 110, 0);
            txtblock.FontSize = 25;
            txtblock.FontWeight = FontWeights.Bold;
            textBox = new TextBox();
            textBox.Width = 300;
            textBox.Height = 30;
            textBox.Margin = new Thickness(90, 0, 0, 0);

            name = new TextBlock();
            name.Text = "Name";
            name.Foreground = Brushes.White;
            wrp2.Margin = new Thickness(70, 20, 150, 0);
            name.FontSize = 25;
            name.FontWeight = FontWeights.Bold;
            name1 = new TextBox();
            name1.Width = 300;
            name1.Height = 30;
            name1.Margin = new Thickness(50, 0, 0, 0);



            Track = new TextBlock();
            Track.Text = "Track";
            Track.Foreground = Brushes.White;
            wrp4.Margin = new Thickness(70, 10, 150, 0);
            Track.FontSize = 25;
            Track.FontWeight = FontWeights.Bold;
            Tracks = new ComboBox();
            Tracks.Width = 300;
            Tracks.Height = 30;
            Tracks.Margin = new Thickness(60, 0, 0, 0);

            Tracks.ItemsSource = service.Tracks.ToList();
            Tracks.DisplayMemberPath = "trk_name";

            branch = new TextBlock();
            branch.Text = "Branch";
            branch.Foreground = Brushes.White;
            wrp4.Margin = new Thickness(70, 10, 150, 0);
            branch.Margin = new Thickness(0, 15, 0, 0);
            branch.FontSize = 25;
            branch.FontWeight = FontWeights.Bold;
            comboBox = new ComboBox();
            comboBox.Width = 300;
            comboBox.Height = 30;
            comboBox.Margin = new Thickness(40, 10, 0, 0);

            comboBox.ItemsSource = service.Branches.ToList();

            comboBox.DisplayMemberPath = "brn_name";

            Intake = new TextBlock();
            Intake.Text = "Intake";
            Intake.Foreground = Brushes.White;
            wrp4.Margin = new Thickness(70, 10, 150, 0);
            Intake.Margin = new Thickness(0, 15, 0, 0);
            Intake.FontSize = 25;
            Intake.FontWeight = FontWeights.Bold;
            comboBox2 = new ComboBox();
            comboBox2.Width = 300;
            comboBox2.Height = 30;
            comboBox2.Margin = new Thickness(45, 10, 0, 0);

            comboBox2.ItemsSource = service.Intakes.ToList();
            comboBox2.DisplayMemberPath = "itk_name";

            delete = new TextBlock();
            delete.Text = "Delete";
            delete.Foreground = Brushes.White;
            wrp5.Margin = new Thickness(70, 15, 150, 0);
            delete.FontSize = 25;
            delete.FontWeight = FontWeights.Bold;
            radioButton = new RadioButton();
            radioButton.Margin = new Thickness(50, 12, 0, 0);
            textBox1 = new TextBlock();
            textBox1.Text = "True";
            textBox1.Foreground = Brushes.White;
            textBox1.Margin = new Thickness(10, 12, 0, 0);
            radioButton1 = new RadioButton();
            radioButton1.Margin = new Thickness(100, 12, 0, 0);
            textBox2 = new TextBlock();
            textBox2.Text = "False";
            textBox2.Foreground = Brushes.White;
            textBox2.Margin = new Thickness(20, 12, 0, 0);

            button = new Button();
            wrp6.Margin = new Thickness(70, 20, 150, 0);
            button.Width = 70;
            button.Height = 40;
            button.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#086564"));

            button.BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#59d4ff"));
            button.Content = new PackIcon { Kind = PackIconKind.GroupAdd, Height = 35, Width = 40 };
            button.Foreground = Brushes.White;
            button.Click += ADD_STUDENT;
            update = new Button();
            wrp6.Margin = new Thickness(70, 30, 150, 0);
            update.Margin = new Thickness(70, 0, 150, 0);
            update.Width = 70;
            update.Height = 40;
            update.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#086564"));

            update.BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#59d4ff"));
            update.Content = new PackIcon { Kind = PackIconKind.Update, Height = 35, Width = 40 };
            update.Foreground = Brushes.White;
            update.Click += UPDATE_STUDENT;

            delete1 = new Button();
            wrp7.Margin = new Thickness(70, -40, 0, 0);
            delete1.Margin = new Thickness(280, 0, 0, 0);
            delete1.Width = 70;
            delete1.Height = 40;
            delete1.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#086564"));

            delete1.BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#59d4ff")); ;
            delete1.Content = new PackIcon { Kind = PackIconKind.Delete, Height = 35, Width = 40 };
            delete1.Foreground = Brushes.White;
            delete1.Click += DELETE_STUDENT;
            wrp.Children.Add(c);
            wrp.Children.Add(wrp1);
            wrp1.Children.Add(txtblock);
            wrp1.Children.Add(textBox);
            wrp2.Children.Add(name);
            wrp2.Children.Add(name1);
            wrp.Children.Add(wrp2);
            wrp.Children.Add(wrp3);

            wrp.Children.Add(wrp4);

            wrp4.Children.Add(Track);
            wrp4.Children.Add(Tracks);
            wrp4.Children.Add(branch);
            wrp4.Children.Add(comboBox);

            wrp4.Children.Add(Intake);
            wrp4.Children.Add(comboBox2);

            wrp.Children.Add(wrp5);
            wrp5.Children.Add(delete);
            wrp5.Children.Add(radioButton);
            wrp5.Children.Add(textBox1);
            wrp5.Children.Add(radioButton1);
            wrp5.Children.Add(textBox2);
            wrp.Children.Add(wrp6);
            wrp6.Children.Add(button);
            wrp6.Children.Add(update);
            wrp.Children.Add(wrp7);
            wrp7.Children.Add(delete1);
            Content.Margin = new Thickness(20, 0, 0, 0);
            Content.Children.Add(wrp);
        }

        private void STUDENTSCHANGED(object sender, SelectionChangedEventArgs e)
        {
            string text = c.SelectedValue.ToString();
            int x = (int.Parse(text));
            Student student = service.Students.FirstOrDefault(st => st.St_ID == x);
            textBox.Text = student.St_ID.ToString();
            name1.Text = student.name;

            var queryy = (from s in service.Students
                          join ibn in service.intake_branch_track on
                          s.id_intake_branch_track equals ibn.id_intake_branch_track
                          join t in service.Tracks on ibn.trk_id
                          equals t.trk_id
                          where s.St_ID == ((Student)c.SelectedItem).St_ID
                          select (t)).FirstOrDefault();
            if (queryy != null)
                Tracks.SelectedItem = queryy;

            var queryy1 = (from s in service.Students
                           join ibn in service.intake_branch_track on
                           s.id_intake_branch_track equals ibn.id_intake_branch_track
                           join b in service.Branches on ibn.brn_id
                           equals b.brn_id
                           where s.St_ID == ((Student)c.SelectedItem).St_ID
                           select (b)).FirstOrDefault();
            if (queryy != null)
                comboBox.SelectedItem = queryy1;
            var queryy2 = (from s in service.Students
                           join ibn in service.intake_branch_track on
                           s.id_intake_branch_track equals ibn.id_intake_branch_track
                           join i in service.Intakes on ibn.itk_id
                           equals i.itk_id
                           where s.St_ID == ((Student)c.SelectedItem).St_ID
                           select (i)).First();
            if (queryy != null)
                comboBox2.SelectedItem = queryy2;

            if (student.is_deleted == true)
                radioButton.IsChecked = true;
            if (student.is_deleted == false)
                radioButton1.IsChecked = true;
        }

        private void DELETE_STUDENT(object sender, RoutedEventArgs e)
        {
            try
            {
                ((Student)c.SelectedItem).is_deleted = true;
                radioButton.IsChecked = true;
                service.SaveChanges();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        private void ADD_STUDENT(object sender, RoutedEventArgs e)
        {
            var s = service.intake_branch_track.Select(ibn => ibn).OrderByDescending(ibn => ibn.id_intake_branch_track).FirstOrDefault();
            int numm = s.id_intake_branch_track;
            intake_branch_track ibnobect = new intake_branch_track();
            ibnobect.id_intake_branch_track = ++numm;
            //MessageBox.Show(ibnobect.id_intake_branch_track.ToString());
            Student student = new Student();

            try
            {
                try
                {

                    var queryy = (from b in service.Branches
                                  where b.brn_name == ((Branch)comboBox.SelectedItem).brn_name
                                  select (b)).FirstOrDefault();
                    ibnobect.brn_id = queryy.brn_id;
                    //MessageBox.Show(ibnobect.brn_id.ToString());
                    var queryy1 = (from t in service.Tracks
                                   where t.trk_name == ((Track)Tracks.SelectedItem).trk_name
                                   select (t)).FirstOrDefault();
                    ibnobect.trk_id = queryy1.trk_id;
                    //MessageBox.Show(ibnobect.trk_id.ToString());
                    var queryy2 = (from i in service.Intakes
                                   where i.itk_name == ((Intake)comboBox2.SelectedItem).itk_name
                                   select (i)).FirstOrDefault();

                    ibnobect.itk_id = queryy2.itk_id;
                    //MessageBox.Show(ibnobect.itk_id.ToString())
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
                student.id_intake_branch_track = ibnobect.id_intake_branch_track;
                if (radioButton.IsChecked == true)
                    student.is_deleted = true;
                if (radioButton1.IsChecked == true)
                    student.is_deleted = false;

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            ibnobect.is_deleted = false;
            service.intake_branch_track.Add(ibnobect);
            service.SaveChanges();
            student.name = name1.Text;
            int num;
            int.TryParse(textBox.Text, out num);
            student.St_ID = num;
            service.Students.Add(student);
            service.SaveChanges();
            MessageBox.Show("student data inserted ");
            c.ItemsSource = service.Students.ToList();
        }

        private void UPDATE_STUDENT(object sender, RoutedEventArgs e)
        {
            try
            {

                var queryibn = (from s in service.Students
                                join ibn in service.intake_branch_track on
                                s.id_intake_branch_track equals ibn.id_intake_branch_track
                                where s.St_ID == ((Student)c.SelectedItem).St_ID
                                select (ibn)).First();
                queryibn.trk_id = ((Track)Tracks.SelectedItem).trk_id;
                queryibn.itk_id = ((Intake)comboBox2.SelectedItem).itk_id;
                queryibn.brn_id = ((Branch)comboBox.SelectedItem).brn_id;
                if (radioButton.IsChecked == true)
                    ((Student)c.SelectedItem).is_deleted = true;
                if (radioButton1.IsChecked == true)
                    ((Student)c.SelectedItem).is_deleted = false;
                ((Student)c.SelectedItem).name = name1.Text;
                service.SaveChanges();
                MessageBox.Show("student data updated");
                c.ItemsSource = service.Students.ToList();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Content.Children.Clear();
            WrapPanel wrp = new WrapPanel();
            WrapPanel wrp1 = new WrapPanel();
            WrapPanel wrp2 = new WrapPanel();
            WrapPanel wrp3 = new WrapPanel();
            WrapPanel wrp4 = new WrapPanel();
            WrapPanel wrp5 = new WrapPanel();
            WrapPanel wrp6 = new WrapPanel();
            WrapPanel wrp7 = new WrapPanel();
            c = new ComboBox();

            c.ItemsSource = service.Tracks.ToList();
            c.DisplayMemberPath = "trk_name";
            c.SelectedValuePath = "trk_id";
            c.SelectionChanged += new SelectionChangedEventHandler(TRACKSCHANGED);

            wrp.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#086564"));

            wrp.Width = 700;
            wrp.Height = 500;
            c.Width = 500;
            c.Height = 30;
            c.Margin = new Thickness(85, 30, 0, 0);
            c.Foreground = Brushes.Black;
            txtblock = new TextBlock();
            txtblock.Text = "ID";
            txtblock.Foreground = Brushes.White;
            wrp1.Margin = new Thickness(70, 40, 110, 0);
            txtblock.FontSize = 25;
            txtblock.FontWeight = FontWeights.Bold;
            textBox = new TextBox();
            textBox.Width = 300;
            textBox.Height = 30;
            textBox.Margin = new Thickness(90, 0, 0, 0);

            name = new TextBlock();
            name.Text = "Name";
            name.Foreground = Brushes.White;
            wrp2.Margin = new Thickness(70, 50, 150, 0);
            name.FontSize = 25;
            name.FontWeight = FontWeights.Bold;
            name1 = new TextBox();
            name1.Width = 300;
            name1.Height = 30;
            name1.Margin = new Thickness(50, 0, 0, 0);

            delete = new TextBlock();
            delete.Text = "Delete";
            delete.Foreground = Brushes.White;
            wrp5.Margin = new Thickness(70, 40, 150, 0);
            delete.Margin = new Thickness(0, 20, 150, 0);
            delete.FontSize = 25;
            delete.FontWeight = FontWeights.Bold;
            radioButton = new RadioButton();
            radioButton.Margin = new Thickness(-50, 30, 0, 0);
            textBox1 = new TextBlock();
            textBox1.Text = "True";
            textBox1.Foreground = Brushes.White;
            textBox1.Margin = new Thickness(-20, 30, 0, 0);
            radioButton1 = new RadioButton();
            radioButton1.Margin = new Thickness(80, 30, 0, 0);
            textBox2 = new TextBlock();
            textBox2.Text = "False";
            textBox2.Foreground = Brushes.White;
            textBox2.Margin = new Thickness(10, 30, 0, 0);

            button = new Button();
            wrp6.Margin = new Thickness(70, 80, 150, 0);
            button.Width = 70;
            button.Height = 40;
            button.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#086564"));

            button.BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#59d4ff"));
            button.Content = new PackIcon { Kind = PackIconKind.GroupAdd, Height = 35, Width = 40 };
            button.Foreground = Brushes.White;
            button.Click += ADD_TRACK;
            update = new Button();
            wrp6.Margin = new Thickness(70, 30, 150, 0);
            update.Margin = new Thickness(70, 0, 150, 0);
            update.Width = 70;
            update.Height = 40;
            update.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#086564"));

            update.BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#59d4ff"));
            update.Content = new PackIcon { Kind = PackIconKind.Update, Height = 35, Width = 40 };
            update.Foreground = Brushes.White;
            update.Click += UPDATE_TRACK;

            delete1 = new Button();
            wrp7.Margin = new Thickness(70, -40, 0, 0);
            delete1.Margin = new Thickness(280, 0, 0, 0);
            delete1.Width = 70;
            delete1.Height = 40;
            delete1.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#086564"));

            delete1.BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#59d4ff"));
            delete1.Content = new PackIcon { Kind = PackIconKind.Delete, Height = 35, Width = 40 };
            delete1.Foreground = Brushes.White;
            delete1.Click += DELETE_TRACK;


            wrp.Children.Add(c);
            wrp.Children.Add(wrp1);
            wrp1.Children.Add(txtblock);
            wrp1.Children.Add(textBox);
            wrp2.Children.Add(name);
            wrp2.Children.Add(name1);
            wrp.Children.Add(wrp2);

            wrp.Children.Add(wrp5);
            wrp5.Children.Add(delete);
            wrp5.Children.Add(radioButton);
            wrp5.Children.Add(textBox1);
            wrp5.Children.Add(radioButton1);
            wrp5.Children.Add(textBox2);
            wrp.Children.Add(wrp6);
            wrp6.Children.Add(button);
            wrp6.Children.Add(update);
            wrp.Children.Add(wrp7);
            wrp7.Children.Add(delete1);
            Content.Margin = new Thickness(20, 0, 0, 0);
            Content.Children.Add(wrp);

        }

        private void TRACKSCHANGED(object sender, SelectionChangedEventArgs e)
        {
            string text = c.SelectedValue.ToString();
            int x = (int.Parse(text));
            Track track = service.Tracks.FirstOrDefault(tk => tk.trk_id == x);
            textBox.Text = track.trk_id.ToString();
            name1.Text = track.trk_name;
        }

        private void ADD_TRACK(object sender, RoutedEventArgs e)
        {
            try
            {
                Track track = new Track();
                if (radioButton.IsChecked == true)
                    track.is_deleted = true;
                if (radioButton1.IsChecked == true)
                    track.is_deleted = false;
                track.trk_name = name1.Text;
                service.Tracks.Add(track);
                service.SaveChanges();
                MessageBox.Show("track inserted sucssfully");
                c.ItemsSource = service.Tracks.ToList();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void DELETE_TRACK(object sender, RoutedEventArgs e)
        {

            try
            {
                ((Track)c.SelectedItem).is_deleted = true;
                radioButton.IsChecked = true;
                MessageBox.Show("deleted track");
                service.SaveChanges();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void UPDATE_TRACK(object sender, RoutedEventArgs e)
        {
            try
            {
                ((Track)c.SelectedItem).trk_name = name1.Text;
                if (radioButton.IsChecked == true)
                    ((Track)c.SelectedItem).is_deleted = true;
                if (radioButton1.IsChecked == true)
                    ((Track)c.SelectedItem).is_deleted = false;
                service.SaveChanges();
                MessageBox.Show("track deleted Updated");
                c.ItemsSource = service.Tracks.ToList();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }


        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Content.Children.Clear();
            WrapPanel wrp = new WrapPanel();
            WrapPanel wrp1 = new WrapPanel();
            WrapPanel wrp2 = new WrapPanel();
            WrapPanel wrp3 = new WrapPanel();
            WrapPanel wrp4 = new WrapPanel();
            WrapPanel wrp5 = new WrapPanel();
            WrapPanel wrp6 = new WrapPanel();
            WrapPanel wrp7 = new WrapPanel();
            c = new ComboBox();

            c.ItemsSource = service.Intakes.ToList();
            c.DisplayMemberPath = "itk_name";
            c.SelectedValuePath = "itk_id";
            c.SelectionChanged += new SelectionChangedEventHandler(INTAKESCHANGED);

            wrp.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#086564"));

            wrp.Width = 700;
            wrp.Height = 500;
            c.Width = 500;
            c.Height = 30;
            c.Margin = new Thickness(85, 30, 0, 0);
            c.Foreground = Brushes.Black;
            txtblock = new TextBlock();
            txtblock.Text = "ID";
            txtblock.Foreground = Brushes.White;
            wrp1.Margin = new Thickness(70, 40, 110, 0);
            txtblock.FontSize = 25;
            txtblock.FontWeight = FontWeights.Bold;
            textBox = new TextBox();
            textBox.Width = 300;
            textBox.Height = 30;
            textBox.Margin = new Thickness(90, 0, 0, 0);

            name = new TextBlock();
            name.Text = "Name";
            name.Foreground = Brushes.White;
            wrp2.Margin = new Thickness(70, 50, 150, 0);
            name.FontSize = 25;
            name.FontWeight = FontWeights.Bold;
            name1 = new TextBox();
            name1.Width = 300;
            name1.Height = 30;
            name1.Margin = new Thickness(50, 0, 0, 0);

            delete = new TextBlock();
            delete.Text = "Delete";
            delete.Foreground = Brushes.White;
            wrp5.Margin = new Thickness(70, 40, 150, 0);
            delete.Margin = new Thickness(0, 20, 150, 0);
            delete.FontSize = 25;
            delete.FontWeight = FontWeights.Bold;
            radioButton = new RadioButton();
            radioButton.Margin = new Thickness(-50, 30, 0, 0);
            textBox1 = new TextBlock();
            textBox1.Text = "True";
            textBox1.Foreground = Brushes.White;
            textBox1.Margin = new Thickness(-20, 30, 0, 0);
            radioButton1 = new RadioButton();
            radioButton1.Margin = new Thickness(80, 30, 0, 0);
            textBox2 = new TextBlock();
            textBox2.Text = "False";
            textBox2.Foreground = Brushes.White;
            textBox2.Margin = new Thickness(10, 30, 0, 0);

            button = new Button();
            wrp6.Margin = new Thickness(70, 80, 150, 0);
            button.Width = 70;
            button.Height = 40;
            button.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#086564"));

            button.BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#59d4ff"));
            button.Content = new PackIcon { Kind = PackIconKind.GroupAdd, Height = 35, Width = 40 };
            button.Foreground = Brushes.White;
            button.Click += ADD_INTAKE;
            update = new Button();
            wrp6.Margin = new Thickness(70, 30, 150, 0);
            update.Margin = new Thickness(70, 0, 150, 0);
            update.Width = 70;
            update.Height = 40;
            update.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#086564"));

            update.BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#59d4ff"));
            update.Content = new PackIcon { Kind = PackIconKind.Update, Height = 35, Width = 40 };
            update.Foreground = Brushes.White;
            update.Click += UPDATE_INTAKE;

            delete1 = new Button();
            wrp7.Margin = new Thickness(70, -40, 0, 0);
            delete1.Margin = new Thickness(280, 0, 0, 0);
            delete1.Width = 70;
            delete1.Height = 40;
            delete1.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#086564"));

            delete1.BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#59d4ff"));
            delete1.Content = new PackIcon { Kind = PackIconKind.Delete, Height = 35, Width = 40 };
            delete1.Foreground = Brushes.White;
            delete1.Click += DELETE_INTAKE;


            wrp.Children.Add(c);
            wrp.Children.Add(wrp1);
            wrp1.Children.Add(txtblock);
            wrp1.Children.Add(textBox);
            wrp2.Children.Add(name);
            wrp2.Children.Add(name1);
            wrp.Children.Add(wrp2);

            wrp.Children.Add(wrp5);
            wrp5.Children.Add(delete);
            wrp5.Children.Add(radioButton);
            wrp5.Children.Add(textBox1);
            wrp5.Children.Add(radioButton1);
            wrp5.Children.Add(textBox2);
            wrp.Children.Add(wrp6);
            wrp6.Children.Add(button);
            wrp6.Children.Add(update);
            wrp.Children.Add(wrp7);
            wrp7.Children.Add(delete1);
            Content.Margin = new Thickness(20, 0, 0, 0);
            Content.Children.Add(wrp);

        }

        private void INTAKESCHANGED(object sender, SelectionChangedEventArgs e)
        {
            string text = c.SelectedValue.ToString();
            int x = (int.Parse(text));
            Intake intake = service.Intakes.FirstOrDefault(intk => intk.itk_id == x);
            textBox.Text = intake.itk_id.ToString();
            name1.Text = intake.itk_name;

        }


        private void ADD_INTAKE(object sender, RoutedEventArgs e)
        {
            try
            {
                Intake intake = new Intake();
                if (radioButton.IsChecked == true)
                    intake.is_deleted = true;
                if (radioButton1.IsChecked == true)
                    intake.is_deleted = false;
                intake.itk_name = name1.Text;
                service.Intakes.Add(intake);
                service.SaveChanges();
                MessageBox.Show("Inteke Inserted Successfully");
                c.ItemsSource = service.Intakes.ToList();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void DELETE_INTAKE(object sender, RoutedEventArgs e)
        {
            try
            {
                ((Intake)c.SelectedItem).is_deleted = true;
                radioButton.IsChecked = true;
                MessageBox.Show("deleted intake");
                service.SaveChanges();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }


        private void UPDATE_INTAKE(object sender, RoutedEventArgs e)
        {
            try
            {
                ((Intake)c.SelectedItem).itk_name = name1.Text;
                if (radioButton.IsChecked == true)
                    ((Intake)c.SelectedItem).is_deleted = true;
                if (radioButton1.IsChecked == true)
                    ((Intake)c.SelectedItem).is_deleted = false;
                service.SaveChanges();
                MessageBox.Show("Inteke Updated Successfully");
                c.ItemsSource = service.Intakes.ToList();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }



        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Content.Children.Clear();
            WrapPanel wrp = new WrapPanel();
            WrapPanel wrp1 = new WrapPanel();
            WrapPanel wrp2 = new WrapPanel();
            WrapPanel wrp3 = new WrapPanel();
            WrapPanel wrp4 = new WrapPanel();
            WrapPanel wrp5 = new WrapPanel();
            WrapPanel wrp6 = new WrapPanel();
            WrapPanel wrp7 = new WrapPanel();
            c = new ComboBox();


            c.ItemsSource = service.Branches.ToList();
            c.DisplayMemberPath = "brn_name";
            c.SelectedValuePath = "brn_id";
            c.SelectionChanged += new SelectionChangedEventHandler(BRANCHESCHANGED);


            wrp.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#086564"));

            wrp.Width = 700;
            wrp.Height = 500;
            c.Width = 500;
            c.Height = 30;
            c.Margin = new Thickness(85, 30, 0, 0);
            c.Foreground = Brushes.Black;
            txtblock = new TextBlock();
            txtblock.Text = "ID";
            txtblock.Foreground = Brushes.White;
            wrp1.Margin = new Thickness(70, 40, 110, 0);
            txtblock.FontSize = 25;
            txtblock.FontWeight = FontWeights.Bold;
            textBox = new TextBox();
            textBox.Width = 300;
            textBox.Height = 30;
            textBox.Margin = new Thickness(90, 0, 0, 0);

            name = new TextBlock();
            name.Text = "Name";
            name.Foreground = Brushes.White;
            wrp2.Margin = new Thickness(70, 50, 150, 0);
            name.FontSize = 25;
            name.FontWeight = FontWeights.Bold;
            name1 = new TextBox();
            name1.Width = 300;
            name1.Height = 30;
            name1.Margin = new Thickness(50, 0, 0, 0);

            delete = new TextBlock();
            delete.Text = "Delete";
            delete.Foreground = Brushes.White;
            wrp5.Margin = new Thickness(70, 40, 150, 0);
            delete.Margin = new Thickness(0, 20, 150, 0);
            delete.FontSize = 25;
            delete.FontWeight = FontWeights.Bold;
            radioButton = new RadioButton();
            radioButton.Margin = new Thickness(-50, 30, 0, 0);
            textBox1 = new TextBlock();
            textBox1.Text = "True";
            textBox1.Foreground = Brushes.White;
            textBox1.Margin = new Thickness(-20, 30, 0, 0);
            radioButton1 = new RadioButton();
            radioButton1.Margin = new Thickness(80, 30, 0, 0);
            textBox2 = new TextBlock();
            textBox2.Text = "False";
            textBox2.Foreground = Brushes.White;
            textBox2.Margin = new Thickness(10, 30, 0, 0);

            button = new Button();
            wrp6.Margin = new Thickness(70, 80, 150, 0);
            button.Width = 70;
            button.Height = 40;
            button.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#086564"));

            button.BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#59d4ff"));
            button.Content = new PackIcon { Kind = PackIconKind.GroupAdd, Height = 35, Width = 40 };
            button.Foreground = Brushes.White;
            button.Click += ADD_BRANCH;
            update = new Button();
            wrp6.Margin = new Thickness(70, 30, 150, 0);
            update.Margin = new Thickness(70, 0, 150, 0);
            update.Width = 70;
            update.Height = 40;
            update.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#086564"));

            update.BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#59d4ff"));
            update.Content = new PackIcon { Kind = PackIconKind.Update, Height = 35, Width = 40 };
            update.Foreground = Brushes.White;
            update.Click += UPDATE_BRANCH;
            delete1 = new Button();
            wrp7.Margin = new Thickness(70, -40, 0, 0);
            delete1.Margin = new Thickness(280, 0, 0, 0);
            delete1.Width = 70;
            delete1.Height = 40;
            delete1.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#086564"));

            delete1.BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#59d4ff"));
            delete1.Content = new PackIcon { Kind = PackIconKind.Delete, Height = 35, Width = 40 };
            delete1.Foreground = Brushes.White;
            delete1.Click += DELETE_BRANCH;


            wrp.Children.Add(c);
            wrp.Children.Add(wrp1);
            wrp1.Children.Add(txtblock);
            wrp1.Children.Add(textBox);
            wrp2.Children.Add(name);
            wrp2.Children.Add(name1);
            wrp.Children.Add(wrp2);

            wrp.Children.Add(wrp5);
            wrp5.Children.Add(delete);
            wrp5.Children.Add(radioButton);
            wrp5.Children.Add(textBox1);
            wrp5.Children.Add(radioButton1);
            wrp5.Children.Add(textBox2);
            wrp.Children.Add(wrp6);
            wrp6.Children.Add(button);
            wrp6.Children.Add(update);
            wrp.Children.Add(wrp7);
            wrp7.Children.Add(delete1);
            Content.Margin = new Thickness(20, 0, 0, 0);
            Content.Children.Add(wrp);
        }

        private void BRANCHESCHANGED(object sender, SelectionChangedEventArgs e)
        {
            string text = c.SelectedValue.ToString();
            int x = (int.Parse(text));
            Branch branch = service.Branches.FirstOrDefault(brn => brn.brn_id == x);
            textBox.Text = branch.brn_id.ToString();
            name1.Text = branch.brn_name;
        }



        private void ADD_BRANCH(object sender, RoutedEventArgs e)
        {
            try
            {
                Branch branch = new Branch();
                branch.brn_name = name1.Text;
                if (radioButton.IsChecked == true)
                    branch.is_deleted = true;
                if (radioButton1.IsChecked == true)
                    branch.is_deleted = false;
                service.Branches.Add(branch);
                service.SaveChanges();
                MessageBox.Show("inserted branched sucssesfaul");
                c.ItemsSource = service.Branches.ToList();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void DELETE_BRANCH(object sender, RoutedEventArgs e)
        {
            try
            {

                ((Branch)c.SelectedItem).is_deleted = true;
                radioButton.IsChecked = true;
                MessageBox.Show("deleted branch");
                service.SaveChanges();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void UPDATE_BRANCH(object sender, RoutedEventArgs e)
        {
            try
            {
                ((Branch)c.SelectedItem).brn_name = name1.Text;
                if (radioButton.IsChecked == true)
                    ((Branch)c.SelectedItem).is_deleted = true;
                if (radioButton.IsChecked == true)
                    ((Branch)c.SelectedItem).is_deleted = false;
                service.SaveChanges();
                MessageBox.Show("updated branched sucssesfaul");
                c.ItemsSource = service.Branches.ToList();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Content.Children.Clear();
            WrapPanel wrp = new WrapPanel();
            WrapPanel wrp1 = new WrapPanel();
            WrapPanel wrp2 = new WrapPanel();
            WrapPanel wrp3 = new WrapPanel();
            WrapPanel wrp4 = new WrapPanel();
            WrapPanel wrp5 = new WrapPanel();
            WrapPanel wrp6 = new WrapPanel();
            WrapPanel wrp7 = new WrapPanel();
            c = new ComboBox();
            c.ItemsSource = service.Courses.ToList();
            c.DisplayMemberPath = "Name";
            c.SelectedValuePath = "C_ID";

            c.SelectionChanged += new SelectionChangedEventHandler(COURSESCHANGED);
            wrp.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#086564"));

            wrp.Width = 700;
            wrp.Height = 500;
            c.Width = 500;
            c.Height = 30;
            c.Margin = new Thickness(85, 30, 0, 0);
            c.Foreground = Brushes.Black;

            txtblock = new TextBlock();
            txtblock.Text = "ID";
            txtblock.Foreground = Brushes.White;
            wrp1.Margin = new Thickness(70, 40, 110, 0);
            txtblock.FontSize = 25;
            txtblock.FontWeight = FontWeights.Bold;
            textBox = new TextBox();
            textBox.Width = 300;
            textBox.Height = 30;
            textBox.Margin = new Thickness(90, 0, 0, 0);

            name = new TextBlock();
            name.Text = "Name";
            name.Foreground = Brushes.White;
            wrp2.Margin = new Thickness(70, 20, 150, 0);
            name.FontSize = 25;
            name.FontWeight = FontWeights.Bold;
            name1 = new TextBox();
            name1.Width = 300;
            name1.Height = 30;
            name1.Margin = new Thickness(50, 0, 0, 0);



            Track = new TextBlock();
            Track.Text = "Instructor";
            Track.Foreground = Brushes.White;
            wrp4.Margin = new Thickness(70, 10, 150, 0);
            Track.FontSize = 25;
            Track.FontWeight = FontWeights.Bold;
            comboBox1 = new ComboBox();
            comboBox1.Width = 300;
            comboBox1.Height = 30;
            comboBox1.Margin = new Thickness(30, 0, 0, 0);

            branch = new TextBlock();
            branch.Text = "track";
            branch.Foreground = Brushes.White;
            wrp4.Margin = new Thickness(70, 10, 150, 0);
            branch.Margin = new Thickness(0, 15, 0, 0);
            branch.FontSize = 25;
            branch.FontWeight = FontWeights.Bold;
            comboBox = new ComboBox();



            comboBox.Width = 300;
            comboBox.Height = 30;
            comboBox.Margin = new Thickness(20, 10, 0, 0);

            comboBox1.ItemsSource = service.Instructors.ToList();
            comboBox1.DisplayMemberPath = "Name";

            comboBox.ItemsSource = service.Tracks.ToList();
            comboBox.DisplayMemberPath = "trk_name";
            TextBlock Intake = new TextBlock();
            Intake.Text = "Description";
            Intake.Foreground = Brushes.White;
            wrp4.Margin = new Thickness(70, 10, 150, 0);
            Intake.Margin = new Thickness(0, 15, 0, 0);
            Intake.FontSize = 25;
            Intake.FontWeight = FontWeights.Bold;
            Desc = new TextBox();
            Desc.Width = 300;
            Desc.Height = 30;
            Desc.Margin = new Thickness(45, 10, 0, 0);

            text_descrtion = new TextBox();
            text_descrtion.Width = 300;
            text_descrtion.Height = 30;
            text_descrtion.Margin = new Thickness(45, 0, 0, 0);

            TextBlock delete = new TextBlock();
            delete.Text = "Delete";
            delete.Foreground = Brushes.White;
            wrp5.Margin = new Thickness(70, 15, 150, 0);
            delete.FontSize = 25;
            delete.FontWeight = FontWeights.Bold;
            radioButton = new RadioButton();
            radioButton.Margin = new Thickness(50, 12, 0, 0);
            TextBlock textBox1 = new TextBlock();
            textBox1.Text = "True";
            textBox1.Foreground = Brushes.White;
            textBox1.Margin = new Thickness(10, 12, 0, 0);
            radioButton1 = new RadioButton();
            radioButton1.Margin = new Thickness(100, 12, 0, 0);
            TextBlock textBox2 = new TextBlock();
            textBox2.Text = "False";
            textBox2.Foreground = Brushes.White;
            textBox2.Margin = new Thickness(20, 12, 0, 0);

            button = new Button();
            wrp6.Margin = new Thickness(70, 30, 150, 0);
            button.Width = 70;
            button.Height = 40;
            button.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#086564"));

            button.BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#59d4ff"));
            button.Content = new PackIcon { Kind = PackIconKind.GroupAdd, Height = 35, Width = 40 };
            button.Foreground = Brushes.White;
            button.Click += ADD_COURSE;

            update = new Button();
            wrp6.Margin = new Thickness(70, 30, 150, 0);
            update.Margin = new Thickness(70, 0, 150, 0);
            update.Width = 70;
            update.Height = 40;
            update.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#086564"));

            update.BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#59d4ff"));
            update.Content = new PackIcon { Kind = PackIconKind.Update, Height = 35, Width = 40 };
            update.Foreground = Brushes.White;
            update.Click += UPDATE_COURSE;
            delete1 = new Button();
            wrp7.Margin = new Thickness(70, -40, 0, 0);
            delete1.Margin = new Thickness(280, 0, 0, 0);
            delete1.Width = 70;
            delete1.Height = 40;
            delete1.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#086564"));

            delete1.BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#59d4ff"));
            delete1.Content = new PackIcon { Kind = PackIconKind.Delete, Height = 35, Width = 40 };
            delete1.Foreground = Brushes.White;
            delete1.Click += DELETE_COURSE;


            wrp.Children.Add(c);
            wrp.Children.Add(wrp1);
            wrp1.Children.Add(txtblock);
            wrp1.Children.Add(textBox);
            wrp2.Children.Add(name);
            wrp2.Children.Add(name1);
            wrp.Children.Add(wrp2);
            wrp.Children.Add(wrp3);
            wrp.Children.Add(wrp4);
            wrp4.Children.Add(Track);
            wrp4.Children.Add(comboBox1);
            wrp4.Children.Add(branch);
            wrp4.Children.Add(comboBox);
            wrp4.Children.Add(Intake);
            wrp4.Children.Add(text_descrtion);
            wrp.Children.Add(wrp5);
            wrp5.Children.Add(delete);
            wrp5.Children.Add(radioButton);
            wrp5.Children.Add(textBox1);
            wrp5.Children.Add(radioButton1);
            wrp5.Children.Add(textBox2);
            wrp.Children.Add(wrp6);
            wrp6.Children.Add(button);
            wrp6.Children.Add(update);
            wrp.Children.Add(wrp7);
            wrp7.Children.Add(delete1);

            Content.Margin = new Thickness(20, 0, 0, 0);
            Content.Children.Add(wrp);

        }

        private void COURSESCHANGED(object sender, SelectionChangedEventArgs e)
        {
            string text = c.SelectedValue.ToString();
            text_ins = new TextBox();
            Course course = (Course)c.SelectedItem;
            textBox.Text = course.C_ID.ToString();
            name1.Text = course.Name;
            text_ins.Text = course.Instruct_ID.ToString();
            text_descrtion.Text = course.description;
            comboBox1.SelectedItem = ((Instructor)service.Instructors.FirstOrDefault(inst => inst.Instruct_ID == course.Instruct_ID));
            int num;
            int.TryParse(textBox.Text.ToString(), out num);
            var queryy = (from t in service.Tracks
                          join c in service.Courses on
                          t.trk_id equals c.Track_ID
                          where c.C_ID == course.C_ID
                          select (t)).First();
            if (queryy != null)
                comboBox.SelectedItem = queryy;
            if (course.is_deleted == true)
                radioButton.IsChecked = true;
            if (course.is_deleted == false)
                radioButton1.IsChecked = true;
        }

        private void DELETE_COURSE(object sender, RoutedEventArgs e)
        {
            try
            {
                ((Course)c.SelectedItem).is_deleted = true;
                radioButton.IsChecked = true;
                MessageBox.Show("deleted course");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void ADD_COURSE(object sender, RoutedEventArgs e)
        {
            try
            {
                Course course = new Course();
                course.Name = name1.Text;
                course.Instruct_ID = ((Instructor)comboBox1.SelectedItem).Instruct_ID;
                course.Track_ID = ((Track)comboBox.SelectedItem).trk_id;
                if (radioButton.IsChecked == true)
                    course.is_deleted = true;
                if (radioButton1.IsChecked == true)
                    course.is_deleted = false;
                course.description = text_descrtion.Text;
                service.Courses.Add(course);
                service.SaveChanges();
                MessageBox.Show("course inserted sessufully");
                c.ItemsSource = service.Courses.ToList();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void UPDATE_COURSE(object sender, RoutedEventArgs e)
        {
            try
            {

                var query = (from s in service.Courses
                             where s.C_ID == ((Course)c.SelectedItem).C_ID
                             select (s)).First();
                query.Instruct_ID = ((Instructor)comboBox1.SelectedItem).Instruct_ID;
                if (radioButton.IsChecked == true)
                    ((Course)c.SelectedItem).is_deleted = true;
                if (radioButton1.IsChecked == true)
                    ((Course)c.SelectedItem).is_deleted = false;
                query.Track_ID = ((Track)comboBox.SelectedItem).trk_id;
                ((Course)c.SelectedItem).description = Desc.Text;
                ((Course)c.SelectedItem).Name = name1.Text;
                ((Course)c.SelectedItem).description = text_descrtion.Text;
                service.SaveChanges();
                MessageBox.Show("course udeted sessufully");
                c.ItemsSource = service.Courses.ToList();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
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

        private void logout(object sender, RoutedEventArgs e)
        {
            LoginForm l = new LoginForm();
            l.Show();
            this.Close();
        }
        /*
private void Comboboxinstrctor_form_for_course_SelectionChanged(object sender, SelectionChangedEventArgs e)
{
   //instrctor_form_for_course.DataContext = comboboxinstrctor_form_for_course.SelectedItem;
   instrctor_id_for_course.Text = ((Instructor)comboboxinstrctor_form_for_course.SelectedValue).Instruct_ID.ToString();
}
*/


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
        public string Titulo { get; private set; }
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


   
}
