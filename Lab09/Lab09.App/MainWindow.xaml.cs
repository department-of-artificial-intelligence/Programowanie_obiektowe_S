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
using Lab09.App.PopUpWindows;
using Lab09.BLL;

namespace Lab09.App
{
    public partial class MainWindow : Window
    {
        protected IList<Student> Students;
        public MainWindow()
        {
            InitializeComponent();
            Students = new List<Student>() { 
                new Student("Vladyslav","Dzhuha",137000,"Software Engineering")
            };
            dataGrid1.Columns.Add(new DataGridTextColumn() { Header = "First name", Binding = new Binding("Name") });
            dataGrid1.Columns.Add(new DataGridTextColumn() { Header = "Last name", Binding = new Binding("Surname") });
            dataGrid1.Columns.Add(new DataGridTextColumn() { Header = "Faculty", Binding = new Binding("Faculty") });
            dataGrid1.Columns.Add(new DataGridTextColumn() { Header = "Student No.", Binding = new Binding("IndexNumber") });
            dataGrid1.AutoGenerateColumns = false;
            dataGrid1.ItemsSource = Students;
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            AddStudentWindow wind = new AddStudentWindow();
            if (wind.ShowDialog()??false)
            {
                Students.Add(wind.Student);
                dataGrid1.Items.Refresh();
            }
        }

        private void Button_Click_Remove(object sender, RoutedEventArgs e)
        {
            if(dataGrid1.SelectedItem is Student student)
            {
                Students.Remove(student);
                dataGrid1.Items.Refresh();
            }
        }
    }
}