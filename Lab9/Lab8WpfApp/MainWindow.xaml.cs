using Lab8.BLL;
using Lab8.WpfApp;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Xml.Serialization;
using Microsoft.Win32;

namespace Lab8WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IList<Student> Students { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Students = new List<Student>()
            {
                new Student(){FirstName = "Jan", SurName = "Kowalski", Faculty = "WIMII", StudentNo = 1010},
                new Student(){FirstName = "Michał", SurName = "Nowak", Faculty = "WIMII", StudentNo = 1011},
                new Student(){FirstName = "Jacek", SurName = "Makieta", Faculty = "WIMII", StudentNo = 1012},
            };
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "First name", Binding = new Binding(path: "FirstName") });
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Sur name", Binding = new Binding(path: "SurName") });
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Faculty", Binding = new Binding(path: "Faculty") });
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Student No.", Binding = new Binding(path: "StudentNo") });
            DataGridStudents.Columns.Add(item: new DataGridTextColumn() { Header = "Grades", Binding = new Binding(path: "JoinedGrades") });
            DataGridStudents.AutoGenerateColumns = false;
            DataGridStudents.ItemsSource = Students;
        }

        private void ButtonAddStudentWindowShow_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button AddStudent)
            {
                AddStudentWindow addStudentWindow = new AddStudentWindow();
                addStudentWindow.ShowDialog();
                if (addStudentWindow.DialogResult ?? false)
                {
                    Students.Add(addStudentWindow.Student);
                }
                DataGridStudents.Items.Refresh();
            }
        }

        private void ButtonRemoveStudentWindowShow_Click(object sender, RoutedEventArgs e)
        {
            if(DataGridStudents.SelectedItem is Student studentToRemove)
            {
                Students.Remove(studentToRemove);
                DataGridStudents.Items.Refresh();
            }
        }

        private void ButtonSaveToTxtFile_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button SaveTxt)
            {
                FileStream fs = new FileStream("D:\\LocalAccounts\\Student\\Documents\\Lukasz_Zych\\Lab9\\data.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                foreach (var i in Students)
                {
                    sw.WriteLine("[[Student]]");
                    sw.WriteLine("[FirstName]");
                    sw.WriteLine(i.FirstName);
                    sw.WriteLine("[SurName]");
                    sw.WriteLine(i.SurName);
                    sw.WriteLine("[StudentNo]");
                    sw.WriteLine(i.StudentNo);
                    sw.WriteLine("[Faculty]");
                    sw.WriteLine(i.Faculty);
                    sw.WriteLine("[[]]");
                }
                sw.Close();
            }
        }

        private void ButtonSaveToXmlFile_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button SaveTxt)
            {
                FileStream fs = new FileStream("D:\\LocalAccounts\\Student\\Documents\\Lukasz_Zych\\Lab9\\data.xml", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("<Student>");
                foreach (var i in Students)
                {
                    sw.WriteLine("<FirstName>");
                    sw.WriteLine(i.FirstName);
                    sw.WriteLine("</FirstName>");
                    sw.WriteLine("<SurName>");
                    sw.WriteLine(i.SurName);
                    sw.WriteLine("</SurName>");
                    sw.WriteLine("<StudentNo>");
                    sw.WriteLine(i.StudentNo);
                    sw.WriteLine("</StudentNo>");
                    sw.WriteLine("<Faculty>");
                    sw.WriteLine(i.Faculty);
                    sw.WriteLine("</Faculty>");
                }
                sw.WriteLine("</Student>");
                sw.Close();
                //string FileName = "D:\\LocalAccounts\\Student\\Documents\\Lukasz_Zych\\Lab9\\data.xml";
                //using var fileStream = new FileStream(SaveFileDialog., FileMode.OpenOrCreate);
            }
        }

        private void ButtonLoadFromTxtFile_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button SaveTxt)
            {
                FileStream fs = new FileStream("D:\\LocalAccounts\\Student\\Documents\\Lukasz_Zych\\Lab9\\data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string fName = "", lName = "", faculty = "";
                int sNo = 0, cnt = 0;
                Students.Clear();
                while(!sr.EndOfStream)
                {
                    var ln = sr.ReadLine();
                    if (ln[0] != '[')
                    {
                        switch(cnt)
                        {
                            case 0:
                                fName = ln;
                                cnt++;
                                break;
                            case 1:
                                lName = ln;
                                cnt++;
                                break;
                            case 2:
                                sNo = int.Parse(ln);
                                cnt++;
                                break;
                            case 3:
                                faculty = ln;
                                Students.Add(new Student() { FirstName = fName, SurName = lName, Faculty = faculty, StudentNo = sNo });
                                cnt = 0;
                                break;
                        }
                    }
                }
                sr.Close();
                DataGridStudents.Items.Refresh();
            }
        }
    }
}
