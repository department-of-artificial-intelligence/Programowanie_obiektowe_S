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
using Lab8.BLL;

namespace Lab8.WpfApp
{
    /// <summary>
    /// Interaction logic for AddStudentWindow.xaml
    /// </summary>
    public partial class AddStudentWindow : Window
    {
        public Student Student1 { get; set; }
        public AddStudentWindow(Student student=null)
        {
            InitializeComponent();
            if (student != null)
            {
                TextBoxFaculty.Text = student.Faculty;
                TextBoxFirstName.Text = student.FirstName;
                TextBoxStudentNo.Text = student.StudentNo.ToString();
                TextBoxSurName.Text = student.SurName;
            }
            Student1 = student ?? new Student();
        }

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(TextBoxFirstName.Text, @"^\p{L}{1,12}") ||
               !Regex.IsMatch(TextBoxSurName.Text, @"^\p{L}{1,12}") ||
               !Regex.IsMatch(TextBoxFaculty.Text, @"^\p{L}{1,12}") ||
               !Regex.IsMatch(TextBoxStudentNo.Text, @"^[0-9]{4,10}$"))
            {
                MessageBox.Show("Invalid input data");
                return;
            }
            Student1.Faculty = TextBoxFaculty.Text;
            Student1.FirstName = TextBoxFirstName.Text;
            Student1.SurName = TextBoxSurName.Text;
            if (!int.TryParse(TextBoxStudentNo.Text, out int studentNo))
                MessageBox.Show("Student is not a number");
            Student1.StudentNo = studentNo;
            DialogResult = true;
            MainWindow x = new MainWindow(); 
            
            //x.DataGridStudents.ItemsSource = x.Students;
        }
    }
}
