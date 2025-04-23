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
    }
}