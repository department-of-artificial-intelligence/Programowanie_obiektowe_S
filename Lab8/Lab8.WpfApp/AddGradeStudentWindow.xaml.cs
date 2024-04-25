using Lab8.BLL;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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

namespace Lab8.WpfApp
{
	/// <summary>
	/// Логика взаимодействия для AddGradeStudentWindow.xaml
	/// </summary>
	public partial class AddGradeStudentWindow : Window
	{
		public Grade Grade { get; set; }
		public AddGradeStudentWindow(Grade grade = null)
		{
			InitializeComponent();
			if (grade != null)
			{
				Lesson_TextBox.Text = grade.Lesson;
				DatePicker_Grade.SelectedDate = grade.Date;
				Grade_TextBox.Text = grade.Value.ToString();
			}
			Grade = grade ?? new Grade();
		}

		private void AddStudent_Click(object sender, RoutedEventArgs e)
		{
			if (!Regex.IsMatch(Lesson_TextBox.Text, @"^\p{L}{1,12}$") ||
			   !DateTime.TryParse(DatePicker_Grade.Text, out DateTime date) ||
			   !double.TryParse(Grade_TextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double value))
			{
				MessageBox.Show("Invalid input data");
				return;
			}

			Grade.Lesson = Lesson_TextBox.Text;
			Grade.Date = date;
			Grade.Value = value;

			DialogResult = true;
		}

	}
}
