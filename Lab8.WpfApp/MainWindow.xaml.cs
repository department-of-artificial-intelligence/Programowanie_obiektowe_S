using Lab8.BLL;
using System.IO;
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
using System.Xml;

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
                studentToEdit.Grades.Add(addGradeWindow.Grade);
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
                    sw.WriteLine("[" + property.Name + "]");
                    if (property.Name != "Grades") sw.WriteLine(property.GetValue(student));
                    else sw.WriteLine(student.WriteGrades());
                }
            }
            sw.Close();
            MessageBox.Show("Saved!");
        }

        private void ButtonLoadTxt_Click(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream("D:\\LocalAccounts\\Student\\Documents\\Jakub_Bytner\\Lab8.WpfApp\\data.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            //var properties = Students[0].GetType().GetProperties();

            while (!sr.EndOfStream)
            {
                var ln = sr.ReadLine();
                Student? student = null;
                if(ln == "[[Student]]")
                {
                    if (student != null) Students.Add(student);
                    student = new Student();
                } else if (ln.StartsWith("["))
                {
                    ln = ln.Substring(1, ln.Length-2);
                    MessageBox.Show(ln);
                    if (student.GetType().GetProperty(ln) != null)
                    {

                    }
                }
            }
        }
    }
}