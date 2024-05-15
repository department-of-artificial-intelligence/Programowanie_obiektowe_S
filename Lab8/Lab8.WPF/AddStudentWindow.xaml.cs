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

namespace Lab8.WPF
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
                TextBoxFirstname.Text = student.FirstName;
                TextBoxSurname.Text = student.SurName;
                TextBoxFaculty.Text = student.Faculty;
                TextBoxStudentNo.Text = student.StudentNo.ToString();
            }
            Student = student ?? new Student();
        }

        private void ButtonConfirm_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(TextBoxFirstname.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(TextBoxSurname.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(TextBoxFaculty.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(TextBoxStudentNo.Text, @"^[0-9]{4,10}$"))
            {
                MessageBox.Show("Invalid input data");
                return;
            }
            Student.FirstName = TextBoxFirstname.Text;
            Student.SurName = TextBoxSurname.Text;
            Student.Faculty = TextBoxFaculty.Text;
            if (!int.TryParse(TextBoxStudentNo.Text, out int studentNo))
                MessageBox.Show("StodentNo. is not a number");
            Student.StudentNo = studentNo;
            DialogResult = true;
        }
    }
}
