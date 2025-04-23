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
    public partial class MainWindow : Window
    {
        public IList<Student> Students { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Students = new List<Student>
            {
                new Student() {FirstName = "Jan", SurName = "Kowalski", Faculty = "WIMII", StudentNo = 1010},
                new Student() {FirstName = "Michał", SurName = "Nowak", Faculty = "WIMII", StudentNo = 1011},
                new Student() {FirstName = "Jacek", SurName = "Makieta", Faculty = "WIMII", StudentNo = 1012},
            };
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "First Name", Binding = new Binding(path: "FirstName") });
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Sur Name", Binding = new Binding(path: "SurName") });
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Faculty", Binding = new Binding(path: "Faculty") });
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "StudentNo", Binding = new Binding(path: "StudentNo") });
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;
        }
    }
}