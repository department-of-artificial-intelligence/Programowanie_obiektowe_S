using System.Windows;

namespace Lab08.App
{
    /// <summary>
    /// Interaction logic for AddStudentWindow.xaml
    /// </summary>
    public partial class AddStudentWindow : Window
    {
        public Student Student { get; set; } = null;
        public event Func<Student> StudentCreated;
        public AddStudentWindow(Student student)
        {
            InitializeComponent();
            //Student = student;
            //if (Student != null)
            //{
            //    FirstNameTextBox.Text = student.FirstName;
            //    SurNameTextBox.Text = student.SurName;
            //    FacultyTextBox.Text = student.Faculty;
            //    StudentNoTextBox.Text = student.StudentNo.ToString();
            //}
            Student = student ?? new Student();
        }

        private void AddStudentBtn_Click(object sender, RoutedEventArgs e)
        {
            //var stringRegex = @"^\p{L}{1,12}$";
            //var intRegex = @"^[0-9]{4,10}$";
            //if (!Regex.IsMatch(FirstNameTextBox.Text, stringRegex) ||
            //    !Regex.IsMatch(SurNameTextBox.Text, stringRegex) ||
            //    !Regex.IsMatch(FacultyTextBox.Text, stringRegex) ||
            //    !Regex.IsMatch(StudentNoTextBox.Text, intRegex))
            //{
            //    MessageBox.Show("Invalid input");
            //    return;
            //}
            CopyFromTextBoxes();

            DialogResult = true;
        }

        private void CopyFromTextBoxes()
        {
            Student.FirstName = FirstNameTextBox.Text;
            Student.SurName = SurNameTextBox.Text;
            Student.Faculty = FacultyTextBox.Text;
            Student.StudentNo = Int32.Parse(StudentNoTextBox.Text);
        }
    }
}
