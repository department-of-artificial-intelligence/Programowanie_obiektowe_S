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
            if (student != null)
            {
                TextBoxFirstName.Text = student.FirstName;
                TextBoxSurname.Text = student.Surname;
                TextBoxStudentNo.Text = student.StudentNo.ToString();
                TextBoxFaculty.Text = student.Faculty;
            }
            Student = student ?? new Student();
        }

        private void ButtonAddStudent_Click(object sender, RoutedEventArgs e)
        {
            
            if (!Regex.IsMatch(TextBoxFirstName.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(TextBoxSurname.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(TextBoxStudentNo.Text, @"^[0-9]{4,10}$") ||
                !Regex.IsMatch(TextBoxFaculty.Text, @"^\p{L}{1,12}$"))
            {
                MessageBox.Show("Invalid input data");
                return;
            }
            
            Student.FirstName = TextBoxFirstName.Text;
            Student.Surname = TextBoxSurname.Text;
            if (!int.TryParse(TextBoxStudentNo.Text, out int studentNo))
                MessageBox.Show("Student is not a number.");
            Student.StudentNo = studentNo;
            Student.Faculty = TextBoxFaculty.Text;
            DialogResult = true;
        }
    }
}
