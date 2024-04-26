using Lab8.BLL;
using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace Lab8.Wpfapp
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Student> Students {  get; set; } = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
            Students.Add(new Student() {FirstName="Jan",LastName="Kowalski", Faculty = "WIMiI",StudentNo=1010,Grades=new List<Grade> { new Grade(0, "Matematyka", 4), new Grade(1, "Informatyka", 5) } });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "First name", Binding = new Binding("FirstName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Sur name", Binding = new Binding("LastName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Faculty", Binding = new Binding("Faculty") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Id", Binding = new Binding("StudentNo") });
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;
        }

        private void DeleteStudentButton_Click(object sender, RoutedEventArgs e)
        {
            new DeleteStudentWindow(Students).ShowDialog();
            DataGridStudents.Items.Refresh();
        }

        private void AddStudentButton_Click(object sender, RoutedEventArgs e)
        {
            new StudentAddWindow(Students).ShowDialog();
            DataGridStudents.Items.Refresh();
        }

        private void SaveTxtButton_Click(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream("TxtSave.txt", FileMode.Create);
            var streamWriter = new StreamWriter(fs);
            Type objType = typeof(Student);
            foreach (var obj in Students)
            {
                
                streamWriter.WriteLine($"[[{objType.AssemblyQualifiedName}]]");
                foreach (var propertyInfo in objType.GetProperties())
                {
                    streamWriter.WriteLine($"[{propertyInfo.Name}]");
                    streamWriter.WriteLine(propertyInfo.GetValue(obj)?.ToString());

                }
                streamWriter.WriteLine("[[]]");
            }
            fs.Close();
        }
        private void SaveXmlButton_Click(object sender, RoutedEventArgs e)
        {
            using var fileStream = new FileStream("xmlSave.xml",FileMode.OpenOrCreate);
            var xmlSerializer = new XmlSerializer(typeof(List<Student>));
            xmlSerializer.Serialize(fileStream, Students);

        }

        private void SaveJsonButton_Click(object sender, RoutedEventArgs e)
        {
            string jsonStr = JsonSerializer.Serialize(Students, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("JsonSave.json", jsonStr);
        }

        private void LoadTxtButton_Click(object sender, RoutedEventArgs e)
        {
            using FileStream fs = new FileStream("TxtSave.txt", FileMode.Open);
            Students = new StreamReader(fs).Load<List<Student>>().Result;
            DataGridStudents.ItemsSource = Students;
            DataGridStudents.Items.Refresh();
        }

        private void LoadXmlButton_Click(object sender, RoutedEventArgs e)
        {
            using var fileStream = new FileStream("xmlSave.xml", FileMode.OpenOrCreate);
            var xmlSerializer = new XmlSerializer(typeof(List<Student>));
            if (xmlSerializer.Deserialize(fileStream) is List<Student> students && students.Count > 0)
            {
                Students = students;
                DataGridStudents.ItemsSource = Students;
                DataGridStudents.Items.Refresh();
            }

        }

        private void LoadJsonButton_Click(object sender, RoutedEventArgs e)
        {
            string jsonStr = File.ReadAllText("JsonSave.json");
            Students = JsonSerializer.Deserialize<List<Student>>(jsonStr);
            DataGridStudents.ItemsSource = Students;
            DataGridStudents.Items.Refresh();

        }
    }
}