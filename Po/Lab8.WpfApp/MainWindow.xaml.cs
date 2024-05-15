using System.Security.Claims;
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
namespace Lab8.WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IList<Student> Students { get; set; }
        public IList<Grade> Grades1 { get; set; }
       
        public MainWindow()
        {
            InitializeComponent();
            Grades1 = new List<Grade> { new Grade() { NameSubject = "Polski", GradeS = 3.5, Weight = 1 } };
            Students = new List<Student> {
                new Student() {FirstName="Jan", SurName="Kowalski",Faculty="WIMII",StudentNo=1010,Grades=new List<Grade>() },
                new Student() {FirstName="Michał", SurName="Nowak",Faculty="WIMII",StudentNo=1011,Grades=new List<Grade>() },
                new Student() {FirstName="Jacek", SurName="Makieta",Faculty="WIMII",StudentNo=1012,Grades=new List<Grade>()},
                //new Student("Jan", "Kowalski","WIMII",1022,new List<Grade>()),
                //new Student("Michał","Nowak","WIMII",1011, new List<Grade>()),
                //new Student("Jacek", "Makieta","WIMII",1012,new List<Grade>())
            };
            DataGridStudents.Columns.Add(new DataGridTextColumn()
            { Header = "First Name", Binding = new Binding("FirstName") });
            
            DataGridStudents.Columns.Add(new DataGridTextColumn()
            { Header = "Sur Name", Binding = new Binding("SurName") });

            DataGridStudents.Columns.Add(new DataGridTextColumn()
            { Header = "Faculty", Binding = new Binding("Faculty") });

            DataGridStudents.Columns.Add(new DataGridTextColumn()
            { Header = "Student No.", Binding = new Binding("StudentNo") });

            DataGridStudents.Columns.Add(new DataGridTextColumn()
            { Header = "Name Subject", Binding = new Binding("Grades.NameSubject") });
            
            DataGridStudents.Columns.Add(new DataGridTextColumn()
            { Header = "Weight", Binding = new Binding("Grades.Weight") });
            
            DataGridStudents.Columns.Add(new DataGridTextColumn()
            { Header = "Grade", Binding = new Binding("Grades.GradeS") });


            ShowGrade.IsEnabled = false;

            DataGridStudents.AutoGenerateColumns = false;
            //DataGridStudents.ItemsSource = Grades1;
            DataGridStudents.ItemsSource = Students;
            //ShowGradeWindow j = new ShowGradeWindow();
            //j.DataGridShowsGrade.ItemsSource = Students;

            

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowGradeWindow a;
            if (DataGridStudents.SelectedItem is Student student)
            {
                if (student != null)
                {
                    
                    ShowGrade.IsEnabled = true;
                }
            }
        }

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow addStudentWindow = new AddStudentWindow();
            addStudentWindow.ShowDialog();
            Students.Add(new Student(addStudentWindow.Student1.FirstName, addStudentWindow.Student1.SurName, addStudentWindow.Student1.Faculty, addStudentWindow.Student1.StudentNo));
            DataGridStudents.Items.Refresh();

            //addStudentWindow.DialogResult = true;
        }

        private void DeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem is Student studentToRemove)
            {
                Students.Remove(studentToRemove);
                DataGridStudents.Items.Refresh();
            }
        }

        private void AddGrade_Click(object sender, RoutedEventArgs e)
        {
            AddGradeWindow a = new AddGradeWindow();
            //ShowGradeWindow b;
            a.ShowDialog();
            if (DataGridStudents.SelectedItem is Student student)
            {
                student.Grades.Add(a.grades);
                foreach (Student s in Students)
                {
                    MessageBox.Show(s.ToString());
                }
                
                DataGridStudents.Items.Refresh();
            }
            
        }

        private void ShowGrade_Click(object sender, RoutedEventArgs e)
        {
            ShowGradeWindow a;
            //ShowGradeWindow a1 = new ShowGradeWindow();
            if (DataGridStudents.SelectedItem is Student student)
            {
                    a = new ShowGradeWindow(student.Grades);
                    a.ShowDialog();
            }
            
        }

        private void SaveToTxtFile_Click(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream("baza.txt",FileMode.Create);
            StreamWriter sw =new StreamWriter(fs);
            sw.WriteLine("[[Student]]");
            sw.Close();
        }
    }
}
