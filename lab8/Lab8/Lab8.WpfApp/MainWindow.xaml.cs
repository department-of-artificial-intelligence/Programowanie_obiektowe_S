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
        public IList<Student> Students { get; set; } // tutaj najedź na student i kliknij w lampkę, powiąż z Lab8.BLL
        public MainWindow()
        {
            InitializeComponent();
            Students = new List<Student>()
            {
                new Student(){ FirstName = "Jan", SurName = "Kowalski", Faculty = "WIMII", StudentNo = 1010},
                new Student(){ FirstName = "Jan", SurName = "Nowak", Faculty = "WIMII", StudentNo = 1011},
                new Student(){ FirstName = "Janina", SurName = "Makieta", Faculty = "WIMII", StudentNo = 1012},
            };
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "First name", Binding = new Binding("FirstName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Sur name", Binding = new Binding("SurName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Faculty", Binding = new Binding("Faculty") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Student No.", Binding = new Binding("StudentNo") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Grades", Binding = new Binding("JoinedGrades") });
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;
            
        }

        private void PrzyciskDodaj_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow addWindow = new AddStudentWindow();
            addWindow.ShowDialog();
            if (addWindow.DialogResult == true)
            {
                Students.Add(addWindow.Student);
                DataGridStudents.Items.Refresh();
            }
        }

        private void PrzyciskUsun_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem is Student studentToRemove)
            {
                Students.Remove(studentToRemove);
                DataGridStudents.Items.Refresh();
            }
        }
    }
}