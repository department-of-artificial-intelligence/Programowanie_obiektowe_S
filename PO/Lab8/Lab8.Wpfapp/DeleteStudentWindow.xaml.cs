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

namespace Lab8.Wpfapp
{
    /// <summary>
    /// Interaction logic for DeleteStudentWindow.xaml
    /// </summary>
    public partial class DeleteStudentWindow : Window
    {
        IList<Student> Students { get; set; }
        public DeleteStudentWindow(IList<Student> Students)
        {
            this.Students = Students;
            InitializeComponent();
        }

        private void btnDeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            var result = ulong.TryParse(idInput.Text, out ulong id);
            if (result)
            {
                if (Students.FirstOrDefault(x => x.StudentNo == id) != null)
                {
                    Students.Remove(Students.First(x => x.StudentNo == id));
                    textOutput.Text = "Student deleted!";
                    idInput.Text = "";
                }
                else 
                {
                    idInput.Text = "";
                    textOutput.Text = "Student not found!";
                }
            }
            else
            {
                textOutput.Text = "Invalid input!";
                idInput.Text = "";
            }
        }

        private void btnBackToMain_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
