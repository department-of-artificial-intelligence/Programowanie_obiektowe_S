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

namespace Lab11.WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Students = new List<Student>
            {
                new Student(){Firstname = "Jan", Surname = "Kowalski", Faculty = "WIiSI", StudentNo = 1010},
                new Student(){Firstname = "Michał", Surname = "Nowak", Faculty = "WIiSI", StudentNo = 1011},
                new Student(){Firstname = "Jacek", Surname = "Makieta", Faculty = "WIiSI", StudentNo = 1012},
            };

            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Firstname", Binding = new Binding("Firstname") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Surname", Binding = new Binding("Surname") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Faculty", Binding = new Binding("Faculty") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Student No.", Binding = new Binding("StudentNo") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Grades", Binding = new Binding("JoinedGrades") });
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;
        }
        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            // Tworzymy okno dla nowego studenta
            AddStudentWindow addWindow = new AddStudentWindow(null); // null wskazuje na nowego studenta
            if (addWindow.ShowDialog() == true)
            {
                // Po zapisaniu studenta w oknie edycji, dodajemy go do listy
                Students.Add(addWindow.Student);  // Zamiast addWindow.EditedStudent, używamy addWindow.Student

                // Odświeżamy DataGrid
                DataGridStudents.Items.Refresh();
            }
        }

        private void EditStudent_Click(object sender, RoutedEventArgs e)
        {
            // Jeśli żaden student nie jest zaznaczony w DataGrid
            if (selectedStudent == null)
            {
                MessageBox.Show("Please select a student to edit.");
                return;
            }

            // Tworzymy okno edycji studenta, przekazując zaznaczonego studenta
            EditStudentWindow editWindow = new EditStudentWindow(selectedStudent);
            if (editWindow.ShowDialog() == true)
            {
                // Zaktualizowany student (dzięki przypisaniu w EditStudentWindow)
                // Odświeżamy widok DataGrid
                DataGridStudents.Items.Refresh();
            }
        }

        private void ButtonRemoveStudentWindowShow_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem is Student studentToRemove)
            {
                Students.Remove(studentToRemove);
                DataGridStudents.Items.Refresh();
            }
        }

        private void DataGridStudents_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (DataGridStudents.SelectedItem != null)
            {
                // Pobieramy wybranego studenta
                Student selectedStudent = DataGridStudents.SelectedItem as Student;

                if (selectedStudent != null)
                {
                    // Ustawiamy DataGridGrades na listę ocen wybranego studenta
                    DataGridGrades.ItemsSource = selectedStudent.Grades;
                    DataGridGrades.Items.Refresh();
                }
            }
        }
        private void AddGrade_Click(object sender, RoutedEventArgs e)
        {
            // Sprawdzamy, czy wybrano studenta
            if (DataGridStudents.SelectedItem == null)
            {
                MessageBox.Show("Please select a student first.");
                return;
            }

            // Pobieramy wybranego studenta
            Student selectedStudent = DataGridStudents.SelectedItem as Student;

            // Otwieramy okno do dodania oceny
            AddGradeWindow addGradeWindow = new AddGradeWindow();
            if (addGradeWindow.ShowDialog() == true)
            {
                // Dodajemy nową ocenę do listy ocen studenta
                selectedStudent.AddGrade(addGradeWindow.NewGrade);

                // Odświeżamy DataGrid ocen
                DataGridGrades.ItemsSource = null; // Resetujemy ItemsSource
                DataGridGrades.ItemsSource = selectedStudent.Grades; // Ustawiamy zaktualizowaną listę
                DataGridGrades.Items.Refresh(); // Odświeżamy widok

                // Informujemy o sukcesie
                MessageBox.Show("Grade added successfully.");
            }
        }

        private void SaveFile_Click(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream("data.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            foreach (Student s in Students)
            {
                sw.WriteLine("[[Student]]");
                sw.WriteLine("[[Firstname]]");
                sw.WriteLine($"{s.Firstname}");
                sw.WriteLine("[Surname]");
                sw.WriteLine($"{s.Surname}");
                sw.WriteLine("[StudentNo]");
                sw.WriteLine($"{s.StudentNo}");
                sw.WriteLine("[Faculty]");
                sw.WriteLine($"{s.Faculty}");
                sw.WriteLine("[[]]");
            }

            sw.Close();

            MessageBox.Show("Data saved to the file successfully.");
        }

        private void LoadFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var loadedStudents = new List<Student>();

                using (StreamReader sr = new StreamReader("data.txt"))
                {
                    Student currentStudent = null;

                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        if (line == "[[Student]]")
                        {
                            currentStudent = new Student();
                        }
                        else if (line == "[[Firstname]]" && currentStudent != null)
                        {
                            currentStudent.Firstname = sr.ReadLine();
                        }
                        else if (line == "[Surname]" && currentStudent != null)
                        {
                            currentStudent.Surname = sr.ReadLine();
                        }
                        else if (line == "[StudentNo]" && currentStudent != null)
                        {
                            if (int.TryParse(sr.ReadLine(), out int studentNo))
                            {
                                currentStudent.StudentNo = studentNo;
                            }
                        }
                        else if (line == "[Faculty]" && currentStudent != null)
                        {
                            currentStudent.Faculty = sr.ReadLine();
                        }
                        else if (line == "[[]]" && currentStudent != null)
                        {
                            loadedStudents.Add(currentStudent);
                            currentStudent = null;
                        }
                    }
                }

                // Zastępujemy istniejącą listę nowymi studentami
                Students = loadedStudents;

                // Odświeżamy źródło danych DataGrid
                DataGridStudents.ItemsSource = null;
                DataGridStudents.ItemsSource = Students;
                DataGridStudents.Items.Refresh();

                MessageBox.Show("Data loaded successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the file:\n{ex.Message}");
            }
        }
    }
}