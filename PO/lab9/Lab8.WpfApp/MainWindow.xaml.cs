using lab8.BLL;
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
            new Student(){FirstName ="Jan", SurName = "Kowalski", Faculty = "WIMII", StudentNo = 1010},
            new Student(){FirstName ="Michał", SurName = "Nowak", Faculty = "WIMII", StudentNo=1011},
            new Student(){FirstName="Jacek", SurName = "Makieta", Faculty = "WIMII", StudentNo = 1012} 
            };
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "First name", Binding = new Binding("FirstName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Sur Name", Binding = new Binding("SurName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Faculty", Binding = new Binding("Faculty") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "StudentNo", Binding = new Binding("StudentNo") });
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource= Students;
        }

        private void ButtonRemoveStudent_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem is Student studentToRemove) 
            {
            Students.Remove(studentToRemove);
            DataGridStudents.Items.Refresh();
            }
        }

        

        private void AddStudentButton_Click(object sender, RoutedEventArgs e)
        {
            object student = DataGridStudents.SelectedItem;
            if (student != null)
            {
                AddStudentWindow asw = new AddStudentWindow();
                
                if (asw.ShowDialog().Value) 
                {
                    Students.Add(asw.Student);
                }
                DataGridStudents.Items.Refresh();



            }

        }

        private void SaveToTxt(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream("data.txt",FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("[[Student]]");
            sw.Close();
        }

        private void Close_Stream(object sender, RoutedEventArgs e)
        {

        }

        private void Load_from_txt_stream(object sender, RoutedEventArgs e)
        {

        }

        private void Save_to_XML(object sender, RoutedEventArgs e)
        {

        }
    }
}