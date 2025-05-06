using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

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
            Students = new List<Student>()
            {
                new Student(){ FirstName = "Jan", LastName = "Kowalski", NumerIndeksu = 1010, Department = "WISII"},
                new Student(){ FirstName = "Michal", LastName = "Nowak", NumerIndeksu = 1011, Department = "WISII"},
                new Student(){ FirstName = "Jacek", LastName = "Makieta", NumerIndeksu = 1012, Department = "WISII"}
            };
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "First name", Binding = new Binding("FirstName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Last name", Binding = new Binding("LastName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Numer Indeksu", Binding = new Binding("NumerIndeksu") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Department", Binding = new Binding("Department") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Grades", Binding = new Binding("JoinedGrades") });
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;
        }

        private void ButtonRemoveStudentWindowShow_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem is Student studentToRemove)
            {
                Students.Remove(studentToRemove);
                DataGridStudents.Items.Refresh();
            }
        }

        private void ButtonOpenDialogAddStudent_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow addStudentWindow = new AddStudentWindow();
            addStudentWindow.StudentAdded += (student) =>
            {
                Students.Add(student);
                DataGridStudents.Items.Refresh();
            };
            addStudentWindow.Show();
        }
    }
}