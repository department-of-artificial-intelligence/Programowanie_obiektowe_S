using System.Diagnostics;
using System;
using System.IO;
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
using Lab09.App.PopUpWindows;
using Lab09.BLL;
using System.Xml.Serialization;
using System.Text.Json;
using Microsoft.Win32;
using System.Security;

namespace Lab09.App
{
    public partial class MainWindow : Window
    {
        protected IList<Student> Students;
        protected string fileTXT = "save.txt";
        protected string fileXML = "save.xml";
        protected string fileJSON = "save.json";
        protected StreamEnumerable<Student> studentStream;
        protected IEnumerator<Student> enumerator;
        public MainWindow()
        {
            InitializeComponent();
            Students = new List<Student>() {
                new Student("Vladyslav","Dzhuha",137000,"Software Engineering")
            };
            Students[0].Grades.Add(new Grade() { Value = 5 });
            dataGrid1.Columns.Add(new DataGridTextColumn() { Header = "First name", Binding = new Binding("Name"), IsReadOnly = true });
            dataGrid1.Columns.Add(new DataGridTextColumn() { Header = "Last name", Binding = new Binding("Surname"), IsReadOnly = true });
            dataGrid1.Columns.Add(new DataGridTextColumn() { Header = "Faculty", Binding = new Binding("Faculty"), IsReadOnly = true });
            dataGrid1.Columns.Add(new DataGridTextColumn() { Header = "Student No.", Binding = new Binding("IndexNumber"), IsReadOnly = true });
            dataGrid1.Columns.Add(new DataGridTextColumn() { Header = "Grades", Binding = new Binding("GetGrades"), IsReadOnly = true });
            dataGrid1.AutoGenerateColumns = false;
            dataGrid1.ItemsSource = Students;
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            AddStudentWindow wind = new AddStudentWindow();
            if (wind.ShowDialog() ?? false)
            {
                Students.Add(wind.Student);
                dataGrid1.Items.Refresh();
            }
        }

        private void Button_Click_Remove(object sender, RoutedEventArgs e)
        {
            if (dataGrid1.SelectedItem is Student student)
            {
                Students.Remove(student);
                dataGrid1.Items.Refresh();
            }
        }

        private void Button_Click_Grade(object sender, RoutedEventArgs e)
        {
            if (dataGrid1.SelectedItem is Student student)
            {
                AddGradeWindow wind = new AddGradeWindow();
                if (wind.ShowDialog() ?? false)
                {
                    student.Grades.Add(new Grade() { Value = wind.Value });
                    dataGrid1.Items.Refresh();
                }
            }
        }
        //LOADING
        private async void Button_Click_LoadTXT(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() ?? false)
            {
                fileTXT = openFileDialog.FileName;
                using (StreamReader reader = new StreamReader(fileTXT))
                {
                    Students.Clear();
                    while (!reader.EndOfStream)
                    {
                        Student? st = await reader.Load<Student>();
                        if (st != null)
                        {
                            Students.Add(st);
                        }
                        else
                        {
                            MessageBox.Show($"The information read from file {fileTXT} is NULL.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                            dataGrid1.Items.Refresh();
                            return;
                        }
                    }
                    dataGrid1.Items.Refresh();
                    MessageBox.Show($"Students were added from file {fileTXT}");
                }
            }
        }

        private void Button_Click_LoadXML(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() ?? false)
            {
                fileXML = openFileDialog.FileName;
                Students.Clear();
                using var fileStream = new FileStream(fileXML, FileMode.OpenOrCreate);
                XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
                try
                {
                    IList<Student>? st = serializer.Deserialize(fileStream) as IList<Student>;
                    if (st != null)
                    {
                        Students = st;
                        dataGrid1.ItemsSource = st;
                        dataGrid1.Items.Refresh();
                        MessageBox.Show($"Students were added from file {fileXML}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void Button_Click_LoadJSON(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() ?? false)
            {
                fileJSON = openFileDialog.FileName;
                Students.Clear();
                try
                {
                    IList<Student>? st = JsonSerializer.Deserialize<List<Student>>(File.ReadAllText(fileJSON));
                    if (st != null)
                    {
                        Students = st;
                        dataGrid1.ItemsSource = st;
                        dataGrid1.Items.Refresh();
                        MessageBox.Show($"Students were added from file {fileJSON}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        //SAVING
        private async void Button_Click_SaveTXT(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() ?? false)
            {
                fileTXT = saveFileDialog.FileName;
                using (StreamWriter writer = new StreamWriter(fileTXT))
                {
                    for (int i = 0; i < Students.Count; i++)
                    {
                        await writer.Save(Students[i]).ContinueWith(t =>
                        {
                            if (i == Students.Count - 1)
                            {
                                MessageBox.Show($"Students were saved to file {fileTXT}");
                                using Process fileopener = new Process();

                                fileopener.StartInfo.FileName = "explorer";
                                fileopener.StartInfo.Arguments = fileTXT;
                                fileopener.Start();
                            }
                        });
                    }
                }
            }
        }

        private void Button_Click_SaveXML(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() ?? false)
            {
                fileXML = saveFileDialog.FileName;
                using var fileStream = new FileStream(fileXML, FileMode.OpenOrCreate);
                XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
                serializer.Serialize(fileStream, Students);
                MessageBox.Show($"Students were saved to file {fileXML}");
            }
        }

        private void Button_Click_SaveJSON(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() ?? false)
            {
                fileJSON = saveFileDialog.FileName;
                string jsonString = JsonSerializer.Serialize(Students, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(fileJSON, jsonString);
                MessageBox.Show($"Students were saved to file {fileJSON}");
            }
        }
        //STREAMS

        private void Button_Click_CloseStream(object sender, RoutedEventArgs e)
        {
            if (studentStream != null)
            {
                if (!studentStream.IsDead)
                {
                    studentStream.Dispose();
                    MessageBox.Show($"Stream was closed. File {fileTXT}");
                    return;
                }
            }
            MessageBox.Show("Stream is neither set nor active.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Button_Click_LoadStudent(object sender, RoutedEventArgs e)
        {
            if (studentStream != null)
            {
                if (!studentStream.IsDead)
                {
                    if (enumerator.MoveNext())
                    {
                        Students.Add(enumerator.Current);
                        dataGrid1.Items.Refresh();
                    }
                    MessageBox.Show("Cant move forward.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
            MessageBox.Show("Stream is neither set nor active.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Button_Click_OpenStream(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() ?? false)
            {
                Students.Clear();
                fileTXT = openFileDialog.FileName;
                studentStream = new StreamEnumerable<Student>(new StreamReader(fileTXT));
                enumerator = studentStream.GetEnumerator();
                if (enumerator.MoveNext())
                {
                    Students.Add(enumerator.Current);
                }
                dataGrid1.Items.Refresh();
            }
        }
    }
}