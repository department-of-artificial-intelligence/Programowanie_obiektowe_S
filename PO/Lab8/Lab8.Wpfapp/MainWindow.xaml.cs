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

namespace Lab8.Wpfapp
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IList<Student> Students {  get; set; } = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
            Students.Add(new Student() {FirstName="Jan",LastName="Kowalski", Faculty = "WIMiI",StudentNo=1010 });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "First name", Binding = new Binding("FirstName") });
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;
        }

        private void DeleteStudentButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddStudentButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}