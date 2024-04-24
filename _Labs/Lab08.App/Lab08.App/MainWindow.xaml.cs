using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Lab08.App
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
                new Student("Jan", "Kowalski", "WIMII", 1010),
                new Student("Janion", "Kowal", "WIMII", 1011),
                new Student("Janus", "Kowalskwowsi", "WIMII", 1012),
            };
            var CreateCol = (string name) =>
            {
                return new DataGridTextColumn()
                { Header = name, Binding = new Binding(name) };
            };
            DataGridStudents.Columns.Add(CreateCol("FirstName"));
            DataGridStudents.Columns.Add(CreateCol("SurName"));
            DataGridStudents.Columns.Add(CreateCol("Faculty"));
            DataGridStudents.Columns.Add(CreateCol("StudentNo"));
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;
        }

        private void CreateBtn_Click(object sender, RoutedEventArgs e)
        {
            var student = new Student();
            var addWindow = new AddStudentWindow(student);
            if (addWindow.ShowDialog() == true)
            {
                Students.Add(student);
                DataGridStudents.Items.Refresh();
            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem is Student student)
            {
                Students.Remove(student);
                DataGridStudents.Items.Refresh();
            }
        }
    }
}