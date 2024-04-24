using Lab08.BLL;
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

namespace Lab08.WpfApp
{
    /// <summary>
    /// Interaction logic for Add_student.xaml
    /// </summary>
    public partial class Add_student : Window
    {
        public Student Student { get; set; }

        public Add_student(Student student = null)
        {
            InitializeComponent();
            if(student != null) {
                FacultyBox.Text = student.Faculty;
                NameBox.Text = student.FirstName;
                LastnameBox.Text = student.LastName;
                NumberBox.Text = student.StudentNumber.ToString();
            }
            Student = student ?? new Student();
        }

        private void AddFinale_Click(object sender, RoutedEventArgs e)
        {
            Student.FirstName = NameBox.Text;
            Student.LastName = LastnameBox.Text;
            Student.Faculty = FacultyBox.Text;
            if (!int.TryParse(NumberBox.Text, out int StudentNumber))
                MessageBox.Show(messageBoxText: "Student is not a number");
            Student.StudentNumber = StudentNumber;
            DialogResult = true;
            
        }
    }
}
