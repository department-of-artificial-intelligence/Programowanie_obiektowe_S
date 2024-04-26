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
using Lab8.BLL;
using System.IO;
using System.Runtime.ExceptionServices;

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
                new Student(){ FirstName = "Jan", SurName = "Kowalski", Faculty = "WIMII", StudentNo = 1010, Grades = {5.0, 4.5, 3.0} },
                new Student(){ FirstName = "Michal", SurName = "Nowak", Faculty = "WIMII", StudentNo = 1011 , Grades = {2.0, 4.5, 3.0} },
                new Student(){ FirstName = "Jacek", SurName = "Makieta", Faculty = "WIMII", StudentNo = 1012 , Grades = {3.0, 4.5, 3.0}},
            };
           /* DataGridStudent.Columns.Add(new DataGridTextColumn() { Header = "First Name", Binding = new Binding("FirstName") });
            DataGridStudent.Columns.Add(new DataGridTextColumn() { Header = "Sur Name", Binding = new Binding("SurName") });
            DataGridStudent.Columns.Add(new DataGridTextColumn() { Header = "Faculty", Binding = new Binding("Faculty") });
            DataGridStudent.Columns.Add(new DataGridTextColumn() { Header = "StudentNo", Binding = new Binding("StudentNo") });
            DataGridStudent.Columns.Add(new DataGridTextColumn() { Header = "Grades", Binding = new Binding("JoinedGrades") });*/
            DataGridStudent.AutoGenerateColumns = true;
            DataGridStudent.ItemsSource = Students;


        }

        private void Button_Add_Student_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow window = new AddStudentWindow();
            if(window.ShowDialog() ?? false)
            {
                Students.Add(window.Student);
                DataGridStudent.Items.Refresh();
            }
        }

        private void Button_Delete_Student_Click(object sender, RoutedEventArgs e)
        {
            if(DataGridStudent.SelectedItem is Student stud)
            {
                Students.Remove(stud);
                DataGridStudent.Items.Refresh();
            }
        }

        private void Button_AddGrade_Click(object sender, RoutedEventArgs e)
        {
            if(DataGridStudent.SelectedItem is Student stud)
            {
                
                AddGrade addGrade = new AddGrade();
                addGrade.ShowDialog();
                stud.Grades.Add(addGrade.Value);
                DataGridStudent.Items.Refresh();

            }
        }

        private void Button_SaveTXT_Click(object sender, RoutedEventArgs e)
        {
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream("data.txt", FileMode.Create);
            StreamReader sr = new StreamReader(fs);
            Student student = new Student();
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                line = sr.ReadLine();
                line = sr.ReadLine();
                student.FirstName = line;
                line = sr.ReadLine();
                line = sr.ReadLine();
                student.SurName = line;
                line = sr.ReadLine();
                line = sr.ReadLine();
                student.StudentNo = int.Parse(line);
                line = sr.ReadLine();
                line = sr.ReadLine();
                student.Faculty = line;
            }
        }
    }
}