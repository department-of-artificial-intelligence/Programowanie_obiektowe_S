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
using System.Windows.Markup.Localizer;

namespace lab8.WpfApp
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
                new Student() {FirstName = "Jan", SurName = "Kowalski", Faculty = "WIMII", StudentNo = 1010},
                new Student() {FirstName = "Michal", SurName = "Nowak", Faculty = "WIMII", StudentNo = 1011},
                new Student() {FirstName = "Jacek", SurName = "Makieta", Faculty = "WIMII", StudentNo = 1012},

            };
           DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "First Name", Binding = new Binding("FirstName") });
           DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Sur Name", Binding = new Binding("SurName") });
           DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Faculty", Binding = new Binding("Faculty") });
           DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Student No.", Binding = new Binding("StudentNo") });
           DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Grades", Binding = new Binding("Grades") });
           DataGridStudents.AutoGenerateColumns = false;
           DataGridStudents.ItemsSource = Students;

        }

      

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem is Student studentToRemove) {
                Students.Remove(studentToRemove);
                DataGridStudents.Items.Refresh();
            }
        

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow addStudentWindow = new AddStudentWindow();
            addStudentWindow.ShowDialog();
            if (addStudentWindow.DialogResult == true)
            {
                Students.Add(addStudentWindow.Student);
                DataGridStudents.Items.Refresh();
            }

        }

       

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream("data.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("[[Student]]");
            foreach (Student student in Students)
            {
                sw.WriteLine("[[FirstName]]");
                sw.WriteLine(student.FirstName);
                sw.WriteLine("[[SurName]]");
                sw.WriteLine(student.SurName);
                sw.WriteLine("[[StudentNo]]");
                sw.WriteLine(student.StudentNo);
                sw.WriteLine("[[Faculty]]");
                sw.WriteLine(student.Faculty);
                sw.WriteLine("[[]]");
            }
           
            sw.Close();
        }

        private void loadxml_Click(object sender, RoutedEventArgs e)
        {
             
            FileStream ls = new FileStream("data.txt", FileMode.Open);
            StreamReader sr = new StreamReader(ls);
            Students = new List<Student> ();

            while (!sr.EndOfStream){
                var ln = sr.ReadLine();
               // Console.WriteLine(ln);
              // switch (ln)
             //   {
                //    case FirstName;
                //            
                //        break;

              //  }

            }
        }

        

        

        
    }
}