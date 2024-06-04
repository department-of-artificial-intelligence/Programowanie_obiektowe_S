using System.Reflection.PortableExecutable;
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
    public partial class MainWindow : Window
    {
        public IList<Student> Students { get; set; }
        public object DataGridStudents { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            Students = new List<Student>();

            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "First name", Binding = new Binding(path: "FirstName") });
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Sur name", Binding = new Binding(path: "SurName") });
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Faculty", Binding = new Binding(path: "Faculty") });
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Student No.", Binding = new Binding(path: "StudentNo") });
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Grades", Binding = new Binding(path: "GradesString") });

            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public void AddStudentToList(Student student)
        {
            Students.Add(student);
        }
        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow addStudentWindow = new AddStudentWindow();
            addStudentWindow.ShowDialog();
            if (addStudentWindow.DialogResult == true)
            {
                Student student = addStudentWindow.Student;
                AddStudentToList(student);
                DataGridStudents.Items.Refresh();
            }
            else
            {
                MessageBox.Show(messageBoxText: "cannot add student");
            }
        }

        private void DeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem is Student studentToRemove)
            {
                Students.Remove(studentToRemove);
                DataGridStudents.Items.Refresh();
            }
        }

        private void ButtonAddGrade_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem != null)
            {
                Student selectedStudent = (Student)DataGridStudents.SelectedItem;
                AddGradeWindow addGradeWindow = new AddGradeWindow();
                addGradeWindow.ShowDialog();
                if (addGradeWindow.DialogResult == true)
                {
                    float value = float.Parse(addGradeWindow.outbox_value.Text);
                    string subject = addGradeWindow.outbox_subject.Text;

                    Grade newGrade = new Grade(value, subject);
                    selectedStudent.Grades.Add(newGrade);
                    DataGridStudents.Items.Refresh();
                }
            }
            else
            {
                MessageBox.Show(messageBoxText: "Error");
            }
        }

        private void SaveToTxtFile_Click(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream("data.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("[[Student]]");
            foreach (var student in Students)
            {
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

        private void LoadFromTxtFileButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("data.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line == "[[Student]]")
                        {
                            string firstName = "";
                            string surName = "";
                            string faculty = "";
                            int studentNo = 0;
                            List<Grade> grades = new List<Grade>();

                            while (true)
                            {
                                line = sr.ReadLine();
                                if (line == null || line == "[FirstName]") // Koniec pliku lub nowy student
                                {
                                    // Tworzymy nowego studenta i dodajemy go do listy Students
                                    Student newStudent = new Student(firstName, surName, faculty, studentNo);
                                    newStudent.Grades.AddRange(grades);
                                    Students.Add(newStudent);
                                    // Zerujemy zmienne dla nowego studenta
                                    firstName = "";
                                    surName = "";
                                    faculty = "";
                                    studentNo = 0;
                                    grades.Clear();

                                    if (line == null) // Koniec pliku
                                        break;
                                }
                                switch (line)
                                {
                                    case "[FirstName]":
                                        firstName = sr.ReadLine();
                                        break;
                                    case "[SurName]":
                                        surName = sr.ReadLine();
                                        break;
                                    case "[Faculty]":
                                        faculty = sr.ReadLine();
                                        break;
                                    case "[StudentNo]":
                                        int.TryParse(sr.ReadLine(), out studentNo);
                                        break;
                                    case "[[Grade]]":
                                        string subject = "";
                                        int value = 0;
                                        while ((line = sr.ReadLine()) != "[[]]")
                                        {
                                            switch (line)
                                            {
                                                case "[Subject]":
                                                    subject = sr.ReadLine();
                                                    break;
                                                case "[Value]":
                                                    int.TryParse(sr.ReadLine(), out value);
                                                    break;
                                            }
                                        }
                                        grades.Add(new Grade(value, subject));
                                        break;
                                }
                            }


                        }
                    }
                }

                // Odświeżamy widok DataGridStudents
                DataGridStudents.Items.Refresh();

                MessageBox.Show("Dane zostały wczytane poprawnie.", "Sukces", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Plik nie został znaleziony.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas wczytywania danych: {ex.Message}", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}