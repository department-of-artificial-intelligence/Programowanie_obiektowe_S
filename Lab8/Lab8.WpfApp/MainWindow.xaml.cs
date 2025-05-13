using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

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
            { new Student(){FirstName="Jan", SurName="Kowalski", Faculty="WIMII", StudentNo=1010,JoinedGrades=JGrades(new List<Grade>{new Grade(3.5f,"PO"),new Grade(4.5f,"SO") })},
                new Student(){FirstName="Michał", SurName="Nowak", Faculty="WIMII", StudentNo=1011},
                new Student(){FirstName="Jacek", SurName="Makieta", Faculty="WIMII", StudentNo=1012},
            };

            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "First name", Binding = new Binding("FirstName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Sur name", Binding = new Binding("SurName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Faculty", Binding = new Binding("Faculty") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Student No.", Binding = new Binding("StudentNo") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Grades", Binding = new Binding("JoinedGrades") });
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;
        }

        private void AddStudentBTN(object sender, RoutedEventArgs e)
        {
            AddStudentWindow window = new AddStudentWindow();
            window.ShowDialog();
            if (window.DialogResult == true)
            {
                Students.Add(window.Student);
                DataGridStudents.Items.Refresh();
            }
        }

        private void DeleteStudentBTN(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem is Student studentToRemove)
            {
                Students.Remove(studentToRemove);
                DataGridStudents.Items.Refresh();
            }
        }
        private void AddGradeBTN(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem is Student student)
            {
                AddGradeWindow window = new AddGradeWindow(student);
                window.ShowDialog();
                if (window.DialogResult == true)
                {

                    DataGridStudents.Items.Refresh();
                }
            }
        }

        public string JGrades(List<Grade> grades)
        {
            string joinedgrades = "";
            foreach (var g in grades)
            {
                joinedgrades += g;
                joinedgrades += "; ";
            }
            return joinedgrades;
        }
    }
}