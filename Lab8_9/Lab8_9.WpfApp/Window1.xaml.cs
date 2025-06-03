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

namespace Lab8_9.WpfApp
{
    public partial class Window1 : Window
    {
        public Student Student { get; set; }

        public Window1(Student ?student = null)
        {
            InitializeComponent();
            if (student != null)
            {
                TBFaculty.Text = student.Faculty;
                TBSName.Text = student.SurName;
                TBName.Text = student.FirstName;
                TBSNo.Text = student.StudentNo.ToString();
            }
            Student = student ?? new Student();
        }

        private void Adding(object sender, RoutedEventArgs e)
        {
            Student.FirstName = TBName.Text;
            Student.SurName = TBSName.Text;
            Student.Faculty = TBFaculty.Text;
            if(int.TryParse(TBSNo.Text, out int studentNo))
            {
                MessageBox.Show("Student is not a number");
            }
            Student.StudentNo = studentNo;
            DialogResult = true;
        }
    }
}
