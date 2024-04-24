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
        public IList<Student> Students { get; set; }
        public StudentMainWindow()
        {

            InitializeComponent();
            Students = new List<Student>
            {
                new Student(){FirstName = "Jan" , LastName = "Kowaki" , Faculity = "WIMII" , id = 135248 },
                new Student(){FirstName = "Michal" , LastName = "Nowak" , Faculity = "WIMII" , id = 135963 },
                new Student(){FirstName = "Adam" , LastName = "Spiner" , Faculity = "WIMII" , id = 135987 }
            };
        }
    }
}
