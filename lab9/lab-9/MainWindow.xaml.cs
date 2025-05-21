using lab9klasy;
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


namespace lab_9

{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IList<Student> Students { get; set; } // tutaj najedź na student i kliknij w lampkę, powiąż z Lab8.BLL
        public MainWindow()
        {
            InitializeComponent();
            Students = new List<Student>()
            {
                new Student(){ FirstName = "Jan", SurName = "Kowalski", Faculty = "WIMII", StudentNo = 1010},
                new Student(){ FirstName = "Jan", SurName = "Nowak", Faculty = "WIMII", StudentNo = 1011},
                new Student(){ FirstName = "Janina", SurName = "Makieta", Faculty = "WIMII", StudentNo = 1012},
            };
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "First name", Binding = new Binding("FirstName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Sur name", Binding = new Binding("SurName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Faculty", Binding = new Binding("Faculty") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Student No.", Binding = new Binding("StudentNo") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Grades", Binding = new Binding("JoinedGrades") });
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;

        }

        private void PrzyciskDodaj_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow addWindow = new AddStudentWindow();
            addWindow.ShowDialog();
            if (addWindow.DialogResult == true)
            {
                Students.Add(addWindow.Student);
                DataGridStudents.Items.Refresh();
            }
        }

        private void PrzyciskUsun_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem is Student studentToRemove)
            {
                Students.Remove(studentToRemove);
                DataGridStudents.Items.Refresh();
            }
        }

        private void CloseStream_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveTxtButton_Click(object sender, RoutedEventArgs e)
        {
            SaveTxtButton.Content= "hej";
            FileStream fs = new FileStream("data.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            foreach (Student student in Students)
            {
                sw.WriteLine("[[Student]]");
                sw.WriteLine("[FirstName]");
                sw.WriteLine(student.FirstName);
                sw.WriteLine("[SurName]");
                sw.WriteLine(student.SurName);
                sw.WriteLine("[StudentNo]");
                sw.WriteLine(student.StudentNo);
                sw.WriteLine("[Faculty]");
                sw.WriteLine(student.Faculty);
                sw.WriteLine("[[]]");
            }
            sw.Close();

        }

        private void LoadTxtButton_Click(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream("data.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                var ln = sr.ReadLine();
            }
            sr.Close();
        }
    }
}