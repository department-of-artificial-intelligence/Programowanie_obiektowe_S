using Lab8.BLL;
using System.Net.WebSockets;
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
using System.IO;
using System.Globalization;
using System.Xml.Serialization;
using Microsoft.Win32;
using System.Text.Json;

namespace Lab8.WpfApp
{
    public partial class MainWindow : Window
    {
        public List<Student> Students { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Students = new List<Student> { 
                new Student(){ FirstName = "Jan", SurName = "Kowalski", Faculty = "WIMII", StudentNo =  1010},
                new Student(){ FirstName = "Michał", SurName = "Nowak", Faculty = "WIMII", StudentNo =  1011},
                new Student(){ FirstName = "Jacek", SurName = "Makieta", Faculty = "WIMII", StudentNo =  1012},
            };
			Student_Grid.AutoGenerateColumns = false;
            Student_Grid.ItemsSource = Students;
        }

        private void Delete_Student(object sender, RoutedEventArgs e)
        {
            if(Student_Grid.SelectedItem is Student studentToRemove)
            {
                Students.Remove(studentToRemove);
                Student_Grid.Items.Refresh();
            }
        }

        private void Add_Student(object sender, RoutedEventArgs e)
        {
            var student = new Student();
            var addWindow = new AddStudentWindow(student);
            if(addWindow.ShowDialog() == true)
            {
                Students.Add(student);
                Student_Grid.Items.Refresh();
            }
        }

		private void AddGrade_Student(object sender, RoutedEventArgs e)
		{
			var grade = new Grade();
			var addWindow = new AddGradeStudentWindow(grade);
			if (addWindow.ShowDialog() == true)
			{
				if (Student_Grid.SelectedItem is Student selectedStudent)
				{
					selectedStudent.Grades.Add(grade); 
					Student_Grid.Items.Refresh();
				}
			}
		}

