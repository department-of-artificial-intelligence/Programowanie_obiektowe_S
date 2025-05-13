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
        IList<Student> Students {  get; set; }
        AddStudentWindow Window { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Students = new List<Student>
            {
                new Student(){FirstName="Jan", SurName="Kowalski", Faculty="WIMII", StudentNo=1000},
                new Student(){FirstName="Anna", SurName="Kowalska", Faculty="WIMII", StudentNo=1001},
                new Student(){FirstName="Jan", SurName="Nowak", Faculty="WIMII", StudentNo=1002},
                new Student(){FirstName="Jana", SurName="Nowak", Faculty="WIMII", StudentNo=1003}
            };

            DataGridStudents.ItemsSource = Students;
            DataGridStudents.AutoGenerateColumns = true;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Window = new AddStudentWindow();
            if (Window.ShowDialog() ?? false) Students.Add(Window.Student);
            DataGridStudents.Items.Refresh();
        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if(DataGridStudents.SelectedItem is Student student)
            {
                Students.Remove(student);
                DataGridStudents.Items.Refresh();
            }
        }
    }
}