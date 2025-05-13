using lab8.bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace lab8
{
    /// <summary>
    /// Interaction logic for AddStudentWindow.xaml
    /// </summary>
    public partial class AddStudentWindow : Window
    {
        public Student Student { get; set; }
        public AddStudentWindow(Student student = null)
        {
            InitializeComponent();
            if(student != null)
            {
                fname.Text = student.FirstName;
                lname.Text = student.LastName;
                fac.Text = student.Faculty;
                num.Text = student.StudNo.ToString();
                
            }
            Student = student ?? new Student();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void dodaj(object sender, RoutedEventArgs e)
        {
            if(!Regex.IsMatch(fname.Text, @"^\p{L}{1,12}$") ||
               !Regex.IsMatch(lname.Text, @"^\p{L}{1,12}$") ||
               !Regex.IsMatch(fac.Text, @"^\p{L}{1,12}$") ||
               !Regex.IsMatch(num.Text, @"^[0-9]{4,10}$"))
            {
                MessageBox.Show("bledne dane");
                return;
            }
            Student.FirstName = fname.Text;
            Student.LastName = lname.Text;
            Student.Faculty = fac.Text;
            if (!int.TryParse(num.Text, out int studNo))
            {
                MessageBox.Show("Student to nie numer");
            }
                Student.StudNo = studNo;
                DialogResult = true;
            


        }
    }
}
