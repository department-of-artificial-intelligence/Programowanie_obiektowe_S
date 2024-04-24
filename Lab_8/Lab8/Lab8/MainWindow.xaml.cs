using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Lab8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IList<Student> Students { get; set; }

        public MainWindow()
        {



            InitializeComponent();

            Students = new List<Student>
            {
                new Student() {FirstName="Jan",SurName="Kowal",Faculty="WXW",StudentNo=1 },
                new Student() {FirstName="Anna",SurName="Nowak",Faculty="WXW",StudentNo=2 },
                new Student() {FirstName="Olga", SurName="Lavrenchuk", Faculty="Eng", StudentNo=3 }
            };
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "First name", Binding = new Binding("FirstName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Sur name", Binding = new Binding("SurName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Faculty", Binding = new Binding("Faculty") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Student No.", Binding = new Binding("StudentNo") });
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {



        }
    }
}