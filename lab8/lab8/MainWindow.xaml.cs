using lab8.bll;
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

namespace lab8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        new IList<Student> Students {  get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Students = new List<Student>
            {
                new Student(){FirstName = "Jan", LastName = "Kowalski", Faculty = "WISI", StudNo = 1},
                new Student(){FirstName = "Adam", LastName = "Kruk", Faculty = "WISI", StudNo = 2},
                new Student(){FirstName = "Jan", LastName = "Kula", Faculty = "WIMI", StudNo = 20},

            };
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "First Name", Binding = new Binding("FirstName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Last Name", Binding = new Binding("LastName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Faculty", Binding = new Binding("Faculty") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "StudNo", Binding = new Binding("StudNo") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Grades", Binding = new Binding("Grades") });
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void usun(object sender, RoutedEventArgs e)
        {
            if(DataGridStudents.SelectedItem is Student studToRemove)
            {
                Students.Remove(studToRemove);
                DataGridStudents.Items.Refresh();
            }
        }

        private void dodajStudenta(object sender, RoutedEventArgs e)
        {
            AddStudentWindow w1 = new AddStudentWindow();
            w1.ShowDialog();
            if(w1.DialogResult == true)
            {
                Students.Add(w1.Student);
                DataGridStudents.Items.Refresh();
            }

        }
    }
}