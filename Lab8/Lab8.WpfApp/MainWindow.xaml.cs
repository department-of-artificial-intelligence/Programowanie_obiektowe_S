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

namespace Lab8.WpfApp
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
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "wydział", ClipboardContentBinding = new Binding("wydział") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "nrIndeksu", ClipboardContentBinding = new Binding("nrIndeksu") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "oceny", ClipboardContentBinding = new Binding("scaloneOceny") });
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}