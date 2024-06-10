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
    public partial class MainWindow : Window
    {
        public IList<Student> Students { get; set; }
        public IList<Grade> Grades { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Students = new List<Student>()
            {
                new Student(){FirstName = "Jan", SurName = "Kowalski", Faculty = "WIMII", StudentNo = 1010},
                new Student(){FirstName = "Michał", SurName = "Nowak", Faculty = "WIMII", StudentNo = 1011},
                new Student(){FirstName = "Jacek", SurName = "Makieta", Faculty = "WIMII", StudentNo = 1012}
            };
            Grades = new List<Grade>();
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "First name", Binding = new Binding(path: "FirstName"), IsReadOnly = true });
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Sur name", Binding = new Binding(path: "SurName"), IsReadOnly = true });
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Faculty", Binding = new Binding(path: "Faculty"), IsReadOnly = true });
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Student No.", Binding = new Binding(path: "StudentNo"), IsReadOnly = true });
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Grades", Binding = new Binding(path: "JoinedGrades"), IsReadOnly = true });
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;

        }
        private void BTN_Add_Student_Click(object sender, EventArgs e)
        {
            var addStudentWindow = new AddStudentWindow();
            if (addStudentWindow.ShowDialog() == true)
            {
                Students.Add(addStudentWindow.Student);
                DataGridStudents.Items.Refresh();
            }

        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            if (DataGridStudents.SelectedItem is Student studentToRemove)
            {
                Students.Remove(studentToRemove);
                DataGridStudents.Items.Refresh();
            }
        }

        private void BTN_Add_Grade_Click(object sender, RoutedEventArgs e)
        {
            var addGradeWindow = new AddGradeWindowxaml();
            if (DataGridStudents.SelectedItem is Student studentToAddGrade)
            {
                if (addGradeWindow.ShowDialog() == true)
                {
                    studentToAddGrade.Grades.Add(addGradeWindow.Grade);
                    DataGridStudents.Items.Refresh();
                }
            }

        }
    }
}
