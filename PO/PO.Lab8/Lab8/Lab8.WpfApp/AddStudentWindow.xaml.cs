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
    public partial class AddStudentWindow : Window
    {
        public Student Student { get; set; }
        public AddStudentWindow(Student? student = null)
        {
            InitializeComponent();
            if (student != null)
            {
                textBox_Name.Text = student.FirstName;
                textBox_Surname.Text = student.SurName;
                textBox_Number.Text = student.StudentNo.ToString();
                textBox_Faculty.Text = student.Faculty;
            }
            Student = student ?? new Student();
        }
        private void BTN_AddS_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(textBox_Name.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(textBox_Surname.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(textBox_Number.Text, @"^[0-9]{4,12}$") ||
                !Regex.IsMatch(textBox_Faculty.Text, @"^\p{L}{1,12}$"))
            {
                MessageBox.Show("Invalid input data!");
                return;
            }
            Student.FirstName = textBox_Name.Text;
            Student.SurName = textBox_Surname.Text;
            Student.Faculty = textBox_Faculty.Text;
            if(!int.TryParse(textBox_Number.Text, out int studentNo))
            {
                MessageBox.Show("Number is invalid!");
            }
            Student.StudentNo = studentNo;
            DialogResult = true;
        }
    }
}
