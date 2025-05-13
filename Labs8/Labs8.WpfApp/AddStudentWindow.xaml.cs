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

namespace Labs8.WpfApp
{
    public partial class AddStudentWindow : Window
    {
        public StudentWindow Student { get; set; }
        public AddStudentWindow(Student student = null)
        {
            InitializeComponent();
            if(student != null) 
            {
                TBox_Faculty.Text = student.Faculty;
                TBox_FirstName.Text = student.FirstName;
                TBox_StudentNo.Text = student.StudentNo.ToString();
                TBox_SurName.Text = student.SurName;
            }
            Student = student ?? new Student();

        }
        private void Button2AddStudent_Click(object sender, RoutedEventArgs e)
        {
            if(!Regex.IsMatch(TBox_FirstName.Text, @"^\p{L}{1,12}$")||
            if(!Regex.IsMatch(TBox_SurName.Text, @"^\p{L}{1,12}$")||
            if(!Regex.IsMatch(TBox_Faculty.Text, @"^\p{L}{1,12}$")||
            if(!Regex.IsMatch(TBox_StudentNo.Text, @"^\[0-9]{4,10}$"))
            {
                            MessageBox.Show(Invalid input data);
                        }
        }
    }
}
