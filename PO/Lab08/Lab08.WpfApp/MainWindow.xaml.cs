using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lab08.DLL;

namespace Lab08.WpfApp
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
                new Student() { FirstName = "Adam", SurName = "Kowalski", Fauclty="WIMII", StudentNo = "1010"},
                new Student() { FirstName = "Jan", SurName = "Adamski", Fauclty="WIMII", StudentNo = "1011"}
            };

            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "First Name", Binding = new Binding("FirstName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Sur Name", Binding = new Binding("SurName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Fauclty", Binding = new Binding("Fauclty") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Number", Binding = new Binding("StudentNo") });
            //DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Sur Name", Binding = new Binding("Grades") });


            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;
        }

        private void AddStudentWindow_click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow asw = new AddStudentWindow();

            if (asw.ShowDialog().Value)
            {
                Students.Add(asw.Student);
                DataGridStudents.Items.Refresh();
            }
            
        }
        private void DelStudent_click(object sender, RoutedEventArgs e)
        {
            if(DataGridStudents.SelectedItem is Student studentToDel)
            {
                Students.Remove(studentToDel);
                DataGridStudents.Items.Refresh();
            }
        }
    }
}