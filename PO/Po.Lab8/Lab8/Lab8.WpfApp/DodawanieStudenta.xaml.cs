using Lab8.BLL;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Lab8.WpfApp
{
    public partial class DodawanieStudenta : Window
    {
        public IList<Student> Students { get; set; }
        public DodawanieStudenta()
        {
            InitializeComponent();

            Students = new List<Student>
            {
                new Student() {FirstName="Jan",SurName="Kowal",Faculty="WXW",StudentNo=1 },
                new Student() {FirstName="Anna",SurName="Nowak",Faculty="WXW",StudentNo=2 },
            };
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "First name", Binding = new Binding("FirstName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Sur name", Binding = new Binding("SurName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Faculty", Binding = new Binding("Faculty") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Student No.", Binding = new Binding("StudentNo") });
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;
        }
    }
}
