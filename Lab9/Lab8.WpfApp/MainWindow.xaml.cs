using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab9.WpfApp
{
    public partial class MainWindow : Window
    {
        public IList<Student> Students { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Students = new List<Student>()
            {
                new Student(){imie = "Jan", nazwisko = "Kowalski", wydzial = "WIMII", nrIndeksu = 1010},
                new Student(){imie = "Michał", nazwisko = "Nowak", wydzial = "WIMII", nrIndeksu = 1011},
                new Student(){imie = "Jacek", nazwisko = "Makieta", wydzial = "WIMII", nrIndeksu = 1012}
            };
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "imie", Binding = new Binding("imie") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "nazwisko", Binding = new Binding("nazwisko") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "wydział", Binding = new Binding("wydzial") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "nrIndeksu", Binding = new Binding("nrIndeksu") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "oceny", Binding = new Binding("scaloneOceny") });
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;

        }


        private void ButtonAddStudent_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow addStudentWindow = new AddStudentWindow();
            addStudentWindow.ShowDialog();

            if (!(addStudentWindow.DialogResult ?? false)) return;

            Students.Add(addStudentWindow.Student);

            DataGridStudents.Items.Refresh();
        }
        private void ButtonDeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem is Student studentToRemove)
            {
                Students.Remove(studentToRemove);
                DataGridStudents.Items.Refresh();
                return;
            }
        }
    }
}