		private void SaveToTxt_Click(object sender, RoutedEventArgs e)
		{
			var saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
			saveFileDialog.Title = "Save Text File";

			try
			{
				if (saveFileDialog.ShowDialog() == true)
				{
					using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
					using (StreamWriter sw = new StreamWriter(fs))
					{
						foreach (Student student in Students)
						{
							sw.WriteLine("[[Student]]");
							sw.WriteLine("[[FirstName]]");
							sw.WriteLine(student.FirstName);
							sw.WriteLine("[[LastName]]");
							sw.WriteLine(student.SurName);
							sw.WriteLine("[[StudentNo]]");
							sw.WriteLine(student.StudentNo);
							sw.WriteLine("[[Faculty]]");
							sw.WriteLine(student.Faculty);
							sw.WriteLine("[[Grades]]");
							foreach (Grade grade in student.Grades)
							{
								sw.WriteLine("[[" + grade.Lesson + "]]");
								sw.WriteLine(grade.Date);
								sw.WriteLine(grade.Value);
							}
							sw.WriteLine("[[]]");
						}
					}
					MessageBox.Show("Txt file was successfully saved", "Success");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while saving data to file: " + ex.Message, "Error");
			}
		}

		private async void LoadFromTxt_Click(object sender, RoutedEventArgs e)
		{
			LoadBar.IsIndeterminate = false;
			LoadBar.Minimum = 0;
			LoadBar.Maximum = Students.Count;
			LoadBar.Value = 0;
			var openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
			openFileDialog.Title = "Open Text File";

			try
			{
				if (openFileDialog.ShowDialog() == true)
				{
					using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
					using (StreamReader sr = new StreamReader(fs))
					{
						Student currentStudent = null;

						string line;
						while ((line = sr.ReadLine()) != null)
						{
							if (line.StartsWith("[[Student]]"))
							{
								if (currentStudent != null)
								{
									await Task.Delay(500);
									Students.Add(currentStudent);
									Student_Grid.Items.Refresh();
									LoadBar.Value++;
								}
								currentStudent = new Student();
							}
							else if (line.StartsWith("[[FirstName]]"))
							{
								currentStudent.FirstName = GetNextLine(sr);
							}
							else if (line.StartsWith("[[LastName]]"))
							{
								currentStudent.SurName = GetNextLine(sr);
							}
							else if (line.StartsWith("[[StudentNo]]"))
							{
								int studentNo;
								if (int.TryParse(GetNextLine(sr), out studentNo))
								{
									currentStudent.StudentNo = studentNo;
								}
							}
							else if (line.StartsWith("[[Faculty]]"))
							{
								currentStudent.Faculty = GetNextLine(sr);
							}
							else if (line.StartsWith("[[Grades]]"))
							{
								while ((line = sr.ReadLine()) != "[[]]")
								{
									if (line.StartsWith("[["))
									{
										string lesson = line.Replace("[[", "").Replace("]]", "");
										DateTime date = DateTime.Parse(GetNextLine(sr));
										double value = double.Parse(GetNextLine(sr), CultureInfo.InvariantCulture);
										currentStudent.Grades.Add(new Grade(lesson, date, value));
									}
								}
							}
						}
						if (currentStudent != null)
						{
							Students.Add(currentStudent);
							LoadBar.Value++;
							Student_Grid.Items.Refresh();
						}
					}
					MessageBox.Show("Data was successfully loaded", "Success");
					LoadBar.Value = 0;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while loading data from file: " + ex.Message, "Error");
			}
		}

		private string GetNextLine(StreamReader sr)
		{
			string nextLine = sr.ReadLine();
			while (string.IsNullOrWhiteSpace(nextLine))
			{
				nextLine = sr.ReadLine();
			}
			return nextLine;
		}
		private void SaveToXml_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				var saveFileDialog = new SaveFileDialog();
				saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
				saveFileDialog.Title = "Save XML File";

				if (saveFileDialog.ShowDialog() == true)
				{
					using (var fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create))
					{
						var xmlSerializer = new XmlSerializer(typeof(List<Student>));
						xmlSerializer.Serialize(fileStream, Students);
						MessageBox.Show("Data saved to XML file successfully.");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while saving data to XML file: " + ex.Message, "Error");
			}
		}

		private async void LoadFromXml_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				LoadBar.IsIndeterminate = false;
				LoadBar.Minimum = 0;
				LoadBar.Maximum = Students.Count;
				LoadBar.Value = 0;
				var openFileDialog = new OpenFileDialog();
				openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
				openFileDialog.Title = "Open XML File";

				if (openFileDialog.ShowDialog() == true)
				{
					using (var fileStream = new FileStream(openFileDialog.FileName, FileMode.Open))
					{
						var xmlSerializer = new XmlSerializer(typeof(List<Student>));
						if (xmlSerializer.Deserialize(fileStream) is List<Student> students && students.Count > 0)
						{
							LoadBar.Maximum = students.Count;
							Students.Clear();
							foreach (var student in students)
							{
								await Task.Delay(500);
								Students.Add(student);
								LoadBar.Value++;
								Student_Grid.Items.Refresh();
							}
							MessageBox.Show("Data loaded from XML file successfully.", "Success");
							LoadBar.Value = 0;
						}
						else
						{
							MessageBox.Show("No data found in the XML file.", "Warning");
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while loading data from XML file: " + ex.Message, "Error");
			}
		}


		private void SaveToJson_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
				if (saveFileDialog.ShowDialog() == true)
				{
					string jsonStr = JsonSerializer.Serialize(Students, new JsonSerializerOptions { WriteIndented = true });
					File.WriteAllText(saveFileDialog.FileName, jsonStr);
					MessageBox.Show("Data saved to JSON file successfully.", "Success");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while saving data to JSON file: " + ex.Message, "Error");
			}
		}

		private async void LoadFromJson_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				LoadBar.IsIndeterminate = false;
				LoadBar.Minimum = 0;
				LoadBar.Value = 0;
				var openFileDialog = new OpenFileDialog();
				openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";

				if (openFileDialog.ShowDialog() == true)
				{
					string jsonStr = File.ReadAllText(openFileDialog.FileName);
					List<Student> students = JsonSerializer.Deserialize<List<Student>>(jsonStr);
					LoadBar.Maximum = students.Count;
					Students.Clear();
					foreach (var student in students)
					{
						await Task.Delay(500);
						Students.Add(student);
						LoadBar.Value++;
						Student_Grid.Items.Refresh();
					}

					MessageBox.Show("Data loaded from JSON file successfully.", "Success");
					LoadBar.Value = 0;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while loading data from JSON file: " + ex.Message, "Error");
			}
		}

	}
}