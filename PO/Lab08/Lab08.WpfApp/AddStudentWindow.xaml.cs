using Lab08.DLL;
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

namespace Lab08.WpfApp
{
    /// <summary>
    /// Interaction logic for AddStudentWindow.xaml
    /// </summary>
    /// 

    public partial class AddStudentWindow : Window
    {
        public Student Student { get; set; }

        public AddStudentWindow(Student student = null)
        {
            InitializeComponent();
            if (student != null)
            {
                FirstNameText.Text = student.FirstName;
                SurNameText.Text = student.SurName; 
                FaucltyText.Text = student.Fauclty;
                NumberText.Text = student.StudentNo.ToString();
            }
            Student = student ?? new Student();
            
        }

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(FirstNameText.Text, @"^\p{L}{1,12}$")||
                !Regex.IsMatch(SurNameText.Text, @"^\p{L}{1,12}$"))
            {
                MessageBox.Show("Invalid data!");
                return;
            }

            Student.FirstName = FirstNameText.Text;
            Student.SurName = SurNameText.Text;
            Student.Fauclty = FaucltyText.Text;
            //if(!int.TryParse(NumberText.Text, out int studentNo))
            //{
            //    MessageBox.Show("Not a number!");
            //}
            Student.StudentNo = NumberText.Text;
            
            DialogResult = true;

        }
    }
}
