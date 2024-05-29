using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfLab8.APP;
using WpfLab8.BLL;
using System.IO;

namespace WpfLab8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IList<Student> Students { get; set; }   
        public MainWindow()
        {
            Students = new List<Student>()
            {
                new Student(){FirstName="Jan",LastName="Kowalski", Faculty="WIMII", StudentNo=1010},
                new Student(){FirstName="Michal",LastName="Nowak", Faculty="WIMII", StudentNo=1011},
                new Student(){FirstName="Jacek",LastName="Makieta", Faculty="WIMII", StudentNo=1012},
            };
            foreach (var student in Students)
            {
                Random rnd = new Random();
                student.Grades.Add(Math.Truncate((rnd.NextDouble() * 4 + 1) * 10) / 10);
                student.Grades.Add(Math.Truncate((rnd.NextDouble() * 4 + 1) * 10) / 10);
                student.Grades.Add(Math.Truncate((rnd.NextDouble() * 4 + 1) * 10) / 10);
                student.Grades.Add(Math.Truncate((rnd.NextDouble() * 4 + 1) * 10) / 10);
            }
            /*DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "First name", Binding = new Binding("FirstName")});
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Last name", Binding = new Binding("LastName")});
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Faculty", Binding = new Binding("Faculty")});
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Student No.", Binding = new Binding("StudentNo")});
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Grades", Binding = new Binding("Grades")});
            DataGridStudents.AutoGenerateColumns = false;*/
            InitializeComponent();
            DataGridStudents.ItemsSource = Students;
        }
        public void ButtonDel_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem is Student std)
            {
                Students.Remove(std);
                DataGridStudents.Items.Refresh();
            }
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow addStudentWindow = new AddStudentWindow();
            if (addStudentWindow.ShowDialog() ?? false)
            {
                Students.Add(addStudentWindow.students);
                DataGridStudents.Items.Refresh();
            }
        }

        private void ButtonGrade_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem is Student std)
            {
                AddGradeWindow addGrade = new AddGradeWindow();
                addGrade.ShowDialog();
                std.Grades.Add(addGrade.Value);
                DataGridStudents.Items.Refresh();
            }
        }

        private void ButtonSaveTXT_Click(object sender, RoutedEventArgs e)
        {
            FileStream fs=new FileStream("data.txt",FileMode.Create);
            StreamWriter sw=new StreamWriter(fs);
            foreach(Student student in Students)
            {
                sw.WriteLine("[[Student]]");
                sw.WriteLine("[FirstName]");
                sw.WriteLine(student.FirstName);
                sw.WriteLine("[SurName]");
                sw.WriteLine(student.LastName);
                sw.WriteLine("[StudentNo]");
                sw.WriteLine(student.StudentNo);
                sw.WriteLine("[Faculty]");
                sw.WriteLine(student.Faculty);
                sw.WriteLine("[[]]");
            }
            sw.Close();
        }
    }
}