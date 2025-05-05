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

namespace Lab8
{
    public partial class Zadanie8 : Window
    {
        public IList<Student> Students { get; set; }

        public Zadanie8()
        {
            InitializeComponent();

            List<Student> Students = new List<Student>
            {
                new Student() { FirstName = "Jan", SurName = "Kowalski", Faculty = "WIMI", StudentNo = 1010 },
                new Student() { FirstName = "Anna", SurName = "Nowak", Faculty = "WEAI", StudentNo = 1011 },
                new Student() { FirstName = "Piotr", SurName = "Wiśniewski", Faculty = "WIMI", StudentNo = 1012 },
                new Student() { FirstName = "Maria", SurName = "Zielińska", Faculty = "WZ", StudentNo = 1013 },
                new Student() { FirstName = "Tomasz", SurName = "Dąbrowski", Faculty = "WEAI", StudentNo = 1014 },
            };

            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "First name", Binding = new Binding("FirstName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Surname", Binding = new Binding("SurName") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Faculty", Binding = new Binding("Faculty") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "Student No", Binding = new Binding("StudentNo") });
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Przykładowa logika: zaznaczony student
            var selectedStudent = (Student)((DataGrid)sender).SelectedItem;

            if (selectedStudent != null)
            {
                // Możesz np. wyświetlić jego dane lub użyć ich gdzieś dalej
                MessageBox.Show($"Wybrano studenta: {selectedStudent.FirstName} {selectedStudent.SurName}");
            }
        }
    }
}
