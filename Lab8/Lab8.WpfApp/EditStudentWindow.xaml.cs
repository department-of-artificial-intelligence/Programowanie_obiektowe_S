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
using Lab8.BLL;

namespace Lab8.WpfApp
{
    public partial class EditStudentWindow : Window
    {
        public Student EditedStudent { get; private set; }  
        public EditStudentWindow(Student studentToEdit)
        {
            InitializeComponent();
            TextBoxFirstname.Text = studentToEdit.Firstname;
            TextBoxSurname.Text = studentToEdit.Surname;
            TextBoxFaculty.Text = studentToEdit.Faculty;
            TextBoxStudentNo.Text = studentToEdit.StudentNo.ToString();
            EditedStudent = studentToEdit;
        }
        private void ButtonEditStudent_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxFirstname.Text) ||
                string.IsNullOrWhiteSpace(TextBoxSurname.Text) ||
                string.IsNullOrWhiteSpace(TextBoxFaculty.Text) ||
                string.IsNullOrWhiteSpace(TextBoxStudentNo.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            EditedStudent.Firstname = TextBoxFirstname.Text;
            EditedStudent.Surname = TextBoxSurname.Text;
            EditedStudent.Faculty = TextBoxFaculty.Text;
            EditedStudent.StudentNo = int.Parse(TextBoxStudentNo.Text);  
            DialogResult = true;
            Close();
        }
    }
}