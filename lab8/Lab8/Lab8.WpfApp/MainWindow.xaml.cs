using Lab8.BLL;
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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IList<Student> Students { get; set; } // tutaj najedź na student i kliknij w lampkę, powiąż z Lab8.BLL
        public MainWindow()
        {
            InitializeComponent();
            Students = new List<Student>()
            {
                new Student(){ FirstName = "Jan", SurName = "Kowalski", Faculty = "WIMII", StudentNo = 1010},
                new Student(){ FirstName = "Jan", SurName = "Kowalski", Faculty = "WIMII", StudentNo = 1010},
                new Student(){ FirstName = "Jan", SurName = "Kowalski", Faculty = "WIMII", StudentNo = 1010},
            };
            //Krok 6 z instrukcji
        }
    }
}