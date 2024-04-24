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
        public Student Student {  get; set; }
        public AddStudentWindow(Student student = null)
        {
            InitializeComponent();
            if (student != null) {
                TB_FirstName.Text = student.FirstName;
                TB_SurName.Text = student.SurName;
                TB_StudentNo.Text = student.StudentNo.ToString();
                TB_Faculty.Text = student.Faculty;
            }
            Student = student ?? new Student();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!Regex.IsMatch(TB_FirstName.Text, @"^\p{L}{1,12}$")||
                !Regex.IsMatch(TB_SurName.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(TB_Faculty.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(TB_StudentNo.Text, @"^[0-9]{4,10}$"))
            {
                MessageBox.Show("Invalid Input Data");
                return;
            }
            Student.FirstName = TB_FirstName.Text;
            Student.SurName = TB_SurName.Text;
            Student.Faculty = TB_Faculty.Text;

            if (!int.TryParse(TB_StudentNo.Text, out int studentNo))
                MessageBox.Show("Student is not a number.");
            Student.StudentNo = studentNo;
            DialogResult = true;
        }
    }
}
