using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfLab8.APP;
using WpfLab8.BLL;

namespace WpfLab8
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
                new Student(){FirstName="Jan",LastName="Kowalski", Faculty="WIMII", StudentNo=1010},
                new Student(){FirstName="Michal",LastName="Nowak", Faculty="WIMII", StudentNo=1011},
                new Student(){FirstName="Jacek",LastName="Makieta", Faculty="WIMII", StudentNo=1012},
            };
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "First name", Binding = new Binding("FirstName")});
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Last name", Binding = new Binding("LastName")});
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Faculty", Binding = new Binding("Faculty")});
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Student No.", Binding = new Binding("StudentNo")});
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;
        }
        public void ButtonDel_Click(object sender, RoutedEventArgs e)
        {
            if(DataGridStudents.SelectedItem is Student studentToRemove)
            {
                Students.Remove(studentToRemove);
                DataGridStudents.Items.Refresh();
            }
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow addStudentWindow = new AddStudentWindow();
            if (addStudentWindow.ShowDialog() ?? false)
            {
                Students.Add(addStudentWindow.students);
                DataGridStudents.Items.Refresh();
            }
        }
    }
}