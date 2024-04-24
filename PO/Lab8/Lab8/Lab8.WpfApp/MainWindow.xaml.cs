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
                new Student(){ FirstName = "Jan", SurName = "Kowalski", Faculty = "WIMII", StudentNo = 1010},
                new Student(){ FirstName = "Michal", SurName = "Nowak", Faculty = "WIMII", StudentNo = 1011},
                new Student(){ FirstName = "Jacek", SurName = "Makieta", Faculty = "WIMII", StudentNo = 1012},
            };
            DataGridStudent.Columns.Add(new DataGridTextColumn() { Header = "First Name", Binding = new Binding("FirstName") });
            DataGridStudent.Columns.Add(new DataGridTextColumn() { Header = "Sur Name", Binding = new Binding("SurName") });
            DataGridStudent.Columns.Add(new DataGridTextColumn() { Header = "Faculty", Binding = new Binding("Faculty") });
            DataGridStudent.Columns.Add(new DataGridTextColumn() { Header = "StudentNo", Binding = new Binding("StudentNo") });
            DataGridStudent.Columns.Add(new DataGridTextColumn() { Header = "Grades", Binding = new Binding("JoinedGrades") });
            DataGridStudent.AutoGenerateColumns = false;
            DataGridStudent.ItemsSource = Students;


        }

        private void Button_Add_Student_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow window = new AddStudentWindow();
            window.ShowDialog();

            DataGridStudent.Items.Refresh();
        }
    }
}