using Lab8.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    public partial class AddStudentWindow : Window
    {
        public Student Student { get; set; }
        public AddStudentWindow(Student student = null)
        {
            InitializeComponent();
            if(student != null)
            {
                FacultyTextBox.Text = student.Faculty;
                FirstNameTextBox.Text = student.FirstName;
                SurNameTextBox.Text = student.SurName;
                StudentsNoTextBox.Text = student.StudentNo.ToString();
            }
            Student = student ?? new Student();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Student.FirstName = FirstNameTextBox.Text;
            Student.SurName = SurNameTextBox.Text;
            int tmp = 0;
            int.TryParse(StudentsNoTextBox.Text, out tmp);
            Student.StudentNo = tmp;
            Student.Faculty = FacultyTextBox.Text;
            DialogResult = true;
        }
    }
}
