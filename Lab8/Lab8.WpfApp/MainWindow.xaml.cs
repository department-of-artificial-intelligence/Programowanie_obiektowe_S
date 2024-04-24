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
                new Student(){FirstName = "Jan", SurName = "Kowalski", Facility = "WIMII", StudentId = 1010},
                new Student(){FirstName = "Michal", SurName = "Nowak", Facility = "WIMII", StudentId = 1011},
                new Student(){FirstName = "Jacek", SurName = "Makieta", Facility = "WIMII", StudentId = 1012}
            };
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "First Name", Binding = new Binding("FirstName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Sur Name", Binding = new Binding("SurName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Facility", Binding = new Binding("Facility") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Id studenta", Binding = new Binding("StudentId") });
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;
        }

        private void add_st_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow window = new AddStudentWindow();  
            window.ShowDialog();
        }
    }
}