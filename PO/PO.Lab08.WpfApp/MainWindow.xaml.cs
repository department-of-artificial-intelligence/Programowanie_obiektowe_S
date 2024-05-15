using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace PO.Lab08.WpfApp
{
    public class Student
    {
        public string _firstName = null!;
        public string _lastName = null!;
        public int _idNumber;
        public string _department = null!;
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int IdNumber { get => _idNumber; set => _idNumber = value; }
        public string Department { get => _department; set => _department = value; }
        public Student(string firstName, string lastName, int idNumber, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            IdNumber = idNumber;
            Department = department;
        }
        public Student()
        {

        }
    }

    public partial class MainWindow : Window
    {
        public IList<Student> Students { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Students = new List<Student>
            {
                new Student() {FirstName = "Jan", LastName = "Kowalski", IdNumber = 1010, Department = "WIMII"},
                new Student() {FirstName = "Jacek", LastName = "Makieta", IdNumber =  1012, Department = "WIMII"},
                new Student() {FirstName = "Michał", LastName = "Nowak", IdNumber = 1011, Department = "WIMII"}
            };
            DataStudents.Columns.Add(new DataGridTextColumn() { Header = "First Name", Binding = new Binding("FirstName") });
            DataStudents.Columns.Add(new DataGridTextColumn() { Header = "Last Name", Binding = new Binding("LastName") });
            DataStudents.Columns.Add(new DataGridTextColumn() { Header = "Department", Binding = new Binding("Department") });
            DataStudents.Columns.Add(new DataGridTextColumn() { Header = "Student No.", Binding = new Binding("IdNumber") });
            DataStudents.AutoGenerateColumns = false;
            DataStudents.ItemsSource = Students;
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button == AddButton)
                AddStudent();
            if (button == DeleteButton)
                DeleteStudent();
        }

        private void AddStudent()
        {
            ShowDialog();

        }

        private void DeleteStudent()
        {

        }
    }
}