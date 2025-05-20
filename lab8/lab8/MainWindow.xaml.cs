using lab8.bll;
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
using System.Xml.Serialization;
using System.Text.Json;

namespace lab8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        new IList<Student> Students {  get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Students = new List<Student>
            {
                new Student(){FirstName = "Jan", LastName = "Kowalski", Faculty = "WISI", StudNo = 1},
                new Student(){FirstName = "Adam", LastName = "Kruk", Faculty = "WISI", StudNo = 2},
                new Student(){FirstName = "Jan", LastName = "Kula", Faculty = "WIMI", StudNo = 20},

            };
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "First Name", Binding = new Binding("FirstName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Last Name", Binding = new Binding("LastName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Faculty", Binding = new Binding("Faculty") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "StudNo", Binding = new Binding("StudNo") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Grades", Binding = new Binding("Grades") });
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void usun(object sender, RoutedEventArgs e)
        {
            if(DataGridStudents.SelectedItem is Student studToRemove)
            {
                Students.Remove(studToRemove);
                DataGridStudents.Items.Refresh();
            }
        }

        private void dodajStudenta(object sender, RoutedEventArgs e)
        {
            AddStudentWindow w1 = new AddStudentWindow();
            w1.ShowDialog();
            if(w1.DialogResult == true)
            {
                Students.Add(w1.Student);
                DataGridStudents.Items.Refresh();
            }

        }

        private void DodajOcene(object sender, RoutedEventArgs e)
        {
            AddGrade g1 = new AddGrade();
            g1.ShowDialog();

            if(g1.DialogResult == true) 
            {
                //odwolac sie do grades
                DataGridStudents.Items.Refresh();
            }
        }

        private void zapiszDoTXT(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream("data.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            foreach(var student in Students)
            {
                string line = $"{student.FirstName};{student.LastName};{student.Faculty};{student.StudNo};{string.Join(",", student.Grades)}";
                sw.WriteLine(line);
            }

            sw.Close();
            fs.Close();

            MessageBox.Show("zapisano do pliku data.txt");

        }

        private void wczytajTXT(object sender, RoutedEventArgs e)
        {
            if (!File.Exists("data.txt"))
            {
                MessageBox.Show("brak takiego pliku!");
                return;

            }

            FileStream fs = new FileStream("data.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            var loadedStud = new List<Student>();

            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();
                var dane = line.Split(";");

                if(dane.Length >= 4)
                {
                    var stud = new Student
                    {
                        FirstName = dane[0],
                        LastName = dane[1],
                        Faculty = dane[2],
                        StudNo = int.Parse(dane[3]),
                        Grades = dane.Length > 4 && !string.IsNullOrWhiteSpace(dane[4])
                    ? dane[4].Split(',').Select(int.Parse).ToList()
                    : new List<int>()
                    };
                    loadedStud.Add(stud);
                }
            }
            sr.Close();
            fs.Close();

            Students = loadedStud;
            DataGridStudents.ItemsSource = Students;
            DataGridStudents.Items.Refresh();

            MessageBox.Show("Wczytano studentow z data.txt");
        }

        private void zapiszXML(object sender, RoutedEventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
            using (FileStream fs = new FileStream("data.xml", FileMode.Create))
            {
                serializer.Serialize(fs, Students.ToList());
            }

            MessageBox.Show("Zapisano do pliku xml");
        }

        private void ZaladujXML(object sender, RoutedEventArgs e)
        {
            if (!File.Exists("data.xml"))
            {
                MessageBox.Show("Brak pliku data.xml");
                return;
            }

            XmlSerializer serializer = new XmlSerializer (typeof(List<Student>));
            using (FileStream fs = new FileStream("data.xml", FileMode.Open))
            {
                Students = (List<Student>)serializer.Deserialize(fs);
            }
            DataGridStudents.ItemsSource = Students;
            DataGridStudents.Items.Refresh();
            MessageBox.Show("Wczytano studentów z data.xml");
        }

        private void DodajJSON(object sender, RoutedEventArgs e)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonStr = JsonSerializer.Serialize(Students.ToList(), options);
            File.WriteAllText("data.json", jsonStr);

            MessageBox.Show("Dodano do data.json");

        }

        private void ZaladujJSON(object sender, RoutedEventArgs e)
        {
            if (!File.Exists("data.json"))
            {
                MessageBox.Show("Nie ma takiego pliku");
                return;
            }

            string jsonStr = File.ReadAllText("data.json");
            var loadedStud = JsonSerializer.Deserialize<List<Student>>(jsonStr);

            Students = loadedStud;
            DataGridStudents.ItemsSource = Students;
            DataGridStudents.Items.Refresh();

            MessageBox.Show("Zaladowano do data.json");


        }

  
    }
}