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
                Faculty_TextBox.Text = student.Faculty;
                FirstName_TextBox.Text = student.FirstName;
                StudentNo_TextBox.Text = student.StudentNo.ToString();
                Surname_TextBox.Text = student.SurName;
            }
            Student = student ?? new Student();
        }

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(FirstName_TextBox.Text, @"^\p{L}{1,12}$") ||
               !Regex.IsMatch(Surname_TextBox.Text, @"^\p{L}{1,12}$") ||
               !Regex.IsMatch(Faculty_TextBox.Text, @"^\p{L}{1,12}$") ||
               !Regex.IsMatch(StudentNo_TextBox.Text, @"^[0-9]{4,10}$"))
            {
                MessageBox.Show("Invalid input data");
                return;
            }
            Student.FirstName = FirstName_TextBox.Text;
            Student.SurName = Surname_TextBox.Text;
            Student.Faculty = Faculty_TextBox.Text;
            if (!int.TryParse(StudentNo_TextBox.Text, out int studentNo))
                MessageBox.Show("Student is not a number.");
            Student.StudentNo = studentNo;
            DialogResult = true;
        }
    }
}
