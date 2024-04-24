using Lab09.BLL;
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

namespace Lab09.App.PopUpWindows
{
    /// <summary>
    /// Interaction logic for AddStudentWindow.xaml
    /// </summary>
    public partial class AddStudentWindow : Window
    {
        public Student Student { get; set; }
        public AddStudentWindow(Student student=null)
        {
            InitializeComponent();
            if(student != null )
            {
                NameTextBox.Text = student.Name;
                SurnameTextBox.Text=student.Surname;
                IndexTextBox.Text = student.IndexNumber.ToString();
                FacultyTextBox.Text = student.Faculty;
            }
            Student = student ?? new Student();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(NameTextBox.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(SurnameTextBox.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(FacultyTextBox.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(IndexTextBox.Text, @"^[0-9]{4,10}$")) { 
                MessageBox.Show("Invalid data.","Warning!",MessageBoxButton.OK,MessageBoxImage.Warning);
                return;
            }
            Student.Name = NameTextBox.Text;
            Student.Surname = SurnameTextBox.Text;
            Student.Faculty = FacultyTextBox.Text;
            Student.IndexNumber = Convert.ToInt32(IndexTextBox.Text);
            DialogResult=true;
        }
    }
}
