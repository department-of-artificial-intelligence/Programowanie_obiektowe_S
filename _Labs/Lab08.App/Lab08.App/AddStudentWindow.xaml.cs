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
            Student = student ?? new Student();
        }

        private void AddStudentBtn_Click(object sender, RoutedEventArgs e)
        {
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
