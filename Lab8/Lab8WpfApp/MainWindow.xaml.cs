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

namespace Lab8WpfApp
{
    public partial class MainWindow : Window
    {
        public IList<Student> Students { get; set; }
       
        private void AddStudentClick(object sender, RoutedEventArgs e)
        {
            var addWindow = new AddStudentWindow();
            bool? result = addWindow.ShowDialog();

            if (result == true)
            {
                Students.Add(addWindow.Student);

                DataGridStudents.Items.Refresh();
            }
        }

        private void RemoveStudentClick(object sender, RoutedEventArgs e)
        {

            if(DataGridStudents.SelectedItem is Student studentToRemove)
            {
                Students.Remove(studentToRemove);
                DataGridStudents.Items.Refresh();
            }

        }
        public MainWindow()
        {
            InitializeComponent();
            Students = new List<Student>
            {
                new Student(){FirstName = "Jan", LastName = "Kowalski", Faculty = "WIISI", StudentNo = 1010},
                new Student(){FirstName = "Anna", LastName = "Nowak", Faculty = "WIMIR", StudentNo = 1011},
                new Student(){FirstName = "Piotr", LastName = "Zieliński", Faculty = "WIEIK", StudentNo = 1012},
                new Student(){FirstName = "Maria", LastName = "Wiśniewska", Faculty = "WIZ", StudentNo = 1013},
                new Student(){FirstName = "Tomasz", LastName = "Lewandowski", Faculty = "WIISI", StudentNo = 1014},
                new Student(){FirstName = "Katarzyna", LastName = "Mazur", Faculty = "WIMIR", StudentNo = 1015}
            };
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "First Name", Binding = new Binding("FirstName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Last Name", Binding = new Binding("LastName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Faculty", Binding = new Binding("Faculty") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "StudentsNo", Binding = new Binding("StudentNo") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Grades", Binding = new Binding("JoinedGrades") });
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;

        }


    }
}