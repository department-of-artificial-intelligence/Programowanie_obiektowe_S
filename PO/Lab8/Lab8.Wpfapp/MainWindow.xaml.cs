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
            Students.Add(new Student() {FirstName="Jan",LastName="Kowalski", Faculty = "WIMiI",StudentNo=1010,Grades=new List<Grade> { new Grade(0, "Matematyka", 4), new Grade(1, "Informatyka", 5) } });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "First name", Binding = new Binding("FirstName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Sur name", Binding = new Binding("LastName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Faculty", Binding = new Binding("Faculty") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Id", Binding = new Binding("StudentNo") });
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;
        }

        private void DeleteStudentButton_Click(object sender, RoutedEventArgs e)
        {
            new DeleteStudentWindow(Students).ShowDialog();
            DataGridStudents.Items.Refresh();
        }

        private void AddStudentButton_Click(object sender, RoutedEventArgs e)
        {
            new StudentAddWindow(Students).ShowDialog();
            DataGridStudents.Items.Refresh();
        }
    }
}