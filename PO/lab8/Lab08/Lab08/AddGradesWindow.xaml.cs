using Lab08.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab08.WpfApp
{
    /// <summary>
    /// Interaction logic for AddGradesWindow.xaml
    /// </summary>
    public partial class AddGradesWindow : Window
    {
        public Grade Grade { get; set; }
        public AddGradesWindow(Grade grade = null)
        {
            InitializeComponent();
            if (grade != null)
            {
                SubjectBox.Text = grade.Subject;
                GradeBox.Text = grade.Value.ToString();
                WeightBox.Text = grade.Weight.ToString();
                
            }
            Grade = grade ?? new Grade();
        }

        private void AddGradeButton_Click(object sender, RoutedEventArgs e)
        {
            Grade.Subject = SubjectBox.Text;
            Grade.Value = float.TryParse(GradeBox.Text);
            //Student.Faculty = FacultyBox.Text;
            //if (!int.TryParse(NumberBox.Text, out int StudentNumber))
            //    MessageBox.Show(messageBoxText: "Student is not a number");
            //Student.StudentNumber = StudentNumber;
            //DialogResult = true;
        }
    }
}
