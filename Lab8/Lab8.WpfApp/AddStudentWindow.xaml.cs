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
            if (student != null )
            {
                TextBoxFaculty.Text = student.Faculty;
                TextBoxFirstname.Text = student.Firstname;
                TextBoxStudentNo.Text = student.StudentNo.ToString();
                TextBoxSurname.Text = student.Surname;
            }
            Student = student ?? new Student();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonAddStudent_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(TextBoxFirstname.Text)) ;
        }
    }
}
