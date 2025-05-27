using Lab8.BLL;
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

namespace Lab8.WpfApp
{
    public partial class AddGradeWindow : Window
    {
        public Student Student { get; set; }
        public AddGradeWindow(Student? student = null)
        {
            InitializeComponent();
            Grades.Columns.Add(new DataGridTextColumn() { Header = "Subject", Binding = new Binding("Subject") });
            Grades.Columns.Add(new DataGridTextColumn() { Header = "Mark", Binding = new Binding("Mark") });
            Grades.AutoGenerateColumns = false;

            Grades.ItemsSource = student?.JoinedGrades ?? new List<Grade>();
            Student = student;
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            var subjectsColumn = new List<string>();
            var marksColumn = new List<float>();
            foreach (var item in Grades.ItemsSource)
            {
                try
                {
                    var value = item.GetType().GetProperty("Subject")?.GetValue(item).ToString().TrimEnd();
                    if (value.Contains(" "))
                    {
                        MessageBox.Show("Each subject should contain only a single word with no spaces");
                        continue;
                    }
                    subjectsColumn.Add(value);
                    float.TryParse(item.GetType().GetProperty("Mark")?.GetValue(item).ToString(), out float markValue);
                    marksColumn.Add(markValue);
                }
                catch { MessageBox.Show("Invalid data"); }
            }
            var gradesList = new List<Grade>();
            for (int i = 0; i < subjectsColumn.Count; i++)
            {
                gradesList.Add(new Grade(subjectsColumn[i], marksColumn[i]));
            }
            Student.JoinedGrades = gradesList;
            DialogResult = true;
        }


    }
}
