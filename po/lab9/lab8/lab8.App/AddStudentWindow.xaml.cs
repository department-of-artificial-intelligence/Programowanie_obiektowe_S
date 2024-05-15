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
using static System.Net.Mime.MediaTypeNames;

namespace lab8.App
{
    /// <summary>
    /// Interaction logic for AddStudentWindow.xaml
    /// </summary>
    public partial class AddStudentWindow : Window
    {
        public Student Student { get; set; }
        public AddStudentWindow(Student? student = null)
        {
            InitializeComponent();
            if (Student != null)
            {
                TextBoxFaculty.Text = student.Faculty;
                TextBoxFirstName.Text = student.FirstName;
                TextBoxStudentNo.Text = student.StudentNo.ToString();
                TextBoxSurName.Text = student.SurName;
            }
            Student = student ?? new Student();


        }
        private void ButtonAddStudent_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(input: TextBoxFirstName.Text, pattern: @"^\p{L}{1,12}$") ||
            !Regex.IsMatch(input: TextBoxSurName.Text, pattern: @"^\p{L}{1,12}$"))
            {
                MessageBox.Show(messageBoxText: "Invalid input data");
                return;
            }
            Student.FirstName = TextBoxFirstName.Text;
            Student.SurName = TextBoxSurName.Text;
            Student.Faculty = TextBoxFaculty.Text;
            if (!int.TryParse(TextBoxStudentNo.Text, out int studentNo))
                MessageBox.Show(messageBoxText: "Student is not a number.");
            Student.StudentNo = studentNo;
            DialogResult = true;
        }

       
    }
}
