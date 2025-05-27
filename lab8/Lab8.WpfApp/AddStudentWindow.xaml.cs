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
using Lab8.BLL;

namespace Lab8.WpfApp
{
    /// <summary>
    /// Логика взаимодействия для AddStudentWindow.xaml
    /// </summary>
    public partial class AddStudentWindow : Window
    {


        public Student Student { get; set; }
        public AddStudentWindow(Student? student = null)
        {
            InitializeComponent();
            if (student != null)
            {
                t1.Text = student.FirstName;
                t2.Text = student.LastName;
                t4.Text = student.ID.ToString();
                t3.Text = student.Faculty;
            }
            Student = student ?? new Student();
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(t1.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(t2.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(t3.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(t4.Text, @"^[0-9]{4,10}$"))
            {
                MessageBox.Show("Invalid input data");
                return;
            }
            Student.FirstName = t1.Text;
            Student.LastName = t2.Text;
            Student.Faculty = t3.Text;
            if (!int.TryParse(t4.Text, out int studentNo))
            {
                MessageBox.Show("Invalid student number");
            }
            Student.ID = studentNo;
            DialogResult = true;
        }
    }
}
