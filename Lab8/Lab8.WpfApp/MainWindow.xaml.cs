using Lab8.BLL;
using System.Net.WebSockets;
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
            Students = new List<Student> { 
                new Student(){ FirstName = "Jan", SurName = "Kowalski", Faculty = "WIMII", StudentNo =  1010},
                new Student(){ FirstName = "Michał", SurName = "Nowak", Faculty = "WIMII", StudentNo =  1011},
                new Student(){ FirstName = "Jacek", SurName = "Makieta", Faculty = "WIMII", StudentNo =  1012},
            };
			Student_Grid.AutoGenerateColumns = false;
            Student_Grid.ItemsSource = Students;
        }

        private void Delete_Student(object sender, RoutedEventArgs e)
        {
            if(Student_Grid.SelectedItem is Student studentToRemove)
            {
                Students.Remove(studentToRemove);
                Student_Grid.Items.Refresh();
            }
        }

        private void Add_Student(object sender, RoutedEventArgs e)
        {
            var student = new Student();
            var addWindow = new AddStudentWindow(student);
            if(addWindow.ShowDialog() == true)
            {
                Students.Add(student);
                Student_Grid.Items.Refresh();
            }
        }

		private void AddGrade_Student(object sender, RoutedEventArgs e)
		{
			var grade = new Grade();
			var addWindow = new AddGradeStudentWindow(grade);
			if (addWindow.ShowDialog() == true)
			{
				if (Student_Grid.SelectedItem is Student selectedStudent)
				{
					selectedStudent.Grades.Add(grade); 
					Student_Grid.Items.Refresh();
				}
			}
		}

        private void SaveToTxt_Click(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream("data.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            foreach(Student student in Students)
            {
                sw.WriteLine("[[Student]]");
                sw.WriteLine("[[FirstName]]");
                sw.WriteLine(student.FirstName);
                sw.WriteLine("[[LastName]]");
                sw.WriteLine(student.SurName);
                sw.WriteLine("[[StudentNo]]");
                sw.WriteLine(student.StudentNo);
                sw.WriteLine("[[Faculty]]");
                sw.WriteLine(student.Faculty);
                sw.WriteLine("[[Grades]]");
                foreach (Grade grade in student.Grades)
                {
                    sw.WriteLine("[[" + grade.Lesson + "]]");
                    sw.WriteLine(grade.Date);
                    sw.WriteLine(grade.Value);
                }
                sw.WriteLine("[[]]");
            }
            if (fs.CanWrite)
                MessageBox.Show("Txt file was succesfully saved");
            sw.Close();
        }
    }
}