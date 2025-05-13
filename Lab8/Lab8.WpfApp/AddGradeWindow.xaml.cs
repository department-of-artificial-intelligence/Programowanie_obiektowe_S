using System.Windows;

namespace Lab8.WpfApp
{
    /// <summary>
    /// Interaction logic for AddGradeWindow.xaml
    /// </summary>
    public partial class AddGradeWindow : Window
    {
        public event Action<Grade> gradeAdded;
        public Grade Grade { get; set; }
        public AddGradeWindow(Grade grade = null)
        {
            InitializeComponent();
            if (grade != null)
            {
                TextBoxGrade.Text = grade.GradeValue.ToString();
            }
            Grade = grade;
        }

        private void ButtonAddGrade_Click(object sender, RoutedEventArgs e)
        {
            float.TryParse(TextBoxGrade.Text, out float gradeValue);
            Grade newGrade = new Grade(gradeValue);
            gradeAdded?.Invoke(newGrade);
            Close();
        }
    }
}
