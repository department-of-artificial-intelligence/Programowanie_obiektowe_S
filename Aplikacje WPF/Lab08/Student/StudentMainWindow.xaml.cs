using Student.BLL;
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


namespace Student.WpfApp
{
    /// <summary>
    /// Interaction logic for StudentMainWindow.xaml
    /// </summary>
    public partial class StudentMainWindow : Window
    {
        public IList<BLL.Student> Students { get; set; }
        public StudentMainWindow()
        {

            InitializeComponent();
            Students = new List<BLL.Student>
            {
                new BLL.Student(){FirstName = "Jan" , LastName = "Kowaki" , Faculity = "WIMII" , Id = 135248 },
                new BLL.Student(){FirstName = "Michal" , LastName = "Nowak" , Faculity = "WIMII" , Id = 135963 },
                new BLL.Student(){FirstName = "Adam" , LastName = "Spiner" , Faculity = "WIMII" , Id = 135987 }
            };
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
