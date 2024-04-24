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
            if(student != null)
            {
                first_nametxt.Text = student.FirstName;
                sur_nametxt.Text = student.SurName;
                facilitytxt.Text = student.Facility;
                studentIdtxt.Text = student.StudentId.ToString();
            }
            Student = student ?? new Student();
        }

        private void confirm_student_Click(object sender, RoutedEventArgs e)
        {
            if(!Regex.IsMatch(first_nametxt.Text, @"^\p{L}{1,12}$") || 
               !Regex.IsMatch(sur_nametxt.Text, @"^\p{L}{1,12}$") || 
               !Regex.IsMatch(facilitytxt.Text, @"^\p{L}{1,12}$")|| 
               !Regex.IsMatch(studentIdtxt.Text, @"^[0-9]{4,10}$"))
            {
                MessageBox.Show("Invalid");
                return;
            }
            Student.FirstName = first_nametxt.Text;
            Student.SurName = sur_nametxt.Text;
            Student.Facility = facilitytxt.Text;
            if(!int.TryParse(studentIdtxt.Text,out int StudentId))
            {
                MessageBox.Show("Invalid 2");
            }
            Student.StudentId = StudentId;
            DialogResult = true;
        }
    }
}
