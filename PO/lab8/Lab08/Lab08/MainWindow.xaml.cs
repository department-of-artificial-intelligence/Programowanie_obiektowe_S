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
using Lab08.BLL;
using Lab08.WpfApp;

namespace Lab08
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
                new Student(){FirstName="Jan", LastName="Kowalski", Faculty="WIMII", StudentNumber=1010},
                new Student(){FirstName="Michał", LastName="Nowak", Faculty="WIMII", StudentNumber=1011},
                new Student(){FirstName="Jacek", LastName="Makieta", Faculty="WIMII", StudentNumber=1012},
            };
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "First name", Binding = new Binding(path: "FirstName") });
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Last name", Binding = new Binding(path: "LastName") });
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Faculty", Binding = new Binding(path: "Faculty") });
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Student No.", Binding = new Binding(path: "StudentNumber") });
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddStudentButton_Click(object sender, RoutedEventArgs e)
        {
            Add_student addStudentWindow = new Add_student();
            addStudentWindow.ShowDialog();
            Students.Add(new Student(addStudentWindow.Student.FirstName, addStudentWindow.Student.LastName, addStudentWindow.Student.Faculty, addStudentWindow.Student.StudentNumber));
            DataGridStudents.Items.Refresh();
        }

        private void DeleteStudentButton_Click(object sender, RoutedEventArgs e)
        {
            if(DataGridStudents.SelectedItem is Student studentToRemove)
            {
                Students.Remove(studentToRemove);
                DataGridStudents.Items.Refresh();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem is Student studentToAddGrade)
            {
                AddGradesWindow addGrade = new AddGradesWindow();
                addGrade.ShowDialog();
                studentToAddGrade.Grades.Add()
                DataGridStudents.Items.Refresh();
            }
        }
    }
}