using System.Text.RegularExpressions;
using System.Windows;

namespace Lab8.WpfApp
{
    /// <summary>
    /// Interaction logic for AddStudentWindow.xaml
    /// </summary>
    public partial class AddStudentWindow : Window
    {
        public event Action<Student> StudentAdded;
        public Student Student { get; set; }
        public AddStudentWindow(Student student = null)
        {
            InitializeComponent();
            if (student != null)
            {
                TextBoxDepartment.Text = student.Department;
                TextBoxNumerIndeksu.Text = student.NumerIndeksu.ToString();
                TextBoxLastName.Text = student.LastName;
                TextBoxFisrtName.Text = student.FirstName;
            }
            Student = student ?? new Student();
        }

        private void ButtonAddStudent_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(TextBoxFisrtName.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(TextBoxLastName.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(TextBoxDepartment.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(TextBoxNumerIndeksu.Text, @"^[0-9]{4,10}$"))
            {
                MessageBox.Show("Invalid input data");
                return;
            }
            Student.FirstName = TextBoxFisrtName.Text;
            Student.LastName = TextBoxLastName.Text;
            Student.Department = TextBoxDepartment.Text;
            if (!int.TryParse(TextBoxNumerIndeksu.Text, out int numerIndeksu))
                MessageBox.Show("Student is not a number");
            Student.NumerIndeksu = numerIndeksu;
            StudentAdded?.Invoke(Student);
            Close();
        }
    }
}
