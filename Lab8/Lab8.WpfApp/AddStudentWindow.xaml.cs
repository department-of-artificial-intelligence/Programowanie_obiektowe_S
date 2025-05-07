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
            if(student != null )
            {
                TextBoxFirstName.Text = student.FirstName;
                TextBoxSurName.Text = student.SurName;
                TextBoxFaculty.Text = student.Faculty;
                TextBoxStudentNo.Text = student.StudentNo.ToString();
            }
            Student = student ?? new Student();
        }

        private void ButtonAddStudent_Click(object sender, RoutedEventArgs e)
        {
            if(!Regex.IsMatch(input TextBoxFirstName.Text, pattern: @"^\p{L}{1,12}$") ||
                 )
        }
        
    }
}
