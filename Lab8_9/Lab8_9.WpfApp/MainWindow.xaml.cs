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

namespace Lab8_9.WpfApp;

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
            new Student { FirstName = "Bob", SurName = "Bobert", Faculty = "Engineering", StudentNo = 1010},
            new Student { FirstName = "Alice", SurName = "Alison", Faculty = "Arts", StudentNo = 2020},
            new Student { FirstName = "Charlie", SurName = "Chaplin", Faculty = "Science", StudentNo = 3030},
        };
        DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "First Name", Binding = new Binding("FirstName") });
        DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Surename", Binding = new Binding("SurName") });
        DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Faculty", Binding = new Binding("Faculty") });
        DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Student No", Binding = new Binding("StudentNo") });
        DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Grade", Binding = new Binding("JoinedGrades") });
        DataGridStudents.AutoGenerateColumns = false;
        DataGridStudents.ItemsSource = Students;
    }

    private void ButtonAdd(object sender, RoutedEventArgs e)
    {
        Window1 window1 = new Window1();
        window1.ShowDialog();
        if (!(window1.DialogResult ?? false)) return;

        Students.Add(window1.Student);
        DataGridStudents.Items.Refresh();
    }

    private void ButtonDel(object sender, RoutedEventArgs e)
    {
        if(DataGridStudents.SelectedItem is Student studentToRemove)
        {
            Students.Remove(studentToRemove);
            DataGridStudents.Items.Refresh();
            return;
        }
    }
}