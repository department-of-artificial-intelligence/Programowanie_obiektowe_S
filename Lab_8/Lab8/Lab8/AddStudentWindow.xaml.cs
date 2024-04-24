using System.Windows;

namespace Lab8
{
    /// <summary>
    /// Interaction logic for AddStudentWindow.xaml
    /// 

    /// </summary>
    /// 



    public partial class AddStudentWindow : Window
    {

        public Student Student { get; set; }

        public AddStudentWindow(Student student = null)
        {
            InitializeComponent();

            if (student != null)
            {

                TextBoxFaculty.Text = student.Faculty;
                TextBoxFirstName.Text = student.FirstName;
                TextBoxStudentNo.Text = student.StudentNo.ToString();
                TextBoxSurName.Text = student.SurName;

            }

            Student = student ?? new Student();


        }

        private void CopyFormTextBoxes()
        {

            Student.FirstName = TextBoxFirstName.Text;
            Student.SurName = TextBoxSurName.Text;
            Student.Faculty = TextBoxFaculty.Text;
            Student.StudentNo = Int32.Parse(TextBoxStudentNo.Text);



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*
                        if (!Regex.IsMatch(input: TextBoxFirstName.Text) ||
                        !Regex.IsMatch(input: TextBoxSurName.Text) ||
                        !Regex.IsMatch(input: TextBoxFaculty.Text) ||
                        !Regex.IsMatch(input: TextBoxStudentNo.Text))
                        {



                        }
            */

            CopyFormTextBoxes();

            DialogResult = true;



        }
    }
}
