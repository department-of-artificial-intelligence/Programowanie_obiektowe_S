using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Lab9.WpfApp
{
    public partial class MainWindow : Window
    {
        public IList<Student> Students { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Students = new List<Student>()
            {
                new Student(){imie = "Jan", nazwisko = "Kowalski", wydzial = "WIMII", nrIndeksu = 1010},
                new Student(){imie = "Michał", nazwisko = "Nowak", wydzial = "WIMII", nrIndeksu = 1011},
                new Student(){imie = "Jacek", nazwisko = "Makieta", wydzial = "WIMII", nrIndeksu = 1012}
            };
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "imie", Binding = new Binding("imie") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "nazwisko", Binding = new Binding("nazwisko") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "wydział", Binding = new Binding("wydzial") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "nrIndeksu", Binding = new Binding("nrIndeksu") });
            DataGridStudents.Columns.Add(new DataGridTextColumn() { Header = "oceny", Binding = new Binding("scaloneOceny") });
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;

        }


        private void ButtonAddStudent_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow addStudentWindow = new AddStudentWindow();
            addStudentWindow.ShowDialog();

            if (!(addStudentWindow.DialogResult ?? false)) return;

            Students.Add(addStudentWindow.Student);

            DataGridStudents.Items.Refresh();
        }
        private void ButtonDeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem is Student studentToRemove)
            {
                Students.Remove(studentToRemove);
                DataGridStudents.Items.Refresh();
                return;
            }
        }

        private void BtnCloseStream_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnLoadStudent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnLoadTxtStream_Click(object sender, RoutedEventArgs e)
        {

        }

        /*
        private void BtnSaveTxt_Click(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream("D:\\LocalAccounts\\Student\\Documents\\Szymon_Kupczyk\\Lab9\\Lab8.WpfApp\\data.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            var properties = Students[0].GetType().GetProperties();
            foreach (var student in Students)
            {
                sw.WriteLine("[[Student]]");
                foreach (var property in properties)
                {
                    if (property.Name != "Grades")
                    {
                        sw.WriteLine("[" + property.Name + "]");
                        sw.WriteLine(property.GetValue(Students));
                    }
                }
                sw.WriteLine("[[]]");
            }
            sw.Close();
            MessageBox.Show("Saved");
        }
        */

        private void BtnLoadTxt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSaveXML_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnLoadXML_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSaveJSON_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnLoadJSON_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}