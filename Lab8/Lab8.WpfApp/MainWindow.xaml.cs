using System.IO;
using System.Windows;

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
            Students = new List<Student>()
            {
                new Student(){ FirstName = "Jan", LastName = "Kowalski", NumerIndeksu = 1010, Department = "WISII", JoinedGrades = new List<Grade>{ new Grade(3.0f), new Grade(4.5f), new Grade(5.0f) }},
                new Student(){ FirstName = "Michal", LastName = "Nowak", NumerIndeksu = 1011, Department = "WISII", JoinedGrades = new List<Grade>{ new Grade(4.0f), new Grade(4.0f), new Grade(4.0f) }},
                new Student(){ FirstName = "Jacek", LastName = "Makieta", NumerIndeksu = 1012, Department = "WISII", JoinedGrades = new List<Grade>{ new Grade(3.0f), new Grade(3.5f), new Grade(3.0f) }}
            };
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;
        }

        private void ButtonRemoveStudentWindowShow_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem is Student studentToRemove)
            {
                Students.Remove(studentToRemove);
                DataGridStudents.Items.Refresh();
            }
        }

        private void ButtonAddGrade_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem is Student selectedStudent)
            {
                AddGradeWindow addGradeWindow = new AddGradeWindow();
                addGradeWindow.gradeAdded += (Grade grade) =>
                {
                    selectedStudent.JoinedGrades.Add(grade);
                    DataGridStudents.Items.Refresh();
                };
                addGradeWindow.Show();
            }
        }

        private void ButtonOpenDialogAddStudent_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow addStudentWindow = new AddStudentWindow();
            addStudentWindow.StudentAdded += (student) =>
            {
                Students.Add(student);
                DataGridStudents.Items.Refresh();
            };
            addStudentWindow.Show();
        }

        private void ButtonSaveDataToTxt_Click(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream("data.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("[[Student]]");
            sw.Close();
        }
    }
}