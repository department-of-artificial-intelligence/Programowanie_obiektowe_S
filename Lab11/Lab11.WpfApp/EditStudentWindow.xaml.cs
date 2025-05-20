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

namespace Lab11.WpfApp
{
    /// <summary>
    /// Interaction logic for EditStudent.xaml
    /// </summary>
    public partial class EditStudentWindow : Window
    {
        public Student EditedStudent { get; private set; }  // Zmieniony student

        public EditStudentWindow(Student studentToEdit)
        {
            InitializeComponent();

            // Przypisanie danych studenta do pól tekstowych
            TextBoxFirstname.Text = studentToEdit.Firstname;
            TextBoxSurname.Text = studentToEdit.Surname;
            TextBoxFaculty.Text = studentToEdit.Faculty;
            TextBoxStudentNo.Text = studentToEdit.StudentNo.ToString();

            // Przypisanie studenta do obiektu EditedStudent
            EditedStudent = studentToEdit;
        }

        private void ButtonEditStudent_Click(object sender, RoutedEventArgs e)
        {
            // Sprawdzamy, czy wszystkie dane są wprowadzone
            if (string.IsNullOrWhiteSpace(TextBoxFirstname.Text) ||
                string.IsNullOrWhiteSpace(TextBoxSurname.Text) ||
                string.IsNullOrWhiteSpace(TextBoxFaculty.Text) ||
                string.IsNullOrWhiteSpace(TextBoxStudentNo.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Zaktualizowanie danych studenta
            EditedStudent.Firstname = TextBoxFirstname.Text;
            EditedStudent.Surname = TextBoxSurname.Text;
            EditedStudent.Faculty = TextBoxFaculty.Text;
            EditedStudent.StudentNo = int.Parse(TextBoxStudentNo.Text);  // Zakładając, że numer albumu jest liczbą

            // Zamykamy okno, sygnalizując, że dane zostały edytowane
            DialogResult = true;
            Close();
        }
    }
}
