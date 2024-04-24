using Lab08.BLL;
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

namespace Lab08.WpfApp
{
    /// <summary>
    /// Interaction logic for AddStudentWindow.xaml
    /// </summary>
    public partial class AddStudentWindow : Window
    {
        public Student Student { get; set; }
        public AddStudentWindow()
        {
            InitializeComponent();
            if (student != null) 
            {
                TextBoxFaculty.Text = student.Faculty;
                TextBoxFirstName.Text = student.FirstName;
                TextBoxStudentNo.Text = student.StudentNo.ToString();
                TextBoxSurName.Text = Student.SurName;
            }
            Student = Student ?? new Student();
        }
        private void ButtonAddStudent_Click(object sender, RoutedEventArgs e)
        {
            if(!Regex.IsMatch(TextBoxFirstName.Text, @"^\p{L}{1,12}$") ||
               !Regex.IsMatch(TextBoxSurName.Text, @"^\p{L}{1,12}$") ||
               !Regex.IsMatch(TextBoxFaculty.Text, @"^\p{L}{1,12}$") ||
               !Regex.IsMatch(TextBoxFirstName.Text, @"^[0-9]{4,10}$"))
            {
                MessageBox.Show("Invalid input data");
                return;
            }
            Student.FirstName = TextBoxFirstName.Text;

        }


    }
}
