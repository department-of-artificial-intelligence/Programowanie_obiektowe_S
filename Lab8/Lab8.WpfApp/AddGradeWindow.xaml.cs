using System.Windows;

namespace Lab8.WpfApp
{
    /// <summary>
    /// Interaction logic for AddGradeWindow.xaml
    /// </summary>
    public partial class AddGradeWindow : Window
    {
        public Student Student { get; set; }
        public AddGradeWindow(Student student = null!)
        {
            InitializeComponent();

            Student = student ?? new Student();
        }

        private void AddGradeBTN(object sender, RoutedEventArgs e)
        {

            string temp = TextBoxSubjectValue.Text;
            if (!float.TryParse(TextBoxGradeValue.Text, out float value))
            {


            }
            else
            {
                Grade newgrade = new Grade(value, temp);
                Student.Grades?.Add(newgrade);
            }

            DialogResult = true;
        }
    }
}
