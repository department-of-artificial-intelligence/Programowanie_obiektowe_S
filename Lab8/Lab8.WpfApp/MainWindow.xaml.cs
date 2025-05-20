using System.Collections.Generic;
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

namespace Lab8.WpfApp {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary> 

    public partial class MainWindow : Window {
        public IList<Student> Students { get; set; }

        public MainWindow() {
            InitializeComponent();
            Students = new List<Student> {
                new Student(){ Name = "Jan", Surname = "Kowalski", Index = 1010, Department = "WIMII" },
                new Student(){ Name = "Michał", Surname = "Nowak", Index = 1011, Department = "WIMII" },
                new Student(){ Name = "Jacek", Surname = "Makieta", Index = 1012, Department = "WIMII" }
            };
            Tabela.Columns.Add(new DataGridTextColumn() { Header = "Name", Binding = new Binding("Name") });
            Tabela.Columns.Add(new DataGridTextColumn() { Header = "Surname", Binding = new Binding("Surname") });
            Tabela.Columns.Add(new DataGridTextColumn() { Header = "Index", Binding = new Binding("Index") });
            Tabela.Columns.Add(new DataGridTextColumn() { Header = "Department", Binding = new Binding("Department") });
            Tabela.AutoGenerateColumns = false;
            Tabela.ItemsSource = Students;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }
    }
}