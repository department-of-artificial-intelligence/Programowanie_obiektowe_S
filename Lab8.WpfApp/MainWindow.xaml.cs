using Lab8.BLL;
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
using System.Xml;
using System.Xml.Serialization;

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
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Grades", Binding = new Binding("Grades") { Mode = BindingMode.TwoWay, Converter = new GradesConverter()}});
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;
            
        }

        private void ButtonAddStudent_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow addStudentWindow = new AddStudentWindow();
            addStudentWindow.ShowDialog();

            if (!(addStudentWindow.DialogResult ?? false)) return;
            
            Students.Add(addStudentWindow.Student);
            DataGridStudents.Items.Refresh();
            return;
        }

        private void ButtonDeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            if(DataGridStudents.SelectedItem is Student studentToRemove)
            {
                Students.Remove(studentToRemove);
                DataGridStudents.Items.Refresh();
                return;
            }
        }

        private void ButtonAddGrade_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem is Student studentToEdit)
            {
                AddGradeWindow addGradeWindow = new AddGradeWindow();
                addGradeWindow.ShowDialog();
                if (!(addGradeWindow.DialogResult ?? false)) return;
                //studentToEdit.Grades.Add(addGradeWindow.Grade);
                DataGridStudents.Items.Refresh();
                return;
            }
        }

        private void ButtonSaveTxt_Click(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream("D:\\LocalAccounts\\Student\\Documents\\Jakub_Bytner\\Lab8.WpfApp\\data.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            //sw.WriteLine("[[Student]]");
            var properties = Students[0].GetType().GetProperties();
            foreach (var student in Students)
            {
                sw.WriteLine("[[Student]]");
                foreach (var property in properties)
                {
                    
                    if (property.Name != "Grades")
                    {
                        sw.WriteLine("[" + property.Name + "]");
                        sw.WriteLine(property.GetValue(student));
                    } //else sw.WriteLine(student.WriteGrades());
                }
                sw.WriteLine("[[]]");
            }
            sw.Close();
            MessageBox.Show("Saved!");
        }

        private void ButtonLoadTxt_Click(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream("D:\\LocalAccounts\\Student\\Documents\\Jakub_Bytner\\Lab8.WpfApp\\data.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            //var properties = Students[0].GetType().GetProperties();
            Student? student = null;
            while (!sr.EndOfStream)
            {
                var ln = sr.ReadLine();

                switch (ln)
                {
                    case "[[Student]]":
                        student = new Student();
                        break;
                    case "[FirstName]":
                        student.FirstName = sr.ReadLine();
                        break;
                    case "[Surname]":
                        student.Surname = sr.ReadLine();
                        break;
                    case "[Faculty]":
                        student.Faculty = sr.ReadLine();
                        break;
                    case "[StudentNo]":
                        student.StudentNo = Int32.Parse(sr.ReadLine());
                        break;
                    case "[[]]":
                        if (student != null) Students.Add(student);
                        break;
                }

            }
            sr.Close();
            MessageBox.Show("Loaded!");
            DataGridStudents.Items.Refresh();
        }

        private void ButtonSaveTxt_Click2(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream("D:\\LocalAccounts\\Student\\Documents\\Jakub_Bytner\\Lab8.WpfApp\\data2.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            foreach(var student in Students) sw.Save(student);
            MessageBox.Show("Saved2!");
            sw.Close();
        }

        private void ButtonLoadTxt_Click2(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream("D:\\LocalAccounts\\Student\\Documents\\Jakub_Bytner\\Lab8.WpfApp\\data2.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                //Students.Add((Student)sr.Load<Student>());
                Students.Add(sr.Load<Student>().Result);
                
            }
            MessageBox.Show("Loaded2!");
            sr.Close();
            DataGridStudents.Items.Refresh();
        }

        private void ButtonSaveXML_Click(object sender, RoutedEventArgs e)
        {
            using var fileStream = new FileStream("D:\\LocalAccounts\\Student\\Documents\\Jakub_Bytner\\Lab8.WpfApp\\data.xml", FileMode.OpenOrCreate);
            var xmlSerializer = new XmlSerializer(typeof(List<Student>));
            xmlSerializer.Serialize(fileStream, Students);
            MessageBox.Show("Saved to XML!");

        }

        private void ButtonLoadXML_Click(object sender, RoutedEventArgs e)
        {
            using var fileStream = new FileStream("D:\\LocalAccounts\\Student\\Documents\\Jakub_Bytner\\Lab8.WpfApp\\data.xml", FileMode.OpenOrCreate);
            var xmlSerializer = new XmlSerializer(typeof(List<Student>));
            
            if(xmlSerializer.Deserialize(fileStream) is List<Student> students && students.Count > 0)
            {
                Students = students;
                DataGridStudents.ItemsSource = Students;
                DataGridStudents.Items.Refresh();
            }

            MessageBox.Show("Loaded from XML!");
        }

        private void ButtonSaveJSON_Click(object sender, RoutedEventArgs e)
        {
            string jsonStr = JsonSerializer.Serialize(Students, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("D:\\LocalAccounts\\Student\\Documents\\Jakub_Bytner\\Lab8.WpfApp\\data.json", jsonStr);
            MessageBox.Show("Saved To JSON!");
        }

        private void ButtonLoadJSON_Click(object sender, RoutedEventArgs e)
        {
            string jsonStr = File.ReadAllText("D:\\LocalAccounts\\Student\\Documents\\Jakub_Bytner\\Lab8.WpfApp\\data.json");
            Students = JsonSerializer.Deserialize<List<Student>>(jsonStr);
            DataGridStudents.ItemsSource = Students;
            DataGridStudents.Items.Refresh();
            MessageBox.Show("Loaded from JSON!");
        }
    }
}