using System.Text.RegularExpressions;
using System.Windows;

namespace Lab8.WpfApp
{
    /// <summary>
    /// Interaction logic for AddStudentWindow.xaml
    /// </summary>
    public partial class AddStudentWindow : Window
    {
        public Student Student { get; set; }
        public AddStudentWindow(Student student = null)
        {
            InitializeComponent();
            if (student != null)
            {
                TextBoxFaculty.Text = student.Faculty;
                TextBoxFirstName.Text = student.Firstname;
                TextBoxStudentNo.Text = student.StudentNo.ToString();
                TextBoxSurname.Text = student.Surname;
            }
            Student = student ?? new Student();
        }

        private void ButtonAddStudent_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(TextBoxFirstName.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(TextBoxSurname.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(TextBoxFaculty.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(TextBoxStudentNo.Text, @"^[0-9]{4,10}$"))
            {
                MessageBox.Show("Invalid input data.");
                return;
            }

            Student.Firstname = TextBoxFirstName.Text;
            Student.Surname = TextBoxSurname.Text;
            Student.Faculty = TextBoxFaculty.Text;

            if (!int.TryParse(TextBoxStudentNo.Text, out int studentNo))
                MessageBox.Show("Student is not a number.");

            Student.StudentNo = studentNo;
            DialogResult = true;
        }
    }
}
