using Lab8.BLL;
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

namespace Lab8.WpfApp
{
    /// <summary>
    /// Interaction logic for WindowStudent.xaml
    /// </summary>
    public partial class WindowStudent : Window
    {
        public Student Student { get; set; }
        public WindowStudent(Student student = null)
        {
            InitializeComponent();
            if(student != null)
            {
                TextBoxFaculty.Text = student.Faculty;
                TextBoxName.Text = student.FirstName;
                TextBoxNO.Text = student.StudentNo.ToString();
                TextBoxSurName.Text = student.SurName;
            }
            Student = student ?? new Student();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!Regex.IsMatch(TextBoxName.Text,@"^\p{L}{1,12}$")||
                !Regex.IsMatch(TextBoxSurName.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(TextBoxFaculty.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(TextBoxNO.Text, @"^\p{L}{1,12}$"))
            {
                MessageBox.Show("Ty Invalid");
                return;
            }
            Student.FirstName = TextBoxName.Text;
            Student.SurName = TextBoxSurName.Text;
            Student.Faculty = TextBoxFaculty.Text;
            if (!int.TryParse(TextBoxNO.Text, out int studentNo))
                MessageBox.Show("Student is not a number");
            Student.StudentNo = studentNo;
            DialogResult = true;
        }
    }
}
