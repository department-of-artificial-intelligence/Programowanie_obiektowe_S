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
using Microsoft.Win32;
using System.Xml.Serialization;
using System.Text.Json;
using System.IO.Pipes;
namespace Lab8.WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IList<Student> Students { get; set; }
        public IList<Student> StudentsWithoutGrades { get; set; }
        public IList<Grade> Grades1 { get; set; }
       
        public MainWindow()
        {
            InitializeComponent();
            Grades1 = new List<Grade> { new Grade() { NameSubject = "Polski", GradeS = "3.5", Weight = 1 } };
            Students = new List<Student> {
                new Student() {FirstName="Jan", SurName="Kowalski",Faculty="WIMII",StudentNo=1010,/*Grades=new List<Grade>()*/
                    Grades=new List<Grade> { new Grade() { NameSubject = "Polski", GradeS = "3.5", Weight = 1 } } },
                new Student() {FirstName="Michał", SurName="Nowak",Faculty="WIMII",StudentNo=1011,Grades=new List<Grade>() },
                new Student() {FirstName="Jacek", SurName="Makieta",Faculty="WIMII",StudentNo=1012,Grades=new List<Grade>()},
                //new Student("Jan", "Kowalski","WIMII",1022,new List<Grade>()),
                //new Student("Michał","Nowak","WIMII",1011, new List<Grade>()),
                //new Student("Jacek", "Makieta","WIMII",1012,new List<Grade>())
            };
            StudentsWithoutGrades = new List<Student> {
                new Student() {FirstName="Jan", SurName="Kowalski",Faculty="WIMII",StudentNo=1010,/*Grades=new List<Grade>()*/
                    },
                new Student() {FirstName="Michał", SurName="Nowak",Faculty="WIMII",StudentNo=1011},
                new Student() {FirstName="Jacek", SurName="Makieta",Faculty="WIMII",StudentNo=1012},
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
            { Header = "Grade", Binding = new Binding("GradesString") });


            //ShowGrade.IsEnabled = false;

            DataGridStudents.AutoGenerateColumns = false;
            //DataGridStudents.ItemsSource = Grades1;
            DataGridStudents.ItemsSource = Students;
            //DataGridStudents.ItemsSource = (System.Collections.IEnumerable)Students.FirstOrDefault(a=>a.Grades==Grades1);
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
                    //ShowGrade.IsEnabled = true;
                    
                }
            }
        }

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow addStudentWindow = new AddStudentWindow();
            addStudentWindow.ShowDialog();
            if (addStudentWindow.Student1.FirstName != null)
            { 
                Students.Add(new Student(addStudentWindow.Student1.FirstName, addStudentWindow.Student1.SurName, addStudentWindow.Student1.Faculty, addStudentWindow.Student1.StudentNo));
                StudentsWithoutGrades.Add(new Student(addStudentWindow.Student1.FirstName, addStudentWindow.Student1.SurName, addStudentWindow.Student1.Faculty, addStudentWindow.Student1.StudentNo));
                
            DataGridStudents.Items.Refresh();
            }

            //addStudentWindow.DialogResult = true;
        }

        private void DeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem is Student studentToRemove)
            {
                Students.Remove(studentToRemove);
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
                
                //foreach (Student s in Students)
                //{
                //    MessageBox.Show(s.ToString());
                //}
                
            }
            DataGridStudents.Items.Refresh();
            
            
        }

        //private void ShowGrade_Click(object sender, RoutedEventArgs e)
        //{
        //    ShowGradeWindow a;
        //    //ShowGradeWindow a1 = new ShowGradeWindow();
        //    if (DataGridStudents.SelectedItem is Student student)
        //    {
        //            a = new ShowGradeWindow(student.Grades);
        //            a.ShowDialog();
        //    }
        //    
        //}

        private async void SaveToTxtFile_Click(object sender, RoutedEventArgs e)
        {
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            
            if (saveFileDialog.ShowDialog() == true)
            {
                using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                using (StreamWriter ws = new StreamWriter(fs))
                {

                    foreach (Student s in Students)
                    {
                        ws.WriteLine("[[Student]]");
                        ws.WriteLine("[Firstname]");
                        ws.WriteLine(s.FirstName);
                        ws.WriteLine("[Surname]");
                        ws.WriteLine(s.SurName);
                        ws.WriteLine("[StudentNo]");
                        ws.WriteLine(s.StudentNo);
                        ws.WriteLine("[Faculty]");
                        ws.WriteLine(s.Faculty);
                        ws.WriteLine("[[]]");
                    }
                    
                }
            }
            
            
           // try
           // {
           //     using (StreamWriter streamWriter = new StreamWriter("C:\\Users\\Admin\\Documents\\baza.txt"))
           //
           //         foreach (var student in StudentsWithoutGrades)
           //         {
           //             await streamWriter.Save(student);
           //         }
           //     MessageBox.Show("File saved successfully!");
           // }
           // catch (Exception ex)
           // { 
           //     MessageBox.Show(ex.Message);
           // }
        }

        private void SaveToXMLFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == true)
            {
                using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    var xmlSerializer = new XmlSerializer(typeof(List<Student>));
                    xmlSerializer.Serialize(fs, Students);
                }
            }
            
            
            //try
            //{
            //    using (StreamWriter streamWriter = new StreamWriter("C:\\Users\\Admin\\Documents\\baza.xml"))
            //        
            //             streamWriter.Save(StudentsWithoutGrades);
            //    MessageBox.Show("File saved successfully!");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void SaveToJSONFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if(saveFileDialog.ShowDialog() == true)
            {
                string jsonStr = JsonSerializer.Serialize(Students, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("C:\\Users\\Admin\\Documents\\baza.json", jsonStr);
            }
            
            //try
            //{
            //    using (StreamWriter streamWriter = new StreamWriter("C:\\Users\\Admin\\Documents\\baza.json"))
            //       
            //             streamWriter.Save(StudentsWithoutGrades);
            //    MessageBox.Show("File saved successfully!");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private async void LoadFromTxtFile_Click(object sender, RoutedEventArgs e)
        {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == true)
                {
                using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                using (StreamReader sr = new StreamReader(fs))
                {

                    List<Student> students = new List<Student>();
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        if (line == "[[Student]]")
                        {
                            Student student = new Student();
                            sr.ReadLine();
                            student.FirstName = sr.ReadLine();
                            sr.ReadLine();
                            student.SurName = sr.ReadLine();
                            sr.ReadLine();
                            int stN;
                            int.TryParse(sr.ReadLine(), out stN);
                            student.StudentNo = stN;
                            sr.ReadLine();
                            student.Faculty = sr.ReadLine();
                            sr.ReadLine();
                            students.Add(student);
                        }
                    }
                    Students = students;
                    DataGridStudents.ItemsSource = Students;
                    DataGridStudents.Items.Refresh();
                    MessageBox.Show("File loaded successfully!");

                }
                
            }
            
                
           

            
            //try
            //{
            //    using (StreamReader streamReader = new StreamReader("C:\\Users\\Admin\\Documents\\baza.txt"))
            //    {
            //        IList<Student> students = await streamReader.Load<List<Student>>();
            //        if (students != null)
            //            StudentsWithoutGrades = students;
            //    }
            //    DataGridStudents.ItemsSource = StudentsWithoutGrades;
            //    DataGridStudents.Items.Refresh();
            //    MessageBox.Show("File loaded successfully!");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error loading file: " + ex.Message);
            //}


        }

        private async void LoadFromXMLFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == true)
            {
                using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                using (StreamReader sr = new StreamReader(fs))
                {

                    var xmlSerializer = new XmlSerializer(typeof(List<Student>));
                    if (xmlSerializer.Deserialize(fs) is List<Student> students && students.Count > 0)
                    {
                        Students = students;
                        DataGridStudents.ItemsSource = Students;
                        DataGridStudents.Items.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("error");
                    }
                }
            }
            
            
            //try
            //{
            //    using (StreamReader streamReader = new StreamReader("C:\\Users\\Admin\\Documents\\baza.xml"))
            //    {
            //        IList<Student> students = await streamReader.Load<List<Student>>();
            //        if (students != null)
            //            StudentsWithoutGrades = students;
            //    }
            //    DataGridStudents.ItemsSource = StudentsWithoutGrades;
            //    DataGridStudents.Items.Refresh();
            //    MessageBox.Show("File loaded successfully!");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error loading file: " + ex.Message);
            //}
        }

        private async void LoadFromJSONFile_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read)) 
                    using (StreamReader rs = new StreamReader(fs))
                    {
                        var studentEnumerable = new StreamEnumerable<Student>(rs);
                        using var enumerator = studentEnumerable.GetEnumerator();
                        if (enumerator.MoveNext())
                        {
                            Students.Add(enumerator.Current);
                           // DataGridStudents.ItemsSource = null;
                            DataGridStudents.ItemsSource = Students;
                            DataGridStudents.Items.Refresh();
                        }
                        else { 
                        MessageBox.Show("error"); }
                        }
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading files: " + ex.Message);
                }
                
            }
            

            //try
            //{
            //    using (StreamReader streamReader = new StreamReader("C:\\Users\\Admin\\Documents\\baza.json"))
            //    {
            //        IList<Student> students = await streamReader.Load<List<Student>>();
            //        if (students != null)
            //            StudentsWithoutGrades = students;
            //    }
            //    DataGridStudents.ItemsSource = StudentsWithoutGrades;
            //    DataGridStudents.Items.Refresh();
            //    MessageBox.Show("File loaded successfully!");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error loading file: " + ex.Message);
            //}
        }

        private void LoadAnotherStudent_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
