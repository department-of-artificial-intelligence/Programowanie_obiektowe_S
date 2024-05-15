using System.Reflection.PortableExecutable;
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
using Lab8.BLL;
using System.IO;

namespace Lab8.WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IList<Student> Students { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Students = new List<Student>
            {
                new Student(){FirstName = "Jan", SurName = "Kowalski", Faculty = "WIMII", StudentNo = 123456},
                new Student(){FirstName = "Mikołaj", SurName = "Szczot", Faculty = "WIMII", StudentNo = 136660},
                new Student(){FirstName = "Bartłomiej", SurName = "Nowak", Faculty = "WZ", StudentNo = 365427},
                new Student(){FirstName = "Piotr", SurName = "Kowal", Faculty = "WE", StudentNo = 389438},
            };

            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "First name", Binding = new Binding(path: "FirstName") });
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Sur name", Binding = new Binding(path: "SurName") });
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Faculty", Binding = new Binding(path: "Faculty") });
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Student No.", Binding = new Binding(path: "StudentNo") });
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Subject", Binding = new Binding(path: "Grades.Subject") });
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Value", Binding = new Binding(path: "Grades.Value") });

            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public void AddStudentToList(Student student)
        {
            Students.Add(student);
        }
        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow addStudentWindow = new AddStudentWindow();
            addStudentWindow.ShowDialog();
            if(addStudentWindow.DialogResult == true)
            {
                Student student = addStudentWindow.Student;
                AddStudentToList(student);
                DataGridStudents.Items.Refresh();
            }
            else
            {
                MessageBox.Show(messageBoxText: "cannot add student");
            }
        }

        private void DeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            if(DataGridStudents.SelectedItem is Student studentToRemove)
            {
                Students.Remove(studentToRemove);
                DataGridStudents.Items.Refresh();
            }
        }

        private void ButtonAddGrade_Click(object sender, RoutedEventArgs e)
        {
            if(DataGridStudents.SelectedItem != null)
            {
                Student selectedStudent = (Student)DataGridStudents.SelectedItem;
                AddGradeWindow addGradeWindow = new AddGradeWindow();
                addGradeWindow.ShowDialog();
                if (addGradeWindow.DialogResult == true)
                {
                    float value = float.Parse(addGradeWindow.outbox_value.Text);
                    string subject = addGradeWindow.outbox_subject.Text;

                    Grade newGrade = new Grade(value, subject);
                    selectedStudent.Grades.Add(newGrade);
                    DataGridStudents.Items.Refresh();
                }
            }
            else
            {
                MessageBox.Show(messageBoxText: "Blad");
            }
        }

        private void SaveToTxtFile_Click(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream("data.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("[[Student]]");
            foreach(var student in Students)
            {
                sw.WriteLine("[FirstName]");
                sw.WriteLine(student.FirstName);
                sw.WriteLine("[SurName]");
                sw.WriteLine(student.SurName);
                sw.WriteLine("[StudentNo]");
                sw.WriteLine(student.StudentNo);
                sw.WriteLine("[Faculty]");
                sw.WriteLine(student.Faculty);
                sw.WriteLine("[[]]");
            }
            sw.Close();

        }
    }
}