using Lab8.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
                new Student(){FirstName =  "Jan",SurName = "Kowalski", Faculty = "WIMII", StudentNo = 1010 },
                new Student(){FirstName =  "Michal",SurName = "Nowak", Faculty = "WIMII", StudentNo = 1011 },
                new Student(){FirstName =  "Slavik",SurName = "Shevchenko", Faculty = "WIMII", StudentNo = 1012 },

            };
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "First name", Binding = new Binding("FirstName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Sur name", Binding = new Binding("SurName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Faculty", Binding = new Binding("Faculty") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Student NO", Binding = new Binding("StudentNo") });
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ButtonDialog_Click(object sender, RoutedEventArgs e)
        {
            WindowStudent windowStudent = new WindowStudent();
            windowStudent.ShowDialog();
            DataGridStudents.Items.Refresh();
        }
    }
}
