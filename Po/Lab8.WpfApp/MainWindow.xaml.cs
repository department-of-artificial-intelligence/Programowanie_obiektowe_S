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
            Students = new List<Student> { 
                new Student(){ FirstName="Jan", SurName="Kowalski",Faculty="WIMII",StudentNo=1010},
                new Student(){ FirstName="Michał", SurName="Nowak",Faculty="WIMII",StudentNo=1011},
                new Student(){ FirstName="Jacek", SurName="Makieta",Faculty="WIMII",StudentNo=1012}
            };
            DataGridStudents.Columns.Add(new DataGridTextColumn()
            { Header = "First Name", Binding = new Binding("FirstName") });

            DataGridStudents.Columns.Add(new DataGridTextColumn()
            { Header = "Sur Name", Binding = new Binding("SurName") });

            DataGridStudents.Columns.Add(new DataGridTextColumn()
            { Header = "Faculty", Binding = new Binding("Faculty") });

            DataGridStudents.Columns.Add(new DataGridTextColumn()
            { Header = "Student No.", Binding = new Binding("StudentNo") });

            DataGridStudents.Columns.Add(new DataGridTextColumn()
            { Header = "Grades", Binding = new Binding("JoinedGrades") });

            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow addStudentWindow = new AddStudentWindow();
            addStudentWindow.ShowDialog();
            Students.Add(new Student(addStudentWindow.Student1.FirstName, addStudentWindow.Student1.SurName, addStudentWindow.Student1.Faculty, addStudentWindow.Student1.StudentNo));
            DataGridStudents.Items.Refresh();

            //addStudentWindow.DialogResult = true;
        }

        private void DeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem is Student studentToRemove)
            {
                Students.Remove(studentToRemove);
                DataGridStudents.Items.Refresh();
            }
        }

        private void AddGrade_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}