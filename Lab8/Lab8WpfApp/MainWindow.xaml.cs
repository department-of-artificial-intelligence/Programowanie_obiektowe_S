using Lab8.BLL;
using Lab8.WpfApp;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab8WpfApp
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
            Students = new List<Student>()
            {
                new Student(){FirstName = "Jan", SurName = "Kowalski", Faculty = "WIMII", StudentNo = "1010"},
                new Student(){FirstName = "Michał", SurName = "Nowak", Faculty = "WIMII", StudentNo = "1011"},
                new Student(){FirstName = "Jacek", SurName = "Makieta", Faculty = "WIMII", StudentNo = "1012"},
            };
            DataGridStudents.Columns.Add(item:new DataGridTextColumn() { Header = "First name", Binding = new Binding(path:"FirstName") });
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Sur name", Binding = new Binding(path: "SurName") });
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Faculty", Binding = new Binding(path: "Faculty") });
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Student No.", Binding = new Binding(path: "StudentNo") });
            //DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Grades", Binding = new Binding(path: "JoinedGrades") });
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;
        }

        private void AddStudentMain_Click(object sender, RoutedEventArgs e)
        {
            /*if(!Regex.IsMatch(TextBoxFirstName.Text, @"^\p{L}{1,12}$") ||
               !Regex.IsMatch(input: TextBoxSurName.Text, pattern: @"^\p{L}{1,12}$") ||
               !Regex.IsMatch(input: TextBoxFaculty.Text, pattern: @"^\p{L}{1,12}$") ||
               !Regex.IsMatch(input: TextBoxStudentNo.Text, pattern: @"^\p{L}{1,12}$") ||)*/
    
            //ShowDialog(AddStudentWindow);
        }
    }
}