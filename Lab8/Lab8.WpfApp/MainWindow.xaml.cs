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
            //DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "First name", Binding = new Binding(path: "FirstName") });
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}