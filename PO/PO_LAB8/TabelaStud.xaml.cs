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
using PO_LAB8.BLL;

namespace PO_LAB8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class TabelaStud : Window
    {
        public IList<Student> Students { get; set; }
        public TabelaStud()
        {
            Students = new List<Student>() { new Student("Heorhii", "Mikula", "WIMII", 228666) };
            InitializeComponent();
            DataGridTable.Columns.Add(item: new DataGridTextColumn() {Header = "FirstName", Binding = new Binding(path: "FirstName") });
            DataGridTable.Columns.Add(item: new DataGridTextColumn() { Header = "LastName", Binding = new Binding(path: "LastName") });
            DataGridTable.Columns.Add(item: new DataGridTextColumn() { Header = "Faculty", Binding = new Binding(path: "Faculty") });
            DataGridTable.Columns.Add(item: new DataGridTextColumn() { Header = "Index", Binding = new Binding(path: "Index") });

            DataGridTable.AutoGenerateColumns = false;
            DataGridTable.ItemsSource = Students;


        }
    }
}