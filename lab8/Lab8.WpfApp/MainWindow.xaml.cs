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
using System.Collections.Generic;

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
            Students = new List<Student>
            {
                new Student(){FirstName = "Jan", Surname = "Kowalski", Faculty = "WIMII", StudentNo = 1010},
                new Student(){FirstName = "Michał", Surname = "Nowak", Faculty = "WIMII", StudentNo = 1011},
                new Student(){FirstName = "Jacek", Surname = "Makieta", Faculty = "WIMII", StudentNo = 1012}
            };

            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "First name", Binding = new Binding("FirstName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Surname", Binding = new Binding("Surname") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Faculty", Binding = new Binding("Faculty") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Student No.", Binding = new Binding("StudentNo") });
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;
        }

        private void ButtonAddStudent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonDeleteStudent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonAddGrade_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonLoadTxt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonSaveTxt_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}