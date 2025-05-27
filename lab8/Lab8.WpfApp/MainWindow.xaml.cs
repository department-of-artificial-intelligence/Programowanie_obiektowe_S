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
using Lab8.WpfApp;

namespace Lab8.WpfApp;

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
                new Student(){FirstName = "Jan", LastName = "Kowalski", Faculty = "WIMII", ID = 1010},
                new Student(){FirstName = "Michal", LastName = "Nowak", Faculty = "WIMII", ID = 1011},
                new Student(){FirstName = "Jacek", LastName = "Makieta", Faculty = "WIMII", ID = 1012},
            };
        StudentsGrid.Columns.Add(new DataGridTextColumn() { Header = "First name", Binding = new Binding("FirstName") });
        StudentsGrid.Columns.Add(new DataGridTextColumn() { Header = "Surname", Binding = new Binding("LastName") });
        StudentsGrid.Columns.Add(new DataGridTextColumn() { Header = "Faculty", Binding = new Binding("Faculty") });
        StudentsGrid.Columns.Add(new DataGridTextColumn() { Header = "Student No.", Binding = new Binding("ID") });
        StudentsGrid.Columns.Add(new DataGridTextColumn() { Header = "Grades", Binding = new Binding("JoinedGrades") { Converter = new GradeConverter() } });
        StudentsGrid.AutoGenerateColumns = false;
        StudentsGrid.ItemsSource = Students;
    }

    private void b0_Click(object sender, RoutedEventArgs e)
    {
        AddStudentWindow asw = new AddStudentWindow();
        asw.ShowDialog();
        if (asw.DialogResult == true)
        {
            Students.Add(asw.Student);
        }
        StudentsGrid.Items.Refresh();
    }

    private void b2_Click(object sender, RoutedEventArgs e)
    {
        if (StudentsGrid.SelectedItem is Student studentToRemove)
        {
            Students.Remove(studentToRemove);
            StudentsGrid.Items.Refresh();
        }
    }

    private void b3_Click(object sender, RoutedEventArgs e)
    {
        if (StudentsGrid.SelectedItem == null)
        {
            MessageBox.Show("Student not selected");
            return;
        }
        AddGradeWindow agw = new AddGradeWindow((Student)StudentsGrid.SelectedItem);
        agw.ShowDialog();
        if (agw.DialogResult == true)
        {
            Students.First(Student => Student.FirstName == agw.Student.FirstName).JoinedGrades = agw.Student.JoinedGrades;
        }
        StudentsGrid.Items.Refresh();
    }
}