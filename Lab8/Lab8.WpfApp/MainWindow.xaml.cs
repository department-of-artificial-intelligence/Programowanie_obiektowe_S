using Lab8.BLL;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.Generic;
namespace Lab8.WpfApp
{
    public partial class MainWindow : Window
    {
        public IList<Student> Students { get; set; }
        private Student selectedStudent;  
        public MainWindow()
        {
            InitializeComponent();
            Students = new List<Student>
            {
                new Student(){Firstname = "Jan", Surname = "Kowalski", Faculty = "WIiSI", StudentNo = 1010},
                new Student(){Firstname = "Michał", Surname = "Nowak", Faculty = "WIiSI", StudentNo = 1011},
                new Student(){Firstname = "Jacek", Surname = "Makieta", Faculty = "WIiSI", StudentNo = 1012},
            };
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Firstname", Binding = new Binding("Firstname") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Surname", Binding = new Binding("Surname") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Faculty", Binding = new Binding("Faculty") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Student No.", Binding = new Binding("StudentNo") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Grades", Binding = new Binding("JoinedGrades") });
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;
        }
        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow addWindow = new AddStudentWindow(null); 
            if (addWindow.ShowDialog() == true)
            {
                Students.Add(addWindow.Student);  
                DataGridStudents.Items.Refresh();
            }
        }
        private void EditStudent_Click(object sender, RoutedEventArgs e)
        {
            if (selectedStudent == null)
            {
                MessageBox.Show("Please select a student to edit.");
                return;
            }
            EditStudentWindow editWindow = new EditStudentWindow(selectedStudent);
            if (editWindow.ShowDialog() == true)
            {
                DataGridStudents.Items.Refresh();
            }
        }
        private void ButtonRemoveStudentWindowShow_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem is Student studentToRemove)
            {
                Students.Remove(studentToRemove);
                DataGridStudents.Items.Refresh();
            }
        }
        private void DataGridStudents_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (DataGridStudents.SelectedItem != null)
            {
                Student selectedStudent = DataGridStudents.SelectedItem as Student;
                DataGridGrades.ItemsSource = selectedStudent.Grades;
                DataGridGrades.Items.Refresh();
            }
        }
        private void AddGrade_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem == null)
            {
                MessageBox.Show("Please select a student first.");
                return;
            }
            Student selectedStudent = DataGridStudents.SelectedItem as Student;
            AddGradeWindow addGradeWindow = new AddGradeWindow();
            if (addGradeWindow.ShowDialog() == true)
            {
                selectedStudent.AddGrade(addGradeWindow.NewGrade);
                DataGridGrades.ItemsSource = null; 
                DataGridGrades.ItemsSource = selectedStudent.Grades; 
                DataGridGrades.Items.Refresh();
                MessageBox.Show("Grade added successfully.");
            }
        }
    }
}