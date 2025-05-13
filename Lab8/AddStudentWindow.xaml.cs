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

namespace Lab8
{
    public partial class AddStudentWindow : Window
    {
        public Student Student { get; set; }

        public AddStudentWindow(Student student = null)
        {
            InitializeComponent();
            if (student != null)
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
            if (!Regex.IsMatch(TextBoxFirstName.Text, @"^\p{L}{1,12}$") ||
               !Regex.IsMatch(TextBoxSurName.Text, @"^\p{L}{1,12}$") ||
               !Regex.IsMatch(TextBoxSurName.Text, @"^\p{L}{1,12}$") ||
               !Regex.IsMatch(TextBoxSurName.Text, @"^[0-9]{4,10}$"))
            {
                MessageBox.Show("Invalid input data");
                return;
            }
            Student.FirstName = TextBoxFirstName.Text;
            Student.SurName = TextBoxSurName.Text;
            Student.Faculty = TextBoxFaculty.Text;
            if (!int.TryParse(TextBoxFirstName.Text, out int studentNo))
                MessageBox.Show("Student is not a number.");
            Student.StudentNo = studentNo;
            DialogResult = true;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Tutaj dodaj kod obsługujący zmianę tekstu w TextBoxSurName
        }
        private void TextBoxFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Tutaj dodaj kod obsługujący zmianę tekstu w TextBoxSurName
        }
    }
}
