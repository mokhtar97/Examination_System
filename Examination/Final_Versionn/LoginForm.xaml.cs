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
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        Context service = new Context();
        public LoginForm()
        {
            InitializeComponent();
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            
            try
            {
                string username = Name.Text;
                string password = Pass.Password;
                var query = service.Logins.Where(c => c.username == username).Where(c => c.Password == password).ToList();
                if (query.Count() >= 1)
                {
                    if(query[0].type=="instructor")
                    {
                     
                        var q = service.Instructors.Where(c => c.Name == username).FirstOrDefault();
                        var mg=service.Instructors.Where(c => c.MG_id == q.Instruct_ID ).FirstOrDefault();
                        if(mg!=null)
                        {
                            
                            instructor_form m = new instructor_form();
                                m.Show();
                            this.Close();
                        }
                        else
                        {
                            InstructorData w = new InstructorData(q.Instruct_ID);
                            w.Show();
                            this.Close();
                        }
                        
                    }
                    else
                    {
                        int id = service.Students.Where(s => s.name == username).Select(s => s.St_ID).FirstOrDefault();
                        Student_form std = new Student_form(id);
                        std.Show();
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid!!");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
