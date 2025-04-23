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
                TextBoxFaculty.Text = student.Faculty;
                TextBoxStudentNo.Text = student.StudentNo.ToString();
                TextBoxFirstName.Text = student.FirstName;
                TextBoxSurName.Text = student.SurName;
            }
            Student = student ?? new Student();

            
        }

        private void ButtonAddStudent_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(input:TextBoxFirstName.Text, pattern: @"^\p{L}{1,12}$")||
                !Regex.IsMatch(input: TextBoxSurName.Text, pattern: @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(input: TextBoxFaculty.Text, pattern: @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(input: TextBoxFirstName.Text, pattern: @"^[0-9]{4,10}$") ))
        {
                MessageBox.Show(messageBoxText: "Invalid input data");
                return;
        }
            Student.FirstName = TextBoxFirstName.Text;
            Student.SurName = TextBoxSurName.Text;
            Student.Faculty = TextBoxFaculty.Text;
        }
    }
}
