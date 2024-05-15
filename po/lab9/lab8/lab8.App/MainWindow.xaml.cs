using System.Security.Cryptography.X509Certificates;
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
using System.IO;
using Lab8.BLL;

namespace lab8.App
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
                new Student(){FirstName = "Jan", SurName = "Kowalski", Faculty = "WIMI", StudentNo = 1010},
                new Student(){FirstName = "Michal", SurName = "Nowak", Faculty = "WIMI", StudentNo = 1011},
                new Student(){FirstName = "Jacek", SurName = "Makieta", Faculty = "WIMI", StudentNo = 1012},
            };

            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "FirstName", Binding = new Binding(path: "FirstName") });
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "SurName", Binding = new Binding(path: "SurName") });
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Faculty", Binding = new Binding(path: "Faculty") });
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "StudentNo", Binding = new Binding(path: "StudentNo") });
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

        private void ButtonAddStudentWindowShow_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow asw = new AddStudentWindow();

            if (asw.ShowDialog().Value)
            {
                Students.Add(asw.Student);
                DataGridStudents.Items.Refresh();
            }
        }

        private void SaveToTxt_Click(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream("data.txt", FileMode.Create);
            StreamWriter sw = new  StreamWriter(fs);

            sw.WriteLine("[[Student]]");
            sw.Close();
        }
    }
}