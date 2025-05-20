using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab9.WpfApp
{
    /// <summary>
    /// Interaction logic for AddStudentWindow.xaml
    /// </summary>
    public partial class AddStudentWindow : Window
    {
        public Student Student { get; set; }

        public AddStudentWindow(Student ?student = null)
        {
            InitializeComponent();
            if(student != null)
            {
                TextBoxFaculty.Text = student.wydzial;
                TextBoxFirstName.Text = student.imie;
                TextBoxStudentNo.Text = student.nrIndeksu.ToString();
                TextBoxSurname.Text = student.nazwisko;
            }
            Student = student ?? new Student();
        }
        private void ButtonAddStudent_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(TextBoxFirstName.Text, @"^\p{L}{1,12}$") ||
               !Regex.IsMatch(TextBoxSurname.Text, @"^\p{L}{1,12}$") ||
               !Regex.IsMatch(TextBoxStudentNo.Text, @"^[0-9]{4,10}$") ||
               !Regex.IsMatch(TextBoxFaculty.Text, @"^\p{L}{1,12}$"))
            {
                MessageBox.Show("Invalid input data");
                return;
            }
            Student.imie = TextBoxFirstName.Text;
            Student.nazwisko = TextBoxSurname.Text;
            Student.wydzial = TextBoxFaculty.Text;
            if (!int.TryParse(TextBoxStudentNo.Text, out int nrIndeksu))
                MessageBox.Show("Podamo błędny numer studenta");
            Student.nrIndeksu = nrIndeksu;
            DialogResult = true;
        }
    }
}
