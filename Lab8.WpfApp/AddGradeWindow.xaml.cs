using Lab8.BLL;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for AddGradeWindow.xaml
    /// </summary>
    public partial class AddGradeWindow : Window
    {
        public Grade Grade { get; set; }

        public AddGradeWindow(Grade grade = null)
        {
            InitializeComponent();
            if (grade != null)
            {
                TextBoxSubject.Text = grade.Subject;
                TextBoxValue.Text = grade.Value.ToString();
            }
            Grade = grade ?? new Grade();
        }

        private void ButtonAddGrade_Click(object sender, RoutedEventArgs e)
        {

            Grade.Subject = TextBoxSubject.Text;
            if (!decimal.TryParse(TextBoxValue.Text, out decimal value))
            {
                MessageBox.Show("Value is not a number.");
                DialogResult = false;
            }
            Grade.Value = value;
            DialogResult = true;
        }
    }
}

