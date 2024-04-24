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
        public Grade grades { get; set; }
        public AddGradeWindow(Grade grade = null)
        {
            InitializeComponent();
            if (grade != null)
            { 
                TextBoxSubject.Text = grade.NameSubject;
                TextBoxWeight.Text = grade.Weight.ToString();
                TextBoxGradae.Text = grade.GradeS.ToString();
            }
            grades = grade ?? new Grade();
        }


        private void AddGrade_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(TextBoxSubject.Text, @"^\p{L}{1,12}") ||
                !Regex.IsMatch(TextBoxWeight.Text, @"^[0-9][1,5]$") ||
                !Regex.IsMatch(TextBoxSubject.Text, @"^[0-9][1-5]$"))
            {
                MessageBox.Show("Invalid input data");
                return;
            }
        }
    }
}
