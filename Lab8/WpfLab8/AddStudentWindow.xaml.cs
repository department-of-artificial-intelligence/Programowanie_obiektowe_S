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
using WpfLab8.BLL;

namespace WpfLab8.APP
{
    /// <summary>
    /// Interaction logic for AddStudentWindow.xaml
    /// </summary>
    public partial class AddStudentWindow : Window
    {
        public Student students { get; set; }
        public AddStudentWindow(Student student = null)
        {
            InitializeComponent();
            if (student != null)
            {
                TextBoxFaculty.Text = student.Faculty;
                TextBoxName.Text = student.FirstName;
                TextBoxLastName.Text = student.LastName;
                TextBoxNo.Text = student.StudentNo.ToString();
            }
            students = student ?? new Student();
        }

        public void ButtonAddStudent_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(TextBoxName.Text, @"^\p{L}{1,12}$") ||
            !Regex.IsMatch(TextBoxLastName.Text, @"^\p{L}{1,12}$") ||
            !Regex.IsMatch(TextBoxName.Text, @"^\p{L}{1,12}$") ||
            !Regex.IsMatch(TextBoxName.Text, @"^\p{L}{1,12}$"))
            {
                MessageBox.Show("Invalid input data");
                return;
            }
            students.FirstName = TextBoxName.Text;
            students.LastName = TextBoxLastName.Text;
            students.Faculty = TextBoxFaculty.Text;
            if(!int.TryParse(TextBoxNo.Text, out int studentNo)) 
            {
                MessageBox.Show("Student is not a number.");
            }
            students.StudentNo=studentNo;
            DialogResult = true;
        }
    }
}
