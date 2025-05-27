using Lab8.BLL;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Serialization;

namespace Lab8.WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public IList<Student> Students { get; set; }
        //private Student selectedStudent;
        public MainWindow()
        {
            InitializeComponent();

            Students = new List<Student>
            {
                new Student(){FirstName = "Jan", Surname = "Kowalski", Faculty = "WIiSI", StudentNo = 1010},
                new Student(){FirstName = "Michał", Surname = "Nowak", Faculty = "WIiSI", StudentNo = 1011},
                new Student(){FirstName = "Jacek", Surname = "Makieta", Faculty = "WIiSI", StudentNo = 1012},
            };

            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "First name", Binding = new Binding("FirstName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Surname", Binding = new Binding("Surname") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Faculty", Binding = new Binding("Faculty") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Student No.", Binding = new Binding("StudentNo") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Grades", Binding = new Binding("Grades") { Mode = BindingMode.TwoWay, Converter = new GradesConverter() } }); 
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;


        }

        private void ButtonAddStudent_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow addStudentWindow = new AddStudentWindow();
            addStudentWindow.ShowDialog();

            if (!(addStudentWindow.DialogResult ?? false)) return;

            Students.Add(addStudentWindow.Student);
            DataGridStudents.Items.Refresh();
            return;
        }

        private void ButtonDeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem is Student studentToRemove)
            {
                Students.Remove(studentToRemove);
                DataGridStudents.Items.Refresh();
                return;
            }
        }

        private void ButtonAddGrade_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem is Student studentToEdit)
            {
                AddGradeWindow addGradeWindow = new AddGradeWindow();
                addGradeWindow.ShowDialog();
                if (!(addGradeWindow.DialogResult ?? false)) return;
                studentToEdit.Grades.Add(addGradeWindow.Grade);
                DataGridStudents.Items.Refresh();
                return;
            }
        }
    }
}