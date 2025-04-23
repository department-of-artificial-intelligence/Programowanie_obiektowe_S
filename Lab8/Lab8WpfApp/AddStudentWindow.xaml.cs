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

namespace Lab8WpfApp
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
            Student = student ?? new Student();
            if (student != null){
                TextBoxFirstName.Text = student.FirstName;
                TextBoxLastName.Text = student.LastName;
                TextBoxFaculty.Text = student.Faculty;
                TextBoxStudentNo.Text = student.StudentNo.ToString();
            }

        }

        private void AddStudentClick(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(TextBoxFirstName.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(TextBoxLastName.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(TextBoxFaculty.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(TextBoxStudentNo.Text, @"^[0-9]{4,10}$"))
            {
                MessageBox.Show("Invalid input data");
                return;
            }

            if (!int.TryParse(TextBoxStudentNo.Text, out int studentNo))
            {
                MessageBox.Show("Student number must be a number");
                return;
            }

            // Przypisanie wartości do obiektu Student
            Student.FirstName = TextBoxFirstName.Text;
            Student.LastName = TextBoxLastName.Text;
            Student.Faculty = TextBoxFaculty.Text;
            Student.StudentNo = studentNo;

            DialogResult = true;
        }
    }
}
