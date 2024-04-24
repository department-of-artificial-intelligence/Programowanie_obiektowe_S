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

namespace Lab8.Wpfapp
{
    /// <summary>
    /// Interaction logic for StudentAddWindow.xaml
    /// </summary>
    public partial class StudentAddWindow : Window
    {
        IList<Student> Students {get; set;}
        public StudentAddWindow(IList<Student> students)
        {
            Students = students;
            InitializeComponent();
        }

        private void addStudentButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(nameInput.Text, @"^\p{L}{1,12}$"))
            {
                Output.Text = "Invalid first name!";
                return;
            }
            if (!Regex.IsMatch(surnameInput.Text, @"^\p{L}{1,12}$"))
            {
                Output.Text = "Invalid last name!";
                return;
            }
            if (!Regex.IsMatch(facultyInput.Text, @"^\p{L}{1,12}$"))
            {
                Output.Text = "Invalid faculty!";
                return;
            }
            if (!Regex.IsMatch(idInput.Text, @"^[0-9]{4,12}$"))
            {
                Output.Text = "Invalid id!";
                return;
            }
            var id = ulong.Parse(idInput.Text);
            if (Students.FirstOrDefault(x => (x.StudentNo == id)) != null)
            {
                Output.Text = "Id already in use!";
                return;
            }
            Students.Add( new Student(nameInput.Text, surnameInput.Text, id, facultyInput.Text));
            Output.Text = "Student added!";
            nameInput.Text = "";
            surnameInput.Text = "";
            facultyInput.Text = "";
            idInput.Text = "";
        }

        private void btnBackToMain_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
